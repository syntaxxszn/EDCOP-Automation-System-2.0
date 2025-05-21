Public Class frmHR_Setup_AddUpdDepartment

    Public isUpdate As Boolean = False

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Public Sub ClearField()
        txtCode.Clear()
        txtDeptName.Clear()
        checkboxOperationDept.CheckState = CheckState.Unchecked
        cbInCharge.SelectedIndex = -1
        checkboxIsInactive.CheckState = CheckState.Unchecked
        txtHotline.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call InsUpd_Department()
    End Sub

    Private Sub checkboxOperationDept_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxOperationDept.CheckedChanged

        If checkboxOperationDept.CheckState = CheckState.Checked Then
            isOperationDept = 1
        Else
            isOperationDept = 0
        End If

    End Sub

    Private Sub checkboxIsInactive_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxIsInactive.CheckedChanged

        If checkboxOperationDept.CheckState = CheckState.Checked Then
            isInactive = 1
        Else
            isInactive = 0
        End If

    End Sub

    Private Sub frmHR_AddNewDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Department"
        Call SelPopulate_EmployeeName(cbInCharge)

        If isUpdate Then
            lblHeader.Text = "Üpdating Department Details"
            Call SelUpd_Department_By_ID()
            Exit Sub
        End If

        _strDepartmentID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub frmHR_AddNewDepartment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ClearField()
    End Sub

    Private Sub frmHR_AddUpdDepartment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
        UncheckCheckBoxes(Me)
    End Sub
End Class
