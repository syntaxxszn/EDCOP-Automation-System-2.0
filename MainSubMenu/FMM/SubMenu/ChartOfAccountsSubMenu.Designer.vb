<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChartOfAccountsSubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChartOfAccountsSubMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMapping = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExternal = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnInternal = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnMapping)
        Me.Panel1.Controls.Add(Me.btnExternal)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnInternal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 151)
        Me.Panel1.TabIndex = 4
        '
        'btnMapping
        '
        Me.btnMapping.BackColor = System.Drawing.Color.White
        Me.btnMapping.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMapping.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMapping.ForeColor = System.Drawing.Color.Black
        Me.btnMapping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMapping.ImageIndex = 0
        Me.btnMapping.ImageList = Me.ImageList1
        Me.btnMapping.Location = New System.Drawing.Point(12, 100)
        Me.btnMapping.Name = "btnMapping"
        Me.btnMapping.Size = New System.Drawing.Size(214, 38)
        Me.btnMapping.TabIndex = 53
        Me.btnMapping.Text = "  &Mapping"
        Me.btnMapping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMapping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMapping.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "transfer.png")
        Me.ImageList1.Images.SetKeyName(1, "compress-alt.png")
        Me.ImageList1.Images.SetKeyName(2, "expand-alt-1.png")
        '
        'btnExternal
        '
        Me.btnExternal.BackColor = System.Drawing.Color.White
        Me.btnExternal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExternal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExternal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExternal.ForeColor = System.Drawing.Color.Black
        Me.btnExternal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExternal.ImageIndex = 2
        Me.btnExternal.ImageList = Me.ImageList1
        Me.btnExternal.Location = New System.Drawing.Point(12, 56)
        Me.btnExternal.Name = "btnExternal"
        Me.btnExternal.Size = New System.Drawing.Size(214, 38)
        Me.btnExternal.TabIndex = 52
        Me.btnExternal.Text = "  &External"
        Me.btnExternal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExternal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExternal.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 147)
        Me.Panel5.TabIndex = 51
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(236, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 147)
        Me.Panel4.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 149)
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
        'btnInternal
        '
        Me.btnInternal.BackColor = System.Drawing.Color.White
        Me.btnInternal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnInternal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInternal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInternal.ForeColor = System.Drawing.Color.Black
        Me.btnInternal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInternal.ImageIndex = 1
        Me.btnInternal.ImageList = Me.ImageList1
        Me.btnInternal.Location = New System.Drawing.Point(12, 12)
        Me.btnInternal.Name = "btnInternal"
        Me.btnInternal.Size = New System.Drawing.Size(214, 38)
        Me.btnInternal.TabIndex = 44
        Me.btnInternal.Text = "  &Internal"
        Me.btnInternal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInternal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInternal.UseVisualStyleBackColor = False
        '
        'ChartOfAccountsSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 151)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChartOfAccountsSubMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ChartOfAccountsSubMenu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMapping As Button
    Friend WithEvents btnExternal As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnInternal As Button
    Friend WithEvents ImageList1 As ImageList
End Class
