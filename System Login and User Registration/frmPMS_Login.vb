Public Class frmPMS_Login

    Private Sub txtEmployeeCode_GotFocus(sender As Object, e As EventArgs) Handles txtEmployeeCode.GotFocus
        If txtEmployeeCode.Text = "Employee Code" Then
            txtEmployeeCode.Text = ""
            txtEmployeeCode.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmployeeCode_LostFocus(sender As Object, e As EventArgs) Handles txtEmployeeCode.LostFocus
        If txtEmployeeCode.Text = "" Then
            txtEmployeeCode.Text = "Employee Code"
            txtEmployeeCode.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "•"
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub frmPMS_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadDBSettings()

        txtEmployeeCode.ForeColor = Color.DarkGray
        txtPassword.ForeColor = Color.DarkGray

        txtEmployeeCode.Text = "2024-1435"

        'Procedure: Show the version according to publish number.
        'lblDeploymentVersion.Text = Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
    End Sub

    Private Sub txtEmployeeCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmployeeCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call Login_User()
    End Sub

    Private Sub frmPMS_Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub txtEmployeeCode_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeCode.TextChanged
        If txtEmployeeCode.Text = "Employee Code" Then
            txtEmployeeCode.ForeColor = Color.DarkGray
        Else
            txtEmployeeCode.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text = "Password" Then
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = Color.DarkGray
        Else
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MessageBox.Show("Please call 8-7000 Human Resources Department.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabelForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelForgotPassword.LinkClicked
        frmPMS_ForgotPassword.ShowDialog()
    End Sub

End Class