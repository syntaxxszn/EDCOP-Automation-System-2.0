Imports System.Windows.Forms

Public Class frmHR_AddForeignAddress

    Private Sub frmHR_AddForeignAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
        frmHR_AddNewPersonnel.cbForeignAddr.CheckState = CheckState.Unchecked
    End Sub
End Class
