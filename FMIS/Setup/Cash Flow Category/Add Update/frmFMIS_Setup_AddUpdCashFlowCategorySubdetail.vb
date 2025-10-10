Public Class frmFMIS_Setup_AddUpdCashFlowCategorySubdetail

    Private Sub frmFMIS_Setup_AddUpdCashFlowCategorySubdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Cash Flow Category Subdetail"
        txtDetailName.Text = _strCashFlowCategoryDetail

        If isUpdate Then
            lblHeader.Text = "Üpdating Cash Flow Category Subdetail"
            Call SelUpd_Setup_CashFlow_CategorySubdetail_ByID()
            Exit Sub
        End If

        _CashFlowCategorySubDetailID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSubdetailName.Clear()
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtSubdetailName.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_CashFlow_CategorySubdetail()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdCashFlowCategorySubdetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmFMIS_Setup_CashFlowCategory.ClearDataGridViewSelectionAll()
        _strCashFlowCategoryDetail = Nothing
        ClearTextBoxes(Me)
        isUpdate = False
    End Sub

End Class