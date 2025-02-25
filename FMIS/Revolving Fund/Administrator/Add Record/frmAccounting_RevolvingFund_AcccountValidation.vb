Imports System.Windows.Forms

Public Class frmAccounting_RevolvingFund_AcccountValidation

    Private Sub frmAccounting_CashFlow_AcccountValidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Insert_FMS_Replenishment_FinalCredit_details()
    End Sub

    Private Sub txtBoxCredit_TextChanged(sender As Object, e As EventArgs) Handles txtBoxCredit.TextChanged

    End Sub

    Private Sub txtBoxCredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxCredit.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txtBoxRFPVoucher_TextChanged(sender As Object, e As EventArgs) Handles txtBoxRFPVoucher.TextChanged

    End Sub

    Private Sub txtBoxRFPVoucher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxRFPVoucher.KeyPress
        Select_FMS_RFPVoucher_Search(txtBoxRFPVoucher, dgvRFPVoucher)
    End Sub

    Private Sub dgvRFPVoucher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRFPVoucher.CellContentClick

    End Sub

    Private Sub dgvRFPVoucher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRFPVoucher.CellClick
        If e.ColumnIndex = -1 Or e.RowIndex = -1 Then Return   ''This code is to prevent from error when clicking header of DGV button. 8/22/2022

        If dgvRFPVoucher.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvRFPVoucher.SelectedRows(0)
            txtBoxRFPVoucher.Text = dgvRFPVoucher.Rows(e.RowIndex).Cells(1).Value.ToString()
            dgvRFPVoucher.Rows.Clear()
        End If
    End Sub
End Class
