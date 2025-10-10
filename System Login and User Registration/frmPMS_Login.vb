Public Class frmPMS_Login

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

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
        txtEmployeeCode.ForeColor = Color.DarkGray
        txtPassword.ForeColor = Color.DarkGray

        txtEmployeeCode.Text = "2019-1057"
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

End Class