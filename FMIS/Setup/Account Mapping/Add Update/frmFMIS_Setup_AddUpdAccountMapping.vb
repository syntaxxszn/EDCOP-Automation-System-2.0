Imports System.ComponentModel

Public Class frmFMIS_Setup_AddUpdAccountMapping

    Private Sub frmFMIS_Setup_AddUpdAccountMapping_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DropDownListChartOfAccounts(cbInternal)
        DropDownListChartOfAccounts_External(cbExternal)

        If isUpdate Then
            SelUpd_Setup_AccountMapping_ByID()
        End If

    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetComboBoxes(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrWhiteSpace(cbExternal.Text) OrElse String.IsNullOrWhiteSpace(cbInternal.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_AccountMapping()

    End Sub

    Private Sub frmFMIS_Setup_AddUpdAccountMapping_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        ResetComboBoxes(Me)
    End Sub

    Private Sub frmFMIS_Setup_AddUpdAccountMapping_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        MsgBox("If selected account is present on the table, it will update hehe")
    End Sub
End Class