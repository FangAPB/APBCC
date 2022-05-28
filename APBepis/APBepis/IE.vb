Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Public Class IE
    Public Shared APBCompatExportSourceFile = ""
    Public Shared APBCompatExportFile As New IniFile("")
    Public Shared APBCompatExportSFDialog As New SaveFileDialog
    Public Shared PresetName As String

    Public Shared APBCompatImportSourceFile = ""
    Public Shared APBCompatImportFile As New IniFile("")
    Public Shared APBCompatImportOFDialog As New OpenFileDialog
    Public Shared FRMLBOX As New Form
    Public Shared FRMLBOXListBox As New ListBox
    Public Shared Sub ImportCompatValues()
        APBCompatImportOFDialog.Filter = "INI Files | *.ini"
        APBCompatImportOFDialog.DefaultExt = "ini"
        Select Case APBCompatImportOFDialog.ShowDialog()
            Case DialogResult.OK
                FRMLBOXListBox.Items.Clear()
                APBCompatImportSourceFile = APBCompatImportOFDialog.FileName
                APBCompatImportFile = New IniFile(APBCompatImportSourceFile)
                FRMLBOX.Enabled = True
                FRMLBOX.Show()
                FRMLBOX.MinimumSize = New Size(400, 400)
                FRMLBOX.MaximumSize = FRMLBOX.MinimumSize
                FRMLBOX.Size = FRMLBOX.MinimumSize
                FRMLBOX.MinimizeBox = False
                FRMLBOX.MaximizeBox = False
                With FRMLBOXListBox
                    FRMLBOXListBox.Size = FRMLBOX.MinimumSize
                    FRMLBOXListBox.Location = New Point(0, 0)
                End With

                AddHandler FRMLBOXListBox.Click, AddressOf FRMLBOXListBox_Click
                AddHandler FRMLBOX.FormClosing, AddressOf FRMLBOX_Closing
                FRMLBOX.Controls.Add(FRMLBOXListBox)
                FRMLBOX.Show()

                For Each Line As String In File.ReadLines(APBCompatImportSourceFile)
                    Dim DeReconstructed = System.Text.RegularExpressions.Regex.Match(Line, "\[.*\]").ToString()
                    Dim separators As Char() = New Char() {" "c, "."c}
                    Dim subs As String() = DeReconstructed.Split(separators, StringSplitOptions.RemoveEmptyEntries)

                    For Each substring As String In subs
                        FRMLBOXListBox.Items.Add(substring.Replace("[", "").Replace("]", ""))
                        If substring.Replace("[", "").Replace("]", "") = "AppCompatUpdate" Or substring.Replace("[", "").Replace("]", "") = "AppCompatGPU-0x10DE" Or substring.Replace("[", "").Replace("]", "") = "AppCompatGPU-0x1002" Then
                            FRMLBOXListBox.Items.Remove(substring.Replace("[", "").Replace("]", ""))
                        End If
                    Next
                Next
            Case DialogResult.Cancel
                Form1.Enabled = True
                Form1.Activate()
            Case DialogResult.No
                Form1.Enabled = True
                Form1.Activate()
            Case DialogResult.Abort
                Form1.Enabled = True
                Form1.Activate()
            Case DialogResult.None
                Form1.Enabled = True
                Form1.Activate()
        End Select
    End Sub
    Public Shared Sub FRMLBOXListBox_Click(sender As Object, e As MouseEventArgs)
        FRMLBOXListBox.SelectedIndex = FRMLBOXListBox.IndexFromPoint(e.Location)
        If FRMLBOXListBox.SelectedIndex < 0 Or FRMLBOXListBox.SelectedIndex > FRMLBOXListBox.Items.Count - 1 Then

        Else
            SetControlsToImportedValues()
            FRMLBOXListBox.Items.Clear()
            FRMLBOX.Enabled = False
            FRMLBOX.Hide()
            Form1.Enabled = True
            Form1.Activate()
        End If
    End Sub
    Public Shared Sub ExportCompatValues()
        APBCompatExportSFDialog.Filter = "INI Files | *.ini"
        APBCompatExportSFDialog.DefaultExt = "ini"
        Select Case APBCompatExportSFDialog.ShowDialog()
            Case DialogResult.OK
                APBCompatExportSourceFile = APBCompatExportSFDialog.FileName
                APBCompatExportFile = New IniFile(APBCompatExportSourceFile)
                If My.Computer.FileSystem.FileExists(APBCompatExportSourceFile) Then
                    Dim G = InputBox("", "Name your preset", "")
                    PresetName = G
                    If G = "" Then
                        Form1.Enabled = True
                        Form1.Activate()
                    Else
                        If My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Contains("[" + G + "]") Then
                            Select Case MsgBox("Preset already exists, do you want to overwrite it?", MsgBoxStyle.YesNo, "caption")
                                Case MsgBoxResult.Yes
                                    WriteNewExportCompatValues()
                                Case MsgBoxResult.No
                                    ExportCompatValues()
                            End Select
                        Else
                            WriteNewExportCompatValues()
                        End If
                    End If
                Else
                    Dim G = InputBox("", "Name your preset", "")
                    PresetName = G
                    If G = "" Then
                        Form1.Enabled = True
                        Form1.Activate()
                    Else
                        Dim FSCreateFile As FileStream = File.Create(APBCompatExportSourceFile)
                        FSCreateFile.Close()
                        WriteNewExportCompatValues()
                    End If
                End If
            Case DialogResult.Cancel
                Form1.Enabled = True
                Form1.Activate()
            Case DialogResult.No
                Form1.Enabled = True
                Form1.Activate()
            Case DialogResult.Abort
                Form1.Enabled = True
                Form1.Activate()
            Case DialogResult.None
                Form1.Enabled = True
                Form1.Activate()
        End Select
    End Sub
    Public Shared Sub FRMLBOX_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        e.Cancel = True
        FRMLBOXListBox.Items.Clear()
        FRMLBOX.Enabled = False
        FRMLBOX.Hide()
        Form1.Enabled = True
        Form1.Activate()
    End Sub
    Public Shared Sub WriteNewExportCompatValues()
        APBCompatExportFile.WriteString(PresetName, "StaticDecals", Form1.CheckBoxStaticDecals.Checked)
        APBCompatExportFile.WriteString(PresetName, "DynamicDecals", Form1.CheckBoxDynamicDecals.Checked)
        APBCompatExportFile.WriteString(PresetName, "LevelParticles", Form1.CheckBoxLevelParticles.Checked)
        APBCompatExportFile.WriteString(PresetName, "DynamicLights", Form1.CheckBoxDynamicLights.Checked)
        APBCompatExportFile.WriteString(PresetName, "DynamicShadows", Form1.CheckBoxDynamicShadows.Checked)
        APBCompatExportFile.WriteString(PresetName, "BlobShadows", Form1.CheckBoxBlobShadows.Checked)
        APBCompatExportFile.WriteString(PresetName, "LightEnvironmentShadows", Form1.CheckBoxLightEnvironmentShadows.Checked)
        APBCompatExportFile.WriteString(PresetName, "EnvironmentShadows", Form1.CheckBoxEnvironmentShadows.Checked)
        APBCompatExportFile.WriteString(PresetName, "CompositeDynamicLights", Form1.CheckBoxCompositeDynamicLights.Checked)
        APBCompatExportFile.WriteString(PresetName, "DirectionalLightmaps", Form1.CheckBoxDirectionalLightmaps.Checked)
        APBCompatExportFile.WriteString(PresetName, "MotionBlur", Form1.CheckBoxMotionBlur.Checked)
        APBCompatExportFile.WriteString(PresetName, "DepthOfField", Form1.CheckBoxDepthOfField.Checked)
        APBCompatExportFile.WriteString(PresetName, "AmbientOcclusion", Form1.CheckBoxAmbientOcclusion.Checked)
        APBCompatExportFile.WriteString(PresetName, "Bloom", Form1.CheckBoxBloom.Checked)
        APBCompatExportFile.WriteString(PresetName, "QualityBloom", Form1.CheckBoxQualityBloom.Checked)
        APBCompatExportFile.WriteString(PresetName, "Distortion", Form1.CheckBoxDistortion.Checked)
        APBCompatExportFile.WriteString(PresetName, "DropParticleDistortion", Form1.CheckBoxDropParticleDistortion.Checked)
        APBCompatExportFile.WriteString(PresetName, "SpeedTreeLeaves", Form1.CheckBoxSpeedTreeLeaves.Checked)
        APBCompatExportFile.WriteString(PresetName, "SpeedTreeFronds", Form1.CheckBoxSpeedTreeFronds.Checked)
        APBCompatExportFile.WriteString(PresetName, "OnlyStreamInTextures", Form1.CheckBoxOnlyStreamInTextures.Checked)
        APBCompatExportFile.WriteString(PresetName, "LensFlares", Form1.CheckBoxLensFlares.Checked)
        APBCompatExportFile.WriteString(PresetName, "FogVolumes", Form1.CheckBoxFogVolumes.Checked)
        APBCompatExportFile.WriteString(PresetName, "FloatingPointRenderTargets", Form1.CheckBoxFloatingPointRenderTargets.Checked)
        APBCompatExportFile.WriteString(PresetName, "Trilinear", Form1.CheckBoxTrilinear.Checked)
        APBCompatExportFile.WriteString(PresetName, "OneFrameThreadLag", Form1.CheckBoxOneFrameThreadLag.Checked)
        APBCompatExportFile.WriteString(PresetName, "UseVsync", Form1.CheckBoxUseVsync.Checked)
        APBCompatExportFile.WriteString(PresetName, "UpscaleScreenPercentage", Form1.CheckBoxUpscaleScreenPercentage.Checked)
        APBCompatExportFile.WriteString(PresetName, "Fullscreen", Form1.CheckBoxFullscreen.Checked)
        APBCompatExportFile.WriteString(PresetName, "AllowD3D10", Form1.CheckBoxAllowD3D10.Checked)
        APBCompatExportFile.WriteString(PresetName, "EnableHighPolyChars", Form1.CheckBoxEnableHighPolyChars.Checked)
        APBCompatExportFile.WriteString(PresetName, "SkeletalMeshLODBias", Form1.TextBoxSkeletalMeshLODBias.Text)
        APBCompatExportFile.WriteString(PresetName, "ParticleLODBias", Form1.TextBoxParticleLODBias.Text)
        APBCompatExportFile.WriteString(PresetName, "DetailMode", Form1.TextBoxDetailMode.Text)
        APBCompatExportFile.WriteString(PresetName, "ShadowFilterQualityBias", Form1.TextBoxShadowFilterQualityBias.Text)
        APBCompatExportFile.WriteString(PresetName, "MaxAnisotropy", Form1.TextBoxMaxAnisotropy.Text)
        APBCompatExportFile.WriteString(PresetName, "AnisotropyAmount", Form1.TextBoxAnisotropyAmount.Text)
        APBCompatExportFile.WriteString(PresetName, "MaxMultisamples", Form1.TextBoxMaxMultisamples.Text)
        APBCompatExportFile.WriteString(PresetName, "MSAA_Amount", Form1.TextBoxMSAA_Amount.Text)
        APBCompatExportFile.WriteString(PresetName, "MinShadowResolution", Form1.TextBoxMinShadowResolution.Text)
        APBCompatExportFile.WriteString(PresetName, "MaxShadowResolution", Form1.TextBoxMaxShadowResolution.Text)
        APBCompatExportFile.WriteString(PresetName, "ShadowFadeResolution", Form1.TextBoxShadowFadeResolution.Text)
        APBCompatExportFile.WriteString(PresetName, "ShadowFadeExponent", Form1.TextBoxShadowFadeExponent.Text)
        APBCompatExportFile.WriteString(PresetName, "ShadowFadeStartDistance", Form1.TextBoxShadowFadeStartDistance.Text)
        APBCompatExportFile.WriteString(PresetName, "ShadowFadeEndDistance", Form1.TextBoxShadowFadeEndDistance.Text)
        APBCompatExportFile.WriteString(PresetName, "MaxDynamicShadows", Form1.TextBoxMaxDynamicShadows.Text)
        APBCompatExportFile.WriteString(PresetName, "SunRenderQuality", Form1.TextBoxSunRenderQuality.Text)
        APBCompatExportFile.WriteString(PresetName, "TrueSunMinScreenSize", Form1.TextBoxTrueSunMinScreenSize.Text)
        APBCompatExportFile.WriteString(PresetName, "ParticleMaxWorldSpaceArea", Form1.TextBoxParticleMaxWorldSpaceArea.Text)
        APBCompatExportFile.WriteString(PresetName, "ScreenPercentage", Form1.TextBoxScreenPercentage.Text)
        APBCompatExportFile.WriteString(PresetName, "SceneCaptureStreamingMultiplier", Form1.TextBoxSceneCaptureStreamingMultiplier.Text)
        APBCompatExportFile.WriteString(PresetName, "FoliageDrawRadiusMultiplier", Form1.TextBoxFoliageDrawRadiusMultiplier.Text)
        APBCompatExportFile.WriteString(PresetName, "ShadowTexelsPerPixel", Form1.TextBoxShadowTexelsPerPixel.Text)
        APBCompatExportFile.WriteString(PresetName, "bEnableVSMShadows", Form1.CheckBoxbEnableVSMShadows.Checked)
        APBCompatExportFile.WriteString(PresetName, "bEnableBranchingPCFShadows", Form1.CheckBoxbEnableBranchingPCFShadows.Checked)
        APBCompatExportFile.WriteString(PresetName, "bAllowBetterModulatedShadows", Form1.CheckBoxbAllowBetterModulatedShadows.Checked)
        APBCompatExportFile.WriteString(PresetName, "bEnableForegroundShadowsOnWorld", Form1.CheckBoxbEnableForegroundShadowsOnWorld.Checked)
        APBCompatExportFile.WriteString(PresetName, "ShadowFilterRadius", Form1.TextBoxShadowFilterRadius.Text)
        APBCompatExportFile.WriteString(PresetName, "ShadowDepthBias", Form1.TextBoxShadowDepthBias.Text)
        APBCompatExportFile.WriteString(PresetName, "ShadowVolumeLightRadiusThreshold", Form1.TextBoxShadowVolumeLightRadiusThreshold.Text)
        APBCompatExportFile.WriteString(PresetName, "ShadowVolumePrimitiveScreenSpacePercentageThreshold", Form1.TextBoxShadowVolumePrimitiveScreenSpacePercentageThreshold.Text)
        WriteTEXCAT_Unknown()
        WriteTEXCAT_Environment()
        WriteTEXCAT_Prop()
        WriteTEXCAT_PlayerCharacter()
        WriteTEXCAT_PlayerVehicle()
        WriteTEXCAT_LCPedestrian()
        WriteTEXCAT_LCVehicle()
        WriteTEXCAT_Pickup()
        WriteTEXCAT_CharacterSource()
        WriteTEXCAT_VehicleSource()
        WriteTEXCAT_PrimitiveSource()
        WriteTEXCAT_UI()
        WriteTEXCAT_VFX()
        WriteTEXCAT_LightAndShadowMap()
        WriteTEXCAT_RenderTarget()
        WriteTEXCAT_Signage()
        WriteTEXCAT_PlayerGraffiti()
        WriteTEXCAT_PlayerStatue()
        WriteTEXCAT_CharacterShared()
        WriteTEXCAT_VehicleShared()
        WriteTEXCAT_NonFinal()
        WriteTEXCAT_Contact()
        APBCompatExportFile.WriteString(PresetName, "nNumCharacterLOD", Form1.TextBoxnNumCharacterLOD.Text)
        APBCompatExportFile.WriteString(PresetName, "nCharacterDiffuseWidth", Form1.TextBoxnCharacterDiffuseWidth.Text)
        APBCompatExportFile.WriteString(PresetName, "nCharacterDiffuseHeight", Form1.TextBoxnCharacterDiffuseHeight.Text)
        APBCompatExportFile.WriteString(PresetName, "nCharacterNormalMapWidth", Form1.TextBoxnCharacterNormalMapWidth.Text)
        APBCompatExportFile.WriteString(PresetName, "nCharacterNormalMapHeight", Form1.TextBoxnCharacterNormalMapHeight.Text)
        APBCompatExportFile.WriteString(PresetName, "bCharacterGenerateUVBleedMesh", Form1.CheckBoxbCharacterGenerateUVBleedMesh.Checked)
        APBCompatExportFile.WriteString(PresetName, "m_bGameRenderEyelashes", Form1.CheckBoxm_bGameRenderEyelashes.Checked)
        APBCompatExportFile.WriteString(PresetName, "fCharacterLODDistance1", Form1.TextBoxfCharacterLODDistance1.Text)
        APBCompatExportFile.WriteString(PresetName, "fCharacterLODDistance2", Form1.TextBoxfCharacterLODDistance2.Text)
        APBCompatExportFile.WriteString(PresetName, "fCharacterCullDistance", Form1.TextBoxfCharacterCullDistance.Text)
        APBCompatExportFile.WriteString(PresetName, "bCharacterForceGCAfterBuild", Form1.CheckBoxbCharacterForceGCAfterBuild.Checked)
        APBCompatExportFile.WriteString(PresetName, "nNumVehicleLOD", Form1.TextBoxnNumVehicleLOD.Text)
        APBCompatExportFile.WriteString(PresetName, "nVehicleExteriorTextureSize", Form1.TextBoxnVehicleExteriorTextureSize.Text)
        APBCompatExportFile.WriteString(PresetName, "nVehicleExteriorNormalTextureSize", Form1.TextBoxnVehicleExteriorNormalTextureSize.Text)
        APBCompatExportFile.WriteString(PresetName, "nVehicleExteriorEmissiveTextureSize", Form1.TextBoxnVehicleExteriorEmissiveTextureSize.Text)
        APBCompatExportFile.WriteString(PresetName, "nVehicleInteriorTextureSize", Form1.TextBoxnVehicleInteriorTextureSize.Text)
        APBCompatExportFile.WriteString(PresetName, "nVehicleInteriorEmissiveTextureSize", Form1.TextBoxnVehicleInteriorEmissiveTextureSize.Text)
        APBCompatExportFile.WriteString(PresetName, "nVehicleWheelTextureSize", Form1.TextBoxnVehicleWheelTextureSize.Text)
        APBCompatExportFile.WriteString(PresetName, "nVehicleWheelEmissiveTextureSize", Form1.TextBoxnVehicleWheelEmissiveTextureSize.Text)
        APBCompatExportFile.WriteString(PresetName, "nVehicleGlassTextureSize", Form1.TextBoxnVehicleGlassTextureSize.Text)
        APBCompatExportFile.WriteString(PresetName, "bVehicleGenerateUVBleedMesh", Form1.CheckBoxbVehicleGenerateUVBleedMesh.Checked)
        APBCompatExportFile.WriteString(PresetName, "bVehicleForceGCAfterBuild", Form1.CheckBoxbVehicleForceGCAfterBuild.Checked)
        APBCompatExportFile.WriteString(PresetName, "fVehicleLODDistance", Form1.TextBoxfVehicleLODDistance.Text)
        APBCompatExportFile.WriteString(PresetName, "fVehicleCullDistance", Form1.TextBoxfVehicleCullDistance.Text)
        APBCompatExportFile.WriteString(PresetName, "nGraffitiTextureWidth", Form1.TextBoxnGraffitiTextureWidth.Text)
        APBCompatExportFile.WriteString(PresetName, "nGraffitiTextureHeight", Form1.TextBoxnGraffitiTextureHeight.Text)
        APBCompatExportFile.WriteString(PresetName, "fCAM_MemoryThresholdNormal", Form1.TextBoxfCAM_MemoryThresholdNormal.Text)
        APBCompatExportFile.WriteString(PresetName, "fCAM_MemoryThresholdCritical", Form1.TextBoxfCAM_MemoryThresholdCritical.Text)
        APBCompatExportFile.WriteString(PresetName, "fCAM_MemoryBackToNormalHysteresis", Form1.TextBoxfCAM_MemoryBackToNormalHysteresis.Text)
        APBCompatExportFile.WriteString(PresetName, "fLCPedestrianLODDistance", Form1.TextBoxfLCPedestrianLODDistance.Text)
        APBCompatExportFile.WriteString(PresetName, "fLCPedestrianCullDistance", Form1.TextBoxfLCPedestrianCullDistance.Text)
        APBCompatExportFile.WriteString(PresetName, "fLCDriverLODDistance", Form1.TextBoxfLCDriverLODDistance.Text)
        APBCompatExportFile.WriteString(PresetName, "fLCDriverCullDistance", Form1.TextBoxfLCDriverCullDistance.Text)
        APBCompatExportFile.WriteString(PresetName, "fLCVehicleLODDistance", Form1.TextBoxfLCVehicleLODDistance.Text)
        APBCompatExportFile.WriteString(PresetName, "fLCVehicleCullDistance", Form1.TextBoxfLCVehicleCullDistance.Text)
        APBCompatExportFile.WriteString(PresetName, "nMaxMemoryCacheEntryCount", Form1.TextBoxnMaxMemoryCacheEntryCount.Text)
        APBCompatExportFile.WriteString(PresetName, "MaxLCHairResolution", Form1.TextBoxMaxLCHairResolution.Text)
        APBCompatExportFile.WriteString(PresetName, "MaxLCVehicleTextureSize", Form1.TextBoxMaxLCVehicleTextureSize.Text)
        APBCompatExportFile.WriteString(PresetName, "SpawnMapDelayTime", Form1.TextBoxSpawnMapDelayTime.Text)
        APBCompatExportFile.WriteString(PresetName, "LowQualityHealthHUD", Form1.CheckBoxLowQualityHealthHUD.Checked)
        APBCompatExportFile.WriteString(PresetName, "bUseSimplifiedVehicleMaterials", Form1.CheckBoxbUseSimplifiedVehicleMaterials.Checked)
        APBCompatExportFile.WriteString(PresetName, "SmoothFrameRate", Form1.CheckBoxSmoothFrameRate.Checked)
        Form1.Enabled = True
        Form1.Activate()
    End Sub
    Public Shared Sub RenameTEXCAT_Unknown()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Unknown=(Usage=1", "TEXCAT_Unknown1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_Unknown()
        RenameTEXCAT_Unknown()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Unknown", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_UnknownMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_UnknownMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_UnknownLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_UnknownDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_UnknownFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Unknown1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_UnknownMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_UnknownMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_UnknownLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_UnknownDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_UnknownFairUsagePriority.Text + ")")
        RestoreTEXCAT_Unknown()
    End Sub
    Public Shared Sub RestoreTEXCAT_Unknown()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Unknown1=(Usage=1", "TEXCAT_Unknown=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_Environment()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Environment=(Usage=1", "TEXCAT_Environment1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_Environment()
        RenameTEXCAT_Environment()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Environment", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_EnvironmentMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_EnvironmentMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_EnvironmentLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_EnvironmentDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_EnvironmentFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Environment1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_EnvironmentMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_EnvironmentMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_EnvironmentLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_EnvironmentDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_EnvironmentFairUsagePriority.Text + ")")
        RestoreTEXCAT_Environment()
    End Sub
    Public Shared Sub RestoreTEXCAT_Environment()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Environment1=(Usage=1", "TEXCAT_Environment=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_Prop()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Prop=(Usage=1", "TEXCAT_Prop1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_Prop()
        RenameTEXCAT_Prop()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Prop", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_PropMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PropMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PropLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PropDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PropFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Prop1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_PropMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PropMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PropLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PropDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PropFairUsagePriority.Text + ")")
        RestoreTEXCAT_Prop()
    End Sub
    Public Shared Sub RestoreTEXCAT_Prop()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Prop1=(Usage=1", "TEXCAT_Prop=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_PlayerCharacter()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_PlayerCharacter=(Usage=1", "TEXCAT_PlayerCharacter1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_PlayerCharacter()
        RenameTEXCAT_PlayerCharacter()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_PlayerCharacter", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_PlayerCharacterMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PlayerCharacterMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PlayerCharacterLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PlayerCharacterDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PlayerCharacterFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_PlayerCharacter1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_PlayerCharacterMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PlayerCharacterMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PlayerCharacterLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PlayerCharacterDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PlayerCharacterFairUsagePriority.Text + ")")
        RestoreTEXCAT_PlayerCharacter()
    End Sub
    Public Shared Sub RestoreTEXCAT_PlayerCharacter()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_PlayerCharacter1=(Usage=1", "TEXCAT_PlayerCharacter=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_PlayerVehicle()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_PlayerVehicle=(Usage=1", "TEXCAT_PlayerVehicle1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_PlayerVehicle()
        RenameTEXCAT_PlayerVehicle()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_PlayerVehicle", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_PlayerVehicleMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PlayerVehicleMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PlayerVehicleLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PlayerVehicleDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PlayerVehicleFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_PlayerVehicle1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_PlayerVehicleMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PlayerVehicleMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PlayerVehicleLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PlayerVehicleDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PlayerVehicleFairUsagePriority.Text + ")")
        RestoreTEXCAT_PlayerVehicle()
    End Sub
    Public Shared Sub RestoreTEXCAT_PlayerVehicle()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_PlayerVehicle1=(Usage=1", "TEXCAT_PlayerVehicle=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_LCPedestrian()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_LCPedestrian=(Usage=1", "TEXCAT_LCPedestrian1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_LCPedestrian()
        RenameTEXCAT_LCPedestrian()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_LCPedestrian", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_LCPedestrianMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_LCPedestrianMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_LCPedestrianLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_LCPedestrianDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_LCPedestrianFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_LCPedestrian1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_LCPedestrianMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_LCPedestrianMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_LCPedestrianLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_LCPedestrianDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_LCPedestrianFairUsagePriority.Text + ")")
        RestoreTEXCAT_LCPedestrian()
    End Sub
    Public Shared Sub RestoreTEXCAT_LCPedestrian()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_LCPedestrian1=(Usage=1", "TEXCAT_LCPedestrian=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_LCVehicle()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_LCVehicle=(Usage=1", "TEXCAT_LCVehicle1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_LCVehicle()
        RenameTEXCAT_LCVehicle()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_LCVehicle", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_LCVehicleMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_LCVehicleMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_LCVehicleLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_LCVehicleDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_LCVehicleFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_LCVehicle1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_LCVehicleMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_LCVehicleMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_LCVehicleLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_LCVehicleDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_LCVehicleFairUsagePriority.Text + ")")
        RestoreTEXCAT_LCVehicle()
    End Sub
    Public Shared Sub RestoreTEXCAT_LCVehicle()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_LCVehicle1=(Usage=1", "TEXCAT_LCVehicle=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_Pickup()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Pickup=(Usage=1", "TEXCAT_Pickup1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_Pickup()
        RenameTEXCAT_Pickup()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Pickup", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_PickupMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PickupMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PickupLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PickupDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PickupFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Pickup1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_PickupMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PickupMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PickupLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PickupDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PickupFairUsagePriority.Text + ")")
        RestoreTEXCAT_Pickup()
    End Sub
    Public Shared Sub RestoreTEXCAT_Pickup()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Pickup1=(Usage=1", "TEXCAT_Pickup=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_CharacterSource()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_CharacterSource=(Usage=1", "TEXCAT_CharacterSource1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_CharacterSource()
        RenameTEXCAT_CharacterSource()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_CharacterSource", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_CharacterSourceMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_CharacterSourceMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_CharacterSourceLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_CharacterSourceDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_CharacterSourceFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_CharacterSource1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_CharacterSourceMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_CharacterSourceMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_CharacterSourceLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_CharacterSourceDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_CharacterSourceFairUsagePriority.Text + ")")
        RestoreTEXCAT_CharacterSource()
    End Sub
    Public Shared Sub RestoreTEXCAT_CharacterSource()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_CharacterSource1=(Usage=1", "TEXCAT_CharacterSource=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_VehicleSource()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_VehicleSource=(Usage=1", "TEXCAT_VehicleSource1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_VehicleSource()
        RenameTEXCAT_VehicleSource()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_VehicleSource", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_VehicleSourceMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_VehicleSourceMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_VehicleSourceLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_VehicleSourceDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_VehicleSourceFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_VehicleSource1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_VehicleSourceMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_VehicleSourceMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_VehicleSourceLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_VehicleSourceDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_VehicleSourceFairUsagePriority.Text + ")")
        RestoreTEXCAT_VehicleSource()
    End Sub
    Public Shared Sub RestoreTEXCAT_VehicleSource()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_VehicleSource1=(Usage=1", "TEXCAT_VehicleSource=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_PrimitiveSource()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_PrimitiveSource=(Usage=1", "TEXCAT_PrimitiveSource1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_PrimitiveSource()
        RenameTEXCAT_PrimitiveSource()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_PrimitiveSource", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_PrimitiveSourceMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PrimitiveSourceMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PrimitiveSourceLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PrimitiveSourceDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PrimitiveSourceFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_PrimitiveSource1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_PrimitiveSourceMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PrimitiveSourceMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PrimitiveSourceLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PrimitiveSourceDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PrimitiveSourceFairUsagePriority.Text + ")")
        RestoreTEXCAT_PrimitiveSource()
    End Sub
    Public Shared Sub RestoreTEXCAT_PrimitiveSource()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_PrimitiveSource1=(Usage=1", "TEXCAT_PrimitiveSource=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_UI()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_UI=(Usage=1", "TEXCAT_UI1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_UI()
        RenameTEXCAT_UI()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_UI", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_UIMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_UIMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_UILODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_UIDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_UIFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_UI1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_UIMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_UIMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_UILODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_UIDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_UIFairUsagePriority.Text + ")")
        RestoreTEXCAT_UI()
    End Sub
    Public Shared Sub RestoreTEXCAT_UI()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_UI1=(Usage=1", "TEXCAT_UI=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_VFX()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_VFX=(Usage=1", "TEXCAT_VFX1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_VFX()
        RenameTEXCAT_VFX()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_VFX", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_VFXMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_VFXMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_VFXLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_VFXDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_VFXFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_VFX1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_VFXMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_VFXMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_VFXLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_VFXDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_VFXFairUsagePriority.Text + ")")
        RestoreTEXCAT_VFX()
    End Sub
    Public Shared Sub RestoreTEXCAT_VFX()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_VFX1=(Usage=1", "TEXCAT_VFX=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_LightAndShadowMap()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_LightAndShadowMap=(Usage=1", "TEXCAT_LightAndShadowMap1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_LightAndShadowMap()
        RenameTEXCAT_LightAndShadowMap()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_LightAndShadowMap", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_LightAndShadowMapMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_LightAndShadowMapMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_LightAndShadowMapLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_LightAndShadowMapDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_LightAndShadowMapFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_LightAndShadowMap1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_LightAndShadowMapMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_LightAndShadowMapMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_LightAndShadowMapLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_LightAndShadowMapDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_LightAndShadowMapFairUsagePriority.Text + ")")
        RestoreTEXCAT_LightAndShadowMap()
    End Sub
    Public Shared Sub RestoreTEXCAT_LightAndShadowMap()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_LightAndShadowMap1=(Usage=1", "TEXCAT_LightAndShadowMap=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_RenderTarget()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_RenderTarget=(Usage=1", "TEXCAT_RenderTarget1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_RenderTarget()
        RenameTEXCAT_RenderTarget()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_RenderTarget", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_RenderTargetMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_RenderTargetMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_RenderTargetLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_RenderTargetDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_RenderTargetFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_RenderTarget1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_RenderTargetMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_RenderTargetMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_RenderTargetLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_RenderTargetDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_RenderTargetFairUsagePriority.Text + ")")
        RestoreTEXCAT_RenderTarget()
    End Sub
    Public Shared Sub RestoreTEXCAT_RenderTarget()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_RenderTarget1=(Usage=1", "TEXCAT_RenderTarget=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_Signage()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Signage=(Usage=1", "TEXCAT_Signage1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_Signage()
        RenameTEXCAT_Signage()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Signage", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_SignageMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_SignageMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_SignageLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_SignageDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_SignageFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Signage1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_SignageMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_SignageMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_SignageLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_SignageDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_SignageFairUsagePriority.Text + ")")
        RestoreTEXCAT_Signage()
    End Sub
    Public Shared Sub RestoreTEXCAT_Signage()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Signage1=(Usage=1", "TEXCAT_Signage=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_PlayerGraffiti()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_PlayerGraffiti=(Usage=1", "TEXCAT_PlayerGraffiti1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_PlayerGraffiti()
        RenameTEXCAT_PlayerGraffiti()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_PlayerGraffiti", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_PlayerGraffitiMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PlayerGraffitiMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PlayerGraffitiLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PlayerGraffitiDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PlayerGraffitiFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_PlayerGraffiti1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_PlayerGraffitiMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PlayerGraffitiMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PlayerGraffitiLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PlayerGraffitiDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PlayerGraffitiFairUsagePriority.Text + ")")
        RestoreTEXCAT_PlayerGraffiti()
    End Sub
    Public Shared Sub RestoreTEXCAT_PlayerGraffiti()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_PlayerGraffiti1=(Usage=1", "TEXCAT_PlayerGraffiti=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_PlayerStatue()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_PlayerStatue=(Usage=1", "TEXCAT_PlayerStatue1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_PlayerStatue()
        RenameTEXCAT_PlayerStatue()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_PlayerStatue", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_PlayerStatueMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PlayerStatueMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PlayerStatueLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PlayerStatueDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PlayerStatueFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_PlayerStatue1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_PlayerStatueMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_PlayerStatueMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_PlayerStatueLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_PlayerStatueDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_PlayerStatueFairUsagePriority.Text + ")")
        RestoreTEXCAT_PlayerStatue()
    End Sub
    Public Shared Sub RestoreTEXCAT_PlayerStatue()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_PlayerStatue1=(Usage=1", "TEXCAT_PlayerStatue=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_CharacterShared()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_CharacterShared=(Usage=1", "TEXCAT_CharacterShared1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_CharacterShared()
        RenameTEXCAT_CharacterShared()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_CharacterShared", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_CharacterSharedMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_CharacterSharedMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_CharacterSharedLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_CharacterSharedDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_CharacterSharedFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_CharacterShared1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_CharacterSharedMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_CharacterSharedMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_CharacterSharedLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_CharacterSharedDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_CharacterSharedFairUsagePriority.Text + ")")
        RestoreTEXCAT_CharacterShared()
    End Sub
    Public Shared Sub RestoreTEXCAT_CharacterShared()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_CharacterShared1=(Usage=1", "TEXCAT_CharacterShared=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_VehicleShared()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_VehicleShared=(Usage=1", "TEXCAT_VehicleShared1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_VehicleShared()
        RenameTEXCAT_VehicleShared()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_VehicleShared", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_VehicleSharedMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_VehicleSharedMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_VehicleSharedLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_VehicleSharedDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_VehicleSharedFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_VehicleShared1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_VehicleSharedMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_VehicleSharedMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_VehicleSharedLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_VehicleSharedDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_VehicleSharedFairUsagePriority.Text + ")")
        RestoreTEXCAT_VehicleShared()
    End Sub
    Public Shared Sub RestoreTEXCAT_VehicleShared()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_VehicleShared1=(Usage=1", "TEXCAT_VehicleShared=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_NonFinal()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_NonFinal=(Usage=1", "TEXCAT_NonFinal1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_NonFinal()
        RenameTEXCAT_NonFinal()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_NonFinal", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_NonFinalMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_NonFinalMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_NonFinalLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_NonFinalDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_NonFinalFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_NonFinal1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_NonFinalMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_NonFinalMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_NonFinalLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_NonFinalDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_NonFinalFairUsagePriority.Text + ")")
        RestoreTEXCAT_NonFinal()
    End Sub
    Public Shared Sub RestoreTEXCAT_NonFinal()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_NonFinal1=(Usage=1", "TEXCAT_NonFinal=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub RenameTEXCAT_Contact()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Contact=(Usage=1", "TEXCAT_Contact1=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub WriteTEXCAT_Contact()
        RenameTEXCAT_Contact()
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Contact", "(Usage=0,MinLODSize=" + Form1.ComboBoxTEXCAT_ContactMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_ContactMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_ContactLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_ContactDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_ContactFairUsagePriority.Text + ")")
        APBCompatExportFile.WriteString(PresetName, "TEXCAT_Contact1", "(Usage=1,MinLODSize=" + Form1.ComboBoxTEXCAT_ContactMinLODSize.SelectedItem + ",MaxLODSize=" + Form1.ComboBoxTEXCAT_ContactMaxLODSize.SelectedItem + ",LODBias=" + Form1.TextBoxTEXCAT_ContactLODBias.Text + ",DisableStreaming=" + Form1.CheckBoxTEXCAT_ContactDisableStreaming.Checked.ToString + ",FairUsagePriority=" + Form1.TextBoxTEXCAT_ContactFairUsagePriority.Text + ")")
        RestoreTEXCAT_Contact()
    End Sub
    Public Shared Sub RestoreTEXCAT_Contact()
        My.Computer.FileSystem.WriteAllText(APBCompatExportSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatExportSourceFile).Replace("TEXCAT_Contact1=(Usage=1", "TEXCAT_Contact=(Usage=1"), False, System.Text.Encoding.ASCII)
    End Sub
    Public Shared Sub SetControlsToImportedValues()
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "StaticDecals", "") = Nothing Then
        Else
            Form1.CheckBoxStaticDecals.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "StaticDecals", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DynamicDecals", "") = Nothing Then
        Else
            Form1.CheckBoxDynamicDecals.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DynamicDecals", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "LevelParticles", "") = Nothing Then
        Else
            Form1.CheckBoxLevelParticles.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "LevelParticles", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DynamicLights", "") = Nothing Then
        Else
            Form1.CheckBoxDynamicLights.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DynamicLights", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DynamicShadows", "") = Nothing Then
        Else
            Form1.CheckBoxDynamicShadows.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DynamicShadows", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "BlobShadows", "") = Nothing Then
        Else
            Form1.CheckBoxBlobShadows.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "BlobShadows", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "LightEnvironmentShadows", "") = Nothing Then
        Else
            Form1.CheckBoxLightEnvironmentShadows.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "LightEnvironmentShadows", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "EnvironmentShadows", "") = Nothing Then
        Else
            Form1.CheckBoxEnvironmentShadows.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "EnvironmentShadows", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "CompositeDynamicLights", "") = Nothing Then
        Else
            Form1.CheckBoxCompositeDynamicLights.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "CompositeDynamicLights", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DirectionalLightmaps", "") = Nothing Then
        Else
            Form1.CheckBoxDirectionalLightmaps.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DirectionalLightmaps", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MotionBlur", "") = Nothing Then
        Else
            Form1.CheckBoxMotionBlur.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MotionBlur", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DepthOfField", "") = Nothing Then
        Else
            Form1.CheckBoxDepthOfField.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DepthOfField", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "AmbientOcclusion", "") = Nothing Then
        Else
            Form1.CheckBoxAmbientOcclusion.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "AmbientOcclusion", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "Bloom", "") = Nothing Then
        Else
            Form1.CheckBoxBloom.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "Bloom", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "QualityBloom", "") = Nothing Then
        Else
            Form1.CheckBoxQualityBloom.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "QualityBloom", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "Distortion", "") = Nothing Then
        Else
            Form1.CheckBoxDistortion.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "Distortion", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DropParticleDistortion", "") = Nothing Then
        Else
            Form1.CheckBoxDropParticleDistortion.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DropParticleDistortion", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SpeedTreeLeaves", "") = Nothing Then
        Else
            Form1.CheckBoxSpeedTreeLeaves.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SpeedTreeLeaves", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SpeedTreeFronds", "") = Nothing Then
        Else
            Form1.CheckBoxSpeedTreeFronds.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SpeedTreeFronds", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "OnlyStreamInTextures", "") = Nothing Then
        Else
            Form1.CheckBoxOnlyStreamInTextures.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "OnlyStreamInTextures", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "LensFlares", "") = Nothing Then
        Else
            Form1.CheckBoxLensFlares.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "LensFlares", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "FogVolumes", "") = Nothing Then
        Else
            Form1.CheckBoxFogVolumes.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "FogVolumes", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "FloatingPointRenderTargets", "") = Nothing Then
        Else
            Form1.CheckBoxFloatingPointRenderTargets.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "FloatingPointRenderTargets", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "Trilinear", "") = Nothing Then
        Else
            Form1.CheckBoxTrilinear.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "Trilinear", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "OneFrameThreadLag", "") = Nothing Then
        Else
            Form1.CheckBoxOneFrameThreadLag.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "OneFrameThreadLag", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "UseVsync", "") = Nothing Then
        Else
            Form1.CheckBoxUseVsync.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "UseVsync", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "UpscaleScreenPercentage", "") = Nothing Then
        Else
            Form1.CheckBoxUpscaleScreenPercentage.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "UpscaleScreenPercentage", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "Fullscreen", "") = Nothing Then
        Else
            Form1.CheckBoxFullscreen.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "Fullscreen", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "AllowD3D10", "") = Nothing Then
        Else
            Form1.CheckBoxAllowD3D10.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "AllowD3D10", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "EnableHighPolyChars", "") = Nothing Then
        Else
            Form1.CheckBoxEnableHighPolyChars.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "EnableHighPolyChars", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SkeletalMeshLODBias", "") = Nothing Then
        Else
            Form1.TextBoxSkeletalMeshLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SkeletalMeshLODBias", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ParticleLODBias", "") = Nothing Then
        Else
            Form1.TextBoxParticleLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ParticleLODBias", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DetailMode", "") = Nothing Then
        Else
            Form1.TextBoxDetailMode.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "DetailMode", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFilterQualityBias", "") = Nothing Then
        Else
            Form1.TextBoxShadowFilterQualityBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFilterQualityBias", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxAnisotropy", "") = Nothing Then
        Else
            Form1.TextBoxMaxAnisotropy.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxAnisotropy", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "AnisotropyAmount", "") = Nothing Then
        Else
            Form1.TextBoxAnisotropyAmount.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "AnisotropyAmount", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxMultisamples", "") = Nothing Then
        Else
            Form1.TextBoxMaxMultisamples.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxMultisamples", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MSAA_Amount", "") = Nothing Then
        Else
            Form1.TextBoxMSAA_Amount.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MSAA_Amount", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MinShadowResolution", "") = Nothing Then
        Else
            Form1.TextBoxMinShadowResolution.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MinShadowResolution", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxShadowResolution", "") = Nothing Then
        Else
            Form1.TextBoxMaxShadowResolution.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxShadowResolution", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFadeResolution", "") = Nothing Then
        Else
            Form1.TextBoxShadowFadeResolution.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFadeResolution", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFadeExponent", "") = Nothing Then
        Else
            Form1.TextBoxShadowFadeExponent.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFadeExponent", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFadeStartDistance", "") = Nothing Then
        Else
            Form1.TextBoxShadowFadeStartDistance.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFadeStartDistance", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFadeEndDistance", "") = Nothing Then
        Else
            Form1.TextBoxShadowFadeEndDistance.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFadeEndDistance", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxDynamicShadows", "") = Nothing Then
        Else
            Form1.TextBoxMaxDynamicShadows.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxDynamicShadows", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SunRenderQuality", "") = Nothing Then
        Else
            Form1.TextBoxSunRenderQuality.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SunRenderQuality", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TrueSunMinScreenSize", "") = Nothing Then
        Else
            Form1.TextBoxTrueSunMinScreenSize.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TrueSunMinScreenSize", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ParticleMaxWorldSpaceArea", "") = Nothing Then
        Else
            Form1.TextBoxParticleMaxWorldSpaceArea.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ParticleMaxWorldSpaceArea", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ScreenPercentage", "") = Nothing Then
        Else
            Form1.TextBoxScreenPercentage.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ScreenPercentage", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SceneCaptureStreamingMultiplier", "") = Nothing Then
        Else
            Form1.TextBoxSceneCaptureStreamingMultiplier.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SceneCaptureStreamingMultiplier", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "FoliageDrawRadiusMultiplier", "") = Nothing Then
        Else
            Form1.TextBoxFoliageDrawRadiusMultiplier.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "FoliageDrawRadiusMultiplier", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowTexelsPerPixel", "") = Nothing Then
        Else
            Form1.TextBoxShadowTexelsPerPixel.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowTexelsPerPixel", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bEnableVSMShadows", "") = Nothing Then
        Else
            Form1.CheckBoxbEnableVSMShadows.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bEnableVSMShadows", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bEnableBranchingPCFShadows", "") = Nothing Then
        Else
            Form1.CheckBoxbEnableBranchingPCFShadows.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bEnableBranchingPCFShadows", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bAllowBetterModulatedShadows", "") = Nothing Then
        Else
            Form1.CheckBoxbAllowBetterModulatedShadows.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bAllowBetterModulatedShadows", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bEnableForegroundShadowsOnWorld", "") = Nothing Then
        Else
            Form1.CheckBoxbEnableForegroundShadowsOnWorld.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bEnableForegroundShadowsOnWorld", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFilterRadius", "") = Nothing Then
        Else
            Form1.TextBoxShadowFilterRadius.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowFilterRadius", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowDepthBias", "") = Nothing Then
        Else
            Form1.TextBoxShadowDepthBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowDepthBias", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowVolumeLightRadiusThreshold", "") = Nothing Then
        Else
            Form1.TextBoxShadowVolumeLightRadiusThreshold.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowVolumeLightRadiusThreshold", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowVolumePrimitiveScreenSpacePercentageThreshold", "") = Nothing Then
        Else
            Form1.TextBoxShadowVolumePrimitiveScreenSpacePercentageThreshold.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "ShadowVolumePrimitiveScreenSpacePercentageThreshold", "(none)")
        End If
        '
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Unknown", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_UnknownMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Unknown", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_UnknownMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Unknown", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_UnknownLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Unknown", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_UnknownDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Unknown", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_UnknownFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Unknown", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If

        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Environment", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_EnvironmentMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Environment", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_EnvironmentMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Environment", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_EnvironmentLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Environment", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_EnvironmentDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Environment", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_EnvironmentFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Environment", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Prop", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_PropMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Prop", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_PropMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Prop", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_PropLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Prop", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_PropDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Prop", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_PropFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Prop", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerCharacter", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_PlayerCharacterMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_PlayerCharacterMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_PlayerCharacterLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_PlayerCharacterDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_PlayerCharacterFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerCharacter", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerVehicle", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_PlayerVehicleMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_PlayerVehicleMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_PlayerVehicleLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_PlayerVehicleDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_PlayerVehicleFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerVehicle", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCPedestrian", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_LCPedestrianMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCPedestrian", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_LCPedestrianMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCPedestrian", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_LCPedestrianLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCPedestrian", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_LCPedestrianDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCPedestrian", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_LCPedestrianFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCPedestrian", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCVehicle", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_LCVehicleMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCVehicle", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_LCVehicleMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCVehicle", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_LCVehicleLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCVehicle", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_LCVehicleDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCVehicle", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_LCVehicleFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LCVehicle", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Pickup", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_PickupMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Pickup", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_PickupMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Pickup", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_PickupLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Pickup", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_PickupDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Pickup", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_PickupFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Pickup", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterSource", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_CharacterSourceMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterSource", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_CharacterSourceMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterSource", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_CharacterSourceLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterSource", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_CharacterSourceDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterSource", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_CharacterSourceFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterSource", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleSource", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_VehicleSourceMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleSource", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_VehicleSourceMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleSource", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_VehicleSourceLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleSource", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_VehicleSourceDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleSource", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_VehicleSourceFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleSource", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PrimitiveSource", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_PrimitiveSourceMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_PrimitiveSourceMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_PrimitiveSourceLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_PrimitiveSourceDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_PrimitiveSourceFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PrimitiveSource", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_UI", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_UIMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_UI", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_UIMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_UI", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_UILODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_UI", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_UIDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_UI", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_UIFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_UI", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VFX", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_VFXMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VFX", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_VFXMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VFX", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_VFXLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VFX", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_VFXDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VFX", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_VFXFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VFX", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LightAndShadowMap", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_LightAndShadowMapMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_LightAndShadowMapMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_LightAndShadowMapLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_LightAndShadowMapDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_LightAndShadowMapFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_LightAndShadowMap", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_RenderTarget", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_RenderTargetMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_RenderTarget", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_RenderTargetMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_RenderTarget", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_RenderTargetLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_RenderTarget", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_RenderTargetDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_RenderTarget", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_RenderTargetFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_RenderTarget", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Signage", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_SignageMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Signage", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_SignageMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Signage", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_SignageLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Signage", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_SignageDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Signage", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_SignageFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Signage", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerGraffiti", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_PlayerGraffitiMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_PlayerGraffitiMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_PlayerGraffitiLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_PlayerGraffitiDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_PlayerGraffitiFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerGraffiti", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerStatue", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_PlayerStatueMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerStatue", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_PlayerStatueMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerStatue", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_PlayerStatueLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerStatue", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_PlayerStatueDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerStatue", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_PlayerStatueFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_PlayerStatue", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterShared", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_CharacterSharedMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterShared", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_CharacterSharedMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterShared", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_CharacterSharedLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterShared", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_CharacterSharedDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterShared", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_CharacterSharedFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_CharacterShared", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleShared", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_VehicleSharedMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleShared", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_VehicleSharedMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleShared", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_VehicleSharedLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleShared", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_VehicleSharedDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleShared", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_VehicleSharedFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_VehicleShared", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_NonFinal", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_NonFinalMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_NonFinal", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_NonFinalMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_NonFinal", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_NonFinalLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_NonFinal", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_NonFinalDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_NonFinal", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_NonFinalFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_NonFinal", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Contact", "") = Nothing Then
        Else
            Form1.ComboBoxTEXCAT_ContactMinLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Contact", "(none)").Split(","c)(1).ToString().Replace("MinLODSize=", "")
            Form1.ComboBoxTEXCAT_ContactMaxLODSize.SelectedItem = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Contact", "(none)").Split(","c)(2).ToString().Replace("MaxLODSize=", "")
            Form1.TextBoxTEXCAT_ContactLODBias.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Contact", "(none)").Split(","c)(3).ToString().Replace("LODBias=", "")
            Form1.CheckBoxTEXCAT_ContactDisableStreaming.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Contact", "(none)").Split(","c)(4).ToString().Replace("DisableStreaming=", "")
            Form1.TextBoxTEXCAT_ContactFairUsagePriority.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "TEXCAT_Contact", "(none)").Split(","c)(5).ToString().Replace("FairUsagePriority=", "")
        End If

        '
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nNumCharacterLOD", "") = Nothing Then
        Else
            Form1.TextBoxnNumCharacterLOD.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nNumCharacterLOD", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nCharacterDiffuseWidth", "") = Nothing Then
        Else
            Form1.TextBoxnCharacterDiffuseWidth.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nCharacterDiffuseWidth", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nCharacterDiffuseHeight", "") = Nothing Then
        Else
            Form1.TextBoxnCharacterDiffuseHeight.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nCharacterDiffuseHeight", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nCharacterNormalMapWidth", "") = Nothing Then
        Else
            Form1.TextBoxnCharacterNormalMapWidth.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nCharacterNormalMapWidth", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nCharacterNormalMapHeight", "") = Nothing Then
        Else
            Form1.TextBoxnCharacterNormalMapHeight.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nCharacterNormalMapHeight", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bCharacterGenerateUVBleedMesh", "") = Nothing Then
        Else
            Form1.CheckBoxbCharacterGenerateUVBleedMesh.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bCharacterGenerateUVBleedMesh", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "m_bGameRenderEyelashes", "") = Nothing Then
        Else
            Form1.CheckBoxm_bGameRenderEyelashes.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "m_bGameRenderEyelashes", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCharacterLODDistance1", "") = Nothing Then
        Else
            Form1.TextBoxfCharacterLODDistance1.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCharacterLODDistance1", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCharacterLODDistance2", "") = Nothing Then
        Else
            Form1.TextBoxfCharacterLODDistance2.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCharacterLODDistance2", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCharacterCullDistance", "") = Nothing Then
        Else
            Form1.TextBoxfCharacterCullDistance.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCharacterCullDistance", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bCharacterForceGCAfterBuild", "") = Nothing Then
        Else
            Form1.CheckBoxbCharacterForceGCAfterBuild.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bCharacterForceGCAfterBuild", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nNumVehicleLOD", "") = Nothing Then
        Else
            Form1.TextBoxnNumVehicleLOD.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nNumVehicleLOD", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleExteriorTextureSize", "") = Nothing Then
        Else
            Form1.TextBoxnVehicleExteriorTextureSize.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleExteriorTextureSize", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleExteriorNormalTextureSize", "") = Nothing Then
        Else
            Form1.TextBoxnVehicleExteriorNormalTextureSize.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleExteriorNormalTextureSize", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleExteriorEmissiveTextureSize", "") = Nothing Then
        Else
            Form1.TextBoxnVehicleExteriorEmissiveTextureSize.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleExteriorEmissiveTextureSize", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleInteriorTextureSize", "") = Nothing Then
        Else
            Form1.TextBoxnVehicleInteriorTextureSize.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleInteriorTextureSize", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleInteriorEmissiveTextureSize", "") = Nothing Then
        Else
            Form1.TextBoxnVehicleInteriorEmissiveTextureSize.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleInteriorEmissiveTextureSize", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleWheelTextureSize", "") = Nothing Then
        Else
            Form1.TextBoxnVehicleWheelTextureSize.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleWheelTextureSize", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleWheelEmissiveTextureSize", "") = Nothing Then
        Else
            Form1.TextBoxnVehicleWheelEmissiveTextureSize.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleWheelEmissiveTextureSize", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleGlassTextureSize", "") = Nothing Then
        Else
            Form1.TextBoxnVehicleGlassTextureSize.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nVehicleGlassTextureSize", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bVehicleGenerateUVBleedMesh", "") = Nothing Then
        Else
            Form1.CheckBoxbVehicleGenerateUVBleedMesh.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bVehicleGenerateUVBleedMesh", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bVehicleForceGCAfterBuild", "") = Nothing Then
        Else
            Form1.CheckBoxbVehicleForceGCAfterBuild.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bVehicleForceGCAfterBuild", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fVehicleLODDistance", "") = Nothing Then
        Else
            Form1.TextBoxfVehicleLODDistance.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fVehicleLODDistance", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fVehicleCullDistance", "") = Nothing Then
        Else
            Form1.TextBoxfVehicleCullDistance.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fVehicleCullDistance", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nGraffitiTextureWidth", "") = Nothing Then
        Else
            Form1.TextBoxnGraffitiTextureWidth.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nGraffitiTextureWidth", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nGraffitiTextureHeight", "") = Nothing Then
        Else
            Form1.TextBoxnGraffitiTextureHeight.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nGraffitiTextureHeight", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCAM_MemoryThresholdNormal", "") = Nothing Then
        Else
            Form1.TextBoxfCAM_MemoryThresholdNormal.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCAM_MemoryThresholdNormal", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCAM_MemoryThresholdCritical", "") = Nothing Then
        Else
            Form1.TextBoxfCAM_MemoryThresholdCritical.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCAM_MemoryThresholdCritical", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCAM_MemoryBackToNormalHysteresis", "") = Nothing Then
        Else
            Form1.TextBoxfCAM_MemoryBackToNormalHysteresis.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fCAM_MemoryBackToNormalHysteresis", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCPedestrianLODDistance", "") = Nothing Then
        Else
            Form1.TextBoxfLCPedestrianLODDistance.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCPedestrianLODDistance", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCPedestrianCullDistance", "") = Nothing Then
        Else
            Form1.TextBoxfLCPedestrianCullDistance.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCPedestrianCullDistance", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCDriverLODDistance", "") = Nothing Then
        Else
            Form1.TextBoxfLCDriverLODDistance.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCDriverLODDistance", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCDriverCullDistance", "") = Nothing Then
        Else
            Form1.TextBoxfLCDriverCullDistance.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCDriverCullDistance", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCVehicleLODDistance", "") = Nothing Then
        Else
            Form1.TextBoxfLCVehicleLODDistance.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCVehicleLODDistance", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCVehicleCullDistance", "") = Nothing Then
        Else
            Form1.TextBoxfLCVehicleCullDistance.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fLCVehicleCullDistance", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nMaxMemoryCacheEntryCount", "") = Nothing Then
        Else
            Form1.TextBoxnMaxMemoryCacheEntryCount.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "nMaxMemoryCacheEntryCount", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxLCHairResolution", "") = Nothing Then
        Else
            Form1.TextBoxMaxLCHairResolution.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxLCHairResolution", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxLCVehicleTextureSize", "") = Nothing Then
        Else
            Form1.TextBoxMaxLCVehicleTextureSize.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxLCVehicleTextureSize", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SpawnMapDelayTime", "") = Nothing Then
        Else
            Form1.TextBoxSpawnMapDelayTime.Text = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SpawnMapDelayTime", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "LowQualityHealthHUD", "") = Nothing Then
        Else
            Form1.CheckBoxLowQualityHealthHUD.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "LowQualityHealthHUD", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bUseSimplifiedVehicleMaterials", "") = Nothing Then
        Else
            Form1.CheckBoxbUseSimplifiedVehicleMaterials.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bUseSimplifiedVehicleMaterials", "(none)")
        End If
        If APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SmoothFrameRate", "") = Nothing Then
        Else
            Form1.CheckBoxSmoothFrameRate.Checked = APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "SmoothFrameRate", "(none)")
        End If
        'not sure if these make sense to import/export yet
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "fMipBiasDiffuseLocalPlayerCharacterTextures", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bCompressDiffuseLocalPlayerCharacterTextures", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bCompressDiffuseLocalPlayerVehicleTextures", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bCompressDiffuseOtherPlayerCharacterTextures", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bCompressDiffuseOtherPlayerVehicleTextures", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "bCompressNormalTextures", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "AudioCompatMode", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxMemoryUsedByTextureStreaming", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxMemoryUsedByTexturePool", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxMemoryUsedByMeshStreaming", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "NumberOfTextureCreationPerFrame", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxFreeMemoryUsedByVBPool", "(none)")
        '        APBCompatImportFile.GetString(FRMLBOXListBox.SelectedItem, "MaxFreeMemoryUsedByIBPool", "(none)")
        '   
        '   = Form1.APBEngineAPBCompatImportFile.GetString("Engine.GameEngine", "MinSmoothedFrameRate", "(none)")
        '   = Form1.APBEngineAPBCompatImportFile.GetString("Engine.GameEngine", "MaxSmoothedFrameRate", "(none)")
        '   = Form1.APBEngineAPBCompatImportFile.GetString("Engine.Client", "MinDesiredFrameRate", "(none)")
        '   
        '   = Form1.APBEngineAPBCompatImportFile.GetString("Engine.PhysicsLODVerticalDestructible", "MaxDynamicChunkCount", "(none)")
        '   = Form1.APBEngineAPBCompatImportFile.GetString("Engine.PhysicsLODVerticalDestructible", "DebrisLifetime", "(none)")
        '   = Form1.APBEngineAPBCompatImportFile.GetString("Engine.PhysicsLODVerticalEmitter", "ParticlePercentage", "(none)")

    End Sub
End Class
