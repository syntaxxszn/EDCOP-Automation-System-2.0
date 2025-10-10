<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestForPaymentSubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RequestForPaymentSubMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAgeing = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSummaryByAccount = New System.Windows.Forms.Button()
        Me.btnSummaryByDateRange = New System.Windows.Forms.Button()
        Me.btnBatchPrinting = New System.Windows.Forms.Button()
        Me.btnRequestForPaymentVoucher = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnAgeing)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnSummaryByAccount)
        Me.Panel1.Controls.Add(Me.btnSummaryByDateRange)
        Me.Panel1.Controls.Add(Me.btnBatchPrinting)
        Me.Panel1.Controls.Add(Me.btnRequestForPaymentVoucher)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 239)
        Me.Panel1.TabIndex = 1
        '
        'btnAgeing
        '
        Me.btnAgeing.BackColor = System.Drawing.Color.White
        Me.btnAgeing.Enabled = False
        Me.btnAgeing.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAgeing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgeing.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgeing.ForeColor = System.Drawing.Color.Black
        Me.btnAgeing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgeing.ImageIndex = 4
        Me.btnAgeing.ImageList = Me.ImageList1
        Me.btnAgeing.Location = New System.Drawing.Point(12, 188)
        Me.btnAgeing.Name = "btnAgeing"
        Me.btnAgeing.Size = New System.Drawing.Size(214, 38)
        Me.btnAgeing.TabIndex = 52
        Me.btnAgeing.Text = "  &Ageing"
        Me.btnAgeing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgeing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgeing.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "account.png")
        Me.ImageList1.Images.SetKeyName(1, "bydate.png")
        Me.ImageList1.Images.SetKeyName(2, "printing.png")
        Me.ImageList1.Images.SetKeyName(3, "rfpv.png")
        Me.ImageList1.Images.SetKeyName(4, "clock.png")
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 235)
        Me.Panel5.TabIndex = 51
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(236, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 235)
        Me.Panel4.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 237)
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
        'btnSummaryByAccount
        '
        Me.btnSummaryByAccount.BackColor = System.Drawing.Color.White
        Me.btnSummaryByAccount.Enabled = False
        Me.btnSummaryByAccount.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSummaryByAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummaryByAccount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummaryByAccount.ForeColor = System.Drawing.Color.Black
        Me.btnSummaryByAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByAccount.ImageIndex = 0
        Me.btnSummaryByAccount.ImageList = Me.ImageList1
        Me.btnSummaryByAccount.Location = New System.Drawing.Point(12, 144)
        Me.btnSummaryByAccount.Name = "btnSummaryByAccount"
        Me.btnSummaryByAccount.Size = New System.Drawing.Size(214, 38)
        Me.btnSummaryByAccount.TabIndex = 47
        Me.btnSummaryByAccount.Text = "  &Summary By Account"
        Me.btnSummaryByAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSummaryByAccount.UseVisualStyleBackColor = False
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
        Me.btnSummaryByDateRange.ImageIndex = 1
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
        Me.btnBatchPrinting.ImageIndex = 2
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
        'btnRequestForPaymentVoucher
        '
        Me.btnRequestForPaymentVoucher.BackColor = System.Drawing.Color.White
        Me.btnRequestForPaymentVoucher.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRequestForPaymentVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequestForPaymentVoucher.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequestForPaymentVoucher.ForeColor = System.Drawing.Color.Black
        Me.btnRequestForPaymentVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRequestForPaymentVoucher.ImageIndex = 3
        Me.btnRequestForPaymentVoucher.ImageList = Me.ImageList1
        Me.btnRequestForPaymentVoucher.Location = New System.Drawing.Point(12, 12)
        Me.btnRequestForPaymentVoucher.Name = "btnRequestForPaymentVoucher"
        Me.btnRequestForPaymentVoucher.Size = New System.Drawing.Size(214, 38)
        Me.btnRequestForPaymentVoucher.TabIndex = 44
        Me.btnRequestForPaymentVoucher.Text = "  &Request For Payment Voucher"
        Me.btnRequestForPaymentVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRequestForPaymentVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRequestForPaymentVoucher.UseVisualStyleBackColor = False
        '
        'RequestForPaymentSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 239)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RequestForPaymentSubMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "RequestForPaymentSubMenu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAgeing As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSummaryByAccount As Button
    Friend WithEvents btnSummaryByDateRange As Button
    Friend WithEvents btnBatchPrinting As Button
    Friend WithEvents btnRequestForPaymentVoucher As Button
    Friend WithEvents ImageList1 As ImageList
End Class
