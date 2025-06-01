Public Class PerformanceManagementSubMenu_Part1

    Private Sub btnForm1GoalSheet_Click(sender As Object, e As EventArgs) Handles btnForm1GoalSheet.Click
        Me.Close()
        frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.ShowDialog()
    End Sub

    Private Sub btnPart1Form2_Click(sender As Object, e As EventArgs) Handles btnPart1Form2.Click
        Me.Close()
        frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2.ShowDialog()
    End Sub

End Class