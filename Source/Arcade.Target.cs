using UnrealBuildTool;
using System.Collections.Generic;

public class ArcadeTarget : TargetRules
{
	public ArcadeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Arcade" } );
	}
}
