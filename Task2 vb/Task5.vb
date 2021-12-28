Public Class Task5

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c(255) As Char
        Dim i As Integer
        For i = 0 To 255
            c(i) = Chr(i)
            ListBox1.Items.Add(c(i) & "    >>>    " & i)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class