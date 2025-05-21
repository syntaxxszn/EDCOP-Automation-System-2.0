Public Class frmHR_Setup_JobTitle

    Private Sub frmHR_Setup_JobTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Sel_JobTitle(dgvJobTitleList, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Call Sel_JobTitle(dgvJobTitleList, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        dgvJobTitleList.ClearSelection()
        frmHR_Setup_AddUpdJobTitle.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvJobTitleList.SelectedRows.Count > 0 Then
            frmHR_Setup_AddUpdJobTitle.isUpdate = True
            frmHR_Setup_AddUpdJobTitle.ShowDialog()
        Else
            MessageBox.Show("Please select from the job title table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        txtboxSearch.Clear()
        lblTitleName.Visible = False
        Call Sel_JobTitle(dgvJobTitleList, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub dgvJobTitleList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobTitleList.CellClick
        Call UnselectDataGridView(dgvJobTitleList)
        If dgvJobTitleList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvJobTitleList.SelectedRows(0)
            _strJobTitleID = selectedRow.Cells(0).Value
            lblTitleName.Visible = True
            lblTitleName.Text = "[ " & selectedRow.Cells(1).Value & " ]"
            Call Sel_Employee_ByJobTitleID(dgvEmployeeList)
        End If
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvJobTitleList IsNot excludeDataGridView Then
            dgvJobTitleList.ClearSelection()
        End If

        If dgvEmployeeList IsNot excludeDataGridView Then
            dgvEmployeeList.ClearSelection()
        End If
    End Sub

    Private Sub dgvJobTitleList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobTitleList.CellDoubleClick
        frmHR_Setup_AddUpdJobTitle.isUpdate = True
        frmHR_Setup_AddUpdJobTitle.ShowDialog()
    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick
        Call UnselectDataGridView(dgvEmployeeList)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub
End Class