Public Class frmHR_PreviewPersonnelDetails_TrainingHistory

    Private Sub frmHR_PreviewPersonnelDetails_TrainingHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SelUpd_HRIS_Personnel_TrainingHistory_ByID(dgvTrainingHistory)
        isEdit = False
    End Sub

End Class