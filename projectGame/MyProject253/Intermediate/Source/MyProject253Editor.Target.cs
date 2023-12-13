using UnrealBuildTool;

public class MyProject253EditorTarget : TargetRules
{
	public MyProject253EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MyProject253");
	}
}
