Public Class frmFMIS_Setup_AddUpdSupplierType

    Private Sub frmFMIS_Setup_AddUpdSupplierType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Supplier Type"

        If isUpdate Then
            lblHeader.Text = "Üpdating Supplier Type"
            Call SelUpd_Setup_SupplierType_ByID()
            Exit Sub
        End If

        SupplierTypeID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtType.Text) OrElse String.IsNullOrWhiteSpace(txtDesc.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_SupplierType()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdSupplierType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        ClearTextBoxes(Me)
    End Sub
End Class