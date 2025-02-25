Imports System.Windows.Forms

Public Class frmAccounting_SummaryOfRP_Preview



    Private Sub frmAccounting_SummaryOfRP_Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvSummaryOfRFP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSummaryOfRFP.CellContentClick

    End Sub

    Private Sub dgvSummaryOfRFP_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSummaryOfRFP.SelectionChanged
        dgvSummaryOfRFP.ClearSelection()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub txtboxJV_TextChanged(sender As Object, e As EventArgs) Handles txtboxJV.TextChanged
        TestingLang()
    End Sub

    Private Sub txtboxJV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxJV.KeyPress

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsertUpdate_FMS_SummaryOfRP_ByJV()
    End Sub

End Class
