Public Class frmFMIS_Setup_FiscalPeriod

    Private Sub frmFMIS_Setup_FiscalPeriod_Load(sender As Object, e As EventArgs) Handles Me.Load
        Sel_Setup_FiscalPeriod(dgvFiscalPeriod, toolstriplabelNoOfRecord)
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If Not HasUserAccess("insert") Then Return
        dgvFiscalPeriod.ClearSelection()
        frmFMIS_Setup_AddUpdFiscalPeriod.ShowDialog()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Sel_Setup_FiscalPeriod(dgvFiscalPeriod, toolstriplabelNoOfRecord)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not HasUserAccess("update") Then Return
        If dgvFiscalPeriod.SelectedRows.Count > 0 Then
            isUpdate = True
            frmFMIS_Setup_AddUpdFiscalPeriod.ShowDialog()
        Else
            MessageBox.Show("Please select from the fiscal table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvFiscalPeriod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFiscalPeriod.CellClick
        If dgvFiscalPeriod.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvFiscalPeriod.SelectedRows(0)
            _FiscalPeriodID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub dgvFiscalPeriod_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFiscalPeriod.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmFMIS_Setup_AddUpdFiscalPeriod.ShowDialog()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Sel_Setup_FiscalPeriod(dgvFiscalPeriod, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If Not HasUserAccess("delete") Then Return
        If dgvFiscalPeriod.SelectedRows.Count > 0 Then
            Del_FiscalPeriod_ByID(dgvFiscalPeriod)
        End If
    End Sub

End Class