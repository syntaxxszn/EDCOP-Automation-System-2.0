Public Class frmMainPanelHRM
    Private Sub frmMainPanelHRM_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnSetup.PerformClick()
    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        frmMain_revise.switchPanelHolder(frmMainPanelHRMDetail.panelSubHRIS_SetupDetails)
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        frmMain_revise.switchPanelHolder(frmMainPanelHRMDetail.panelSubHRIS_TransactionDetails)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmMain_revise.switchPanelHolder(frmMainPanelHRMDetail.panelSubHRIS_Reports)
    End Sub
End Class