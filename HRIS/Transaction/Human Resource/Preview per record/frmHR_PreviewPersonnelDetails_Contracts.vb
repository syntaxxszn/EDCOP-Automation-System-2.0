Public Class frmHR_PreviewPersonnelDetails_Contracts
    Private Sub frmHR_PreviewPersonnelDetails_Contracts_Load(sender As Object, e As EventArgs) Handles Me.Load
        Sel_HRIS_Personnel_ContractHistory_ByID(dgvContracts)
        isEdit = False
    End Sub
End Class