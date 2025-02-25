Public Class frmAccounting_RequestForPayment


    Private Sub frmAccounting_RequestForPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnAddNewRF_Click(sender As Object, e As EventArgs) Handles btnAddNewRF.Click
        frmAccounting_RequestForPayment_AddNew.ShowDialog()
    End Sub
End Class