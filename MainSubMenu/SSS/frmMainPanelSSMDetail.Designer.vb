<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainPanelSSMDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPanelSSMDetail))
        Me.panelSubSSS_TransactionDetails = New System.Windows.Forms.Panel()
        Me.btnGroupAccess = New System.Windows.Forms.Button()
        Me.ImageListSubMenuIcon = New System.Windows.Forms.ImageList(Me.components)
        Me.btnUserAccess = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelSubSSS_TransactionDetails.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSubSSS_TransactionDetails
        '
        Me.panelSubSSS_TransactionDetails.Controls.Add(Me.btnGroupAccess)
        Me.panelSubSSS_TransactionDetails.Controls.Add(Me.btnUserAccess)
        Me.panelSubSSS_TransactionDetails.Controls.Add(Me.Panel12)
        Me.panelSubSSS_TransactionDetails.Location = New System.Drawing.Point(12, 12)
        Me.panelSubSSS_TransactionDetails.Name = "panelSubSSS_TransactionDetails"
        Me.panelSubSSS_TransactionDetails.Size = New System.Drawing.Size(282, 120)
        Me.panelSubSSS_TransactionDetails.TabIndex = 6
        '
        'btnGroupAccess
        '
        Me.btnGroupAccess.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGroupAccess.FlatAppearance.BorderSize = 0
        Me.btnGroupAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGroupAccess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGroupAccess.ImageIndex = 0
        Me.btnGroupAccess.ImageList = Me.ImageListSubMenuIcon
        Me.btnGroupAccess.Location = New System.Drawing.Point(0, 69)
        Me.btnGroupAccess.Name = "btnGroupAccess"
        Me.btnGroupAccess.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnGroupAccess.Size = New System.Drawing.Size(282, 35)
        Me.btnGroupAccess.TabIndex = 12
        Me.btnGroupAccess.Tag = "1200000002"
        Me.btnGroupAccess.Text = "   Group Access"
        Me.btnGroupAccess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGroupAccess.UseVisualStyleBackColor = True
        '
        'ImageListSubMenuIcon
        '
        Me.ImageListSubMenuIcon.ImageStream = CType(resources.GetObject("ImageListSubMenuIcon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListSubMenuIcon.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListSubMenuIcon.Images.SetKeyName(0, "Company.png")
        '
        'btnUserAccess
        '
        Me.btnUserAccess.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserAccess.FlatAppearance.BorderSize = 0
        Me.btnUserAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserAccess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserAccess.ImageIndex = 0
        Me.btnUserAccess.ImageList = Me.ImageListSubMenuIcon
        Me.btnUserAccess.Location = New System.Drawing.Point(0, 34)
        Me.btnUserAccess.Name = "btnUserAccess"
        Me.btnUserAccess.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnUserAccess.Size = New System.Drawing.Size(282, 35)
        Me.btnUserAccess.TabIndex = 11
        Me.btnUserAccess.Tag = "1200000001"
        Me.btnUserAccess.Text = "   User Access"
        Me.btnUserAccess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserAccess.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Label1)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(282, 34)
        Me.Panel12.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System Settings > Transaction"
        '
        'frmMainPanelSSMDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 485)
        Me.Controls.Add(Me.panelSubSSS_TransactionDetails)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainPanelSSMDetail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmMainPanelSSSDetail"
        Me.panelSubSSS_TransactionDetails.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSubSSS_TransactionDetails As Panel
    Friend WithEvents btnUserAccess As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageListSubMenuIcon As ImageList
    Friend WithEvents btnGroupAccess As Button
End Class
