Imports System.Text.RegularExpressions

Public Class FileMover

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CnlButton.Click
        Close()
    End Sub


    Private Sub FromBrwoseButton_Click(sender As Object, e As EventArgs) Handles FromBrwoseButton.Click
        If FromOFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim ExcCmd As String = Regex.Replace(FromOFD.FileName, "\\\w+_.*?_", "\*")
            ExcCmd = Regex.Replace(ExcCmd, "\\", "/")
            ExcCmd = Regex.Replace(ExcCmd, ".*/US Jobs", "/Spider/Main/BotLibrary/US_Jobs")
            FromTB.Text = ExcCmd
        End If

    End Sub

    Private Sub ToBrowseButton_Click(sender As Object, e As EventArgs) Handles ToBrowseButton.Click
        ToFBD.SelectedPath = ToTB.Text
        If ToFBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim ExcPath As String = Regex.Replace(ToFBD.SelectedPath, "\\", "/")
            ToTB.Text = ExcPath
        End If
    End Sub


    Private Sub MoveButton_Click(sender As Object, e As EventArgs) Handles MoveButton.Click
        MessageBox.Show("tfs.exe /k rename ""$" + FromTB.Text + """ ""$" + ToTB.Text + """")
        'Process.Start("cmd.exe", "tfs.exe /k rename ""$" + FromTB.Text + """ ""$" + ToTB.Text + """")
    End Sub
End Class
