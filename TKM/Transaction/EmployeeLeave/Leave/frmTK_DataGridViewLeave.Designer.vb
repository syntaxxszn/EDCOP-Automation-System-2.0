<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTK_DataGridViewLeave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTK_DataGridViewLeave))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvLeave = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailmentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeRange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateFiled = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostingName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostingDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteThisFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvLeave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "VL.png")
        Me.ImageList.Images.SetKeyName(1, "SL.png")
        Me.ImageList.Images.SetKeyName(2, "absent.png")
        Me.ImageList.Images.SetKeyName(3, "no-fee.png")
        Me.ImageList.Images.SetKeyName(4, "no-corruption.png")
        Me.ImageList.Images.SetKeyName(5, "late.png")
        Me.ImageList.Images.SetKeyName(6, "maternity.png")
        Me.ImageList.Images.SetKeyName(7, "faternity.png")
        Me.ImageList.Images.SetKeyName(8, "home.png")
        Me.ImageList.Images.SetKeyName(9, "women.png")
        Me.ImageList.Images.SetKeyName(10, "solo.png")
        Me.ImageList.Images.SetKeyName(11, "postgrad.png")
        Me.ImageList.Images.SetKeyName(12, "credit.png")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 327)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgvLeave)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(928, 327)
        Me.Panel4.TabIndex = 2
        '
        'dgvLeave
        '
        Me.dgvLeave.AllowUserToAddRows = False
        Me.dgvLeave.AllowUserToDeleteRows = False
        Me.dgvLeave.AllowUserToResizeColumns = False
        Me.dgvLeave.AllowUserToResizeRows = False
        Me.dgvLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLeave.BackgroundColor = System.Drawing.Color.White
        Me.dgvLeave.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLeave.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLeave.ColumnHeadersHeight = 35
        Me.dgvLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLeave.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.EmployeeName, Me.Department, Me.Code, Me.AvailmentDate, Me.Column2, Me.TimeRange, Me.Hour, Me.LeaveCount, Me.DateFiled, Me.Status, Me.Column3, Me.PostingName, Me.PostingDate, Me.StatusRemarks, Me.Remarks, Me.Column1, Me.Column4})
        Me.dgvLeave.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvLeave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLeave.Location = New System.Drawing.Point(0, 0)
        Me.dgvLeave.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvLeave.MultiSelect = False
        Me.dgvLeave.Name = "dgvLeave"
        Me.dgvLeave.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLeave.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvLeave.RowHeadersVisible = False
        Me.dgvLeave.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvLeave.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvLeave.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvLeave.RowTemplate.Height = 30
        Me.dgvLeave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLeave.Size = New System.Drawing.Size(928, 327)
        Me.dgvLeave.TabIndex = 66
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
        'Code
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code.DefaultCellStyle = DataGridViewCellStyle2
        Me.Code.FillWeight = 97.68703!
        Me.Code.HeaderText = "Leave Type"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        '
        'AvailmentDate
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailmentDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.AvailmentDate.FillWeight = 106.7164!
        Me.AvailmentDate.HeaderText = "Start Date"
        Me.AvailmentDate.Name = "AvailmentDate"
        Me.AvailmentDate.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 109.127!
        Me.Column2.HeaderText = "End Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'TimeRange
        '
        Me.TimeRange.FillWeight = 105.1344!
        Me.TimeRange.HeaderText = "Time Range"
        Me.TimeRange.Name = "TimeRange"
        Me.TimeRange.ReadOnly = True
        '
        'Hour
        '
        Me.Hour.FillWeight = 81.8657!
        Me.Hour.HeaderText = "Hour"
        Me.Hour.Name = "Hour"
        Me.Hour.ReadOnly = True
        '
        'LeaveCount
        '
        Me.LeaveCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.LeaveCount.DefaultCellStyle = DataGridViewCellStyle4
        Me.LeaveCount.FillWeight = 97.97103!
        Me.LeaveCount.HeaderText = "Leave Count"
        Me.LeaveCount.Name = "LeaveCount"
        Me.LeaveCount.ReadOnly = True
        '
        'DateFiled
        '
        Me.DateFiled.FillWeight = 82.39674!
        Me.DateFiled.HeaderText = "Day Type"
        Me.DateFiled.Name = "DateFiled"
        Me.DateFiled.ReadOnly = True
        '
        'Status
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.DefaultCellStyle = DataGridViewCellStyle5
        Me.Status.FillWeight = 76.93766!
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "ApproverName"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'PostingName
        '
        Me.PostingName.HeaderText = "PostingName"
        Me.PostingName.Name = "PostingName"
        Me.PostingName.ReadOnly = True
        Me.PostingName.Visible = False
        '
        'PostingDate
        '
        Me.PostingDate.HeaderText = "PostingDate"
        Me.PostingDate.Name = "PostingDate"
        Me.PostingDate.ReadOnly = True
        Me.PostingDate.Visible = False
        '
        'StatusRemarks
        '
        Me.StatusRemarks.HeaderText = "StatusRemarks"
        Me.StatusRemarks.Name = "StatusRemarks"
        Me.StatusRemarks.ReadOnly = True
        Me.StatusRemarks.Visible = False
        '
        'Remarks
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Remarks.DefaultCellStyle = DataGridViewCellStyle6
        Me.Remarks.FillWeight = 158.0734!
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        Me.Remarks.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "DateFiled"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "LeaveCredit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
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
        'frmTK_DataGridViewLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTK_DataGridViewLeave"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmTK_DataGridViewLeave"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvLeave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvLeave As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UpdateStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteThisFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents AvailmentDate As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents TimeRange As DataGridViewTextBoxColumn
    Friend WithEvents Hour As DataGridViewTextBoxColumn
    Friend WithEvents LeaveCount As DataGridViewTextBoxColumn
    Friend WithEvents DateFiled As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents PostingName As DataGridViewTextBoxColumn
    Friend WithEvents PostingDate As DataGridViewTextBoxColumn
    Friend WithEvents StatusRemarks As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
