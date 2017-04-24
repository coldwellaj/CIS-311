Public Class Language
    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        My.Settings.defaultLanguage = cbxLanguage.SelectedItem

        Select Case My.Settings.defaultLanguage
            Case "Español"
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                New Globalization.CultureInfo("es-ES")
                System.Threading.Thread.CurrentThread.CurrentCulture =
                New Globalization.CultureInfo("es-ES")
            Case "Norsk"
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                New Globalization.CultureInfo("no")
                System.Threading.Thread.CurrentThread.CurrentCulture =
                New Globalization.CultureInfo("no")
            Case Else
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                New Globalization.CultureInfo("en-US")
                System.Threading.Thread.CurrentThread.CurrentCulture =
                New Globalization.CultureInfo("en-US")
        End Select

        Me.Hide()
    End Sub
End Class