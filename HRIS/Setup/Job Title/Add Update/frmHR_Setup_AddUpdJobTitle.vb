Imports System.ComponentModel

Public Class frmHR_Setup_AddUpdJobTitle

    Public isUpdate As Boolean = False

    Private Sub frmHR_Setup_AddUpdJobTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DropDownListDepartment(cbDept)
        Call DropDownListJobClassLevel(cbLevel)
        Call DropDownListJobClusterGroup(cbCluster)

        lblHeader.Text = "Add New Job Title / Designation"

        If isUpdate Then
            lblHeader.Text = "Üpdating Job Title / Designation Details"
            Call SelUpd_JobTitle_By_ID()
            Exit Sub
        End If

        _strJobTitleID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub txtSalaryFrom_Validating(sender As Object, e As CancelEventArgs) Handles txtSalaryFrom.Validating
        Call Textbox_NumericFormat(txtSalaryFrom, e.Cancel)
    End Sub

    Private Sub txtSalaryTo_Validating(sender As Object, e As CancelEventArgs) Handles txtSalaryTo.Validating
        Call Textbox_NumericFormat(txtSalaryTo, e.Cancel)
    End Sub

    Private Sub txtSalary_Validating(sender As Object, e As CancelEventArgs) Handles txtSalary.Validating
        Call Textbox_NumericFormat(txtSalary, e.Cancel)
    End Sub

    Private Sub txtIncreasePerYr_Validating(sender As Object, e As CancelEventArgs) Handles txtIncreasePerYr.Validating
        Call Textbox_NumericFormat(txtIncreasePerYr, e.Cancel)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ClearTextBoxes(Me)
        Call ResetComboBoxes(Me)
    End Sub

    Private Sub frmHR_Setup_AddUpdJobTitle_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call ClearTextBoxes(Me)
        Call ResetComboBoxes(Me)
        isUpdate = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsUpd_JobTitle()
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

End Class