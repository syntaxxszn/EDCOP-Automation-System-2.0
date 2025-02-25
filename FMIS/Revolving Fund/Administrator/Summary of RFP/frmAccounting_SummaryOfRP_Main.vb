Public Class frmAccounting_SummaryOfRP_Main
    Private Sub frmAccounting_SummaryOfRP_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Dispose()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click

        Select_SummaryOfRP(dgvSummaryOfRFP)
        Select_SummaryOfRP_PaidAccounts(dgvSummaryOfRFP_PaidAccounts)

    End Sub

    Private Sub dgvSummaryOfRFP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSummaryOfRFP.CellContentClick

    End Sub

    Private Sub dgvSummaryOfRFP_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSummaryOfRFP.CellDoubleClick

        If dgvSummaryOfRFP.SelectedRows.Count > 0 Then

            Dim selectedRow = dgvSummaryOfRFP.SelectedRows(0)
            _strRFPVoucherID = selectedRow.Cells(0).Value
            SelUpd_FMS_SummaryOfRP_ByID(frmAccounting_SummaryOfRP_Preview.dgvSummaryOfRFP, frmAccounting_SummaryOfRP_Preview.lblReferenceNo, frmAccounting_SummaryOfRP_Preview.lblDate, frmAccounting_SummaryOfRP_Preview.ToolStripLabelTotal, frmAccounting_SummaryOfRP_Preview.txtboxJV)
            frmAccounting_SummaryOfRP_Preview.ShowDialog()

        End If

    End Sub

    Private Sub dgvSummaryOfRFP_PaidAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSummaryOfRFP_PaidAccounts.CellContentClick

    End Sub

    Private Sub dgvSummaryOfRFP_PaidAccounts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSummaryOfRFP_PaidAccounts.CellDoubleClick

        If dgvSummaryOfRFP_PaidAccounts.SelectedRows.Count > 0 Then

            Dim selectedRow = dgvSummaryOfRFP_PaidAccounts.SelectedRows(0)
            _strRFPVoucherID = selectedRow.Cells(0).Value
            SelUpd_FMS_SummaryOfRP_ByPaidAccounts(frmAccounting_SummaryOfRP_Preview.dgvSummaryOfRFP, frmAccounting_SummaryOfRP_Preview.lblReferenceNo, frmAccounting_SummaryOfRP_Preview.lblDate, frmAccounting_SummaryOfRP_Preview.ToolStripLabelTotal, frmAccounting_SummaryOfRP_Preview.txtboxJV)
            frmAccounting_SummaryOfRP_Preview.ShowDialog()

        End If

    End Sub
End Class