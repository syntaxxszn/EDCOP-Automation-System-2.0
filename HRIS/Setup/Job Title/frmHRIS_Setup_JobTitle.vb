Public Class frmHRIS_Setup_JobTitle

    Private Sub frmHR_Setup_JobTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Sel_JobTitle(dgvJobTitleList, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If Not HasUserAccess("insert") Then Return
        dgvJobTitleList.ClearSelection()
        frmHRIS_Setup_AddUpdJobTitle.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not HasUserAccess("update") Then Return
        If dgvJobTitleList.SelectedRows.Count > 0 Then
            isUpdate = True
            frmHRIS_Setup_AddUpdJobTitle.ShowDialog()
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
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmHRIS_Setup_AddUpdJobTitle.ShowDialog()
    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick
        Call UnselectDataGridView(dgvEmployeeList)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If Not HasUserAccess("delete") Then Return
        MessageBox.Show("On-going process.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Job Title"
                btnSearchFilter.Text = "Employee"
            Case Else
                btnSearchFilter.Text = "Job Title"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If btnSearchFilter.Text = "Job Title" Then
            Call Sel_JobTitle(dgvJobTitleList, txtboxSearch, toolstriplabelNoOfRecord)
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
End Class