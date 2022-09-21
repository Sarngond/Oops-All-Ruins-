using UnrealBuildTool;

public class Oops_All_RuinsTarget : TargetRules
{
	public Oops_All_RuinsTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Oops_All_Ruins");
	}
}
