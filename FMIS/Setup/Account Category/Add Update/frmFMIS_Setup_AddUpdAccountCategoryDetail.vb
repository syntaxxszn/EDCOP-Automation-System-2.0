Public Class frmFMIS_Setup_AddUpdAccountCategoryDetail

    Private Sub frmFMIS_Setup_AddUpdAccountCategoryDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Account Category Detail"

        If isUpdate Then
            lblHeader.Text = "Updating Account Category Detail"
            Call SelUpd_Setup_AccountCategoryDetail_ByID()
            Exit Sub
        End If

        Sel_Setup_AccountCategory_Detail_Code(txtCode)
        _AccountCategoryDetailID = 0 'set to ID = 0 to trigger insert in stored procedure

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdAccountCategoryDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrWhiteSpace(txtCode.Text) OrElse String.IsNullOrWhiteSpace(txtType.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_AccountCategory_Detail()

    End Sub

End Class