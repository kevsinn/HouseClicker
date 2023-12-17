using UnrealBuildTool;

public class MyProjectServerTarget : TargetRules
{
	public MyProjectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MyProject");
	}
}
