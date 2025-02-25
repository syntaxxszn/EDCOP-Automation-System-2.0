Imports System.Windows.Forms

Public Class frmHR_AddNewDepartment


    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Sub ClearField()
        txtCode.Clear()
        txtDeptName.Clear()
        checkboxOperationDept.CheckState = CheckState.Unchecked
        cbInCharge.SelectedIndex = -1
        checkboxIsInactive.CheckState = CheckState.Unchecked
        txtHotline.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Ins_Department()
    End Sub

    Private Sub checkboxOperationDept_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxOperationDept.CheckedChanged

    End Sub

    Private Sub checkboxOperationDept_CheckStateChanged(sender As Object, e As EventArgs) Handles checkboxOperationDept.CheckStateChanged

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

    Private Sub cbInCharge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbInCharge.SelectedIndexChanged

    End Sub

    Private Sub cbInCharge_DropDown(sender As Object, e As EventArgs) Handles cbInCharge.DropDown
        SelPopulate_EmployeeName(cbInCharge)
    End Sub
End Class
