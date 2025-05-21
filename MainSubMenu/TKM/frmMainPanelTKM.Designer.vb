<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainPanelTKM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPanelTKM))
        Me.ImageListMenuIcon = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelTKM = New System.Windows.Forms.Panel()
        Me.btnOption = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.PanelTKM.SuspendLayout()
        Me.SuspendLayout()
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
        'PanelTKM
        '
        Me.PanelTKM.BackColor = System.Drawing.Color.White
        Me.PanelTKM.Controls.Add(Me.btnOption)
        Me.PanelTKM.Controls.Add(Me.btnReport)
        Me.PanelTKM.Controls.Add(Me.btnTransaction)
        Me.PanelTKM.Controls.Add(Me.btnSetup)
        Me.PanelTKM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTKM.Location = New System.Drawing.Point(0, 0)
        Me.PanelTKM.Name = "PanelTKM"
        Me.PanelTKM.Size = New System.Drawing.Size(284, 167)
        Me.PanelTKM.TabIndex = 3
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
        Me.btnOption.Location = New System.Drawing.Point(0, 118)
        Me.btnOption.Name = "btnOption"
        Me.btnOption.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnOption.Size = New System.Drawing.Size(284, 38)
        Me.btnOption.TabIndex = 20
        Me.btnOption.Text = "   Options"
        Me.btnOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOption.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.White
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.Black
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = 1
        Me.btnReport.ImageList = Me.ImageListMenuIcon
        Me.btnReport.Location = New System.Drawing.Point(0, 80)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnReport.Size = New System.Drawing.Size(284, 38)
        Me.btnReport.TabIndex = 19
        Me.btnReport.Text = "   Report"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = False
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
        Me.btnTransaction.Location = New System.Drawing.Point(0, 38)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnTransaction.Size = New System.Drawing.Size(284, 42)
        Me.btnTransaction.TabIndex = 18
        Me.btnTransaction.Text = " Transaction"
        Me.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'btnSetup
        '
        Me.btnSetup.BackColor = System.Drawing.Color.White
        Me.btnSetup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSetup.FlatAppearance.BorderSize = 0
        Me.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetup.ForeColor = System.Drawing.Color.Black
        Me.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetup.ImageIndex = 0
        Me.btnSetup.ImageList = Me.ImageListMenuIcon
        Me.btnSetup.Location = New System.Drawing.Point(0, 0)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnSetup.Size = New System.Drawing.Size(284, 38)
        Me.btnSetup.TabIndex = 4
        Me.btnSetup.Text = "   Setup"
        Me.btnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetup.UseVisualStyleBackColor = False
        '
        'frmMainPanelTKM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 167)
        Me.Controls.Add(Me.PanelTKM)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainPanelTKM"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmMainPanelTKM"
        Me.PanelTKM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageListMenuIcon As ImageList
    Friend WithEvents PanelTKM As Panel
    Friend WithEvents btnOption As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnSetup As Button
End Class
