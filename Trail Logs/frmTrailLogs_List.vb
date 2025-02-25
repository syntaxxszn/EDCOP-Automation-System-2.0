Imports System.Windows.Forms

Public Class frmTrailLogs_List


    Private Sub frmTrailLogs_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvActivityLog_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivityLog.CellContentClick

    End Sub

    Private Sub dgvActivityLog_SelectionChanged(sender As Object, e As EventArgs) Handles dgvActivityLog.SelectionChanged
        dgvActivityLog.ClearSelection()
    End Sub
End Class
