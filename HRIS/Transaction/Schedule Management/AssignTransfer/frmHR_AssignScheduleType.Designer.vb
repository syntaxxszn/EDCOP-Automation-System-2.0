<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHR_AssignScheduleType
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbEffectivityPeriod = New System.Windows.Forms.ComboBox()
        Me.cbScheduleType = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvActiveEmployees = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvActiveEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 537)
        Me.Panel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.cbEffectivityPeriod)
        Me.Panel3.Controls.Add(Me.cbScheduleType)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Panel6)
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
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.dgvActiveEmployees)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(16, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(694, 464)
        Me.Panel3.TabIndex = 6
        '
        'cbEffectivityPeriod
        '
        Me.cbEffectivityPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEffectivityPeriod.FormattingEnabled = True
        Me.cbEffectivityPeriod.Location = New System.Drawing.Point(373, 240)
        Me.cbEffectivityPeriod.Name = "cbEffectivityPeriod"
        Me.cbEffectivityPeriod.Size = New System.Drawing.Size(304, 23)
        Me.cbEffectivityPeriod.TabIndex = 145
        '
        'cbScheduleType
        '
        Me.cbScheduleType.BackColor = System.Drawing.Color.White
        Me.cbScheduleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbScheduleType.FormattingEnabled = True
        Me.cbScheduleType.Location = New System.Drawing.Point(373, 190)
        Me.cbScheduleType.Name = "cbScheduleType"
        Me.cbScheduleType.Size = New System.Drawing.Size(304, 23)
        Me.cbScheduleType.TabIndex = 144
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(370, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 15)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "Effectivity Date :"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.Location = New System.Drawing.Point(344, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(3, 464)
        Me.Panel6.TabIndex = 141
        '
        'btnAssignSchedule
        '
        Me.btnAssignSchedule.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAssignSchedule.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnAssignSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssignSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignSchedule.ForeColor = System.Drawing.Color.White
        Me.btnAssignSchedule.Location = New System.Drawing.Point(470, 420)
        Me.btnAssignSchedule.Name = "btnAssignSchedule"
        Me.btnAssignSchedule.Size = New System.Drawing.Size(114, 26)
        Me.btnAssignSchedule.TabIndex = 121
        Me.btnAssignSchedule.Text = "&Assign"
        Me.btnAssignSchedule.UseVisualStyleBackColor = False
        '
        'txtJobPosition
        '
        Me.txtJobPosition.BackColor = System.Drawing.SystemColors.Control
        Me.txtJobPosition.Location = New System.Drawing.Point(373, 89)
        Me.txtJobPosition.Name = "txtJobPosition"
        Me.txtJobPosition.ReadOnly = True
        Me.txtJobPosition.Size = New System.Drawing.Size(304, 23)
        Me.txtJobPosition.TabIndex = 140
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(370, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 15)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "Job Position :"
        '
        'txtDepartment
        '
        Me.txtDepartment.BackColor = System.Drawing.SystemColors.Control
        Me.txtDepartment.Location = New System.Drawing.Point(373, 138)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.ReadOnly = True
        Me.txtDepartment.Size = New System.Drawing.Size(304, 23)
        Me.txtDepartment.TabIndex = 137
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(370, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 15)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Department :"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.Location = New System.Drawing.Point(373, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(304, 23)
        Me.txtName.TabIndex = 135
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Employee Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(370, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Schedule Type :"
        '
        'txtRemarks
        '
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Location = New System.Drawing.Point(373, 382)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(304, 23)
        Me.txtRemarks.TabIndex = 132
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Remarks* :"
        '
        'chSunday
        '
        Me.chSunday.AutoSize = True
        Me.chSunday.Location = New System.Drawing.Point(612, 305)
        Me.chSunday.Name = "chSunday"
        Me.chSunday.Size = New System.Drawing.Size(65, 19)
        Me.chSunday.TabIndex = 130
        Me.chSunday.Text = "Sunday"
        Me.chSunday.UseVisualStyleBackColor = True
        '
        'chSaturday
        '
        Me.chSaturday.AutoSize = True
        Me.chSaturday.Location = New System.Drawing.Point(542, 330)
        Me.chSaturday.Name = "chSaturday"
        Me.chSaturday.Size = New System.Drawing.Size(72, 19)
        Me.chSaturday.TabIndex = 129
        Me.chSaturday.Text = "Saturday"
        Me.chSaturday.UseVisualStyleBackColor = True
        '
        'chWednesday
        '
        Me.chWednesday.AutoSize = True
        Me.chWednesday.Location = New System.Drawing.Point(449, 305)
        Me.chWednesday.Name = "chWednesday"
        Me.chWednesday.Size = New System.Drawing.Size(87, 19)
        Me.chWednesday.TabIndex = 128
        Me.chWednesday.Text = "Wednesday"
        Me.chWednesday.UseVisualStyleBackColor = True
        '
        'chTuesday
        '
        Me.chTuesday.AutoSize = True
        Me.chTuesday.Location = New System.Drawing.Point(373, 330)
        Me.chTuesday.Name = "chTuesday"
        Me.chTuesday.Size = New System.Drawing.Size(69, 19)
        Me.chTuesday.TabIndex = 127
        Me.chTuesday.Text = "Tuesday"
        Me.chTuesday.UseVisualStyleBackColor = True
        '
        'chMonday
        '
        Me.chMonday.AutoSize = True
        Me.chMonday.Location = New System.Drawing.Point(373, 305)
        Me.chMonday.Name = "chMonday"
        Me.chMonday.Size = New System.Drawing.Size(70, 19)
        Me.chMonday.TabIndex = 126
        Me.chMonday.Text = "Monday"
        Me.chMonday.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(370, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Rest Days* :"
        '
        'chFriday
        '
        Me.chFriday.AutoSize = True
        Me.chFriday.Location = New System.Drawing.Point(542, 305)
        Me.chFriday.Name = "chFriday"
        Me.chFriday.Size = New System.Drawing.Size(58, 19)
        Me.chFriday.TabIndex = 124
        Me.chFriday.Text = "Friday"
        Me.chFriday.UseVisualStyleBackColor = True
        '
        'chThursday
        '
        Me.chThursday.AutoSize = True
        Me.chThursday.Location = New System.Drawing.Point(449, 330)
        Me.chThursday.Name = "chThursday"
        Me.chThursday.Size = New System.Drawing.Size(74, 19)
        Me.chThursday.TabIndex = 123
        Me.chThursday.Text = "Thursday"
        Me.chThursday.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.ImageIndex = 0
        Me.Button1.Location = New System.Drawing.Point(257, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 26)
        Me.Button1.TabIndex = 122
        Me.Button1.Text = "&Refresh"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(17, 27)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(234, 26)
        Me.txtSearch.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee Search :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Active Employees"
        '
        'dgvActiveEmployees
        '
        Me.dgvActiveEmployees.AllowUserToAddRows = False
        Me.dgvActiveEmployees.AllowUserToDeleteRows = False
        Me.dgvActiveEmployees.AllowUserToResizeColumns = False
        Me.dgvActiveEmployees.AllowUserToResizeRows = False
        Me.dgvActiveEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvActiveEmployees.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActiveEmployees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvActiveEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActiveEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Code, Me.EmployeeName, Me.Column3, Me.Department})
        Me.dgvActiveEmployees.Location = New System.Drawing.Point(17, 83)
        Me.dgvActiveEmployees.Name = "dgvActiveEmployees"
        Me.dgvActiveEmployees.ReadOnly = True
        Me.dgvActiveEmployees.RowHeadersVisible = False
        Me.dgvActiveEmployees.RowTemplate.Height = 30
        Me.dgvActiveEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActiveEmployees.Size = New System.Drawing.Size(310, 362)
        Me.dgvActiveEmployees.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Code
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Code.DefaultCellStyle = DataGridViewCellStyle2
        Me.Code.FillWeight = 71.06599!
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        '
        'EmployeeName
        '
        Me.EmployeeName.FillWeight = 128.934!
        Me.EmployeeName.HeaderText = "Employee Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "JobPosition"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Department
        '
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        Me.Department.ReadOnly = True
        Me.Department.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.PictureBox1)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.Label12)
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(726, 51)
        Me.Panel8.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.folder
        Me.PictureBox1.Location = New System.Drawing.Point(16, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(421, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "A selected employee will be transferred if they already have an existing schedule" &
    "."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(58, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(235, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Assigning Schedule to Employee"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 495)
        Me.Panel2.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(716, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 513)
        Me.Panel4.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(-31, 527)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(804, 10)
        Me.Panel5.TabIndex = 8
        '
        'frmHR_AssignScheduleType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 537)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHR_AssignScheduleType"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvActiveEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
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
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvActiveEmployees As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbEffectivityPeriod As ComboBox
    Friend WithEvents cbScheduleType As ComboBox
End Class
