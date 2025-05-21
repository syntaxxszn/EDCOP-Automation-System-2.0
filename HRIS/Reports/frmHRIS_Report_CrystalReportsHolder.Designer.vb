<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRIS_Report_CrystalReportsHolder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRIS_Report_CrystalReportsHolder))
        Me.HRIS_CrystalReports_Holder = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCOESendEmail = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSaveWord = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HRIS_CrystalReports_Holder
        '
        Me.HRIS_CrystalReports_Holder.ActiveViewIndex = -1
        Me.HRIS_CrystalReports_Holder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HRIS_CrystalReports_Holder.Cursor = System.Windows.Forms.Cursors.Default
        Me.HRIS_CrystalReports_Holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HRIS_CrystalReports_Holder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HRIS_CrystalReports_Holder.ForeColor = System.Drawing.SystemColors.Control
        Me.HRIS_CrystalReports_Holder.Location = New System.Drawing.Point(0, 56)
        Me.HRIS_CrystalReports_Holder.Name = "HRIS_CrystalReports_Holder"
        Me.HRIS_CrystalReports_Holder.Size = New System.Drawing.Size(943, 546)
        Me.HRIS_CrystalReports_Holder.TabIndex = 6
        Me.HRIS_CrystalReports_Holder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCOESendEmail)
        Me.Panel1.Controls.Add(Me.btnSaveWord)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 56)
        Me.Panel1.TabIndex = 7
        '
        'btnCOESendEmail
        '
        Me.btnCOESendEmail.BackColor = System.Drawing.Color.White
        Me.btnCOESendEmail.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnCOESendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCOESendEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCOESendEmail.ForeColor = System.Drawing.Color.Navy
        Me.btnCOESendEmail.ImageIndex = 1
        Me.btnCOESendEmail.ImageList = Me.ImageList1
        Me.btnCOESendEmail.Location = New System.Drawing.Point(189, 8)
        Me.btnCOESendEmail.Name = "btnCOESendEmail"
        Me.btnCOESendEmail.Size = New System.Drawing.Size(137, 39)
        Me.btnCOESendEmail.TabIndex = 47
        Me.btnCOESendEmail.Text = " &Send as Email"
        Me.btnCOESendEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCOESendEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCOESendEmail.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "word.png")
        Me.ImageList1.Images.SetKeyName(1, "email.png")
        '
        'btnSaveWord
        '
        Me.btnSaveWord.BackColor = System.Drawing.Color.White
        Me.btnSaveWord.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnSaveWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveWord.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveWord.ForeColor = System.Drawing.Color.Navy
        Me.btnSaveWord.ImageIndex = 0
        Me.btnSaveWord.ImageList = Me.ImageList1
        Me.btnSaveWord.Location = New System.Drawing.Point(9, 8)
        Me.btnSaveWord.Name = "btnSaveWord"
        Me.btnSaveWord.Size = New System.Drawing.Size(174, 39)
        Me.btnSaveWord.TabIndex = 46
        Me.btnSaveWord.Text = " &Save as Word Document"
        Me.btnSaveWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveWord.UseVisualStyleBackColor = False
        '
        'frmHRIS_Report_CrystalReportsHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 602)
        Me.Controls.Add(Me.HRIS_CrystalReports_Holder)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "frmHRIS_Report_CrystalReportsHolder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Human Resource Crystal Report"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HRIS_CrystalReports_Holder As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSaveWord As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnCOESendEmail As Button
End Class
