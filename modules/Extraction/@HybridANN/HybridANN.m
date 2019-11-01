function this = HybridANN( Config)

this.Members  = struct();
this.Members.Config = struct();
this.SimParam = struct();

% Instantiate a HybridANN object
this = class( this, 'HybridANN');

if( exist( 'Config', 'var'))
    this = SetConfig( this, Config);
else
    this = ResetConfig( this);
end
