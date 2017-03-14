'-------------------------------------------------------------------'
'-          File name: frmManager.vb                               -'
'-          Part of project: Assignment4                           -'
'-------------------------------------------------------------------'
'-          Written By: Alex Coldwell                              -'
'-          Written On: 02/07/2017                                 -'
'-------------------------------------------------------------------'
'- File Purpose:                                                   -'
'-                                                                 -'
'- This contains the MdiParent form for the program. The MdiParent -'
'- allows users to create new frmCalculator objects, select among  -'
'- active children forms, and exit from the application.           -'
'-------------------------------------------------------------------'
'- Program Purpose:                                                -'
'-                                                                 -'
'- This program allows the user to create frmCalculator objects    -'
'- and use them as children of the MdiParent form MdiParent.vb.    -'
'- The frmCalculator is a fully funtional 1970s calculator that    -'
'- will prompt the user if the entry is not 0 whether they really  -'
'- want to close the form.                                         -'
'-------------------------------------------------------------------'
'- Global Variable Dictionary                                      -'
'- (none)                                                          -'
'-------------------------------------------------------------------'
Public Class MdiParent
    '-------------------------------------------------------------------'
    '-                    Subprogram Name: NewToolStripMenuItem_Click  -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/27/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered whenever NewToolStripMenuItem is clicked-'
    '-   It loads a new frmCalculator object, names it according the   -'
    '-   intFormCount, then sets it's parent to be MdiParent.vb.       -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   frmNewCalc - frmCalculator object to be created.              -'
    '-------------------------------------------------------------------'
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim frmNewCalc As New frmCalculator()

        'Increment the number for this child form        
        My.Application.intFormCount += 1
        'Change the form's name and text 
        frmNewCalc.Name = "1970s calculator "
        frmNewCalc.Name &= "- " & Trim(CStr(My.Application.intFormCount))
        frmNewCalc.Text = frmNewCalc.Name
        frmNewCalc.MdiParent = Me

        frmNewCalc.Show()

    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: ExitToolStripMenuItem_Click -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/27/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered whenever ExitToolStripMenuItem is       -'
    '-   clicked. It closes the MdiParent Form.                        -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: MdiParent_Load              -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/27/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered whenever MdiParent is loaded. It loads  -'
    '-   a new frmCalculator.                                          -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub MdiParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewToolStripMenuItem.PerformClick()
    End Sub
End Class