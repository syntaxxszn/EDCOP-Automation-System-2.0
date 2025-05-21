<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRIS_Transaction_TrainingEnrollment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRIS_Transaction_TrainingEnrollment))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.dgvTrainingList = New System.Windows.Forms.DataGridView()
        Me.ShiftID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripTrainingList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddNewTrainingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteThisTrainingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.lblTrainingName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.dgvTrainingBatchList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripTrainingBatch = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddNewBatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteThisBatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ImageListBtn = New System.Windows.Forms.ImageList(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel44 = New System.Windows.Forms.Panel()
        Me.btnEditBatch = New System.Windows.Forms.Button()
        Me.btnAddNewBatch = New System.Windows.Forms.Button()
        Me.Panel40 = New System.Windows.Forms.Panel()
        Me.lblTrainingBatch = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel39 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.dgvEnrolledEmployee = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripTrainingEnrollees = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EnrollEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateTrainingResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.btnUpdateResult = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel46 = New System.Windows.Forms.Panel()
        Me.btnEnrollEmployee = New System.Windows.Forms.Button()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.Panel38 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCreateNew = New System.Windows.Forms.Button()
        Me.btnSearchFilter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripBtnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.dgvTrainingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripTrainingList.SuspendLayout()
        Me.Panel42.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.dgvTrainingBatchList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripTrainingBatch.SuspendLayout()
        Me.Panel43.SuspendLayout()
        Me.Panel40.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel41.SuspendLayout()
        CType(Me.dgvEnrolledEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripTrainingEnrollees.SuspendLayout()
        Me.Panel45.SuspendLayout()
        Me.Panel33.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 678)
        Me.Panel1.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.SplitContainer1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(13, 106)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1174, 559)
        Me.Panel8.TabIndex = 78
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel26)
        Me.SplitContainer1.Size = New System.Drawing.Size(1174, 559)
        Me.SplitContainer1.SplitterDistance = 360
        Me.SplitContainer1.TabIndex = 38
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel12)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel13)
        Me.SplitContainer2.Size = New System.Drawing.Size(1174, 360)
        Me.SplitContainer2.SplitterDistance = 180
        Me.SplitContainer2.TabIndex = 0
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.dgvTrainingList)
        Me.Panel12.Controls.Add(Me.Panel42)
        Me.Panel12.Controls.Add(Me.Panel34)
        Me.Panel12.Controls.Add(Me.Panel32)
        Me.Panel12.Controls.Add(Me.Panel24)
        Me.Panel12.Controls.Add(Me.Panel22)
        Me.Panel12.Controls.Add(Me.Panel21)
        Me.Panel12.Controls.Add(Me.Panel19)
        Me.Panel12.Controls.Add(Me.Panel16)
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1174, 180)
        Me.Panel12.TabIndex = 0
        '
        'dgvTrainingList
        '
        Me.dgvTrainingList.AllowUserToAddRows = False
        Me.dgvTrainingList.AllowUserToDeleteRows = False
        Me.dgvTrainingList.AllowUserToResizeColumns = False
        Me.dgvTrainingList.AllowUserToResizeRows = False
        Me.dgvTrainingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTrainingList.BackgroundColor = System.Drawing.Color.White
        Me.dgvTrainingList.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTrainingList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTrainingList.ColumnHeadersHeight = 35
        Me.dgvTrainingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTrainingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShiftID, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvTrainingList.ContextMenuStrip = Me.ContextMenuStripTrainingList
        Me.dgvTrainingList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTrainingList.Location = New System.Drawing.Point(10, 34)
        Me.dgvTrainingList.MultiSelect = False
        Me.dgvTrainingList.Name = "dgvTrainingList"
        Me.dgvTrainingList.ReadOnly = True
        Me.dgvTrainingList.RowHeadersVisible = False
        Me.dgvTrainingList.RowTemplate.Height = 30
        Me.dgvTrainingList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTrainingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTrainingList.Size = New System.Drawing.Size(1154, 136)
        Me.dgvTrainingList.TabIndex = 11
        '
        'ShiftID
        '
        Me.ShiftID.HeaderText = "ID"
        Me.ShiftID.Name = "ShiftID"
        Me.ShiftID.ReadOnly = True
        Me.ShiftID.Visible = False
        '
        'Column1
        '
        Me.Column1.FillWeight = 146.3221!
        Me.Column1.HeaderText = "Training Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.FillWeight = 55.53122!
        Me.Column2.HeaderText = "Category"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.FillWeight = 50.76143!
        Me.Column3.HeaderText = "Nature"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 126.2496!
        Me.Column4.HeaderText = "Description"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 121.1356!
        Me.Column5.HeaderText = "Remarks"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'ContextMenuStripTrainingList
        '
        Me.ContextMenuStripTrainingList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewTrainingToolStripMenuItem, Me.DeleteThisTrainingToolStripMenuItem})
        Me.ContextMenuStripTrainingList.Name = "ContextMenuStripTrainingList"
        Me.ContextMenuStripTrainingList.Size = New System.Drawing.Size(175, 48)
        '
        'AddNewTrainingToolStripMenuItem
        '
        Me.AddNewTrainingToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_add_96
        Me.AddNewTrainingToolStripMenuItem.Name = "AddNewTrainingToolStripMenuItem"
        Me.AddNewTrainingToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AddNewTrainingToolStripMenuItem.Text = "Add New Training"
        '
        'DeleteThisTrainingToolStripMenuItem
        '
        Me.DeleteThisTrainingToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_close_48
        Me.DeleteThisTrainingToolStripMenuItem.Name = "DeleteThisTrainingToolStripMenuItem"
        Me.DeleteThisTrainingToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DeleteThisTrainingToolStripMenuItem.Text = "Delete this Training"
        '
        'Panel42
        '
        Me.Panel42.BackColor = System.Drawing.Color.Navy
        Me.Panel42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel42.Controls.Add(Me.lblTrainingName)
        Me.Panel42.Controls.Add(Me.Label8)
        Me.Panel42.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel42.Location = New System.Drawing.Point(10, 10)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(1154, 24)
        Me.Panel42.TabIndex = 10
        '
        'lblTrainingName
        '
        Me.lblTrainingName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTrainingName.AutoSize = True
        Me.lblTrainingName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainingName.ForeColor = System.Drawing.Color.LightCoral
        Me.lblTrainingName.Location = New System.Drawing.Point(149, 4)
        Me.lblTrainingName.Name = "lblTrainingName"
        Me.lblTrainingName.Size = New System.Drawing.Size(14, 15)
        Me.lblTrainingName.TabIndex = 3
        Me.lblTrainingName.Text = "x"
        Me.lblTrainingName.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(5, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "T R A I N I N G   L I S T"
        '
        'Panel34
        '
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel34.Location = New System.Drawing.Point(1164, 10)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(5, 160)
        Me.Panel34.TabIndex = 9
        '
        'Panel32
        '
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel32.Location = New System.Drawing.Point(10, 170)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(1159, 5)
        Me.Panel32.TabIndex = 8
        '
        'Panel24
        '
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(5, 10)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(5, 165)
        Me.Panel24.TabIndex = 7
        '
        'Panel22
        '
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(5, 5)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1164, 5)
        Me.Panel22.TabIndex = 6
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.LightGray
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel21.Location = New System.Drawing.Point(1169, 5)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(5, 170)
        Me.Panel21.TabIndex = 4
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.LightGray
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel19.Location = New System.Drawing.Point(5, 175)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1169, 5)
        Me.Panel19.TabIndex = 3
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.LightGray
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(0, 5)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(5, 175)
        Me.Panel16.TabIndex = 2
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.LightGray
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1174, 5)
        Me.Panel14.TabIndex = 1
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.dgvTrainingBatchList)
        Me.Panel13.Controls.Add(Me.Panel43)
        Me.Panel13.Controls.Add(Me.Panel40)
        Me.Panel13.Controls.Add(Me.Panel39)
        Me.Panel13.Controls.Add(Me.Panel31)
        Me.Panel13.Controls.Add(Me.Panel25)
        Me.Panel13.Controls.Add(Me.Panel23)
        Me.Panel13.Controls.Add(Me.Panel20)
        Me.Panel13.Controls.Add(Me.Panel18)
        Me.Panel13.Controls.Add(Me.Panel17)
        Me.Panel13.Controls.Add(Me.Panel15)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1174, 176)
        Me.Panel13.TabIndex = 0
        '
        'dgvTrainingBatchList
        '
        Me.dgvTrainingBatchList.AllowUserToAddRows = False
        Me.dgvTrainingBatchList.AllowUserToDeleteRows = False
        Me.dgvTrainingBatchList.AllowUserToResizeColumns = False
        Me.dgvTrainingBatchList.AllowUserToResizeRows = False
        Me.dgvTrainingBatchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTrainingBatchList.BackgroundColor = System.Drawing.Color.White
        Me.dgvTrainingBatchList.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTrainingBatchList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTrainingBatchList.ColumnHeadersHeight = 35
        Me.dgvTrainingBatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTrainingBatchList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13})
        Me.dgvTrainingBatchList.ContextMenuStrip = Me.ContextMenuStripTrainingBatch
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTrainingBatchList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTrainingBatchList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTrainingBatchList.Location = New System.Drawing.Point(10, 87)
        Me.dgvTrainingBatchList.MultiSelect = False
        Me.dgvTrainingBatchList.Name = "dgvTrainingBatchList"
        Me.dgvTrainingBatchList.ReadOnly = True
        Me.dgvTrainingBatchList.RowHeadersVisible = False
        Me.dgvTrainingBatchList.RowTemplate.Height = 30
        Me.dgvTrainingBatchList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTrainingBatchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTrainingBatchList.Size = New System.Drawing.Size(1154, 79)
        Me.dgvTrainingBatchList.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Column6
        '
        Me.Column6.FillWeight = 90.25182!
        Me.Column6.HeaderText = "Batch No."
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.FillWeight = 87.55665!
        Me.Column7.HeaderText = "Code"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.FillWeight = 84.55694!
        Me.Column8.HeaderText = "Status"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.FillWeight = 114.1041!
        Me.Column9.HeaderText = "Plan"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.FillWeight = 114.1041!
        Me.Column10.HeaderText = "Actual"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.FillWeight = 81.21828!
        Me.Column11.HeaderText = "Hours"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.FillWeight = 114.1041!
        Me.Column12.HeaderText = "Facilitator"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.FillWeight = 114.1041!
        Me.Column13.HeaderText = "Venue"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'ContextMenuStripTrainingBatch
        '
        Me.ContextMenuStripTrainingBatch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewBatchToolStripMenuItem, Me.DeleteThisBatchToolStripMenuItem})
        Me.ContextMenuStripTrainingBatch.Name = "ContextMenuStripTrainingBatch"
        Me.ContextMenuStripTrainingBatch.Size = New System.Drawing.Size(163, 48)
        '
        'AddNewBatchToolStripMenuItem
        '
        Me.AddNewBatchToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_add_96
        Me.AddNewBatchToolStripMenuItem.Name = "AddNewBatchToolStripMenuItem"
        Me.AddNewBatchToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AddNewBatchToolStripMenuItem.Text = "Add New Batch"
        '
        'DeleteThisBatchToolStripMenuItem
        '
        Me.DeleteThisBatchToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_close_48
        Me.DeleteThisBatchToolStripMenuItem.Name = "DeleteThisBatchToolStripMenuItem"
        Me.DeleteThisBatchToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DeleteThisBatchToolStripMenuItem.Text = "Delete this Batch"
        '
        'Panel43
        '
        Me.Panel43.BackColor = System.Drawing.Color.White
        Me.Panel43.Controls.Add(Me.Button5)
        Me.Panel43.Controls.Add(Me.Button4)
        Me.Panel43.Controls.Add(Me.Panel44)
        Me.Panel43.Controls.Add(Me.btnEditBatch)
        Me.Panel43.Controls.Add(Me.btnAddNewBatch)
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel43.Location = New System.Drawing.Point(10, 36)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(1154, 51)
        Me.Panel43.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Navy
        Me.Button5.ImageIndex = 5
        Me.Button5.ImageList = Me.ImageListBtn
        Me.Button5.Location = New System.Drawing.Point(868, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 38)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "  &Export"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ImageListBtn
        '
        Me.ImageListBtn.ImageStream = CType(resources.GetObject("ImageListBtn.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBtn.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListBtn.Images.SetKeyName(0, "icons8-add-96.png")
        Me.ImageListBtn.Images.SetKeyName(1, "pen.png")
        Me.ImageListBtn.Images.SetKeyName(2, "active.png")
        Me.ImageListBtn.Images.SetKeyName(3, "inactive.png")
        Me.ImageListBtn.Images.SetKeyName(4, "printing.png")
        Me.ImageListBtn.Images.SetKeyName(5, "export.png")
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.ImageIndex = 4
        Me.Button4.ImageList = Me.ImageListBtn
        Me.Button4.Location = New System.Drawing.Point(1015, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 38)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "  &Print"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel44
        '
        Me.Panel44.BackColor = System.Drawing.Color.LightGray
        Me.Panel44.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel44.Location = New System.Drawing.Point(0, 49)
        Me.Panel44.Name = "Panel44"
        Me.Panel44.Size = New System.Drawing.Size(1154, 2)
        Me.Panel44.TabIndex = 10
        '
        'btnEditBatch
        '
        Me.btnEditBatch.BackColor = System.Drawing.Color.White
        Me.btnEditBatch.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnEditBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBatch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBatch.ForeColor = System.Drawing.Color.Navy
        Me.btnEditBatch.ImageIndex = 1
        Me.btnEditBatch.ImageList = Me.ImageListBtn
        Me.btnEditBatch.Location = New System.Drawing.Point(147, 6)
        Me.btnEditBatch.Name = "btnEditBatch"
        Me.btnEditBatch.Size = New System.Drawing.Size(153, 38)
        Me.btnEditBatch.TabIndex = 44
        Me.btnEditBatch.Text = "  &Edit Batch"
        Me.btnEditBatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditBatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditBatch.UseVisualStyleBackColor = False
        '
        'btnAddNewBatch
        '
        Me.btnAddNewBatch.BackColor = System.Drawing.Color.White
        Me.btnAddNewBatch.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnAddNewBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewBatch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewBatch.ForeColor = System.Drawing.Color.Navy
        Me.btnAddNewBatch.ImageIndex = 0
        Me.btnAddNewBatch.ImageList = Me.ImageListBtn
        Me.btnAddNewBatch.Location = New System.Drawing.Point(0, 6)
        Me.btnAddNewBatch.Name = "btnAddNewBatch"
        Me.btnAddNewBatch.Size = New System.Drawing.Size(141, 38)
        Me.btnAddNewBatch.TabIndex = 43
        Me.btnAddNewBatch.Text = "  &Add New Batch"
        Me.btnAddNewBatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddNewBatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNewBatch.UseVisualStyleBackColor = False
        '
        'Panel40
        '
        Me.Panel40.BackColor = System.Drawing.Color.Navy
        Me.Panel40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel40.Controls.Add(Me.lblTrainingBatch)
        Me.Panel40.Controls.Add(Me.Label6)
        Me.Panel40.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel40.Location = New System.Drawing.Point(10, 10)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(1154, 26)
        Me.Panel40.TabIndex = 10
        '
        'lblTrainingBatch
        '
        Me.lblTrainingBatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTrainingBatch.AutoSize = True
        Me.lblTrainingBatch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainingBatch.ForeColor = System.Drawing.Color.LightCoral
        Me.lblTrainingBatch.Location = New System.Drawing.Point(167, 5)
        Me.lblTrainingBatch.Name = "lblTrainingBatch"
        Me.lblTrainingBatch.Size = New System.Drawing.Size(14, 15)
        Me.lblTrainingBatch.TabIndex = 3
        Me.lblTrainingBatch.Text = "x"
        Me.lblTrainingBatch.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "T R A I N I N G   B A T C H"
        '
        'Panel39
        '
        Me.Panel39.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel39.Location = New System.Drawing.Point(1164, 10)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(5, 156)
        Me.Panel39.TabIndex = 9
        '
        'Panel31
        '
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel31.Location = New System.Drawing.Point(10, 166)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(1159, 5)
        Me.Panel31.TabIndex = 8
        '
        'Panel25
        '
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel25.Location = New System.Drawing.Point(5, 10)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(5, 161)
        Me.Panel25.TabIndex = 7
        '
        'Panel23
        '
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(5, 5)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(1164, 5)
        Me.Panel23.TabIndex = 6
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.LightGray
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel20.Location = New System.Drawing.Point(1169, 5)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(5, 166)
        Me.Panel20.TabIndex = 4
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.LightGray
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel18.Location = New System.Drawing.Point(5, 171)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1169, 5)
        Me.Panel18.TabIndex = 3
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.LightGray
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel17.Location = New System.Drawing.Point(0, 5)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(5, 171)
        Me.Panel17.TabIndex = 2
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.LightGray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1174, 5)
        Me.Panel15.TabIndex = 1
        '
        'Panel26
        '
        Me.Panel26.Controls.Add(Me.Panel41)
        Me.Panel26.Controls.Add(Me.Panel33)
        Me.Panel26.Controls.Add(Me.Panel30)
        Me.Panel26.Controls.Add(Me.Panel29)
        Me.Panel26.Controls.Add(Me.Panel28)
        Me.Panel26.Controls.Add(Me.Panel27)
        Me.Panel26.Controls.Add(Me.Panel35)
        Me.Panel26.Controls.Add(Me.Panel36)
        Me.Panel26.Controls.Add(Me.Panel37)
        Me.Panel26.Controls.Add(Me.Panel38)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel26.Location = New System.Drawing.Point(0, 0)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(1174, 195)
        Me.Panel26.TabIndex = 0
        '
        'Panel41
        '
        Me.Panel41.Controls.Add(Me.dgvEnrolledEmployee)
        Me.Panel41.Controls.Add(Me.Panel45)
        Me.Panel41.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel41.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.Panel41.Location = New System.Drawing.Point(10, 34)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(1154, 151)
        Me.Panel41.TabIndex = 9
        '
        'dgvEnrolledEmployee
        '
        Me.dgvEnrolledEmployee.AllowUserToAddRows = False
        Me.dgvEnrolledEmployee.AllowUserToDeleteRows = False
        Me.dgvEnrolledEmployee.AllowUserToResizeColumns = False
        Me.dgvEnrolledEmployee.AllowUserToResizeRows = False
        Me.dgvEnrolledEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEnrolledEmployee.BackgroundColor = System.Drawing.Color.White
        Me.dgvEnrolledEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEnrolledEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvEnrolledEmployee.ColumnHeadersHeight = 35
        Me.dgvEnrolledEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEnrolledEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18})
        Me.dgvEnrolledEmployee.ContextMenuStrip = Me.ContextMenuStripTrainingEnrollees
        Me.dgvEnrolledEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEnrolledEmployee.Location = New System.Drawing.Point(0, 51)
        Me.dgvEnrolledEmployee.MultiSelect = False
        Me.dgvEnrolledEmployee.Name = "dgvEnrolledEmployee"
        Me.dgvEnrolledEmployee.ReadOnly = True
        Me.dgvEnrolledEmployee.RowHeadersVisible = False
        Me.dgvEnrolledEmployee.RowTemplate.Height = 30
        Me.dgvEnrolledEmployee.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEnrolledEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnrolledEmployee.Size = New System.Drawing.Size(1154, 100)
        Me.dgvEnrolledEmployee.TabIndex = 13
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'Column14
        '
        Me.Column14.FillWeight = 113.0288!
        Me.Column14.HeaderText = "Employee Name"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.FillWeight = 113.0288!
        Me.Column15.HeaderText = "Department"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column16
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column16.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column16.FillWeight = 60.9137!
        Me.Column16.HeaderText = "Result"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'Column17
        '
        Me.Column17.FillWeight = 113.0288!
        Me.Column17.HeaderText = "Remarks"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        '
        'Column18
        '
        Me.Column18.HeaderText = "EmployeeID"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Visible = False
        '
        'ContextMenuStripTrainingEnrollees
        '
        Me.ContextMenuStripTrainingEnrollees.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnrollEmployeesToolStripMenuItem, Me.UpdateTrainingResultToolStripMenuItem, Me.RemoveEmployeeToolStripMenuItem})
        Me.ContextMenuStripTrainingEnrollees.Name = "ContextMenuStripTrainingEnrollees"
        Me.ContextMenuStripTrainingEnrollees.Size = New System.Drawing.Size(193, 70)
        '
        'EnrollEmployeesToolStripMenuItem
        '
        Me.EnrollEmployeesToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_add_96
        Me.EnrollEmployeesToolStripMenuItem.Name = "EnrollEmployeesToolStripMenuItem"
        Me.EnrollEmployeesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.EnrollEmployeesToolStripMenuItem.Text = "Enroll Employee(s)"
        '
        'UpdateTrainingResultToolStripMenuItem
        '
        Me.UpdateTrainingResultToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.pen
        Me.UpdateTrainingResultToolStripMenuItem.Name = "UpdateTrainingResultToolStripMenuItem"
        Me.UpdateTrainingResultToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.UpdateTrainingResultToolStripMenuItem.Text = "Update Training Result"
        '
        'RemoveEmployeeToolStripMenuItem
        '
        Me.RemoveEmployeeToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_close_48
        Me.RemoveEmployeeToolStripMenuItem.Name = "RemoveEmployeeToolStripMenuItem"
        Me.RemoveEmployeeToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.RemoveEmployeeToolStripMenuItem.Text = "Remove Employee"
        '
        'Panel45
        '
        Me.Panel45.Controls.Add(Me.btnUpdateResult)
        Me.Panel45.Controls.Add(Me.Button1)
        Me.Panel45.Controls.Add(Me.Button2)
        Me.Panel45.Controls.Add(Me.Panel46)
        Me.Panel45.Controls.Add(Me.btnEnrollEmployee)
        Me.Panel45.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel45.Location = New System.Drawing.Point(0, 0)
        Me.Panel45.Name = "Panel45"
        Me.Panel45.Size = New System.Drawing.Size(1154, 51)
        Me.Panel45.TabIndex = 12
        '
        'btnUpdateResult
        '
        Me.btnUpdateResult.BackColor = System.Drawing.Color.White
        Me.btnUpdateResult.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnUpdateResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateResult.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateResult.ForeColor = System.Drawing.Color.Navy
        Me.btnUpdateResult.ImageIndex = 1
        Me.btnUpdateResult.ImageList = Me.ImageListBtn
        Me.btnUpdateResult.Location = New System.Drawing.Point(147, 6)
        Me.btnUpdateResult.Name = "btnUpdateResult"
        Me.btnUpdateResult.Size = New System.Drawing.Size(153, 38)
        Me.btnUpdateResult.TabIndex = 48
        Me.btnUpdateResult.Text = "  &Update Result"
        Me.btnUpdateResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateResult.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageListBtn
        Me.Button1.Location = New System.Drawing.Point(868, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 38)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "  &Export"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.ImageIndex = 4
        Me.Button2.ImageList = Me.ImageListBtn
        Me.Button2.Location = New System.Drawing.Point(1015, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 38)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "  &Print"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel46
        '
        Me.Panel46.BackColor = System.Drawing.Color.LightGray
        Me.Panel46.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel46.Location = New System.Drawing.Point(0, 49)
        Me.Panel46.Name = "Panel46"
        Me.Panel46.Size = New System.Drawing.Size(1154, 2)
        Me.Panel46.TabIndex = 10
        '
        'btnEnrollEmployee
        '
        Me.btnEnrollEmployee.BackColor = System.Drawing.Color.White
        Me.btnEnrollEmployee.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnEnrollEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnrollEmployee.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrollEmployee.ForeColor = System.Drawing.Color.Navy
        Me.btnEnrollEmployee.ImageIndex = 0
        Me.btnEnrollEmployee.ImageList = Me.ImageListBtn
        Me.btnEnrollEmployee.Location = New System.Drawing.Point(0, 6)
        Me.btnEnrollEmployee.Name = "btnEnrollEmployee"
        Me.btnEnrollEmployee.Size = New System.Drawing.Size(141, 38)
        Me.btnEnrollEmployee.TabIndex = 43
        Me.btnEnrollEmployee.Text = "  &Enroll Employee"
        Me.btnEnrollEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnrollEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnrollEmployee.UseVisualStyleBackColor = False
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.Navy
        Me.Panel33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel33.Controls.Add(Me.lblEmployeeName)
        Me.Panel33.Controls.Add(Me.Label5)
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel33.Location = New System.Drawing.Point(10, 10)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(1154, 24)
        Me.Panel33.TabIndex = 8
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.LightCoral
        Me.lblEmployeeName.Location = New System.Drawing.Point(206, 4)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(14, 15)
        Me.lblEmployeeName.TabIndex = 3
        Me.lblEmployeeName.Text = "x"
        Me.lblEmployeeName.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(5, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "E N R O L L E D   E M P L O Y E E S"
        '
        'Panel30
        '
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel30.Location = New System.Drawing.Point(10, 185)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(1154, 5)
        Me.Panel30.TabIndex = 7
        '
        'Panel29
        '
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel29.Location = New System.Drawing.Point(1164, 10)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(5, 180)
        Me.Panel29.TabIndex = 6
        '
        'Panel28
        '
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel28.Location = New System.Drawing.Point(10, 5)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(1159, 5)
        Me.Panel28.TabIndex = 5
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel27.Location = New System.Drawing.Point(5, 5)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(5, 185)
        Me.Panel27.TabIndex = 4
        '
        'Panel35
        '
        Me.Panel35.BackColor = System.Drawing.Color.LightGray
        Me.Panel35.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel35.Location = New System.Drawing.Point(1169, 5)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(5, 185)
        Me.Panel35.TabIndex = 3
        '
        'Panel36
        '
        Me.Panel36.BackColor = System.Drawing.Color.LightGray
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel36.Location = New System.Drawing.Point(5, 190)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(1169, 5)
        Me.Panel36.TabIndex = 2
        '
        'Panel37
        '
        Me.Panel37.BackColor = System.Drawing.Color.LightGray
        Me.Panel37.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel37.Location = New System.Drawing.Point(0, 5)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(5, 190)
        Me.Panel37.TabIndex = 1
        '
        'Panel38
        '
        Me.Panel38.BackColor = System.Drawing.Color.LightGray
        Me.Panel38.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel38.Location = New System.Drawing.Point(0, 0)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(1174, 5)
        Me.Panel38.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Navy
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(1187, 106)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(3, 559)
        Me.Panel9.TabIndex = 77
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Navy
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(13, 103)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1177, 3)
        Me.Panel7.TabIndex = 76
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Navy
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(10, 103)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(3, 562)
        Me.Panel10.TabIndex = 75
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.btnEdit)
        Me.Panel5.Controls.Add(Me.btnCreateNew)
        Me.Panel5.Controls.Add(Me.btnSearchFilter)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.txtboxSearch)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.Color.Navy
        Me.Panel5.Location = New System.Drawing.Point(10, 37)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1180, 66)
        Me.Panel5.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label3.Location = New System.Drawing.Point(1026, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 12)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Mode :"
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
        Me.btnEdit.Location = New System.Drawing.Point(171, 14)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(142, 39)
        Me.btnEdit.TabIndex = 46
        Me.btnEdit.Text = " &Edit Training"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
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
        Me.btnCreateNew.Size = New System.Drawing.Size(159, 39)
        Me.btnCreateNew.TabIndex = 45
        Me.btnCreateNew.Text = " &Add New Training"
        Me.btnCreateNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreateNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreateNew.UseVisualStyleBackColor = False
        '
        'btnSearchFilter
        '
        Me.btnSearchFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchFilter.BackColor = System.Drawing.Color.Navy
        Me.btnSearchFilter.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnSearchFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchFilter.ForeColor = System.Drawing.Color.White
        Me.btnSearchFilter.Location = New System.Drawing.Point(1028, 30)
        Me.btnSearchFilter.Name = "btnSearchFilter"
        Me.btnSearchFilter.Size = New System.Drawing.Size(137, 23)
        Me.btnSearchFilter.TabIndex = 44
        Me.btnSearchFilter.Text = "Training"
        Me.btnSearchFilter.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label2.Location = New System.Drawing.Point(796, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 12)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "You may search any value on the search bar."
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxSearch.Location = New System.Drawing.Point(780, 31)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(236, 22)
        Me.txtboxSearch.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(730, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Search "
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Navy
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(10, 665)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1180, 3)
        Me.Panel11.TabIndex = 73
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(10, 668)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1180, 10)
        Me.Panel6.TabIndex = 67
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1190, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 641)
        Me.Panel3.TabIndex = 64
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 37)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 641)
        Me.Panel4.TabIndex = 63
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 37)
        Me.Panel2.TabIndex = 19
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripBtnClose, Me.ToolStripButtonHelp, Me.ToolStripBtnRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1198, 35)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(462, 32)
        Me.ToolStripLabel1.Text = "Human Resources Module > Transaction > Training Management > Training Enrollment"
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
        'ToolStripBtnRefresh
        '
        Me.ToolStripBtnRefresh.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_refresh_96
        Me.ToolStripBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnRefresh.Name = "ToolStripBtnRefresh"
        Me.ToolStripBtnRefresh.Size = New System.Drawing.Size(66, 32)
        Me.ToolStripBtnRefresh.Text = "Refresh"
        '
        'frmHRIS_Transaction_TrainingEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 678)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHRIS_Transaction_TrainingEnrollment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Training Enrollment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.dgvTrainingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripTrainingList.ResumeLayout(False)
        Me.Panel42.ResumeLayout(False)
        Me.Panel42.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        CType(Me.dgvTrainingBatchList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripTrainingBatch.ResumeLayout(False)
        Me.Panel43.ResumeLayout(False)
        Me.Panel40.ResumeLayout(False)
        Me.Panel40.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel41.ResumeLayout(False)
        CType(Me.dgvEnrolledEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripTrainingEnrollees.ResumeLayout(False)
        Me.Panel45.ResumeLayout(False)
        Me.Panel33.ResumeLayout(False)
        Me.Panel33.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel41 As Panel
    Friend WithEvents Panel33 As Panel
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Panel36 As Panel
    Friend WithEvents Panel37 As Panel
    Friend WithEvents Panel38 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCreateNew As Button
    Friend WithEvents btnSearchFilter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel39 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel42 As Panel
    Friend WithEvents lblTrainingName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel40 As Panel
    Friend WithEvents lblTrainingBatch As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel43 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel44 As Panel
    Friend WithEvents btnAddNewBatch As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnEditBatch As Button
    Friend WithEvents Panel45 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel46 As Panel
    Friend WithEvents btnEnrollEmployee As Button
    Friend WithEvents ImageListBtn As ImageList
    Friend WithEvents dgvTrainingList As DataGridView
    Friend WithEvents dgvTrainingBatchList As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents dgvEnrolledEmployee As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents ShiftID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripBtnClose As ToolStripButton
    Friend WithEvents ToolStripButtonHelp As ToolStripButton
    Friend WithEvents ToolStripBtnRefresh As ToolStripButton
    Friend WithEvents ContextMenuStripTrainingList As ContextMenuStrip
    Friend WithEvents AddNewTrainingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteThisTrainingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripTrainingBatch As ContextMenuStrip
    Friend WithEvents AddNewBatchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteThisBatchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripTrainingEnrollees As ContextMenuStrip
    Friend WithEvents EnrollEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateTrainingResultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnUpdateResult As Button
End Class
