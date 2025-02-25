<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashDisbursementSubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashDisbursementSubMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSummaryByProject = New System.Windows.Forms.Button()
        Me.btnSummaryByAccount = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSummaryByBank = New System.Windows.Forms.Button()
        Me.btnSummaryByDateRange = New System.Windows.Forms.Button()
        Me.btnBatchPrinting = New System.Windows.Forms.Button()
        Me.btnCheckVoucher = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnSummaryByProject)
        Me.Panel1.Controls.Add(Me.btnSummaryByAccount)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnSummaryByBank)
        Me.Panel1.Controls.Add(Me.btnSummaryByDateRange)
        Me.Panel1.Controls.Add(Me.btnBatchPrinting)
        Me.Panel1.Controls.Add(Me.btnCheckVoucher)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 282)
        Me.Panel1.TabIndex = 2
        '
        'btnSummaryByProject
        '
        Me.btnSummaryByProject.BackColor = System.Drawing.Color.White
        Me.btnSummaryByProject.Enabled = False
        Me.btnSummaryByProject.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSummaryByProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummaryByProject.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummaryByProject.ForeColor = System.Drawing.Color.Black
        Me.btnSummaryByProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByProject.ImageIndex = 5
        Me.btnSummaryByProject.ImageList = Me.ImageList1
        Me.btnSummaryByProject.Location = New System.Drawing.Point(12, 232)
        Me.btnSummaryByProject.Name = "btnSummaryByProject"
        Me.btnSummaryByProject.Size = New System.Drawing.Size(214, 38)
        Me.btnSummaryByProject.TabIndex = 53
        Me.btnSummaryByProject.Text = "  &Summary By Project"
        Me.btnSummaryByProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSummaryByProject.UseVisualStyleBackColor = False
        '
        'btnSummaryByAccount
        '
        Me.btnSummaryByAccount.BackColor = System.Drawing.Color.White
        Me.btnSummaryByAccount.Enabled = False
        Me.btnSummaryByAccount.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSummaryByAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummaryByAccount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummaryByAccount.ForeColor = System.Drawing.Color.Black
        Me.btnSummaryByAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByAccount.ImageIndex = 4
        Me.btnSummaryByAccount.ImageList = Me.ImageList1
        Me.btnSummaryByAccount.Location = New System.Drawing.Point(12, 188)
        Me.btnSummaryByAccount.Name = "btnSummaryByAccount"
        Me.btnSummaryByAccount.Size = New System.Drawing.Size(214, 38)
        Me.btnSummaryByAccount.TabIndex = 52
        Me.btnSummaryByAccount.Text = "  &Summary By Account"
        Me.btnSummaryByAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSummaryByAccount.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 278)
        Me.Panel5.TabIndex = 51
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(236, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 278)
        Me.Panel4.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 280)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(238, 2)
        Me.Panel3.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 2)
        Me.Panel2.TabIndex = 48
        '
        'btnSummaryByBank
        '
        Me.btnSummaryByBank.BackColor = System.Drawing.Color.White
        Me.btnSummaryByBank.Enabled = False
        Me.btnSummaryByBank.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSummaryByBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummaryByBank.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummaryByBank.ForeColor = System.Drawing.Color.Black
        Me.btnSummaryByBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByBank.ImageIndex = 3
        Me.btnSummaryByBank.ImageList = Me.ImageList1
        Me.btnSummaryByBank.Location = New System.Drawing.Point(12, 144)
        Me.btnSummaryByBank.Name = "btnSummaryByBank"
        Me.btnSummaryByBank.Size = New System.Drawing.Size(214, 38)
        Me.btnSummaryByBank.TabIndex = 47
        Me.btnSummaryByBank.Text = "  &Summary By Bank"
        Me.btnSummaryByBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByBank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSummaryByBank.UseVisualStyleBackColor = False
        '
        'btnSummaryByDateRange
        '
        Me.btnSummaryByDateRange.BackColor = System.Drawing.Color.White
        Me.btnSummaryByDateRange.Enabled = False
        Me.btnSummaryByDateRange.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSummaryByDateRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummaryByDateRange.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummaryByDateRange.ForeColor = System.Drawing.Color.Black
        Me.btnSummaryByDateRange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByDateRange.ImageIndex = 2
        Me.btnSummaryByDateRange.ImageList = Me.ImageList1
        Me.btnSummaryByDateRange.Location = New System.Drawing.Point(12, 100)
        Me.btnSummaryByDateRange.Name = "btnSummaryByDateRange"
        Me.btnSummaryByDateRange.Size = New System.Drawing.Size(214, 38)
        Me.btnSummaryByDateRange.TabIndex = 46
        Me.btnSummaryByDateRange.Text = "  &Summary By Date Range"
        Me.btnSummaryByDateRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByDateRange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSummaryByDateRange.UseVisualStyleBackColor = False
        '
        'btnBatchPrinting
        '
        Me.btnBatchPrinting.BackColor = System.Drawing.Color.White
        Me.btnBatchPrinting.Enabled = False
        Me.btnBatchPrinting.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBatchPrinting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatchPrinting.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatchPrinting.ForeColor = System.Drawing.Color.Black
        Me.btnBatchPrinting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatchPrinting.ImageIndex = 1
        Me.btnBatchPrinting.ImageList = Me.ImageList1
        Me.btnBatchPrinting.Location = New System.Drawing.Point(12, 56)
        Me.btnBatchPrinting.Name = "btnBatchPrinting"
        Me.btnBatchPrinting.Size = New System.Drawing.Size(214, 38)
        Me.btnBatchPrinting.TabIndex = 45
        Me.btnBatchPrinting.Text = "  &Batch Printing"
        Me.btnBatchPrinting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatchPrinting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBatchPrinting.UseVisualStyleBackColor = False
        '
        'btnCheckVoucher
        '
        Me.btnCheckVoucher.BackColor = System.Drawing.Color.White
        Me.btnCheckVoucher.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCheckVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckVoucher.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckVoucher.ForeColor = System.Drawing.Color.Black
        Me.btnCheckVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckVoucher.ImageIndex = 0
        Me.btnCheckVoucher.ImageList = Me.ImageList1
        Me.btnCheckVoucher.Location = New System.Drawing.Point(12, 12)
        Me.btnCheckVoucher.Name = "btnCheckVoucher"
        Me.btnCheckVoucher.Size = New System.Drawing.Size(214, 38)
        Me.btnCheckVoucher.TabIndex = 44
        Me.btnCheckVoucher.Text = "  &Check Voucher"
        Me.btnCheckVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCheckVoucher.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "chledger.png")
        Me.ImageList1.Images.SetKeyName(1, "printing.png")
        Me.ImageList1.Images.SetKeyName(2, "bydate.png")
        Me.ImageList1.Images.SetKeyName(3, "bank.png")
        Me.ImageList1.Images.SetKeyName(4, "account.png")
        Me.ImageList1.Images.SetKeyName(5, "project.png")
        '
        'CashDisbursementSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 282)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CashDisbursementSubMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CashDisbursementSubMenu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSummaryByProject As Button
    Friend WithEvents btnSummaryByAccount As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSummaryByBank As Button
    Friend WithEvents btnSummaryByDateRange As Button
    Friend WithEvents btnBatchPrinting As Button
    Friend WithEvents btnCheckVoucher As Button
    Friend WithEvents ImageList1 As ImageList
End Class
