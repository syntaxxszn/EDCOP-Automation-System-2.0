<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainPanelSSM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPanelSSM))
        Me.PanelSSS = New System.Windows.Forms.Panel()
        Me.btnOption = New System.Windows.Forms.Button()
        Me.ImageListMenuIcon = New System.Windows.Forms.ImageList(Me.components)
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.PanelSSS.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSSS
        '
        Me.PanelSSS.BackColor = System.Drawing.Color.White
        Me.PanelSSS.Controls.Add(Me.btnOption)
        Me.PanelSSS.Controls.Add(Me.btnTransaction)
        Me.PanelSSS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSSS.Location = New System.Drawing.Point(0, 0)
        Me.PanelSSS.Name = "PanelSSS"
        Me.PanelSSS.Size = New System.Drawing.Size(284, 93)
        Me.PanelSSS.TabIndex = 3
        '
        'btnOption
        '
        Me.btnOption.BackColor = System.Drawing.Color.White
        Me.btnOption.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOption.FlatAppearance.BorderSize = 0
        Me.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOption.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption.ForeColor = System.Drawing.Color.Black
        Me.btnOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOption.ImageIndex = 2
        Me.btnOption.ImageList = Me.ImageListMenuIcon
        Me.btnOption.Location = New System.Drawing.Point(0, 42)
        Me.btnOption.Name = "btnOption"
        Me.btnOption.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnOption.Size = New System.Drawing.Size(284, 38)
        Me.btnOption.TabIndex = 20
        Me.btnOption.Text = "   Tools"
        Me.btnOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOption.UseVisualStyleBackColor = False
        '
        'ImageListMenuIcon
        '
        Me.ImageListMenuIcon.ImageStream = CType(resources.GetObject("ImageListMenuIcon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListMenuIcon.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListMenuIcon.Images.SetKeyName(0, "Setup.png")
        Me.ImageListMenuIcon.Images.SetKeyName(1, "Transaction.png")
        Me.ImageListMenuIcon.Images.SetKeyName(2, "Report.png")
        Me.ImageListMenuIcon.Images.SetKeyName(3, "Option.png")
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.White
        Me.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.Black
        Me.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.ImageIndex = 3
        Me.btnTransaction.ImageList = Me.ImageListMenuIcon
        Me.btnTransaction.Location = New System.Drawing.Point(0, 0)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnTransaction.Size = New System.Drawing.Size(284, 42)
        Me.btnTransaction.TabIndex = 18
        Me.btnTransaction.Text = " Transaction"
        Me.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'frmMainPanelSSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 93)
        Me.Controls.Add(Me.PanelSSS)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainPanelSSS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmMainPanelSSS"
        Me.PanelSSS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSSS As Panel
    Friend WithEvents btnOption As Button
    Friend WithEvents btnTransaction As Button
    Friend WithEvents ImageListMenuIcon As ImageList
End Class
