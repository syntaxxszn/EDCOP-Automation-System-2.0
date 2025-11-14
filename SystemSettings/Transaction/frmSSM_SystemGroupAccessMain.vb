Public Class frmSSM_SystemGroupAccessMain

    Private Sub frmSSS_SystemModulesMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_SystemGroups(dgvGroupList)
    End Sub

    Private Sub UpdateRowCount()
        Dim rowCount As Integer = dgvGroupList.Rows.Count - If(dgvGroupList.AllowUserToAddRows, 1, 0)
        toolstriplabelNoOfRecord.Text = rowCount.ToString()
    End Sub

    Private Sub dgvGroupList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGroupList.CellContentClick

    End Sub

    Private Sub dgvGroupList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGroupList.CellClick
        Call UnselectDataGridView(dgvGroupList)
        btnSaveChanges.Visible = False
        If dgvGroupList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvGroupList.SelectedRows(0)
            _SystemGroupID = selectedRow.Cells(0).Value
            isPopulating = True
            Call Sel_SystemModuleItems(dgvModuleItem)
            isPopulating = False
        End If
    End Sub

    Private Sub dgvGroupList_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvGroupList.RowsAdded
        UpdateRowCount()
    End Sub

    Private Sub dgvGroupList_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvGroupList.RowsRemoved
        UpdateRowCount()
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvGroupList IsNot excludeDataGridView Then
            dgvGroupList.ClearSelection()
        End If

        If dgvModuleItem IsNot excludeDataGridView Then
            dgvModuleItem.ClearSelection()
        End If
    End Sub

    Private Sub dgvModuleItem_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvModuleItem.CellFormatting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 3 Then
            If CBool(dgvModuleItem(e.ColumnIndex, e.RowIndex).Value) Then
                e.CellStyle.BackColor = Color.Navy
            End If
        End If
    End Sub

    Private Sub dgvModuleItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvModuleItem.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 3 Then
            Dim isChecked As Boolean = Not CBool(dgvModuleItem(e.ColumnIndex, e.RowIndex).Value)
            dgvModuleItem(e.ColumnIndex, e.RowIndex).Value = isChecked

            ' Get clicked row's ModuleCode
            Dim moduleCode As String = dgvModuleItem.Rows(e.RowIndex).Cells(1).Value.ToString()

            ' Apply recursively
            ToggleChildAccess(moduleCode, isChecked)

            If Not btnSaveChanges.Visible Then btnSaveChanges.Visible = True

            dgvModuleItem.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgvModuleItem.EndEdit()
            dgvModuleItem.Invalidate()
        End If
    End Sub

    Private Sub ToggleChildAccess(parentCode As String, isChecked As Boolean)
        For Each row As DataGridViewRow In dgvModuleItem.Rows
            If Not row.IsNewRow Then
                Dim rowParentCode As String = row.Cells(4).Value.ToString()
                If rowParentCode = parentCode Then
                    row.Cells(3).Value = isChecked
                    ' Recurse into children of this child
                    Dim childCode As String = row.Cells(1).Value.ToString()
                    ToggleChildAccess(childCode, isChecked)
                End If
            End If
        Next
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        ProcessDataGridViewGroupAccess(dgvModuleItem)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_SystemGroups(dgvGroupList)
        dgvModuleItem.Rows.Clear()
        btnSaveChanges.Visible = False
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()

    End Sub
End Class