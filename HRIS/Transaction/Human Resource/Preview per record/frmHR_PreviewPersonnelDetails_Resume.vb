Public Class frmHR_PreviewPersonnelDetails_Resume
    Private Sub frmHR_PreviewPersonnelDetails_Resume_Load(sender As Object, e As EventArgs) Handles Me.Load
        Sel_HRIS_Personnel_Resume_ByID(dgvResume)
        isEdit = False
        defaultpdf()
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

            If IO.File.Exists(file) Then
                If ext = ".pdf" Then
                    wbResume.Navigate(file)
                Else
                    If MessageBox.Show("Word Document (.doc) will be opened in the Word, proceed?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
                    Try : Process.Start(file)
                    Catch ex As Exception
                        MessageBox.Show("Unable to open file: " & ex.Message, "Error")
                    End Try
                End If
            Else
                MessageBox.Show("File not found.", "Notice")
                defaultpdf()
            End If
        End If
    End Sub

    Private Sub frmHR_PreviewPersonnelDetails_Resume_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        wbResume.DocumentText = ""
    End Sub
End Class