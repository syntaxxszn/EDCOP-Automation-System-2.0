Public Class frmAccounting_ReportTab


    Private Sub frmAccounting_ReportTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Text = "Trial Balance" Then
            frmAccounting_DialogTrialBalance.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Dispose()
    End Sub
End Class