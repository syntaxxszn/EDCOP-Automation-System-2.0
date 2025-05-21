Public Class frmHR_UpdatePersonnelDetails_Resume
    Private Sub btnPersonalInformation_Click(sender As Object, e As EventArgs) Handles btnPersonalInformation.Click
        Call BrowseResume(wbResume)
    End Sub

    Private Sub frmHR_UpdatePersonnelDetails_Resume_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_HRIS_Personnel_Resume_ByID(dgvResume)
        Call defaultpdf()
    End Sub

    Private Sub defaultpdf()
        Dim pdffile As String = "\\192.168.0.250\references\DIMS_APPS_INST\Resume\default.pdf"
        wbResume.Navigate(pdffile)
    End Sub

    Private Sub dgvResume_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResume.CellClick
        If dgvResume.SelectedRows.Count > 0 Then

            Dim selectedRow = dgvResume.SelectedRows(0)
            Dim file As String = selectedRow.Cells(1).Value
            Dim ext = IO.Path.GetExtension(file).ToLower()

            If ext = ".pdf" Then
                wbResume.Navigate(file)
            Else
                defaultpdf()
            End If

        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvResume.SelectedRows.Count > 0 Then

            Dim basePath As String = "\\192.168.0.250\references\DIMS_APPS_INST\Resume\"
            Dim selectedRow = dgvResume.SelectedRows(0)
            Dim fileid = selectedRow.Cells(0).Value
            Dim file As String = selectedRow.Cells(1).Value.ToString()
            Dim filePath = IO.Path.Combine(basePath, file)

            If MessageBox.Show("Are you sure you want to delete this file?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
            If IO.File.Exists(filePath) Then
                Try
                    IO.File.Delete(filePath)
                    dgvResume.Rows.Remove(selectedRow)
                    Del_Personnel_Resume_ByID(fileid)
                    MessageBox.Show("File deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    defaultpdf()
                Catch ex As Exception
                    MessageBox.Show("Error deleting file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                If MessageBox.Show("File not found. Would you like to remove it from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
                Try
                    dgvResume.Rows.Remove(selectedRow)
                    Del_Personnel_Resume_ByID(fileid)
                    MessageBox.Show("File deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    defaultpdf()
                Catch ex As Exception
                    MessageBox.Show("Error deleting file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub frmHR_UpdatePersonnelDetails_Resume_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        wbResume.DocumentText = ""
    End Sub
End Class