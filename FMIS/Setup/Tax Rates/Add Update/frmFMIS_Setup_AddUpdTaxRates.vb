Imports System.ComponentModel

Public Class frmFMIS_Setup_AddUpdTaxRates

    Private Sub frmFMIS_Setup_AddUpdTaxRates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Tax Rate"
        Call DropDownListChartOfAccounts(cbAccount)

        If isUpdate Then
            lblHeader.Text = "Üpdating Tax Rate"
            Call SelUpd_Setup_TaxRates_ByID()
            Exit Sub
        End If

        TaxRateID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
        UncheckCheckBoxes(Me)
        txtRate.Text = "0.00"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtCode.Text) OrElse String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_SupplierType()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdTaxRates_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
        UncheckCheckBoxes(Me)
        txtRate.Text = "0.00"
    End Sub

    Private Sub txtRate_Validating(sender As Object, e As CancelEventArgs) Handles txtRate.Validating
        Call Textbox_NumericFormat(txtRate, e.Cancel)
    End Sub

End Class