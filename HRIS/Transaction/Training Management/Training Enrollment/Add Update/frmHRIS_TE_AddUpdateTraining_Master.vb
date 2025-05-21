Public Class frmHRIS_TE_AddUpdateTraining_Master

    Public isUpdate As Boolean = False

    Private Sub frmHRIS_TE_AddUpdateTraining_Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TrainingCategoryDropDownList(cbTrainingCategory)
        Call TrainingNatureDropDownList(cbTrainingNature)

        lblHeader.Text = "Add New Employee Training"
        If isUpdate Then
            Call SelUpd_Training_TrainingList_ByID()
            lblHeader.Text = "Updating Employee Training"
            Exit Sub
        End If

        _TrainingListID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
        String.IsNullOrWhiteSpace(cbTrainingCategory.Text) OrElse
        String.IsNullOrWhiteSpace(cbTrainingNature.Text) Then
            MessageBox.Show("Oooppss... Some fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Call InsUpd_TE_TrainingList()
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        Call ClearTextBoxes(Me)
        Call ResetComboBoxes(Me)
    End Sub

    Private Sub frmHRIS_TE_AddUpdateTraining_Master_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        Call ClearTextBoxes(Me)
        Call ResetComboBoxes(Me)
    End Sub
End Class