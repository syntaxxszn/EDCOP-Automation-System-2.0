Imports System.Windows.Forms

Public Class frmHR_AddUpdForeignAddress

    Private Sub frmHR_AddForeignAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = isEdit
        btnDiscard.Enabled = isEdit
        txtForeignAddress.Enabled = isEdit

        If Not isEdit Then
            lblTitle.Text = "Viewing Employee Foreign Address"
        Else
            lblTitle.Text = "Add Foreign Address"
        End If

    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        isEdit = False
        Me.Dispose()
        'frmHR_AddNewPersonnel.cbForeignAddr.CheckState = CheckState.Unchecked
        'frmHR_PreviewPersonnelDetails_PersonalInformation.cbForeignAddr.CheckState = CheckState.Unchecked
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtForeignAddress.Text = "" Then
            frmHR_PreviewPersonnelDetails_PersonalInformation.cbForeignAddr.Checked = False
        End If
        Me.Close()
    End Sub

End Class
