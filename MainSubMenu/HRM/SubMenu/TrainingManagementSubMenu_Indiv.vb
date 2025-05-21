Public Class TrainingManagementSubMenu_Indiv
    Private Sub btnTrainingEvaluation_Click(sender As Object, e As EventArgs) Handles btnTrainingEvaluation.Click
        Me.Close()
        OpenChildForm_Revision(frmHRIS_Transaction_TrainingEvaluation)
    End Sub

    Private Sub btnTrainingRequest_Click(sender As Object, e As EventArgs) Handles btnTrainingRequest.Click
        Me.Close()
        OpenChildForm_Revision(frmHRIS_Transaction_TrainingRequest)
    End Sub
End Class