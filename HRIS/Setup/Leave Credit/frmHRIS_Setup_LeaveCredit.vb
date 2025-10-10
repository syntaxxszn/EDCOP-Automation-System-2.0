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
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            If Not HasUserAccess("insert") Then Return
            frmHRIS_Setup_AddUpdLeaveCredit.ShowDialog()
        Else
            MessageBox.Show("Please select from the employee table before starting to create.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            If Not HasUserAccess("update") Then Return
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
        If dgvLeaveIssuedList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvLeaveIssuedList.SelectedRows(0)
            _LeaveTypeID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub dgvEmployeeList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        frmHRIS_Setup_AddUpdLeaveCredit.ShowDialog()
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

    Private Sub GetEmployeeCreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetEmployeeCreditsToolStripMenuItem.Click
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            frmHRIS_Setup_SelectDateLeaveCredit.ShowDialog()
        End If
    End Sub

    Private Sub ViewLeaveCreditDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLeaveCreditDetailsToolStripMenuItem.Click
        If _LeaveTypeID <> 1 AndAlso _LeaveTypeID <> 2 Then
            MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        frmHRIS_Setup_PreviewLeaveBalances.ShowDialog()
    End Sub

    Private Sub ViewLeaveTakenDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLeaveTakenDetailsToolStripMenuItem.Click
        frmHRIS_Setup_PreviewLeaveTaken.ShowDialog()
    End Sub

    Private Sub SetPreviousToConvertedToCashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetPreviousToConvertedToCashToolStripMenuItem.Click
        If dgvLeaveIssuedList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvLeaveIssuedList.SelectedRows(0)
            Dim stat = If(selectedRow.Cells(5).Value.ToString() = "Yes", 0, 1)
            Upd_Employee_Leave_Credits_isPayrollProcessed(DateTime.Now.AddYears(-1), stat, selectedRow.Cells(0).Value)
        End If
    End Sub

    Private Sub ContextMenuStripViewDetail_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripViewDetail.Opening
        If dgvLeaveIssuedList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvLeaveIssuedList.SelectedRows(0)
            Dim validIDs As Integer() = {1, 3, 7, 13, 14, 15}
            Dim cellValue As Integer = CInt(selectedRow.Cells(0).Value)

            SetPreviousToConvertedToCashToolStripMenuItem.Enabled = validIDs.Contains(cellValue)
        End If
    End Sub

End Class