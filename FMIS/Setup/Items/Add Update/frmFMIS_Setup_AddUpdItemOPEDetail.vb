Imports System.ComponentModel

Public Class frmFMIS_Setup_AddUpdItemOPEDetail

    Private Sub frmFMIS_Setup_AddUpdItemOPEDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblHeader.Text = "Add New Item Out-Of-Pocket Detail"
        txtOPE.Text = frmFMIS_Setup_Items.lblDetail.Text
        Call DropDownListChartOfAccounts(cbAccount)
        Call DropDownListSupplier(cbVendor)

        If isUpdate Then
            lblHeader.Text = "Üpdating Item Out-Of-Pocket Detail"
            Call SelUpd_Setup_ItemOPE_Detail_ByID()
            Exit Sub
        End If

        ItemSubDetailID = 0 'set to ID = 0 to trigger insert in stored procedure

    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
        txtPrice.Text = "0.00"
        txtLifeSpan.Text = "0.00"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse String.IsNullOrWhiteSpace(txtCode.Text) OrElse String.IsNullOrWhiteSpace(cbAccount.Text) OrElse String.IsNullOrWhiteSpace(cbVendor.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_ItemOPE_Detail()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdItemOPEDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
        txtPrice.Text = "0.00"
        txtLifeSpan.Text = "0.00"
        isUpdate = False
    End Sub

    Private Sub txtLifeSpan_Validating(sender As Object, e As CancelEventArgs) Handles txtLifeSpan.Validating
        Textbox_NumericFormat(txtLifeSpan, e.Cancel)
    End Sub

    Private Sub txtPrice_Validating(sender As Object, e As CancelEventArgs) Handles txtPrice.Validating
        Textbox_NumericFormat(txtPrice, e.Cancel)
    End Sub

End Class