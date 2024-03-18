using UnrealBuildTool;

public class fantasyLane_UEServerTarget : TargetRules
{
	public fantasyLane_UEServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("fantasyLane_UE");
	}
}
