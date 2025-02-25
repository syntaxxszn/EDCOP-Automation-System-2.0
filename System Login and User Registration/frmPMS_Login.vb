Imports System.Windows.Forms

Public Class frmPMS_Login

    Private Sub frmPMS_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label6.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        txtboxConnectedServer.Enabled = False
        txtboxConnectedServer.Text = "192.168.0.249"

        txtboxEmployeeeNo.Text = "2019-1057"
        'If MessageBox.Show("The System is under maintenance. Can't access right now.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
        '    Application.Exit()
        'End If

    End Sub

    Private Sub frmPMS_Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    End Sub

    Private Sub frmPMS_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If MessageBox.Show("Do you want to continue exit?", "E-PCM System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
        '    e.Cancel = True
        'End If
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Login_User()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub txtboxEmployeeeNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxEmployeeeNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtboxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtboxEmployeeeNo_TextChanged(sender As Object, e As EventArgs) Handles txtboxEmployeeeNo.TextChanged

    End Sub
End Class
