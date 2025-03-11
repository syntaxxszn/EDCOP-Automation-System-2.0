Imports System.Data.SqlClient
Module Module_HRIS

	Public FilePath As String = ""
	Public _strPersonnelID As Integer
	Public _strSameAsAddressValidation As Integer
	Public isOperationDept As Integer
	Public isInactive As Integer

	Public isFlexi As Integer
	Public isForceBreak As Integer
	Public _strShiftID As Integer

	Public isEdit As Boolean = False
	Public PanelTagID As Integer = 0
	Private originalReadOnly As New Dictionary(Of TextBox, Boolean)

	Public _PersonnelPSID1 As Integer
	Public _PersonnelPSID2 As Integer = 1000000
	Public _PersonnelSCID1 As Integer
	Public _PersonnelSCID2 As Integer = 1000000

	Public _PersonnelEducationID1 As Integer
	Public _PersonnelEducationID2 As Integer = 1000000

	Public _PersonnelCharRefID1 As Integer
	Public _PersonnelCharRefID2 As Integer = 1000000

	Public _ContractID1 As Integer
	Public _ContractID2 As Integer = 1000000


	Sub FunctionBtnEdit_Enable()
		isEdit = Not isEdit
		If PanelTagID = 101 Then
			If isEdit Then
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Show()
				Call frmHR_PreviewPersonnelDetails_PersonalInformation.function_ReadOnly_isFalse()
			Else
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
				Call frmHR_PreviewPersonnelDetails_PersonalInformation.Function_ReadOnly_isTrue()
			End If
		ElseIf PanelTagID = 102 Then
			If isEdit Then
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_UpdatePersonnelDetails_Contracts) 'call edit form
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Show()
			Else
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_PreviewPersonnelDetails_Contracts) 'call non-edit form
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
			End If
		ElseIf PanelTagID = 103 Then
			If isEdit Then
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_UpdatePersonnelDetails_CharacterReference)
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Show()
			Else
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_PreviewPersonnelDetails_CharacterReference)
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
			End If
		ElseIf PanelTagID = 104 Then
			If isEdit Then
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_UpdatePersonnelDetails_EducationBackground)
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Show()
			Else
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_PreviewPersonnelDetails_EducationBackground)
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
			End If
		End If
	End Sub

	Sub Sel_Personnel_Active(dgvPersonnelList As DataGridView)

		dgvPersonnelList.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[SpSelHRIS_Personnel_Active]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgvPersonnelList.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2),
			dr.GetString(3),
			dr.GetString(4),
			dr.GetString(5),
			dr.GetString(6))
		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgvPersonnelList.ClearSelection()
	End Sub

	Sub Sel_Personnel_InActive(dgvPersonnelList As DataGridView)

		dgvPersonnelList.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[SpSelHRIS_Personnel_InActive]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgvPersonnelList.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2),
			dr.GetString(3),
			dr.GetString(4))
			'dr.GetString(5)

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgvPersonnelList.ClearSelection()

	End Sub

	Sub Sel_Personnel_PersonalInformation_ByEmployeeID()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelUpdHRIS_Personnel_PreviewDetailsByID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			frmHR_PreviewPersonnelDetails.lblFullName.Text = dr.GetString(2)
			frmHR_PreviewPersonnelDetails.lblEmployeeNo.Text = dr.GetString(1)
			frmHR_PreviewPersonnelDetails_PersonalInformation.dtpDateofBirth.Text = dr.GetString(3)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtAge.Text = dr.GetInt32(4)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtPlaceofBirth.Text = dr.GetString(5)
			frmHR_PreviewPersonnelDetails_PersonalInformation.cbGender.Text = dr.GetString(6)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtHeight.Text = dr.GetString(7)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtWeight.Text = dr.GetString(8)
			frmHR_PreviewPersonnelDetails_PersonalInformation.cbCitizenship.Text = dr.GetString(9)
			frmHR_PreviewPersonnelDetails_PersonalInformation.cbCivilStatus.Text = dr.GetString(10)
			frmHR_PreviewPersonnelDetails_PersonalInformation.cbReligion.Text = dr.GetString(11)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtEmailAddress.Text = dr.GetString(12)

			frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrStreet1.Text = dr.GetString(13)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrBrgy1.Text = dr.GetString(14)
			frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrRegion1.Text = dr.GetString(15)
			frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrProvince1.Text = dr.GetString(16)
			frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrCity1.Text = dr.GetString(17)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrCountry1.Text = dr.GetString(18)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrZip1.Text = dr.GetString(19)

			frmHR_PreviewPersonnelDetails_PersonalInformation.cbPresentAdr.CheckState = If(dr.GetInt32(20) = 1, CheckState.Checked, CheckState.Unchecked)
			frmHR_PreviewPersonnelDetails_PersonalInformation.cbForeignAddr.CheckState = If(dr.GetInt32(21) = 1, CheckState.Checked, CheckState.Unchecked)
			frmHR_AddUpdForeignAddress.txtForeignAddress.Text = dr.GetString(22)
			' Name : Dela Pena, Jerome [2024-1435]
			' Date Created : 02-24-25

			frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrStreet2.Text = dr.GetString(23)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrBrgy2.Text = dr.GetString(24)
			frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrRegion2.Text = dr.GetString(25)
			frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrProvince2.Text = dr.GetString(26)
			frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrCity2.Text = dr.GetString(27)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrCountry2.Text = dr.GetString(28)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrZip2.Text = dr.GetString(29)

			frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxSSSNo.Text = dr.GetString(30)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxTIN.Text = dr.GetString(31)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxPhilHealth.Text = dr.GetString(32)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxHDMF.Text = dr.GetString(33)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxPRCNo.Text = dr.GetString(34)
			frmHR_PreviewPersonnelDetails_PersonalInformation.dtpPRCIssuanceDate.Value = If(dr.IsDBNull(35), DateTime.Now, dr.GetDateTime(35))
			frmHR_PreviewPersonnelDetails_PersonalInformation.dtpPRCExpiryDate.Value = If(dr.IsDBNull(36), DateTime.Now, dr.GetDateTime(36))
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxPTRNo.Text = dr.GetString(37)
			frmHR_PreviewPersonnelDetails_PersonalInformation.dtpPTRIssuanceDate.Value = If(dr.IsDBNull(38), DateTime.Now, dr.GetDateTime(38))
			frmHR_PreviewPersonnelDetails_PersonalInformation.dtpPTRExpiryDate.Value = If(dr.IsDBNull(39), DateTime.Now, dr.GetDateTime(39))
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxPayrollAccountNo.Text = dr.GetString(40)
			''No Bank Accouunt and Payroll Category 

			frmHR_PreviewPersonnelDetails_PersonalInformation.txtTelephone.Text = dr.GetString(41)
			frmHR_PreviewPersonnelDetails_PersonalInformation.txtMobileNumber.Text = dr.GetString(42)

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
	End Sub

	Sub BrowseProfilePic(_profilePicImage As PictureBox)
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
				_profilePicImage.Image = Image.FromFile(destPath)
				_profilePicImage.SizeMode = PictureBoxSizeMode.StretchImage
			End If
		End Using
	End Sub

	Sub GetImageProfile(_profilePicImage As PictureBox)
		If System.IO.File.Exists(FilePath) Then
			_profilePicImage.SizeMode = PictureBoxSizeMode.StretchImage
			_profilePicImage.Image = Image.FromFile(FilePath)
		Else
			_profilePicImage.SizeMode = PictureBoxSizeMode.StretchImage
			'_profilePicImage.Image = Image.FromFile("D:\SOFT DEV TEAM WORK\ROME\6-5-2024\JD\EDCOP Project Monitoring System\Resources\pc14.png")
		End If
	End Sub

	Sub Sel_Personnel_PersonalInformationDependent_ByEmployeeID()

		frmHR_PreviewPersonnelDetails_Dependents.dgvPrevParentsDetails.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Personnel_Dependents_PreviewDetailsByID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			frmHR_PreviewPersonnelDetails_Dependents.dgvPrevParentsDetails.Rows.Add(
			 dr.GetInt32(0),
			 dr.GetString(1),
			 dr.GetString(2))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()

	End Sub


	Sub Family_Background_Relationship_DropDownList()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_FamilyRelationshipDropDownList]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
		.CommandType = CommandType.StoredProcedure
	}
		frmHR_PreviewPersonnelDetails_PersonalInformation.cbRelationshipPS.Items.Clear()
		frmHR_PreviewPersonnelDetails_PersonalInformation.cbSRelationhipSC.Items.Clear()

		Dim DependentsDictionaryPS As New Dictionary(Of String, Integer)()
		Dim DependentsDictionarySC As New Dictionary(Of String, Integer)()

		Using reader As SqlDataReader = cmd.ExecuteReader()
			While reader.Read()
				Dim id As Integer = reader.GetInt32(0)
				Dim dependents As String = reader.GetString(1)
				If id >= 718 AndAlso id <= 723 Then
					frmHR_PreviewPersonnelDetails_PersonalInformation.cbRelationshipPS.Items.Add(dependents)
					DependentsDictionaryPS.Add(dependents, id)
				End If
				If id >= 724 AndAlso id <= 726 Then
					frmHR_PreviewPersonnelDetails_PersonalInformation.cbSRelationhipSC.Items.Add(dependents)
					DependentsDictionarySC.Add(dependents, id)
				End If
			End While
		End Using
		frmHR_PreviewPersonnelDetails_PersonalInformation.cbRelationshipPS.Tag = DependentsDictionaryPS
		frmHR_PreviewPersonnelDetails_PersonalInformation.cbSRelationhipSC.Tag = DependentsDictionarySC
		Conn.Close()
	End Sub

	Sub SelUpd_FamilyBackground(dgvParentsAndSiblings As DataGridView, dgvSpouseAndChildren As DataGridView)
		dgvParentsAndSiblings.Rows.Clear()
		dgvSpouseAndChildren.Rows.Clear()

		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelUpdHRIS_Personnel_FamilyBackground_PreviewDetailsByID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						dgvParentsAndSiblings.Rows.Add(
						Convert.ToInt32(dr(0)),
						dr(1).ToString(),
						dr(2).ToString(),
						Convert.ToDateTime(dr(3)),
						Convert.ToInt32(dr(4)),
						dr(5).ToString())
					End While

					dr.NextResult()
					While dr.Read()
						dgvSpouseAndChildren.Rows.Add(
						Convert.ToInt32(dr(0)),
						dr(1).ToString(),
						dr(2).ToString(),
						Convert.ToDateTime(dr(3)),
						Convert.ToInt32(dr(4)),
						dr(5).ToString())
					End While
				End Using
				dgvParentsAndSiblings.ClearSelection()
				dgvSpouseAndChildren.ClearSelection()
			End Using
		End Using
	End Sub

	'Sub Sel_Personnel_PersonalInformationDependentSiblings_ByEmployeeID()

	'	frmHR_PreviewPersonnelDetails_Dependents.dgvPrevSiblingsDetails.Rows.Clear()
	'	Conn = New SqlConnection(StrConn)
	'	Conn.Open()
	'	cmd = Conn.CreateCommand
	'	cmd.CommandText = "[spSelEmployeeSiblings]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn) With {
	'					.CommandType = CommandType.StoredProcedure
	'					}
	'	cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
	'	dr = cmd.ExecuteReader()
	'	While dr.Read()

	'		frmHR_PreviewPersonnelDetails_Dependents.dgvPrevSiblingsDetails.Rows.Add(
	'		dr.GetInt32(0),
	'		 dr.GetString(1),
	'		 dr.GetString(2),
	'		 dr.GetString(3),
	'		 dr.GetString(5))

	'	End While
	'	dr.Close()
	'	Conn.Close()
	'	cmd.Parameters.Clear()

	'End Sub

	Sub Sel_Personnel_EducationalBG_ByEmployeeID()

		'frmHR_PreviewPersonnelDetails.dgvEducationalBG.Rows.Clear()
		'Conn = New SqlConnection(StrConn)
		'Conn.Open()
		'cmd = Conn.CreateCommand
		'cmd.CommandText = "[spSelEducationBGByPersonnelID]"

		'cmd = New SqlCommand(cmd.CommandText, Conn) With {
		'				.CommandType = CommandType.StoredProcedure
		'				}
		'cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
		'dr = cmd.ExecuteReader()
		'While dr.Read()

		'	frmHR_PreviewPersonnelDetails.dgvEducationalBG.Rows.Add(
		'	 dr.GetInt32(0),
		'	 dr.GetString(1),
		'	 dr.GetString(2),
		'	 dr.GetString(3),
		'	 dr.GetString(4),
		'	 dr.GetString(5))

		'End While
		'dr.Close()
		'Conn.Close()
		'cmd.Parameters.Clear()
		'frmHR_PreviewPersonnelDetails.dgvEducationalBG.ClearSelection()

	End Sub

	Sub Sel_Personnel_TrainingHistory_ByEmployeeID(_dgvTrainingHistory As DataGridView)

		_dgvTrainingHistory.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelTrainingHistoryByPersonnelID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
		dr = cmd.ExecuteReader()
		If dr.HasRows Then

			While dr.Read()
				_dgvTrainingHistory.Rows.Add(
		   dr.GetInt32(0),
		   dr.GetString(1),
		   dr.GetString(2),
		   dr.GetString(3),
		   dr.GetString(4),
		   dr.GetString(5))
			End While

		Else

			MessageBox.Show("No record found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

		End If

		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		_dgvTrainingHistory.ClearSelection()

	End Sub

	Sub Search_DGVPersonnel(_dgvPersonnelList As DataGridView, _txtBoxItemName As TextBox)

		_dgvPersonnelList.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Personnel_Search]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@PersonnelSearch", _txtBoxItemName.Text)
		dr = cmd.ExecuteReader()
		If dr.HasRows Then

			While dr.Read()

				_dgvPersonnelList.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2),
			dr.GetString(3),
			dr.GetString(4),
			dr.GetString(5),
			dr.GetString(6))

			End While

		Else

			MessageBox.Show("Record not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

		End If

		dr.Dispose()
		Conn.Dispose()

		_dgvPersonnelList.ClearSelection()

	End Sub

	Sub Search_DGVDepartment(dgv As DataGridView, txtSearch As TextBox)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_DepartmentSearch]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@Search", txtSearch.Text)
		dr = cmd.ExecuteReader()
		If dr.HasRows Then

			While dr.Read()

				dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2),
			dr.GetString(3),
			dr.GetString(4),
			dr.GetString(5),
			dr.GetString(6))


			End While

		Else

			MessageBox.Show("Search not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

		End If

		dr.Dispose()
		Conn.Dispose()

		dgv.ClearSelection()

	End Sub

	Sub Sel_Personnel_TransferHistory_ByEmployeeID(_dgvTransferHistory As DataGridView)

		_dgvTransferHistory.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRM_TransferHistory_ByEmployeeID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
		dr = cmd.ExecuteReader()
		If dr.HasRows Then

			While dr.Read()

				_dgvTransferHistory.Rows.Add(
		   dr.GetInt32(0),
		   dr.GetString(1),
		   dr.GetString(2),
		   dr.GetString(3),
		   dr.GetString(4),
		   dr.GetString(5),
		   dr.GetString(6),
		   dr.GetString(7),
		   dr.GetString(8),
		   dr.GetDecimal(9),
		   dr.GetString(10),
		   dr.GetString(11),
		   dr.GetString(12))

			End While

		Else

			MessageBox.Show("No record found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

		End If

		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		_dgvTransferHistory.ClearSelection()

	End Sub

	Sub Sel_Personnel_CharacterReferences_ByEmployeeID(_dgvCharacterReference As DataGridView)

		_dgvCharacterReference.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelCharacterReferenceByPersonnelID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
		dr = cmd.ExecuteReader()
		' If dr.HasRows Then

		While dr.Read()
			_dgvCharacterReference.Rows.Add(
	   dr.GetInt32(0),
	   dr.GetString(1),
	   dr.GetString(2),
	   dr.GetString(3),
	   dr.GetString(4),
	   dr.GetString(5))
		End While

		' Else

		'  MessageBox.Show("No record found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

		'End If

		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		_dgvCharacterReference.ClearSelection()

	End Sub

	Sub Ins_Personnel_ProfilePic()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsHRIS_Personnel_ProfilePicture]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
				}
		cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@CreatedBy", frmMain.ToolStripEmployeeNo.Text)
		cmd.Parameters.AddWithValue("@FilePath", FilePath)
		cmd.ExecuteNonQuery()
		Conn.Close()

	End Sub

	Sub Ins_PersonnelDetails()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsHRIS_Personnel_NewRecord]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
				}
		cmd.Parameters.AddWithValue("@ID", _strPersonnelID)
		cmd.Parameters.AddWithValue("@Code", frmHR_AddNewPersonnel.txtCode.Text)
		cmd.Parameters.AddWithValue("@Pronouns", frmHR_AddNewPersonnel.cbPronouns.Text)
		cmd.Parameters.AddWithValue("@Prefix", frmHR_AddNewPersonnel.cbPrefix.Text)
		cmd.Parameters.AddWithValue("@LastName", frmHR_AddNewPersonnel.txtLastName.Text)
		cmd.Parameters.AddWithValue("@FirstName", frmHR_AddNewPersonnel.txtFirstName.Text)
		cmd.Parameters.AddWithValue("@MiddleName", frmHR_AddNewPersonnel.txtMiddleName.Text)
		cmd.Parameters.AddWithValue("@Suffix", frmHR_AddNewPersonnel.cbSuffix.Text)

		cmd.Parameters.AddWithValue("@BirthDate", frmHR_AddNewPersonnel.dtpDateofBirth.Text)
		'  cmd.Parameters.AddWithValue("@Age", frmHR_AddNewPersonnel.txtAge.Text)
		cmd.Parameters.AddWithValue("@BirthPlace", frmHR_AddNewPersonnel.txtPlaceofBirth.Text)
		cmd.Parameters.AddWithValue("@Gender", frmHR_AddNewPersonnel.cbGender.Text)
		cmd.Parameters.AddWithValue("@Height", frmHR_AddNewPersonnel.txtHeight.Text)
		cmd.Parameters.AddWithValue("@Weight", frmHR_AddNewPersonnel.txtWeight.Text)

		cmd.Parameters.AddWithValue("@Citizenship", frmHR_AddNewPersonnel.cbCitizenship.Text)
		cmd.Parameters.AddWithValue("@Religion", frmHR_AddNewPersonnel.cbReligion.Text)
		cmd.Parameters.AddWithValue("@CivilStatus", frmHR_AddNewPersonnel.cbCivilStatus.Text)

		cmd.Parameters.AddWithValue("@TelNo", frmHR_AddNewPersonnel.txtTelephone.Text)
		cmd.Parameters.AddWithValue("@CellPhoneNo", frmHR_AddNewPersonnel.txtMobileNumber.Text)
		cmd.Parameters.AddWithValue("@EmailAddress", frmHR_AddNewPersonnel.txtEmailAddress.Text)

		cmd.Parameters.AddWithValue("@TaxCode", frmHR_AddNewPersonnel.cbTaxCode.Text)

		' cmd.Parameters.AddWithValue("@TaxCode", frmHR_AddNewPersonnel.cbPayrollCategory.Text)
		cmd.Parameters.AddWithValue("@PayrollAccountNo", frmHR_AddNewPersonnel.txtboxPayrollAccountNo.Text)
		cmd.Parameters.AddWithValue("@BankName", frmHR_AddNewPersonnel.cbBank.Text)

		cmd.Parameters.AddWithValue("@ModifiedBy", frmMain.ToolStripEmployeeNo.Text)

		If cmd.ExecuteNonQuery = -1 Then
			MessageBox.Show("OK")
		Else
			MessageBox.Show("Invalid")
		End If
		Conn.Close()

	End Sub

	Sub Ins_Personnel_AddressDetails()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsHRIS_Personnel_AddressDetails]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
				}

		cmd.Parameters.AddWithValue("@PersonnelID", _strPersonnelID)
		cmd.Parameters.AddWithValue("@StreetAdd1", frmHR_AddNewPersonnel.txtAdrStreet1.Text)
		cmd.Parameters.AddWithValue("@BrgyAdd1", frmHR_AddNewPersonnel.txtAdrBrgy1.Text)
		cmd.Parameters.AddWithValue("@MunicipalityName1", frmHR_AddNewPersonnel.cbAdrCity1.Text)
		cmd.Parameters.AddWithValue("@ProvinceName1", frmHR_AddNewPersonnel.cbAdrProvince1.Text)
		cmd.Parameters.AddWithValue("@RegionName1", frmHR_AddNewPersonnel.cbAdrRegion1.Text)
		cmd.Parameters.AddWithValue("@Country1", frmHR_AddNewPersonnel.txtAdrCountry1.Text)
		cmd.Parameters.AddWithValue("@PostalCode1", frmHR_AddNewPersonnel.txtAdrZip1.Text)

		cmd.Parameters.AddWithValue("@SameAsPresentAdd", _strSameAsAddressValidation)

		cmd.Parameters.AddWithValue("@StreetAdd2", frmHR_AddNewPersonnel.txtAdrStreet2.Text)
		cmd.Parameters.AddWithValue("@BrgyAdd2", frmHR_AddNewPersonnel.txtAdrBrgy2.Text)
		cmd.Parameters.AddWithValue("@MunicipalityName2", frmHR_AddNewPersonnel.cbAdrCity2.Text)
		cmd.Parameters.AddWithValue("@ProvinceName2", frmHR_AddNewPersonnel.cbAdrProvince2.Text)
		cmd.Parameters.AddWithValue("@RegionName2", frmHR_AddNewPersonnel.cbAdrRegion2.Text)
		cmd.Parameters.AddWithValue("@Country2", frmHR_AddNewPersonnel.txtAdrCountry2.Text)
		cmd.Parameters.AddWithValue("@PostalCode2", frmHR_AddNewPersonnel.txtAdrZip2.Text)
		cmd.Parameters.AddWithValue("@ModifiedBy", frmMain.ToolStripEmployeeNo.Text)

		If cmd.ExecuteNonQuery = -1 Then
			'MessageBox.Show("OK")
		Else
			MessageBox.Show("Invalid")
		End If
		Conn.Close()

	End Sub

	Sub Ins_Personnel_Identification()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsUpdHRIS_Personnel_Identifications]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
				}

		cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@SocialSecNo", frmHR_AddNewPersonnel.txtboxSSSNo.Text)
		cmd.Parameters.AddWithValue("@TIN", frmHR_AddNewPersonnel.txtboxTIN.Text)
		cmd.Parameters.AddWithValue("@PhilHealthNo", frmHR_AddNewPersonnel.txtboxPhilHealth.Text)
		cmd.Parameters.AddWithValue("@PagIbigNo", frmHR_AddNewPersonnel.txtboxHDMF.Text)
		cmd.Parameters.AddWithValue("@PRCNo", frmHR_AddNewPersonnel.txtboxPRCNo.Text)
		cmd.Parameters.AddWithValue("@PRCNoIssuanceDate", frmHR_AddNewPersonnel.dtpPRCIssuanceDate.Value.Date)
		cmd.Parameters.AddWithValue("@PRCNoExpiryDate", frmHR_AddNewPersonnel.dtpPRCExpiryDate.Value.Date)
		cmd.Parameters.AddWithValue("@PTRNo", frmHR_AddNewPersonnel.txtboxPTRNo.Text)
		cmd.Parameters.AddWithValue("@PTRNoIssuanceDate", frmHR_AddNewPersonnel.dtpPTRIssuanceDate.Value.Date)
		cmd.Parameters.AddWithValue("@PTRNoExpiryDate", frmHR_AddNewPersonnel.dtpPTRExpiryDate.Value.Date)
		cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
		cmd.ExecuteNonQuery()

		Conn.Close()
		cmd.Parameters.Clear()
	End Sub

	Sub InsUpd_ForeignAddress()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsUpdHRIS_Personnel_ForeignAddress]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@ForeignAddress", frmHR_AddUpdForeignAddress.txtForeignAddress.Text)
		cmd.ExecuteNonQuery()
		Conn.Close()
		cmd.Parameters.Clear()
		frmHR_AddUpdForeignAddress.Close()
	End Sub

	Sub ProcessDataGridViewParentsAndSiblings(dataGridView As DataGridView)

		'\\ Credit by Jerome Dela Pena [2024-1435]  : 

		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spInsUpdHRIS_Personnel_ParentsSiblings]", Conn)
				cmd.CommandType = CommandType.StoredProcedure

				For Each row As DataGridViewRow In dataGridView.Rows

					cmd.Parameters.AddWithValue("@ID", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
					cmd.Parameters.AddWithValue("@Relationship", If(row.Cells(1).Value IsNot DBNull.Value, row.Cells(1).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@Name", If(row.Cells(2).Value IsNot DBNull.Value, row.Cells(2).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@BirthDate", If(row.Cells(3).Value IsNot DBNull.Value, row.Cells(3).Value.ToString(), ""))
					' cmd.Parameters.AddWithValue("@Age", If(row.Cells(3).Value IsNot DBNull.Value, row.Cells(3).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@ContactNo", If(row.Cells(5).Value IsNot DBNull.Value, row.Cells(5).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)

					cmd.ExecuteNonQuery()
					cmd.Parameters.Clear()
				Next
			End Using
		End Using

	End Sub

	Sub ProcessDataGridViewSpouseAndChildren(dataGridView As DataGridView)

		'\\ Credit by Jerome Dela Pena [2024-1435]  : 

		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spInsUpdHRIS_Personnel_Dependents]", Conn)
				cmd.CommandType = CommandType.StoredProcedure

				For Each row As DataGridViewRow In dataGridView.Rows

					cmd.Parameters.AddWithValue("@ID", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
					cmd.Parameters.AddWithValue("@Relationship", If(row.Cells(1).Value IsNot DBNull.Value, row.Cells(1).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@Name", If(row.Cells(2).Value IsNot DBNull.Value, row.Cells(2).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@BirthDate", If(row.Cells(3).Value IsNot DBNull.Value, row.Cells(3).Value.ToString(), ""))
					' cmd.Parameters.AddWithValue("@Age", If(row.Cells(3).Value IsNot DBNull.Value, row.Cells(3).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@ContactNo", If(row.Cells(5).Value IsNot DBNull.Value, row.Cells(5).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)

					cmd.ExecuteNonQuery()
					cmd.Parameters.Clear()
				Next
			End Using
		End Using
	End Sub

	'--->>> Personnel Information Update <<<---

	Sub InsUpd_PersonnelDetails()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd.Connection.CreateCommand()
		cmd.CommandText = "[spInsUpdHRIS_Personnel_details]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
					}

		cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@Birthdate", frmHR_PreviewPersonnelDetails_PersonalInformation.dtpDateofBirth.Text)
		cmd.Parameters.AddWithValue("@BirthPlace", frmHR_PreviewPersonnelDetails_PersonalInformation.txtPlaceofBirth.Text)
		cmd.Parameters.AddWithValue("@Gender", frmHR_PreviewPersonnelDetails_PersonalInformation.cbGender.Text)
		cmd.Parameters.AddWithValue("@Height", frmHR_PreviewPersonnelDetails_PersonalInformation.txtHeight.Text)
		cmd.Parameters.AddWithValue("@Weight", frmHR_PreviewPersonnelDetails_PersonalInformation.txtWeight.Text)
		cmd.Parameters.AddWithValue("@Citizenship", frmHR_PreviewPersonnelDetails_PersonalInformation.cbCitizenship.Text)
		cmd.Parameters.AddWithValue("@CivilStatus", frmHR_PreviewPersonnelDetails_PersonalInformation.cbCivilStatus.Text)
		cmd.Parameters.AddWithValue("@Religion", frmHR_PreviewPersonnelDetails_PersonalInformation.cbReligion.Text)
		cmd.Parameters.AddWithValue("@TelNo", frmHR_PreviewPersonnelDetails_PersonalInformation.txtTelephone.Text)
		cmd.Parameters.AddWithValue("@CellphoneNo", frmHR_PreviewPersonnelDetails_PersonalInformation.txtMobileNumber.Text)
		cmd.Parameters.AddWithValue("@EmailAddress", frmHR_PreviewPersonnelDetails_PersonalInformation.txtEmailAddress.Text)

		'cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)

		If cmd.ExecuteNonQuery = -1 Then
			Call FunctionBtnEdit_Enable()
			MessageBox.Show("Saved.")
			frmHR_PreviewPersonnelDetails.btnEdit.PerformClick()
			If frmHR_Transaction_EmployeeFile.txtboxSearch.Text <> "" Then
				Call Search_DGVPersonnel(frmHR_Transaction_EmployeeFile.dgvEmployeeList, frmHR_Transaction_EmployeeFile.txtboxSearch)
			Else
				Call frmHR_Transaction_EmployeeFile.EmployeeList_Active()
			End If
		Else
				MessageBox.Show("Cannot update, Something went wrong. ", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		Conn.Close()
		cmd.Parameters.Clear()
		Call frmHR_PreviewPersonnelDetails_PersonalInformation.Function_ReadOnly_isTrue()
	End Sub

	Sub InsUpd_PersonnelDetails_Address()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd.Connection.CreateCommand()
		cmd.CommandText = "[spInsUpdHRIS_Personnel_AddressDetails]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
					}

		cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@StreetAdd1", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrStreet1.Text)
		cmd.Parameters.AddWithValue("@BrgyAdd1", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrBrgy1.Text)
		cmd.Parameters.AddWithValue("@MunicipalityName1", frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrCity1.Text)
		cmd.Parameters.AddWithValue("@ProvinceName1", frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrProvince1.Text)
		cmd.Parameters.AddWithValue("@RegionName1", frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrRegion1.Text)
		cmd.Parameters.AddWithValue("@PostalCode1", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrZip1.Text)
		cmd.Parameters.AddWithValue("@Country1", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrCountry1.Text)

		cmd.Parameters.AddWithValue("@SameAsPresentAdd", _strSameAsAddressValidation)

		cmd.Parameters.AddWithValue("@StreetAdd2", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrStreet2.Text)
		cmd.Parameters.AddWithValue("@BrgyAdd2", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrBrgy2.Text)
		cmd.Parameters.AddWithValue("@MunicipalityName2", frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrCity2.Text)
		cmd.Parameters.AddWithValue("@ProvinceName2", frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrProvince2.Text)
		cmd.Parameters.AddWithValue("@RegionName2", frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrRegion2.Text)
		cmd.Parameters.AddWithValue("@PostalCode2", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrZip2.Text)
		cmd.Parameters.AddWithValue("@Country2", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrCountry2.Text)

		cmd.Parameters.AddWithValue("@ModifiedBy", frmMain.ToolStripEmployeeNo.Text)

		cmd.ExecuteNonQuery()
		Conn.Close()
		cmd.Parameters.Clear()
	End Sub

	Sub InsUpd_Personnel_Identification()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsUpdHRIS_Personnel_Identifications]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
				}

		cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@SocialSecNo", frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxSSSNo.Text)
		cmd.Parameters.AddWithValue("@TIN", frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxTIN.Text)
		cmd.Parameters.AddWithValue("@PhilHealthNo", frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxPhilHealth.Text)
		cmd.Parameters.AddWithValue("@PagIbigNo", frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxHDMF.Text)
		cmd.Parameters.AddWithValue("@PRCNo", frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxPRCNo.Text)
		cmd.Parameters.AddWithValue("@PRCNoIssuanceDate", frmHR_PreviewPersonnelDetails_PersonalInformation.dtpPRCIssuanceDate.Value.Date)
		cmd.Parameters.AddWithValue("@PRCNoExpiryDate", frmHR_PreviewPersonnelDetails_PersonalInformation.dtpPRCExpiryDate.Value.Date)
		cmd.Parameters.AddWithValue("@PTRNo", frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxPTRNo.Text)
		cmd.Parameters.AddWithValue("@PTRNoIssuanceDate", frmHR_PreviewPersonnelDetails_PersonalInformation.dtpPTRIssuanceDate.Value.Date)
		cmd.Parameters.AddWithValue("@PTRNoExpiryDate", frmHR_PreviewPersonnelDetails_PersonalInformation.dtpPTRExpiryDate.Value.Date)
		cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
		cmd.ExecuteNonQuery()

		Conn.Close()
		cmd.Parameters.Clear()
	End Sub

	Sub Del_Personnel_ParentsAndSiblings_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_Personnel_ParentsAndSiblings]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _PersonnelPSID1)
				cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()
				MsgBox("Deletion Success!")
			End Using
		End Using
		dgv.Rows.Remove(dgv.SelectedRows(0))
	End Sub

	Sub Del_Personnel_SpouseAndChildren_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_Personnel_SpouseAndChildren]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _PersonnelSCID1)
				cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()
				MsgBox("Deletion Success!")
			End Using
		End Using
		dgv.Rows.Remove(dgv.SelectedRows(0))
	End Sub



	'--->>> Drop Down Lists <<<---
	Sub DropDownListGender(_strGender As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		_strGender.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Gender]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()

			Dim a = dr.GetString(0)
			col.Add(a)
			_strGender.Items.Add(a)

		End While
		_strGender.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListCitizenship(cbCitizenship As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cbCitizenship.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Citizenship]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()

			Dim a = dr.GetString(0)
			col.Add(a)
			cbCitizenship.Items.Add(a)

		End While
		cbCitizenship.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListReligion(cbReligion As ComboBox)

		cbReligion.Items.Clear()
		Conn = New SqlConnection(StrConn)
		cmd.CommandText = "[spSelHRIS_Religion]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()
			Dim a = dr.GetString(0)
			cbReligion.Items.Add(a)
		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListCivilStatus(cbCivilStatus As ComboBox)

		cbCivilStatus.Items.Clear()
		Conn = New SqlConnection(StrConn)
		cmd.CommandText = "[spSelHRIS_CivilStatus]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()
			Dim a = dr.GetString(0)
			cbCivilStatus.Items.Add(a)
		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListTaxCode()

		frmHR_AddNewPersonnel.cbTaxCode.Items.Clear()
		Conn = New SqlConnection(StrConn)
		cmd.CommandText = "[spSelHRIS_TaxCode]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()
			Dim a = dr.GetString(0)
			frmHR_AddNewPersonnel.cbTaxCode.Items.Add(a)
		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListBank()

		frmHR_AddNewPersonnel.cbBank.Items.Clear()
		Conn = New SqlConnection(StrConn)
		cmd.CommandText = "[spSelHRIS_Bank]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()
			Dim a = dr.GetString(0)
			frmHR_AddNewPersonnel.cbBank.Items.Add(a)
		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListRegion(_cmbRegion As ComboBox, _cmbProvince As ComboBox)

		_cmbProvince.Items.Clear()
		_cmbRegion.Items.Clear()
		Conn = New SqlConnection(StrConn)
		cmd.CommandText = "[spSelHRIS_Region]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()
			Dim a = dr.GetString(0)
			_cmbRegion.Items.Add(a)
		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListProvince(_cmbRegion As ComboBox, _cmbProvince As ComboBox, _cmbMunicipality As ComboBox)

		Conn = New SqlConnection(StrConn)
		_cmbProvince.Items.Clear()
		_cmbMunicipality.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Province]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		cmd.CommandType = CommandType.StoredProcedure
		Conn.Open()
		cmd.Parameters.AddWithValue("@RegionName", _cmbRegion.Text)
		dr = cmd.ExecuteReader()

		While dr.Read()

			Dim a = dr.GetString(0)
			_cmbProvince.Items.Add(a)

		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListMunicipality(_cmbProvince As ComboBox, _cmbMunicipality As ComboBox)

		Conn = New SqlConnection(StrConn)
		_cmbMunicipality.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Municipality]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		cmd.CommandType = CommandType.StoredProcedure
		Conn.Open()
		cmd.Parameters.AddWithValue("@ProvinceName", _cmbProvince.Text)
		dr = cmd.ExecuteReader()

		While dr.Read()

			Dim a = dr.GetString(0)
			_cmbMunicipality.Items.Add(a)

		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListCountry(_cmbCountry As ComboBox)

		Conn = New SqlConnection(StrConn)
		_cmbCountry.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Country]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		cmd.CommandType = CommandType.StoredProcedure
		Conn.Open()
		dr = cmd.ExecuteReader()

		While dr.Read()

			Dim a = dr.GetString(0)
			_cmbCountry.Items.Add(a)

		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub PrefixDropDownList()

		Conn = New SqlConnection(StrConn)
		frmHR_AddNewPersonnel.cbPrefix.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Prefix]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		cmd.CommandType = CommandType.StoredProcedure
		Conn.Open()
		dr = cmd.ExecuteReader()

		While dr.Read()

			Dim a = dr.GetString(0)
			frmHR_AddNewPersonnel.cbPrefix.Items.Add(a)

		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListSuffix()

		Conn = New SqlConnection(StrConn)
		frmHR_AddNewPersonnel.cbSuffix.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Suffix]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		cmd.CommandType = CommandType.StoredProcedure
		Conn.Open()
		dr = cmd.ExecuteReader()

		While dr.Read()

			Dim a = dr.GetString(0)
			frmHR_AddNewPersonnel.cbSuffix.Items.Add(a)

		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListDependentsParentSiblings(_cmbRelationship As ComboBox)

		Conn = New SqlConnection(StrConn)
		_cmbRelationship.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Dependents_ParentSiblings]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		cmd.CommandType = CommandType.StoredProcedure
		Conn.Open()
		dr = cmd.ExecuteReader()

		While dr.Read()

			Dim a = dr.GetString(0)
			_cmbRelationship.Items.Add(a)

		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListDependentsSpouse(_cmbRelationship As ComboBox)

		Conn = New SqlConnection(StrConn)
		_cmbRelationship.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Dependents_Spouse]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		cmd.CommandType = CommandType.StoredProcedure
		Conn.Open()
		dr = cmd.ExecuteReader()

		While dr.Read()

			Dim a = dr.GetString(0)
			_cmbRelationship.Items.Add(a)

		End While
		dr.Close()
		Conn.Close()

	End Sub


	Sub DropDownListEducationBackground(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_EducationBackgroundDropDownList]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()

			Dim a = dr.GetString(0)
			col.Add(a)
			cBox.Items.Add(a)

		End While
		cBox.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListEmploymentType(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_EmployeeType]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()

			Dim a = dr.GetString(0)
			col.Add(a)
			cBox.Items.Add(a)

		End While
		cBox.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListDepartment(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Department]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()

			Dim a = dr.GetString(0)
			col.Add(a)
			cBox.Items.Add(a)

		End While
		cBox.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListJobPosition(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_JobPosition]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()

			Dim a = dr.GetString(0)
			col.Add(a)
			cBox.Items.Add(a)

		End While
		cBox.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListJobClass(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_JobClass]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()

			Dim a = dr.GetString(0)
			col.Add(a)
			cBox.Items.Add(a)

		End While
		cBox.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListSupervisorEmployeeName(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_SupervisorEmployeeName]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()

			Dim a = dr.GetString(0)
			col.Add(a)
			cBox.Items.Add(a)

		End While
		cBox.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListLocation(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Location]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()

			Dim a = dr.GetString(0)
			col.Add(a)
			cBox.Items.Add(a)

		End While
		cBox.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListSignatoryEmployeeName(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Signatories]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()

			Dim a = dr.GetString(0)
			col.Add(a)
			cBox.Items.Add(a)

		End While
		cBox.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub








	Sub Ins_PersonnelTempRecord()

		' 1st Proc. : Insert temporary rows to table.
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsHRIS_Personnel_NewRecordTemp]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@CreatedBy", frmMain.ToolStripEmployeeNo.Text)
		'cmd.ExecuteNonQuery()

		''2nd Proc. : Call the 'dr = cmd.ExecuteReader' to get the Max Primary key of the table based on @@Indentity.
		dr = cmd.ExecuteReader()
		While dr.Read()
			_strPersonnelID = dr.GetInt32(0)
		End While

		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

	'Sub Sel_PersonnelID() 'removed as the select in Ins_PersonnelTempRecord will be directly assigned as ID

	'	Conn = New SqlConnection(StrConn)
	'	Conn.Open()
	'	cmd = Conn.CreateCommand
	'	cmd.CommandText = "[spSelHRIS_Personnel_ByID]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn) With {
	'					.CommandType = CommandType.StoredProcedure
	'					}

	'	_strPersonnelID = cmd.ExecuteScalar

	'	Conn.Close()
	'	cmd.Parameters.Clear()

	'End Sub

	Sub Delete_PersonnelTempRecord()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spDelHRIS_PersonnelTableTempID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strPersonnelID)
		cmd.ExecuteNonQuery()
		Conn.Close()
		cmd.Parameters.Clear()
	End Sub

	Sub Delete_ShiftTempRecord()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spDelHRIS_ShiftTableTempID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strShiftID)
		cmd.ExecuteNonQuery()
		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

	Sub Sel_Department(dgv As DataGridView, txtbox As TextBox)

		txtbox.Clear()
		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_AllDepartment]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2),
			dr.GetString(3),
			dr.GetString(4),
			dr.GetString(5),
			dr.GetString(6))

			'\\ This Function will count the Number of record retrieved.
			Call Sel_Department_CountRec()

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Sel_Department_CountRec()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_DepartmentCount]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}

		frmHR_Setup_Department.toolstriplabelNoOfRecord.Text = cmd.ExecuteScalar

		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

	Sub Sel_ShiftID()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Shift_ByID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}

		_strShiftID = cmd.ExecuteScalar

		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

	Sub Sel_ShiftAll(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Shift]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2),
			dr.GetString(3),
			dr.GetString(4),
			dr.GetString(5),
			dr.GetDecimal(6),
			dr.GetDecimal(7),
			dr.GetString(8),
			dr.GetString(9),
			 dr.GetString(10),
			dr.GetString(11),
			dr.GetString(12),
			dr.GetString(13))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Sel_LeaveType(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelLeaveType]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2),
			dr.GetString(3))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Ins_Department()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsHRIS_Department]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
				}

		cmd.Parameters.AddWithValue("@Code", frmHR_AddNewDepartment.txtCode.Text)
		cmd.Parameters.AddWithValue("@Name", frmHR_AddNewDepartment.txtDeptName.Text)
		cmd.Parameters.AddWithValue("@InCharge", frmHR_AddNewDepartment.cbInCharge.Text)
		cmd.Parameters.AddWithValue("@Hotline", frmHR_AddNewDepartment.txtHotline.Text)
		cmd.Parameters.AddWithValue("@IsOperationDept", isOperationDept)
		cmd.Parameters.AddWithValue("@IsInactive", isInactive)
		cmd.Parameters.AddWithValue("@ModifiedBy", frmMain.ToolStripEmployeeNo.Text)
		If cmd.ExecuteNonQuery = -1 Then

			'\\ This Code will Select the Data after Insert.

			Call Sel_Department(frmHR_Setup_Department.dgvDepartmentList, frmHR_Setup_Department.txtboxSearch)
			Call frmHR_AddNewDepartment.ClearField()

			'\\

		End If

		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

	Sub Ins_Shift()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsHRIS_Shift]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
				}

		cmd.Parameters.AddWithValue("@ID", _strShiftID)
		cmd.Parameters.AddWithValue("@Code", frmHR_AddNewShift.txtCode.Text)
		cmd.Parameters.AddWithValue("@Name", frmHR_AddNewShift.txtName.Text)
		cmd.Parameters.AddWithValue("@Description", frmHR_AddNewShift.txtDescriptions.Text)
		cmd.Parameters.AddWithValue("@TimeFrom", frmHR_AddNewShift.dtpNormalWorkTimeFrom.Text)
		cmd.Parameters.AddWithValue("@TimeTo", frmHR_AddNewShift.dtpNormalWorkTimeTo.Text)
		'cmd.Parameters.AddWithValue("@SlideTimeMins", frmHR_AddNewShift.txtSlideTime.Text)
		cmd.Parameters.AddWithValue("@BreakIn", frmHR_AddNewShift.dtpNormalBreakTimeFrom.Text)
		cmd.Parameters.AddWithValue("@BreakOut", frmHR_AddNewShift.dtpNormalBreakTimeTo.Text)
		cmd.Parameters.AddWithValue("@IsForceBreak", isForceBreak)
		cmd.Parameters.AddWithValue("@IsFlexi", isFlexi)
		cmd.Parameters.AddWithValue("@ModifiedBy", frmMain.ToolStripEmployeeNo.Text)

		If cmd.ExecuteNonQuery = -1 Then

			Ins_ShiftTempRecord()
			Sel_ShiftID()
			Sel_ShiftAll(frmHR_Setup_Shift.dgvAllShift)
			frmHR_AddNewShift.ClearField()

		End If

		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

	Sub Ins_ShiftTempRecord()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsHRIS_Shift_NewRecordTemp]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@CreatedBy", frmMain.ToolStripEmployeeNo.Text)
		cmd.ExecuteNonQuery()
		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

	Sub SelPopulate_EmployeeName(cmbEmployeeName As ComboBox)

		cmbEmployeeName.AutoCompleteMode = AutoCompleteMode.None
		cmbEmployeeName.AutoCompleteSource = AutoCompleteSource.CustomSource

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cmbEmployeeName.Items.Clear()
		cmd.CommandText = "[spSelHRIS_EmployeeFullName]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()
			Dim a = dr.GetString(0)
			col.Add(a)
			cmbEmployeeName.Items.Add(a)

		End While
		cmbEmployeeName.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub

	''--->>> Education Background <<<---

	Sub Preview_Personnel_EducationBackground_ByID(ByRef dataSet As DataSet)
		Using Conn As New SqlConnection(StrConn)
			Try
				Conn.Open()
				Using cmd As SqlCommand = Conn.CreateCommand()
					cmd.CommandText = "[spSelHRIS_EducationBackground_ByEmployeeID]"
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
					dataSet.Clear()
					Using adapter As New SqlDataAdapter(cmd)
						adapter.Fill(dataSet)
					End Using
				End Using
			Catch ex As Exception
				MessageBox.Show("Error retrieving data: " & ex.Message)
			End Try
		End Using
	End Sub

	Sub DisplayEducationLevel(tableIndex As Integer, dataSet As DataSet)
		If dataSet.Tables.Count > tableIndex Then
			Dim table As DataTable = dataSet.Tables(tableIndex)
			If table.Rows.Count > 0 Then
				frmHR_PreviewPersonnelDetails_EducationBackground.dgvEducationalSchool.Rows.Clear()
				For Each row As DataRow In table.Rows
					frmHR_PreviewPersonnelDetails_EducationBackground.dgvEducationalSchool.Rows.Add(
					row(0).ToString(),
					row(1).ToString(),
					row(2).ToString(),
					row(3).ToString(),
					row(4).ToString(),
					row(5).ToString())
				Next
				frmHR_PreviewPersonnelDetails_EducationBackground.dgvEducationalSchool.ClearSelection()
			End If
		Else
			MessageBox.Show("Invalid table index.")
		End If
	End Sub

	Sub SelUpd_HRIS_Personnel_EducationBackground_ByID(dgv As DataGridView)
		dgv.Rows.Clear()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelUpdHRIS_EducationBackground_ByEmployeeID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						dgv.Rows.Add(
							Convert.ToInt32(dr(0)),
							dr(1).ToString(),
							dr(2).ToString(),
							Convert.ToDateTime(dr(3)),
							Convert.ToDateTime(dr(4)),
							dr(5).ToString(),
							dr(6).ToString(),
							dr(7).ToString(),
							dr(8).ToString(),
							dr(9).ToString()
						)
					End While
				End Using
				dgv.ClearSelection()
			End Using
		End Using
	End Sub

	Sub ProcessDataGridViewEducationBackground(dataGridView As DataGridView)
		'\\ Credit by Jerome Dela Pena [2024-1435]:
		'\\ Added Try Catch to store/show errors
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spInsUpdHRIS_Personnel_EducationBackground]", Conn)
					cmd.CommandType = CommandType.StoredProcedure

					For Each row As DataGridViewRow In dataGridView.Rows
						cmd.Parameters.AddWithValue("@ID", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
						cmd.Parameters.AddWithValue("@Attainment", If(row.Cells(1).Value IsNot DBNull.Value, row.Cells(1).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@SchoolUniversity", If(row.Cells(2).Value IsNot DBNull.Value, row.Cells(2).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@EducFrom", If(row.Cells(3).Value IsNot DBNull.Value, row.Cells(3).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@EducTo", If(row.Cells(4).Value IsNot DBNull.Value, row.Cells(4).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@SchoolAddress", If(row.Cells(5).Value IsNot DBNull.Value, row.Cells(5).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@FOSDegree", If(row.Cells(6).Value IsNot DBNull.Value, row.Cells(6).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@AwardsRecogCerti", If(row.Cells(7).Value IsNot DBNull.Value, row.Cells(7).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@SchoolEmailAdr", If(row.Cells(8).Value IsNot DBNull.Value, row.Cells(8).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@SchoolTelNo", If(row.Cells(9).Value IsNot DBNull.Value, row.Cells(9).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
						cmd.ExecuteNonQuery()
						cmd.Parameters.Clear()
					Next
				End Using
			End Using
			MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
			frmHR_PreviewPersonnelDetails.btnEdit.PerformClick()
		Catch ex As Exception
			' Show error message if something goes wrong
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub Del_Personnel_EducationBackground_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list? This cannot be undone.", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_Personnel_EducationBackground]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _PersonnelEducationID1)
				cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()
				MsgBox("Deletion Success!")
			End Using
		End Using
		dgv.Rows.Remove(dgv.SelectedRows(0))
	End Sub

	''--->>> Character References <<<---

	Sub SelUpd_HRIS_Personnel_CharacterReference_ByID(dgv As DataGridView)
		dgv.Rows.Clear()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelUpdHRIS_CharacterReference_ByEmployeeID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						dgv.Rows.Add(
							Convert.ToInt32(dr(0)),
							dr(1).ToString(),
							dr(2).ToString(),
							dr(3).ToString(),
							dr(4).ToString(),
							dr(5).ToString(),
							dr(6).ToString(),
							dr(7).ToString(),
							dr(8).ToString()
						)
					End While
				End Using
				dgv.ClearSelection()
			End Using
		End Using
	End Sub

	Sub ProcessDataGridViewCharacterReference(dataGridView As DataGridView)
		'\\ Credit by Jerome Dela Pena [2024-1435]:
		'\\ Added Try Catch to store/show errors
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spInsUpdHRIS_Personnel_CharacterReference]", Conn)
					cmd.CommandType = CommandType.StoredProcedure

					For Each row As DataGridViewRow In dataGridView.Rows
						cmd.Parameters.AddWithValue("@ID", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
						cmd.Parameters.AddWithValue("@Company", If(row.Cells(1).Value IsNot DBNull.Value, row.Cells(1).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@FullName", If(row.Cells(2).Value IsNot DBNull.Value, row.Cells(2).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@JobTitle", If(row.Cells(3).Value IsNot DBNull.Value, row.Cells(3).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Department", If(row.Cells(4).Value IsNot DBNull.Value, row.Cells(4).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@MobileNumber", If(row.Cells(5).Value IsNot DBNull.Value, row.Cells(5).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@EmailAddress", If(row.Cells(6).Value IsNot DBNull.Value, row.Cells(6).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@CompanyAddress", If(row.Cells(7).Value IsNot DBNull.Value, row.Cells(7).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Relationship", If(row.Cells(8).Value IsNot DBNull.Value, row.Cells(8).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
						cmd.ExecuteNonQuery()
						cmd.Parameters.Clear()
					Next
				End Using
			End Using
			MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
			frmHR_PreviewPersonnelDetails.btnEdit.PerformClick()
		Catch ex As Exception
			' Show error message if something goes wrong
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub Del_Personnel_CharacterReference_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list? This cannot be undone.", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_Personnel_CharacterReference]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _PersonnelCharRefID1)
				cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()
				MsgBox("Deletion Success!")
			End Using
		End Using
		dgv.Rows.Remove(dgv.SelectedRows(0))
	End Sub


	''--->>> Contracts <<<---

	Sub Sel_HRIS_Personnel_ContractHistory_ByID(dgv As DataGridView) 'for preview
		dgv.Rows.Clear()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelHRIS_ContractHistory_ByEmployeeID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						dgv.Rows.Add(
							dr.GetInt32(0),
							dr.GetString(1),
							dr.GetString(2),
							dr.GetString(3),
							dr.GetString(4),
							dr.GetString(5),
							dr.GetString(6),
							dr.GetString(7),
							dr.GetString(8),
							dr.GetDecimal(9),
							dr.GetString(10),
							dr.GetString(11),
							dr.GetString(12)
						)
					End While
				End Using
				dgv.ClearSelection()
			End Using
		End Using
	End Sub

	Sub SelUpd_HRIS_Personnel_ContractHistory_ByID(dgv As DataGridView) 'for update
		dgv.Rows.Clear()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelUpdHRIS_ContractHistory_ByEmployeeID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						dgv.Rows.Add(
							dr.GetInt32(0),
							dr.GetString(1),
							dr.GetString(2),
							dr.GetString(3),
							dr.GetString(4),
							dr.GetString(5),
							dr.GetDecimal(6),
							dr.GetDecimal(7),
							dr.GetString(8),
							dr.GetString(9),
							dr.GetString(10),
							dr.GetString(11),
							dr.GetDecimal(12),
							dr.GetString(13),
							dr.GetString(14),
							dr.GetString(15),
							dr.GetString(16),
							dr.GetString(17),
							dr.GetString(18),
							dr.GetString(19))
					End While
				End Using
				dgv.ClearSelection()
			End Using
		End Using
	End Sub

	Sub ProcessDataGridViewContractHistory(dataGridView As DataGridView)
		'\\ Credit by Jerome Dela Pena [2024-1435]:
		'\\ Added Try Catch to store/show errors
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spInsUpdHRIS_Personnel_ContractHistory]", Conn)
					cmd.CommandType = CommandType.StoredProcedure

					For Each row As DataGridViewRow In dataGridView.Rows
						cmd.Parameters.AddWithValue("@ID", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
						cmd.Parameters.AddWithValue("@Type", If(row.Cells(2).Value IsNot DBNull.Value, row.Cells(2).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Department", If(row.Cells(3).Value IsNot DBNull.Value, row.Cells(3).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@StartDate", If(row.Cells(4).Value IsNot DBNull.Value, row.Cells(4).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@EndDate", If(row.Cells(5).Value IsNot DBNull.Value, row.Cells(5).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@MonthlyRate", If(IsNumeric(row.Cells(6).Value), Convert.ToDecimal(row.Cells(6).Value), DBNull.Value))
						cmd.Parameters.AddWithValue("@ProjectDiff", If(IsNumeric(row.Cells(7).Value), Convert.ToDecimal(row.Cells(7).Value), DBNull.Value))
						cmd.Parameters.AddWithValue("@JobTitle", If(row.Cells(8).Value IsNot DBNull.Value, row.Cells(8).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Class", If(row.Cells(9).Value IsNot DBNull.Value, row.Cells(9).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Supervisor", If(row.Cells(10).Value IsNot DBNull.Value, row.Cells(10).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Location", If(row.Cells(11).Value IsNot DBNull.Value, row.Cells(11).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@FieldAllowance", If(IsNumeric(row.Cells(12).Value), Convert.ToDecimal(row.Cells(12).Value), DBNull.Value))
						cmd.Parameters.AddWithValue("@ContractNotes", If(row.Cells(13).Value IsNot DBNull.Value, row.Cells(13).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@ProjectNotes", If(row.Cells(14).Value IsNot DBNull.Value, row.Cells(14).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Remarks", If(row.Cells(15).Value IsNot DBNull.Value, row.Cells(15).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Signatory1", If(row.Cells(16).Value IsNot DBNull.Value, row.Cells(16).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Signatory2", If(row.Cells(17).Value IsNot DBNull.Value, row.Cells(17).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Default", If(row.Cells(18).Value IsNot DBNull.Value, row.Cells(18).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Overtime", If(row.Cells(19).Value IsNot DBNull.Value, row.Cells(19).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
						cmd.ExecuteNonQuery()
						cmd.Parameters.Clear()
					Next

				End Using
			End Using
			MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
			frmHR_PreviewPersonnelDetails.btnEdit.PerformClick()
		Catch ex As Exception
			' Show error message if something goes wrong
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub Del_Personnel_ContractsHistory_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list? This cannot be undone.", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_Personnel_ContractHistory]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _ContractID1)
				cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()
				MsgBox("Deletion Success!")
			End Using
		End Using
		dgv.Rows.Remove(dgv.SelectedRows(0))
	End Sub






End Module
