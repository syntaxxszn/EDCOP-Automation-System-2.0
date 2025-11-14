Imports System.Net
Imports System.Net.Mail

Public Class frmHR_PreviewPersonnelDetails_OneTimePasscode
    Private Sub frmHR_PreviewPersonnelDetails_OneTimePasscode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectLogin_OneTimePasscode(lblPinCode)
    End Sub

    Private Sub btnRegenerate_Click(sender As Object, e As EventArgs) Handles btnRegenerate.Click

        Dim pin As String = GenerateSecurePin()
        InsertLogin_OneTimePasscode(pin)
        lblPinCode.Text = pin

        'If frmHR_PreviewPersonnelDetails_PersonalInformation.txtEmailAddress.Text.Trim() <> "" Then
        '    Try
        '        ' Get the email address from the textbox
        '        Dim recipientEmail As String = frmHR_PreviewPersonnelDetails_PersonalInformation.txtEmailAddress.Text.Trim()

        '        ' Validate email format 
        '        If Not recipientEmail.Contains("@") Then
        '            MessageBox.Show("Invalid email address.")
        '            Exit Sub
        '        End If

        '        ' Create the mail message
        '        Dim mail As New MailMessage()
        '        mail.From = New MailAddress("jrmdlpn1031@gmail.com")
        '        mail.To.Add(recipientEmail) ' <-- pass textbox value here
        '        mail.Subject = "Engineering and Development Corporation of the Philippines"
        '        mail.Body = "Your One-Time Password for On-Boarding is: " & pin & vbCrLf & vbCrLf &
        '                    "Please use this OTP within 24-Hours. Do not share it with anyone."

        '        ' Configure the SMTP client for Gmail
        '        Dim smtp As New SmtpClient("smtp.gmail.com")
        '        smtp.Port = 587
        '        smtp.EnableSsl = True
        '        smtp.Credentials = New NetworkCredential("jrmdlpn1031@gmail.com", "jiel ryem rzzr vwaf")

        '        ' Send the message
        '        smtp.Send(mail)

        '        MessageBox.Show("Email sent successfully.")
        '    Catch ex As Exception
        '        MessageBox.Show("Send failure: " & ex.Message)
        '    End Try
        'Else
        '    MessageBox.Show("No Email Address found.")
        'End If

        If frmHR_PreviewPersonnelDetails_PersonalInformation.txtEmailAddress.Text.Trim() <> "" Then
            Try

                ' Show loading cursor
                Cursor.Current = Cursors.WaitCursor
                Application.DoEvents() ' Forces UI to update immediately

                Dim recipientEmail As String = frmHR_PreviewPersonnelDetails_PersonalInformation.txtEmailAddress.Text.Trim()

                ' Create the mail message
                Dim mail As New MailMessage()
                mail.From = New MailAddress("jrmdlpn1031@gmail.com", "EDCOP Automation System 2.0")
                mail.To.Add(recipientEmail)
                mail.Subject = "On-Boarding One-Time Password"

                ' Enable HTML body
                mail.IsBodyHtml = True

                ' === Build HTML body ===
                Dim htmlBody As String = $"
        <html>
        <body style='font-family:Arial, sans-serif; color:#333333; font-size:14px;'>
            <p>Dear Employee,</p>

            <p>Employee Code: 
                <b style='color:#000080; font-size:14px;'>{frmHR_PreviewPersonnelDetails.lblEmployeeNo.Text}</b>
            </p>

            <p>Your One-Time Password (OTP) for On-Boarding is: 
                <b style='color:#000080; font-size:14px;'>{pin}</b>
            </p>

            <p>Please use this OTP within <b>24-Hours</b>. Do not share it with anyone.</p>

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

                '' === Attach a PDF file ===
                'Dim pdfPath As String = "\\192.168.0.250\references\DIMS_APPS_INST\Resume\default.pdf" ' Change this path

                'If IO.File.Exists(pdfPath) Then
                '    mail.Attachments.Add(New Attachment(pdfPath))
                'Else
                '    MessageBox.Show("Attachment file not found: " & pdfPath)
                '    Exit Sub
                'End If

                mail.AlternateViews.Add(altView)

                ' Configure SMTP client
                Dim smtp As New SmtpClient("smtp.gmail.com")
                smtp.Port = 587
                smtp.EnableSsl = True
                smtp.Credentials = New NetworkCredential("jrmdlpn1031@gmail.com", "jiel ryem rzzr vwaf")

                ' Send
                smtp.Send(mail)

            Catch ex As Exception
                MessageBox.Show("Send failure: " & ex.Message)
            Finally
                ' Always reset cursor
                Cursor.Current = Cursors.Default
            End Try

        End If

    End Sub

    Private Sub frmHR_PreviewPersonnelDetails_OneTimePasscode_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        lblPinCode.Text = ""
    End Sub

End Class