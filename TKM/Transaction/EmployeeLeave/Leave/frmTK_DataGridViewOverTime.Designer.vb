<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTK_DataGridViewOverTime
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvOverTime = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeRange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverheadDept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualOT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateFiled = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Authorize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteThisFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvOverTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dgvOverTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 327)
        Me.Panel1.TabIndex = 0
        '
        'dgvOverTime
        '
        Me.dgvOverTime.AllowUserToAddRows = False
        Me.dgvOverTime.AllowUserToDeleteRows = False
        Me.dgvOverTime.AllowUserToResizeColumns = False
        Me.dgvOverTime.AllowUserToResizeRows = False
        Me.dgvOverTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOverTime.BackgroundColor = System.Drawing.Color.White
        Me.dgvOverTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOverTime.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOverTime.ColumnHeadersHeight = 35
        Me.dgvOverTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvOverTime.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Column1, Me.Column2, Me.Column3, Me.DatePeriod, Me.TimeRange, Me.Hours, Me.OverheadDept, Me.ProjectNo, Me.ProjectName, Me.ActualOT, Me.DateFiled, Me.Remarks, Me.Status, Me.Authorize})
        Me.dgvOverTime.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvOverTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOverTime.Location = New System.Drawing.Point(0, 0)
        Me.dgvOverTime.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvOverTime.MultiSelect = False
        Me.dgvOverTime.Name = "dgvOverTime"
        Me.dgvOverTime.ReadOnly = True
        Me.dgvOverTime.RowHeadersVisible = False
        Me.dgvOverTime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvOverTime.RowTemplate.Height = 30
        Me.dgvOverTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOverTime.Size = New System.Drawing.Size(928, 327)
        Me.dgvOverTime.TabIndex = 3
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Department"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "JobTitle"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'DatePeriod
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePeriod.DefaultCellStyle = DataGridViewCellStyle2
        Me.DatePeriod.FillWeight = 91.26106!
        Me.DatePeriod.HeaderText = "Date Period"
        Me.DatePeriod.Name = "DatePeriod"
        Me.DatePeriod.ReadOnly = True
        '
        'TimeRange
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TimeRange.DefaultCellStyle = DataGridViewCellStyle3
        Me.TimeRange.FillWeight = 114.0799!
        Me.TimeRange.HeaderText = "Time Range"
        Me.TimeRange.Name = "TimeRange"
        Me.TimeRange.ReadOnly = True
        '
        'Hours
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Hours.DefaultCellStyle = DataGridViewCellStyle4
        Me.Hours.FillWeight = 74.21413!
        Me.Hours.HeaderText = "No.OfHours"
        Me.Hours.Name = "Hours"
        Me.Hours.ReadOnly = True
        '
        'OverheadDept
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.OverheadDept.DefaultCellStyle = DataGridViewCellStyle5
        Me.OverheadDept.HeaderText = "Overhead Dept."
        Me.OverheadDept.Name = "OverheadDept"
        Me.OverheadDept.ReadOnly = True
        '
        'ProjectNo
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ProjectNo.DefaultCellStyle = DataGridViewCellStyle6
        Me.ProjectNo.FillWeight = 114.0799!
        Me.ProjectNo.HeaderText = "Project No."
        Me.ProjectNo.Name = "ProjectNo"
        Me.ProjectNo.ReadOnly = True
        '
        'ProjectName
        '
        Me.ProjectName.FillWeight = 148.9774!
        Me.ProjectName.HeaderText = "Project Name"
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.ReadOnly = True
        Me.ProjectName.Visible = False
        '
        'ActualOT
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ActualOT.DefaultCellStyle = DataGridViewCellStyle7
        Me.ActualOT.FillWeight = 71.83152!
        Me.ActualOT.HeaderText = "Actual Overtime"
        Me.ActualOT.Name = "ActualOT"
        Me.ActualOT.ReadOnly = True
        '
        'DateFiled
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DateFiled.DefaultCellStyle = DataGridViewCellStyle8
        Me.DateFiled.FillWeight = 93.57772!
        Me.DateFiled.HeaderText = "Date Filed"
        Me.DateFiled.Name = "DateFiled"
        Me.DateFiled.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.FillWeight = 119.5739!
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'Status
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.DefaultCellStyle = DataGridViewCellStyle9
        Me.Status.FillWeight = 71.32602!
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Authorize
        '
        Me.Authorize.HeaderText = "Authorize"
        Me.Authorize.Name = "Authorize"
        Me.Authorize.ReadOnly = True
        Me.Authorize.Visible = False
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
        'frmTK_DataGridViewOverTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTK_DataGridViewOverTime"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmTK_DataGridViewOverTime"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvOverTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvOverTime As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UpdateStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteThisFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DatePeriod As DataGridViewTextBoxColumn
    Friend WithEvents TimeRange As DataGridViewTextBoxColumn
    Friend WithEvents Hours As DataGridViewTextBoxColumn
    Friend WithEvents OverheadDept As DataGridViewTextBoxColumn
    Friend WithEvents ProjectNo As DataGridViewTextBoxColumn
    Friend WithEvents ProjectName As DataGridViewTextBoxColumn
    Friend WithEvents ActualOT As DataGridViewTextBoxColumn
    Friend WithEvents DateFiled As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Authorize As DataGridViewTextBoxColumn
End Class
