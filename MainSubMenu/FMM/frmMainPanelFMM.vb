Public Class frmMainPanelFMM

    Private BtnColorText As Button = Nothing

    Private Sub SetButtonColor(newClickedBtn As Button)
        If BtnColorText IsNot Nothing Then
            BtnColorText.BackColor = Color.White
        End If
        newClickedBtn.BackColor = Color.Gainsboro
        BtnColorText = newClickedBtn
    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        SetButtonColor(btnSetup)
        frmMain_revise.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_SetupDetails)
    End Sub

    Private Sub btnProjectStatus_Click(sender As Object, e As EventArgs) Handles btnProjectStatus.Click
        SetButtonColor(btnProjectStatus)
        frmMain_revise.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_ProjectStatusDetails)
    End Sub

    Private Sub btnBudgetManagement_Click(sender As Object, e As EventArgs) Handles btnBudgetManagement.Click
        SetButtonColor(btnBudgetManagement)
        frmMain_revise.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_BudgetManagementDetails)
    End Sub

    Private Sub btnPettyCash_Click(sender As Object, e As EventArgs) Handles btnPettyCash.Click
        SetButtonColor(btnPettyCash)
        frmMain_revise.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_PettyCashDetails)
    End Sub

    Private Sub btnCashAdvance_Click(sender As Object, e As EventArgs) Handles btnCashAdvance.Click
        SetButtonColor(btnCashAdvance)
        frmMain_revise.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_CashAdvanceDetails)
    End Sub

    Private Sub btnCashLedger_Click(sender As Object, e As EventArgs) Handles btnCashLedger.Click
        SetButtonColor(btnCashLedger)
        frmMain_revise.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_CashJournalDetails)
    End Sub

    Private Sub btnGeneralJournal_Click(sender As Object, e As EventArgs) Handles btnGeneralJournal.Click
        SetButtonColor(btnGeneralJournal)
        frmMain_revise.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_GeneralJournalDetails)
    End Sub

    Private Sub btnFinancialStatement_Click(sender As Object, e As EventArgs) Handles btnFinancialStatement.Click
        SetButtonColor(btnFinancialStatement)
        frmMain_revise.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_FinancialStatementsDetails)
    End Sub

    Private Sub btnLedgerReports_Click(sender As Object, e As EventArgs) Handles btnLedgerReports.Click
        SetButtonColor(btnLedgerReports)
        frmMain_revise.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_LedgerReportsDetails)
    End Sub

    Private Sub btnNewReports_Click(sender As Object, e As EventArgs) Handles btnNewReports.Click
        SetButtonColor(btnNewReports)
        frmMain_revise.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_NewReportsDetails)
    End Sub

    Private Sub btnOtherReports_Click(sender As Object, e As EventArgs) Handles btnOtherReports.Click
        SetButtonColor(btnOtherReports)
        frmMain_revise.switchPanelHolder(frmMainPanelFMMDetail.panelSubFMM_OtherReportsDetails)
    End Sub
End Class