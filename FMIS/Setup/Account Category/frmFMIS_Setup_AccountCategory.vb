Public Class frmFMIS_Setup_AccountCategory

    Private Sub frmFMIS_Setup_AccountCategory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_AccountCategory(dgvAccountCategoryMain)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click

        Call Sel_Setup_AccountCategory(dgvAccountCategoryMain)
        _AccountCategoryID = 0
        _AccountCategoryDetailID = 0
        lblHeader.Text = ""

    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmFMIS_Setup_AddUpdAccountCategory.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If _AccountCategoryID = 0 Then
            MessageBox.Show("Please select category.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        isUpdate = True
        frmFMIS_Setup_AddUpdAccountCategory.ShowDialog()

    End Sub

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvAccountCategoryMain IsNot excludeDataGridView Then
            dgvAccountCategoryMain.ClearSelection()
        End If

        If dgvAccountCategoryDetail IsNot excludeDataGridView Then
            dgvAccountCategoryDetail.ClearSelection()
        End If
    End Sub

    Public Sub ClearDataGridViewSelectionAll()
        dgvAccountCategoryMain.ClearSelection()
        dgvAccountCategoryDetail.ClearSelection()
    End Sub

    Private Sub dgvAccountCategoryMain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccountCategoryMain.CellClick
        UnselectDataGridView(dgvAccountCategoryMain)
        If dgvAccountCategoryMain.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvAccountCategoryMain.SelectedRows(0)
            _AccountCategoryID = selectedRow.Cells(0).Value
            lblHeader.Text = selectedRow.Cells(2).Value
            _AccountCategoryDetailID = 0
            lblCostCenter.Visible = False
            Sel_Setup_AccountCategory_ByTypeID(dgvAccountCategoryDetail)
        End If
    End Sub

    Private Sub dgvAccountCategoryDetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccountCategoryDetail.CellClick
        UnselectDataGridView(dgvAccountCategoryDetail)
        If dgvAccountCategoryDetail.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvAccountCategoryDetail.SelectedRows(0)
            _AccountCategoryDetailID = selectedRow.Cells(0).Value
            lblCostCenter.Text = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub AddNewCategoryDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCategoryDetailToolStripMenuItem.Click
        frmFMIS_Setup_AddUpdAccountCategoryDetail.ShowDialog()
    End Sub

    Private Sub dgvAccountCategoryMain_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccountCategoryMain.CellDoubleClick
        If dgvAccountCategoryMain.SelectedRows.Count > 0 Then
            isUpdate = True
            frmFMIS_Setup_AddUpdAccountCategory.ShowDialog()
        End If
    End Sub

    Private Sub EditThisAccountCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditThisAccountCategoryToolStripMenuItem.Click

        If _AccountCategoryID = 0 OrElse dgvAccountCategoryMain.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select category.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        isUpdate = True
        frmFMIS_Setup_AddUpdAccountCategory.ShowDialog()

    End Sub

    Private Sub DeleteThisAccountCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisAccountCategoryToolStripMenuItem.Click

        If _AccountCategoryID = 0 OrElse dgvAccountCategoryMain.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select category.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Del_Setup_AccountCategory_ByID(dgvAccountCategoryMain, dgvAccountCategoryDetail)

    End Sub

    Private Sub EditThisAccountCategoryDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditThisAccountCategoryDetailToolStripMenuItem.Click

        If _AccountCategoryDetailID = 0 OrElse dgvAccountCategoryDetail.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select category detail.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        isUpdate = True
        frmFMIS_Setup_AddUpdAccountCategoryDetail.ShowDialog()

    End Sub

    Private Sub DeleteThisAccountCategoryDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisAccountCategoryDetailToolStripMenuItem.Click

        If _AccountCategoryDetailID = 0 OrElse dgvAccountCategoryDetail.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select category detail.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Del_Setup_AccountCategoryDetail_ByID(dgvAccountCategoryDetail)

    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Account"
                btnSearchFilter.Text = "Detail"
            Case Else
                btnSearchFilter.Text = "Account"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()

        ' Require 3 chars (unless cleared)
        If keyword.Length < 3 AndAlso keyword <> "" Then Exit Sub

        frmLoading.Show()
        frmLoading.Refresh()

        Try

            Select Case btnSearchFilter.Text
                Case "Account"
                    Call Sel_Setup_AccountCategory(dgvAccountCategoryMain)

                Case Else
                    Call Sel_Setup_AccountCategory_ByTypeID(dgvAccountCategoryDetail)

            End Select

        Finally

            frmLoading.Close()

            If dgvAccountCategoryDetail.Rows.Count = 0 Then
                MessageBox.Show("No records found.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End Try

    End Sub

    Private Sub dgvAccountCategoryMain_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvAccountCategoryMain.RowsRemoved
        toolstriplabelNoOfRecord.Text = dgvAccountCategoryMain.Rows.Count.ToString("N2")
    End Sub

    Private Sub dgvAccountCategoryMain_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvAccountCategoryMain.RowsAdded
        toolstriplabelNoOfRecord.Text = dgvAccountCategoryMain.Rows.Count.ToString("N2")
    End Sub

    Private Sub dgvAccountCategoryDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccountCategoryDetail.CellContentClick

    End Sub

    Private Sub dgvAccountCategoryDetail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccountCategoryDetail.CellDoubleClick

        isUpdate = True
        frmFMIS_Setup_AddUpdAccountCategoryDetail.ShowDialog()

    End Sub

    Private Sub lblCostCenter_TextChanged(sender As Object, e As EventArgs) Handles lblCostCenter.TextChanged
        lblCostCenter.Visible = True
    End Sub



End Class