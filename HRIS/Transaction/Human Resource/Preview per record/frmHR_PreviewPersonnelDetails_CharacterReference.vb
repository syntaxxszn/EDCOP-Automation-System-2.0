Public Class frmHR_PreviewPersonnelDetails_CharacterReference
    Private Sub frmHR_PreviewPersonnelDetails_CharacterReference_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SelUpd_HRIS_Personnel_CharacterReference_ByID(dgvCharRef)
        isEdit = False
    End Sub
End Class