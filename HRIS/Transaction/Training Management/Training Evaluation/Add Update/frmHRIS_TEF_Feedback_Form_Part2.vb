Public Class frmHRIS_TEF_Feedback_Form_Part2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        InsUpd_TE_TrainingEvaluationFeedback()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub
End Class