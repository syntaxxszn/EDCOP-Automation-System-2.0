Public Class frmFMIS_Setup_AddUpdBankAccount

    Private Sub frmFMIS_Setup_AddUpdBankAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblHeader.Text = "Add New Bank Account"

        DropDownListCurrency(cbCurrency)
        DropDownListBankCategoryAccount(cbAccountTitle)

        If isUpdate Then
            lblHeader.Text = "Üpdating Bank Account"
            Call SelUpd_Setup_BankAccount_ByID()
            Exit Sub
        End If

        BankDetailID = 0 'set to ID = 0 to trigger insert in stored procedure

    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cbAccountTitle.SelectedIndex = -1
        cbCurrency.SelectedIndex = -1
        txtAccountNo.Clear()
        txtBranchName.Clear()
        chForeign.Checked = False
    End Sub

    Private Sub frmFMIS_Setup_AddUpdBankAccount_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        ResetComboBoxes(Me)
        txtAccountNo.Clear()
        txtBranchName.Clear()
        txtName.Clear()
        chForeign.Checked = False
        isUpdate = False

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrWhiteSpace(txtName.Text) OrElse String.IsNullOrWhiteSpace(txtBranchName.Text) OrElse
         String.IsNullOrWhiteSpace(txtAccountNo.Text) OrElse String.IsNullOrWhiteSpace(cbAccountTitle.Text) OrElse String.IsNullOrWhiteSpace(cbCurrency.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_BankAccount()

    End Sub

End Class