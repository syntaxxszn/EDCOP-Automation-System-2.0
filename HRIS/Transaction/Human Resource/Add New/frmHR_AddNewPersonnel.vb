Imports System.ComponentModel
Imports System.Text.RegularExpressions


Public Class frmHR_AddNewPersonnel

    Public isExist As Boolean = False

    Private Sub frmHR_AddNewPersonnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(_strPersonnelID)
        FilePath = "\\192.168.0.250\references\DIMS_APPS_INST\Images Profile\default_image.png"
        Call GetImageProfile(PictureBoxAddProfile)
        _strEmployeeID = 0 'this is to reset and tell the stored proc that its new employee and needs to be inserted
        Call Family_Background_Relationship_DropDownList(cbRelationshipPS, cbSRelationhipSC)
        txtAdrCountry1.Text = "PHILIPPINES"
        txtAdrCountry2.Text = "PHILIPPINES"

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
        cbAdrCity1.SelectedIndex = -1
        cbAdrBarangay1.SelectedIndex = -1
    End Sub

    Private Sub cbAdrProvince_DropDown(sender As Object, e As EventArgs) Handles cbAdrProvince1.DropDown
        DropDownListProvince(cbAdrRegion1, cbAdrProvince1, cbAdrCity1)
    End Sub

    Private Sub cbAdrRegion_DropDown(sender As Object, e As EventArgs) Handles cbAdrRegion1.DropDown
        DropDownListRegion(cbAdrRegion1, cbAdrProvince1)
    End Sub

    Private Sub cbAdrCity_DropDown(sender As Object, e As EventArgs) Handles cbAdrCity1.DropDown
        DropDownListMunicipality(cbAdrProvince1, cbAdrCity1)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If Not HasUserAccess("insert") Then Return
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

    Private Sub cbCitizenship_DropDown(sender As Object, e As EventArgs) Handles cbCitizenship.DropDown
        DropDownListCitizenship(cbCitizenship)
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

    Private Sub cbPrefix_DropDown(sender As Object, e As EventArgs) Handles cbPrefix.DropDown
        PrefixDropDownList()
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
        DropDownListBank(cbBank)
    End Sub

    Sub ClearField_PersonnelDetails()
        dtpDateofBirth.ResetText()
        txtAge.Clear()
        cbBirthPlaceCity.SelectedIndex = -1
        cbBirthPlaceProvince.SelectedIndex = -1
        cbGender.SelectedIndex = -1
        txtHeight.Clear()
        txtWeight.Clear()
        cbCitizenship.SelectedIndex = -1
        cbReligion.SelectedIndex = -1
        cbCivilStatus.SelectedIndex = -1
        txtTelephone.Clear()
        txtMobileNumber.Clear()
        txtEmailAddress.Clear()
        txtAdrStreet1.Clear()
        cbAdrBarangay1.SelectedIndex = -1
        cbAdrRegion1.SelectedIndex = -1
        cbAdrProvince1.SelectedIndex = -1
        cbAdrCity1.SelectedIndex = -1
        txtAdrZip1.Clear()
        cbPresentAdr.CheckState = CheckState.Unchecked

        txtAdrStreet2.Clear()
        cbAdrBarangay2.SelectedIndex = -1
        cbAdrRegion2.SelectedIndex = -1
        cbAdrProvince2.SelectedIndex = -1
        cbAdrCity2.SelectedIndex = -1
        txtAdrZip2.Clear()
        'cbAdrCountry2.SelectedIndex = -1

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not HasUserAccess("insert") Then Return
        If isExist Then
            MessageBox.Show("This Employee Code exists in the database.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtCode.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(cbPronouns.Text) Then
            MessageBox.Show("Employee Code, Firstname, Lastname and Pronouns are required.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtECFullName1.Text) OrElse
           String.IsNullOrWhiteSpace(txtECEmailAddress1.Text) OrElse
           String.IsNullOrWhiteSpace(txtECMobileNo1.Text) Then
            MessageBox.Show("Please provide atleast 1 Emergency Contact.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedTab = TabPage4
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
                Call Ins_EmergencyContact()
                'InsUpd_Personnel_Identification() Not updated as stored procedure is edited to accept insert and update
                'Ins_PersonnelTempRecord() removed by [2024-1435] and integrated it in the stored proc
                'Sel_PersonnelID()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub cbRelationshipPS_SelectedIndexChanged(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub cbRelationshipPS_DropDown(sender As Object, e As EventArgs)
    '    DropDownListDependentsParentSiblings(cbRelationshipPS)
    'End Sub

    'Private Sub cbSRelationhipSC_SelectedIndexChanged(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub cbSRelationhipSC_DropDown(sender As Object, e As EventArgs)
    '    DropDownListDependentsSpouse(cbSRelationhipSC)
    'End Sub

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

    Private Sub txtMobileNoPS_Validating(sender As Object, e As CancelEventArgs) Handles txtMobileNoPS.Validating
        MobileNumber_Color(txtMobileNoPS, e.Cancel)
    End Sub

    Private Sub txtMobileNoSC_Validating(sender As Object, e As CancelEventArgs) Handles txtMobileNoSC.Validating
        MobileNumber_Color(txtMobileNoSC, e.Cancel)
    End Sub

    Private Sub txtHeight_Validating(sender As Object, e As CancelEventArgs) Handles txtHeight.Validating
        Textbox_NumericFormat(txtHeight, e.Cancel)
    End Sub

    Private Sub txtWeight_Validating(sender As Object, e As CancelEventArgs) Handles txtWeight.Validating
        Textbox_NumericFormat(txtWeight, e.Cancel)
    End Sub

    Private Sub txtAdrZip1_Validating(sender As Object, e As CancelEventArgs) Handles txtAdrZip1.Validating
        ZipCode_Color(txtAdrZip1, e.Cancel)
    End Sub

    Private Sub PictureBoxAddProfile_Click(sender As Object, e As EventArgs)
        If Not HasUserAccess("insert") Then Return
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
            End If
        End Using
    End Sub

    Private Sub PictureBoxAddProfile_Click_1(sender As Object, e As EventArgs) Handles PictureBoxAddProfile.Click
        Dim basePath As String = "\\192.168.0.250\references\DIMS_APPS_INST\Images Profile\"

        Using ofd As New OpenFileDialog With {.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim destPath As String = basePath & IO.Path.GetFileName(ofd.FileName)

                ' Check if file exists
                If IO.File.Exists(destPath) Then
                    MessageBox.Show("Image already exists in the destination!", "Duplicate Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                Else
                    IO.File.Copy(ofd.FileName, destPath) ' Copy original to destination
                End If

                FilePath = destPath

                ' Load and convert image to 2x2 inches (192x192 pixels at 96 DPI)
                Dim originalImage As Image = Image.FromFile(destPath)
                Dim targetWidth As Integer = 2 * 96 ' 192 pixels
                Dim targetHeight As Integer = 2 * 96 ' 192 pixels

                Dim resizedImage As New Bitmap(targetWidth, targetHeight)
                Using g As Graphics = Graphics.FromImage(resizedImage)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(originalImage, 0, 0, targetWidth, targetHeight)
                End Using

                resizedImage.SetResolution(96, 96) ' Set DPI metadata (optional but good practice)

                ' Set resized image to PictureBox
                PictureBoxAddProfile.Image = resizedImage
                PictureBoxAddProfile.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Using

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

    Private Sub txtboxSSSNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxSSSNo.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxSSSNo_Validating(sender As Object, e As CancelEventArgs) Handles txtboxSSSNo.Validating
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

    Private Sub txtboxTIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxTIN.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxTIN_Validating(sender As Object, e As CancelEventArgs) Handles txtboxTIN.Validating
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

    Private Sub txtboxPhilHealth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxPhilHealth.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxPhilHealth_Validating(sender As Object, e As CancelEventArgs) Handles txtboxPhilHealth.Validating
        If Not Regex.IsMatch(txtboxPhilHealth.Text, "^\d{2}-\d{9}-\d{1}$") Then
            MessageBox.Show("PhilHealth must be in the format: 01-123456789-1", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    Private Sub cbPayrollCategory_DropDown(sender As Object, e As EventArgs) Handles cbPayrollCategory.DropDown
        DropDownListPayrollCategory(cbPayrollCategory)
    End Sub

    Private Sub cbPayrollCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPayrollCategory.SelectedIndexChanged

    End Sub

    Private Sub cbAdrBarangay1_DropDown(sender As Object, e As EventArgs) Handles cbAdrBarangay1.DropDown
        DropDownListBarangay(cbAdrCity1, cbAdrBarangay1)
    End Sub

    Private Sub cbAdrRegion1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAdrRegion1.SelectedIndexChanged
        cbAdrProvince1.SelectedIndex = -1
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
        cbAdrBarangay2.SelectedIndex = -1
    End Sub

    Private Sub cbAdrBarangay2_DropDown(sender As Object, e As EventArgs) Handles cbAdrBarangay2.DropDown
        DropDownListBarangay(cbAdrCity2, cbAdrBarangay2)
    End Sub

    Private Sub cbBirthPlaceRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBirthPlaceRegion.SelectedIndexChanged
        cbBirthPlaceProvince.SelectedIndex = -1
        cbBirthPlaceCity.SelectedIndex = -1
    End Sub

    Private Sub cbBirthPlaceRegion_DropDown(sender As Object, e As EventArgs) Handles cbBirthPlaceRegion.DropDown
        DropDownListRegion(cbBirthPlaceRegion, cbBirthPlaceProvince)
    End Sub

    Private Sub cbBirthPlaceProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBirthPlaceProvince.SelectedIndexChanged
        cbBirthPlaceCity.SelectedIndex = -1
    End Sub

    Private Sub cbBirthPlaceProvince_DropDown(sender As Object, e As EventArgs) Handles cbBirthPlaceProvince.DropDown
        DropDownListProvince(cbBirthPlaceRegion, cbBirthPlaceProvince, cbBirthPlaceCity)
    End Sub

    Private Sub cbBirthPlaceCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBirthPlaceCity.SelectedIndexChanged

    End Sub

    Private Sub cbBirthPlaceCity_DropDown(sender As Object, e As EventArgs) Handles cbBirthPlaceCity.DropDown
        DropDownListMunicipality(cbBirthPlaceProvince, cbBirthPlaceCity)
    End Sub

    Private Sub txtTelephone_Validating(sender As Object, e As CancelEventArgs) Handles txtTelephone.Validating
        TelephoneNumber_Color(txtTelephone, e.Cancel)
    End Sub

    Private Sub txtMobileNumber_Validating(sender As Object, e As CancelEventArgs) Handles txtMobileNumber.Validating
        MobileNumber_Color(txtMobileNumber, e.Cancel)
    End Sub

    Private Sub txtEmailAddress_Validating(sender As Object, e As CancelEventArgs) Handles txtEmailAddress.Validating
        EmailRegEx_Color(txtEmailAddress, e.Cancel)
    End Sub

    Private Sub frmHR_AddNewPersonnel_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
        ResetDatePickers(Me)
        UncheckCheckBoxes(Me)
        ClearDataGridViewRows(Me)
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
        If Not Regex.IsMatch(txtboxHDMF.Text, "^\d{4}-\d{4}-\d{4}$") Then
            MessageBox.Show("PAG-IBIG must be in the format: 1234-1234-1234", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    Private Sub cbMedicalCategory_DropDown(sender As Object, e As EventArgs) Handles cbMedicalCategory.DropDown
        DropDownListMedicalCategory(cbMedicalCategory)
    End Sub

    Private Sub cbMedicalCondition_DropDown(sender As Object, e As EventArgs) Handles cbMedicalCondition.DropDown
        DropDownListMedicalCondition(cbMedicalCondition, cbMedicalCategory)
    End Sub

    Private Sub cbMedicalCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMedicalCategory.SelectedIndexChanged
        cbMedicalCondition.SelectedIndex = -1
    End Sub

    Private Sub btnEmergencyContacts_Click(sender As Object, e As EventArgs) Handles btnEmergencyContacts.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged

    End Sub
End Class
