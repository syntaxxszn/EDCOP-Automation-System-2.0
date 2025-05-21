Public Class frmTK_DataGridViewLeave

    Private Sub dgvLeave_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvLeave.CellFormatting
        If dgvLeave.Columns(e.ColumnIndex).Name = "Status" Then
            If e.Value IsNot Nothing Then
                Select Case e.Value.ToString()
                    Case "Approved"
                        e.CellStyle.ForeColor = Color.DarkGreen
                    Case "Disapproved"
                        e.CellStyle.ForeColor = Color.Red
                    Case "Pending"
                        e.CellStyle.ForeColor = Color.Navy
                    Case "For Evaluation"
                        e.CellStyle.ForeColor = Color.Goldenrod
                End Select
            End If
        End If
    End Sub

    Private Sub dgvLeave_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeave.CellClick
        If dgvLeave.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvLeave.SelectedRows(0)
            _LeaveFileID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub dgvLeave_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeave.CellDoubleClick
        If dgvLeave.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvLeave.SelectedRows(0)
            With frmTK_PrevEmployeeLeave
                .txtFullName.Text = selectedRow.Cells(1).Value
                .txtDepartment.Text = selectedRow.Cells(2).Value
                .txtLeave.Text = selectedRow.Cells(3).Value
                .txtDatePeriod.Text = selectedRow.Cells(4).Value & " to " & selectedRow.Cells(5).Value
                .txtHours.Text = selectedRow.Cells(7).Value
                .txtLeaveCount.Text = selectedRow.Cells(8).Value
                '.lblStatus.Text = selectedRow.Cells(9).Value
                .lblStatus.Text = selectedRow.Cells(10).Value
                .txtApprover.Text = selectedRow.Cells(11).Value
                .txtPostingName.Text = selectedRow.Cells(12).Value
                .txtPostingDate.Text = selectedRow.Cells(13).Value
                ._MsgStatusRemarks = selectedRow.Cells(14).Value
                .txtReason.Text = selectedRow.Cells(15).Value
                .txtDateFiled.Text = selectedRow.Cells(16).Value
                .txtLeaveCredits.Text = selectedRow.Cells(17).Value
            End With
        End If
        frmTK_PrevEmployeeLeave.ShowDialog()
    End Sub

    Private Sub UpdateStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStatusToolStripMenuItem.Click
        If dgvLeave.CurrentRow?.Cells(10).Value?.ToString() <> "Pending" Then
            MessageBox.Show($"This file is already in '{dgvLeave.CurrentRow.Cells(10).Value}' status, further rectification is not allowed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmTK_UpdateLeaveStatus.ShowDialog()
    End Sub

    Private Sub DeleteThisFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisFileToolStripMenuItem.Click
        If dgvLeave.CurrentRow?.Cells(10).Value?.ToString() <> "Pending" Then
            MessageBox.Show($"This file is already in '{dgvLeave.CurrentRow.Cells(10).Value}' status, deletion is not allowed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Del_EmployeeLeave_By_ID(dgvLeave)
    End Sub
End Class