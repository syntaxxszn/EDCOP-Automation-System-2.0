Public Class frmMainPanelPMM
    Private Sub btnPurchaseJournal_Click(sender As Object, e As EventArgs) Handles btnPurchaseJournal.Click
        frmMain.switchPanelHolder(frmMainPanelPMMDetail.panelSubHRIS_PurchaseJournal)
    End Sub

    Private Sub frmMainPanelPMM_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnPurchaseJournal.PerformClick()
    End Sub
End Class