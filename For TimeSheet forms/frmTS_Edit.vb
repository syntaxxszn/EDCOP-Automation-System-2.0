Imports System.Windows.Forms

Public Class frmTS_Edit


    Private Sub frmTS_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate_ComboBox_TimeSheet()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsUpd_TimeSheet()
    End Sub

    Private Sub cmboBoxTimeIn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboBoxTimeIn.SelectedIndexChanged

    End Sub

    Private Sub cmboBoxTimeIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmboBoxTimeIn.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmboBoxTimeOut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboBoxTimeOut.SelectedIndexChanged

    End Sub

    Private Sub cmboBoxTimeOut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmboBoxTimeOut.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmboBoxOTIn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboBoxOTIn.SelectedIndexChanged

    End Sub

    Private Sub cmboBoxOTIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmboBoxOTIn.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmboBoxBreakOut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboBoxBreakOut.SelectedIndexChanged

    End Sub

    Private Sub cmboBoxBreakOut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmboBoxBreakOut.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmboBoxBreakIn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboBoxBreakIn.SelectedIndexChanged

    End Sub

    Private Sub cmboBoxBreakIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmboBoxBreakIn.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmboBoxOTOut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboBoxOTOut.SelectedIndexChanged

    End Sub

    Private Sub cmboBoxOTOut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmboBoxOTOut.KeyPress
        e.Handled = True
    End Sub
End Class
