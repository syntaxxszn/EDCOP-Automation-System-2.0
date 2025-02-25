Imports System.Windows.Forms

Public Class frmAccounting_AddRF_ReplenishmentAmount


    Private Sub frmAccounting_ReplenishmentAmount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Dispose()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Insert_FMS_ReplenishmentAmount()
    End Sub
End Class
