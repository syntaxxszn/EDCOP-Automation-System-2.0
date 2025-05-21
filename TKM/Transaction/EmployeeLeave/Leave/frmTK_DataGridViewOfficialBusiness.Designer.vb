<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTK_DataGridViewOfficialBusiness
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
        Me.dgvOfficialBusiness = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ControlNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Period = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Transport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preparedby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreparedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Approvedby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverheadDepartment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargeTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateFiled = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteThisFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvOfficialBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.dgvOfficialBusiness)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 327)
        Me.Panel1.TabIndex = 1
        '
        'dgvOfficialBusiness
        '
        Me.dgvOfficialBusiness.AllowUserToAddRows = False
        Me.dgvOfficialBusiness.AllowUserToDeleteRows = False
        Me.dgvOfficialBusiness.AllowUserToResizeColumns = False
        Me.dgvOfficialBusiness.AllowUserToResizeRows = False
        Me.dgvOfficialBusiness.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOfficialBusiness.BackgroundColor = System.Drawing.Color.White
        Me.dgvOfficialBusiness.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOfficialBusiness.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOfficialBusiness.ColumnHeadersHeight = 35
        Me.dgvOfficialBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvOfficialBusiness.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.EmployeeName, Me.Department, Me.ControlNumber, Me.Purpose, Me.DestinationFrom, Me.DestinationTo, Me.Period, Me.ETD, Me.ETA, Me.Transport, Me.Preparedby, Me.PreparedDate, Me.Approvedby, Me.OverheadDepartment, Me.ChargeTo, Me.ProjectName, Me.Status, Me.DateFiled})
        Me.dgvOfficialBusiness.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvOfficialBusiness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOfficialBusiness.Location = New System.Drawing.Point(0, 0)
        Me.dgvOfficialBusiness.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvOfficialBusiness.Name = "dgvOfficialBusiness"
        Me.dgvOfficialBusiness.ReadOnly = True
        Me.dgvOfficialBusiness.RowHeadersVisible = False
        Me.dgvOfficialBusiness.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvOfficialBusiness.RowTemplate.Height = 30
        Me.dgvOfficialBusiness.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOfficialBusiness.Size = New System.Drawing.Size(928, 327)
        Me.dgvOfficialBusiness.TabIndex = 1
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
        'ControlNumber
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlNumber.DefaultCellStyle = DataGridViewCellStyle2
        Me.ControlNumber.FillWeight = 91.37057!
        Me.ControlNumber.HeaderText = "Control Number"
        Me.ControlNumber.Name = "ControlNumber"
        Me.ControlNumber.ReadOnly = True
        '
        'Purpose
        '
        Me.Purpose.FillWeight = 110.9139!
        Me.Purpose.HeaderText = "Purpose"
        Me.Purpose.Name = "Purpose"
        Me.Purpose.ReadOnly = True
        '
        'DestinationFrom
        '
        Me.DestinationFrom.HeaderText = "DestinationFrom"
        Me.DestinationFrom.Name = "DestinationFrom"
        Me.DestinationFrom.ReadOnly = True
        Me.DestinationFrom.Visible = False
        '
        'DestinationTo
        '
        Me.DestinationTo.FillWeight = 110.9139!
        Me.DestinationTo.HeaderText = "Destination To"
        Me.DestinationTo.Name = "DestinationTo"
        Me.DestinationTo.ReadOnly = True
        '
        'Period
        '
        Me.Period.FillWeight = 110.9139!
        Me.Period.HeaderText = "Period"
        Me.Period.Name = "Period"
        Me.Period.ReadOnly = True
        '
        'ETD
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ETD.DefaultCellStyle = DataGridViewCellStyle3
        Me.ETD.FillWeight = 73.13004!
        Me.ETD.HeaderText = "ETD"
        Me.ETD.Name = "ETD"
        Me.ETD.ReadOnly = True
        Me.ETD.Visible = False
        '
        'ETA
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ETA.DefaultCellStyle = DataGridViewCellStyle4
        Me.ETA.FillWeight = 70.016!
        Me.ETA.HeaderText = "ETA"
        Me.ETA.Name = "ETA"
        Me.ETA.ReadOnly = True
        Me.ETA.Visible = False
        '
        'Transport
        '
        Me.Transport.FillWeight = 110.9139!
        Me.Transport.HeaderText = "Transport"
        Me.Transport.Name = "Transport"
        Me.Transport.ReadOnly = True
        '
        'Preparedby
        '
        Me.Preparedby.HeaderText = "Preparedby"
        Me.Preparedby.Name = "Preparedby"
        Me.Preparedby.ReadOnly = True
        Me.Preparedby.Visible = False
        '
        'PreparedDate
        '
        Me.PreparedDate.HeaderText = "PreparedDate"
        Me.PreparedDate.Name = "PreparedDate"
        Me.PreparedDate.ReadOnly = True
        Me.PreparedDate.Visible = False
        '
        'Approvedby
        '
        Me.Approvedby.HeaderText = "Approvedby"
        Me.Approvedby.Name = "Approvedby"
        Me.Approvedby.ReadOnly = True
        Me.Approvedby.Visible = False
        '
        'OverheadDepartment
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.OverheadDepartment.DefaultCellStyle = DataGridViewCellStyle5
        Me.OverheadDepartment.HeaderText = "Overhead Dept."
        Me.OverheadDepartment.Name = "OverheadDepartment"
        Me.OverheadDepartment.ReadOnly = True
        '
        'ChargeTo
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ChargeTo.DefaultCellStyle = DataGridViewCellStyle6
        Me.ChargeTo.FillWeight = 110.9139!
        Me.ChargeTo.HeaderText = "Project No."
        Me.ChargeTo.Name = "ChargeTo"
        Me.ChargeTo.ReadOnly = True
        '
        'ProjectName
        '
        Me.ProjectName.HeaderText = "Project Name"
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.ReadOnly = True
        Me.ProjectName.Visible = False
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
        'DateFiled
        '
        Me.DateFiled.HeaderText = "DateFiled"
        Me.DateFiled.Name = "DateFiled"
        Me.DateFiled.ReadOnly = True
        Me.DateFiled.Visible = False
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
        'frmTK_DataGridViewOfficialBusiness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTK_DataGridViewOfficialBusiness"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmTK_DataGridViewOfficialBusiness"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvOfficialBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvOfficialBusiness As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UpdateStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteThisFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents ControlNumber As DataGridViewTextBoxColumn
    Friend WithEvents Purpose As DataGridViewTextBoxColumn
    Friend WithEvents DestinationFrom As DataGridViewTextBoxColumn
    Friend WithEvents DestinationTo As DataGridViewTextBoxColumn
    Friend WithEvents Period As DataGridViewTextBoxColumn
    Friend WithEvents ETD As DataGridViewTextBoxColumn
    Friend WithEvents ETA As DataGridViewTextBoxColumn
    Friend WithEvents Transport As DataGridViewTextBoxColumn
    Friend WithEvents Preparedby As DataGridViewTextBoxColumn
    Friend WithEvents PreparedDate As DataGridViewTextBoxColumn
    Friend WithEvents Approvedby As DataGridViewTextBoxColumn
    Friend WithEvents OverheadDepartment As DataGridViewTextBoxColumn
    Friend WithEvents ChargeTo As DataGridViewTextBoxColumn
    Friend WithEvents ProjectName As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents DateFiled As DataGridViewTextBoxColumn
End Class
