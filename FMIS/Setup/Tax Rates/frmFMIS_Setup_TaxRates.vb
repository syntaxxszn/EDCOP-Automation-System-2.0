Public Class frmFMIS_Setup_TaxRates

    Private Sub frmFMIS_Setup_TaxRates_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_TaxRates(dgvTaxRates, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_TaxRates(dgvTaxRates, toolstriplabelNoOfRecord)
        lblHeader.Text = ""
        TaxRateID = 0
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvTaxRates_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTaxRates.CellContentClick

    End Sub

    Private Sub dgvTaxRates_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTaxRates.CellClick
        If dgvTaxRates.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvTaxRates.SelectedRows(0)
            TaxRateID = selectedRow.Cells(0).Value
            lblHeader.Text = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        dgvTaxRates.ClearSelection()
        frmFMIS_Setup_AddUpdTaxRates.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TaxRateID = 0 Then Exit Sub
        isUpdate = True
        frmFMIS_Setup_AddUpdTaxRates.ShowDialog()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()

        ' Select grid based on filter
        Dim targetGrid As DataGridView =
        If(btnSearchFilter.Text = "Name", dgvTaxRates, Nothing)

        If targetGrid Is Nothing Then Exit Sub

        ' Require at least 3 chars unless cleared
        If keyword.Length < 3 AndAlso keyword <> "" Then Exit Sub

        frmLoading.Show()
        frmLoading.Refresh()

        Dim matchFound As Boolean = False

        For Each row As DataGridViewRow In targetGrid.Rows
            If row.IsNewRow Then Continue For

            If keyword = "" Then
                row.Visible = True
                matchFound = True
                Continue For
            End If

            Dim cellValue As String = If(row.Cells(2).Value, "").ToString().ToLower()
            Dim isMatch As Boolean = cellValue.Contains(keyword)

            row.Visible = isMatch
            If isMatch Then matchFound = True
        Next

        frmLoading.Close()

        ' Show only ONCE after filtering, not on every keystroke
        If Not matchFound AndAlso keyword <> "" Then
            MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub dgvTaxRates_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTaxRates.CellDoubleClick
        isUpdate = True
        frmFMIS_Setup_AddUpdTaxRates.ShowDialog()
    End Sub

End Class