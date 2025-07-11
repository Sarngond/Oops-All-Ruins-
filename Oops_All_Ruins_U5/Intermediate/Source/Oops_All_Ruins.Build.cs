using UnrealBuildTool;

public class Oops_All_Ruins : ModuleRules
{
	public Oops_All_Ruins(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
