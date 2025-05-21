<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTK_AddUpdOverTime
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
        Me.chActualOvertime = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpWTO = New System.Windows.Forms.DateTimePicker()
        Me.dtpWorkDate = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbOverheadDept = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnClearTextFields = New System.Windows.Forms.Button()
        Me.btnAddOfficialBusiness = New System.Windows.Forms.Button()
        Me.cbProjectName = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpWTI = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDetailsWork = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Size = New System.Drawing.Size(343, 379)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.dtpDateFiling)
        Me.Panel3.Controls.Add(Me.chActualOvertime)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.dtpWTO)
        Me.Panel3.Controls.Add(Me.dtpWorkDate)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.cbOverheadDept)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.btnClearTextFields)
        Me.Panel3.Controls.Add(Me.btnAddOfficialBusiness)
        Me.Panel3.Controls.Add(Me.cbProjectName)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.dtpWTI)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtDetailsWork)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(16, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(311, 306)
        Me.Panel3.TabIndex = 6
        '
        'dtpDateFiling
        '
        Me.dtpDateFiling.Enabled = False
        Me.dtpDateFiling.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFiling.Location = New System.Drawing.Point(149, 194)
        Me.dtpDateFiling.Name = "dtpDateFiling"
        Me.dtpDateFiling.Size = New System.Drawing.Size(144, 23)
        Me.dtpDateFiling.TabIndex = 129
        '
        'chActualOvertime
        '
        Me.chActualOvertime.AutoSize = True
        Me.chActualOvertime.Checked = True
        Me.chActualOvertime.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chActualOvertime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chActualOvertime.Location = New System.Drawing.Point(20, 197)
        Me.chActualOvertime.Name = "chActualOvertime"
        Me.chActualOvertime.Size = New System.Drawing.Size(123, 19)
        Me.chActualOvertime.TabIndex = 128
        Me.chActualOvertime.Text = "Actual Overtime? :"
        Me.chActualOvertime.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 15)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Expected Work Time-Out* :"
        '
        'dtpWTO
        '
        Me.dtpWTO.CustomFormat = "HH:mm"
        Me.dtpWTO.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpWTO.Location = New System.Drawing.Point(174, 75)
        Me.dtpWTO.Name = "dtpWTO"
        Me.dtpWTO.ShowUpDown = True
        Me.dtpWTO.Size = New System.Drawing.Size(119, 23)
        Me.dtpWTO.TabIndex = 125
        '
        'dtpWorkDate
        '
        Me.dtpWorkDate.Location = New System.Drawing.Point(143, 17)
        Me.dtpWorkDate.Name = "dtpWorkDate"
        Me.dtpWorkDate.Size = New System.Drawing.Size(150, 23)
        Me.dtpWorkDate.TabIndex = 124
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 15)
        Me.Label17.TabIndex = 123
        Me.Label17.Text = "Overhead/Dep't* :"
        '
        'cbOverheadDept
        '
        Me.cbOverheadDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOverheadDept.DropDownWidth = 260
        Me.cbOverheadDept.FormattingEnabled = True
        Me.cbOverheadDept.Location = New System.Drawing.Point(125, 136)
        Me.cbOverheadDept.Name = "cbOverheadDept"
        Me.cbOverheadDept.Size = New System.Drawing.Size(169, 23)
        Me.cbOverheadDept.TabIndex = 122
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 168)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 15)
        Me.Label16.TabIndex = 121
        Me.Label16.Text = "Project Name* :"
        '
        'btnClearTextFields
        '
        Me.btnClearTextFields.BackColor = System.Drawing.Color.White
        Me.btnClearTextFields.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnClearTextFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearTextFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTextFields.ForeColor = System.Drawing.Color.Teal
        Me.btnClearTextFields.Location = New System.Drawing.Point(159, 262)
        Me.btnClearTextFields.Name = "btnClearTextFields"
        Me.btnClearTextFields.Size = New System.Drawing.Size(120, 26)
        Me.btnClearTextFields.TabIndex = 117
        Me.btnClearTextFields.Text = "&Clear Fields"
        Me.btnClearTextFields.UseVisualStyleBackColor = False
        '
        'btnAddOfficialBusiness
        '
        Me.btnAddOfficialBusiness.BackColor = System.Drawing.Color.White
        Me.btnAddOfficialBusiness.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnAddOfficialBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddOfficialBusiness.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOfficialBusiness.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAddOfficialBusiness.Location = New System.Drawing.Point(33, 262)
        Me.btnAddOfficialBusiness.Name = "btnAddOfficialBusiness"
        Me.btnAddOfficialBusiness.Size = New System.Drawing.Size(120, 26)
        Me.btnAddOfficialBusiness.TabIndex = 116
        Me.btnAddOfficialBusiness.Text = "&Submit"
        Me.btnAddOfficialBusiness.UseVisualStyleBackColor = False
        '
        'cbProjectName
        '
        Me.cbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProjectName.DropDownWidth = 285
        Me.cbProjectName.FormattingEnabled = True
        Me.cbProjectName.Location = New System.Drawing.Point(125, 165)
        Me.cbProjectName.Name = "cbProjectName"
        Me.cbProjectName.Size = New System.Drawing.Size(168, 23)
        Me.cbProjectName.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 15)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "This is charge to :"
        '
        'dtpWTI
        '
        Me.dtpWTI.CustomFormat = "HH:mm"
        Me.dtpWTI.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpWTI.Location = New System.Drawing.Point(173, 46)
        Me.dtpWTI.Name = "dtpWTI"
        Me.dtpWTI.ShowUpDown = True
        Me.dtpWTI.Size = New System.Drawing.Size(120, 23)
        Me.dtpWTI.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 15)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Expected Work Time-In* :"
        '
        'txtDetailsWork
        '
        Me.txtDetailsWork.Location = New System.Drawing.Point(125, 223)
        Me.txtDetailsWork.Name = "txtDetailsWork"
        Me.txtDetailsWork.Size = New System.Drawing.Size(169, 23)
        Me.txtDetailsWork.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Details of Work* :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Expected Work Day* :"
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
        Me.Label7.Location = New System.Drawing.Point(52, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Please fill up all fields required to proceed."
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(52, 10)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(143, 20)
        Me.lblHeader.TabIndex = 24
        Me.lblHeader.Text = "Add New Overtime"
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
        Me.Panel5.Location = New System.Drawing.Point(3, 369)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(341, 10)
        Me.Panel5.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.folder
        Me.PictureBox1.Location = New System.Drawing.Point(10, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 146
        Me.PictureBox1.TabStop = False
        '
        'frmTK_AddUpdOverTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 379)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTK_AddUpdOverTime"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OT"
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
    Friend WithEvents Label17 As Label
    Friend WithEvents cbOverheadDept As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnClearTextFields As Button
    Friend WithEvents btnAddOfficialBusiness As Button
    Friend WithEvents cbProjectName As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpWTI As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDetailsWork As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dtpWorkDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpWTO As DateTimePicker
    Friend WithEvents dtpDateFiling As DateTimePicker
    Friend WithEvents chActualOvertime As CheckBox
    Friend WithEvents PictureBoxHelp As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
