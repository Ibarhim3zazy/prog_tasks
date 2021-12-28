Public Class Task10

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.Control Then
            MsgBox("You pressed on control key")
        End If
        If e.Alt Then
            MsgBox("You pressed on Alt key")
        End If
        If e.Shift Then
            MsgBox("You pressed on shift key")
        End If
        If e.KeyCode Then
            MsgBox("You pressed on Data key")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim C As Char
        If System.Char.IsControl(e.KeyChar) Then Exit Sub
        C = e.KeyChar
        TextBox1.SelectedText = System.Char.ToUpper(C)
        e.Handled = True
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Main.Show()
        Me.Hide()
    End Sub
End Class