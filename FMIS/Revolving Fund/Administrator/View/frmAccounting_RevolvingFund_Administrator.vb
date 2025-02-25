Public Class frmAccounting_RevolvingFund_Administrator

    Private Sub frmAccounting_CashFlow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Dispose()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Select_ReplenishmentAmount_Administrator(lblForPayment, dgvReplenishmentAmount, lblAmountOrig)
        Select_FMS_Replenishment_Details_Administrator(dgvCashFlow)

    End Sub


    Private Sub dgvReplenishmentAmount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReplenishmentAmount.CellContentClick

    End Sub

    Private Sub dgvReplenishmentAmount_SelectionChanged(sender As Object, e As EventArgs) Handles dgvReplenishmentAmount.SelectionChanged
        dgvReplenishmentAmount.ClearSelection()
    End Sub

    Private Sub dgvCashFlow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlow.CellContentClick

    End Sub

    Private Sub dgvCashFlow_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlow.CellValueChanged
        '\\ Insert function for Status Drop Down - C\O idea from Jerome . 06/03/2024

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 9 Then
            InsUpd_FMS_Replenishment_ByStatus_Administrator(e.ColumnIndex)
        End If

    End Sub

    Private Sub dgvCashFlow_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvCashFlow.CurrentCellDirtyStateChanged
        If dgvCashFlow.IsCurrentCellDirty Then
            dgvCashFlow.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvCashFlow_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlow.CellClick

        If dgvCashFlow.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCashFlow.SelectedRows(0)
            _strRevolvingFundID = selectedRow.Cells(0).Value
            _strStatus = selectedRow.Cells(10).Value
        End If

    End Sub

    Private Sub dgvCashFlow_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlow.CellDoubleClick
        If dgvCashFlow.SelectedRows.Count > 0 Then

            Dim selectedRow = dgvCashFlow.SelectedRows(0)
            _strRevolvingFundID = selectedRow.Cells(0).Value
            Select_FMS_Replenishment_DetailsByID()
            frmAccounting_RevolvingFund_AcccountValidation.ShowDialog()

        End If
    End Sub


End Class