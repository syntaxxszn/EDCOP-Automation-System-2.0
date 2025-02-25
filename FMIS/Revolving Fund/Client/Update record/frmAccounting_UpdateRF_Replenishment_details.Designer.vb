<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounting_UpdateRF_Replenishment_details
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtboxParticular = New System.Windows.Forms.TextBox()
        Me.dgvEmployeeName = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkboxAdvances = New System.Windows.Forms.CheckBox()
        Me.txtBoxCredit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxFundUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtboxControlNo = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.panelDGVLeft = New System.Windows.Forms.Panel()
        Me.panelDGVRight = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelCredit = New System.Windows.Forms.Label()
        CType(Me.dgvEmployeeName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Particulars :"
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Text = "Select"
        Me.Column3.Width = 5
        '
        'Column2
        '
        Me.Column2.HeaderText = "Employee"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 81
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 43
        '
        'txtboxParticular
        '
        Me.txtboxParticular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxParticular.Location = New System.Drawing.Point(131, 300)
        Me.txtboxParticular.Multiline = True
        Me.txtboxParticular.Name = "txtboxParticular"
        Me.txtboxParticular.Size = New System.Drawing.Size(294, 90)
        Me.txtboxParticular.TabIndex = 99
        '
        'dgvEmployeeName
        '
        Me.dgvEmployeeName.AllowUserToAddRows = False
        Me.dgvEmployeeName.AllowUserToDeleteRows = False
        Me.dgvEmployeeName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvEmployeeName.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmployeeName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeName.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvEmployeeName.Location = New System.Drawing.Point(131, 151)
        Me.dgvEmployeeName.MultiSelect = False
        Me.dgvEmployeeName.Name = "dgvEmployeeName"
        Me.dgvEmployeeName.ReadOnly = True
        Me.dgvEmployeeName.RowTemplate.Height = 25
        Me.dgvEmployeeName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployeeName.Size = New System.Drawing.Size(294, 143)
        Me.dgvEmployeeName.TabIndex = 98
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Maroon
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(281, 467)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 26)
        Me.btnCancel.TabIndex = 97
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(131, 467)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 26)
        Me.btnSave.TabIndex = 96
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'chkboxAdvances
        '
        Me.chkboxAdvances.AutoSize = True
        Me.chkboxAdvances.Location = New System.Drawing.Point(131, 428)
        Me.chkboxAdvances.Name = "chkboxAdvances"
        Me.chkboxAdvances.Size = New System.Drawing.Size(93, 17)
        Me.chkboxAdvances.TabIndex = 95
        Me.chkboxAdvances.Text = "is Advances ?"
        Me.chkboxAdvances.UseVisualStyleBackColor = True
        '
        'txtBoxCredit
        '
        Me.txtBoxCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxCredit.Location = New System.Drawing.Point(253, 396)
        Me.txtBoxCredit.Name = "txtBoxCredit"
        Me.txtBoxCredit.Size = New System.Drawing.Size(172, 22)
        Me.txtBoxCredit.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Amount :"
        '
        'txtboxFundUser
        '
        Me.txtboxFundUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxFundUser.Location = New System.Drawing.Point(131, 123)
        Me.txtboxFundUser.Name = "txtboxFundUser"
        Me.txtboxFundUser.Size = New System.Drawing.Size(256, 22)
        Me.txtboxFundUser.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Area Coordinator :"
        '
        'txtboxControlNo
        '
        Me.txtboxControlNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxControlNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtboxControlNo.Location = New System.Drawing.Point(131, 95)
        Me.txtboxControlNo.Name = "txtboxControlNo"
        Me.txtboxControlNo.Size = New System.Drawing.Size(174, 22)
        Me.txtboxControlNo.TabIndex = 90
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkGray
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(14, 513)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(429, 2)
        Me.Panel9.TabIndex = 88
        '
        'panelDGVLeft
        '
        Me.panelDGVLeft.BackColor = System.Drawing.Color.DarkGray
        Me.panelDGVLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelDGVLeft.Location = New System.Drawing.Point(12, 76)
        Me.panelDGVLeft.Name = "panelDGVLeft"
        Me.panelDGVLeft.Size = New System.Drawing.Size(2, 439)
        Me.panelDGVLeft.TabIndex = 87
        '
        'panelDGVRight
        '
        Me.panelDGVRight.BackColor = System.Drawing.Color.DarkGray
        Me.panelDGVRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelDGVRight.Location = New System.Drawing.Point(443, 76)
        Me.panelDGVRight.Name = "panelDGVRight"
        Me.panelDGVRight.Size = New System.Drawing.Size(2, 439)
        Me.panelDGVRight.TabIndex = 86
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkGray
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(12, 74)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(433, 2)
        Me.Panel7.TabIndex = 85
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(445, 74)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(12, 441)
        Me.Panel6.TabIndex = 84
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(12, 515)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(445, 12)
        Me.Panel8.TabIndex = 83
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(12, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(445, 12)
        Me.Panel3.TabIndex = 82
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(12, 465)
        Me.Panel2.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Fill up all text boxes and click &Save once done."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Update record for Replenishment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Control No. :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 62)
        Me.Panel1.TabIndex = 80
        '
        'LabelCredit
        '
        Me.LabelCredit.AutoSize = True
        Me.LabelCredit.Location = New System.Drawing.Point(138, 400)
        Me.LabelCredit.Name = "LabelCredit"
        Me.LabelCredit.Size = New System.Drawing.Size(65, 13)
        Me.LabelCredit.TabIndex = 101
        Me.LabelCredit.Text = "LabelCredit"
        '
        'frmAccounting_UpdateRF_Replenishment_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(457, 527)
        Me.Controls.Add(Me.LabelCredit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtboxParticular)
        Me.Controls.Add(Me.dgvEmployeeName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkboxAdvances)
        Me.Controls.Add(Me.txtBoxCredit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtboxFundUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtboxControlNo)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.panelDGVLeft)
        Me.Controls.Add(Me.panelDGVRight)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccounting_UpdateRF_Replenishment_details"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAccounting_UpdateRF_Replenishment_details"
        CType(Me.dgvEmployeeName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents txtboxParticular As TextBox
    Friend WithEvents dgvEmployeeName As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents chkboxAdvances As CheckBox
    Friend WithEvents txtBoxCredit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxFundUser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxControlNo As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents panelDGVLeft As Panel
    Friend WithEvents panelDGVRight As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelCredit As Label
End Class
