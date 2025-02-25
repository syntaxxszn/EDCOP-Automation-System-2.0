Public Class frmHR_Setup_Department


    Private Sub frmHR_Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Sel_Department(dgvDepartmentList, txtboxSearch)
    End Sub

    Private Sub toolstripBtnNew_Click(sender As Object, e As EventArgs) Handles toolstripBtnNew.Click
        frmHR_AddNewDepartment.ShowDialog()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        '\\ This code search record from database of Deparment %Search%.

        Search_DGVDepartment(dgvDepartmentList, txtboxSearch)

    End Sub


End Class