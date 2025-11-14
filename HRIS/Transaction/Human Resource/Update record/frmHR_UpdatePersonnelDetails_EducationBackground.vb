Imports System.ComponentModel

Public Class frmHR_UpdatePersonnelDetails_EducationBackground

    Private Sub frmHR_UpdatePersonnelDetails_EducationBackground_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SelUpd_HRIS_Personnel_EducationBackground_ByID(dgvEducationBackground)
        Call DropDownListEducationBackground(cbEducationAttainment)
        Call ClearTextBoxes(Me)
        Call ResetDatePickers(Me)
        Call ResetComboBoxes(Me)
        btnAddUpdEducation.Text = "Add"
    End Sub

    Private Sub dgvEducationBackground_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEducationBackground.CellDoubleClick
        If dgvEducationBackground.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEducationBackground.SelectedRows(0)
            Dim educationAttainmentIndex As Integer = cbEducationAttainment.FindStringExact(selectedRow.Cells(1).Value.ToString())
            If educationAttainmentIndex <> -1 Then cbEducationAttainment.SelectedIndex = educationAttainmentIndex
            txtSchoolName.Text = selectedRow.Cells(2).Value
            dtpEducFrom.Value = selectedRow.Cells(3).Value
            dtpEducTo.Value = selectedRow.Cells(4).Value
            txtSchoolAdr.Text = selectedRow.Cells(5).Value
            txtDegree.Text = selectedRow.Cells(6).Value
            txtAwardsRecogCerti.Text = selectedRow.Cells(7).Value
            txtEducEmailAdr.Text = selectedRow.Cells(8).Value
            txtEducTelNo.Text = selectedRow.Cells(9).Value
            btnAddUpdEducation.Text = "Update"
        End If
    End Sub

    Private Sub btnAddUpdEducation_Click(sender As Object, e As EventArgs) Handles btnAddUpdEducation.Click
        If String.IsNullOrWhiteSpace(cbEducationAttainment.Text) OrElse
          String.IsNullOrWhiteSpace(txtSchoolName.Text) OrElse
          String.IsNullOrWhiteSpace(dtpEducFrom.Text) OrElse
          String.IsNullOrWhiteSpace(dtpEducTo.Text) Then
            MessageBox.Show("Error! Please fill up all fields required.")
            Return
        End If

        Dim exists As Boolean = dgvEducationBackground.Rows.Cast(Of DataGridViewRow)().
          Any(Function(row) CInt(row.Cells(0).Value) = _PersonnelEducationID1)
        If exists Then
            If MessageBox.Show("Are you sure you want to update this record?", "Warning Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim selectedRow = dgvEducationBackground.SelectedRows(0)
                _PersonnelEducationID1 = Convert.ToInt32(selectedRow.Cells(0).Value)
                selectedRow.Cells(1).Value = cbEducationAttainment.SelectedItem
                selectedRow.Cells(2).Value = txtSchoolName.Text
                selectedRow.Cells(3).Value = dtpEducFrom.Value
                selectedRow.Cells(4).Value = dtpEducTo.Value
                selectedRow.Cells(5).Value = txtSchoolAdr.Text
                selectedRow.Cells(6).Value = txtDegree.Text
                selectedRow.Cells(7).Value = txtAwardsRecogCerti.Text
                selectedRow.Cells(8).Value = txtEducEmailAdr.Text
                selectedRow.Cells(9).Value = txtEducTelNo.Text
            End If
        Else
            Dim newRowIndex As Integer = dgvEducationBackground.Rows.Add(_PersonnelEducationID2, cbEducationAttainment.Text, txtSchoolName.Text, dtpEducFrom.Text, dtpEducTo.Text, txtSchoolAdr.Text, txtDegree.Text, txtAwardsRecogCerti.Text, txtEducEmailAdr.Text, txtEducTelNo.Text)
            dgvEducationBackground.Rows(newRowIndex).Tag = "New"
            _PersonnelEducationID2 += 1
        End If
        ClearTransactionField()
    End Sub

    Private Sub ClearTransactionField()
        dgvEducationBackground.ClearSelection()
        _PersonnelEducationID1 = _PersonnelEducationID2
        ClearTextBoxes(Me)
        ResetDatePickers(Me)
        cbEducationAttainment.SelectedIndex = -1
        btnAddUpdEducation.Text = "Add"
    End Sub

    'Private Sub btnDelEducation_Click(sender As Object, e As EventArgs)
    '    If dgvEducationBackground.Rows.Count > 0 Then
    '        Dim lastRow As DataGridViewRow = dgvEducationBackground.Rows(dgvEducationBackground.Rows.Count - 1)
    '        If lastRow.Tag?.ToString() = "New" Then
    '            dgvEducationBackground.Rows.Remove(lastRow)
    '        ElseIf dgvEducationBackground.SelectedRows.Count > 0 Then
    '            Del_Personnel_EducationBackground_ByID(dgvEducationBackground)
    '        Else
    '            MsgBox("Nothing to remove.")
    '        End If
    '        ClearTransactionField()
    '    End If
    'End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        ClearTransactionField()
    End Sub

    Private Sub dgvEducationBackground_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEducationBackground.CellClick
        If dgvEducationBackground.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEducationBackground.SelectedRows(0)
            _PersonnelEducationID1 = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If dgvEducationBackground.Rows.Count > 0 Then
            Dim lastRow As DataGridViewRow = dgvEducationBackground.Rows(dgvEducationBackground.Rows.Count - 1)
            If lastRow.Tag?.ToString() = "New" Then
                dgvEducationBackground.Rows.Remove(lastRow)
            ElseIf dgvEducationBackground.SelectedRows.Count > 0 Then
                Del_Personnel_EducationBackground_ByID(dgvEducationBackground)
            Else
                MsgBox("Nothing to remove.")
            End If
            ClearTransactionField()
        End If
    End Sub

End Class