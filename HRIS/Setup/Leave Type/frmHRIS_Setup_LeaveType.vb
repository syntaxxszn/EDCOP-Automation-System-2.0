Public Class frmHRIS_Setup_LeaveType

    Private Sub frmHR_Setup_LeaveType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Sel_LeaveType(dgvLeaveTypeList, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Call Sel_LeaveType(dgvLeaveTypeList, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        dgvLeaveTypeList.ClearSelection()
        frmHRIS_Setup_AddUpdateLeaveType.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvLeaveTypeList.SelectedRows.Count > 0 Then
            frmHRIS_Setup_AddUpdateLeaveType.isUpdate = True
            frmHRIS_Setup_AddUpdateLeaveType.ShowDialog()
        Else
            MessageBox.Show("Please select from the leave types table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        txtboxSearch.Clear()
        Call Sel_LeaveType(dgvLeaveTypeList, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub dgvLeaveTypeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeaveTypeList.CellClick
        If dgvLeaveTypeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvLeaveTypeList.SelectedRows(0)
            _strLeaveTypeID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub dgvLeaveTypeList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeaveTypeList.CellDoubleClick
        frmHRIS_Setup_AddUpdateLeaveType.isUpdate = True
        frmHRIS_Setup_AddUpdateLeaveType.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub
End Class