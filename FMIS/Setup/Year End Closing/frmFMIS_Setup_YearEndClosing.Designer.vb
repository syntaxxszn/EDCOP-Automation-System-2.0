<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFMIS_Setup_YearEndClosing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFMIS_Setup_YearEndClosing))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.ImageListBtn = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCreateNew = New System.Windows.Forms.Button()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.toolstriplabelNoOfRecord = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.lblHeader = New System.Windows.Forms.ToolStripLabel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.dgvYearEndDate = New System.Windows.Forms.DataGridView()
        Me.AccountCategoryMainID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvYearEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 29
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripBtnRefresh, Me.ToolStripLabel7, Me.ToolStripBtnClose, Me.ToolStripButtonHelp})
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(309, 32)
        Me.ToolStripLabel1.Text = "Finance Management Module > Setup > Year End Closing"
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
        Me.Panel2.Size = New System.Drawing.Size(10, 566)
        Me.Panel2.TabIndex = 86
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1066, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 566)
        Me.Panel3.TabIndex = 91
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(10, 593)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1056, 10)
        Me.Panel6.TabIndex = 95
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
        Me.Panel4.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label1.Location = New System.Drawing.Point(900, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 12)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Mode :"
        '
        'btnSearchFilter
        '
        Me.btnSearchFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchFilter.BackColor = System.Drawing.Color.Navy
        Me.btnSearchFilter.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnSearchFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchFilter.ForeColor = System.Drawing.Color.White
        Me.btnSearchFilter.Location = New System.Drawing.Point(902, 28)
        Me.btnSearchFilter.Name = "btnSearchFilter"
        Me.btnSearchFilter.Size = New System.Drawing.Size(137, 23)
        Me.btnSearchFilter.TabIndex = 52
        Me.btnSearchFilter.Text = "Date"
        Me.btnSearchFilter.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label2.Location = New System.Drawing.Point(664, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 12)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "You may search any code on the search bar."
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
        Me.Label4.Location = New System.Drawing.Point(598, 33)
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
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripLabel2, Me.toolstriplabelNoOfRecord, Me.ToolStripLabel4, Me.lblHeader})
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
        Me.ToolStripLabel3.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripLabel3.Text = "Y E A R   E N D   C L O S I N G"
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
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Gold
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(10, 22)
        Me.lblHeader.Text = " "
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Navy
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(10, 130)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1056, 3)
        Me.Panel8.TabIndex = 97
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Navy
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(10, 133)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(3, 460)
        Me.Panel10.TabIndex = 98
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Navy
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(1063, 133)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(3, 460)
        Me.Panel9.TabIndex = 99
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Navy
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(13, 590)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1050, 3)
        Me.Panel7.TabIndex = 100
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.LightGray
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel25.Location = New System.Drawing.Point(13, 133)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(1050, 5)
        Me.Panel25.TabIndex = 101
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.LightGray
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(13, 138)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(5, 452)
        Me.Panel24.TabIndex = 102
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.LightGray
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel21.Location = New System.Drawing.Point(18, 585)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(1045, 5)
        Me.Panel21.TabIndex = 103
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.LightGray
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel20.Location = New System.Drawing.Point(1058, 138)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(5, 447)
        Me.Panel20.TabIndex = 104
        '
        'dgvYearEndDate
        '
        Me.dgvYearEndDate.AllowUserToAddRows = False
        Me.dgvYearEndDate.AllowUserToDeleteRows = False
        Me.dgvYearEndDate.AllowUserToResizeColumns = False
        Me.dgvYearEndDate.AllowUserToResizeRows = False
        Me.dgvYearEndDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvYearEndDate.BackgroundColor = System.Drawing.Color.White
        Me.dgvYearEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvYearEndDate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvYearEndDate.ColumnHeadersHeight = 35
        Me.dgvYearEndDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvYearEndDate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountCategoryMainID, Me.Column1})
        Me.dgvYearEndDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvYearEndDate.Location = New System.Drawing.Point(18, 138)
        Me.dgvYearEndDate.MultiSelect = False
        Me.dgvYearEndDate.Name = "dgvYearEndDate"
        Me.dgvYearEndDate.ReadOnly = True
        Me.dgvYearEndDate.RowHeadersVisible = False
        Me.dgvYearEndDate.RowTemplate.Height = 30
        Me.dgvYearEndDate.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvYearEndDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvYearEndDate.Size = New System.Drawing.Size(1040, 447)
        Me.dgvYearEndDate.TabIndex = 108
        '
        'AccountCategoryMainID
        '
        Me.AccountCategoryMainID.HeaderText = "ID"
        Me.AccountCategoryMainID.Name = "AccountCategoryMainID"
        Me.AccountCategoryMainID.ReadOnly = True
        Me.AccountCategoryMainID.Visible = False
        Me.AccountCategoryMainID.Width = 43
        '
        'Column1
        '
        Me.Column1.HeaderText = "Closing Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 90
        '
        'frmFMIS_Setup_YearEndClosing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 603)
        Me.Controls.Add(Me.dgvYearEndDate)
        Me.Controls.Add(Me.Panel20)
        Me.Controls.Add(Me.Panel21)
        Me.Controls.Add(Me.Panel24)
        Me.Controls.Add(Me.Panel25)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel9)
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
        Me.Name = "frmFMIS_Setup_YearEndClosing"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmFMIS_Setup_YearEndClosing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvYearEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripBtnRefresh As ToolStripButton
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripBtnClose As ToolStripButton
    Friend WithEvents ToolStripButtonHelp As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
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
    Friend WithEvents lblHeader As ToolStripLabel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents dgvYearEndDate As DataGridView
    Friend WithEvents AccountCategoryMainID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ImageListBtn As ImageList
End Class
