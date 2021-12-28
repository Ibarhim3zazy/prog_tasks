Public Class Task11

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Videos files (.mp4 .wmv .avi .mov .flv .3gp)| *.mp4; *.wmv; *.avi; *.mov; *.flv; *.3gp| sound fils (.mp3 .wav .aiff .flac .alac .aac) | *.mp3; *.wav; *.aiff; *.flac; *.alac; *.aac | All Files (*.*) | *.*"
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScreenToolStripMenuItem.Click
        AxWindowsMediaPlayer1.fullScreen = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Main.Show()
        Me.Hide()
    End Sub
End Class