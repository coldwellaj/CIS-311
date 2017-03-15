<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbxSource = New System.Windows.Forms.GroupBox()
        Me.lstSourceFiles = New System.Windows.Forms.ListBox()
        Me.cmdSetSource = New System.Windows.Forms.Button()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.gbxDirectory = New System.Windows.Forms.GroupBox()
        Me.lstDestinationFiles = New System.Windows.Forms.ListBox()
        Me.cmdSetDestination = New System.Windows.Forms.Button()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.tbrOverwrite = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblFileProcess = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFileNumber = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblByteProcess = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbxSource.SuspendLayout()
        Me.gbxDirectory.SuspendLayout()
        CType(Me.tbrOverwrite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxSource
        '
        Me.gbxSource.Controls.Add(Me.lstSourceFiles)
        Me.gbxSource.Controls.Add(Me.cmdSetSource)
        Me.gbxSource.Controls.Add(Me.txtSource)
        Me.gbxSource.Location = New System.Drawing.Point(21, 27)
        Me.gbxSource.Name = "gbxSource"
        Me.gbxSource.Size = New System.Drawing.Size(822, 215)
        Me.gbxSource.TabIndex = 0
        Me.gbxSource.TabStop = False
        Me.gbxSource.Text = "Source Directory and Files"
        '
        'lstSourceFiles
        '
        Me.lstSourceFiles.FormattingEnabled = True
        Me.lstSourceFiles.Location = New System.Drawing.Point(6, 59)
        Me.lstSourceFiles.Name = "lstSourceFiles"
        Me.lstSourceFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSourceFiles.Size = New System.Drawing.Size(810, 147)
        Me.lstSourceFiles.TabIndex = 2
        '
        'cmdSetSource
        '
        Me.cmdSetSource.Location = New System.Drawing.Point(662, 19)
        Me.cmdSetSource.Name = "cmdSetSource"
        Me.cmdSetSource.Size = New System.Drawing.Size(154, 20)
        Me.cmdSetSource.TabIndex = 1
        Me.cmdSetSource.Text = "Set Source"
        Me.cmdSetSource.UseVisualStyleBackColor = True
        '
        'txtSource
        '
        Me.txtSource.Enabled = False
        Me.txtSource.Location = New System.Drawing.Point(6, 19)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(650, 20)
        Me.txtSource.TabIndex = 0
        '
        'gbxDirectory
        '
        Me.gbxDirectory.Controls.Add(Me.lstDestinationFiles)
        Me.gbxDirectory.Controls.Add(Me.cmdSetDestination)
        Me.gbxDirectory.Controls.Add(Me.txtDestination)
        Me.gbxDirectory.Location = New System.Drawing.Point(21, 259)
        Me.gbxDirectory.Name = "gbxDirectory"
        Me.gbxDirectory.Size = New System.Drawing.Size(822, 215)
        Me.gbxDirectory.TabIndex = 1
        Me.gbxDirectory.TabStop = False
        Me.gbxDirectory.Text = "Destination Directory and Files"
        '
        'lstDestinationFiles
        '
        Me.lstDestinationFiles.AllowDrop = True
        Me.lstDestinationFiles.FormattingEnabled = True
        Me.lstDestinationFiles.Location = New System.Drawing.Point(6, 59)
        Me.lstDestinationFiles.Name = "lstDestinationFiles"
        Me.lstDestinationFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstDestinationFiles.Size = New System.Drawing.Size(810, 147)
        Me.lstDestinationFiles.TabIndex = 3
        '
        'cmdSetDestination
        '
        Me.cmdSetDestination.Location = New System.Drawing.Point(662, 19)
        Me.cmdSetDestination.Name = "cmdSetDestination"
        Me.cmdSetDestination.Size = New System.Drawing.Size(154, 20)
        Me.cmdSetDestination.TabIndex = 2
        Me.cmdSetDestination.Text = "Set Destination"
        Me.cmdSetDestination.UseVisualStyleBackColor = True
        '
        'txtDestination
        '
        Me.txtDestination.Enabled = False
        Me.txtDestination.Location = New System.Drawing.Point(6, 19)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(650, 20)
        Me.txtDestination.TabIndex = 0
        '
        'tbrOverwrite
        '
        Me.tbrOverwrite.Location = New System.Drawing.Point(210, 513)
        Me.tbrOverwrite.Maximum = 1
        Me.tbrOverwrite.Name = "tbrOverwrite"
        Me.tbrOverwrite.Size = New System.Drawing.Size(326, 45)
        Me.tbrOverwrite.TabIndex = 2
        Me.tbrOverwrite.Value = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 545)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 52)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Do Not" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If Filename" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Already Exists"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 545)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 52)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Overwrite" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Existing Copy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If Filename" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exists"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar1, Me.lblFileProcess, Me.lblFileNumber, Me.lblByteProcess})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 618)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(869, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ProgressBar1.Step = 1
        '
        'lblFileProcess
        '
        Me.lblFileProcess.Name = "lblFileProcess"
        Me.lblFileProcess.Size = New System.Drawing.Size(121, 17)
        Me.lblFileProcess.Text = "ToolStripStatusLabel1"
        '
        'lblFileNumber
        '
        Me.lblFileNumber.Name = "lblFileNumber"
        Me.lblFileNumber.Size = New System.Drawing.Size(121, 17)
        Me.lblFileNumber.Text = "ToolStripStatusLabel2"
        '
        'lblByteProcess
        '
        Me.lblByteProcess.Name = "lblByteProcess"
        Me.lblByteProcess.Size = New System.Drawing.Size(121, 17)
        Me.lblByteProcess.Text = "ToolStripStatusLabel3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 640)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbrOverwrite)
        Me.Controls.Add(Me.gbxDirectory)
        Me.Controls.Add(Me.gbxSource)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxSource.ResumeLayout(False)
        Me.gbxSource.PerformLayout()
        Me.gbxDirectory.ResumeLayout(False)
        Me.gbxDirectory.PerformLayout()
        CType(Me.tbrOverwrite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxSource As GroupBox
    Friend WithEvents lstSourceFiles As ListBox
    Friend WithEvents cmdSetSource As Button
    Friend WithEvents txtSource As TextBox
    Friend WithEvents gbxDirectory As GroupBox
    Friend WithEvents lstDestinationFiles As ListBox
    Friend WithEvents cmdSetDestination As Button
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents tbrOverwrite As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents lblFileProcess As ToolStripStatusLabel
    Friend WithEvents lblFileNumber As ToolStripStatusLabel
    Friend WithEvents lblByteProcess As ToolStripStatusLabel
End Class
