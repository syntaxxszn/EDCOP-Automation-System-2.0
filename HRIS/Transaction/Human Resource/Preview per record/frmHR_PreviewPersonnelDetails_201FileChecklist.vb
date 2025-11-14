Public Class frmHR_PreviewPersonnelDetails_201FileChecklist
    Private Sub frmHR_PreviewPersonnelDetails_201FileChecklist_Load(sender As Object, e As EventArgs) Handles Me.Load
        Sel_HRIS_Personnel_201FileChecklist_ByID(dgv201CheckList)
        isEdit = False
    End Sub

    Private Sub dgv201CheckList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv201CheckList.CellDoubleClick
        Dim selectedRow = dgv201CheckList.SelectedRows(0)
        Dim file As String = selectedRow.Cells(6).Value
        Dim ext = IO.Path.GetExtension(file).ToLower()

        If IO.File.Exists(file) Then
            If ext = ".pdf" Then
                frmHR_PreviewPersonnelDetails_201FileChecklistPreviewFile.wbFile.Navigate(file)
                frmHR_PreviewPersonnelDetails_201FileChecklistPreviewFile.ShowDialog()
            Else
                If MessageBox.Show("Word Document (.doc) will be opened in the Word, proceed?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
                Try : Process.Start(file)
                Catch ex As Exception
                    MessageBox.Show("Unable to open file: " & ex.Message, "Error")
                End Try
            End If
        Else
            MessageBox.Show("File not found.", "Notice")
        End If
    End Sub

    Private Sub dgv201CheckList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv201CheckList.CellFormatting
        ' Column index 3 (fourth column)
        If dgv201CheckList.Columns(e.ColumnIndex).Name = "Column4" AndAlso e.Value IsNot Nothing Then
            Dim cellValue As String = e.Value.ToString().Trim().ToLower()

            If cellValue = "yes" Then
                e.CellStyle.BackColor = Color.DarkGreen
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.Font = New Font(dgv201CheckList.Font, FontStyle.Bold)
            ElseIf cellValue = "pending" Then
                e.CellStyle.BackColor = Color.Gold
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.Font = New Font(dgv201CheckList.Font, FontStyle.Bold)
            Else
                e.CellStyle.BackColor = Color.White
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.Font = dgv201CheckList.Font
            End If
        End If
    End Sub

End Class