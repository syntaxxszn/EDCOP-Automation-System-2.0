Public Class frmHR_PreviewPersonnelDetails_Contracts
    Private Sub frmHR_PreviewPersonnelDetails_Contracts_Load(sender As Object, e As EventArgs) Handles Me.Load
        Sel_HRIS_Personnel_ContractHistory_ByID(dgvContracts, True)
        isEdit = False
    End Sub

    Private Sub btnAddNewContract_Click(sender As Object, e As EventArgs) Handles btnAddNewContract.Click
        frmHR_AddNewContract.txtEmployeeName.Text = frmHR_PreviewPersonnelDetails.lblFullName.Text
        frmHR_AddNewContract.ShowDialog()
    End Sub
End Class