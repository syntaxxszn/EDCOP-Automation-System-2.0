Public Class frmFMIS_Setup_AddUpdTransactionClosing

    Private Sub frmFMIS_Setup_AddUpdTransactionClosing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Transaction Closing"

        If isUpdate Then
            lblHeader.Text = "Üpdating Transaction Closing"
            Call SelUpd_Setup_Transaction_Closing_ByID()
            Exit Sub
        End If

        TransactionClosingID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetDatePickers(Me)
        UncheckCheckBoxes(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call InsUpd_Setup_Transaction_Closing()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdTransactionClosing_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        ResetDatePickers(Me)
        UncheckCheckBoxes(Me)
    End Sub

End Class