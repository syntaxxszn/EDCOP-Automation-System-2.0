Public Class frmHRIS_Transaction_TrainingRequest

    Private Sub frmHRIS_Transaction_TrainingRequest_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call Select_TrainingRequestList_Main(dgvTrainingRequest)

    End Sub

    Private Sub dgvTrainingRequest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrainingRequest.CellClick

        UnselectDataGridView(dgvTrainingRequest)

        If dgvTrainingRequest.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvTrainingRequest.SelectedRows(0)
            _TrainingRequestID = selectedRow.Cells(0).Value
            lblTrainingName.Text = selectedRow.Cells(1).Value
            Call Select_TrainingRequest_Participant_List(dgvEmployeeList)
            lblEmployeeName.Visible = False
        End If

    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)

        If dgvTrainingRequest IsNot excludeDataGridView Then
            dgvTrainingRequest.ClearSelection()
        End If

        If dgvEmployeeList IsNot excludeDataGridView Then
            dgvEmployeeList.ClearSelection()
        End If

    End Sub

    Private Sub lblTrainingName_TextChanged(sender As Object, e As EventArgs) Handles lblTrainingName.TextChanged
        lblTrainingName.Visible = True
    End Sub

    Private Sub dgvTrainingRequest_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTrainingRequest.CellFormatting
        If dgvTrainingRequest.Columns(e.ColumnIndex).Name = "Status" Then
            If e.Value IsNot Nothing Then
                Select Case e.Value.ToString()
                    Case "For Evaluation"
                        e.CellStyle.ForeColor = Color.DarkGreen
                    Case "Pending"
                        e.CellStyle.ForeColor = Color.Navy
                    Case "Approved"
                        e.CellStyle.ForeColor = Color.Black
                    Case "Disapproved"
                        e.CellStyle.ForeColor = Color.DarkRed
                End Select
            End If
        End If
    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick

        UnselectDataGridView(dgvEmployeeList)

        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            _TrainingEmployeeID = selectedRow.Cells(0).Value
            lblEmployeeName.Text = selectedRow.Cells(2).Value & " [" & selectedRow.Cells(1).Value & "]"
        End If

    End Sub

    Private Sub lblEmployeeName_TextChanged(sender As Object, e As EventArgs) Handles lblEmployeeName.TextChanged
        lblEmployeeName.Visible = True
    End Sub

    Private Sub dgvTrainingRequest_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvTrainingRequest.RowsAdded
        lblEmployeeName.Visible = False
        lblTrainingName.Visible = False
        dgvEmployeeList.Rows.Clear()
    End Sub

    Private Sub dgvTrainingRequest_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvTrainingRequest.RowsRemoved
        lblEmployeeName.Visible = False
        lblTrainingName.Visible = False
        dgvEmployeeList.Rows.Clear()
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Employee"
                btnSearchFilter.Text = "Training"
            Case Else
                btnSearchFilter.Text = "Employee"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
        Dim targetGrid As DataGridView = Nothing

        ' Determine which grid to work with based on button text
        Select Case btnSearchFilter.Text
            Case "Training"
                targetGrid = dgvTrainingRequest
            Case "Employee"
                targetGrid = dgvEmployeeList
        End Select

        ' Proceed if a valid grid is found
        If targetGrid Is dgvEmployeeList Then

            Dim matchFound As Boolean = False

            For Each row As DataGridViewRow In targetGrid.Rows
                If Not row.IsNewRow Then
                    If keyword = "" Then
                        row.Visible = True
                        matchFound = True
                    Else
                        Dim cellValue As String = row.Cells(2).Value?.ToString().ToLower()
                        Dim isMatch As Boolean = (cellValue IsNot Nothing AndAlso cellValue.Contains(keyword))
                        row.Visible = isMatch
                        If isMatch Then matchFound = True
                    End If
                End If
            Next

            ' Show message if no match found and keyword is not empty
            If Not matchFound AndAlso keyword <> "" Then
                MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Call Select_TrainingRequestList_Search(dgvTrainingRequest)
        End If

    End Sub

    Private Sub btnAddNewRequest_Click(sender As Object, e As EventArgs) Handles btnAddNewRequest.Click
        If Not HasUserAccess("insert") Then Return
        frmHRIS_TR_AddUpdateTrainingRequest.ShowDialog()
    End Sub

    Private Sub btnEditTrainingRequest_Click(sender As Object, e As EventArgs) Handles btnEditTrainingRequest.Click
        If Not HasUserAccess("update") Then Return
        If dgvTrainingRequest.SelectedRows.Count = 0 Then
            MessageBox.Show("Oooppss... Select from the list first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        isUpdate = True
        frmHRIS_TR_AddUpdateTrainingRequest.ShowDialog()
    End Sub

    Private Sub dgvTrainingRequest_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrainingRequest.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        btnEditTrainingRequest.PerformClick()
    End Sub

    Private Sub EditTrainingRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditTrainingRequestToolStripMenuItem.Click
        If Not HasUserAccess("update") Then Return
        btnEditTrainingRequest.PerformClick()
    End Sub

    Private Sub AddTrainingParticipantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTrainingParticipantsToolStripMenuItem.Click
        If Not HasUserAccess("insert") Then Return
        frmHRIS_TR_AddUpdTrainingParticipants.ShowDialog()
    End Sub

    Private Sub dgvEmployeeList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellDoubleClick
        If Not lblTrainingName.Visible Then
            MessageBox.Show("Please select from the Batch List or Create a new one.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        frmHRIS_TR_AddUpdTrainingParticipants.ShowDialog()
    End Sub

    Private Sub DeleteThisTrainingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisTrainingToolStripMenuItem.Click
        If Not HasUserAccess("delete") Then Return
        If dgvEmployeeList.Rows.Count <> 0 Then
            If MessageBox.Show("Are you sure you want to delete this request and its participant(s)?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
            Call Del_TrainingRequest_By_ID(dgvTrainingRequest)
        End If
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Select_TrainingRequestList_Main(dgvTrainingRequest)

    End Sub

    Private Sub ToolStripBtnPrint_Click(sender As Object, e As EventArgs) Handles ToolStripBtnPrint.Click
        If dgvTrainingRequest.SelectedRows.Count > 0 Then
            PrintRPT_EmployeeTrainingRequest()
        ElseIf dgvEmployeeList.SelectedRows.Count > 0 Then
            PrintRPT_TrainingRequestParticipant()
        End If
    End Sub

    Private Sub UpdateStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStatusToolStripMenuItem.Click
        If Not HasUserAccess("update") Then Return
        frmHRIS_TR_UpdateStatusAndRemarks.ShowDialog()
    End Sub

End Class