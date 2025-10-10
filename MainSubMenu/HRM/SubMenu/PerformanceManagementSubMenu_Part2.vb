Public Class PerformanceManagementSubMenu_Part2

    Private Sub btnFormA_Click(sender As Object, e As EventArgs) Handles btnFormA.Click
        Me.Close()
        frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.ShowDialog()
    End Sub

    Private Sub btnFormB_Click(sender As Object, e As EventArgs) Handles btnFormB.Click
        Me.Close()
        frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.ShowDialog()
    End Sub

    Private Sub btnFormC_Click(sender As Object, e As EventArgs) Handles btnFormC.Click
        Me.Close()
        frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.ShowDialog()
    End Sub
End Class