Imports System.Windows.Forms

Public Class frmPMS_Administrator_SummaryOfCharge_PerEmployeeProject

    Private Sub frmPMS_Administrator_SummaryOfCharge_PerEmployeeProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If dtpDateFrom.Text > dtpDateTo.Text Then
            MessageBox.Show("Invalid date selected. [ Date from ] must be less than from [ Date to ].", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Print_PerEmployeeChargeToProject()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class
