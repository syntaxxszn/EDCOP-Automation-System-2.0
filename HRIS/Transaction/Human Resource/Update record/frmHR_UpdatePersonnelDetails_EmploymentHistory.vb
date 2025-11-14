Imports System.ComponentModel

Public Class frmHR_UpdatePersonnelDetails_EmploymentHistory
    Private Sub frmHR_UpdatePersonnelDetails_EmploymentHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SelUpd_HRIS_Personnel_EmploymentHistory_ByID(dgvEmploymentHistory)
        Call DropDownLists()
        Call ClearTextBoxes(Me)
        Call ResetDatePickers(Me)
        Call ResetComboBoxes(Me)
        btnAddUpdEducation.Text = "Add"
    End Sub

    Private Sub DropDownLists()
        Call DropDownListIndustryType(cbIndustry)
        Call DropDownListIndustrySpecialization(cbSpecializationType)
        Call DropDownListEmploymentType(cbEmploymentType)
        Call DropDownListSeparationType(cbSeparationType)
    End Sub

    Private Sub btnAddUpdEducation_Click(sender As Object, e As EventArgs) Handles btnAddUpdEducation.Click
        If String.IsNullOrWhiteSpace(cbIndustry.Text) OrElse
          String.IsNullOrWhiteSpace(cbSeparationType.Text) OrElse
          String.IsNullOrWhiteSpace(cbSpecializationType.Text) OrElse
          String.IsNullOrWhiteSpace(txtCompany.Text) OrElse
          String.IsNullOrWhiteSpace(txtJobTitle.Text) OrElse
          String.IsNullOrWhiteSpace(txtSalary.Text) OrElse
          String.IsNullOrWhiteSpace(cbEmploymentType.Text) Then
            MessageBox.Show("Error! Please fill up all fields required.")
            Return
        End If

        Dim exists As Boolean = dgvEmploymentHistory.Rows.Cast(Of DataGridViewRow)().
        Any(Function(row) CInt(row.Cells(0).Value) = _PersonnelEmploymentHistoryID1)

        If exists Then
            If MessageBox.Show("Are you sure you want to update this record?", "Warning Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim selectedRow = dgvEmploymentHistory.SelectedRows(0)
                _PersonnelEmploymentHistoryID1 = Convert.ToInt32(selectedRow.Cells(0).Value)
                selectedRow.Cells(1).Value = txtCompany.Text
                selectedRow.Cells(2).Value = txtJobTitle.Text
                selectedRow.Cells(3).Value = dtpFrom.Value
                selectedRow.Cells(4).Value = dtpTo.Value
                selectedRow.Cells(5).Value = txtCompanyAddress.Text
                selectedRow.Cells(6).Value = cbIndustry.SelectedItem
                selectedRow.Cells(7).Value = cbSpecializationType.SelectedItem
                selectedRow.Cells(8).Value = txtCompanyNo.Text
                selectedRow.Cells(9).Value = txtSupervisorName.Text
                selectedRow.Cells(10).Value = txtSupervisorPosition.Text
                selectedRow.Cells(11).Value = txtSupervisorContactNo.Text
                selectedRow.Cells(12).Value = txtSupervisorEmail.Text
                selectedRow.Cells(13).Value = txtSalary.Text
                selectedRow.Cells(14).Value = txtAllowances.Text
                selectedRow.Cells(15).Value = cbEmploymentType.SelectedItem
                selectedRow.Cells(16).Value = cbSeparationType.Text
            End If
        Else
            Dim newRowIndex As Integer = dgvEmploymentHistory.Rows.Add(_PersonnelEmploymentHistoryID2,
                                                                       txtCompany.Text,
                                                                       txtJobTitle.Text,
                                                                       dtpFrom.Text,
                                                                       dtpTo.Text,
                                                                       txtCompanyAddress.Text,
                                                                       cbIndustry.Text,
                                                                       cbSpecializationType.Text,
                                                                       txtCompanyNo.Text,
                                                                       txtSupervisorName.Text,
                                                                       txtSupervisorPosition.Text,
                                                                       txtSupervisorContactNo.Text,
                                                                       txtSupervisorEmail.Text,
                                                                       txtSalary.Text,
                                                                       txtAllowances.Text,
                                                                       cbEmploymentType.Text,
                                                                       cbSeparationType.Text)
            dgvEmploymentHistory.Rows(newRowIndex).Tag = "New"
            _PersonnelEmploymentHistoryID2 += 1
        End If
        ClearTransactionField()
    End Sub

    Private Sub ClearTransactionField()
        dgvEmploymentHistory.ClearSelection()
        _PersonnelEmploymentHistoryID1 = _PersonnelEmploymentHistoryID2
        ClearTextBoxes(Me)
        ResetDatePickers(Me)
        cbIndustry.SelectedIndex = -1
        cbSeparationType.SelectedIndex = -1
        cbSpecializationType.SelectedIndex = -1
        cbEmploymentType.SelectedIndex = -1
        btnAddUpdEducation.Text = "Add"
    End Sub

    Private Sub dgvEmploymentHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmploymentHistory.CellClick
        If dgvEmploymentHistory.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmploymentHistory.SelectedRows(0)
            _PersonnelEmploymentHistoryID1 = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub dgvEmploymentHistory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmploymentHistory.CellDoubleClick
        If dgvEmploymentHistory.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmploymentHistory.SelectedRows(0)
            txtCompany.Text = selectedRow.Cells(1).Value
            txtJobTitle.Text = selectedRow.Cells(2).Value
            dtpFrom.Value = selectedRow.Cells(3).Value
            dtpTo.Value = selectedRow.Cells(4).Value
            txtCompanyAddress.Text = selectedRow.Cells(5).Value

            Dim type1 As Integer = cbIndustry.FindStringExact(selectedRow.Cells(6).Value.ToString())
            If type1 <> -1 Then cbIndustry.SelectedIndex = type1

            Dim type2 As Integer = cbSpecializationType.FindStringExact(selectedRow.Cells(7).Value.ToString())
            If type2 <> -1 Then cbSpecializationType.SelectedIndex = type2

            txtCompanyNo.Text = selectedRow.Cells(8).Value
            txtSupervisorName.Text = selectedRow.Cells(9).Value
            txtSupervisorPosition.Text = selectedRow.Cells(10).Value
            txtSupervisorContactNo.Text = selectedRow.Cells(11).Value
            txtSupervisorEmail.Text = selectedRow.Cells(12).Value
            txtSalary.Text = selectedRow.Cells(13).Value
            txtAllowances.Text = selectedRow.Cells(14).Value

            Dim type3 As Integer = cbEmploymentType.FindStringExact(selectedRow.Cells(15).Value.ToString())
            If type3 <> -1 Then cbEmploymentType.SelectedIndex = type3

            Dim type4 As Integer = cbSeparationType.FindStringExact(selectedRow.Cells(16).Value.ToString())
            If type4 <> -1 Then cbSeparationType.SelectedIndex = type4
            btnAddUpdEducation.Text = "Update"
        End If
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        ClearTransactionField()
    End Sub

    'Private Sub btnDelEmploymentHistory_Click(sender As Object, e As EventArgs)
    '    If dgvEmploymentHistory.Rows.Count > 0 Then
    '        Dim lastRow As DataGridViewRow = dgvEmploymentHistory.Rows(dgvEmploymentHistory.Rows.Count - 1)
    '        If lastRow.Tag?.ToString() = "New" Then
    '            dgvEmploymentHistory.Rows.Remove(lastRow)
    '        ElseIf dgvEmploymentHistory.SelectedRows.Count > 0 Then
    '            Call Del_Personnel_EmploymentHistory_ByID(dgvEmploymentHistory)
    '        Else
    '            MsgBox("Nothing to remove.")
    '        End If
    '        ClearTransactionField()
    '    End If
    'End Sub

    Private Sub txtSalary_Validating(sender As Object, e As CancelEventArgs) Handles txtSalary.Validating
        Call Textbox_NumericFormat(txtSalary, e.Cancel)
    End Sub

    Private Sub txtAllowances_Validating(sender As Object, e As CancelEventArgs) Handles txtAllowances.Validating
        Call Textbox_NumericFormat(txtAllowances, e.Cancel)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If dgvEmploymentHistory.Rows.Count > 0 Then
            Dim lastRow As DataGridViewRow = dgvEmploymentHistory.Rows(dgvEmploymentHistory.Rows.Count - 1)
            If lastRow.Tag?.ToString() = "New" Then
                dgvEmploymentHistory.Rows.Remove(lastRow)
            ElseIf dgvEmploymentHistory.SelectedRows.Count > 0 Then
                Call Del_Personnel_EmploymentHistory_ByID(dgvEmploymentHistory)
            Else
                MsgBox("Nothing to remove.")
            End If
            ClearTransactionField()
        End If
    End Sub
End Class