Imports Microsoft.VisualBasic.ApplicationServices

'--------------------------------------------------------------------'
'-          File name: ApplicationEvents.vb                         -'
'-          Part of project: Assignment11                           -'
'--------------------------------------------------------------------'
'-          Written By: Alex Coldwell                               -'
'-          Written On: 04/24/2017                                  -'
'--------------------------------------------------------------------'
'- File Purpose:                                                    -'
'-                                                                  -'
'- This file loads the saved default language and sets the current  -'
'- Culture Info. If -settings is entered from the command prompt    -'
'- the apllication will load the Language form first to select a    -'
'- language.                                                        -'
'--------------------------------------------------------------------'
'- (none)                                                           -'
'--------------------------------------------------------------------'
Namespace My
    Partial Friend Class MyApplication
        'Load Prevoious selected language
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
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

            'Indicates we found/didn't find -SETTINGS in command line            
            Dim blnFoundSettings As Boolean = False

            'Scan for -SETTINGS in each command line argument            
            For Each s As String In My.Application.CommandLineArgs
                If s.ToUpper = "-SETTINGS" Then
                    blnFoundSettings = True
                End If
            Next

            'If we found -SETTINGS, show configuration screen            
            If blnFoundSettings Then
                Language.ShowDialog()
            End If


        End Sub
    End Class
End Namespace
