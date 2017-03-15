<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Xeroxing_Progress
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
        Me.pbrCopyProgress = New System.Windows.Forms.ProgressBar()
        Me.lblBytesProcessed = New System.Windows.Forms.Label()
        Me.lblFileNumber = New System.Windows.Forms.Label()
        Me.lblFileProcess = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pbrCopyProgress
        '
        Me.pbrCopyProgress.Location = New System.Drawing.Point(15, 100)
        Me.pbrCopyProgress.Name = "pbrCopyProgress"
        Me.pbrCopyProgress.Size = New System.Drawing.Size(730, 39)
        Me.pbrCopyProgress.TabIndex = 9
        '
        'lblBytesProcessed
        '
        Me.lblBytesProcessed.AutoSize = True
        Me.lblBytesProcessed.Location = New System.Drawing.Point(12, 197)
        Me.lblBytesProcessed.Name = "lblBytesProcessed"
        Me.lblBytesProcessed.Size = New System.Drawing.Size(39, 13)
        Me.lblBytesProcessed.TabIndex = 8
        Me.lblBytesProcessed.Text = "Label4"
        '
        'lblFileNumber
        '
        Me.lblFileNumber.AutoSize = True
        Me.lblFileNumber.Location = New System.Drawing.Point(12, 165)
        Me.lblFileNumber.Name = "lblFileNumber"
        Me.lblFileNumber.Size = New System.Drawing.Size(39, 13)
        Me.lblFileNumber.TabIndex = 7
        Me.lblFileNumber.Text = "Label3"
        '
        'lblFileProcess
        '
        Me.lblFileProcess.AutoSize = True
        Me.lblFileProcess.Location = New System.Drawing.Point(99, 55)
        Me.lblFileProcess.Name = "lblFileProcess"
        Me.lblFileProcess.Size = New System.Drawing.Size(39, 13)
        Me.lblFileProcess.TabIndex = 6
        Me.lblFileProcess.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Processing File:"
        '
        'Xeroxing_Progress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 238)
        Me.Controls.Add(Me.pbrCopyProgress)
        Me.Controls.Add(Me.lblBytesProcessed)
        Me.Controls.Add(Me.lblFileNumber)
        Me.Controls.Add(Me.lblFileProcess)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Xeroxing_Progress"
        Me.Text = "Xeroxing_Progress"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbrCopyProgress As ProgressBar
    Friend WithEvents lblBytesProcessed As Label
    Friend WithEvents lblFileNumber As Label
    Friend WithEvents lblFileProcess As Label
    Friend WithEvents Label1 As Label
End Class
