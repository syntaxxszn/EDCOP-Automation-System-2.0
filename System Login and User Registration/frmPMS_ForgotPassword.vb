Public Class frmPMS_ForgotPassword

    Private Sub frmPMS_ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MessageBox.Show("On-going development. =)", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class