Public Class frmHRIS_TE_AddUpdateTrainingDetail_Master

    Public isUpdate As Boolean = False

    Private Sub frmHRIS_TE_AddUpdateTrainingDetail_Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtName.Text = frmHRIS_Transaction_TrainingEnrollment.lblTrainingName.Text
        lblHeader.Text = "Add New Employee Training Detail"
        Call SelTrainingBatchNumber(_TrainingListID)
        Call TrainingStatusDropDownList(cbTrainingStatus)
        btnSubmit.Select()

        If isUpdate Then
            Call SelUpd_Training_TrainingDetail_ByID()
            lblHeader.Text = "Update Employee Training Detail"
            dtpActualEndDate.Enabled = True
            dtpActualStartDate.Enabled = True
            Exit Sub
        End If

        _TrainingBatchListID = 0 'set to ID = 0 to trigger insert in stored procedure

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
            String.IsNullOrWhiteSpace(txtBatchNumber.Text) OrElse
            String.IsNullOrWhiteSpace(cbTrainingStatus.Text) OrElse
            String.IsNullOrWhiteSpace(txtHours.Text) OrElse
            String.IsNullOrWhiteSpace(txtFacilitator.Text) OrElse
            String.IsNullOrWhiteSpace(txtVenue.Text) OrElse
            String.IsNullOrWhiteSpace(txtCode.Text) Then
            MessageBox.Show("Oooppss... Some fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Call InsUpd_TE_TrainingDetail()
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        Me.Dispose()
    End Sub

    Private Sub frmHRIS_TE_AddUpdateTrainingDetail_Master_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call ClearTextBoxes(Me)
        Call ResetDatePickers(Me)
        Call ResetComboBoxes(Me)
    End Sub
End Class