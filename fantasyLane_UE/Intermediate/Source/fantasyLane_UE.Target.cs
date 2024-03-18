using UnrealBuildTool;

public class fantasyLane_UETarget : TargetRules
{
	public fantasyLane_UETarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("fantasyLane_UE");
	}
}
