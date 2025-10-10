Public Class frmFMIS_Setup_AddUpdAccountCategory

    Private Sub frmFMIS_Setup_AddUpdAccountCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Account Category"

        If isUpdate Then
            lblHeader.Text = "Üpdating Account Category"
            Call SelUpd_Setup_AccountCategory_ByID()
            Exit Sub
        End If

        Call Sel_Setup_AccountCategory_Main_Code(txtCode)
        _AccountCategoryID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub chDebit_CheckedChanged(sender As Object, e As EventArgs) Handles chDebit.CheckedChanged
        If chDebit.Checked Then
            chCredit.Checked = False
        End If
    End Sub

    Private Sub chCredit_CheckedChanged(sender As Object, e As EventArgs) Handles chCredit.CheckedChanged
        If chCredit.Checked Then
            chDebit.Checked = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextBoxes(Me)
        UncheckCheckBoxes(Me)
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdAccountCategory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        ClearTextBoxes(Me)
        UncheckCheckBoxes(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtCode.Text) OrElse String.IsNullOrWhiteSpace(txtType.Text) OrElse (Not chCredit.Checked AndAlso Not chDebit.Checked) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_AccountCategory()
    End Sub

End Class