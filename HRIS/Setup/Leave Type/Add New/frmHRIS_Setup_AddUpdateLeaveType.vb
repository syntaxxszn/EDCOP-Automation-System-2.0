Imports System.Windows.Forms

Public Class frmHRIS_Setup_AddUpdateLeaveType

    Public isUpdate As Boolean = False

    Private Sub frmHR_AddNewLeaveType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Leave Type"

        If isUpdate Then
            lblHeader.Text = "Üpdating Leave Type Details"
            Call SelUpd_LeaveType_By_ID()
            Exit Sub
        End If

        _strLeaveTypeID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call InsUpd_LeaveType()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call ClearTextBoxes(Me)
        Call UncheckCheckBoxes(Me)
    End Sub

    Private Sub frmHR_Setup_AddUpdateLeaveType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call ClearTextBoxes(Me)
        Call UncheckCheckBoxes(Me)
        isUpdate = False
    End Sub
End Class
