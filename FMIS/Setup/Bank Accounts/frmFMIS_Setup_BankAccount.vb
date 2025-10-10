Public Class frmFMIS_Setup_BankAccount

    Private Sub frmFMIS_Setup_BankAccount_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_BankAccounts(dgvBankAccount)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_BankAccounts(dgvBankAccount)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvBankAccount IsNot excludeDataGridView Then
            dgvBankAccount.ClearSelection()
        End If

        If dgvBankAccountDetail IsNot excludeDataGridView Then
            dgvBankAccountDetail.ClearSelection()
        End If
    End Sub

    Private Sub dgvBankAccount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBankAccount.CellContentClick

    End Sub

    Private Sub dgvBankAccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBankAccount.CellClick
        UnselectDataGridView(dgvBankAccount)
        If dgvBankAccount.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvBankAccount.SelectedRows(0)
            BankID = selectedRow.Cells(0).Value
            Sel_Setup_BankAccounts_ByID(dgvBankAccountDetail)
        End If
    End Sub

End Class