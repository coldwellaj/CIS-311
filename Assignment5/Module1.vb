'-------------------------------------------------------------------'
'-          File name: Module1.vb                                  -'
'-          Part of project: Assignment5                           -'
'-------------------------------------------------------------------'
'-          Written By: Alex Coldwell                              -'
'-          Written On: 02/14/2017                                 -'
'-------------------------------------------------------------------'
'- File Purpose:                                                   -'
'-                                                                 -'
'- This file runs the program. It propts the user to enter in the  -'
'- location of a text file that contains the grade info for all the-'
'- students. It then calls all of the functions to print the grade -'
'- report.                                                         -'
'-------------------------------------------------------------------'
'- Program Purpose:                                                -'
'-                                                                 -'
'- This program allows the user to create a grade report from a    -'
'- text file that contains the students grade info.                -'
'-------------------------------------------------------------------'
'- Global Variable Dictionary                                      -'
'- (none)                                                          -'
'-------------------------------------------------------------------'
Module Module1

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: Main                        -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub runs the program, first asking the user for an       -'
    '-   address to find the text file containing the student info,    -'
    '-   storing those students in a list of Students objects. This    -'
    '-   sub then prints all of the grade reports to the console using -'
    '-   a variety of subs.                                            -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  (none)                                                         -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-  myStreamReader: Stream reader to read in info from file.       -'
    '-  objClass: List object of students to hold the class.           -'
    '-  strAddress: String to hold the address of the text file.       -'
    '-  strInput: String to hold the input line from the Stream Reader -'
    '-------------------------------------------------------------------'
    Sub Main()
        Dim objClass As New List(Of Students)
        Dim strInput As String = ""
        Dim strAddress As String = ""
        Dim myStreamReader As System.IO.StreamReader

        ' Ask user to enter address of file
        System.Console.WriteLine("Please Enter the memory address of the text file")
        strAddress = System.Console.ReadLine()

        ' Check if file exists. If not print error, and exit. If it does open file
        If (Not My.Computer.FileSystem.FileExists(strAddress)) Then
            System.Console.WriteLine(StrDup(22, "-"))
            System.Console.WriteLine("Error File not found!!")
            System.Console.WriteLine(StrDup(22, "-"))
            System.Console.WriteLine("")
            System.Console.WriteLine("Press and Key to Exit..")
            System.Console.Read()
        Else
            myStreamReader = My.Computer.FileSystem.OpenTextFileReader(strAddress)


            ' Proccess file
            While Not myStreamReader.EndOfStream
                strInput = myStreamReader.ReadLine()
                objClass.Add(New Students(strInput))
            End While

            ' Print Report
            PrintClassList(objClass)
            System.Console.WriteLine("")
            DistributionStat(objClass)
            RangeStat(objClass)
            OverallStat(objClass)

            System.Console.WriteLine("Report Complete please press and Key to Exit..")
            System.Console.Read()
        End If


    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: PrintClassList              -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub uses a LINQ to query all the students in objClass    -'
    '-   then prints a semester grade report for all the students.     -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  objClass - List of students to be queried from.                -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-  objQuery: Object to hold the LINQ query.                       -'
    '-------------------------------------------------------------------'
    Sub PrintClassList(ByRef objClass As List(Of Students))
        Dim objQuery As Object

        ' Find all students in objClass and sort them by Last name
        objQuery = From Student In objClass
                   Order By Student.strLastName Ascending
                   Select Student

        ' Print Report Title and Labels
        System.Console.WriteLine(StrDup(26, " ") & "Ye Old Country School")
        System.Console.WriteLine(StrDup(22, " ") & "*** Semester Grade Report ***")
        System.Console.WriteLine(StrDup(22, " ") & StrDup(29, "-"))
        System.Console.WriteLine("")
        System.Console.WriteLine(StrDup(23, " ") & "HomeWork Scores" & StrDup(8, " ") _
                                 & "Exam" & StrDup(3, " ") & "Numeric" & StrDup(2, " ") _
                                 & "Letter")
        System.Console.WriteLine(StrDup(6, " ") & "Name" & StrDup(10, " ") _
                                 & "1" & StrDup(6, " ") & "2" & StrDup(6, " ") _
                                 & "3" & StrDup(6, " ") & "4" & StrDup(4, " ") _
                                 & "Score" & StrDup(3, " ") & "Grade" & StrDup(4, " ") _
                                 & "Grade")
        System.Console.WriteLine(StrDup(14, "-") & StrDup(4, " ") & StrDup(5, "-") _
                                 & StrDup(2, " ") & StrDup(5, "-") & StrDup(2, " ") _
                                 & StrDup(5, "-") & StrDup(2, " ") & StrDup(5, "-") _
                                 & StrDup(2, " ") & StrDup(5, "-") & StrDup(2, " ") _
                                 & StrDup(7, "-") & StrDup(2, " ") & StrDup(6, "-"))
        ' Print each student and there grade report
        For Each Student In objQuery
            System.Console.WriteLine(" " & Student.strInitials & " " & LSet(Student.strLastName, 12) _
                                     & String.Format("{0:N}", Student.sglHomework1) & "  " _
                                     & String.Format("{0:N}", Student.sglHomework2) & "  " _
                                     & String.Format("{0:N}", Student.sglHomework3) & "  " _
                                     & String.Format("{0:N}", Student.sglHomework4) & " " _
                                     & RSet(String.Format("{0:N}", Student.sglExamScore), 6) & "   " _
                                     & RSet(String.Format("{0:N}", Student.sglNumericGrade), 6) & "     " _
                                     & Student.strLetterGrade)
        Next

    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: DistributionStat            -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub prints a title then calls PrintGradeDistribution to  -'
    '-   Print the grade distribution for each letter.                 -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  objClass - List of students to be pasted to another sub.       -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-  (none)                                                         -'
    '-------------------------------------------------------------------'
    Sub DistributionStat(ByRef objClass As List(Of Students))

        ' Print title
        System.Console.WriteLine(StrDup(73, "-"))
        System.Console.WriteLine(StrDup(20, " ") & "Grade Distribution Statistics")
        System.Console.WriteLine(StrDup(73, "-"))

        ' Call sub to print a grade Dist. for each letter
        PrintGradeDistribution(objClass, "A")
        PrintGradeDistribution(objClass, "B")
        PrintGradeDistribution(objClass, "C")
        PrintGradeDistribution(objClass, "D")
        PrintGradeDistribution(objClass, "F")
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: PrintGradeDistribution      -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub LINQ queries the objClass list object to find all the-'
    '-   students who earned the letter grade chrGradeLetter.          -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  objClass - List of students to be queried from.                -'
    '-  chrGradeLetter - char to tell the query which letter it should -'
    '-  look for.                                                      -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-  objQuery - object to hold the LINQ query results.              -'
    '-------------------------------------------------------------------'
    Sub PrintGradeDistribution(ByRef objClass As List(Of Students), ByVal chrGradeLetter As Char)
        Dim objQuery As Object

        ' Find all students with the lettergrade chrGradeLetter
        objQuery = From Student In objClass
                   Where Student.strLetterGrade(0) = chrGradeLetter
                   Order By Student.strLastName Ascending
                   Select Student

        ' Print all students in objQuery
        System.Console.WriteLine("Those Students Earning a " & chrGradeLetter & " Grade are:")
        For Each Student In objQuery
            System.Console.WriteLine("   " & Student.strInitials & " " & LSet(Student.strLastName, 11) _
                                     & "--> " & Student.strLetterGrade)
        Next
        System.Console.WriteLine("")

    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: RangeStat                   -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub prints a title then calls PrintGradeRange to print   -'
    '-   the grade range for each assignment.                          -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  objClass - List of students to be past to other sub.           -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-  (none)                                                         -'
    '-------------------------------------------------------------------'
    Sub RangeStat(ByRef objClass As List(Of Students))

        ' Print the title
        System.Console.WriteLine(StrDup(73, "-"))
        System.Console.WriteLine(StrDup(15, " ") & "HomeWork/Exam Grade Range Statistics")
        System.Console.WriteLine(StrDup(73, "-"))
        System.Console.WriteLine(StrDup(15, " ") & "Low" & StrDup(22, " ") _
                                 & "Ave" & StrDup(22, " ") & "High")

        ' Call sub to print each assignment
        PrintGradeRange(objClass, "HW1")
        PrintGradeRange(objClass, "HW2")
        PrintGradeRange(objClass, "HW3")
        PrintGradeRange(objClass, "HW4")
        PrintGradeRange(objClass, "Exam")
        System.Console.WriteLine("")
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: PrintGradeRange             -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub LINQ queries the objClass list object to find the    -'
    '-   lowest, highest, and average score of assignment strAssignment-'
    '-   The sub then prints the grade range for that assignment.      -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  objClass - List of students to be queried from.                -'
    '-  strAssignment - string to tell the sub which assingment to     -'
    '-  find the Grade Range for.                                      -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-  sglAvg - single to hold the average assignment score.          -'
    '-  sglMax - single to hold the highest assignment score.          -'
    '-  sglMin - single to hold the lowest assignment score.           -'
    '-------------------------------------------------------------------'
    Sub PrintGradeRange(ByRef objClass As List(Of Students), ByVal strAssignment As String)
        Dim sglMin
        Dim sglMax
        Dim sglAvg

        ' Check to see what the user wants to print then find and print the Min, Max, and Avg
        If (strAssignment = "HW1") Then
            sglMin = Aggregate nums In objClass Into MinScore = Min(nums.sglHomework1)
            sglAvg = Aggregate nums In objClass Into MinScore = Average(nums.sglHomework1)
            sglMax = Aggregate nums In objClass Into MaxScore = Max(nums.sglHomework1)
            System.Console.WriteLine("Homework 1 :   " & String.Format("{0:N}", (sglMin * 4)) _
                                     & " %" & StrDup(18, ".") & String.Format("{0:N}", (sglAvg * 4)) _
                                     & " %" & StrDup(18, ".") & String.Format("{0:N}", (sglMax * 4)))
        ElseIf (strAssignment = "HW2") Then
            sglMin = Aggregate nums In objClass Into MinScore = Min(nums.sglHomework2)
            sglAvg = Aggregate nums In objClass Into MinScore = Average(nums.sglHomework2)
            sglMax = Aggregate nums In objClass Into MaxScore = Max(nums.sglHomework2)
            System.Console.WriteLine("Homework 2 :   " & String.Format("{0:N}", (sglMin * 4)) _
                                     & " %" & StrDup(18, ".") & String.Format("{0:N}", (sglAvg * 4)) _
                                     & " %" & StrDup(18, ".") & String.Format("{0:N}", (sglMax * 4)))
        ElseIf (strAssignment = "HW3") Then
            sglMin = Aggregate nums In objClass Into MinScore = Min(nums.sglHomework3)
            sglAvg = Aggregate nums In objClass Into MinScore = Average(nums.sglHomework3)
            sglMax = Aggregate nums In objClass Into MaxScore = Max(nums.sglHomework3)
            System.Console.WriteLine("Homework 3 :   " & String.Format("{0:N}", (sglMin * 4)) _
                                     & " %" & StrDup(18, ".") & String.Format("{0:N}", (sglAvg * 4)) _
                                     & " %" & StrDup(18, ".") & String.Format("{0:N}", (sglMax * 4)))
        ElseIf (strAssignment = "HW4") Then
            sglMin = Aggregate nums In objClass Into MinScore = Min(nums.sglHomework4)
            sglAvg = Aggregate nums In objClass Into MinScore = Average(nums.sglHomework4)
            sglMax = Aggregate nums In objClass Into MaxScore = Max(nums.sglHomework4)
            System.Console.WriteLine("Homework 4 :   " & String.Format("{0:N}", (sglMin * 4)) _
                                     & " %" & StrDup(18, ".") & String.Format("{0:N}", (sglAvg * 4)) _
                                     & " %" & StrDup(18, ".") & String.Format("{0:N}", (sglMax * 4)))
        ElseIf (strAssignment = "Exam") Then
            sglMin = Aggregate nums In objClass Into MinScore = Min(nums.sglExamScore)
            sglAvg = Aggregate nums In objClass Into MinScore = Average(nums.sglExamScore)
            sglMax = Aggregate nums In objClass Into MaxScore = Max(nums.sglExamScore)
            System.Console.WriteLine("Exam       :   " & String.Format("{0:N}", sglMin) _
                                     & " %" & StrDup(18, ".") & String.Format("{0:N}", sglAvg) _
                                     & " %" & StrDup(18, ".") & String.Format("{0:N}", sglMax))
        End If

    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: OverallStat                 -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub prints a title then the Lowest and Highest overall   -'
    '-   grade in the class.                                           -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  objClass - List of students to be queried from.                -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-  objQuery - Object to hold the LINQ query.                      -'
    '-  sglMax - single to hold the highest score.                     -'
    '-  sglMin - single to hold the lowest score.                      -'
    '-------------------------------------------------------------------'
    Sub OverallStat(ByRef objClass As List(Of Students))
        Dim sglMin
        Dim sglMax
        Dim objQuery As Object

        ' Find max and min scores of final grade
        sglMin = Aggregate nums In objClass Into MinScore = Min(nums.sglNumericGrade)
        sglMax = Aggregate nums In objClass Into MaxScore = Max(nums.sglNumericGrade)

        ' Find all students who had the higest grade
        objQuery = From Student In objClass
                   Where Student.sglNumericGrade = sglMax
                   Order By Student.strLastName Ascending
                   Select Student

        ' Print all students who had a final grade equal to the higest
        System.Console.WriteLine("The higest course grade of " & sglMax & " was earned by")
        For Each Student In objQuery
            System.Console.WriteLine("   " & Student.strInitials & " " & LSet(Student.strLastName, 11) _
                                     & "--> " & Student.sglNumericGrade)
        Next
        System.Console.WriteLine("")

        ' Find all students who had the lowest score
        objQuery = From Student In objClass
                   Where Student.sglNumericGrade = sglMin
                   Order By Student.strLastName Ascending
                   Select Student

        ' Print all students who had a final grade equal to the lowset
        System.Console.WriteLine("The lowest course grade of " & sglMin & " was earned by")
        For Each Student In objQuery
            System.Console.WriteLine("   " & Student.strInitials & " " & LSet(Student.strLastName, 11) _
                                     & "--> " & Student.sglNumericGrade)
        Next
    End Sub
End Module
