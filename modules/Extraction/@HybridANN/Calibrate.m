function [this, TF] = Calibrate(this, Data, Options)
% TF = CalcTuningFunctions( Data, Options)
%
% Calculates tuning functions from Data, where data is the common data
% format returned by the Import*.m scripts. Returns a reference to the
% modified object (because it remembers the tuning functions for further
% analysis) and the tuning functions TF, a struct containing the fields:
% Model - a string representing the model for the tuning function
% Coeff - calibrated model coefficients

    if ~isfield(Options, 'verbose')
        Options.verbose = 1;
    end

    if isfield(Options, 'NoiseModel')
        NoiseModel = Options.NoiseModel;
    else
        NoiseModel = 'normal';
    end

    if( Options.verbose == 1), disp(['Using noise model "' NoiseModel '"']); end

    if( ~isfield(Options, 'Delay'))
        Options.Delay = 0;
    end

    % Select firing rates from specified cells and samples
    if ~strcmp(NoiseModel, 'normal')
        fprintf('\n\nWARNING: NoiseModel parameter does not match expected value. Using "normal" instead\n\n');
        NoiseModel = 'normal';
    end

    if ( isfield(Options, 'type') && strcmp(Options.type, 'rate'))
        FiringRate = Data.FiringRate;
    else
        FiringRate = FilterSpikeCounts(Data, Options.AdaptationFilterCoeffs);
    end
    
    if( isfield(Options, 'CellMask') && ~isempty(Options.CellMask))
        ActiveCellMask = Options.CellMask;
    else
        ActiveCellMask = (sum(FiringRate, 2)>0)';
    end
    ActiveCellIndex = find(ActiveCellMask);
    FR = double(FiringRate(ActiveCellIndex,:));
    
    if( isfield(Options, 'SampleMask') && ~isempty(Options.SampleMask))
        FR = FR(:, Options.SampleMask);
    end

    % Assume model to be a string of the form, e.g. "1+avx+avy+avz" meaning
    % that it has a constant term, and additive terms for actual velocity x,y
    % and z components
    [additive_components, Components, constant] = GetComponents(Options.Model);
    num_comps = length( Components);

    RawQ = GetQuantities( Data, [], additive_components);
    
    % filter the quantities to match the filtering delay of the firing rates
    if ( isfield(Options, 'type') && strcmp(Options.type, 'rate'))
        Q = RawQ;
    else
        Q = filter( Options.TargetFilterCoeffs, 1, RawQ, [], 2);
    end

    if( isfield(Options, 'SampleMask') && ~isempty(Options.SampleMask))
        Q = Q(:, Options.SampleMask);
    end
    
    NormalizeGroups = Options.NormalizeGroups;
    NormalizeGroups(find(NormalizeGroups==0))=[];
    whichGroups = unique(NormalizeGroups(NormalizeGroups ~= 0));
    mags = zeros(size(Q,2), length(whichGroups));

    for i=1:length(whichGroups)
      groupData = Q(find(NormalizeGroups == whichGroups(i)), :);
      mags(:, i) = sqrt(sum(groupData .^ 2))';
    end
    targetNormalizeMags = nanmean(mags);

    for i=1:length(whichGroups)
       Q(find(NormalizeGroups == whichGroups(i)), :) = Q(find(NormalizeGroups == whichGroups(i)), :) ./ targetNormalizeMags(i);
    end
    
    
    % fit speed-offset encoding model
    %magQ = sqrt(sum(Q.^2, 1));  % speed = mag(velocity)
    %Q    = [Q; magQ];           % speed-offset model
    LR  = FitLinearModel(FR', Q', 'on');
    PredictiveCellMask = (LR.R2 >= Options.RSquaredCutoff);
    PredictiveCellIndex = ActiveCellIndex(PredictiveCellMask);
    this.Members.PredictiveCellIndex = PredictiveCellIndex;
    
    % speed profile for simulated trials
    speedProfile = SimulateSpeedProfile(this.SimParam);
    % simulate velocity profile for extra trials
    extraVel = SimulateVel_CenterOut3D(speedProfile, this.SimParam);
    % simulate neural activity for extra trials
    extraNeural = SimulateNeuralData(extraVel, LR.B(PredictiveCellMask, :), ...
                                     Options.AdaptationFilterCoeffs, 1/this.SimParam.Framerate);
    
    
    % train ANN
    Y      = extraNeural.estimatedFR;    % simulated data for training
    validY = FR(PredictiveCellMask, :);  % real data for validation
    annX   = [Y validY];                 % firing rates as inputs
    
    X      = extraVel.Vel;
    validX = Q(1:size(X, 1), :);
    annT   = [X validX];                  % velocities as outputs
    
    trainInd = [1:size(X, 2)];
    validInd = size(X, 2) + [1:size(validX, 2)];
    testInd  = [];
    
    net = TrainANN(annX, annT, this.Members.NumHiddenUnits, trainInd, validInd, testInd);
    

    % Create structured output
    TF = [];
    TF.FullB = LR.B;
    TF.R2    = LR.R2;
    TF.Model = Options.Model;
    TF.Components = Components;
    TF.PredictiveCellsMask = PredictiveCellMask;
    TF.Data.FRateBuffer  = FR;
    TF.Data.TargetBuffer = Q;
    TF.Data.FRateSim     = extraNeural;
    TF.Data.TargetSim    = extraVel;
    TF.net               = net;


 %%========================= Fit linear encoding model =========================
