using UnrealBuildTool;

public class MyProjectEditorTarget : TargetRules
{
	public MyProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MyProject");
	}
}
