Imports System.Windows.Forms

Public Class frmAccounting_RevolvingFund_Advances

    Private Sub frmAccounting_RevolvingFund_Advances_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvAdvances_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdvances.CellValueChanged
        '\\ Insert function for Status Drop Down - C\O idea from Jerome . 06/22/2024

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 6 Then
            InsertUpdate_FMS_Advances_ByStatus(e.ColumnIndex)
        End If
    End Sub

    Private Sub dgvAdvances_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvAdvances.CurrentCellDirtyStateChanged
        If dgvAdvances.IsCurrentCellDirty Then
            dgvAdvances.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvAdvances_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdvances.CellContentClick

    End Sub

    Private Sub dgvAdvances_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdvances.CellClick

        If dgvAdvances.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvAdvances.SelectedRows(0)
            _strRevolvingFundID = selectedRow.Cells(0).Value
        End If

    End Sub
End Class
