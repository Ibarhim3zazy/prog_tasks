Public Class task3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MsgBox(TextBox1.Lines(0), , "Line 1 content")
        Catch ex As Exception
            MsgBox("Sorry (-_-)" & vbCrLf & vbCrLf & "Empty content", , "Line 1 content")
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                MsgBox(TextBox1.Lines(0), , "Line 1 content")
            End If
        Catch ex As Exception
            MsgBox("Sorry (-_-)" & vbCrLf & vbCrLf & "Empty content", , "Line 1 content")
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Main.Show()
        Me.Hide()
    End Sub
End Class