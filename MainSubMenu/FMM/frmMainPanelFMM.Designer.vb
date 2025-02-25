<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainPanelFMM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPanelFMM))
        Me.PanelFMM = New System.Windows.Forms.Panel()
        Me.btn = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCashFlow = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.btnOtherReports = New System.Windows.Forms.Button()
        Me.btnNewReports = New System.Windows.Forms.Button()
        Me.btnLedgerReports = New System.Windows.Forms.Button()
        Me.btnFinancialStatement = New System.Windows.Forms.Button()
        Me.btnGeneralJournal = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnCashLedger = New System.Windows.Forms.Button()
        Me.btnCashAdvance = New System.Windows.Forms.Button()
        Me.btnPettyCash = New System.Windows.Forms.Button()
        Me.btnBudgetManagement = New System.Windows.Forms.Button()
        Me.btnProjectStatus = New System.Windows.Forms.Button()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.PanelFMM.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelFMM
        '
        Me.PanelFMM.AutoScroll = True
        Me.PanelFMM.BackColor = System.Drawing.Color.White
        Me.PanelFMM.Controls.Add(Me.btn)
        Me.PanelFMM.Controls.Add(Me.btnCashFlow)
        Me.PanelFMM.Controls.Add(Me.Button12)
        Me.PanelFMM.Controls.Add(Me.Button11)
        Me.PanelFMM.Controls.Add(Me.btnOtherReports)
        Me.PanelFMM.Controls.Add(Me.btnNewReports)
        Me.PanelFMM.Controls.Add(Me.btnLedgerReports)
        Me.PanelFMM.Controls.Add(Me.btnFinancialStatement)
        Me.PanelFMM.Controls.Add(Me.btnGeneralJournal)
        Me.PanelFMM.Controls.Add(Me.Button5)
        Me.PanelFMM.Controls.Add(Me.btnCashLedger)
        Me.PanelFMM.Controls.Add(Me.btnCashAdvance)
        Me.PanelFMM.Controls.Add(Me.btnPettyCash)
        Me.PanelFMM.Controls.Add(Me.btnBudgetManagement)
        Me.PanelFMM.Controls.Add(Me.btnProjectStatus)
        Me.PanelFMM.Controls.Add(Me.btnSetup)
        Me.PanelFMM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFMM.Location = New System.Drawing.Point(0, 0)
        Me.PanelFMM.Name = "PanelFMM"
        Me.PanelFMM.Size = New System.Drawing.Size(265, 650)
        Me.PanelFMM.TabIndex = 1
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.Color.White
        Me.btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn.FlatAppearance.BorderSize = 0
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.ForeColor = System.Drawing.Color.Black
        Me.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn.ImageIndex = 15
        Me.btn.ImageList = Me.ImageList1
        Me.btn.Location = New System.Drawing.Point(0, 598)
        Me.btn.Name = "btn"
        Me.btn.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btn.Size = New System.Drawing.Size(265, 42)
        Me.btn.TabIndex = 32
        Me.btn.Text = "   Options"
        Me.btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "setup.png")
        Me.ImageList1.Images.SetKeyName(1, "budgetman.png")
        Me.ImageList1.Images.SetKeyName(2, "pttycsh.png")
        Me.ImageList1.Images.SetKeyName(3, "purlegder.png")
        Me.ImageList1.Images.SetKeyName(4, "chledger.png")
        Me.ImageList1.Images.SetKeyName(5, "invoice.png")
        Me.ImageList1.Images.SetKeyName(6, "receiptledger.png")
        Me.ImageList1.Images.SetKeyName(7, "finstatement.png")
        Me.ImageList1.Images.SetKeyName(8, "genledger.png")
        Me.ImageList1.Images.SetKeyName(9, "otherreports.png")
        Me.ImageList1.Images.SetKeyName(10, "reports.png")
        Me.ImageList1.Images.SetKeyName(11, "bank.png")
        Me.ImageList1.Images.SetKeyName(12, "housemonitoring.png")
        Me.ImageList1.Images.SetKeyName(13, "cashflow.png")
        Me.ImageList1.Images.SetKeyName(14, "timemon.png")
        Me.ImageList1.Images.SetKeyName(15, "options.png")
        '
        'btnCashFlow
        '
        Me.btnCashFlow.BackColor = System.Drawing.Color.White
        Me.btnCashFlow.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCashFlow.FlatAppearance.BorderSize = 0
        Me.btnCashFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCashFlow.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashFlow.ForeColor = System.Drawing.Color.Black
        Me.btnCashFlow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashFlow.ImageIndex = 13
        Me.btnCashFlow.ImageList = Me.ImageList1
        Me.btnCashFlow.Location = New System.Drawing.Point(0, 556)
        Me.btnCashFlow.Name = "btnCashFlow"
        Me.btnCashFlow.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnCashFlow.Size = New System.Drawing.Size(265, 42)
        Me.btnCashFlow.TabIndex = 31
        Me.btnCashFlow.Text = "   Cash Flow"
        Me.btnCashFlow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashFlow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCashFlow.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.ImageIndex = 12
        Me.Button12.ImageList = Me.ImageList1
        Me.Button12.Location = New System.Drawing.Point(0, 514)
        Me.Button12.Name = "Button12"
        Me.Button12.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.Button12.Size = New System.Drawing.Size(265, 42)
        Me.Button12.TabIndex = 30
        Me.Button12.Text = "   In-House Budget Monitoring"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.ImageIndex = 11
        Me.Button11.ImageList = Me.ImageList1
        Me.Button11.Location = New System.Drawing.Point(0, 472)
        Me.Button11.Name = "Button11"
        Me.Button11.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.Button11.Size = New System.Drawing.Size(265, 42)
        Me.Button11.TabIndex = 29
        Me.Button11.Text = "   Bank Recon"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button11.UseVisualStyleBackColor = False
        '
        'btnOtherReports
        '
        Me.btnOtherReports.BackColor = System.Drawing.Color.White
        Me.btnOtherReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOtherReports.FlatAppearance.BorderSize = 0
        Me.btnOtherReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOtherReports.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtherReports.ForeColor = System.Drawing.Color.Black
        Me.btnOtherReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOtherReports.ImageIndex = 9
        Me.btnOtherReports.ImageList = Me.ImageList1
        Me.btnOtherReports.Location = New System.Drawing.Point(0, 430)
        Me.btnOtherReports.Name = "btnOtherReports"
        Me.btnOtherReports.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnOtherReports.Size = New System.Drawing.Size(265, 42)
        Me.btnOtherReports.TabIndex = 28
        Me.btnOtherReports.Text = "   Other Reports"
        Me.btnOtherReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOtherReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOtherReports.UseVisualStyleBackColor = False
        '
        'btnNewReports
        '
        Me.btnNewReports.BackColor = System.Drawing.Color.White
        Me.btnNewReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewReports.FlatAppearance.BorderSize = 0
        Me.btnNewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewReports.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewReports.ForeColor = System.Drawing.Color.Black
        Me.btnNewReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewReports.ImageIndex = 10
        Me.btnNewReports.ImageList = Me.ImageList1
        Me.btnNewReports.Location = New System.Drawing.Point(0, 388)
        Me.btnNewReports.Name = "btnNewReports"
        Me.btnNewReports.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnNewReports.Size = New System.Drawing.Size(265, 42)
        Me.btnNewReports.TabIndex = 27
        Me.btnNewReports.Text = "   New Reports"
        Me.btnNewReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewReports.UseVisualStyleBackColor = False
        '
        'btnLedgerReports
        '
        Me.btnLedgerReports.BackColor = System.Drawing.Color.White
        Me.btnLedgerReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLedgerReports.FlatAppearance.BorderSize = 0
        Me.btnLedgerReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLedgerReports.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLedgerReports.ForeColor = System.Drawing.Color.Black
        Me.btnLedgerReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLedgerReports.ImageIndex = 8
        Me.btnLedgerReports.ImageList = Me.ImageList1
        Me.btnLedgerReports.Location = New System.Drawing.Point(0, 346)
        Me.btnLedgerReports.Name = "btnLedgerReports"
        Me.btnLedgerReports.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnLedgerReports.Size = New System.Drawing.Size(265, 42)
        Me.btnLedgerReports.TabIndex = 26
        Me.btnLedgerReports.Text = "   Ledger Reports"
        Me.btnLedgerReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLedgerReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLedgerReports.UseVisualStyleBackColor = False
        '
        'btnFinancialStatement
        '
        Me.btnFinancialStatement.BackColor = System.Drawing.Color.White
        Me.btnFinancialStatement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFinancialStatement.FlatAppearance.BorderSize = 0
        Me.btnFinancialStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinancialStatement.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinancialStatement.ForeColor = System.Drawing.Color.Black
        Me.btnFinancialStatement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinancialStatement.ImageIndex = 7
        Me.btnFinancialStatement.ImageList = Me.ImageList1
        Me.btnFinancialStatement.Location = New System.Drawing.Point(0, 308)
        Me.btnFinancialStatement.Name = "btnFinancialStatement"
        Me.btnFinancialStatement.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnFinancialStatement.Size = New System.Drawing.Size(265, 38)
        Me.btnFinancialStatement.TabIndex = 25
        Me.btnFinancialStatement.Text = "   Financial Statements"
        Me.btnFinancialStatement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinancialStatement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFinancialStatement.UseVisualStyleBackColor = False
        '
        'btnGeneralJournal
        '
        Me.btnGeneralJournal.BackColor = System.Drawing.Color.White
        Me.btnGeneralJournal.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGeneralJournal.FlatAppearance.BorderSize = 0
        Me.btnGeneralJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneralJournal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneralJournal.ForeColor = System.Drawing.Color.Black
        Me.btnGeneralJournal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneralJournal.ImageIndex = 6
        Me.btnGeneralJournal.ImageList = Me.ImageList1
        Me.btnGeneralJournal.Location = New System.Drawing.Point(0, 270)
        Me.btnGeneralJournal.Name = "btnGeneralJournal"
        Me.btnGeneralJournal.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnGeneralJournal.Size = New System.Drawing.Size(265, 38)
        Me.btnGeneralJournal.TabIndex = 24
        Me.btnGeneralJournal.Text = "   General Journal"
        Me.btnGeneralJournal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneralJournal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGeneralJournal.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.ImageIndex = 5
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(0, 232)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(265, 38)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "   Sales Journal"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnCashLedger
        '
        Me.btnCashLedger.BackColor = System.Drawing.Color.White
        Me.btnCashLedger.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCashLedger.FlatAppearance.BorderSize = 0
        Me.btnCashLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCashLedger.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashLedger.ForeColor = System.Drawing.Color.Black
        Me.btnCashLedger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashLedger.ImageIndex = 4
        Me.btnCashLedger.ImageList = Me.ImageList1
        Me.btnCashLedger.Location = New System.Drawing.Point(0, 194)
        Me.btnCashLedger.Name = "btnCashLedger"
        Me.btnCashLedger.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnCashLedger.Size = New System.Drawing.Size(265, 38)
        Me.btnCashLedger.TabIndex = 22
        Me.btnCashLedger.Text = "   Cash Journal"
        Me.btnCashLedger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashLedger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCashLedger.UseVisualStyleBackColor = False
        '
        'btnCashAdvance
        '
        Me.btnCashAdvance.BackColor = System.Drawing.Color.White
        Me.btnCashAdvance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCashAdvance.FlatAppearance.BorderSize = 0
        Me.btnCashAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCashAdvance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashAdvance.ForeColor = System.Drawing.Color.Black
        Me.btnCashAdvance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashAdvance.ImageIndex = 3
        Me.btnCashAdvance.ImageList = Me.ImageList1
        Me.btnCashAdvance.Location = New System.Drawing.Point(0, 156)
        Me.btnCashAdvance.Name = "btnCashAdvance"
        Me.btnCashAdvance.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnCashAdvance.Size = New System.Drawing.Size(265, 38)
        Me.btnCashAdvance.TabIndex = 21
        Me.btnCashAdvance.Text = "   Cash Advance"
        Me.btnCashAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashAdvance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCashAdvance.UseVisualStyleBackColor = False
        '
        'btnPettyCash
        '
        Me.btnPettyCash.BackColor = System.Drawing.Color.White
        Me.btnPettyCash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPettyCash.FlatAppearance.BorderSize = 0
        Me.btnPettyCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPettyCash.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPettyCash.ForeColor = System.Drawing.Color.Black
        Me.btnPettyCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPettyCash.ImageIndex = 2
        Me.btnPettyCash.ImageList = Me.ImageList1
        Me.btnPettyCash.Location = New System.Drawing.Point(0, 118)
        Me.btnPettyCash.Name = "btnPettyCash"
        Me.btnPettyCash.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnPettyCash.Size = New System.Drawing.Size(265, 38)
        Me.btnPettyCash.TabIndex = 20
        Me.btnPettyCash.Text = "   Petty Cash"
        Me.btnPettyCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPettyCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPettyCash.UseVisualStyleBackColor = False
        '
        'btnBudgetManagement
        '
        Me.btnBudgetManagement.BackColor = System.Drawing.Color.White
        Me.btnBudgetManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBudgetManagement.FlatAppearance.BorderSize = 0
        Me.btnBudgetManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBudgetManagement.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBudgetManagement.ForeColor = System.Drawing.Color.Black
        Me.btnBudgetManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBudgetManagement.ImageIndex = 1
        Me.btnBudgetManagement.ImageList = Me.ImageList1
        Me.btnBudgetManagement.Location = New System.Drawing.Point(0, 80)
        Me.btnBudgetManagement.Name = "btnBudgetManagement"
        Me.btnBudgetManagement.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnBudgetManagement.Size = New System.Drawing.Size(265, 38)
        Me.btnBudgetManagement.TabIndex = 19
        Me.btnBudgetManagement.Text = "   Bugdget Management"
        Me.btnBudgetManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBudgetManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBudgetManagement.UseVisualStyleBackColor = False
        '
        'btnProjectStatus
        '
        Me.btnProjectStatus.BackColor = System.Drawing.Color.White
        Me.btnProjectStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProjectStatus.FlatAppearance.BorderSize = 0
        Me.btnProjectStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProjectStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjectStatus.ForeColor = System.Drawing.Color.Black
        Me.btnProjectStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProjectStatus.ImageIndex = 14
        Me.btnProjectStatus.ImageList = Me.ImageList1
        Me.btnProjectStatus.Location = New System.Drawing.Point(0, 38)
        Me.btnProjectStatus.Name = "btnProjectStatus"
        Me.btnProjectStatus.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnProjectStatus.Size = New System.Drawing.Size(265, 42)
        Me.btnProjectStatus.TabIndex = 18
        Me.btnProjectStatus.Text = "   Project Status"
        Me.btnProjectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProjectStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProjectStatus.UseVisualStyleBackColor = False
        '
        'btnSetup
        '
        Me.btnSetup.BackColor = System.Drawing.Color.White
        Me.btnSetup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSetup.FlatAppearance.BorderSize = 0
        Me.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetup.ForeColor = System.Drawing.Color.Black
        Me.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetup.ImageIndex = 0
        Me.btnSetup.ImageList = Me.ImageList1
        Me.btnSetup.Location = New System.Drawing.Point(0, 0)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnSetup.Size = New System.Drawing.Size(265, 38)
        Me.btnSetup.TabIndex = 4
        Me.btnSetup.Text = "   Setup"
        Me.btnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetup.UseVisualStyleBackColor = False
        '
        'frmMainPanelFMM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 650)
        Me.Controls.Add(Me.PanelFMM)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainPanelFMM"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmMainPanelFMM"
        Me.PanelFMM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelFMM As Panel
    Friend WithEvents btn As Button
    Friend WithEvents btnCashFlow As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents btnOtherReports As Button
    Friend WithEvents btnNewReports As Button
    Friend WithEvents btnLedgerReports As Button
    Friend WithEvents btnFinancialStatement As Button
    Friend WithEvents btnGeneralJournal As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnCashLedger As Button
    Friend WithEvents btnCashAdvance As Button
    Friend WithEvents btnPettyCash As Button
    Friend WithEvents btnBudgetManagement As Button
    Friend WithEvents btnProjectStatus As Button
    Friend WithEvents btnSetup As Button
    Friend WithEvents ImageList1 As ImageList
End Class
