Public Class frmMainPanelSSMDetail

    Private Sub btnGroupAccess_Click(sender As Object, e As EventArgs) Handles btnGroupAccess.Click
        OpenChildForm_Revision(frmSSM_SystemGroupAccessMain)
    End Sub

    Private Sub btnUserAccess_Click(sender As Object, e As EventArgs) Handles btnUserAccess.Click
        OpenChildForm_Revision(frmSSM_SystemUserAccessMain)
    End Sub
End Class