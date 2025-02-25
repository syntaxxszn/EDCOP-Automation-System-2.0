Public Class frmMainPanelPMMDetail
    Private Sub btnCompany_Click(sender As Object, e As EventArgs) Handles btnCashAdvance.Click
        ShowSubMenu(New CashAdvanceSubMenu(), btnCashAdvance)
    End Sub

    Private Sub btnPurchaseRequisition_Click(sender As Object, e As EventArgs) Handles btnPurchaseRequisition.Click
        ShowSubMenu(New PurchaseRequisitionSubMenu(), btnPurchaseRequisition)
    End Sub
End Class