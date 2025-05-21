<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTK_AddUpdUnderTime
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpDateFiling = New System.Windows.Forms.DateTimePicker()
        Me.chLateFiling = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpSWT = New System.Windows.Forms.DateTimePicker()
        Me.dtpWorkDate = New System.Windows.Forms.DateTimePicker()
        Me.btnClearTextFields = New System.Windows.Forms.Button()
        Me.btnAddUndertime = New System.Windows.Forms.Button()
        Me.dtpEWT = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBoxHelp = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBoxHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 294)
        Me.Panel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.dtpDateFiling)
        Me.Panel3.Controls.Add(Me.chLateFiling)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.dtpSWT)
        Me.Panel3.Controls.Add(Me.dtpWorkDate)
        Me.Panel3.Controls.Add(Me.btnClearTextFields)
        Me.Panel3.Controls.Add(Me.btnAddUndertime)
        Me.Panel3.Controls.Add(Me.dtpEWT)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtReason)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(16, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(311, 221)
        Me.Panel3.TabIndex = 6
        '
        'dtpDateFiling
        '
        Me.dtpDateFiling.Enabled = False
        Me.dtpDateFiling.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFiling.Location = New System.Drawing.Point(124, 109)
        Me.dtpDateFiling.Name = "dtpDateFiling"
        Me.dtpDateFiling.Size = New System.Drawing.Size(169, 23)
        Me.dtpDateFiling.TabIndex = 129
        '
        'chLateFiling
        '
        Me.chLateFiling.AutoSize = True
        Me.chLateFiling.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chLateFiling.Location = New System.Drawing.Point(20, 114)
        Me.chLateFiling.Name = "chLateFiling"
        Me.chLateFiling.Size = New System.Drawing.Size(91, 19)
        Me.chLateFiling.TabIndex = 128
        Me.chLateFiling.Text = "Late Filing? :"
        Me.chLateFiling.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 15)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Supposed Work Time-Out* :"
        '
        'dtpSWT
        '
        Me.dtpSWT.CustomFormat = "HH:mm"
        Me.dtpSWT.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSWT.Location = New System.Drawing.Point(174, 75)
        Me.dtpSWT.Name = "dtpSWT"
        Me.dtpSWT.ShowUpDown = True
        Me.dtpSWT.Size = New System.Drawing.Size(119, 23)
        Me.dtpSWT.TabIndex = 125
        '
        'dtpWorkDate
        '
        Me.dtpWorkDate.Location = New System.Drawing.Point(145, 17)
        Me.dtpWorkDate.Name = "dtpWorkDate"
        Me.dtpWorkDate.Size = New System.Drawing.Size(148, 23)
        Me.dtpWorkDate.TabIndex = 124
        '
        'btnClearTextFields
        '
        Me.btnClearTextFields.BackColor = System.Drawing.Color.White
        Me.btnClearTextFields.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnClearTextFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearTextFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTextFields.ForeColor = System.Drawing.Color.Teal
        Me.btnClearTextFields.Location = New System.Drawing.Point(159, 177)
        Me.btnClearTextFields.Name = "btnClearTextFields"
        Me.btnClearTextFields.Size = New System.Drawing.Size(120, 26)
        Me.btnClearTextFields.TabIndex = 117
        Me.btnClearTextFields.Text = "&Clear Fields"
        Me.btnClearTextFields.UseVisualStyleBackColor = False
        '
        'btnAddUndertime
        '
        Me.btnAddUndertime.BackColor = System.Drawing.Color.White
        Me.btnAddUndertime.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnAddUndertime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUndertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUndertime.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAddUndertime.Location = New System.Drawing.Point(33, 177)
        Me.btnAddUndertime.Name = "btnAddUndertime"
        Me.btnAddUndertime.Size = New System.Drawing.Size(120, 26)
        Me.btnAddUndertime.TabIndex = 116
        Me.btnAddUndertime.Text = "&Submit"
        Me.btnAddUndertime.UseVisualStyleBackColor = False
        '
        'dtpEWT
        '
        Me.dtpEWT.CustomFormat = "HH:mm"
        Me.dtpEWT.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEWT.Location = New System.Drawing.Point(173, 46)
        Me.dtpEWT.Name = "dtpEWT"
        Me.dtpEWT.ShowUpDown = True
        Me.dtpEWT.Size = New System.Drawing.Size(120, 23)
        Me.dtpEWT.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(151, 15)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Expected Work Time-Out* :"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(141, 138)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(152, 23)
        Me.txtReason.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Reason for Leaving* :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Expected Leave Day* :"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.PictureBox1)
        Me.Panel8.Controls.Add(Me.PictureBoxHelp)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.lblHeader)
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(343, 51)
        Me.Panel8.TabIndex = 4
        '
        'PictureBoxHelp
        '
        Me.PictureBoxHelp.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.help
        Me.PictureBoxHelp.Location = New System.Drawing.Point(297, 8)
        Me.PictureBoxHelp.Name = "PictureBoxHelp"
        Me.PictureBoxHelp.Size = New System.Drawing.Size(30, 30)
        Me.PictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHelp.TabIndex = 145
        Me.PictureBoxHelp.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Please fill up all fields required to proceed."
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(51, 8)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(153, 20)
        Me.lblHeader.TabIndex = 24
        Me.lblHeader.Text = "Add New Undertime"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 595)
        Me.Panel2.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(333, 41)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 597)
        Me.Panel4.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(-3, 284)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(360, 10)
        Me.Panel5.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.folder
        Me.PictureBox1.Location = New System.Drawing.Point(9, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 146
        Me.PictureBox1.TabStop = False
        '
        'frmTK_AddUpdUnderTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 294)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTK_AddUpdUnderTime"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBoxHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtpDateFiling As DateTimePicker
    Friend WithEvents chLateFiling As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpSWT As DateTimePicker
    Friend WithEvents dtpWorkDate As DateTimePicker
    Friend WithEvents btnClearTextFields As Button
    Friend WithEvents btnAddUndertime As Button
    Friend WithEvents dtpEWT As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBoxHelp As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
