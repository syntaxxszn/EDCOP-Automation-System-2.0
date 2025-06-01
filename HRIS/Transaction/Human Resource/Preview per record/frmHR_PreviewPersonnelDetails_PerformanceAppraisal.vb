Public Class frmHR_PreviewPersonnelDetails_PerformanceAppraisal

    Private Sub frmHR_PreviewPersonnelDetails_PerformanceAppraisal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SelUpd_HRIS_Personnel_PerformanceAppraisal_ByID(dgvPerformanceAppraisal)
        isEdit = False
    End Sub

End Class