Public Class frmMainPanelTKM
    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        frmMain.switchPanelHolder(frmMainPanelTKMDetail.panelSubTKM_TransactionDetails)
    End Sub
End Class