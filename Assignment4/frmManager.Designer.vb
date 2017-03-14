<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManager
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
        Me.components = New System.ComponentModel.Container()
        Me.gbxDegree = New System.Windows.Forms.GroupBox()
        Me.gbxClass = New System.Windows.Forms.GroupBox()
        Me.cmdBuild = New System.Windows.Forms.Button()
        Me.lstDegrees = New System.Windows.Forms.ListBox()
        Me.lblDegree = New System.Windows.Forms.Label()
        Me.txtDegreeDesignator = New System.Windows.Forms.TextBox()
        Me.txtDegreeName = New System.Windows.Forms.TextBox()
        Me.cmdAddDegree = New System.Windows.Forms.Button()
        Me.cmdDeleteDegree = New System.Windows.Forms.Button()
        Me.cmdDeleteCourse = New System.Windows.Forms.Button()
        Me.cmdAddCourse = New System.Windows.Forms.Button()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.txtCourseDesignator = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbxDegree.SuspendLayout()
        Me.gbxClass.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDegree
        '
        Me.gbxDegree.Controls.Add(Me.cmdDeleteDegree)
        Me.gbxDegree.Controls.Add(Me.cmdAddDegree)
        Me.gbxDegree.Controls.Add(Me.txtDegreeName)
        Me.gbxDegree.Controls.Add(Me.txtDegreeDesignator)
        Me.gbxDegree.Controls.Add(Me.lblDegree)
        Me.gbxDegree.Controls.Add(Me.lstDegrees)
        Me.gbxDegree.Location = New System.Drawing.Point(20, 19)
        Me.gbxDegree.Name = "gbxDegree"
        Me.gbxDegree.Size = New System.Drawing.Size(761, 281)
        Me.gbxDegree.TabIndex = 0
        Me.gbxDegree.TabStop = False
        Me.gbxDegree.Text = "Degree Maintenance"
        '
        'gbxClass
        '
        Me.gbxClass.Controls.Add(Me.cmdDeleteCourse)
        Me.gbxClass.Controls.Add(Me.cmdAddCourse)
        Me.gbxClass.Controls.Add(Me.txtCourseName)
        Me.gbxClass.Controls.Add(Me.txtCourseDesignator)
        Me.gbxClass.Controls.Add(Me.lblCourse)
        Me.gbxClass.Controls.Add(Me.lstCourses)
        Me.gbxClass.Location = New System.Drawing.Point(22, 306)
        Me.gbxClass.Name = "gbxClass"
        Me.gbxClass.Size = New System.Drawing.Size(761, 281)
        Me.gbxClass.TabIndex = 1
        Me.gbxClass.TabStop = False
        Me.gbxClass.Text = "Class Maintenance"
        '
        'cmdBuild
        '
        Me.cmdBuild.Location = New System.Drawing.Point(276, 603)
        Me.cmdBuild.Name = "cmdBuild"
        Me.cmdBuild.Size = New System.Drawing.Size(213, 59)
        Me.cmdBuild.TabIndex = 2
        Me.cmdBuild.Text = "Build Degree"
        Me.cmdBuild.UseVisualStyleBackColor = True
        '
        'lstDegrees
        '
        Me.lstDegrees.FormattingEnabled = True
        Me.lstDegrees.Location = New System.Drawing.Point(13, 22)
        Me.lstDegrees.Name = "lstDegrees"
        Me.lstDegrees.Size = New System.Drawing.Size(729, 121)
        Me.lstDegrees.TabIndex = 0
        '
        'lblDegree
        '
        Me.lblDegree.AutoSize = True
        Me.lblDegree.Location = New System.Drawing.Point(10, 175)
        Me.lblDegree.Name = "lblDegree"
        Me.lblDegree.Size = New System.Drawing.Size(415, 13)
        Me.lblDegree.TabIndex = 1
        Me.lblDegree.Text = "Enter New Degree Designator and Name in TerxtBoxes and Press Add Degree Button."
        '
        'txtDegreeDesignator
        '
        Me.txtDegreeDesignator.Location = New System.Drawing.Point(13, 200)
        Me.txtDegreeDesignator.Name = "txtDegreeDesignator"
        Me.txtDegreeDesignator.Size = New System.Drawing.Size(100, 20)
        Me.txtDegreeDesignator.TabIndex = 2
        '
        'txtDegreeName
        '
        Me.txtDegreeName.Location = New System.Drawing.Point(157, 200)
        Me.txtDegreeName.Name = "txtDegreeName"
        Me.txtDegreeName.Size = New System.Drawing.Size(585, 20)
        Me.txtDegreeName.TabIndex = 3
        '
        'cmdAddDegree
        '
        Me.cmdAddDegree.Location = New System.Drawing.Point(13, 236)
        Me.cmdAddDegree.Name = "cmdAddDegree"
        Me.cmdAddDegree.Size = New System.Drawing.Size(339, 34)
        Me.cmdAddDegree.TabIndex = 4
        Me.cmdAddDegree.Text = "Add Degree"
        Me.cmdAddDegree.UseVisualStyleBackColor = True
        '
        'cmdDeleteDegree
        '
        Me.cmdDeleteDegree.Location = New System.Drawing.Point(397, 236)
        Me.cmdDeleteDegree.Name = "cmdDeleteDegree"
        Me.cmdDeleteDegree.Size = New System.Drawing.Size(345, 34)
        Me.cmdDeleteDegree.TabIndex = 5
        Me.cmdDeleteDegree.Text = "Delete Degree"
        Me.cmdDeleteDegree.UseVisualStyleBackColor = True
        '
        'cmdDeleteCourse
        '
        Me.cmdDeleteCourse.Location = New System.Drawing.Point(398, 235)
        Me.cmdDeleteCourse.Name = "cmdDeleteCourse"
        Me.cmdDeleteCourse.Size = New System.Drawing.Size(342, 34)
        Me.cmdDeleteCourse.TabIndex = 11
        Me.cmdDeleteCourse.Text = "Delete Course"
        Me.cmdDeleteCourse.UseVisualStyleBackColor = True
        '
        'cmdAddCourse
        '
        Me.cmdAddCourse.Location = New System.Drawing.Point(14, 235)
        Me.cmdAddCourse.Name = "cmdAddCourse"
        Me.cmdAddCourse.Size = New System.Drawing.Size(339, 34)
        Me.cmdAddCourse.TabIndex = 10
        Me.cmdAddCourse.Text = "Add Course"
        Me.cmdAddCourse.UseVisualStyleBackColor = True
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(157, 199)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(583, 20)
        Me.txtCourseName.TabIndex = 9
        '
        'txtCourseDesignator
        '
        Me.txtCourseDesignator.Location = New System.Drawing.Point(14, 199)
        Me.txtCourseDesignator.Name = "txtCourseDesignator"
        Me.txtCourseDesignator.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseDesignator.TabIndex = 8
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(11, 174)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(411, 13)
        Me.lblCourse.TabIndex = 7
        Me.lblCourse.Text = "Enter New Course Designator and Name in TerxtBoxes and Press Add Course Button."
        '
        'lstCourses
        '
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.Location = New System.Drawing.Point(14, 21)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.Size = New System.Drawing.Size(726, 121)
        Me.lstCourses.TabIndex = 6
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 682)
        Me.Controls.Add(Me.cmdBuild)
        Me.Controls.Add(Me.gbxClass)
        Me.Controls.Add(Me.gbxDegree)
        Me.Name = "frmManager"
        Me.Text = "Degree and Course Manager"
        Me.gbxDegree.ResumeLayout(False)
        Me.gbxDegree.PerformLayout()
        Me.gbxClass.ResumeLayout(False)
        Me.gbxClass.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxDegree As GroupBox
    Friend WithEvents cmdDeleteDegree As Button
    Friend WithEvents cmdAddDegree As Button
    Friend WithEvents txtDegreeName As TextBox
    Friend WithEvents txtDegreeDesignator As TextBox
    Friend WithEvents lblDegree As Label
    Friend WithEvents lstDegrees As ListBox
    Friend WithEvents gbxClass As GroupBox
    Friend WithEvents cmdDeleteCourse As Button
    Friend WithEvents cmdAddCourse As Button
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtCourseDesignator As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents lstCourses As ListBox
    Friend WithEvents cmdBuild As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
