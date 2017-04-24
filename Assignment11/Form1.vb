'--------------------------------------------------------------------'
'-          File name: Form1.vb                                     -'
'-          Part of project: Assignment11                           -'
'--------------------------------------------------------------------'
'-          Written By: Alex Coldwell                               -'
'-          Written On: 04/24/2017                                  -'
'--------------------------------------------------------------------'
'- File Purpose:                                                    -'
'-                                                                  -'
'- This file connects to an access database and then allows the     -'
'- user to cycle through the customers, add new customers, update   -'
'- existing customers, delete customers and there orders.           -'
'--------------------------------------------------------------------'
'- Program Purpose:                                                 -'
'-                                                                  -'
'- This program allows users to view records of customers and       -'
'- their orders at an online store. The user can add new cutomers,  -'
'- update existing cumtomers info, and delete custmers. User cannot -'
'- add orders to the OrderedItems table.                            -'
'--------------------------------------------------------------------'
'- Global Variable Dictionary                                       -'
'- dsOrderedItems - DataSet to hold OrderedItems Table              -'
'- dsCustomers - DataSet to hold Customers Table                    -'
'- DBConn - OleDbConnection to DataBase                             -'
'- DBAdaptOrderedItems - DataAdapter for OrderedItems table         -'
'- DBAdaptCustomers - DataAdapter for Customers table               -'
'--------------------------------------------------------------------'

