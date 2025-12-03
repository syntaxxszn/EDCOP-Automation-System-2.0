Public Class frmFMIS_Setup_AddUpdItemCategory

    Private Sub frmFMIS_Setup_AddUpdItemCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Item Category"

        If isUpdate Then
            lblHeader.Text = "Üpdating Item Category"
            Call SelUpd_Setup_ItemCategoryType_ByID()
            Exit Sub
        End If

        ItemCategoryID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtType.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_ItemCategoryType()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdItemCategory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        ClearTextBoxes(Me)
    End Sub

End Class