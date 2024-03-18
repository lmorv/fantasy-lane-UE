using UnrealBuildTool;

public class fantasyLane_UEClientTarget : TargetRules
{
	public fantasyLane_UEClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("fantasyLane_UE");
	}
}
