Public Class frmAccounting_CashJournalMain

    Public CurrentForm As Form = Nothing
    Public lastclickBtn As Integer = 0
    Dim dtc As Boolean = False
    Dim selectedRow As DataGridViewRow

    Private Sub frmAccounting_CashJournalMain_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Public Sub switchPanel(form As Form)
        PanelHolder.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        PanelHolder.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub
End Class