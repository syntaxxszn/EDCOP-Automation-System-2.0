Public Class frmFMIS_Setup_AddUpdSupplierAccount

    Private Sub frmFMIS_Setup_AddUpdSupplierAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Supplier Account"

        If isUpdate Then
            lblHeader.Text = "Üpdating Supplier Account"
            Call SelUpd_Setup_SupplierAccount_ByID()
            Exit Sub
        End If

        SupplierAccountID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextBoxes(Me)
        UncheckCheckBoxes(Me)
        ResetRadioButtons(Me)
        txtBalance.Text = "0.00"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtCode.Text) OrElse String.IsNullOrWhiteSpace(txtTitle.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_SupplierAccount()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdSupplierAccount_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        UncheckCheckBoxes(Me)
        ResetRadioButtons(Me)
        txtBalance.Text = "0.00"
        isUpdate = False
    End Sub

End Class