function LR = FitLinearModel(Y, X, constant)
    % Y:    num_sample x num_unit
    % X:    num_sample x num_dim
    % regress firing rate/spike count of each unit against X
    % linear model with Gaussian noise

    if nargin < 3
        constant = 'on';
    end

    % get data dimensions
    [num_sample, dim_y] = size(Y);
    if num_sample ~= size(X, 1)
        error('Data should have the same number of samples.');
    else
        dim_x = size(X, 2);
    end

    % allocate regression results
    switch constant
        case 'off'
            FullB = nan(dim_y, dim_x);
        otherwise
            FullB = nan(dim_y, dim_x + 1);
    end
    R2    = nan(dim_y, 1);
    Sigma = nan(dim_y, dim_y);
    Res   = nan(num_sample, dim_y);
    pVal  = nan(size(FullB));

    % per dim_y linear regression
    for i = 1:dim_y
        y = Y(:, i);

        [b, dev, stats] = glmfit(X, y, 'normal', 'constant', constant);

        FullB(i, :) = b;
        R2(i, 1)    = 1 - dev / nansum((y - nanmean(y)).^2);
        Res(:, i)   = stats.resid;
        pVal(i, :)  = stats.p;
    end

    Sigma = nancov(Res);

    % return fitted linear model
    LR.B      = FullB;
    LR.R2     = R2;
    LR.Sigma  = Sigma;
    LR.dim_y  = dim_y;
    LR.dim_x  = dim_x;
    LR.pValue = pVal;

    
%%========================= Simulate standard speed profile =========================
function [s] = SimulateSpeedProfile(simParam)
    
    if isfield(simParam, 'TargetDist')
        distance = simParam.TargetDist;
    else
        error('SimParam.TargetDist undefined!');
    end
    
    if isfield(simParam, 'MovementTime')
        duration = simParam.MovementTime;
    else
        error('SimParam.MovementTime undefined!');
    end
    
    if isfield(simParam, 'Framerate')
        frame_rate = simParam.Framerate;
    else
        frame_rate = 50;
    end

    if isfield(simParam, 'SpeedProfileSigma')
        norm_sigma = simParam.SpeedProfileSigma;
    else
        norm_sigma = 0.12;
    end

    % calculate number of frames/bins to reach to target distance
    num_bin = round(duration * frame_rate);

    % calculate standard speed profile from a gaussian pdf, with x in [-0.5 0.5]
    x       = [0:1/(num_bin - 1):1] - 0.5;          % ticks: -0.5 ... 0.5
    s_raw   = normpdf(x, 0, norm_sigma);            % raw bell-shaped speed profile
    scaling = distance * frame_rate / sum(s_raw);   % scale speed up or down according to distance and movement time
    s       = scaling * s_raw;                      % standard speed profile


