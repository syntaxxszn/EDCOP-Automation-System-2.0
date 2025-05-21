Public Class frmTK_DataGridViewOverTime

    Private Sub dgvOverTime_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOverTime.CellDoubleClick
        If dgvOverTime.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvOverTime.SelectedRows(0)
            With frmTK_PrevEmployeeOverTime
                .lblFullName.Text = selectedRow.Cells(1).Value
                .txtDepartment.Text = selectedRow.Cells(2).Value
                .txtPosition.Text = selectedRow.Cells(3).Value
                .lblDatePeriod.Text = selectedRow.Cells(4).Value
                .lblTimeRange.Text = selectedRow.Cells(5).Value
                .lblHours.Text = selectedRow.Cells(6).Value
                .txtOverHeadDept.Text = selectedRow.Cells(7).Value
                .lblProjectNumber.Text = selectedRow.Cells(8).Value
                .txtProjectName.Text = selectedRow.Cells(9).Value
                .lblDateFiled.Text = selectedRow.Cells(11).Value
                .txtDetailsWork.Text = selectedRow.Cells(12).Value
                .lblStatus.Text = selectedRow.Cells(13).Value
                .txtAuthorize.Text = selectedRow.Cells(14).Value
            End With
        End If
        frmTK_PrevEmployeeOverTime.ShowDialog()
    End Sub

    Private Sub dgvOverTime_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvOverTime.CellFormatting
        If dgvOverTime.Columns(e.ColumnIndex).Name = "Status" Then
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

    Private Sub dgvOverTime_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOverTime.CellClick
        If dgvOverTime.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvOverTime.SelectedRows(0)
            _OverTimeFileID = selectedRow.Cells(0).Value
        End If
    End Sub

    'Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    '    With dgvOverTime.HitTest(dgvOverTime.PointToClient(Cursor.Position).X, dgvOverTime.PointToClient(Cursor.Position).Y)
    '        If .RowIndex < 0 Then e.Cancel = True : Exit Sub
    '        Dim status = dgvOverTime.Rows(.RowIndex).Cells(13).Value?.ToString()
    '        If status = "Disapproved" OrElse status = "For Evaluation" OrElse status = "Approved" Then
    '            MessageBox.Show($"This file is already in '{status}' status, further rectification is not allowed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            e.Cancel = True
    '        End If
    '    End With
    'End Sub

    Private Sub UpdateStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStatusToolStripMenuItem.Click
        If dgvOverTime.CurrentRow?.Cells(13).Value?.ToString() <> "Pending" Then
            MessageBox.Show($"This file is already in '{dgvOverTime.CurrentRow.Cells(13).Value}' status, further rectification is not allowed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmTK_UpdateLeaveStatus.ShowDialog()
    End Sub

    Private Sub DeleteThisFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisFileToolStripMenuItem.Click
        If dgvOverTime.CurrentRow?.Cells(13).Value?.ToString() <> "Pending" Then
            MessageBox.Show($"This file is already in '{dgvOverTime.CurrentRow.Cells(13).Value}' status, deletion is not allowed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Del_Overtime_By_ID(dgvOverTime)
    End Sub
End Class