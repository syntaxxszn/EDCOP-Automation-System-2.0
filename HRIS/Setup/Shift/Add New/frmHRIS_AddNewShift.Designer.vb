<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHRIS_AddNewShift
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescriptions = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpNormalWorkTimeFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpNormalWorkTimeTo = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.checkboxFlexi = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSlideTime = New System.Windows.Forms.TextBox()
        Me.checkboxForceBreak = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpNormalBreakTimeTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpNormalBreakTimeFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalHours = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 81)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.folder
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(75, 21)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(111, 20)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Add New Shift"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fill-up all entry box then click &Save button."
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(565, 81)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(16, 326)
        Me.Panel4.TabIndex = 73
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(16, 326)
        Me.Panel3.TabIndex = 72
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.btnDiscard)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 407)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(581, 70)
        Me.Panel2.TabIndex = 71
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Control
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(464, 21)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 28)
        Me.btnReset.TabIndex = 105
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnDiscard
        '
        Me.btnDiscard.BackColor = System.Drawing.Color.White
        Me.btnDiscard.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscard.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscard.ForeColor = System.Drawing.Color.Maroon
        Me.btnDiscard.Location = New System.Drawing.Point(124, 21)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(94, 28)
        Me.btnDiscard.TabIndex = 104
        Me.btnDiscard.Text = "&Discard "
        Me.btnDiscard.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSave.Location = New System.Drawing.Point(22, 21)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 28)
        Me.btnSave.TabIndex = 103
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(19, 404)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(543, 3)
        Me.Panel6.TabIndex = 78
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gray
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(19, 81)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(543, 3)
        Me.Panel5.TabIndex = 77
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gray
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(562, 81)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(3, 326)
        Me.Panel7.TabIndex = 76
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gray
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(16, 81)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(3, 326)
        Me.Panel8.TabIndex = 75
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Location = New System.Drawing.Point(136, 107)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(386, 23)
        Me.txtCode.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(46, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Code *:"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(136, 137)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(386, 23)
        Me.txtName.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(46, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Name *:"
        '
        'txtDescriptions
        '
        Me.txtDescriptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescriptions.Location = New System.Drawing.Point(136, 167)
        Me.txtDescriptions.Name = "txtDescriptions"
        Me.txtDescriptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescriptions.Size = New System.Drawing.Size(386, 23)
        Me.txtDescriptions.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(46, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Description :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(46, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Normal Work Time *:"
        '
        'dtpNormalWorkTimeFrom
        '
        Me.dtpNormalWorkTimeFrom.CustomFormat = "hh:mm tt"
        Me.dtpNormalWorkTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNormalWorkTimeFrom.Location = New System.Drawing.Point(185, 205)
        Me.dtpNormalWorkTimeFrom.Name = "dtpNormalWorkTimeFrom"
        Me.dtpNormalWorkTimeFrom.Size = New System.Drawing.Size(100, 23)
        Me.dtpNormalWorkTimeFrom.TabIndex = 86
        '
        'dtpNormalWorkTimeTo
        '
        Me.dtpNormalWorkTimeTo.CustomFormat = "hh:mm tt"
        Me.dtpNormalWorkTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNormalWorkTimeTo.Location = New System.Drawing.Point(320, 205)
        Me.dtpNormalWorkTimeTo.Name = "dtpNormalWorkTimeTo"
        Me.dtpNormalWorkTimeTo.Size = New System.Drawing.Size(100, 23)
        Me.dtpNormalWorkTimeTo.TabIndex = 87
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(292, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "to"
        '
        'checkboxFlexi
        '
        Me.checkboxFlexi.AutoSize = True
        Me.checkboxFlexi.Location = New System.Drawing.Point(428, 209)
        Me.checkboxFlexi.Name = "checkboxFlexi"
        Me.checkboxFlexi.Size = New System.Drawing.Size(84, 19)
        Me.checkboxFlexi.TabIndex = 89
        Me.checkboxFlexi.Text = "Flexi Time?"
        Me.checkboxFlexi.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(46, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Slide Time (mins) :"
        '
        'txtSlideTime
        '
        Me.txtSlideTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSlideTime.Location = New System.Drawing.Point(185, 235)
        Me.txtSlideTime.Name = "txtSlideTime"
        Me.txtSlideTime.Size = New System.Drawing.Size(100, 23)
        Me.txtSlideTime.TabIndex = 91
        '
        'checkboxForceBreak
        '
        Me.checkboxForceBreak.AutoSize = True
        Me.checkboxForceBreak.Location = New System.Drawing.Point(428, 269)
        Me.checkboxForceBreak.Name = "checkboxForceBreak"
        Me.checkboxForceBreak.Size = New System.Drawing.Size(95, 19)
        Me.checkboxForceBreak.TabIndex = 96
        Me.checkboxForceBreak.Text = "Force Break ?"
        Me.checkboxForceBreak.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(292, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "to"
        '
        'dtpNormalBreakTimeTo
        '
        Me.dtpNormalBreakTimeTo.CustomFormat = "hh:mm tt"
        Me.dtpNormalBreakTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNormalBreakTimeTo.Location = New System.Drawing.Point(320, 265)
        Me.dtpNormalBreakTimeTo.Name = "dtpNormalBreakTimeTo"
        Me.dtpNormalBreakTimeTo.Size = New System.Drawing.Size(100, 23)
        Me.dtpNormalBreakTimeTo.TabIndex = 94
        '
        'dtpNormalBreakTimeFrom
        '
        Me.dtpNormalBreakTimeFrom.CustomFormat = "hh:mm tt"
        Me.dtpNormalBreakTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNormalBreakTimeFrom.Location = New System.Drawing.Point(185, 265)
        Me.dtpNormalBreakTimeFrom.Name = "dtpNormalBreakTimeFrom"
        Me.dtpNormalBreakTimeFrom.Size = New System.Drawing.Size(100, 23)
        Me.dtpNormalBreakTimeFrom.TabIndex = 93
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(46, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "Normal Break Time :"
        '
        'txtTotalHours
        '
        Me.txtTotalHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalHours.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTotalHours.Location = New System.Drawing.Point(308, 347)
        Me.txtTotalHours.Name = "txtTotalHours"
        Me.txtTotalHours.Size = New System.Drawing.Size(113, 23)
        Me.txtTotalHours.TabIndex = 98
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(46, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Work Hours Total :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label12.Location = New System.Drawing.Point(47, 351)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 24)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "( * Auto Compute based on input. )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Work time hr - Breaktime hr = @Total"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Gray
        Me.Panel9.Location = New System.Drawing.Point(38, 310)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(503, 3)
        Me.Panel9.TabIndex = 100
        '
        'frmHR_AddNewShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(581, 477)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalHours)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.checkboxForceBreak)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpNormalBreakTimeTo)
        Me.Controls.Add(Me.dtpNormalBreakTimeFrom)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSlideTime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.checkboxFlexi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpNormalWorkTimeTo)
        Me.Controls.Add(Me.dtpNormalWorkTimeFrom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDescriptions)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHR_AddNewShift"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Shift"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDiscard As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescriptions As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpNormalWorkTimeFrom As DateTimePicker
    Friend WithEvents dtpNormalWorkTimeTo As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents checkboxFlexi As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSlideTime As TextBox
    Friend WithEvents checkboxForceBreak As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpNormalBreakTimeTo As DateTimePicker
    Friend WithEvents dtpNormalBreakTimeFrom As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalHours As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel9 As Panel
End Class
