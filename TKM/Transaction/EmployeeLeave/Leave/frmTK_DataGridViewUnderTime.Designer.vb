<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTK_DataGridViewUnderTime
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvUnderTime = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeRange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursLacked = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateFiled = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteThisFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvUnderTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dgvUnderTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 327)
        Me.Panel1.TabIndex = 0
        '
        'dgvUnderTime
        '
        Me.dgvUnderTime.AllowUserToAddRows = False
        Me.dgvUnderTime.AllowUserToDeleteRows = False
        Me.dgvUnderTime.AllowUserToResizeColumns = False
        Me.dgvUnderTime.AllowUserToResizeRows = False
        Me.dgvUnderTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUnderTime.BackgroundColor = System.Drawing.Color.White
        Me.dgvUnderTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUnderTime.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUnderTime.ColumnHeadersHeight = 35
        Me.dgvUnderTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUnderTime.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.EmployeeName, Me.Department, Me.DatePeriod, Me.TimeRange, Me.HoursLacked, Me.DateFiled, Me.Column3, Me.Reason, Me.Status, Me.StatusRemarks, Me.Column1, Me.Column2})
        Me.dgvUnderTime.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvUnderTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUnderTime.Location = New System.Drawing.Point(0, 0)
        Me.dgvUnderTime.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvUnderTime.MultiSelect = False
        Me.dgvUnderTime.Name = "dgvUnderTime"
        Me.dgvUnderTime.ReadOnly = True
        Me.dgvUnderTime.RowHeadersVisible = False
        Me.dgvUnderTime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvUnderTime.RowTemplate.Height = 30
        Me.dgvUnderTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnderTime.Size = New System.Drawing.Size(928, 327)
        Me.dgvUnderTime.TabIndex = 4
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'EmployeeName
        '
        Me.EmployeeName.HeaderText = "Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Visible = False
        '
        'Department
        '
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        Me.Department.ReadOnly = True
        Me.Department.Visible = False
        '
        'DatePeriod
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePeriod.DefaultCellStyle = DataGridViewCellStyle2
        Me.DatePeriod.FillWeight = 101.0787!
        Me.DatePeriod.HeaderText = "Date Period"
        Me.DatePeriod.Name = "DatePeriod"
        Me.DatePeriod.ReadOnly = True
        '
        'TimeRange
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TimeRange.DefaultCellStyle = DataGridViewCellStyle3
        Me.TimeRange.FillWeight = 101.0787!
        Me.TimeRange.HeaderText = "Time Range"
        Me.TimeRange.Name = "TimeRange"
        Me.TimeRange.ReadOnly = True
        '
        'HoursLacked
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.HoursLacked.DefaultCellStyle = DataGridViewCellStyle4
        Me.HoursLacked.FillWeight = 101.0787!
        Me.HoursLacked.HeaderText = "Hours Lacked"
        Me.HoursLacked.Name = "HoursLacked"
        Me.HoursLacked.ReadOnly = True
        '
        'DateFiled
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DateFiled.DefaultCellStyle = DataGridViewCellStyle5
        Me.DateFiled.FillWeight = 101.0787!
        Me.DateFiled.HeaderText = "Date Filed"
        Me.DateFiled.Name = "DateFiled"
        Me.DateFiled.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column3.HeaderText = "Posting Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Reason
        '
        Me.Reason.FillWeight = 101.0787!
        Me.Reason.HeaderText = "Reason"
        Me.Reason.Name = "Reason"
        Me.Reason.ReadOnly = True
        '
        'Status
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.DefaultCellStyle = DataGridViewCellStyle7
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'StatusRemarks
        '
        Me.StatusRemarks.HeaderText = "StatusRemarks"
        Me.StatusRemarks.Name = "StatusRemarks"
        Me.StatusRemarks.ReadOnly = True
        Me.StatusRemarks.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "ApproverName"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "PosterName"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateStatusToolStripMenuItem, Me.DeleteThisFileToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(151, 48)
        '
        'UpdateStatusToolStripMenuItem
        '
        Me.UpdateStatusToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.gear
        Me.UpdateStatusToolStripMenuItem.Name = "UpdateStatusToolStripMenuItem"
        Me.UpdateStatusToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.UpdateStatusToolStripMenuItem.Text = "Update Status"
        '
        'DeleteThisFileToolStripMenuItem
        '
        Me.DeleteThisFileToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_close_48
        Me.DeleteThisFileToolStripMenuItem.Name = "DeleteThisFileToolStripMenuItem"
        Me.DeleteThisFileToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DeleteThisFileToolStripMenuItem.Text = "Delete this File"
        '
        'frmTK_DataGridViewUnderTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTK_DataGridViewUnderTime"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmTK_DataGridViewUnderTime"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvUnderTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvUnderTime As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UpdateStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteThisFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents DatePeriod As DataGridViewTextBoxColumn
    Friend WithEvents TimeRange As DataGridViewTextBoxColumn
    Friend WithEvents HoursLacked As DataGridViewTextBoxColumn
    Friend WithEvents DateFiled As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Reason As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents StatusRemarks As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
