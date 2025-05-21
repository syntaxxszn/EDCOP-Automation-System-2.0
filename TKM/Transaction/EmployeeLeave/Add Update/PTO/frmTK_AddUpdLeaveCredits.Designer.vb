<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTK_AddUpdLeaveCredits
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtLeaveCount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClearTextFields = New System.Windows.Forms.Button()
        Me.btnAddUpdLeave = New System.Windows.Forms.Button()
        Me.dgvLeaveCredits = New System.Windows.Forms.DataGridView()
        Me.LeaveType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainingLeave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateIssued = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpLeaveIssuance = New System.Windows.Forms.DateTimePicker()
        Me.cbLeaveType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSubmitLeaveCredits = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvLeaveCredits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 583)
        Me.Panel1.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(4, 573)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(423, 10)
        Me.Panel7.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.txtLeaveCount)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.btnClearTextFields)
        Me.Panel4.Controls.Add(Me.btnAddUpdLeave)
        Me.Panel4.Controls.Add(Me.dgvLeaveCredits)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.dtpLeaveIssuance)
        Me.Panel4.Controls.Add(Me.cbLeaveType)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(16, 57)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(367, 510)
        Me.Panel4.TabIndex = 5
        '
        'txtLeaveCount
        '
        Me.txtLeaveCount.Location = New System.Drawing.Point(62, 48)
        Me.txtLeaveCount.Name = "txtLeaveCount"
        Me.txtLeaveCount.Size = New System.Drawing.Size(47, 23)
        Me.txtLeaveCount.TabIndex = 119
        Me.txtLeaveCount.Text = "00.00"
        Me.txtLeaveCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Count :"
        '
        'btnClearTextFields
        '
        Me.btnClearTextFields.BackColor = System.Drawing.Color.White
        Me.btnClearTextFields.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnClearTextFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearTextFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTextFields.ForeColor = System.Drawing.Color.Teal
        Me.btnClearTextFields.Location = New System.Drawing.Point(245, 88)
        Me.btnClearTextFields.Name = "btnClearTextFields"
        Me.btnClearTextFields.Size = New System.Drawing.Size(110, 26)
        Me.btnClearTextFields.TabIndex = 117
        Me.btnClearTextFields.Text = "&Clear Fields"
        Me.btnClearTextFields.UseVisualStyleBackColor = False
        '
        'btnAddUpdLeave
        '
        Me.btnAddUpdLeave.BackColor = System.Drawing.Color.White
        Me.btnAddUpdLeave.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btnAddUpdLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUpdLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUpdLeave.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnAddUpdLeave.Location = New System.Drawing.Point(129, 88)
        Me.btnAddUpdLeave.Name = "btnAddUpdLeave"
        Me.btnAddUpdLeave.Size = New System.Drawing.Size(110, 26)
        Me.btnAddUpdLeave.TabIndex = 116
        Me.btnAddUpdLeave.Text = "&Add / Update"
        Me.btnAddUpdLeave.UseVisualStyleBackColor = False
        '
        'dgvLeaveCredits
        '
        Me.dgvLeaveCredits.AllowUserToAddRows = False
        Me.dgvLeaveCredits.AllowUserToDeleteRows = False
        Me.dgvLeaveCredits.AllowUserToResizeColumns = False
        Me.dgvLeaveCredits.AllowUserToResizeRows = False
        Me.dgvLeaveCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLeaveCredits.BackgroundColor = System.Drawing.Color.White
        Me.dgvLeaveCredits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLeaveCredits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLeaveCredits.ColumnHeadersHeight = 35
        Me.dgvLeaveCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLeaveCredits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LeaveType, Me.RemainingLeave, Me.DateIssued})
        Me.dgvLeaveCredits.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dgvLeaveCredits.Location = New System.Drawing.Point(13, 130)
        Me.dgvLeaveCredits.MultiSelect = False
        Me.dgvLeaveCredits.Name = "dgvLeaveCredits"
        Me.dgvLeaveCredits.ReadOnly = True
        Me.dgvLeaveCredits.RowHeadersVisible = False
        Me.dgvLeaveCredits.RowTemplate.Height = 30
        Me.dgvLeaveCredits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLeaveCredits.Size = New System.Drawing.Size(342, 367)
        Me.dgvLeaveCredits.TabIndex = 4
        '
        'LeaveType
        '
        Me.LeaveType.FillWeight = 124.1641!
        Me.LeaveType.HeaderText = "Leave Type"
        Me.LeaveType.Name = "LeaveType"
        Me.LeaveType.ReadOnly = True
        '
        'RemainingLeave
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.RemainingLeave.DefaultCellStyle = DataGridViewCellStyle2
        Me.RemainingLeave.FillWeight = 84.46536!
        Me.RemainingLeave.HeaderText = "Leave Credit"
        Me.RemainingLeave.Name = "RemainingLeave"
        Me.RemainingLeave.ReadOnly = True
        '
        'DateIssued
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DateIssued.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateIssued.FillWeight = 91.37056!
        Me.DateIssued.HeaderText = "Issuance Date"
        Me.DateIssued.Name = "DateIssued"
        Me.DateIssued.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Issuance Date :"
        '
        'dtpLeaveIssuance
        '
        Me.dtpLeaveIssuance.Location = New System.Drawing.Point(209, 48)
        Me.dtpLeaveIssuance.Name = "dtpLeaveIssuance"
        Me.dtpLeaveIssuance.Size = New System.Drawing.Size(146, 23)
        Me.dtpLeaveIssuance.TabIndex = 2
        '
        'cbLeaveType
        '
        Me.cbLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLeaveType.FormattingEnabled = True
        Me.cbLeaveType.Items.AddRange(New Object() {"Sick"})
        Me.cbLeaveType.Location = New System.Drawing.Point(101, 16)
        Me.cbLeaveType.Name = "cbLeaveType"
        Me.cbLeaveType.Size = New System.Drawing.Size(254, 23)
        Me.cbLeaveType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Leave Type :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnSubmitLeaveCredits)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(399, 51)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.folder
        Me.PictureBox1.Location = New System.Drawing.Point(10, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'btnSubmitLeaveCredits
        '
        Me.btnSubmitLeaveCredits.BackColor = System.Drawing.Color.White
        Me.btnSubmitLeaveCredits.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnSubmitLeaveCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitLeaveCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitLeaveCredits.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSubmitLeaveCredits.Location = New System.Drawing.Point(279, 12)
        Me.btnSubmitLeaveCredits.Name = "btnSubmitLeaveCredits"
        Me.btnSubmitLeaveCredits.Size = New System.Drawing.Size(104, 26)
        Me.btnSubmitLeaveCredits.TabIndex = 121
        Me.btnSubmitLeaveCredits.Text = "&Save"
        Me.btnSubmitLeaveCredits.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Leave/s and its issuance date."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(52, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Employee Leave Credits"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Location = New System.Drawing.Point(0, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 553)
        Me.Panel3.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(13, 360)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(499, 10)
        Me.Panel6.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(389, 39)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 557)
        Me.Panel5.TabIndex = 6
        '
        'frmTK_AddUpdLeaveCredits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTK_AddUpdLeaveCredits"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credits"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvLeaveCredits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSubmitLeaveCredits As Button
    Friend WithEvents txtLeaveCount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClearTextFields As Button
    Friend WithEvents btnAddUpdLeave As Button
    Friend WithEvents dgvLeaveCredits As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpLeaveIssuance As DateTimePicker
    Friend WithEvents cbLeaveType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LeaveType As DataGridViewTextBoxColumn
    Friend WithEvents RemainingLeave As DataGridViewTextBoxColumn
    Friend WithEvents DateIssued As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
