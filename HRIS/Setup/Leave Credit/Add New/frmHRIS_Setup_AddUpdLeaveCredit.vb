Imports System.ComponentModel

Public Class frmHRIS_Setup_AddUpdLeaveCredit

    Public isUpdate As Boolean = False

    Private Sub frmHR_Setup_AddNewLeaveCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DropDownListLeaveType(cbLeaveType)
        Call SelUpd_Employee_Leave_Credits_By_ID(dgvLeaveCredits)
    End Sub

    Private Sub txtLeaveCount_Validating(sender As Object, e As CancelEventArgs) Handles txtLeaveCount.Validating
        Textbox_NumericFormat(txtLeaveCount, e.Cancel)
    End Sub

    Private Sub btnAddUpdLeave_Click(sender As Object, e As EventArgs) Handles btnAddUpdLeave.Click
        If String.IsNullOrWhiteSpace(cbLeaveType.Text) OrElse
               String.IsNullOrWhiteSpace(txtLeaveCount.Text) OrElse txtLeaveCount.Text = "00.00" Then
            MessageBox.Show("Error! Please fill up all fields required.")
            Return
        End If

        Dim exists As Boolean = dgvLeaveCredits.Rows.Cast(Of DataGridViewRow)().
            Any(Function(row) row.Cells(0).Value.ToString() = cbLeaveType.Text)

        If exists Then
            If MessageBox.Show("Are you sure you want to update this record?", "Warning Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim selectedRow = dgvLeaveCredits.SelectedRows(0)
                selectedRow.Cells(0).Value = cbLeaveType.SelectedItem
                selectedRow.Cells(1).Value = txtLeaveCount.Text
                selectedRow.Cells(2).Value = dtpLeaveIssuance.Value.ToString("MM-dd-yy / ddd").ToUpper()
            End If
        Else
            Dim newRowIndex As Integer = dgvLeaveCredits.Rows.Add(cbLeaveType.Text, txtLeaveCount.Text, dtpLeaveIssuance.Value.ToString("MM-dd-yy / ddd").ToUpper())
            dgvLeaveCredits.Rows(newRowIndex).Tag = "New"
        End If

        ClearTransactionField()
    End Sub

    Private Sub ClearTransactionField()
        dgvLeaveCredits.ClearSelection()
        txtLeaveCount.Text = "00.00"
        dtpLeaveIssuance.Value = Date.Now
        cbLeaveType.SelectedIndex = -1
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        ClearTransactionField()
    End Sub

    Private Sub dgvLeaveCredits_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeaveCredits.CellDoubleClick
        If dgvLeaveCredits.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvLeaveCredits.SelectedRows(0)
            isUpdate = True
            Dim type As Integer = cbLeaveType.FindStringExact(selectedRow.Cells(0).Value.ToString())
            If type <> -1 Then cbLeaveType.SelectedIndex = type
            txtLeaveCount.Text = selectedRow.Cells(1).Value
            If IsDate(selectedRow.Cells(2).Value) Then
                dtpLeaveIssuance.Value = CDate(selectedRow.Cells(2).Value)
            End If
            isUpdate = False
        End If
    End Sub

    Private Sub cbLeaveType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLeaveType.SelectedIndexChanged
        If isUpdate Then Exit Sub
        If dgvLeaveCredits.Rows.Cast(Of DataGridViewRow)().Any(Function(r) r.Cells(0).Value?.ToString() = cbLeaveType.Text) Then
            MessageBox.Show("Leave Type already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call ClearTransactionField()
        End If
    End Sub

    Private Sub btnSubmitLeaveCredits_Click(sender As Object, e As EventArgs) Handles btnSubmitLeaveCredits.Click
        InsUpd_Employee_Leave_Credits(dgvLeaveCredits)
    End Sub

    'Private Sub frmHR_Setup_AddNewLeaveCredit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    '    ClearTransactionField()
    '    ClearDataGridViewRows(Me)
    'End Sub


End Class
