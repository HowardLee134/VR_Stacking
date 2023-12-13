using UnrealBuildTool;

public class MyProject253ServerTarget : TargetRules
{
	public MyProject253ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MyProject253");
	}
}
