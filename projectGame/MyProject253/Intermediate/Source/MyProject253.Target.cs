using UnrealBuildTool;

public class MyProject253Target : TargetRules
{
	public MyProject253Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyProject253");
	}
}
