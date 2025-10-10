<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHR_UpdatePersonnelDetails_201FileChecklist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgv201CheckList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip201FileChecklist = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetToCompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRemarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRemoveFile = New System.Windows.Forms.Button()
        Me.btnAddNewFile = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgv201CheckList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip201FileChecklist.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Controls.Add(Me.btnRemoveFile)
        Me.Panel1.Controls.Add(Me.btnAddNewFile)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 613)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(450, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Select from the list first then click on Add File. Right-click to see more option" &
    "s."
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Panel6)
        Me.Panel14.Controls.Add(Me.Panel5)
        Me.Panel14.Controls.Add(Me.Panel4)
        Me.Panel14.Controls.Add(Me.Panel3)
        Me.Panel14.Controls.Add(Me.Panel2)
        Me.Panel14.Location = New System.Drawing.Point(12, 48)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(809, 553)
        Me.Panel14.TabIndex = 91
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgv201CheckList)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(801, 545)
        Me.Panel6.TabIndex = 4
        '
        'dgv201CheckList
        '
        Me.dgv201CheckList.AllowUserToAddRows = False
        Me.dgv201CheckList.AllowUserToDeleteRows = False
        Me.dgv201CheckList.AllowUserToResizeColumns = False
        Me.dgv201CheckList.AllowUserToResizeRows = False
        Me.dgv201CheckList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv201CheckList.BackgroundColor = System.Drawing.Color.White
        Me.dgv201CheckList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv201CheckList.ColumnHeadersHeight = 35
        Me.dgv201CheckList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv201CheckList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column7, Me.Column2, Me.Column4, Me.Column5, Me.Column3, Me.Column6})
        Me.dgv201CheckList.ContextMenuStrip = Me.ContextMenuStrip201FileChecklist
        Me.dgv201CheckList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv201CheckList.Location = New System.Drawing.Point(0, 0)
        Me.dgv201CheckList.MultiSelect = False
        Me.dgv201CheckList.Name = "dgv201CheckList"
        Me.dgv201CheckList.ReadOnly = True
        Me.dgv201CheckList.RowHeadersVisible = False
        Me.dgv201CheckList.RowTemplate.Height = 30
        Me.dgv201CheckList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv201CheckList.Size = New System.Drawing.Size(801, 545)
        Me.dgv201CheckList.TabIndex = 88
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 43
        '
        'Column7
        '
        Me.Column7.HeaderText = "FileID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        Me.Column7.Width = 59
        '
        'Column2
        '
        Me.Column2.HeaderText = "File Type"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 70
        '
        'Column4
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column4.HeaderText = "Completed"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 88
        '
        'Column5
        '
        Me.Column5.HeaderText = "Remarks"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "File Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 76
        '
        'Column6
        '
        Me.Column6.HeaderText = "File Path"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        Me.Column6.Width = 68
        '
        'ContextMenuStrip201FileChecklist
        '
        Me.ContextMenuStrip201FileChecklist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip201FileChecklist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetToCompleteToolStripMenuItem, Me.AddRemarksToolStripMenuItem})
        Me.ContextMenuStrip201FileChecklist.Name = "ContextMenuStrip201FileChecklist"
        Me.ContextMenuStrip201FileChecklist.Size = New System.Drawing.Size(155, 48)
        '
        'SetToCompleteToolStripMenuItem
        '
        Me.SetToCompleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompleteToolStripMenuItem, Me.IncompleteToolStripMenuItem})
        Me.SetToCompleteToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.timesheetcorrection
        Me.SetToCompleteToolStripMenuItem.Name = "SetToCompleteToolStripMenuItem"
        Me.SetToCompleteToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SetToCompleteToolStripMenuItem.Text = "Set Status"
        '
        'CompleteToolStripMenuItem
        '
        Me.CompleteToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.yes
        Me.CompleteToolStripMenuItem.Name = "CompleteToolStripMenuItem"
        Me.CompleteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CompleteToolStripMenuItem.Text = "Complete (Yes)"
        '
        'IncompleteToolStripMenuItem
        '
        Me.IncompleteToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.icons8_close_48
        Me.IncompleteToolStripMenuItem.Name = "IncompleteToolStripMenuItem"
        Me.IncompleteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IncompleteToolStripMenuItem.Text = "Incomplete (No)"
        '
        'AddRemarksToolStripMenuItem
        '
        Me.AddRemarksToolStripMenuItem.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.pen
        Me.AddRemarksToolStripMenuItem.Name = "AddRemarksToolStripMenuItem"
        Me.AddRemarksToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AddRemarksToolStripMenuItem.Text = "Add Remarks"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(3, 548)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(801, 3)
        Me.Panel5.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(801, 3)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(804, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 551)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 551)
        Me.Panel2.TabIndex = 0
        '
        'btnRemoveFile
        '
        Me.btnRemoveFile.BackColor = System.Drawing.Color.Maroon
        Me.btnRemoveFile.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btnRemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveFile.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFile.ForeColor = System.Drawing.Color.White
        Me.btnRemoveFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemoveFile.ImageIndex = 0
        Me.btnRemoveFile.Location = New System.Drawing.Point(139, 12)
        Me.btnRemoveFile.Name = "btnRemoveFile"
        Me.btnRemoveFile.Size = New System.Drawing.Size(121, 30)
        Me.btnRemoveFile.TabIndex = 2
        Me.btnRemoveFile.Text = " Remove File"
        Me.btnRemoveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemoveFile.UseVisualStyleBackColor = False
        '
        'btnAddNewFile
        '
        Me.btnAddNewFile.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAddNewFile.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAddNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewFile.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewFile.ForeColor = System.Drawing.Color.White
        Me.btnAddNewFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddNewFile.ImageIndex = 1
        Me.btnAddNewFile.Location = New System.Drawing.Point(12, 12)
        Me.btnAddNewFile.Name = "btnAddNewFile"
        Me.btnAddNewFile.Size = New System.Drawing.Size(121, 30)
        Me.btnAddNewFile.TabIndex = 1
        Me.btnAddNewFile.Text = " Add File"
        Me.btnAddNewFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNewFile.UseVisualStyleBackColor = False
        '
        'frmHR_UpdatePersonnelDetails_201FileChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 613)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHR_UpdatePersonnelDetails_201FileChecklist"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = "109"
        Me.Text = "frmHR_UpdatePersonnelDetails_201File"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgv201CheckList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip201FileChecklist.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgv201CheckList As DataGridView
    Friend WithEvents btnRemoveFile As Button
    Friend WithEvents btnAddNewFile As Button
    Friend WithEvents ContextMenuStrip201FileChecklist As ContextMenuStrip
    Friend WithEvents SetToCompleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRemarksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents CompleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncompleteToolStripMenuItem As ToolStripMenuItem
End Class
