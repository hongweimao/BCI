function this = SetConfig( this, varargin)

% If a Config struct is provided, then replaces the entire config with
% that. If Value/Property pairs are provided, then adds those to the
% existing config.

% Set the config
nargs = length( varargin);
if( nargs == 1)
    this.Members.Config = varargin{1};
else
    for i = 1 : 2 : nargs
        prop_name = varargin{i};
        prop_value = varargin{i+1};
        this.Members.Config.(prop_name) = prop_value;
    end
end

% Recalculate member variables based on new config
if( isfield( this.Members.Config, 'Gain'))
    gain_idx = this.Members.Config.Gain ~= 0;
    this.Members.Gain = this.Members.Config.Gain(gain_idx);
else
    %this.Members.Gain = 1;
    disp ('Warning: Invalid Gain option, keeping the old value')
end

if( isfield( this.Members.Config, 'TuningFunctions'))
    this.Members.PredictiveCellsMask = this.Members.Config.TuningFunctions.PredictiveCellsMask;
    this.Members.net = this.Members.Config.TuningFunctions.net;
end

