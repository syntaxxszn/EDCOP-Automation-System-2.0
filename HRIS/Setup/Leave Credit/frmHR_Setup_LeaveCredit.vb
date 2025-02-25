Public Class frmHR_Setup_LeaveCredit


    Private Sub frmHR_Setup_LeaveCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub toolstripBtnNew_Click(sender As Object, e As EventArgs) Handles toolstripBtnNew.Click
        frmHR_AddNewLeaveCredit.ShowDialog()
    End Sub
End Class