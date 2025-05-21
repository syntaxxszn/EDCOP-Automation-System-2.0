Public Class frmHR_Setup_Department

    Private Sub frmHR_Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sel_Department(dgvDepartmentList, txtboxSearch)
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        dgvDepartmentList.ClearSelection()
        frmHR_Setup_AddUpdDepartment.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvDepartmentList.SelectedRows.Count > 0 Then
            frmHR_Setup_AddUpdDepartment.isUpdate = True
            frmHR_Setup_AddUpdDepartment.ShowDialog()
        Else
            MessageBox.Show("Please select from the department table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Sel_Department(dgvDepartmentList, txtboxSearch)
        dgvEmployeeList.Rows.Clear()
        lblDepartmentName.Visible = False
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub txtboxSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Search_DGVDepartment(dgvDepartmentList, txtboxSearch)
        dgvEmployeeList.Rows.Clear()
    End Sub

    Private Sub dgvDepartmentList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartmentList.CellClick
        UnselectDataGridView(dgvDepartmentList)
        If dgvDepartmentList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvDepartmentList.SelectedRows(0)
            _strDepartmentID = selectedRow.Cells(0).Value
            lblDepartmentName.Visible = True
            lblDepartmentName.Text = "[ " & selectedRow.Cells(2).Value & " ]"
            Sel_Employee_ByDepartmentID(dgvEmployeeList)
        End If
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvDepartmentList IsNot excludeDataGridView Then
            dgvDepartmentList.ClearSelection()
        End If

        If dgvEmployeeList IsNot excludeDataGridView Then
            dgvEmployeeList.ClearSelection()
        End If
    End Sub

    Private Sub dgvDepartmentList_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvDepartmentList.RowsAdded
        UpdateRowCount()
    End Sub

    Private Sub dgvDepartmentList_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvDepartmentList.RowsRemoved
        UpdateRowCount()
    End Sub

    Private Sub UpdateRowCount()
        Dim rowCount As Integer = dgvDepartmentList.Rows.Count - If(dgvDepartmentList.AllowUserToAddRows, 1, 0)
        toolstriplabelNoOfRecord.Text = rowCount.ToString()
    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick
        UnselectDataGridView(dgvEmployeeList)
    End Sub

    Private Sub dgvDepartmentList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartmentList.CellDoubleClick
        frmHR_Setup_AddUpdDepartment.isUpdate = True
        frmHR_Setup_AddUpdDepartment.ShowDialog()
    End Sub

End Class