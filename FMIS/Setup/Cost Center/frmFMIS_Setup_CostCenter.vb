Public Class frmFMIS_Setup_CostCenter

    Private Sub frmFMIS_Setup_CostCenter_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_CostCenter(dgvCostCenterDepartment, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_CostCenter(dgvCostCenterDepartment, toolstriplabelNoOfRecord)
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If Not HasUserAccess("insert") Then Return
        If dgvCostCenterProject.SelectedRows.Count > 0 Then

        Else
            frmHRIS_Setup_AddUpdDepartment.ShowDialog()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmHRIS_Setup_AddUpdDepartment.ShowDialog()
    End Sub

    Private Sub dgvCostCenterDepartment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCostCenterDepartment.CellClick
        UnselectDataGridView(dgvCostCenterDepartment)
        If dgvCostCenterDepartment.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCostCenterDepartment.SelectedRows(0)
            _strDepartmentID = selectedRow.Cells(0).Value
            lblCostCenter.Visible = False
            Sel_Setup_ProjectName_ByID(dgvCostCenterProject)
        End If
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvCostCenterDepartment IsNot excludeDataGridView Then
            dgvCostCenterDepartment.ClearSelection()
        End If

        If dgvCostCenterProject IsNot excludeDataGridView Then
            dgvCostCenterProject.ClearSelection()
        End If
    End Sub

    Private Sub dgvCostCenterProject_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCostCenterProject.CellClick
        UnselectDataGridView(dgvCostCenterProject)
        If dgvCostCenterProject.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCostCenterProject.SelectedRows(0)
            _strCostCenterID = selectedRow.Cells(0).Value
            lblCostCenter.Text = selectedRow.Cells(2).Value
        End If
    End Sub

    Private Sub lblCostCenter_TextChanged(sender As Object, e As EventArgs) Handles lblCostCenter.TextChanged
        lblCostCenter.Visible = True
    End Sub

    Private Sub dgvCostCenterDepartment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCostCenterDepartment.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmHRIS_Setup_AddUpdDepartment.ShowDialog()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

    End Sub
End Class