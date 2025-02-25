<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainPanelPMM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPanelPMM))
        Me.PanelPMM = New System.Windows.Forms.Panel()
        Me.btnPurchaseJournal = New System.Windows.Forms.Button()
        Me.ImageListMenuIcon = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelPMM.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelPMM
        '
        Me.PanelPMM.BackColor = System.Drawing.Color.White
        Me.PanelPMM.Controls.Add(Me.btnPurchaseJournal)
        Me.PanelPMM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPMM.Location = New System.Drawing.Point(0, 0)
        Me.PanelPMM.Name = "PanelPMM"
        Me.PanelPMM.Size = New System.Drawing.Size(284, 45)
        Me.PanelPMM.TabIndex = 3
        '
        'btnPurchaseJournal
        '
        Me.btnPurchaseJournal.BackColor = System.Drawing.Color.White
        Me.btnPurchaseJournal.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPurchaseJournal.FlatAppearance.BorderSize = 0
        Me.btnPurchaseJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurchaseJournal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchaseJournal.ForeColor = System.Drawing.Color.Black
        Me.btnPurchaseJournal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchaseJournal.ImageIndex = 0
        Me.btnPurchaseJournal.ImageList = Me.ImageListMenuIcon
        Me.btnPurchaseJournal.Location = New System.Drawing.Point(0, 0)
        Me.btnPurchaseJournal.Name = "btnPurchaseJournal"
        Me.btnPurchaseJournal.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnPurchaseJournal.Size = New System.Drawing.Size(284, 42)
        Me.btnPurchaseJournal.TabIndex = 19
        Me.btnPurchaseJournal.Text = " Purchase Journal"
        Me.btnPurchaseJournal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchaseJournal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPurchaseJournal.UseVisualStyleBackColor = False
        '
        'ImageListMenuIcon
        '
        Me.ImageListMenuIcon.ImageStream = CType(resources.GetObject("ImageListMenuIcon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListMenuIcon.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListMenuIcon.Images.SetKeyName(0, "purlegder.png")
        '
        'frmMainPanelPMM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 45)
        Me.Controls.Add(Me.PanelPMM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainPanelPMM"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmMainPanelPMM"
        Me.PanelPMM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPMM As Panel
    Friend WithEvents ImageListMenuIcon As ImageList
    Friend WithEvents btnPurchaseJournal As Button
End Class
