Public Class frmFMIS_Setup_AddUpdCashFlowCategoryType

    Private Sub frmFMIS_Setup_CashFlowCategoryType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DropDownListCompany(cbCompany)

        lblHeader.Text = "Add New Cash Flow Category"

        If isUpdate Then
            lblHeader.Text = "Üpdating Cash Flow Category"
            Call SelUpd_Setup_CashFlow_CategoryType_ByID()
            Exit Sub
        End If

        _CashFlowCategoryID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetComboBoxes(Me)
        ClearTextBoxes(Me)
    End Sub

    Private Sub frmFMIS_Setup_AddUpdCashFlowCategoryType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ResetComboBoxes(Me)
        ClearTextBoxes(Me)
        isUpdate = False
        frmFMIS_Setup_CashFlowCategory.ClearDataGridViewSelectionAll()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtType.Text) OrElse cbCompany.Text = "" Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_CashFlow_CategoryType()
    End Sub

End Class