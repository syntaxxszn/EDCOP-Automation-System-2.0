Public Class frmFMIS_Setup_BeginningProject

    Private Sub frmFMIS_Setup_BeginningProject_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_BeginningProject(dgvProjectList, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_BeginningProject(dgvProjectList, toolstriplabelNoOfRecord)
        lblHeader.Text = ""
        BeginProjectID = 0
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvProjectList IsNot excludeDataGridView Then
            dgvProjectList.ClearSelection()
        End If

        If dgvProjectDetail IsNot excludeDataGridView Then
            dgvProjectDetail.ClearSelection()
        End If
    End Sub

    Private Sub dgvProjectList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectList.CellContentClick

    End Sub

    Private Sub dgvProjectList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectList.CellClick
        UnselectDataGridView(dgvProjectList)
        If dgvProjectList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvProjectList.SelectedRows(0)
            BeginProjectID = selectedRow.Cells(0).Value
            lblHeader.Text = selectedRow.Cells(1).Value
            frmFMIS_Setup_AddUpdProjectDetail.txtProjectName.Text = selectedRow.Cells(1).Value & " " & selectedRow.Cells(2).Value
            SupplierAccountID = 0
            lblDetail.Visible = False
            Call Sel_Setup_BeginningProject_Detail_ByID(dgvProjectDetail)
        End If
    End Sub

    Private Sub dgvProjectDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectDetail.CellContentClick

    End Sub

    Private Sub dgvProjectDetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectDetail.CellClick
        UnselectDataGridView(dgvProjectDetail)
        If dgvProjectDetail.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvProjectDetail.SelectedRows(0)
            BeginProjectDetailID = selectedRow.Cells(0).Value
            lblDetail.Text = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub lblDetail_TextChanged(sender As Object, e As EventArgs) Handles lblDetail.TextChanged
        lblDetail.Visible = True
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If dgvProjectDetail.SelectedRows.Count > 0 Then
            isUpdate = False
            frmFMIS_Setup_AddUpdProjectDetail.ShowDialog()
        Else
            frmFMIS_Setup_AddUpdProjectList.ShowDialog()
        End If
    End Sub

    Private Sub AddNewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewAccountToolStripMenuItem.Click
        isUpdate = False
        frmFMIS_Setup_AddUpdProjectDetail.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        isUpdate = True
        If dgvProjectDetail.SelectedRows.Count > 0 AndAlso BeginProjectID <> 0 Then
            frmFMIS_Setup_AddUpdProjectDetail.ShowDialog()
        Else
            MessageBox.Show("Unknown Action.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isUpdate = False
        End If
    End Sub

    Private Sub EditProjectDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProjectDetailToolStripMenuItem.Click
        If BeginProjectID = 0 Then Return
        isUpdate = True
        frmFMIS_Setup_AddUpdProjectDetail.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "List"
                btnSearchFilter.Text = "Detail"
            Case Else
                btnSearchFilter.Text = "List"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
        Dim targetGrid As DataGridView = Nothing

        ' Determine target grid
        Select Case btnSearchFilter.Text
            Case "List"
                targetGrid = dgvProjectList
                dgvProjectDetail.Rows.Clear()

            Case "Detail"
                targetGrid = dgvProjectDetail
        End Select

        If targetGrid Is Nothing Then Exit Sub

        ' Require 3 chars (unless cleared)
        If keyword.Length < 3 AndAlso keyword <> "" Then Exit Sub

        frmLoading.Show()
        frmLoading.Refresh()

        Try
            targetGrid.Visible = True
            Dim matchFound As Boolean = False

            For Each row As DataGridViewRow In targetGrid.Rows
                If row.IsNewRow Then Continue For

                If keyword = "" Then
                    row.Visible = True
                    matchFound = True
                Else

                    Dim cellValue As String = ""

                    Select Case btnSearchFilter.Text
                        Case "List"
                            cellValue = If(row.Cells(1).Value, "").ToString().ToLower()
                        Case "Detail"
                            cellValue = If(row.Cells(0).Value, "").ToString().ToLower()
                    End Select

                    Dim isMatch As Boolean = cellValue.Contains(keyword)
                    row.Visible = isMatch
                    If isMatch Then matchFound = True

                End If
            Next

            frmLoading.Close()

            If Not matchFound AndAlso keyword <> "" Then
                MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Finally

        End Try

    End Sub
End Class