Public Class frmHR_UpdatePersonnelDetails_201FileChecklistRemarks
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmHR_UpdatePersonnelDetails_201FileChecklist.dgv201CheckList.SelectedRows(0).Cells(4).Value = txtRemarks.Text
        frmHR_UpdatePersonnelDetails_201FileChecklist.dgv201CheckList.SelectedRows(0).Cells(7).Value = 1
        frmHR_UpdatePersonnelDetails_201FileChecklist.dgv201CheckList.ClearSelection()
        Me.Close()
    End Sub

    Private Sub frmHR_UpdatePersonnelDetails_201FileChecklistRemarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmHR_UpdatePersonnelDetails_201FileChecklistRemarks_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtRemarks.Clear()
    End Sub

End Class