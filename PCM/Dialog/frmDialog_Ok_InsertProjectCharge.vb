Imports System.Windows.Forms

Public Class frmDialog_Ok_InsertProjectCharge


    Private Sub frmDialog_Ok_InsertProjectCharge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        'ProjectCharge_Clear()
        'Me.Close()
        'Me.Dispose()

        DialogResult_Yes_InsertProjectCharge()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        'PayrollPeriod_Details(frmPMS_Individual.dgvPayrollPeriodDetails)
        'ProjectCharge_Clear()
        'Me.Close()

        'FrmPMS_Individual_AddNew_Activity.Close()
    End Sub



End Class
