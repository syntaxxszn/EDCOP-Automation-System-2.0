<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHR_UpdatePersonnelDetails_PerformanceAppraisal
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvPerformanceAppraisal = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFollowUp = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnClearTextFields = New System.Windows.Forms.Button()
        Me.btnAddUpdAppraisal = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRating = New System.Windows.Forms.TextBox()
        Me.cbSuperior = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvPerformanceAppraisal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.Panel1.TabIndex = 1
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
        Me.Panel14.Location = New System.Drawing.Point(12, 156)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(809, 445)
        Me.Panel14.TabIndex = 91
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvPerformanceAppraisal)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(801, 437)
        Me.Panel6.TabIndex = 4
        '
        'dgvPerformanceAppraisal
        '
        Me.dgvPerformanceAppraisal.AllowUserToAddRows = False
        Me.dgvPerformanceAppraisal.AllowUserToDeleteRows = False
        Me.dgvPerformanceAppraisal.AllowUserToResizeColumns = False
        Me.dgvPerformanceAppraisal.AllowUserToResizeRows = False
        Me.dgvPerformanceAppraisal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvPerformanceAppraisal.BackgroundColor = System.Drawing.Color.White
        Me.dgvPerformanceAppraisal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPerformanceAppraisal.ColumnHeadersHeight = 35
        Me.dgvPerformanceAppraisal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPerformanceAppraisal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column7, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvPerformanceAppraisal.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvPerformanceAppraisal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPerformanceAppraisal.Location = New System.Drawing.Point(0, 0)
        Me.dgvPerformanceAppraisal.MultiSelect = False
        Me.dgvPerformanceAppraisal.Name = "dgvPerformanceAppraisal"
        Me.dgvPerformanceAppraisal.ReadOnly = True
        Me.dgvPerformanceAppraisal.RowHeadersVisible = False
        Me.dgvPerformanceAppraisal.RowTemplate.Height = 30
        Me.dgvPerformanceAppraisal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPerformanceAppraisal.Size = New System.Drawing.Size(801, 437)
        Me.dgvPerformanceAppraisal.TabIndex = 87
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
        Me.Column2.HeaderText = "Start Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 77
        '
        'Column7
        '
        Me.Column7.HeaderText = "End Date"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 73
        '
        'Column3
        '
        Me.Column3.HeaderText = "Evaluator"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column4.HeaderText = "Rating"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 66
        '
        'Column5
        '
        Me.Column5.HeaderText = "Follow Up"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 78
        '
        'Column6
        '
        Me.Column6.HeaderText = "Remarks"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 75
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
        Me.Panel5.Location = New System.Drawing.Point(3, 440)
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
        Me.Panel3.Size = New System.Drawing.Size(3, 443)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 443)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFollowUp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.btnClearTextFields)
        Me.GroupBox1.Controls.Add(Me.btnAddUpdAppraisal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtRating)
        Me.GroupBox1.Controls.Add(Me.cbSuperior)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpTo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(809, 138)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "To edit, select and double click on the table below."
        '
        'dtpFollowUp
        '
        Me.dtpFollowUp.Location = New System.Drawing.Point(514, 58)
        Me.dtpFollowUp.Name = "dtpFollowUp"
        Me.dtpFollowUp.Size = New System.Drawing.Size(140, 23)
        Me.dtpFollowUp.TabIndex = 125
        Me.dtpFollowUp.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(432, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Follow-Up * :"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(73, 87)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(581, 23)
        Me.txtRemarks.TabIndex = 123
        '
        'btnClearTextFields
        '
        Me.btnClearTextFields.BackColor = System.Drawing.Color.Gray
        Me.btnClearTextFields.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearTextFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearTextFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTextFields.ForeColor = System.Drawing.Color.White
        Me.btnClearTextFields.Location = New System.Drawing.Point(669, 90)
        Me.btnClearTextFields.Name = "btnClearTextFields"
        Me.btnClearTextFields.Size = New System.Drawing.Size(120, 26)
        Me.btnClearTextFields.TabIndex = 122
        Me.btnClearTextFields.Text = "Clear &Fields"
        Me.btnClearTextFields.UseVisualStyleBackColor = False
        '
        'btnAddUpdAppraisal
        '
        Me.btnAddUpdAppraisal.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAddUpdAppraisal.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnAddUpdAppraisal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUpdAppraisal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUpdAppraisal.ForeColor = System.Drawing.Color.White
        Me.btnAddUpdAppraisal.Location = New System.Drawing.Point(669, 58)
        Me.btnAddUpdAppraisal.Name = "btnAddUpdAppraisal"
        Me.btnAddUpdAppraisal.Size = New System.Drawing.Size(120, 26)
        Me.btnAddUpdAppraisal.TabIndex = 116
        Me.btnAddUpdAppraisal.Text = "&Add"
        Me.btnAddUpdAppraisal.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "Remarks :"
        '
        'txtRating
        '
        Me.txtRating.Location = New System.Drawing.Point(514, 29)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(140, 23)
        Me.txtRating.TabIndex = 117
        '
        'cbSuperior
        '
        Me.cbSuperior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSuperior.DropDownWidth = 175
        Me.cbSuperior.FormattingEnabled = True
        Me.cbSuperior.Location = New System.Drawing.Point(149, 29)
        Me.cbSuperior.Name = "cbSuperior"
        Me.cbSuperior.Size = New System.Drawing.Size(270, 23)
        Me.cbSuperior.TabIndex = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 15)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Evaluated By / Rater :"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(265, 58)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(154, 23)
        Me.dtpTo.TabIndex = 91
        Me.dtpTo.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 15)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "To* :"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(61, 58)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(162, 23)
        Me.dtpFrom.TabIndex = 89
        Me.dtpFrom.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "From* :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(432, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Rating* :"
        '
        'frmHR_UpdatePersonnelDetails_PerformanceAppraisal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 613)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHR_UpdatePersonnelDetails_PerformanceAppraisal"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = "111"
        Me.Text = "frmHR_UpdatePersonnelDetails_PerformanceAppraisal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvPerformanceAppraisal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClearTextFields As Button
    Friend WithEvents btnAddUpdAppraisal As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRating As TextBox
    Friend WithEvents cbSuperior As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFollowUp As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents dgvPerformanceAppraisal As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
