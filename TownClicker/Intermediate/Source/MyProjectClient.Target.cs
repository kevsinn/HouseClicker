using UnrealBuildTool;

public class MyProjectClientTarget : TargetRules
{
	public MyProjectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MyProject");
	}
}
