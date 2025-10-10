Public Class frmSSM_SystemUserAccess_AddUpdAccess

    Private Sub frmSSM_SystemUserAccess_AddUpdAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DropDownListGroupAccess(cbGroupAccess)
        Call DropDownListUserAccess(cbAccessType)
        Call SelUpd_UserAccess_ByEmployeeID()
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ClearTextBoxes(Me)
        Call ResetComboBoxes(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call InsUpd_UserAccess_ByEmployeeID()
    End Sub

    Private Sub frmSSM_SystemUserAccess_AddUpdAccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call ClearTextBoxes(Me)
        Call ResetComboBoxes(Me)
    End Sub
End Class