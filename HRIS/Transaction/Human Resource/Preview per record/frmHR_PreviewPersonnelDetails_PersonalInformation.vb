Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class frmHR_PreviewPersonnelDetails_PersonalInformation

    Dim tooltip As New ToolTip()

    Private Sub frmHR_PreviewPersonnelDetails_PersonalInformation_Load(sender As Object, e As EventArgs) Handles Me.Load
        Function_ReadOnly_isTrue()
        Call Sel_Personnel_PersonalInformation_ByEmployeeID()
        Call SelUpd_FamilyBackground(dgvParentsAndSiblings, dgvSpouseAndChildren)
        Call Family_Background_Relationship_DropDownList(cbRelationshipPS, cbSRelationhipSC)
        frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
        TabControl1.SelectedTab = TabPageMain

        isEdit = False

        If txtAdrCountry1.Text = "" Then
            txtAdrCountry1.Text = "Philippines"
        End If

    End Sub

    Public Sub Function_ReadOnly_isTrue()
        SetControlsReadOnly(Me)
    End Sub

    Public Sub function_ReadOnly_isFalse()
        SetControlsEditable(Me)
        cbPresentAdr_CheckedChanged(cbPresentAdr, EventArgs.Empty)
        cbForeignAddr_CheckedChanged(cbForeignAddr, EventArgs.Empty)
    End Sub

    Private Sub txtMobileNoPS_TextChanged(sender As Object, e As EventArgs) Handles txtMobileNoPS.TextChanged

    End Sub

    Private Sub txtMobileNoSC_TextChanged(sender As Object, e As EventArgs) Handles txtMobileNoSC.TextChanged

    End Sub

    Private Sub btnNextTab1_Click(sender As Object, e As EventArgs) Handles btnNextTab1.Click
        TabControl1.SelectedTab = TabPagePIN
    End Sub

    Private Sub btnNextTab2_Click(sender As Object, e As EventArgs) Handles btnNextTab2.Click
        TabControl1.SelectedTab = TabPageFamBackground
    End Sub

    Private Sub btnBackTab3_Click(sender As Object, e As EventArgs) Handles btnBackTab3.Click
        TabControl1.SelectedTab = TabPagePIN
    End Sub

    Private Sub btnBackTab2_Click(sender As Object, e As EventArgs) Handles btnBackTab2.Click
        TabControl1.SelectedTab = TabPageMain
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

    Private Sub dtpBirthDatePS_Validating(sender As Object, e As CancelEventArgs) Handles dtpBirthDatePS.Validating
        Dim birthDate = dtpBirthDatePS.Value
        If birthDate < DateTime.Today Then
            Dim age = DateTime.Today.Year - birthDate.Year - If(birthDate > DateTime.Today.AddYears(-(DateTime.Today.Year - birthDate.Year)), 1, 0)
            txtAgePS.Text = age
        End If
    End Sub

    Private Sub dtpBirthDateSC_Validating(sender As Object, e As CancelEventArgs) Handles dtpBirthDateSC.Validating
        Dim birthDate = dtpBirthDateSC.Value
        If birthDate < DateTime.Today Then
            Dim age = DateTime.Today.Year - birthDate.Year - If(birthDate > DateTime.Today.AddYears(-(DateTime.Today.Year - birthDate.Year)), 1, 0)
            txtAgeSC.Text = age
        End If
    End Sub

    Private Sub btnClearPS_Click(sender As Object, e As EventArgs) Handles btnRemovePS.Click
        ClearTransactionFieldPS()
    End Sub

    Private Sub dgvParentsAndSiblings_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParentsAndSiblings.CellDoubleClick
        If Not cbRelationshipPS.Enabled Then
            Return 'if editable is not true
        End If

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

    Private Sub dgvSpouseAndChildren_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSpouseAndChildren.CellDoubleClick
        If Not cbSRelationhipSC.Enabled Then
            Return 'if editable is not true
        End If

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

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvSpouseAndChildren IsNot excludeDataGridView Then
            dgvSpouseAndChildren.ClearSelection()
        End If

        If dgvParentsAndSiblings IsNot excludeDataGridView Then
            dgvParentsAndSiblings.ClearSelection()
        End If
    End Sub

    Private Sub dgvParentsAndSiblings_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParentsAndSiblings.CellClick
        UnselectDataGridView(dgvParentsAndSiblings)
    End Sub

    Private Sub dgvSpouseAndChildren_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSpouseAndChildren.CellClick
        UnselectDataGridView(dgvSpouseAndChildren)
    End Sub

    Private Sub cbGender_DropDown(sender As Object, e As EventArgs) Handles cbGender.DropDown
        Call DropDownListGender(cbGender)
    End Sub

    Private Sub cbCitizenship_DropDown(sender As Object, e As EventArgs) Handles cbCitizenship.DropDown
        Call DropDownListCitizenship(cbCitizenship)
    End Sub

    Private Sub cbReligion_DropDown(sender As Object, e As EventArgs) Handles cbReligion.DropDown
        Call DropDownListReligion(cbReligion)
    End Sub

    Private Sub cbCivilStatus_DropDown(sender As Object, e As EventArgs) Handles cbCivilStatus.DropDown
        Call DropDownListCivilStatus(cbCivilStatus)
    End Sub

    Private Sub cbAdrRegion1_DropDown(sender As Object, e As EventArgs) Handles cbAdrRegion1.DropDown
        Call DropDownListRegion(cbAdrRegion1, cbAdrProvince1)
    End Sub

    Private Sub cbAdrProvince1_DropDown(sender As Object, e As EventArgs) Handles cbAdrProvince1.DropDown
        Call DropDownListProvince(cbAdrRegion1, cbAdrProvince1, cbAdrCity1)
    End Sub

    Private Sub cbAdrCity1_DropDown(sender As Object, e As EventArgs) Handles cbAdrCity1.DropDown
        Call DropDownListMunicipality(cbAdrProvince1, cbAdrCity1)
    End Sub

    Private Sub dtpDateofBirth_Validating(sender As Object, e As CancelEventArgs) Handles dtpDateofBirth.Validating
        Dim birthDate = dtpDateofBirth.Value
        If birthDate < DateTime.Today Then
            Dim age = DateTime.Today.Year - birthDate.Year - If(birthDate > DateTime.Today.AddYears(-(DateTime.Today.Year - birthDate.Year)), 1, 0)
            txtAge.Text = age
        End If
    End Sub

    Private Sub cbPresentAdr_CheckedChanged(sender As Object, e As EventArgs) Handles cbPresentAdr.CheckedChanged
        If cbPresentAdr.Checked Then cbForeignAddr.Checked = False ' Uncheck cbForeignAddr
        _strSameAsAddressValidation = If(cbPresentAdr.Checked, 1, 0)
        SetPermanentAdrControls(Not cbPresentAdr.Checked)
    End Sub

    Private Sub cbForeignAddr_CheckedChanged(sender As Object, e As EventArgs) Handles cbForeignAddr.CheckedChanged
        If cbForeignAddr.Checked Then cbPresentAdr.Checked = False
        LinkLabelViewForeignAddress.Visible = cbForeignAddr.Checked
        SetPermanentAdrControls(Not cbForeignAddr.Checked)
    End Sub

    Public Sub SetPermanentAdrControls(isEnabled As Boolean) ' Disable controls if checked
        For Each ctrl As Control In gbPermanentAdr.Controls
            ctrl.Enabled = isEnabled
            If Not isEnabled Then ' Only clear if disabled
                If TypeOf ctrl Is TextBox Then DirectCast(ctrl, TextBox).Clear()
                If TypeOf ctrl Is ComboBox Then DirectCast(ctrl, ComboBox).ResetText()
            End If
        Next
    End Sub

    Private Sub cbBank_DropDown(sender As Object, e As EventArgs) Handles cbBank.DropDown
        Call DropDownListBank(cbBank)
    End Sub

    Private Sub cbAdrRegion2_DropDown(sender As Object, e As EventArgs) Handles cbAdrRegion2.DropDown
        Call DropDownListRegion(cbAdrRegion2, cbAdrProvince2)
    End Sub

    Private Sub cbAdrProvince2_DropDown(sender As Object, e As EventArgs) Handles cbAdrProvince2.DropDown
        Call DropDownListProvince(cbAdrRegion2, cbAdrProvince2, cbAdrCity2)
    End Sub

    Private Sub cbAdrCity2_DropDown(sender As Object, e As EventArgs) Handles cbAdrCity2.DropDown
        Call DropDownListMunicipality(cbAdrProvince2, cbAdrCity2)
    End Sub

    Private Sub btnRemoveSC_Click(sender As Object, e As EventArgs) Handles btnRemoveSC.Click
        ClearTransactionFieldSC()
    End Sub

    Private Sub LinkLabelViewForeignAddress_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelViewForeignAddress.LinkClicked
        frmHR_AddUpdForeignAddress.ShowDialog()
    End Sub

    Private Sub txtTelephone_MouseHover(sender As Object, e As EventArgs) Handles txtTelephone.MouseHover
        tooltip.SetToolTip(txtTelephone, "Format: 02XXXXXXXX (can be 8 or 10 digits only)")
    End Sub

    Private Sub txtMobileNumber_MouseHover(sender As Object, e As EventArgs) Handles txtMobileNumber.MouseHover
        tooltip.SetToolTip(txtMobileNumber, "Format: 09XXXXXXXXX (11 digits only)")
    End Sub

    Private Sub txtMobileNumber_Validating(sender As Object, e As CancelEventArgs) Handles txtMobileNumber.Validating
        Call MobileNumber_Color(txtMobileNumber, e.Cancel)
    End Sub

    Private Sub txtTelephone_Validating(sender As Object, e As CancelEventArgs) Handles txtTelephone.Validating
        Call TelephoneNumber_Color(txtTelephone, e.Cancel)
    End Sub

    Private Sub txtAdrZip1_Validating(sender As Object, e As CancelEventArgs) Handles txtAdrZip1.Validating
        Call ZipCode_Color(txtAdrZip1, e.Cancel)
    End Sub

    Private Sub txtAdrZip2_Validating(sender As Object, e As CancelEventArgs) Handles txtAdrZip2.Validating
        Call ZipCode_Color(txtAdrZip2, e.Cancel)
    End Sub

    Private Sub cbBirthPlaceRegion_DropDown(sender As Object, e As EventArgs) Handles cbBirthPlaceRegion.DropDown
        DropDownListRegion(cbBirthPlaceRegion, cbBirthPlaceProvince)
    End Sub

    Private Sub cbBirthPlaceProvince_DropDown(sender As Object, e As EventArgs) Handles cbBirthPlaceProvince.DropDown
        DropDownListProvince(cbBirthPlaceRegion, cbBirthPlaceProvince, cbBirthPlaceCity)
    End Sub

    Private Sub cbBirthPlaceCity_DropDown(sender As Object, e As EventArgs) Handles cbBirthPlaceCity.DropDown
        DropDownListMunicipality(cbBirthPlaceProvince, cbBirthPlaceCity)
    End Sub

    Private Sub cbAdrBarangay1_DropDown(sender As Object, e As EventArgs) Handles cbAdrBarangay1.DropDown
        DropDownListBarangay(cbAdrCity1, cbAdrBarangay1)
    End Sub

    Private Sub cbAdrBarangay2_DropDown(sender As Object, e As EventArgs) Handles cbAdrBarangay2.DropDown
        DropDownListBarangay(cbAdrCity2, cbAdrBarangay2)
    End Sub

    Private Sub cbBirthPlaceRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBirthPlaceRegion.SelectedIndexChanged
        cbBirthPlaceProvince.SelectedIndex = -1
        cbBirthPlaceCity.SelectedIndex = -1
    End Sub

    Private Sub cbBirthPlaceProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBirthPlaceProvince.SelectedIndexChanged
        cbBirthPlaceCity.SelectedIndex = -1
    End Sub

    Private Sub cbAdrRegion1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrRegion1.SelectedIndexChanged
        cbAdrProvince1.SelectedIndex = -1
        cbAdrCity1.SelectedIndex = -1
        cbAdrBarangay1.SelectedIndex = -1
    End Sub

    Private Sub cbAdrProvince1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrProvince1.SelectedIndexChanged
        cbAdrCity1.SelectedIndex = -1
        cbAdrBarangay1.SelectedIndex = -1
    End Sub

    Private Sub cbAdrCity1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrCity1.SelectedIndexChanged
        cbAdrBarangay1.SelectedIndex = -1
    End Sub

    Private Sub cbAdrRegion2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrRegion2.SelectedIndexChanged
        cbAdrProvince2.SelectedIndex = -1
        cbAdrCity2.SelectedIndex = -1
        cbAdrBarangay2.SelectedIndex = -1
    End Sub

    Private Sub cbAdrProvince2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrProvince2.SelectedIndexChanged
        cbAdrCity2.SelectedIndex = -1
        cbAdrBarangay2.SelectedIndex = -1
    End Sub

    Private Sub cbAdrCity2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrCity2.SelectedIndexChanged
        cbAdrBarangay1.SelectedIndex = -1
    End Sub

    Private Sub cbPayrollCategory_DropDown(sender As Object, e As EventArgs) Handles cbPayrollCategory.DropDown
        DropDownListPayrollCategory(cbPayrollCategory)
    End Sub

    Private Sub txtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHeight.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or (e.KeyChar = "."c AndAlso Not txtHeight.Text.Contains("."))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeight.KeyPress
        If Not (Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or (e.KeyChar = "."c AndAlso Not txtWeight.Text.Contains("."))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAdrZip1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdrZip1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAdrZip2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdrZip2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMobileNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobileNumber.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelephone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelephone.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxSSSNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxSSSNo.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxTIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxTIN.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxPhilHealth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxPhilHealth.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxHDMF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxHDMF.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxPayrollAccountNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxPayrollAccountNo.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxSSSNo_TextChanged(sender As Object, e As EventArgs) Handles txtboxSSSNo.TextChanged
        Dim digits = New String(txtboxSSSNo.Text.Where(AddressOf Char.IsDigit).ToArray())
        If digits.Length > 10 Then
            MessageBox.Show("SSS must be in the format: 01-1234567-1.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            digits = digits.Substring(0, 10)
        End If

        Dim formatted = digits
        If digits.Length > 2 Then
            formatted = digits.Substring(0, 2) & "-" & digits.Substring(2)
            If digits.Length > 9 Then
                formatted = formatted.Insert(10, "-")
            End If
        End If

        If txtboxSSSNo.Text <> formatted Then
            txtboxSSSNo.Text = formatted
            txtboxSSSNo.SelectionStart = formatted.Length
        End If
    End Sub

    Private Sub txtboxSSSNo_Validating(sender As Object, e As CancelEventArgs) Handles txtboxSSSNo.Validating
        If String.IsNullOrWhiteSpace(txtboxSSSNo.Text) Then Exit Sub
        If Not Regex.IsMatch(txtboxSSSNo.Text, "^\d{2}-\d{7}-\d{1}$") Then
            MessageBox.Show("SSS must be in the format: 01-1234567-1.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtboxTIN_TextChanged(sender As Object, e As EventArgs) Handles txtboxTIN.TextChanged
        Dim digits = New String(txtboxTIN.Text.Where(AddressOf Char.IsDigit).ToArray())

        If digits.Length > 9 Then
            MessageBox.Show("TIN must be in the format: 123-123-123", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            digits = digits.Substring(0, 9)
        End If

        Dim formatted As String = digits
        If digits.Length > 3 Then formatted = digits.Substring(0, 3) & "-" & digits.Substring(3)
        If digits.Length > 6 Then formatted = formatted.Insert(7, "-")

        If txtboxTIN.Text <> formatted Then
            txtboxTIN.Text = formatted
            txtboxTIN.SelectionStart = formatted.Length
        End If
    End Sub

    Private Sub txtboxTIN_Validating(sender As Object, e As CancelEventArgs) Handles txtboxTIN.Validating
        If String.IsNullOrWhiteSpace(txtboxSSSNo.Text) Then Exit Sub
        If Not Regex.IsMatch(txtboxTIN.Text, "^\d{3}-\d{3}-\d{3}$") Then
            MessageBox.Show("TIN must be in the format: 123-123-123", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtboxPhilHealth_TextChanged(sender As Object, e As EventArgs) Handles txtboxPhilHealth.TextChanged
        Dim digits = New String(txtboxPhilHealth.Text.Where(AddressOf Char.IsDigit).ToArray())

        If digits.Length > 12 Then
            MessageBox.Show("PhilHealth must be in the format: 01-123456789-1", "Invalid Format")
            digits = digits.Substring(0, 12)
        End If

        Dim formatted As String = digits
        If digits.Length > 2 Then formatted = digits.Substring(0, 2) & "-" & digits.Substring(2)
        If digits.Length > 11 Then formatted = formatted.Insert(12, "-")

        If txtboxPhilHealth.Text <> formatted Then
            txtboxPhilHealth.Text = formatted
            txtboxPhilHealth.SelectionStart = formatted.Length
        End If
    End Sub

    Private Sub txtboxPhilHealth_Validating(sender As Object, e As CancelEventArgs) Handles txtboxPhilHealth.Validating
        If String.IsNullOrWhiteSpace(txtboxSSSNo.Text) Then Exit Sub
        If Not Regex.IsMatch(txtboxPhilHealth.Text, "^\d{2}-\d{9}-\d{1}$") Then
            MessageBox.Show("PhilHealth must be in the format: 01-123456789-1", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtboxHDMF_TextChanged(sender As Object, e As EventArgs) Handles txtboxHDMF.TextChanged
        Dim digits = New String(txtboxHDMF.Text.Where(AddressOf Char.IsDigit).ToArray())

        If digits.Length > 12 Then
            MessageBox.Show("PAG-IBIG must be in the format: 1234-1234-1234", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            digits = digits.Substring(0, 12)
        End If

        Dim formatted As String = digits
        If digits.Length > 4 Then formatted = digits.Substring(0, 4) & "-" & digits.Substring(4)
        If digits.Length > 8 Then formatted = formatted.Insert(9, "-")

        If txtboxHDMF.Text <> formatted Then
            txtboxHDMF.Text = formatted
            txtboxHDMF.SelectionStart = formatted.Length
        End If
    End Sub

    Private Sub txtboxHDMF_Validating(sender As Object, e As CancelEventArgs) Handles txtboxHDMF.Validating
        If String.IsNullOrWhiteSpace(txtboxSSSNo.Text) Then Exit Sub
        If Not Regex.IsMatch(txtboxHDMF.Text, "^\d{4}-\d{4}-\d{4}$") Then
            MessageBox.Show("PAG-IBIG must be in the format: 1234-1234-1234", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    Private Sub btnNextTab3_Click(sender As Object, e As EventArgs) Handles btnNextTab3.Click
        TabControl1.SelectedTab = TabPageEmergencyContact
    End Sub

    Private Sub btnBackTab4_Click(sender As Object, e As EventArgs) Handles btnBackTab4.Click
        TabControl1.SelectedTab = TabPageFamBackground
    End Sub

    Private Sub cbMedicalCategory_DropDown(sender As Object, e As EventArgs) Handles cbMedicalCategory.DropDown
        DropDownListMedicalCategory(cbMedicalCategory)
    End Sub

    Private Sub cbMedicalCondition_DropDown(sender As Object, e As EventArgs) Handles cbMedicalCondition.DropDown
        DropDownListMedicalCondition(cbMedicalCondition, cbMedicalCategory)
    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged
        dgvParentsAndSiblings.ClearSelection()
        dgvSpouseAndChildren.ClearSelection()
    End Sub

    Private Sub ContextMenuStripPS_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStripPS.Opening
        If Not isEdit Then e.Cancel = True ' <- This stops the context menu from showing
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If dgvParentsAndSiblings.Rows.Count > 0 Then
            Dim lastRow As DataGridViewRow = dgvParentsAndSiblings.Rows(dgvParentsAndSiblings.Rows.Count - 1)
            If lastRow.Tag?.ToString() = "New" Then
                dgvParentsAndSiblings.Rows.Remove(lastRow)
            ElseIf dgvParentsAndSiblings.SelectedRows.Count > 0 Then
                Del_Personnel_ParentsAndSiblings_ByID(dgvParentsAndSiblings)
            End If
            ClearTransactionFieldPS()
        End If
    End Sub

    Private Sub ContextMenuStripSC_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStripSC.Opening
        If Not isEdit Then e.Cancel = True
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        If dgvSpouseAndChildren.Rows.Count > 0 Then
            Dim lastRow As DataGridViewRow = dgvSpouseAndChildren.Rows(dgvSpouseAndChildren.Rows.Count - 1)
            If lastRow.Tag?.ToString() = "New" Then
                dgvSpouseAndChildren.Rows.Remove(lastRow)
            ElseIf dgvSpouseAndChildren.SelectedRows.Count > 0 Then
                Del_Personnel_SpouseAndChildren_ByID(dgvSpouseAndChildren)
            Else
                MsgBox("Nothing to remove.")
            End If
            ClearTransactionFieldPS()
        End If
    End Sub

    Private Sub txtMobileNoPS_Validating(sender As Object, e As CancelEventArgs) Handles txtMobileNoPS.Validating
        MobileNumber_Color(txtMobileNoPS)
    End Sub

    Private Sub txtMobileNoSC_Validating(sender As Object, e As CancelEventArgs) Handles txtMobileNoSC.Validating
        MobileNumber_Color(txtMobileNoSC)
    End Sub


End Class
