<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.gbxDisplay = New System.Windows.Forms.GroupBox()
        Me.rdoInt = New System.Windows.Forms.RadioButton()
        Me.rdoFloat = New System.Windows.Forms.RadioButton()
        Me.cmdSqrt = New System.Windows.Forms.Button()
        Me.cmdSin = New System.Windows.Forms.Button()
        Me.cmdCos = New System.Windows.Forms.Button()
        Me.cmdTan = New System.Windows.Forms.Button()
        Me.cmdClearAll = New System.Windows.Forms.Button()
        Me.cmdClearEntry = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.cmd9 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmdNegate = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.cmdDecimal = New System.Windows.Forms.Button()
        Me.cmdMod = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdSubtract = New System.Windows.Forms.Button()
        Me.cmdEquals = New System.Windows.Forms.Button()
        Me.gbxDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Enabled = False
        Me.txtOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(12, 12)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(323, 29)
        Me.txtOutput.TabIndex = 0
        Me.txtOutput.TabStop = False
        Me.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbxDisplay
        '
        Me.gbxDisplay.Controls.Add(Me.rdoInt)
        Me.gbxDisplay.Controls.Add(Me.rdoFloat)
        Me.gbxDisplay.Location = New System.Drawing.Point(211, 66)
        Me.gbxDisplay.Name = "gbxDisplay"
        Me.gbxDisplay.Size = New System.Drawing.Size(124, 39)
        Me.gbxDisplay.TabIndex = 1
        Me.gbxDisplay.TabStop = False
        Me.gbxDisplay.Text = "Display Mode"
        '
        'rdoInt
        '
        Me.rdoInt.AutoSize = True
        Me.rdoInt.Location = New System.Drawing.Point(71, 16)
        Me.rdoInt.Name = "rdoInt"
        Me.rdoInt.Size = New System.Drawing.Size(37, 17)
        Me.rdoInt.TabIndex = 2
        Me.rdoInt.TabStop = True
        Me.rdoInt.Tag = "Int"
        Me.rdoInt.Text = "Int"
        Me.rdoInt.UseVisualStyleBackColor = True
        '
        'rdoFloat
        '
        Me.rdoFloat.AutoSize = True
        Me.rdoFloat.Location = New System.Drawing.Point(6, 16)
        Me.rdoFloat.Name = "rdoFloat"
        Me.rdoFloat.Size = New System.Drawing.Size(48, 17)
        Me.rdoFloat.TabIndex = 0
        Me.rdoFloat.TabStop = True
        Me.rdoFloat.Tag = "Float"
        Me.rdoFloat.Text = "Float"
        Me.rdoFloat.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.Location = New System.Drawing.Point(12, 66)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(52, 39)
        Me.cmdSqrt.TabIndex = 1
        Me.cmdSqrt.Tag = "sqrt"
        Me.cmdSqrt.Text = "sqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        Me.cmdSin.Location = New System.Drawing.Point(12, 111)
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.Size = New System.Drawing.Size(52, 39)
        Me.cmdSin.TabIndex = 2
        Me.cmdSin.Tag = "sin"
        Me.cmdSin.Text = "sin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdCos
        '
        Me.cmdCos.Location = New System.Drawing.Point(70, 111)
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.Size = New System.Drawing.Size(52, 39)
        Me.cmdCos.TabIndex = 3
        Me.cmdCos.Tag = "cos"
        Me.cmdCos.Text = "cos"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        Me.cmdTan.Location = New System.Drawing.Point(128, 111)
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.Size = New System.Drawing.Size(52, 39)
        Me.cmdTan.TabIndex = 5
        Me.cmdTan.Tag = "tan"
        Me.cmdTan.Text = "tan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdClearAll
        '
        Me.cmdClearAll.Location = New System.Drawing.Point(217, 111)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.Size = New System.Drawing.Size(52, 39)
        Me.cmdClearAll.TabIndex = 6
        Me.cmdClearAll.Tag = "C"
        Me.cmdClearAll.Text = "C"
        Me.cmdClearAll.UseVisualStyleBackColor = True
        '
        'cmdClearEntry
        '
        Me.cmdClearEntry.Location = New System.Drawing.Point(275, 111)
        Me.cmdClearEntry.Name = "cmdClearEntry"
        Me.cmdClearEntry.Size = New System.Drawing.Size(52, 39)
        Me.cmdClearEntry.TabIndex = 7
        Me.cmdClearEntry.Tag = "CE"
        Me.cmdClearEntry.Text = "CE"
        Me.cmdClearEntry.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Location = New System.Drawing.Point(12, 174)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(52, 39)
        Me.cmd7.TabIndex = 8
        Me.cmd7.Tag = "7"
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Location = New System.Drawing.Point(70, 174)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(52, 39)
        Me.cmd8.TabIndex = 9
        Me.cmd8.Tag = "8"
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.Location = New System.Drawing.Point(128, 174)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(52, 39)
        Me.cmd9.TabIndex = 10
        Me.cmd9.Tag = "9"
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(12, 219)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(52, 39)
        Me.cmd4.TabIndex = 11
        Me.cmd4.Tag = "4"
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Location = New System.Drawing.Point(70, 219)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(52, 39)
        Me.cmd5.TabIndex = 12
        Me.cmd5.Tag = "5"
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Location = New System.Drawing.Point(128, 219)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(52, 39)
        Me.cmd6.TabIndex = 13
        Me.cmd6.Tag = "6"
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(12, 262)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(52, 39)
        Me.cmd1.TabIndex = 14
        Me.cmd1.Tag = "1"
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(70, 262)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(52, 39)
        Me.cmd2.TabIndex = 15
        Me.cmd2.Tag = "2"
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(128, 262)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(52, 39)
        Me.cmd3.TabIndex = 16
        Me.cmd3.Tag = "3"
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmdNegate
        '
        Me.cmdNegate.Location = New System.Drawing.Point(12, 307)
        Me.cmdNegate.Name = "cmdNegate"
        Me.cmdNegate.Size = New System.Drawing.Size(52, 39)
        Me.cmdNegate.TabIndex = 17
        Me.cmdNegate.Tag = "+/-"
        Me.cmdNegate.Text = "+/-"
        Me.cmdNegate.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Location = New System.Drawing.Point(70, 307)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(52, 39)
        Me.cmd0.TabIndex = 18
        Me.cmd0.Tag = "0"
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmdDecimal
        '
        Me.cmdDecimal.Location = New System.Drawing.Point(128, 307)
        Me.cmdDecimal.Name = "cmdDecimal"
        Me.cmdDecimal.Size = New System.Drawing.Size(52, 39)
        Me.cmdDecimal.TabIndex = 19
        Me.cmdDecimal.Tag = "."
        Me.cmdDecimal.Text = "."
        Me.cmdDecimal.UseVisualStyleBackColor = True
        '
        'cmdMod
        '
        Me.cmdMod.Location = New System.Drawing.Point(217, 174)
        Me.cmdMod.Name = "cmdMod"
        Me.cmdMod.Size = New System.Drawing.Size(52, 39)
        Me.cmdMod.TabIndex = 20
        Me.cmdMod.Tag = "%"
        Me.cmdMod.Text = "%"
        Me.cmdMod.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Location = New System.Drawing.Point(275, 174)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(52, 39)
        Me.cmdPower.TabIndex = 21
        Me.cmdPower.Tag = "^"
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(217, 219)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(52, 39)
        Me.cmdMultiply.TabIndex = 22
        Me.cmdMultiply.Tag = "*"
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Location = New System.Drawing.Point(275, 219)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(52, 39)
        Me.cmdDivide.TabIndex = 23
        Me.cmdDivide.Tag = "/"
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(217, 262)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(52, 39)
        Me.cmdAdd.TabIndex = 24
        Me.cmdAdd.Tag = "+"
        Me.cmdAdd.Text = "+"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdSubtract
        '
        Me.cmdSubtract.Location = New System.Drawing.Point(275, 262)
        Me.cmdSubtract.Name = "cmdSubtract"
        Me.cmdSubtract.Size = New System.Drawing.Size(52, 39)
        Me.cmdSubtract.TabIndex = 25
        Me.cmdSubtract.Tag = "-"
        Me.cmdSubtract.Text = "-"
        Me.cmdSubtract.UseVisualStyleBackColor = True
        '
        'cmdEquals
        '
        Me.cmdEquals.Location = New System.Drawing.Point(217, 307)
        Me.cmdEquals.Name = "cmdEquals"
        Me.cmdEquals.Size = New System.Drawing.Size(110, 39)
        Me.cmdEquals.TabIndex = 26
        Me.cmdEquals.Tag = "="
        Me.cmdEquals.Text = "="
        Me.cmdEquals.UseVisualStyleBackColor = True
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 366)
        Me.Controls.Add(Me.cmdEquals)
        Me.Controls.Add(Me.cmdSubtract)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdDivide)
        Me.Controls.Add(Me.cmdMultiply)
        Me.Controls.Add(Me.cmdPower)
        Me.Controls.Add(Me.cmdMod)
        Me.Controls.Add(Me.cmdDecimal)
        Me.Controls.Add(Me.cmd0)
        Me.Controls.Add(Me.cmdNegate)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.cmd6)
        Me.Controls.Add(Me.cmd5)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd9)
        Me.Controls.Add(Me.cmd8)
        Me.Controls.Add(Me.cmd7)
        Me.Controls.Add(Me.cmdClearEntry)
        Me.Controls.Add(Me.cmdClearAll)
        Me.Controls.Add(Me.cmdTan)
        Me.Controls.Add(Me.cmdCos)
        Me.Controls.Add(Me.cmdSin)
        Me.Controls.Add(Me.cmdSqrt)
        Me.Controls.Add(Me.gbxDisplay)
        Me.Controls.Add(Me.txtOutput)
        Me.Name = "frmCalculator"
        Me.Text = "1970 Calcutech"
        Me.gbxDisplay.ResumeLayout(False)
        Me.gbxDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As TextBox
    Friend WithEvents gbxDisplay As GroupBox
    Friend WithEvents rdoInt As RadioButton
    Friend WithEvents rdoFloat As RadioButton
    Friend WithEvents cmdSqrt As Button
    Friend WithEvents cmdSin As Button
    Friend WithEvents cmdCos As Button
    Friend WithEvents cmdTan As Button
    Friend WithEvents cmdClearAll As Button
    Friend WithEvents cmdClearEntry As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmdNegate As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmdDecimal As Button
    Friend WithEvents cmdMod As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdDivide As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdSubtract As Button
    Friend WithEvents cmdEquals As Button


End Class
