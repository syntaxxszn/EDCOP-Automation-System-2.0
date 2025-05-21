Public Class frmHR_Setup_Shift

    Private Sub frmHR_Setup_Shift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sel_ShiftAll(dgvAllShift)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Sel_ShiftAll(dgvAllShift)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If dgvEffectivityDate.SelectedRows.Count > 0 Then
            If _strShiftID = 0 Then
                MessageBox.Show("Please select a valid shift.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            frmHR_AddNewShiftEffectivity.ShowDialog()
        Else
            frmHR_AddNewShift.ShowDialog()
        End If
    End Sub

    Private Sub dgvAllShift_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAllShift.CellClick
        UnselectDataGridView(dgvAllShift)
        If dgvAllShift.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvAllShift.SelectedRows(0)
            _strShiftID = selectedRow.Cells(0).Value
            lblShiftType.Visible = True
            lblShiftType.Text = "[ " & selectedRow.Cells(1).Value & " ]"
            Sel_Shift_EffectivityDate_ByID(dgvEffectivityDate)
        End If
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvAllShift IsNot excludeDataGridView Then
            dgvAllShift.ClearSelection()
        End If

        If dgvEffectivityDate IsNot excludeDataGridView Then
            dgvEffectivityDate.ClearSelection()
        End If
    End Sub

    Private Sub dgvEffectivityDate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEffectivityDate.CellClick
        UnselectDataGridView(dgvEffectivityDate)
        If dgvEffectivityDate.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEffectivityDate.SelectedRows(0)
            _strShiftEffectivityID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvEffectivityDate.SelectedRows.Count > 0 Then
            frmHR_AddNewShiftEffectivity.isUpdate = True
            frmHR_AddNewShiftEffectivity.ShowDialog()
        ElseIf dgvAllShift.SelectedRows.Count > 0 Then
            frmHR_AddNewShift.isUpdate = True
            frmHR_AddNewShift.ShowDialog()
        Else
            MessageBox.Show("Please select either from the table shift or its effecitvity date.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub AddNewEffectivityDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewEffectivityDateToolStripMenuItem.Click
        If _strShiftID = 0 Then
            MessageBox.Show("Please select a valid shift.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If dgvAllShift.SelectedRows.Count > 0 Then
            frmHR_AddNewShiftEffectivity.ShowDialog()
        End If
    End Sub

    Private Sub dgvAllShift_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAllShift.CellDoubleClick
        frmHR_AddNewShift.isUpdate = True
        frmHR_AddNewShift.ShowDialog()
    End Sub

    Private Sub dgvEffectivityDate_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEffectivityDate.CellDoubleClick
        frmHR_AddNewShiftEffectivity.isUpdate = True
        frmHR_AddNewShiftEffectivity.ShowDialog()
    End Sub

    Private Sub SetToInactiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetToInactiveToolStripMenuItem.Click
        Del_Shift_By_ID(dgvAllShift)
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Del_Shift_EffectivityDate_By_ID(dgvEffectivityDate)
    End Sub

    Private Sub dgvAllShift_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvAllShift.RowsAdded
        UpdateRowCount()
    End Sub

    Private Sub dgvAllShift_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvAllShift.RowsRemoved
        UpdateRowCount()
    End Sub

    Private Sub UpdateRowCount()
        Dim rowCount As Integer = dgvAllShift.Rows.Count - If(dgvAllShift.AllowUserToAddRows, 1, 0)
        toolstriplabelNoOfRecord.Text = rowCount.ToString()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

    End Sub
End Class