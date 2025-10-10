Public Class ChartOfAccountsSubMenu

    Private Sub btnInternal_Click(sender As Object, e As EventArgs) Handles btnInternal.Click
        Me.Close()
        OpenChildForm_Revision(frmFMIS_Setup_ChartOfAccounts_Internal)
    End Sub

    Private Sub btnExternal_Click(sender As Object, e As EventArgs) Handles btnExternal.Click
        Me.Close()
        OpenChildForm_Revision(frmFMIS_Setup_ChartOfAccounts)
    End Sub

    Private Sub btnMapping_Click(sender As Object, e As EventArgs) Handles btnMapping.Click
        Me.Close()
    End Sub

End Class