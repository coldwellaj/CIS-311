<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Language
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Language))
        Me.cbxLanguage = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxLanguage
        '
        resources.ApplyResources(Me.cbxLanguage, "cbxLanguage")
        Me.cbxLanguage.FormattingEnabled = True
        Me.cbxLanguage.Items.AddRange(New Object() {resources.GetString("cbxLanguage.Items"), resources.GetString("cbxLanguage.Items1"), resources.GetString("cbxLanguage.Items2")})
        Me.cbxLanguage.Name = "cbxLanguage"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cmdSelect
        '
        resources.ApplyResources(Me.cmdSelect, "cmdSelect")
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'Language
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxLanguage)
        Me.Name = "Language"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxLanguage As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdSelect As Button
End Class
