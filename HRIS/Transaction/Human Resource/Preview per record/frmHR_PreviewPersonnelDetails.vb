Imports System.Windows.Forms

Public Class frmHR_PreviewPersonnelDetails

    Private PreviousPanelForm As Form = Nothing

    Private Sub frmHR_PreviewPersonnelDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Focus()
        switchPanel(frmHR_PreviewPersonnelDetails_PersonalInformation)
        'TabControl1.SelectedTab = TabPageMain

        ''\\ Hide Update buttons, Only visible when 'Edit profile' Click.
        Function_btnUpdates_Hide()

        ''\\ List of textboxes that set to Read only.
        frmHR_PreviewPersonnelDetails_PersonalInformation.Function_ReadOnly_isTrue()
    End Sub

    Private Sub frmHR_PreviewPersonnelDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Public Sub Function_btnUpdates_Hide()
        btnSave.Visible = False
        btnDiscard.Visible = False
    End Sub

    Private Sub switchPanel(ByVal panel As Form)
        If PreviousPanelForm IsNot Nothing Then
            PreviousPanelForm.Close()
        End If
        PanelHolder.Controls.Clear()
        panel.TopLevel = False
        PanelTagID = panel.Tag
        PanelHolder.Controls.Add(panel)
        PreviousPanelForm = panel
        Function_btnUpdates_Hide()
        panel.Show()
    End Sub

    'Public Sub Function_ReadOnly_isTrue()

    '    dtpDateofBirth.Enabled = False
    '    txtAge.ReadOnly = True
    '    txtPlaceofBirth.ReadOnly = True
    '    cbGender.Enabled = False
    '    txtHeight.ReadOnly = True
    '    txtWeight.ReadOnly = True
    '    cbCitizenship.Enabled = False
    '    cbCivilStatus.Enabled = False
    '    cbReligion.Enabled = True
    '    txtTelephone.ReadOnly = True
    '    txtEmailAddress.ReadOnly = True

    '    txtAdrStreet1.ReadOnly = True
    '    txtAdrBrgy1.ReadOnly = True
    '    cbAdrRegion1.Enabled = False
    '    cbAdrProvince1.Enabled = False
    '    cbAdrCity1.Enabled = False
    '    txtAdrZip1.ReadOnly = True

    '    cbPresentAdr.Enabled = False

    '    txtAdrStreet2.ReadOnly = True
    '    txtAdrBrgy2.ReadOnly = True
    '    cbAdrRegion2.Enabled = False
    '    cbAdrProvince2.Enabled = False
    '    cbAdrCity2.Enabled = False
    '    txtAdrZip2.ReadOnly = True

    'End Sub

    'Public Sub function_ReadOnly_isFalse()

    '    dtpDateofBirth.Enabled = True
    '    txtAge.ReadOnly = False
    '    txtPlaceofBirth.ReadOnly = False
    '    cbGender.Enabled = True
    '    txtHeight.ReadOnly = False
    '    txtWeight.ReadOnly = False
    '    cbCitizenship.Enabled = True
    '    cbCivilStatus.Enabled = True
    '    cbReligion.Enabled = True
    '    txtTelephone.ReadOnly = False
    '    txtMobileNumber.ReadOnly = False
    '    txtEmailAddress.ReadOnly = False

    '    txtAdrStreet1.ReadOnly = False
    '    txtAdrBrgy1.ReadOnly = False
    '    cbAdrRegion1.Enabled = True
    '    cbAdrProvince1.Enabled = True
    '    cbAdrCity1.Enabled = True
    '    txtAdrZip1.ReadOnly = False

    '    cbPresentAdr.Enabled = True

    '    txtAdrStreet2.ReadOnly = False
    '    txtAdrBrgy2.ReadOnly = False
    '    cbAdrRegion2.Enabled = True
    '    cbAdrProvince2.Enabled = True
    '    cbAdrCity2.Enabled = True
    '    txtAdrZip2.ReadOnly = False

    'End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If PanelTagID = 101 Then
            '\\  Button Edit
            InsUpd_PersonnelDetails()
        ElseIf PanelTagID = 102 Then
        ElseIf PanelTagID = 103 Then
        ElseIf PanelTagID = 104 Then
            MsgBox("Hellox")
        ElseIf PanelTagID = 105 Then
        ElseIf PanelTagID = 106 Then
        ElseIf PanelTagID = 107 Then
        Else
            MessageBox.Show("Unexpected Error Occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        '\\  Button Edit
        Call FunctionBtnEdit_Enable()
    End Sub

    Private Sub cbGender_DropDown(sender As Object, e As EventArgs)
        'DropDownListGender(cbGender)
    End Sub

    Private Sub cbCitizenship_SelectedIndexChanged(sender As Object, e As EventArgs)
        '\\ Go to Dropdown for  Function.
    End Sub

    Private Sub cbCitizenship_DropDown(sender As Object, e As EventArgs)
        'DropDownListCitizenship(cbCitizenship)
    End Sub

    Private Sub cbReligion_SelectedIndexChanged(sender As Object, e As EventArgs)
        '\\ Go to Dropdown for Function.
    End Sub

    Private Sub cbReligion_DropDown(sender As Object, e As EventArgs)
        'DropDownListReligion(cbReligion)
    End Sub

    Private Sub cbCivilStatus_SelectedIndexChanged(sender As Object, e As EventArgs)
        '\\ Go to Dropdown for Function.
    End Sub

    Private Sub cbCivilStatus_DropDown(sender As Object, e As EventArgs)
        'DropDownListCivilStatus(cbCivilStatus)
    End Sub

    Private Sub cbAdrRegion1_SelectedIndexChanged(sender As Object, e As EventArgs)
        '\\ Go to Dropdown for Function.
    End Sub

    Private Sub cbAdrRegion1_DropDown(sender As Object, e As EventArgs)
        'DropDownListRegion(cbAdrRegion1, cbAdrProvince1)
    End Sub

    Private Sub cbAdrRegion1_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub cbAdrProvince1_SelectedIndexChanged(sender As Object, e As EventArgs)
        '\\ Go to Dropdown for Function.
    End Sub

    Private Sub cbAdrProvince1_DropDown(sender As Object, e As EventArgs)
        'DropDownListProvince(cbAdrRegion1, cbAdrProvince1, cbAdrCity1)
    End Sub

    Private Sub cbAdrCity1_SelectedIndexChanged(sender As Object, e As EventArgs)
        '\\ Go to Dropdown for Function.
    End Sub

    Private Sub cbAdrCity1_DropDown(sender As Object, e As EventArgs)
        'DropDownListMunicipality(cbAdrProvince1, cbAdrCity1)
    End Sub

    Private Sub btnPersonalInformation_Click(sender As Object, e As EventArgs) Handles btnPersonalInformation.Click
        switchPanel(frmHR_PreviewPersonnelDetails_PersonalInformation)
    End Sub

    Private Sub btnEducBack_Click(sender As Object, e As EventArgs) Handles btnEducBack.Click
        switchPanel(frmHR_PreviewPersonnelDetails_EducationBackground)
    End Sub

    'Private Sub cbPresentAdr_CheckedChanged(sender As Object, e As EventArgs)


    '    If cbPresentAdr.CheckState = CheckState.Checked Then

    '        _strSameAsAddressValidation = 1
    '        txtAdrStreet2.Text = txtAdrStreet1.Text
    '        txtAdrBrgy2.Text = txtAdrBrgy1.Text
    '        cbAdrRegion2.Text = cbAdrRegion1.Text
    '        cbAdrProvince2.Text = cbAdrProvince1.Text
    '        cbAdrCity2.Text = cbAdrCity1.Text
    '        txtAdrZip2.Text = txtAdrZip1.Text
    '        txtAdrCountry2.Text = txtAdrCountry1.Text

    '        '\\ This code is to Set the Permanent Address to ReadOnly = true, and Enabled = True.

    '        txtAdrStreet2.ReadOnly = True
    '        txtAdrBrgy2.ReadOnly = True
    '        cbAdrRegion2.Enabled = False
    '        cbAdrProvince2.Enabled = False
    '        cbAdrCity2.Enabled = False
    '        txtAdrZip2.ReadOnly = True
    '        txtAdrCountry2.ReadOnly = True


    '    Else

    '        _strSameAsAddressValidation = 0
    '        txtAdrStreet2.Clear()
    '        txtAdrBrgy2.Clear()
    '        cbAdrRegion2.SelectedIndex = -1
    '        cbAdrProvince2.SelectedIndex = -1
    '        cbAdrCity2.SelectedIndex = -1
    '        txtAdrZip2.Clear()
    '        txtAdrCountry2.Clear()

    '        '\\ This code is to Set the Permanent Address to ReadOnly = False, and Enabled = True.

    '        txtAdrStreet2.ReadOnly = False
    '        txtAdrBrgy2.ReadOnly = False
    '        cbAdrRegion2.Enabled = True
    '        cbAdrProvince2.Enabled = True
    '        cbAdrCity2.Enabled = True
    '        txtAdrZip2.ReadOnly = False
    '        txtAdrCountry2.ReadOnly = False

    '    End If

    'End Sub

    'Private Sub cbAdrRegion2_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    '\\ Go to Dropdown for Function.
    'End Sub

    'Private Sub cbAdrRegion2_DropDown(sender As Object, e As EventArgs)
    '    DropDownListRegion(cbAdrRegion1, cbAdrProvince1)
    'End Sub

    'Private Sub btnNextTab1_Click(sender As Object, e As EventArgs)
    '    TabControl1.SelectedTab = TabPagePIN
    'End Sub

    'Private Sub btnBackTab2_Click(sender As Object, e As EventArgs)
    '    TabControl1.SelectedTab = TabPageMain
    'End Sub

    'Private Sub btnNextTab2_Click(sender As Object, e As EventArgs)
    '    TabControl1.SelectedTab = TabPageFamBackground
    'End Sub

    'Private Sub btnBackTab3_Click(sender As Object, e As EventArgs)
    '    TabControl1.SelectedTab = TabPagePIN
    'End Sub





End Class
