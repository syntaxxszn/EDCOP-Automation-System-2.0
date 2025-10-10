Public Class frmHRIS_Transaction_TrainingEnrollment
    Private Sub frmHRIS_Transaction_TrainingEnrollment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Select_TE_TrainingList_Master(dgvTrainingList)
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)

        If dgvTrainingList IsNot excludeDataGridView Then
            dgvTrainingList.ClearSelection()
        End If

        If dgvTrainingBatchList IsNot excludeDataGridView Then
            dgvTrainingBatchList.ClearSelection()
        End If

        If dgvEnrolledEmployee IsNot excludeDataGridView Then
            dgvEnrolledEmployee.ClearSelection()
        End If

    End Sub


    Private Sub dgvTrainingList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrainingList.CellClick

        Call UnselectDataGridView(dgvTrainingList)
        If dgvTrainingList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvTrainingList.SelectedRows(0)
            _TrainingListID = selectedRow.Cells(0).Value
            lblTrainingName.Text = selectedRow.Cells(1).Value
            Call Select_TE_BatchList_Master(dgvTrainingBatchList)

            lblTrainingBatch.Visible = False
            dgvEnrolledEmployee.Rows.Clear()
        End If

    End Sub

    Private Sub dgvTrainingBatchList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrainingBatchList.CellClick

        Call UnselectDataGridView(dgvTrainingBatchList)

        If dgvTrainingBatchList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvTrainingBatchList.SelectedRows(0)
            _TrainingBatchListID = selectedRow.Cells(0).Value
            lblTrainingBatch.Text = selectedRow.Cells(1).Value
            Call Select_TE_EnrolledList_Master(dgvEnrolledEmployee)

            lblEmployeeName.Visible = False
        End If

        'If _TrainingListID <> 0 Then
        '    If dgvEnrolledEmployee.Rows.Count = 0 Then
        '        Dim result As DialogResult = MessageBox.Show("Would you like to enroll employee(s) to this training?", "No Enrolled Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '        If result = DialogResult.Yes Then
        '            'frmHRIS_TE_AddUpdateTrainingEnrollee_Master.ShowDialog()
        '        End If
        '    End If
        'Else
        '    Return
        'End If

    End Sub

    Private Sub dgvEnrolledEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrolledEmployee.CellClick

        Call UnselectDataGridView(dgvEnrolledEmployee)

        If dgvEnrolledEmployee.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEnrolledEmployee.SelectedRows(0)
            _TrainingSubDetailID = selectedRow.Cells(0).Value
            lblEmployeeName.Text = selectedRow.Cells(1).Value
            _TrainingEmployeeID = selectedRow.Cells(5).Value
        End If

    End Sub

    Private Sub lblTrainingName_TextChanged(sender As Object, e As EventArgs) Handles lblTrainingName.TextChanged
        lblTrainingName.Visible = True
    End Sub

    Private Sub lblTrainingBatch_TextChanged(sender As Object, e As EventArgs) Handles lblTrainingBatch.TextChanged
        lblTrainingBatch.Visible = True
    End Sub

    Private Sub lblEmployeeName_TextChanged(sender As Object, e As EventArgs) Handles lblEmployeeName.TextChanged
        lblEmployeeName.Visible = True
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If Not HasUserAccess("insert") Then Return
        isUpdate = False
        frmHRIS_TE_AddUpdateTraining_Master.ShowDialog()
    End Sub

    Public Sub RefreshDataGridViewTrainingList()
        Call Select_TE_TrainingList_Master(dgvTrainingList)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not HasUserAccess("update") Then Return
        If dgvTrainingList.SelectedRows.Count > 0 Then
            isUpdate = True
            frmHRIS_TE_AddUpdateTraining_Master.ShowDialog()
        Else
            MessageBox.Show("Error Occured, please select training from the list first.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AddNewTrainingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewTrainingToolStripMenuItem.Click
        If Not HasUserAccess("insert") Then Return
        isUpdate = False
        frmHRIS_TE_AddUpdateTraining_Master.ShowDialog()
    End Sub

    Private Sub dgvTrainingList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrainingList.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmHRIS_TE_AddUpdateTraining_Master.ShowDialog()
    End Sub

    Private Sub DeleteThisTrainingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisTrainingToolStripMenuItem.Click
        If Not HasUserAccess("delete") Then Return
        If dgvTrainingBatchList.Rows.Count <> 0 Then
            MessageBox.Show("This training cannot be deleted because it is a parent training and has associated batch(es).", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Call Del_Training_TrainingList_By_ID(dgvTrainingList)
        End If
    End Sub

    Private Sub AddNewBatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewBatchToolStripMenuItem.Click
        If Not HasUserAccess("insert") Then Return
        isUpdate = False
        frmHRIS_TE_AddUpdateTrainingDetail_Master.ShowDialog()
    End Sub

    Private Sub btnAddNewBatch_Click(sender As Object, e As EventArgs) Handles btnAddNewBatch.Click
        If Not HasUserAccess("insert") Then Return
        isUpdate = False
        frmHRIS_TE_AddUpdateTrainingDetail_Master.ShowDialog()
    End Sub

    Public Sub RefreshDataGridViewTrainingBatchList()
        Call Select_TE_BatchList_Master(dgvTrainingBatchList)
    End Sub

    Private Sub btnEditBatch_Click(sender As Object, e As EventArgs) Handles btnEditBatch.Click
        If Not HasUserAccess("update") Then Return
        If dgvTrainingBatchList.SelectedRows.Count > 0 Then
            isUpdate = True
            frmHRIS_TE_AddUpdateTrainingDetail_Master.ShowDialog()
        Else
            MessageBox.Show("Error Occured, please select training from the batch list.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvTrainingBatchList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrainingBatchList.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmHRIS_TE_AddUpdateTrainingDetail_Master.ShowDialog()
    End Sub

    Private Sub DeleteThisBatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisBatchToolStripMenuItem.Click
        If Not HasUserAccess("delete") Then Return
        If dgvEnrolledEmployee.Rows.Count <> 0 Then
            MessageBox.Show("This training batch cannot be deleted because it has enrolled employee(s).", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Call Del_Training_TrainingDetail_By_ID(dgvTrainingBatchList)
        End If
    End Sub

    Private Sub btnEnrollEmployee_Click(sender As Object, e As EventArgs) Handles btnEnrollEmployee.Click
        If Not HasUserAccess("insert") Then Return
        If Not lblTrainingBatch.Visible Then
            MessageBox.Show("Please select from the Batch List or Create a new one.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        frmHRIS_TE_AddUpdateTrainingEnrollee_Master.ShowDialog()
    End Sub

    Public Sub RefreshDataGridViewTrainingEnrollees()
        Call Select_TE_EnrolledList_Master(dgvEnrolledEmployee)
    End Sub

    Private Sub EnrollEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnrollEmployeesToolStripMenuItem.Click
        If Not HasUserAccess("insert") Then Return
        frmHRIS_TE_AddUpdateTrainingEnrollee_Master.ShowDialog()
    End Sub

    Private Sub dgvEnrolledEmployee_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrolledEmployee.CellDoubleClick
        frmHRIS_TE_AddUpdateTrainingEnrollee_Master.ShowDialog()
    End Sub

    Private Sub RemoveEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveEmployeeToolStripMenuItem.Click
        If Not HasUserAccess("delete") Then Return
        Call DelEmployeeTrainingEnrollment()
        Call Select_TE_EnrolledList_Master(dgvEnrolledEmployee)
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Batch"
                btnSearchFilter.Text = "Employee"
            Case "Employee"
                btnSearchFilter.Text = "Training"
            Case Else
                btnSearchFilter.Text = "Batch"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
        Dim targetGrid As DataGridView = Nothing

        ' Determine which grid to work with based on button text
        Select Case btnSearchFilter.Text
            Case "Training"
                targetGrid = dgvTrainingList
            Case "Batch"
                targetGrid = dgvTrainingBatchList
            Case "Employee"
                targetGrid = dgvEnrolledEmployee
        End Select

        ' Proceed if a valid grid is found
        If targetGrid IsNot Nothing Then
            targetGrid.Visible = True

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
        End If
    End Sub

    Private Sub dgvTrainingList_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvTrainingList.RowsAdded
        dgvTrainingBatchList.Rows.Clear()
        dgvEnrolledEmployee.Rows.Clear()
    End Sub

    Private Sub dgvTrainingList_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvTrainingList.RowsRemoved
        dgvTrainingBatchList.Rows.Clear()
        dgvEnrolledEmployee.Rows.Clear()
    End Sub

    Private Sub dgvTrainingBatchList_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvTrainingBatchList.RowsAdded
        dgvEnrolledEmployee.Rows.Clear()
    End Sub

    Private Sub dgvTrainingBatchList_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvTrainingBatchList.RowsRemoved
        dgvEnrolledEmployee.Rows.Clear()
    End Sub

    Private Sub btnUpdateResult_Click(sender As Object, e As EventArgs) Handles btnUpdateResult.Click
        If Not HasUserAccess("update") Then Return
    End Sub

    Private Sub UpdateTrainingResultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateTrainingResultToolStripMenuItem.Click
        If Not HasUserAccess("update") Then Return
    End Sub
End Class