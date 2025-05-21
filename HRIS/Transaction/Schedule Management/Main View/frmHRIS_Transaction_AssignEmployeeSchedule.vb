Public Class frmHRIS_Transaction_AssignEmployeeSchedule

    Private Sub frmHRIS_Transaction_AssignEmployeeSchedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        Sel_ShiftAll(dgvAllShift)
    End Sub

    Private Sub dgvAllShift_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAllShift.CellClick
        UnselectDataGridView(dgvAllShift)
        If dgvAllShift.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvAllShift.SelectedRows(0)
            _strShiftID = selectedRow.Cells(0).Value
            lblShiftType.Visible = True
            lblShiftType.Text = "[ " & selectedRow.Cells(1).Value & " ]"
            Sel_Shift_EffectivityDate_ByID(dgvEffectivityDate)
            SelectFirstRowInShiftDetails()
        End If
        If txtboxSearch.Text <> "" Then
            txtboxSearch.Clear()
        End If
    End Sub

    Private Sub SelectFirstRowInShiftDetails()
        If dgvEffectivityDate.Rows.Count > 0 Then
            dgvEffectivityDate.Rows(0).Selected = True
            If dgvEffectivityDate.SelectedRows.Count > 0 Then
                Dim selectedRow = dgvEffectivityDate.SelectedRows(0)
                _strShiftEffectivityID = selectedRow.Cells(0).Value
                lblShiftEffectivityDate.Visible = True
                lblShiftEffectivityDate.Text = "[ " & selectedRow.Cells(1).Value & " - " & selectedRow.Cells(2).Value & " ]"
                Sel_ScheduleShift_SubDetails(dgvShiftSubDetails)
            End If
        End If
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvAllShift IsNot excludeDataGridView Then
            dgvAllShift.ClearSelection()
        End If

        If dgvEffectivityDate IsNot excludeDataGridView Then
            dgvEffectivityDate.ClearSelection()
        End If

        If dgvShiftSubDetails IsNot excludeDataGridView Then
            dgvShiftSubDetails.ClearSelection()
        End If
    End Sub

    Private Sub dgvEffectivityDate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEffectivityDate.CellClick
        UnselectDataGridView(dgvEffectivityDate)
        If dgvEffectivityDate.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEffectivityDate.SelectedRows(0)
            _strShiftEffectivityID = selectedRow.Cells(0).Value
            lblShiftEffectivityDate.Visible = True
            lblShiftEffectivityDate.Text = "[ " & selectedRow.Cells(1).Value & " - " & selectedRow.Cells(2).Value & " ]"
            Sel_ScheduleShift_SubDetails(dgvShiftSubDetails)
        End If
    End Sub

    Private Sub dgvShiftSubDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShiftSubDetails.CellClick
        UnselectDataGridView(dgvShiftSubDetails)
        If dgvShiftSubDetails.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvShiftSubDetails.SelectedRows(0)
            _strShiftEmployeeID = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub dgvShiftSubDetails_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvShiftSubDetails.RowsAdded
        UpdateRowCount()
    End Sub

    Private Sub dgvShiftSubDetails_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvShiftSubDetails.RowsRemoved
        UpdateRowCount()
    End Sub

    Private Sub UpdateRowCount()
        Dim rowCount As Integer = dgvShiftSubDetails.Rows.Count - If(dgvShiftSubDetails.AllowUserToAddRows, 1, 0)
        toolstriplabelNoOfRecord.Text = rowCount.ToString()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmHR_AssignScheduleType.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvShiftSubDetails.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvShiftSubDetails.SelectedRows(0)
            _strShiftEmployeeID = selectedRow.Cells(0).Value
            frmHR_TransferScheduleType.txtName.Text = selectedRow.Cells(2).Value
            frmHR_TransferScheduleType.txtJobPosition.Text = selectedRow.Cells(3).Value
            frmHR_TransferScheduleType.txtDepartment.Text = selectedRow.Cells(4).Value
            frmHR_TransferScheduleType.ShowDialog()
        Else
            MessageBox.Show("Please select an Employee to begin transfer of schedule.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvShiftSubDetails_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShiftSubDetails.CellDoubleClick
        Dim selectedRow = dgvShiftSubDetails.SelectedRows(0)
        _strShiftEmployeeID = selectedRow.Cells(0).Value
        frmHR_TransferScheduleType.txtName.Text = selectedRow.Cells(2).Value
        frmHR_TransferScheduleType.txtJobPosition.Text = selectedRow.Cells(3).Value
        frmHR_TransferScheduleType.txtDepartment.Text = selectedRow.Cells(4).Value
        frmHR_TransferScheduleType.ShowDialog()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Sel_ScheduleShift_SubDetails(dgvShiftSubDetails)
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        dgvAllShift.ClearSelection()
        dgvEffectivityDate.ClearSelection()
        lblShiftType.Text = "Filtered"
        SelSearch_ScheduleShift_SubDetails(dgvShiftSubDetails, txtboxSearch)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub
End Class