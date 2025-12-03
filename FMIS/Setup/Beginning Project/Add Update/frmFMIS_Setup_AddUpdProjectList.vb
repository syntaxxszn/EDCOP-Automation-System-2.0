Public Class frmFMIS_Setup_AddUpdProjectList

    Private Sub frmFMIS_Setup_AddUpdProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DropDownListProjectList(cbProject)
    End Sub

    Private Sub cbProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProject.SelectedIndexChanged
        Call Sel_ProjectDetail_By_ProjectName()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetComboBoxes(Me)
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub frmFMIS_Setup_AddUpdProjectList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ResetComboBoxes(Me)
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(cbProject.Text) Then
            MessageBox.Show("Error, please fill up required fields.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_Setup_ProjectList()
    End Sub

End Class