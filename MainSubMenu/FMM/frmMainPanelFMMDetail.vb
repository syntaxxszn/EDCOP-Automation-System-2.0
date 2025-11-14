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
End Class