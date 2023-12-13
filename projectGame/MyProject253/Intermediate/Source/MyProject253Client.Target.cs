using UnrealBuildTool;

public class MyProject253ClientTarget : TargetRules
{
	public MyProject253ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MyProject253");
	}
}
