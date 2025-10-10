<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFMIS_Setup_AddUpdChartOfAccounts
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCashFlow = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chContra = New System.Windows.Forms.CheckBox()
        Me.chActive = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lblHeader)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 70)
        Me.Panel2.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDCOP_Project_Monitoring_System.My.Resources.Resources.folder
        Me.PictureBox1.Location = New System.Drawing.Point(14, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(64, 18)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(189, 20)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Add New Level 1 Account"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(226, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Fill-up all entry box then click &Save button."
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.btnReset)
        Me.Panel5.Controls.Add(Me.btnDiscard)
        Me.Panel5.Controls.Add(Me.btnSave)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 369)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(356, 61)
        Me.Panel5.TabIndex = 76
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.White
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Maroon
        Me.btnReset.Location = New System.Drawing.Point(10, 18)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(81, 24)
        Me.btnReset.TabIndex = 105
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnDiscard
        '
        Me.btnDiscard.BackColor = System.Drawing.Color.White
        Me.btnDiscard.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscard.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscard.ForeColor = System.Drawing.Color.DarkGray
        Me.btnDiscard.Location = New System.Drawing.Point(178, 18)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(81, 24)
        Me.btnDiscard.TabIndex = 104
        Me.btnDiscard.Text = "&Discard "
        Me.btnDiscard.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(265, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 24)
        Me.btnSave.TabIndex = 103
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 299)
        Me.Panel4.TabIndex = 77
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(346, 70)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 299)
        Me.Panel6.TabIndex = 83
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gray
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(10, 70)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(336, 3)
        Me.Panel7.TabIndex = 126
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gray
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(10, 73)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(3, 296)
        Me.Panel8.TabIndex = 127
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Gray
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(343, 73)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(3, 296)
        Me.Panel9.TabIndex = 129
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gray
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(13, 366)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(330, 3)
        Me.Panel10.TabIndex = 130
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCode.Cursor = System.Windows.Forms.Cursors.No
        Me.txtCode.Location = New System.Drawing.Point(132, 128)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(192, 22)
        Me.txtCode.TabIndex = 146
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Remarks* :"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(132, 244)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(192, 37)
        Me.txtRemarks.TabIndex = 144
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Beginning Balance* :"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(154, 215)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(170, 22)
        Me.txtBalance.TabIndex = 142
        Me.txtBalance.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Cash Flow Category* :"
        '
        'cbCashFlow
        '
        Me.cbCashFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCashFlow.FormattingEnabled = True
        Me.cbCashFlow.Location = New System.Drawing.Point(154, 186)
        Me.cbCashFlow.Name = "cbCashFlow"
        Me.cbCashFlow.Size = New System.Drawing.Size(170, 21)
        Me.cbCashFlow.TabIndex = 140
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Account Title* :"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(132, 157)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(192, 22)
        Me.txtTitle.TabIndex = 138
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chContra)
        Me.GroupBox1.Controls.Add(Me.chActive)
        Me.GroupBox1.Location = New System.Drawing.Point(78, 289)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 52)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'chContra
        '
        Me.chContra.AutoSize = True
        Me.chContra.Location = New System.Drawing.Point(130, 22)
        Me.chContra.Name = "chContra"
        Me.chContra.Size = New System.Drawing.Size(106, 17)
        Me.chContra.TabIndex = 122
        Me.chContra.Text = "Contra Account"
        Me.chContra.UseVisualStyleBackColor = True
        '
        'chActive
        '
        Me.chActive.AutoSize = True
        Me.chActive.Location = New System.Drawing.Point(10, 22)
        Me.chActive.Name = "chActive"
        Me.chActive.Size = New System.Drawing.Size(101, 17)
        Me.chActive.TabIndex = 121
        Me.chActive.Text = "Account Active"
        Me.chActive.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Account Type* :"
        '
        'txtType
        '
        Me.txtType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtType.Cursor = System.Windows.Forms.Cursors.No
        Me.txtType.Location = New System.Drawing.Point(132, 99)
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.Size = New System.Drawing.Size(192, 22)
        Me.txtType.TabIndex = 135
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Account Code* :"
        '
        'frmFMIS_Setup_AddUpdChartOfAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(356, 430)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbCashFlow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFMIS_Setup_AddUpdChartOfAccounts"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDiscard As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCashFlow As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chContra As CheckBox
    Friend WithEvents chActive As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label5 As Label
End Class
