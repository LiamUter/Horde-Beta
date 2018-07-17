

using UnrealBuildTool;
using System.Collections.Generic;

public class CoopGameEditorTarget : TargetRules
{
	public CoopGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "CoopGame" } );
	}
}
