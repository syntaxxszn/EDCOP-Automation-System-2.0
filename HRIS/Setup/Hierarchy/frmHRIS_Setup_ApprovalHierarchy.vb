Public Class frmHRIS_Setup_ApprovalHierarchy

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
        If Not HasUserAccess("insert") Then Return
        frmHRIS_Setup_AddUpdApprovalHierarchy.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvApprovalList.SelectedRows.Count > 0 Then
            If Not HasUserAccess("update") Then Return
            isUpdate = True
            frmHRIS_Setup_AddUpdApprovalHierarchy.ShowDialog()
        Else
            MessageBox.Show("Please select from the hierarchy table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmHRIS_Setup_AddUpdApprovalHierarchy.ShowDialog()
    End Sub

    Private Sub AddNewReviewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewReviewerToolStripMenuItem.Click
        If Not HasUserAccess("insert") Then Return
        frmHRIS_Setup_AddUpdApprovalHierarchyDetail.ShowDialog()
    End Sub

    Private Sub EditNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditNameToolStripMenuItem.Click
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmHRIS_Setup_AddUpdApprovalHierarchyDetail.ShowDialog()
    End Sub

    Private Sub dgvEmployeeList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmHRIS_Setup_AddUpdApprovalHierarchyDetail.ShowDialog()
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Hierarchy"
                btnSearchFilter.Text = "Employee"
            Case Else
                btnSearchFilter.Text = "Hierarchy"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If btnSearchFilter.Text = "Hierarchy" Then
            Call Sel_ApprovalHierarchy(dgvApprovalList, txtboxSearch, toolstriplabelNoOfRecord)
            lblTitleName.Visible = False
            dgvEmployeeList.Rows.Clear()
        Else
            Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
            ' Proceed if a valid grid is found
            If dgvEmployeeList IsNot Nothing Then
                Dim matchFound As Boolean = False
                For Each row As DataGridViewRow In dgvEmployeeList.Rows
                    If Not row.IsNewRow Then
                        If keyword = "" Then
                            row.Visible = True
                            matchFound = True
                        Else
                            Dim cellValue As String = row.Cells(1).Value?.ToString().ToLower()
                            Dim isMatch As Boolean = (cellValue IsNot Nothing AndAlso cellValue.Contains(keyword))
                            row.Visible = isMatch
                            If isMatch Then matchFound = True
                        End If
                    End If
                Next
                ' Show message if no match found and keyword is not empty
                If Not matchFound AndAlso keyword <> "" Then
                    MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If Not HasUserAccess("delete") Then Return
        MessageBox.Show("On-going process.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If Not HasUserAccess("delete") Then Return
        MessageBox.Show("On-going process.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class