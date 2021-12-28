Public Class Task9

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.Font = .Font
            End If
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.ForeColor = .Color
            End If
        End With
    End Sub

    Private Sub BackcolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackcolorToolStripMenuItem.Click
        With ColorDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.BackColor = .Color
            End If
        End With
    End Sub
    Function load(pic As Object)
        OpenFileDialog1.Filter = "Images Files (jpeg jpg png gif webg bmp tif) | *.jpeg; *.jpg; *.gif; *.png; *.wpag; *.bmp; *.tif| All Files (*.*) | *.*"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            With pic
                .Image = Image.FromFile(OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.Zoom
                .BorderStyle = BorderStyle.None
            End With
        End If
    End Function
    Private Sub Picture1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Picture1ToolStripMenuItem.Click
        load(PictureBox1)
    End Sub

    Private Sub Picture2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Picture2ToolStripMenuItem.Click
        load(PictureBox2)
    End Sub

    Private Sub Picture3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Picture3ToolStripMenuItem.Click
        load(PictureBox3)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Select()
        RichTextBox1.Cut()
    End Sub

    Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBox1.SelectionChanged
        If RichTextBox1.SelectionLength > 0 Then
            CutToolStripMenuItem.Enabled = True
            CopyToolStripMenuItem.Enabled = True
        Else
            CutToolStripMenuItem.Enabled = False
            CopyToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Select()
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GoToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToToolStripMenuItem.Click
        Dim Line As Integer
        Try
            Line = InputBox("Enter Line Number")
            RichTextBox1.Focus()
            RichTextBox1.SelectionStart = RichTextBox1.GetFirstCharIndexFromLine(Line - 1)
        Catch ex As Exception
            Me.TopMost = False
            MessageBox.Show("Num " + Line.ToString + " Out of range", "modula", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(Me.RichTextBox1.Font.Name, 14, FontStyle.Regular)
        RichTextBox1.SelectionColor = Color.Black
        RichTextBox1.BackColor = Color.White
        RichTextBox1.DeselectAll()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Main.Show()
        Me.Hide()
    End Sub
End Class