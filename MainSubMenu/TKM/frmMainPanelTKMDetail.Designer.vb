<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainPanelTKMDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPanelTKMDetail))
        Me.panelSubTKM_TransactionDetails = New System.Windows.Forms.Panel()
        Me.btnLeavePTO = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPerformanceManagement = New System.Windows.Forms.Button()
        Me.btnBenefitAdmin = New System.Windows.Forms.Button()
        Me.btnTrainingManagement = New System.Windows.Forms.Button()
        Me.btnSchedManagement = New System.Windows.Forms.Button()
        Me.btnHumanResource = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelSubTKM_TransactionDetails.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSubTKM_TransactionDetails
        '
        Me.panelSubTKM_TransactionDetails.Controls.Add(Me.btnLeavePTO)
        Me.panelSubTKM_TransactionDetails.Controls.Add(Me.Button2)
        Me.panelSubTKM_TransactionDetails.Controls.Add(Me.Button1)
        Me.panelSubTKM_TransactionDetails.Controls.Add(Me.btnPerformanceManagement)
        Me.panelSubTKM_TransactionDetails.Controls.Add(Me.btnBenefitAdmin)
        Me.panelSubTKM_TransactionDetails.Controls.Add(Me.btnTrainingManagement)
        Me.panelSubTKM_TransactionDetails.Controls.Add(Me.btnSchedManagement)
        Me.panelSubTKM_TransactionDetails.Controls.Add(Me.btnHumanResource)
        Me.panelSubTKM_TransactionDetails.Controls.Add(Me.Panel12)
        Me.panelSubTKM_TransactionDetails.Location = New System.Drawing.Point(12, 12)
        Me.panelSubTKM_TransactionDetails.Name = "panelSubTKM_TransactionDetails"
        Me.panelSubTKM_TransactionDetails.Size = New System.Drawing.Size(282, 322)
        Me.panelSubTKM_TransactionDetails.TabIndex = 6
        '
        'btnLeavePTO
        '
        Me.btnLeavePTO.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLeavePTO.FlatAppearance.BorderSize = 0
        Me.btnLeavePTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeavePTO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLeavePTO.ImageIndex = 2
        Me.btnLeavePTO.ImageList = Me.ImageList1
        Me.btnLeavePTO.Location = New System.Drawing.Point(0, 279)
        Me.btnLeavePTO.Name = "btnLeavePTO"
        Me.btnLeavePTO.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLeavePTO.Size = New System.Drawing.Size(282, 35)
        Me.btnLeavePTO.TabIndex = 18
        Me.btnLeavePTO.Text = "   Leave / PTO"
        Me.btnLeavePTO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLeavePTO.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "timesheetcorrection.png")
        Me.ImageList1.Images.SetKeyName(1, "timesheetentry.png")
        Me.ImageList1.Images.SetKeyName(2, "timesheetleave.png")
        Me.ImageList1.Images.SetKeyName(3, "timesheetmanual.png")
        Me.ImageList1.Images.SetKeyName(4, "timesheetmonitoring.png")
        Me.ImageList1.Images.SetKeyName(5, "timesheetpreparation.png")
        Me.ImageList1.Images.SetKeyName(6, "timesheettagging.png")
        Me.ImageList1.Images.SetKeyName(7, "timesheettransaction.png")
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 7
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(0, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(282, 35)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "   ManMonth Used Per Period Transaction"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(0, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(282, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "   ManMonth Balance Correction Module"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPerformanceManagement
        '
        Me.btnPerformanceManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPerformanceManagement.FlatAppearance.BorderSize = 0
        Me.btnPerformanceManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerformanceManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerformanceManagement.ImageIndex = 4
        Me.btnPerformanceManagement.ImageList = Me.ImageList1
        Me.btnPerformanceManagement.Location = New System.Drawing.Point(0, 174)
        Me.btnPerformanceManagement.Name = "btnPerformanceManagement"
        Me.btnPerformanceManagement.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnPerformanceManagement.Size = New System.Drawing.Size(282, 35)
        Me.btnPerformanceManagement.TabIndex = 15
        Me.btnPerformanceManagement.Text = "   Time Sheet Monitoring"
        Me.btnPerformanceManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPerformanceManagement.UseVisualStyleBackColor = True
        '
        'btnBenefitAdmin
        '
        Me.btnBenefitAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBenefitAdmin.FlatAppearance.BorderSize = 0
        Me.btnBenefitAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBenefitAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBenefitAdmin.ImageIndex = 1
        Me.btnBenefitAdmin.ImageList = Me.ImageList1
        Me.btnBenefitAdmin.Location = New System.Drawing.Point(0, 139)
        Me.btnBenefitAdmin.Name = "btnBenefitAdmin"
        Me.btnBenefitAdmin.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBenefitAdmin.Size = New System.Drawing.Size(282, 35)
        Me.btnBenefitAdmin.TabIndex = 14
        Me.btnBenefitAdmin.Text = "   Manual Timekeeping"
        Me.btnBenefitAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBenefitAdmin.UseVisualStyleBackColor = True
        '
        'btnTrainingManagement
        '
        Me.btnTrainingManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTrainingManagement.FlatAppearance.BorderSize = 0
        Me.btnTrainingManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrainingManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrainingManagement.ImageIndex = 3
        Me.btnTrainingManagement.ImageList = Me.ImageList1
        Me.btnTrainingManagement.Location = New System.Drawing.Point(0, 104)
        Me.btnTrainingManagement.Name = "btnTrainingManagement"
        Me.btnTrainingManagement.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnTrainingManagement.Size = New System.Drawing.Size(282, 35)
        Me.btnTrainingManagement.TabIndex = 13
        Me.btnTrainingManagement.Text = "   Manual Tagging"
        Me.btnTrainingManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTrainingManagement.UseVisualStyleBackColor = True
        '
        'btnSchedManagement
        '
        Me.btnSchedManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSchedManagement.FlatAppearance.BorderSize = 0
        Me.btnSchedManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchedManagement.ImageIndex = 6
        Me.btnSchedManagement.ImageList = Me.ImageList1
        Me.btnSchedManagement.Location = New System.Drawing.Point(0, 69)
        Me.btnSchedManagement.Name = "btnSchedManagement"
        Me.btnSchedManagement.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSchedManagement.Size = New System.Drawing.Size(282, 35)
        Me.btnSchedManagement.TabIndex = 12
        Me.btnSchedManagement.Text = "   Time Sheet Manual Entry"
        Me.btnSchedManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSchedManagement.UseVisualStyleBackColor = True
        '
        'btnHumanResource
        '
        Me.btnHumanResource.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHumanResource.FlatAppearance.BorderSize = 0
        Me.btnHumanResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHumanResource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHumanResource.ImageIndex = 5
        Me.btnHumanResource.ImageList = Me.ImageList1
        Me.btnHumanResource.Location = New System.Drawing.Point(0, 34)
        Me.btnHumanResource.Name = "btnHumanResource"
        Me.btnHumanResource.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHumanResource.Size = New System.Drawing.Size(282, 35)
        Me.btnHumanResource.TabIndex = 11
        Me.btnHumanResource.Text = "   Time Sheet Preparation"
        Me.btnHumanResource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHumanResource.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Label1)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(282, 34)
        Me.Panel12.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Timekeeping > Transaction"
        '
        'frmMainPanelTKMDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 640)
        Me.Controls.Add(Me.panelSubTKM_TransactionDetails)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainPanelTKMDetail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmMainPanelTKMDetail"
        Me.panelSubTKM_TransactionDetails.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSubTKM_TransactionDetails As Panel
    Friend WithEvents btnLeavePTO As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPerformanceManagement As Button
    Friend WithEvents btnBenefitAdmin As Button
    Friend WithEvents btnTrainingManagement As Button
    Friend WithEvents btnSchedManagement As Button
    Friend WithEvents btnHumanResource As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
