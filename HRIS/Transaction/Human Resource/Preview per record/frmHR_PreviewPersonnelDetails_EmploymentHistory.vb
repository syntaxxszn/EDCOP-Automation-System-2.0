Public Class frmHR_PreviewPersonnelDetails_EmploymentHistory
    Private Sub frmHR_PreviewPersonnelDetails_EmploymentHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SelUpd_HRIS_Personnel_EmploymentHistory_ByID(dgvEmploymentHistory)
        isEdit = False
    End Sub
End Class