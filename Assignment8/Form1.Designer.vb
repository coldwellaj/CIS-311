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
        Me.dgvResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(12, 335)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.Size = New System.Drawing.Size(759, 256)
        Me.dgvResults.TabIndex = 0
        '
        'pnlSaveCancel
        '
        Me.pnlSaveCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSaveCancel.Controls.Add(Me.cmdCancel)
        Me.pnlSaveCancel.Controls.Add(Me.cmdSave)
        Me.pnlSaveCancel.Location = New System.Drawing.Point(3, 221)
        Me.pnlSaveCancel.Name = "pnlSaveCancel"
        Me.pnlSaveCancel.Size = New System.Drawing.Size(753, 76)
        Me.pnlSaveCancel.TabIndex = 1
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(643, 29)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(53, 29)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(762, 308)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Info"
        '
        'pnlNavigation
        '
        Me.pnlNavigation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigation.Controls.Add(Me.cmdNext)
        Me.pnlNavigation.Controls.Add(Me.cmdLast)
        Me.pnlNavigation.Controls.Add(Me.cmdUpdate)
        Me.pnlNavigation.Controls.Add(Me.cmdDelete)
        Me.pnlNavigation.Controls.Add(Me.cmdBack)
        Me.pnlNavigation.Controls.Add(Me.cmdAdd)
        Me.pnlNavigation.Controls.Add(Me.cmdFirst)
        Me.pnlNavigation.Location = New System.Drawing.Point(3, 139)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.Size = New System.Drawing.Size(753, 76)
        Me.pnlNavigation.TabIndex = 30
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(673, 14)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(29, 49)
        Me.cmdNext.TabIndex = 6
        Me.cmdNext.Text = ">>"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdLast
        '
        Me.cmdLast.Location = New System.Drawing.Point(708, 14)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(32, 49)
        Me.cmdLast.TabIndex = 7
        Me.cmdLast.Text = "|>"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(419, 14)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 49)
        Me.cmdUpdate.TabIndex = 5
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(329, 14)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 49)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(53, 14)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(29, 49)
        Me.cmdBack.TabIndex = 2
        Me.cmdBack.Text = "<<"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(236, 14)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 49)
        Me.cmdAdd.TabIndex = 3
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdFirst
        '
        Me.cmdFirst.Location = New System.Drawing.Point(15, 14)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(32, 49)
        Me.cmdFirst.TabIndex = 1
        Me.cmdFirst.Text = "<|"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Location = New System.Drawing.Point(632, 23)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtIdNumber.TabIndex = 3
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(360, 76)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(173, 20)
        Me.txtZipCode.TabIndex = 7
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(317, 23)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(216, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(95, 50)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(438, 20)
        Me.txtStreetAddress.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(95, 76)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(216, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(317, 76)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(37, 20)
        Me.txtState.TabIndex = 6
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(95, 23)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(216, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'lblIdNumber
        '
        Me.lblIdNumber.AutoSize = True
        Me.lblIdNumber.Location = New System.Drawing.Point(565, 26)
        Me.lblIdNumber.Name = "lblIdNumber"
        Me.lblIdNumber.Size = New System.Drawing.Size(61, 13)
        Me.lblIdNumber.TabIndex = 22
        Me.lblIdNumber.Text = "ID Number:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(23, 53)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 21
        Me.lblAddress.Text = "Address:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(23, 26)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 603)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
