Public Class frmFMIS_Setup_CashFlowCategory

    Private Sub frmFMIS_Setup_CashFlowCategory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Sel_Setup_CashFlow_CategoryType(dgvCashFlowType, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Sel_Setup_CashFlow_CategoryType(dgvCashFlowType, toolstriplabelNoOfRecord)
        ClearDataGridViewSelectionAll()
        dgvCashFlowSubdetail.Rows.Clear()
        dgvCashFlowDetail.Rows.Clear()
        lblDetailName.Visible = False
        lblSubdetailName.Visible = False
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If Not HasUserAccess("insert") Then Return

        If dgvCashFlowType.SelectedRows.Count > 0 Then
            frmFMIS_Setup_AddUpdCashFlowCategoryDetail.ShowDialog()
        ElseIf dgvCashFlowDetail.SelectedRows.Count > 0 Then
            frmFMIS_Setup_AddUpdCashFlowCategorySubdetail.ShowDialog()
        ElseIf dgvCashFlowSubdetail.SelectedRows.Count > 0 Then
            MessageBox.Show("Action not allowed.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            frmFMIS_Setup_AddUpdCashFlowCategoryType.ShowDialog()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        If dgvCashFlowType.SelectedRows.Count > 0 Then
            frmFMIS_Setup_AddUpdCashFlowCategoryType.ShowDialog()
        ElseIf dgvCashFlowDetail.SelectedRows.Count > 0 Then
            frmFMIS_Setup_AddUpdCashFlowCategoryDetail.ShowDialog()
        ElseIf dgvCashFlowsubdetail.SelectedRows.Count > 0 Then
            frmFMIS_Setup_AddUpdCashFlowCategorySubdetail.ShowDialog()
        End If
    End Sub

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvCashFlowType IsNot excludeDataGridView Then
            dgvCashFlowType.ClearSelection()
        End If

        If dgvCashFlowDetail IsNot excludeDataGridView Then
            dgvCashFlowDetail.ClearSelection()
        End If

        If dgvCashFlowSubdetail IsNot excludeDataGridView Then
            dgvCashFlowSubdetail.ClearSelection()
        End If
    End Sub

    Public Sub ClearDataGridViewSelectionAll()
        dgvCashFlowDetail.ClearSelection()
        dgvCashFlowSubdetail.ClearSelection()
        dgvCashFlowType.ClearSelection()
    End Sub

    Private Sub dgvCashFlowType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlowType.CellClick
        UnselectDataGridView(dgvCashFlowType)
        If dgvCashFlowType.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCashFlowType.SelectedRows(0)
            _CashFlowCategoryID = selectedRow.Cells(0).Value
            _strCashFlowCategory = selectedRow.Cells(1).Value
            Sel_Setup_CashFlow_CategoryDetail(dgvCashFlowDetail)
            lblDetailName.Visible = False
            lblSubdetailName.Visible = False
            dgvCashFlowSubdetail.Rows.Clear()
        End If
    End Sub

    Private Sub dgvCashFlowType_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlowType.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmFMIS_Setup_AddUpdCashFlowCategoryType.ShowDialog()
    End Sub

    Private Sub dgvCashFlowDetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlowDetail.CellClick
        UnselectDataGridView(dgvCashFlowDetail)
        If dgvCashFlowDetail.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCashFlowDetail.SelectedRows(0)
            _CashFlowCategoryDetailID = selectedRow.Cells(0).Value
            _strCashFlowCategoryDetail = selectedRow.Cells(1).Value
            lblDetailName.Text = selectedRow.Cells(1).Value
            Sel_Setup_CashFlow_CategorySubdetail(dgvCashFlowSubdetail)
            lblSubdetailName.Visible = False
        End If
    End Sub

    Private Sub dgvCashFlowDetail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlowDetail.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmFMIS_Setup_AddUpdCashFlowCategoryDetail.ShowDialog()
    End Sub

    Private Sub dgvCashFlowSubdetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlowSubdetail.CellClick
        UnselectDataGridView(dgvCashFlowSubdetail)
        If dgvCashFlowSubdetail.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCashFlowSubdetail.SelectedRows(0)
            _CashFlowCategorySubDetailID = selectedRow.Cells(0).Value
            lblSubdetailName.Text = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub dgvCashFlowSubdetail_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCashFlowSubdetail.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmFMIS_Setup_AddUpdCashFlowCategorySubdetail.ShowDialog()
    End Sub

    Private Sub AddNewCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCategoryToolStripMenuItem.Click
        frmFMIS_Setup_AddUpdCashFlowCategoryDetail.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If Not HasUserAccess("delete") Then Return
        If dgvCashFlowType.Rows.Count <> 0 Then
            MessageBox.Show("Error Occured: This item is a Parent, please delete its child before proceeding.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Del_Setup_CashFlow_Category_ByID(dgvCashFlowType)
    End Sub

    Private Sub AddNewDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewDetailToolStripMenuItem.Click
        frmFMIS_Setup_AddUpdCashFlowCategorySubdetail.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If Not HasUserAccess("delete") Then Return
        If dgvCashFlowDetail.Rows.Count <> 0 Then
            MessageBox.Show("Error Occured: This item is a Parent, please delete its child before proceeding.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Del_Setup_CashFlow_CategoryDetail_ByID(dgvCashFlowDetail)
        lblDetailName.Visible = False
    End Sub

    Private Sub AddNewSubdetailToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If Not HasUserAccess("delete") Then Return
        Del_Setup_CashFlow_CategorySubdetail_ByID(dgvCashFlowSubdetail)
    End Sub

    Private Sub lblDetailName_TextChanged(sender As Object, e As EventArgs) Handles lblDetailName.TextChanged
        lblDetailName.Visible = True
    End Sub

    Private Sub lblSubdetailName_TextChanged(sender As Object, e As EventArgs) Handles lblSubdetailName.TextChanged
        lblSubdetailName.Visible = True
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Category"
                btnSearchFilter.Text = "Detail"
            Case "Detail"
                btnSearchFilter.Text = "Sub - Detail"
            Case Else
                btnSearchFilter.Text = "Category"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
        Dim targetGrid As DataGridView = Nothing

        ' Determine which grid to work with based on button text
        Select Case btnSearchFilter.Text
            Case "Category"
                targetGrid = dgvCashFlowType
            Case "Detail"
                targetGrid = dgvCashFlowDetail
            Case "Sub - Detail"
                targetGrid = dgvCashFlowSubdetail
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
End Class