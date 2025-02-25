<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainPanelPMMDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPanelPMMDetail))
        Me.panelSubHRIS_PurchaseJournal = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLeaveType = New System.Windows.Forms.Button()
        Me.btnShift = New System.Windows.Forms.Button()
        Me.btnApprovalHierarchy = New System.Windows.Forms.Button()
        Me.btnJobtitle = New System.Windows.Forms.Button()
        Me.btnPurchaseRequisition = New System.Windows.Forms.Button()
        Me.btnCashAdvance = New System.Windows.Forms.Button()
        Me.panelSubHRIS_PurchaseJournal.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSubHRIS_PurchaseJournal
        '
        Me.panelSubHRIS_PurchaseJournal.Controls.Add(Me.btnLeaveType)
        Me.panelSubHRIS_PurchaseJournal.Controls.Add(Me.btnShift)
        Me.panelSubHRIS_PurchaseJournal.Controls.Add(Me.btnApprovalHierarchy)
        Me.panelSubHRIS_PurchaseJournal.Controls.Add(Me.btnJobtitle)
        Me.panelSubHRIS_PurchaseJournal.Controls.Add(Me.btnPurchaseRequisition)
        Me.panelSubHRIS_PurchaseJournal.Controls.Add(Me.btnCashAdvance)
        Me.panelSubHRIS_PurchaseJournal.Controls.Add(Me.Panel13)
        Me.panelSubHRIS_PurchaseJournal.Location = New System.Drawing.Point(12, 12)
        Me.panelSubHRIS_PurchaseJournal.Name = "panelSubHRIS_PurchaseJournal"
        Me.panelSubHRIS_PurchaseJournal.Size = New System.Drawing.Size(282, 270)
        Me.panelSubHRIS_PurchaseJournal.TabIndex = 5
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "money.png")
        Me.ImageList1.Images.SetKeyName(1, "requisition.png")
        Me.ImageList1.Images.SetKeyName(2, "cart.png")
        Me.ImageList1.Images.SetKeyName(3, "delivery.png")
        Me.ImageList1.Images.SetKeyName(4, "inventory.png")
        Me.ImageList1.Images.SetKeyName(5, "deliveryreceipt.png")
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Label2)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(282, 34)
        Me.Panel13.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(16, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PMM > Purchase Journal"
        '
        'btnLeaveType
        '
        Me.btnLeaveType.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLeaveType.FlatAppearance.BorderSize = 0
        Me.btnLeaveType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeaveType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLeaveType.ImageIndex = 5
        Me.btnLeaveType.ImageList = Me.ImageList1
        Me.btnLeaveType.Location = New System.Drawing.Point(0, 224)
        Me.btnLeaveType.Name = "btnLeaveType"
        Me.btnLeaveType.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLeaveType.Size = New System.Drawing.Size(282, 38)
        Me.btnLeaveType.TabIndex = 9
        Me.btnLeaveType.Text = "   Receiving Report"
        Me.btnLeaveType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLeaveType.UseVisualStyleBackColor = True
        '
        'btnShift
        '
        Me.btnShift.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnShift.FlatAppearance.BorderSize = 0
        Me.btnShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShift.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShift.ImageIndex = 4
        Me.btnShift.ImageList = Me.ImageList1
        Me.btnShift.Location = New System.Drawing.Point(0, 186)
        Me.btnShift.Name = "btnShift"
        Me.btnShift.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnShift.Size = New System.Drawing.Size(282, 38)
        Me.btnShift.TabIndex = 8
        Me.btnShift.Text = "   Inventory"
        Me.btnShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShift.UseVisualStyleBackColor = True
        '
        'btnApprovalHierarchy
        '
        Me.btnApprovalHierarchy.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnApprovalHierarchy.FlatAppearance.BorderSize = 0
        Me.btnApprovalHierarchy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprovalHierarchy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApprovalHierarchy.ImageIndex = 3
        Me.btnApprovalHierarchy.ImageList = Me.ImageList1
        Me.btnApprovalHierarchy.Location = New System.Drawing.Point(0, 148)
        Me.btnApprovalHierarchy.Name = "btnApprovalHierarchy"
        Me.btnApprovalHierarchy.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnApprovalHierarchy.Size = New System.Drawing.Size(282, 38)
        Me.btnApprovalHierarchy.TabIndex = 7
        Me.btnApprovalHierarchy.Text = "   Delivery Receipt"
        Me.btnApprovalHierarchy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApprovalHierarchy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApprovalHierarchy.UseVisualStyleBackColor = True
        '
        'btnJobtitle
        '
        Me.btnJobtitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnJobtitle.FlatAppearance.BorderSize = 0
        Me.btnJobtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJobtitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJobtitle.ImageIndex = 2
        Me.btnJobtitle.ImageList = Me.ImageList1
        Me.btnJobtitle.Location = New System.Drawing.Point(0, 110)
        Me.btnJobtitle.Name = "btnJobtitle"
        Me.btnJobtitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnJobtitle.Size = New System.Drawing.Size(282, 38)
        Me.btnJobtitle.TabIndex = 6
        Me.btnJobtitle.Text = "   Purchase Order"
        Me.btnJobtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJobtitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnJobtitle.UseVisualStyleBackColor = True
        '
        'btnPurchaseRequisition
        '
        Me.btnPurchaseRequisition.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPurchaseRequisition.FlatAppearance.BorderSize = 0
        Me.btnPurchaseRequisition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurchaseRequisition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchaseRequisition.ImageIndex = 1
        Me.btnPurchaseRequisition.ImageList = Me.ImageList1
        Me.btnPurchaseRequisition.Location = New System.Drawing.Point(0, 72)
        Me.btnPurchaseRequisition.Name = "btnPurchaseRequisition"
        Me.btnPurchaseRequisition.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnPurchaseRequisition.Size = New System.Drawing.Size(282, 38)
        Me.btnPurchaseRequisition.TabIndex = 5
        Me.btnPurchaseRequisition.Text = "   Purchase Requisition"
        Me.btnPurchaseRequisition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPurchaseRequisition.UseVisualStyleBackColor = True
        '
        'btnCashAdvance
        '
        Me.btnCashAdvance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCashAdvance.FlatAppearance.BorderSize = 0
        Me.btnCashAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCashAdvance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashAdvance.ImageIndex = 0
        Me.btnCashAdvance.ImageList = Me.ImageList1
        Me.btnCashAdvance.Location = New System.Drawing.Point(0, 34)
        Me.btnCashAdvance.Name = "btnCashAdvance"
        Me.btnCashAdvance.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCashAdvance.Size = New System.Drawing.Size(282, 38)
        Me.btnCashAdvance.TabIndex = 4
        Me.btnCashAdvance.Text = "   Cash Advance"
        Me.btnCashAdvance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCashAdvance.UseVisualStyleBackColor = True
        '
        'frmMainPanelPMMDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 294)
        Me.Controls.Add(Me.panelSubHRIS_PurchaseJournal)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainPanelPMMDetail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmMainPanelPMMDetail"
        Me.panelSubHRIS_PurchaseJournal.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSubHRIS_PurchaseJournal As Panel
    Friend WithEvents btnLeaveType As Button
    Friend WithEvents btnShift As Button
    Friend WithEvents btnApprovalHierarchy As Button
    Friend WithEvents btnJobtitle As Button
    Friend WithEvents btnPurchaseRequisition As Button
    Friend WithEvents btnCashAdvance As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
