'-------------------------------------------------------------------'
'-          File name: frmManager.vb                               -'
'-          Part of project: Assignment4                           -'
'-------------------------------------------------------------------'
'-          Written By: Alex Coldwell                              -'
'-          Written On: 02/07/2017                                 -'
'-------------------------------------------------------------------'
'- File Purpose:                                                   -'
'-                                                                 -'
'- This file allows users to create and delete degrees and courses -'
'- to be used by the degree builder. The courses and degrees are   -'
'- in their own dictionaries.                                      -
'-------------------------------------------------------------------'
'- Program Purpose:                                                -'
'-                                                                 -'
'- This program allows the user to create degree programs by first -'
'- allowing the user to create and delete degrees and courses and  -'
'- then allowing the user to use the Degree Builder to create a    -'
'- collection of classes for each degree.                          -'
'-------------------------------------------------------------------'
'- Global Variable Dictionary                                      -'
'- objDegrees: Dictionary object to hold the degrees.              -'
'- objCourses: Dictionary object to hold the degrees.              -'
'-------------------------------------------------------------------'

Imports System.ComponentModel

Public Class frmManager
    Public objDegrees As New SortedDictionary(Of String, String)
    Public objCourses As New SortedDictionary(Of String, String)

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdAddDegree_Click          -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user presses the Add Degree    -'
    '-   command button. The sub first checks if there is a degree     -'
    '-   Designator and Name are  entered If there are then it adds    -'
    '-   then degree to the degree dictionary then re-populates the    -'
    '-   Degrees list. If not then the sub diplays errors using the    -'
    '-   Error provider.                                               -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub cmdAddDegree_Click(sender As Object, e As EventArgs) Handles cmdAddDegree.Click

        ' Check if either txtDegreeDesignator or txtDegreeName are empty
        If txtDegreeDesignator.Text = "" Or txtDegreeName.Text = "" Then

            ' Check if txtDegreeDesignator is empty and set off error provider
            If txtDegreeDesignator.Text = "" Then
                ErrorProvider1.SetError(Me.txtDegreeDesignator, "Must Have Degree Designator")
            Else
                ErrorProvider1.SetError(Me.txtDegreeDesignator, Nothing)
            End If

            ' Check if txtDegreeName is empty and set off error provider
            If txtDegreeName.Text = "" Then
                ErrorProvider1.SetError(Me.txtDegreeName, "Must Have Degree Name")
            Else
                ErrorProvider1.SetError(Me.txtDegreeName, Nothing)
            End If
        Else

            ' Reset Error Provider
            ErrorProvider1.SetError(Me.txtDegreeDesignator, Nothing)
            ErrorProvider1.SetError(Me.txtDegreeName, Nothing)

            ' Check if either the degree name or designator are already used
            If objDegrees.ContainsKey(txtDegreeDesignator.Text) Or objDegrees.ContainsValue(txtDegreeName.Text) Then

                'Check if degree designator is already used
                If objDegrees.ContainsKey(txtDegreeDesignator.Text) Then
                    ErrorProvider1.SetError(Me.txtDegreeDesignator, "There is already a degree designator: " & txtDegreeDesignator.Text)
                Else
                    ErrorProvider1.SetError(Me.txtDegreeDesignator, Nothing)
                End If

                ' Check if degree name is already used
                If objDegrees.ContainsValue(txtDegreeName.Text) Then
                    ErrorProvider1.SetError(Me.txtDegreeName, "There is already a degree name: " & txtDegreeName.Text)
                Else
                    ErrorProvider1.SetError(Me.txtDegreeName, Nothing)
                End If
            Else

                ' Reset Error Provider and add degree to obj Degree
                ErrorProvider1.SetError(Me.txtDegreeDesignator, Nothing)
                objDegrees.Add(txtDegreeDesignator.Text, txtDegreeName.Text)
            End If

            ' Clear lstDegrees
            lstDegrees.Items.Clear()

            ' Populate elements of objDegrees into lstDegrees
            For Each intX In objDegrees.Keys
                lstDegrees.Items.Add(intX & " - " & objDegrees.Item(intX))
            Next
        End If
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdDeleteDegree_Click       -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user presses the Delete Degree -'
    '-   command button. The sub first checks if there is a degree     -'
    '-   selected. If there is then it removes the course from the     -'
    '-   degree dictionary then re-populates the Degrees list. If not  -'
    '-   then the sub diplays errors using the error provider.
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   strKey: Str to hold the Key to delete from the dictionary    -'
    '-------------------------------------------------------------------'
    Private Sub cmdDeleteDegree_Click(sender As Object, e As EventArgs) Handles cmdDeleteDegree.Click
        Dim strKey = ""


        ' Check if lstDegrees is either empty of if nothing is selected
        If lstDegrees.SelectedItem = "" Or lstDegrees.Items.Count = 0 Then

            ' Check if nothing is selected in lstDegrees and set off Error Provider
            If lstDegrees.SelectedItem = "" Then
                ErrorProvider1.SetError(Me.lstDegrees, "Must Select Degree to Delete")
            End If

            ' Check if lstDegrees is empty and set off Error Provider
            If lstDegrees.Items.Count = 0 Then
                ErrorProvider1.SetError(Me.lstDegrees, "Must have an item in list box to delete")
            End If
        Else

            ' Reset Error Provider
            ErrorProvider1.SetError(Me.lstDegrees, Nothing)

            ' Delete item from objDegrees
            strKey = lstDegrees.SelectedItem
            strKey = strKey.Substring(0, strKey.IndexOf(" "))
            objDegrees.Remove(strKey)

            ' Clear lstDegrees
            lstDegrees.Items.Clear()

            ' Populate elements of objDegrees into lstDegrees
            For Each intX In objDegrees.Keys
                lstDegrees.Items.Add(intX & " - " & objDegrees.Item(intX))
            Next
        End If
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdAddCourse_Click          -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user presses the Add Course    -'
    '-   command button. The sub first checks if there is a course     -'
    '-   Designator and Name entered If there is then it adds the      -'
    '-   course to the course dictionary then re-populates the Courses -'
    '-   list. If not then the sub diplays errors using the error      -'
    '-   provider.                                                     -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub cmdAddCourse_Click(sender As Object, e As EventArgs) Handles cmdAddCourse.Click
        ' Check if either txtCourseDesignator or txtCourseName are empty
        If txtCourseDesignator.Text = "" Or txtCourseName.Text = "" Then

            ' Check if txtNameDesignator is empty and set off error provider
            If txtCourseDesignator.Text = "" Then
                ErrorProvider1.SetError(Me.txtCourseDesignator, "Must Have Course Designator")
            Else
                ErrorProvider1.SetError(Me.txtCourseDesignator, Nothing)
            End If

            ' Check if txtCourseName is empty and set off error provider
            If txtCourseName.Text = "" Then
                ErrorProvider1.SetError(Me.txtCourseName, "Must Have Course Name")
            Else
                ErrorProvider1.SetError(Me.txtCourseName, Nothing)
            End If
        Else

            ' Reset Error Provider
            ErrorProvider1.SetError(Me.txtCourseDesignator, Nothing)
            ErrorProvider1.SetError(Me.txtCourseName, Nothing)

            ' Check if either the Course name or designator are already used
            If objCourses.ContainsKey(txtCourseDesignator.Text) Or objCourses.ContainsValue(txtCourseName.Text) Then

                'Check if Course designator is already used
                If objCourses.ContainsKey(txtCourseDesignator.Text) Then
                    ErrorProvider1.SetError(Me.txtCourseDesignator, "There is already a course designator: " & txtCourseDesignator.Text)
                Else
                    ErrorProvider1.SetError(Me.txtCourseDesignator, Nothing)
                End If

                ' Check if course name is already used
                If objCourses.ContainsValue(txtCourseName.Text) Then
                    ErrorProvider1.SetError(Me.txtCourseName, "There is already a course name: " & txtCourseName.Text)
                Else
                    ErrorProvider1.SetError(Me.txtCourseName, Nothing)
                End If
            Else

                ' Reset Error Provider and add course to obj Degree
                ErrorProvider1.SetError(Me.txtCourseDesignator, Nothing)
                objCourses.Add(txtCourseDesignator.Text, txtCourseName.Text)
            End If

            ' Clear lstCourses
            lstCourses.Items.Clear()

            ' Populate elements of objCourses into lstCourses
            For Each intX In objCourses.Keys
                lstCourses.Items.Add(intX & " - " & objCourses.Item(intX))
            Next
        End If
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdDeleteCourse_Click       -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user presses the Delete Course -'
    '-   command button. The sub first checks if there is a course     -'
    '-   selected. If there is then it removes the course from the     -'
    '-   course dictionary then re-populates the Courses list. If not  -'
    '-   then the sub diplays errors using the error provider.
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   strKey: Str to hold the Key to delete from the dictionary    -'
    '-------------------------------------------------------------------'
    Private Sub cmdDeleteCourse_Click(sender As Object, e As EventArgs) Handles cmdDeleteCourse.Click
        ' Dim Variables
        Dim strKey = ""

        ' Check if lstCourses is either empty of if nothing is selected
        If lstCourses.SelectedItem = "" Or lstCourses.Items.Count = 0 Then

            ' Check if lstCourses is empty and set off Error Provider
            If lstCourses.Items.Count = 0 Then
                ErrorProvider1.SetError(Me.lstCourses, "Must have an item in list box to delete")
            End If

            ' Check if nothing is selected in lstCourses and set off Error Provider
            If lstCourses.SelectedItem = "" Then
                ErrorProvider1.SetError(Me.lstCourses, "Must Select Course to Delete")
            End If


        Else

            ' Reset Error Provider
            ErrorProvider1.SetError(Me.lstCourses, Nothing)

            ' Delete item from objCourses
            strKey = lstCourses.SelectedItem
            strKey = strKey.Substring(0, strKey.IndexOf(" "))
            objCourses.Remove(strKey)

            ' Clear lstCourses
            lstCourses.Items.Clear()

            ' Populate elements of objCourses into lstCourses
            For Each intX In objCourses.Keys
                lstCourses.Items.Add(intX & " - " & objCourses.Item(intX))
            Next
        End If
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdBuild_Click              -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user presses the cmdBuild      -'
    '-   command button. This sub checks if there are elements in both -'
    '-   dictionaries. If there are then it switches to frmBuilder, if -'
    '-   not then it displays errors with the error provider.          -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '- (none)                                                          -'
    '-------------------------------------------------------------------'
    Private Sub cmdBuild_Click(sender As Object, e As EventArgs) Handles cmdBuild.Click

        ' Check if there are elements in lstCourses and lstDegrees
        If lstCourses.Items.Count = 0 Or lstDegrees.Items.Count = 0 Then

            ' Check if there are elements in lstCourses
            If lstCourses.Items.Count = 0 Then
                ErrorProvider1.SetError(Me.lstCourses, "You have no courses to build with")
            Else
                ErrorProvider1.SetError(Me.lstCourses, Nothing)
            End If

            ' Check if there are elements in lstDegrees
            If lstDegrees.Items.Count = 0 Then
                ErrorProvider1.SetError(Me.lstDegrees, "You have no degrees to build with")
            Else
                ErrorProvider1.SetError(Me.lstDegrees, Nothing)
            End If
        Else

            ' Clear elements from frmBuilder.lstDegrees, frmBuilder.lstCourses,
            ' and frmBuilder.lstProgram
            frmBuilder.lstDegrees.Items.Clear()
            frmBuilder.lstCourses.Items.Clear()
            frmBuilder.lstProgram.Items.Clear()

            ' Populate elements of objDegrees into frmBuilder.lstDegrees
            For Each intX In objDegrees.Keys
                frmBuilder.lstDegrees.Items.Add(intX & " - " & objDegrees.Item(intX))
            Next

            ' Populate elements of objCourses into frmBuilder.lstCourses
            For Each intX In objCourses.Keys
                frmBuilder.lstCourses.Items.Add(intX & " - " & objCourses.Item(intX))
            Next

            ' Switch views
            Me.Hide()
            Try
                frmBuilder.ShowDialog()
            Catch ex As Exception
                frmBuilder.Show()
            End Try




        End If
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: frmManager_Load             -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when frmManager is first loaded. This   -'
    '-   sub preloads some elements into the degrees and courses       -'
    '-   dictionaries. It also loads the dictionaries into list boxes. -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '- (none)                                                          -'
    '-------------------------------------------------------------------'
    Private Sub frmManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load some Degrees into the objDegree Dictionary
        objDegrees.Add("ACCT", "Accounting")
        objDegrees.Add("CIS", "Computer Information Systems")
        objDegrees.Add("CS", "Computer Science")
        objDegrees.Add("MATH", "Mathematics")

        ' Populate elements of objDegrees into lstDegrees
        For Each intX In objDegrees.Keys
            lstDegrees.Items.Add(intX & " - " & objDegrees.Item(intX))
        Next

        ' Load some Courses into the objCourses Dictionary
        objCourses.Add("ACCT213", "Managerial Accounting")
        objCourses.Add("ACCT214", "Financial Accounting")
        objCourses.Add("CIS311", "Windows Programming with VB.NET")
        objCourses.Add("CIS422", "Systems Analysis and Design")
        objCourses.Add("CIS424", "Systems Design and Implementation")
        objCourses.Add("CS116", "Computer Programming I")
        objCourses.Add("CS160", "Microcomputer Applications")
        objCourses.Add("CS216", "Computer Programming II")
        objCourses.Add("CS401", "Computer Networks")
        objCourses.Add("CS422", "Software Engineering")
        objCourses.Add("MATH120B", "Finite Mathmatics")
        objCourses.Add("MATH161", "Calculus I")
        objCourses.Add("MATH162", "Calculus II")
        objCourses.Add("MATH400", "Mathematical Analysis")

        ' Populate elements of objDegrees into lstDegrees
        For Each intX In objCourses.Keys
            lstCourses.Items.Add(intX & " - " & objCourses.Item(intX))
        Next
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: frmManager_Closing          -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/07/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered whenever frmManager is attemping to     -'
    '-   close. This sub checks if the user is attempting to close     -'
    '-   frmManager while frmManager is shown. If so it prevents       -'
    '-   frmManager from being closed.                                 -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the CancelEventArgs object sent to the routine        -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '- (none)                                                          -'
    '-------------------------------------------------------------------'
    Private Sub frmManager_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Me.Visible Then
            e.Cancel = True
        End If
    End Sub
End Class
