<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSSM_SystemUserAccessMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSSM_SystemUserAccessMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripBtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripBtnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonHelp = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchFilter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.toolstriplabelNoOfRecord = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Panel38 = New System.Windows.Forms.Panel()
        Me.Panel40 = New System.Windows.Forms.Panel()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.Panel46 = New System.Windows.Forms.Panel()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.dgvSystemUsers = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvSystemUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 37)
        Me.Panel1.TabIndex = 23
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripBtnRefresh, Me.ToolStripLabel7, Me.ToolStripBtnClose, Me.ToolStripButtonHelp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(996, 35)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(280, 32)
        Me.ToolStripLabel1.Text = "System Settings Module > Transaction > User Access"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStripBtnRefresh
        '
        Me.ToolStripBtnRefresh.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_refresh_96
        Me.ToolStripBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnRefresh.Name = "ToolStripBtnRefresh"
        Me.ToolStripBtnRefresh.Size = New System.Drawing.Size(66, 32)
        Me.ToolStripBtnRefresh.Text = "Refresh"
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(109, 32)
        Me.ToolStripLabel7.Text = "                                  "
        '
        'ToolStripBtnClose
        '
        Me.ToolStripBtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripBtnClose.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_close_48
        Me.ToolStripBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnClose.Name = "ToolStripBtnClose"
        Me.ToolStripBtnClose.Size = New System.Drawing.Size(55, 32)
        Me.ToolStripBtnClose.Text = "Close"
        '
        'ToolStripButtonHelp
        '
        Me.ToolStripButtonHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButtonHelp.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.question
        Me.ToolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonHelp.Name = "ToolStripButtonHelp"
        Me.ToolStripButtonHelp.Size = New System.Drawing.Size(51, 32)
        Me.ToolStripButtonHelp.Text = "Help"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 591)
        Me.Panel2.TabIndex = 80
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(988, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 591)
        Me.Panel3.TabIndex = 87
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(10, 618)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(978, 10)
        Me.Panel6.TabIndex = 88
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.btnSearchFilter)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtboxSearch)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.ToolStrip2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(10, 37)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(978, 93)
        Me.Panel4.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label1.Location = New System.Drawing.Point(313, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 12)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Mode :"
        '
        'btnSearchFilter
        '
        Me.btnSearchFilter.BackColor = System.Drawing.Color.Navy
        Me.btnSearchFilter.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnSearchFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchFilter.ForeColor = System.Drawing.Color.White
        Me.btnSearchFilter.Location = New System.Drawing.Point(315, 32)
        Me.btnSearchFilter.Name = "btnSearchFilter"
        Me.btnSearchFilter.Size = New System.Drawing.Size(137, 23)
        Me.btnSearchFilter.TabIndex = 57
        Me.btnSearchFilter.Text = "Employee"
        Me.btnSearchFilter.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label2.Location = New System.Drawing.Point(77, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 12)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "You may search any value on the search bar."
        '
        'txtboxSearch
        '
        Me.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxSearch.Location = New System.Drawing.Point(61, 33)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(236, 22)
        Me.txtboxSearch.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Search "
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Navy
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripLabel2, Me.toolstriplabelNoOfRecord, Me.ToolStripLabel4})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 68)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip2.Size = New System.Drawing.Size(978, 25)
        Me.ToolStrip2.TabIndex = 37
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripLabel3.Text = "U S E R  A C C E S S   R I G H T S"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(158, 22)
        Me.ToolStripLabel2.Text = "-- [ No. of Record Retrieved :"
        '
        'toolstriplabelNoOfRecord
        '
        Me.toolstriplabelNoOfRecord.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.toolstriplabelNoOfRecord.ForeColor = System.Drawing.Color.Gold
        Me.toolstriplabelNoOfRecord.Name = "toolstriplabelNoOfRecord"
        Me.toolstriplabelNoOfRecord.Size = New System.Drawing.Size(150, 22)
        Me.toolstriplabelNoOfRecord.Text = "toolstriplabelNoOfRecord"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripLabel4.Text = "] --"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "document.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-add-96.png")
        Me.ImageList1.Images.SetKeyName(2, "pen.png")
        Me.ImageList1.Images.SetKeyName(3, "timesheetcorrection.png")
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Navy
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(10, 130)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(978, 3)
        Me.Panel8.TabIndex = 90
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Navy
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(10, 133)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(3, 485)
        Me.Panel10.TabIndex = 91
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Navy
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(13, 615)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(975, 3)
        Me.Panel7.TabIndex = 92
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Navy
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(985, 133)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(3, 482)
        Me.Panel9.TabIndex = 93
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.LightGray
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel31.Location = New System.Drawing.Point(13, 133)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(972, 5)
        Me.Panel31.TabIndex = 94
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.LightGray
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel34.Location = New System.Drawing.Point(13, 138)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(5, 477)
        Me.Panel34.TabIndex = 95
        '
        'Panel36
        '
        Me.Panel36.BackColor = System.Drawing.Color.LightGray
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel36.Location = New System.Drawing.Point(980, 138)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(5, 477)
        Me.Panel36.TabIndex = 96
        '
        'Panel38
        '
        Me.Panel38.BackColor = System.Drawing.Color.LightGray
        Me.Panel38.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel38.Location = New System.Drawing.Point(18, 610)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(962, 5)
        Me.Panel38.TabIndex = 97
        '
        'Panel40
        '
        Me.Panel40.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel40.Location = New System.Drawing.Point(18, 138)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(962, 5)
        Me.Panel40.TabIndex = 98
        '
        'Panel43
        '
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel43.Location = New System.Drawing.Point(975, 143)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(5, 467)
        Me.Panel43.TabIndex = 99
        '
        'Panel46
        '
        Me.Panel46.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel46.Location = New System.Drawing.Point(18, 605)
        Me.Panel46.Name = "Panel46"
        Me.Panel46.Size = New System.Drawing.Size(957, 5)
        Me.Panel46.TabIndex = 100
        '
        'Panel42
        '
        Me.Panel42.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel42.Location = New System.Drawing.Point(18, 143)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(5, 462)
        Me.Panel42.TabIndex = 101
        '
        'dgvSystemUsers
        '
        Me.dgvSystemUsers.AllowUserToAddRows = False
        Me.dgvSystemUsers.AllowUserToDeleteRows = False
        Me.dgvSystemUsers.AllowUserToResizeColumns = False
        Me.dgvSystemUsers.AllowUserToResizeRows = False
        Me.dgvSystemUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSystemUsers.BackgroundColor = System.Drawing.Color.White
        Me.dgvSystemUsers.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSystemUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSystemUsers.ColumnHeadersHeight = 35
        Me.dgvSystemUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSystemUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvSystemUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSystemUsers.Location = New System.Drawing.Point(23, 143)
        Me.dgvSystemUsers.MultiSelect = False
        Me.dgvSystemUsers.Name = "dgvSystemUsers"
        Me.dgvSystemUsers.ReadOnly = True
        Me.dgvSystemUsers.RowHeadersVisible = False
        Me.dgvSystemUsers.RowTemplate.Height = 30
        Me.dgvSystemUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSystemUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSystemUsers.Size = New System.Drawing.Size(952, 462)
        Me.dgvSystemUsers.TabIndex = 106
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'Column1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "User Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "Employee Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 104
        '
        'Column3
        '
        Me.Column3.HeaderText = "Group Access"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 93
        '
        'Column4
        '
        Me.Column4.HeaderText = "Access Type"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 83
        '
        'Column5
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Password Protected?"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 126
        '
        'frmSSM_SystemUserAccessMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 628)
        Me.Controls.Add(Me.dgvSystemUsers)
        Me.Controls.Add(Me.Panel42)
        Me.Controls.Add(Me.Panel46)
        Me.Controls.Add(Me.Panel43)
        Me.Controls.Add(Me.Panel40)
        Me.Controls.Add(Me.Panel38)
        Me.Controls.Add(Me.Panel36)
        Me.Controls.Add(Me.Panel34)
        Me.Controls.Add(Me.Panel31)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSSM_SystemUserAccessMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmSSM_SystemUserAccessMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvSystemUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripBtnRefresh As ToolStripButton
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripBtnClose As ToolStripButton
    Friend WithEvents ToolStripButtonHelp As ToolStripButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchFilter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents toolstriplabelNoOfRecord As ToolStripLabel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel36 As Panel
    Friend WithEvents Panel38 As Panel
    Friend WithEvents Panel40 As Panel
    Friend WithEvents Panel43 As Panel
    Friend WithEvents Panel46 As Panel
    Friend WithEvents Panel42 As Panel
    Friend WithEvents dgvSystemUsers As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
