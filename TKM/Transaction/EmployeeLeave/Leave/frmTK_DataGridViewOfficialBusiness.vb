Public Class frmTK_DataGridViewOfficialBusiness

    Private Sub frmTK_DataGridViewOfficialBusiness_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub dgvOfficialBusiness_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOfficialBusiness.CellDoubleClick
        If dgvOfficialBusiness.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvOfficialBusiness.SelectedRows(0)
            With frmTK_PrevEmployeeOfficialBusiness
                .txtEmployeeName.Text = selectedRow.Cells(1).Value
                .txtDepartment.Text = selectedRow.Cells(2).Value
                .lblControlNumber.Text = selectedRow.Cells(3).Value
                .txtPurpose.Text = selectedRow.Cells(4).Value
                .txtDestinationFrom.Text = selectedRow.Cells(5).Value
                .txtDestinationTo.Text = selectedRow.Cells(6).Value
                .txtDateRange.Text = selectedRow.Cells(7).Value
                .txtDepartureTime.Text = selectedRow.Cells(8).Value
                .txtArrivalTime.Text = selectedRow.Cells(9).Value
                .txtTransportOthers.Text = selectedRow.Cells(10).Value
                .txtPreparedby.Text = selectedRow.Cells(11).Value
                .txtPreparedDate.Text = selectedRow.Cells(12).Value
                .txtAuthorizedby.Text = selectedRow.Cells(13).Value
                .txtOverheadDepartment.Text = selectedRow.Cells(14).Value
                .txtProjectName.Text = selectedRow.Cells(15).Value & " " & selectedRow.Cells(16).Value
                .lblStatus.Text = selectedRow.Cells(17).Value
                .lblDateFiled.Text = selectedRow.Cells(18).Value
            End With
        End If
        frmTK_PrevEmployeeOfficialBusiness.ShowDialog()
    End Sub

    Private Sub dgvOfficialBusiness_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvOfficialBusiness.CellFormatting
        If dgvOfficialBusiness.Columns(e.ColumnIndex).Name = "Status" Then
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

    Private Sub dgvOfficialBusiness_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOfficialBusiness.CellClick
        If dgvOfficialBusiness.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvOfficialBusiness.SelectedRows(0)
            _OfficialBusFileID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub UpdateStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStatusToolStripMenuItem.Click
        If dgvOfficialBusiness.CurrentRow?.Cells(17).Value?.ToString() <> "Pending" Then
            MessageBox.Show($"This file is already in '{dgvOfficialBusiness.CurrentRow.Cells(17).Value}' status, further rectification is not allowed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        frmTK_UpdateLeaveStatus.ShowDialog()
    End Sub

    'Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
    '    With dgvOfficialBusiness.HitTest(dgvOfficialBusiness.PointToClient(Cursor.Position).X, dgvOfficialBusiness.PointToClient(Cursor.Position).Y)
    '        If .RowIndex < 0 Then e.Cancel = True : Exit Sub
    '        Dim status = dgvOfficialBusiness.Rows(.RowIndex).Cells(17).Value?.ToString()
    '        If status = "Disapproved" OrElse status = "For Evaluation" OrElse status = "Approved" Then
    '            MessageBox.Show($"This file is already in '{status}' status, further rectification is not allowed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            e.Cancel = True
    '        End If
    '    End With
    'End Sub

    Private Sub DeleteThisFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisFileToolStripMenuItem.Click
        If dgvOfficialBusiness.CurrentRow?.Cells(17).Value?.ToString() <> "Pending" Then
            MessageBox.Show($"This file is already in '{dgvOfficialBusiness.CurrentRow.Cells(17).Value}' status, deletion is not allowed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Del_OfficialBusiness_By_ID(dgvOfficialBusiness)
    End Sub
End Class