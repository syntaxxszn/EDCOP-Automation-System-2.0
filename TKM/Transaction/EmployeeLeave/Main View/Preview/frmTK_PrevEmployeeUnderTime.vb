Public Class frmTK_PrevEmployeeUnderTime
    Public _MsgStatusRemarks As String

    Private Sub linkUnderTime_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkUnderTime.LinkClicked
        MsgBox("it's a prank! 👉UwU👈")
    End Sub

    Private Sub btnStatusRemarks_Click(sender As Object, e As EventArgs) Handles btnStatusRemarks.Click
        MsgBox(_MsgStatusRemarks)
    End Sub

    Private Sub frmTK_PrevEmployeeUnderTime_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _MsgStatusRemarks = Nothing
    End Sub

    Private Sub btnPrintDetails_Click(sender As Object, e As EventArgs) Handles btnPrintDetails.Click

    End Sub

End Class