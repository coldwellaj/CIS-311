'-------------------------------------------------------------------'
'-          File name: Module1.vb                                  -'
'-          Part of project: Assignment9                           -'
'-------------------------------------------------------------------'
'-          Written By: Alex Coldwell                              -'
'-          Written On: 04/05/2017                                 -'
'-------------------------------------------------------------------'
'- File Purpose:                                                   -'
'-                                                                 -'
'- This file runs the program. It stores the employee info in the  -'
'- ArrayList myEmps and then uses the Microsoft Office Excel       -'
'- Library to create a payroll spreadsheet in Excel.               -'
'-------------------------------------------------------------------'
'- Program Purpose:                                                -'
'-                                                                 -'
'- This program creates an Excel payroll spreadsheet complete with -'
'- Name, ID, Payrate, Hours, and Total Pay for each employee and   -'
'- Average, Min, Max, and Total for each Coloumn.                  -'
'-------------------------------------------------------------------'
'- Global Variable Dictionary                                      -'
'- (none)                                                          -'
'-------------------------------------------------------------------'

Imports Microsoft.Office.Interop
Module Module1
    Const intOvertime As Integer = 40

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: Main                        -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/05/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub runs the program, it first creates and ArrayList of  -'
    '-   the clsEmployee type. The Sub then fills in the info given for-'
    '-   each employee. This Sub then creates on Excel spreadsheet for -'
    '-   employee payroll. This sub then prints to the Excel           -'
    '-   the Average, Min, Max, and Total for each column. This sub    -'
    '-   then prompts the user that their spreadsheet is complete and  -'
    '-   leaves the spreadsheet open for the user to view.             -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  (none)                                                         -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-  myEmps: ArrayList of clsEmployees                              -'
    '-  CheckExcel: An object to check if Excel is running or not      -'
    '-  anExcelDoc: An Excel Application                               -'
    '-  intLoop: Integer counter to keep track of which row is being   -'
    '-      printed                                                    -'
    '-  intEmpsLength: current length of the myEmps ArrayList          -'
    '-------------------------------------------------------------------'
    Sub Main()
        Dim myEmps As New ArrayList()

        myEmps.Add(New clsEmployee("Sue", 103, 15.25, {8, 8, 8, 8, 8, 0, 0}))
        myEmps.Add(New clsEmployee("Scott", 105, 15.0, {10, 10, 0, 10, 10, 10, 0}))
        myEmps.Add(New clsEmployee("Bill", 106, 12.0, {8, 8, 8, 8, 9, 0, 0}))
        myEmps.Add(New clsEmployee("Tina", 107, 16.0, {8, 8, 8, 8, 8, 0, 0}))
        myEmps.Add(New clsEmployee("Ron", 108, 15.5, {0, 0, 9, 9, 9, 9, 9}))
        myEmps.Add(New clsEmployee("Barb", 109, 13.0, {0, 10, 0, 10, 10, 10, 0}))
        myEmps.Add(New clsEmployee("Cathy", 110, 14.5, {8, 8, 8, 8, 8, 0, 0}))
        myEmps.Add(New clsEmployee("Al", 111, 15.0, {10, 10, 10, 10, 8, 0, 0}))
        myEmps.Add(New clsEmployee("Dave", 133, 15.5, {0, 0, 8, 8, 8, 8, 8}))
        myEmps.Add(New clsEmployee("Haley", 134, 16.5, {8, 8, 8, 8, 8, 0, 0}))
        myEmps.Add(New clsEmployee("Drew", 136, 12.25, {10, 10, 0, 0, 10, 10, 0}))
        myEmps.Add(New clsEmployee("John", 137, 13.0, {8, 8, 8, 8, 8, 0, 0}))
        myEmps.Add(New clsEmployee("Mary", 138, 14.0, {8, 8, 8, 8, 8, 0, 0}))
        myEmps.Add(New clsEmployee("Ann", 139, 15.0, {0, 0, 0, 10, 10, 10, 10}))
        myEmps.Add(New clsEmployee("Chuck", 140, 15.0, {0, 8, 8, 8, 8, 8, 0}))

        Dim CheckExcel As Object
        Dim anExcelDoc As Excel.Application
        Dim intLoop As Integer
        Dim intEmpsLength As Integer = myEmps.Count()

        'Check to see if Excel is already loaded in memory

        Try
            CheckExcel = GetObject(, "Excel.Application")
        Catch Ex As Exception
            'Excel was not running, so we got an error
        End Try

        If CheckExcel Is Nothing Then
            'Create a new instance of Excel
            anExcelDoc = New Excel.Application()
            anExcelDoc.Visible = True
        Else
            anExcelDoc = CheckExcel
            anExcelDoc.Visible = True
        End If

        'Add a new workbook and a new sheet
        anExcelDoc.Workbooks.Add()
        anExcelDoc.Sheets.Add()

        anExcelDoc.Cells(1, 1) = "Name"
        anExcelDoc.Cells(1, 2) = "ID"
        anExcelDoc.Cells(1, 3) = "Payrate"
        anExcelDoc.Cells(1, 4) = "Hours"
        anExcelDoc.Cells(1, 5) = "Total"

        'Put some data on the sheet
        For intLoop = 0 To intEmpsLength - 1
            anExcelDoc.Cells(intLoop + 2, 1) = myEmps(intLoop).strName
            anExcelDoc.Cells(intLoop + 2, 2) = myEmps(intLoop).intId
            anExcelDoc.Cells(intLoop + 2, 3) = myEmps(intLoop).dblPay
            anExcelDoc.Cells(intLoop + 2, 4) = myEmps(intLoop).Hours()
            anExcelDoc.Cells(intLoop + 2, 5) = "=IF(D" & (intLoop + 2) & ">" _
                & intOvertime & ",((D" & (intLoop + 2) & "-" & intOvertime _
                & ")*(C" & (intLoop + 2) & "*1.5))+(C" & (intLoop + 2) _
                & "*" & intOvertime & "),(D" & (intLoop + 2) & "*C" & (intLoop + 2) _
                & "))"
        Next

        ' Labels
        anExcelDoc.Cells(intEmpsLength + 3, 2) = "Aver:"
        anExcelDoc.Cells(intEmpsLength + 4, 2) = "Min:"
        anExcelDoc.Cells(intEmpsLength + 5, 2) = "Max:"
        anExcelDoc.Cells(intEmpsLength + 6, 2) = "Total:"

        ' Payrate
        anExcelDoc.Cells(intEmpsLength + 3, 3) = "=AVERAGE(C2:C" & intEmpsLength + 1 & ")"
        anExcelDoc.Cells(intEmpsLength + 4, 3) = "=MIN(C2:C" & intEmpsLength + 1 & ")"
        anExcelDoc.Cells(intEmpsLength + 5, 3) = "=MAX(C2:C" & intEmpsLength + 1 & ")"
        anExcelDoc.Cells(intEmpsLength + 6, 3) = "=SUM(C2:C" & intEmpsLength + 1 & ")"

        ' Hours
        anExcelDoc.Cells(intEmpsLength + 3, 4) = "=AVERAGE(D2:D" & intEmpsLength + 1 & ")"
        anExcelDoc.Cells(intEmpsLength + 4, 4) = "=MIN(D2:D" & intEmpsLength + 1 & ")"
        anExcelDoc.Cells(intEmpsLength + 5, 4) = "=MAX(D2:D" & intEmpsLength + 1 & ")"
        anExcelDoc.Cells(intEmpsLength + 6, 4) = "=SUM(D2:D" & intEmpsLength + 1 & ")"

        ' Total
        anExcelDoc.Cells(intEmpsLength + 3, 5) = "=AVERAGE(E2:E" & intEmpsLength + 1 & ")"
        anExcelDoc.Cells(intEmpsLength + 4, 5) = "=MIN(E2:E" & intEmpsLength + 1 & ")"
        anExcelDoc.Cells(intEmpsLength + 5, 5) = "=MAX(E2:E" & intEmpsLength + 1 & ")"
        anExcelDoc.Cells(intEmpsLength + 6, 5) = "=SUM(E2:E" & intEmpsLength + 1 & ")"

    End Sub

End Module
