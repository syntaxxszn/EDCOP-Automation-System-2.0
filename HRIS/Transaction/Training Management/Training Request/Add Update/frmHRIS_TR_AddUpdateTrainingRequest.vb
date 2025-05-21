Imports System.ComponentModel

Public Class frmHRIS_TR_AddUpdateTrainingRequest

    Public isUpdate As Boolean = False

    Private Sub frmHR_AddUpdateTrainingRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If isUpdate Then
            Call SelUpd_Training_TrainingRequestByID()
            Exit Sub
        End If

        _TrainingRequestID = 0 'set to ID = 0 to trigger insert in stored procedure

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtTrainingName.Text) OrElse
        String.IsNullOrWhiteSpace(txtDescription.Text) OrElse
        String.IsNullOrWhiteSpace(txtFacilitator.Text) OrElse
        String.IsNullOrWhiteSpace(txtMeasurement.Text) OrElse
        String.IsNullOrWhiteSpace(txtMethodology.Text) OrElse
        String.IsNullOrWhiteSpace(txtLogistics.Text) OrElse
        String.IsNullOrWhiteSpace(txtProgramOutline.Text) OrElse
        String.IsNullOrWhiteSpace(txtFee.Text) Then
            MessageBox.Show("Oooppss... Some fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_TrainingRequest()
    End Sub

    Private Sub txtFee_Validating(sender As Object, e As CancelEventArgs) Handles txtFee.Validating
        Textbox_NumericFormat(txtFee, e.Cancel)
    End Sub

    Private Sub frmHR_AddUpdateTrainingRequest_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Not Me.IsDisposed Then Me.Dispose()
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        Me.Dispose()
    End Sub
End Class