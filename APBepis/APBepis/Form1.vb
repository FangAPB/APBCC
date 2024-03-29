﻿Imports System.IO
Public Class Form1
    Public Shared APBInstallDir = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\APBCompatConfigurator", "APBInstallDirectory", Nothing)
    Public Shared APBCompatSourceFile = APBInstallDir + "\APBGame\Config\APBCompat.ini"
    Public Shared APBCompat As New IniFile(APBCompatSourceFile)
    Public Shared BaseEngineSourceFile = APBInstallDir + "\Engine\Config\BaseEngine.ini"
    Public Shared BaseEngine As New IniFile(BaseEngineSourceFile)
    Public Shared APBEngineSourceFile = APBInstallDir + "\APBGame\Config\APBEngine.ini"
    Public Shared APBEngine As New IniFile(APBEngineSourceFile)
    Public Shared APBCompatSection = "AppCompatBucket1"
    Dim PrevSize As New Size()
    Dim PrevState = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.DoubleBuffered = True
        Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled
        Me.ShowInTaskbar = True
        Form1LoadEvents.CheckAPBDirectoryExists()
        'Updates these variables after a directory is chosen otherwise program will throw an exception
        'Because the APBInstallDir variable on program initialization may be empty or incorrect
        'and the following variables depend on APBInstallDir being proper, hence why all 3 need to be refreshed
        APBInstallDir = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\APBCompatConfigurator", "APBInstallDirectory", Nothing)
        APBCompatSourceFile = APBInstallDir + "\APBGame\Config\APBCompat.ini"
        APBCompat = New IniFile(APBCompatSourceFile)
        Form1LoadEvents.UnCommentSmoothFrameRates()
        CurrentValueLabels.SetCurrentValueLabels()
        CurrentValues.LoadCurrentValuesToControls()
        ComboBoxAPBCompatSection.SelectedItem = "AppCompatBucket1"
        Me.Text = "APB Compat Configurator " + Me.GetType.Assembly.GetName.Version.ToString()
        Me.AutoScroll = True
        For Each FormControl As Control In Me.Controls
            If TypeOf FormControl Is Control Then
                AddHandler FormControl.GotFocus, AddressOf ControlFocus
            End If
        Next
        For Each TBoxTC As TextBox In Me.Controls.OfType(Of TextBox)()
            AddHandler TBoxTC.TextChanged, AddressOf TextBox_TextChanged
        Next
        For Each TBoxKP As TextBox In Me.Controls.OfType(Of TextBox)()
            AddHandler TBoxKP.KeyPress, AddressOf TextBox_KeyPress
        Next
        For Each CBOBox As ComboBox In Me.Controls.OfType(Of ComboBox)()
            AddHandler CBOBox.MouseWheel, AddressOf ComboBox_MouseWheel
        Next
        FixScuff()
        Form1LoadEvents.Form1LoadTextboxSizesAndFilter()
        'Me.MinimumSize = New Size(654, 397)
        ButtonImport.BackgroundImage = My.Resources.ResourceManager.GetObject("ImportButton") 'Image.FromFile("C:\Users\Administrator\Desktop\ImportButton.tiff")
        ButtonExport.BackgroundImage = My.Resources.ResourceManager.GetObject("ExportButton") 'Image.FromFile("C:\Users\Administrator\Desktop\ExportButton.tiff")
    End Sub
    Private Sub Form1_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        Me.Refresh()
    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Const WM_SYSCOMMAND As Int32 = &H112
        Const SC_MINIMIZE As Int32 = &HF020
        Const SC_RESTORE As Int32 = &HF120
        Const SC_MAXIMIZE As Int32 = &HF030

        If m.Msg = WM_SYSCOMMAND Then
            If m.WParam.ToInt32 = SC_MINIMIZE Then
                If Me.WindowState = FormWindowState.Maximized Then
                    PrevState = "Max"
                    Me.WindowState = FormWindowState.Minimized
                Else
                    PrevSize = New Size(Me.Size)
                    Me.WindowState = FormWindowState.Minimized
                End If
            ElseIf m.WParam.ToInt32 = SC_MAXIMIZE Then
                PrevSize = Me.Size
                Me.WindowState = FormWindowState.Maximized
            ElseIf m.WParam.ToInt32 = SC_RESTORE Then
                If PrevState = "Max" Then
                    Me.WindowState = FormWindowState.Maximized
                    PrevState = ""
                Else
                    Me.WindowState = FormWindowState.Normal
                    Me.Size = New Size(PrevSize)
                End If
            Else
                MyBase.WndProc(m)
            End If
        Else
            MyBase.WndProc(m)
        End If
    End Sub
    Private Sub CheckAPBCompatSourceFileExists()
        If My.Computer.FileSystem.FileExists(APBCompatSourceFile) Then
            My.Computer.FileSystem.WriteAllText(APBCompatSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatSourceFile).Replace(" =", "="), False, System.Text.Encoding.ASCII)
            My.Computer.FileSystem.WriteAllText(APBCompatSourceFile, My.Computer.FileSystem.ReadAllText(APBCompatSourceFile).Replace("= ", "="), False, System.Text.Encoding.ASCII)
        Else
            Form1LoadEvents.CheckAPBDirectoryExists()
            MsgBox("Could not locate APBCompat.ini" & vbNewLine & "Please place APBCompat.ini back in it's original location" & vbNewLine & "Or repair APB through the official launcher")
        End If
    End Sub
    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click
        Select Case (ComboBoxAPBCompatSection.SelectedItem)
            Case "AppCompatBucket1"
                WriteNewCompatValues.WriteNewCompatValuesToCompat()
                CurrentValueLabels.SetCurrentValueLabels()
            Case "AppCompatBucket2"
                WriteNewCompatValues.WriteNewCompatValuesToCompat()
                CurrentValueLabels.SetCurrentValueLabels()
            Case "AppCompatBucket3"
                WriteNewCompatValues.WriteNewCompatValuesToCompat()
                CurrentValueLabels.SetCurrentValueLabels()
            Case "AppCompatBucket4"
                WriteNewCompatValues.WriteNewCompatValuesToCompat()
                CurrentValueLabels.SetCurrentValueLabels()
            Case "AppCompatBucket5"
                WriteNewCompatValues.WriteNewCompatValuesToCompat()
                CurrentValueLabels.SetCurrentValueLabels()
            Case "AppHWConstraintsBucket1"
                WriteNewCompatValues.WriteNewBucket1and2CompatValuesToCompat()
                CurrentValueLabels.SetCurrentBucket1and2ValueLabels()
            Case "AppHWConstraintsBucket2"
                WriteNewCompatValues.WriteNewBucket1and2CompatValuesToCompat()
                CurrentValueLabels.SetCurrentBucket1and2ValueLabels()
            Case "AppHWConstraintsBucket3"
                WriteNewCompatValues.WriteNewBucket3CompatValuesToCompat()
                CurrentValueLabels.SetCurrentBucket3ValueLabels()
        End Select
        TextBoxValuesMatch()
        ComboBoxValuesMatch()
        CheckBoxValuesMatch()
    End Sub
    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
        Me.Enabled = False
        Select Case (ComboBoxAPBCompatSection.SelectedItem)
            Case "AppCompatBucket1"
                IE.ImportCompatValues()
            Case "AppCompatBucket2"
                IE.ImportCompatValues()
            Case "AppCompatBucket3"
                IE.ImportCompatValues()
            Case "AppCompatBucket4"
                IE.ImportCompatValues()
            Case "AppCompatBucket5"
                IE.ImportCompatValues()
            Case Else
                MsgBox("Currently exporting non CompatBucket (Graphics settings presets Minimum High etc) isn't supported")
        End Select
    End Sub
    Private Sub ButtonExport_Click(sender As Object, e As EventArgs) Handles ButtonExport.Click
        Me.Enabled = False
        IE.ExportCompatValues()
    End Sub
    Private Sub ComboBoxAPBCompatSection_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxAPBCompatSection.SelectedValueChanged
        Select Case (ComboBoxAPBCompatSection.SelectedItem)
            Case "AppCompatBucket1"
                LabelInGame.Text = "In Game:"
                LabelAPBCompatSection.Text = "Minimal"
                APBCompatSection = "AppCompatBucket1"
                EnableControls()
                EnableSharedControlsBucket()
                CurrentValueLabels.SetCurrentValueLabels()
                CurrentValues.LoadCurrentValuesToControls()
                EnableControlConstraintsAlwaysActive()
                LabelWeDontTalkAboutThisOne.Visible = False
            Case "AppCompatBucket2"
                LabelInGame.Text = "In Game:"
                LabelAPBCompatSection.Text = "Low"
                APBCompatSection = "AppCompatBucket2"
                EnableControls()
                EnableSharedControlsBucket()
                CurrentValueLabels.SetCurrentValueLabels()
                CurrentValues.LoadCurrentValuesToControls()
                EnableControlConstraintsAlwaysActive()
                LabelWeDontTalkAboutThisOne.Visible = False
            Case "AppCompatBucket3"
                LabelInGame.Text = "In Game:"
                LabelAPBCompatSection.Text = "Medium"
                APBCompatSection = "AppCompatBucket3"
                If Form1.APBCompat.GetString("AppCompatBucket3", "bUseSimplifiedVehicleMaterials", "") = "" Then
                    Form1.APBCompat.WriteString("AppCompatBucket3", "bUseSimplifiedVehicleMaterials", "False")
                End If
                EnableControls()
                EnableSharedControlsBucket()
                CurrentValueLabels.SetCurrentValueLabels()
                CurrentValues.LoadCurrentValuesToControls()
                EnableControlConstraintsAlwaysActive()
                LabelWeDontTalkAboutThisOne.Visible = False
            Case "AppCompatBucket4"
                LabelInGame.Text = "In Game:"
                LabelAPBCompatSection.Text = "High"
                APBCompatSection = "AppCompatBucket4"
                If Form1.APBCompat.GetString("AppCompatBucket4", "bUseSimplifiedVehicleMaterials", "") = "" Then
                    Form1.APBCompat.WriteString("AppCompatBucket4", "bUseSimplifiedVehicleMaterials", "False")
                End If
                EnableControls()
                EnableSharedControlsBucket()
                CurrentValueLabels.SetCurrentValueLabels()
                CurrentValues.LoadCurrentValuesToControls()
                EnableControlConstraintsAlwaysActive()
                LabelWeDontTalkAboutThisOne.Visible = False
            Case "AppCompatBucket5"
                LabelInGame.Text = "In Game:"
                LabelAPBCompatSection.Text = "Maximum"
                APBCompatSection = "AppCompatBucket5"
                If Form1.APBCompat.GetString("AppCompatBucket5", "bUseSimplifiedVehicleMaterials", "") = "" Then
                    Form1.APBCompat.WriteString("AppCompatBucket5", "bUseSimplifiedVehicleMaterials", "False")
                End If
                EnableControls()
                EnableSharedControlsBucket()
                EnableControlConstraintsAlwaysActive()
                CurrentValueLabels.SetCurrentValueLabels()
                CurrentValues.LoadCurrentValuesToControls()
                LabelWeDontTalkAboutThisOne.Visible = False
            Case "AppHWConstraintsBucket1"
                LabelInGame.Text = ""
                LabelAPBCompatSection.Text = ""
                APBCompatSection = "AppHWConstraintsBucket1"
                DisableControls()
                EnableControlConstraintsAlwaysActive()
                CurrentValueLabels.SetCurrentBucket1and2ValueLabels()
                CurrentValues.LoadCurrentBucket1and2ValuesToControls()
                EnableSharedControlsBucket()
                LabelWeDontTalkAboutThisOne.Visible = False
            Case "AppHWConstraintsBucket2"
                LabelInGame.Text = ""
                LabelAPBCompatSection.Text = ""
                APBCompatSection = "AppHWConstraintsBucket2"
                DisableControls()
                EnableControlConstraintsAlwaysActive()
                CurrentValueLabels.SetCurrentBucket1and2ValueLabels()
                CurrentValues.LoadCurrentBucket1and2ValuesToControls()
                EnableSharedControlsBucket()
                LabelWeDontTalkAboutThisOne.Visible = False
            Case "AppHWConstraintsBucket3"
                LabelInGame.Text = ""
                LabelAPBCompatSection.Text = ""
                APBCompatSection = "AppHWConstraintsBucket3"
                DisableControlsBucket3()
                EnableControlConstraintsAlwaysActive()
                CurrentValueLabels.SetCurrentBucket3ValueLabels()
                CurrentValues.LoadCurrentBucket3ValuesToControls()
                LabelWeDontTalkAboutThisOne.Visible = False
        End Select
        TextBoxValuesMatch()
        ComboBoxValuesMatch()
        CheckBoxValuesMatch()
    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)
        Dim TBoxTC As TextBox = DirectCast(sender, TextBox)
        If TBoxTC.Name.Contains("TEXCAT") Then
            TBoxTC.MaximumSize = New Size(50, 20)
            TBoxTC.MinimumSize = New Size(30, 20)
            TBoxTC.MaxLength = 6
        Else
            TBoxTC.MaximumSize = New Size(100, 20)
            TBoxTC.MinimumSize = New Size(30, 20)
            TBoxTC.MaxLength = 14
        End If

        Dim TBoxTCL As String = TBoxTC.Text
        TBoxTC.Width = TBoxTCL.Length.ToString * 9
        Dim CharWList As String = "-.1234567890"
        Dim TText As String = TBoxTC.Text
        Dim WLChar As String
        Dim SelectionIndex As Integer = TBoxTC.SelectionStart
        Dim RemoveChar As Integer

        For x As Integer = 0 To TBoxTC.Text.Length - 1
            WLChar = TBoxTC.Text.Substring(x, 1)
            If CharWList.Contains(WLChar) = False Then
                TText = TText.Replace(WLChar, String.Empty)
                RemoveChar = 1
            End If
        Next

        TBoxTC.Text = TText
        Try
            TBoxTC.Select(SelectionIndex - RemoveChar, 0)
        Catch NewEx As Exception
        End Try
    End Sub
    Private Sub ComboBox_MouseWheel(sender As Object, e As EventArgs)
        Dim CBOBox As ComboBox = DirectCast(sender, ComboBox)
        Dim CBOBoxMouseWheel As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        CBOBoxMouseWheel.Handled = True
    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim TBoxKP As TextBox = DirectCast(sender, TextBox)
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim NegativeSign As String = Application.CurrentCulture.NumberFormat.NegativeSign
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1) Or (e.KeyChar = NegativeSign And sender.Text.IndexOf(NegativeSign) = -1))
    End Sub
    Private Sub ControlFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        For Each FormControl As Control In Me.Controls
            If TypeOf FormControl Is ComboBox Then
                FormControl.BackColor = SystemColors.Window
                FormControl.ForeColor = SystemColors.WindowText
            ElseIf TypeOf FormControl Is TextBox Then
                FormControl.BackColor = SystemColors.Window
                FormControl.ForeColor = SystemColors.WindowText
            ElseIf TypeOf FormControl Is CheckBox Then
                FormControl.BackColor = Color.Transparent
                FormControl.ForeColor = SystemColors.WindowText
            ElseIf TypeOf FormControl Is Button Then
                FormControl.BackColor = SystemColors.InactiveBorder
                FormControl.ForeColor = SystemColors.WindowText
            ElseIf TypeOf FormControl Is Label Then
                FormControl.BackColor = Color.Transparent
            End If
        Next
        TextBoxValuesMatch()
        ComboBoxValuesMatch()
        CheckBoxValuesMatch()

        If CType(sender, Control).Focused = True Then
            CType(sender, Control).BackColor = SystemColors.ActiveCaption 'SystemColors.HotTrack
            CType(sender, Control).ForeColor = SystemColors.WindowText 'SystemColors.Window
        End If
    End Sub
    Private Sub LabelShadowVolumePrimitiveScreenSpacePercentageThreshold_Hover(sender As Object, e As EventArgs) Handles LabelShadowVolumePrimitiveScreenSpacePercentageThreshold.MouseHover
        LabelWeDontTalkAboutThisOne.Visible = True
    End Sub
    Private Sub Form1_MouseMove(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        LabelWeDontTalkAboutThisOne.Visible = False
    End Sub
    Public Shared Sub FixScuff()
        My.Computer.FileSystem.WriteAllText(Form1.APBCompatSourceFile, My.Computer.FileSystem.ReadAllText(Form1.APBCompatSourceFile).Replace("TRUE", "True"), False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText(Form1.APBCompatSourceFile, My.Computer.FileSystem.ReadAllText(Form1.APBCompatSourceFile).Replace("true", "True"), False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText(Form1.APBCompatSourceFile, My.Computer.FileSystem.ReadAllText(Form1.APBCompatSourceFile).Replace("FALSE", "False"), False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText(Form1.APBCompatSourceFile, My.Computer.FileSystem.ReadAllText(Form1.APBCompatSourceFile).Replace("false", "False"), False, System.Text.Encoding.ASCII)
        For Each Line In APBCompatSourceFile
            Dim Lines As List(Of String) = System.IO.File.ReadAllLines(APBCompatSourceFile).ToList
            Lines.Remove(" ")
            System.IO.File.WriteAllLines(APBCompatSourceFile, Lines)
        Next
        My.Computer.FileSystem.WriteAllText(Form1.APBCompatSourceFile, My.Computer.FileSystem.ReadAllText(Form1.APBCompatSourceFile).Replace("	", ""), False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText(Form1.APBCompatSourceFile, My.Computer.FileSystem.ReadAllText(Form1.APBCompatSourceFile).Replace("  ", ""), False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText(Form1.APBCompatSourceFile, My.Computer.FileSystem.ReadAllText(Form1.APBCompatSourceFile).Replace(" =", "="), False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText(Form1.APBCompatSourceFile, My.Computer.FileSystem.ReadAllText(Form1.APBCompatSourceFile).Replace("= ", "="), False, System.Text.Encoding.ASCII)
        File.WriteAllLines(APBCompatSourceFile, File.ReadAllLines(APBCompatSourceFile).Where(Function(s) s <> String.Empty))
    End Sub
    Private Sub EnableControls()
        For Each FormControl As Control In Me.Controls
            If TypeOf FormControl Is Control Then
                If DeclareCompatVarialbes.ControlConstraintsBucket1and2.Contains(FormControl) Then
                    FormControl.Enabled = False
                    FormControl.Visible = True
                    ButtonApply.Enabled = True
                    ComboBoxAPBCompatSection.Enabled = True
                Else
                    FormControl.Enabled = True
                    FormControl.Visible = True
                    ButtonApply.Enabled = True
                    ComboBoxAPBCompatSection.Enabled = True
                End If
            End If
        Next
    End Sub
    Private Sub DisableControls()
        For Each FormControl As Control In Me.Controls
            If TypeOf FormControl Is Control Then
                If DeclareCompatVarialbes.ControlConstraintsBucket1and2.Contains(FormControl) Then
                    FormControl.Enabled = True
                    FormControl.Visible = True
                    ButtonApply.Enabled = True
                    ComboBoxAPBCompatSection.Enabled = True
                Else
                    FormControl.Enabled = False
                    FormControl.Visible = True
                    ButtonApply.Enabled = True
                    ComboBoxAPBCompatSection.Enabled = True
                End If
            End If
        Next
    End Sub
    Private Sub DisableControlsBucket3()
        For Each FormControl As Control In Me.Controls
            If TypeOf FormControl Is Control Then
                If DeclareCompatVarialbes.ControlConstraintsBucket3.Contains(FormControl) Then
                    FormControl.Enabled = True
                    FormControl.Visible = True
                    ButtonApply.Enabled = True
                    ComboBoxAPBCompatSection.Enabled = True
                Else
                    FormControl.Enabled = False
                    FormControl.Visible = True
                    ButtonApply.Enabled = True
                    ComboBoxAPBCompatSection.Enabled = True
                End If
            End If
        Next
    End Sub
    Private Sub EnableSharedControlsBucket()
        For Each FormControl As Control In Me.Controls
            If TypeOf FormControl Is Control Then
                If DeclareCompatVarialbes.ControlConstraintsBucketShared.Contains(FormControl) Then
                    FormControl.Enabled = True
                    FormControl.Visible = True
                    ButtonApply.Enabled = True
                    ComboBoxAPBCompatSection.Enabled = True
                End If
            End If
        Next
    End Sub
    Private Sub EnableControlConstraintsAlwaysActive()
        For Each FormControl As Control In Me.Controls
            If TypeOf FormControl Is Control Then
                If DeclareCompatVarialbes.ControlConstraintsAlwaysActive.Contains(FormControl) Then
                    FormControl.Enabled = True
                    FormControl.Visible = True
                    ButtonApply.Enabled = True
                    ComboBoxAPBCompatSection.Enabled = True
                End If
            End If
        Next
    End Sub
    Public Shared Sub TextBoxValuesMatch()
        For Each FormLabel As Label In Form1.Controls.OfType(Of Label)()
            For Each FormTextBox As TextBox In Form1.Controls.OfType(Of TextBox)()
                Dim FormTextBoxNameFirstFormat = (FormTextBox.Name.ToString.Replace("TextBox", "Label"))
                Dim FormTextBoxNameFinalFormat = (FormTextBoxNameFirstFormat + "Current2")
                If FormTextBoxNameFinalFormat = FormLabel.Name.ToString Then
                    If FormLabel.Text.ToString = FormTextBox.Text.ToString Then
                        FormLabel.BackColor = Color.FromArgb(233, 255, 233)
                        FormTextBox.BackColor = Color.FromArgb(233, 255, 233)
                    Else
                        FormLabel.BackColor = Color.Transparent
                    End If
                End If
            Next
        Next
    End Sub
    Public Shared Sub ComboBoxValuesMatch()
        For Each FormLabel As Label In Form1.Controls.OfType(Of Label)()
            For Each FormComboBox As ComboBox In Form1.Controls.OfType(Of ComboBox)()
                Dim FormComboBoxNameFirstFormat = (FormComboBox.Name.ToString.Replace("ComboBox", "Label"))
                Dim FormComboBoxNameFinalFormat = (FormComboBoxNameFirstFormat + "Current2")
                If FormComboBoxNameFinalFormat = FormLabel.Name.ToString Then
                    If FormLabel.Text.ToString = FormComboBox.Text.ToString Then
                        FormLabel.BackColor = Color.FromArgb(233, 255, 233)
                        FormComboBox.BackColor = Color.FromArgb(233, 255, 233)
                    Else
                        FormLabel.BackColor = Color.Transparent
                    End If
                End If
            Next
        Next
    End Sub
    Public Shared Sub CheckBoxValuesMatch()
        For Each FormLabel As Label In Form1.Controls.OfType(Of Label)()
            For Each FormCheckBox As CheckBox In Form1.Controls.OfType(Of CheckBox)()
                Dim FormCheckBoxNameFirstFormat = (FormCheckBox.Name.ToString.Replace("CheckBox", "Label"))
                Dim FormCheckBoxNameFinalFormat = (FormCheckBoxNameFirstFormat + "Current2")
                If FormCheckBoxNameFinalFormat = FormLabel.Name.ToString Then
                    If FormLabel.Text.ToString = FormCheckBox.Checked.ToString Then
                        FormLabel.BackColor = Color.FromArgb(233, 255, 233)
                        FormCheckBox.BackColor = Color.FromArgb(233, 255, 233)
                    Else
                        FormLabel.BackColor = Color.Transparent
                    End If
                End If
            Next
        Next
    End Sub
End Class