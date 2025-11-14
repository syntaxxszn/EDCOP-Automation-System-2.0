Public Class frmFMIS_Setup_AddUpdBankName

    Private Sub frmFMIS_Setup_AddUpdBankAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Bank"

        If isUpdate Then
            lblHeader.Text = "Üpdating Bank"
            Call SelUpd_Setup_BankName_ByID()
            Exit Sub
        End If

        BankID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_BankName()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdBankAccount_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtName.Clear()
        isUpdate = False
    End Sub

End Class