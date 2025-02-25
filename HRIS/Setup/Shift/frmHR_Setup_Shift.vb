Public Class frmHR_Setup_Shift

    Private Sub frmHR_Setup_Shift_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click

        Sel_ShiftAll(dgvAllShift)

    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click

        Me.Dispose()

    End Sub

    Private Sub toolstripBtnNew_Click(sender As Object, e As EventArgs) Handles toolstripBtnNew.Click

        Ins_ShiftTempRecord()
        Sel_ShiftID()
        frmHR_AddNewShift.ShowDialog()

    End Sub
End Class