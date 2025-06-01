Public Class PerformanceManagementSubMenu

    Private Sub btnPart1_Click(sender As Object, e As EventArgs) Handles btnPart1.Click
        Me.Close()
        OpenChildForm_Revision(frmHRIS_Transaction_PerformanceManagement_Part1)
    End Sub

    Private Sub btnPart2_Click(sender As Object, e As EventArgs) Handles btnPart2.Click
        Me.Close()
        OpenChildForm_Revision(frmHRIS_Transaction_PerformanceManagement_Part2)
    End Sub

End Class