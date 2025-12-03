Public Class frmFMIS_Setup_TransactionClosing

    Private Sub frmFMIS_Setup_TransactionClosing_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_Transaction_Closing(dgvTransactionDate, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_Transaction_Closing(dgvTransactionDate, toolstriplabelNoOfRecord)
        lblHeader.Text = ""
        TransactionClosingID = 0
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvTransactionDate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionDate.CellContentClick

    End Sub

    Private Sub dgvTransactionDate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionDate.CellClick
        If dgvTransactionDate.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvTransactionDate.SelectedRows(0)
            TransactionClosingID = selectedRow.Cells(0).Value
            lblHeader.Text = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        dgvTransactionDate.ClearSelection()
        frmFMIS_Setup_AddUpdTransactionClosing.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        isUpdate = True
        If dgvTransactionDate.SelectedRows.Count > 0 Then
            frmFMIS_Setup_AddUpdTransactionClosing.ShowDialog()
        Else
            isUpdate = False
            MessageBox.Show("Select an item before starting to edit.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvTransactionDate_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionDate.CellDoubleClick
        isUpdate = True
        frmFMIS_Setup_AddUpdTransactionClosing.ShowDialog()
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click

    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()

        ' Require 3 chars (unless cleared)
        If keyword.Length < 3 AndAlso keyword <> "" Then Exit Sub

        frmLoading.Show()
        frmLoading.Refresh()

        Try
            Call Sel_Setup_Transaction_Closing(dgvTransactionDate, toolstriplabelNoOfRecord)
        Finally
            frmLoading.Close()
        End Try

    End Sub

End Class