Public Class frmFMIS_Setup_AddUpdCashFlowCategoryDetail

    Private Sub frmFMIS_Setup_AddUpdCashFlowCategoryDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Cash Flow Category Detail"
        txtTypeName.Text = _strCashFlowCategory

        If isUpdate Then
            lblHeader.Text = "Üpdating Cash Flow Category Detail"
            Call SelUpd_Setup_CashFlow_CategoryDetail_ByID()
            Exit Sub
        End If

        _CashFlowCategoryDetailID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtDetailName.Clear()
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtDetailName.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_CashFlow_CategoryDetail()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdCashFlowCategoryDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmFMIS_Setup_CashFlowCategory.ClearDataGridViewSelectionAll()
        _strCashFlowCategory = Nothing
        ClearTextBoxes(Me)
        isUpdate = False
    End Sub

End Class