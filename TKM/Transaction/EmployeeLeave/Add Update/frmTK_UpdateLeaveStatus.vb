Public Class frmTK_UpdateLeaveStatus
    Private Sub frmTK_UpdateLeaveStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaveStatus_Click(sender As Object, e As EventArgs) Handles btnSaveStatus.Click
        If frmTimeKeeping_Transaction_EmployeeLeave.lastClickedBtn = 1 Then
            Upd_OfficialBusiness_Status_By_PersonnelID()
        ElseIf frmTimeKeeping_Transaction_EmployeeLeave.lastClickedBtn = 2 Then
            Upd_Overtime_Status_By_PersonnelID()
        ElseIf frmTimeKeeping_Transaction_EmployeeLeave.lastClickedBtn = 3 Then
            Upd_Undertime_Status_By_PersonnelID()
        ElseIf frmTimeKeeping_Transaction_EmployeeLeave.lastClickedBtn = 4 Then
            Upd_EmployeeLeave_Status_By_PersonnelID()
        Else
            MessageBox.Show("Ooppssiee, something went wrong. (T_T)", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cbApprover_DropDown(sender As Object, e As EventArgs) Handles cbStatus.DropDown
        DropDownListLeaveStatus(cbStatus)
    End Sub

    Private Sub cbSupervisor_DropDown(sender As Object, e As EventArgs) Handles cbSupervisor.DropDown
        DropDownListSupervisorEmployeeName(cbSupervisor)
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
    End Sub

    Private Sub frmTK_UpdateLeaveStatus_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
    End Sub
End Class