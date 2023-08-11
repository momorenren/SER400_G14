using UnrealBuildTool;

public class SER400_G14_DIY_PCBTarget : TargetRules
{
	public SER400_G14_DIY_PCBTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SER400_G14_DIY_PCB");
	}
}
