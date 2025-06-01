<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerformanceManagementSubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PerformanceManagementSubMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPart2 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPart1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnPart2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnPart1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 119)
        Me.Panel1.TabIndex = 8
        '
        'btnPart2
        '
        Me.btnPart2.BackColor = System.Drawing.Color.White
        Me.btnPart2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPart2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPart2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPart2.ForeColor = System.Drawing.Color.Black
        Me.btnPart2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPart2.ImageIndex = 0
        Me.btnPart2.ImageList = Me.ImageList1
        Me.btnPart2.Location = New System.Drawing.Point(12, 61)
        Me.btnPart2.Name = "btnPart2"
        Me.btnPart2.Size = New System.Drawing.Size(214, 43)
        Me.btnPart2.TabIndex = 52
        Me.btnPart2.Text = " &Part 2 - Performance Factors"
        Me.btnPart2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPart2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPart2.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-performance-64.png")
        Me.ImageList1.Images.SetKeyName(1, "requisition.png")
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(2, 115)
        Me.Panel5.TabIndex = 51
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(237, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2, 115)
        Me.Panel4.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 117)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(239, 2)
        Me.Panel3.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 2)
        Me.Panel2.TabIndex = 48
        '
        'btnPart1
        '
        Me.btnPart1.BackColor = System.Drawing.Color.White
        Me.btnPart1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPart1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPart1.ForeColor = System.Drawing.Color.Black
        Me.btnPart1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPart1.ImageIndex = 1
        Me.btnPart1.ImageList = Me.ImageList1
        Me.btnPart1.Location = New System.Drawing.Point(12, 12)
        Me.btnPart1.Name = "btnPart1"
        Me.btnPart1.Size = New System.Drawing.Size(214, 43)
        Me.btnPart1.TabIndex = 44
        Me.btnPart1.Text = " &Part 1 - Performance Sheets"
        Me.btnPart1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPart1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPart1.UseVisualStyleBackColor = False
        '
        'PerformanceManagementSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 119)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PerformanceManagementSubMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PerformanceManagementSubMenu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPart2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPart1 As Button
    Friend WithEvents ImageList1 As ImageList
End Class
