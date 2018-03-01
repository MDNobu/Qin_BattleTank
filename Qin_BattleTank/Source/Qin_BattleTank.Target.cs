// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Qin_BattleTankTarget : TargetRules
{
	public Qin_BattleTankTarget(TargetInfo Target)
	{
		Type = TargetType.Game;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "Qin_BattleTank" } );
	}
}
