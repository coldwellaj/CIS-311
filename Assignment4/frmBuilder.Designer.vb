<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuilder
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBackToManager = New System.Windows.Forms.Button()
        Me.lstDegrees = New System.Windows.Forms.ListBox()
        Me.lstProgram = New System.Windows.Forms.ListBox()
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBackToManager
        '
        Me.btnBackToManager.Location = New System.Drawing.Point(30, 12)
        Me.btnBackToManager.Name = "btnBackToManager"
        Me.btnBackToManager.Size = New System.Drawing.Size(727, 46)
        Me.btnBackToManager.TabIndex = 0
        Me.btnBackToManager.Text = "Back to Degree and Course Maintenance"
        Me.btnBackToManager.UseVisualStyleBackColor = True
        '
        'lstDegrees
        '
        Me.lstDegrees.FormattingEnabled = True
        Me.lstDegrees.Location = New System.Drawing.Point(31, 88)
        Me.lstDegrees.Name = "lstDegrees"
        Me.lstDegrees.Size = New System.Drawing.Size(726, 82)
        Me.lstDegrees.TabIndex = 1
        '
        'lstProgram
        '
        Me.lstProgram.FormattingEnabled = True
        Me.lstProgram.Location = New System.Drawing.Point(31, 205)
        Me.lstProgram.Name = "lstProgram"
        Me.lstProgram.Size = New System.Drawing.Size(285, 186)
        Me.lstProgram.TabIndex = 2
        '
        'lstCourses
        '
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.Location = New System.Drawing.Point(469, 205)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.Size = New System.Drawing.Size(288, 186)
        Me.lstCourses.TabIndex = 3
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(359, 227)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 35)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "<-"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(359, 291)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(75, 35)
        Me.cmdRemove.TabIndex = 5
        Me.cmdRemove.Text = "->"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 453)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstCourses)
        Me.Controls.Add(Me.lstProgram)
        Me.Controls.Add(Me.lstDegrees)
        Me.Controls.Add(Me.btnBackToManager)
        Me.Name = "frmBuilder"
        Me.Text = "Degree Builder"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBackToManager As Button
    Friend WithEvents lstDegrees As ListBox
    Friend WithEvents lstProgram As ListBox
    Friend WithEvents lstCourses As ListBox
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdRemove As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
