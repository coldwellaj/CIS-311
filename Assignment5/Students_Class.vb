'-------------------------------------------------------------------'
'-          File name: Studnets_Class.vb                           -'
'-          Part of project: Assignment5                           -'
'-------------------------------------------------------------------'
'-          Written By: Alex Coldwell                              -'
'-          Written On: 02/14/2017                                 -'
'-------------------------------------------------------------------'
'- File Purpose:                                                   -'
'-                                                                 -'
'- This file contains the Students class it's properties and its   -'
'- subroutines.                                                    -'
'-------------------------------------------------------------------'
'- Global Variable Dictionary                                      -'
'- strInitials: A string to hold the initials of the student       -'
'- strLastName: A string to hold the students last name            -'
'- sglHomework1: A single to hold the grade for the first HW       -'
'- sglHomework2: A single to hold the grade for the secnond HW     -'
'- sglHomework3: A single to hold the grade for the third HW       -'
'- sglHomework4: A single to hold the grade for the fourth HW      -'
'- sglExamScore:  A single to hold the grade for the exam          -'
'- sglNumericGrade: A single to hold the final grade               -'
'- strLetterGrade: A string to hold the letter grade               -'
'-------------------------------------------------------------------'

Module Students_Class
    Class Students
        ' Variables
        Public strInitials As String
        Public strLastName As String
        Public sglHomework1 As Single
        Public sglHomework2 As Single
        Public sglHomework3 As Single
        Public sglHomework4 As Single
        Public sglExamScore As Single
        Public sglNumericGrade As Single
        Public strLetterGrade As String

        ' Constants
        Const sglAssignmentWeight As Single = 0.5
        Const sglGradeA = 95
        Const sglGradeAMinus = 90
        Const sglGradeBPlus = 87
        Const sglGradeB = 85
        Const sglGradeBMinus = 80
        Const sglGradeCPlus = 77
        Const sglGradeC = 74
        Const sglGradeCMinus = 70
        Const sglGradeDPlus = 67
        Const sglGradeD = 64
        Const sglGradeDMinus = 60


        '-------------------------------------------------------------------'
        '-                    Subprogram Name: New                         -'
        '-------------------------------------------------------------------'
        '-                    Written By: Alex Coldwell                    -'
        '-                    Written On: 02/14/17                         -'
        '-------------------------------------------------------------------'
        '- Sub Purpose:                                                    -'
        '-   This sub is triggered when the user creates a new instence    -'
        '-   of students. It tales a string and parses it into the         -'
        '-   properties of the class instence. It then calls subs to find  -'
        '-   the final grade and letter grade.                             -'
        '-------------------------------------------------------------------'
        '- Parameter Dictionary (in parameter order):                      -'
        '-  strInput - String to hold the line to be parsed.               -'
        '-------------------------------------------------------------------'
        '- Local Variable Dictionary (alphabetically):                     -'
        '-   strInputArray - Array of strings to hold the parsed data      -'
        '-------------------------------------------------------------------'
        Public Sub New(ByVal strInput As String)
            Dim strInputArray(7) As String
            strInputArray = strInput.Split(" ")

            strInitials = strInputArray(0)
            strLastName = strInputArray(1)
            sglHomework1 = CSng(strInputArray(2))
            sglHomework2 = CSng(strInputArray(3))
            sglHomework3 = CSng(strInputArray(4))
            sglHomework4 = CSng(strInputArray(5))
            sglExamScore = CSng(strInputArray(6))

            ' Call to find Final and Letter Grade
            FindFinalGrade()
            FindLetterGrade()

        End Sub

        '-------------------------------------------------------------------'
        '-                    Subprogram Name: FindFinalGrade              -'
        '-------------------------------------------------------------------'
        '-                    Written By: Alex Coldwell                    -'
        '-                    Written On: 02/14/17                         -'
        '-------------------------------------------------------------------'
        '- Sub Purpose:                                                    -'
        '-   This sub uses the properties of the class object to find the  -'
        '-   final overall grade.                                          -'
        '-------------------------------------------------------------------'
        '- Parameter Dictionary (in parameter order):                      -'
        '-  (none)                                                         -'
        '-------------------------------------------------------------------'
        '- Local Variable Dictionary (alphabetically):                     -'
        '-  sglFinal - single to hold the final overall grade.             -'
        '-  sglHomeworkOverall - single to hold the over grade for homework-'
        '-------------------------------------------------------------------'
        Private Sub FindFinalGrade()
            Dim sglFinal As Single
            Dim sglHomeworkOverall As Single = 0

            ' Find Overall grade for Homework
            sglHomeworkOverall += sglHomework1
            sglHomeworkOverall += sglHomework2
            sglHomeworkOverall += sglHomework3
            sglHomeworkOverall += sglHomework4

            ' Add weighted grades to the total
            sglFinal = (sglHomeworkOverall * sglAssignmentWeight) + (sglExamScore * sglAssignmentWeight)
            sglNumericGrade = sglFinal

        End Sub

        '-------------------------------------------------------------------'
        '-                    Subprogram Name: FindLetterGrade             -'
        '-------------------------------------------------------------------'
        '-                    Written By: Alex Coldwell                    -'
        '-                    Written On: 02/14/17                         -'
        '-------------------------------------------------------------------'
        '- Sub Purpose:                                                    -'
        '-   This sub uses the properties of the class object to find the  -'
        '-   letter grade the student earned.                              -'
        '-------------------------------------------------------------------'
        '- Parameter Dictionary (in parameter order):                      -'
        '-  (none)                                                         -'
        '-------------------------------------------------------------------'
        '- Local Variable Dictionary (alphabetically):                     -'
        '-  (none)                                                         -'
        '-------------------------------------------------------------------'
        Private Sub FindLetterGrade()
            If (sglNumericGrade >= sglGradeA) Then
                strLetterGrade = "A"
            ElseIf (sglNumericGrade < sglGradeA And sglNumericGrade >= sglGradeAMinus) Then
                strLetterGrade = "A-"
            ElseIf (sglNumericGrade < sglGradeAMinus And sglNumericGrade >= sglGradeBPlus) Then
                strLetterGrade = "B+"
            ElseIf (sglNumericGrade < sglGradeBPlus And sglNumericGrade >= sglGradeB) Then
                strLetterGrade = "B"
            ElseIf (sglNumericGrade < sglGradeB And sglNumericGrade >= sglGradeBMinus) Then
                strLetterGrade = "B-"
            ElseIf (sglNumericGrade < sglGradeBMinus And sglNumericGrade >= sglGradeCPlus) Then
                strLetterGrade = "C+"
            ElseIf (sglNumericGrade < sglGradeCPlus And sglNumericGrade >= sglGradeC) Then
                strLetterGrade = "C"
            ElseIf (sglNumericGrade < sglGradeC And sglNumericGrade >= sglGradeCMinus) Then
                strLetterGrade = "C-"
            ElseIf (sglNumericGrade < sglGradeCMinus And sglNumericGrade >= sglGradeDPlus) Then
                strLetterGrade = "D+"
            ElseIf (sglNumericGrade < sglGradeDPlus And sglNumericGrade >= sglGradeD) Then
                strLetterGrade = "D"
            ElseIf (sglNumericGrade < sglGradeD And sglNumericGrade >= sglGradeDMinus) Then
                strLetterGrade = "D-"
            Else
                strLetterGrade = "F"
            End If
        End Sub

    End Class

End Module
