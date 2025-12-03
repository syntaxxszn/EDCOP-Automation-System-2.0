Public Class frmFMIS_Setup_Items

    Private Sub frmFMIS_Setup_Items_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_Item_CategoryType(dgvType, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        If dgvOPE.SelectedRows.Count > 0 Then
            Call Sel_Setup_Item_CategoryType(dgvType, toolstriplabelNoOfRecord)
        ElseIf dgvOPE.SelectedRows.Count > 0 Then
            Call Sel_Setup_Item_OPE_ByID(dgvOPE)
        Else
            Call Sel_Setup_Item_OPE_Detail_ByID(dgvSubDetail)
        End If
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvType IsNot excludeDataGridView Then
            dgvType.ClearSelection()
        End If

        If dgvOPE IsNot excludeDataGridView Then
            dgvOPE.ClearSelection()
        End If

        If dgvSubDetail IsNot excludeDataGridView Then
            dgvSubDetail.ClearSelection()
        End If
    End Sub

    Private Sub dgvType_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvType.CellContentClick

    End Sub

    Private Sub dgvType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvType.CellClick
        UnselectDataGridView(dgvType)
        If dgvType.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvType.SelectedRows(0)
            ItemCategoryID = selectedRow.Cells(0).Value
            lblHeader.Text = selectedRow.Cells(1).Value
            ItemOPEID = 0
            lblDetail.Visible = False
            Call Sel_Setup_Item_OPE_ByID(dgvOPE)
            dgvSubDetail.Rows.Clear()
        End If
    End Sub

    Private Sub dgvOPE_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOPE.CellContentClick

    End Sub

    Private Sub dgvOPE_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOPE.CellClick
        UnselectDataGridView(dgvOPE)
        If dgvOPE.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvOPE.SelectedRows(0)
            ItemOPEID = selectedRow.Cells(0).Value
            lblDetail.Text = selectedRow.Cells(1).Value
            ItemSubDetailID = 0
            lblSubDetail.Visible = False
            Call Sel_Setup_Item_OPE_Detail_ByID(dgvSubDetail)
        End If
    End Sub

    Private Sub lblDetail_TextChanged(sender As Object, e As EventArgs) Handles lblDetail.TextChanged
        lblDetail.Visible = True
    End Sub

    Private Sub lblSubDetail_TextChanged(sender As Object, e As EventArgs) Handles lblSubDetail.TextChanged
        lblSubDetail.Visible = True
    End Sub

    Private Sub dgvSubDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubDetail.CellContentClick

    End Sub

    Private Sub dgvSubDetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubDetail.CellClick
        UnselectDataGridView(dgvSubDetail)
        If dgvSubDetail.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvSubDetail.SelectedRows(0)
            ItemSubDetailID = selectedRow.Cells(0).Value
            lblSubDetail.Text = selectedRow.Cells(2).Value
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If dgvOPE.SelectedRows.Count > 0 Then
            frmFMIS_Setup_AddUpdItemOPE.ShowDialog()
        ElseIf dgvOPE.SelectedRows.Count > 0 Then
            frmFMIS_Setup_AddUpdItemOPEDetail.ShowDialog()
        Else
            frmFMIS_Setup_AddUpdItemCategory.ShowDialog()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        isUpdate = True
        If dgvType.SelectedRows.Count > 0 AndAlso ItemCategoryID <> 0 Then
            frmFMIS_Setup_AddUpdItemCategory.ShowDialog()
        ElseIf dgvOPE.SelectedRows.Count > 0 AndAlso ItemOPEID <> 0 Then
            frmFMIS_Setup_AddUpdItemOPE.ShowDialog()
        ElseIf dgvSubDetail.SelectedRows.Count > 0 AndAlso ItemSubDetailID <> 0 Then
            frmFMIS_Setup_AddUpdItemOPEDetail.ShowDialog()
        Else
            isUpdate = False
        End If
    End Sub

    Private Sub dgvType_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvType.CellDoubleClick
        isUpdate = True
        frmFMIS_Setup_AddUpdItemCategory.ShowDialog()
    End Sub

    Private Sub dgvOPE_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOPE.CellDoubleClick
        isUpdate = True
        frmFMIS_Setup_AddUpdItemOPE.ShowDialog()
    End Sub

    Private Sub AddNewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewAccountToolStripMenuItem.Click
        isUpdate = False
        frmFMIS_Setup_AddUpdItemOPE.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        isUpdate = False
        frmFMIS_Setup_AddUpdItemOPEDetail.ShowDialog()
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Category Type"
                btnSearchFilter.Text = "OPE Items"
            Case "OPE Items"
                btnSearchFilter.Text = "Sub Detail"
            Case Else
                btnSearchFilter.Text = "Category Type"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
        Dim targetGrid As DataGridView = Nothing

        ' Determine target grid
        Select Case btnSearchFilter.Text
            Case "Category Type"
                targetGrid = dgvType
                dgvOPE.Rows.Clear()
                dgvSubDetail.Rows.Clear()

            Case "OPE Items"
                targetGrid = dgvOPE
                dgvSubDetail.Rows.Clear()

            Case "Sub Detail"
                targetGrid = dgvSubDetail
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

    Private Sub dgvSubDetail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubDetail.CellDoubleClick
        isUpdate = True
        frmFMIS_Setup_AddUpdItemOPEDetail.ShowDialog()
    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub
End Class