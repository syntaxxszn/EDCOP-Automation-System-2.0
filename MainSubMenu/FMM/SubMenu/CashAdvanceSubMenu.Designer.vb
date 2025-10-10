<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashAdvanceSubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashAdvanceSubMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCashSlip = New System.Windows.Forms.Button()
        Me.btnRequestForCashAdvance = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCashSlip)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnRequestForCashAdvance)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 106)
        Me.Panel1.TabIndex = 3
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "process.png")
        Me.ImageList1.Images.SetKeyName(1, "audit.png")
        Me.ImageList1.Images.SetKeyName(2, "money.png")
        Me.ImageList1.Images.SetKeyName(3, "expense.png")
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 102)
        Me.Panel5.TabIndex = 51
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(236, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 102)
        Me.Panel4.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 104)
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
        'btnCashSlip
        '
        Me.btnCashSlip.BackColor = System.Drawing.Color.White
        Me.btnCashSlip.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCashSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCashSlip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashSlip.ForeColor = System.Drawing.Color.Black
        Me.btnCashSlip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashSlip.ImageIndex = 2
        Me.btnCashSlip.ImageList = Me.ImageList1
        Me.btnCashSlip.Location = New System.Drawing.Point(12, 56)
        Me.btnCashSlip.Name = "btnCashSlip"
        Me.btnCashSlip.Size = New System.Drawing.Size(214, 38)
        Me.btnCashSlip.TabIndex = 52
        Me.btnCashSlip.Text = "  &Cash Advance Slip"
        Me.btnCashSlip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashSlip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCashSlip.UseVisualStyleBackColor = False
        '
        'btnRequestForCashAdvance
        '
        Me.btnRequestForCashAdvance.BackColor = System.Drawing.Color.White
        Me.btnRequestForCashAdvance.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRequestForCashAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequestForCashAdvance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequestForCashAdvance.ForeColor = System.Drawing.Color.Black
        Me.btnRequestForCashAdvance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRequestForCashAdvance.ImageIndex = 0
        Me.btnRequestForCashAdvance.ImageList = Me.ImageList1
        Me.btnRequestForCashAdvance.Location = New System.Drawing.Point(12, 12)
        Me.btnRequestForCashAdvance.Name = "btnRequestForCashAdvance"
        Me.btnRequestForCashAdvance.Size = New System.Drawing.Size(214, 38)
        Me.btnRequestForCashAdvance.TabIndex = 44
        Me.btnRequestForCashAdvance.Text = "  &Request For Cash Advance"
        Me.btnRequestForCashAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRequestForCashAdvance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRequestForCashAdvance.UseVisualStyleBackColor = False
        '
        'CashAdvanceSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 106)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CashAdvanceSubMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CashAdvanceSubMenu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCashSlip As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRequestForCashAdvance As Button
    Friend WithEvents ImageList1 As ImageList
End Class
