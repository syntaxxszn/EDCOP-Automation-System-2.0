<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFMIS_Setup_AddUpdSupplierAccount
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbZero = New System.Windows.Forms.RadioButton()
        Me.rbVat = New System.Windows.Forms.RadioButton()
        Me.rbNonVat = New System.Windows.Forms.RadioButton()
        Me.chAccredited = New System.Windows.Forms.CheckBox()
        Me.chDocumented = New System.Windows.Forms.CheckBox()
        Me.chActive = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTIN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel2.TabIndex = 16
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
        Me.lblHeader.Size = New System.Drawing.Size(172, 20)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Add New Supplier Type"
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
        Me.Panel5.Location = New System.Drawing.Point(0, 399)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(356, 61)
        Me.Panel5.TabIndex = 80
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
        Me.Panel4.Size = New System.Drawing.Size(10, 329)
        Me.Panel4.TabIndex = 81
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(346, 70)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 329)
        Me.Panel6.TabIndex = 87
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gray
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(10, 70)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(336, 3)
        Me.Panel7.TabIndex = 130
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gray
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(10, 73)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(3, 326)
        Me.Panel8.TabIndex = 131
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Gray
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(343, 73)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(3, 326)
        Me.Panel9.TabIndex = 135
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gray
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(13, 396)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(330, 3)
        Me.Panel10.TabIndex = 136
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbZero)
        Me.GroupBox1.Controls.Add(Me.rbVat)
        Me.GroupBox1.Controls.Add(Me.rbNonVat)
        Me.GroupBox1.Controls.Add(Me.chAccredited)
        Me.GroupBox1.Controls.Add(Me.chDocumented)
        Me.GroupBox1.Controls.Add(Me.chActive)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 82)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'rbZero
        '
        Me.rbZero.AutoSize = True
        Me.rbZero.Location = New System.Drawing.Point(193, 49)
        Me.rbZero.Name = "rbZero"
        Me.rbZero.Size = New System.Drawing.Size(81, 17)
        Me.rbZero.TabIndex = 147
        Me.rbZero.TabStop = True
        Me.rbZero.Text = "Zero Rated"
        Me.rbZero.UseVisualStyleBackColor = True
        '
        'rbVat
        '
        Me.rbVat.AutoSize = True
        Me.rbVat.Location = New System.Drawing.Point(119, 49)
        Me.rbVat.Name = "rbVat"
        Me.rbVat.Size = New System.Drawing.Size(67, 17)
        Me.rbVat.TabIndex = 146
        Me.rbVat.TabStop = True
        Me.rbVat.Text = "VAT REG"
        Me.rbVat.UseVisualStyleBackColor = True
        '
        'rbNonVat
        '
        Me.rbNonVat.AutoSize = True
        Me.rbNonVat.Location = New System.Drawing.Point(15, 49)
        Me.rbNonVat.Name = "rbNonVat"
        Me.rbNonVat.Size = New System.Drawing.Size(95, 17)
        Me.rbNonVat.TabIndex = 145
        Me.rbNonVat.TabStop = True
        Me.rbNonVat.Text = "NON VAT REG"
        Me.rbNonVat.UseVisualStyleBackColor = True
        '
        'chAccredited
        '
        Me.chAccredited.AutoSize = True
        Me.chAccredited.Location = New System.Drawing.Point(195, 23)
        Me.chAccredited.Name = "chAccredited"
        Me.chAccredited.Size = New System.Drawing.Size(80, 17)
        Me.chAccredited.TabIndex = 2
        Me.chAccredited.Text = "Accredited"
        Me.chAccredited.UseVisualStyleBackColor = True
        '
        'chDocumented
        '
        Me.chDocumented.AutoSize = True
        Me.chDocumented.Location = New System.Drawing.Point(91, 24)
        Me.chDocumented.Name = "chDocumented"
        Me.chDocumented.Size = New System.Drawing.Size(92, 17)
        Me.chDocumented.TabIndex = 1
        Me.chDocumented.Text = "Documented"
        Me.chDocumented.UseVisualStyleBackColor = True
        '
        'chActive
        '
        Me.chActive.AutoSize = True
        Me.chActive.Location = New System.Drawing.Point(15, 24)
        Me.chActive.Name = "chActive"
        Me.chActive.Size = New System.Drawing.Size(56, 17)
        Me.chActive.TabIndex = 0
        Me.chActive.Text = "Active"
        Me.chActive.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "Contact Number :"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(147, 239)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(172, 22)
        Me.txtContactNumber.TabIndex = 179
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 178
        Me.Label6.Text = "Contact Person :"
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Location = New System.Drawing.Point(147, 211)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(172, 22)
        Me.txtContactPerson.TabIndex = 177
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 176
        Me.Label5.Text = "Tax Iden. Num.:"
        '
        'txtTIN
        '
        Me.txtTIN.Location = New System.Drawing.Point(147, 183)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Size = New System.Drawing.Size(172, 22)
        Me.txtTIN.TabIndex = 175
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Address :"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(147, 155)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(172, 22)
        Me.txtAddress.TabIndex = 173
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Beginning Balance :"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(147, 267)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(172, 22)
        Me.txtBalance.TabIndex = 171
        Me.txtBalance.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "Subsidiary Name* :"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(147, 127)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(172, 22)
        Me.txtTitle.TabIndex = 169
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(147, 99)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(172, 22)
        Me.txtCode.TabIndex = 168
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Subsidiary Code* :"
        '
        'frmFMIS_Setup_AddUpdSupplierAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 460)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtContactPerson)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTIN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
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
        Me.Name = "frmFMIS_Setup_AddUpdSupplierAccount"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbZero As RadioButton
    Friend WithEvents rbVat As RadioButton
    Friend WithEvents rbNonVat As RadioButton
    Friend WithEvents chAccredited As CheckBox
    Friend WithEvents chDocumented As CheckBox
    Friend WithEvents chActive As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtContactPerson As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTIN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label1 As Label
End Class
