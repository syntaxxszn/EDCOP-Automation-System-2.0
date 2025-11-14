Imports System.Net
Imports System.Net.Mail
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO


Public Class frmHRIS_Report_SendAsEmail

    Private Sub frmHRIS_Report_SendAsEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmHRIS_Report_SendAsEmail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtEmailAddress.Clear()
        txtSubject.Clear()
        txtBody.Clear()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If txtEmailAddress.Text.Trim() <> "" Then
            Try
                ' Show loading cursor
                Cursor.Current = Cursors.WaitCursor
                Application.DoEvents() ' Forces UI to update immediately

                Dim recipientEmail As String = txtEmailAddress.Text.Trim()

                ' Create the mail message
                Dim mail As New MailMessage()
                mail.From = New MailAddress("jrmdlpn1031@gmail.com", "EDCOP Automation System 2.0")
                mail.To.Add(recipientEmail)
                mail.Subject = txtSubject.Text

                ' Enable HTML body
                mail.IsBodyHtml = True

                ' === Build HTML body ===
                Dim htmlBody As String = $"
                        <html>
                        <body style='font-family:Arial, sans-serif; color:#333333; font-size:14px;'>
                            <p>Dear Employee,</p>

                            <p>{txtBody.Text}</p>

                            <p style='margin:0;'>Thank you and regards,</p>
                            <p style='margin:0;'><b>EDCOP</b></p>

                            <p style='font-size:11px; color:#888; margin-top:15px;'>
                                This is a system-generated email, for concerns please contact Human Resources. Do not reply to this email.
                            </p>

                            <hr style='border:none; border-top:1px solid #cccccc; margin:20px 0;'>

                            <table>
                                <tr>
                                    <td style='padding-right:10px;'>
                                        <img src='cid:logoImage' width='120' alt='EDCOP Logo'>
                                    </td>
                                    <td style='vertical-align:top; font-size:12px; line-height:1.4;'>
                                        <b style='font-size:13px;'>Human Resources Department</b><br>
                                        Data and Information Management System<br>
                                        Engineering and Development Corporation of the Philippines<br>
                                        <a href='mailto:consult@edcop.ph' style='color:#0055A5; text-decoration:none;'>consult@edcop.ph</a><br>
                                        <span style='color:#777;'>Tel: +63 (2) 1234-5678</span>
                                    </td>
                                </tr>
                            </table>

                            <p style='font-size:11px; color:#888; margin-top:15px;'>
                               The information contained in this email message and its attachments is intended solely for the use of the individual or entity to whom it is addressed and other parties authorized to receive it.  Confidential or legally privileged information may be contained in this message.  If you are not the intended recipient of this email and its attachments, you may not use, copy, distribute or deliver to anyone any part of this message or take any action in reliance on it.  If you have received this communication in error, please notify us immediately by responding to this email and then delete it from your system.  Any views or opinions expressed are solely those of the author and do not necessarily represent those of Engineering and Development Corporation of the Philippines (EDCOP).  EDCOP is neither liable for the proper and complete transmission of the information contained in this communication nor for any delay in its receipt. 
                            </p>

                        </body>
                        </html>"

                ' Attach HTML and inline logo
                Dim altView As AlternateView = AlternateView.CreateAlternateViewFromString(htmlBody, Nothing, "text/html")

                ' Attach logo image (local file)
                Dim logoPath As String = "\\192.168.0.250\references\DIMS_APPS_INST\Images Profile\EDCOP_Logo.png" ' <-- change this path
                If IO.File.Exists(logoPath) Then
                    Dim logo As New LinkedResource(logoPath)
                    logo.ContentId = "logoImage"
                    altView.LinkedResources.Add(logo)
                End If

                ' === Export Crystal Report to PDF and attach ===
                Dim rpt As ReportDocument = frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource

                If rpt Is Nothing Then
                    MessageBox.Show("No report loaded.")
                    Exit Sub
                End If

                ' === Export report to PDF in memory ===
                Dim pdfStream As Stream = rpt.ExportToStream(ExportFormatType.PortableDocFormat)
                pdfStream.Seek(0, SeekOrigin.Begin)

                ' === Generate random alphanumeric filename (24 characters) ===
                Dim rnd As New Random()
                Const chars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
                Dim fileName As String = New String(Enumerable.Repeat(chars, 24).Select(Function(s) s(rnd.Next(s.Length))).ToArray()) & ".pdf"

                ' === Attach to email with random filename ===
                Dim attachment As New Attachment(pdfStream, fileName, "application/pdf")
                mail.Attachments.Add(attachment)

                mail.AlternateViews.Add(altView)

                ' Configure SMTP client
                Dim smtp As New SmtpClient("smtp.gmail.com")
                smtp.Port = 587
                smtp.EnableSsl = True
                smtp.Credentials = New NetworkCredential("jrmdlpn1031@gmail.com", "jiel ryem rzzr vwaf")

                ' Send
                smtp.Send(mail)
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Send failure: " & ex.Message)
            Finally
                ' Always reset cursor
                Cursor.Current = Cursors.Default
            End Try

        End If
    End Sub

End Class