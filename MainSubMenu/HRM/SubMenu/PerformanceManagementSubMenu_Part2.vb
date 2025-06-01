Public Class PerformanceManagementSubMenu_Part2
    Private Sub btnFormA_Click(sender As Object, e As EventArgs) Handles btnFormA.Click
        Me.Close()
        frmHRIS_PerformanceManagement_AddUpdatePart2_FormAValues.ShowDialog()
    End Sub
End Class