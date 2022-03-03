// Copyright(C) Sebastian Krause. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UprojectNameEditorTarget : TargetRules
{
	public UprojectNameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "UprojectName" } );
	}
}
