Public Class frmHR_Setup_LeaveType

    Private Sub frmHR_Setup_LeaveType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Sel_LeaveType(dgvLeaveType)
    End Sub

    Private Sub toolstripBtnNew_Click(sender As Object, e As EventArgs) Handles toolstripBtnNew.Click
        frmHR_AddNewLeaveType.ShowDialog()
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub
End Class