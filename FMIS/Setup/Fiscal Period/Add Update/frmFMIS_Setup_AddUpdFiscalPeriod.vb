Public Class frmFMIS_Setup_AddUpdFiscalPeriod
    Private Sub frmFMIS_Setup_FiscalPeriod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DropDownListTaxForms(cbTaxForm)

        lblHeader.Text = "Add New Fiscal Period"

        If isUpdate Then
            lblHeader.Text = "Üpdating Fiscal Period"
            Call SelUpd_FiscalPeriod_ByID()
            Exit Sub
        End If

        _FiscalPeriodID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetDatePickers(Me)
        ResetComboBoxes(Me)
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cbTaxForm.Text = "" Then
            MessageBox.Show("Error! Please fill up all fields required.")
            Return
        End If

        InsUpd_FiscalPeriod()
    End Sub

    Private Sub frmFMIS_Setup_FiscalPeriod_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ResetDatePickers(Me)
        ResetComboBoxes(Me)
    End Sub

End Class