﻿Public Class CurrentValues
    Public Shared Sub LoadCurrentValuesToControls()
        DeclareCompatVarialbes.DeclareCompatVariablesAgain()
        Form1.CheckBoxStaticDecals.Checked = DeclareCompatVarialbes.StaticDecalsValue
        Form1.CheckBoxDynamicDecals.Checked = DeclareCompatVarialbes.DynamicDecalsValue
        Form1.CheckBoxLevelParticles.Checked = DeclareCompatVarialbes.LevelParticlesValue
        Form1.CheckBoxDynamicLights.Checked = DeclareCompatVarialbes.DynamicLightsValue
        Form1.CheckBoxDynamicShadows.Checked = DeclareCompatVarialbes.DynamicShadowsValue
        Form1.CheckBoxBlobShadows.Checked = DeclareCompatVarialbes.BlobShadowsValue
        Form1.CheckBoxLightEnvironmentShadows.Checked = DeclareCompatVarialbes.LightEnvironmentShadowsValue
        Form1.CheckBoxEnvironmentShadows.Checked = DeclareCompatVarialbes.EnvironmentShadowsValue
        Form1.CheckBoxCompositeDynamicLights.Checked = DeclareCompatVarialbes.CompositeDynamicLightsValue
        Form1.CheckBoxDirectionalLightmaps.Checked = DeclareCompatVarialbes.DirectionalLightmapsValue
        Form1.CheckBoxMotionBlur.Checked = DeclareCompatVarialbes.MotionBlurValue
        Form1.CheckBoxDepthOfField.Checked = DeclareCompatVarialbes.DepthOfFieldValue
        Form1.CheckBoxAmbientOcclusion.Checked = DeclareCompatVarialbes.AmbientOcclusionValue
        Form1.CheckBoxBloom.Checked = DeclareCompatVarialbes.BloomValue
        Form1.CheckBoxQualityBloom.Checked = DeclareCompatVarialbes.QualityBloomValue
        Form1.CheckBoxDistortion.Checked = DeclareCompatVarialbes.DistortionValue
        Form1.CheckBoxDropParticleDistortion.Checked = DeclareCompatVarialbes.DropParticleDistortionValue
        Form1.CheckBoxSpeedTreeLeaves.Checked = DeclareCompatVarialbes.SpeedTreeLeavesValue
        Form1.CheckBoxSpeedTreeFronds.Checked = DeclareCompatVarialbes.SpeedTreeFrondsValue
        Form1.CheckBoxOnlyStreamInTextures.Checked = DeclareCompatVarialbes.OnlyStreamInTexturesValue
        Form1.CheckBoxLensFlares.Checked = DeclareCompatVarialbes.LensFlaresValue
        Form1.CheckBoxFogVolumes.Checked = DeclareCompatVarialbes.FogVolumesValue
        Form1.CheckBoxFloatingPointRenderTargets.Checked = DeclareCompatVarialbes.FloatingPointRenderTargetsValue
        Form1.CheckBoxTrilinear.Checked = DeclareCompatVarialbes.TrilinearValue
        Form1.CheckBoxOneFrameThreadLag.Checked = DeclareCompatVarialbes.OneFrameThreadLagValue
        Form1.CheckBoxUseVsync.Checked = DeclareCompatVarialbes.UseVsyncValue
        Form1.CheckBoxUpscaleScreenPercentage.Checked = DeclareCompatVarialbes.UpscaleScreenPercentageValue
        Form1.CheckBoxFullscreen.Checked = DeclareCompatVarialbes.FullscreenValue
        Form1.CheckBoxAllowD3D10.Checked = DeclareCompatVarialbes.AllowD3D10Value
        Form1.CheckBoxEnableHighPolyChars.Checked = DeclareCompatVarialbes.EnableHighPolyCharsValue
        Form1.TextBoxSkeletalMeshLODBias.Text = DeclareCompatVarialbes.SkeletalMeshLODBiasValue
        Form1.TextBoxParticleLODBias.Text = DeclareCompatVarialbes.ParticleLODBiasValue
        Form1.TextBoxDetailMode.Text = DeclareCompatVarialbes.DetailModeValue
        Form1.TextBoxShadowFilterQualityBias.Text = DeclareCompatVarialbes.ShadowFilterQualityBiasValue
        Form1.TextBoxMaxAnisotropy.Text = DeclareCompatVarialbes.MaxAnisotropyValue
        Form1.TextBoxAnisotropyAmount.Text = DeclareCompatVarialbes.AnisotropyAmountValue
        Form1.TextBoxMaxMultisamples.Text = DeclareCompatVarialbes.MaxMultisamplesValue
        Form1.TextBoxMSAA_Amount.Text = DeclareCompatVarialbes.MSAA_AmountValue
        Form1.TextBoxMinShadowResolution.Text = DeclareCompatVarialbes.MinShadowResolutionValue
        Form1.TextBoxMaxShadowResolution.Text = DeclareCompatVarialbes.MaxShadowResolutionValue
        Form1.TextBoxShadowFadeResolution.Text = DeclareCompatVarialbes.ShadowFadeResolutionValue
        Form1.TextBoxShadowFadeExponent.Text = DeclareCompatVarialbes.ShadowFadeExponentValue
        Form1.TextBoxShadowFadeStartDistance.Text = DeclareCompatVarialbes.ShadowFadeStartDistanceValue
        Form1.TextBoxShadowFadeEndDistance.Text = DeclareCompatVarialbes.ShadowFadeEndDistanceValue
        Form1.TextBoxMaxDynamicShadows.Text = DeclareCompatVarialbes.MaxDynamicShadowsValue
        Form1.TextBoxSunRenderQuality.Text = DeclareCompatVarialbes.SunRenderQualityValue
        Form1.TextBoxTrueSunMinScreenSize.Text = DeclareCompatVarialbes.TrueSunMinScreenSizeValue
        Form1.TextBoxParticleMaxWorldSpaceArea.Text = DeclareCompatVarialbes.ParticleMaxWorldSpaceAreaValue
        Form1.TextBoxScreenPercentage.Text = DeclareCompatVarialbes.ScreenPercentageValue
        Form1.TextBoxSceneCaptureStreamingMultiplier.Text = DeclareCompatVarialbes.SceneCaptureStreamingMultiplierValue
        Form1.TextBoxFoliageDrawRadiusMultiplier.Text = DeclareCompatVarialbes.FoliageDrawRadiusMultiplierValue
        Form1.TextBoxShadowTexelsPerPixel.Text = DeclareCompatVarialbes.ShadowTexelsPerPixelValue
        Form1.CheckBoxbEnableVSMShadows.Checked = DeclareCompatVarialbes.bEnableVSMShadowsValue
        Form1.CheckBoxbEnableBranchingPCFShadows.Checked = DeclareCompatVarialbes.bEnableBranchingPCFShadowsValue
        Form1.CheckBoxbAllowBetterModulatedShadows.Checked = DeclareCompatVarialbes.bAllowBetterModulatedShadowsValue
        Form1.CheckBoxbEnableForegroundShadowsOnWorld.Checked = DeclareCompatVarialbes.bEnableForegroundShadowsOnWorldValue
        Form1.TextBoxShadowFilterRadius.Text = DeclareCompatVarialbes.ShadowFilterRadiusValue
        Form1.TextBoxShadowDepthBias.Text = DeclareCompatVarialbes.ShadowDepthBiasValue
        Form1.TextBoxShadowVolumeLightRadiusThreshold.Text = DeclareCompatVarialbes.ShadowVolumeLightRadiusThresholdValue
        Form1.TextBoxShadowVolumePrimitiveScreenSpacePercentageThreshold.Text = DeclareCompatVarialbes.ShadowVolumePrimitiveScreenSpacePercentageThresholdValue
        Form1.TextBoxnNumCharacterLOD.Text = DeclareCompatVarialbes.nNumCharacterLODValue
        Form1.TextBoxnCharacterDiffuseWidth.Text = DeclareCompatVarialbes.nCharacterDiffuseWidthValue
        Form1.TextBoxnCharacterDiffuseHeight.Text = DeclareCompatVarialbes.nCharacterDiffuseHeightValue
        Form1.TextBoxnCharacterNormalMapWidth.Text = DeclareCompatVarialbes.nCharacterNormalMapWidthValue
        Form1.TextBoxnCharacterNormalMapHeight.Text = DeclareCompatVarialbes.nCharacterNormalMapHeightValue
        Form1.CheckBoxbCharacterGenerateUVBleedMesh.Checked = DeclareCompatVarialbes.bCharacterGenerateUVBleedMeshValue
        Form1.CheckBoxm_bGameRenderEyelashes.Checked = DeclareCompatVarialbes.m_bGameRenderEyelashesValue
        Form1.TextBoxfCharacterLODDistance1.Text = DeclareCompatVarialbes.fCharacterLODDistance1Value
        Form1.TextBoxfCharacterLODDistance2.Text = DeclareCompatVarialbes.fCharacterLODDistance2Value
        Form1.TextBoxfCharacterCullDistance.Text = DeclareCompatVarialbes.fCharacterCullDistanceValue
        Form1.CheckBoxbCharacterForceGCAfterBuild.Checked = DeclareCompatVarialbes.bCharacterForceGCAfterBuildValue
        Form1.TextBoxnNumVehicleLOD.Text = DeclareCompatVarialbes.nNumVehicleLODValue
        Form1.TextBoxnVehicleExteriorTextureSize.Text = DeclareCompatVarialbes.nVehicleExteriorTextureSizeValue
        Form1.TextBoxnVehicleExteriorNormalTextureSize.Text = DeclareCompatVarialbes.nVehicleExteriorNormalTextureSizeValue
        Form1.TextBoxnVehicleExteriorEmissiveTextureSize.Text = DeclareCompatVarialbes.nVehicleExteriorEmissiveTextureSizeValue
        Form1.TextBoxnVehicleInteriorTextureSize.Text = DeclareCompatVarialbes.nVehicleInteriorTextureSizeValue
        Form1.TextBoxnVehicleInteriorEmissiveTextureSize.Text = DeclareCompatVarialbes.nVehicleInteriorEmissiveTextureSizeValue
        Form1.TextBoxnVehicleWheelTextureSize.Text = DeclareCompatVarialbes.nVehicleWheelTextureSizeValue
        Form1.TextBoxnVehicleWheelEmissiveTextureSize.Text = DeclareCompatVarialbes.nVehicleWheelEmissiveTextureSizeValue
        Form1.TextBoxnVehicleGlassTextureSize.Text = DeclareCompatVarialbes.nVehicleGlassTextureSizeValue
        Form1.CheckBoxbVehicleGenerateUVBleedMesh.Checked = DeclareCompatVarialbes.bVehicleGenerateUVBleedMeshValue
        Form1.CheckBoxbVehicleForceGCAfterBuild.Checked = DeclareCompatVarialbes.bVehicleForceGCAfterBuildValue
        Form1.TextBoxfVehicleLODDistance.Text = DeclareCompatVarialbes.fVehicleLODDistanceValue
        Form1.TextBoxfVehicleCullDistance.Text = DeclareCompatVarialbes.fVehicleCullDistanceValue
        Form1.TextBoxnGraffitiTextureWidth.Text = DeclareCompatVarialbes.nGraffitiTextureWidthValue
        Form1.TextBoxnGraffitiTextureHeight.Text = DeclareCompatVarialbes.nGraffitiTextureHeightValue
        Form1.TextBoxfCAM_MemoryThresholdNormal.Text = DeclareCompatVarialbes.fCAM_MemoryThresholdNormalValue
        Form1.TextBoxfCAM_MemoryThresholdCritical.Text = DeclareCompatVarialbes.fCAM_MemoryThresholdCriticalValue
        Form1.TextBoxfCAM_MemoryBackToNormalHysteresis.Text = DeclareCompatVarialbes.fCAM_MemoryBackToNormalHysteresisValue
        Form1.TextBoxfLCPedestrianLODDistance.Text = DeclareCompatVarialbes.fLCPedestrianLODDistanceValue
        Form1.TextBoxfLCPedestrianCullDistance.Text = DeclareCompatVarialbes.fLCPedestrianCullDistanceValue
        Form1.TextBoxfLCDriverLODDistance.Text = DeclareCompatVarialbes.fLCDriverLODDistanceValue
        Form1.TextBoxfLCDriverCullDistance.Text = DeclareCompatVarialbes.fLCDriverCullDistanceValue
        Form1.TextBoxfLCVehicleLODDistance.Text = DeclareCompatVarialbes.fLCVehicleLODDistanceValue
        Form1.TextBoxfLCVehicleCullDistance.Text = DeclareCompatVarialbes.fLCVehicleCullDistanceValue
        Form1.TextBoxnMaxMemoryCacheEntryCount.Text = DeclareCompatVarialbes.nMaxMemoryCacheEntryCountValue
        Form1.TextBoxMaxLCHairResolution.Text = DeclareCompatVarialbes.MaxLCHairResolutionValue
        Form1.TextBoxMaxLCVehicleTextureSize.Text = DeclareCompatVarialbes.MaxLCVehicleTextureSizeValue
        Form1.TextBoxSpawnMapDelayTime.Text = DeclareCompatVarialbes.SpawnMapDelayTimeValue
        Form1.CheckBoxLowQualityHealthHUD.Checked = DeclareCompatVarialbes.LowQualityHealthHUDValue
        If Form1.APBCompat.GetString(Form1.APBCompatSection, "bUseSimplifiedVehicleMaterials", "(none)") Is Nothing Then
        Else
            Form1.CheckBoxbUseSimplifiedVehicleMaterials.Checked = DeclareCompatVarialbes.bUseSimplifiedVehicleMaterialsValue
        End If


        Form1.CheckBoxSmoothFrameRate.Checked = DeclareCompatVarialbes.SmoothFrameRateValue
        '
        Form1.ComboBoxTEXCAT_UnknownMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_UnknownMinLODSizeValue
        Form1.ComboBoxTEXCAT_UnknownMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_UnknownMaxLODSizeValue
        Form1.TextBoxTEXCAT_UnknownLODBias.Text = DeclareCompatVarialbes.TEXCAT_UnknownLODBiasValue
        Form1.TextBoxTEXCAT_UnknownFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_UnknownFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_UnknownDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_UnknownDisableStreamingValue
        Form1.ComboBoxTEXCAT_EnvironmentMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_EnvironmentMinLODSizeValue
        Form1.ComboBoxTEXCAT_EnvironmentMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_EnvironmentMaxLODSizeValue
        Form1.TextBoxTEXCAT_EnvironmentLODBias.Text = DeclareCompatVarialbes.TEXCAT_EnvironmentLODBiasValue
        Form1.TextBoxTEXCAT_EnvironmentFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_EnvironmentFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_EnvironmentDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_EnvironmentDisableStreamingValue
        Form1.ComboBoxTEXCAT_PropMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PropMinLODSizeValue
        Form1.ComboBoxTEXCAT_PropMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PropMaxLODSizeValue
        Form1.TextBoxTEXCAT_PropLODBias.Text = DeclareCompatVarialbes.TEXCAT_PropLODBiasValue
        Form1.TextBoxTEXCAT_PropFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_PropFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_PropDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_PropDisableStreamingValue
        Form1.ComboBoxTEXCAT_PlayerCharacterMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PlayerCharacterMinLODSizeValue
        Form1.ComboBoxTEXCAT_PlayerCharacterMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PlayerCharacterMaxLODSizeValue
        Form1.TextBoxTEXCAT_PlayerCharacterLODBias.Text = DeclareCompatVarialbes.TEXCAT_PlayerCharacterLODBiasValue
        Form1.TextBoxTEXCAT_PlayerCharacterFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_PlayerCharacterFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_PlayerCharacterDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_PlayerCharacterDisableStreamingValue
        Form1.ComboBoxTEXCAT_PlayerVehicleMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PlayerVehicleMinLODSizeValue
        Form1.ComboBoxTEXCAT_PlayerVehicleMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PlayerVehicleMaxLODSizeValue
        Form1.TextBoxTEXCAT_PlayerVehicleLODBias.Text = DeclareCompatVarialbes.TEXCAT_PlayerVehicleLODBiasValue
        Form1.TextBoxTEXCAT_PlayerVehicleFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_PlayerVehicleFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_PlayerVehicleDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_PlayerVehicleDisableStreamingValue
        Form1.ComboBoxTEXCAT_LCPedestrianMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_LCPedestrianMinLODSizeValue
        Form1.ComboBoxTEXCAT_LCPedestrianMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_LCPedestrianMaxLODSizeValue
        Form1.TextBoxTEXCAT_LCPedestrianLODBias.Text = DeclareCompatVarialbes.TEXCAT_LCPedestrianLODBiasValue
        Form1.TextBoxTEXCAT_LCPedestrianFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_LCPedestrianFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_LCPedestrianDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_LCPedestrianDisableStreamingValue
        Form1.ComboBoxTEXCAT_LCVehicleMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_LCVehicleMinLODSizeValue
        Form1.ComboBoxTEXCAT_LCVehicleMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_LCVehicleMaxLODSizeValue
        Form1.TextBoxTEXCAT_LCVehicleLODBias.Text = DeclareCompatVarialbes.TEXCAT_LCVehicleLODBiasValue
        Form1.TextBoxTEXCAT_LCVehicleFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_LCVehicleFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_LCVehicleDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_LCVehicleDisableStreamingValue
        Form1.ComboBoxTEXCAT_PickupMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PickupMinLODSizeValue
        Form1.ComboBoxTEXCAT_PickupMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PickupMaxLODSizeValue
        Form1.TextBoxTEXCAT_PickupLODBias.Text = DeclareCompatVarialbes.TEXCAT_PickupLODBiasValue
        Form1.TextBoxTEXCAT_PickupFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_PickupFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_PickupDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_PickupDisableStreamingValue
        Form1.ComboBoxTEXCAT_CharacterSourceMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_CharacterSourceMinLODSizeValue
        Form1.ComboBoxTEXCAT_CharacterSourceMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_CharacterSourceMaxLODSizeValue
        Form1.TextBoxTEXCAT_CharacterSourceLODBias.Text = DeclareCompatVarialbes.TEXCAT_CharacterSourceLODBiasValue
        Form1.TextBoxTEXCAT_CharacterSourceFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_CharacterSourceFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_CharacterSourceDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_CharacterSourceDisableStreamingValue
        Form1.ComboBoxTEXCAT_VehicleSourceMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_VehicleSourceMinLODSizeValue
        Form1.ComboBoxTEXCAT_VehicleSourceMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_VehicleSourceMaxLODSizeValue
        Form1.TextBoxTEXCAT_VehicleSourceLODBias.Text = DeclareCompatVarialbes.TEXCAT_VehicleSourceLODBiasValue
        Form1.TextBoxTEXCAT_VehicleSourceFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_VehicleSourceFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_VehicleSourceDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_VehicleSourceDisableStreamingValue
        Form1.ComboBoxTEXCAT_PrimitiveSourceMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PrimitiveSourceMinLODSizeValue
        Form1.ComboBoxTEXCAT_PrimitiveSourceMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PrimitiveSourceMaxLODSizeValue
        Form1.TextBoxTEXCAT_PrimitiveSourceLODBias.Text = DeclareCompatVarialbes.TEXCAT_PrimitiveSourceLODBiasValue
        Form1.TextBoxTEXCAT_PrimitiveSourceFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_PrimitiveSourceFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_PrimitiveSourceDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_PrimitiveSourceDisableStreamingValue
        Form1.ComboBoxTEXCAT_UIMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_UIMinLODSizeValue
        Form1.ComboBoxTEXCAT_UIMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_UIMaxLODSizeValue
        Form1.TextBoxTEXCAT_UILODBias.Text = DeclareCompatVarialbes.TEXCAT_UILODBiasValue
        Form1.TextBoxTEXCAT_UIFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_UIFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_UIDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_UIDisableStreamingValue
        Form1.ComboBoxTEXCAT_VFXMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_VFXMinLODSizeValue
        Form1.ComboBoxTEXCAT_VFXMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_VFXMaxLODSizeValue
        Form1.TextBoxTEXCAT_VFXLODBias.Text = DeclareCompatVarialbes.TEXCAT_VFXLODBiasValue
        Form1.TextBoxTEXCAT_VFXFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_VFXFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_VFXDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_VFXDisableStreamingValue
        Form1.ComboBoxTEXCAT_LightAndShadowMapMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_LightAndShadowMapMinLODSizeValue
        Form1.ComboBoxTEXCAT_LightAndShadowMapMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_LightAndShadowMapMaxLODSizeValue
        Form1.TextBoxTEXCAT_LightAndShadowMapLODBias.Text = DeclareCompatVarialbes.TEXCAT_LightAndShadowMapLODBiasValue
        Form1.TextBoxTEXCAT_LightAndShadowMapFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_LightAndShadowMapFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_LightAndShadowMapDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_LightAndShadowMapDisableStreamingValue
        Form1.ComboBoxTEXCAT_RenderTargetMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_RenderTargetMinLODSizeValue
        Form1.ComboBoxTEXCAT_RenderTargetMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_RenderTargetMaxLODSizeValue
        Form1.TextBoxTEXCAT_RenderTargetLODBias.Text = DeclareCompatVarialbes.TEXCAT_RenderTargetLODBiasValue
        Form1.TextBoxTEXCAT_RenderTargetFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_RenderTargetFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_RenderTargetDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_RenderTargetDisableStreamingValue
        Form1.ComboBoxTEXCAT_SignageMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_SignageMinLODSizeValue
        Form1.ComboBoxTEXCAT_SignageMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_SignageMaxLODSizeValue
        Form1.TextBoxTEXCAT_SignageLODBias.Text = DeclareCompatVarialbes.TEXCAT_SignageLODBiasValue
        Form1.TextBoxTEXCAT_SignageFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_SignageFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_SignageDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_SignageDisableStreamingValue
        Form1.ComboBoxTEXCAT_PlayerGraffitiMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PlayerGraffitiMinLODSizeValue
        Form1.ComboBoxTEXCAT_PlayerGraffitiMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PlayerGraffitiMaxLODSizeValue
        Form1.TextBoxTEXCAT_PlayerGraffitiLODBias.Text = DeclareCompatVarialbes.TEXCAT_PlayerGraffitiLODBiasValue
        Form1.TextBoxTEXCAT_PlayerGraffitiFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_PlayerGraffitiFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_PlayerGraffitiDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_PlayerGraffitiDisableStreamingValue
        Form1.ComboBoxTEXCAT_PlayerStatueMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PlayerStatueMinLODSizeValue
        Form1.ComboBoxTEXCAT_PlayerStatueMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PlayerStatueMaxLODSizeValue
        Form1.TextBoxTEXCAT_PlayerStatueLODBias.Text = DeclareCompatVarialbes.TEXCAT_PlayerStatueLODBiasValue
        Form1.TextBoxTEXCAT_PlayerStatueFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_PlayerStatueFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_PlayerStatueDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_PlayerStatueDisableStreamingValue
        Form1.ComboBoxTEXCAT_CharacterSharedMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_CharacterSharedMinLODSizeValue
        Form1.ComboBoxTEXCAT_CharacterSharedMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_CharacterSharedMaxLODSizeValue
        Form1.TextBoxTEXCAT_CharacterSharedLODBias.Text = DeclareCompatVarialbes.TEXCAT_CharacterSharedLODBiasValue
        Form1.TextBoxTEXCAT_CharacterSharedFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_CharacterSharedFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_CharacterSharedDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_CharacterSharedDisableStreamingValue
        Form1.ComboBoxTEXCAT_VehicleSharedMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_VehicleSharedMinLODSizeValue
        Form1.ComboBoxTEXCAT_VehicleSharedMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_VehicleSharedMaxLODSizeValue
        Form1.TextBoxTEXCAT_VehicleSharedLODBias.Text = DeclareCompatVarialbes.TEXCAT_VehicleSharedLODBiasValue
        Form1.TextBoxTEXCAT_VehicleSharedFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_VehicleSharedFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_VehicleSharedDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_VehicleSharedDisableStreamingValue
        Form1.ComboBoxTEXCAT_NonFinalMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_NonFinalMinLODSizeValue
        Form1.ComboBoxTEXCAT_NonFinalMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_NonFinalMaxLODSizeValue
        Form1.TextBoxTEXCAT_NonFinalLODBias.Text = DeclareCompatVarialbes.TEXCAT_NonFinalLODBiasValue
        Form1.TextBoxTEXCAT_NonFinalFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_NonFinalFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_NonFinalDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_NonFinalDisableStreamingValue
        Form1.ComboBoxTEXCAT_ContactMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_ContactMinLODSizeValue
        Form1.ComboBoxTEXCAT_ContactMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_ContactMaxLODSizeValue
        Form1.TextBoxTEXCAT_ContactLODBias.Text = DeclareCompatVarialbes.TEXCAT_ContactLODBiasValue
        Form1.TextBoxTEXCAT_ContactFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_ContactFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_ContactDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_ContactDisableStreamingValue
        LoadOtherValuesToControls()
        LoadAPBGameValuesToControls()
        LoadInputValuesToControls()
    End Sub
    Public Shared Sub LoadCurrentBucket1and2ValuesToControls()
        DeclareCompatVarialbes.DeclareCompatVariablesAgainBucket1and2()
        Form1.ComboBoxTEXCAT_LCPedestrianMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_LCPedestrianMinLODSizeValue
        Form1.ComboBoxTEXCAT_LCPedestrianMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_LCPedestrianMaxLODSizeValue
        Form1.TextBoxTEXCAT_LCPedestrianLODBias.Text = DeclareCompatVarialbes.TEXCAT_LCPedestrianLODBiasValue
        Form1.TextBoxTEXCAT_LCPedestrianFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_LCPedestrianFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_LCPedestrianDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_LCPedestrianDisableStreamingValue
        Form1.ComboBoxTEXCAT_LCVehicleMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_LCVehicleMinLODSizeValue
        Form1.ComboBoxTEXCAT_LCVehicleMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_LCVehicleMaxLODSizeValue
        Form1.TextBoxTEXCAT_LCVehicleLODBias.Text = DeclareCompatVarialbes.TEXCAT_LCVehicleLODBiasValue
        Form1.TextBoxTEXCAT_LCVehicleFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_LCVehicleFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_LCVehicleDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_LCVehicleDisableStreamingValue
        Form1.ComboBoxTEXCAT_EnvironmentMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_EnvironmentMinLODSizeValue
        Form1.ComboBoxTEXCAT_EnvironmentMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_EnvironmentMaxLODSizeValue
        Form1.TextBoxTEXCAT_EnvironmentLODBias.Text = DeclareCompatVarialbes.TEXCAT_EnvironmentLODBiasValue
        Form1.TextBoxTEXCAT_EnvironmentFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_EnvironmentFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_EnvironmentDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_EnvironmentDisableStreamingValue
        Form1.ComboBoxTEXCAT_PropMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PropMinLODSizeValue
        Form1.ComboBoxTEXCAT_PropMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_PropMaxLODSizeValue
        Form1.TextBoxTEXCAT_PropLODBias.Text = DeclareCompatVarialbes.TEXCAT_PropLODBiasValue
        Form1.TextBoxTEXCAT_PropFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_PropFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_PropDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_PropDisableStreamingValue
        Form1.ComboBoxTEXCAT_CharacterSharedMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_CharacterSharedMinLODSizeValue
        Form1.ComboBoxTEXCAT_CharacterSharedMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_CharacterSharedMaxLODSizeValue
        Form1.TextBoxTEXCAT_CharacterSharedLODBias.Text = DeclareCompatVarialbes.TEXCAT_CharacterSharedLODBiasValue
        Form1.TextBoxTEXCAT_CharacterSharedFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_CharacterSharedFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_CharacterSharedDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_CharacterSharedDisableStreamingValue
        Form1.ComboBoxTEXCAT_VehicleSharedMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_VehicleSharedMinLODSizeValue
        Form1.ComboBoxTEXCAT_VehicleSharedMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_VehicleSharedMaxLODSizeValue
        Form1.TextBoxTEXCAT_VehicleSharedLODBias.Text = DeclareCompatVarialbes.TEXCAT_VehicleSharedLODBiasValue
        Form1.TextBoxTEXCAT_VehicleSharedFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_VehicleSharedFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_VehicleSharedDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_VehicleSharedDisableStreamingValue
        Form1.ComboBoxTEXCAT_ContactMinLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_ContactMinLODSizeValue
        Form1.ComboBoxTEXCAT_ContactMaxLODSize.SelectedItem = DeclareCompatVarialbes.TEXCAT_ContactMaxLODSizeValue
        Form1.TextBoxTEXCAT_ContactLODBias.Text = DeclareCompatVarialbes.TEXCAT_ContactLODBiasValue
        Form1.TextBoxTEXCAT_ContactFairUsagePriority.Text = DeclareCompatVarialbes.TEXCAT_ContactFairUsagePriorityValue
        Form1.CheckBoxTEXCAT_ContactDisableStreaming.Checked = DeclareCompatVarialbes.TEXCAT_ContactDisableStreamingValue
        Form1.TextBoxnCharacterDiffuseWidth.Text = DeclareCompatVarialbes.nCharacterDiffuseWidthValue
        Form1.TextBoxnCharacterDiffuseHeight.Text = DeclareCompatVarialbes.nCharacterDiffuseHeightValue
        Form1.TextBoxnCharacterNormalMapWidth.Text = DeclareCompatVarialbes.nCharacterNormalMapWidthValue
        Form1.TextBoxnCharacterNormalMapHeight.Text = DeclareCompatVarialbes.nCharacterNormalMapHeightValue
        Form1.TextBoxnVehicleExteriorTextureSize.Text = DeclareCompatVarialbes.nVehicleExteriorTextureSizeValue
        Form1.TextBoxnVehicleExteriorNormalTextureSize.Text = DeclareCompatVarialbes.nVehicleExteriorNormalTextureSizeValue
        Form1.TextBoxnVehicleExteriorEmissiveTextureSize.Text = DeclareCompatVarialbes.nVehicleExteriorEmissiveTextureSizeValue
        Form1.TextBoxnVehicleInteriorTextureSize.Text = DeclareCompatVarialbes.nVehicleInteriorTextureSizeValue
        Form1.TextBoxnVehicleInteriorEmissiveTextureSize.Text = DeclareCompatVarialbes.nVehicleInteriorEmissiveTextureSizeValue
        Form1.TextBoxnVehicleWheelTextureSize.Text = DeclareCompatVarialbes.nVehicleWheelTextureSizeValue
        Form1.TextBoxnVehicleWheelEmissiveTextureSize.Text = DeclareCompatVarialbes.nVehicleWheelEmissiveTextureSizeValue
        Form1.TextBoxnVehicleGlassTextureSize.Text = DeclareCompatVarialbes.nVehicleGlassTextureSizeValue
        Form1.TextBoxfMipBiasDiffuseLocalPlayerCharacterTextures.Text = DeclareCompatVarialbes.fMipBiasDiffuseLocalPlayerCharacterTexturesValue
        Form1.CheckBoxbCompressDiffuseLocalPlayerCharacterTextures.Checked = DeclareCompatVarialbes.bCompressDiffuseLocalPlayerCharacterTexturesValue
        Form1.CheckBoxbCompressDiffuseLocalPlayerVehicleTextures.Checked = DeclareCompatVarialbes.bCompressDiffuseLocalPlayerVehicleTexturesValue
        Form1.CheckBoxbCompressDiffuseOtherPlayerCharacterTextures.Checked = DeclareCompatVarialbes.bCompressDiffuseOtherPlayerCharacterTexturesValue
        Form1.CheckBoxbCompressDiffuseOtherPlayerVehicleTextures.Checked = DeclareCompatVarialbes.bCompressDiffuseOtherPlayerVehicleTexturesValue
        Form1.CheckBoxbCompressNormalTextures.Checked = DeclareCompatVarialbes.bCompressNormalTexturesValue
        Form1.TextBoxnMaxMemoryCacheEntryCount.Text = DeclareCompatVarialbes.nMaxMemoryCacheEntryCountValue
        Form1.TextBoxAudioCompatMode.Text = DeclareCompatVarialbes.AudioCompatModeValue
        Form1.TextBoxMaxMemoryUsedByTextureStreaming.Text = DeclareCompatVarialbes.MaxMemoryUsedByTextureStreamingValue
        Form1.TextBoxMaxMemoryUsedByTexturePool.Text = DeclareCompatVarialbes.MaxMemoryUsedByTexturePoolValue
        Form1.TextBoxMaxMemoryUsedByMeshStreaming.Text = DeclareCompatVarialbes.MaxMemoryUsedByMeshStreamingValue
        Form1.TextBoxNumberOfTextureCreationPerFrame.Text = DeclareCompatVarialbes.NumberOfTextureCreationPerFrameValue
        Form1.TextBoxMaxFreeMemoryUsedByVBPool.Text = DeclareCompatVarialbes.MaxFreeMemoryUsedByVBPoolValue
        Form1.TextBoxMaxFreeMemoryUsedByIBPool.Text = DeclareCompatVarialbes.MaxFreeMemoryUsedByIBPoolValue
        LoadOtherValuesToControls()
        LoadAPBGameValuesToControls()
        LoadInputValuesToControls()
    End Sub
    Public Shared Sub LoadCurrentBucket3ValuesToControls()
        DeclareCompatVarialbes.DeclareCompatVariablesAgainBucket3()
        Form1.TextBoxfMipBiasDiffuseLocalPlayerCharacterTextures.Text = DeclareCompatVarialbes.fMipBiasDiffuseLocalPlayerCharacterTexturesValue
        Form1.CheckBoxbCompressDiffuseLocalPlayerCharacterTextures.Checked = DeclareCompatVarialbes.bCompressDiffuseLocalPlayerCharacterTexturesValue
        Form1.CheckBoxbCompressDiffuseLocalPlayerVehicleTextures.Checked = DeclareCompatVarialbes.bCompressDiffuseLocalPlayerVehicleTexturesValue
        Form1.CheckBoxbCompressDiffuseOtherPlayerCharacterTextures.Checked = DeclareCompatVarialbes.bCompressDiffuseOtherPlayerCharacterTexturesValue
        Form1.CheckBoxbCompressDiffuseOtherPlayerVehicleTextures.Checked = DeclareCompatVarialbes.bCompressDiffuseOtherPlayerVehicleTexturesValue
        Form1.CheckBoxbCompressNormalTextures.Checked = DeclareCompatVarialbes.bCompressNormalTexturesValue
        Form1.TextBoxnMaxMemoryCacheEntryCount.Text = DeclareCompatVarialbes.nMaxMemoryCacheEntryCountValue
        Form1.TextBoxAudioCompatMode.Text = DeclareCompatVarialbes.AudioCompatModeValue
        Form1.TextBoxMaxMemoryUsedByTextureStreaming.Text = DeclareCompatVarialbes.MaxMemoryUsedByTextureStreamingValue
        Form1.TextBoxMaxMemoryUsedByTexturePool.Text = DeclareCompatVarialbes.MaxMemoryUsedByTexturePoolValue
        Form1.TextBoxMaxMemoryUsedByMeshStreaming.Text = DeclareCompatVarialbes.MaxMemoryUsedByMeshStreamingValue
        Form1.TextBoxNumberOfTextureCreationPerFrame.Text = DeclareCompatVarialbes.NumberOfTextureCreationPerFrameValue
        Form1.TextBoxMaxFreeMemoryUsedByVBPool.Text = DeclareCompatVarialbes.MaxFreeMemoryUsedByVBPoolValue
        Form1.TextBoxMaxFreeMemoryUsedByIBPool.Text = DeclareCompatVarialbes.MaxFreeMemoryUsedByIBPoolValue
        LoadOtherValuesToControls()
        LoadAPBGameValuesToControls()
        LoadInputValuesToControls()
    End Sub
    Public Shared Sub LoadOtherValuesToControls()
        DeclareCompatVarialbes.DeclareOtherValuesAgain()
        Form1.TextBoxMinSmoothedFrameRate.Text = DeclareCompatVarialbes.MinSmoothedFrameRateValue
        Form1.TextBoxMaxSmoothedFrameRate.Text = DeclareCompatVarialbes.MaxSmoothedFrameRateValue
        Form1.TextBoxMinDesiredFrameRate.Text = DeclareCompatVarialbes.MinDesiredFrameRateValue
        Form1.TextBoxMaxClientFrameRate.Text = DeclareCompatVarialbes.MaxClientFrameRateValue
    End Sub
    Public Shared Sub LoadAPBGameValuesToControls()
        DeclareCompatVarialbes.APBGameValuesAgain()
        If My.Computer.FileSystem.FileExists(Form1.APBGameSourceFile) Then
            Form1.CheckBoxm_bHideEnvironmentStreamingOnStartup.Checked = DeclareCompatVarialbes.m_bHideEnvironmentStreamingOnStartupValue
            Form1.CheckBoxm_bHideCharacterStreamingOnStartup.Checked = DeclareCompatVarialbes.m_bHideCharacterStreamingOnStartupValue
            Form1.CheckBoxm_bWaitForClosestBuildingLODOnly.Checked = DeclareCompatVarialbes.m_bWaitForClosestBuildingLODOnlyValue
        Else End If
    End Sub
    Public Shared Sub LoadInputValuesToControls()
        DeclareCompatVarialbes.APBInputValuesAgain()
        If My.Computer.FileSystem.FileExists(Form1.APBInputSourceFile) Then
            Select Case DeclareCompatVarialbes.AlwaysSprintValue
                Case """InputSprinting | OnRelease InputStopSprinting"")"
                    Form1.CheckBoxAlwaysSprint.Checked = False
                Case """InputStopSprinting | OnRelease InputSprinting"")"
                    Form1.CheckBoxAlwaysSprint.Checked = True
            End Select
            Select Case DeclareCompatVarialbes.HoldCrouchValue
                Case """Button m_bDuckButton | InputToggleDuck"")"
                    Form1.CheckBoxHoldCrouch.Checked = False
                Case """Button m_bDuckButton | InputToggleDuck | OnRelease InputToggleDuck"")"
                    Form1.CheckBoxHoldCrouch.Checked = True
            End Select
        Else End If
    End Sub
End Class