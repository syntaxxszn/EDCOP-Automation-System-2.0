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
        'Dim smtp As New SmtpClient("smtp-mail.outlook.com")
        'smtp.Port = 587
        'smtp.Credentials = New Net.NetworkCredential("jerome.delapena1031@outlook.com", "lzpdeswmwgqsdfhp")
        'smtp.EnableSsl = True

        'Dim mail As New MailMessage()
        'mail.From = New MailAddress("jerome.delapena1031@outlook.com")
        'mail.To.Add("jerome.delapena1031@gmail.com")
        'mail.Subject = "Test Email"
        'mail.Body = "This is a test email from VB.NET."

        'smtp.Send(mail)
        'MessageBox.Show("Email Sent Successfully!")
    End Sub
End Class