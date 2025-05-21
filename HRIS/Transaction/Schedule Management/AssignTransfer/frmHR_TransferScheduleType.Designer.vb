<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHR_TransferScheduleType
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbEffectivityPeriod = New System.Windows.Forms.ComboBox()
        Me.cbScheduleType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAssignSchedule = New System.Windows.Forms.Button()
        Me.txtJobPosition = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chSunday = New System.Windows.Forms.CheckBox()
        Me.chSaturday = New System.Windows.Forms.CheckBox()
        Me.chWednesday = New System.Windows.Forms.CheckBox()
        Me.chTuesday = New System.Windows.Forms.CheckBox()
        Me.chMonday = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chFriday = New System.Windows.Forms.CheckBox()
        Me.chThursday = New System.Windows.Forms.CheckBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 534)
        Me.Panel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.cbEffectivityPeriod)
        Me.Panel3.Controls.Add(Me.cbScheduleType)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnAssignSchedule)
        Me.Panel3.Controls.Add(Me.txtJobPosition)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtDepartment)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtRemarks)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.chSunday)
        Me.Panel3.Controls.Add(Me.chSaturday)
        Me.Panel3.Controls.Add(Me.chWednesday)
        Me.Panel3.Controls.Add(Me.chTuesday)
        Me.Panel3.Controls.Add(Me.chMonday)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.chFriday)
        Me.Panel3.Controls.Add(Me.chThursday)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(16, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(340, 461)
        Me.Panel3.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(174, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 26)
        Me.Button1.TabIndex = 145
        Me.Button1.Text = "&Discard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbEffectivityPeriod
        '
        Me.cbEffectivityPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEffectivityPeriod.FormattingEnabled = True
        Me.cbEffectivityPeriod.Location = New System.Drawing.Point(19, 237)
        Me.cbEffectivityPeriod.Name = "cbEffectivityPeriod"
        Me.cbEffectivityPeriod.Size = New System.Drawing.Size(304, 23)
        Me.cbEffectivityPeriod.TabIndex = 144
        '
        'cbScheduleType
        '
        Me.cbScheduleType.BackColor = System.Drawing.Color.White
        Me.cbScheduleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbScheduleType.FormattingEnabled = True
        Me.cbScheduleType.Location = New System.Drawing.Point(19, 186)
        Me.cbScheduleType.Name = "cbScheduleType"
        Me.cbScheduleType.Size = New System.Drawing.Size(304, 23)
        Me.cbScheduleType.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Effectivity Period* :"
        '
        'btnAssignSchedule
        '
        Me.btnAssignSchedule.BackColor = System.Drawing.Color.White
        Me.btnAssignSchedule.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnAssignSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignSchedule.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAssignSchedule.Location = New System.Drawing.Point(54, 418)
        Me.btnAssignSchedule.Name = "btnAssignSchedule"
        Me.btnAssignSchedule.Size = New System.Drawing.Size(114, 26)
        Me.btnAssignSchedule.TabIndex = 121
        Me.btnAssignSchedule.Text = "&Save"
        Me.btnAssignSchedule.UseVisualStyleBackColor = False
        '
        'txtJobPosition
        '
        Me.txtJobPosition.BackColor = System.Drawing.SystemColors.Control
        Me.txtJobPosition.Location = New System.Drawing.Point(19, 89)
        Me.txtJobPosition.Name = "txtJobPosition"
        Me.txtJobPosition.ReadOnly = True
        Me.txtJobPosition.Size = New System.Drawing.Size(304, 23)
        Me.txtJobPosition.TabIndex = 140
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 15)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "Job Position :"
        '
        'txtDepartment
        '
        Me.txtDepartment.BackColor = System.Drawing.SystemColors.Control
        Me.txtDepartment.Location = New System.Drawing.Point(19, 138)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.ReadOnly = True
        Me.txtDepartment.Size = New System.Drawing.Size(304, 23)
        Me.txtDepartment.TabIndex = 137
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 15)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Department :"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.Location = New System.Drawing.Point(19, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(304, 23)
        Me.txtName.TabIndex = 135
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Employee Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Schedule Type* :"
        '
        'txtRemarks
        '
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Location = New System.Drawing.Point(19, 377)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(304, 23)
        Me.txtRemarks.TabIndex = 132
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Remarks :"
        '
        'chSunday
        '
        Me.chSunday.AutoSize = True
        Me.chSunday.Location = New System.Drawing.Point(259, 303)
        Me.chSunday.Name = "chSunday"
        Me.chSunday.Size = New System.Drawing.Size(65, 19)
        Me.chSunday.TabIndex = 130
        Me.chSunday.Text = "Sunday"
        Me.chSunday.UseVisualStyleBackColor = True
        '
        'chSaturday
        '
        Me.chSaturday.AutoSize = True
        Me.chSaturday.Location = New System.Drawing.Point(189, 324)
        Me.chSaturday.Name = "chSaturday"
        Me.chSaturday.Size = New System.Drawing.Size(72, 19)
        Me.chSaturday.TabIndex = 129
        Me.chSaturday.Text = "Saturday"
        Me.chSaturday.UseVisualStyleBackColor = True
        '
        'chWednesday
        '
        Me.chWednesday.AutoSize = True
        Me.chWednesday.Location = New System.Drawing.Point(96, 299)
        Me.chWednesday.Name = "chWednesday"
        Me.chWednesday.Size = New System.Drawing.Size(87, 19)
        Me.chWednesday.TabIndex = 128
        Me.chWednesday.Text = "Wednesday"
        Me.chWednesday.UseVisualStyleBackColor = True
        '
        'chTuesday
        '
        Me.chTuesday.AutoSize = True
        Me.chTuesday.Location = New System.Drawing.Point(20, 324)
        Me.chTuesday.Name = "chTuesday"
        Me.chTuesday.Size = New System.Drawing.Size(69, 19)
        Me.chTuesday.TabIndex = 127
        Me.chTuesday.Text = "Tuesday"
        Me.chTuesday.UseVisualStyleBackColor = True
        '
        'chMonday
        '
        Me.chMonday.AutoSize = True
        Me.chMonday.Location = New System.Drawing.Point(20, 299)
        Me.chMonday.Name = "chMonday"
        Me.chMonday.Size = New System.Drawing.Size(70, 19)
        Me.chMonday.TabIndex = 126
        Me.chMonday.Text = "Monday"
        Me.chMonday.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Rest Days* :"
        '
        'chFriday
        '
        Me.chFriday.AutoSize = True
        Me.chFriday.Location = New System.Drawing.Point(189, 299)
        Me.chFriday.Name = "chFriday"
        Me.chFriday.Size = New System.Drawing.Size(58, 19)
        Me.chFriday.TabIndex = 124
        Me.chFriday.Text = "Friday"
        Me.chFriday.UseVisualStyleBackColor = True
        '
        'chThursday
        '
        Me.chThursday.AutoSize = True
        Me.chThursday.Location = New System.Drawing.Point(96, 324)
        Me.chThursday.Name = "chThursday"
        Me.chThursday.Size = New System.Drawing.Size(74, 19)
        Me.chThursday.TabIndex = 123
        Me.chThursday.Text = "Thursday"
        Me.chThursday.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.PictureBox1)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(372, 51)
        Me.Panel8.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(313, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "An active employee cannot have two concurrent schedules. "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(58, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(224, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Transfer Schedule of Employee"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(362, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 554)
        Me.Panel4.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 495)
        Me.Panel2.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(-27, 524)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(461, 10)
        Me.Panel5.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.folder
        Me.PictureBox1.Location = New System.Drawing.Point(16, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'frmHR_TransferScheduleType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 534)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHR_TransferScheduleType"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbEffectivityPeriod As ComboBox
    Friend WithEvents cbScheduleType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAssignSchedule As Button
    Friend WithEvents txtJobPosition As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chSunday As CheckBox
    Friend WithEvents chSaturday As CheckBox
    Friend WithEvents chWednesday As CheckBox
    Friend WithEvents chTuesday As CheckBox
    Friend WithEvents chMonday As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chFriday As CheckBox
    Friend WithEvents chThursday As CheckBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
