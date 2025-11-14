Public Class frmFMIS_Setup_BankAccount

    Private Sub frmFMIS_Setup_BankAccount_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_BankAccounts(dgvBankName)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_BankAccounts(dgvBankName)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If dgvBankAccount.SelectedRows.Count > 0 Then
            frmFMIS_Setup_AddUpdBankAccount.ShowDialog()
        Else
            dgvBankName.ClearSelection()
            frmFMIS_Setup_AddUpdBankName.ShowDialog()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        isUpdate = True
        If dgvBankName.SelectedRows.Count > 0 And BankID <> 0 Then
            frmFMIS_Setup_AddUpdBankName.ShowDialog()
        ElseIf dgvBankAccount.SelectedRows.Count > 0 Then
            frmFMIS_Setup_AddUpdBankAccount.ShowDialog()
        Else
            MessageBox.Show("Unknown Action.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isUpdate = False
        End If
    End Sub

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvBankName IsNot excludeDataGridView Then
            dgvBankName.ClearSelection()
        End If

        If dgvBankAccount IsNot excludeDataGridView Then
            dgvBankAccount.ClearSelection()
        End If
    End Sub

    Private Sub dgvBankAccount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBankName.CellContentClick

    End Sub

    Private Sub dgvBankAccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBankName.CellClick
        UnselectDataGridView(dgvBankName)
        If dgvBankName.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvBankName.SelectedRows(0)
            BankID = selectedRow.Cells(0).Value
            BankDetailID = 0
            lblCostCenter.Visible = False
            frmFMIS_Setup_AddUpdBankAccount.txtName.Text = selectedRow.Cells(1).Value
            Sel_Setup_BankAccounts_ByID(dgvBankAccount)
        End If
    End Sub

    Private Sub dgvBankAccountDetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBankAccount.CellClick
        UnselectDataGridView(dgvBankAccount)
        If dgvBankAccount.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvBankAccount.SelectedRows(0)
            BankDetailID = selectedRow.Cells(0).Value
            lblCostCenter.Text = selectedRow.Cells(3).Value
        End If
    End Sub

    Private Sub dgvBankAccount_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBankName.CellDoubleClick
        isUpdate = True
        frmFMIS_Setup_AddUpdBankName.ShowDialog()
    End Sub

    Private Sub dgvBankAccountDetail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBankAccount.CellDoubleClick
        isUpdate = True
        frmFMIS_Setup_AddUpdBankAccount.ShowDialog()
    End Sub

    Private Sub AddNewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewAccountToolStripMenuItem.Click
        frmFMIS_Setup_AddUpdBankAccount.ShowDialog()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
        Dim targetGrid As DataGridView = Nothing

        ' Determine which grid to work with based on button text
        Select Case btnSearchFilter.Text
            Case "Bank Account"
                targetGrid = dgvBankAccount
            Case "Bank Name"
                targetGrid = dgvBankName
                dgvBankAccount.Rows.Clear()
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

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Bank Name"
                btnSearchFilter.Text = "Bank Account"
            Case Else
                btnSearchFilter.Text = "Bank Name"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub dgvBankAccount_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvBankName.RowsAdded
        toolstriplabelNoOfRecord.Text = dgvBankName.Rows.Count.ToString("N2")
    End Sub

    Private Sub dgvBankAccount_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvBankName.RowsRemoved
        toolstriplabelNoOfRecord.Text = dgvBankName.Rows.Count.ToString("N2")
    End Sub

    Private Sub lblCostCenter_TextChanged(sender As Object, e As EventArgs) Handles lblCostCenter.TextChanged
        lblCostCenter.Visible = True
    End Sub

End Class