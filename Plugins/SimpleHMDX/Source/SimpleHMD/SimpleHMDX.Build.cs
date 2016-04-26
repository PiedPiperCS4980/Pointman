// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.
using System.IO;
namespace UnrealBuildTool.Rules
{
	public class SimpleHMDX : ModuleRules
	{
		public SimpleHMDX(TargetInfo Target)
		{
			PrivateIncludePaths.AddRange(
				new string[] {
					"SimpleHMDX/Private",
					Path.GetDirectoryName( RulesCompiler.GetModuleFilename("Renderer"))+"/Private",
					// ... add other private include paths required here ...
				}
				);
			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
					"Engine",
					"InputCore",
					"RHI",
					"RenderCore",
					"Renderer",
					"ShaderCore",
					"HeadMountedDisplay"
				}
				);
		}
	}
}
