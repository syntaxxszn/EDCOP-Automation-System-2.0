Public Class frmFMIS_Setup_AccountBalances

    Private Sub frmFMIS_Setup_AccountBalances_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_AccountBalances(dgvYear, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_AccountBalances(dgvYear, toolstriplabelNoOfRecord)
        lblHeader.Text = ""
        AccountBalancesYear = 0
        AccountBalancesID = 0
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvYear IsNot excludeDataGridView Then
            dgvYear.ClearSelection()
        End If

        If dgvDecemberAudited IsNot excludeDataGridView Then
            dgvDecemberAudited.ClearSelection()
        End If
    End Sub

    Private Sub dgvYear_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvYear.CellContentClick

    End Sub

    Private Sub dgvYear_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvYear.CellClick
        UnselectDataGridView(dgvYear)
        If dgvYear.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvYear.SelectedRows(0)
            AccountBalancesYear = selectedRow.Cells(0).Value
            lblHeader.Text = selectedRow.Cells(0).Value
            AccountBalancesID = 0
            lblDetail.Visible = False
            Call Sel_Setup_AccountBalances_ByID(dgvDecemberAudited, 0)
        End If
    End Sub

    Private Sub dgvYear_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvYear.CellDoubleClick

    End Sub

    Private Sub lblDetail_TextChanged(sender As Object, e As EventArgs) Handles lblDetail.TextChanged
        lblDetail.Visible = True
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmFMIS_Setup_AddAccountBalances.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If AccountBalancesYear = 0 OrElse dgvYear.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a year.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        frmFMIS_Setup_UpdAccountBalances.ShowDialog()

    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()

        ' Require 3 chars (unless cleared)
        If keyword.Length < 3 AndAlso keyword <> "" Then Exit Sub

        frmLoading.Show()
        frmLoading.Refresh()

        Try

            Select Case btnSearchFilter.Text
                Case "Year"
                    Call Sel_Setup_AccountBalances(dgvYear, toolstriplabelNoOfRecord)
                Case Else
                    Call Sel_Setup_AccountBalances_ByID(dgvDecemberAudited, 0)
            End Select

        Finally
            frmLoading.Close()
        End Try

    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Year"
                btnSearchFilter.Text = "Account"
            Case Else
                btnSearchFilter.Text = "Year"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub dgvDecemberAudited_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDecemberAudited.CellContentClick

    End Sub

    Private Sub dgvDecemberAudited_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDecemberAudited.CellClick
        UnselectDataGridView(dgvDecemberAudited)
        If dgvDecemberAudited.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvDecemberAudited.SelectedRows(0)
            AccountBalancesID = selectedRow.Cells(0).Value
            lblDetail.Text = selectedRow.Cells(2).Value
        End If
    End Sub

    Private Sub dgvDecemberAudited_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDecemberAudited.CellDoubleClick
        frmFMIS_Setup_UpdAccountBalances.ShowDialog()
    End Sub

End Class