Public Class frmHRIS_Setup_Shift

    Private Sub frmHR_Setup_Shift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Sel_Assign_ScheduleShift(dgvShift)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Assign_ScheduleShift(dgvShift)
        dgvShiftDetails.Rows.Clear()
        dgvShiftSubDetails.Rows.Clear()
        _strShiftID = 0
        _strShiftEffectivityID = 0
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvShift_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShift.CellContentClick

    End Sub

    Private Sub dgvShift_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShift.CellClick
        If dgvShift.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvShift.SelectedRows(0)
            _strShiftID = selectedRow.Cells(0).Value
            frmHRIS_AssignScheduleType.txtSchedule.Text = selectedRow.Cells(2).Value & " (" & selectedRow.Cells(1).Value & ")"
            Sel_Assign_ScheduleShift_Detail(dgvShiftDetails)
            SelectFirstRowInShiftDetails()
        End If
    End Sub

    Private Sub dgvShift_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShift.CellDoubleClick
        If _strShiftID <> 0 Then
            isUpdate = True
            frmHRIS_AddNewShift.ShowDialog()
        End If
    End Sub

    Private Sub SelectFirstRowInShiftDetails()
        If dgvShiftDetails.Rows.Count > 0 Then
            dgvShiftDetails.Rows(0).Selected = True
            If dgvShiftDetails.SelectedRows.Count > 0 Then
                Dim selectedRow = dgvShiftDetails.SelectedRows(0)
                _strShiftEffectivityID = CInt(selectedRow.Cells(0).Value)
                Sel_Assign_ScheduleShift_SubDetail(dgvShiftSubDetails)
            End If
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        isUpdate = False
        frmHRIS_AddNewShift.ShowDialog()
    End Sub

    Private Sub AddNewEffectivityDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewEffectivityDateToolStripMenuItem.Click
        If _strShiftID <> 0 Then
            frmHRIS_AddNewShiftEffectivity.ShowDialog()
        End If
    End Sub

    Private Sub dgvShiftDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShiftDetails.CellContentClick

    End Sub

    Private Sub dgvShiftDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShiftDetails.CellClick
        If dgvShiftDetails.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvShiftDetails.SelectedRows(0)
            _strShiftEffectivityID = CInt(selectedRow.Cells(0).Value)
            Sel_Assign_ScheduleShift_SubDetail(dgvShiftSubDetails)
        End If
    End Sub

    Private Sub dgvShiftDetails_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShiftDetails.CellDoubleClick
        If _strShiftEffectivityID <> 0 Then
            isUpdate = True
            frmHRIS_AddNewShiftEffectivity.ShowDialog()
        End If
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        If _strShiftEffectivityID <> 0 Then
            frmHRIS_AssignScheduleType.ShowDialog()
        End If
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        If _strShiftEffectivityID = 0 OrElse _strShiftID = 0 Then
            MessageBox.Show("Please select type and its effectivity date first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        frmHRIS_AssignScheduleType.ShowDialog()
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Shift"
                btnSearchFilter.Text = "Effectivity"
            Case "Effectivity"
                btnSearchFilter.Text = "Employee Code"
            Case Else
                btnSearchFilter.Text = "Shift"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
        Dim targetGrid As DataGridView = Nothing

        Select Case btnSearchFilter.Text
            Case "Shift" : targetGrid = dgvShift
            Case "Effectivity" : targetGrid = dgvShiftDetails
            Case "Employee Code" : targetGrid = dgvShiftSubDetails
        End Select

        If targetGrid Is Nothing Then Exit Sub

        Dim allRows As New List(Of DataGridViewRow)
        Dim matchedRows As New List(Of DataGridViewRow)
        Dim nonMatchedRows As New List(Of DataGridViewRow)

        ' Collect rows
        For Each row As DataGridViewRow In targetGrid.Rows
            If row.IsNewRow Then Continue For
            Dim cellValue As String = row.Cells(1).Value?.ToString().ToLower()
            If keyword <> "" AndAlso cellValue IsNot Nothing AndAlso cellValue.Contains(keyword) Then
                matchedRows.Add(row)
            Else
                nonMatchedRows.Add(row)
            End If
        Next

        ' Reorder the grid
        targetGrid.Rows.Clear()
        targetGrid.Rows.AddRange(matchedRows.ToArray())
        targetGrid.Rows.AddRange(nonMatchedRows.ToArray())

        ' Limit scroll to first 15 matches (optional)
        If matchedRows.Count > 15 Then
            targetGrid.FirstDisplayedScrollingRowIndex = 0
        End If

        ' Show message if no matches
        If matchedRows.Count = 0 AndAlso keyword <> "" Then
            MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dgvShiftSubDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShiftSubDetails.CellContentClick

    End Sub

    Private Sub dgvShiftSubDetails_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvShiftSubDetails.RowsAdded
        toolstriplabelNoOfRecord.Text = dgvShiftSubDetails.Rows.Count.ToString()
    End Sub

    Private Sub dgvShiftSubDetails_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvShiftSubDetails.RowsRemoved
        toolstriplabelNoOfRecord.Text = dgvShiftSubDetails.Rows.Count.ToString()
    End Sub

    Private Sub SetToInactiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetToInactiveToolStripMenuItem.Click
        If _strShiftID = 0 Then Return
        Del_Shift_By_ID(dgvShift)
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        If _strShiftEffectivityID = 0 Then Return
        Del_Shift_EffectivityDate_By_ID(dgvShiftDetails)
    End Sub

End Class