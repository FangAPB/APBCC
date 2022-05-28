Public Class Form1LoadEvents
    Public Shared Sub CheckAPBDirectoryExists()
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\APBCompatConfigurator", "APBInstallDirectory", Nothing) Is Nothing Then
            MsgBox("Please select your APB Reloaded folder")
            SetAPBInstallPath()
        ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\APBCompatConfigurator", "APBInstallDirectory", Nothing).ToString.Length < "2" Then
            MsgBox("Paths of less than 2 characters are not supported." & vbNewLine & "The bare minimum is C: (or the corresponding letter of your home drive)" & vbNewLine & "Please select your APB Reloaded folder")
            SetAPBInstallPath()
        End If
        If Not My.Computer.FileSystem.FileExists(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\APBCompatConfigurator", "APBInstallDirectory", Nothing) + "\Binaries\APB.exe") Then
            Console.WriteLine("APB.exe not present")
            MsgBox("Please select your APB Reloaded folder")
            SetAPBInstallPath()
        End If
    End Sub
    Public Shared Sub SetAPBInstallPath()
        If Form1.APBDirectoryFolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Form1.Close()
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\APBCompatConfigurator", "APBInstallDirectory", Form1.APBDirectoryFolderBrowserDialog.SelectedPath)
            CheckAPBDirectoryExists()
        End If
    End Sub
    Public Shared Sub Form1LoadTextboxSizesAndFilter()
        For Each TBoxTC As TextBox In Form1.Controls.OfType(Of TextBox)()

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
        Next
    End Sub
    Public Shared Sub UnCommentSmoothFrameRates()
        My.Computer.FileSystem.WriteAllText(Form1.APBEngineSourceFile, My.Computer.FileSystem.ReadAllText(Form1.APBEngineSourceFile).Replace(";MinSmoothedFrameRate", "MinSmoothedFrameRate"), False, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllText(Form1.APBEngineSourceFile, My.Computer.FileSystem.ReadAllText(Form1.APBEngineSourceFile).Replace(";MaxSmoothedFrameRate", "MaxSmoothedFrameRate"), False, System.Text.Encoding.ASCII)
    End Sub
End Class