<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFMIS_Setup_FiscalPeriod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFMIS_Setup_FiscalPeriod))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripBtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonHelp = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchFilter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.ImageListBtn = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCreateNew = New System.Windows.Forms.Button()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.toolstriplabelNoOfRecord = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.dgvFiscalPeriod = New System.Windows.Forms.DataGridView()
        Me.CompanyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiscalYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxForm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.dgvFiscalPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1076, 37)
        Me.Panel1.TabIndex = 22
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripBtnRefresh, Me.ToolStripBtnClose, Me.ToolStripButtonHelp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1074, 35)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(293, 32)
        Me.ToolStripLabel1.Text = "Financial Management Module > Setup > Fiscal Period"
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
        Me.Panel2.Size = New System.Drawing.Size(10, 566)
        Me.Panel2.TabIndex = 79
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(10, 593)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1066, 10)
        Me.Panel6.TabIndex = 85
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1066, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 556)
        Me.Panel3.TabIndex = 86
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.btnSearchFilter)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtboxSearch)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.btnEdit)
        Me.Panel4.Controls.Add(Me.btnCreateNew)
        Me.Panel4.Controls.Add(Me.ToolStrip2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(10, 37)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1056, 93)
        Me.Panel4.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label1.Location = New System.Drawing.Point(900, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 12)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Search Mode :"
        '
        'btnSearchFilter
        '
        Me.btnSearchFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchFilter.BackColor = System.Drawing.Color.Navy
        Me.btnSearchFilter.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnSearchFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFilter.ForeColor = System.Drawing.Color.White
        Me.btnSearchFilter.Location = New System.Drawing.Point(902, 28)
        Me.btnSearchFilter.Name = "btnSearchFilter"
        Me.btnSearchFilter.Size = New System.Drawing.Size(137, 23)
        Me.btnSearchFilter.TabIndex = 52
        Me.btnSearchFilter.Text = "Fiscal"
        Me.btnSearchFilter.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label2.Location = New System.Drawing.Point(649, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 12)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "You may search any value on the search bar."
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxSearch.Location = New System.Drawing.Point(648, 29)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(236, 22)
        Me.txtboxSearch.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(598, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Search "
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.White
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Navy
        Me.btnEdit.ImageIndex = 1
        Me.btnEdit.ImageList = Me.ImageListBtn
        Me.btnEdit.Location = New System.Drawing.Point(127, 14)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(115, 39)
        Me.btnEdit.TabIndex = 48
        Me.btnEdit.Text = " &Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'ImageListBtn
        '
        Me.ImageListBtn.ImageStream = CType(resources.GetObject("ImageListBtn.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBtn.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListBtn.Images.SetKeyName(0, "icons8-add-96.png")
        Me.ImageListBtn.Images.SetKeyName(1, "pen.png")
        '
        'btnCreateNew
        '
        Me.btnCreateNew.BackColor = System.Drawing.Color.White
        Me.btnCreateNew.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateNew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNew.ForeColor = System.Drawing.Color.Navy
        Me.btnCreateNew.ImageIndex = 0
        Me.btnCreateNew.ImageList = Me.ImageListBtn
        Me.btnCreateNew.Location = New System.Drawing.Point(6, 14)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.Size = New System.Drawing.Size(115, 39)
        Me.btnCreateNew.TabIndex = 47
        Me.btnCreateNew.Text = " &Create New"
        Me.btnCreateNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreateNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreateNew.UseVisualStyleBackColor = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Navy
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripLabel2, Me.toolstriplabelNoOfRecord, Me.ToolStripLabel4})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 68)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip2.Size = New System.Drawing.Size(1056, 25)
        Me.ToolStrip2.TabIndex = 37
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(201, 22)
        Me.ToolStripLabel3.Text = "F I S C A L   P E R I O D   D E T A I L S"
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
        Me.toolstriplabelNoOfRecord.Size = New System.Drawing.Size(14, 22)
        Me.toolstriplabelNoOfRecord.Text = "0"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripLabel4.Text = "] --"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Navy
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(10, 130)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1056, 3)
        Me.Panel8.TabIndex = 88
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Navy
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(10, 133)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(3, 460)
        Me.Panel10.TabIndex = 89
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Navy
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(13, 590)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1053, 3)
        Me.Panel7.TabIndex = 90
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Navy
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(1063, 133)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(3, 457)
        Me.Panel9.TabIndex = 91
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Panel11)
        Me.Panel5.Controls.Add(Me.Panel12)
        Me.Panel5.Controls.Add(Me.Panel13)
        Me.Panel5.Controls.Add(Me.Panel14)
        Me.Panel5.Controls.Add(Me.Panel15)
        Me.Panel5.Controls.Add(Me.Panel16)
        Me.Panel5.Controls.Add(Me.Panel17)
        Me.Panel5.Controls.Add(Me.Panel18)
        Me.Panel5.Controls.Add(Me.Panel19)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(13, 133)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1050, 457)
        Me.Panel5.TabIndex = 92
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.dgvFiscalPeriod)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(10, 10)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1030, 437)
        Me.Panel11.TabIndex = 8
        '
        'dgvFiscalPeriod
        '
        Me.dgvFiscalPeriod.AllowUserToAddRows = False
        Me.dgvFiscalPeriod.AllowUserToDeleteRows = False
        Me.dgvFiscalPeriod.AllowUserToResizeColumns = False
        Me.dgvFiscalPeriod.AllowUserToResizeRows = False
        Me.dgvFiscalPeriod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFiscalPeriod.BackgroundColor = System.Drawing.Color.White
        Me.dgvFiscalPeriod.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFiscalPeriod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFiscalPeriod.ColumnHeadersHeight = 35
        Me.dgvFiscalPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFiscalPeriod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompanyID, Me.FiscalYear, Me.TaxYear, Me.TaxForm})
        Me.dgvFiscalPeriod.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvFiscalPeriod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFiscalPeriod.Location = New System.Drawing.Point(0, 0)
        Me.dgvFiscalPeriod.MultiSelect = False
        Me.dgvFiscalPeriod.Name = "dgvFiscalPeriod"
        Me.dgvFiscalPeriod.ReadOnly = True
        Me.dgvFiscalPeriod.RowHeadersVisible = False
        Me.dgvFiscalPeriod.RowTemplate.Height = 30
        Me.dgvFiscalPeriod.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFiscalPeriod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFiscalPeriod.Size = New System.Drawing.Size(1030, 437)
        Me.dgvFiscalPeriod.TabIndex = 9
        '
        'CompanyID
        '
        Me.CompanyID.HeaderText = "ID"
        Me.CompanyID.Name = "CompanyID"
        Me.CompanyID.ReadOnly = True
        Me.CompanyID.Visible = False
        '
        'FiscalYear
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiscalYear.DefaultCellStyle = DataGridViewCellStyle2
        Me.FiscalYear.FillWeight = 60.06027!
        Me.FiscalYear.HeaderText = "Fiscal Year"
        Me.FiscalYear.Name = "FiscalYear"
        Me.FiscalYear.ReadOnly = True
        '
        'TaxYear
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TaxYear.DefaultCellStyle = DataGridViewCellStyle3
        Me.TaxYear.HeaderText = "Tax Year"
        Me.TaxYear.Name = "TaxYear"
        Me.TaxYear.ReadOnly = True
        '
        'TaxForm
        '
        Me.TaxForm.HeaderText = "Tax Form"
        Me.TaxForm.Name = "TaxForm"
        Me.TaxForm.ReadOnly = True
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(10, 5)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1030, 5)
        Me.Panel12.TabIndex = 7
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel13.Location = New System.Drawing.Point(1040, 5)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(5, 442)
        Me.Panel13.TabIndex = 6
        '
        'Panel14
        '
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel14.Location = New System.Drawing.Point(10, 447)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1035, 5)
        Me.Panel14.TabIndex = 5
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(5, 5)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(5, 447)
        Me.Panel15.TabIndex = 4
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.LightGray
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel16.Location = New System.Drawing.Point(1045, 5)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(5, 447)
        Me.Panel16.TabIndex = 3
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.LightGray
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(5, 452)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1045, 5)
        Me.Panel17.TabIndex = 2
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.LightGray
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(0, 5)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(5, 452)
        Me.Panel18.TabIndex = 1
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.LightGray
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1050, 5)
        Me.Panel19.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_close_48
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'frmFMIS_Setup_FiscalPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 603)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFMIS_Setup_FiscalPeriod"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Setup - FiscalPeriod"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.dgvFiscalPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripBtnRefresh As ToolStripButton
    Friend WithEvents ToolStripBtnClose As ToolStripButton
    Friend WithEvents ToolStripButtonHelp As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchFilter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCreateNew As Button
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents toolstriplabelNoOfRecord As ToolStripLabel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ImageListBtn As ImageList
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents dgvFiscalPeriod As DataGridView
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents CompanyID As DataGridViewTextBoxColumn
    Friend WithEvents FiscalYear As DataGridViewTextBoxColumn
    Friend WithEvents TaxYear As DataGridViewTextBoxColumn
    Friend WithEvents TaxForm As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
