Public Class frmFMIS_CashJournal_RequestForPayment

    Private Sub frmFMIS_CashJournal_RequestForPayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_CashJournal_RequestForPaymentVoucher(dgvRequestVoucher, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_CashJournal_RequestForPaymentVoucher(dgvRequestVoucher, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvRequestVoucher IsNot excludeDataGridView Then
            dgvRequestVoucher.ClearSelection()
        End If

        If dgvRequestVoucherDetail IsNot excludeDataGridView Then
            dgvRequestVoucherDetail.ClearSelection()
        End If
    End Sub

    Private Sub dgvRequestVoucher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequestVoucher.CellContentClick

    End Sub

    Private Sub dgvRequestVoucher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequestVoucher.CellClick
        UnselectDataGridView(dgvRequestVoucher)
        If dgvRequestVoucher.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvRequestVoucher.SelectedRows(0)
            RequestVoucherID = selectedRow.Cells(0).Value
            lblHeader.Text = selectedRow.Cells(1).Value
            RequestVoucherDetailID = 0
            lblDetail.Visible = False
            Call Sel_CashJournal_RequestForPaymentVoucher_Detail_ByID(dgvRequestVoucherDetail, 1)
        End If
    End Sub

    Private Sub dgvRequestVoucherDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequestVoucherDetail.CellContentClick

    End Sub

    Private Sub dgvRequestVoucherDetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequestVoucherDetail.CellClick
        UnselectDataGridView(dgvRequestVoucherDetail)
        If dgvRequestVoucherDetail.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvRequestVoucherDetail.SelectedRows(0)
            RequestVoucherDetailID = selectedRow.Cells(0).Value
            lblDetail.Text = selectedRow.Cells(2).Value
        End If
    End Sub

    Private Sub lblDetail_TextChanged(sender As Object, e As EventArgs) Handles lblDetail.TextChanged
        lblDetail.Visible = True
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmFMIS_CashJournal_AddUpdateRequestForPayment.ShowDialog()
    End Sub
End Class