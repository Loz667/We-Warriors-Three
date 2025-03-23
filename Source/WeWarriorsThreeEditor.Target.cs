// Copyright Loren Penny

using UnrealBuildTool;
using System.Collections.Generic;

public class WeWarriorsThreeEditorTarget : TargetRules
{
	public WeWarriorsThreeEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "WeWarriorsThree" } );
	}
}
