<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHR_UpdatePersonnelDetails_EmploymentHistory
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
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvEmploymentHistory = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClearTextFields = New System.Windows.Forms.Button()
        Me.btnDelEmploymentHistory = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAddUpdEducation = New System.Windows.Forms.Button()
        Me.cbEmploymentType = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAllowances = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSupervisorEmail = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSupervisorContactNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSupervisorPosition = New System.Windows.Forms.TextBox()
        Me.txtCompanyNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCompanyAddress = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbSpecializationType = New System.Windows.Forms.ComboBox()
        Me.cbSeparationType = New System.Windows.Forms.ComboBox()
        Me.cbIndustry = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSupervisorName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJobTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvEmploymentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 613)
        Me.Panel1.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Panel6)
        Me.Panel14.Controls.Add(Me.Panel5)
        Me.Panel14.Controls.Add(Me.Panel4)
        Me.Panel14.Controls.Add(Me.Panel3)
        Me.Panel14.Controls.Add(Me.Panel2)
        Me.Panel14.Location = New System.Drawing.Point(12, 288)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(809, 313)
        Me.Panel14.TabIndex = 91
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvEmploymentHistory)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(801, 305)
        Me.Panel6.TabIndex = 4
        '
        'dgvEmploymentHistory
        '
        Me.dgvEmploymentHistory.AllowUserToAddRows = False
        Me.dgvEmploymentHistory.AllowUserToDeleteRows = False
        Me.dgvEmploymentHistory.AllowUserToResizeColumns = False
        Me.dgvEmploymentHistory.AllowUserToResizeRows = False
        Me.dgvEmploymentHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvEmploymentHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmploymentHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmploymentHistory.ColumnHeadersHeight = 35
        Me.dgvEmploymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEmploymentHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column7, Me.Column6, Me.Column16, Me.Column3, Me.Column4, Me.Column17, Me.Column13, Me.Column11, Me.Column12, Me.Column5, Me.Column19, Me.Column8, Me.Column9, Me.Column15, Me.Column18})
        Me.dgvEmploymentHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmploymentHistory.Location = New System.Drawing.Point(0, 0)
        Me.dgvEmploymentHistory.MultiSelect = False
        Me.dgvEmploymentHistory.Name = "dgvEmploymentHistory"
        Me.dgvEmploymentHistory.ReadOnly = True
        Me.dgvEmploymentHistory.RowHeadersVisible = False
        Me.dgvEmploymentHistory.RowTemplate.Height = 30
        Me.dgvEmploymentHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmploymentHistory.Size = New System.Drawing.Size(801, 305)
        Me.dgvEmploymentHistory.TabIndex = 85
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 43
        '
        'Column2
        '
        Me.Column2.HeaderText = "Company / Employer"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Last Position Held"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 114
        '
        'Column6
        '
        Me.Column6.HeaderText = "From"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 58
        '
        'Column16
        '
        Me.Column16.HeaderText = "To"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 44
        '
        'Column3
        '
        Me.Column3.HeaderText = "Company Address"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 114
        '
        'Column4
        '
        Me.Column4.HeaderText = "Industry"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 74
        '
        'Column17
        '
        Me.Column17.HeaderText = "Specialization"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 103
        '
        'Column13
        '
        Me.Column13.HeaderText = "Company Contact No."
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 115
        '
        'Column11
        '
        Me.Column11.HeaderText = "Imm. Supervisor Name"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 132
        '
        'Column12
        '
        Me.Column12.HeaderText = "Supervisor Position"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sup. Contact No."
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 93
        '
        'Column19
        '
        Me.Column19.HeaderText = "Sup. Email Address"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Width = 118
        '
        'Column8
        '
        Me.Column8.HeaderText = "Basic Monthly Salary"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 124
        '
        'Column9
        '
        Me.Column9.HeaderText = "Allowances (s)"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 96
        '
        'Column15
        '
        Me.Column15.HeaderText = "Employment Status"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 119
        '
        'Column18
        '
        Me.Column18.HeaderText = "Separation Type"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 105
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(3, 308)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(801, 3)
        Me.Panel5.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(801, 3)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(804, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 311)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 311)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClearTextFields)
        Me.GroupBox1.Controls.Add(Me.btnDelEmploymentHistory)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.btnAddUpdEducation)
        Me.GroupBox1.Controls.Add(Me.cbEmploymentType)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtAllowances)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtSupervisorEmail)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtSupervisorContactNo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtSupervisorPosition)
        Me.GroupBox1.Controls.Add(Me.txtCompanyNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtCompanyAddress)
        Me.GroupBox1.Controls.Add(Me.txtSalary)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbSpecializationType)
        Me.GroupBox1.Controls.Add(Me.cbSeparationType)
        Me.GroupBox1.Controls.Add(Me.cbIndustry)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSupervisorName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpTo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtJobTitle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCompany)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(809, 270)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "To edit, select and double click on the table below."
        '
        'btnClearTextFields
        '
        Me.btnClearTextFields.BackColor = System.Drawing.Color.Teal
        Me.btnClearTextFields.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnClearTextFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearTextFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTextFields.ForeColor = System.Drawing.Color.White
        Me.btnClearTextFields.Location = New System.Drawing.Point(676, 229)
        Me.btnClearTextFields.Name = "btnClearTextFields"
        Me.btnClearTextFields.Size = New System.Drawing.Size(120, 26)
        Me.btnClearTextFields.TabIndex = 122
        Me.btnClearTextFields.Text = "Clear &Fields"
        Me.btnClearTextFields.UseVisualStyleBackColor = False
        '
        'btnDelEmploymentHistory
        '
        Me.btnDelEmploymentHistory.BackColor = System.Drawing.Color.Crimson
        Me.btnDelEmploymentHistory.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnDelEmploymentHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelEmploymentHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelEmploymentHistory.ForeColor = System.Drawing.Color.White
        Me.btnDelEmploymentHistory.Location = New System.Drawing.Point(676, 197)
        Me.btnDelEmploymentHistory.Name = "btnDelEmploymentHistory"
        Me.btnDelEmploymentHistory.Size = New System.Drawing.Size(120, 26)
        Me.btnDelEmploymentHistory.TabIndex = 121
        Me.btnDelEmploymentHistory.Text = "&Delete Record"
        Me.btnDelEmploymentHistory.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(337, 206)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 15)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "Employment Status :"
        '
        'btnAddUpdEducation
        '
        Me.btnAddUpdEducation.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnAddUpdEducation.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnAddUpdEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUpdEducation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUpdEducation.ForeColor = System.Drawing.Color.White
        Me.btnAddUpdEducation.Location = New System.Drawing.Point(676, 165)
        Me.btnAddUpdEducation.Name = "btnAddUpdEducation"
        Me.btnAddUpdEducation.Size = New System.Drawing.Size(120, 26)
        Me.btnAddUpdEducation.TabIndex = 116
        Me.btnAddUpdEducation.Text = "&Add / Update"
        Me.btnAddUpdEducation.UseVisualStyleBackColor = False
        '
        'cbEmploymentType
        '
        Me.cbEmploymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmploymentType.DropDownWidth = 175
        Me.cbEmploymentType.FormattingEnabled = True
        Me.cbEmploymentType.Location = New System.Drawing.Point(479, 203)
        Me.cbEmploymentType.Name = "cbEmploymentType"
        Me.cbEmploymentType.Size = New System.Drawing.Size(184, 23)
        Me.cbEmploymentType.TabIndex = 119
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(337, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 15)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "Allowances ( Php ) :"
        '
        'txtAllowances
        '
        Me.txtAllowances.Location = New System.Drawing.Point(479, 174)
        Me.txtAllowances.Name = "txtAllowances"
        Me.txtAllowances.Size = New System.Drawing.Size(184, 23)
        Me.txtAllowances.TabIndex = 117
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(337, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 15)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Supervisor Email :"
        '
        'txtSupervisorEmail
        '
        Me.txtSupervisorEmail.Location = New System.Drawing.Point(479, 116)
        Me.txtSupervisorEmail.Name = "txtSupervisorEmail"
        Me.txtSupervisorEmail.Size = New System.Drawing.Size(184, 23)
        Me.txtSupervisorEmail.TabIndex = 114
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(337, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 15)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Supervisor Contact No. :"
        '
        'txtSupervisorContactNo
        '
        Me.txtSupervisorContactNo.Location = New System.Drawing.Point(479, 87)
        Me.txtSupervisorContactNo.Name = "txtSupervisorContactNo"
        Me.txtSupervisorContactNo.Size = New System.Drawing.Size(184, 23)
        Me.txtSupervisorContactNo.TabIndex = 112
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(337, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 15)
        Me.Label13.TabIndex = 111
        Me.Label13.Text = "Supervisor Position :"
        '
        'txtSupervisorPosition
        '
        Me.txtSupervisorPosition.Location = New System.Drawing.Point(479, 58)
        Me.txtSupervisorPosition.Name = "txtSupervisorPosition"
        Me.txtSupervisorPosition.Size = New System.Drawing.Size(184, 23)
        Me.txtSupervisorPosition.TabIndex = 110
        '
        'txtCompanyNo
        '
        Me.txtCompanyNo.Location = New System.Drawing.Point(141, 232)
        Me.txtCompanyNo.Name = "txtCompanyNo"
        Me.txtCompanyNo.Size = New System.Drawing.Size(184, 23)
        Me.txtCompanyNo.TabIndex = 109
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 15)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Company Contact No. :"
        '
        'txtCompanyAddress
        '
        Me.txtCompanyAddress.Location = New System.Drawing.Point(141, 145)
        Me.txtCompanyAddress.Name = "txtCompanyAddress"
        Me.txtCompanyAddress.Size = New System.Drawing.Size(184, 23)
        Me.txtCompanyAddress.TabIndex = 105
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(479, 145)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(184, 23)
        Me.txtSalary.TabIndex = 104
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 15)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Company Address :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(337, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Salary ( Php ) :"
        '
        'cbSpecializationType
        '
        Me.cbSpecializationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSpecializationType.DropDownWidth = 175
        Me.cbSpecializationType.FormattingEnabled = True
        Me.cbSpecializationType.Location = New System.Drawing.Point(141, 203)
        Me.cbSpecializationType.Name = "cbSpecializationType"
        Me.cbSpecializationType.Size = New System.Drawing.Size(184, 23)
        Me.cbSpecializationType.TabIndex = 101
        '
        'cbSeparationType
        '
        Me.cbSeparationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSeparationType.DropDownWidth = 175
        Me.cbSeparationType.FormattingEnabled = True
        Me.cbSeparationType.Location = New System.Drawing.Point(479, 232)
        Me.cbSeparationType.Name = "cbSeparationType"
        Me.cbSeparationType.Size = New System.Drawing.Size(184, 23)
        Me.cbSeparationType.TabIndex = 100
        '
        'cbIndustry
        '
        Me.cbIndustry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIndustry.DropDownWidth = 175
        Me.cbIndustry.FormattingEnabled = True
        Me.cbIndustry.Location = New System.Drawing.Point(141, 174)
        Me.cbIndustry.Name = "cbIndustry"
        Me.cbIndustry.Size = New System.Drawing.Size(184, 23)
        Me.cbIndustry.TabIndex = 99
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Industry* :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Specialization :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(337, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 15)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Seperation Type* :"
        '
        'txtSupervisorName
        '
        Me.txtSupervisorName.Location = New System.Drawing.Point(479, 29)
        Me.txtSupervisorName.Name = "txtSupervisorName"
        Me.txtSupervisorName.Size = New System.Drawing.Size(184, 23)
        Me.txtSupervisorName.TabIndex = 93
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(337, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 15)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Imm. Supervisor Name :"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(141, 116)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(184, 23)
        Me.dtpTo.TabIndex = 91
        Me.dtpTo.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 15)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "To* :"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(141, 87)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(184, 23)
        Me.dtpFrom.TabIndex = 89
        Me.dtpFrom.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "From* :"
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Location = New System.Drawing.Point(141, 58)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.Size = New System.Drawing.Size(184, 23)
        Me.txtJobTitle.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Position Held* :"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(141, 29)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(184, 23)
        Me.txtCompany.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 15)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Company / Employer* :"
        '
        'frmHR_UpdatePersonnelDetails_EmploymentHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 613)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHR_UpdatePersonnelDetails_EmploymentHistory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = "108"
        Me.Text = "frmHR_UpdatePersonnelDetails_EmploymentHistory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvEmploymentHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCompanyNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCompanyAddress As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbSpecializationType As ComboBox
    Friend WithEvents cbSeparationType As ComboBox
    Friend WithEvents cbIndustry As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSupervisorName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSupervisorEmail As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSupervisorContactNo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSupervisorPosition As TextBox
    Friend WithEvents btnAddUpdEducation As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAllowances As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbEmploymentType As ComboBox
    Friend WithEvents btnClearTextFields As Button
    Friend WithEvents btnDelEmploymentHistory As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvEmploymentHistory As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
End Class
