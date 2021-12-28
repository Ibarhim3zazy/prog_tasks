Public Class Task4
    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim op As String
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button16.Click, Button1.Click
        Dim b As Button = sender
        If Label1.Text = "0" Then
            Label1.Text = b.Text
        Else
            Label1.Text = Label1.Text + b.Text
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Label1.Text = "0"
        Label2.Text = ""
    End Sub

    Private Sub arithmatic_faunctions(sender As Object, e As EventArgs) Handles Button12.Click, Button11.Click, Button23.Click, Button20.Click, Button14.Click, Button13.Click
        Dim ops As Button = sender
        Try
            f = Label1.Text
            Label2.Text = Label1.Text
            Label1.Text = ""
            op = ops.Text
            Label2.Text = Label2.Text + " " + op
        Catch ex As Exception
            Label1.Text = ""
            Label2.Text = ""
            MsgBox("We are sorry Please try again", , "Erorr")
        End Try
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Try
            s = Label1.Text
            If op = "+" Then
                a = f + s
                Label1.Text = a
                Label2.Text = ""
            ElseIf op = "-" Then
                a = f - s
                Label1.Text = a
                Label2.Text = ""
            ElseIf op = "x" Then
                a = f * s
                Label1.Text = a
                Label2.Text = ""
            ElseIf op = "÷" Then
                a = f / s
                Label1.Text = a
                Label2.Text = ""
            ElseIf op = "mod" Then
                a = f Mod s
                Label1.Text = a
                Label2.Text = ""
            ElseIf op = "exp" Then
                a = f ^ s
                Label1.Text = a
                Label2.Text = ""
            End If
        Catch ex As Exception
            Label1.Text = ""
            Label2.Text = ""
            MsgBox("We are sorry Please try again", , "Erorr")
        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            f = Label1.Text
            Label1.Text = ""
            f = f * Math.PI / 180
            a = Math.Sin(f)
            Label1.Text = a
            Label2.Text = ""
        Catch ex As Exception
            Label1.Text = ""
            Label2.Text = ""
            MsgBox("We are sorry Please try again", , "Erorr")
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            f = Label1.Text
            Label1.Text = ""
            f = f * Math.PI / 180
            a = Math.Cos(f)
            Label1.Text = a
            Label2.Text = ""
        Catch ex As Exception
            Label1.Text = ""
            Label2.Text = ""
            MsgBox("We are sorry Please try again", , "Erorr")
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            f = Label1.Text
            Label1.Text = ""
            f = f * Math.PI / 180
            a = Math.Tan(f)
            Label1.Text = a
            Label2.Text = ""
        Catch ex As Exception
            Label1.Text = ""
            Label2.Text = ""
            MsgBox("We are sorry Please try again", , "Erorr")
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Try
            a = Math.Log(Label1.Text)
            Label1.Text = a
            Label2.Text = ""
        Catch ex As Exception
            Label1.Text = ""
            Label2.Text = ""
            MsgBox("We are sorry Please try again", , "Erorr")
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Try
            a = Math.Sqrt(Label1.Text)
            Label1.Text = a
            Label2.Text = ""
        Catch ex As Exception
            Label1.Text = ""
            Label2.Text = ""
            MsgBox("We are sorry Please try again", , "Erorr")
        End Try
    End Sub
End Class