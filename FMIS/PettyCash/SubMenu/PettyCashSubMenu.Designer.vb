<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PettyCashSubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PettyCashSubMenu))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSummaryByDateRange = New System.Windows.Forms.Button()
        Me.btnSummaryByReplenishment = New System.Windows.Forms.Button()
        Me.btnPettyCashVoucher = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "pettycashvoucher.png")
        Me.ImageList1.Images.SetKeyName(1, "byreple.png")
        Me.ImageList1.Images.SetKeyName(2, "bydate.png")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnSummaryByDateRange)
        Me.Panel1.Controls.Add(Me.btnSummaryByReplenishment)
        Me.Panel1.Controls.Add(Me.btnPettyCashVoucher)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 150)
        Me.Panel1.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 146)
        Me.Panel5.TabIndex = 51
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(236, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 146)
        Me.Panel4.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 148)
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
        'btnSummaryByReplenishment
        '
        Me.btnSummaryByReplenishment.BackColor = System.Drawing.Color.White
        Me.btnSummaryByReplenishment.Enabled = False
        Me.btnSummaryByReplenishment.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSummaryByReplenishment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummaryByReplenishment.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummaryByReplenishment.ForeColor = System.Drawing.Color.Black
        Me.btnSummaryByReplenishment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByReplenishment.ImageIndex = 1
        Me.btnSummaryByReplenishment.ImageList = Me.ImageList1
        Me.btnSummaryByReplenishment.Location = New System.Drawing.Point(12, 56)
        Me.btnSummaryByReplenishment.Name = "btnSummaryByReplenishment"
        Me.btnSummaryByReplenishment.Size = New System.Drawing.Size(214, 38)
        Me.btnSummaryByReplenishment.TabIndex = 45
        Me.btnSummaryByReplenishment.Text = "  &Summary By Replenishment"
        Me.btnSummaryByReplenishment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummaryByReplenishment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSummaryByReplenishment.UseVisualStyleBackColor = False
        '
        'btnPettyCashVoucher
        '
        Me.btnPettyCashVoucher.BackColor = System.Drawing.Color.White
        Me.btnPettyCashVoucher.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPettyCashVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPettyCashVoucher.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPettyCashVoucher.ForeColor = System.Drawing.Color.Black
        Me.btnPettyCashVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPettyCashVoucher.ImageIndex = 0
        Me.btnPettyCashVoucher.ImageList = Me.ImageList1
        Me.btnPettyCashVoucher.Location = New System.Drawing.Point(12, 12)
        Me.btnPettyCashVoucher.Name = "btnPettyCashVoucher"
        Me.btnPettyCashVoucher.Size = New System.Drawing.Size(214, 38)
        Me.btnPettyCashVoucher.TabIndex = 44
        Me.btnPettyCashVoucher.Text = "  &Petty Cash Voucher"
        Me.btnPettyCashVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPettyCashVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPettyCashVoucher.UseVisualStyleBackColor = False
        '
        'PettyCashSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 150)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PettyCashSubMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PettyCashSubMenu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSummaryByDateRange As Button
    Friend WithEvents btnSummaryByReplenishment As Button
    Friend WithEvents btnPettyCashVoucher As Button
End Class
