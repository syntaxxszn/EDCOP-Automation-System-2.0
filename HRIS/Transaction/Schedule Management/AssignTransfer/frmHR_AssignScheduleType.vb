Public Class frmHR_AssignScheduleType

    Private Sub frmHR_AssignScheduleType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sel_Personnel_Active(dgvActiveEmployees)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Search_DGVPersonnel(dgvActiveEmployees, txtSearch, False)
    End Sub

    Private Sub cbScheduleType_DropDown(sender As Object, e As EventArgs) Handles cbScheduleType.DropDown
        DropDownListShiftType(cbScheduleType)
    End Sub

    Private Sub cbScheduleType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbScheduleType.SelectedIndexChanged
        DropDownListShiftEffectivityByShiftTypeID(cbEffectivityPeriod, cbScheduleType)
    End Sub

    Private Sub dgvActiveEmployees_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActiveEmployees.CellDoubleClick
        If dgvActiveEmployees.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvActiveEmployees.SelectedRows(0)
            _strShiftEmployeeID = selectedRow.Cells(0).Value
            txtName.Text = selectedRow.Cells(2).Value.ToString() & " (" & selectedRow.Cells(1).Value.ToString() & ")"
            txtJobPosition.Text = selectedRow.Cells(3).Value.ToString()
            txtDepartment.Text = selectedRow.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub btnAssignSchedule_Click(sender As Object, e As EventArgs) Handles btnAssignSchedule.Click
        Assign_ScheduleShiftType_To_Employee()
    End Sub

    Private Sub frmHR_AssignScheduleType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
End Class