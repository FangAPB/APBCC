Public Class DeclareCompatVarialbes
    Public Shared StaticDecalsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "StaticDecals", "(none)")
    Public Shared DynamicDecalsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "DynamicDecals", "(none)")
    Public Shared LevelParticlesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "LevelParticles", "(none)")
    Public Shared DynamicLightsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "DynamicLights", "(none)")
    Public Shared DynamicShadowsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "DynamicShadows", "(none)")
    Public Shared BlobShadowsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "BlobShadows", "(none)")
    Public Shared LightEnvironmentShadowsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "LightEnvironmentShadows", "(none)")
    Public Shared EnvironmentShadowsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "EnvironmentShadows", "(none)")
    Public Shared CompositeDynamicLightsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "CompositeDynamicLights", "(none)")
    Public Shared DirectionalLightmapsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "DirectionalLightmaps", "(none)")
    Public Shared MotionBlurValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MotionBlur", "(none)")
    Public Shared DepthOfFieldValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "DepthOfField", "(none)")
    Public Shared AmbientOcclusionValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "AmbientOcclusion", "(none)")
    Public Shared BloomValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "Bloom", "(none)")
    Public Shared QualityBloomValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "QualityBloom", "(none)")
    Public Shared DistortionValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "Distortion", "(none)")
    Public Shared DropParticleDistortionValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "DropParticleDistortion", "(none)")
    Public Shared SpeedTreeLeavesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "SpeedTreeLeaves", "(none)")
    Public Shared SpeedTreeFrondsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "SpeedTreeFronds", "(none)")
    Public Shared OnlyStreamInTexturesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "OnlyStreamInTextures", "(none)")
    Public Shared LensFlaresValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "LensFlares", "(none)")
    Public Shared FogVolumesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "FogVolumes", "(none)")
    Public Shared FloatingPointRenderTargetsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "FloatingPointRenderTargets", "(none)")
    Public Shared TrilinearValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "Trilinear", "(none)")
    Public Shared OneFrameThreadLagValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "OneFrameThreadLag", "(none)")
    Public Shared UseVsyncValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "UseVsync", "(none)")
    Public Shared UpscaleScreenPercentageValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "UpscaleScreenPercentage", "(none)")
    Public Shared FullscreenValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "Fullscreen", "(none)")
    Public Shared AllowD3D10Value As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "AllowD3D10", "(none)")
    Public Shared EnableHighPolyCharsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "EnableHighPolyChars", "(none)")
    Public Shared SkeletalMeshLODBiasValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "SkeletalMeshLODBias", "(none)")
    Public Shared ParticleLODBiasValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ParticleLODBias", "(none)")
    Public Shared DetailModeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "DetailMode", "(none)")
    Public Shared ShadowFilterQualityBiasValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFilterQualityBias", "(none)")
    Public Shared MaxAnisotropyValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxAnisotropy", "(none)")
    Public Shared AnisotropyAmountValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "AnisotropyAmount", "(none)")
    Public Shared MaxMultisamplesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMultisamples", "(none)")
    Public Shared MSAA_AmountValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MSAA_Amount", "(none)")
    Public Shared MinShadowResolutionValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MinShadowResolution", "(none)")
    Public Shared MaxShadowResolutionValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxShadowResolution", "(none)")
    Public Shared ShadowFadeResolutionValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFadeResolution", "(none)")
    Public Shared ShadowFadeExponentValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFadeExponent", "(none)")
    Public Shared ShadowFadeStartDistanceValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFadeStartDistance", "(none)")
    Public Shared ShadowFadeEndDistanceValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFadeEndDistance", "(none)")
    Public Shared MaxDynamicShadowsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxDynamicShadows", "(none)")
    Public Shared SunRenderQualityValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "SunRenderQuality", "(none)")
    Public Shared TrueSunMinScreenSizeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TrueSunMinScreenSize", "(none)")
    Public Shared ParticleMaxWorldSpaceAreaValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ParticleMaxWorldSpaceArea", "(none)")
    Public Shared ScreenPercentageValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ScreenPercentage", "(none)")
    Public Shared SceneCaptureStreamingMultiplierValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "SceneCaptureStreamingMultiplier", "(none)")
    Public Shared FoliageDrawRadiusMultiplierValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "FoliageDrawRadiusMultiplier", "(none)")
    Public Shared ShadowTexelsPerPixelValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowTexelsPerPixel", "(none)")
    Public Shared bEnableVSMShadowsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bEnableVSMShadows", "(none)")
    Public Shared bEnableBranchingPCFShadowsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bEnableBranchingPCFShadows", "(none)")
    Public Shared bAllowBetterModulatedShadowsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bAllowBetterModulatedShadows", "(none)")
    Public Shared bEnableForegroundShadowsOnWorldValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bEnableForegroundShadowsOnWorld", "(none)")
    Public Shared ShadowFilterRadiusValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFilterRadius", "(none)")
    Public Shared ShadowDepthBiasValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowDepthBias", "(none)")
    Public Shared ShadowVolumeLightRadiusThresholdValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowVolumeLightRadiusThreshold", "(none)")
    Public Shared ShadowVolumePrimitiveScreenSpacePercentageThresholdValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowVolumePrimitiveScreenSpacePercentageThreshold", "(none)")
    Public Shared nNumCharacterLODValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nNumCharacterLOD", "(none)")
    Public Shared nCharacterDiffuseWidthValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterDiffuseWidth", "(none)")
    Public Shared nCharacterDiffuseHeightValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterDiffuseHeight", "(none)")
    Public Shared nCharacterNormalMapWidthValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterNormalMapWidth", "(none)")
    Public Shared nCharacterNormalMapHeightValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterNormalMapHeight", "(none)")
    Public Shared bCharacterGenerateUVBleedMeshValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCharacterGenerateUVBleedMesh", "(none)")
    Public Shared m_bGameRenderEyelashesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "m_bGameRenderEyelashes", "(none)")
    Public Shared fCharacterLODDistance1Value As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCharacterLODDistance1", "(none)")
    Public Shared fCharacterLODDistance2Value As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCharacterLODDistance2", "(none)")
    Public Shared fCharacterCullDistanceValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCharacterCullDistance", "(none)")
    Public Shared bCharacterForceGCAfterBuildValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCharacterForceGCAfterBuild", "(none)")
    Public Shared nNumVehicleLODValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nNumVehicleLOD", "(none)")
    Public Shared nVehicleExteriorTextureSizeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleExteriorTextureSize", "(none)")
    Public Shared nVehicleExteriorNormalTextureSizeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleExteriorNormalTextureSize", "(none)")
    Public Shared nVehicleExteriorEmissiveTextureSizeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleExteriorEmissiveTextureSize", "(none)")
    Public Shared nVehicleInteriorTextureSizeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleInteriorTextureSize", "(none)")
    Public Shared nVehicleInteriorEmissiveTextureSizeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleInteriorEmissiveTextureSize", "(none)")
    Public Shared nVehicleWheelTextureSizeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleWheelTextureSize", "(none)")
    Public Shared nVehicleWheelEmissiveTextureSizeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleWheelEmissiveTextureSize", "(none)")
    Public Shared nVehicleGlassTextureSizeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleGlassTextureSize", "(none)")
    Public Shared bVehicleGenerateUVBleedMeshValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bVehicleGenerateUVBleedMesh", "(none)")
    Public Shared bVehicleForceGCAfterBuildValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bVehicleForceGCAfterBuild", "(none)")
    Public Shared fVehicleLODDistanceValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fVehicleLODDistance", "(none)")
    Public Shared fVehicleCullDistanceValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fVehicleCullDistance", "(none)")
    Public Shared nGraffitiTextureWidthValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nGraffitiTextureWidth", "(none)")
    Public Shared nGraffitiTextureHeightValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nGraffitiTextureHeight", "(none)")
    Public Shared fCAM_MemoryThresholdNormalValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCAM_MemoryThresholdNormal", "(none)")
    Public Shared fCAM_MemoryThresholdCriticalValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCAM_MemoryThresholdCritical", "(none)")
    Public Shared fCAM_MemoryBackToNormalHysteresisValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCAM_MemoryBackToNormalHysteresis", "(none)")
    Public Shared fLCPedestrianLODDistanceValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCPedestrianLODDistance", "(none)")
    Public Shared fLCPedestrianCullDistanceValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCPedestrianCullDistance", "(none)")
    Public Shared fLCDriverLODDistanceValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCDriverLODDistance", "(none)")
    Public Shared fLCDriverCullDistanceValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCDriverCullDistance", "(none)")
    Public Shared fLCVehicleLODDistanceValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCVehicleLODDistance", "(none)")
    Public Shared fLCVehicleCullDistanceValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCVehicleCullDistance", "(none)")
    Public Shared nMaxMemoryCacheEntryCountValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "nMaxMemoryCacheEntryCount", "(none)")
    Public Shared MaxLCHairResolutionValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxLCHairResolution", "(none)")
    Public Shared MaxLCVehicleTextureSizeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxLCVehicleTextureSize", "(none)")
    Public Shared SpawnMapDelayTimeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "SpawnMapDelayTime", "(none)")
    Public Shared LowQualityHealthHUDValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "LowQualityHealthHUD", "(none)")
    Public Shared bUseSimplifiedVehicleMaterialsValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bUseSimplifiedVehicleMaterials", "(none)")
    Public Shared SmoothFrameRateValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "SmoothFrameRate", "(none)")
    Public Shared TEXCAT_UnknownMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Unknown", "(none)").Split(","c)(1).ToString '.Split(" "c, ","c)
    Public Shared TEXCAT_UnknownMinLODSizeValue As String = TEXCAT_UnknownMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_UnknownMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Unknown", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_UnknownMaxLODSizeValue As String = TEXCAT_UnknownMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_UnknownLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Unknown", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_UnknownLODBiasValue As String = TEXCAT_UnknownLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_UnknownDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Unknown", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_UnknownDisableStreamingValue As String = TEXCAT_UnknownDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_UnknownFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Unknown", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_UnknownFairUsagePriorityValue As String = TEXCAT_UnknownFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_EnvironmentMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_EnvironmentMinLODSizeValue As String = TEXCAT_EnvironmentMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_EnvironmentMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_EnvironmentMaxLODSizeValue As String = TEXCAT_EnvironmentMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_EnvironmentLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_EnvironmentLODBiasValue As String = TEXCAT_EnvironmentLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_EnvironmentDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_EnvironmentDisableStreamingValue As String = TEXCAT_EnvironmentDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_EnvironmentFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_EnvironmentFairUsagePriorityValue As String = TEXCAT_EnvironmentFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_PropMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_PropMinLODSizeValue As String = TEXCAT_PropMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_PropMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_PropMaxLODSizeValue As String = TEXCAT_PropMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_PropLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_PropLODBiasValue As String = TEXCAT_PropLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_PropDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_PropDisableStreamingValue As String = TEXCAT_PropDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_PropFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_PropFairUsagePriorityValue As String = TEXCAT_PropFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_PlayerCharacterMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_PlayerCharacterMinLODSizeValue As String = TEXCAT_PlayerCharacterMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_PlayerCharacterMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_PlayerCharacterMaxLODSizeValue As String = TEXCAT_PlayerCharacterMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_PlayerCharacterLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_PlayerCharacterLODBiasValue As String = TEXCAT_PlayerCharacterLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_PlayerCharacterDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_PlayerCharacterDisableStreamingValue As String = TEXCAT_PlayerCharacterDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_PlayerCharacterFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_PlayerCharacterFairUsagePriorityValue As String = TEXCAT_PlayerCharacterFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_PlayerVehicleMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_PlayerVehicleMinLODSizeValue As String = TEXCAT_PlayerVehicleMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_PlayerVehicleMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_PlayerVehicleMaxLODSizeValue As String = TEXCAT_PlayerVehicleMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_PlayerVehicleLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_PlayerVehicleLODBiasValue As String = TEXCAT_PlayerVehicleLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_PlayerVehicleDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_PlayerVehicleDisableStreamingValue As String = TEXCAT_PlayerVehicleDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_PlayerVehicleFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_PlayerVehicleFairUsagePriorityValue As String = TEXCAT_PlayerVehicleFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_LCPedestrianMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_LCPedestrianMinLODSizeValue As String = TEXCAT_LCPedestrianMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_LCPedestrianMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_LCPedestrianMaxLODSizeValue As String = TEXCAT_LCPedestrianMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_LCPedestrianLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_LCPedestrianLODBiasValue As String = TEXCAT_LCPedestrianLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_LCPedestrianDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_LCPedestrianDisableStreamingValue As String = TEXCAT_LCPedestrianDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_LCPedestrianFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_LCPedestrianFairUsagePriorityValue As String = TEXCAT_LCPedestrianFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_LCVehicleMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_LCVehicleMinLODSizeValue As String = TEXCAT_LCVehicleMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_LCVehicleMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_LCVehicleMaxLODSizeValue As String = TEXCAT_LCVehicleMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_LCVehicleLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_LCVehicleLODBiasValue As String = TEXCAT_LCVehicleLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_LCVehicleDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_LCVehicleDisableStreamingValue As String = TEXCAT_LCVehicleDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_LCVehicleFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_LCVehicleFairUsagePriorityValue As String = TEXCAT_LCVehicleFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_PickupMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Pickup", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_PickupMinLODSizeValue As String = TEXCAT_PickupMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_PickupMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Pickup", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_PickupMaxLODSizeValue As String = TEXCAT_PickupMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_PickupLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Pickup", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_PickupLODBiasValue As String = TEXCAT_PickupLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_PickupDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Pickup", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_PickupDisableStreamingValue As String = TEXCAT_PickupDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_PickupFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Pickup", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_PickupFairUsagePriorityValue As String = TEXCAT_PickupFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_CharacterSourceMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterSource", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_CharacterSourceMinLODSizeValue As String = TEXCAT_CharacterSourceMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_CharacterSourceMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterSource", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_CharacterSourceMaxLODSizeValue As String = TEXCAT_CharacterSourceMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_CharacterSourceLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterSource", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_CharacterSourceLODBiasValue As String = TEXCAT_CharacterSourceLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_CharacterSourceDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterSource", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_CharacterSourceDisableStreamingValue As String = TEXCAT_CharacterSourceDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_CharacterSourceFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterSource", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_CharacterSourceFairUsagePriorityValue As String = TEXCAT_CharacterSourceFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_VehicleSourceMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleSource", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_VehicleSourceMinLODSizeValue As String = TEXCAT_VehicleSourceMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_VehicleSourceMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleSource", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_VehicleSourceMaxLODSizeValue As String = TEXCAT_VehicleSourceMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_VehicleSourceLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleSource", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_VehicleSourceLODBiasValue As String = TEXCAT_VehicleSourceLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_VehicleSourceDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleSource", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_VehicleSourceDisableStreamingValue As String = TEXCAT_VehicleSourceDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_VehicleSourceFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleSource", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_VehicleSourceFairUsagePriorityValue As String = TEXCAT_VehicleSourceFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_PrimitiveSourceMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_PrimitiveSourceMinLODSizeValue As String = TEXCAT_PrimitiveSourceMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_PrimitiveSourceMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_PrimitiveSourceMaxLODSizeValue As String = TEXCAT_PrimitiveSourceMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_PrimitiveSourceLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_PrimitiveSourceLODBiasValue As String = TEXCAT_PrimitiveSourceLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_PrimitiveSourceDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_PrimitiveSourceDisableStreamingValue As String = TEXCAT_PrimitiveSourceDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_PrimitiveSourceFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_PrimitiveSourceFairUsagePriorityValue As String = TEXCAT_PrimitiveSourceFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_UIMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_UI", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_UIMinLODSizeValue As String = TEXCAT_UIMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_UIMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_UI", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_UIMaxLODSizeValue As String = TEXCAT_UIMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_UILODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_UI", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_UILODBiasValue As String = TEXCAT_UILODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_UIDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_UI", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_UIDisableStreamingValue As String = TEXCAT_UIDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_UIFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_UI", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_UIFairUsagePriorityValue As String = TEXCAT_UIFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_VFXMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VFX", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_VFXMinLODSizeValue As String = TEXCAT_VFXMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_VFXMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VFX", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_VFXMaxLODSizeValue As String = TEXCAT_VFXMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_VFXLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VFX", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_VFXLODBiasValue As String = TEXCAT_VFXLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_VFXDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VFX", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_VFXDisableStreamingValue As String = TEXCAT_VFXDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_VFXFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VFX", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_VFXFairUsagePriorityValue As String = TEXCAT_VFXFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_LightAndShadowMapMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_LightAndShadowMapMinLODSizeValue As String = TEXCAT_LightAndShadowMapMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_LightAndShadowMapMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_LightAndShadowMapMaxLODSizeValue As String = TEXCAT_LightAndShadowMapMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_LightAndShadowMapLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_LightAndShadowMapLODBiasValue As String = TEXCAT_LightAndShadowMapLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_LightAndShadowMapDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_LightAndShadowMapDisableStreamingValue As String = TEXCAT_LightAndShadowMapDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_LightAndShadowMapFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_LightAndShadowMapFairUsagePriorityValue As String = TEXCAT_LightAndShadowMapFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_RenderTargetMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_RenderTarget", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_RenderTargetMinLODSizeValue As String = TEXCAT_RenderTargetMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_RenderTargetMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_RenderTarget", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_RenderTargetMaxLODSizeValue As String = TEXCAT_RenderTargetMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_RenderTargetLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_RenderTarget", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_RenderTargetLODBiasValue As String = TEXCAT_RenderTargetLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_RenderTargetDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_RenderTarget", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_RenderTargetDisableStreamingValue As String = TEXCAT_RenderTargetDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_RenderTargetFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_RenderTarget", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_RenderTargetFairUsagePriorityValue As String = TEXCAT_RenderTargetFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_SignageMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Signage", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_SignageMinLODSizeValue As String = TEXCAT_SignageMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_SignageMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Signage", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_SignageMaxLODSizeValue As String = TEXCAT_SignageMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_SignageLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Signage", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_SignageLODBiasValue As String = TEXCAT_SignageLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_SignageDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Signage", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_SignageDisableStreamingValue As String = TEXCAT_SignageDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_SignageFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Signage", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_SignageFairUsagePriorityValue As String = TEXCAT_SignageFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_PlayerGraffitiMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_PlayerGraffitiMinLODSizeValue As String = TEXCAT_PlayerGraffitiMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_PlayerGraffitiMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_PlayerGraffitiMaxLODSizeValue As String = TEXCAT_PlayerGraffitiMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_PlayerGraffitiLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_PlayerGraffitiLODBiasValue As String = TEXCAT_PlayerGraffitiLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_PlayerGraffitiDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_PlayerGraffitiDisableStreamingValue As String = TEXCAT_PlayerGraffitiDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_PlayerGraffitiFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_PlayerGraffitiFairUsagePriorityValue As String = TEXCAT_PlayerGraffitiFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_PlayerStatueMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerStatue", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_PlayerStatueMinLODSizeValue As String = TEXCAT_PlayerStatueMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_PlayerStatueMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerStatue", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_PlayerStatueMaxLODSizeValue As String = TEXCAT_PlayerStatueMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_PlayerStatueLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerStatue", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_PlayerStatueLODBiasValue As String = TEXCAT_PlayerStatueLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_PlayerStatueDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerStatue", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_PlayerStatueDisableStreamingValue As String = TEXCAT_PlayerStatueDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_PlayerStatueFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerStatue", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_PlayerStatueFairUsagePriorityValue As String = TEXCAT_PlayerStatueFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_CharacterSharedMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_CharacterSharedMinLODSizeValue As String = TEXCAT_CharacterSharedMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_CharacterSharedMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_CharacterSharedMaxLODSizeValue As String = TEXCAT_CharacterSharedMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_CharacterSharedLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_CharacterSharedLODBiasValue As String = TEXCAT_CharacterSharedLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_CharacterSharedDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_CharacterSharedDisableStreamingValue As String = TEXCAT_CharacterSharedDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_CharacterSharedFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_CharacterSharedFairUsagePriorityValue As String = TEXCAT_CharacterSharedFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_VehicleSharedMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_VehicleSharedMinLODSizeValue As String = TEXCAT_VehicleSharedMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_VehicleSharedMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_VehicleSharedMaxLODSizeValue As String = TEXCAT_VehicleSharedMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_VehicleSharedLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_VehicleSharedLODBiasValue As String = TEXCAT_VehicleSharedLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_VehicleSharedDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_VehicleSharedDisableStreamingValue As String = TEXCAT_VehicleSharedDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_VehicleSharedFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_VehicleSharedFairUsagePriorityValue As String = TEXCAT_VehicleSharedFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_NonFinalMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_NonFinal", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_NonFinalMinLODSizeValue As String = TEXCAT_NonFinalMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_NonFinalMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_NonFinal", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_NonFinalMaxLODSizeValue As String = TEXCAT_NonFinalMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_NonFinalLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_NonFinal", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_NonFinalLODBiasValue As String = TEXCAT_NonFinalLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_NonFinalDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_NonFinal", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_NonFinalDisableStreamingValue As String = TEXCAT_NonFinalDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_NonFinalFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_NonFinal", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_NonFinalFairUsagePriorityValue As String = TEXCAT_NonFinalFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared TEXCAT_ContactMinLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(1).ToString
    Public Shared TEXCAT_ContactMinLODSizeValue As String = TEXCAT_ContactMinLODSizeValueRaw.Replace("MinLODSize=", "")
    Public Shared TEXCAT_ContactMaxLODSizeValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(2).ToString
    Public Shared TEXCAT_ContactMaxLODSizeValue As String = TEXCAT_ContactMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
    Public Shared TEXCAT_ContactLODBiasValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(3).ToString
    Public Shared TEXCAT_ContactLODBiasValue As String = TEXCAT_ContactLODBiasValueRaw.Replace("LODBias=", "")
    Public Shared TEXCAT_ContactDisableStreamingValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(4).ToString
    Public Shared TEXCAT_ContactDisableStreamingValue As String = TEXCAT_ContactDisableStreamingValueRaw.Replace("DisableStreaming=", "")
    Public Shared TEXCAT_ContactFairUsagePriorityValueRaw As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(5).ToString
    Public Shared TEXCAT_ContactFairUsagePriorityValue As String = TEXCAT_ContactFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
    Public Shared fMipBiasDiffuseLocalPlayerCharacterTexturesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "fMipBiasDiffuseLocalPlayerCharacterTextures", "(none)")
    Public Shared bCompressDiffuseLocalPlayerCharacterTexturesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseLocalPlayerCharacterTextures", "(none)")
    Public Shared bCompressDiffuseLocalPlayerVehicleTexturesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseLocalPlayerVehicleTextures", "(none)")
    Public Shared bCompressDiffuseOtherPlayerCharacterTexturesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseOtherPlayerCharacterTextures", "(none)")
    Public Shared bCompressDiffuseOtherPlayerVehicleTexturesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseOtherPlayerVehicleTextures", "(none)")
    Public Shared bCompressNormalTexturesValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressNormalTextures", "(none)")
    Public Shared AudioCompatModeValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "AudioCompatMode", "(none)")
    Public Shared MaxMemoryUsedByTextureStreamingValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByTextureStreaming", "(none)")
    Public Shared MaxMemoryUsedByTexturePoolValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByTexturePool", "(none)")
    Public Shared MaxMemoryUsedByMeshStreamingValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByMeshStreaming", "(none)")
    Public Shared NumberOfTextureCreationPerFrameValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "NumberOfTextureCreationPerFrame", "(none)")
    Public Shared MaxFreeMemoryUsedByVBPoolValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxFreeMemoryUsedByVBPool", "(none)")
    Public Shared MaxFreeMemoryUsedByIBPoolValue As String = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxFreeMemoryUsedByIBPool", "(none)")
    '---APBEngine.ini---
    Public Shared MinSmoothedFrameRateValue As String = Form1.APBEngine.GetString("Engine.GameEngine", "MinSmoothedFrameRate", "(none)")
    Public Shared MaxSmoothedFrameRateValue As String = Form1.APBEngine.GetString("Engine.GameEngine", "MaxSmoothedFrameRate", "(none)")
    Public Shared MinDesiredFrameRateValue As String = Form1.APBEngine.GetString("Engine.Client", "MinDesiredFrameRate", "(none)")
    '!-!'!-!'Experimental'!-!'!-!'
    Public Shared MaxDynamicChunkCountValue As String = Form1.APBEngine.GetString("Engine.PhysicsLODVerticalDestructible", "MaxDynamicChunkCount", "(none)")
    Public Shared DebrisLifetimeValue As String = Form1.APBEngine.GetString("Engine.PhysicsLODVerticalDestructible", "DebrisLifetime", "(none)")
    Public Shared ParticlePercentageValue As String = Form1.APBEngine.GetString("Engine.PhysicsLODVerticalEmitter", "ParticlePercentage", "(none)")
    '!-!'!-!'END Experimental'!-!'!-!'
    Public Shared ControlConstraintsBucket1and2 As New List(Of Control) From {
    Form1.LabelnCharacterDiffuseWidth,
Form1.LabelnCharacterDiffuseWidthCurrent1,
Form1.LabelnCharacterDiffuseWidthCurrent2,
Form1.TextBoxnCharacterDiffuseWidth,
Form1.LabelnCharacterDiffuseHeight,
Form1.LabelnCharacterDiffuseHeightCurrent1,
Form1.LabelnCharacterDiffuseHeightCurrent2,
Form1.TextBoxnCharacterDiffuseHeight,
Form1.LabelnCharacterNormalMapWidth,
Form1.LabelnCharacterNormalMapWidthCurrent1,
Form1.LabelnCharacterNormalMapWidthCurrent2,
Form1.TextBoxnCharacterNormalMapWidth,
Form1.LabelnCharacterNormalMapHeight,
Form1.LabelnCharacterNormalMapHeightCurrent1,
Form1.LabelnCharacterNormalMapHeightCurrent2,
Form1.TextBoxnCharacterNormalMapHeight,
Form1.LabelnVehicleExteriorTextureSize,
Form1.LabelnVehicleExteriorTextureSizeCurrent1,
Form1.LabelnVehicleExteriorTextureSizeCurrent2,
Form1.TextBoxnVehicleExteriorTextureSize,
Form1.LabelnVehicleExteriorNormalTextureSize,
Form1.LabelnVehicleExteriorNormalTextureSizeCurrent1,
Form1.LabelnVehicleExteriorNormalTextureSizeCurrent2,
Form1.TextBoxnVehicleExteriorNormalTextureSize,
Form1.LabelnVehicleExteriorEmissiveTextureSize,
Form1.LabelnVehicleExteriorEmissiveTextureSizeCurrent1,
Form1.LabelnVehicleExteriorEmissiveTextureSizeCurrent2,
Form1.TextBoxnVehicleExteriorEmissiveTextureSize,
Form1.LabelnVehicleInteriorTextureSize,
Form1.LabelnVehicleInteriorTextureSizeCurrent1,
Form1.LabelnVehicleInteriorTextureSizeCurrent2,
Form1.TextBoxnVehicleInteriorTextureSize,
Form1.LabelnVehicleInteriorEmissiveTextureSize,
Form1.LabelnVehicleInteriorEmissiveTextureSizeCurrent1,
Form1.LabelnVehicleInteriorEmissiveTextureSizeCurrent2,
Form1.TextBoxnVehicleInteriorEmissiveTextureSize,
Form1.LabelnVehicleWheelTextureSize,
Form1.LabelnVehicleWheelTextureSizeCurrent1,
Form1.LabelnVehicleWheelTextureSizeCurrent2,
Form1.TextBoxnVehicleWheelTextureSize,
Form1.LabelnVehicleWheelEmissiveTextureSize,
Form1.LabelnVehicleWheelEmissiveTextureSizeCurrent1,
Form1.LabelnVehicleWheelEmissiveTextureSizeCurrent2,
Form1.TextBoxnVehicleWheelEmissiveTextureSize,
Form1.LabelnVehicleGlassTextureSize,
Form1.LabelnVehicleGlassTextureSizeCurrent1,
Form1.LabelnVehicleGlassTextureSizeCurrent2,
Form1.TextBoxnVehicleGlassTextureSize,
Form1.LabelfMipBiasDiffuseLocalPlayerCharacterTextures,
Form1.LabelfMipBiasDiffuseLocalPlayerCharacterTexturesCurrent1,
Form1.LabelfMipBiasDiffuseLocalPlayerCharacterTexturesCurrent2,
Form1.TextBoxfMipBiasDiffuseLocalPlayerCharacterTextures,
Form1.LabelnMaxMemoryCacheEntryCount,
Form1.LabelnMaxMemoryCacheEntryCountCurrent1,
Form1.LabelnMaxMemoryCacheEntryCountCurrent2,
Form1.TextBoxnMaxMemoryCacheEntryCount,
Form1.LabelAudioCompatMode,
Form1.LabelAudioCompatModeCurrent1,
Form1.LabelAudioCompatModeCurrent2,
Form1.TextBoxAudioCompatMode,
Form1.LabelMaxMemoryUsedByTextureStreaming,
Form1.LabelMaxMemoryUsedByTextureStreamingCurrent1,
Form1.LabelMaxMemoryUsedByTextureStreamingCurrent2,
Form1.TextBoxMaxMemoryUsedByTextureStreaming,
Form1.LabelMaxMemoryUsedByTexturePool,
Form1.LabelMaxMemoryUsedByTexturePoolCurrent1,
Form1.LabelMaxMemoryUsedByTexturePoolCurrent2,
Form1.TextBoxMaxMemoryUsedByTexturePool,
Form1.LabelMaxMemoryUsedByMeshStreaming,
Form1.LabelMaxMemoryUsedByMeshStreamingCurrent1,
Form1.LabelMaxMemoryUsedByMeshStreamingCurrent2,
Form1.TextBoxMaxMemoryUsedByMeshStreaming,
Form1.LabelNumberOfTextureCreationPerFrame,
Form1.LabelNumberOfTextureCreationPerFrameCurrent1,
Form1.LabelNumberOfTextureCreationPerFrameCurrent2,
Form1.TextBoxNumberOfTextureCreationPerFrame,
Form1.LabelMaxFreeMemoryUsedByVBPool,
Form1.LabelMaxFreeMemoryUsedByVBPoolCurrent1,
Form1.LabelMaxFreeMemoryUsedByVBPoolCurrent2,
Form1.TextBoxMaxFreeMemoryUsedByVBPool,
Form1.LabelMaxFreeMemoryUsedByIBPool,
Form1.LabelMaxFreeMemoryUsedByIBPoolCurrent1,
Form1.LabelMaxFreeMemoryUsedByIBPoolCurrent2,
Form1.TextBoxMaxFreeMemoryUsedByIBPool,
Form1.CheckBoxbCompressDiffuseLocalPlayerCharacterTextures,
Form1.LabelbCompressDiffuseLocalPlayerCharacterTexturesCurrent1,
Form1.LabelbCompressDiffuseLocalPlayerCharacterTexturesCurrent2,
Form1.CheckBoxbCompressDiffuseLocalPlayerVehicleTextures,
Form1.LabelbCompressDiffuseLocalPlayerVehicleTexturesCurrent1,
Form1.LabelbCompressDiffuseLocalPlayerVehicleTexturesCurrent2,
Form1.CheckBoxbCompressDiffuseOtherPlayerCharacterTextures,
Form1.LabelbCompressDiffuseOtherPlayerCharacterTexturesCurrent1,
Form1.LabelbCompressDiffuseOtherPlayerCharacterTexturesCurrent2,
Form1.CheckBoxbCompressDiffuseOtherPlayerVehicleTextures,
Form1.LabelbCompressDiffuseOtherPlayerVehicleTexturesCurrent1,
Form1.LabelbCompressDiffuseOtherPlayerVehicleTexturesCurrent2,
Form1.CheckBoxbCompressNormalTextures,
Form1.LabelbCompressNormalTexturesCurrent1,
Form1.LabelbCompressNormalTexturesCurrent2,
Form1.LabelTEXCAT_LCPedestrian,
Form1.LabelTEXCAT_LCPedestrianMinLODSize,
Form1.ComboBoxTEXCAT_LCPedestrianMinLODSize,
Form1.LabelTEXCAT_LCPedestrianMinLODSizeCurrent2,
Form1.LabelTEXCAT_LCPedestrianMaxLODSize,
Form1.ComboBoxTEXCAT_LCPedestrianMaxLODSize,
Form1.LabelTEXCAT_LCPedestrianMaxLODSizeCurrent2,
Form1.LabelTEXCAT_LCPedestrianLODBias,
Form1.TextBoxTEXCAT_LCPedestrianLODBias,
Form1.LabelTEXCAT_LCPedestrianLODBiasCurrent2,
Form1.CheckBoxTEXCAT_LCPedestrianDisableStreaming,
Form1.LabelTEXCAT_LCPedestrianDisableStreamingCurrent2,
Form1.LabelTEXCAT_LCPedestrianFairUsagePriority,
Form1.TextBoxTEXCAT_LCPedestrianFairUsagePriority,
Form1.LabelTEXCAT_LCPedestrianFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_LCVehicle,
Form1.LabelTEXCAT_LCVehicleMinLODSize,
Form1.ComboBoxTEXCAT_LCVehicleMinLODSize,
Form1.LabelTEXCAT_LCVehicleMinLODSizeCurrent2,
Form1.LabelTEXCAT_LCVehicleMaxLODSize,
Form1.ComboBoxTEXCAT_LCVehicleMaxLODSize,
Form1.LabelTEXCAT_LCVehicleMaxLODSizeCurrent2,
Form1.LabelTEXCAT_LCVehicleLODBias,
Form1.TextBoxTEXCAT_LCVehicleLODBias,
Form1.LabelTEXCAT_LCVehicleLODBiasCurrent2,
Form1.CheckBoxTEXCAT_LCVehicleDisableStreaming,
Form1.LabelTEXCAT_LCVehicleDisableStreamingCurrent2,
Form1.LabelTEXCAT_LCVehicleFairUsagePriority,
Form1.TextBoxTEXCAT_LCVehicleFairUsagePriority,
Form1.LabelTEXCAT_LCVehicleFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_Environment,
Form1.LabelTEXCAT_EnvironmentMinLODSize,
Form1.ComboBoxTEXCAT_EnvironmentMinLODSize,
Form1.LabelTEXCAT_EnvironmentMinLODSizeCurrent2,
Form1.LabelTEXCAT_EnvironmentMaxLODSize,
Form1.ComboBoxTEXCAT_EnvironmentMaxLODSize,
Form1.LabelTEXCAT_EnvironmentMaxLODSizeCurrent2,
Form1.LabelTEXCAT_EnvironmentLODBias,
Form1.TextBoxTEXCAT_EnvironmentLODBias,
Form1.LabelTEXCAT_EnvironmentLODBiasCurrent2,
Form1.CheckBoxTEXCAT_EnvironmentDisableStreaming,
Form1.LabelTEXCAT_EnvironmentDisableStreamingCurrent2,
Form1.LabelTEXCAT_EnvironmentFairUsagePriority,
Form1.TextBoxTEXCAT_EnvironmentFairUsagePriority,
Form1.LabelTEXCAT_EnvironmentFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_Prop,
Form1.LabelTEXCAT_PropMinLODSize,
Form1.ComboBoxTEXCAT_PropMinLODSize,
Form1.LabelTEXCAT_PropMinLODSizeCurrent2,
Form1.LabelTEXCAT_PropMaxLODSize,
Form1.ComboBoxTEXCAT_PropMaxLODSize,
Form1.LabelTEXCAT_PropMaxLODSizeCurrent2,
Form1.LabelTEXCAT_PropLODBias,
Form1.TextBoxTEXCAT_PropLODBias,
Form1.LabelTEXCAT_PropLODBiasCurrent2,
Form1.CheckBoxTEXCAT_PropDisableStreaming,
Form1.LabelTEXCAT_PropDisableStreamingCurrent2,
Form1.LabelTEXCAT_PropFairUsagePriority,
Form1.TextBoxTEXCAT_PropFairUsagePriority,
Form1.LabelTEXCAT_PropFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_CharacterShared,
Form1.LabelTEXCAT_CharacterSharedMinLODSize,
Form1.ComboBoxTEXCAT_CharacterSharedMinLODSize,
Form1.LabelTEXCAT_CharacterSharedMinLODSizeCurrent2,
Form1.LabelTEXCAT_CharacterSharedMaxLODSize,
Form1.ComboBoxTEXCAT_CharacterSharedMaxLODSize,
Form1.LabelTEXCAT_CharacterSharedMaxLODSizeCurrent2,
Form1.LabelTEXCAT_CharacterSharedLODBias,
Form1.TextBoxTEXCAT_CharacterSharedLODBias,
Form1.LabelTEXCAT_CharacterSharedLODBiasCurrent2,
Form1.CheckBoxTEXCAT_CharacterSharedDisableStreaming,
Form1.LabelTEXCAT_CharacterSharedDisableStreamingCurrent2,
Form1.LabelTEXCAT_CharacterSharedFairUsagePriority,
Form1.TextBoxTEXCAT_CharacterSharedFairUsagePriority,
Form1.LabelTEXCAT_CharacterSharedFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_VehicleShared,
Form1.LabelTEXCAT_VehicleSharedMinLODSize,
Form1.ComboBoxTEXCAT_VehicleSharedMinLODSize,
Form1.LabelTEXCAT_VehicleSharedMinLODSizeCurrent2,
Form1.LabelTEXCAT_VehicleSharedMaxLODSize,
Form1.ComboBoxTEXCAT_VehicleSharedMaxLODSize,
Form1.LabelTEXCAT_VehicleSharedMaxLODSizeCurrent2,
Form1.LabelTEXCAT_VehicleSharedLODBias,
Form1.TextBoxTEXCAT_VehicleSharedLODBias,
Form1.LabelTEXCAT_VehicleSharedLODBiasCurrent2,
Form1.CheckBoxTEXCAT_VehicleSharedDisableStreaming,
Form1.LabelTEXCAT_VehicleSharedDisableStreamingCurrent2,
Form1.LabelTEXCAT_VehicleSharedFairUsagePriority,
Form1.TextBoxTEXCAT_VehicleSharedFairUsagePriority,
Form1.LabelTEXCAT_VehicleSharedFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_Contact,
Form1.LabelTEXCAT_ContactMinLODSize,
Form1.ComboBoxTEXCAT_ContactMinLODSize,
Form1.LabelTEXCAT_ContactMinLODSizeCurrent2,
Form1.LabelTEXCAT_ContactMaxLODSize,
Form1.ComboBoxTEXCAT_ContactMaxLODSize,
Form1.LabelTEXCAT_ContactMaxLODSizeCurrent2,
Form1.LabelTEXCAT_ContactLODBias,
Form1.TextBoxTEXCAT_ContactLODBias,
Form1.LabelTEXCAT_ContactLODBiasCurrent2,
Form1.CheckBoxTEXCAT_ContactDisableStreaming,
Form1.LabelTEXCAT_ContactDisableStreamingCurrent2,
Form1.LabelTEXCAT_ContactFairUsagePriority,
Form1.TextBoxTEXCAT_ContactFairUsagePriority,
Form1.LabelTEXCAT_ContactFairUsagePriorityCurrent2
    }
    Public Shared ControlConstraintsBucket3 As New List(Of Control) From {
Form1.LabelfMipBiasDiffuseLocalPlayerCharacterTextures,
Form1.LabelfMipBiasDiffuseLocalPlayerCharacterTexturesCurrent1,
Form1.LabelfMipBiasDiffuseLocalPlayerCharacterTexturesCurrent2,
Form1.TextBoxfMipBiasDiffuseLocalPlayerCharacterTextures,
Form1.LabelnMaxMemoryCacheEntryCount,
Form1.LabelnMaxMemoryCacheEntryCountCurrent1,
Form1.LabelnMaxMemoryCacheEntryCountCurrent2,
Form1.TextBoxnMaxMemoryCacheEntryCount,
Form1.LabelAudioCompatMode,
Form1.LabelAudioCompatModeCurrent1,
Form1.LabelAudioCompatModeCurrent2,
Form1.TextBoxAudioCompatMode,
Form1.LabelMaxMemoryUsedByTextureStreaming,
Form1.LabelMaxMemoryUsedByTextureStreamingCurrent1,
Form1.LabelMaxMemoryUsedByTextureStreamingCurrent2,
Form1.TextBoxMaxMemoryUsedByTextureStreaming,
Form1.LabelMaxMemoryUsedByTexturePool,
Form1.LabelMaxMemoryUsedByTexturePoolCurrent1,
Form1.LabelMaxMemoryUsedByTexturePoolCurrent2,
Form1.TextBoxMaxMemoryUsedByTexturePool,
Form1.LabelMaxMemoryUsedByMeshStreaming,
Form1.LabelMaxMemoryUsedByMeshStreamingCurrent1,
Form1.LabelMaxMemoryUsedByMeshStreamingCurrent2,
Form1.TextBoxMaxMemoryUsedByMeshStreaming,
Form1.LabelNumberOfTextureCreationPerFrame,
Form1.LabelNumberOfTextureCreationPerFrameCurrent1,
Form1.LabelNumberOfTextureCreationPerFrameCurrent2,
Form1.TextBoxNumberOfTextureCreationPerFrame,
Form1.LabelMaxFreeMemoryUsedByVBPool,
Form1.LabelMaxFreeMemoryUsedByVBPoolCurrent1,
Form1.LabelMaxFreeMemoryUsedByVBPoolCurrent2,
Form1.TextBoxMaxFreeMemoryUsedByVBPool,
Form1.LabelMaxFreeMemoryUsedByIBPool,
Form1.LabelMaxFreeMemoryUsedByIBPoolCurrent1,
Form1.LabelMaxFreeMemoryUsedByIBPoolCurrent2,
Form1.TextBoxMaxFreeMemoryUsedByIBPool,
Form1.CheckBoxbCompressDiffuseLocalPlayerCharacterTextures,
Form1.LabelbCompressDiffuseLocalPlayerCharacterTexturesCurrent1,
Form1.LabelbCompressDiffuseLocalPlayerCharacterTexturesCurrent2,
Form1.CheckBoxbCompressDiffuseLocalPlayerVehicleTextures,
Form1.LabelbCompressDiffuseLocalPlayerVehicleTexturesCurrent1,
Form1.LabelbCompressDiffuseLocalPlayerVehicleTexturesCurrent2,
Form1.CheckBoxbCompressDiffuseOtherPlayerCharacterTextures,
Form1.LabelbCompressDiffuseOtherPlayerCharacterTexturesCurrent1,
Form1.LabelbCompressDiffuseOtherPlayerCharacterTexturesCurrent2,
Form1.CheckBoxbCompressDiffuseOtherPlayerVehicleTextures,
Form1.LabelbCompressDiffuseOtherPlayerVehicleTexturesCurrent1,
Form1.LabelbCompressDiffuseOtherPlayerVehicleTexturesCurrent2,
Form1.CheckBoxbCompressNormalTextures,
Form1.LabelbCompressNormalTexturesCurrent1,
Form1.LabelbCompressNormalTexturesCurrent2
    }
    Public Shared ControlConstraintsBucketShared As New List(Of Control) From {
Form1.LabelTEXCAT_LCPedestrian,
Form1.LabelTEXCAT_LCPedestrianMinLODSize,
Form1.ComboBoxTEXCAT_LCPedestrianMinLODSize,
Form1.LabelTEXCAT_LCPedestrianMinLODSizeCurrent2,
Form1.LabelTEXCAT_LCPedestrianMaxLODSize,
Form1.ComboBoxTEXCAT_LCPedestrianMaxLODSize,
Form1.LabelTEXCAT_LCPedestrianMaxLODSizeCurrent2,
Form1.LabelTEXCAT_LCPedestrianLODBias,
Form1.TextBoxTEXCAT_LCPedestrianLODBias,
Form1.LabelTEXCAT_LCPedestrianLODBiasCurrent2,
Form1.CheckBoxTEXCAT_LCPedestrianDisableStreaming,
Form1.LabelTEXCAT_LCPedestrianDisableStreamingCurrent2,
Form1.LabelTEXCAT_LCPedestrianFairUsagePriority,
Form1.TextBoxTEXCAT_LCPedestrianFairUsagePriority,
Form1.LabelTEXCAT_LCPedestrianFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_LCVehicle,
Form1.LabelTEXCAT_LCVehicleMinLODSize,
Form1.ComboBoxTEXCAT_LCVehicleMinLODSize,
Form1.LabelTEXCAT_LCVehicleMinLODSizeCurrent2,
Form1.LabelTEXCAT_LCVehicleMaxLODSize,
Form1.ComboBoxTEXCAT_LCVehicleMaxLODSize,
Form1.LabelTEXCAT_LCVehicleMaxLODSizeCurrent2,
Form1.LabelTEXCAT_LCVehicleLODBias,
Form1.TextBoxTEXCAT_LCVehicleLODBias,
Form1.LabelTEXCAT_LCVehicleLODBiasCurrent2,
Form1.CheckBoxTEXCAT_LCVehicleDisableStreaming,
Form1.LabelTEXCAT_LCVehicleDisableStreamingCurrent2,
Form1.LabelTEXCAT_LCVehicleFairUsagePriority,
Form1.TextBoxTEXCAT_LCVehicleFairUsagePriority,
Form1.LabelTEXCAT_LCVehicleFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_Environment,
Form1.LabelTEXCAT_EnvironmentMinLODSize,
Form1.ComboBoxTEXCAT_EnvironmentMinLODSize,
Form1.LabelTEXCAT_EnvironmentMinLODSizeCurrent2,
Form1.LabelTEXCAT_EnvironmentMaxLODSize,
Form1.ComboBoxTEXCAT_EnvironmentMaxLODSize,
Form1.LabelTEXCAT_EnvironmentMaxLODSizeCurrent2,
Form1.LabelTEXCAT_EnvironmentLODBias,
Form1.TextBoxTEXCAT_EnvironmentLODBias,
Form1.LabelTEXCAT_EnvironmentLODBiasCurrent2,
Form1.CheckBoxTEXCAT_EnvironmentDisableStreaming,
Form1.LabelTEXCAT_EnvironmentDisableStreamingCurrent2,
Form1.LabelTEXCAT_EnvironmentFairUsagePriority,
Form1.TextBoxTEXCAT_EnvironmentFairUsagePriority,
Form1.LabelTEXCAT_EnvironmentFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_Prop,
Form1.LabelTEXCAT_PropMinLODSize,
Form1.ComboBoxTEXCAT_PropMinLODSize,
Form1.LabelTEXCAT_PropMinLODSizeCurrent2,
Form1.LabelTEXCAT_PropMaxLODSize,
Form1.ComboBoxTEXCAT_PropMaxLODSize,
Form1.LabelTEXCAT_PropMaxLODSizeCurrent2,
Form1.LabelTEXCAT_PropLODBias,
Form1.TextBoxTEXCAT_PropLODBias,
Form1.LabelTEXCAT_PropLODBiasCurrent2,
Form1.CheckBoxTEXCAT_PropDisableStreaming,
Form1.LabelTEXCAT_PropDisableStreamingCurrent2,
Form1.LabelTEXCAT_PropFairUsagePriority,
Form1.TextBoxTEXCAT_PropFairUsagePriority,
Form1.LabelTEXCAT_PropFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_CharacterShared,
Form1.LabelTEXCAT_CharacterSharedMinLODSize,
Form1.ComboBoxTEXCAT_CharacterSharedMinLODSize,
Form1.LabelTEXCAT_CharacterSharedMinLODSizeCurrent2,
Form1.LabelTEXCAT_CharacterSharedMaxLODSize,
Form1.ComboBoxTEXCAT_CharacterSharedMaxLODSize,
Form1.LabelTEXCAT_CharacterSharedMaxLODSizeCurrent2,
Form1.LabelTEXCAT_CharacterSharedLODBias,
Form1.TextBoxTEXCAT_CharacterSharedLODBias,
Form1.LabelTEXCAT_CharacterSharedLODBiasCurrent2,
Form1.CheckBoxTEXCAT_CharacterSharedDisableStreaming,
Form1.LabelTEXCAT_CharacterSharedDisableStreamingCurrent2,
Form1.LabelTEXCAT_CharacterSharedFairUsagePriority,
Form1.TextBoxTEXCAT_CharacterSharedFairUsagePriority,
Form1.LabelTEXCAT_CharacterSharedFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_VehicleShared,
Form1.LabelTEXCAT_VehicleSharedMinLODSize,
Form1.ComboBoxTEXCAT_VehicleSharedMinLODSize,
Form1.LabelTEXCAT_VehicleSharedMinLODSizeCurrent2,
Form1.LabelTEXCAT_VehicleSharedMaxLODSize,
Form1.ComboBoxTEXCAT_VehicleSharedMaxLODSize,
Form1.LabelTEXCAT_VehicleSharedMaxLODSizeCurrent2,
Form1.LabelTEXCAT_VehicleSharedLODBias,
Form1.TextBoxTEXCAT_VehicleSharedLODBias,
Form1.LabelTEXCAT_VehicleSharedLODBiasCurrent2,
Form1.CheckBoxTEXCAT_VehicleSharedDisableStreaming,
Form1.LabelTEXCAT_VehicleSharedDisableStreamingCurrent2,
Form1.LabelTEXCAT_VehicleSharedFairUsagePriority,
Form1.TextBoxTEXCAT_VehicleSharedFairUsagePriority,
Form1.LabelTEXCAT_VehicleSharedFairUsagePriorityCurrent2,
Form1.LabelTEXCAT_Contact,
Form1.LabelTEXCAT_ContactMinLODSize,
Form1.ComboBoxTEXCAT_ContactMinLODSize,
Form1.LabelTEXCAT_ContactMinLODSizeCurrent2,
Form1.LabelTEXCAT_ContactMaxLODSize,
Form1.ComboBoxTEXCAT_ContactMaxLODSize,
Form1.LabelTEXCAT_ContactMaxLODSizeCurrent2,
Form1.LabelTEXCAT_ContactLODBias,
Form1.TextBoxTEXCAT_ContactLODBias,
Form1.LabelTEXCAT_ContactLODBiasCurrent2,
Form1.CheckBoxTEXCAT_ContactDisableStreaming,
Form1.LabelTEXCAT_ContactDisableStreamingCurrent2,
Form1.LabelTEXCAT_ContactFairUsagePriority,
Form1.TextBoxTEXCAT_ContactFairUsagePriority,
Form1.LabelTEXCAT_ContactFairUsagePriorityCurrent2,
Form1.LabelnCharacterDiffuseWidth,
Form1.LabelnCharacterDiffuseWidthCurrent1,
Form1.LabelnCharacterDiffuseWidthCurrent2,
Form1.TextBoxnCharacterDiffuseWidth,
Form1.LabelnCharacterDiffuseHeight,
Form1.LabelnCharacterDiffuseHeightCurrent1,
Form1.LabelnCharacterDiffuseHeightCurrent2,
Form1.TextBoxnCharacterDiffuseHeight,
Form1.LabelnCharacterNormalMapWidth,
Form1.LabelnCharacterNormalMapWidthCurrent1,
Form1.LabelnCharacterNormalMapWidthCurrent2,
Form1.TextBoxnCharacterNormalMapWidth,
Form1.LabelnCharacterNormalMapHeight,
Form1.LabelnCharacterNormalMapHeightCurrent1,
Form1.LabelnCharacterNormalMapHeightCurrent2,
Form1.TextBoxnCharacterNormalMapHeight,
Form1.LabelnVehicleExteriorTextureSize,
Form1.LabelnVehicleExteriorTextureSizeCurrent1,
Form1.LabelnVehicleExteriorTextureSizeCurrent2,
Form1.TextBoxnVehicleExteriorTextureSize,
Form1.LabelnVehicleExteriorNormalTextureSize,
Form1.LabelnVehicleExteriorNormalTextureSizeCurrent1,
Form1.LabelnVehicleExteriorNormalTextureSizeCurrent2,
Form1.TextBoxnVehicleExteriorNormalTextureSize,
Form1.LabelnVehicleExteriorEmissiveTextureSize,
Form1.LabelnVehicleExteriorEmissiveTextureSizeCurrent1,
Form1.LabelnVehicleExteriorEmissiveTextureSizeCurrent2,
Form1.TextBoxnVehicleExteriorEmissiveTextureSize,
Form1.LabelnVehicleInteriorTextureSize,
Form1.LabelnVehicleInteriorTextureSizeCurrent1,
Form1.LabelnVehicleInteriorTextureSizeCurrent2,
Form1.TextBoxnVehicleInteriorTextureSize,
Form1.LabelnVehicleInteriorEmissiveTextureSize,
Form1.LabelnVehicleInteriorEmissiveTextureSizeCurrent1,
Form1.LabelnVehicleInteriorEmissiveTextureSizeCurrent2,
Form1.TextBoxnVehicleInteriorEmissiveTextureSize,
Form1.LabelnVehicleWheelTextureSize,
Form1.LabelnVehicleWheelTextureSizeCurrent1,
Form1.LabelnVehicleWheelTextureSizeCurrent2,
Form1.TextBoxnVehicleWheelTextureSize,
Form1.LabelnVehicleWheelEmissiveTextureSize,
Form1.LabelnVehicleWheelEmissiveTextureSizeCurrent1,
Form1.LabelnVehicleWheelEmissiveTextureSizeCurrent2,
Form1.TextBoxnVehicleWheelEmissiveTextureSize,
Form1.LabelnVehicleGlassTextureSize,
Form1.LabelnVehicleGlassTextureSizeCurrent1,
Form1.LabelnVehicleGlassTextureSizeCurrent2,
Form1.TextBoxnVehicleGlassTextureSize,
Form1.LabelnMaxMemoryCacheEntryCount,
Form1.LabelnMaxMemoryCacheEntryCountCurrent1,
Form1.LabelnMaxMemoryCacheEntryCountCurrent2,
Form1.TextBoxnMaxMemoryCacheEntryCount
}
    Public Shared ControlConstraintsAlwaysActive As New List(Of Control) From {
    Form1.LabelMinSmoothedFrameRate,
    Form1.LabelMinSmoothedFrameRateCurrent1,
    Form1.LabelMinSmoothedFrameRateCurrent2,
    Form1.TextBoxMinSmoothedFrameRate,
    Form1.LabelMaxSmoothedFrameRate,
    Form1.LabelMaxSmoothedFrameRateCurrent1,
    Form1.LabelMaxSmoothedFrameRateCurrent2,
    Form1.TextBoxMaxSmoothedFrameRate,
    Form1.LabelMinDesiredFrameRate,
    Form1.LabelMinDesiredFrameRateCurrent1,
    Form1.LabelMinDesiredFrameRateCurrent2,
    Form1.TextBoxMinDesiredFrameRate
    }
    Public Shared Sub DeclareCompatVariablesAgain()
        StaticDecalsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "StaticDecals", "(none)")
        DynamicDecalsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "DynamicDecals", "(none)")
        LevelParticlesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "LevelParticles", "(none)")
        DynamicLightsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "DynamicLights", "(none)")
        DynamicShadowsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "DynamicShadows", "(none)")
        BlobShadowsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "BlobShadows", "(none)")
        LightEnvironmentShadowsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "LightEnvironmentShadows", "(none)")
        EnvironmentShadowsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "EnvironmentShadows", "(none)")
        CompositeDynamicLightsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "CompositeDynamicLights", "(none)")
        DirectionalLightmapsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "DirectionalLightmaps", "(none)")
        MotionBlurValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MotionBlur", "(none)")
        DepthOfFieldValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "DepthOfField", "(none)")
        AmbientOcclusionValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "AmbientOcclusion", "(none)")
        BloomValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "Bloom", "(none)")
        QualityBloomValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "QualityBloom", "(none)")
        DistortionValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "Distortion", "(none)")
        DropParticleDistortionValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "DropParticleDistortion", "(none)")
        SpeedTreeLeavesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "SpeedTreeLeaves", "(none)")
        SpeedTreeFrondsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "SpeedTreeFronds", "(none)")
        OnlyStreamInTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "OnlyStreamInTextures", "(none)")
        LensFlaresValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "LensFlares", "(none)")
        FogVolumesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "FogVolumes", "(none)")
        FloatingPointRenderTargetsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "FloatingPointRenderTargets", "(none)")
        TrilinearValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "Trilinear", "(none)")
        OneFrameThreadLagValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "OneFrameThreadLag", "(none)")
        UseVsyncValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "UseVsync", "(none)")
        UpscaleScreenPercentageValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "UpscaleScreenPercentage", "(none)")
        FullscreenValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "Fullscreen", "(none)")
        AllowD3D10Value = Form1.APBCompat.GetString(Form1.APBCompatSection, "AllowD3D10", "(none)")
        EnableHighPolyCharsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "EnableHighPolyChars", "(none)")
        SkeletalMeshLODBiasValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "SkeletalMeshLODBias", "(none)")
        ParticleLODBiasValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ParticleLODBias", "(none)")
        DetailModeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "DetailMode", "(none)")
        ShadowFilterQualityBiasValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFilterQualityBias", "(none)")
        MaxAnisotropyValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxAnisotropy", "(none)")
        AnisotropyAmountValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "AnisotropyAmount", "(none)")
        MaxMultisamplesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMultisamples", "(none)")
        MSAA_AmountValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MSAA_Amount", "(none)")
        MinShadowResolutionValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MinShadowResolution", "(none)")
        MaxShadowResolutionValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxShadowResolution", "(none)")
        ShadowFadeResolutionValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFadeResolution", "(none)")
        ShadowFadeExponentValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFadeExponent", "(none)")
        ShadowFadeStartDistanceValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFadeStartDistance", "(none)")
        ShadowFadeEndDistanceValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFadeEndDistance", "(none)")
        MaxDynamicShadowsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxDynamicShadows", "(none)")
        SunRenderQualityValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "SunRenderQuality", "(none)")
        TrueSunMinScreenSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "TrueSunMinScreenSize", "(none)")
        ParticleMaxWorldSpaceAreaValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ParticleMaxWorldSpaceArea", "(none)")
        ScreenPercentageValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ScreenPercentage", "(none)")
        SceneCaptureStreamingMultiplierValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "SceneCaptureStreamingMultiplier", "(none)")
        FoliageDrawRadiusMultiplierValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "FoliageDrawRadiusMultiplier", "(none)")
        ShadowTexelsPerPixelValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowTexelsPerPixel", "(none)")
        bEnableVSMShadowsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bEnableVSMShadows", "(none)")
        bEnableBranchingPCFShadowsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bEnableBranchingPCFShadows", "(none)")
        bAllowBetterModulatedShadowsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bAllowBetterModulatedShadows", "(none)")
        bEnableForegroundShadowsOnWorldValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bEnableForegroundShadowsOnWorld", "(none)")
        ShadowFilterRadiusValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowFilterRadius", "(none)")
        ShadowDepthBiasValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowDepthBias", "(none)")
        ShadowVolumeLightRadiusThresholdValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowVolumeLightRadiusThreshold", "(none)")
        ShadowVolumePrimitiveScreenSpacePercentageThresholdValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "ShadowVolumePrimitiveScreenSpacePercentageThreshold", "(none)")
        nNumCharacterLODValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nNumCharacterLOD", "(none)")
        nCharacterDiffuseWidthValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterDiffuseWidth", "(none)")
        nCharacterDiffuseHeightValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterDiffuseHeight", "(none)")
        nCharacterNormalMapWidthValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterNormalMapWidth", "(none)")
        nCharacterNormalMapHeightValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterNormalMapHeight", "(none)")
        bCharacterGenerateUVBleedMeshValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCharacterGenerateUVBleedMesh", "(none)")
        m_bGameRenderEyelashesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "m_bGameRenderEyelashes", "(none)")
        fCharacterLODDistance1Value = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCharacterLODDistance1", "(none)")
        fCharacterLODDistance2Value = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCharacterLODDistance2", "(none)")
        fCharacterCullDistanceValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCharacterCullDistance", "(none)")
        bCharacterForceGCAfterBuildValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCharacterForceGCAfterBuild", "(none)")
        nNumVehicleLODValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nNumVehicleLOD", "(none)")
        nVehicleExteriorTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleExteriorTextureSize", "(none)")
        nVehicleExteriorNormalTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleExteriorNormalTextureSize", "(none)")
        nVehicleExteriorEmissiveTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleExteriorEmissiveTextureSize", "(none)")
        nVehicleInteriorTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleInteriorTextureSize", "(none)")
        nVehicleInteriorEmissiveTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleInteriorEmissiveTextureSize", "(none)")
        nVehicleWheelTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleWheelTextureSize", "(none)")
        nVehicleWheelEmissiveTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleWheelEmissiveTextureSize", "(none)")
        nVehicleGlassTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleGlassTextureSize", "(none)")
        bVehicleGenerateUVBleedMeshValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bVehicleGenerateUVBleedMesh", "(none)")
        bVehicleForceGCAfterBuildValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bVehicleForceGCAfterBuild", "(none)")
        fVehicleLODDistanceValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fVehicleLODDistance", "(none)")
        fVehicleCullDistanceValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fVehicleCullDistance", "(none)")
        nGraffitiTextureWidthValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nGraffitiTextureWidth", "(none)")
        nGraffitiTextureHeightValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nGraffitiTextureHeight", "(none)")
        fCAM_MemoryThresholdNormalValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCAM_MemoryThresholdNormal", "(none)")
        fCAM_MemoryThresholdCriticalValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCAM_MemoryThresholdCritical", "(none)")
        fCAM_MemoryBackToNormalHysteresisValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fCAM_MemoryBackToNormalHysteresis", "(none)")
        fLCPedestrianLODDistanceValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCPedestrianLODDistance", "(none)")
        fLCPedestrianCullDistanceValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCPedestrianCullDistance", "(none)")
        fLCDriverLODDistanceValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCDriverLODDistance", "(none)")
        fLCDriverCullDistanceValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCDriverCullDistance", "(none)")
        fLCVehicleLODDistanceValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCVehicleLODDistance", "(none)")
        fLCVehicleCullDistanceValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fLCVehicleCullDistance", "(none)")
        nMaxMemoryCacheEntryCountValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nMaxMemoryCacheEntryCount", "(none)")
        MaxLCHairResolutionValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxLCHairResolution", "(none)")
        MaxLCVehicleTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxLCVehicleTextureSize", "(none)")
        SpawnMapDelayTimeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "SpawnMapDelayTime", "(none)")
        LowQualityHealthHUDValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "LowQualityHealthHUD", "(none)")
        bUseSimplifiedVehicleMaterialsValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bUseSimplifiedVehicleMaterials", "(none)")
        SmoothFrameRateValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "SmoothFrameRate", "(none)")
        TEXCAT_UnknownMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Unknown", "(none)").Split(","c)(1).ToString '.Split(" "c, ","c)
        TEXCAT_UnknownMinLODSizeValue = TEXCAT_UnknownMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_UnknownMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Unknown", "(none)").Split(","c)(2).ToString
        TEXCAT_UnknownMaxLODSizeValue = TEXCAT_UnknownMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_UnknownLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Unknown", "(none)").Split(","c)(3).ToString
        TEXCAT_UnknownLODBiasValue = TEXCAT_UnknownLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_UnknownDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Unknown", "(none)").Split(","c)(4).ToString
        TEXCAT_UnknownDisableStreamingValue = TEXCAT_UnknownDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_UnknownFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Unknown", "(none)").Split(","c)(5).ToString
        TEXCAT_UnknownFairUsagePriorityValue = TEXCAT_UnknownFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_EnvironmentMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(1).ToString
        TEXCAT_EnvironmentMinLODSizeValue = TEXCAT_EnvironmentMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_EnvironmentMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(2).ToString
        TEXCAT_EnvironmentMaxLODSizeValue = TEXCAT_EnvironmentMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_EnvironmentLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(3).ToString
        TEXCAT_EnvironmentLODBiasValue = TEXCAT_EnvironmentLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_EnvironmentDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(4).ToString
        TEXCAT_EnvironmentDisableStreamingValue = TEXCAT_EnvironmentDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_EnvironmentFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(5).ToString
        TEXCAT_EnvironmentFairUsagePriorityValue = TEXCAT_EnvironmentFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_PropMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(1).ToString
        TEXCAT_PropMinLODSizeValue = TEXCAT_PropMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_PropMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(2).ToString
        TEXCAT_PropMaxLODSizeValue = TEXCAT_PropMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_PropLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(3).ToString
        TEXCAT_PropLODBiasValue = TEXCAT_PropLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_PropDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(4).ToString
        TEXCAT_PropDisableStreamingValue = TEXCAT_PropDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_PropFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(5).ToString
        TEXCAT_PropFairUsagePriorityValue = TEXCAT_PropFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_PlayerCharacterMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(1).ToString
        TEXCAT_PlayerCharacterMinLODSizeValue = TEXCAT_PlayerCharacterMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_PlayerCharacterMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(2).ToString
        TEXCAT_PlayerCharacterMaxLODSizeValue = TEXCAT_PlayerCharacterMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_PlayerCharacterLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(3).ToString
        TEXCAT_PlayerCharacterLODBiasValue = TEXCAT_PlayerCharacterLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_PlayerCharacterDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(4).ToString
        TEXCAT_PlayerCharacterDisableStreamingValue = TEXCAT_PlayerCharacterDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_PlayerCharacterFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(5).ToString
        TEXCAT_PlayerCharacterFairUsagePriorityValue = TEXCAT_PlayerCharacterFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_PlayerVehicleMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(1).ToString
        TEXCAT_PlayerVehicleMinLODSizeValue = TEXCAT_PlayerVehicleMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_PlayerVehicleMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(2).ToString
        TEXCAT_PlayerVehicleMaxLODSizeValue = TEXCAT_PlayerVehicleMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_PlayerVehicleLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(3).ToString
        TEXCAT_PlayerVehicleLODBiasValue = TEXCAT_PlayerVehicleLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_PlayerVehicleDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(4).ToString
        TEXCAT_PlayerVehicleDisableStreamingValue = TEXCAT_PlayerVehicleDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_PlayerVehicleFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(5).ToString
        TEXCAT_PlayerVehicleFairUsagePriorityValue = TEXCAT_PlayerVehicleFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_LCPedestrianMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(1).ToString
        TEXCAT_LCPedestrianMinLODSizeValue = TEXCAT_LCPedestrianMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_LCPedestrianMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(2).ToString
        TEXCAT_LCPedestrianMaxLODSizeValue = TEXCAT_LCPedestrianMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_LCPedestrianLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(3).ToString
        TEXCAT_LCPedestrianLODBiasValue = TEXCAT_LCPedestrianLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_LCPedestrianDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(4).ToString
        TEXCAT_LCPedestrianDisableStreamingValue = TEXCAT_LCPedestrianDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_LCPedestrianFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(5).ToString
        TEXCAT_LCPedestrianFairUsagePriorityValue = TEXCAT_LCPedestrianFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_LCVehicleMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(1).ToString
        TEXCAT_LCVehicleMinLODSizeValue = TEXCAT_LCVehicleMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_LCVehicleMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(2).ToString
        TEXCAT_LCVehicleMaxLODSizeValue = TEXCAT_LCVehicleMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_LCVehicleLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(3).ToString
        TEXCAT_LCVehicleLODBiasValue = TEXCAT_LCVehicleLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_LCVehicleDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(4).ToString
        TEXCAT_LCVehicleDisableStreamingValue = TEXCAT_LCVehicleDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_LCVehicleFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(5).ToString
        TEXCAT_LCVehicleFairUsagePriorityValue = TEXCAT_LCVehicleFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_PickupMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Pickup", "(none)").Split(","c)(1).ToString
        TEXCAT_PickupMinLODSizeValue = TEXCAT_PickupMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_PickupMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Pickup", "(none)").Split(","c)(2).ToString
        TEXCAT_PickupMaxLODSizeValue = TEXCAT_PickupMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_PickupLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Pickup", "(none)").Split(","c)(3).ToString
        TEXCAT_PickupLODBiasValue = TEXCAT_PickupLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_PickupDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Pickup", "(none)").Split(","c)(4).ToString
        TEXCAT_PickupDisableStreamingValue = TEXCAT_PickupDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_PickupFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Pickup", "(none)").Split(","c)(5).ToString
        TEXCAT_PickupFairUsagePriorityValue = TEXCAT_PickupFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_CharacterSourceMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterSource", "(none)").Split(","c)(1).ToString
        TEXCAT_CharacterSourceMinLODSizeValue = TEXCAT_CharacterSourceMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_CharacterSourceMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterSource", "(none)").Split(","c)(2).ToString
        TEXCAT_CharacterSourceMaxLODSizeValue = TEXCAT_CharacterSourceMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_CharacterSourceLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterSource", "(none)").Split(","c)(3).ToString
        TEXCAT_CharacterSourceLODBiasValue = TEXCAT_CharacterSourceLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_CharacterSourceDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterSource", "(none)").Split(","c)(4).ToString
        TEXCAT_CharacterSourceDisableStreamingValue = TEXCAT_CharacterSourceDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_CharacterSourceFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterSource", "(none)").Split(","c)(5).ToString
        TEXCAT_CharacterSourceFairUsagePriorityValue = TEXCAT_CharacterSourceFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_VehicleSourceMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleSource", "(none)").Split(","c)(1).ToString
        TEXCAT_VehicleSourceMinLODSizeValue = TEXCAT_VehicleSourceMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_VehicleSourceMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleSource", "(none)").Split(","c)(2).ToString
        TEXCAT_VehicleSourceMaxLODSizeValue = TEXCAT_VehicleSourceMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_VehicleSourceLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleSource", "(none)").Split(","c)(3).ToString
        TEXCAT_VehicleSourceLODBiasValue = TEXCAT_VehicleSourceLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_VehicleSourceDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleSource", "(none)").Split(","c)(4).ToString
        TEXCAT_VehicleSourceDisableStreamingValue = TEXCAT_VehicleSourceDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_VehicleSourceFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleSource", "(none)").Split(","c)(5).ToString
        TEXCAT_VehicleSourceFairUsagePriorityValue = TEXCAT_VehicleSourceFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_PrimitiveSourceMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(1).ToString
        TEXCAT_PrimitiveSourceMinLODSizeValue = TEXCAT_PrimitiveSourceMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_PrimitiveSourceMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(2).ToString
        TEXCAT_PrimitiveSourceMaxLODSizeValue = TEXCAT_PrimitiveSourceMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_PrimitiveSourceLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(3).ToString
        TEXCAT_PrimitiveSourceLODBiasValue = TEXCAT_PrimitiveSourceLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_PrimitiveSourceDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(4).ToString
        TEXCAT_PrimitiveSourceDisableStreamingValue = TEXCAT_PrimitiveSourceDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_PrimitiveSourceFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(5).ToString
        TEXCAT_PrimitiveSourceFairUsagePriorityValue = TEXCAT_PrimitiveSourceFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_UIMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_UI", "(none)").Split(","c)(1).ToString
        TEXCAT_UIMinLODSizeValue = TEXCAT_UIMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_UIMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_UI", "(none)").Split(","c)(2).ToString
        TEXCAT_UIMaxLODSizeValue = TEXCAT_UIMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_UILODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_UI", "(none)").Split(","c)(3).ToString
        TEXCAT_UILODBiasValue = TEXCAT_UILODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_UIDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_UI", "(none)").Split(","c)(4).ToString
        TEXCAT_UIDisableStreamingValue = TEXCAT_UIDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_UIFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_UI", "(none)").Split(","c)(5).ToString
        TEXCAT_UIFairUsagePriorityValue = TEXCAT_UIFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_VFXMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VFX", "(none)").Split(","c)(1).ToString
        TEXCAT_VFXMinLODSizeValue = TEXCAT_VFXMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_VFXMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VFX", "(none)").Split(","c)(2).ToString
        TEXCAT_VFXMaxLODSizeValue = TEXCAT_VFXMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_VFXLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VFX", "(none)").Split(","c)(3).ToString
        TEXCAT_VFXLODBiasValue = TEXCAT_VFXLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_VFXDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VFX", "(none)").Split(","c)(4).ToString
        TEXCAT_VFXDisableStreamingValue = TEXCAT_VFXDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_VFXFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VFX", "(none)").Split(","c)(5).ToString
        TEXCAT_VFXFairUsagePriorityValue = TEXCAT_VFXFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_LightAndShadowMapMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(1).ToString
        TEXCAT_LightAndShadowMapMinLODSizeValue = TEXCAT_LightAndShadowMapMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_LightAndShadowMapMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(2).ToString
        TEXCAT_LightAndShadowMapMaxLODSizeValue = TEXCAT_LightAndShadowMapMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_LightAndShadowMapLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(3).ToString
        TEXCAT_LightAndShadowMapLODBiasValue = TEXCAT_LightAndShadowMapLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_LightAndShadowMapDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(4).ToString
        TEXCAT_LightAndShadowMapDisableStreamingValue = TEXCAT_LightAndShadowMapDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_LightAndShadowMapFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(5).ToString
        TEXCAT_LightAndShadowMapFairUsagePriorityValue = TEXCAT_LightAndShadowMapFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_RenderTargetMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_RenderTarget", "(none)").Split(","c)(1).ToString
        TEXCAT_RenderTargetMinLODSizeValue = TEXCAT_RenderTargetMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_RenderTargetMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_RenderTarget", "(none)").Split(","c)(2).ToString
        TEXCAT_RenderTargetMaxLODSizeValue = TEXCAT_RenderTargetMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_RenderTargetLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_RenderTarget", "(none)").Split(","c)(3).ToString
        TEXCAT_RenderTargetLODBiasValue = TEXCAT_RenderTargetLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_RenderTargetDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_RenderTarget", "(none)").Split(","c)(4).ToString
        TEXCAT_RenderTargetDisableStreamingValue = TEXCAT_RenderTargetDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_RenderTargetFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_RenderTarget", "(none)").Split(","c)(5).ToString
        TEXCAT_RenderTargetFairUsagePriorityValue = TEXCAT_RenderTargetFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_SignageMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Signage", "(none)").Split(","c)(1).ToString
        TEXCAT_SignageMinLODSizeValue = TEXCAT_SignageMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_SignageMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Signage", "(none)").Split(","c)(2).ToString
        TEXCAT_SignageMaxLODSizeValue = TEXCAT_SignageMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_SignageLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Signage", "(none)").Split(","c)(3).ToString
        TEXCAT_SignageLODBiasValue = TEXCAT_SignageLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_SignageDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Signage", "(none)").Split(","c)(4).ToString
        TEXCAT_SignageDisableStreamingValue = TEXCAT_SignageDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_SignageFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Signage", "(none)").Split(","c)(5).ToString
        TEXCAT_SignageFairUsagePriorityValue = TEXCAT_SignageFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_PlayerGraffitiMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(1).ToString
        TEXCAT_PlayerGraffitiMinLODSizeValue = TEXCAT_PlayerGraffitiMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_PlayerGraffitiMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(2).ToString
        TEXCAT_PlayerGraffitiMaxLODSizeValue = TEXCAT_PlayerGraffitiMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_PlayerGraffitiLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(3).ToString
        TEXCAT_PlayerGraffitiLODBiasValue = TEXCAT_PlayerGraffitiLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_PlayerGraffitiDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(4).ToString
        TEXCAT_PlayerGraffitiDisableStreamingValue = TEXCAT_PlayerGraffitiDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_PlayerGraffitiFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(5).ToString
        TEXCAT_PlayerGraffitiFairUsagePriorityValue = TEXCAT_PlayerGraffitiFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_PlayerStatueMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerStatue", "(none)").Split(","c)(1).ToString
        TEXCAT_PlayerStatueMinLODSizeValue = TEXCAT_PlayerStatueMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_PlayerStatueMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerStatue", "(none)").Split(","c)(2).ToString
        TEXCAT_PlayerStatueMaxLODSizeValue = TEXCAT_PlayerStatueMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_PlayerStatueLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerStatue", "(none)").Split(","c)(3).ToString
        TEXCAT_PlayerStatueLODBiasValue = TEXCAT_PlayerStatueLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_PlayerStatueDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerStatue", "(none)").Split(","c)(4).ToString
        TEXCAT_PlayerStatueDisableStreamingValue = TEXCAT_PlayerStatueDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_PlayerStatueFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_PlayerStatue", "(none)").Split(","c)(5).ToString
        TEXCAT_PlayerStatueFairUsagePriorityValue = TEXCAT_PlayerStatueFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_CharacterSharedMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(1).ToString
        TEXCAT_CharacterSharedMinLODSizeValue = TEXCAT_CharacterSharedMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_CharacterSharedMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(2).ToString
        TEXCAT_CharacterSharedMaxLODSizeValue = TEXCAT_CharacterSharedMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_CharacterSharedLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(3).ToString
        TEXCAT_CharacterSharedLODBiasValue = TEXCAT_CharacterSharedLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_CharacterSharedDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(4).ToString
        TEXCAT_CharacterSharedDisableStreamingValue = TEXCAT_CharacterSharedDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_CharacterSharedFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(5).ToString
        TEXCAT_CharacterSharedFairUsagePriorityValue = TEXCAT_CharacterSharedFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_VehicleSharedMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(1).ToString
        TEXCAT_VehicleSharedMinLODSizeValue = TEXCAT_VehicleSharedMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_VehicleSharedMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(2).ToString
        TEXCAT_VehicleSharedMaxLODSizeValue = TEXCAT_VehicleSharedMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_VehicleSharedLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(3).ToString
        TEXCAT_VehicleSharedLODBiasValue = TEXCAT_VehicleSharedLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_VehicleSharedDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(4).ToString
        TEXCAT_VehicleSharedDisableStreamingValue = TEXCAT_VehicleSharedDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_VehicleSharedFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(5).ToString
        TEXCAT_VehicleSharedFairUsagePriorityValue = TEXCAT_VehicleSharedFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_NonFinalMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_NonFinal", "(none)").Split(","c)(1).ToString
        TEXCAT_NonFinalMinLODSizeValue = TEXCAT_NonFinalMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_NonFinalMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_NonFinal", "(none)").Split(","c)(2).ToString
        TEXCAT_NonFinalMaxLODSizeValue = TEXCAT_NonFinalMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_NonFinalLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_NonFinal", "(none)").Split(","c)(3).ToString
        TEXCAT_NonFinalLODBiasValue = TEXCAT_NonFinalLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_NonFinalDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_NonFinal", "(none)").Split(","c)(4).ToString
        TEXCAT_NonFinalDisableStreamingValue = TEXCAT_NonFinalDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_NonFinalFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_NonFinal", "(none)").Split(","c)(5).ToString
        TEXCAT_NonFinalFairUsagePriorityValue = TEXCAT_NonFinalFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_ContactMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(1).ToString
        TEXCAT_ContactMinLODSizeValue = TEXCAT_ContactMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_ContactMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(2).ToString
        TEXCAT_ContactMaxLODSizeValue = TEXCAT_ContactMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_ContactLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(3).ToString
        TEXCAT_ContactLODBiasValue = TEXCAT_ContactLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_ContactDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(4).ToString
        TEXCAT_ContactDisableStreamingValue = TEXCAT_ContactDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_ContactFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(5).ToString
        TEXCAT_ContactFairUsagePriorityValue = TEXCAT_ContactFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        fMipBiasDiffuseLocalPlayerCharacterTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fMipBiasDiffuseLocalPlayerCharacterTextures", "(none)")
        bCompressDiffuseLocalPlayerCharacterTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseLocalPlayerCharacterTextures", "(none)")
        bCompressDiffuseLocalPlayerVehicleTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseLocalPlayerVehicleTextures", "(none)")
        bCompressDiffuseOtherPlayerCharacterTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseOtherPlayerCharacterTextures", "(none)")
        bCompressDiffuseOtherPlayerVehicleTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseOtherPlayerVehicleTextures", "(none)")
        bCompressNormalTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressNormalTextures", "(none)")
        AudioCompatModeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "AudioCompatMode", "(none)")
        MaxMemoryUsedByTextureStreamingValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByTextureStreaming", "(none)")
        MaxMemoryUsedByTexturePoolValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByTexturePool", "(none)")
        MaxMemoryUsedByMeshStreamingValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByMeshStreaming", "(none)")
        NumberOfTextureCreationPerFrameValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "NumberOfTextureCreationPerFrame", "(none)")
        MaxFreeMemoryUsedByVBPoolValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxFreeMemoryUsedByVBPool", "(none)")
        MaxFreeMemoryUsedByIBPoolValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxFreeMemoryUsedByIBPool", "(none)")
    End Sub
    Public Shared Sub DeclareCompatVariablesAgainBucket1and2()
        TEXCAT_LCPedestrianMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(1).ToString
        TEXCAT_LCPedestrianMinLODSizeValue = TEXCAT_LCPedestrianMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_LCPedestrianMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(2).ToString
        TEXCAT_LCPedestrianMaxLODSizeValue = TEXCAT_LCPedestrianMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_LCPedestrianLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(3).ToString
        TEXCAT_LCPedestrianLODBiasValue = TEXCAT_LCPedestrianLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_LCPedestrianDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(4).ToString
        TEXCAT_LCPedestrianDisableStreamingValue = TEXCAT_LCPedestrianDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_LCPedestrianFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCPedestrian", "(none)").Split(","c)(5).ToString
        TEXCAT_LCPedestrianFairUsagePriorityValue = TEXCAT_LCPedestrianFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_LCVehicleMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(1).ToString
        TEXCAT_LCVehicleMinLODSizeValue = TEXCAT_LCVehicleMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_LCVehicleMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(2).ToString
        TEXCAT_LCVehicleMaxLODSizeValue = TEXCAT_LCVehicleMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_LCVehicleLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(3).ToString
        TEXCAT_LCVehicleLODBiasValue = TEXCAT_LCVehicleLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_LCVehicleDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(4).ToString
        TEXCAT_LCVehicleDisableStreamingValue = TEXCAT_LCVehicleDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_LCVehicleFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_LCVehicle", "(none)").Split(","c)(5).ToString
        TEXCAT_LCVehicleFairUsagePriorityValue = TEXCAT_LCVehicleFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_EnvironmentMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(1).ToString
        TEXCAT_EnvironmentMinLODSizeValue = TEXCAT_EnvironmentMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_EnvironmentMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(2).ToString
        TEXCAT_EnvironmentMaxLODSizeValue = TEXCAT_EnvironmentMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_EnvironmentLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(3).ToString
        TEXCAT_EnvironmentLODBiasValue = TEXCAT_EnvironmentLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_EnvironmentDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(4).ToString
        TEXCAT_EnvironmentDisableStreamingValue = TEXCAT_EnvironmentDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_EnvironmentFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Environment", "(none)").Split(","c)(5).ToString
        TEXCAT_EnvironmentFairUsagePriorityValue = TEXCAT_EnvironmentFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_PropMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(1).ToString
        TEXCAT_PropMinLODSizeValue = TEXCAT_PropMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_PropMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(2).ToString
        TEXCAT_PropMaxLODSizeValue = TEXCAT_PropMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_PropLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(3).ToString
        TEXCAT_PropLODBiasValue = TEXCAT_PropLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_PropDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(4).ToString
        TEXCAT_PropDisableStreamingValue = TEXCAT_PropDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_PropFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Prop", "(none)").Split(","c)(5).ToString
        TEXCAT_PropFairUsagePriorityValue = TEXCAT_PropFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_CharacterSharedMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(1).ToString
        TEXCAT_CharacterSharedMinLODSizeValue = TEXCAT_CharacterSharedMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_CharacterSharedMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(2).ToString
        TEXCAT_CharacterSharedMaxLODSizeValue = TEXCAT_CharacterSharedMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_CharacterSharedLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(3).ToString
        TEXCAT_CharacterSharedLODBiasValue = TEXCAT_CharacterSharedLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_CharacterSharedDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(4).ToString
        TEXCAT_CharacterSharedDisableStreamingValue = TEXCAT_CharacterSharedDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_CharacterSharedFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_CharacterShared", "(none)").Split(","c)(5).ToString
        TEXCAT_CharacterSharedFairUsagePriorityValue = TEXCAT_CharacterSharedFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_VehicleSharedMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(1).ToString
        TEXCAT_VehicleSharedMinLODSizeValue = TEXCAT_VehicleSharedMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_VehicleSharedMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(2).ToString
        TEXCAT_VehicleSharedMaxLODSizeValue = TEXCAT_VehicleSharedMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_VehicleSharedLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(3).ToString
        TEXCAT_VehicleSharedLODBiasValue = TEXCAT_VehicleSharedLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_VehicleSharedDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(4).ToString
        TEXCAT_VehicleSharedDisableStreamingValue = TEXCAT_VehicleSharedDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_VehicleSharedFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_VehicleShared", "(none)").Split(","c)(5).ToString
        TEXCAT_VehicleSharedFairUsagePriorityValue = TEXCAT_VehicleSharedFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        TEXCAT_ContactMinLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(1).ToString
        TEXCAT_ContactMinLODSizeValue = TEXCAT_ContactMinLODSizeValueRaw.Replace("MinLODSize=", "")
        TEXCAT_ContactMaxLODSizeValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(2).ToString
        TEXCAT_ContactMaxLODSizeValue = TEXCAT_ContactMaxLODSizeValueRaw.Replace("MaxLODSize=", "")
        TEXCAT_ContactLODBiasValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(3).ToString
        TEXCAT_ContactLODBiasValue = TEXCAT_ContactLODBiasValueRaw.Replace("LODBias=", "")
        TEXCAT_ContactDisableStreamingValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(4).ToString
        TEXCAT_ContactDisableStreamingValue = TEXCAT_ContactDisableStreamingValueRaw.Replace("DisableStreaming=", "")
        TEXCAT_ContactFairUsagePriorityValueRaw = Form1.APBCompat.GetString(Form1.APBCompatSection, "TEXCAT_Contact", "(none)").Split(","c)(5).ToString
        TEXCAT_ContactFairUsagePriorityValue = TEXCAT_ContactFairUsagePriorityValueRaw.Replace("FairUsagePriority=", "").Replace(")", "")
        nCharacterDiffuseWidthValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterDiffuseWidth", "(none)")
        nCharacterDiffuseHeightValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterDiffuseHeight", "(none)")
        nCharacterNormalMapWidthValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterNormalMapWidth", "(none)")
        nCharacterNormalMapHeightValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nCharacterNormalMapHeight", "(none)")
        nVehicleExteriorTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleExteriorTextureSize", "(none)")
        nVehicleExteriorNormalTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleExteriorNormalTextureSize", "(none)")
        nVehicleExteriorEmissiveTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleExteriorEmissiveTextureSize", "(none)")
        nVehicleInteriorTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleInteriorTextureSize", "(none)")
        nVehicleInteriorEmissiveTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleInteriorEmissiveTextureSize", "(none)")
        nVehicleWheelTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleWheelTextureSize", "(none)")
        nVehicleWheelEmissiveTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleWheelEmissiveTextureSize", "(none)")
        nVehicleGlassTextureSizeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nVehicleGlassTextureSize", "(none)")
        fMipBiasDiffuseLocalPlayerCharacterTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fMipBiasDiffuseLocalPlayerCharacterTextures", "(none)")
        bCompressDiffuseLocalPlayerCharacterTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseLocalPlayerCharacterTextures", "(none)")
        bCompressDiffuseLocalPlayerVehicleTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseLocalPlayerVehicleTextures", "(none)")
        bCompressDiffuseOtherPlayerCharacterTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseOtherPlayerCharacterTextures", "(none)")
        bCompressDiffuseOtherPlayerVehicleTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseOtherPlayerVehicleTextures", "(none)")
        bCompressNormalTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressNormalTextures", "(none)")
        nMaxMemoryCacheEntryCountValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nMaxMemoryCacheEntryCount", "(none)")
        AudioCompatModeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "AudioCompatMode", "(none)")
        MaxMemoryUsedByTextureStreamingValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByTextureStreaming", "(none)")
        MaxMemoryUsedByTexturePoolValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByTexturePool", "(none)")
        MaxMemoryUsedByMeshStreamingValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByMeshStreaming", "(none)")
        NumberOfTextureCreationPerFrameValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "NumberOfTextureCreationPerFrame", "(none)")
        MaxFreeMemoryUsedByVBPoolValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxFreeMemoryUsedByVBPool", "(none)")
        MaxFreeMemoryUsedByIBPoolValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxFreeMemoryUsedByIBPool", "(none)")
    End Sub
    Public Shared Sub DeclareCompatVariablesAgainBucket3()
        fMipBiasDiffuseLocalPlayerCharacterTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "fMipBiasDiffuseLocalPlayerCharacterTextures", "(none)")
        bCompressDiffuseLocalPlayerCharacterTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseLocalPlayerCharacterTextures", "(none)")
        bCompressDiffuseLocalPlayerVehicleTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseLocalPlayerVehicleTextures", "(none)")
        bCompressDiffuseOtherPlayerCharacterTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseOtherPlayerCharacterTextures", "(none)")
        bCompressDiffuseOtherPlayerVehicleTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressDiffuseOtherPlayerVehicleTextures", "(none)")
        bCompressNormalTexturesValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "bCompressNormalTextures", "(none)")
        nMaxMemoryCacheEntryCountValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "nMaxMemoryCacheEntryCount", "(none)")
        AudioCompatModeValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "AudioCompatMode", "(none)")
        MaxMemoryUsedByTextureStreamingValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByTextureStreaming", "(none)")
        MaxMemoryUsedByTexturePoolValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByTexturePool", "(none)")
        MaxMemoryUsedByMeshStreamingValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxMemoryUsedByMeshStreaming", "(none)")
        NumberOfTextureCreationPerFrameValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "NumberOfTextureCreationPerFrame", "(none)")
        MaxFreeMemoryUsedByVBPoolValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxFreeMemoryUsedByVBPool", "(none)")
        MaxFreeMemoryUsedByIBPoolValue = Form1.APBCompat.GetString(Form1.APBCompatSection, "MaxFreeMemoryUsedByIBPool", "(none)")
    End Sub
    Public Shared Sub DeclareOtherValuesAgain()
        '---APBEngine.ini---
        MinSmoothedFrameRateValue = Form1.APBEngine.GetString("Engine.GameEngine", "MinSmoothedFrameRate", "(none)")
        MaxSmoothedFrameRateValue = Form1.APBEngine.GetString("Engine.GameEngine", "MaxSmoothedFrameRate", "(none)")
        MinDesiredFrameRateValue = Form1.APBEngine.GetString("Engine.Client", "MinDesiredFrameRate", "(none)")
        '!-!'!-!'Experimental'!-!'!-!'
        MaxDynamicChunkCountValue = Form1.APBEngine.GetString("Engine.PhysicsLODVerticalDestructible", "MaxDynamicChunkCount", "(none)")
        DebrisLifetimeValue = Form1.APBEngine.GetString("Engine.PhysicsLODVerticalDestructible", "DebrisLifetime", "(none)")
        ParticlePercentageValue = Form1.APBEngine.GetString("Engine.PhysicsLODVerticalEmitter", "ParticlePercentage", "(none)")
        '!-!'!-!'END Experimental'!-!'!-!'
    End Sub
End Class
