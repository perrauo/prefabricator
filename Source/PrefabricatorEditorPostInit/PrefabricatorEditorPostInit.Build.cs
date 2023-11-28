//$ Copyright 2015-23, Code Respawn Technologies Pvt Ltd - All Rights Reserved $//

namespace UnrealBuildTool.Rules
{
	public class PrefabricatorEditorPostInit : ModuleRules
	{
		public PrefabricatorEditorPostInit(ReadOnlyTargetRules Target) : base(Target)
        {
            bUseUnity = false;
            PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
			OptimizeCode = CodeOptimization.Never;
			PublicIncludePaths.AddRange(
				new string[] {
					// ... add public include paths required here ...
                }
				);

			PrivateIncludePaths.AddRange(
				new string[] {
					// ... add other private include paths required here ...
				}
				);

            PrivateIncludePathModuleNames.AddRange(
                new string[] {
                "Settings",
                "AssetTools",
            }
            );

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
                    "Engine",
                    "EditorStyle",
                    "UnrealEd",
                }
				);

			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
                    "InputCore",
                    "Slate",
                    "SlateCore",
				    "RenderCore",
                    "PropertyEditor",
                    "PrefabricatorRuntime",
					// ... add private dependencies that you statically link with here ...
				}
				);

			DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
                }
				);
		}
	}
}