%%========================= Simulate velocity profiles =========================
function Data = SimulateVel_CenterOut3D(speedProfile, simParam)

    % -------------------- define target locations   ----------------------
    tgtDir    = simParam.TargetDirection;  
    tgtDir    = tgtDir ./ repmat(sqrt(sum(tgtDir.^2, 2)), 1, size(tgtDir, 2));
    numTarget = size(tgtDir, 1);
    
    % --------------- define reaching movement trajectory   ---------------
    numBin    = length(speedProfile);
    tgtDist   = sum(speedProfile / simParam.Framerate);

    speedProfileGains = simParam.SpeedGains; % random speed gains based on the standard speed profile
    allSpeedProfiles  = cell(1, length(speedProfileGains));
    for j = 1:length(speedProfileGains)
        gain = speedProfileGains(j);
        numSample = numBin / gain;
        sp = interp1(1:numBin, speedProfile, 1:(numBin-1)/(numSample-1):numBin);
        allSpeedProfiles{1, j} = tgtDist * sp / sum(sp) * simParam.Framerate;
    end

    % ---------------- simulate per target velocity data ------------------
    tgtVelocity = cell(numTarget, length(speedProfileGains));
    for k = 1:numTarget
        for j = 1:length(speedProfileGains)
            tgtVelocity{k, j} = tgtDir(k, :)' * [zeros(1, 10) allSpeedProfiles{1, j} zeros(1, 10)];
        end
    end

    % generate velocity data for training, validation and testing datasets
    Vel         = [];

    for i = 1:simParam.NumSimRep
        for k = 1:numTarget
            speed_ind   = randi(size(tgtVelocity, 2), 1, 1);
            Vel         = [Vel tgtVelocity{k, speed_ind}];
        end
    end

    % --------------------- put data together -----------------------------
    Data.Vel      = Vel;
    Data.Speed    = sqrt(sum(Vel .^ 2, 1));
    Data.SpeedProfile = speedProfile;
    Data.TargetDirection  = tgtDir;
    

%%========================= Simulate neural data =========================
function Data = SimulateNeuralData(VelData, B, filterCoeffs, dt)
    % generate firing rate using the offset model
    X  = [ones(1, size(VelData.Vel, 2)); ...
          VelData.Vel; ...
          VelData.Speed];
    FR = B * X(1:size(B, 2), :);
    FR(FR < 0) = 0;

    SC = poissrnd(FR * dt);     % simulate per time bin spike counts
    estimatedFR = SC / dt;
    filteredFR  = filter(filterCoeffs, 1, estimatedFR, [], 2);

    % return simulated neural data
    Data    = VelData;
    Data.B  = B;
    Data.FR = FR;
    Data.SC = SC;
    Data.estimatedFR = estimatedFR;
    Data.filteredFR  = filteredFR;
    

%%========================= Train ANN =========================
function net = TrainANN(x, t, n, train_ind, valid_ind, test_ind)
    
    trainFcn = 'trainlm';  % Levenberg-Marquardt backpropagation.
    hiddenLayerSize = n;
    net = fitnet(hiddenLayerSize, trainFcn);

        net.input.processFcns = {'removeconstantrows','mapminmax'};
        net.output.processFcns = {'removeconstantrows','mapminmax'};

    %     net.input.processFcns = {'removeconstantrows'};
    %     net.output.processFcns = {'removeconstantrows'};

    net.divideFcn = 'divideind';
    net.divideParam.trainInd = train_ind;
    net.divideParam.valInd   = valid_ind;
    net.divideParam.testInd  = test_ind;

    net.performFcn = 'mse';  % Mean Squared Error

    %     net.plotFcns = {'plotperform','plottrainstate','ploterrhist', ...
    %     'plotregression', 'plotfit'};

    net.trainParam.mu       = 0.001;
    net.trainParam.mu_inc   = 1.1;
    net.trainParam.mu_dec   = 0.9;
    net.trainParam.epochs   = 50;
    net.trainParam.goal     = 1e-5;
    net.trainParam.max_fail = 6;

    % Train the Network
    [net, tr] = train(net, x, t);

    % Test the Network
    % y = net(x);
    % e = gsubtract(t, y);
    % performance = perform(net, t, y);

    % Recalculate Training, Validation and Test Performance
    % trainTargets    = t .* tr.trainMask{1};
    % valTargets      = t .* tr.valMask{1};
    % testTargets     = t .* tr.testMask{1};
    % trainPerformance = perform(net, trainTargets, y);
    % valPerformance  = perform(net, valTargets, y);
    % testPerformance = perform(net, testTargets, y);

