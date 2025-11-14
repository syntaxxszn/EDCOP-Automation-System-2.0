Public Class frmSSM_SystemUserAccessMain

    Private Sub frmSSM_SystemUserAccessMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_SystemUsers(dgvSystemUsers, txtboxSearch)
    End Sub

    Private Sub UpdateRowCount()
        Dim rowCount As Integer = dgvSystemUsers.Rows.Count - If(dgvSystemUsers.AllowUserToAddRows, 1, 0)
        toolstriplabelNoOfRecord.Text = rowCount.ToString()
    End Sub

    Private Sub dgvSystemUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSystemUsers.CellClick
        If dgvSystemUsers.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvSystemUsers.SelectedRows(0)
            _SystemUserID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub dgvSystemUsers_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvSystemUsers.RowsAdded
        UpdateRowCount()
    End Sub

    Private Sub dgvSystemUsers_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvSystemUsers.RowsRemoved
        UpdateRowCount()
    End Sub

    Private Sub dgvSystemUsers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSystemUsers.CellDoubleClick
        frmSSM_SystemUserAccess_AddUpdAccess.ShowDialog()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvSystemUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSystemUsers.CellContentClick

    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Call Sel_SystemUsers(dgvSystemUsers, txtboxSearch)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click

        Me.Close()

    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_SystemUsers(dgvSystemUsers, txtboxSearch)
    End Sub
End Class