Public Class frmHR_UpdatePersonnelDetails_201FileChecklist

    Private Sub frmHR_UpdatePersonnelDetails_201FileChecklist_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_HRIS_Personnel_201FileChecklist_ByID(dgv201CheckList)
    End Sub

    Private Sub dgv201CheckList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv201CheckList.CellClick
        If dgv201CheckList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgv201CheckList.SelectedRows(0)
            _201FileID = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub btnAddNewFile_Click(sender As Object, e As EventArgs) Handles btnAddNewFile.Click
        If dgv201CheckList.SelectedRows.Count > 0 Then
            Browse201Files(dgv201CheckList)
        Else
            MessageBox.Show("Please select from the list to add file on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemoveFile_Click(sender As Object, e As EventArgs) Handles btnRemoveFile.Click
        If dgv201CheckList.SelectedRows.Count > 0 Then

            Dim selectedRow = dgv201CheckList.SelectedRows(0)
            Dim fileid = selectedRow.Cells(1).Value
            Dim filePath = IO.Path.GetFullPath(selectedRow.Cells(6).Value.ToString())

            If selectedRow.Cells(5).Value = "" Then
                'MessageBox.Show("No file exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If MessageBox.Show("Are you sure you want to delete this file?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
            If IO.File.Exists(filePath) Then
                Try
                    IO.File.Delete(filePath)
                    'selectedRow.Cells(3).Value = "No"
                    'selectedRow.Cells(4).Value = ""
                    'selectedRow.Cells(5).Value = ""
                    Del_Personnel_201FileChecklist_ByID(fileid)
                    MessageBox.Show("File deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error deleting file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                If MessageBox.Show("File not found. Would you like to remove it from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
                Try
                    Del_Personnel_201FileChecklist_ByID(fileid)
                    MessageBox.Show("File deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error deleting file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            Call Sel_HRIS_Personnel_201FileChecklist_ByID(dgv201CheckList)
        End If
    End Sub

    Private Sub SetToCompleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetToCompleteToolStripMenuItem.Click
        'If dgv201CheckList.SelectedRows.Count > 0 Then
        '    With dgv201CheckList.SelectedRows(0).Cells(3)
        '        If .Value?.ToString().Trim().ToLower() <> "no" Then
        '            .Value = "No"
        '            .Style.BackColor = Color.White
        '            .Style.ForeColor = Color.Black
        '            .Style.Font = dgv201CheckList.Font
        '            btnRemoveFile.PerformClick() ' Call to remove the file from the server
        '        End If
        '    End With
        '    dgv201CheckList.ClearSelection()
        'End If
    End Sub

    Private Sub AddRemarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRemarksToolStripMenuItem.Click
        If dgv201CheckList.SelectedRows.Count > 0 Then
            frmHR_UpdatePersonnelDetails_201FileChecklistRemarks.ShowDialog()
        End If
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
        If dgv201CheckList.Columns(e.ColumnIndex).Name = "Column4" AndAlso e.Value IsNot Nothing Then
            Dim cellValue As String = e.Value.ToString().Trim().ToLower()

            If cellValue = "yes" Then
                e.CellStyle.BackColor = Color.DarkGreen
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.Font = New Font(dgv201CheckList.Font, FontStyle.Bold)
            Else
                e.CellStyle.BackColor = Color.White
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.Font = dgv201CheckList.Font
            End If
        End If
    End Sub

    Private Sub dgv201CheckList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv201CheckList.CellContentClick

    End Sub

    Private Sub CompleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompleteToolStripMenuItem.Click

        If dgv201CheckList.SelectedRows.Count > 0 Then
            SetChecklistStatus(dgv201CheckList.SelectedRows(0), "Yes")
            dgv201CheckList.ClearSelection()
        End If

    End Sub

    Private Sub IncompleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncompleteToolStripMenuItem.Click

        If dgv201CheckList.SelectedRows.Count > 0 Then
            SetChecklistStatus(dgv201CheckList.SelectedRows(0), "No")
            dgv201CheckList.ClearSelection()
        End If

    End Sub

    Private Sub SetChecklistStatus(row As DataGridViewRow, status As String)
        Dim cell = row.Cells(3)
        Dim current = cell.Value?.ToString().Trim().ToLower()

        If current = status.ToLower() Then
            Exit Sub
        End If

        Select Case status.ToLower()
            Case "yes"
                cell.Value = "Yes"
                cell.Style.BackColor = Color.White
                cell.Style.ForeColor = Color.DarkGreen
                cell.Style.Font = dgv201CheckList.Font

            Case "no"
                cell.Value = "No"
                cell.Style.BackColor = Color.White
                cell.Style.ForeColor = Color.Black
                cell.Style.Font = dgv201CheckList.Font

                ' Remove the file if status is set to Incomplete
                btnRemoveFile.PerformClick()
        End Select


    End Sub

End Class