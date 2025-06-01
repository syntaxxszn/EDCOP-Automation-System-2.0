Imports System.ComponentModel

Public Class frmHRIS_PerformanceManagement_AddUpdatePart2_FormAValues

    Public isUpdate As Boolean = False

    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart2_FormAValues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SelPopulate_ActivePart1Form1List(cbPart1)
        Call SelPopulate_EmployeeName(cbReviewer)

        If isUpdate Then
            isPopulating = True
            'Call SelUpd_PMAS_Part1Form1_ByID()
            isPopulating = False
            Exit Sub
        End If

        _strPerformancePart2FormAID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ClearTextBoxes(Me)
        Call ResetComboBoxes(Me)
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart2_FormAValues_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call ClearTextBoxes(Me)
        Call ResetComboBoxes(Me)
        isUpdate = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.ShowDialog()
    End Sub

    Private Sub cbPart1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPart1.SelectedIndexChanged

    End Sub

    Private Sub cbReviewer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReviewer.SelectedIndexChanged

    End Sub

    Private Sub txtFW1_Validating(sender As Object, e As CancelEventArgs) Handles txtFW1.Validating
        Textbox_NumericFormat(txtFW1, e.Cancel)
    End Sub

    Private Sub txtFW2_Validating(sender As Object, e As CancelEventArgs) Handles txtFW2.Validating
        Textbox_NumericFormat(txtFW2, e.Cancel)
    End Sub

    Private Sub txtFW3_Validating(sender As Object, e As CancelEventArgs) Handles txtFW3.Validating
        Textbox_NumericFormat(txtFW3, e.Cancel)
    End Sub

    Private Sub txtFW4_Validating(sender As Object, e As CancelEventArgs) Handles txtFW4.Validating
        Textbox_NumericFormat(txtFW4, e.Cancel)
    End Sub

    Private Sub txtFW5_Validating(sender As Object, e As CancelEventArgs) Handles txtFW5.Validating
        Textbox_NumericFormat(txtFW5, e.Cancel)
    End Sub

    Private Sub txtFW6_Validating(sender As Object, e As CancelEventArgs) Handles txtFW6.Validating
        Textbox_NumericFormat(txtFW6, e.Cancel)
    End Sub

    Private Sub txtFW7_Validating(sender As Object, e As CancelEventArgs) Handles txtFW7.Validating
        Textbox_NumericFormat(txtFW7, e.Cancel)
    End Sub

    Private Sub txtFW8_Validating(sender As Object, e As CancelEventArgs) Handles txtFW8.Validating
        Textbox_NumericFormat(txtFW8, e.Cancel)
    End Sub

    Private Sub txtFW9_Validating(sender As Object, e As CancelEventArgs) Handles txtFW9.Validating
        Textbox_NumericFormat(txtFW9, e.Cancel)
    End Sub

    Private Sub txtFW10_Validating(sender As Object, e As CancelEventArgs) Handles txtFW10.Validating
        Textbox_NumericFormat(txtFW10, e.Cancel)
    End Sub


End Class