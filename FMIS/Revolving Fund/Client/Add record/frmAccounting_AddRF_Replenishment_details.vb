Imports System.Windows.Forms


Public Class frmAccounting_AddRF_Replenishment_details

    Private Sub frmAccounting_AddRF_Replenishment_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub txtboxAmount_TextChanged(sender As Object, e As EventArgs) Handles txtBoxCredit.TextChanged

    End Sub

    Private Sub txtboxAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxCredit.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtboxFundUser.TextLength < 5 Then
            MessageBox.Show("Select Fund user.")
        Else
            Insert_FMS_Replenishment_details()

        End If

    End Sub

    Private Sub dgvEmployeeName_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeName.CellContentClick

    End Sub

    Private Sub dgvEmployeeName_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeName.CellClick
        If e.ColumnIndex = -1 Or e.RowIndex = -1 Then Return   ''This code is to prevent from error when clicking header of DGV button. 8/22/2022

        If dgvEmployeeName.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeName.SelectedRows(0)
            txtboxFundUser.Text = dgvEmployeeName.Rows(e.RowIndex).Cells(1).Value.ToString()
            _dgvEmployeeName.Rows.Clear()
        End If

    End Sub

    Private Sub txtboxFundUser_TextChanged(sender As Object, e As EventArgs) Handles txtboxFundUser.TextChanged

    End Sub

    Private Sub txtboxFundUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxFundUser.KeyPress
        Select_FMS_EmployeeList_Search(txtboxFundUser, dgvEmployeeName)
    End Sub

    Private Sub chkboxAdvances_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAdvances.CheckedChanged

        If chkboxAdvances.Checked Then
            _strIsAdvances = 1
        Else
            _strIsAdvances = 0
        End If

    End Sub
End Class
