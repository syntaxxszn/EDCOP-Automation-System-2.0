Public Class frmHRIS_TR_AddUpdTrainingParticipants

    Private Sub frmHRIS_TR_AddUpdTrainingParticipants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Proc. : Call the function to refresh the list of available employee for trainings.
        Call Select_TR_ActiveEmployee_TrainingRequestParticipant(dgvActiveEmployees)

        ' Proc. : Call the function to refresh the training DGV.
        Call Select_TR_EnrolledEmployee_TrainingRequestParticipant(dgvAddedEmployees)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call Search_DGVPersonnel(dgvActiveEmployees, txtSearch, False)
    End Sub

    Private Sub btnSendtoRight_Click(sender As Object, e As EventArgs) Handles btnSendtoRight.Click
        If dgvActiveEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("No employee selected.")
        Else
            txtSearch.Clear()
            Call Ins_Employee_TR_Participant()
            txtSearch.Focus()
        End If
    End Sub

    Private Sub dgvActiveEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActiveEmployees.CellClick
        If dgvActiveEmployees.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvActiveEmployees.SelectedRows(0)
            _TrainingEmployeeID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub btnSendtoLeft_Click(sender As Object, e As EventArgs) Handles btnSendtoLeft.Click
        If dgvAddedEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("No employee selected.")
        Else
            Call Del_Employee_TR_Participant()
        End If
    End Sub

    Private Sub dgvAddedEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddedEmployees.CellClick
        If dgvAddedEmployees.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvAddedEmployees.SelectedRows(0)
            _TrainingEmployeeID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub frmHRIS_TR_AddUpdTrainingParticipants_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Call Select_TrainingRequest_Participant_List(frmHRIS_Transaction_TrainingRequest.dgvEmployeeList)
    End Sub

    Private Sub frmHRIS_TR_AddUpdTrainingParticipants_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Not Me.IsDisposed Then Me.Dispose()
    End Sub
End Class