Imports System.ComponentModel
'-------------------------------------------------------------------'
'-          File name: frmCalculator.vb                            -'
'-          Part of project: Assignment6                           -'
'-------------------------------------------------------------------'
'-          Written By: Alex Coldwell                              -'
'-          Written On: 02/26/2017                                 -'
'-------------------------------------------------------------------'
'- File Purpose:                                                   -'
'-                                                                 -'
'- This file contains the frmCalculator object. This object holds  -'
'- all of the calculator operation methods for a simple 1970s calc -'
'-------------------------------------------------------------------'
'- Global Variable Dictionary                                      -'
'- dblFirstNumber - double to hold the first input number          -'
'- dblSecondNumber - double to hold the second input number        -'
'- dblTotal - double to hold the total produced by the calculation -'
'- intTotal - integer to hold the total produced by the calculation-'
'- intOperations - integer to tell the calculat funtion what       -'
'-  operator was used                                              -'
'- boolOperator - boolean to tell whether an operator has been used-'
'-------------------------------------------------------------------'
Public Class frmCalculator
    Dim dblFirstNumber As Double
    Dim dblSecondNumber As Double
    Dim dblTotal As Double
    Dim intTotal As Integer
    Dim intOperations As Integer
    Dim boolOperator As Boolean = False

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdClick                    -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/27/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub handles all of the click events on the calculator.   -'
    '-   This sub uses a case switch to tell which button was pressed  -'
    '-   and performs the correct operation for that button.           -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub cmdClick(sender As Object, e As EventArgs) Handles cmdSqrt.Click, cmd0.Click, cmd1.Click,
            cmd2.Click, cmd3.Click, cmd4.Click, cmd5.Click, cmd6.Click, cmd7.Click, cmd8.Click, cmd9.Click,
            cmdAdd.Click, cmdClearAll.Click, cmdClearEntry.Click, cmdCos.Click, cmdDecimal.Click, cmdDivide.Click,
            cmdEquals.Click, cmdMod.Click, cmdMultiply.Click, cmdNegate.Click, cmdPower.Click, cmdSin.Click,
            cmdSqrt.Click, cmdSubtract.Click, cmdTan.Click

        Select Case sender.tag.ToString
            Case "0"
                If txtOutput.Text <> "0" Then
                    txtOutput.Text += "0"
                End If
            Case "1"
                If txtOutput.Text <> "0" Then
                    txtOutput.Text += "1"
                Else
                    txtOutput.Text = "1"
                End If
            Case "2"
                If txtOutput.Text <> "0" Then
                    txtOutput.Text += "2"
                Else
                    txtOutput.Text = "2"
                End If
            Case "3"
                If txtOutput.Text <> "0" Then
                    txtOutput.Text += "3"
                Else
                    txtOutput.Text = "3"
                End If
            Case "4"
                If txtOutput.Text <> "0" Then
                    txtOutput.Text += "4"
                Else
                    txtOutput.Text = "4"
                End If
            Case "5"
                If txtOutput.Text <> "0" Then
                    txtOutput.Text += "5"
                Else
                    txtOutput.Text = "5"
                End If
            Case "6"
                If txtOutput.Text <> "0" Then
                    txtOutput.Text += "6"
                Else
                    txtOutput.Text = "6"
                End If
            Case "7"
                If txtOutput.Text <> "0" Then
                    txtOutput.Text += "7"
                Else
                    txtOutput.Text = "7"
                End If
            Case "8"
                If txtOutput.Text <> "0" Then
                    txtOutput.Text += "8"
                Else
                    txtOutput.Text = "8"
                End If
            Case "9"
                If txtOutput.Text <> "0" Then
                    txtOutput.Text += "9"
                Else
                    txtOutput.Text = "9"
                End If
            Case "."
                If Not (txtOutput.Text.Contains(".")) Then
                    txtOutput.Text += "."
                End If
            Case "+/-"
                Dim strHold As String
                If txtOutput.Text.Contains("-") Then
                    strHold = txtOutput.Text
                    strHold = strHold.Remove(0, 1)
                    txtOutput.Text = strHold
                Else
                    strHold = txtOutput.Text
                    txtOutput.Text = "-" & strHold
                End If
            Case "C"
                txtOutput.Text = "0"
                dblTotal = 0
                boolOperator = False
            Case "CE"
                txtOutput.Text = "0"
            Case "+"
                ' Check for chain combo
                If boolOperator = True Then
                    calculate()
                End If
                dblFirstNumber = txtOutput.Text
                txtOutput.Text = "0"
                boolOperator = True
                intOperations = 1 ' = +
            Case "-"
                ' Check for chain combo
                If boolOperator = True Then
                    calculate()
                End If
                dblFirstNumber = txtOutput.Text
                txtOutput.Text = "0"
                boolOperator = True
                intOperations = 2 ' = -
            Case "*"
                ' Check for chain combo
                If boolOperator = True Then
                    calculate()
                End If
                dblFirstNumber = txtOutput.Text
                txtOutput.Text = "0"
                boolOperator = True
                intOperations = 3 ' = *
            Case "/"
                ' Check for chain combo
                If boolOperator = True Then
                    calculate()
                End If
                dblFirstNumber = txtOutput.Text
                txtOutput.Text = "0"
                boolOperator = True
                intOperations = 4 ' = /
            Case "%"
                ' Check for chain combo
                If boolOperator = True Then
                    calculate()
                End If
                dblFirstNumber = txtOutput.Text
                txtOutput.Text = "0"
                boolOperator = True
                intOperations = 5 ' = %
            Case "^"
                ' Check for chain combo
                If boolOperator = True Then
                    calculate()
                End If
                dblFirstNumber = txtOutput.Text
                txtOutput.Text = "0"
                boolOperator = True
                intOperations = 6 ' = ^
            Case "sin"
                ' Check for chain combo
                If boolOperator = True Then
                    calculate()
                End If
                dblFirstNumber = txtOutput.Text
                boolOperator = True
                intOperations = 7 ' = sin
            Case "cos"
                ' Check for chain combo
                If boolOperator = True Then
                    calculate()
                End If
                dblFirstNumber = txtOutput.Text
                boolOperator = True
                intOperations = 8 ' = cos
            Case "tan"
                ' Check for chain combo
                If boolOperator = True Then
                    calculate()
                End If
                dblFirstNumber = txtOutput.Text
                boolOperator = True
                intOperations = 9 ' = tan
            Case "sqrt"
                ' Check for chain combo
                If boolOperator = True Then
                    calculate()
                End If
                dblFirstNumber = txtOutput.Text
                boolOperator = True
                intOperations = 10 ' = sqrt
            Case "="
                calculate()


        End Select

    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: frmCalculator_Closing       -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/27/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered whenever frmCalculator is closing. It   -'
    '-   checks to see if txtOutput.Text = "0". If not it asks the     -'
    '-   user if they really want to close the Form and either closes  -'
    '-   it or cancles the closing process.                            -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the CancelEventArgs object sent to the routine        -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-  result - integer to hold the result from the yes/no messagebox -'
    '-------------------------------------------------------------------'
    Private Sub frmCalculator_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If txtOutput.Text = "0" Then
        Else
            Dim result As Integer = MessageBox.Show("Do you really want to close this calculator", "You want to close " & Me.Name, MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: frmCalculator_Load          -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/27/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered whenever frmCalculator is loaded. It    -'
    '-   selects rdoFloat as it's default setting and sets txtOutput   -'
    '-   text to "0".                                                  -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOutput.Text = 0
        rdoFloat.Select()
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: calculate                   -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/27/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub performs the seleced operations on dblFirstNumber and-'
    '-   dblSecondNumber and places them in both dblTotal and intTotal.-'
    '-   This sub then prints out either the intTotal or the dblTotal  -'
    '-   depending on which rdoBox is selected.                        -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- (none)                                                          -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '- (none)                                                          -'
    '-------------------------------------------------------------------'
    Public Sub calculate()
        If rdoFloat.Checked Then
            If boolOperator = True Then
                dblSecondNumber = txtOutput.Text
                If intOperations = 1 Then ' = +
                    dblTotal = dblFirstNumber + dblSecondNumber
                    intTotal = dblFirstNumber + dblSecondNumber
                    txtOutput.Text = dblTotal
                ElseIf intOperations = 2 Then ' = -
                    dblTotal = dblFirstNumber - dblSecondNumber
                    intTotal = dblFirstNumber - dblSecondNumber
                    txtOutput.Text = dblTotal
                ElseIf intOperations = 3 Then ' = *
                    dblTotal = dblFirstNumber * dblSecondNumber
                    intTotal = dblFirstNumber * dblSecondNumber
                    txtOutput.Text = dblTotal
                ElseIf intOperations = 4 Then ' = /
                    If dblSecondNumber = 0 Then
                        txtOutput.Text = "Error!"
                    Else
                        dblTotal = dblFirstNumber / dblSecondNumber
                        intTotal = dblFirstNumber / dblSecondNumber
                        txtOutput.Text = dblTotal
                    End If
                ElseIf intOperations = 5 Then ' = %
                    dblTotal = dblFirstNumber Mod dblSecondNumber
                    intTotal = dblFirstNumber Mod dblSecondNumber
                    txtOutput.Text = dblTotal
                ElseIf intOperations = 6 Then ' = ^
                    dblTotal = dblFirstNumber ^ dblSecondNumber
                    intTotal = dblFirstNumber ^ dblSecondNumber
                    txtOutput.Text = dblTotal
                ElseIf intOperations = 7 Then ' = sin
                    dblTotal = Math.Sin(dblFirstNumber)
                    intTotal = Math.Sin(dblFirstNumber)
                    txtOutput.Text = dblTotal
                ElseIf intOperations = 8 Then ' = cos
                    dblTotal = Math.Cos(dblFirstNumber)
                    intTotal = Math.Cos(dblFirstNumber)
                    txtOutput.Text = dblTotal
                ElseIf intOperations = 9 Then ' = tan
                    dblTotal = Math.Tan(dblFirstNumber)
                    intTotal = Math.Tan(dblFirstNumber)
                    txtOutput.Text = dblTotal
                ElseIf intOperations = 10 Then ' = sqrt
                    dblTotal = Math.Sqrt(dblFirstNumber)
                    intTotal = Math.Sqrt(dblFirstNumber)
                    txtOutput.Text = dblTotal

                End If
            End If
        Else
            If boolOperator = True Then
                dblSecondNumber = txtOutput.Text
                If intOperations = 1 Then ' = +
                    intTotal = dblFirstNumber + dblSecondNumber
                    dblTotal = dblFirstNumber + dblSecondNumber
                    txtOutput.Text = intTotal
                ElseIf intOperations = 2 Then ' = -
                    intTotal = dblFirstNumber - dblSecondNumber
                    dblTotal = dblFirstNumber - dblSecondNumber
                    txtOutput.Text = intTotal
                ElseIf intOperations = 3 Then ' = *
                    intTotal = dblFirstNumber * dblSecondNumber
                    dblTotal = dblFirstNumber * dblSecondNumber
                    txtOutput.Text = intTotal
                ElseIf intOperations = 4 Then ' = /
                    If dblSecondNumber = 0 Then
                        txtOutput.Text = "Error!"
                    Else
                        intTotal = dblFirstNumber / dblSecondNumber
                        dblTotal = dblFirstNumber / dblSecondNumber
                        txtOutput.Text = intTotal
                    End If
                ElseIf intOperations = 5 Then ' = %
                    intTotal = dblFirstNumber Mod dblSecondNumber
                    dblTotal = dblFirstNumber Mod dblSecondNumber
                    txtOutput.Text = intTotal
                ElseIf intOperations = 6 Then ' = ^
                    intTotal = dblFirstNumber ^ dblSecondNumber
                    dblTotal = dblFirstNumber ^ dblSecondNumber
                    txtOutput.Text = intTotal
                ElseIf intOperations = 7 Then ' = sin
                    intTotal = Math.Sin(dblFirstNumber)
                    dblTotal = Math.Sin(dblFirstNumber)
                    txtOutput.Text = intTotal
                ElseIf intOperations = 8 Then ' = cos
                    intTotal = Math.Cos(dblFirstNumber)
                    dblTotal = Math.Cos(dblFirstNumber)
                    txtOutput.Text = intTotal
                ElseIf intOperations = 9 Then ' = tan
                    intTotal = Math.Tan(dblFirstNumber)
                    dblTotal = Math.Tan(dblFirstNumber)
                    txtOutput.Text = intTotal
                ElseIf intOperations = 10 Then ' = sqrt
                    intTotal = Math.Sqrt(dblFirstNumber)
                    dblTotal = Math.Sqrt(dblFirstNumber)
                    txtOutput.Text = intTotal

                End If
            End If
        End If
        boolOperator = False
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: gbxDisplay_Enter            -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 02/27/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered whenever the user switches from float   -'
    '-   to int or int to float. It switches the formating of the out- -'
    '-   put from one to the other and disables the decimal button if  -'
    '-   int formating is selected                                     -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub gbxDisplay_Enter(sender As Object, e As EventArgs) Handles rdoFloat.CheckedChanged, rdoInt.CheckedChanged
        Select Case sender.tag.ToString
            Case "Int"
                cmdDecimal.Enabled = False
                txtOutput.Text = intTotal
            Case "Float"
                cmdDecimal.Enabled = True
                txtOutput.Text = dblTotal
        End Select
    End Sub
End Class
