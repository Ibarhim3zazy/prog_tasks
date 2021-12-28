<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Task10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(128, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 45)
        Me.TextBox1.TabIndex = 0
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.SteelBlue
        Me.Button22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.White
        Me.Button22.Location = New System.Drawing.Point(0, 0)
        Me.Button22.Margin = New System.Windows.Forms.Padding(4)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(486, 40)
        Me.Button22.TabIndex = 9
        Me.Button22.Text = "Home"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Task10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 433)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.TextBox1)
        Me.MinimizeBox = False
        Me.Name = "Task10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Task10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button22 As System.Windows.Forms.Button
End Class
