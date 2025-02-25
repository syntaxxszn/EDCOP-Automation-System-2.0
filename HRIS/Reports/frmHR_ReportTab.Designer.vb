<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHR_ReportTab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executive")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Officer")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Assistant")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Associate")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Driver")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Manager")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Officer")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Others")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Supervisor")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Assistant")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Associate")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CAD Assistant")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CAD Associate")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CAD Junior")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CAD Senior")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Executive")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Junior")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Officer")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Principal")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Senior")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Structural Engineer")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Technical", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Regular", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Assistant")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Driver")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Others")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Project Assistant ")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26, TreeNode27, TreeNode28})
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Assistant")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CAD Junior")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Technical", New System.Windows.Forms.TreeNode() {TreeNode30, TreeNode31})
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Project-Based", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode29, TreeNode32})
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Assistant")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Driver")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support Officer")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support", New System.Windows.Forms.TreeNode() {TreeNode34, TreeNode35, TreeNode36})
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Assistant")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Junior")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Technical", New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode39})
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Probationary", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode37, TreeNode40})
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode24, TreeNode33, TreeNode41})
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Active", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode42})
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("In Active")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee Status report", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode43, TreeNode44})
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Annual Salary per Department")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("New Hire per year by Employee Status")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Resignations per year and per department")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Separations (EOC,Resignation,Term) per year by Employee Status")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("No. of Employee per age Bracket")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("No. of Employee per position")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Out Patient benefits Utilization per Quarter / Year")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Out Patient benefits utilization per category ( Principal and dependents )")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tardiness")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("No / Late filing of Absences")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHR_ReportTab))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.RptImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.panelDGVLeft = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelDGVRight = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ToolStripBtnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1160, 37)
        Me.Panel1.TabIndex = 18
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripBtnNew, Me.ToolStripBtnRefresh, Me.ToolStripBtnClose, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1158, 35)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(238, 32)
        Me.ToolStripLabel1.Text = "Human Resources Management - Report tab"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 37)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1160, 35)
        Me.Panel5.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(13, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Report Management"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 72)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1160, 41)
        Me.Panel4.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Directory Path :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(113, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "---"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 113)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.panelDGVLeft)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.panelDGVRight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel6)
        Me.SplitContainer1.Size = New System.Drawing.Size(1160, 634)
        Me.SplitContainer1.SplitterDistance = 361
        Me.SplitContainer1.TabIndex = 58
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Segoe UI", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.RptImageList
        Me.TreeView1.Indent = 19
        Me.TreeView1.ItemHeight = 22
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node8"
        TreeNode1.Text = "Executive"
        TreeNode2.Name = "Node7"
        TreeNode2.Text = "Officer"
        TreeNode3.Name = "Node4"
        TreeNode3.Text = "Support Assistant"
        TreeNode4.Name = "Node5"
        TreeNode4.Text = "Support Associate"
        TreeNode5.Name = "Node6"
        TreeNode5.Text = "Support Driver"
        TreeNode6.Name = "Node7"
        TreeNode6.Text = "Support Manager"
        TreeNode7.Name = "Node8"
        TreeNode7.Text = "Support Officer"
        TreeNode8.Name = "Node9"
        TreeNode8.Text = "Support Others"
        TreeNode9.Name = "Node11"
        TreeNode9.Text = "Support Supervisor"
        TreeNode10.Name = "Node6"
        TreeNode10.Text = "Support"
        TreeNode11.Name = "Node8"
        TreeNode11.Text = "Assistant"
        TreeNode12.Name = "Node9"
        TreeNode12.Text = "Associate"
        TreeNode13.Name = "Node10"
        TreeNode13.Text = "CAD Assistant"
        TreeNode14.Name = "Node11"
        TreeNode14.Text = "CAD Associate"
        TreeNode15.Name = "Node12"
        TreeNode15.Text = "CAD Junior"
        TreeNode16.Name = "Node13"
        TreeNode16.Text = "CAD Senior"
        TreeNode17.Name = "Node14"
        TreeNode17.Text = "Executive"
        TreeNode18.Name = "Node15"
        TreeNode18.Text = "Junior"
        TreeNode19.Name = "Node16"
        TreeNode19.Text = "Officer"
        TreeNode20.Name = "Node17"
        TreeNode20.Text = "Principal"
        TreeNode21.Name = "Node18"
        TreeNode21.Text = "Senior"
        TreeNode22.Name = "Node19"
        TreeNode22.Text = "Structural Engineer"
        TreeNode23.Name = "Node7"
        TreeNode23.Text = "Technical"
        TreeNode24.ImageIndex = 1
        TreeNode24.Name = "Node2"
        TreeNode24.SelectedImageIndex = 1
        TreeNode24.Text = "Regular"
        TreeNode25.Name = "Node2"
        TreeNode25.Text = "Support Assistant"
        TreeNode26.Name = "Node4"
        TreeNode26.Text = "Support Driver"
        TreeNode27.Name = "Node5"
        TreeNode27.Text = "Support Others"
        TreeNode28.Name = "Node3"
        TreeNode28.Text = "Support Project Assistant "
        TreeNode29.Name = "Node0"
        TreeNode29.Text = "Support"
        TreeNode30.Name = "Node6"
        TreeNode30.Text = "Assistant"
        TreeNode31.Name = "Node7"
        TreeNode31.Text = "CAD Junior"
        TreeNode32.Name = "Node1"
        TreeNode32.Text = "Technical"
        TreeNode33.ImageIndex = 1
        TreeNode33.Name = "Node1"
        TreeNode33.SelectedImageIndex = 1
        TreeNode33.Text = "Project-Based"
        TreeNode34.Name = "Node11"
        TreeNode34.Text = "Support Assistant"
        TreeNode35.Name = "Node12"
        TreeNode35.Text = "Support Driver"
        TreeNode36.Name = "Node13"
        TreeNode36.Text = "Support Officer"
        TreeNode37.Name = "Node9"
        TreeNode37.Text = "Support"
        TreeNode38.Name = "Node14"
        TreeNode38.Text = "Assistant"
        TreeNode39.Name = "Node15"
        TreeNode39.Text = "Junior"
        TreeNode40.Name = "Node10"
        TreeNode40.Text = "Technical"
        TreeNode41.ImageIndex = 1
        TreeNode41.Name = "Node2"
        TreeNode41.SelectedImageIndex = 1
        TreeNode41.Text = "Probationary"
        TreeNode42.ImageIndex = 1
        TreeNode42.Name = "Node0"
        TreeNode42.SelectedImageIndex = 1
        TreeNode42.Text = "Employee"
        TreeNode43.ImageIndex = 1
        TreeNode43.Name = "Node0"
        TreeNode43.SelectedImageIndex = 1
        TreeNode43.Text = "Active"
        TreeNode44.Name = "Node1"
        TreeNode44.Text = "In Active"
        TreeNode45.ImageIndex = 1
        TreeNode45.Name = "Node0"
        TreeNode45.SelectedImageIndex = 1
        TreeNode45.Text = "Employee Status report"
        TreeNode46.Name = "Node2"
        TreeNode46.Text = "Annual Salary per Department"
        TreeNode47.Name = "Node3"
        TreeNode47.Text = "New Hire per year by Employee Status"
        TreeNode48.Name = "Node4"
        TreeNode48.Text = "Resignations per year and per department"
        TreeNode49.Name = "Node5"
        TreeNode49.Text = "Separations (EOC,Resignation,Term) per year by Employee Status"
        TreeNode50.Name = "Node6"
        TreeNode50.Text = "No. of Employee per age Bracket"
        TreeNode51.Name = "Node7"
        TreeNode51.Text = "No. of Employee per position"
        TreeNode52.Name = "Node8"
        TreeNode52.Text = "Out Patient benefits Utilization per Quarter / Year"
        TreeNode53.Name = "Node9"
        TreeNode53.Text = "Out Patient benefits utilization per category ( Principal and dependents )"
        TreeNode54.Name = "Node10"
        TreeNode54.Text = "Tardiness"
        TreeNode55.Name = "Node11"
        TreeNode55.Text = "No / Late filing of Absences"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode45, TreeNode46, TreeNode47, TreeNode48, TreeNode49, TreeNode50, TreeNode51, TreeNode52, TreeNode53, TreeNode54, TreeNode55})
        Me.TreeView1.PathSeparator = " \ "
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(361, 634)
        Me.TreeView1.TabIndex = 0
        '
        'RptImageList
        '
        Me.RptImageList.ImageStream = CType(resources.GetObject("RptImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.RptImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.RptImageList.Images.SetKeyName(0, "seo-report.png")
        Me.RptImageList.Images.SetKeyName(1, "folder.png")
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(2, 2)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(779, 618)
        Me.CrystalReportViewer1.TabIndex = 68
        '
        'panelDGVLeft
        '
        Me.panelDGVLeft.BackColor = System.Drawing.Color.DarkGray
        Me.panelDGVLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelDGVLeft.Location = New System.Drawing.Point(0, 2)
        Me.panelDGVLeft.Name = "panelDGVLeft"
        Me.panelDGVLeft.Size = New System.Drawing.Size(2, 618)
        Me.panelDGVLeft.TabIndex = 67
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 620)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 2)
        Me.Panel2.TabIndex = 66
        '
        'panelDGVRight
        '
        Me.panelDGVRight.BackColor = System.Drawing.Color.DarkGray
        Me.panelDGVRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelDGVRight.Location = New System.Drawing.Point(781, 2)
        Me.panelDGVRight.Name = "panelDGVRight"
        Me.panelDGVRight.Size = New System.Drawing.Size(2, 620)
        Me.panelDGVRight.TabIndex = 65
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 622)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(783, 12)
        Me.Panel8.TabIndex = 64
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(783, 2)
        Me.Panel3.TabIndex = 62
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(783, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(12, 634)
        Me.Panel6.TabIndex = 51
        '
        'ToolStripBtnNew
        '
        Me.ToolStripBtnNew.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_add_96
        Me.ToolStripBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnNew.Name = "ToolStripBtnNew"
        Me.ToolStripBtnNew.Size = New System.Drawing.Size(104, 32)
        Me.ToolStripBtnNew.Text = "New Personnel"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.question
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(51, 32)
        Me.ToolStripButton1.Text = "Help"
        '
        'frmHR_ReportTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1160, 747)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHR_ReportTab"
        Me.Text = "frmHR_ReportTab"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripBtnNew As ToolStripButton
    Friend WithEvents ToolStripBtnRefresh As ToolStripButton
    Friend WithEvents ToolStripBtnClose As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents panelDGVRight As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelDGVLeft As Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RptImageList As ImageList
End Class
