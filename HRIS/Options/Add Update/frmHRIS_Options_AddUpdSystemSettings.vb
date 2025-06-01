Public Class frmHRIS_Options_AddUpdSystemSettings

    Public isUpdate As Boolean = False

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Private Sub frmHR_Options_AddUpdSystemSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        isUpdate = False
    End Sub

    Private Sub frmHR_Options_AddUpdSystemSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGroup.Text = "HR"

        lblHeader.Text = "Add New HR System Settings"

        If isUpdate Then
            lblHeader.Text = "Üpdating HR System Settings"
            Call SelUpd_HRIS_SystemSettings_By_ID()
            Exit Sub
        End If

        _strSystemSettingsID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsUpd_HR_SystemSettings()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCode.Clear()
        txtDescription.Clear()
        txtValue.Clear()
    End Sub

End Class