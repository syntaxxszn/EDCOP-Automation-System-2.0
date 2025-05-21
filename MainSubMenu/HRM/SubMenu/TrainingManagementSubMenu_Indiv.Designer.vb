<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainingManagementSubMenu_Indiv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrainingManagementSubMenu_Indiv))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTrainingEvaluation = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTrainingRequest = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "employees.png")
        Me.ImageList1.Images.SetKeyName(1, "requisition.png")
        Me.ImageList1.Images.SetKeyName(2, "feedback.png")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnTrainingEvaluation)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnTrainingRequest)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 119)
        Me.Panel1.TabIndex = 7
        '
        'btnTrainingEvaluation
        '
        Me.btnTrainingEvaluation.BackColor = System.Drawing.Color.White
        Me.btnTrainingEvaluation.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnTrainingEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrainingEvaluation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrainingEvaluation.ForeColor = System.Drawing.Color.Black
        Me.btnTrainingEvaluation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrainingEvaluation.ImageIndex = 2
        Me.btnTrainingEvaluation.ImageList = Me.ImageList1
        Me.btnTrainingEvaluation.Location = New System.Drawing.Point(12, 61)
        Me.btnTrainingEvaluation.Name = "btnTrainingEvaluation"
        Me.btnTrainingEvaluation.Size = New System.Drawing.Size(214, 43)
        Me.btnTrainingEvaluation.TabIndex = 52
        Me.btnTrainingEvaluation.Text = " &Training Evaluation"
        Me.btnTrainingEvaluation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrainingEvaluation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTrainingEvaluation.UseVisualStyleBackColor = False
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
        'btnTrainingRequest
        '
        Me.btnTrainingRequest.BackColor = System.Drawing.Color.White
        Me.btnTrainingRequest.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnTrainingRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrainingRequest.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrainingRequest.ForeColor = System.Drawing.Color.Black
        Me.btnTrainingRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrainingRequest.ImageIndex = 0
        Me.btnTrainingRequest.ImageList = Me.ImageList1
        Me.btnTrainingRequest.Location = New System.Drawing.Point(12, 12)
        Me.btnTrainingRequest.Name = "btnTrainingRequest"
        Me.btnTrainingRequest.Size = New System.Drawing.Size(214, 43)
        Me.btnTrainingRequest.TabIndex = 44
        Me.btnTrainingRequest.Text = " &Training Request"
        Me.btnTrainingRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrainingRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTrainingRequest.UseVisualStyleBackColor = False
        '
        'TrainingManagementSubMenu_Indiv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 119)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TrainingManagementSubMenu_Indiv"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "TrainingManagementSubMenu_Indiv"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnTrainingEvaluation As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTrainingRequest As Button
End Class
