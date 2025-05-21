Public Class frmHR_Setup_ApprovalHierarchy

    Private Sub frmHR_Setup_ApprovalHierarchy_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_ApprovalHierarchy(dgvApprovalList, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Employee_ByHierarchyID(dgvEmployeeList)
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmHR_Setup_AddUpdApprovalHierarchy.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvApprovalList.SelectedRows.Count > 0 Then
            frmHR_Setup_AddUpdApprovalHierarchy.isUpdate = True
            frmHR_Setup_AddUpdApprovalHierarchy.ShowDialog()
        Else
            MessageBox.Show("Please select from the hierarchy table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Call Sel_ApprovalHierarchy(dgvApprovalList, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub dgvApprovalList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApprovalList.CellClick
        Call UnselectDataGridView(dgvApprovalList)
        If dgvApprovalList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvApprovalList.SelectedRows(0)
            _strHierarchyID = selectedRow.Cells(0).Value
            lblTitleName.Visible = True
            lblTitleName.Text = "[ " & selectedRow.Cells(1).Value & " ]"
            Call Sel_Employee_ByHierarchyID(dgvEmployeeList)
        End If
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvApprovalList IsNot excludeDataGridView Then
            dgvApprovalList.ClearSelection()
        End If

        If dgvEmployeeList IsNot excludeDataGridView Then
            dgvEmployeeList.ClearSelection()
        End If
    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick
        Call UnselectDataGridView(dgvEmployeeList)
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            _strHierarchyDetailID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub dgvApprovalList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApprovalList.CellDoubleClick
        frmHR_Setup_AddUpdApprovalHierarchy.isUpdate = True
        frmHR_Setup_AddUpdApprovalHierarchy.ShowDialog()
    End Sub

    Private Sub AddNewReviewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewReviewerToolStripMenuItem.Click
        frmHR_Setup_AddUpdApprovalHierarchyDetail.ShowDialog()
    End Sub

    Private Sub EditNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditNameToolStripMenuItem.Click
        frmHR_Setup_AddUpdApprovalHierarchyDetail.isUpdate = True
        frmHR_Setup_AddUpdApprovalHierarchyDetail.ShowDialog()
    End Sub

    Private Sub dgvEmployeeList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellDoubleClick
        frmHR_Setup_AddUpdApprovalHierarchyDetail.isUpdate = True
        frmHR_Setup_AddUpdApprovalHierarchyDetail.ShowDialog()
    End Sub


End Class