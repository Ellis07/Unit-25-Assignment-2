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
        Student = New Button()
        Teacher = New Button()
        Attendance = New Button()
        Record = New Button()
        SuspendLayout()
        ' 
        ' Student
        ' 
        Student.Location = New Point(96, 64)
        Student.Name = "Student"
        Student.Size = New Size(75, 23)
        Student.TabIndex = 0
        Student.Text = "Student"
        Student.UseVisualStyleBackColor = True
        ' 
        ' Teacher
        ' 
        Teacher.Location = New Point(371, 64)
        Teacher.Name = "Teacher"
        Teacher.Size = New Size(75, 23)
        Teacher.TabIndex = 1
        Teacher.Text = "Teacher"
        Teacher.UseVisualStyleBackColor = True
        ' 
        ' Attendance
        ' 
        Attendance.Location = New Point(96, 222)
        Attendance.Name = "Attendance"
        Attendance.Size = New Size(100, 23)
        Attendance.TabIndex = 2
        Attendance.Text = "Attendance"
        Attendance.UseVisualStyleBackColor = True
        ' 
        ' Record
        ' 
        Record.Location = New Point(371, 222)
        Record.Name = "Record"
        Record.Size = New Size(75, 23)
        Record.TabIndex = 3
        Record.Text = "Record"
        Record.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Record)
        Controls.Add(Attendance)
        Controls.Add(Teacher)
        Controls.Add(Student)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Student As Button
    Friend WithEvents Teacher As Button
    Friend WithEvents Attendance As Button
    Friend WithEvents Record As Button

End Class
