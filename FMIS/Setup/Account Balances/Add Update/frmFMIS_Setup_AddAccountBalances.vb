Imports System.ComponentModel

Public Class frmFMIS_Setup_AddAccountBalances

    Public isExist As Boolean = False

    Private Sub frmFMIS_Setup_AddAccountBalances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Sel_Setup_AccountBalances_Ins(dgvDecemberAudited)
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        btnSave.Enabled = False
    End Sub

    Private Sub txtYear_Validating(sender As Object, e As CancelEventArgs) Handles txtYear.Validating

        Sel_AccountBalances_Year_ifNonExistence(txtYear)
        If isExist Then
            MessageBox.Show("This year exists in the database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
            Return
        End If

        btnSave.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If isExist Then
            MessageBox.Show("This year exists in the database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Call Ins_Setup_Account_Balances(dgvDecemberAudited, txtYear)
        Call Sel_Setup_AccountBalances_Ins(dgvDecemberAudited)

    End Sub

    Private Sub dgvDecemberAudited_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDecemberAudited.CellClick

    End Sub

    Private Sub dgvDecemberAudited_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDecemberAudited.CellEndEdit

        If e.ColumnIndex = 3 OrElse e.ColumnIndex = 4 Then

            Dim cell = dgvDecemberAudited.Rows(e.RowIndex).Cells(e.ColumnIndex)

            If IsNumeric(cell.Value) Then
                cell.Value = FormatNumber(cell.Value, 2)
            Else
                MessageBox.Show("This column only accepts digit or number.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cell.Value = "0.00"
            End If

        End If

    End Sub

    Private Sub frmFMIS_Setup_AddAccountBalances_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        isExist = False
        btnSave.Enabled = False
        ClearDataGridViewRows(Me)
        txtYear.Clear()
        Call Sel_Setup_AccountBalances_ByID(frmFMIS_Setup_AccountBalances.dgvDecemberAudited, 0)

    End Sub

End Class