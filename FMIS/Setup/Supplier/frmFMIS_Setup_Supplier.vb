Public Class frmFMIS_Setup_Supplier

    Private Sub frmFMIS_Setup_Supplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_SupplierType(dgvType, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_SupplierType(dgvType, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvType IsNot excludeDataGridView Then
            dgvType.ClearSelection()
        End If

        If dgvSupplierAccount IsNot excludeDataGridView Then
            dgvSupplierAccount.ClearSelection()
        End If
    End Sub

    Private Sub dgvType_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvType.CellContentClick

    End Sub

    Private Sub dgvType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvType.CellClick
        UnselectDataGridView(dgvType)
        If dgvType.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvType.SelectedRows(0)
            SupplierTypeID = selectedRow.Cells(0).Value
            lblHeader.Text = selectedRow.Cells(1).Value
            SupplierAccountID = 0
            lblDetail.Visible = False
            Call Sel_Setup_SupplierAccount_ByID(dgvSupplierAccount)
        End If
    End Sub

    Private Sub dgvSupplierAccount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplierAccount.CellContentClick

    End Sub

    Private Sub dgvSupplierAccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplierAccount.CellClick
        UnselectDataGridView(dgvSupplierAccount)
        If dgvSupplierAccount.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvSupplierAccount.SelectedRows(0)
            SupplierAccountID = selectedRow.Cells(0).Value
            lblDetail.Text = selectedRow.Cells(2).Value
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If dgvSupplierAccount.SelectedRows.Count > 0 Then
            frmFMIS_Setup_AddUpdSupplierAccount.ShowDialog()
        Else
            dgvType.ClearSelection()
            frmFMIS_Setup_AddUpdSupplierType.ShowDialog()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        isUpdate = True
        If dgvType.SelectedRows.Count > 0 AndAlso SupplierTypeID <> 0 Then
            frmFMIS_Setup_AddUpdSupplierType.ShowDialog()
        ElseIf dgvSupplierAccount.SelectedRows.Count > 0 AndAlso SupplierAccountID <> 0 Then
            frmFMIS_Setup_AddUpdSupplierAccount.ShowDialog()
        Else
            MessageBox.Show("Unknown Action.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isUpdate = False
        End If
    End Sub

    Private Sub dgvType_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvType.CellDoubleClick
        isUpdate = True
        frmFMIS_Setup_AddUpdSupplierType.ShowDialog()
    End Sub

    Private Sub dgvSupplierAccount_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplierAccount.CellDoubleClick
        isUpdate = True
        frmFMIS_Setup_AddUpdSupplierAccount.ShowDialog()
    End Sub

    Private Sub AddNewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewAccountToolStripMenuItem.Click
        frmFMIS_Setup_AddUpdSupplierAccount.ShowDialog()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
        Dim targetGrid As DataGridView = Nothing

        ' Determine target grid
        Select Case btnSearchFilter.Text
            Case "Type"
                targetGrid = dgvType
                dgvSupplierAccount.Rows.Clear()

            Case "Account"
                targetGrid = dgvSupplierAccount
        End Select

        If targetGrid Is Nothing Then Exit Sub

        ' Require 3 chars (unless cleared)
        If keyword.Length < 3 AndAlso keyword <> "" Then Exit Sub

        frmLoading.Show()
        frmLoading.Refresh()

        Try
            targetGrid.Visible = True
            Dim matchFound As Boolean = False

            For Each row As DataGridViewRow In targetGrid.Rows
                If row.IsNewRow Then Continue For

                If keyword = "" Then
                    row.Visible = True
                    matchFound = True
                Else
                    Dim cellValue As String = If(row.Cells(1).Value, "").ToString().ToLower()
                    Dim isMatch As Boolean = cellValue.Contains(keyword)
                    row.Visible = isMatch
                    If isMatch Then matchFound = True
                End If
            Next

            If Not matchFound AndAlso keyword <> "" Then
                MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Finally
            frmLoading.Close()
        End Try

    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Type"
                btnSearchFilter.Text = "Account"
            Case Else
                btnSearchFilter.Text = "Type"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub lblDetail_TextChanged(sender As Object, e As EventArgs) Handles lblDetail.TextChanged
        lblDetail.Visible = True
    End Sub


End Class