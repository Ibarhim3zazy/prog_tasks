Public Class Task6

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress
        Try
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Sorry (-_-)" & vbCrLf & vbCrLf & "Empty content", , "Line 1 content")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, b1, b2, b3, b4 As Integer
        x = Val(TextBox1.Text)
        b1 = Val(TextBox3.Text)
        y = Val(TextBox2.Text)
        b2 = Val(TextBox4.Text)
        b3 = Val(TextBox5.Text)
        b4 = Val(TextBox6.Text)
        If IsNumeric(x) And IsNumeric(y) And TextBox5.Text = "" Or IsNumeric(x) And IsNumeric(y) And TextBox6.Text = "" Then
            TextBox3.Text = x
            TextBox4.Text = y
            Me.DesktopLocation = New Point(x, y)
        End If
        If IsNumeric(b1) And IsNumeric(b2) And IsNumeric(b3) And IsNumeric(b4) And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            TextBox1.Text = b1
            TextBox2.Text = b2
            Me.DesktopBounds = New Rectangle(b1, b2, b3, b4)
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Main.Show()
        Me.Hide()
    End Sub

    Public Function changecolor()
        Dim R, G, B As Integer
        R = TrackBar1.Value
        G = TrackBar2.Value
        B = TrackBar3.Value
        Me.BackColor = Color.FromArgb(R, G, B)
    End Function

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll, TrackBar2.Scroll, TrackBar3.Scroll
        changecolor()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim R, G, B As Integer
        R = TrackBar1.Value
        G = TrackBar2.Value
        B = TrackBar3.Value
        Main.BackColor = Color.FromArgb(R, G, B)
    End Sub
End Class