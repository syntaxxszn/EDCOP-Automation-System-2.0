Public Class frmHRIS_Setup_Department

    Private Sub frmHR_Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sel_Department(dgvDepartmentList, txtboxSearch)
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        dgvDepartmentList.ClearSelection()
        frmHRIS_Setup_AddUpdDepartment.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvDepartmentList.SelectedRows.Count > 0 Then
            frmHRIS_Setup_AddUpdDepartment.isUpdate = True
            frmHRIS_Setup_AddUpdDepartment.ShowDialog()
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
        frmHRIS_Setup_AddUpdDepartment.isUpdate = True
        frmHRIS_Setup_AddUpdDepartment.ShowDialog()
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Department"
                btnSearchFilter.Text = "Employee"
            Case Else
                btnSearchFilter.Text = "Department"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If btnSearchFilter.Text = "Department" Then
            Search_DGVDepartment(dgvDepartmentList, txtboxSearch)
            dgvEmployeeList.Rows.Clear()
            lblDepartmentName.Visible = False
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
                            Dim cellValue As String = row.Cells(2).Value?.ToString().ToLower()
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