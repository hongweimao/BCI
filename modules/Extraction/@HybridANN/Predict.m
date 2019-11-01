function [this, ProcessStateEst] = Predict( this, Measurement)

% [hANN, ProcessStateEst] = Predict( hANN, Measurement)
%
% Perform an update/predict step for the hANN Decoder. Measurement
% is the observed data. The output ProcessStateEst represents the estimated
% state of the process. No smoothing is performed on the Measurement. If
% smoothing is desired, it should be done externally prior to passing the
% Measurement to this function.

% Meel Velliste 9/19/2009
% Hongwei Mao 10/31/2019
    
    Gain = this.Members.Gain;
    if ~isempty(Measurement)
        ProcessStateEst = Gain.*this.Members.net(Measurement);
    else
        ProcessStateEst = zeros(this.Members.NumControlDim, size(Measurement, 2));
    end

