<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHR_UpdatePersonnelDetails_EducationBackground
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelUpdEducationBackground = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvEducationBackground = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbEmployment = New System.Windows.Forms.GroupBox()
        Me.btnAddUpdEducation = New System.Windows.Forms.Button()
        Me.btnClearTextFields = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDegree = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEducTelNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpEducTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpEducFrom = New System.Windows.Forms.DateTimePicker()
        Me.cbEducationAttainment = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEducEmailAdr = New System.Windows.Forms.TextBox()
        Me.txtAwardsRecogCerti = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSchoolAdr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSchoolName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelUpdEducationBackground.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvEducationBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.gbEmployment.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelUpdEducationBackground
        '
        Me.PanelUpdEducationBackground.BackColor = System.Drawing.Color.White
        Me.PanelUpdEducationBackground.Controls.Add(Me.Panel14)
        Me.PanelUpdEducationBackground.Controls.Add(Me.gbEmployment)
        Me.PanelUpdEducationBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelUpdEducationBackground.Location = New System.Drawing.Point(0, 0)
        Me.PanelUpdEducationBackground.Name = "PanelUpdEducationBackground"
        Me.PanelUpdEducationBackground.Size = New System.Drawing.Size(833, 613)
        Me.PanelUpdEducationBackground.TabIndex = 2
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
        Me.Panel14.Location = New System.Drawing.Point(12, 211)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(809, 390)
        Me.Panel14.TabIndex = 85
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvEducationBackground)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(801, 382)
        Me.Panel6.TabIndex = 4
        '
        'dgvEducationBackground
        '
        Me.dgvEducationBackground.AllowUserToAddRows = False
        Me.dgvEducationBackground.AllowUserToDeleteRows = False
        Me.dgvEducationBackground.AllowUserToResizeColumns = False
        Me.dgvEducationBackground.AllowUserToResizeRows = False
        Me.dgvEducationBackground.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvEducationBackground.BackgroundColor = System.Drawing.Color.White
        Me.dgvEducationBackground.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEducationBackground.ColumnHeadersHeight = 35
        Me.dgvEducationBackground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEducationBackground.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgvEducationBackground.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvEducationBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEducationBackground.Location = New System.Drawing.Point(0, 0)
        Me.dgvEducationBackground.MultiSelect = False
        Me.dgvEducationBackground.Name = "dgvEducationBackground"
        Me.dgvEducationBackground.ReadOnly = True
        Me.dgvEducationBackground.RowHeadersVisible = False
        Me.dgvEducationBackground.RowTemplate.Height = 30
        Me.dgvEducationBackground.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEducationBackground.Size = New System.Drawing.Size(801, 382)
        Me.dgvEducationBackground.TabIndex = 85
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
        Me.Column2.HeaderText = "Educational Attainment"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 140
        '
        'Column3
        '
        Me.Column3.HeaderText = "School / University"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 116
        '
        'Column4
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "D"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column4.HeaderText = "From"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 58
        '
        'Column5
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "D"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column5.HeaderText = "To"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 44
        '
        'Column6
        '
        Me.Column6.HeaderText = "School Address"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 102
        '
        'Column7
        '
        Me.Column7.HeaderText = "Field of Study / Degre"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 104
        '
        'Column8
        '
        Me.Column8.HeaderText = "Awards / Recognition / Certification"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 196
        '
        'Column9
        '
        Me.Column9.HeaderText = "School Email"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 89
        '
        'Column10
        '
        Me.Column10.HeaderText = "School Telephone"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 114
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_close_48
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(3, 385)
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
        Me.Panel3.Size = New System.Drawing.Size(3, 388)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 388)
        Me.Panel2.TabIndex = 0
        '
        'gbEmployment
        '
        Me.gbEmployment.Controls.Add(Me.btnAddUpdEducation)
        Me.gbEmployment.Controls.Add(Me.btnClearTextFields)
        Me.gbEmployment.Controls.Add(Me.Label10)
        Me.gbEmployment.Controls.Add(Me.txtDegree)
        Me.gbEmployment.Controls.Add(Me.Label9)
        Me.gbEmployment.Controls.Add(Me.txtEducTelNo)
        Me.gbEmployment.Controls.Add(Me.Label7)
        Me.gbEmployment.Controls.Add(Me.dtpEducTo)
        Me.gbEmployment.Controls.Add(Me.dtpEducFrom)
        Me.gbEmployment.Controls.Add(Me.cbEducationAttainment)
        Me.gbEmployment.Controls.Add(Me.Label8)
        Me.gbEmployment.Controls.Add(Me.txtEducEmailAdr)
        Me.gbEmployment.Controls.Add(Me.txtAwardsRecogCerti)
        Me.gbEmployment.Controls.Add(Me.Label6)
        Me.gbEmployment.Controls.Add(Me.txtSchoolAdr)
        Me.gbEmployment.Controls.Add(Me.Label5)
        Me.gbEmployment.Controls.Add(Me.Label4)
        Me.gbEmployment.Controls.Add(Me.Label3)
        Me.gbEmployment.Controls.Add(Me.txtSchoolName)
        Me.gbEmployment.Controls.Add(Me.Label2)
        Me.gbEmployment.Controls.Add(Me.Label1)
        Me.gbEmployment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEmployment.Location = New System.Drawing.Point(12, 12)
        Me.gbEmployment.Name = "gbEmployment"
        Me.gbEmployment.Size = New System.Drawing.Size(809, 193)
        Me.gbEmployment.TabIndex = 3
        Me.gbEmployment.TabStop = False
        Me.gbEmployment.Text = "Please fill up all fields required. Only details present in the table will be sav" &
    "ed."
        '
        'btnAddUpdEducation
        '
        Me.btnAddUpdEducation.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAddUpdEducation.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnAddUpdEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUpdEducation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUpdEducation.ForeColor = System.Drawing.Color.White
        Me.btnAddUpdEducation.Location = New System.Drawing.Point(674, 110)
        Me.btnAddUpdEducation.Name = "btnAddUpdEducation"
        Me.btnAddUpdEducation.Size = New System.Drawing.Size(120, 26)
        Me.btnAddUpdEducation.TabIndex = 113
        Me.btnAddUpdEducation.Text = "&Add"
        Me.btnAddUpdEducation.UseVisualStyleBackColor = False
        '
        'btnClearTextFields
        '
        Me.btnClearTextFields.BackColor = System.Drawing.Color.Gray
        Me.btnClearTextFields.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearTextFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearTextFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTextFields.ForeColor = System.Drawing.Color.White
        Me.btnClearTextFields.Location = New System.Drawing.Point(674, 142)
        Me.btnClearTextFields.Name = "btnClearTextFields"
        Me.btnClearTextFields.Size = New System.Drawing.Size(120, 26)
        Me.btnClearTextFields.TabIndex = 112
        Me.btnClearTextFields.Text = "Clear &Fields"
        Me.btnClearTextFields.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(356, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 15)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Field of Study / Degree :"
        '
        'txtDegree
        '
        Me.txtDegree.Location = New System.Drawing.Point(500, 27)
        Me.txtDegree.Multiline = True
        Me.txtDegree.Name = "txtDegree"
        Me.txtDegree.Size = New System.Drawing.Size(159, 23)
        Me.txtDegree.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(372, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 15)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "/ Certification:"
        '
        'txtEducTelNo
        '
        Me.txtEducTelNo.Location = New System.Drawing.Point(500, 145)
        Me.txtEducTelNo.Multiline = True
        Me.txtEducTelNo.Name = "txtEducTelNo"
        Me.txtEducTelNo.Size = New System.Drawing.Size(159, 23)
        Me.txtEducTelNo.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(356, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "School Tel. No. :"
        '
        'dtpEducTo
        '
        Me.dtpEducTo.Location = New System.Drawing.Point(162, 116)
        Me.dtpEducTo.Name = "dtpEducTo"
        Me.dtpEducTo.Size = New System.Drawing.Size(180, 23)
        Me.dtpEducTo.TabIndex = 78
        Me.dtpEducTo.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        '
        'dtpEducFrom
        '
        Me.dtpEducFrom.Location = New System.Drawing.Point(162, 87)
        Me.dtpEducFrom.Name = "dtpEducFrom"
        Me.dtpEducFrom.Size = New System.Drawing.Size(180, 23)
        Me.dtpEducFrom.TabIndex = 77
        Me.dtpEducFrom.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        '
        'cbEducationAttainment
        '
        Me.cbEducationAttainment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEducationAttainment.DropDownWidth = 180
        Me.cbEducationAttainment.FormattingEnabled = True
        Me.cbEducationAttainment.Location = New System.Drawing.Point(162, 29)
        Me.cbEducationAttainment.Name = "cbEducationAttainment"
        Me.cbEducationAttainment.Size = New System.Drawing.Size(180, 23)
        Me.cbEducationAttainment.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(356, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 15)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "School Email Adr. :"
        '
        'txtEducEmailAdr
        '
        Me.txtEducEmailAdr.Location = New System.Drawing.Point(500, 116)
        Me.txtEducEmailAdr.Multiline = True
        Me.txtEducEmailAdr.Name = "txtEducEmailAdr"
        Me.txtEducEmailAdr.Size = New System.Drawing.Size(159, 23)
        Me.txtEducEmailAdr.TabIndex = 71
        '
        'txtAwardsRecogCerti
        '
        Me.txtAwardsRecogCerti.Location = New System.Drawing.Point(500, 56)
        Me.txtAwardsRecogCerti.Multiline = True
        Me.txtAwardsRecogCerti.Name = "txtAwardsRecogCerti"
        Me.txtAwardsRecogCerti.Size = New System.Drawing.Size(159, 52)
        Me.txtAwardsRecogCerti.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(356, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 15)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Awards / Recognition "
        '
        'txtSchoolAdr
        '
        Me.txtSchoolAdr.Location = New System.Drawing.Point(162, 145)
        Me.txtSchoolAdr.Multiline = True
        Me.txtSchoolAdr.Name = "txtSchoolAdr"
        Me.txtSchoolAdr.Size = New System.Drawing.Size(180, 23)
        Me.txtSchoolAdr.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "School Address :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "To* :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "From* :"
        '
        'txtSchoolName
        '
        Me.txtSchoolName.Location = New System.Drawing.Point(162, 58)
        Me.txtSchoolName.Name = "txtSchoolName"
        Me.txtSchoolName.Size = New System.Drawing.Size(180, 23)
        Me.txtSchoolName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "School / University* :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Educational Attainment* :"
        '
        'frmHR_UpdatePersonnelDetails_EducationBackground
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 613)
        Me.Controls.Add(Me.PanelUpdEducationBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHR_UpdatePersonnelDetails_EducationBackground"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = "104"
        Me.Text = "frmHR_UpdatePersonnelDetails_EducationBackground"
        Me.PanelUpdEducationBackground.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvEducationBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.gbEmployment.ResumeLayout(False)
        Me.gbEmployment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelUpdEducationBackground As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents gbEmployment As GroupBox
    Friend WithEvents btnClearTextFields As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDegree As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEducTelNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpEducTo As DateTimePicker
    Friend WithEvents dtpEducFrom As DateTimePicker
    Friend WithEvents cbEducationAttainment As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEducEmailAdr As TextBox
    Friend WithEvents txtAwardsRecogCerti As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSchoolAdr As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSchoolName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEducationBackground As DataGridView
    Friend WithEvents btnAddUpdEducation As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
