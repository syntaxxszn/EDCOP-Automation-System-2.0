Public Class frmHR_UpdatePersonnelDetails_201FileChecklistRemarks
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmHR_UpdatePersonnelDetails_201FileChecklist.dgv201CheckList.SelectedRows(0).Cells(4).Value = txtRemarks.Text
        frmHR_UpdatePersonnelDetails_201FileChecklist.dgv201CheckList.ClearSelection()
        Me.Dispose()
    End Sub

    Private Sub frmHR_UpdatePersonnelDetails_201FileChecklistRemarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class