Public Class frmFMIS_Setup_AddUpdSubsidiaryType

    Private Sub frmFMIS_Setup_AddUpdSubsidiaryType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Subsidiary Type"

        If isUpdate Then
            lblHeader.Text = "Üpdating Subsidiary Type"
            Call SelUpd_Setup_SubsidiaryType_ByID()
            Exit Sub
        End If

        SubsidiaryTypeID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtType.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtType.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_SubsidiaryType()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdSubsidiaryType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtType.Clear()
        isUpdate = False
    End Sub

End Class