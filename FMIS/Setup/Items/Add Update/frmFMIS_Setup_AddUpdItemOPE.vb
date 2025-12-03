Public Class frmFMIS_Setup_AddUpdItemOPE

    Private Sub frmFMIS_Setup_AddUpdItemOPE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Item Out-Of-Pocket"
        txtType.Text = frmFMIS_Setup_Items.lblHeader.Text

        If isUpdate Then
            lblHeader.Text = "Üpdating Item Out-Of-Pocket"
            Call SelUpd_Setup_ItemOPE_ByID()
            Exit Sub
        End If

        ItemOPEID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextBoxes(Me)
        UncheckCheckBoxes(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtType.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_ItemOPE()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdItemOPE_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        UncheckCheckBoxes(Me)
        isUpdate = False
    End Sub

End Class