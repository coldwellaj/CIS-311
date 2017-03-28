Imports System.Data.OleDb
Public Class Form1
    Public Const gstrDBName As String = "HW8.accdb"

    Public intCustID As Integer = 1

    'This is where our results will land        
    Dim dsOrderedItems As New DataSet
    Dim dsCustomers As New DataSet

    Const gstrConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & gstrDBName &
                                            ";Persist Security Info=False"

    'Here's the connection to the database object        
    Dim DBConn As New OleDbConnection(gstrConnString)

    'We will use this to fill our data set with the DB        
    Dim DBAdaptOrderedItems As OleDbDataAdapter
    Dim DBAdaptCustomers As OleDbDataAdapter



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
        strSQLCmd = "Select ItemNumber, ItemName, Quantity, ItemPrice, (Quantity * ItemPrice) AS [Total]" &
            "From OrderedItems Where CustomerID = " & Trim(txtIdNumber.Text)


        'Hook the data adapter up to run the SQL command on our connection        
        DBAdaptOrderedItems = New OleDbDataAdapter(strSQLCmd, DBConn)

        'Fill the dataset        
        DBAdaptOrderedItems.Fill(dsOrderedItems, "OrderedItems")

        'Now hook the datagridview up to the Addresses table in the dataset        
        dgvResults.DataSource = dsOrderedItems.Tables("OrderedItems")

    End Sub

    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        ' Move postion to first row
        BindingContext(dsCustomers, "Customers").Position = 0

        ' Reload DGV
        RefreshDGV()
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        ' Move position to previous row
        BindingContext(dsCustomers, "Customers").Position = (BindingContext(dsCustomers,
                       "Customers").Position - 1)

        ' Reload DGV
        RefreshDGV()

    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        ' Move Position to next row
        BindingContext(dsCustomers, "Customers").Position = (BindingContext(dsCustomers,
                       "Customers").Position + 1)

        ' Reload DGV
        RefreshDGV()
    End Sub

    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        'Move Position to last row
        BindingContext(dsCustomers, "Customers").Position =
                      (dsCustomers.Tables("Customers").Rows.Count - 1)

        ' Reload DGV
        RefreshDGV()
    End Sub

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



    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        BindingContext(dsCustomers, "Customers").CancelCurrentEdit()
        cmdFirst_Click(sender, e)

        ' Disable Textboxes and switch panels
        AddNew(False)
    End Sub

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

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim cmdBuilder As OleDbCommandBuilder

        cmdBuilder = New OleDbCommandBuilder(DBAdaptCustomers)
        DBAdaptCustomers.InsertCommand = cmdBuilder.GetInsertCommand


        'Clear out the current edits
        BindingContext(dsCustomers, "Customers").EndCurrentEdit()

        ' Enable Textboxes and switch panels
        AddNew(True)
    End Sub

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

    Public Sub RefreshDGV()
        ' Clear dataset
        dsOrderedItems.Clear()

        Dim strSQLCmd As String
        'SQL for Items       
        strSQLCmd = "Select ItemNumber, ItemName, Quantity, ItemPrice, (Quantity * ItemPrice) AS [Total]" &
            "From OrderedItems Where CustomerID = " & Trim(txtIdNumber.Text)


        'Hook the data adapter up to run the SQL command on our connection        
        DBAdaptOrderedItems = New OleDbDataAdapter(strSQLCmd, DBConn)

        'Fill the dataset        
        DBAdaptOrderedItems.Fill(dsOrderedItems, "OrderedItems")

        'Now hook the datagridview up to the Addresses table in the dataset        
        dgvResults.DataSource = dsOrderedItems.Tables("OrderedItems")
    End Sub

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
End Class
