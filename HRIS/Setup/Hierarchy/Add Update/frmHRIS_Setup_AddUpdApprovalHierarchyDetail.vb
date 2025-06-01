Public Class frmHRIS_Setup_AddUpdApprovalHierarchyDetail

    Public isUpdate As Boolean = False

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ResetComboBoxes(Me)
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Private Sub frmHR_Setup_AddUpdApprovalHierarchyDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SelPopulate_EmployeeName(cbName)
        lblHeader.Text = "Add New Hierarchy Detail / Reviewer "

        If isUpdate Then
            lblHeader.Text = "Üpdating Hierarchy / Reviewer Details"
            Call SelUpd_HierarchyDetail_By_ID()
            Exit Sub
        End If

        _strHierarchyDetailID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call InsUpd_ApprovalHierarchyDetail()
    End Sub

    Private Sub frmHR_Setup_AddUpdApprovalHierarchyDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        ResetComboBoxes(Me)
    End Sub
End Class