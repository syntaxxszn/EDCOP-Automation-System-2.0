Imports System.Windows.Forms

Public Class frmPMS_UserRegistration


    Private Sub frmPMS_UserRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate_ComboBox_EmployeeNo(cmbboxUserAccount)
        txtboxEmployeeName.Enabled = False
        txtboxDepartment.Enabled = False
        txtBoxContracNo.Enabled = False
        txtBoxJobTitle.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Login_UserRegistration_Clear()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cmbboxUserAccount.SelectedIndex = -1 Then
            MessageBox.Show("Please Select User to Register.", "PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If cmbboxUserLevel.SelectedIndex = -1 Then
            MessageBox.Show("Please Select User Level of Access.", "PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            InsertLogin_UserRegistration()
        End If

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub cmbboxUserAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbboxUserAccount.SelectedIndexChanged
        Login_GetUserRegistrationDetailsByUserName()
    End Sub

    Private Sub cmbboxUserAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbboxUserAccount.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Login_GetUserRegistrationDetailsByUserName()
        'End If
    End Sub
End Class
