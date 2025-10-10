Public Class frmFMIS_Setup_ChartOfAccounts_Internal

    Private Sub frmFMIS_Setup_ChartOfAccounts_Internal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click

    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvAccountType IsNot excludeDataGridView Then
            dgvAccountType.ClearSelection()
        End If

        If dgvLevel1 IsNot excludeDataGridView Then
            dgvLevel1.ClearSelection()
        End If

        If dgvLevel2 IsNot excludeDataGridView Then
            dgvLevel2.ClearSelection()
        End If

        If dgvLevel3 IsNot excludeDataGridView Then
            dgvLevel3.ClearSelection()
        End If
    End Sub

    Private Sub dgvAccountType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccountType.CellClick

    End Sub

End Class