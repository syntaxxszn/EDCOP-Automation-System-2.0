Public Class frmHR_PreviewPersonnelDetails_OneTimePasscode
    Private Sub frmHR_PreviewPersonnelDetails_OneTimePasscode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectLogin_OneTimePasscode(lblPinCode)
    End Sub

    Private Sub btnRegenerate_Click(sender As Object, e As EventArgs) Handles btnRegenerate.Click
        Dim pin As String = GenerateSecurePin()
        InsertLogin_OneTimePasscode(pin)
        lblPinCode.Text = pin
    End Sub

    Private Sub frmHR_PreviewPersonnelDetails_OneTimePasscode_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        lblPinCode.Text = ""
    End Sub

End Class