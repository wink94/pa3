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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRegNum = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalcGrade = New System.Windows.Forms.Button()
        Me.lblGradeDisplay = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAttendance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModCode = New System.Windows.Forms.TextBox()
        Me.btnWritetoFile = New System.Windows.Forms.Button()
        Me.btnNewStudent = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RegNo"
        '
        'txtRegNum
        '
        Me.txtRegNum.Location = New System.Drawing.Point(208, 39)
        Me.txtRegNum.Name = "txtRegNum"
        Me.txtRegNum.Size = New System.Drawing.Size(100, 20)
        Me.txtRegNum.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnCalcGrade)
        Me.GroupBox1.Controls.Add(Me.lblGradeDisplay)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAttendance)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMarks)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtModCode)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 190)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(320, 113)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalcGrade
        '
        Me.btnCalcGrade.Location = New System.Drawing.Point(320, 31)
        Me.btnCalcGrade.Name = "btnCalcGrade"
        Me.btnCalcGrade.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcGrade.TabIndex = 2
        Me.btnCalcGrade.Text = "Calculate"
        Me.btnCalcGrade.UseVisualStyleBackColor = True
        '
        'lblGradeDisplay
        '
        Me.lblGradeDisplay.AutoSize = True
        Me.lblGradeDisplay.Location = New System.Drawing.Point(121, 151)
        Me.lblGradeDisplay.Name = "lblGradeDisplay"
        Me.lblGradeDisplay.Size = New System.Drawing.Size(39, 13)
        Me.lblGradeDisplay.TabIndex = 0
        Me.lblGradeDisplay.Text = "Label1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Grade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Attendance"
        '
        'txtAttendance
        '
        Me.txtAttendance.Location = New System.Drawing.Point(124, 113)
        Me.txtAttendance.Name = "txtAttendance"
        Me.txtAttendance.Size = New System.Drawing.Size(100, 20)
        Me.txtAttendance.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Marks"
        '
        'txtMarks
        '
        Me.txtMarks.Location = New System.Drawing.Point(124, 73)
        Me.txtMarks.Name = "txtMarks"
        Me.txtMarks.Size = New System.Drawing.Size(100, 20)
        Me.txtMarks.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Module code"
        '
        'txtModCode
        '
        Me.txtModCode.Location = New System.Drawing.Point(124, 36)
        Me.txtModCode.Name = "txtModCode"
        Me.txtModCode.Size = New System.Drawing.Size(100, 20)
        Me.txtModCode.TabIndex = 1
        '
        'btnWritetoFile
        '
        Me.btnWritetoFile.Location = New System.Drawing.Point(263, 298)
        Me.btnWritetoFile.Name = "btnWritetoFile"
        Me.btnWritetoFile.Size = New System.Drawing.Size(75, 23)
        Me.btnWritetoFile.TabIndex = 2
        Me.btnWritetoFile.Text = "WriteToFile"
        Me.btnWritetoFile.UseVisualStyleBackColor = True
        '
        'btnNewStudent
        '
        Me.btnNewStudent.Location = New System.Drawing.Point(434, 34)
        Me.btnNewStudent.Name = "btnNewStudent"
        Me.btnNewStudent.Size = New System.Drawing.Size(109, 23)
        Me.btnNewStudent.TabIndex = 2
        Me.btnNewStudent.Text = "Enter New Student"
        Me.btnNewStudent.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 344)
        Me.Controls.Add(Me.btnNewStudent)
        Me.Controls.Add(Me.btnWritetoFile)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRegNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRegNum As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnWritetoFile As Button
    Friend WithEvents btnCalcGrade As Button
    Friend WithEvents lblGradeDisplay As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAttendance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMarks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModCode As TextBox
    Friend WithEvents btnNewStudent As Button
End Class
