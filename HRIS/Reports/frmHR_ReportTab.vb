Public Class frmHR_ReportTab

    Private Sub frmHR_ReportTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub

    Private Sub ToolStripBtnClose_Click_1(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Dispose()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        Dim CurrentNode As TreeNode = e.Node
        Dim fullpath As String = CurrentNode.FullPath
        Label2.Text = fullpath

    End Sub

    Private Sub TreeView1_DoubleClick(sender As Object, e As EventArgs) Handles TreeView1.DoubleClick

        If TreeView1.SelectedNode.Text = "Executive" Then
            frmHR_ReportTab_Dialog.ShowDialog()
        End If

    End Sub


End Class