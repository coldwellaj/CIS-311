﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MyClock1 = New Spell_Checker.UserControl1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MyClock1
        '
        Me.MyClock1.Location = New System.Drawing.Point(78, 24)
        Me.MyClock1.Name = "MyClock1"
        Me.MyClock1.Size = New System.Drawing.Size(118, 41)
        Me.MyClock1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Toggle Clock"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(70, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 25)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Toggle Backcolor"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MyClock1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyClock1 As Spell_Checker.UserControl1
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
