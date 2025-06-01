Public Class frmHRIS_Options_MainView
    Private Sub frmHR_Options_MainView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Sel_SystemSetting_ByModule(dgvSystemSettings, txtboxSearch, toolstriplabelNoOfRecord, "HR")
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Sel_SystemSetting_ByModule(dgvSystemSettings, txtboxSearch, toolstriplabelNoOfRecord, "HR")
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Sel_SystemSetting_ByModule(dgvSystemSettings, txtboxSearch, toolstriplabelNoOfRecord, "HR")
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        dgvSystemSettings.ClearSelection()
        frmHRIS_Options_AddUpdSystemSettings.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvSystemSettings.SelectedRows.Count > 0 Then
            frmHRIS_Options_AddUpdSystemSettings.isUpdate = True
            frmHRIS_Options_AddUpdSystemSettings.ShowDialog()
        Else
            MessageBox.Show("Please select from the table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvSystemSettings_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSystemSettings.CellClick
        If dgvSystemSettings.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvSystemSettings.SelectedRows(0)
            _strSystemSettingsID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub dgvSystemSettings_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSystemSettings.CellDoubleClick
        frmHRIS_Options_AddUpdSystemSettings.isUpdate = True
        frmHRIS_Options_AddUpdSystemSettings.ShowDialog()
    End Sub

End Class