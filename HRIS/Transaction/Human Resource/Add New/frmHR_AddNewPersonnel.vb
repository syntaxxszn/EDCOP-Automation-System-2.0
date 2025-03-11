Imports System.Windows.Forms

Public Class frmHR_AddNewPersonnel

    Public isFormSubmitted As Boolean = False

    Private Sub frmHR_AddNewPersonnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(_strPersonnelID)
    End Sub

    Private Sub btnPersonalInformation_Click(sender As Object, e As EventArgs) Handles btnPersonalInformation.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnDependentsAndSiblings_Click(sender As Object, e As EventArgs) Handles btnDependentsAndSiblings.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub cbAdrProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrProvince1.SelectedIndexChanged

    End Sub

    Private Sub cbAdrProvince_DropDown(sender As Object, e As EventArgs) Handles cbAdrProvince1.DropDown
        DropDownListProvince(cbAdrRegion1, cbAdrProvince1, cbAdrCity1)
    End Sub

    Private Sub cbAdrRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrRegion1.SelectedIndexChanged


    End Sub


    Private Sub cbAdrRegion_DropDown(sender As Object, e As EventArgs) Handles cbAdrRegion1.DropDown
        DropDownListRegion(cbAdrRegion1, cbAdrProvince1)
    End Sub

    Private Sub cbAdrCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrCity1.SelectedIndexChanged

    End Sub

    Private Sub cbAdrCity_DropDown(sender As Object, e As EventArgs) Handles cbAdrCity1.DropDown
        DropDownListMunicipality(cbAdrProvince1, cbAdrCity1)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        BrowseProfilePic(PictureBoxAddProfile)
    End Sub


    Private Sub btnNextTab1_Click(sender As Object, e As EventArgs) Handles btnNextTab1.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnNextTab2_Click(sender As Object, e As EventArgs) Handles btnNextTab2.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub btnBackTab3_Click(sender As Object, e As EventArgs) Handles btnBackTab3.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnBackTab2_Click(sender As Object, e As EventArgs) Handles btnBackTab2.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub cbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGender.SelectedIndexChanged

    End Sub

    Private Sub cbGender_DropDown(sender As Object, e As EventArgs) Handles cbGender.DropDown
        DropDownListGender(cbGender)

    End Sub

    Private Sub cbCitizenship_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCitizenship.SelectedIndexChanged

    End Sub

    Private Sub cbCitizenship_DropDown(sender As Object, e As EventArgs) Handles cbCitizenship.DropDown
        DropDownListCitizenship(cbCitizenship)
    End Sub

    Private Sub cbReligion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReligion.SelectedIndexChanged

    End Sub

    Private Sub cbReligion_DropDown(sender As Object, e As EventArgs) Handles cbReligion.DropDown
        DropDownListReligion(cbReligion)
    End Sub

    Private Sub cbCivilStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCivilStatus.SelectedIndexChanged

        'If cbCivilStatus.SelectedItem = "Single" Then
        '    gbSpouseAndChildren.Enabled = False
        'End If

    End Sub

    Private Sub cbCivilStatus_DropDown(sender As Object, e As EventArgs) Handles cbCivilStatus.DropDown
        DropDownListCivilStatus(cbCivilStatus)
    End Sub

    Private Sub cbTaxCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTaxCode.SelectedIndexChanged

    End Sub

    Private Sub cbTaxCode_DropDown(sender As Object, e As EventArgs) Handles cbTaxCode.DropDown
        DropDownListTaxCode()
    End Sub


    Private Sub cbPrefix_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPrefix.SelectedIndexChanged

    End Sub

    Private Sub cbPrefix_DropDown(sender As Object, e As EventArgs) Handles cbPrefix.DropDown
        PrefixDropDownList()
    End Sub

    Private Sub cbSuffix_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSuffix.SelectedIndexChanged

    End Sub

    Private Sub cbSuffix_DropDown(sender As Object, e As EventArgs) Handles cbSuffix.DropDown
        DropDownListSuffix()
    End Sub

    Private Sub cbPresentAdr_CheckedChanged(sender As Object, e As EventArgs) Handles cbPresentAdr.CheckedChanged


        If cbPresentAdr.CheckState = CheckState.Checked Then

            _strSameAsAddressValidation = 1

            'txtAdrStreet2.Text = txtAdrStreet1.Text
            'txtAdrBrgy2.Text = txtAdrBrgy1.Text
            'cbAdrRegion2.Text = cbAdrRegion1.Text
            'cbAdrProvince2.Text = cbAdrProvince1.Text
            'cbAdrCity2.Text = cbAdrCity1.Text
            'txtAdrZip2.Text = txtAdrZip1.Text
            'cbAdrCountry2.Text = cbAdrCountry1.Text
            txtAdrStreet2.Clear()
            txtAdrBrgy2.Clear()
            cbAdrRegion2.SelectedIndex = -1
            cbAdrProvince2.SelectedIndex = -1
            cbAdrCity2.SelectedIndex = -1
            txtAdrZip2.Clear()
            ' cbAdrCountry2.SelectedIndex = -1

            gbPresentAdr.Enabled = False

        Else

            _strSameAsAddressValidation = 0

            txtAdrStreet2.Clear()
            txtAdrBrgy2.Clear()
            cbAdrRegion2.SelectedIndex = -1
            cbAdrProvince2.SelectedIndex = -1
            cbAdrCity2.SelectedIndex = -1
            txtAdrZip2.Clear()
            ' cbAdrCountry2.SelectedIndex = -1

            gbPresentAdr.Enabled = True

        End If
    End Sub




    Private Sub cbAdrRegion2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrRegion2.SelectedIndexChanged

    End Sub

    Private Sub cbAdrRegion2_DropDown(sender As Object, e As EventArgs) Handles cbAdrRegion2.DropDown
        DropDownListRegion(cbAdrRegion2, cbAdrProvince2)
    End Sub

    Private Sub cbAdrProvince2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrProvince2.SelectedIndexChanged

    End Sub

    Private Sub cbAdrProvince2_DropDown(sender As Object, e As EventArgs) Handles cbAdrProvince2.DropDown
        DropDownListProvince(cbAdrRegion2, cbAdrProvince2, cbAdrCity2)
    End Sub

    Private Sub cbAdrCity2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrCity2.SelectedIndexChanged

    End Sub

    Private Sub cbAdrCity2_DropDown(sender As Object, e As EventArgs) Handles cbAdrCity2.DropDown
        DropDownListMunicipality(cbAdrProvince2, cbAdrCity2)
    End Sub

    Sub DateofBirthAge(_strdtpbirthDate As DateTimePicker, _strAge As TextBox)

        '\\ Credit by Jerome Dela Pena [2024-1435] Dated: 7/18/2024  : 
        '\\ Function: If Date is Default Value = '01/01/1990' Then, Value = Nothing ELSE Get Age.

        If _strdtpbirthDate.Value = Date.Today Then
            _strAge.Text = ""
        Else
            Dim age As Integer = DateTime.Today.Year - _strdtpbirthDate.Value.Year
            If _strdtpbirthDate.Value > DateTime.Today.AddYears(-age) Then age -= 1
            _strAge.Text = age.ToString()
        End If

    End Sub

    Private Sub dtpDateofBirth_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateofBirth.ValueChanged
        DateofBirthAge(dtpDateofBirth, txtAge)
    End Sub

    Private Sub dtpBirthDatePS_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthDatePS.ValueChanged
        DateofBirthAge(dtpBirthDatePS, txtAgePS)
    End Sub

    Private Sub dtpDateBirthSC_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthDateSC.ValueChanged
        DateofBirthAge(dtpBirthDateSC, txtAgeSC)
    End Sub

    Private Sub cbBank_DropDown(sender As Object, e As EventArgs) Handles cbBank.DropDown
        DropDownListBank()
    End Sub

    Sub ClearField_PersonnelDetails()
        dtpDateofBirth.ResetText()
        txtAge.Clear()
        txtPlaceofBirth.Clear()
        cbGender.SelectedIndex = -1
        txtHeight.Clear()
        txtWeight.Clear()
        cbCitizenship.SelectedIndex = -1
        cbReligion.SelectedIndex = -1
        cbCivilStatus.SelectedIndex = -1
        txtTelephone.Clear()
        txtMobileNumber.Clear()
        txtEmailAddress.Clear()
        cbTaxCode.SelectedIndex = -1
        txtAdrStreet1.Clear()
        txtAdrBrgy1.Clear()
        cbAdrRegion1.SelectedIndex = -1
        cbAdrProvince1.SelectedIndex = -1
        cbAdrCity1.SelectedIndex = -1
        txtAdrZip1.Clear()
        cbPresentAdr.CheckState = CheckState.Unchecked

        txtAdrStreet2.Clear()
        txtAdrBrgy2.Clear()
        cbAdrRegion2.SelectedIndex = -1
        cbAdrProvince2.SelectedIndex = -1
        cbAdrCity2.SelectedIndex = -1
        txtAdrZip2.Clear()
        'cbAdrCountry2.SelectedIndex = -1

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'If PictureBoxAddProfile.Image Is Nothing AndAlso PictureBoxAddProfile.Tag IsNot Nothing Then
        '    FilePath = PictureBoxAddProfile.Tag.ToString()
        'End If

        If Not PictureBoxAddProfile.Image Is Nothing Then
            MessageBox.Show("No Image has been Load")
        Else
            Ins_Personnel_ProfilePic()
            Ins_PersonnelDetails()
            Ins_Personnel_AddressDetails()
            'InsUpd_Personnel_Identification() Not updated as stored procedure is edited to accept insert and update
            ProcessDataGridViewParentsAndSiblings(dgvParentsAndSiblings)
            ProcessDataGridViewSpouseAndChildren(dgvSpouseAndChildren)
            Ins_PersonnelTempRecord()
            'Sel_PersonnelID()
            isFormSubmitted = True
        End If
    End Sub

    Private Sub cbRelationshipPS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRelationshipPS.SelectedIndexChanged

    End Sub

    Private Sub cbRelationshipPS_DropDown(sender As Object, e As EventArgs) Handles cbRelationshipPS.DropDown
        DropDownListDependentsParentSiblings(cbRelationshipPS)
    End Sub

    Private Sub cbSRelationhipSC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSRelationhipSC.SelectedIndexChanged

    End Sub

    Private Sub cbSRelationhipSC_DropDown(sender As Object, e As EventArgs) Handles cbSRelationhipSC.DropDown
        DropDownListDependentsSpouse(cbSRelationhipSC)
    End Sub

    Private Sub btnAddPS_Click(sender As Object, e As EventArgs) Handles btnAddPS.Click

        Dim row As String() = {
            cbRelationshipPS.Text,
            txtFullNamePS.Text,
            dtpBirthDatePS.Text,
            txtAgePS.Text,
            txtMobileNoPS.Text}
        dgvParentsAndSiblings.Rows.Add(row)

        '\\After inserting to Grid, Text input clear.

        cbRelationshipPS.SelectedIndex = -1
        txtFullNamePS.Clear()
        dtpBirthDatePS.Refresh()
        txtAgePS.Clear()
        txtMobileNoPS.Clear()


    End Sub

    Private Sub btnClearPS_Click(sender As Object, e As EventArgs) Handles btnClearPS.Click
        If dgvParentsAndSiblings.Rows.Count > 0 Then
            dgvParentsAndSiblings.Rows.RemoveAt(dgvParentsAndSiblings.Rows.Count - 1)
        End If
    End Sub

    Private Sub btnAddSC_Click(sender As Object, e As EventArgs) Handles btnAddSC.Click
        ' Dim row As String() = {cbSRelationhipSC.Text, txtNameSC.Text, dtpDateBirthSC.Text, txtAgeSC.Text, txtMobileNoSC.Text}
        '  dgvSpouseAndChildren.Rows.Add(row)

        Dim row As String() = {
          cbSRelationhipSC.Text,
          txtFullNameSC.Text,
          dtpBirthDateSC.Text,
          txtAgeSC.Text,
          txtMobileNoSC.Text}
        dgvSpouseAndChildren.Rows.Add(row)

    End Sub

    Private Sub btnClearSC_Click(sender As Object, e As EventArgs) Handles btnClearSC.Click
        If dgvSpouseAndChildren.Rows.Count > 0 Then
            dgvSpouseAndChildren.Rows.RemoveAt(dgvSpouseAndChildren.Rows.Count - 1)
        End If
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged

    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) AndAlso e.KeyChar <> Convert.ToChar(Keys.Delete) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAgePS_TextChanged(sender As Object, e As EventArgs) Handles txtAgePS.TextChanged

    End Sub

    Private Sub txtAgePS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAgePS.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) AndAlso e.KeyChar <> Convert.ToChar(Keys.Delete) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAgeSC_TextChanged(sender As Object, e As EventArgs) Handles txtAgeSC.TextChanged

    End Sub

    Private Sub txtAgeSC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAgeSC.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) AndAlso e.KeyChar <> Convert.ToChar(Keys.Delete) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtAdrCountry1_TextChanged(sender As Object, e As EventArgs) Handles txtAdrCountry1.TextChanged

    End Sub

    Private Sub txtAdrCountry1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdrCountry1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) AndAlso e.KeyChar <> Convert.ToChar(Keys.Delete) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbForeignAddr_CheckedChanged(sender As Object, e As EventArgs) Handles cbForeignAddr.CheckedChanged
        If cbForeignAddr.CheckState = CheckState.Checked Then
            frmHR_AddUpdForeignAddress.ShowDialog()
        End If
    End Sub

    Private Sub frmHR_AddNewPersonnel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isFormSubmitted = False
    End Sub

    Private Sub frmHR_AddNewPersonnel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not isFormSubmitted Then
            Delete_PersonnelTempRecord()
        End If
    End Sub
End Class
