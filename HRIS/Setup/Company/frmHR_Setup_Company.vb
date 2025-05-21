Public Class frmHR_Setup_Company

    Private Sub frmHR_Setup_Company_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Company(dgvCompanyList)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        dgvCompanyList.ClearSelection()
        frmHR_Setup_AddUpdCompany.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvCompanyList.SelectedRows.Count > 0 Then
            frmHR_Setup_AddUpdCompany.isUpdate = True
            frmHR_Setup_AddUpdCompany.ShowDialog()
        Else
            MessageBox.Show("Please select from the department table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvCompanyList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompanyList.CellClick
        Call UnselectDataGridView(dgvCompanyList)
        If dgvCompanyList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCompanyList.SelectedRows(0)
            _strCompanyID = selectedRow.Cells(0).Value
            lblCompanyName.Visible = True
            lblCompanyName.Text = "[ " & selectedRow.Cells(2).Value & " ]"
            Call Sel_Department_ByCompanyID(dgvDepartmentList)
        End If
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvDepartmentList IsNot excludeDataGridView Then
            dgvDepartmentList.ClearSelection()
        End If

        If dgvCompanyList IsNot excludeDataGridView Then
            dgvCompanyList.ClearSelection()
        End If
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Company(dgvCompanyList)
        dgvDepartmentList.Rows.Clear()
        lblCompanyName.Visible = False
    End Sub

    Private Sub dgvCompanyList_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvCompanyList.RowsAdded
        Call UpdateRowCount()
    End Sub

    Private Sub dgvCompanyList_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvCompanyList.RowsRemoved
        Call UpdateRowCount()
    End Sub

    Private Sub UpdateRowCount()
        Dim rowCount As Integer = dgvCompanyList.Rows.Count - If(dgvCompanyList.AllowUserToAddRows, 1, 0)
        toolstriplabelNoOfRecord.Text = rowCount.ToString()
    End Sub

    Private Sub dgvDepartmentList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartmentList.CellClick
        Call UnselectDataGridView(dgvDepartmentList)
    End Sub

    Private Sub dgvDepartmentList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartmentList.CellDoubleClick
        frmHR_Setup_AddUpdCompany.isUpdate = True
        frmHR_Setup_AddUpdCompany.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub
End Class