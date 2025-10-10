Public Class frmFMIS_Setup_AddUpdCostCenter

    Private Sub frmFMIS_Setup_AddUpdCostCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtCode.Text) OrElse
            String.IsNullOrWhiteSpace(txtName.Text) OrElse
            String.IsNullOrWhiteSpace(txtRemarks.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'InsUpd_CostCenter()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdCostCenter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        isUpdate = False
    End Sub
End Class