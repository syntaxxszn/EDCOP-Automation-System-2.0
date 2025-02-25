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

	Private isEdit As Boolean = False
	Public PanelTagID As Integer = 0
	Private originalReadOnly As New Dictionary(Of TextBox, Boolean)


	Sub FunctionBtnEdit_Enable()

		isEdit = Not isEdit
		If PanelTagID = 101 Then
			For Each textBox As TextBox In frmHR_PreviewPersonnelDetails_PersonalInformation.groupboxPersonalInfo.Controls.OfType(Of TextBox)().Where(Function(t) t.Name.StartsWith("txt"))
				If isEdit Then
					' Add to dictionary only if not present
					If Not originalReadOnly.ContainsKey(textBox) Then
						originalReadOnly(textBox) = textBox.Enabled = False   ' Save original state
					End If
					textBox.ReadOnly = False
					textBox.Cursor = Cursors.IBeam
					frmHR_PreviewPersonnelDetails.btnSave.Visible = True
					frmHR_PreviewPersonnelDetails.btnDiscard.Visible = True
					Call frmHR_PreviewPersonnelDetails_PersonalInformation.function_ReadOnly_isFalse()
				Else
					' Check if it exists in the dictionary
					If originalReadOnly.ContainsKey(textBox) Then
						textBox.ReadOnly = originalReadOnly(textBox) ' Restore original state
						textBox.Cursor = Cursors.No
						Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
						Call frmHR_PreviewPersonnelDetails_PersonalInformation.Function_ReadOnly_isTrue()
					End If
				End If
			Next
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
			dr.GetString(4))
			'dr.GetString(5),
			'dr.GetString(6))

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

			_strSameAsAddressValidation = dr.GetInt32(20)

			If _strSameAsAddressValidation = 1 Then
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbPresentAdr.CheckState = CheckState.Checked
			End If
		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
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

	Sub Sel_Personnel_PersonalInformationDependentSiblings_ByEmployeeID()

		frmHR_PreviewPersonnelDetails_Dependents.dgvPrevSiblingsDetails.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelEmployeeSiblings]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			frmHR_PreviewPersonnelDetails_Dependents.dgvPrevSiblingsDetails.Rows.Add(
			dr.GetInt32(0),
			 dr.GetString(1),
			 dr.GetString(2),
			 dr.GetString(3),
			 dr.GetString(5))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

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
			dr.GetString(4))
				'dr.GetString(5)
				')

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
		cmd.Parameters.AddWithValue("@EmployeeID", _strPersonnelID)
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
			' MessageBox.Show("OK")
		Else
			MessageBox.Show("Invalid")
		End If
		Conn.Close()

	End Sub

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

			'CAll Select_ActivityDetails(FrmPMS_Individual_ViewActivity.dgvProjectTagList)
			MessageBox.Show("OK")
			Call InsUpd_PersonnelDetails_Address()
			Call FunctionBtnEdit_Enable()
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
		cmd.CommandText = "[spInsHRIS_Personnel_Identifications]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
				}

		cmd.Parameters.AddWithValue("@PersonnelID", _strPersonnelID)
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
		cmd.Parameters.AddWithValue("@CreatedBy", frmMain.ToolStripEmployeeNo.Text)
		cmd.ExecuteNonQuery()

		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

	Sub ProcessDataGridViewParentsAndSiblings(dataGridView As DataGridView)

		'\\ Credit by Jerome Dela Pena [2024-1435]  : 

		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spInsHRIS_Personnel_ParentsSiblings]", Conn)
				cmd.CommandType = CommandType.StoredProcedure

				For Each row As DataGridViewRow In dataGridView.Rows

					cmd.Parameters.AddWithValue("@EmployeeID", _strPersonnelID)
					cmd.Parameters.AddWithValue("@Relationship", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@Name", If(row.Cells(1).Value IsNot DBNull.Value, row.Cells(1).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@BirthDate", If(row.Cells(2).Value IsNot DBNull.Value, row.Cells(2).Value.ToString(), ""))
					' cmd.Parameters.AddWithValue("@Age", If(row.Cells(3).Value IsNot DBNull.Value, row.Cells(3).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@ContactNo", If(row.Cells(4).Value IsNot DBNull.Value, row.Cells(4).Value.ToString(), ""))
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
			Using cmd As New SqlCommand("[spInsHRIS_Personnel_Dependents]", Conn)
				cmd.CommandType = CommandType.StoredProcedure

				For Each row As DataGridViewRow In dataGridView.Rows

					cmd.Parameters.AddWithValue("@EmployeeID", _strPersonnelID)
					cmd.Parameters.AddWithValue("@Relationship", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@Name", If(row.Cells(1).Value IsNot DBNull.Value, row.Cells(1).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@BirthDate", If(row.Cells(2).Value IsNot DBNull.Value, row.Cells(2).Value.ToString(), ""))
					'  cmd.Parameters.AddWithValue("@Age", If(row.Cells(3).Value IsNot DBNull.Value, row.Cells(3).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@ContactNo", If(row.Cells(4).Value IsNot DBNull.Value, row.Cells(4).Value.ToString(), ""))
					cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)

					cmd.ExecuteNonQuery()
					cmd.Parameters.Clear()
				Next
			End Using
		End Using
	End Sub

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
			frmHR_AddNewPersonnel.Label7.Text = dr.GetInt32(0)
		End While

		Conn.Close()
		cmd.Parameters.Clear()

	End Sub


	Sub Sel_PersonnelID()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Personnel_ByID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}

		_strPersonnelID = cmd.ExecuteScalar

		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

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
					cmd.CommandText = "[spSelHRIS_EducationBackground_By_EmployeeID]"
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
			Else
				MessageBox.Show("No data found.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		Else
			MessageBox.Show("Invalid table index.")
		End If
	End Sub



End Module