Imports System.Data.OleDb
Public Class Form1
    'DataSets for OrderedItems and Customers        
    Dim dsOrderedItems As New DataSet
    Dim dsCustomers As New DataSet

    ' DB connection address
    Dim gstrConnString As String = My.Settings.dbConnection

    'DB Connection       
    Dim DBConn As New OleDbConnection(gstrConnString)

    'DBAdapters       
    Dim DBAdaptOrderedItems As OleDbDataAdapter
    Dim DBAdaptCustomers As OleDbDataAdapter
    Dim DBAdaptLocalization As OleDbDataReader


    '-------------------------------------------------------------------'
    '-                    Subprogram Name: Form1_Load                  -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when Form1 is loaded into memory. This  -'
    '-   sub disables textboxes and sets panels. This sub then loads   -'
    '-   the Customers table into the dsCutomers DS. This sub also     -'
    '-   sets bindings on the customer related fields. This Sub then   -'
    '-   loads the info from the ordered Items for the first Customer. -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular form raised the load       –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   strSQLCmd - String to hold the SQL command                    -'
    '-------------------------------------------------------------------'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Disable Textboxes and set panels
        AddNew(False)

        Dim strSQLCmd As String



        'Load up all Customers        
        strSQLCmd = "Select * From Customers"
        DBAdaptCustomers = New OleDbDataAdapter(strSQLCmd, gstrConnString)
        DBAdaptCustomers.Fill(dsCustomers, "Customers")

        'Set bindings on the customer related fields 
        txtFirstName.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.FirstName"))
        txtLastName.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.LastName"))
        txtIdNumber.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.TUID"))
        txtStreetAddress.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.StreetAddress"))
        txtCity.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.City"))
        txtState.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.State"))
        txtZipCode.DataBindings.Add(New Binding("Text", dsCustomers, "Customers.ZipCode"))




        'SQL for Items       
        strSQLCmd = LocationalizeTable() & Trim(txtIdNumber.Text)


        'Hook the data adapter up to run the SQL command on our connection        
        DBAdaptOrderedItems = New OleDbDataAdapter(strSQLCmd, DBConn)

        'Fill the dataset        
        DBAdaptOrderedItems.Fill(dsOrderedItems, "OrderedItems")

        'Now hook the datagridview up to the Addresses table in the dataset        
        dgvResults.DataSource = dsOrderedItems.Tables("OrderedItems")

    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdFirst_Click              -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when cmdFirst is clicked. This sub      -'
    '-   changes the Binding context position to 0, and then refreshed -'
    '-   the DGV.                                                      -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the click   –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        ' Move postion to first row
        BindingContext(dsCustomers, "Customers").Position = 0

        ' Reload DGV
        RefreshDGV()
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdBack_Click               -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when cmdBack is clicked. This sub       -'
    '-   decrements the Binding context position by 1, and then        -'
    '-   refreshed the DGV.                                            -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the click   –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        ' Move position to previous row
        BindingContext(dsCustomers, "Customers").Position = (BindingContext(dsCustomers,
                       "Customers").Position - 1)

        ' Reload DGV
        RefreshDGV()

    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdNext_Click               -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when cmdNext is clicked. This sub       -'
    '-   increments the Binding context position by 1, and then        -'
    '-   refreshed the DGV.                                            -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the click   –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        ' Move Position to next row
        BindingContext(dsCustomers, "Customers").Position = (BindingContext(dsCustomers,
                       "Customers").Position + 1)

        ' Reload DGV
        RefreshDGV()
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdLast_Click               -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when cmdLast is clicked. This sub      -'
    '-   sets the Binding context position to the last position, and   -'
    '-   then refreshed the DGV.                                       -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the click   –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        'Move Position to last row
        BindingContext(dsCustomers, "Customers").Position =
                      (dsCustomers.Tables("Customers").Rows.Count - 1)

        ' Reload DGV
        RefreshDGV()
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdAdd_Click                -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when cmdAdd is clicked. This sub adds a -'
    '-   new element to the dsCustomers. This sub then enables all     -'
    '-   textboxes and clears them.                                    -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the click   –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   cmdBuilder - OleBdCommandBuilder                              -'
    '-------------------------------------------------------------------'
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim cmdBuilder As OleDbCommandBuilder

        cmdBuilder = New OleDbCommandBuilder(DBAdaptCustomers)
        DBAdaptCustomers.InsertCommand = cmdBuilder.GetInsertCommand


        'Clear out the current edits
        BindingContext(dsCustomers, "Customers").EndCurrentEdit()

        'Add a new record to the recordset
        BindingContext(dsCustomers, "Customers").AddNew()


        ' Enable Textboxes and switch panels
        AddNew(True)
        For Each Elem As Control In GroupBox1.Controls
            If Elem.GetType.Name = "TextBox" Then
                Elem.Text = ""
            End If

        Next

        txtIdNumber.Text = dsCustomers.Tables("Customers").Rows.Count + 1


    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdCancel_Click             -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when cmdCancel is clicked. This sub     -'
    '-   cancels the current edit being made on the dsCustomers DS.    -'
    '-   This sub then calls cmdFirst_Click and AddNew(False).         -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the click   –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        BindingContext(dsCustomers, "Customers").CancelCurrentEdit()
        cmdFirst_Click(sender, e)

        ' Disable Textboxes and switch panels
        AddNew(False)
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdSave_Click               -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when cmdSave is clicked. This sub       -'
    '-   commits the changes done to the DS to DB, then calls          -'
    '-   cmdFirst_Click And AddNew(False).                             -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the click   –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        'Stop any current edits.
        BindingContext(dsCustomers, "Customers").EndCurrentEdit()

        'Update the database
        DBConn.Open()
        DBAdaptCustomers.Update(dsCustomers, "Customers")
        DBConn.Close()

        'Update the dataset to correspond with database.
        dsCustomers.AcceptChanges()

        cmdLast_Click(sender, e)

        ' Disable Textboxes and switch panels
        AddNew(False)
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdUpdate_Click             -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when cmdUpdate is clicked. This sub     -'
    '-   enables the text box for users to edit.                       -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the click   –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   cmdBuilder - OleBdCommandBuilder                              -'
    '-------------------------------------------------------------------'
    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim cmdBuilder As OleDbCommandBuilder

        cmdBuilder = New OleDbCommandBuilder(DBAdaptCustomers)
        DBAdaptCustomers.InsertCommand = cmdBuilder.GetInsertCommand


        ' Clear out the current edits
        BindingContext(dsCustomers, "Customers").EndCurrentEdit()

        ' Enable Textboxes and switch panels
        AddNew(True)
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: AddNew                      -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub either enables or disables textboxes.                -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- choice - boolean on weither to enable or disable textboxes.     -' 
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Public Sub AddNew(choice As Boolean)
        If choice = True Then
            txtCity.Enabled = True
            txtFirstName.Enabled = True
            txtLastName.Enabled = True
            txtState.Enabled = True
            txtStreetAddress.Enabled = True
            txtZipCode.Enabled = True
            pnlNavigation.Visible = False
            pnlSaveCancel.Visible = True
        Else
            txtCity.Enabled = False
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            txtState.Enabled = False
            txtStreetAddress.Enabled = False
            txtZipCode.Enabled = False
            txtIdNumber.Enabled = False
            pnlNavigation.Visible = True
            pnlSaveCancel.Visible = False
        End If
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: RefreshDGV                  -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is clears all Items in the dsOrderedItems and then   -'
    '-   reloads the info from the Ordered Items for the current Cust. -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- (none)                                                          -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   strSQLCmd - string to hold SQl command                        -'
    '-------------------------------------------------------------------'
    Public Sub RefreshDGV()
        ' Clear dataset
        dsOrderedItems.Clear()

        Dim strSQLCmd As String
        'SQL for Items       
        strSQLCmd = LocationalizeTable() & Trim(txtIdNumber.Text)


        'Hook the data adapter up to run the SQL command on our connection        
        DBAdaptOrderedItems = New OleDbDataAdapter(strSQLCmd, DBConn)

        'Fill the dataset        
        DBAdaptOrderedItems.Fill(dsOrderedItems, "OrderedItems")

        'Now hook the datagridview up to the Addresses table in the dataset        
        dgvResults.DataSource = dsOrderedItems.Tables("OrderedItems")
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdDelete_Click             -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when cmdDelete is clicked. This sub     -'
    '-   prompts the user wiether or not they would like to delete the -'
    '-   selected record if the user says yes it gets deleted, if no   -'
    '-   sub does nothing. The sub then refreshes the data set.        -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the click   –'
    '-          event                                                  -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   cmdBuilder - OleBdCommandBuilder                              -'
    '-------------------------------------------------------------------'
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim strSQLCmd As String
        DBConn = New OleDbConnection(gstrConnString)
        DBConn.Open()
        Dim DBCmd As OleDbCommand = New OleDbCommand()
        Dim intResult As Integer = MessageBox.Show("Are you Sure you want to delete " & txtFirstName.Text &
                                                 txtLastName.Text & " from the data base?", "Caution: Entering Danger Zone" _
                                                 , MessageBoxButtons.YesNo)
        If intResult = DialogResult.Yes Then
            ' Delete Customer
            DBCmd.CommandText = "Delete From Customers Where TUID = " & txtIdNumber.Text
            DBCmd.Connection = DBConn
            DBCmd.ExecuteNonQuery()

            ' Delete Items Ordered by Customer
            DBCmd.CommandText = "Delete From OrderedItems Where CustomerID = " & txtIdNumber.Text
            DBCmd.ExecuteNonQuery()
            DBConn.Close()
        End If

        'refresh dataset

        dsCustomers.Clear()
        strSQLCmd = "Select * From Customers"
        DBAdaptCustomers = New OleDbDataAdapter(strSQLCmd, gstrConnString)
        DBAdaptCustomers.Fill(dsCustomers, "Customers")


        BindingContext(dsCustomers, "Customers").Position = 0
    End Sub


    '-------------------------------------------------------------------'
    '-                    Subprogram Name: LocationalizeTable          -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 04/24/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub returns the sql statement with the proper titles     -'
    '-   depending on the default language                             -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- (none)                                                          -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Function LocationalizeTable() As String
        If My.Settings.defaultLanguage = "Español" Then
            Return "Select (ItemNumber) AS [Número de artículo], (ItemName) AS [Nombre del árticulo], " &
                "(Quantity) AS [Cantidad], (ItemPrice) As [Precio del articulo], (Quantity * ItemPrice) AS [Total]" &
                "From OrderedItems Where CustomerID = "
        ElseIf My.Settings.defaultLanguage = "Norsk" Then
            Return "Select (ItemNumber) AS [Artikkelnummer], (ItemName) AS [Gjenstandsnavn], " &
                "(Quantity) AS [Mengde], (ItemPrice) As [Varepris], (Quantity * ItemPrice) AS [Total]" &
                "From OrderedItems Where CustomerID = "
        Else
            Return "Select ItemNumber, ItemName, " & "Quantity, ItemPrice, (Quantity * ItemPrice) AS [Total]" &
                "From OrderedItems Where CustomerID = "
        End If
    End Function
End Class
