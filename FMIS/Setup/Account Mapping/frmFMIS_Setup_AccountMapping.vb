Public Class frmFMIS_Setup_AccountMapping

    Private Sub frmFMIS_Setup_AccountMapping_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_AccountMapping(dgvMapping, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_AccountMapping(dgvMapping, toolstriplabelNoOfRecord)
        AccountMappingInternal = ""
        lblHeader.Text = ""
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        dgvMapping.ClearSelection()
        frmFMIS_Setup_AddUpdAccountMapping.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvMapping.SelectedRows.Count > 0 Then
            isUpdate = True
            frmFMIS_Setup_AddUpdAccountMapping.ShowDialog()
        End If
    End Sub

    Private Sub dgvMapping_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMapping.CellContentClick

    End Sub

    Private Sub dgvMapping_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMapping.CellClick
        If dgvMapping.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvMapping.SelectedRows(0)
            AccountMappingInternal = selectedRow.Cells(2).Value
            lblHeader.Text = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub dgvMapping_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMapping.CellDoubleClick
        isUpdate = True
        frmFMIS_Setup_AddUpdAccountMapping.ShowDialog()
        'MsgBox(AccountMappingInternal)
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Call Sel_Setup_AccountMapping(dgvMapping, toolstriplabelNoOfRecord)
    End Sub

End Class