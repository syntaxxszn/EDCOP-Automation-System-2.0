Public Class frmFMIS_Setup_Subsidiary

    Private Sub frmFMIS_Setup_Subsidiary_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_Subsidiary(dgvType, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_Subsidiary(dgvType, toolstriplabelNoOfRecord)
    End Sub

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvType IsNot excludeDataGridView Then
            dgvType.ClearSelection()
        End If

        If dgvSubsidiaryAccount IsNot excludeDataGridView Then
            dgvSubsidiaryAccount.ClearSelection()
        End If
    End Sub

    Private Sub dgvType_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvType.CellContentClick

    End Sub

    Private Sub dgvType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvType.CellClick
        UnselectDataGridView(dgvType)
        If dgvType.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvType.SelectedRows(0)
            SubsidiaryTypeID = selectedRow.Cells(0).Value
            SubsidiaryAccountID = 0
            lblDetail.Visible = False
            Call Sel_Setup_SubsidiaryAccount_ByID(dgvSubsidiaryAccount)
        End If
    End Sub

    Private Sub dgvSubsidiaryAccount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubsidiaryAccount.CellContentClick

    End Sub

    Private Sub dgvSubsidiaryAccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubsidiaryAccount.CellClick
        UnselectDataGridView(dgvSubsidiaryAccount)
        If dgvSubsidiaryAccount.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvSubsidiaryAccount.SelectedRows(0)
            SubsidiaryAccountID = selectedRow.Cells(0).Value
            lblDetail.Text = selectedRow.Cells(3).Value
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If dgvSubsidiaryAccount.SelectedRows.Count > 0 And SubsidiaryAccountID <> 0 Then
            frmFMIS_Setup_AddUpdSubsidiaryAccount.ShowDialog()
        Else
            dgvType.ClearSelection()
            dgvSubsidiaryAccount.ClearSelection()
            MessageBox.Show("Unknown Action.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'frmFMIS_Setup_AddUpdSubsidiaryType.ShowDialog()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        isUpdate = True
        If dgvType.SelectedRows.Count > 0 Then
            MessageBox.Show("Unknown Action.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dgvSubsidiaryAccount.SelectedRows.Count > 0 And SubsidiaryAccountID <> 0 Then
            frmFMIS_Setup_AddUpdSubsidiaryAccount.ShowDialog()
        Else
            MessageBox.Show("Unknown Action.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isUpdate = False
        End If
    End Sub

    Private Sub dgvSubsidiaryAccount_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubsidiaryAccount.CellDoubleClick
        isUpdate = True
        frmFMIS_Setup_AddUpdSubsidiaryAccount.ShowDialog()
    End Sub

    Private Sub AddNewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewAccountToolStripMenuItem.Click
        frmFMIS_Setup_AddUpdSubsidiaryAccount.ShowDialog()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
        Dim targetGrid As DataGridView = Nothing

        ' Determine which grid to work with based on button text
        Select Case btnSearchFilter.Text
            Case "Account"
                targetGrid = dgvSubsidiaryAccount
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

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

End Class