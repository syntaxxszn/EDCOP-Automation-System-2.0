Public Class frmMainPanelFMMDetail

    Private Sub btnPettyCash_Click(sender As Object, e As EventArgs) Handles btnPettyCash.Click
        ShowSubMenu(New PettyCashSubMenu(), btnPettyCash)
    End Sub

    Private Sub btnRequestForPayment_Click(sender As Object, e As EventArgs) Handles btnRequestForPayment.Click
        ShowSubMenu(New RequestForPaymentSubMenu(), btnRequestForPayment)
    End Sub

    Private Sub btnCashDisbursement_Click(sender As Object, e As EventArgs) Handles btnCashDisbursement.Click
        ShowSubMenu(New CashDisbursementSubMenu(), btnCashDisbursement)
    End Sub
End Class