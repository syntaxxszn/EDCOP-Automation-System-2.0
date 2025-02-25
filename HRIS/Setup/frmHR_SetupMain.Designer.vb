<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHR_SetupMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHR_SetupMain))
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripBtnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnApprovedHierarchy = New System.Windows.Forms.Button()
        Me.btnLeaveCredit = New System.Windows.Forms.Button()
        Me.btnJobTitle = New System.Windows.Forms.Button()
        Me.btnLeaveType = New System.Windows.Forms.Button()
        Me.btnCompany = New System.Windows.Forms.Button()
        Me.btnDepartment = New System.Windows.Forms.Button()
        Me.btnShift = New System.Windows.Forms.Button()
        Me.ImageListMainButton = New System.Windows.Forms.ImageList(Me.components)
        Me.panelOpenForm = New System.Windows.Forms.Panel()
        Me.Panel8.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.ToolStrip1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1162, 37)
        Me.Panel8.TabIndex = 40
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripBtnClose, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1160, 35)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(217, 32)
        Me.ToolStripLabel1.Text = "Human Resources Management > Setup"
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 37)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1162, 35)
        Me.Panel5.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "- Setup tab -"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.btnApprovedHierarchy)
        Me.Panel4.Controls.Add(Me.btnLeaveCredit)
        Me.Panel4.Controls.Add(Me.btnJobTitle)
        Me.Panel4.Controls.Add(Me.btnLeaveType)
        Me.Panel4.Controls.Add(Me.btnCompany)
        Me.Panel4.Controls.Add(Me.btnDepartment)
        Me.Panel4.Controls.Add(Me.btnShift)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 72)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1162, 66)
        Me.Panel4.TabIndex = 42
        '
        'btnApprovedHierarchy
        '
        Me.btnApprovedHierarchy.BackColor = System.Drawing.Color.White
        Me.btnApprovedHierarchy.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnApprovedHierarchy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprovedHierarchy.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprovedHierarchy.ForeColor = System.Drawing.Color.Black
        Me.btnApprovedHierarchy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApprovedHierarchy.ImageIndex = 3
        Me.btnApprovedHierarchy.ImageList = Me.ImageListMainButton
        Me.btnApprovedHierarchy.Location = New System.Drawing.Point(500, 13)
        Me.btnApprovedHierarchy.Name = "btnApprovedHierarchy"
        Me.btnApprovedHierarchy.Size = New System.Drawing.Size(161, 38)
        Me.btnApprovedHierarchy.TabIndex = 49
        Me.btnApprovedHierarchy.Text = "   &Approved Hierarchy"
        Me.btnApprovedHierarchy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApprovedHierarchy.UseVisualStyleBackColor = False
        '
        'btnLeaveCredit
        '
        Me.btnLeaveCredit.BackColor = System.Drawing.Color.White
        Me.btnLeaveCredit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLeaveCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeaveCredit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeaveCredit.ForeColor = System.Drawing.Color.Black
        Me.btnLeaveCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLeaveCredit.ImageIndex = 7
        Me.btnLeaveCredit.ImageList = Me.ImageListMainButton
        Me.btnLeaveCredit.Location = New System.Drawing.Point(989, 13)
        Me.btnLeaveCredit.Name = "btnLeaveCredit"
        Me.btnLeaveCredit.Size = New System.Drawing.Size(155, 38)
        Me.btnLeaveCredit.TabIndex = 48
        Me.btnLeaveCredit.Text = "   &Leave Credit"
        Me.btnLeaveCredit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLeaveCredit.UseVisualStyleBackColor = False
        '
        'btnJobTitle
        '
        Me.btnJobTitle.BackColor = System.Drawing.Color.White
        Me.btnJobTitle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnJobTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJobTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJobTitle.ForeColor = System.Drawing.Color.Black
        Me.btnJobTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJobTitle.ImageIndex = 2
        Me.btnJobTitle.ImageList = Me.ImageListMainButton
        Me.btnJobTitle.Location = New System.Drawing.Point(339, 13)
        Me.btnJobTitle.Name = "btnJobTitle"
        Me.btnJobTitle.Size = New System.Drawing.Size(155, 38)
        Me.btnJobTitle.TabIndex = 47
        Me.btnJobTitle.Text = "   &Job title"
        Me.btnJobTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnJobTitle.UseVisualStyleBackColor = False
        '
        'btnLeaveType
        '
        Me.btnLeaveType.BackColor = System.Drawing.Color.White
        Me.btnLeaveType.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLeaveType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeaveType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeaveType.ForeColor = System.Drawing.Color.Black
        Me.btnLeaveType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLeaveType.ImageIndex = 6
        Me.btnLeaveType.ImageList = Me.ImageListMainButton
        Me.btnLeaveType.Location = New System.Drawing.Point(828, 13)
        Me.btnLeaveType.Name = "btnLeaveType"
        Me.btnLeaveType.Size = New System.Drawing.Size(155, 38)
        Me.btnLeaveType.TabIndex = 46
        Me.btnLeaveType.Text = "   &Leave Type"
        Me.btnLeaveType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLeaveType.UseVisualStyleBackColor = False
        '
        'btnCompany
        '
        Me.btnCompany.BackColor = System.Drawing.Color.White
        Me.btnCompany.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompany.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompany.ForeColor = System.Drawing.Color.Black
        Me.btnCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompany.ImageIndex = 0
        Me.btnCompany.ImageList = Me.ImageListMainButton
        Me.btnCompany.Location = New System.Drawing.Point(17, 13)
        Me.btnCompany.Name = "btnCompany"
        Me.btnCompany.Size = New System.Drawing.Size(155, 38)
        Me.btnCompany.TabIndex = 43
        Me.btnCompany.Text = "   &Company"
        Me.btnCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompany.UseVisualStyleBackColor = False
        '
        'btnDepartment
        '
        Me.btnDepartment.BackColor = System.Drawing.Color.White
        Me.btnDepartment.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepartment.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepartment.ForeColor = System.Drawing.Color.Black
        Me.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepartment.ImageIndex = 1
        Me.btnDepartment.ImageList = Me.ImageListMainButton
        Me.btnDepartment.Location = New System.Drawing.Point(178, 13)
        Me.btnDepartment.Name = "btnDepartment"
        Me.btnDepartment.Size = New System.Drawing.Size(155, 38)
        Me.btnDepartment.TabIndex = 45
        Me.btnDepartment.Text = "   &Department"
        Me.btnDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDepartment.UseVisualStyleBackColor = False
        '
        'btnShift
        '
        Me.btnShift.BackColor = System.Drawing.Color.White
        Me.btnShift.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShift.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShift.ForeColor = System.Drawing.Color.Black
        Me.btnShift.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShift.ImageIndex = 5
        Me.btnShift.ImageList = Me.ImageListMainButton
        Me.btnShift.Location = New System.Drawing.Point(667, 13)
        Me.btnShift.Name = "btnShift"
        Me.btnShift.Size = New System.Drawing.Size(155, 38)
        Me.btnShift.TabIndex = 44
        Me.btnShift.Text = "   &Shift"
        Me.btnShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShift.UseVisualStyleBackColor = False
        '
        'ImageListMainButton
        '
        Me.ImageListMainButton.ImageStream = CType(resources.GetObject("ImageListMainButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListMainButton.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListMainButton.Images.SetKeyName(0, "Company.png")
        Me.ImageListMainButton.Images.SetKeyName(1, "Department.png")
        Me.ImageListMainButton.Images.SetKeyName(2, "Job Title.png")
        Me.ImageListMainButton.Images.SetKeyName(3, "Approved_Hierarchy.png")
        Me.ImageListMainButton.Images.SetKeyName(4, "Approved_Hierarchy.png")
        Me.ImageListMainButton.Images.SetKeyName(5, "Shift.png")
        Me.ImageListMainButton.Images.SetKeyName(6, "leave_Type.png")
        Me.ImageListMainButton.Images.SetKeyName(7, "leave_Credit.png")
        '
        'panelOpenForm
        '
        Me.panelOpenForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelOpenForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelOpenForm.Location = New System.Drawing.Point(0, 138)
        Me.panelOpenForm.Name = "panelOpenForm"
        Me.panelOpenForm.Size = New System.Drawing.Size(1162, 527)
        Me.panelOpenForm.TabIndex = 47
        '
        'frmHR_SetupMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1162, 665)
        Me.Controls.Add(Me.panelOpenForm)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel8)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHR_SetupMain"
        Me.Text = "frmHR_SetupMain"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel8 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripBtnClose As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnApprovedHierarchy As Button
    Friend WithEvents btnLeaveCredit As Button
    Friend WithEvents btnJobTitle As Button
    Friend WithEvents btnLeaveType As Button
    Friend WithEvents btnCompany As Button
    Friend WithEvents btnDepartment As Button
    Friend WithEvents btnShift As Button
    Friend WithEvents ImageListMainButton As ImageList
    Friend WithEvents panelOpenForm As Panel
End Class
