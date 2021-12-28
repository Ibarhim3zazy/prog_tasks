Public Class Task8

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o1 As New Task8
        Dim l As New Label
        Me.AddOwnedForm(o1)
        Me.Text = "Owner Form " & Me.Text
        o1.Text = "Owned Form"
        o1.Button1.Visible = False
        o1.Button2.Visible = False
        o1.Button3.Visible = False
        o1.Button22.Visible = False
        l.SetBounds(135, 200, 200, 400)
        l.Text = "Hello in my Owned form"
        l.Font = New Font("", 12, FontStyle.Regular)
        o1.Controls.Add(l)
        o1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c1 As New Task8
        Dim l As New Label
        Me.IsMdiContainer = True
        c1.MdiParent = Me
        Me.Text = "Parent Form" & Me.Text
        c1.Text = "Child Form"
        c1.Button1.Visible = False
        c1.Button2.Visible = False
        c1.Button3.Visible = False
        c1.Button22.Visible = False
        l.SetBounds(135, 200, 200, 400)
        l.Text = "Hello in my Child form"
        l.Font = New Font("", 12, FontStyle.Regular)
        c1.Controls.Add(l)
        c1.Show()
        Me.LayoutMdi(MdiLayout.TileHorizontal)
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = True
        Button22.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = False
        Button22.Visible = True
        Me.IsMdiContainer = False
    End Sub
End Class