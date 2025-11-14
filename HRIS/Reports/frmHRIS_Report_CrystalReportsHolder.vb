Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
'Imports System.Net.Mail

Public Class frmHRIS_Report_CrystalReportsHolder
    Private Sub frmHRIS_Report_CrystalReportsHolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmHRIS_Report_CrystalReportsHolder_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmHRIS_Report_RequestPurpose.Close()
    End Sub

    Private Sub btnSaveWord_Click(sender As Object, e As EventArgs) Handles btnSaveWord.Click
        Try
            If HRIS_CrystalReports_Holder.ReportSource IsNot Nothing Then
                ' display save file dialog and specify the file formats
                Using saveDialog As New SaveFileDialog()
                    saveDialog.Filter = "Word Document (*.doc)|*.doc"
                    saveDialog.Title = "Save Report As"
                    saveDialog.FileName = "Employee Name"

                    If saveDialog.ShowDialog() = DialogResult.OK Then
                        Dim filePath As String = saveDialog.FileName

                        ' Get the report document from the viewer
                        Dim report As ReportDocument = CType(HRIS_CrystalReports_Holder.ReportSource, ReportDocument)
                        ' Export the report to the selected location
                        report.ExportToDisk(ExportFormatType.WordForWindows, filePath)
                        MessageBox.Show("File saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Else
                MessageBox.Show("No report is currently loaded in the viewer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCOESendEmail_Click(sender As Object, e As EventArgs) Handles btnCOESendEmail.Click
        frmHRIS_Report_SendAsEmail.ShowDialog()
    End Sub
End Class