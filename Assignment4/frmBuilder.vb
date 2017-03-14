'-------------------------------------------------------------------'
'-          File name: frmBuilder.vb                               -'
'-          Part of project: Assignment4                           -'
'-------------------------------------------------------------------'
'-          Written By: Alex Coldwell                              -'
'-          Written On: 02/07/2017                                 -'
'-------------------------------------------------------------------'
'- File Purpose:                                                   -'
'-                                                                 -'
'- This file allows users to create degree programs buy adding     -'
'- courses to there designated degree dictionary in the objProrgams-'
'- dictionary.                                                     -'
'-------------------------------------------------------------------'
'- Global Variable Dictionary                                      -'
'- objPrograms: Dictionary object of dictionary objects to hold    -'
'- the degrees programs.                                           -'
'-------------------------------------------------------------------'
Imports System.ComponentModel

Public Class frmBuilder
    ' Dim Dictionary to hold programs
    Dim objProgram As New Dictionary(Of String, Dictionary(Of String, String))

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdBackToManager_Click      -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user presses the BackToManager -'
    '-   command button. It switches back to frmManger                 -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '- (none)                                                          -'
    '-------------------------------------------------------------------'
    Private Sub btnBackToManager_Click(sender As Object, e As EventArgs) Handles btnBackToManager.Click
        frmManager.Show()
        Me.Hide()
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: frmBuilder_Closing          -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered whenever frmBuilder is attemping to     -'
    '-   close. This sub triggers a close event for frmManager as well.-'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the CancelEventArgs object sent to the routine        -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '- (none)                                                          -'
    '-------------------------------------------------------------------'
    Private Sub frmBuilder_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmManager.Close()
    End Sub

    '-------------------------------------------------------------------'
    '-           Subprogram Name: lstDegrees_SelectedIndexChanged      -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user changes what is selected  -'
    '-   in the Degrees listbox. The sub first checks to see if the    -'
    '-   degree program has been created. If is has not then it        -'
    '-   displays to the user that the degree is empty. If it has been -'
    '-   created then it prints the courses in the degree program.     -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '- strKey: String to hold the key to get the degree program        -'
    '-------------------------------------------------------------------'
    Private Sub lstDegrees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDegrees.SelectedIndexChanged

        ' Reset Error Provider
        ErrorProvider1.SetError(lstDegrees, Nothing)

        ' Dim Variables
        Dim strKey As String
        strKey = lstDegrees.SelectedItem
        strKey = strKey.Substring(0, strKey.IndexOf(" "))

        ' Check if program has been built yet
        If Not objProgram.ContainsKey(strKey) Then
            MessageBox.Show("This Degree Has no Courses")
            lstProgram.Items.Clear()
        Else

            ' Clear lstProgram
            lstProgram.Items.Clear()

            ' Print Elements of specific program dictionary
            For Each intX In objProgram(strKey).Keys
                lstProgram.Items.Add(intX & " - " & objProgram(strKey).Item(intX))
            Next
        End If

    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdAdd_Click                -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user presses the <- command    -'
    '-   button. The sub first checks if the user has a degree to      -'
    '-   create selected and a course to add selected. If not then the -'
    '-   sub presents errors using the error provider. If all the right-'
    '-   criteria is met then the sub checks to make sure the course is-'
    '-   not already in the degree dictionary. If the degree dosen't   -'
    '-   already contain the course then the sub adds the course to the-'
    '-   degree dictionary.                                            -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '- strDegree: String to hold the key to the degree dictionary.     -'
    '- strCourseDesignator: String to hold the Course Designator.      -'
    '- StrCourseName: String to hold the course Name.                  -'
    '-------------------------------------------------------------------'
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        ' Dim Key
        Dim strCourseDesignator = ""
        Dim strCourseName = ""
        Dim strDegree = ""

        ' Check if the user selceted a Degree and a Course to add
        If lstDegrees.SelectedItem = "" Or lstCourses.SelectedItem = "" Then

            ' Check if the user selected a Degree and set off error
            If lstDegrees.SelectedItem = "" Then
                ErrorProvider1.SetError(lstDegrees, "You need to select a Degree to create")
            Else
                ErrorProvider1.SetError(lstDegrees, Nothing)
            End If

            ' Check if the user selected a course to add and set off error
            If lstCourses.SelectedItem = "" Then
                ErrorProvider1.SetError(lstCourses, "You need to select a course to add to the Degree")
            Else
                ErrorProvider1.SetError(lstCourses, Nothing)
            End If
        Else

            ' Find keys for degree and course
            strDegree = lstDegrees.SelectedItem
            strDegree = strDegree.Substring(0, strDegree.IndexOf(" "))
            strCourseDesignator = lstCourses.SelectedItem
            strCourseDesignator = strCourseDesignator.Substring(0, strCourseDesignator.IndexOf(" "))
            strCourseName = lstCourses.SelectedItem
            strCourseName = strCourseName.Substring(strCourseName.IndexOf(" ") + 3)

            ' If not already created create a dictionary for the degree
            If Not objProgram.ContainsKey(strDegree) Then
                objProgram.Add(strDegree, New Dictionary(Of String, String))
            End If



            ' Reset Errors
            ErrorProvider1.SetError(lstDegrees, Nothing)
            ErrorProvider1.SetError(lstCourses, Nothing)

            ' Check to see if the selected item is already in the degree dictionary
            If objProgram(strDegree).ContainsKey(strCourseDesignator) Then
                ErrorProvider1.SetError(lstCourses, "This degree already conatains the course: " & strCourseDesignator)
            Else
                ' Add course to specific program
                objProgram(strDegree).Add(strCourseDesignator, strCourseName)
            End If

            ' Clear lstProgram
            lstProgram.Items.Clear()

            ' Print Elements of specific program dictionary
            For Each intX In objProgram(strDegree).Keys
                lstProgram.Items.Add(intX & " - " & objProgram(strDegree).Item(intX))
            Next
        End If
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdRemove_Click             -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user presses the <- command    -'
    '-   button. The sub first checks if they're are elements selected -'
    '-   in the Program list. If there is then it removes it from the  -'
    '-   degree dictionary. If the course is the last in the degree    -'
    '-   then the sub removes the degree dictionary from the program   -'
    '-   dictionary. If there is no course selected Then the Sub errors-'
    '-   using the Error provider.
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '- strDegree: String to hold the key to the degree dictionary.     -'
    '- strCourseDesignator: String to hold the Course Designator.      -'
    '-------------------------------------------------------------------'
    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        ' Dim Key
        Dim strCourseDesignator = ""
        Dim strDegree = ""

        ' Check if item is selected
        If lstProgram.SelectedItem = "" Then
            ErrorProvider1.SetError(lstProgram, "You need to select a course to remove.")
        Else
            ErrorProvider1.SetError(lstProgram, Nothing)

            ' Find keys for degree and course
            strDegree = lstDegrees.SelectedItem
            strDegree = strDegree.Substring(0, strDegree.IndexOf(" "))
            strCourseDesignator = lstProgram.SelectedItem
            strCourseDesignator = strCourseDesignator.Substring(0, strCourseDesignator.IndexOf(" "))

            ' Check if it's the last course in the dictionary
            If objProgram(strDegree).Count = 1 Then
                objProgram.Remove(strDegree)
                lstProgram.Items.Clear()
            Else
                objProgram(strDegree).Remove(strCourseDesignator)

                ' Clear lstProgram
                lstProgram.Items.Clear()

                ' Print Elements of specific program dictionary
                For Each intX In objProgram(strDegree).Keys
                    lstProgram.Items.Add(intX & " - " & objProgram(strDegree).Item(intX))
                Next
            End If
        End If
    End Sub

    '-------------------------------------------------------------------'
    '-           Subprogram Name: lstProgram_SelectedIndexChanged      -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user changes what is selected  -'
    '-   in the Program listbox. The sub resets the error provider for -'
    '-   the Program listbox to nothing.                               -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '- (none)                                                          -'
    '-------------------------------------------------------------------'
    Private Sub lstProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProgram.SelectedIndexChanged
        ErrorProvider1.SetError(lstProgram, Nothing)
    End Sub

    '-------------------------------------------------------------------'
    '-           Subprogram Name: lstCourses_SelectedIndexChanged      -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user changes what is selected  -'
    '-   in the Courses listbox. The sub resets the error provider for -'
    '-   the Courses listbox to nothing.                               -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '- (none)                                                          -'
    '-------------------------------------------------------------------'
    Private Sub lstCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCourses.SelectedIndexChanged
        ErrorProvider1.SetError(lstCourses, Nothing)
    End Sub
End Class