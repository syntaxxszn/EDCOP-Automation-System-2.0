Public Class frmTK_DataGridViewUnderTime

    Private Sub dgvUnderTime_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUnderTime.CellFormatting
        If dgvUnderTime.Columns(e.ColumnIndex).Name = "Status" Then
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

    Private Sub dgvUnderTime_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnderTime.CellClick
        If dgvUnderTime.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvUnderTime.SelectedRows(0)
            _UnderTimeFileID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub dgvUnderTime_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnderTime.CellDoubleClick
        If dgvUnderTime.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvUnderTime.SelectedRows(0)
            With frmTK_PrevEmployeeUnderTime
                .txtFullName.Text = selectedRow.Cells(1).Value
                .txtDepartment.Text = selectedRow.Cells(2).Value
                .txtDatePeriod.Text = selectedRow.Cells(3).Value
                .txtTimeRange.Text = selectedRow.Cells(4).Value
                .txtHours.Text = selectedRow.Cells(5).Value
                .txtDateFiled.Text = selectedRow.Cells(6).Value
                .txtPostedDate.Text = selectedRow.Cells(7).Value
                .txtReason.Text = selectedRow.Cells(8).Value
                .lblStatus.Text = selectedRow.Cells(9).Value
                ._MsgStatusRemarks = selectedRow.Cells(10).Value
                .txtApprovedBy.Text = selectedRow.Cells(11).Value
                .txtPostedBy.Text = selectedRow.Cells(12).Value
            End With
        End If
        frmTK_PrevEmployeeUnderTime.ShowDialog()
    End Sub

    'Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    '    With dgvUnderTime.HitTest(dgvUnderTime.PointToClient(Cursor.Position).X, dgvUnderTime.PointToClient(Cursor.Position).Y)
    '        If .RowIndex < 0 Then e.Cancel = True : Exit Sub
    '        Dim status = dgvUnderTime.Rows(.RowIndex).Cells(9).Value?.ToString()
    '        If status = "Disapproved" OrElse status = "For Evaluation" OrElse status = "Approved" Then
    '            MessageBox.Show($"This file is already in '{status}' status, further rectification is not allowed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            e.Cancel = True
    '        End If
    '    End With
    'End Sub

    Private Sub UpdateStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStatusToolStripMenuItem.Click
        If dgvUnderTime.CurrentRow?.Cells(9).Value?.ToString() <> "Pending" Then
            MessageBox.Show($"This file is already in '{dgvUnderTime.CurrentRow.Cells(9).Value}' status, further rectification is not allowed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmTK_UpdateLeaveStatus.ShowDialog()
    End Sub

    Private Sub DeleteThisFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisFileToolStripMenuItem.Click
        If dgvUnderTime.CurrentRow?.Cells(9).Value?.ToString() <> "Pending" Then
            MessageBox.Show($"This file is already in '{dgvUnderTime.CurrentRow.Cells(9).Value}' status, deletion is not allowed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Del_Undertime_By_ID(dgvUnderTime)
    End Sub
End Class