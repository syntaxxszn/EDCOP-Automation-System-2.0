Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Text.RegularExpressions


Public Class frmHR_AddNewPersonnel

    Public isExist As Boolean = False

    Private Sub frmHR_AddNewPersonnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(_strPersonnelID)
        FilePath = "\\192.168.0.250\references\DIMS_APPS_INST\Images Profile\default_image.png"
        Call GetImageProfile(PictureBoxAddProfile)
        _strEmployeeID = 0 'this is to reset and tell the stored proc that its new employee and needs to be inserted

        Call Family_Background_Relationship_DropDownList(cbRelationshipPS, cbSRelationhipSC)

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

        Dim basePath As String = "\\192.168.0.250\references\DIMS_APPS_INST\Images Profile\"
        Using ofd As New OpenFileDialog With {.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim destPath As String = basePath & IO.Path.GetFileName(ofd.FileName)
                ' Check if file exists
                If IO.File.Exists(destPath) Then
                    MessageBox.Show("Image already exists in the destination!", "Duplicate Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                Else
                    IO.File.Copy(ofd.FileName, destPath) ' Copy if not exists
                End If
                FilePath = destPath
                PictureBoxAddProfile.Image = Image.FromFile(destPath)
                PictureBoxAddProfile.SizeMode = PictureBoxSizeMode.StretchImage

                'Try : Call Ins_Personnel_ProfilePic()
                'Catch ex As Exception
                '    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End Try

            End If
        End Using
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
        If cbPresentAdr.Checked Then cbForeignAddr.Checked = False ' Uncheck cbForeignAddr
        _strSameAsAddressValidation = If(cbPresentAdr.Checked, 1, 0)
        SetPermanentAdrControls(Not cbPresentAdr.Checked)
    End Sub

    Private Sub SetPermanentAdrControls(isEnabled As Boolean) ' Disable controls if checked
        For Each ctrl As Control In gbPermanentAdr.Controls
            ctrl.Enabled = isEnabled
            If Not isEnabled Then ' Only clear if disabled
                If TypeOf ctrl Is TextBox Then DirectCast(ctrl, TextBox).Clear()
                If TypeOf ctrl Is ComboBox Then DirectCast(ctrl, ComboBox).ResetText()
            End If
        Next
    End Sub

    Private Sub cbForeignAddr_CheckedChanged(sender As Object, e As EventArgs) Handles cbForeignAddr.CheckedChanged
        If cbForeignAddr.Checked Then
            cbPresentAdr.Checked = False
            isEdit = True
            frmHR_AddUpdForeignAddress.ShowDialog()
        End If
        SetPermanentAdrControls(Not cbForeignAddr.Checked)
    End Sub

    Private Sub cbAdrRegion2_DropDown(sender As Object, e As EventArgs) Handles cbAdrRegion2.DropDown
        DropDownListRegion(cbAdrRegion2, cbAdrProvince2)
    End Sub

    Private Sub cbAdrProvince2_DropDown(sender As Object, e As EventArgs) Handles cbAdrProvince2.DropDown
        DropDownListProvince(cbAdrRegion2, cbAdrProvince2, cbAdrCity2)
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

        If isExist Then
            MessageBox.Show("This Employee Code exists in the database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtCode.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(cbPronouns.Text) Then
            MessageBox.Show("Some fields are required, please check and try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try

            If PictureBoxAddProfile.Image Is Nothing Then
                MessageBox.Show("No Image has been Load")
            Else
                Call Ins_PersonnelDetails()
                Call Ins_Personnel_ProfilePic()
                Call InsUpd_ForeignAddress()
                Call Ins_Personnel_Identification()
                Call ProcessDataGridViewParentsAndSiblings(dgvParentsAndSiblings)
                Call ProcessDataGridViewSpouseAndChildren(dgvSpouseAndChildren)
                Call Ins_Personnel_AddressDetails()
                'InsUpd_Personnel_Identification() Not updated as stored procedure is edited to accept insert and update
                'Ins_PersonnelTempRecord() removed by [2024-1435] and integrated it in the stored proc
                'Sel_PersonnelID()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cbRelationshipPS_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbRelationshipPS_DropDown(sender As Object, e As EventArgs)
        DropDownListDependentsParentSiblings(cbRelationshipPS)
    End Sub

    Private Sub cbSRelationhipSC_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbSRelationhipSC_DropDown(sender As Object, e As EventArgs)
        DropDownListDependentsSpouse(cbSRelationhipSC)
    End Sub

    Private Sub btnAddPS_Click(sender As Object, e As EventArgs) Handles btnAddPS.Click
        If String.IsNullOrWhiteSpace(txtFullNamePS.Text) OrElse
           String.IsNullOrWhiteSpace(txtAgePS.Text) OrElse
           String.IsNullOrWhiteSpace(dtpBirthDatePS.Text) OrElse
           String.IsNullOrWhiteSpace(cbRelationshipPS.Text) Then
            MessageBox.Show("Something is wrong, please check and try again. ", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim exists As Boolean = dgvParentsAndSiblings.Rows.Cast(Of DataGridViewRow)().
          Any(Function(row) CInt(row.Cells(0).Value) = _PersonnelPSID1)
        If exists Then
            If MessageBox.Show("Are you sure you want to update this record?", "Warning Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim selectedRow = dgvParentsAndSiblings.SelectedRows(0)
                _PersonnelPSID1 = Convert.ToInt32(selectedRow.Cells(0).Value)
                selectedRow.Cells(1).Value = cbRelationshipPS.SelectedItem
                selectedRow.Cells(2).Value = txtFullNamePS.Text
                selectedRow.Cells(3).Value = dtpBirthDatePS.Value
                selectedRow.Cells(4).Value = txtAgePS.Text
                selectedRow.Cells(5).Value = txtMobileNoPS.Text
            End If
        Else
            Dim newRowIndex As Integer = dgvParentsAndSiblings.Rows.Add(_PersonnelPSID2, cbRelationshipPS.Text, txtFullNamePS.Text, dtpBirthDatePS.Value, txtAgePS.Text, txtMobileNoPS.Text)
            dgvParentsAndSiblings.Rows(newRowIndex).Tag = "New"
            _PersonnelPSID2 += 1
        End If
        ClearTransactionFieldPS()
    End Sub

    Private Sub ClearTransactionFieldPS()
        dgvParentsAndSiblings.ClearSelection()
        _PersonnelPSID1 = _PersonnelPSID2
        txtFullNamePS.Clear()
        txtAgePS.Clear()
        txtMobileNoPS.Clear()
        dtpBirthDatePS.Value = New DateTime(1990, 1, 1)
        cbRelationshipPS.SelectedIndex = -1
    End Sub



    Private Sub btnClearPS_Click(sender As Object, e As EventArgs) Handles btnClearPS.Click
        If dgvParentsAndSiblings.Rows.Count > 0 Then
            dgvParentsAndSiblings.Rows.RemoveAt(dgvParentsAndSiblings.Rows.Count - 1)
        End If
    End Sub

    Private Sub btnAddSC_Click(sender As Object, e As EventArgs) Handles btnAddSC.Click
        If String.IsNullOrWhiteSpace(txtFullNameSC.Text) OrElse
            String.IsNullOrWhiteSpace(txtAgeSC.Text) OrElse
             String.IsNullOrWhiteSpace(dtpBirthDateSC.Text) OrElse
                String.IsNullOrWhiteSpace(cbSRelationhipSC.Text) Then
            MessageBox.Show("Error! Please fill up all fields required.")
            Return
        End If

        Dim exists As Boolean = dgvSpouseAndChildren.Rows.Cast(Of DataGridViewRow)().
          Any(Function(row) CInt(row.Cells(0).Value) = _PersonnelSCID1)
        If exists Then
            If MessageBox.Show("Are you sure you want to update this record?", "Warning Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim selectedRow = dgvSpouseAndChildren.SelectedRows(0)
                _PersonnelSCID1 = Convert.ToInt32(selectedRow.Cells(0).Value)
                selectedRow.Cells(1).Value = cbSRelationhipSC.SelectedItem
                selectedRow.Cells(2).Value = txtFullNameSC.Text
                selectedRow.Cells(3).Value = dtpBirthDateSC.Value
                selectedRow.Cells(4).Value = txtAgeSC.Text
                selectedRow.Cells(5).Value = txtMobileNoSC.Text
            End If
        Else
            Dim newRowIndex As Integer = dgvSpouseAndChildren.Rows.Add(_PersonnelSCID2, cbSRelationhipSC.Text, txtFullNameSC.Text, dtpBirthDateSC.Value, txtAgeSC.Text, txtMobileNoSC.Text)
            dgvSpouseAndChildren.Rows(newRowIndex).Tag = "New"
            _PersonnelSCID2 += 1
        End If
        ClearTransactionFieldSC()
    End Sub

    Private Sub ClearTransactionFieldSC()
        dgvSpouseAndChildren.ClearSelection()
        _PersonnelSCID1 = _PersonnelSCID2
        txtFullNameSC.Clear()
        txtAgeSC.Clear()
        txtMobileNoSC.Clear()
        dtpBirthDateSC.Value = New DateTime(1990, 1, 1)
        cbSRelationhipSC.SelectedIndex = -1
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

    Private Sub frmHR_AddNewPersonnel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub dgvParentsAndSiblings_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParentsAndSiblings.CellDoubleClick
        If dgvParentsAndSiblings.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvParentsAndSiblings.SelectedRows(0)
            _PersonnelPSID1 = selectedRow.Cells(0).Value
            Dim valIndex As Integer = cbRelationshipPS.FindStringExact(selectedRow.Cells(1).Value.ToString())
            If valIndex <> -1 Then cbRelationshipPS.SelectedIndex = valIndex
            txtFullNamePS.Text = selectedRow.Cells(2).Value
            dtpBirthDatePS.Value = selectedRow.Cells(3).Value
            txtAgePS.Text = selectedRow.Cells(4).Value
            txtMobileNoPS.Text = selectedRow.Cells(5).Value
        End If
    End Sub

    Private Sub dgvSpouseAndChildren_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSpouseAndChildren.CellDoubleClick
        If dgvSpouseAndChildren.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvSpouseAndChildren.SelectedRows(0)
            _PersonnelSCID1 = selectedRow.Cells(0).Value
            Dim valIndex As Integer = cbSRelationhipSC.FindStringExact(selectedRow.Cells(1).Value.ToString())
            If valIndex <> -1 Then cbSRelationhipSC.SelectedIndex = valIndex
            txtFullNameSC.Text = selectedRow.Cells(2).Value
            dtpBirthDateSC.Value = selectedRow.Cells(3).Value
            txtAgeSC.Text = selectedRow.Cells(4).Value
            txtMobileNoSC.Text = selectedRow.Cells(5).Value
        End If
    End Sub

    Private Sub txtMobileNoPS_TextChanged(sender As Object, e As EventArgs) Handles txtMobileNoPS.TextChanged
        MobileNumber_Color(txtMobileNoPS)
    End Sub

    Private Sub txtMobileNoSC_TextChanged(sender As Object, e As EventArgs) Handles txtMobileNoSC.TextChanged
        MobileNumber_Color(txtMobileNoSC)
    End Sub

    Private Sub txtCode_Validating(sender As Object, e As CancelEventArgs) Handles txtCode.Validating

        If Not Regex.IsMatch(txtCode.Text, "^\d{4}-\d{4}$") Then
            ' If the format is invalid, cancel the event and show an error message
            MessageBox.Show("Invalid format. Please enter the code in the format YYYY-XXXX (e.g., 2024-1435).", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If

        Sel_PersonnelCode_ifNonExistence(txtCode)
        If isExist Then
            MessageBox.Show("This Employee Code exists in the database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
            Return
        End If

    End Sub

End Class
