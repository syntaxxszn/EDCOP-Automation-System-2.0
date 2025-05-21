Public Class frmHRIS_Transaction_TrainingEvaluation

    Private isManagerMaster As Boolean = False

    Private Sub frmHRIS_TEF_view_Master_Load(sender As Object, e As EventArgs) Handles Me.Load

        Select_TEF_EmployeeList_Main(dgvEmployeeList)

        isManagerMaster = dgvEmployeeList.Rows.Count > 1 'this will identify if the user logged in has access rights to evaluate as supervisor

        If isManagerMaster Then
            EvaluateThisTrainingToolStripMenuItem.Text = "Evaluate this Training (As Supervisor)"
        End If

    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick

        UnselectDataGridView(dgvEmployeeList)

        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            _TrainingEmployeeID = selectedRow.Cells(0).Value
            lblTrainingName.Text = selectedRow.Cells(2).Value & " [" & selectedRow.Cells(1).Value & "]"
            Label10.Text = selectedRow.Cells(1).Value
            Call Select_TEF_TrainingListByEmployeeID_PendingRate(dgvEvaluationTraining)
        End If

    End Sub

    Private Sub lblTrainingName_TextChanged(sender As Object, e As EventArgs) Handles lblTrainingName.TextChanged
        lblTrainingName.Visible = True
    End Sub

    Private Sub lblPendingTraining_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEvaluationTraining.CellClick

        UnselectDataGridView(dgvEvaluationTraining)

        If dgvEvaluationTraining.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEvaluationTraining.SelectedRows(0)
            _TrainingSubDetailID = selectedRow.Cells(0).Value
            lblPending.Text = selectedRow.Cells(1).Value
            Label7.Text = selectedRow.Cells(3).Value
            Label9.Text = selectedRow.Cells(7).Value
        End If

    End Sub

    Private Sub lblPending_TextChanged(sender As Object, e As EventArgs) Handles lblPending.TextChanged
        lblPending.Visible = True
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)

        If dgvEmployeeList IsNot excludeDataGridView Then
            dgvEmployeeList.ClearSelection()
        End If

        If dgvEvaluationTraining IsNot excludeDataGridView Then
            dgvEvaluationTraining.ClearSelection()
        End If

    End Sub

    Private Sub dgvPendingRaterTraining_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEvaluationTraining.CellDoubleClick

        'Dim selectedRow = dgvEvaluationTraining.SelectedRows(0)
        'Dim Status As String = selectedRow.Cells(8).Value

        'If Not isManagerMaster Then
        '    If _TrainingSubDetailID = 0 AndAlso _TrainingEmployeeID = 0 Then
        '        MessageBox.Show("Select training first.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    ElseIf Status = "Pending-Rater" OrElse Status = "Completed" Then
        '        MessageBox.Show("Further action not allowed.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        frmHRIS_TEF_Feedback_Form_Part1.ShowDialog()
        '    End If
        '    Exit Sub
        'End If

        'If _TrainingSubDetailID = 0 Then
        '    MessageBox.Show("Select training first.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'ElseIf Status = "Pending-Ratee" OrElse Status = "Completed" Then
        '    MessageBox.Show("Further action not allowed.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        '    Call SelUpd_TEF_TrainingEvaluationByMngrID()
        '    frmHRIS_TEF_Feedback_BySuperior.ShowDialog()
        'End If

        btnEvaluateTraining.PerformClick()

    End Sub

    Private Sub btnEvaluateTraining_Click(sender As Object, e As EventArgs) Handles btnEvaluateTraining.Click

        If dgvEvaluationTraining.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a valid training to be evaluated.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim selectedRow = dgvEvaluationTraining.SelectedRows(0)
        Dim Status As String = selectedRow.Cells(8).Value

        If Not isManagerMaster Then

            ''Individual
            If _TrainingSubDetailID = 0 AndAlso _TrainingEmployeeID = 0 Then
                MessageBox.Show("Select training first.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Status = "Pending-Rater" OrElse Status = "Completed" Then
                MessageBox.Show("Further action not allowed.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                frmHRIS_TEF_Feedback_Form_Part1.ShowDialog()
            End If


        Else

            ''Master / Manager
            If Label10.Text = frmMain.ToolStripEmployeeNo.Text AndAlso Status = "Pending-Ratee" Then
                frmHRIS_TEF_Feedback_Form_Part1.ShowDialog()
                Exit Sub
            End If

            If Status = "Pending-Ratee" OrElse Status = "Completed" Then
                MessageBox.Show("Further action not allowed.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If _TrainingSubDetailID = 0 Then
                MessageBox.Show("Select training first.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Call SelUpd_TEF_TrainingEvaluationByMngrID()
                frmHRIS_TEF_Feedback_BySuperior.ShowDialog()
            End If

        End If

    End Sub

    Private Sub EvaluateThisTrainingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluateThisTrainingToolStripMenuItem.Click


        btnEvaluateTraining.PerformClick()

        'Dim selectedRow = dgvEvaluationTraining.SelectedRows(0)
        'Dim Status As String = selectedRow.Cells(8).Value

        'If Not isManagerMaster Then
        '    If _TrainingSubDetailID = 0 AndAlso _TrainingEmployeeID = 0 Then
        '        MessageBox.Show("Select training first.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    ElseIf Status = "Pending-Rater" OrElse Status = "Completed" Then
        '        MessageBox.Show("Further action not allowed.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        frmHRIS_TEF_Feedback_Form_Part1.ShowDialog()
        '    End If
        'Else
        '    If Status = "Pending-Ratee" Then
        '        frmHRIS_TEF_Feedback_Form_Part1.ShowDialog()
        '    Else
        '        MessageBox.Show("Further action not allowed.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'End If

    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Select_TEF_TrainingListByEmployeeID_PendingRate(dgvEvaluationTraining)
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
                targetGrid = dgvEvaluationTraining
            Case "Employee"
                targetGrid = dgvEmployeeList
        End Select

        ' Proceed if a valid grid is found
        If targetGrid Is dgvEvaluationTraining Then

            Dim matchFound As Boolean = False

            For Each row As DataGridViewRow In targetGrid.Rows
                If Not row.IsNewRow Then
                    If keyword = "" Then
                        row.Visible = True
                        matchFound = True
                    Else
                        Dim cellValue As String = row.Cells(1).Value?.ToString().ToLower()
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
            Call Search_DGVPersonnel(dgvEmployeeList, txtboxSearch, False)
        End If

        'dgvEvaluationTraining.Rows.Clear()
    End Sub

    Private Sub dgvEvaluationTraining_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvEvaluationTraining.CellFormatting
        If dgvEvaluationTraining.Columns(e.ColumnIndex).Name = "Status" Then
            If e.Value IsNot Nothing Then
                Select Case e.Value.ToString()
                    Case "Pending-Rater"
                        e.CellStyle.ForeColor = Color.DarkGreen
                    Case "Pending-Ratee"
                        e.CellStyle.ForeColor = Color.Navy
                    Case "Completed"
                        e.CellStyle.ForeColor = Color.Black
                End Select
            End If
        End If
    End Sub

    Private Sub dgvEmployeeList_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvEmployeeList.RowsAdded
        lblPending.Visible = False
        dgvEvaluationTraining.Rows.Clear()
    End Sub

    Private Sub dgvEmployeeList_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvEmployeeList.RowsRemoved
        lblPending.Visible = False
        dgvEvaluationTraining.Rows.Clear()
    End Sub

    Private Sub PrintThisTEFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintThisTEFToolStripMenuItem.Click
        If _TrainingSubDetailID = 0 Then
            MessageBox.Show("Select training first.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Call Print_TrainingEvaluation()
        End If
        'MsgBox(_TrainingEmployeeID)
        'MsgBox(_TrainingSubDetailID)
        ResetComboBoxes(Me)
    End Sub
End Class