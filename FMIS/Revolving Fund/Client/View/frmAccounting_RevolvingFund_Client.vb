Imports System.Data.SqlClient
Public Class frmAccounting_RevolvingFund_Client


    Private Sub frmAccounting_CashFlow_Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvCashFlow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlow.CellContentClick

    End Sub

    Private Sub dgvCashFlow_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlow.CellClick

        If dgvCashFlow.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCashFlow.SelectedRows(0)
            _strRevolvingFundID = selectedRow.Cells(0).Value
            _strStatus = selectedRow.Cells(7).Value
        End If

    End Sub

    Private Sub dgvCashFlow_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlow.CellDoubleClick

        '\\ Check if the _strStatus Is 966 (Submitted).
        If _strStatus = 966 Then
            MessageBox.Show("Cannot edit Submitted record.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SelUpd_FMS_Replenishment_Details()
            frmAccounting_UpdateRF_Replenishment_details.ShowDialog()
        End If

    End Sub

    Private Sub dgvCashFlow_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvCashFlow.CurrentCellDirtyStateChanged

        If dgvCashFlow.IsCurrentCellDirty Then
            dgvCashFlow.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Sub dgvCashFlow_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvCashFlow.CellBeginEdit

        If dgvCashFlow.CurrentRow.Cells(7).Value.ToString() = 966 Then
            MessageBox.Show("Cannot edit Submitted record.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        End If

    End Sub

    Private Sub dgvCashFlow_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlow.CellValueChanged

        '\\ Insert function for Status Drop Down - C\O idea from Jerome . 06/03/2024

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 6 Then
            InsertUpdate_FMS_Replenishment_ByStatus(e.ColumnIndex)
        End If

    End Sub

    Private Sub btnAddNewReplenishAmount_Click(sender As Object, e As EventArgs) Handles btnAddNewReplenishAmount.Click
        frmAccounting_AddRF_ReplenishmentAmount.ShowDialog()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Select_ReplenishmentAmount_Individual(lblAmountOrig, dgvReplenishmentAmount)
        Select_FMS_Replenishment_Details(dgvCashFlow)
    End Sub

    Private Sub dgvReplenishmentAmount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReplenishmentAmount.CellContentClick

    End Sub

    Private Sub dgvReplenishmentAmount_SelectionChanged(sender As Object, e As EventArgs) Handles dgvReplenishmentAmount.SelectionChanged

        dgvReplenishmentAmount.ClearSelection()

    End Sub


    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click

        Me.Dispose()

    End Sub

    Private Sub btnAddNewRF_Click(sender As Object, e As EventArgs) Handles btnAddNewRF.Click

        'If frmAccounting_AddRF_ReplenishmentAmount.txtboxReplenishmentAmount.Text = Nothing Then
        '    MessageBox.Show("Please input Initial Value ")
        'Else
        Select_CashFlowID()
        frmAccounting_AddRF_Replenishment_details.ShowDialog()
        ' End If

    End Sub

    Private Sub btnListOfAdvances_Click(sender As Object, e As EventArgs) Handles btnListOfAdvances.Click
        Select_FMS_Replenishment_AdvancesDetails(frmAccounting_RevolvingFund_Advances.dgvAdvances)

        frmAccounting_RevolvingFund_Advances.ShowDialog()
    End Sub
End Class