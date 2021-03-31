using UnrealBuildTool;

public class MajorProjectTarget : TargetRules
{
	public MajorProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MajorProject");
	}
}
