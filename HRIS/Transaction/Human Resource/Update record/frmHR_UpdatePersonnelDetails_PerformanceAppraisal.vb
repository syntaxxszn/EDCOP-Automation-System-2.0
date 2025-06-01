Imports System.ComponentModel

Public Class frmHR_UpdatePersonnelDetails_PerformanceAppraisal

    Private Sub frmHR_UpdatePersonnelDetails_PerformanceAppraisal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SelUpd_HRIS_Personnel_PerformanceAppraisal_ByID(dgvPerformanceAppraisal)
        Call ResetDatePickers(Me)
        Call ResetComboBoxes(Me)
        Call ClearTextBoxes(Me)
        Call DropDownListSupervisorEmployeeName3(cbSuperior)
    End Sub

    Private Sub btnAddUpdAppraisal_Click(sender As Object, e As EventArgs) Handles btnAddUpdAppraisal.Click
        If String.IsNullOrWhiteSpace(cbSuperior.Text) OrElse
          String.IsNullOrWhiteSpace(txtRating.Text) Then
            MessageBox.Show("Error! Please fill up all fields required.")
            Return
        End If

        Dim exists As Boolean = dgvPerformanceAppraisal.Rows.Cast(Of DataGridViewRow)().
        Any(Function(row) CInt(row.Cells(0).Value) = _PersonnelAppraisalID1)

        If exists Then
            If MessageBox.Show("Are you sure you want to update this record?", "Warning Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim selectedRow = dgvPerformanceAppraisal.SelectedRows(0)
                _PersonnelAppraisalID1 = Convert.ToInt32(selectedRow.Cells(0).Value)
                selectedRow.Cells(1).Value = dtpFrom.Text
                selectedRow.Cells(2).Value = dtpTo.Text
                selectedRow.Cells(3).Value = cbSuperior.SelectedItem
                selectedRow.Cells(4).Value = txtRating.Text
                selectedRow.Cells(5).Value = dtpFollowUp.Text
                selectedRow.Cells(6).Value = txtRemarks.Text
            End If
        Else
            Dim newRowIndex As Integer = dgvPerformanceAppraisal.Rows.Add(_PersonnelAppraisalID2,
                                                                       dtpFrom.Text,
                                                                       dtpTo.Text,
                                                                       cbSuperior.Text,
                                                                       txtRating.Text,
                                                                       dtpFollowUp.Text,
                                                                       txtRemarks.Text)
            dgvPerformanceAppraisal.Rows(newRowIndex).Tag = "New"
            _PersonnelAppraisalID2 += 1
        End If
        ClearTransactionField()
    End Sub

    Private Sub ClearTransactionField()
        dgvPerformanceAppraisal.ClearSelection()
        _PersonnelAppraisalID1 = _PersonnelAppraisalID2
        ClearTextBoxes(Me)
        ResetDatePickers(Me)
        cbSuperior.SelectedIndex = -1
    End Sub

    Private Sub dgvPerformanceAppraisal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerformanceAppraisal.CellClick
        If dgvPerformanceAppraisal.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvPerformanceAppraisal.SelectedRows(0)
            _PersonnelAppraisalID1 = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub dgvPerformanceAppraisal_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerformanceAppraisal.CellDoubleClick
        If dgvPerformanceAppraisal.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvPerformanceAppraisal.SelectedRows(0)
            dtpFrom.Value = selectedRow.Cells(1).Value
            dtpTo.Value = selectedRow.Cells(2).Value

            Dim type As Integer = cbSuperior.FindStringExact(selectedRow.Cells(3).Value.ToString())
            If type <> -1 Then cbSuperior.SelectedIndex = type

            txtRating.Text = selectedRow.Cells(4).Value
            dtpFollowUp.Value = selectedRow.Cells(5).Value
            txtRemarks.Text = selectedRow.Cells(6).Value
        End If
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        ClearTransactionField()
    End Sub

    Private Sub btnDelAppraisal_Click(sender As Object, e As EventArgs) Handles btnDelAppraisal.Click
        If dgvPerformanceAppraisal.Rows.Count > 0 Then
            Dim lastRow As DataGridViewRow = dgvPerformanceAppraisal.Rows(dgvPerformanceAppraisal.Rows.Count - 1)
            If lastRow.Tag?.ToString() = "New" Then
                dgvPerformanceAppraisal.Rows.Remove(lastRow)
            ElseIf dgvPerformanceAppraisal.SelectedRows.Count > 0 Then
                Call Del_Personnel_PerformanceAppraisal_ByID(dgvPerformanceAppraisal)
            Else
                MsgBox("Nothing to remove.")
            End If
            ClearTransactionField()
        End If
    End Sub

    Private Sub txtRating_Validating(sender As Object, e As CancelEventArgs) Handles txtRating.Validating
        Call Textbox_NumericFormat(txtRating, e.Cancel)
    End Sub

End Class