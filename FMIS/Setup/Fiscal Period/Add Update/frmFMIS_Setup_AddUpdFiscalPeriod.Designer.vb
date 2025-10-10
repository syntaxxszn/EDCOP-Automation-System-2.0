<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFMIS_Setup_AddUpdFiscalPeriod
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTaxForm = New System.Windows.Forms.ComboBox()
        Me.dtpTaxEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTaxStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFiscalEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFiscalStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(362, 70)
        Me.Panel2.TabIndex = 8
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
        Me.lblHeader.Size = New System.Drawing.Size(165, 20)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Add New Fiscal Period"
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
        Me.Panel5.Location = New System.Drawing.Point(0, 255)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(362, 61)
        Me.Panel5.TabIndex = 72
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
        Me.btnDiscard.Location = New System.Drawing.Point(184, 18)
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
        Me.btnSave.Location = New System.Drawing.Point(271, 18)
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
        Me.Panel4.Size = New System.Drawing.Size(10, 185)
        Me.Panel4.TabIndex = 73
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(352, 70)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 185)
        Me.Panel6.TabIndex = 74
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gray
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(10, 70)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(342, 3)
        Me.Panel7.TabIndex = 75
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gray
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(10, 73)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(3, 182)
        Me.Panel8.TabIndex = 76
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Gray
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(349, 73)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(3, 182)
        Me.Panel9.TabIndex = 77
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gray
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(13, 252)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(336, 3)
        Me.Panel10.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "Tax Form* :"
        '
        'cbTaxForm
        '
        Me.cbTaxForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTaxForm.DropDownWidth = 350
        Me.cbTaxForm.FormattingEnabled = True
        Me.cbTaxForm.Location = New System.Drawing.Point(106, 209)
        Me.cbTaxForm.Name = "cbTaxForm"
        Me.cbTaxForm.Size = New System.Drawing.Size(222, 21)
        Me.cbTaxForm.TabIndex = 162
        '
        'dtpTaxEndDate
        '
        Me.dtpTaxEndDate.Location = New System.Drawing.Point(178, 180)
        Me.dtpTaxEndDate.Name = "dtpTaxEndDate"
        Me.dtpTaxEndDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpTaxEndDate.TabIndex = 161
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Tax Year End Date* :"
        '
        'dtpTaxStartDate
        '
        Me.dtpTaxStartDate.Location = New System.Drawing.Point(178, 151)
        Me.dtpTaxStartDate.Name = "dtpTaxStartDate"
        Me.dtpTaxStartDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpTaxStartDate.TabIndex = 159
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Tax Year Start Date* :"
        '
        'dtpFiscalEndDate
        '
        Me.dtpFiscalEndDate.Location = New System.Drawing.Point(178, 122)
        Me.dtpFiscalEndDate.Name = "dtpFiscalEndDate"
        Me.dtpFiscalEndDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpFiscalEndDate.TabIndex = 157
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Fiscal Period End Date* :"
        '
        'dtpFiscalStartDate
        '
        Me.dtpFiscalStartDate.Location = New System.Drawing.Point(178, 93)
        Me.dtpFiscalStartDate.Name = "dtpFiscalStartDate"
        Me.dtpFiscalStartDate.Size = New System.Drawing.Size(150, 22)
        Me.dtpFiscalStartDate.TabIndex = 155
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Fiscal Period Start Date* :"
        '
        'frmFMIS_Setup_AddUpdFiscalPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 316)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbTaxForm)
        Me.Controls.Add(Me.dtpTaxEndDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTaxStartDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFiscalEndDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFiscalStartDate)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFMIS_Setup_AddUpdFiscalPeriod"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiscal Period"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTaxForm As ComboBox
    Friend WithEvents dtpTaxEndDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTaxStartDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFiscalEndDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFiscalStartDate As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
