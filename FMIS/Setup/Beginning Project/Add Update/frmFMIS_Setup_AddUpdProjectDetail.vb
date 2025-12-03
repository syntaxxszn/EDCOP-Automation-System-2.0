Imports System.ComponentModel

Public Class frmFMIS_Setup_AddUpdProjectDetail

    Private Sub frmFMIS_Setup_AddUpdProjectDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call DropDownListChartOfAccounts(cbAccount)

        lblHeader.Text = "Add New Project Detail"

        If isUpdate Then
            lblHeader.Text = "Üpdating Project Detail"
            Call SelUpd_FMIS_Setup_ProjectDetail_ByID(dgvProjectAccount)
            Call SumAccounts(dgvProjectAccount)
            Exit Sub
        End If

        BeginProjectDetailID = 0 'set to ID = 0 to trigger insert in stored procedure

    End Sub

    Private Sub txtPrice_Validating(sender As Object, e As CancelEventArgs) Handles txtAmount.Validating
        Textbox_NumericFormat(txtAmount, e.Cancel)
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        cbAccount.SelectedIndex = -1
        txtAmount.Text = "0.00"
        dgvProjectAccount.ClearSelection()
        Call SumAccounts(dgvProjectAccount)
    End Sub

    Private Sub btnAddUpdLeave_Click(sender As Object, e As EventArgs) Handles btnAddUpdLeave.Click

        If String.IsNullOrWhiteSpace(cbAccount.Text) OrElse
             String.IsNullOrWhiteSpace(txtAmount.Text) Then
            MessageBox.Show("Error! Please fill up all fields required.")
            Return
        End If

        Dim exists As Boolean =
                dgvProjectAccount.Rows.Cast(Of DataGridViewRow)().
                Where(Function(r) Not r.IsNewRow).
                Any(Function(row) CStr(row.Cells(0).Value) = cbAccount.Text)

        If exists Then

            If dgvProjectAccount.SelectedRows.Count = 0 Then
                MessageBox.Show("Error encountered, please check account selected if exists.")
                btnClearTextFields.PerformClick()
                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to update this record?", "Warning Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim selectedRow = dgvProjectAccount.SelectedRows(0)
                selectedRow.Cells(0).Value = cbAccount.SelectedItem
                selectedRow.Cells(1).Value = Convert.ToDecimal(txtAmount.Text)
            End If
        Else
            Dim amount As Decimal
            If Decimal.TryParse(txtAmount.Text, amount) Then
                Dim newRowIndex As Integer = dgvProjectAccount.Rows.Add(cbAccount.Text, amount.ToString("N2"))
                dgvProjectAccount.Rows(newRowIndex).Tag = "New"
            Else
                MessageBox.Show("Invalid amount entered.")
            End If
        End If

        Call SumAccounts(dgvProjectAccount)

        txtAmount.Text = "0.00"
        cbAccount.SelectedIndex = -1
        dgvProjectAccount.ClearSelection()

    End Sub

    Private Sub dgvProjectAccount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectAccount.CellContentClick

    End Sub

    Private Sub dgvProjectAccount_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectAccount.CellDoubleClick

        If dgvProjectAccount.SelectedRows.Count > 0 Then

            Dim selectedRow = dgvProjectAccount.SelectedRows(0)
            Dim accountname As Integer = cbAccount.FindStringExact(selectedRow.Cells(0).Value.ToString())
            If accountname <> -1 Then cbAccount.SelectedIndex = accountname
            txtAmount.Text = selectedRow.Cells(1).Value

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        If MessageBox.Show("This will empty the table above, proceed?", "Warning Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            cbAccount.SelectedIndex = -1
            txtAmount.Text = "0.00"
            lblTotal.Text = "0.00"
            dgvProjectAccount.Rows.Clear()
            Call SumAccounts(dgvProjectAccount)
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim hasRows As Boolean =
                dgvProjectAccount.Rows.Cast(Of DataGridViewRow)().
                Any(Function(r) Not r.IsNewRow)

        If String.IsNullOrWhiteSpace(txtProjectName.Text) OrElse Not hasRows Then
            MessageBox.Show("Nothing to save.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Call ProcessDataGridView_Setup_ProjectDetail(dgvProjectAccount)
    End Sub

    Private Sub frmFMIS_Setup_AddUpdProjectDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        ClearDataGridViewRows(Me)
        txtAmount.Text = "0.00"
        lblTotal.Text = "0.00"
        isUpdate = False
    End Sub

    Private Sub SumAccounts(dgv As DataGridView)
        Dim total As Decimal = 0D

        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Dim v = row.Cells(1).Value
                If v IsNot Nothing AndAlso IsNumeric(v) Then
                    total += CDec(v)
                End If
            End If
        Next

        lblTotal.Text = total.ToString("N2")
    End Sub

End Class