Public Class frmMainPanelFMMDetail

    'Private Sub btnPettyCash_Click(sender As Object, e As EventArgs) Handles btnPettyCash.Click
    '    ShowSubMenu(New PettyCashSubMenu(), btnPettyCash)
    'End Sub

    'Private Sub btnRequestForPayment_Click(sender As Object, e As EventArgs) Handles btnRequestForPayment.Click
    '    ShowSubMenu(New RequestForPaymentSubMenu(), btnRequestForPayment)
    'End Sub

    'Private Sub btnCashDisbursement_Click(sender As Object, e As EventArgs) Handles btnCashDisbursement.Click
    '    ShowSubMenu(New CashDisbursementSubMenu(), btnCashDisbursement)
    'End Sub

    Private Sub btnCompany_Click(sender As Object, e As EventArgs) Handles btnCompany.Click
        If HasSubMenuAccess(btnCompany) Then
            SetButtonColor(btnCompany) 'set btn color to gainsboro if recently clicked
            frmHRIS_Setup_Company.ToolStripLabel1.Text = "Financial Management Module > Setup > Company"
            OpenChildForm_Revision(frmHRIS_Setup_Company)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnFiscalPeriod_Click(sender As Object, e As EventArgs) Handles btnFiscalPeriod.Click
        If HasSubMenuAccess(btnFiscalPeriod) Then
            SetButtonColor(btnFiscalPeriod)
            OpenChildForm_Revision(frmFMIS_Setup_FiscalPeriod)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCashFlowCategory_Click(sender As Object, e As EventArgs) Handles btnCashFlowCategory.Click
        If HasSubMenuAccess(btnCashFlowCategory) Then
            SetButtonColor(btnCashFlowCategory)
            OpenChildForm_Revision(frmFMIS_Setup_CashFlowCategory)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCostCenter_Click(sender As Object, e As EventArgs) Handles btnCostCenter.Click
        If HasSubMenuAccess(btnCostCenter) Then
            SetButtonColor(btnCostCenter)
            OpenChildForm_Revision(frmFMIS_Setup_CostCenter)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAccountCategory_Click(sender As Object, e As EventArgs) Handles btnAccountCategory.Click
        If HasSubMenuAccess(btnAccountCategory) Then
            SetButtonColor(btnAccountCategory)
            OpenChildForm_Revision(frmFMIS_Setup_AccountCategory)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnChartOfAccounts_Click(sender As Object, e As EventArgs) Handles btnChartOfAccounts.Click
        If HasSubMenuAccess(btnChartOfAccounts) Then
            SetButtonColor(btnChartOfAccounts)
            'ShowSubMenu(New ChartOfAccountsSubMenu(), btnChartOfAccounts)
            OpenChildForm_Revision(frmFMIS_Setup_ChartOfAccounts)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBankAccounts_Click(sender As Object, e As EventArgs) Handles btnBankAccounts.Click
        If HasSubMenuAccess(btnBankAccounts) Then
            SetButtonColor(btnBankAccounts)
            OpenChildForm_Revision(frmFMIS_Setup_BankAccount)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSubsidiary_Click(sender As Object, e As EventArgs) Handles btnSubsidiary.Click
        If HasSubMenuAccess(btnSubsidiary) Then
            SetButtonColor(btnSubsidiary)
            OpenChildForm_Revision(frmFMIS_Setup_Subsidiary)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        If HasSubMenuAccess(btnSupplier) Then
            SetButtonColor(btnSupplier)
            OpenChildForm_Revision(frmFMIS_Setup_Supplier)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnTaxRates_Click(sender As Object, e As EventArgs) Handles btnTaxRates.Click
        If HasSubMenuAccess(btnTaxRates) Then
            SetButtonColor(btnTaxRates)
            OpenChildForm_Revision(frmFMIS_Setup_TaxRates)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        If HasSubMenuAccess(btnItems) Then
            SetButtonColor(btnItems)
            OpenChildForm_Revision(frmFMIS_Setup_Items)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBeginningProject_Click(sender As Object, e As EventArgs) Handles btnBeginningProject.Click
        If HasSubMenuAccess(btnBeginningProject) Then
            SetButtonColor(btnBeginningProject)
            OpenChildForm_Revision(frmFMIS_Setup_BeginningProject)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBeginningSubsidiaries_Click(sender As Object, e As EventArgs) Handles btnBeginningSubsidiaries.Click
        If HasSubMenuAccess(btnBeginningSubsidiaries) Then
            SetButtonColor(btnBeginningSubsidiaries)
            OpenChildForm_Revision(frmFMIS_Setup_BeginningSubsidiaries)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnTransactionClosing_Click(sender As Object, e As EventArgs) Handles btnTransactionClosing.Click
        If HasSubMenuAccess(btnTransactionClosing) Then
            SetButtonColor(btnTransactionClosing)
            OpenChildForm_Revision(frmFMIS_Setup_TransactionClosing)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnYearEndClosing_Click(sender As Object, e As EventArgs) Handles btnYearEndClosing.Click
        If HasSubMenuAccess(btnYearEndClosing) Then
            SetButtonColor(btnYearEndClosing)
            OpenChildForm_Revision(frmFMIS_Setup_YearEndClosing)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnApproverSetup_Click(sender As Object, e As EventArgs) Handles btnApproverSetup.Click
        If HasSubMenuAccess(btnApproverSetup) Then
            SetButtonColor(btnApproverSetup)
            OpenChildForm_Revision(frmFMIS_Setup_ApproverSetup)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnVoucherStatus_Click(sender As Object, e As EventArgs) Handles btnVoucherStatus.Click
        If HasSubMenuAccess(btnVoucherStatus) Then
            SetButtonColor(btnVoucherStatus)
            OpenChildForm_Revision(frmFMIS_Setup_ApproverSetup)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAccountBalances_Click(sender As Object, e As EventArgs) Handles btnAccountBalances.Click
        If HasSubMenuAccess(btnAccountBalances) Then
            SetButtonColor(btnAccountBalances)
            OpenChildForm_Revision(frmFMIS_Setup_AccountBalances)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAccountMapping_Click(sender As Object, e As EventArgs) Handles btnAccountMapping.Click
        If HasSubMenuAccess(btnAccountMapping) Then
            SetButtonColor(btnAccountMapping)
            OpenChildForm_Revision(frmFMIS_Setup_AccountMapping)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRequestForPayment_Click(sender As Object, e As EventArgs) Handles btnRequestForPayment.Click
        If HasSubMenuAccess(btnRequestForPayment) Then
            SetButtonColor(btnRequestForPayment)
            OpenChildForm_Revision(frmFMIS_CashJournal_RequestForPayment)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class