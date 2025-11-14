<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHR_UpdatePersonnelDetails_CharacterReference
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
        Me.PanelUpdCharacterReference = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvCharRef = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbEmployment = New System.Windows.Forms.GroupBox()
        Me.btnClearTextFields = New System.Windows.Forms.Button()
        Me.btnAddUpdCharRef = New System.Windows.Forms.Button()
        Me.txtRelationship = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.txtJobTitle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmailAdd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCompanyAdd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMobileNum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelUpdCharacterReference.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvCharRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEmployment.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelUpdCharacterReference
        '
        Me.PanelUpdCharacterReference.BackColor = System.Drawing.Color.White
        Me.PanelUpdCharacterReference.Controls.Add(Me.Panel14)
        Me.PanelUpdCharacterReference.Controls.Add(Me.gbEmployment)
        Me.PanelUpdCharacterReference.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelUpdCharacterReference.Location = New System.Drawing.Point(0, 0)
        Me.PanelUpdCharacterReference.Name = "PanelUpdCharacterReference"
        Me.PanelUpdCharacterReference.Size = New System.Drawing.Size(833, 613)
        Me.PanelUpdCharacterReference.TabIndex = 70
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
        Me.Panel14.Location = New System.Drawing.Point(12, 170)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(809, 431)
        Me.Panel14.TabIndex = 86
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvCharRef)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(801, 423)
        Me.Panel6.TabIndex = 4
        '
        'dgvCharRef
        '
        Me.dgvCharRef.AllowUserToAddRows = False
        Me.dgvCharRef.AllowUserToDeleteRows = False
        Me.dgvCharRef.AllowUserToResizeColumns = False
        Me.dgvCharRef.AllowUserToResizeRows = False
        Me.dgvCharRef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCharRef.BackgroundColor = System.Drawing.Color.White
        Me.dgvCharRef.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCharRef.ColumnHeadersHeight = 35
        Me.dgvCharRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCharRef.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvCharRef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCharRef.Location = New System.Drawing.Point(0, 0)
        Me.dgvCharRef.MultiSelect = False
        Me.dgvCharRef.Name = "dgvCharRef"
        Me.dgvCharRef.ReadOnly = True
        Me.dgvCharRef.RowHeadersVisible = False
        Me.dgvCharRef.RowTemplate.Height = 30
        Me.dgvCharRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCharRef.Size = New System.Drawing.Size(801, 423)
        Me.dgvCharRef.TabIndex = 85
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
        'Column3
        '
        Me.Column3.HeaderText = "Full Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 77
        '
        'Column4
        '
        Me.Column4.HeaderText = "Job Title"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 69
        '
        'Column5
        '
        Me.Column5.HeaderText = "Department"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 93
        '
        'Column6
        '
        Me.Column6.HeaderText = "Mobile Number"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 103
        '
        'Column7
        '
        Me.Column7.HeaderText = "Email Address"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 95
        '
        'Column8
        '
        Me.Column8.HeaderText = "Company Address"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 114
        '
        'Column9
        '
        Me.Column9.HeaderText = "Relationship"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 97
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(3, 426)
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
        Me.Panel3.Size = New System.Drawing.Size(3, 429)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 429)
        Me.Panel2.TabIndex = 0
        '
        'gbEmployment
        '
        Me.gbEmployment.Controls.Add(Me.btnClearTextFields)
        Me.gbEmployment.Controls.Add(Me.btnAddUpdCharRef)
        Me.gbEmployment.Controls.Add(Me.txtRelationship)
        Me.gbEmployment.Controls.Add(Me.txtDepartment)
        Me.gbEmployment.Controls.Add(Me.txtJobTitle)
        Me.gbEmployment.Controls.Add(Me.Label8)
        Me.gbEmployment.Controls.Add(Me.txtEmailAdd)
        Me.gbEmployment.Controls.Add(Me.Label7)
        Me.gbEmployment.Controls.Add(Me.txtCompanyAdd)
        Me.gbEmployment.Controls.Add(Me.Label6)
        Me.gbEmployment.Controls.Add(Me.txtMobileNum)
        Me.gbEmployment.Controls.Add(Me.Label5)
        Me.gbEmployment.Controls.Add(Me.Label4)
        Me.gbEmployment.Controls.Add(Me.Label3)
        Me.gbEmployment.Controls.Add(Me.txtFullName)
        Me.gbEmployment.Controls.Add(Me.Label2)
        Me.gbEmployment.Controls.Add(Me.txtCompany)
        Me.gbEmployment.Controls.Add(Me.Label1)
        Me.gbEmployment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEmployment.Location = New System.Drawing.Point(12, 11)
        Me.gbEmployment.Name = "gbEmployment"
        Me.gbEmployment.Size = New System.Drawing.Size(809, 153)
        Me.gbEmployment.TabIndex = 1
        Me.gbEmployment.TabStop = False
        Me.gbEmployment.Text = "Please fill up all fields required."
        '
        'btnClearTextFields
        '
        Me.btnClearTextFields.BackColor = System.Drawing.Color.Gray
        Me.btnClearTextFields.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearTextFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearTextFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTextFields.ForeColor = System.Drawing.Color.White
        Me.btnClearTextFields.Location = New System.Drawing.Point(667, 102)
        Me.btnClearTextFields.Name = "btnClearTextFields"
        Me.btnClearTextFields.Size = New System.Drawing.Size(120, 26)
        Me.btnClearTextFields.TabIndex = 115
        Me.btnClearTextFields.Text = "&Clear Fields"
        Me.btnClearTextFields.UseVisualStyleBackColor = False
        '
        'btnAddUpdCharRef
        '
        Me.btnAddUpdCharRef.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAddUpdCharRef.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnAddUpdCharRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUpdCharRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUpdCharRef.ForeColor = System.Drawing.Color.White
        Me.btnAddUpdCharRef.Location = New System.Drawing.Point(667, 70)
        Me.btnAddUpdCharRef.Name = "btnAddUpdCharRef"
        Me.btnAddUpdCharRef.Size = New System.Drawing.Size(120, 26)
        Me.btnAddUpdCharRef.TabIndex = 113
        Me.btnAddUpdCharRef.Text = "&Add"
        Me.btnAddUpdCharRef.UseVisualStyleBackColor = False
        '
        'txtRelationship
        '
        Me.txtRelationship.Location = New System.Drawing.Point(460, 116)
        Me.txtRelationship.Name = "txtRelationship"
        Me.txtRelationship.Size = New System.Drawing.Size(180, 23)
        Me.txtRelationship.TabIndex = 75
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(150, 116)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(180, 23)
        Me.txtDepartment.TabIndex = 74
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Location = New System.Drawing.Point(150, 87)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.Size = New System.Drawing.Size(180, 23)
        Me.txtJobTitle.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(351, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 15)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Email Address :"
        '
        'txtEmailAdd
        '
        Me.txtEmailAdd.Location = New System.Drawing.Point(460, 58)
        Me.txtEmailAdd.Multiline = True
        Me.txtEmailAdd.Name = "txtEmailAdd"
        Me.txtEmailAdd.Size = New System.Drawing.Size(180, 23)
        Me.txtEmailAdd.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(351, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 15)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Relationship* :"
        '
        'txtCompanyAdd
        '
        Me.txtCompanyAdd.Location = New System.Drawing.Point(460, 87)
        Me.txtCompanyAdd.Name = "txtCompanyAdd"
        Me.txtCompanyAdd.Size = New System.Drawing.Size(180, 23)
        Me.txtCompanyAdd.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(351, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 15)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Company Address :"
        '
        'txtMobileNum
        '
        Me.txtMobileNum.Location = New System.Drawing.Point(460, 29)
        Me.txtMobileNum.Multiline = True
        Me.txtMobileNum.Name = "txtMobileNum"
        Me.txtMobileNum.Size = New System.Drawing.Size(180, 23)
        Me.txtMobileNum.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(351, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mobile Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Department :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Job Title* :"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(150, 58)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(180, 23)
        Me.txtFullName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Full Name* :"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(150, 29)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(180, 23)
        Me.txtCompany.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Company / Employer* :"
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
        'frmHR_UpdatePersonnelDetails_CharacterReference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 613)
        Me.Controls.Add(Me.PanelUpdCharacterReference)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHR_UpdatePersonnelDetails_CharacterReference"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = "103"
        Me.Text = "frmHR_PreviewPersonnelDetails_CharacterReference"
        Me.PanelUpdCharacterReference.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvCharRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEmployment.ResumeLayout(False)
        Me.gbEmployment.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelUpdCharacterReference As Panel
    Friend WithEvents gbEmployment As GroupBox
    Friend WithEvents btnClearTextFields As Button
    Friend WithEvents btnAddUpdCharRef As Button
    Friend WithEvents txtRelationship As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmailAdd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCompanyAdd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMobileNum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgvCharRef As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
