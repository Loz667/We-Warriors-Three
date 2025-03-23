// Copyright Loren Penny

using UnrealBuildTool;
using System.Collections.Generic;

public class WeWarriorsThreeTarget : TargetRules
{
	public WeWarriorsThreeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "WeWarriorsThree" } );
	}
}
