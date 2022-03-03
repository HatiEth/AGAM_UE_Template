// Copyright(C) Sebastian Krause. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UprojectNameTarget : TargetRules
{
	public UprojectNameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "UprojectName" } );
	}
}
