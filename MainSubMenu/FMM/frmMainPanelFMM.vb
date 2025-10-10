Public Class frmMainPanelFMM

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        If HasMenuAccess(btnSetup) Then
            SubMenuLoadAccess(btnSetup)
            For Each btn In {frmMainPanelFMMDetail.btnCompany, frmMainPanelFMMDetail.btnFiscalPeriod, frmMainPanelFMMDetail.btnCashFlowCategory,
                frmMainPanelFMMDetail.btnCostCenter, frmMainPanelFMMDetail.btnAccountCategory, frmMainPanelFMMDetail.btnChartOfAccounts,
                frmMainPanelFMMDetail.btnBankAccounts, frmMainPanelFMMDetail.btnSubsidiary, frmMainPanelFMMDetail.btnSupplier, frmMainPanelFMMDetail.btnTaxRates,
                frmMainPanelFMMDetail.btnItems, frmMainPanelFMMDetail.btnBeginningProject, frmMainPanelFMMDetail.btnBeginningSubsidiaries, frmMainPanelFMMDetail.btnTransactionClosing,
                frmMainPanelFMMDetail.btnYearEndClosing, frmMainPanelFMMDetail.btnApproverSetup, frmMainPanelFMMDetail.btnVoucherStatus, frmMainPanelFMMDetail.btnAccountBalances,
                frmMainPanelFMMDetail.btnAccountMapping}
                btn.Visible = SubMenuAccessList.Contains(btn.Tag?.ToString())
            Next
            SetButtonColor(btnSetup)
            frmMain.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_SetupDetails)
        Else
            Return
        End If
    End Sub

    Private Sub btnProjectStatus_Click(sender As Object, e As EventArgs) Handles btnProjectStatus.Click
        SetButtonColor(btnProjectStatus)
        frmMain.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_ProjectStatusDetails)
    End Sub

    Private Sub btnBudgetManagement_Click(sender As Object, e As EventArgs) Handles btnBudgetManagement.Click
        SetButtonColor(btnBudgetManagement)
        frmMain.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_BudgetManagementDetails)
    End Sub

    Private Sub btnPettyCash_Click(sender As Object, e As EventArgs) Handles btnPettyCash.Click
        SetButtonColor(btnPettyCash)
        frmMain.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_PettyCashDetails)
    End Sub

    Private Sub btnCashAdvance_Click(sender As Object, e As EventArgs) Handles btnCashAdvance.Click
        SetButtonColor(btnCashAdvance)
        frmMain.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_CashAdvanceDetails)
    End Sub

    Private Sub btnCashLedger_Click(sender As Object, e As EventArgs) Handles btnCashLedger.Click
        SetButtonColor(btnCashLedger)
        frmMain.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_CashJournalDetails)
    End Sub

    Private Sub btnGeneralJournal_Click(sender As Object, e As EventArgs) Handles btnGeneralJournal.Click
        SetButtonColor(btnGeneralJournal)
        frmMain.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_GeneralJournalDetails)
    End Sub

    Private Sub btnFinancialStatement_Click(sender As Object, e As EventArgs) Handles btnFinancialStatement.Click
        SetButtonColor(btnFinancialStatement)
        frmMain.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_FinancialStatementsDetails)
    End Sub

    Private Sub btnLedgerReports_Click(sender As Object, e As EventArgs) Handles btnLedgerReports.Click
        SetButtonColor(btnLedgerReports)
        frmMain.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_LedgerReportsDetails)
    End Sub

    Private Sub btnNewReports_Click(sender As Object, e As EventArgs) Handles btnNewReports.Click
        SetButtonColor(btnNewReports)
        frmMain.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_NewReportsDetails)
    End Sub

    Private Sub btnOtherReports_Click(sender As Object, e As EventArgs) Handles btnOtherReports.Click
        SetButtonColor(btnOtherReports)
        frmMain.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_OtherReportsDetails)
    End Sub

End Class