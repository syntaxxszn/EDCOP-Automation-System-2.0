<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTK_AddUpdLeave
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbDayType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumDays = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEndPeriod = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpStartPeriod = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLeaveCredits = New System.Windows.Forms.TextBox()
        Me.cbLeaveType = New System.Windows.Forms.ComboBox()
        Me.dtpDateFiling = New System.Windows.Forms.DateTimePicker()
        Me.chLateFiling = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpSET = New System.Windows.Forms.DateTimePicker()
        Me.btnClearTextFields = New System.Windows.Forms.Button()
        Me.btnAddUpdEmployeeLeave = New System.Windows.Forms.Button()
        Me.dtpSST = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBoxHelp = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBoxHelp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(343, 437)
        Me.Panel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cbDayType)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtNumDays)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.dtpEndPeriod)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.dtpStartPeriod)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtLeaveCredits)
        Me.Panel3.Controls.Add(Me.cbLeaveType)
        Me.Panel3.Controls.Add(Me.dtpDateFiling)
        Me.Panel3.Controls.Add(Me.chLateFiling)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.dtpSET)
        Me.Panel3.Controls.Add(Me.btnClearTextFields)
        Me.Panel3.Controls.Add(Me.btnAddUpdEmployeeLeave)
        Me.Panel3.Controls.Add(Me.dtpSST)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtRemarks)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(16, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(311, 364)
        Me.Panel3.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "Day Type* :"
        '
        'cbDayType
        '
        Me.cbDayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDayType.FormattingEnabled = True
        Me.cbDayType.Location = New System.Drawing.Point(106, 164)
        Me.cbDayType.Name = "cbDayType"
        Me.cbDayType.Size = New System.Drawing.Size(188, 23)
        Me.cbDayType.TabIndex = 139
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 15)
        Me.Label8.TabIndex = 138
        Me.Label8.Text = "No. of Days :"
        '
        'txtNumDays
        '
        Me.txtNumDays.BackColor = System.Drawing.Color.White
        Me.txtNumDays.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumDays.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDays.Location = New System.Drawing.Point(106, 135)
        Me.txtNumDays.Name = "txtNumDays"
        Me.txtNumDays.Size = New System.Drawing.Size(188, 23)
        Me.txtNumDays.TabIndex = 137
        Me.txtNumDays.Text = "1.00"
        Me.txtNumDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "End Date* :"
        '
        'dtpEndPeriod
        '
        Me.dtpEndPeriod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndPeriod.Location = New System.Drawing.Point(106, 106)
        Me.dtpEndPeriod.Name = "dtpEndPeriod"
        Me.dtpEndPeriod.Size = New System.Drawing.Size(188, 23)
        Me.dtpEndPeriod.TabIndex = 135
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Start Date* :"
        '
        'dtpStartPeriod
        '
        Me.dtpStartPeriod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartPeriod.Location = New System.Drawing.Point(106, 77)
        Me.dtpStartPeriod.Name = "dtpStartPeriod"
        Me.dtpStartPeriod.Size = New System.Drawing.Size(188, 23)
        Me.dtpStartPeriod.TabIndex = 133
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Leave Credits :"
        '
        'txtLeaveCredits
        '
        Me.txtLeaveCredits.BackColor = System.Drawing.Color.White
        Me.txtLeaveCredits.Cursor = System.Windows.Forms.Cursors.No
        Me.txtLeaveCredits.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeaveCredits.Location = New System.Drawing.Point(106, 48)
        Me.txtLeaveCredits.Name = "txtLeaveCredits"
        Me.txtLeaveCredits.ReadOnly = True
        Me.txtLeaveCredits.Size = New System.Drawing.Size(188, 23)
        Me.txtLeaveCredits.TabIndex = 131
        Me.txtLeaveCredits.Text = "0.00"
        Me.txtLeaveCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbLeaveType
        '
        Me.cbLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLeaveType.FormattingEnabled = True
        Me.cbLeaveType.Location = New System.Drawing.Point(106, 19)
        Me.cbLeaveType.Name = "cbLeaveType"
        Me.cbLeaveType.Size = New System.Drawing.Size(188, 23)
        Me.cbLeaveType.TabIndex = 130
        '
        'dtpDateFiling
        '
        Me.dtpDateFiling.Enabled = False
        Me.dtpDateFiling.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFiling.Location = New System.Drawing.Point(129, 251)
        Me.dtpDateFiling.Name = "dtpDateFiling"
        Me.dtpDateFiling.Size = New System.Drawing.Size(165, 23)
        Me.dtpDateFiling.TabIndex = 129
        '
        'chLateFiling
        '
        Me.chLateFiling.AutoSize = True
        Me.chLateFiling.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chLateFiling.Location = New System.Drawing.Point(20, 253)
        Me.chLateFiling.Name = "chLateFiling"
        Me.chLateFiling.Size = New System.Drawing.Size(91, 19)
        Me.chLateFiling.TabIndex = 128
        Me.chLateFiling.Text = "Late Filing? :"
        Me.chLateFiling.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Scheduled End Time* :"
        '
        'dtpSET
        '
        Me.dtpSET.CustomFormat = "HH:mm"
        Me.dtpSET.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSET.Location = New System.Drawing.Point(152, 222)
        Me.dtpSET.Name = "dtpSET"
        Me.dtpSET.ShowUpDown = True
        Me.dtpSET.Size = New System.Drawing.Size(142, 23)
        Me.dtpSET.TabIndex = 125
        '
        'btnClearTextFields
        '
        Me.btnClearTextFields.BackColor = System.Drawing.Color.White
        Me.btnClearTextFields.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnClearTextFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearTextFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTextFields.ForeColor = System.Drawing.Color.Teal
        Me.btnClearTextFields.Location = New System.Drawing.Point(159, 320)
        Me.btnClearTextFields.Name = "btnClearTextFields"
        Me.btnClearTextFields.Size = New System.Drawing.Size(120, 26)
        Me.btnClearTextFields.TabIndex = 117
        Me.btnClearTextFields.Text = "&Clear Fields"
        Me.btnClearTextFields.UseVisualStyleBackColor = False
        '
        'btnAddUpdEmployeeLeave
        '
        Me.btnAddUpdEmployeeLeave.BackColor = System.Drawing.Color.White
        Me.btnAddUpdEmployeeLeave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnAddUpdEmployeeLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUpdEmployeeLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUpdEmployeeLeave.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAddUpdEmployeeLeave.Location = New System.Drawing.Point(33, 320)
        Me.btnAddUpdEmployeeLeave.Name = "btnAddUpdEmployeeLeave"
        Me.btnAddUpdEmployeeLeave.Size = New System.Drawing.Size(120, 26)
        Me.btnAddUpdEmployeeLeave.TabIndex = 116
        Me.btnAddUpdEmployeeLeave.Text = "&Submit"
        Me.btnAddUpdEmployeeLeave.UseVisualStyleBackColor = False
        '
        'dtpSST
        '
        Me.dtpSST.CustomFormat = "HH:mm"
        Me.dtpSST.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSST.Location = New System.Drawing.Point(152, 193)
        Me.dtpSST.Name = "dtpSST"
        Me.dtpSST.ShowUpDown = True
        Me.dtpSST.Size = New System.Drawing.Size(142, 23)
        Me.dtpSST.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 197)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 15)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Scheduled Start Time* :"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(129, 280)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(165, 23)
        Me.txtRemarks.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Remarks (optional) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Leave Type* :"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.PictureBox1)
        Me.Panel8.Controls.Add(Me.PictureBoxHelp)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.lblHeader)
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(343, 51)
        Me.Panel8.TabIndex = 4
        '
        'PictureBoxHelp
        '
        Me.PictureBoxHelp.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.help
        Me.PictureBoxHelp.Location = New System.Drawing.Point(297, 8)
        Me.PictureBoxHelp.Name = "PictureBoxHelp"
        Me.PictureBoxHelp.Size = New System.Drawing.Size(30, 30)
        Me.PictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHelp.TabIndex = 145
        Me.PictureBoxHelp.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Please fill up all fields required to proceed."
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(52, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(231, 20)
        Me.lblHeader.TabIndex = 24
        Me.lblHeader.Text = "Add New Leave / Paid Time-Off"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 595)
        Me.Panel2.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(333, 41)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 417)
        Me.Panel4.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(-1, 427)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(347, 10)
        Me.Panel5.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.folder
        Me.PictureBox1.Location = New System.Drawing.Point(10, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'frmTK_AddUpdLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 437)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTK_AddUpdLeave"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Leave"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBoxHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents cbDayType As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNumDays As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpEndPeriod As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpStartPeriod As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLeaveCredits As TextBox
    Friend WithEvents cbLeaveType As ComboBox
    Friend WithEvents dtpDateFiling As DateTimePicker
    Friend WithEvents chLateFiling As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpSET As DateTimePicker
    Friend WithEvents btnClearTextFields As Button
    Friend WithEvents btnAddUpdEmployeeLeave As Button
    Friend WithEvents dtpSST As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBoxHelp As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
