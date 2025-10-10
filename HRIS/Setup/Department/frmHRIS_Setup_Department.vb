Public Class frmHRIS_Setup_Department

    Private Sub frmHR_Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sel_Department(dgvDepartmentList, txtboxSearch)
        If Not HasUserAccess("view") Then Return
        Call Sel_Department(dgvMainDepartment, txtboxSearch)
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If Not HasUserAccess("insert") Then Return
        dgvMainDepartment.ClearSelection()
        frmHRIS_Setup_AddUpdDepartment.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not HasUserAccess("update") Then Return
        If dgvMainDepartment.SelectedRows.Count > 0 Then
            isUpdate = True
            frmHRIS_Setup_AddUpdDepartment.ShowDialog()
        Else
            MessageBox.Show("Please select from the department table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Department(dgvMainDepartment, txtboxSearch)
        dgvEmployeeList.Rows.Clear()
        lblEmployeeName.Visible = False
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvDivisionHistory IsNot excludeDataGridView Then
            dgvDivisionHistory.ClearSelection()
        End If

        If dgvEmployeeList IsNot excludeDataGridView Then
            dgvEmployeeList.ClearSelection()
        End If

        If dgvMainDepartment IsNot excludeDataGridView Then
            dgvMainDepartment.ClearSelection()
        End If
    End Sub

    Private Sub UpdateRowCount()
        Dim rowCount As Integer = dgvMainDepartment.Rows.Count - If(dgvMainDepartment.AllowUserToAddRows, 1, 0)
        toolstriplabelNoOfRecord.Text = rowCount.ToString()
    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick
        UnselectDataGridView(dgvEmployeeList)
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            lblEmployeeName.Visible = True
            lblEmployeeName.Text = "[ " & selectedRow.Cells(2).Value & " ]"
        End If
    End Sub


    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Division"
                btnSearchFilter.Text = "Employee"
            Case Else
                btnSearchFilter.Text = "Division"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If btnSearchFilter.Text = "Division" Then
            Call Sel_Department(dgvMainDepartment, txtboxSearch)
            dgvEmployeeList.Rows.Clear()
            lblEmployeeName.Visible = False
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

    Private Sub dgvMainDepartment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMainDepartment.CellContentClick

    End Sub

    Private Sub dgvMainDepartment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMainDepartment.CellClick
        UnselectDataGridView(dgvMainDepartment)
        If dgvMainDepartment.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvMainDepartment.SelectedRows(0)
            _strDepartmentID = selectedRow.Cells(0).Value
            _strParentDepartmentID = selectedRow.Cells(1).Value
            lblDivisionListName.Visible = True
            lblDivisionListName.Text = "[ " & selectedRow.Cells(2).Value & " ]"
            Sel_DepartmentHistory(dgvDivisionHistory)
            Sel_Employee_ByDepartmentID(dgvEmployeeList)
        End If
    End Sub

    Private Sub dgvMainDepartment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMainDepartment.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmHRIS_Setup_AddUpdDepartment.ShowDialog()
    End Sub

    Private Sub dgvMainDepartment_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvMainDepartment.RowsAdded
        UpdateRowCount()
    End Sub

    Private Sub dgvMainDepartment_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvMainDepartment.RowsRemoved
        UpdateRowCount()
    End Sub
End Class
