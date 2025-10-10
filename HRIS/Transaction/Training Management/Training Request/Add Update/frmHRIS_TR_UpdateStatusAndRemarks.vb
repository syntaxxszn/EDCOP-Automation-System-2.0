Public Class frmHRIS_TR_UpdateStatusAndRemarks

    Private Sub frmHRIS_TR_UpdateStatusAndRemarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbStatus_DropDown(sender As Object, e As EventArgs) Handles cbStatus.DropDown
        TrainingStatusDropDownList2(cbStatus)
    End Sub

    Private Sub cbReviewedBy_DropDown(sender As Object, e As EventArgs) Handles cbReviewedBy.DropDown
        DropDownListSupervisorEmployeeName2(cbReviewedBy)
    End Sub


    Private Sub cbApprovedBy_DropDown(sender As Object, e As EventArgs) Handles cbApprovedBy.DropDown
        DropDownListSupervisorEmployeeName2(cbApprovedBy)
    End Sub

    Private Sub cbApprovedBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbApprovedBy.SelectedIndexChanged
        If cbApprovedBy.SelectedIndex >= 1 Then
            dtpApprovedDate.Enabled = True
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        UpdTrainingDetailStatus()
    End Sub

    Private Sub frmHRIS_TR_UpdateStatusAndRemarks_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ResetComboBoxes(Me)
        ClearTextBoxes(Me)
        ResetDatePickers(Me)
    End Sub
End Class
