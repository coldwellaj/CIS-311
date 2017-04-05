'-------------------------------------------------------------------'
'-          File name: clsEmployee.vb                              -'
'-          Part of project: Assignment9                           -'
'-------------------------------------------------------------------'
'-          Written By: Alex Coldwell                              -'
'-          Written On: 04/05/2017                                 -'
'-------------------------------------------------------------------'
'- File Purpose:                                                   -'
'-                                                                 -'
'- This file contains the clsEmployee class it's properties and    -'
'- its' subroutines.                                               -'
'-------------------------------------------------------------------'
'- Global Variable Dictionary                                      -'
'- strName: A string to hold the Name of the employee              -'
'- intId: A Integer to hold the Id of the employee                 -'
'- dblPay: A double to hold the Pay of the employee                -'
'- intHours(7): An Array of 7 integers to hold the hours each day  -'
'-              of the week
'-------------------------------------------------------------------'
Public Class clsEmployee
    Public strName As String
    Public intId As Integer
    Public dblPay As Double
    Public intHours(7) As Integer

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: New                         -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/05/2017                       -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user creates a new instence    -'
    '-   of clsEmployees. It takes a string an integer, a double, and  -'
    '-   an array of integers and sets them to the properties of the 
    '-   Class instence.                                               -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  _Name - String to hold the Name input.                         -'
    '-  _Id - Integer to hold the Id input.                            -'
    '-  _Pay - Double to hold the Pay Rate input.                      -'
    '-  _Hours() - array of integer to hold the input for hours        -'
    '-  worked on each day of the week.                                -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Public Sub New(_Name As String, _Id As Integer, _Pay As Double, _Hours() As Integer)
            strName = _Name
            intId = _Id
            dblPay = _Pay
            Array.Copy(_Hours, intHours, 7)
        End Sub
    '-------------------------------------------------------------------'
    '-                    Function Name: Hours                         -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/05/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub uses the properties of the class object to find and  -'
    '-   retrun the total hours worked for the week.                   -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  (none)                                                         -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-  (none)                                                         -'
    '-------------------------------------------------------------------'
    Public Function Hours()
        Dim dblTotal As Integer = 0

        For intI As Integer = 0 To 6
            dblTotal += intHours(intI)
        Next

        Return dblTotal
    End Function

End Class
