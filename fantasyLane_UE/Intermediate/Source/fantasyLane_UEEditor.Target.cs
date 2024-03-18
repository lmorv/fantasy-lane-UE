using UnrealBuildTool;

public class fantasyLane_UEEditorTarget : TargetRules
{
	public fantasyLane_UEEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("fantasyLane_UE");
	}
}
