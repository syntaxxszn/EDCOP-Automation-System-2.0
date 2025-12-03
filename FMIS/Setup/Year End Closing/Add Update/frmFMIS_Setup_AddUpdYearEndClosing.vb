Public Class frmFMIS_Setup_AddUpdYearEndClosing

    Private Sub frmFMIS_Setup_AddUpdYearEndClosing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Year End Closing"

        If isUpdate Then
            lblHeader.Text = "Üpdating Year End Closing"
            Call SelUpd_Setup_YearEnd_Closing_ByID()
            Exit Sub
        End If

        YearEndClosingID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetDatePickers(Me)
    End Sub

    Private Sub frmFMIS_Setup_AddUpdYearEndClosing_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        ResetDatePickers(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call InsUpd_Setup_YearEnd_Closing()
    End Sub

End Class