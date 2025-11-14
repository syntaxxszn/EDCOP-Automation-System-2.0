Public Class frmPSCR_Main

    Private Sub frmPSCR_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_IHB_PCSR_ProjectList(dgvAllProjects, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_IHB_PCSR_ProjectList(dgvAllProjects, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

End Class