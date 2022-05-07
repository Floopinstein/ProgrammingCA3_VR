using UnrealBuildTool;

public class ProgrammingCA3_VRTarget : TargetRules
{
	public ProgrammingCA3_VRTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProgrammingCA3_VR");
	}
}
