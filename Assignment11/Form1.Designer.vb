<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.pnlSaveCancel = New System.Windows.Forms.Panel()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlNavigation = New System.Windows.Forms.Panel()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdLast = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdFirst = New System.Windows.Forms.Button()
        Me.txtIdNumber = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblIdNumber = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSaveCancel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlNavigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvResults
        '
        resources.ApplyResources(Me.dgvResults, "dgvResults")
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.TabStop = False
        '
        'pnlSaveCancel
        '
        resources.ApplyResources(Me.pnlSaveCancel, "pnlSaveCancel")
        Me.pnlSaveCancel.Controls.Add(Me.cmdCancel)
        Me.pnlSaveCancel.Controls.Add(Me.cmdSave)
        Me.pnlSaveCancel.Name = "pnlSaveCancel"
        '
        'cmdCancel
        '
        resources.ApplyResources(Me.cmdCancel, "cmdCancel")
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        resources.ApplyResources(Me.cmdSave, "cmdSave")
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.pnlNavigation)
        Me.GroupBox1.Controls.Add(Me.txtIdNumber)
        Me.GroupBox1.Controls.Add(Me.txtZipCode)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtStreetAddress)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.lblIdNumber)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.pnlSaveCancel)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'pnlNavigation
        '
        resources.ApplyResources(Me.pnlNavigation, "pnlNavigation")
        Me.pnlNavigation.Controls.Add(Me.cmdNext)
        Me.pnlNavigation.Controls.Add(Me.cmdLast)
        Me.pnlNavigation.Controls.Add(Me.cmdUpdate)
        Me.pnlNavigation.Controls.Add(Me.cmdDelete)
        Me.pnlNavigation.Controls.Add(Me.cmdBack)
        Me.pnlNavigation.Controls.Add(Me.cmdAdd)
        Me.pnlNavigation.Controls.Add(Me.cmdFirst)
        Me.pnlNavigation.Name = "pnlNavigation"
        '
        'cmdNext
        '
        resources.ApplyResources(Me.cmdNext, "cmdNext")
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdLast
        '
        resources.ApplyResources(Me.cmdLast, "cmdLast")
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        resources.ApplyResources(Me.cmdUpdate, "cmdUpdate")
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        resources.ApplyResources(Me.cmdDelete, "cmdDelete")
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        resources.ApplyResources(Me.cmdBack, "cmdBack")
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        resources.ApplyResources(Me.cmdAdd, "cmdAdd")
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdFirst
        '
        resources.ApplyResources(Me.cmdFirst, "cmdFirst")
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'txtIdNumber
        '
        resources.ApplyResources(Me.txtIdNumber, "txtIdNumber")
        Me.txtIdNumber.Name = "txtIdNumber"
        '
        'txtZipCode
        '
        resources.ApplyResources(Me.txtZipCode, "txtZipCode")
        Me.txtZipCode.Name = "txtZipCode"
        '
        'txtLastName
        '
        resources.ApplyResources(Me.txtLastName, "txtLastName")
        Me.txtLastName.Name = "txtLastName"
        '
        'txtStreetAddress
        '
        resources.ApplyResources(Me.txtStreetAddress, "txtStreetAddress")
        Me.txtStreetAddress.Name = "txtStreetAddress"
        '
        'txtCity
        '
        resources.ApplyResources(Me.txtCity, "txtCity")
        Me.txtCity.Name = "txtCity"
        '
        'txtState
        '
        resources.ApplyResources(Me.txtState, "txtState")
        Me.txtState.Name = "txtState"
        '
        'txtFirstName
        '
        resources.ApplyResources(Me.txtFirstName, "txtFirstName")
        Me.txtFirstName.Name = "txtFirstName"
        '
        'lblIdNumber
        '
        resources.ApplyResources(Me.lblIdNumber, "lblIdNumber")
        Me.lblIdNumber.Name = "lblIdNumber"
        '
        'lblAddress
        '
        resources.ApplyResources(Me.lblAddress, "lblAddress")
        Me.lblAddress.Name = "lblAddress"
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.Name = "lblName"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSaveCancel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlNavigation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents pnlSaveCancel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents txtIdNumber As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblIdNumber As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents cmdNext As Button
    Friend WithEvents cmdLast As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdBack As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdFirst As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdSave As Button
End Class
