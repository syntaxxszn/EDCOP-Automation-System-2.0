Public Class frmFMIS_Setup_TaxRates

    Private Sub frmFMIS_Setup_TaxRates_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_TaxRates(dgvTaxRates, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_TaxRates(dgvTaxRates, toolstriplabelNoOfRecord)
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

    End Sub
End Class