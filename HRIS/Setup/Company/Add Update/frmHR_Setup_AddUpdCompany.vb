Public Class frmHR_Setup_AddUpdCompany

    Public isUpdate As Boolean = False

    Private Sub frmHR_AddUpdCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DropDownListIndustryType(cbCompanyIndustry)
        Call DropDownListOrganizationType(cbCompanyOrganization)

        lblHeader.Text = "Add New Company"

        If isUpdate Then
            lblHeader.Text = "Üpdating Company Details"
            Call SelUpd_Company_By_ID()
            Exit Sub
        End If

        _strCompanyID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Public Sub ClearField()
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        ClearField()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsUpd_Company()
    End Sub

    Private Sub frmHR_AddUpdCompany_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClearField()
    End Sub

    Private Sub frmHR_AddUpdCompany_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
    End Sub
End Class