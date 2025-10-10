Public Class frmHRIS_Setup_SelectDateLeaveCredit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnSubmitLeaveCredits_Click(sender As Object, e As EventArgs) Handles btnSubmitLeaveCredits.Click
        If dtpAsOfDate.Value.Date > Date.Today Then
            MessageBox.Show("The selected date cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpAsOfDate.Value = DateTime.Now
            Return
        End If

        If MessageBox.Show("This will override employee leave credits based on worked dates, proceed?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            InsUpd_Employee_Leave_Credits_ByWorkDate()
        End If
    End Sub

    Private Sub frmHRIS_Setup_SelectDateLeaveCredit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        dtpAsOfDate.Value = DateTime.Now
    End Sub

    Private Sub frmHRIS_Setup_SelectDateLeaveCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class