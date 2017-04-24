'-------------------------------------------------------------------'
'-          File name: Form1.vb                                    -'
'-          Part of project: Assignment10                          -'
'-------------------------------------------------------------------'
'-          Written By: Alex Coldwell                              -'
'-          Written On: 04/16/2017                                 -'
'-------------------------------------------------------------------'
'- File Purpose:                                                   -'
'-                                                                 -'
'- This file contains Form1. Form1 implements the user control     -'
'- MyClock1. 
'-------------------------------------------------------------------'
'- Program Purpose:                                                -'
'-                                                                 -'
'- The program contains two buttons to change the foreground of the-'
'- control and to change the background of the form.               -'
'-------------------------------------------------------------------'
'- Global Variable Dictionary                                      -'
'- (none)                                                          -'
'-------------------------------------------------------------------'
Public Class Form1
    '-------------------------------------------------------------------'
    '-                    Subprogram Name: Button1_Click               -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/16/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when Button1 is clicked. This sub       -'
    '-   toggles the ForeColor of MyClock1 between red and black.      -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the click   –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MyClock1.ForeColor = Color.Red Then
            MyClock1.ForeColor = Color.Black
        Else
            MyClock1.ForeColor = Color.Red
        End If
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: Button2_Click               -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/16/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when Button2 is clicked. This sub       -'
    '-   toggles the BackColor of Form1 between Blue and White.        -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the click   –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.BackColor = Color.Blue Then
            Me.BackColor = Color.White
        Else
            Me.BackColor = Color.Blue
        End If
    End Sub
End Class
