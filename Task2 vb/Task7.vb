Public Class Task7

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ob As Object
        Dim i As Integer
        Dim sum As Integer
        Dim avg As Double
        Dim num As Integer
        For i = 1 To Me.Controls.Count - 1
            ob = Me.Controls(i)
            If ob.GetType Is GetType(System.Windows.Forms.TextBox) Then
                If Trim(ob.text) = "" Then
                    ErrorProvider1.SetError(ob, "Please fill this textbox")
                Else
                    ErrorProvider1.SetError(ob, "")
                    If IsNumeric(CType(ob, TextBox).Text) Then
                        sum = sum + CType(ob, TextBox).Text
                    End If
                    num += 1
                End If
            End If
        Next
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" Then
            avg = sum / num
            MsgBox("count of textbox is " & num & vbCrLf & vbCrLf & "avrage of number in textboxs is " & avg)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress
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

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim ob As Object
        Dim i As Integer
        For i = 1 To Me.Controls.Count - 1
            ob = Me.Controls(i)
            If CheckBox1.Checked = True Then
                ob.enabled = False
                CheckBox1.Enabled = True
            ElseIf CheckBox1.Checked = False Then
                ob.enabled = True
            End If
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("https://ibarhim3zazy.github.io/portfolio/")
    End Sub
End Class