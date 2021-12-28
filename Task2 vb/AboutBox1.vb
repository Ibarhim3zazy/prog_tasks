Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = String.Format("Modula", My.Application.Info.ProductName)
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = String.Format("@2021 3zazy Group corporation", My.Application.Info.Copyright)
        Me.LabelCompanyName.Text = String.Format("3zazyGroup", My.Application.Info.CompanyName)
        Me.TextBoxDescription.Text = String.Format("عمل الطالب ابراهيم السيد محمد عزازي" & vbCrLf & " طالب بالفرقه الرابعه قسم حاسب الي " & vbCrLf & " فرع ميت غمر جامعة المنصورة" & vbCrLf & "للتواصل" & vbCrLf & "واتس&فون       01145452440" & vbCrLf & "فون                  01094989981", My.Application.Info.Description)
    End Sub

    Private Sub OKButton_Click_1(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class
