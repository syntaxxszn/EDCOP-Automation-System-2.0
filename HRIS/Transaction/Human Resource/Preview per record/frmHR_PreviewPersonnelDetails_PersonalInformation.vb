Imports System.ComponentModel

Public Class frmHR_PreviewPersonnelDetails_PersonalInformation

    Dim tooltip As New ToolTip()

    Private Sub frmHR_PreviewPersonnelDetails_PersonalInformation_Load(sender As Object, e As EventArgs) Handles Me.Load
        Function_ReadOnly_isTrue()
        Call Sel_Personnel_PersonalInformation_ByEmployeeID()
        Call SelUpd_FamilyBackground(dgvParentsAndSiblings, dgvSpouseAndChildren)
        Call Family_Background_Relationship_DropDownList()
        frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
        TabControl1.SelectedTab = TabPageMain
        isEdit = False
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
        MobileNumber_Color(txtMobileNoPS)
    End Sub

    Private Sub txtMobileNoSC_TextChanged(sender As Object, e As EventArgs) Handles txtMobileNoSC.TextChanged
        MobileNumber_Color(txtMobileNoSC)
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
        If dgvParentsAndSiblings.Rows.Count > 0 Then
            Dim lastRow As DataGridViewRow = dgvParentsAndSiblings.Rows(dgvParentsAndSiblings.Rows.Count - 1)
            If lastRow.Tag?.ToString() = "New" Then
                dgvParentsAndSiblings.Rows.Remove(lastRow)
            ElseIf dgvParentsAndSiblings.SelectedRows.Count > 0 Then
                Del_Personnel_ParentsAndSiblings_ByID(dgvParentsAndSiblings)
            Else
                MsgBox("Nothing to remove.")
            End If
            ClearTransactionFieldPS()
        End If
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

    Private Sub SetPermanentAdrControls(isEnabled As Boolean) ' Disable controls if checked
        For Each ctrl As Control In gbPermanentAdr.Controls
            ctrl.Enabled = isEnabled
            If Not isEnabled Then ' Only clear if disabled
                If TypeOf ctrl Is TextBox Then DirectCast(ctrl, TextBox).Clear()
                If TypeOf ctrl Is ComboBox Then DirectCast(ctrl, ComboBox).ResetText()
            End If
        Next
    End Sub

    Private Sub txtMobileNumber_TextChanged(sender As Object, e As EventArgs) Handles txtMobileNumber.TextChanged
        If Not txtMobileNumber.Enabled Then
            Call MobileNumber_Color(txtMobileNumber)
        End If
    End Sub

    Private Sub cbBank_DropDown(sender As Object, e As EventArgs) Handles cbBank.DropDown
        Call DropDownListBank()
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

    Private Sub LinkLabelViewForeignAddress_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelViewForeignAddress.LinkClicked
        frmHR_AddUpdForeignAddress.ShowDialog()
    End Sub

    Private Sub txtTelephone_MouseHover(sender As Object, e As EventArgs) Handles txtTelephone.MouseHover
        tooltip.SetToolTip(txtTelephone, "Format: 02XXXXXXXX (can be 8 or 10 digits only)")
    End Sub

    Private Sub txtMobileNumber_MouseHover(sender As Object, e As EventArgs) Handles txtMobileNumber.MouseHover
        tooltip.SetToolTip(txtMobileNumber, "Format: 09XXXXXXXXX (11 digits only)")
    End Sub

    Private Sub txtTelephone_TextChanged(sender As Object, e As EventArgs) Handles txtTelephone.TextChanged
        If Not txtTelephone.Enabled Then
            Call TelephoneNumber_Color(txtTelephone)
        End If
    End Sub

    Private Sub txtAdrZip1_TextChanged(sender As Object, e As EventArgs) Handles txtAdrZip1.TextChanged
        If Not txtAdrZip1.Enabled Then
            Call ZipCode_Color(txtAdrZip1)
        End If
    End Sub

    Private Sub txtAdrZip2_TextChanged(sender As Object, e As EventArgs) Handles txtAdrZip2.TextChanged
        If Not txtAdrZip2.Enabled Then
            Call ZipCode_Color(txtAdrZip2)
        End If
    End Sub

End Class