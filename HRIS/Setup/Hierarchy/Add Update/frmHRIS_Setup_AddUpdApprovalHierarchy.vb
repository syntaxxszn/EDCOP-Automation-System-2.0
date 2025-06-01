Public Class frmHRIS_Setup_AddUpdApprovalHierarchy

    Public isUpdate As Boolean = False

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ClearTextBoxes(Me)
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call InsUpd_ApprovalHierarchy()
    End Sub

    Private Sub frmHR_Setup_AddUpdApprovalHierarchy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Hierarchy"

        If isUpdate Then
            lblHeader.Text = "Üpdating Hierarchy Details"
            Call SelUpd_Hierarchy_By_ID()
            Exit Sub
        End If

        _strHierarchyID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub frmHR_Setup_AddUpdApprovalHierarchy_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        Call ClearTextBoxes(Me)
    End Sub
End Class