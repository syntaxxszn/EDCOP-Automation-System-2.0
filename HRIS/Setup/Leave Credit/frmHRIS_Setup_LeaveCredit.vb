Public Class frmHRIS_Setup_LeaveCredit


    Private Sub frmHR_Setup_LeaveCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sel_LeaveCredits(dgvEmployeeList, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Sel_LeaveCredit_ByEmployeeID(dgvLeaveIssuedList)
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmHRIS_Setup_AddUpdLeaveCredit.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            frmHRIS_Setup_AddUpdLeaveCredit.ShowDialog()
        Else
            MessageBox.Show("Please select from the employee table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick
        UnselectDataGridView(dgvEmployeeList)
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            _strEmployeeID = selectedRow.Cells(0).Value
            lblEmployeeName.Visible = True
            lblEmployeeName.Text = "[ " & selectedRow.Cells(1).Value & " ]"
            Sel_LeaveCredit_ByEmployeeID(dgvLeaveIssuedList)
        End If
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvEmployeeList IsNot excludeDataGridView Then
            dgvEmployeeList.ClearSelection()
        End If

        If dgvLeaveIssuedList IsNot excludeDataGridView Then
            dgvLeaveIssuedList.ClearSelection()
        End If
    End Sub

    Private Sub dgvLeaveIssuedList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeaveIssuedList.CellClick
        UnselectDataGridView(dgvLeaveIssuedList)
    End Sub

    Private Sub dgvEmployeeList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellDoubleClick
        frmTK_AddUpdLeaveCredits.ShowDialog()
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Employee"
                btnSearchFilter.Text = "Type"
            Case Else
                btnSearchFilter.Text = "Employee"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If btnSearchFilter.Text = "Employee" Then
            Sel_LeaveCredits(dgvEmployeeList, txtboxSearch, toolstriplabelNoOfRecord)
            dgvLeaveIssuedList.Rows.Clear()
            lblEmployeeName.Visible = False
        Else
            Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
            ' Proceed if a valid grid is found
            If dgvLeaveIssuedList IsNot Nothing Then
                Dim matchFound As Boolean = False
                For Each row As DataGridViewRow In dgvLeaveIssuedList.Rows
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