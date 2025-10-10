Public Class frmHRIS_Setup_Company

    Private Sub frmHR_Setup_Company_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Company(dgvCompanyList)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If Not HasUserAccess("insert") Then Return
        dgvCompanyList.ClearSelection()
        frmHRIS_Setup_AddUpdCompany.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not HasUserAccess("update") Then Return
        If dgvCompanyList.SelectedRows.Count > 0 Then
            isUpdate = True
            frmHRIS_Setup_AddUpdCompany.ShowDialog()
        Else
            MessageBox.Show("Please select from the company table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If Not HasUserAccess("delete") Then Return
        MsgBox("Not Yet Working")
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click

        Select Case btnSearchFilter.Text
            Case "Company"
                btnSearchFilter.Text = "Department"
            Case Else
                btnSearchFilter.Text = "Company"
        End Select
        txtboxSearch.Clear()

    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If btnSearchFilter.Text = "Company" Then
            Call Sel_Company(dgvCompanyList)
            lblCompanyName.Visible = False
            dgvDepartmentList.Rows.Clear()
        Else
            Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
            ' Proceed if a valid grid is found
            If dgvDepartmentList IsNot Nothing Then
                Dim matchFound As Boolean = False
                For Each row As DataGridViewRow In dgvDepartmentList.Rows
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

    Private Sub dgvCompanyList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompanyList.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmHRIS_Setup_AddUpdCompany.ShowDialog()
    End Sub


End Class