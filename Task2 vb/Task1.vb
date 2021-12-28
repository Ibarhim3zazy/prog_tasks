Public Class Task1

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity > 0.5 Then
            Me.Opacity -= 0.05
            Label1.Text = Me.Opacity.ToString()
        Else
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity > 0.49 And Me.Opacity <> 1 Then
            Me.Opacity += 0.05
            Label1.Text = Me.Opacity.ToString()
        Else
            Timer2.Enabled = False
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Main.Show()
        Me.Hide()
    End Sub
End Class