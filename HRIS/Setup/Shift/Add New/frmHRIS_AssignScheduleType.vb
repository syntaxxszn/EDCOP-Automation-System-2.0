Public Class frmHRIS_AssignScheduleType

    Private Sub frmHRIS_AssignScheduleType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtSchedule.Text = "" Then
            MessageBox.Show("Please select a valid schedule.", "Type not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Call Sel_Shift_Personnel_Active(dgvActiveEmployees)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Sel_Shift_Personnel_Active(dgvActiveEmployees)
    End Sub

    Private Sub dgvActiveEmployees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActiveEmployees.CellContentClick

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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Search_Shift_Personnel_Active(dgvActiveEmployees, txtSearch)
    End Sub

    Private Sub frmHRIS_AssignScheduleType_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dgvActiveEmployees.ClearSelection()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAssignSchedule_Click(sender As Object, e As EventArgs) Handles btnAssignSchedule.Click

        If _strShiftEmployeeID = 0 Then Return

        If Not (chMonday.Checked Or chTuesday.Checked Or chWednesday.Checked Or chThursday.Checked Or chFriday.Checked Or chSaturday.Checked Or chSunday.Checked) _
               AndAlso MessageBox.Show("No rest day(s) selected. Proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If

        Assign_ScheduleShiftType_To_Employee()

    End Sub

    Private Sub frmHRIS_AssignScheduleType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        ClearDataGridViewRows(Me)
        ClearTextBoxes(Me)
        UncheckCheckBoxes(Me)

    End Sub

End Class