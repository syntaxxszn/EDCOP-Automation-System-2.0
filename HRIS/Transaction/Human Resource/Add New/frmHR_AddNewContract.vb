Imports System.ComponentModel

Public Class frmHR_AddNewContract

    Private Sub frmHR_AddNewContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DropDownLists()
    End Sub

    Private Sub DropDownLists()
        Call DropDownListEmploymentType(cbEmploymentType)
        Call DropDownListDepartment(cbDepartment)
        Call DropDownListJobPosition(cbJobPosition)
        Call DropDownListJobClass(cbJobClassLevel)
        Call DropDownListSupervisorEmployeeName(cbSuperior)
        Call DropDownListLocation(cbLocation)
        Call DropDownListSignatoryEmployeeName(cbSignatory1)
        Call DropDownListSignatoryEmployeeName(cbSignatory2)
    End Sub

    Private Sub isContractEndCheck()
        dtpContractEnd.Enabled = chContractEnd.Checked
        dtpContractEnd.Value = If(chContractEnd.Checked, dtpContractEnd.Value, New Date(1990, 1, 1))
    End Sub

    Private Sub chContractEnd_CheckedChanged(sender As Object, e As EventArgs) Handles chContractEnd.CheckedChanged
        Call isContractEndCheck()
    End Sub

    Private Sub txtMonthlyRate_Validating(sender As Object, e As CancelEventArgs) Handles txtMonthlyRate.Validating
        Textbox_NumericFormat(txtMonthlyRate, e.Cancel)
    End Sub

    Private Sub txtProjectDiff_Validating(sender As Object, e As CancelEventArgs) Handles txtProjectDiff.Validating
        Textbox_NumericFormat(txtProjectDiff, e.Cancel)
    End Sub

    Private Sub txtFieldAllowance_Validating(sender As Object, e As CancelEventArgs) Handles txtFieldAllowance.Validating
        Textbox_NumericFormat(txtFieldAllowance, e.Cancel)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(cbDepartment.Text) OrElse
             String.IsNullOrWhiteSpace(cbJobClassLevel.Text) OrElse
             String.IsNullOrWhiteSpace(cbJobPosition.Text) OrElse
             String.IsNullOrWhiteSpace(cbEmploymentType.Text) Then
            MessageBox.Show("Please fill up all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Ins_Personnel_ContractHistory()
    End Sub

    Private Sub frmHR_AddNewContract_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
        UncheckCheckBoxes(Me)
        ClearDataGridViewRows(Me)
        ResetDatePickers(Me)
        txtContractNo.Text = "EC-00-00-212-0000"
        txtProjectDiff.Text = "0.00"
        txtMonthlyRate.Text = "0.00"
        txtFieldAllowance.Text = "0.00"

    End Sub

    Private Sub btnAddNewOmnibusProject_Click(sender As Object, e As EventArgs) Handles btnAddNewOmnibusProject.Click
        frmHR_AddNewOmnibusProject.ShowDialog()
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub
End Class