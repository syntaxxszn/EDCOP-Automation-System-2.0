Public Class frmHR_UpdatePersonnelDetails_CharacterReference
    Private Sub frmHR_UpdatePersonnelDetails_CharacterReference_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SelUpd_HRIS_Personnel_CharacterReference_ByID(dgvCharRef)
        Call ClearTextBoxes(Me)
    End Sub

    Private Sub dgvCharRef_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCharRef.CellDoubleClick
        If dgvCharRef.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCharRef.SelectedRows(0)
            txtCompany.Text = selectedRow.Cells(1).Value
            txtFullName.Text = selectedRow.Cells(2).Value
            txtJobTitle.Text = selectedRow.Cells(3).Value
            txtDepartment.Text = selectedRow.Cells(4).Value
            txtMobileNum.Text = selectedRow.Cells(5).Value
            txtEmailAdd.Text = selectedRow.Cells(6).Value
            txtCompanyAdd.Text = selectedRow.Cells(7).Value
            txtRelationship.Text = selectedRow.Cells(8).Value
        End If
    End Sub

    Private Sub dgvCharRef_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCharRef.CellClick
        If dgvCharRef.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCharRef.SelectedRows(0)
            _PersonnelCharRefID1 = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub btnAddUpdCharRef_Click(sender As Object, e As EventArgs) Handles btnAddUpdCharRef.Click
        If String.IsNullOrWhiteSpace(txtCompany.Text) OrElse
        String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
        String.IsNullOrWhiteSpace(txtJobTitle.Text) OrElse
        String.IsNullOrWhiteSpace(txtRelationship.Text) OrElse
        String.IsNullOrWhiteSpace(txtMobileNum.Text) Then
            MessageBox.Show("Error! Please fill up all fields required.")
            Return
        End If

        Dim exists As Boolean = dgvCharRef.Rows.Cast(Of DataGridViewRow)().
          Any(Function(row) CInt(row.Cells(0).Value) = _PersonnelCharRefID1)
        If exists Then
            If MessageBox.Show("Are you sure you want to update this record?", "Warning Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim selectedRow = dgvCharRef.SelectedRows(0)
                _PersonnelCharRefID1 = Convert.ToInt32(selectedRow.Cells(0).Value)
                selectedRow.Cells(1).Value = txtCompany.Text
                selectedRow.Cells(2).Value = txtFullName.Text
                selectedRow.Cells(3).Value = txtJobTitle.Text
                selectedRow.Cells(4).Value = txtDepartment.Text
                selectedRow.Cells(5).Value = txtMobileNum.Text
                selectedRow.Cells(6).Value = txtEmailAdd.Text
                selectedRow.Cells(7).Value = txtCompanyAdd.Text
                selectedRow.Cells(8).Value = txtRelationship.Text
            End If
        Else
            Dim newRowIndex As Integer = dgvCharRef.Rows.Add(_PersonnelCharRefID2, txtCompany.Text, txtFullName.Text, txtJobTitle.Text, txtDepartment.Text, txtMobileNum.Text, txtEmailAdd.Text, txtCompanyAdd.Text, txtRelationship.Text)
            dgvCharRef.Rows(newRowIndex).Tag = "New"
            _PersonnelCharRefID2 += 1
        End If
        ClearTransactionField()
    End Sub

    Private Sub ClearTransactionField()
        dgvCharRef.ClearSelection()
        _PersonnelCharRefID1 = _PersonnelCharRefID2
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnDelEmployee_Click(sender As Object, e As EventArgs) Handles btnDelEmployee.Click
        If dgvCharRef.Rows.Count > 0 Then
            Dim lastRow As DataGridViewRow = dgvCharRef.Rows(dgvCharRef.Rows.Count - 1)
            If lastRow.Tag?.ToString() = "New" Then
                dgvCharRef.Rows.Remove(lastRow)
            ElseIf dgvCharRef.SelectedRows.Count > 0 Then
                Del_Personnel_CharacterReference_ByID(dgvCharRef)
            Else
                MsgBox("Nothing to remove.")
            End If
            ClearTransactionField()
        End If
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        ClearTransactionField()
    End Sub

End Class