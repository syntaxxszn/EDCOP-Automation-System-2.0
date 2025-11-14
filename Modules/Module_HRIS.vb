Imports System.Data.SqlClient

Module Module_HRIS

	Sub FunctionBtnEdit_Enable()
		isEdit = Not isEdit
		If PanelTagID = 101 Then
			frmHR_PreviewPersonnelDetails_PersonalInformation.LinkLabelViewForeignAddress.Text = If(isEdit, "Add Address", "View Address")
			If isEdit Then

				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Show()
				Call frmHR_PreviewPersonnelDetails_PersonalInformation.function_ReadOnly_isFalse()

				frmHR_PreviewPersonnelDetails_PersonalInformation.btnAddPS.Enabled = isEdit
				frmHR_PreviewPersonnelDetails_PersonalInformation.btnAddSC.Enabled = isEdit
				frmHR_PreviewPersonnelDetails_PersonalInformation.btnRemovePS.Enabled = isEdit
				frmHR_PreviewPersonnelDetails_PersonalInformation.btnRemoveSC.Enabled = isEdit

				If frmHR_PreviewPersonnelDetails_PersonalInformation.cbPresentAdr.Checked Then
					frmHR_PreviewPersonnelDetails_PersonalInformation.SetPermanentAdrControls(Not frmHR_PreviewPersonnelDetails_PersonalInformation.cbPresentAdr.Checked)
				End If

			Else

				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
				Call frmHR_PreviewPersonnelDetails_PersonalInformation.Function_ReadOnly_isTrue()

				frmHR_PreviewPersonnelDetails_PersonalInformation.btnAddPS.Enabled = isEdit
				frmHR_PreviewPersonnelDetails_PersonalInformation.btnAddSC.Enabled = isEdit
				frmHR_PreviewPersonnelDetails_PersonalInformation.btnRemovePS.Enabled = isEdit
				frmHR_PreviewPersonnelDetails_PersonalInformation.btnRemoveSC.Enabled = isEdit

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
		ElseIf PanelTagID = 105 Then
			If isEdit Then
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_UpdatePersonnelDetails_Resume)
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Show()
			Else
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_PreviewPersonnelDetails_Resume)
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
			End If
		ElseIf PanelTagID = 108 Then
			If isEdit Then
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_UpdatePersonnelDetails_EmploymentHistory)
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Show()
			Else
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_PreviewPersonnelDetails_EmploymentHistory)
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
			End If
		ElseIf PanelTagID = 109 Then
			If isEdit Then
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_UpdatePersonnelDetails_201FileChecklist)
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Show()
			Else
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_PreviewPersonnelDetails_201FileChecklist)
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
			End If
		ElseIf PanelTagID = 110 Then
			MessageBox.Show("If you intend to make changes, head to Training Management.", "Edit Forbidden - Training History", MessageBoxButtons.OK, MessageBoxIcon.Error)
			isEdit = False
			Return
		ElseIf PanelTagID = 111 Then
			If isEdit Then
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_UpdatePersonnelDetails_PerformanceAppraisal)
				Call frmHR_PreviewPersonnelDetails.Function_btnUpdates_Show()
			Else
				Call frmHR_PreviewPersonnelDetails.switchPanel(frmHR_PreviewPersonnelDetails_PerformanceAppraisal)
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
			dr.GetString(6),
			dr.GetString(7),
			dr.GetString(8),
			dr.GetString(9))
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
		Try
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
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbBirthPlaceRegion.Text = dr.GetString(5)
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbGender.Text = dr.GetString(6)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtHeight.Text = dr.GetString(7)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtWeight.Text = dr.GetString(8)
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbCitizenship.Text = dr.GetString(9)
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbCivilStatus.Text = dr.GetString(10)
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbReligion.Text = dr.GetString(11)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtEmailAddress.Text = dr.GetString(12)

				frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrStreet1.Text = dr.GetString(13)
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrBarangay1.Text = dr.GetString(14)
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
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrBarangay2.Text = dr.GetString(24)
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

				frmHR_PreviewPersonnelDetails_PersonalInformation.txtTelephone.Text = dr.GetString(41)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtMobileNumber.Text = dr.GetString(42)

				frmHR_PreviewPersonnelDetails_PersonalInformation.cbBirthPlaceProvince.Text = dr.GetString(43)
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbBirthPlaceCity.Text = dr.GetString(44)

				frmHR_PreviewPersonnelDetails_PersonalInformation.cbBank.Text = dr.GetString(45)
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbPayrollCategory.Text = dr.GetString(46)

				frmHR_PreviewPersonnelDetails_PersonalInformation.txtECFullName1.Text = dr.GetString(47)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtECEmailAddress1.Text = dr.GetString(48)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtECMobileNo1.Text = dr.GetString(49)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtECFullName2.Text = dr.GetString(50)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtECEmailAddress2.Text = dr.GetString(51)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtECMobileNo2.Text = dr.GetString(52)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtECFullName3.Text = dr.GetString(53)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtECEmailAddress3.Text = dr.GetString(54)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtECMobileNo3.Text = dr.GetString(55)
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbMedicalCategory.Text = dr.GetString(56)
				frmHR_PreviewPersonnelDetails_PersonalInformation.cbMedicalCondition.Text = dr.GetString(57)
				frmHR_PreviewPersonnelDetails_PersonalInformation.chEnvironmentalAllergy.Checked = dr.GetBoolean(58)
				frmHR_PreviewPersonnelDetails_PersonalInformation.chFoodAllergy.Checked = dr.GetBoolean(59)
				frmHR_PreviewPersonnelDetails_PersonalInformation.chDrugAllergy.Checked = dr.GetBoolean(60)
				frmHR_PreviewPersonnelDetails_PersonalInformation.chInsectAllergy.Checked = dr.GetBoolean(61)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtECAllergy.Text = dr.GetString(62)
				frmHR_PreviewPersonnelDetails_PersonalInformation.txtECMedicalNotes.Text = dr.GetString(63)

			End While

		Catch ex As Exception
			MessageBox.Show("Error Occured : " & ex.Message, "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			dr.Close()
			Conn.Close()
			cmd.Parameters.Clear()
		End Try

	End Sub

	Sub BrowseProfilePic(_profilePicImage As PictureBox)
		Dim basePath As String = "\\192.168.0.250\references\DIMS_APPS_INST\Images Profile\"
		Using ofd As New OpenFileDialog With {.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*"}
			If ofd.ShowDialog() = DialogResult.OK Then
				Dim fileInfo As New IO.FileInfo(ofd.FileName)

				' Limit to 2MB (2 * 1024 * 1024 bytes)
				If fileInfo.Length > 2 * 1024 * 1024 Then
					MessageBox.Show("Sorry, file size must be less than 2MB.", "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If

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

				Try
					Call Ins_Personnel_ProfilePic()
				Catch ex As Exception
					MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Using
	End Sub

	Sub GetImageProfile(_profilePicImage As PictureBox)
		If System.IO.File.Exists(FilePath) Then
			_profilePicImage.SizeMode = PictureBoxSizeMode.StretchImage
			_profilePicImage.Image = Image.FromFile(FilePath)
		Else
			_profilePicImage.SizeMode = PictureBoxSizeMode.StretchImage
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


	Sub Family_Background_Relationship_DropDownList(cBox1 As ComboBox, cBox2 As ComboBox)
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_FamilyRelationshipDropDownList]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
		.CommandType = CommandType.StoredProcedure
	}
		cBox1.Items.Clear()
		cBox2.Items.Clear()

		Dim DependentsDictionaryPS As New Dictionary(Of String, Integer)()
		Dim DependentsDictionarySC As New Dictionary(Of String, Integer)()

		Using reader As SqlDataReader = cmd.ExecuteReader()
			While reader.Read()
				Dim id As Integer = reader.GetInt32(0)
				Dim dependents As String = reader.GetString(1)
				If id >= 718 AndAlso id <= 723 Then
					cBox1.Items.Add(dependents)
					DependentsDictionaryPS.Add(dependents, id)
				End If
				If id >= 724 AndAlso id <= 726 Then
					cBox2.Items.Add(dependents)
					DependentsDictionarySC.Add(dependents, id)
				End If
			End While
		End Using
		cBox1.Tag = DependentsDictionaryPS
		cBox2.Tag = DependentsDictionarySC
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

	Sub Search_DGVPersonnel(_dgvPersonnelList As DataGridView, _txtBoxItemName As TextBox, stat As Boolean)

		_dgvPersonnelList.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Personnel_Search]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@PersonnelSearch", _txtBoxItemName.Text)
		cmd.Parameters.AddWithValue("@Status", stat)

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
			dr.GetString(6),
			dr.GetString(7),
			dr.GetString(8),
			dr.GetString(9))

			End While

		Else

			MessageBox.Show("Record not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

		End If

		dr.Dispose()
		Conn.Dispose()

		_dgvPersonnelList.ClearSelection()

	End Sub

	Sub Search_DGVPersonnel_by_Filter(_dgvPersonnelList As DataGridView)

		_dgvPersonnelList.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Personnel_Search_by_Filter]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}

		cmd.Parameters.AddWithValue("@Status", frmHRIS_Transaction_SearchFilter.EmployeeStatusID)
		cmd.Parameters.AddWithValue("@isEmployee", frmHRIS_Transaction_SearchFilter.isEmployeeID)
		cmd.Parameters.AddWithValue("@isTechnical", frmHRIS_Transaction_SearchFilter.isTechnicalID)

		Dim table1 As New DataTable()
		table1.Columns.Add("ID", GetType(Integer))
		frmHRIS_Transaction_SearchFilter.EmployeeSubStatus1ID.ForEach(Sub(id) table1.Rows.Add(id))
		cmd.Parameters.AddWithValue("@EmpSubStatusID1s", table1).SqlDbType = SqlDbType.Structured
		cmd.Parameters("@EmpSubStatusID1s").TypeName = "dbo.IntList"

		Dim table2 As New DataTable()
		table2.Columns.Add("ID", GetType(Integer))
		frmHRIS_Transaction_SearchFilter.EmployeeSubStatus2ID.ForEach(Sub(id) table2.Rows.Add(id))
		cmd.Parameters.AddWithValue("@EmpSubStatusID2s", table2).SqlDbType = SqlDbType.Structured
		cmd.Parameters("@EmpSubStatusID2s").TypeName = "dbo.IntList"

		Dim table3 As New DataTable()
		table3.Columns.Add("ID", GetType(Integer))
		frmHRIS_Transaction_SearchFilter.EmployeeClassGroupID.ForEach(Sub(id) table3.Rows.Add(id))
		cmd.Parameters.AddWithValue("@JobClassGroupIDs", table3).SqlDbType = SqlDbType.Structured
		cmd.Parameters("@JobClassGroupIDs").TypeName = "dbo.IntList"

		Dim table4 As New DataTable()
		table4.Columns.Add("String", GetType(String))
		frmHRIS_Transaction_SearchFilter.EmployeeJobPositionCombinedString.ForEach(Sub(item) table4.Rows.Add(item))
		cmd.Parameters.AddWithValue("@JobPositionStrings", table4).SqlDbType = SqlDbType.Structured
		cmd.Parameters("@JobPositionStrings").TypeName = "dbo.StringList"

		Dim table5 As New DataTable()
		table5.Columns.Add("ID", GetType(Integer))
		frmHRIS_Transaction_SearchFilter.EmployeeDepartmentID.ForEach(Sub(id) table5.Rows.Add(id))
		cmd.Parameters.AddWithValue("@DepartmentIDs", table5).SqlDbType = SqlDbType.Structured
		cmd.Parameters("@DepartmentIDs").TypeName = "dbo.IntList"

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
			dr.GetString(6),
			dr.GetString(7),
			dr.GetString(8),
			dr.GetString(9)
				)

			End While

			frmHRIS_Transaction_SearchFilter.Hide()

		Else

			MessageBox.Show("Sorry, no matching records found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

		End If

		dr.Dispose()
		Conn.Dispose()
		cmd.Parameters.Clear()
		_dgvPersonnelList.ClearSelection()
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

	'Sub Ins_Personnel_Resume()

	'	Conn = New SqlConnection(StrConn)
	'	Conn.Open()
	'	cmd = Conn.CreateCommand
	'	cmd.CommandText = "[spInsHRIS_Personnel_Resume]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn) With {
	'				.CommandType = CommandType.StoredProcedure
	'			}
	'	cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
	'	cmd.Parameters.AddWithValue("@CreatedBy", frmMain.ToolStripEmployeeNo.Text)
	'	cmd.Parameters.AddWithValue("@FilePath", FilePath)
	'	cmd.ExecuteNonQuery()
	'	Conn.Close()

	'End Sub

	Sub ProcessDataGridViewResume(dataGridView As DataGridView)

		'\\ Credit by Jerome Dela Pena [2024-1435]  : 
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()

				Using cmd As New SqlCommand("[spInsHRIS_Personnel_Resume]", Conn)
					cmd.CommandType = CommandType.StoredProcedure

					For Each row As DataGridViewRow In dataGridView.Rows

						cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
						cmd.Parameters.AddWithValue("@ID", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@FilePath", If(row.Cells(2).Value IsNot DBNull.Value, row.Cells(2).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)

						cmd.ExecuteNonQuery()
						cmd.Parameters.Clear()
					Next
				End Using
				MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
				frmHR_PreviewPersonnelDetails.btnEdit.PerformClick()
			End Using
		Catch ex As Exception
			' Show error message if something goes wrong
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub Ins_PersonnelDetails()

		Conn = New SqlConnection(StrConn)
		cmd = New SqlCommand("[spInsHRIS_Personnel_NewRecord]", Conn) With {
		.CommandType = CommandType.StoredProcedure
		}

		cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@Code", frmHR_AddNewPersonnel.txtCode.Text)
		cmd.Parameters.AddWithValue("@Pronouns", frmHR_AddNewPersonnel.cbPronouns.Text)
		cmd.Parameters.AddWithValue("@Prefix", frmHR_AddNewPersonnel.cbPrefix.Text)
		cmd.Parameters.AddWithValue("@LastName", frmHR_AddNewPersonnel.txtLastName.Text)
		cmd.Parameters.AddWithValue("@FirstName", frmHR_AddNewPersonnel.txtFirstName.Text)
		cmd.Parameters.AddWithValue("@MiddleName", frmHR_AddNewPersonnel.txtMiddleName.Text)
		cmd.Parameters.AddWithValue("@Suffix", frmHR_AddNewPersonnel.cbSuffix.Text)

		cmd.Parameters.AddWithValue("@BirthDate", frmHR_AddNewPersonnel.dtpDateofBirth.Text)

		'cmd.Parameters.AddWithValue("@Age", frmHR_AddNewPersonnel.txtAge.Text)
		'cmd.Parameters.AddWithValue("@BirthPlaceCity", frmHR_AddNewPersonnel.cbBirthPlaceCity.Text)
		'cmd.Parameters.AddWithValue("@BirthPlaceRegion", frmHR_AddNewPersonnel.cbBirthPlaceProvince.Text)

		cmd.Parameters.AddWithValue("@Gender", frmHR_AddNewPersonnel.cbGender.Text)
		cmd.Parameters.AddWithValue("@Height", frmHR_AddNewPersonnel.txtHeight.Text)
		cmd.Parameters.AddWithValue("@Weight", frmHR_AddNewPersonnel.txtWeight.Text)

		cmd.Parameters.AddWithValue("@Citizenship", frmHR_AddNewPersonnel.cbCitizenship.Text)
		cmd.Parameters.AddWithValue("@Religion", frmHR_AddNewPersonnel.cbReligion.Text)
		cmd.Parameters.AddWithValue("@CivilStatus", frmHR_AddNewPersonnel.cbCivilStatus.Text)

		cmd.Parameters.AddWithValue("@TelNo", frmHR_AddNewPersonnel.txtTelephone.Text)
		cmd.Parameters.AddWithValue("@CellPhoneNo", frmHR_AddNewPersonnel.txtMobileNumber.Text)
		cmd.Parameters.AddWithValue("@EmailAddress", frmHR_AddNewPersonnel.txtEmailAddress.Text)

		'cmd.Parameters.AddWithValue("@TaxCode", frmHR_AddNewPersonnel.cbTaxCode.Text)

		cmd.Parameters.AddWithValue("@PayrollCategory", frmHR_AddNewPersonnel.cbPayrollCategory.Text)
		cmd.Parameters.AddWithValue("@PayrollAccountNo", frmHR_AddNewPersonnel.txtboxPayrollAccountNo.Text)
		cmd.Parameters.AddWithValue("@BankName", frmHR_AddNewPersonnel.cbBank.Text)

		cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

		Dim returnParam As New SqlParameter("@ReturnTempID", SqlDbType.Int)
		returnParam.Direction = ParameterDirection.Output
		cmd.Parameters.Add(returnParam)

		Try

			Conn.Open()
			cmd.ExecuteNonQuery()
			_strEmployeeID = If(IsDBNull(returnParam.Value), 0, Convert.ToInt32(returnParam.Value))

			If _strEmployeeID > 0 Then
				'MessageBox.Show("Saved.")

				frmHR_AddNewPersonnel.Close()
				Call frmHRIS_Transaction_EmployeeFile.WhatToSearch()

			End If

		Finally

			Conn.Close()
			cmd.Parameters.Clear()

		End Try

	End Sub

	Sub Ins_Personnel_AddressDetails()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsHRIS_Personnel_AddressDetails]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
				}

		cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)

		cmd.Parameters.AddWithValue("@BirthPlaceCity", frmHR_AddNewPersonnel.cbBirthPlaceCity.Text)
		cmd.Parameters.AddWithValue("@BirthPlaceProvince", frmHR_AddNewPersonnel.cbBirthPlaceProvince.Text)
		cmd.Parameters.AddWithValue("@BirthPlaceRegion", frmHR_AddNewPersonnel.cbBirthPlaceRegion.Text)

		cmd.Parameters.AddWithValue("@StreetAdd1", frmHR_AddNewPersonnel.txtAdrStreet1.Text)
		cmd.Parameters.AddWithValue("@BrgyAdd1", frmHR_AddNewPersonnel.cbAdrBarangay1.Text)
		cmd.Parameters.AddWithValue("@MunicipalityName1", frmHR_AddNewPersonnel.cbAdrCity1.Text)
		cmd.Parameters.AddWithValue("@ProvinceName1", frmHR_AddNewPersonnel.cbAdrProvince1.Text)
		cmd.Parameters.AddWithValue("@RegionName1", frmHR_AddNewPersonnel.cbAdrRegion1.Text)
		cmd.Parameters.AddWithValue("@Country1", frmHR_AddNewPersonnel.txtAdrCountry1.Text)
		cmd.Parameters.AddWithValue("@PostalCode1", frmHR_AddNewPersonnel.txtAdrZip1.Text)

		cmd.Parameters.AddWithValue("@SameAsPresentAdd", _strSameAsAddressValidation)

		cmd.Parameters.AddWithValue("@StreetAdd2", frmHR_AddNewPersonnel.txtAdrStreet2.Text)
		cmd.Parameters.AddWithValue("@BrgyAdd2", frmHR_AddNewPersonnel.cbAdrBarangay2.Text)
		cmd.Parameters.AddWithValue("@MunicipalityName2", frmHR_AddNewPersonnel.cbAdrCity2.Text)
		cmd.Parameters.AddWithValue("@ProvinceName2", frmHR_AddNewPersonnel.cbAdrProvince2.Text)
		cmd.Parameters.AddWithValue("@RegionName2", frmHR_AddNewPersonnel.cbAdrRegion2.Text)
		cmd.Parameters.AddWithValue("@Country2", frmHR_AddNewPersonnel.txtAdrCountry2.Text)
		cmd.Parameters.AddWithValue("@PostalCode2", frmHR_AddNewPersonnel.txtAdrZip2.Text)
		cmd.Parameters.AddWithValue("@ModifiedBy", frmMain.ToolStripEmployeeNo.Text)

		cmd.ExecuteNonQuery()

		Conn.Close()
		cmd.Parameters.Clear()
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

	Sub Sel_PersonnelCode_ifNonExistence(txt As TextBox)

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Personnel_CodeIfExistence]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@txt", txt.Text)

		frmHR_AddNewPersonnel.isExist = cmd.ExecuteScalar

		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

	Sub Ins_EmergencyContact()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsUpdHRIS_Personnel_EmergencyContact]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}

		cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@Person1", frmHR_AddNewPersonnel.txtECFullName1.Text)
		cmd.Parameters.AddWithValue("@EmailAddress1", frmHR_AddNewPersonnel.txtECEmailAddress1.Text)
		cmd.Parameters.AddWithValue("@MobileNo1", frmHR_AddNewPersonnel.txtECMobileNo1.Text)
		cmd.Parameters.AddWithValue("@Person2", frmHR_AddNewPersonnel.txtECFullName2.Text)
		cmd.Parameters.AddWithValue("@EmailAddress2", frmHR_AddNewPersonnel.txtECEmailAddress2.Text)
		cmd.Parameters.AddWithValue("@MobileNo2", frmHR_AddNewPersonnel.txtECMobileNo2.Text)
		cmd.Parameters.AddWithValue("@Person3", frmHR_AddNewPersonnel.txtECFullName3.Text)
		cmd.Parameters.AddWithValue("@EmailAddress3", frmHR_AddNewPersonnel.txtECEmailAddress3.Text)
		cmd.Parameters.AddWithValue("@MobileNo3", frmHR_AddNewPersonnel.txtECMobileNo3.Text)
		cmd.Parameters.AddWithValue("@MedicalCondition", frmHR_AddNewPersonnel.cbMedicalCondition.Text)
		cmd.Parameters.AddWithValue("@EA", frmHR_AddNewPersonnel.chEnvironmentalAllergy.Checked)
		cmd.Parameters.AddWithValue("@FA", frmHR_AddNewPersonnel.chFoodAllergy.Checked)
		cmd.Parameters.AddWithValue("@DA", frmHR_AddNewPersonnel.chDrugAllergy.Checked)
		cmd.Parameters.AddWithValue("@IA", frmHR_AddNewPersonnel.chInsectAllergy.Checked)
		cmd.Parameters.AddWithValue("@SpecifiedAllergy", frmHR_AddNewPersonnel.txtECAllergy.Text)
		cmd.Parameters.AddWithValue("@MedicalNotes", frmHR_AddNewPersonnel.txtECMedicalNotes.Text)
		cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

		cmd.ExecuteNonQuery()
		Conn.Close()
		cmd.Parameters.Clear()
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
		'cmd.Parameters.AddWithValue("@BirthPlace", frmHR_PreviewPersonnelDetails_PersonalInformation.cbBirthPlaceProvince.Text)
		cmd.Parameters.AddWithValue("@Gender", frmHR_PreviewPersonnelDetails_PersonalInformation.cbGender.Text)
		cmd.Parameters.AddWithValue("@Height", frmHR_PreviewPersonnelDetails_PersonalInformation.txtHeight.Text)
		cmd.Parameters.AddWithValue("@Weight", frmHR_PreviewPersonnelDetails_PersonalInformation.txtWeight.Text)
		cmd.Parameters.AddWithValue("@Citizenship", frmHR_PreviewPersonnelDetails_PersonalInformation.cbCitizenship.Text)
		cmd.Parameters.AddWithValue("@CivilStatus", frmHR_PreviewPersonnelDetails_PersonalInformation.cbCivilStatus.Text)
		cmd.Parameters.AddWithValue("@Religion", frmHR_PreviewPersonnelDetails_PersonalInformation.cbReligion.Text)
		cmd.Parameters.AddWithValue("@TelNo", frmHR_PreviewPersonnelDetails_PersonalInformation.txtTelephone.Text)
		cmd.Parameters.AddWithValue("@CellphoneNo", frmHR_PreviewPersonnelDetails_PersonalInformation.txtMobileNumber.Text)
		cmd.Parameters.AddWithValue("@EmailAddress", frmHR_PreviewPersonnelDetails_PersonalInformation.txtEmailAddress.Text)

		cmd.Parameters.AddWithValue("@Bank", frmHR_PreviewPersonnelDetails_PersonalInformation.cbBank.Text)
		cmd.Parameters.AddWithValue("@PayrollAccountNo", frmHR_PreviewPersonnelDetails_PersonalInformation.txtboxPayrollAccountNo.Text)
		cmd.Parameters.AddWithValue("@PayrollCategory", frmHR_PreviewPersonnelDetails_PersonalInformation.cbPayrollCategory.Text)

		'cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)

		If cmd.ExecuteNonQuery = -1 Then
			'MessageBox.Show("Saved.")
			frmHR_PreviewPersonnelDetails.btnEdit.PerformClick()
			'If frmHRIS_Transaction_EmployeeFile.txtboxSearch.Text <> "" Then
			'	Call Search_DGVPersonnel(frmHRIS_Transaction_EmployeeFile.dgvEmployeeList, frmHRIS_Transaction_EmployeeFile.txtboxSearch, False)
			'Else
			'	Call frmHRIS_Transaction_EmployeeFile.EmployeeList_Active()
			'End If
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

		cmd.Parameters.AddWithValue("@BirthPlaceRegion", frmHR_PreviewPersonnelDetails_PersonalInformation.cbBirthPlaceRegion.Text)
		cmd.Parameters.AddWithValue("@BirthPlaceProvince", frmHR_PreviewPersonnelDetails_PersonalInformation.cbBirthPlaceProvince.Text)
		cmd.Parameters.AddWithValue("@BirthPlaceCity", frmHR_PreviewPersonnelDetails_PersonalInformation.cbBirthPlaceCity.Text)

		cmd.Parameters.AddWithValue("@StreetAdd1", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrStreet1.Text)
		cmd.Parameters.AddWithValue("@BrgyAdd1", frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrBarangay1.Text)
		cmd.Parameters.AddWithValue("@MunicipalityName1", frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrCity1.Text)
		cmd.Parameters.AddWithValue("@ProvinceName1", frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrProvince1.Text)
		cmd.Parameters.AddWithValue("@RegionName1", frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrRegion1.Text)
		cmd.Parameters.AddWithValue("@PostalCode1", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrZip1.Text)
		cmd.Parameters.AddWithValue("@Country1", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrCountry1.Text)

		cmd.Parameters.AddWithValue("@SameAsPresentAdd", _strSameAsAddressValidation)

		cmd.Parameters.AddWithValue("@StreetAdd2", frmHR_PreviewPersonnelDetails_PersonalInformation.txtAdrStreet2.Text)
		cmd.Parameters.AddWithValue("@BrgyAdd2", frmHR_PreviewPersonnelDetails_PersonalInformation.cbAdrBarangay2.Text)
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

	Sub InsUpd_EmergencyContact()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsUpdHRIS_Personnel_EmergencyContact]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}

		cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@Person1", frmHR_PreviewPersonnelDetails_PersonalInformation.txtECFullName1.Text)
		cmd.Parameters.AddWithValue("@EmailAddress1", frmHR_PreviewPersonnelDetails_PersonalInformation.txtECEmailAddress1.Text)
		cmd.Parameters.AddWithValue("@MobileNo1", frmHR_PreviewPersonnelDetails_PersonalInformation.txtECMobileNo1.Text)
		cmd.Parameters.AddWithValue("@Person2", frmHR_PreviewPersonnelDetails_PersonalInformation.txtECFullName2.Text)
		cmd.Parameters.AddWithValue("@EmailAddress2", frmHR_PreviewPersonnelDetails_PersonalInformation.txtECEmailAddress2.Text)
		cmd.Parameters.AddWithValue("@MobileNo2", frmHR_PreviewPersonnelDetails_PersonalInformation.txtECMobileNo2.Text)
		cmd.Parameters.AddWithValue("@Person3", frmHR_PreviewPersonnelDetails_PersonalInformation.txtECFullName3.Text)
		cmd.Parameters.AddWithValue("@EmailAddress3", frmHR_PreviewPersonnelDetails_PersonalInformation.txtECEmailAddress3.Text)
		cmd.Parameters.AddWithValue("@MobileNo3", frmHR_PreviewPersonnelDetails_PersonalInformation.txtECMobileNo3.Text)
		cmd.Parameters.AddWithValue("@MedicalCondition", frmHR_PreviewPersonnelDetails_PersonalInformation.cbMedicalCondition.Text)
		cmd.Parameters.AddWithValue("@EA", frmHR_PreviewPersonnelDetails_PersonalInformation.chEnvironmentalAllergy.Checked)
		cmd.Parameters.AddWithValue("@FA", frmHR_PreviewPersonnelDetails_PersonalInformation.chFoodAllergy.Checked)
		cmd.Parameters.AddWithValue("@DA", frmHR_PreviewPersonnelDetails_PersonalInformation.chDrugAllergy.Checked)
		cmd.Parameters.AddWithValue("@IA", frmHR_PreviewPersonnelDetails_PersonalInformation.chInsectAllergy.Checked)
		cmd.Parameters.AddWithValue("@SpecifiedAllergy", frmHR_PreviewPersonnelDetails_PersonalInformation.txtECAllergy.Text)
		cmd.Parameters.AddWithValue("@MedicalNotes", frmHR_PreviewPersonnelDetails_PersonalInformation.txtECMedicalNotes.Text)
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

	'Sub DropDownListTaxCode()

	'	frmHR_AddNewPersonnel.cbTaxCode.Items.Clear()
	'	Conn = New SqlConnection(StrConn)
	'	cmd.CommandText = "[spSelHRIS_TaxCode]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn)
	'	Conn.Open()
	'	dr = cmd.ExecuteReader()
	'	While dr.Read()
	'		Dim a = dr.GetString(0)
	'		frmHR_AddNewPersonnel.cbTaxCode.Items.Add(a)
	'	End While
	'	dr.Close()
	'	Conn.Close()

	'End Sub

	Sub DropDownListBank(cb As ComboBox)

		cb.Items.Clear()
		Conn = New SqlConnection(StrConn)
		cmd.CommandText = "[spSelHRIS_Bank]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()
			Dim a = dr.GetString(0)
			cb.Items.Add(a)
		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListPayrollCategory(cbox As ComboBox)

		cbox.Items.Clear()
		Conn = New SqlConnection(StrConn)
		cmd.CommandText = "[spSelHRIS_PayrollCategory]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()
			Dim a = dr.GetString(0)
			cbox.Items.Add(a)
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

	Sub DropDownListBarangay(_cmbMunicipality As ComboBox, _cmbBarangay As ComboBox)

		Conn = New SqlConnection(StrConn)
		_cmbBarangay.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Barangay]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		cmd.CommandType = CommandType.StoredProcedure
		Conn.Open()
		cmd.Parameters.AddWithValue("@CityName", _cmbMunicipality.Text)
		dr = cmd.ExecuteReader()

		While dr.Read()

			Dim a = dr.GetString(0)
			_cmbBarangay.Items.Add(a)

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

	Sub DropDownListMedicalCategory(cb As ComboBox)

		cb.Items.Clear()
		Conn = New SqlConnection(StrConn)
		cmd.CommandText = "[spSelHRIS_MedicalCategory]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		Conn.Open()
		dr = cmd.ExecuteReader()
		While dr.Read()
			Dim a = dr.GetString(0)
			cb.Items.Add(a)
		End While
		dr.Close()
		Conn.Close()

	End Sub

	Sub DropDownListMedicalCondition(cb As ComboBox, cb1 As ComboBox)

		Conn = New SqlConnection(StrConn)
		cb.Items.Clear()
		cmd.CommandText = "[spSelHRIS_MedicalCondition]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		cmd.CommandType = CommandType.StoredProcedure
		Conn.Open()
		cmd.Parameters.AddWithValue("@Category", cb1.Text)
		dr = cmd.ExecuteReader()

		While dr.Read()

			Dim a = dr.GetString(0)
			cb.Items.Add(a)

		End While
		dr.Close()
		Conn.Close()

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

	Sub DropDownListParentDepartment(cbBox As ComboBox)

		Conn = New SqlConnection(StrConn)
		cbBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_ParentDepartment]"
		cmd = New SqlCommand(cmd.CommandText, Conn)
		cmd.CommandType = CommandType.StoredProcedure
		Conn.Open()
		dr = cmd.ExecuteReader()

		While dr.Read()

			Dim a = dr.GetString(0)
			cbBox.Items.Add(a)

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

	Sub DropDownListIndustryType(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_IndustryType]"
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

	Sub DropDownListOrganizationType(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_OrganizationType]"
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

	Sub DropDownListIndustrySpecialization(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_IndustrySpecialization]"
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

	Sub DropDownListSeparationType(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_SeparationType]"
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

	Sub DropDownListJobPosition2(cBox As ComboBox)

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_JobPositionWithID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
			 .CommandType = CommandType.StoredProcedure
		 }

		cBox.Items.Clear()
		Dim itemDictionary As New Dictionary(Of String, Integer)()

		Using reader As SqlDataReader = cmd.ExecuteReader()
			While reader.Read()
				Dim id As Integer = reader.GetInt32(0)
				Dim item As String = reader.GetString(1)

				itemDictionary.Add(item, id)
				cBox.Items.Add(item)
			End While
		End Using
		cBox.Tag = itemDictionary
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

	Sub DropDownListJobClassLevel(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_JobClassLevel]"
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

	Sub DropDownListJobClusterGroup(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_JobClusterGroup]"
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

	Sub DropDownListSupervisorEmployeeName2(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_SupervisorEmployeeName2]"
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

	Sub DropDownListSupervisorEmployeeName3(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_SupervisorEmployeeName3]"
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

	Sub DropDownListShiftType(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_ActiveShiftType]"
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

	Sub DropDownListShiftEffectivityByShiftTypeID(cBox0 As ComboBox, cBox1 As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox0.Items.Clear()
		Dim cmd As New SqlCommand("[spSelHRIS_ActiveShiftEffectivityByID]", Conn)
		cmd.CommandType = CommandType.StoredProcedure
		cmd.Parameters.AddWithValue("@ShiftType", cBox1.Text)
		Conn.Open()
		dr = cmd.ExecuteReader()

		While dr.Read()
			Dim a = dr.GetString(0)
			col.Add(a)
			cBox0.Items.Add(a)
		End While

		cBox0.AutoCompleteCustomSource = col
		dr.Close()
		Conn.Close()

	End Sub


	Sub TrainingCategoryDropDownList(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_TrainingCategory]"
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

	Sub TrainingNatureDropDownList(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_TrainingNature]"
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

	Sub TrainingStatusDropDownList(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_TrainingStatus]"
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

	Sub TrainingStatusDropDownList2(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_TrainingStatus2]"
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

	Sub TimeFrameDropDownList(cBox As ComboBox)

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_Training_MngrTimeFrame]"
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

	Sub SelPopulate_ProjectList(cBox As ComboBox)

		cBox.AutoCompleteMode = AutoCompleteMode.None
		cBox.AutoCompleteSource = AutoCompleteSource.CustomSource

		Dim col As New AutoCompleteStringCollection()
		Conn = New SqlConnection(StrConn)
		cBox.Items.Clear()
		cmd.CommandText = "[spSelHRIS_PMAS_ProjectList]"
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

	Sub SelPopulate_ActivePart1Form1AList(cBox As ComboBox, idx As Integer)

		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelHRIS_PMAS_ActivePart1Form1AList]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", idx)
				cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
				cBox.Items.Clear()
				Dim idDictionary As New Dictionary(Of String, Integer)()
				Using reader As SqlDataReader = cmd.ExecuteReader()
					While reader.Read()
						Dim id As Integer = reader.GetInt32(0)
						Dim val As String = reader.GetString(1)
						idDictionary.Add(val, id)
						cBox.Items.Add(val)
					End While
				End Using
				cBox.Tag = idDictionary
			End Using
		End Using

	End Sub

	Sub SelPopulate_ActivePart1Form1BList(cBox As ComboBox, idx As Integer)

		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelHRIS_PMAS_ActivePart1Form1BList]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", idx)
				cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
				cBox.Items.Clear()
				Dim idDictionary As New Dictionary(Of String, Integer)()
				Using reader As SqlDataReader = cmd.ExecuteReader()
					While reader.Read()
						Dim id As Integer = reader.GetInt32(0)
						Dim val As String = reader.GetString(1)
						idDictionary.Add(val, id)
						cBox.Items.Add(val)
					End While
				End Using
				cBox.Tag = idDictionary
			End Using
		End Using

	End Sub

	Sub SelPopulate_ActivePart1Form1CList(cBox As ComboBox, idx As Integer)

		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelHRIS_PMAS_ActivePart1Form1CList]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", idx)
				cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
				cBox.Items.Clear()
				Dim idDictionary As New Dictionary(Of String, Integer)()
				Using reader As SqlDataReader = cmd.ExecuteReader()
					While reader.Read()
						Dim id As Integer = reader.GetInt32(0)
						Dim val As String = reader.GetString(1)
						idDictionary.Add(val, id)
						cBox.Items.Add(val)
					End While
				End Using
				cBox.Tag = idDictionary
			End Using
		End Using

	End Sub


	'Sub Ins_PersonnelTempRecord()

	'	' 1st Proc. : Insert temporary rows to table.
	'	Conn = New SqlConnection(StrConn)
	'	Conn.Open()
	'	cmd = Conn.CreateCommand
	'	cmd.CommandText = "[spInsHRIS_Personnel_NewRecordTemp]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn) With {
	'					.CommandType = CommandType.StoredProcedure
	'					}
	'	cmd.Parameters.AddWithValue("@CreatedBy", frmMain.ToolStripEmployeeNo.Text)
	'	'cmd.ExecuteNonQuery()

	'	''2nd Proc. : Call the 'dr = cmd.ExecuteReader' to get the Max Primary key of the table based on @@Indentity.
	'	dr = cmd.ExecuteReader()
	'	While dr.Read()
	'		_strPersonnelID = dr.GetInt32(0)
	'	End While

	'	Conn.Close()
	'	cmd.Parameters.Clear()

	'End Sub

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

	'Sub Delete_PersonnelTempRecord()

	'	Conn = New SqlConnection(StrConn)
	'	Conn.Open()
	'	cmd = Conn.CreateCommand
	'	cmd.CommandText = "[spDelHRIS_PersonnelTableTempID]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn) With {
	'					.CommandType = CommandType.StoredProcedure
	'					}
	'	cmd.Parameters.AddWithValue("@ID", _strPersonnelID)
	'	cmd.ExecuteNonQuery()
	'	Conn.Close()
	'	cmd.Parameters.Clear()
	'End Sub

	'Sub Delete_ShiftTempRecord()

	'	Conn = New SqlConnection(StrConn)
	'	Conn.Open()
	'	cmd = Conn.CreateCommand
	'	cmd.CommandText = "[spDelHRIS_ShiftTableTempID]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn) With {
	'					.CommandType = CommandType.StoredProcedure
	'					}
	'	cmd.Parameters.AddWithValue("@ID", _strShiftID)
	'	cmd.ExecuteNonQuery()
	'	Conn.Close()
	'	cmd.Parameters.Clear()

	'End Sub

	Sub Sel_Company(dgv As DataGridView)
		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_AllCompany]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		'cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
		dr = cmd.ExecuteReader()
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
			dr.GetString(9),
			dr.GetString(10),
			dr.GetString(11))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Sel_Department_ByCompanyID(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_DepartmentByCompanyID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strCompanyID)
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

	Sub Sel_DepartmentHistory(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_MainDepartment]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strParentDepartmentID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Sel_Department(dgv As DataGridView, txtSearch As TextBox)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_AllDepartment]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@Search", txtSearch.Text)
		dr = cmd.ExecuteReader()

		If dr.HasRows Then
			While dr.Read()
				dgv.Rows.Add(
				dr.GetInt32(0),
				dr.GetInt32(1),
				dr.GetString(2),
				dr.GetString(3),
				dr.GetString(4),
				dr.GetString(5),
				dr.GetString(6),
				dr.GetString(7),
				dr.GetInt32(8))
			End While
		Else
			MessageBox.Show("Search not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Sel_Employee_ByDepartmentID(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_EmployeeDepartmentByID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strDepartmentID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2),
			dr.GetString(3),
			dr.GetString(4),
			dr.GetString(5))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Sel_LeaveCredit_ByEmployeeID(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_LeaveCreditsByEmployeeID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
				dr.GetInt32(0),
				dr.GetString(1),
				dr.GetDecimal(2),
				dr.GetDecimal(3),
				dr.GetDecimal(4),
				dr.GetString(5),
				dr.GetDecimal(6),
				dr.GetDecimal(7),
				dr.GetDecimal(8),
				If(dr.IsDBNull(9), "", dr.GetString(9)))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub InsUpd_Employee_Leave_Credits(dataGridView As DataGridView)

		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spInsUpdTKMS_Leave_EmployeeLeaveCredits]", Conn)
					cmd.CommandType = CommandType.StoredProcedure

					For Each row As DataGridViewRow In dataGridView.Rows
						cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
						cmd.Parameters.AddWithValue("@LeaveType", If(IsDBNull(row.Cells(0).Value), "", row.Cells(0).Value.ToString()))
						cmd.Parameters.AddWithValue("@LeaveCredit", If(IsDBNull(row.Cells(1).Value), 0D, CDec(row.Cells(1).Value)))
						cmd.Parameters.AddWithValue("@DateIssued", If(IsDBNull(row.Cells(2).Value), "", row.Cells(2).Value.ToString()))
						cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
						cmd.ExecuteNonQuery()
						cmd.Parameters.Clear()
					Next

				End Using
			End Using
			MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
			frmHRIS_Setup_AddUpdLeaveCredit.Close()
		Catch ex As Exception
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

	End Sub

	Sub InsUpd_Employee_Leave_Credits_ByWorkDate()
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spInsHRIS_Employee_LeaveAccumulation]", Conn)
					cmd.CommandType = CommandType.StoredProcedure

					cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
					cmd.Parameters.AddWithValue("@AsOfDate", frmHRIS_Setup_SelectDateLeaveCredit.dtpAsOfDate.Value)
					cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text.Trim())

					If cmd.ExecuteNonQuery() = -1 Then
						MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
						frmHRIS_Setup_SelectDateLeaveCredit.Close()
						Sel_LeaveCredit_ByEmployeeID(frmHRIS_Setup_LeaveCredit.dgvLeaveIssuedList)
					End If

				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub Sel_AccumulatedLeaveCredit_ByEmployeeID(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_AccumulatedLeaveCredits_ByEmployeeID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@TypeID", _LeaveTypeID)

		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
				dr.GetString(0),
				dr.GetString(1),
				dr.GetDecimal(2),
				dr.GetDecimal(3))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Sel_AccumulatedLeaveTaken_ByEmployeeID(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_AccumulatedLeaveTaken_ByEmployeeID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@TypeID", _LeaveTypeID)

		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
				dr.GetString(0),
				dr.GetString(1),
				dr.GetString(2),
				dr.GetDecimal(3))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Upd_Employee_Leave_Credits_isPayrollProcessed(DateToday As DateTime, bool As Boolean, type As Integer)
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spUpdHRIS_Employee_Leave_isPayrollProcessed]", Conn)
					cmd.CommandType = CommandType.StoredProcedure

					cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
					cmd.Parameters.AddWithValue("@Type", type)
					cmd.Parameters.AddWithValue("@AsOfDate", DateToday)
					cmd.Parameters.AddWithValue("@Status", bool)
					cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text.Trim())

					If cmd.ExecuteNonQuery() = -1 Then
						MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
						Sel_LeaveCredit_ByEmployeeID(frmHRIS_Setup_LeaveCredit.dgvLeaveIssuedList)
					End If

				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	'Sub Sel_JobTitle(dgv As DataGridView, txtbox As TextBox, txt As ToolStripLabel)

	'	dgv.Rows.Clear()
	'	Conn = New SqlConnection(StrConn)
	'	Conn.Open()
	'	cmd = Conn.CreateCommand
	'	cmd.CommandText = "[spSelHRIS_AllJobTitle]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn) With {
	'					.CommandType = CommandType.StoredProcedure
	'					}
	'	cmd.Parameters.AddWithValue("@txt", txtbox.Text)

	'	Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
	'	returnParam.Direction = ParameterDirection.Output
	'	cmd.Parameters.Add(returnParam)

	'	dr = cmd.ExecuteReader()
	'	While dr.Read()
	'		txt.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
	'		dgv.Rows.Add(
	'		dr.GetInt32(0),
	'		dr.GetString(1),
	'		dr.GetString(2),
	'		dr.GetString(3),
	'		dr.GetString(4),
	'		dr.GetString(5),
	'		dr.GetString(6),
	'		dr.GetString(7),
	'		dr.GetString(8))

	'	End While
	'	txt.Text = If(IsDBNull(returnParam.Value), "0", returnParam.Value.ToString())

	'	dr.Close()
	'	Conn.Close()
	'	cmd.Parameters.Clear()
	'	dgv.ClearSelection()

	'End Sub

	Sub Sel_JobTitle(dgv As DataGridView, txtbox As TextBox, txt As ToolStripLabel)
		dgv.Rows.Clear()
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spSelHRIS_AllJobTitle]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@txt", txtbox.Text)

					Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
					returnParam.Direction = ParameterDirection.Output
					cmd.Parameters.Add(returnParam)

					Using dr As SqlDataReader = cmd.ExecuteReader()
						While dr.Read()
							txt.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
							dgv.Rows.Add(
								dr.GetInt32(0),
								dr.GetString(1),
								dr.GetString(2),
								dr.GetString(3),
								dr.GetString(4),
								dr.GetString(5),
								dr.GetString(6),
								dr.GetString(7),
								dr.GetString(8))
						End While
					End Using
					txt.Text = If(IsDBNull(returnParam.Value), "0", returnParam.Value.ToString())
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		dgv.ClearSelection()
	End Sub

	Sub Sel_ApprovalHierarchy(dgv As DataGridView, txtbox As TextBox, txt As ToolStripLabel)
		dgv.Rows.Clear()
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spSelHRIS_AllApprovalHierarchy]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@txt", txtbox.Text)

					Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
					returnParam.Direction = ParameterDirection.Output
					cmd.Parameters.Add(returnParam)

					Using dr As SqlDataReader = cmd.ExecuteReader()
						While dr.Read()
							txt.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
							dgv.Rows.Add(
								dr.GetInt32(0),
								dr.GetString(1),
								dr.GetString(2))
						End While
					End Using
					txt.Text = If(IsDBNull(returnParam.Value), "0", returnParam.Value.ToString())
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		dgv.ClearSelection()
	End Sub

	Sub Sel_Employee_ByJobTitleID(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_EmployeeByJobTitleID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strJobTitleID)
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


	Sub Sel_Employee_ByHierarchyID(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_EmployeeByHierarchyID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strHierarchyID)
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

	'Sub Sel_Department_CountRec()

	'	Conn = New SqlConnection(StrConn)
	'	Conn.Open()
	'	cmd = Conn.CreateCommand
	'	cmd.CommandText = "[spSelHRIS_DepartmentCount]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn) With {
	'					.CommandType = CommandType.StoredProcedure
	'					}

	'	frmHR_Setup_Department.toolstriplabelNoOfRecord.Text = cmd.ExecuteScalar

	'	Conn.Close()
	'	cmd.Parameters.Clear()

	'End Sub

	'Sub Sel_ShiftID()

	'	Conn = New SqlConnection(StrConn)
	'	Conn.Open()
	'	cmd = Conn.CreateCommand
	'	cmd.CommandText = "[spSelHRIS_Shift_ByID]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn) With {
	'					.CommandType = CommandType.StoredProcedure
	'					}

	'	_strShiftID = cmd.ExecuteScalar

	'	Conn.Close()
	'	cmd.Parameters.Clear()

	'End Sub

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

	Sub SelUpd_Shift_By_ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_ShiftByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strShiftID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then
						frmHRIS_AddNewShift.txtCode.Text = dr.GetString(0)
						frmHRIS_AddNewShift.txtName.Text = dr.GetString(1)
						frmHRIS_AddNewShift.txtDescriptions.Text = dr.GetString(2)

						Dim StartTimeSpanValue As TimeSpan
						If TimeSpan.TryParse(dr.GetString(3), StartTimeSpanValue) Then
							frmHRIS_AddNewShift.dtpNormalWorkTimeFrom.Value = frmHRIS_AddNewShift.dtpNormalWorkTimeFrom.Value.Date.Add(StartTimeSpanValue)
						End If

						Dim EndTimeSpanValue As TimeSpan
						If TimeSpan.TryParse(dr.GetString(4), EndTimeSpanValue) Then
							frmHRIS_AddNewShift.dtpNormalWorkTimeTo.Value = frmHRIS_AddNewShift.dtpNormalWorkTimeTo.Value.Date.Add(EndTimeSpanValue)
						End If

						frmHRIS_AddNewShift.txtTotalHours.Text = dr.GetString(5)
						frmHRIS_AddNewShift.txtSlideTime.Text = dr.GetString(6)

						Dim StartBreakSpanValue As TimeSpan
						If TimeSpan.TryParse(dr.GetString(7), StartBreakSpanValue) Then
							frmHRIS_AddNewShift.dtpNormalBreakTimeFrom.Value = frmHRIS_AddNewShift.dtpNormalBreakTimeFrom.Value.Date.Add(StartBreakSpanValue)
						End If

						Dim EndBreakSpanValue As TimeSpan
						If TimeSpan.TryParse(dr.GetString(8), EndBreakSpanValue) Then
							frmHRIS_AddNewShift.dtpNormalBreakTimeTo.Value = frmHRIS_AddNewShift.dtpNormalBreakTimeTo.Value.Date.Add(EndBreakSpanValue)
						End If

						frmHRIS_AddNewShift.checkboxForceBreak.Checked = dr.GetBoolean(9)
						frmHRIS_AddNewShift.checkboxFlexi.Checked = dr.GetBoolean(10)
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub SelUpd_Shift_EffectivityDate_By_ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_ShiftEffectivityDateByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@PID", _strShiftID)
				cmd.Parameters.AddWithValue("@ID", _strShiftEffectivityID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then
						frmHRIS_AddNewShiftEffectivity.dtpStartPeriod.Value = If(dr.IsDBNull(0), DateTime.Now, dr.GetDateTime(0))
						frmHRIS_AddNewShiftEffectivity.dtpEndPeriod.Value = If(dr.IsDBNull(1), DateTime.Now, dr.GetDateTime(1))
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub Del_Shift_EffectivityDate_By_ID(dgv As DataGridView)
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spDelHRIS_ShiftEffectivityDateByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strShiftEffectivityID)

				If cmd.ExecuteNonQuery = -1 Then
					MessageBox.Show("Successfully Removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
					dgv.Rows.Remove(dgv.SelectedRows(0))
				End If

				Conn.Close()
				cmd.Parameters.Clear()
			End Using
		End Using
	End Sub

	Sub Del_Shift_By_ID(dgv As DataGridView)
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spDelHRIS_ShiftByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strShiftID)

				If cmd.ExecuteNonQuery = -1 Then
					MessageBox.Show("Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
					dgv.Rows.Remove(dgv.SelectedRows(0))
				End If

				Conn.Close()
				cmd.Parameters.Clear()
			End Using
		End Using
	End Sub

	Sub Sel_Shift_EffectivityDate_ByID(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_ShiftEffectivityDatesByID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strShiftID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Sel_LeaveType(dgv As DataGridView, txtbox As TextBox, txt As ToolStripLabel)
		dgv.Rows.Clear()
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spSelHRIS_AllLeaveType]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@txt", txtbox.Text)

					Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
					returnParam.Direction = ParameterDirection.Output
					cmd.Parameters.Add(returnParam)

					Using dr As SqlDataReader = cmd.ExecuteReader()
						While dr.Read()
							txt.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
							dgv.Rows.Add(
								dr.GetInt32(0),
								dr.GetString(1),
								dr.GetString(2),
								dr.GetString(3),
								dr.GetString(4),
								dr.GetString(5))
						End While
					End Using
					txt.Text = If(IsDBNull(returnParam.Value), "0", returnParam.Value.ToString())
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		dgv.ClearSelection()
	End Sub

	Sub Sel_LeaveCredits(dgv As DataGridView, txtbox As TextBox, txt As ToolStripLabel)
		dgv.Rows.Clear()
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spSelHRIS_AllLeaveCredits]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@txt", txtbox.Text)

					Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
					returnParam.Direction = ParameterDirection.Output
					cmd.Parameters.Add(returnParam)

					Using dr As SqlDataReader = cmd.ExecuteReader()
						While dr.Read()
							txt.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
							dgv.Rows.Add(
								dr.GetInt32(0),
								dr.GetString(1),
								dr.GetString(2),
								dr.GetString(3),
								dr.GetString(4),
								dr.GetString(5))
						End While
					End Using
					txt.Text = If(IsDBNull(returnParam.Value), "0", returnParam.Value.ToString())
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		dgv.ClearSelection()
	End Sub

	Sub Sel_SystemSetting_ByModule(dgv As DataGridView, txtbox As TextBox, txt As ToolStripLabel, grp As String)
		dgv.Rows.Clear()
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spSelSystemSettings_AllOptions]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@Group", grp)
					cmd.Parameters.AddWithValue("@txt", txtbox.Text)

					Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
					returnParam.Direction = ParameterDirection.Output
					cmd.Parameters.Add(returnParam)

					Using dr As SqlDataReader = cmd.ExecuteReader()
						While dr.Read()
							txt.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
							dgv.Rows.Add(
								dr.GetInt32(0),
								dr.GetString(1),
								dr.GetString(2),
								dr.GetString(3))
						End While
					End Using
					txt.Text = If(IsDBNull(returnParam.Value), "0", returnParam.Value.ToString())
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		dgv.ClearSelection()
	End Sub

	Sub InsUpd_Department()
		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_Department]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strDepartmentID)
			cmd.Parameters.AddWithValue("@Code", frmHRIS_Setup_AddUpdDepartment.txtCode.Text)
			cmd.Parameters.AddWithValue("@Name", frmHRIS_Setup_AddUpdDepartment.txtDeptName.Text)
			cmd.Parameters.AddWithValue("@InCharge", frmHRIS_Setup_AddUpdDepartment.cbInCharge.Text)
			cmd.Parameters.AddWithValue("@Hotline", frmHRIS_Setup_AddUpdDepartment.txtHotline.Text)
			cmd.Parameters.AddWithValue("@IsOperationDept", isOperationDept)
			cmd.Parameters.AddWithValue("@ParentDept", frmHRIS_Setup_AddUpdDepartment.cbParentDept.Text)
			cmd.Parameters.AddWithValue("@IsInactive", False)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
			If cmd.ExecuteNonQuery = -1 Then

				'\\ This Code will Select the Data after Insert.

				Call Sel_Department(frmHRIS_Setup_Department.dgvMainDepartment, frmHRIS_Setup_Department.txtboxSearch)
				Call frmHRIS_Setup_AddUpdDepartment.Dispose()

			End If

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try
	End Sub

	Sub SelUpd_Department_By_ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_DepartmentByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strDepartmentID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then

						frmHRIS_Setup_AddUpdDepartment.txtCode.Text = dr.GetString(0)
						frmHRIS_Setup_AddUpdDepartment.txtDeptName.Text = dr.GetString(1)

						Dim employeeIndex As Integer = frmHRIS_Setup_AddUpdDepartment.cbInCharge.FindStringExact(dr(2).ToString())
						If employeeIndex <> -1 Then frmHRIS_Setup_AddUpdDepartment.cbInCharge.SelectedIndex = employeeIndex

						frmHRIS_Setup_AddUpdDepartment.txtHotline.Text = dr.GetString(3)
						frmHRIS_Setup_AddUpdDepartment.checkboxOperationDept.Checked = dr.GetBoolean(4)
						'frmHRIS_Setup_AddUpdDepartment.checkboxIsInactive.Checked = dr.GetBoolean(5)

						Dim parentDept As Integer = frmHRIS_Setup_AddUpdDepartment.cbParentDept.FindStringExact(dr(5).ToString())
						If parentDept <> -1 Then frmHRIS_Setup_AddUpdDepartment.cbParentDept.SelectedIndex = parentDept

					End If
				End Using
			End Using
		End Using
	End Sub

	Sub SelUpd_HRIS_SystemSettings_By_ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_SystemSettingsByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strSystemSettingsID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then
						frmHRIS_Options_AddUpdSystemSettings.txtCode.Text = dr.GetString(0)
						frmHRIS_Options_AddUpdSystemSettings.txtDescription.Text = dr.GetString(1)
						frmHRIS_Options_AddUpdSystemSettings.txtValue.Text = dr.GetString(2)
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub SelUpd_Hierarchy_By_ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_HierarchyByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strHierarchyID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then
						frmHRIS_Setup_AddUpdApprovalHierarchy.txtName.Text = dr.GetString(0)
						frmHRIS_Setup_AddUpdApprovalHierarchy.txtDescription.Text = dr.GetString(1)
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub SelUpd_HierarchyDetail_By_ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_HierarchyDetailByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strHierarchyDetailID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then
						Dim employeeIndex As Integer = frmHRIS_Setup_AddUpdApprovalHierarchyDetail.cbName.FindStringExact(dr(0).ToString())
						If employeeIndex <> -1 Then frmHRIS_Setup_AddUpdApprovalHierarchyDetail.cbName.SelectedIndex = employeeIndex
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub SelUpd_LeaveType_By_ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_LeaveTypeByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strLeaveTypeID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then
						frmHRIS_Setup_AddUpdateLeaveType.txtName.Text = dr.GetString(0)
						frmHRIS_Setup_AddUpdateLeaveType.txtDescription.Text = dr.GetString(1)
						frmHRIS_Setup_AddUpdateLeaveType.checkboxCummulative.Checked = dr.GetBoolean(2)
						frmHRIS_Setup_AddUpdateLeaveType.checkboxIncremental.Checked = dr.GetBoolean(3)
						frmHRIS_Setup_AddUpdateLeaveType.checkboxPaid.Checked = dr.GetBoolean(4)
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub InsUpd_Company()

		Try
			Using Conn As New SqlConnection(StrConn),
			cmd As New SqlCommand("[spInsUpdHRIS_Company]", Conn)
				Conn.Open()
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strCompanyID)
				cmd.Parameters.AddWithValue("@Name", frmHRIS_Setup_AddUpdCompany.txtName.Text)
				cmd.Parameters.AddWithValue("@LegalName", frmHRIS_Setup_AddUpdCompany.txtLegalName.Text)
				cmd.Parameters.AddWithValue("@CEO", frmHRIS_Setup_AddUpdCompany.txtCEO.Text)
				cmd.Parameters.AddWithValue("@BusRegNo", frmHRIS_Setup_AddUpdCompany.txtBusReg.Text)
				cmd.Parameters.AddWithValue("@Address1", frmHRIS_Setup_AddUpdCompany.txtAddress1.Text)
				cmd.Parameters.AddWithValue("@Address2", frmHRIS_Setup_AddUpdCompany.txtAddress2.Text)
				cmd.Parameters.AddWithValue("@Organization", frmHRIS_Setup_AddUpdCompany.cbCompanyOrganization.Text)
				cmd.Parameters.AddWithValue("@Industry", frmHRIS_Setup_AddUpdCompany.cbCompanyIndustry.Text)
				cmd.Parameters.AddWithValue("@Website", frmHRIS_Setup_AddUpdCompany.txtWebsite.Text)
				cmd.Parameters.AddWithValue("@Email", frmHRIS_Setup_AddUpdCompany.txtEmail.Text)
				cmd.Parameters.AddWithValue("@Trunkline", frmHRIS_Setup_AddUpdCompany.txtTrunkline.Text)
				cmd.Parameters.AddWithValue("@Hotline", frmHRIS_Setup_AddUpdCompany.txtHotline.Text)
				cmd.Parameters.AddWithValue("@FaxNo", frmHRIS_Setup_AddUpdCompany.txtFaxNo.Text)
				cmd.Parameters.AddWithValue("@ModifiedBy", frmMain.ToolStripEmployeeNo.Text)
				If cmd.ExecuteNonQuery = -1 Then
					'\\ This Code will Select the Data after Insert.
					Call Sel_Company(frmHRIS_Setup_Company.dgvCompanyList)
					Call frmHRIS_Setup_AddUpdCompany.Close()
				End If
			End Using

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try

	End Sub

	Sub SelUpd_Company_By_ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_CompanyByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strCompanyID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then
						frmHRIS_Setup_AddUpdCompany.txtName.Text = dr.GetString(0)
						frmHRIS_Setup_AddUpdCompany.txtLegalName.Text = dr.GetString(1)
						frmHRIS_Setup_AddUpdCompany.txtCEO.Text = dr.GetString(2)
						frmHRIS_Setup_AddUpdCompany.txtBusReg.Text = dr.GetString(3)
						frmHRIS_Setup_AddUpdCompany.txtAddress1.Text = dr.GetString(4)
						frmHRIS_Setup_AddUpdCompany.txtAddress2.Text = dr.GetString(5)

						Dim organizationIndex As Integer = frmHRIS_Setup_AddUpdCompany.cbCompanyOrganization.FindStringExact(dr(6).ToString())
						If organizationIndex <> -1 Then frmHRIS_Setup_AddUpdCompany.cbCompanyOrganization.SelectedIndex = organizationIndex

						Dim industryIndex As Integer = frmHRIS_Setup_AddUpdCompany.cbCompanyIndustry.FindStringExact(dr(7).ToString())
						If industryIndex <> -1 Then frmHRIS_Setup_AddUpdCompany.cbCompanyIndustry.SelectedIndex = industryIndex

						frmHRIS_Setup_AddUpdCompany.txtEmail.Text = dr.GetString(8)
						frmHRIS_Setup_AddUpdCompany.txtWebsite.Text = dr.GetString(9)
						frmHRIS_Setup_AddUpdCompany.txtTrunkline.Text = dr.GetString(10)
						frmHRIS_Setup_AddUpdCompany.txtHotline.Text = dr.GetString(11)
						frmHRIS_Setup_AddUpdCompany.txtFaxNo.Text = dr.GetString(12)
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub InsUpd_JobTitle()
		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_JobTitle]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strJobTitleID)
			cmd.Parameters.AddWithValue("@Name", frmHRIS_Setup_AddUpdJobTitle.txtName.Text)
			cmd.Parameters.AddWithValue("@DeptName", frmHRIS_Setup_AddUpdJobTitle.cbDept.Text)
			cmd.Parameters.AddWithValue("@Level", frmHRIS_Setup_AddUpdJobTitle.cbLevel.Text)
			cmd.Parameters.AddWithValue("@SalaryFrom", frmHRIS_Setup_AddUpdJobTitle.txtSalaryFrom.Text)
			cmd.Parameters.AddWithValue("@SalaryTo", frmHRIS_Setup_AddUpdJobTitle.txtSalaryTo.Text)
			cmd.Parameters.AddWithValue("@Salary", frmHRIS_Setup_AddUpdJobTitle.txtSalary.Text)
			cmd.Parameters.AddWithValue("@IncreasePerYear", frmHRIS_Setup_AddUpdJobTitle.txtIncreasePerYr.Text)
			cmd.Parameters.AddWithValue("@ClusterGroup", frmHRIS_Setup_AddUpdJobTitle.cbCluster.Text)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
			If cmd.ExecuteNonQuery = -1 Then

				'\\ This Code will Select the Data after Insert.

				Call Sel_JobTitle(frmHRIS_Setup_JobTitle.dgvJobTitleList, frmHRIS_Setup_JobTitle.txtboxSearch, frmHRIS_Setup_JobTitle.toolstriplabelNoOfRecord)
				Call frmHRIS_Setup_AddUpdJobTitle.Dispose()

			End If

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try
	End Sub

	Sub SelUpd_JobTitle_By_ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_JobTitleByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strJobTitleID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then
						frmHRIS_Setup_AddUpdJobTitle.txtName.Text = dr.GetString(0)

						Dim divIndex As Integer = frmHRIS_Setup_AddUpdJobTitle.cbDept.FindStringExact(dr(1).ToString())
						If divIndex <> -1 Then frmHRIS_Setup_AddUpdJobTitle.cbDept.SelectedIndex = divIndex

						Dim lvlIndex As Integer = frmHRIS_Setup_AddUpdJobTitle.cbLevel.FindStringExact(dr(2).ToString())
						If lvlIndex <> -1 Then frmHRIS_Setup_AddUpdJobTitle.cbLevel.SelectedIndex = lvlIndex

						frmHRIS_Setup_AddUpdJobTitle.txtSalaryFrom.Text = dr.GetDecimal(3)
						frmHRIS_Setup_AddUpdJobTitle.txtSalaryTo.Text = dr.GetDecimal(4)
						frmHRIS_Setup_AddUpdJobTitle.txtSalary.Text = dr.GetDecimal(5)
						frmHRIS_Setup_AddUpdJobTitle.txtIncreasePerYr.Text = dr.GetDecimal(6)

						Dim clusterIndex As Integer = frmHRIS_Setup_AddUpdJobTitle.cbCluster.FindStringExact(dr(7).ToString())
						If clusterIndex <> -1 Then frmHRIS_Setup_AddUpdJobTitle.cbCluster.SelectedIndex = clusterIndex
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub InsUpd_LeaveType()
		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_LeaveType]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strLeaveTypeID)
			cmd.Parameters.AddWithValue("@Name", frmHRIS_Setup_AddUpdateLeaveType.txtName.Text)
			cmd.Parameters.AddWithValue("@Description", frmHRIS_Setup_AddUpdateLeaveType.txtDescription.Text)
			cmd.Parameters.AddWithValue("@Cummulative", frmHRIS_Setup_AddUpdateLeaveType.checkboxCummulative.Checked)
			cmd.Parameters.AddWithValue("@Incremental", frmHRIS_Setup_AddUpdateLeaveType.checkboxIncremental.Checked)
			cmd.Parameters.AddWithValue("@Paid", frmHRIS_Setup_AddUpdateLeaveType.checkboxPaid.Checked)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
			If cmd.ExecuteNonQuery = -1 Then

				'\\ This Code will Select the Data after Insert.

				Call Sel_LeaveType(frmHRIS_Setup_LeaveType.dgvLeaveTypeList, frmHRIS_Setup_LeaveType.txtboxSearch, frmHRIS_Setup_LeaveType.toolstriplabelNoOfRecord)
				Call frmHRIS_Setup_AddUpdateLeaveType.Dispose()

			End If

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try
	End Sub

	Sub InsUpd_HR_SystemSettings()
		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_SystemSettings]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strSystemSettingsID)
			cmd.Parameters.AddWithValue("@Group", frmHRIS_Options_AddUpdSystemSettings.txtGroup.Text)
			cmd.Parameters.AddWithValue("@Code", frmHRIS_Options_AddUpdSystemSettings.txtCode.Text)
			cmd.Parameters.AddWithValue("@Description", frmHRIS_Options_AddUpdSystemSettings.txtDescription.Text)
			cmd.Parameters.AddWithValue("@Value", frmHRIS_Options_AddUpdSystemSettings.txtValue.Text)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
			If cmd.ExecuteNonQuery = -1 Then

				'\\ This Code will Select the Data after Insert.

				Call Sel_SystemSetting_ByModule(frmHRIS_Options_MainView.dgvSystemSettings, frmHRIS_Options_MainView.txtboxSearch, frmHRIS_Options_MainView.toolstriplabelNoOfRecord, "HR")
				Call frmHRIS_Options_AddUpdSystemSettings.Dispose()

			End If

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)

		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try
	End Sub

	Sub InsUpd_Shift()
		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_Shift]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strShiftID)
			cmd.Parameters.AddWithValue("@Code", frmHRIS_AddNewShift.txtCode.Text)
			cmd.Parameters.AddWithValue("@Name", frmHRIS_AddNewShift.txtName.Text)
			cmd.Parameters.AddWithValue("@Description", frmHRIS_AddNewShift.txtDescriptions.Text)
			cmd.Parameters.AddWithValue("@TimeFrom", frmHRIS_AddNewShift.dtpNormalWorkTimeFrom.Text)
			cmd.Parameters.AddWithValue("@TimeTo", frmHRIS_AddNewShift.dtpNormalWorkTimeTo.Text)
			cmd.Parameters.AddWithValue("@SlideTimeMins", frmHRIS_AddNewShift.txtSlideTime.Text)
			cmd.Parameters.AddWithValue("@BreakIn", frmHRIS_AddNewShift.dtpNormalBreakTimeFrom.Text)
			cmd.Parameters.AddWithValue("@BreakOut", frmHRIS_AddNewShift.dtpNormalBreakTimeTo.Text)
			cmd.Parameters.AddWithValue("@IsForceBreak", isForceBreak)
			cmd.Parameters.AddWithValue("@IsFlexi", isFlexi)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

			If cmd.ExecuteNonQuery = -1 Then
				'Ins_ShiftTempRecord()
				'Sel_ShiftID()
				'Sel_ShiftAll(frmHRIS_Setup_Shift.dgvAllShift)
				frmHRIS_AddNewShift.Dispose()
			End If
		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try
	End Sub

	Sub InsUpd_ShiftEffectivityDate()
		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_ShiftEffectivityDate]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strShiftEffectivityID)
			cmd.Parameters.AddWithValue("@PID", _strShiftID)
			cmd.Parameters.AddWithValue("@StartDate", frmHRIS_AddNewShiftEffectivity.dtpStartPeriod.Value)
			cmd.Parameters.AddWithValue("@EndDate", frmHRIS_AddNewShiftEffectivity.dtpEndPeriod.Value)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

			If cmd.ExecuteNonQuery = -1 Then
				'Ins_ShiftTempRecord()
				'Sel_ShiftID()
				'Sel_Shift_EffectivityDate_ByID(frmHRIS_Setup_Shift.dgvShiftDetails)
				Sel_Assign_ScheduleShift_Detail(frmHRIS_Setup_Shift.dgvShiftDetails)
				frmHRIS_AddNewShiftEffectivity.Close()
			End If
		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try
	End Sub

	Sub InsUpd_ApprovalHierarchy()
		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_ApprovalHierarchy]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strHierarchyID)
			cmd.Parameters.AddWithValue("@Name", frmHRIS_Setup_AddUpdApprovalHierarchy.txtName.Text)
			cmd.Parameters.AddWithValue("@Description", frmHRIS_Setup_AddUpdApprovalHierarchy.txtDescription.Text)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
			If cmd.ExecuteNonQuery = -1 Then

				'\\ This Code will Select the Data after Insert.

				Call Sel_ApprovalHierarchy(frmHRIS_Setup_ApprovalHierarchy.dgvApprovalList, frmHRIS_Setup_ApprovalHierarchy.txtboxSearch, frmHRIS_Setup_ApprovalHierarchy.toolstriplabelNoOfRecord)
				Call frmHRIS_Setup_AddUpdApprovalHierarchy.Dispose()

			End If

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try
	End Sub

	Sub InsUpd_ApprovalHierarchyDetail()
		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_ApprovalHierarchyDetail]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strHierarchyDetailID)
			cmd.Parameters.AddWithValue("@PID", _strHierarchyID)
			cmd.Parameters.AddWithValue("@Name", frmHRIS_Setup_AddUpdApprovalHierarchyDetail.cbName.Text)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
			If cmd.ExecuteNonQuery = -1 Then

				'\\ This Code will Select the Data after Insert.

				Call Sel_Employee_ByHierarchyID(frmHRIS_Setup_ApprovalHierarchy.dgvEmployeeList)
				Call frmHRIS_Setup_AddUpdApprovalHierarchyDetail.Dispose()

			End If

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try
	End Sub

	'Sub Ins_ShiftTempRecord()

	'	Conn = New SqlConnection(StrConn)
	'	Conn.Open()
	'	cmd = Conn.CreateCommand
	'	cmd.CommandText = "[spInsHRIS_Shift_NewRecordTemp]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn) With {
	'					.CommandType = CommandType.StoredProcedure
	'					}
	'	cmd.Parameters.AddWithValue("@CreatedBy", frmMain.ToolStripEmployeeNo.Text)
	'	cmd.ExecuteNonQuery()
	'	Conn.Close()
	'	cmd.Parameters.Clear()

	'End Sub

	''--->>> Assign Employee Schedule <<<---

	Sub Sel_ScheduleShift_SubDetails(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_ShiftSubDetailByDetailID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ShiftDetailID", _strShiftEffectivityID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2),
			dr.GetString(3),
			dr.GetString(4),
			dr.GetString(5),
			dr.GetString(6),
			dr.GetString(7))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub SelSearch_ScheduleShift_SubDetails(dgv As DataGridView, txt As TextBox)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_SearchShiftSubDetailByEmployeeNameCode]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}

		cmd.Parameters.AddWithValue("@txtSearch", txt.Text)

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
			dr.GetString(6),
			dr.GetString(7))

			End While
		Else
			MessageBox.Show("Record not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Assign_ScheduleShiftType_To_Employee()

		Dim restDaysList As New List(Of String)
		Try
			Using Conn As New SqlConnection(StrConn),
			cmd As New SqlCommand("[spInsUpdHRIS_ShiftAssignedToEmployee]", Conn)
				Conn.Open()
				cmd.CommandType = CommandType.StoredProcedure
				'cmd.Parameters.AddWithValue("@ShiftType", frmHR_AssignScheduleType.cbScheduleType.Text)
				cmd.Parameters.AddWithValue("@ShiftDetailID", _strShiftEffectivityID)
				cmd.Parameters.AddWithValue("@EmployeeID", _strShiftEmployeeID)

				If frmHRIS_AssignScheduleType.chMonday.Checked Then restDaysList.Add("2")
				If frmHRIS_AssignScheduleType.chTuesday.Checked Then restDaysList.Add("3")
				If frmHRIS_AssignScheduleType.chWednesday.Checked Then restDaysList.Add("4")
				If frmHRIS_AssignScheduleType.chThursday.Checked Then restDaysList.Add("5")
				If frmHRIS_AssignScheduleType.chFriday.Checked Then restDaysList.Add("6")
				If frmHRIS_AssignScheduleType.chSaturday.Checked Then restDaysList.Add("7")
				If frmHRIS_AssignScheduleType.chSunday.Checked Then restDaysList.Add("1")

				Dim restDays As String = String.Join(",", restDaysList)
				cmd.Parameters.AddWithValue("@RestDay", restDays)

				cmd.Parameters.AddWithValue("@Remarks", frmHRIS_AssignScheduleType.txtRemarks.Text)
				cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()

				Sel_Assign_ScheduleShift_SubDetail(frmHRIS_Setup_Shift.dgvShiftSubDetails)
				MessageBox.Show("Success! Schedule Assigned to Employee.")
			End Using
			frmHRIS_AssignScheduleType.Close()
			restDaysList.Clear()

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		End Try

	End Sub

	Sub Update_ScheduleShiftType_To_Employee()

		Dim restDaysList As New List(Of String)
		Try
			Using Conn As New SqlConnection(StrConn),
		cmd As New SqlCommand("[spInsUpdHRIS_ShiftAssignedToEmployee]", Conn)
				Conn.Open()
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ShiftType", frmHR_TransferScheduleType.cbScheduleType.Text)
				cmd.Parameters.AddWithValue("@ShiftEffectivityDate", frmHR_TransferScheduleType.cbEffectivityPeriod.Text)
				cmd.Parameters.AddWithValue("@EmployeeID", _strShiftEmployeeID)

				If frmHR_TransferScheduleType.chMonday.Checked Then restDaysList.Add("2")
				If frmHR_TransferScheduleType.chTuesday.Checked Then restDaysList.Add("3")
				If frmHR_TransferScheduleType.chWednesday.Checked Then restDaysList.Add("4")
				If frmHR_TransferScheduleType.chThursday.Checked Then restDaysList.Add("5")
				If frmHR_TransferScheduleType.chFriday.Checked Then restDaysList.Add("6")
				If frmHR_TransferScheduleType.chSaturday.Checked Then restDaysList.Add("7")
				If frmHR_TransferScheduleType.chSunday.Checked Then restDaysList.Add("1")

				Dim restDays As String = String.Join(",", restDaysList)
				cmd.Parameters.AddWithValue("@RestDay", restDays)

				cmd.Parameters.AddWithValue("@Remarks", frmHR_TransferScheduleType.txtRemarks.Text)
				cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()

				MessageBox.Show("Success! Schedule Assigned to Employee is updated.")
			End Using
			frmHR_TransferScheduleType.Dispose()
			restDaysList.Clear()
			Sel_ScheduleShift_SubDetails(frmHRIS_Transaction_AssignEmployeeSchedule.dgvShiftSubDetails)
		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		End Try
	End Sub

	Sub SelUpd_ShiftSubDetail_By_ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelUpdHRIS_ShiftSubDetailByID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strShiftEmployeeID)
				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then
						Dim shiftIndex As Integer = frmHR_TransferScheduleType.cbScheduleType.FindStringExact(dr("ShiftCode").ToString())
						If shiftIndex <> -1 Then frmHR_TransferScheduleType.cbScheduleType.SelectedIndex = shiftIndex

						Dim effectivityIndex As Integer = frmHR_TransferScheduleType.cbEffectivityPeriod.FindStringExact(dr("EffectivityDate").ToString())
						If effectivityIndex <> -1 Then frmHR_TransferScheduleType.cbEffectivityPeriod.SelectedIndex = effectivityIndex

						Dim restDays As String = dr("RestDay").ToString()
						Dim restDaysArray As String() = restDays.Split(","c)
						For Each day As String In restDaysArray
							Select Case day.Trim()
								Case "Mon"
									frmHR_TransferScheduleType.chMonday.Checked = True
								Case "Tue"
									frmHR_TransferScheduleType.chTuesday.Checked = True
								Case "Wed"
									frmHR_TransferScheduleType.chWednesday.Checked = True
								Case "Thu"
									frmHR_TransferScheduleType.chThursday.Checked = True
								Case "Fri"
									frmHR_TransferScheduleType.chFriday.Checked = True
								Case "Sat"
									frmHR_TransferScheduleType.chSaturday.Checked = True
								Case "Sun"
									frmHR_TransferScheduleType.chSunday.Checked = True
							End Select
						Next
						frmHR_TransferScheduleType.txtRemarks.Text = dr("Remarks").ToString()
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub Sel_Assign_ScheduleShift(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Assign_Shift]"
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
			dr.GetDecimal(5),
			dr.GetDecimal(6),
			dr.GetString(7),
			dr.GetString(8),
			dr.GetDecimal(9),
			dr.GetString(10),
			dr.GetString(11))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Sel_Assign_ScheduleShift_Detail(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Assign_ShiftDetail]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ParentID", _strShiftID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Sel_Assign_ScheduleShift_SubDetail(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Assign_ShiftSubDetail]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ShiftDetailID", _strShiftEffectivityID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2),
			dr.GetString(3),
			dr.GetString(4),
			dr.GetString(5),
			dr.GetString(6),
			dr.GetString(7))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Sel_Shift_Personnel_Active(dgvPersonnelList As DataGridView)

		dgvPersonnelList.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Assign_ActiveEmployees]"
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

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgvPersonnelList.ClearSelection()

	End Sub

	Sub Search_Shift_Personnel_Active(dgv As DataGridView, _txtBoxItemName As TextBox)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Assign_ActiveEmployees]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}

		cmd.Parameters.AddWithValue("@Search", _txtBoxItemName.Text)

		dr = cmd.ExecuteReader()
		If dr.HasRows Then
			While dr.Read()

				dgv.Rows.Add(
				dr.GetInt32(0),
				dr.GetString(1),
				dr.GetString(2),
				dr.GetString(3),
				dr.GetString(4))

			End While
		Else
			MessageBox.Show("Record not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
		dr.Dispose()
		Conn.Dispose()
		dgv.ClearSelection()

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

	''--->>> Employment History <<<---

	Sub SelUpd_HRIS_Personnel_EmploymentHistory_ByID(dgv As DataGridView)
		dgv.Rows.Clear()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelUpdHRIS_EmploymentHistory_ByEmployeeID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
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
							dr.GetString(9),
							dr.GetString(10),
							dr.GetString(11),
							dr.GetString(12),
							dr.GetDecimal(13),
							dr.GetDecimal(14),
							dr.GetString(15),
							dr.GetString(16))
					End While
				End Using
				dgv.ClearSelection()
			End Using
		End Using
	End Sub

	Sub ProcessDataGridViewEmploymentHistory(dataGridView As DataGridView)
		'\\ Credit by Jerome Dela Pena [2024-1435]:
		'\\ Added Try Catch to store/show errors
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spInsUpdHRIS_Personnel_EmploymentHistory]", Conn)
					cmd.CommandType = CommandType.StoredProcedure

					For Each row As DataGridViewRow In dataGridView.Rows
						cmd.Parameters.AddWithValue("@ID", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
						cmd.Parameters.AddWithValue("@CompanyName", If(row.Cells(1).Value IsNot DBNull.Value, row.Cells(1).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@JobTitle", If(row.Cells(2).Value IsNot DBNull.Value, row.Cells(2).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@From", If(row.Cells(3).Value IsNot DBNull.Value, row.Cells(3).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@To", If(row.Cells(4).Value IsNot DBNull.Value, row.Cells(4).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@CompanyAddress", If(row.Cells(5).Value IsNot DBNull.Value, row.Cells(5).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Industry", If(row.Cells(6).Value IsNot DBNull.Value, row.Cells(6).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Specialization", If(row.Cells(7).Value IsNot DBNull.Value, row.Cells(7).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@CompanyContactNo", If(row.Cells(8).Value IsNot DBNull.Value, row.Cells(8).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@SupervisorName", If(row.Cells(9).Value IsNot DBNull.Value, row.Cells(9).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@SupervisorPosition", If(row.Cells(10).Value IsNot DBNull.Value, row.Cells(10).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@SupervisorContactNo", If(row.Cells(11).Value IsNot DBNull.Value, row.Cells(11).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@SupervisorEmail", If(row.Cells(12).Value IsNot DBNull.Value, row.Cells(12).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Salary", If(IsNumeric(row.Cells(13).Value), Convert.ToDecimal(row.Cells(13).Value), DBNull.Value))
						cmd.Parameters.AddWithValue("@Allowances", If(IsNumeric(row.Cells(14).Value), Convert.ToDecimal(row.Cells(14).Value), DBNull.Value))
						cmd.Parameters.AddWithValue("@EmploymentStatus", If(row.Cells(15).Value IsNot DBNull.Value, row.Cells(15).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@SeparationType", If(row.Cells(16).Value IsNot DBNull.Value, row.Cells(16).Value.ToString(), ""))
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

	Sub Del_Personnel_EmploymentHistory_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list? This cannot be undone.", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_Personnel_EmploymentHistory]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _PersonnelEmploymentHistoryID1)
				cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()
				MsgBox("Deletion Success!")
			End Using
		End Using
		dgv.Rows.Remove(dgv.SelectedRows(0))
	End Sub

	''--->>> Training History <<<---

	Sub SelUpd_HRIS_Personnel_TrainingHistory_ByID(dgv As DataGridView)
		dgv.Rows.Clear()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelUpdHRIS_TrainingHistory_ByEmployeeID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						dgv.Rows.Add(
							dr.GetInt32(0),
							dr.GetString(1),
							dr.GetString(2),
							dr.GetString(3),
							dr.GetString(4),
							dr.GetString(5))
					End While
				End Using
				dgv.ClearSelection()
			End Using
		End Using
	End Sub

	''--->>> Performance Appraisal <<<---

	Sub SelUpd_HRIS_Personnel_PerformanceAppraisal_ByID(dgv As DataGridView)
		dgv.Rows.Clear()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelUpdHRIS_PerformanceAppraisal_ByEmployeeID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						dgv.Rows.Add(
							dr.GetInt32(0),
							dr.GetString(1),
							dr.GetString(2),
							dr.GetString(3),
							dr.GetDecimal(4),
							dr.GetString(5),
							dr.GetString(6))
					End While
				End Using
				dgv.ClearSelection()
			End Using
		End Using
	End Sub

	Sub ProcessDataGridViewPerformanceAppraisal(dataGridView As DataGridView)

		'\\ Credit by Jerome Dela Pena [2024-1435]  : 
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()

				Using cmd As New SqlCommand("[spInsUpdHRIS_Personnel_PerformanceAppraisal]", Conn)
					cmd.CommandType = CommandType.StoredProcedure

					For Each row As DataGridViewRow In dataGridView.Rows

						cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
						cmd.Parameters.AddWithValue("@ID", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@StartDate", If(row.Cells(1).Value IsNot DBNull.Value, row.Cells(1).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@EndDate", If(row.Cells(2).Value IsNot DBNull.Value, row.Cells(2).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Rater", If(row.Cells(3).Value IsNot DBNull.Value, row.Cells(3).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Rating", If(IsNumeric(row.Cells(4).Value), Convert.ToDecimal(row.Cells(4).Value), DBNull.Value))
						cmd.Parameters.AddWithValue("@FollowUpDate", If(row.Cells(5).Value IsNot DBNull.Value, row.Cells(5).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Remarks", If(row.Cells(6).Value IsNot DBNull.Value, row.Cells(6).Value.ToString(), ""))
						cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)

						cmd.ExecuteNonQuery()
						cmd.Parameters.Clear()
					Next
				End Using
				MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
				frmHR_PreviewPersonnelDetails.btnEdit.PerformClick()
			End Using
		Catch ex As Exception
			' Show error message if something goes wrong
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

	End Sub

	Sub Del_Personnel_PerformanceAppraisal_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list? This cannot be undone.", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_Personnel_PerformanceAppraisal]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _PersonnelAppraisalID1)
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

	Sub Sel_HRIS_Personnel_ContractHistory_ByID(dgv As DataGridView, all As Boolean) 'for preview
		dgv.Rows.Clear()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelHRIS_ContractHistory_ByEmployeeID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
				cmd.Parameters.AddWithValue("@isAll", all)
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

	''--->>> Contracts <<<---

	Sub Ins_Personnel_ContractHistory()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsHRIS_Personnel_ContractHistory]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
				}

		cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@Type", frmHR_AddNewContract.cbEmploymentType.Text)
		cmd.Parameters.AddWithValue("@Department", frmHR_AddNewContract.cbDepartment.Text)
		cmd.Parameters.AddWithValue("@StartDate", frmHR_AddNewContract.dtpContractStart.Value)
		cmd.Parameters.AddWithValue("@EndDate", frmHR_AddNewContract.dtpContractEnd.Value)
		cmd.Parameters.AddWithValue("@MonthlyRate", Decimal.Parse(frmHR_AddNewContract.txtMonthlyRate.Text.Replace(",", "")))
		cmd.Parameters.AddWithValue("@ProjectDiff", Decimal.Parse(frmHR_AddNewContract.txtProjectDiff.Text.Replace(",", "")))
		cmd.Parameters.AddWithValue("@JobTitle", frmHR_AddNewContract.cbJobPosition.Text)
		cmd.Parameters.AddWithValue("@Class", frmHR_AddNewContract.cbJobClassLevel.Text)
		cmd.Parameters.AddWithValue("@Supervisor", frmHR_AddNewContract.cbSuperior.Text)
		cmd.Parameters.AddWithValue("@Location", frmHR_AddNewContract.cbLocation.Text)
		cmd.Parameters.AddWithValue("@FieldAllowance", Decimal.Parse(frmHR_AddNewContract.txtFieldAllowance.Text.Replace(",", "")))
		cmd.Parameters.AddWithValue("@ContractNotes", frmHR_AddNewContract.txtContractNotes.Text)
		cmd.Parameters.AddWithValue("@ProjectNotes", frmHR_AddNewContract.txtProjectNotes.Text)
		cmd.Parameters.AddWithValue("@Remarks", frmHR_AddNewContract.txtRemarks.Text)
		cmd.Parameters.AddWithValue("@Signatory1", frmHR_AddNewContract.cbSignatory1.Text)
		cmd.Parameters.AddWithValue("@Signatory2", frmHR_AddNewContract.cbSignatory2.Text)
		cmd.Parameters.AddWithValue("@Default", frmHR_AddNewContract.chDefaultContract.Checked)
		cmd.Parameters.AddWithValue("@Overtime", frmHR_AddNewContract.chOverTimeAllowed.Checked)
		cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

		If cmd.ExecuteNonQuery = -1 Then
			frmHR_AddNewContract.Close()
			Sel_HRIS_Personnel_ContractHistory_ByID(frmHR_PreviewPersonnelDetails_Contracts.dgvContracts, True)
		End If

		Conn.Close()
		cmd.Parameters.Clear()

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

	''--->>> End of Contracts <<<---

	''--->>> Resume <<<---

	Sub Sel_HRIS_Personnel_Resume_ByID(dgv As DataGridView) 'for preview
		dgv.Rows.Clear()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelHRIS_Personnel_Resume]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						dgv.Rows.Add(
							dr.GetInt32(0),
							dr.GetString(1),
							dr.GetString(2))
					End While
				End Using
				dgv.ClearSelection()
			End Using
		End Using
	End Sub

	Sub BrowseResume(viewer As WebBrowser)
		Dim basePath As String = "\\192.168.0.250\references\DIMS_APPS_INST\Resume\"
		Using ofd As New OpenFileDialog With {.Filter = "PDF/Word Files|*.pdf;*.doc;*.docx", .Title = "Select Resume"}

			If ofd.ShowDialog() <> DialogResult.OK Then Exit Sub

			Dim fileName = IO.Path.GetFileName(ofd.FileName)
			Dim destPath = IO.Path.Combine(basePath, fileName)
			Dim ext = IO.Path.GetExtension(fileName).ToLower()

			If IO.File.Exists(destPath) Then
				MessageBox.Show("File already exists!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Exit Sub
			End If

			IO.File.Copy(ofd.FileName, destPath)

			If ext = ".pdf" Then
				viewer.Navigate(destPath)
			Else
				MessageBox.Show("Word documents will be opened in Word.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If

			frmHR_UpdatePersonnelDetails_Resume.dgvResume.Rows.Add(0, destPath, fileName)
			frmHR_UpdatePersonnelDetails_Resume.dgvResume.ClearSelection()

		End Using
	End Sub

	Sub Del_Personnel_Resume_ByID(fileid As Integer)
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_Personnel_ResumeByID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", fileid)
				cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
				cmd.ExecuteNonQuery()
			End Using
		End Using
	End Sub

	''--->>> End of Resume <<<---

	''--->>> 201 File Checklist <<<---

	Sub Sel_HRIS_Personnel_201FileChecklist_ByID(dgv As DataGridView) 'for preview
		dgv.Rows.Clear()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelHRIS_Personnel_201FileChecklist]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						dgv.Rows.Add(
							dr.GetInt32(0),
							dr.GetInt32(1),
							dr.GetString(2),
							dr.GetString(3),
							dr.GetString(4),
							dr.GetString(5),
							dr.GetString(6),
							dr.GetInt32(7))
					End While
				End Using
				dgv.ClearSelection()
			End Using
		End Using
	End Sub

	Sub Browse201Files(dgv As DataGridView)
		Dim basePath As String = "\\192.168.0.250\references\DIMS_APPS_INST\201Files\"
		Using ofd As New OpenFileDialog With {.Filter = "PDF/Word Files|*.pdf;*.doc;*.docx", .Title = "Choose a File"}

			If dgv.SelectedRows.Count = 0 Then
				MessageBox.Show("No row selected.")
				Exit Sub
			End If

			If ofd.ShowDialog() <> DialogResult.OK Then Exit Sub

			Dim ext As String = IO.Path.GetExtension(ofd.FileName).ToLower()
			Dim randomName As String = IO.Path.GetRandomFileName().Replace(".", "")
			Dim newFileName As String = frmHR_PreviewPersonnelDetails.lblFullName.Text & "_" & _201FileID & "_" & randomName & IO.Path.GetExtension(ofd.FileName).ToLower()
			Dim destPath As String = IO.Path.Combine(basePath, newFileName)

			IO.File.Copy(ofd.FileName, destPath, overwrite:=False)

			dgv.SelectedRows(0).Cells(5).Value = newFileName
			dgv.SelectedRows(0).Cells(6).Value = destPath
			dgv.SelectedRows(0).Cells(7).Value = 1

			With dgv.SelectedRows(0).Cells(3)
				.Value = "Submitted"
				.Style.BackColor = Color.DarkGreen
				.Style.ForeColor = Color.White
				.Style.Font = New Font(dgv.Font, FontStyle.Bold)
			End With

			'Call Sel_HRIS_Personnel_201FileChecklist_ByID(frmHR_UpdatePersonnelDetails_201FileChecklist.dgv201CheckList)

			dgv.ClearSelection()

		End Using
	End Sub

	Sub ProcessDataGridView201Checklist(dgv As DataGridView)
		Try
			Using conn As New SqlConnection(StrConn),
			  cmd As New SqlCommand("spInsUpdHRIS_Personnel_201FileChecklist", conn)

				conn.Open()
				cmd.CommandType = CommandType.StoredProcedure

				For Each row As DataGridViewRow In dgv.Rows
					If row.IsNewRow Then Continue For

					cmd.Parameters.Clear()
					cmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(_strEmployeeID))
					cmd.Parameters.AddWithValue("@ID", If(IsNumeric(row.Cells(0).Value), CInt(row.Cells(0).Value), DBNull.Value))
					cmd.Parameters.AddWithValue("@FieldID", If(IsNumeric(row.Cells(1).Value), CInt(row.Cells(1).Value), DBNull.Value))
					cmd.Parameters.AddWithValue("@FileName", If(row.Cells(5).Value?.ToString(), ""))
					cmd.Parameters.AddWithValue("@isCompleted", If(row.Cells(3).Value?.ToString(), ""))
					cmd.Parameters.AddWithValue("@Remarks", If(row.Cells(4).Value?.ToString(), ""))
					cmd.Parameters.AddWithValue("@isEdited", If(IsNumeric(row.Cells(7).Value), CInt(row.Cells(7).Value), DBNull.Value))
					cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

					cmd.ExecuteNonQuery()
				Next

				MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
				frmHR_PreviewPersonnelDetails.btnEdit.PerformClick()
			End Using
		Catch ex As Exception
			MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub Del_Personnel_201FileChecklist_ByID(fileid As Integer)
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_Personnel_201FileChecklistByID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", fileid)
				cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
				cmd.ExecuteNonQuery()

			End Using
		End Using
	End Sub

	Sub PrintRPT_Employee_201FileChecklist()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_Employee201FileCheckList
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_Employee201FileCheck_List]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							rpt.SetParameterValue("@ID", _strEmployeeID)
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub


	''--->>> End of 201 File Checklist <<<---

	''--->>> Set To Inactive <<<---

	Sub Upd_EmployeeStatus_To_Inactive()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spUpdHRIS_Personnel_201Status]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strEmployeeID)

		cmd.ExecuteNonQuery()
		frmHR_PreviewPersonnelDetails.Close()
		Call frmHRIS_Transaction_EmployeeFile.EmployeeList_Active()

		Conn.Close()
		cmd.Parameters.Clear()

	End Sub


	''--->>> Reports - Certificate of Employment <<<---

	Sub Search_DGVPersonnel_List(_dgvPersonnelList As DataGridView, _txtBoxItemName As TextBox, isActive As Boolean, LoggedInEmployeeID As Nullable(Of Integer))

		_dgvPersonnelList.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Reports_Employee_Search]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@PersonnelSearch", _txtBoxItemName.Text)
		cmd.Parameters.AddWithValue("@isActive", isActive)
		cmd.Parameters.AddWithValue("@PersonnelID", LoggedInEmployeeID)
		dr = cmd.ExecuteReader()
		If dr.HasRows Then

			While dr.Read()

				_dgvPersonnelList.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2))
			End While

		Else

			MessageBox.Show("Record not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

		End If

		dr.Dispose()
		Conn.Dispose()

		_dgvPersonnelList.ClearSelection()

	End Sub

	Sub Sel_HRIS_Personnel_COE_Issued_List(dgv As DataGridView)
		dgv.Rows.Clear()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelHRIS_COE_Issued_List]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						dgv.Rows.Add(
							dr.GetInt32(0),
							dr.GetInt32(1),
							dr.GetString(2),
							dr.GetString(3),
							dr.GetString(4),
							dr.GetString(5),
							dr.GetString(6),
							dr.GetString(7),
							Convert.ToDateTime(dr(8)),
							dr.GetString(9),
							dr.GetInt32(10))
					End While
				End Using
				dgv.ClearSelection()
			End Using
		End Using
	End Sub

	Sub InsUpd_COE_References()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spInsUpdHRIS_Personnel_COE_References]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
				}

		cmd.Parameters.AddWithValue("@ID", _COEID1)
		cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
		cmd.Parameters.AddWithValue("@ReferenceNo", frmHRIS_Report_RequestPurpose.txtReferenceNo.Text)
		cmd.Parameters.AddWithValue("@Purpose", frmHRIS_Report_RequestPurpose.txtPurpose.Text)
		cmd.Parameters.AddWithValue("@COEType", _COEType)
		cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
		cmd.ExecuteNonQuery()

		Conn.Close()
		cmd.Parameters.Clear()
		MessageBox.Show("Saved.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Call Sel_HRIS_Personnel_COE_Issued_List(frmHRIS_Report_COE_PreviewList.dgvCOE) 'to update dgv
	End Sub

	Sub PrintRPT_COE_Current_NO_GAP()

		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh()

		Dim rpt = New HRIS_COE_CURRENT_NO_GAP

		rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
		rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

		Conn = New SqlConnection(StrConn)
		Try
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spSelRptHRIS_COE_CurrentNoGap]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
			cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
			cmd.Parameters.AddWithValue("@ID", _COEID1)
			cmd.Parameters.AddWithValue("@TypeID", _COEType)
			dr = cmd.ExecuteReader()
			If dr.HasRows Then

				While (dr.Read)
					rpt.SetParameterValue("@EmployeeID", _strEmployeeID)
					rpt.SetParameterValue("@ID", _COEID1)
					rpt.SetParameterValue("@TypeID", _COEType)
				End While

				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
				frmHRIS_Report_CrystalReportsHolder.ShowDialog()
				frmHRIS_Report_RequestPurpose.Close()
			Else
				MessageBox.Show("Error Occured, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		Catch ex As Exception
			MsgBox("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
		Finally
			dr.Close()
			Conn.Close()
			frmLoading.Close()
		End Try

	End Sub

	Sub PrintRPT_COE_Current_WITH_GAP()

		frmLoading.Show()
		frmLoading.Refresh()

		Dim rpt = New HRIS_COE_CURRENT_WITH_GAP

		rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
		rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

		Conn = New SqlConnection(StrConn)
		Try
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spSelRptHRIS_COE_CurrentWithGap]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
			cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
			cmd.Parameters.AddWithValue("@ID", _COEID1)
			cmd.Parameters.AddWithValue("@TypeID", _COEType)
			dr = cmd.ExecuteReader()
			If dr.HasRows Then

				While (dr.Read)
					rpt.SetParameterValue("@EmployeeID", _strEmployeeID)
					rpt.SetParameterValue("@ID", _COEID1)
					rpt.SetParameterValue("@TypeID", _COEType)
				End While

				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
				frmHRIS_Report_CrystalReportsHolder.ShowDialog()
				frmHRIS_Report_RequestPurpose.Close()
			Else
				MessageBox.Show("Error Occured, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		Catch ex As Exception
			MsgBox("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
		Finally
			dr.Close()
			Conn.Close()
			frmLoading.Close()
		End Try

	End Sub

	Sub PrintRPT_COE_Current_WITH_COMPENSATION_ITEMIZED()

		frmLoading.Show()
		frmLoading.Refresh()

		Dim rpt = New HRIS_COE_CURRENT_WITH_COMPENSATION_ITEMIZED

		rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
		rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

		Conn = New SqlConnection(StrConn)
		Try
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spSelRptHRIS_COE_CurrentWithCompensationItemized]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
			cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
			cmd.Parameters.AddWithValue("@ID", _COEID1)
			cmd.Parameters.AddWithValue("@TypeID", _COEType)
			dr = cmd.ExecuteReader()
			If dr.HasRows Then

				While (dr.Read)
					rpt.SetParameterValue("@EmployeeID", _strEmployeeID)
					rpt.SetParameterValue("@ID", _COEID1)
					rpt.SetParameterValue("@TypeID", _COEType)
				End While

				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
				frmHRIS_Report_CrystalReportsHolder.ShowDialog()
				frmHRIS_Report_RequestPurpose.Close()
			Else
				MessageBox.Show("Error Occured, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		Catch ex As Exception
			MsgBox("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
		Finally
			dr.Close()
			Conn.Close()
			frmLoading.Close()
		End Try

	End Sub

	Sub PrintRPT_COE_Current_WITH_COMPENSATION_ITEMIZED_WITH_GAP()

		frmLoading.Show()
		frmLoading.Refresh()

		Dim rpt = New HRIS_COE_CURRENT_WITH_COMPENSATION_ITEMIZED_WITH_GAP

		rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
		rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

		Conn = New SqlConnection(StrConn)
		Try
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spSelRptHRIS_COE_CurrentWithCompensationItemizedWithGap]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
			cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
			cmd.Parameters.AddWithValue("@ID", _COEID1)
			cmd.Parameters.AddWithValue("@TypeID", _COEType)
			dr = cmd.ExecuteReader()
			If dr.HasRows Then

				While (dr.Read)
					rpt.SetParameterValue("@EmployeeID", _strEmployeeID)
					rpt.SetParameterValue("@ID", _COEID1)
					rpt.SetParameterValue("@TypeID", _COEType)
				End While

				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
				frmHRIS_Report_CrystalReportsHolder.ShowDialog()
				frmHRIS_Report_RequestPurpose.Close()
			Else
				MessageBox.Show("Error Occured, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		Catch ex As Exception
			MsgBox("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
		Finally
			dr.Close()
			Conn.Close()
			frmLoading.Close()
		End Try

	End Sub

	Sub PrintRPT_COE_Current_WITH_COMPENSATION_ANNUALIZED()

		frmLoading.Show()
		frmLoading.Refresh()

		Dim rpt = New HRIS_COE_CURRENT_WITH_COMPENSATION_ANNUALIZED

		rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
		rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

		Conn = New SqlConnection(StrConn)
		Try
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spSelRptHRIS_COE_CurrentWithCompensationAnnualized]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
			cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
			cmd.Parameters.AddWithValue("@ID", _COEID1)
			cmd.Parameters.AddWithValue("@TypeID", _COEType)
			dr = cmd.ExecuteReader()
			If dr.HasRows Then

				While (dr.Read)
					rpt.SetParameterValue("@EmployeeID", _strEmployeeID)
					rpt.SetParameterValue("@ID", _COEID1)
					rpt.SetParameterValue("@TypeID", _COEType)
				End While

				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
				frmHRIS_Report_CrystalReportsHolder.ShowDialog()
				frmHRIS_Report_RequestPurpose.Close()
			Else
				MessageBox.Show("Error Occured, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		Catch ex As Exception
			MsgBox("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
		Finally
			dr.Close()
			Conn.Close()
			frmLoading.Close()
		End Try

	End Sub

	Sub PrintRPT_COE_Current_WITH_COMPENSATION_ANNUALIZED_WITH_GAP()

		frmLoading.Show()
		frmLoading.Refresh()

		Dim rpt = New HRIS_COE_CURRENT_WITH_COMPENSATION_ANNUALIZED_WITH_GAP

		rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
		rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

		Conn = New SqlConnection(StrConn)
		Try
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spSelRptHRIS_COE_CurrentWithCompensationAnnualizedWithGap]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
			cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
			cmd.Parameters.AddWithValue("@ID", _COEID1)
			cmd.Parameters.AddWithValue("@TypeID", _COEType)
			dr = cmd.ExecuteReader()
			If dr.HasRows Then

				While (dr.Read)
					rpt.SetParameterValue("@EmployeeID", _strEmployeeID)
					rpt.SetParameterValue("@ID", _COEID1)
					rpt.SetParameterValue("@TypeID", _COEType)
				End While

				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
				frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
				frmHRIS_Report_CrystalReportsHolder.ShowDialog()
				frmHRIS_Report_RequestPurpose.Close()
			Else
				MessageBox.Show("Error Occured, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		Catch ex As Exception
			MsgBox("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
		Finally
			dr.Close()
			Conn.Close()
			frmLoading.Close()
		End Try

	End Sub

	Sub PrintRPT_COE_SEPARATED_AND_CLEARED()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New HRIS_COE_SEPARATED_AND_CLEARED
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spSelRptHRIS_COE_SeparatedAndCleared]", Conn)
					cmd.CommandType = CommandType.StoredProcedure

					cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
					cmd.Parameters.AddWithValue("@ID", _COEID1)
					cmd.Parameters.AddWithValue("@TypeID", _COEType)

					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then

							rpt.SetParameterValue("@EmployeeID", _strEmployeeID)
							rpt.SetParameterValue("@ID", _COEID1)
							rpt.SetParameterValue("@TypeID", _COEType)

							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
							frmHRIS_Report_CrystalReportsHolder.ShowDialog()

						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	Sub PrintRPT_COE_SEPARATED_AND_NOT_CLEARED()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New HRIS_COE_SEPARATED_AND_NOT_CLEARED
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spSelRptHRIS_COE_SeparatedAndCleared]", Conn)
					cmd.CommandType = CommandType.StoredProcedure

					cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
					cmd.Parameters.AddWithValue("@ID", _COEID1)
					cmd.Parameters.AddWithValue("@TypeID", _COEType)

					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then

							rpt.SetParameterValue("@EmployeeID", _strEmployeeID)
							rpt.SetParameterValue("@ID", _COEID1)
							rpt.SetParameterValue("@TypeID", _COEType)

							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
							frmHRIS_Report_CrystalReportsHolder.ShowDialog()

						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub



	''--->>> Reports - End of Certificate of Employment <<<---

	''--->>> Reports - Employee <<<---

	Sub PrintRPT_Employee_isInActive(stat As Boolean)
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_isActiveEmployee_List
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_isActiveEmployee_MasterList]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@isInactive", stat)

					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							rpt.SetParameterValue("@isInactive", stat)
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	Sub PrintRPT_Employee_ByDepartment()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_EmployeeByDepartment_List
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_EmployeeByDepartment_List]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	Sub PrintRPT_Employee_AdhocInformation()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_EmployeeAdhocInfo_List
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_EmployeeAdhocInfo_List]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	Sub PrintRPT_Employee_ByJobPosition(id As Integer)
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_EmployeeByJobPosition_List
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_EmployeeByJobPosition_List]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@ID", id)

					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							rpt.SetParameterValue("@ID", id)
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using

				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	Sub PrintRPT_Employee_LeaveEncashment()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_EmployeeLeaveEncashment_List
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_Employee_LeaveEncashment_List]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	Sub PrintRPT_Employee_LeaveBalances()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_EmployeeLeaveBalances_List
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_Employee_LeaveBalances_List]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	Sub PrintRPT_Employee_Birthdates()

		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh()

		Try
			Dim rpt As New rptHRIS_EmployeeBirthdate_List()

			' === dynamic connection info ===
			Dim crConn As New CrystalDecisions.Shared.ConnectionInfo()
			crConn.ServerName = ServerIP
			crConn.DatabaseName = DatabaseName
			crConn.UserID = DBUser
			crConn.Password = DBPass

			' === Apply connection info to main report ===
			For Each t As CrystalDecisions.CrystalReports.Engine.Table In rpt.Database.Tables
				Dim logonInfo As CrystalDecisions.Shared.TableLogOnInfo = t.LogOnInfo
				logonInfo.ConnectionInfo = crConn
				t.ApplyLogOnInfo(logonInfo)
			Next

			' === Apply to subreports (if any) ===
			For Each sr As CrystalDecisions.CrystalReports.Engine.ReportDocument In rpt.Subreports
				For Each t As CrystalDecisions.CrystalReports.Engine.Table In sr.Database.Tables
					Dim logonInfo As CrystalDecisions.Shared.TableLogOnInfo = t.LogOnInfo
					logonInfo.ConnectionInfo = crConn
					t.ApplyLogOnInfo(logonInfo)
				Next
			Next

			' verify if db is found
			rpt.VerifyDatabase()
			rpt.Refresh()

			' === Set report source ===
			frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
			frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}",
						"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close()
		End Try

	End Sub

	Sub PrintRPT_Employee_201File()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_Employee201_File
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_Employee201_File]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							rpt.SetParameterValue("@ID", _strEmployeeID)
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	Sub PrintRPT_Employee_201FileSummary()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_Employee201FileSummary
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_Employee201FileCheck_List_Summary]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					'cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							'rpt.SetParameterValue("@ID", _strEmployeeID)
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub


	''--->>> Reports - End of Employee <<<---

	''--->>> Reports - Company <<<---

	Sub PrintRPT_Company_List()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_Company_Masterlist
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_Company_Masterlist]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					'cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							'rpt.SetParameterValue("@ID", _strEmployeeID)
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	''--->>> Reports - End of Company <<<---

	''--->>> Reports - Department <<<---

	Sub PrintRPT_Department_List()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_Department_Masterlist
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_Department_Masterlist]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					'cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							'rpt.SetParameterValue("@ID", _strEmployeeID)
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	''--->>> Reports - End of Department <<<---

	''--->>> Reports - Training <<<---

	Sub PrintRPT_Training_List()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_Training_Masterlist
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_Training_Masterlist]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					'cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							'rpt.SetParameterValue("@ID", _strEmployeeID)
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_MainPreview.HRIS_CrystalReports_Holder.Refresh()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	''--->>> Reports - End of Department <<<---


	''--->>> Transaction - Training Management - Enrollment <<<---

	Sub Select_TE_TrainingList_Master(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_TrainingList]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
				dr(0).ToString,
				dr(1).ToString,
				dr(2).ToString,
				dr(3).ToString,
				dr(4).ToString,
				dr(5).ToString
				)
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub Select_TE_BatchList_Master(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_TrainingBatchByID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@TrainingID", _TrainingListID)
		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
				dr(0).ToString,
				dr(1).ToString,
				dr(2).ToString,
				dr(3).ToString,
				dr(4).ToString,
				dr(5).ToString,
				dr(6).ToString,
				dr(7).ToString,
				dr(8).ToString)
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub Select_TE_EnrolledList_Master(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_EnrolledEmployeeByID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@BatchID", _TrainingBatchListID)
		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
				dr(0).ToString,
				dr(1).ToString,
				dr(2).ToString,
				dr(3).ToString,
				dr(4).ToString,
				dr(5).ToString)
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub InsUpd_TE_TrainingList()

		Try

			Using Conn As New SqlConnection(StrConn),
			cmd As New SqlCommand("[spInsUpdHRIS_Training_TrainingList]", Conn)
				Conn.Open()

				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _TrainingListID)
				cmd.Parameters.AddWithValue("@Name", frmHRIS_TE_AddUpdateTraining_Master.txtName.Text)
				cmd.Parameters.AddWithValue("@Description", frmHRIS_TE_AddUpdateTraining_Master.txtDescription.Text)
				cmd.Parameters.AddWithValue("@Remarks", frmHRIS_TE_AddUpdateTraining_Master.txtRemarks.Text)
				cmd.Parameters.AddWithValue("@TrainingCategory", frmHRIS_TE_AddUpdateTraining_Master.cbTrainingCategory.Text)
				cmd.Parameters.AddWithValue("@TrainingNature", frmHRIS_TE_AddUpdateTraining_Master.cbTrainingNature.Text)
				cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()

				MessageBox.Show("Training saved.")

				frmHRIS_TE_AddUpdateTraining_Master.Dispose()
				frmHRIS_Transaction_TrainingEnrollment.RefreshDataGridViewTrainingList()

			End Using

			dr.Close()
			Conn.Close()

		Catch ex As Exception
			MsgBox("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
		End Try

	End Sub

	Sub SelUpd_Training_TrainingList_ByID()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelUpdHRIS_Training_TrainingListByID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _TrainingListID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			frmHRIS_TE_AddUpdateTraining_Master.txtName.Text = dr.GetString(0)
			frmHRIS_TE_AddUpdateTraining_Master.txtDescription.Text = dr.GetString(1)
			frmHRIS_TE_AddUpdateTraining_Master.txtRemarks.Text = dr.GetString(2)

			Dim catIndex As Integer = frmHRIS_TE_AddUpdateTraining_Master.cbTrainingCategory.FindStringExact(dr(3).ToString())
			If catIndex <> -1 Then frmHRIS_TE_AddUpdateTraining_Master.cbTrainingCategory.SelectedIndex = catIndex

			Dim typeIndex As Integer = frmHRIS_TE_AddUpdateTraining_Master.cbTrainingNature.FindStringExact(dr(4).ToString())
			If typeIndex <> -1 Then frmHRIS_TE_AddUpdateTraining_Master.cbTrainingNature.SelectedIndex = typeIndex

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

	Sub SelTrainingBatchNumber(TrainingID As Integer)

		Try
			Using Conn As New SqlConnection(StrConn),
		  cmd As New SqlCommand("[spSelHRIS_BatchNumber]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@TrainingID", TrainingID)
				Dim voucherCodeParam As New SqlParameter("@BatchNo", SqlDbType.VarChar, 20)
				voucherCodeParam.Direction = ParameterDirection.Output
				cmd.Parameters.Add(voucherCodeParam)
				Conn.Open()
				cmd.ExecuteNonQuery()
				frmHRIS_TE_AddUpdateTrainingDetail_Master.txtBatchNumber.Text = cmd.Parameters("@BatchNo").Value.ToString()
			End Using
		Catch ex As Exception
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

	End Sub

	Sub InsUpd_TE_TrainingDetail()

		Try

			Using Conn As New SqlConnection(StrConn),
			cmd As New SqlCommand("[spInsUpdHRIS_Training_TrainingDetail]", Conn)
				Conn.Open()

				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _TrainingBatchListID)
				cmd.Parameters.AddWithValue("@TrainingID", _TrainingListID)
				cmd.Parameters.AddWithValue("@Code", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtCode.Text)
				cmd.Parameters.AddWithValue("@BatchNo", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtBatchNumber.Text)
				cmd.Parameters.AddWithValue("@PlanStartDate", frmHRIS_TE_AddUpdateTrainingDetail_Master.dtpPlanStartDate.Value.Date)
				cmd.Parameters.AddWithValue("@PlanEndDate", frmHRIS_TE_AddUpdateTrainingDetail_Master.dtpPlanEndDate.Value.Date)
				cmd.Parameters.AddWithValue("@ActualStartDate", frmHRIS_TE_AddUpdateTrainingDetail_Master.dtpActualStartDate.Value.Date)
				cmd.Parameters.AddWithValue("@ActualEndDate", frmHRIS_TE_AddUpdateTrainingDetail_Master.dtpActualEndDate.Value.Date)
				cmd.Parameters.AddWithValue("@Venue", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtVenue.Text)
				cmd.Parameters.AddWithValue("@Facilitator", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtFacilitator.Text)
				cmd.Parameters.AddWithValue("@ResourcePerson", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtResourcePerson.Text)
				cmd.Parameters.AddWithValue("@TrainingHours", Decimal.Parse(frmHRIS_TE_AddUpdateTrainingDetail_Master.txtHours.Text))
				cmd.Parameters.AddWithValue("@CertificateNotes", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtCertificateNotes.Text)
				cmd.Parameters.AddWithValue("@Signatory1", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSignatory1.Text)
				cmd.Parameters.AddWithValue("@TitleSignatory1", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSinatoryTitle1.Text)
				cmd.Parameters.AddWithValue("@Signatory2", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSignatory2.Text)
				cmd.Parameters.AddWithValue("@TitleSignatory2", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSinatoryTitle2.Text)
				cmd.Parameters.AddWithValue("@Signatory3", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSignatory3.Text)
				cmd.Parameters.AddWithValue("@TitleSignatory3", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSinatoryTitle3.Text)
				cmd.Parameters.AddWithValue("@Signatory4", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSignatory4.Text)
				cmd.Parameters.AddWithValue("@TitleSignatory4", frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSinatoryTitle4.Text)
				cmd.Parameters.AddWithValue("@Status", frmHRIS_TE_AddUpdateTrainingDetail_Master.cbTrainingStatus.Text)
				cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

				cmd.ExecuteNonQuery()

				MessageBox.Show("Training Batch saved.")
				frmHRIS_TE_AddUpdateTrainingDetail_Master.Dispose()
				frmHRIS_Transaction_TrainingEnrollment.RefreshDataGridViewTrainingBatchList()

			End Using

			dr.Close()
			Conn.Close()

		Catch ex As Exception
			MsgBox("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
		End Try

	End Sub

	Sub SelUpd_Training_TrainingDetail_ByID()

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelUpdHRIS_Training_TrainingDetailByID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _TrainingBatchListID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtCode.Text = dr.GetString(0)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtBatchNumber.Text = dr.GetString(1)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.dtpPlanStartDate.Value = If(dr.IsDBNull(2), New DateTime(1990, 1, 1), dr.GetDateTime(2))
			frmHRIS_TE_AddUpdateTrainingDetail_Master.dtpPlanEndDate.Value = If(dr.IsDBNull(3), New DateTime(1990, 1, 1), dr.GetDateTime(3))
			frmHRIS_TE_AddUpdateTrainingDetail_Master.dtpActualStartDate.Value = If(dr.IsDBNull(4), New DateTime(1990, 1, 1), dr.GetDateTime(4))
			frmHRIS_TE_AddUpdateTrainingDetail_Master.dtpActualEndDate.Value = If(dr.IsDBNull(5), New DateTime(1990, 1, 1), dr.GetDateTime(5))
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtVenue.Text = dr.GetString(6)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtFacilitator.Text = dr.GetString(7)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtResourcePerson.Text = dr.GetString(8)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtHours.Text = dr.GetDecimal(9)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtCertificateNotes.Text = dr.GetString(10)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSignatory1.Text = dr.GetString(11)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSinatoryTitle1.Text = dr.GetString(12)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSignatory2.Text = dr.GetString(13)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSinatoryTitle2.Text = dr.GetString(14)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSignatory3.Text = dr.GetString(15)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSinatoryTitle3.Text = dr.GetString(16)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSignatory4.Text = dr.GetString(17)
			frmHRIS_TE_AddUpdateTrainingDetail_Master.txtSinatoryTitle4.Text = dr.GetString(18)

			Dim typeIndex As Integer = frmHRIS_TE_AddUpdateTrainingDetail_Master.cbTrainingStatus.FindStringExact(dr(19).ToString())
			If typeIndex <> -1 Then frmHRIS_TE_AddUpdateTrainingDetail_Master.cbTrainingStatus.SelectedIndex = typeIndex

		End While

		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()

	End Sub

	Sub Del_Training_TrainingList_By_ID(dgv As DataGridView)

		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spDelHRIS_Training_TrainingListByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _TrainingListID)

				If cmd.ExecuteNonQuery = -1 Then
					MessageBox.Show("Successfully Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
					dgv.Rows.Remove(dgv.SelectedRows(0))
				End If

				cmd.Parameters.Clear()

			End Using
		End Using

		Conn.Close()

	End Sub

	Sub Del_Training_TrainingDetail_By_ID(dgv As DataGridView)

		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spDelHRIS_Training_TrainingDetailByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _TrainingListID)

				If cmd.ExecuteNonQuery = -1 Then
					MessageBox.Show("Successfully Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
					dgv.Rows.Remove(dgv.SelectedRows(0))
				End If

				cmd.Parameters.Clear()

			End Using
		End Using

		Conn.Close()

	End Sub

	Sub Select_TE_ActiveEmployeeTrainingEnrollment_Master(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelUpdHRIS_ActiveEmployeeForTraining]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@TrainingBatchListID", _TrainingBatchListID)
		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2))
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub Select_TE_TrainingEnrolledEmployee_Master(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelUpdHRIS_EmployeeTrainingEnrollment]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@TrainingDetailID", _TrainingBatchListID)
		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2))
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub InsEmployeeTrainingEnrollment()

		Try

			Using Conn As New SqlConnection(StrConn)
				Using cmd As New SqlCommand("[spInsHRIS_Training_EmployeeEnrollment]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					Conn.Open()
					'cmd.Parameters.AddWithValue("@PersonnelID", frmHRIS_TE_AddUpdateTrainingEnrollee_Master.Label12.Text)
					cmd.Parameters.AddWithValue("@PersonnelID", _TrainingEmployeeID)
					cmd.Parameters.AddWithValue("@TrainingDetailID", _TrainingBatchListID)
					cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

					If cmd.ExecuteNonQuery = -1 Then
						' Proc. : Call the function to refresh the list of available employee for trainings.
						Call Select_TE_ActiveEmployeeTrainingEnrollment_Master(frmHRIS_TE_AddUpdateTrainingEnrollee_Master.dgvActiveEmployees)
						' Proc. : Call the function to refresh the training DGV.
						Call Select_TE_TrainingEnrolledEmployee_Master(frmHRIS_TE_AddUpdateTrainingEnrollee_Master.dgvAddedEmployees)
					End If

				End Using
			End Using

			Conn.Close()

		Catch ex As Exception
			MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

	End Sub

	Sub DelEmployeeTrainingEnrollment()

		Using Conn As New SqlConnection(StrConn)
			Using cmd As New SqlCommand("[spDelHRIS_EmployeeTrainingEnrollment]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				Conn.Open()

				' cmd.Parameters.AddWithValue("@PersonnelID", frmHRIS_TE_AddUpdateTrainingEnrollee_Master.Label12.Text)
				cmd.Parameters.AddWithValue("@PersonnelID", _TrainingEmployeeID)
				cmd.Parameters.AddWithValue("@TrainingDetailID", _TrainingBatchListID)

				If cmd.ExecuteNonQuery = -1 Then

					' Proc. : Call the function to refresh the list of available employee for trainings.
					Call Select_TE_ActiveEmployeeTrainingEnrollment_Master(frmHRIS_TE_AddUpdateTrainingEnrollee_Master.dgvActiveEmployees)

					' Proc. : Call the function to refresh the training dgv.
					Call Select_TE_TrainingEnrolledEmployee_Master(frmHRIS_TE_AddUpdateTrainingEnrollee_Master.dgvAddedEmployees)

				End If
			End Using
		End Using

		Conn.Close()

	End Sub

	''--->>> Transaction - Training Management - End of Enrollment <<<---


	''--->>> Transaction - Training Management - Evaluation <<<---

	Sub Select_TEF_EmployeeList_Main(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_EmployeeByInChargeID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@EmployeeCode", frmMain.ToolStripEmployeeNo.Text)
		cmd.Parameters.AddWithValue("@AccessRights", frmMain.ToolStripAccessRights.Text)
		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
				dr(0).ToString,
				dr(1).ToString,
				dr(2).ToString,
				dr(3).ToString,
				dr(4).ToString)
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub


	Sub Select_TEF_TrainingListByEmployeeID_PendingRate(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_Training_AttendedByEmpID_PendingRater]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@EmployeeID", _TrainingEmployeeID)
		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
				dr(0).ToString,
				dr(1).ToString,
				dr(2).ToString,
				dr(3).ToString,
				dr(4).ToString,
				dr(5).ToString,
				dr(6).ToString,
				dr(7).ToString,
				dr(8).ToString)
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub SelUpd_TEF_TrainingEvaluationByMngrID()
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As SqlCommand = Conn.CreateCommand()
					cmd.CommandText = "[spSelUpdHRIS_Training_TrainingEvaluationBySuperior]"
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@PersonnelID", _TrainingEmployeeID)
					cmd.Parameters.AddWithValue("@TrainingSubDetailID", _TrainingSubDetailID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.Read() Then

							frmHRIS_TEF_Feedback_BySuperior.txtNameParticipant.Text = dr.GetString(0)
							frmHRIS_TEF_Feedback_BySuperior.txtTitleSeminar.Text = dr.GetString(1)
							frmHRIS_TEF_Feedback_BySuperior.txtFacilitator.Text = dr.GetString(2)
							frmHRIS_TEF_Feedback_BySuperior.txtDateConducted.Text = dr.GetString(3)

							frmHRIS_TEF_Feedback_BySuperior.cbTrainingType1.Checked = (dr.GetInt32(4) = 900)
							frmHRIS_TEF_Feedback_BySuperior.cbTrainingType2.Checked = (dr.GetInt32(4) = 903)
							frmHRIS_TEF_Feedback_BySuperior.cbTrainingType3.Checked = (dr.GetInt32(4) = 901)
							frmHRIS_TEF_Feedback_BySuperior.txtTrainingType4.Text = If(dr.GetInt32(4) = 902, "Echo Sessions", "")

							' 1st Section [Checkbox Feedback]
							frmHRIS_TEF_Feedback_BySuperior.cb1.Checked = (dr.GetInt32(5) = 877)
							frmHRIS_TEF_Feedback_BySuperior.cb2.Checked = (dr.GetInt32(5) = 878)
							frmHRIS_TEF_Feedback_BySuperior.cb3.Checked = (dr.GetInt32(5) = 879)

							' 2nd Section [Checkbox Feedback]
							frmHRIS_TEF_Feedback_BySuperior.cb4.Checked = (dr.GetInt32(6) = 880)
							frmHRIS_TEF_Feedback_BySuperior.cb5.Checked = (dr.GetInt32(6) = 881)
							frmHRIS_TEF_Feedback_BySuperior.cb6.Checked = (dr.GetInt32(6) = 882)

							' 3rd Section [Checkbox Feedback]
							frmHRIS_TEF_Feedback_BySuperior.cb7.Checked = (dr.GetInt32(7) = 883)
							frmHRIS_TEF_Feedback_BySuperior.cb8.Checked = (dr.GetInt32(7) = 884)
							frmHRIS_TEF_Feedback_BySuperior.cb9.Checked = (dr.GetInt32(7) = 885)

							' 4th Section [Checkbox Feedback]
							frmHRIS_TEF_Feedback_BySuperior.cb10.Checked = (dr.GetInt32(8) = 886)
							frmHRIS_TEF_Feedback_BySuperior.cb11.Checked = (dr.GetInt32(8) = 887)
							frmHRIS_TEF_Feedback_BySuperior.cb12.Checked = (dr.GetInt32(8) = 888)

							' 5th Section [Checkbox Feedback]
							frmHRIS_TEF_Feedback_BySuperior.cb13.Checked = (dr.GetInt32(9) = 889)
							frmHRIS_TEF_Feedback_BySuperior.cb14.Checked = (dr.GetInt32(9) = 890)
							frmHRIS_TEF_Feedback_BySuperior.cb15.Checked = (dr.GetInt32(9) = 891)

							' 1st Section [Checkbox Ratings]
							frmHRIS_TEF_Feedback_BySuperior.cbr1.Checked = (dr.GetInt32(10) = 1)
							frmHRIS_TEF_Feedback_BySuperior.cbr2.Checked = (dr.GetInt32(10) = 2)
							frmHRIS_TEF_Feedback_BySuperior.cbr3.Checked = (dr.GetInt32(10) = 3)
							frmHRIS_TEF_Feedback_BySuperior.cbr4.Checked = (dr.GetInt32(10) = 4)

							frmHRIS_TEF_Feedback_BySuperior.txtImprovSuggestion.Text = dr.GetString(11)
							frmHRIS_TEF_Feedback_BySuperior.txtFeedback1.Text = dr.GetString(12)
							frmHRIS_TEF_Feedback_BySuperior.txtFeedback2.Text = dr.GetString(13)

							' Part III. Post Evaluation Feedback ( If there is an existing record. )

							' 1st Section of Effectiveness [ Checkbox ]
							frmHRIS_TEF_Feedback_BySuperior.cbe1.Checked = (dr.GetInt32(14) = 2)
							frmHRIS_TEF_Feedback_BySuperior.cbe2.Checked = (dr.GetInt32(14) = 1)
							frmHRIS_TEF_Feedback_BySuperior.cbe3.Checked = (dr.GetInt32(14) = 3)

							' 2nd Section of Effectiveness [ Checkbox ]
							frmHRIS_TEF_Feedback_BySuperior.cbe4.Checked = (dr.GetInt32(15) = 2)
							frmHRIS_TEF_Feedback_BySuperior.cbe5.Checked = (dr.GetInt32(15) = 1)
							frmHRIS_TEF_Feedback_BySuperior.cbe6.Checked = (dr.GetInt32(15) = 3)

							' 3rd Section of Effectiveness [ Checkbox ]
							frmHRIS_TEF_Feedback_BySuperior.cbe7.Checked = (dr.GetInt32(16) = 2)
							frmHRIS_TEF_Feedback_BySuperior.cbe8.Checked = (dr.GetInt32(16) = 1)
							frmHRIS_TEF_Feedback_BySuperior.cbe9.Checked = (dr.GetInt32(16) = 3)

							frmHRIS_TEF_Feedback_BySuperior.cbd1.Checked = (dr.GetBoolean(17) = "True")
							frmHRIS_TEF_Feedback_BySuperior.cbd2.Checked = (dr.GetBoolean(18) = "True")
							frmHRIS_TEF_Feedback_BySuperior.cbd3.Checked = (dr.GetString(19) <> Nothing)
							frmHRIS_TEF_Feedback_BySuperior.txtDimension1.Text = dr.GetString(19)

							frmHRIS_TEF_Feedback_BySuperior.cbd4.Checked = (dr.GetBoolean(20) = "True")
							frmHRIS_TEF_Feedback_BySuperior.cbd5.Checked = (dr.GetBoolean(21) = "True")
							frmHRIS_TEF_Feedback_BySuperior.cbd6.Checked = (dr.GetString(22) <> Nothing)
							frmHRIS_TEF_Feedback_BySuperior.txtDimension2.Text = dr.GetString(22)

							frmHRIS_TEF_Feedback_BySuperior.cbd7.Checked = (dr.GetBoolean(23) = "True")
							frmHRIS_TEF_Feedback_BySuperior.cbd8.Checked = (dr.GetBoolean(24) = "True")
							frmHRIS_TEF_Feedback_BySuperior.cbd9.Checked = (dr.GetBoolean(25) = "True")
							frmHRIS_TEF_Feedback_BySuperior.cbd10.Checked = (dr.GetBoolean(26) = "True")
							frmHRIS_TEF_Feedback_BySuperior.cbd11.Checked = (dr.GetString(27) <> Nothing)
							frmHRIS_TEF_Feedback_BySuperior.txtDimension3.Text = dr.GetString(27)

							frmHRIS_TEF_Feedback_BySuperior.txtRecommendedTraining.Text = dr.GetString(28)
							frmHRIS_TEF_Feedback_BySuperior.cbTimeFrame.Text = dr.GetString(29)

							frmHRIS_TEF_Feedback_BySuperior.Label8.Text = dr.GetString(30)

						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Try
	End Sub

	Sub InsUpd_TEF_TrainingEvaluationFeedbackByMngrID()

		Try

			Dim Effectiveness1 As Integer = 0
			Dim Effectiveness2 As Integer = 0
			Dim Effectiveness3 As Integer = 0
			Dim Dimension1S1 As Boolean = False
			Dim Dimension1S2 As Boolean = False
			Dim Dimension1S3 As String = ""
			Dim Dimension2S1 As Boolean = False
			Dim Dimension2S2 As Boolean = False
			Dim Dimension2S3 As String = ""
			Dim Dimension3S1 As Boolean = False
			Dim Dimension3S2 As Boolean = False
			Dim Dimension3S3 As Boolean = False
			Dim Dimension3S4 As Boolean = False
			Dim Dimension3S5 As String = ""

			If frmHRIS_TEF_Feedback_BySuperior.cbe1.Checked Then Effectiveness1 = 2
			If frmHRIS_TEF_Feedback_BySuperior.cbe2.Checked Then Effectiveness1 = 1
			If frmHRIS_TEF_Feedback_BySuperior.cbe3.Checked Then Effectiveness1 = 3

			If frmHRIS_TEF_Feedback_BySuperior.cbe4.Checked Then Effectiveness2 = 2
			If frmHRIS_TEF_Feedback_BySuperior.cbe5.Checked Then Effectiveness2 = 1
			If frmHRIS_TEF_Feedback_BySuperior.cbe6.Checked Then Effectiveness2 = 3

			If frmHRIS_TEF_Feedback_BySuperior.cbe7.Checked Then Effectiveness3 = 2
			If frmHRIS_TEF_Feedback_BySuperior.cbe8.Checked Then Effectiveness3 = 1
			If frmHRIS_TEF_Feedback_BySuperior.cbe9.Checked Then Effectiveness3 = 3

			If frmHRIS_TEF_Feedback_BySuperior.cbd1.Checked Then Dimension1S1 = True
			If frmHRIS_TEF_Feedback_BySuperior.cbd2.Checked Then Dimension1S2 = True
			If frmHRIS_TEF_Feedback_BySuperior.cbd3.Checked Then Dimension1S3 = frmHRIS_TEF_Feedback_BySuperior.txtDimension1.Text

			If frmHRIS_TEF_Feedback_BySuperior.cbd4.Checked Then Dimension2S1 = True
			If frmHRIS_TEF_Feedback_BySuperior.cbd5.Checked Then Dimension2S2 = True
			If frmHRIS_TEF_Feedback_BySuperior.cbd6.Checked Then Dimension2S3 = frmHRIS_TEF_Feedback_BySuperior.txtDimension2.Text

			If frmHRIS_TEF_Feedback_BySuperior.cbd7.Checked Then Dimension3S1 = True
			If frmHRIS_TEF_Feedback_BySuperior.cbd8.Checked Then Dimension3S2 = True
			If frmHRIS_TEF_Feedback_BySuperior.cbd9.Checked Then Dimension3S3 = True
			If frmHRIS_TEF_Feedback_BySuperior.cbd10.Checked Then Dimension3S4 = True
			If frmHRIS_TEF_Feedback_BySuperior.cbd11.Checked Then Dimension3S5 = frmHRIS_TEF_Feedback_BySuperior.txtDimension3.Text

			Using Conn As New SqlConnection(StrConn),
				 cmd As New SqlCommand("[spInsUpdHRIS_Training_TrainingEvaluationBySuperior]", Conn)
				Conn.Open()
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@TrainingSubDetailID", _TrainingSubDetailID)
				cmd.Parameters.AddWithValue("@EmployeeID", _TrainingEmployeeID)
				cmd.Parameters.AddWithValue("@Effectiveness1", Effectiveness1)
				cmd.Parameters.AddWithValue("@Effectiveness2", Effectiveness2)
				cmd.Parameters.AddWithValue("@Effectiveness3", Effectiveness3)
				cmd.Parameters.AddWithValue("@Dimension1s1", Dimension1S1)
				cmd.Parameters.AddWithValue("@Dimension1s2", Dimension1S2)
				cmd.Parameters.AddWithValue("@Dimension1s3", Dimension1S3)
				cmd.Parameters.AddWithValue("@Dimension2s1", Dimension2S1)
				cmd.Parameters.AddWithValue("@Dimension2s2", Dimension2S2)
				cmd.Parameters.AddWithValue("@Dimension2s3", Dimension2S3)
				cmd.Parameters.AddWithValue("@Dimension3s1", Dimension3S1)
				cmd.Parameters.AddWithValue("@Dimension3s2", Dimension3S2)
				cmd.Parameters.AddWithValue("@Dimension3s3", Dimension3S3)
				cmd.Parameters.AddWithValue("@Dimension3s4", Dimension3S4)
				cmd.Parameters.AddWithValue("@Dimension3s5", Dimension3S5)
				cmd.Parameters.AddWithValue("@MngrRecommendation", frmHRIS_TEF_Feedback_BySuperior.txtRecommendedTraining.Text)
				cmd.Parameters.AddWithValue("@TimeFrame", frmHRIS_TEF_Feedback_BySuperior.cbTimeFrame.Text)
				cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text) 'this is also set as superior id

				cmd.ExecuteNonQuery()

				MessageBox.Show("Successfully Submitted Evaluation Form, Thank You!")
				frmHRIS_TEF_Feedback_BySuperior.Dispose()

				Call Select_TEF_TrainingListByEmployeeID_PendingRate(frmHRIS_Transaction_TrainingEvaluation.dgvEvaluationTraining)

			End Using

			Conn.Close()

		Catch ex As Exception
			MessageBox.Show("Error: " & ex.Message)
		End Try

	End Sub

	Sub InsUpd_TE_TrainingEvaluationFeedback()

		Try
			Dim Section1Value As Integer = 0
			Dim Section2Value As Integer = 0
			Dim Section3Value As Integer = 0
			Dim Section4Value As Integer = 0
			Dim Section5Value As Integer = 0
			Dim RatingValue As Integer = 0

			If frmHRIS_TEF_Feedback_Form_Part1.cb1.Checked Then Section1Value = 877
			If frmHRIS_TEF_Feedback_Form_Part1.cb2.Checked Then Section1Value = 878
			If frmHRIS_TEF_Feedback_Form_Part1.cb3.Checked Then Section1Value = 879

			If frmHRIS_TEF_Feedback_Form_Part1.cb4.Checked Then Section2Value = 880
			If frmHRIS_TEF_Feedback_Form_Part1.cb5.Checked Then Section2Value = 881
			If frmHRIS_TEF_Feedback_Form_Part1.cb6.Checked Then Section2Value = 882

			If frmHRIS_TEF_Feedback_Form_Part1.cb7.Checked Then Section3Value = 883
			If frmHRIS_TEF_Feedback_Form_Part1.cb8.Checked Then Section3Value = 884
			If frmHRIS_TEF_Feedback_Form_Part1.cb9.Checked Then Section3Value = 885

			If frmHRIS_TEF_Feedback_Form_Part1.cb10.Checked Then Section4Value = 886
			If frmHRIS_TEF_Feedback_Form_Part1.cb11.Checked Then Section4Value = 887
			If frmHRIS_TEF_Feedback_Form_Part1.cb12.Checked Then Section4Value = 888

			If frmHRIS_TEF_Feedback_Form_Part1.cb13.Checked Then Section5Value = 889
			If frmHRIS_TEF_Feedback_Form_Part1.cb14.Checked Then Section5Value = 890
			If frmHRIS_TEF_Feedback_Form_Part1.cb15.Checked Then Section5Value = 891

			If frmHRIS_TEF_Feedback_Form_Part1.cbr1.Checked Then RatingValue = 1
			If frmHRIS_TEF_Feedback_Form_Part1.cbr2.Checked Then RatingValue = 2
			If frmHRIS_TEF_Feedback_Form_Part1.cbr3.Checked Then RatingValue = 3
			If frmHRIS_TEF_Feedback_Form_Part1.cbr4.Checked Then RatingValue = 4

			Using Conn As New SqlConnection(StrConn),
			cmd As New SqlCommand("[spInsHRIS_Training_FeedbackTemp]", Conn)
				'  cmd As New SqlCommand("[spInsHRIS_Training_Feedback]", Conn)

				Conn.Open()
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@TrainingSubDetailID", _TrainingSubDetailID)
				cmd.Parameters.AddWithValue("@EmployeeID", _TrainingEmployeeID)
				cmd.Parameters.AddWithValue("@Section1", Section1Value)
				cmd.Parameters.AddWithValue("@Section2", Section2Value)
				cmd.Parameters.AddWithValue("@Section3", Section3Value)
				cmd.Parameters.AddWithValue("@Section4", Section4Value)
				cmd.Parameters.AddWithValue("@Section5", Section5Value)
				cmd.Parameters.AddWithValue("@Rating", RatingValue)
				cmd.Parameters.AddWithValue("@EmployeeImprovSuggestion", frmHRIS_TEF_Feedback_Form_Part1.txtImprovSuggestion.Text)
				cmd.Parameters.AddWithValue("@EmployeeLearningsGained", frmHRIS_TEF_Feedback_Form_Part2.txtLearningsGained.Text)
				cmd.Parameters.AddWithValue("@EmployeeRecommendedSeminar", frmHRIS_TEF_Feedback_Form_Part2.txtRecommendedSeminar.Text)
				cmd.Parameters.AddWithValue("@ModifiedBy", frmMain.ToolStripEmployeeNo.Text)
				If cmd.ExecuteNonQuery() = -1 Then

					MessageBox.Show("Successfully Submitted Evaluation Form, Thank You!")
					frmHRIS_TEF_Feedback_Form_Part1.Dispose()
					frmHRIS_TEF_Feedback_Form_Part2.Dispose()

					Call Select_TEF_TrainingListByEmployeeID_PendingRate(frmHRIS_Transaction_TrainingEvaluation.dgvEvaluationTraining)

				End If

			End Using

			Conn.Close()

		Catch ex As Exception
			MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Try
	End Sub

	Sub Print_TrainingEvaluation()

		frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ShowProgressAnimation(True)

		Dim report1 As New TrainingEvaluationR1

		Dim user As String = "sa"
		Dim pwd As String = "3dcoP2024"
		report1.SetDatabaseLogon(user, pwd)

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spRpt_HRIS_TrainingEvaluation]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
					}

		cmd.Parameters.AddWithValue("@PersonnelID", _TrainingEmployeeID)
		cmd.Parameters.AddWithValue("@TrainingSubDetailID", _TrainingSubDetailID)

		dr = cmd.ExecuteReader()
		If dr.HasRows Then
			While (dr.Read)

				report1.SetParameterValue("rptPersonnelID", _TrainingEmployeeID)
				report1.SetParameterValue("rptTrainingSubDetailID", _TrainingSubDetailID)

			End While
			frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
			frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = report1
			frmHRIS_Report_CrystalReportsHolder.ShowDialog()

		Else
			MessageBox.Show("Error print.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
		dr.Close()
		Conn.Close()

	End Sub

	''--->>> Transaction - Training Management - End of Evaluation <<<---

	''--->>> Transaction - Training Management - Request <<<---

	Sub Select_TrainingRequestList_Main(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[SelHRIS_TrainingRequestList]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@EmployeeCode", frmMain.ToolStripEmployeeNo.Text)
		cmd.Parameters.AddWithValue("@AccessRights", frmMain.ToolStripAccessRights.Text)

		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
				dr(0).ToString,
				dr(1).ToString,
				dr(2).ToString,
				dr(3).ToString,
				dr(4).ToString,
				dr(5).ToString,
				dr(6).ToString,
				dr(7).ToString,
				dr(8).ToString,
				dr(9).ToString
				)
		End While

		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub Select_TrainingRequest_Participant_List(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_TrainingRequestParticipant]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@TrainingID", _TrainingRequestID)

		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
				dr(0).ToString,
				dr(1).ToString,
				dr(2).ToString,
				dr(3).ToString,
				dr(4).ToString)
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub Select_TrainingRequestList_Search(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[SelHRIS_TrainingRequestList_Search]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@txt", frmHRIS_Transaction_TrainingRequest.txtboxSearch.Text)
		dr = cmd.ExecuteReader()

		If dr.HasRows Then
			While dr.Read()
				dgv.Rows.Add(
					dr(0).ToString,
					dr(1).ToString,
					dr(2).ToString,
					dr(3).ToString,
					dr(4).ToString,
					dr(5).ToString,
					dr(6).ToString,
					dr(7).ToString,
					dr(8).ToString,
					dr(9).ToString
					)
			End While
		Else
			MessageBox.Show("Search not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub InsUpd_TrainingRequest()

		Try

			Using Conn As New SqlConnection(StrConn),
				 cmd As New SqlCommand("[spInsUpdHRIS_Training_TrainingRequest]", Conn)
				Conn.Open()
				cmd.CommandType = CommandType.StoredProcedure

				cmd.Parameters.AddWithValue("@ID", _TrainingRequestID)
				cmd.Parameters.AddWithValue("@TrainingName", frmHRIS_TR_AddUpdateTrainingRequest.txtTrainingName.Text)
				cmd.Parameters.AddWithValue("@Facilitator", frmHRIS_TR_AddUpdateTrainingRequest.txtFacilitator.Text)
				cmd.Parameters.AddWithValue("@Description", frmHRIS_TR_AddUpdateTrainingRequest.txtDescription.Text)
				cmd.Parameters.AddWithValue("@Objectives", frmHRIS_TR_AddUpdateTrainingRequest.txtObjectives.Text)
				cmd.Parameters.AddWithValue("@TrainingFee", frmHRIS_TR_AddUpdateTrainingRequest.txtFee.Text)
				cmd.Parameters.AddWithValue("@Methodology", frmHRIS_TR_AddUpdateTrainingRequest.txtMethodology.Text)
				cmd.Parameters.AddWithValue("@StartDate", frmHRIS_TR_AddUpdateTrainingRequest.dtpTrainingRequestStartDate.Value.Date)
				cmd.Parameters.AddWithValue("@EndDate", frmHRIS_TR_AddUpdateTrainingRequest.dtpTrainingRequestEndDate.Value.Date)
				cmd.Parameters.AddWithValue("@StartHour", frmHRIS_TR_AddUpdateTrainingRequest.dtpTrainingRequestStartTime.Value.TimeOfDay)
				cmd.Parameters.AddWithValue("@EndHour", frmHRIS_TR_AddUpdateTrainingRequest.dtpTrainingRequestEndTime.Value.TimeOfDay)
				cmd.Parameters.AddWithValue("@Logistics", frmHRIS_TR_AddUpdateTrainingRequest.txtLogistics.Text)
				cmd.Parameters.AddWithValue("@ProgramCourseOutline", frmHRIS_TR_AddUpdateTrainingRequest.txtProgramOutline.Text)
				cmd.Parameters.AddWithValue("@FollowMeasurement", frmHRIS_TR_AddUpdateTrainingRequest.txtMeasurement.Text)
				cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

				cmd.ExecuteNonQuery()

				MessageBox.Show("Success! Request saved.")
				frmHRIS_TR_AddUpdateTrainingRequest.Dispose()

			End Using

			Conn.Close()

		Catch ex As Exception
			MsgBox("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
		End Try

	End Sub

	Sub SelUpd_Training_TrainingRequestByID()

		Try

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As SqlCommand = Conn.CreateCommand()
					cmd.CommandText = "[spSelUpd_Training_TrainingRequestByID]"
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@ID", _TrainingRequestID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.Read() Then

							frmHRIS_TR_AddUpdateTrainingRequest.txtTrainingName.Text = dr.GetString(0)
							frmHRIS_TR_AddUpdateTrainingRequest.txtFacilitator.Text = dr.GetString(1)
							frmHRIS_TR_AddUpdateTrainingRequest.txtDescription.Text = dr.GetString(2)
							frmHRIS_TR_AddUpdateTrainingRequest.txtObjectives.Text = dr.GetString(3)
							frmHRIS_TR_AddUpdateTrainingRequest.txtFee.Text = dr.GetDecimal(4).ToString()
							frmHRIS_TR_AddUpdateTrainingRequest.txtMethodology.Text = dr.GetString(5)

							Dim TargetStartDate As DateTime
							If DateTime.TryParse(dr.GetValue(6).ToString(), TargetStartDate) Then
								frmHRIS_TR_AddUpdateTrainingRequest.dtpTrainingRequestStartDate.Value = TargetStartDate
							End If

							Dim TargetEndDate As DateTime
							If DateTime.TryParse(dr.GetValue(7).ToString(), TargetEndDate) Then
								frmHRIS_TR_AddUpdateTrainingRequest.dtpTrainingRequestEndDate.Value = TargetEndDate
							End If

							Dim StartSpanValue As TimeSpan
							If TimeSpan.TryParse(dr.GetValue(8).ToString(), StartSpanValue) Then
								frmHRIS_TR_AddUpdateTrainingRequest.dtpTrainingRequestStartTime.Value = frmHRIS_TR_AddUpdateTrainingRequest.dtpTrainingRequestStartTime.Value.Date.Add(StartSpanValue)
							End If

							Dim EndSpanValue As TimeSpan
							If TimeSpan.TryParse(dr.GetValue(9).ToString(), EndSpanValue) Then
								frmHRIS_TR_AddUpdateTrainingRequest.dtpTrainingRequestEndTime.Value = frmHRIS_TR_AddUpdateTrainingRequest.dtpTrainingRequestEndTime.Value.Date.Add(EndSpanValue)
							End If

							frmHRIS_TR_AddUpdateTrainingRequest.txtLogistics.Text = dr.GetString(10)
							frmHRIS_TR_AddUpdateTrainingRequest.txtProgramOutline.Text = dr.GetString(11)
							frmHRIS_TR_AddUpdateTrainingRequest.txtMeasurement.Text = dr.GetString(12)
						End If

					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MsgBox("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
		End Try

	End Sub

	Sub Select_TR_ActiveEmployee_TrainingRequestParticipant(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelUpdHRIS_ActiveEmployeeForParticipants]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@TrainingRequestID", _TrainingRequestID)
		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2))
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub Select_TR_EnrolledEmployee_TrainingRequestParticipant(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelUpdHRIS_EmployeeTrainingParticipant]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@TrainingRequestID", _TrainingRequestID)
		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2))
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub Ins_Employee_TR_Participant()

		Try

			Using Conn As New SqlConnection(StrConn)
				Using cmd As New SqlCommand("[spInsHRIS_Training_ParticipantEnrollment]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					Conn.Open()
					'cmd.Parameters.AddWithValue("@PersonnelID", frmHRIS_TE_AddUpdateTrainingEnrollee_Master.Label12.Text)
					cmd.Parameters.AddWithValue("@PersonnelID", _TrainingEmployeeID)
					cmd.Parameters.AddWithValue("@TrainingRequestID", _TrainingRequestID)
					cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

					If cmd.ExecuteNonQuery = -1 Then
						' Proc. : Call the function to refresh the list of available employee for trainings.
						Call Select_TR_ActiveEmployee_TrainingRequestParticipant(frmHRIS_TR_AddUpdTrainingParticipants.dgvActiveEmployees)
						' Proc. : Call the function to refresh the training DGV.
						Call Select_TR_EnrolledEmployee_TrainingRequestParticipant(frmHRIS_TR_AddUpdTrainingParticipants.dgvAddedEmployees)
					End If

				End Using
			End Using

			Conn.Close()

		Catch ex As Exception
			MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

	End Sub

	Sub Del_Employee_TR_Participant()

		Using Conn As New SqlConnection(StrConn)
			Using cmd As New SqlCommand("[spDelHRIS_Training_ParticipantEnrollment]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				Conn.Open()

				' cmd.Parameters.AddWithValue("@PersonnelID", frmHRIS_TE_AddUpdateTrainingEnrollee_Master.Label12.Text)
				cmd.Parameters.AddWithValue("@PersonnelID", _TrainingEmployeeID)
				cmd.Parameters.AddWithValue("@TrainingRequestID", _TrainingRequestID)

				If cmd.ExecuteNonQuery = -1 Then

					' Proc. : Call the function to refresh the list of available employee for trainings.
					Call Select_TR_ActiveEmployee_TrainingRequestParticipant(frmHRIS_TR_AddUpdTrainingParticipants.dgvActiveEmployees)

					' Proc. : Call the function to refresh the training dgv.
					Call Select_TR_EnrolledEmployee_TrainingRequestParticipant(frmHRIS_TR_AddUpdTrainingParticipants.dgvAddedEmployees)

				End If
			End Using
		End Using

		Conn.Close()

	End Sub

	Sub Del_TrainingRequest_By_ID(dgv As DataGridView)
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spDelHRIS_TrainingRequestByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _TrainingRequestID)

				If cmd.ExecuteNonQuery = -1 Then
					MessageBox.Show("Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
					dgv.Rows.Remove(dgv.SelectedRows(0))
				End If

				Conn.Close()
				cmd.Parameters.Clear()
			End Using
		End Using
	End Sub

	Sub PrintRPT_EmployeeTrainingRequest()

		frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ShowProgressAnimation(True)
		Dim TrainingRequest As New TrainingRequest

		TrainingRequest.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
		TrainingRequest.DataSourceConnections(0).SetLogon(DBUser, DBPass)

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spRptHRIS_Training_TrainingRequest]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
					}
		cmd.Parameters.AddWithValue("@TrainingRequestID", _TrainingRequestID)

		dr = cmd.ExecuteReader()
		If dr.HasRows Then
			While (dr.Read)
				TrainingRequest.SetParameterValue("@TrainingRequestID", _TrainingRequestID)
			End While

			frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = TrainingRequest
			frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
			frmHRIS_Report_CrystalReportsHolder.ShowDialog()
		Else
			MessageBox.Show("X", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
		dr.Close()
		Conn.Close()

	End Sub

	Sub PrintRPT_TrainingRequestParticipant()

		frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ShowProgressAnimation(True)
		Dim TrainingParticipant As New ListofParticipant

		TrainingParticipant.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
		TrainingParticipant.DataSourceConnections(0).SetLogon(DBUser, DBPass)

		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spRptHRIS_Training_TrainingRequestParticipant]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
					.CommandType = CommandType.StoredProcedure
					}
		cmd.Parameters.AddWithValue("@TrainingRequestID", _TrainingRequestID)

		dr = cmd.ExecuteReader()
		If dr.HasRows Then
			While (dr.Read)
				TrainingParticipant.SetParameterValue("@TrainingRequestID", _TrainingRequestID)
			End While

			frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = TrainingParticipant
			frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
			frmHRIS_Report_CrystalReportsHolder.ShowDialog()
		Else
			MessageBox.Show("X", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
		dr.Close()
		Conn.Close()

	End Sub

	Sub UpdTrainingDetailStatus()

		Try

			Using Conn As New SqlConnection(StrConn)
				Using cmd As New SqlCommand("[spUpdHRIS_Training_TrainingRequestStatus]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					Conn.Open()
					cmd.Parameters.AddWithValue("@TrainingRequestID", _TrainingRequestID)
					cmd.Parameters.AddWithValue("@RecommendingEmployee", frmHRIS_TR_UpdateStatusAndRemarks.cbReviewedBy.Text)
					cmd.Parameters.AddWithValue("@RecommendingDate", frmHRIS_TR_UpdateStatusAndRemarks.dtpReviewedDate.Value.Date)
					cmd.Parameters.AddWithValue("@ApprovingEmployee", frmHRIS_TR_UpdateStatusAndRemarks.cbApprovedBy.Text)
					If frmHRIS_TR_UpdateStatusAndRemarks.cbApprovedBy.Text = "-" Then
						cmd.Parameters.AddWithValue("@ApprovingDate", DBNull.Value)
					Else
						cmd.Parameters.AddWithValue("@ApprovingDate", frmHRIS_TR_UpdateStatusAndRemarks.dtpApprovedDate.Value.Date)
					End If
					cmd.Parameters.AddWithValue("@Status", frmHRIS_TR_UpdateStatusAndRemarks.cbStatus.Text)
					cmd.Parameters.AddWithValue("@StatusRemarks", frmHRIS_TR_UpdateStatusAndRemarks.txtStatusRemarks.Text)
					cmd.Parameters.AddWithValue("@ModifiedBy", frmMain.ToolStripEmployeeNo.Text)
					cmd.ExecuteNonQuery()
				End Using

				MessageBox.Show("Success! Changes saved.")
				frmHRIS_Transaction_TrainingRequest.ToolStripBtnRefresh.PerformClick()
				frmHRIS_TR_UpdateStatusAndRemarks.Close()
			End Using
		Catch ex As Exception
			MessageBox.Show("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
		End Try

	End Sub

	''--->>> Transaction - Training Management - End of Request <<<---

	''--->>> Transaction - Performance Management <<<---

	Sub Sel_PMAS_ActiveEmployeeList(dgv As DataGridView, txtbox As TextBox, txt As ToolStripLabel)
		dgv.Rows.Clear()
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spSelHRIS_PMAS_EmployeeList]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@txt", txtbox.Text)

					Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
					returnParam.Direction = ParameterDirection.Output
					cmd.Parameters.Add(returnParam)

					Using dr As SqlDataReader = cmd.ExecuteReader()
						While dr.Read()
							txt.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
							dgv.Rows.Add(
								dr.GetInt32(0),
								dr.GetString(1),
								dr.GetString(2),
								dr.GetString(3),
								dr.GetString(4),
								dr.GetString(5),
								dr.GetString(6),
								dr.GetString(7),
								dr.GetString(8))
						End While
					End Using
					txt.Text = If(IsDBNull(returnParam.Value), "0", returnParam.Value.ToString())
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		dgv.ClearSelection()
	End Sub

	'Sub Sel_PMAS_isEmployeeTechnical_ByID()

	'	Try

	'		Using Conn As New SqlConnection(StrConn)
	'			Conn.Open()
	'			Using cmd As SqlCommand = Conn.CreateCommand()
	'				cmd.CommandText = "[spSelHRIS_PMAS_isEmployeeTechnical_ByID]"
	'				cmd.CommandType = CommandType.StoredProcedure
	'				cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
	'				Using dr As SqlDataReader = cmd.ExecuteReader()
	'					If dr.Read() Then
	'						_isEmpTechnical = Convert.ToBoolean(dr(0))
	'					End If
	'				End Using
	'			End Using
	'		End Using

	'		Conn.Close()
	'		dr.Close()

	'	Catch ex As Exception
	'		MsgBox("Please Contact System Administrator." & vbCrLf & "Error occurred: " & ex.Message)
	'	End Try

	'End Sub

	Sub InsUpd_PMAS_Part1Form1()

		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_PMAS_Part1Form1_GoalSheet]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form1ID)
			cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
			cmd.Parameters.AddWithValue("@ProjectName", frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.cbProjectList.Text)
			cmd.Parameters.AddWithValue("@JobTitle", frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.cbJobPosition.Text)
			cmd.Parameters.AddWithValue("@StartDate", frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.dtpStartDate.Value)
			cmd.Parameters.AddWithValue("@EndDate", frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.dtpEndDate.Value)
			cmd.Parameters.AddWithValue("@ReviewDate", frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.dtpReviewDate.Value)
			cmd.Parameters.AddWithValue("@Remarks", frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.txtRemarks.Text)

			cmd.Parameters.AddWithValue("@KRA1", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra1goals.Text)
			cmd.Parameters.AddWithValue("@FactorWeight1", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra1fw.Text)
			cmd.Parameters.AddWithValue("@Rating1", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.ch1.Tag)
			cmd.Parameters.AddWithValue("@RxFW1", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra1rfw.Text)

			cmd.Parameters.AddWithValue("@KRA2", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra2goals.Text)
			cmd.Parameters.AddWithValue("@FactorWeight2", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra2fw.Text)
			cmd.Parameters.AddWithValue("@Rating2", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.ch2.Tag)
			cmd.Parameters.AddWithValue("@RxFW2", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra2rfw.Text)

			cmd.Parameters.AddWithValue("@KRA3", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra3goals.Text)
			cmd.Parameters.AddWithValue("@FactorWeight3", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra3fw.Text)
			cmd.Parameters.AddWithValue("@Rating3", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.ch3.Tag)
			cmd.Parameters.AddWithValue("@RxFW3", frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra3rfw.Text)

			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

			If cmd.ExecuteNonQuery = -1 Then
				MessageBox.Show("Saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Call Sel_PMAS_Part1Form1_ByEmployeeID(frmHRIS_Transaction_PerformanceManagement_Part1.dgvPerformanceRecordPart1)
				Call frmHRIS_PerformanceManagement_AddUpdatePart1Form1.Dispose()
			End If

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try

	End Sub

	Sub Sel_PMAS_Part1Form1_ByEmployeeID(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_PMAS_Part1Form1_GoalSheet_ByEmployeeID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2),
			dr.GetString(3),
			dr.GetString(4),
			dr.GetDecimal(5),
			dr.GetString(6),
			dr.GetDecimal(7),
			dr.GetString(8),
			dr.GetDecimal(9),
			dr.GetDecimal(10),
			dr.GetString(11))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub SelUpd_PMAS_Part1Form1_ByID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_PMAS_Part1Form1_GoalSheet_ByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form1ID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then
						Dim Index As Integer = frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.cbProjectList.FindStringExact(dr(0).ToString())
						If Index <> -1 Then frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.cbProjectList.SelectedIndex = Index

						frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.dtpStartDate.Value = dr.GetDateTime(1)
						frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.dtpEndDate.Value = dr.GetDateTime(2)
						frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.dtpReviewDate.Value = dr.GetDateTime(3)
						frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.txtRemarks.Text = dr.GetString(4)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra1goals.Text = dr.GetString(5)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra1fw.Text = dr.GetDecimal(6)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra1r1.Checked = (dr.GetDecimal(7) = 1)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra1r2.Checked = (dr.GetDecimal(7) = 2)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra1r3.Checked = (dr.GetDecimal(7) = 3)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra1r4.Checked = (dr.GetDecimal(7) = 4)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra1r5.Checked = (dr.GetDecimal(7) = 5)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra1rfw.Text = dr.GetDecimal(8)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra2goals.Text = dr.GetString(9)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra2fw.Text = dr.GetDecimal(10)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra2r1.Checked = (dr.GetDecimal(11) = 1)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra2r2.Checked = (dr.GetDecimal(11) = 2)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra2r3.Checked = (dr.GetDecimal(11) = 3)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra2r4.Checked = (dr.GetDecimal(11) = 4)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra2r5.Checked = (dr.GetDecimal(11) = 5)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra2rfw.Text = dr.GetDecimal(12)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra3goals.Text = dr.GetString(13)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra3fw.Text = dr.GetDecimal(14)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra3r1.Checked = (dr.GetDecimal(15) = 1)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra3r2.Checked = (dr.GetDecimal(15) = 2)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra3r3.Checked = (dr.GetDecimal(15) = 3)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra3r4.Checked = (dr.GetDecimal(15) = 4)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra3r5.Checked = (dr.GetDecimal(15) = 5)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form1.kra3rfw.Text = dr.GetDecimal(16)

						Dim Index1 As Integer = frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.cbJobPosition.FindStringExact(dr(17).ToString())
						If Index1 <> -1 Then frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.cbJobPosition.SelectedIndex = Index1
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub Select_PMAS_Part1Form2_SummarySheet_By4ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelHRIS_PMAS_Part1Form2_SummarySheet_By4ID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure

				' Prepare DataTable for TVP
				Dim table1 As New DataTable()
				table1.Columns.Add("ID", GetType(Integer))
				frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2.Part1Form1ID.ForEach(Sub(id) table1.Rows.Add(id))

				' Add structured parameter properly
				Dim param = cmd.Parameters.Add("@Part1Form1ID", SqlDbType.Structured)
				param.TypeName = "dbo.IntList"
				param.Value = table1

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.HasRows AndAlso dr.Read() Then

						'Project 1
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.atxtProjectName1.Text = dr.GetString(0)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtProjectDesignation1.Text = dr.GetString(1)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtCoveringPeriod1.Text = dr.GetString(2)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP1FW1.Text = dr.GetDecimal(3)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP1Rating1.Text = dr.GetDecimal(4)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP1WS1.Text = dr.GetDecimal(5)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP1FW2.Text = dr.GetDecimal(6)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP1Rating2.Text = dr.GetDecimal(7)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP1WS2.Text = dr.GetDecimal(8)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP1FW3.Text = dr.GetDecimal(9)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP1Rating3.Text = dr.GetDecimal(10)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP1WS3.Text = dr.GetDecimal(11)

						'Project 2
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.atxtProjectName2.Text = dr.GetString(12)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtProjectDesignation2.Text = dr.GetString(13)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtCoveringPeriod2.Text = dr.GetString(14)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP2FW1.Text = dr.GetDecimal(15)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP2Rating1.Text = dr.GetDecimal(16)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP2WS1.Text = dr.GetDecimal(17)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP2FW2.Text = dr.GetDecimal(18)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP2Rating2.Text = dr.GetDecimal(19)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP2WS2.Text = dr.GetDecimal(20)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP2FW3.Text = dr.GetDecimal(21)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP2Rating3x.Text = dr.GetDecimal(22)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP2WS3.Text = dr.GetDecimal(23)

						'Project 3
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.atxtProjectName3.Text = dr.GetString(24)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtProjectDesignation3.Text = dr.GetString(25)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtCoveringPeriod3.Text = dr.GetString(26)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP3FW1.Text = dr.GetDecimal(27)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP3Rating1.Text = dr.GetDecimal(28)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP3WS1.Text = dr.GetDecimal(29)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP3FW2.Text = dr.GetDecimal(30)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP3Rating2.Text = dr.GetDecimal(31)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP3WS2.Text = dr.GetDecimal(32)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP3FW3.Text = dr.GetDecimal(33)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP3Rating3.Text = dr.GetDecimal(34)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP3WS3.Text = dr.GetDecimal(35)

						'Project 4
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.atxtProjectName4.Text = dr.GetString(36)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtProjectDesignation4.Text = dr.GetString(37)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtCoveringPeriod4.Text = dr.GetString(38)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP4FW1.Text = dr.GetDecimal(39)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP4Rating1.Text = dr.GetDecimal(40)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP4WS1.Text = dr.GetDecimal(41)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP4FW2.Text = dr.GetDecimal(42)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP4Rating2.Text = dr.GetDecimal(43)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP4WS2.Text = dr.GetDecimal(44)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP4FW3.Text = dr.GetDecimal(45)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP4Rating3.Text = dr.GetDecimal(46)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP4WS3.Text = dr.GetDecimal(47)

					Else
						MessageBox.Show("Sorry, no matching records found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub Select_PMAS_Part1Form2_SummarySheet_By8ID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spSelHRIS_PMAS_Part1Form2_SummarySheet_By8ID]", Conn)
				cmd.CommandType = CommandType.StoredProcedure

				' Prepare DataTable for TVP
				Dim table1 As New DataTable()
				table1.Columns.Add("ID", GetType(Integer))
				frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2.Part1Form1ID.ForEach(Sub(id) table1.Rows.Add(id))

				' Add structured parameter properly
				Dim param = cmd.Parameters.Add("@Part1Form1ID", SqlDbType.Structured)
				param.TypeName = "dbo.IntList"
				param.Value = table1

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.HasRows AndAlso dr.Read() Then

						'Project 1
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.atxtProjectName1.Text = dr.GetString(0)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtProjectDesignation1.Text = dr.GetString(1)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtCoveringPeriod1.Text = dr.GetString(2)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP1FW1.Text = dr.GetDecimal(3)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP1Rating1.Text = dr.GetDecimal(4)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP1WS1.Text = dr.GetDecimal(5)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP1FW2.Text = dr.GetDecimal(6)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP1Rating2.Text = dr.GetDecimal(7)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP1WS2.Text = dr.GetDecimal(8)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP1FW3.Text = dr.GetDecimal(9)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP1Rating3.Text = dr.GetDecimal(10)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP1WS3.Text = dr.GetDecimal(11)

						'Project 2
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.atxtProjectName2.Text = dr.GetString(12)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtProjectDesignation2.Text = dr.GetString(13)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtCoveringPeriod2.Text = dr.GetString(14)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP2FW1.Text = dr.GetDecimal(15)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP2Rating1.Text = dr.GetDecimal(16)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP2WS1.Text = dr.GetDecimal(17)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP2FW2.Text = dr.GetDecimal(18)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP2Rating2.Text = dr.GetDecimal(19)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP2WS2.Text = dr.GetDecimal(20)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP2FW3.Text = dr.GetDecimal(21)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP2Rating3.Text = dr.GetDecimal(22)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP2WS3.Text = dr.GetDecimal(23)

						'Project 3
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.atxtProjectName3.Text = dr.GetString(24)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtProjectDesignation3.Text = dr.GetString(25)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtCoveringPeriod3.Text = dr.GetString(26)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP3FW1.Text = dr.GetDecimal(27)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP3Rating1.Text = dr.GetDecimal(28)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP3WS1.Text = dr.GetDecimal(29)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP3FW2.Text = dr.GetDecimal(30)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP3Rating2.Text = dr.GetDecimal(31)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP3WS2.Text = dr.GetDecimal(32)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP3FW3.Text = dr.GetDecimal(33)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP3Rating3.Text = dr.GetDecimal(34)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP3WS3.Text = dr.GetDecimal(35)

						'Project 4
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.atxtProjectName4.Text = dr.GetString(36)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtProjectDesignation4.Text = dr.GetString(37)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtCoveringPeriod4.Text = dr.GetString(38)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP4FW1.Text = dr.GetDecimal(39)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP4Rating1.Text = dr.GetDecimal(40)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP4WS1.Text = dr.GetDecimal(41)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP4FW2.Text = dr.GetDecimal(42)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP4Rating2.Text = dr.GetDecimal(43)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP4WS2.Text = dr.GetDecimal(44)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP4FW3.Text = dr.GetDecimal(45)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP4Rating3.Text = dr.GetDecimal(46)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP4WS3.Text = dr.GetDecimal(47)

						'Project 5
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.atxtProjectName5.Text = dr.GetString(48)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtProjectDesignation5.Text = dr.GetString(49)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtCoveringPeriod5.Text = dr.GetString(50)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP5FW1.Text = dr.GetDecimal(51)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP5Rating1.Text = dr.GetDecimal(52)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP5WS1.Text = dr.GetDecimal(53)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP5FW2.Text = dr.GetDecimal(54)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP5Rating2.Text = dr.GetDecimal(55)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP5WS2.Text = dr.GetDecimal(56)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP5FW3.Text = dr.GetDecimal(57)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP5Rating3.Text = dr.GetDecimal(58)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP5WS3.Text = dr.GetDecimal(59)

						'Project 6
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.atxtProjectName6.Text = dr.GetString(60)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtProjectDesignation6.Text = dr.GetString(61)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtCoveringPeriod6.Text = dr.GetString(62)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP6FW1.Text = dr.GetDecimal(63)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP6Rating1.Text = dr.GetDecimal(64)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP6WS1.Text = dr.GetDecimal(65)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP6FW2.Text = dr.GetDecimal(66)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP6Rating2.Text = dr.GetDecimal(67)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP6WS2.Text = dr.GetDecimal(68)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP6FW3.Text = dr.GetDecimal(69)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP6Rating3.Text = dr.GetDecimal(70)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP6WS3.Text = dr.GetDecimal(71)

						'Project 7
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.atxtProjectName7.Text = dr.GetString(72)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtProjectDesignation7.Text = dr.GetString(73)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtCoveringPeriod7.Text = dr.GetString(74)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP7FW1.Text = dr.GetDecimal(75)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP7Rating1.Text = dr.GetDecimal(76)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP7WS1.Text = dr.GetDecimal(77)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP7FW2.Text = dr.GetDecimal(78)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP7Rating2.Text = dr.GetDecimal(79)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP7WS2.Text = dr.GetDecimal(80)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP7FW3.Text = dr.GetDecimal(81)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP7Rating3.Text = dr.GetDecimal(82)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP7WS3.Text = dr.GetDecimal(83)

						'Project 8
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.atxtProjectName8.Text = dr.GetString(84)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtProjectDesignation8.Text = dr.GetString(85)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtCoveringPeriod8.Text = dr.GetString(86)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP8FW1.Text = dr.GetDecimal(87)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP8Rating1.Text = dr.GetDecimal(88)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP8WS1.Text = dr.GetDecimal(89)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP8FW2.Text = dr.GetDecimal(90)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP8Rating2.Text = dr.GetDecimal(91)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP8WS2.Text = dr.GetDecimal(92)

						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP8FW3.Text = dr.GetDecimal(93)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP8Rating3.Text = dr.GetDecimal(94)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP8WS3.Text = dr.GetDecimal(95)

					Else
						MessageBox.Show("Sorry, no matching records found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return
					End If
				End Using
			End Using
		End Using
	End Sub


	Sub InsUpd_PMAS_Part1Form2()

		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_PMAS_Part1Form2_SummarySheet]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form2ID)
			cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)

			' Prepare DataTable for TVP
			Dim table1 As New DataTable()
			table1.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2.Part1Form1ID.ForEach(Sub(id) table1.Rows.Add(id))

			' Add structured parameter properly
			Dim param = cmd.Parameters.Add("@Part1Form1ID", SqlDbType.Structured)
			param.TypeName = "dbo.IntList"
			param.Value = table1

			cmd.Parameters.AddWithValue("@TotalAverage", frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2.lblTotalWeighedAverage.Text)
			cmd.Parameters.AddWithValue("@Q1", frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2.txtQ1.Text)
			cmd.Parameters.AddWithValue("@Q2", frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2.txtQ2.Text)
			cmd.Parameters.AddWithValue("@Q3", frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2.txtQ3.Text)
			cmd.Parameters.AddWithValue("@Q4", frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2.txtQ4.Text)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

			If cmd.ExecuteNonQuery = -1 Then
				'Call Sel_PerformancePart1Form1_ByEmployeeID(frmHRIS_Transaction_PerformanceManagement.dgvPerformanceRecordPart1)

				MessageBox.Show("Saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Call frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2.Dispose()
				Call frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.Dispose()
				Call frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2.Dispose()

			End If

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try

	End Sub

	Sub Sel_PMAS_Part1Form2_ByForm1ID(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_PMAS_Part1Form2_SummarySheet_ByForm1ID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form1ID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetDecimal(1),
			dr.GetString(2),
			dr.GetString(3),
			dr.GetString(4),
			dr.GetString(5))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub Select_PMAS_Part1Form2_ActiveSummarySheet(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelUpdHRIS_PMAS_ActiveGoalSheet]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form2ID)
		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2))
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub Select_PMAS_Part1Form1_ActiveGoalSheet(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_PMAS_ActiveGoalSheet]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
		dr = cmd.ExecuteReader()
		While dr.Read()
			dgv.Rows.Add(
			dr.GetInt32(0),
			dr.GetString(1),
			dr.GetString(2))
		End While
		dr.Close()
		Conn.Close()
		dgv.ClearSelection()

	End Sub

	Sub SelUpd_PMAS_Part1Form2_ByID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_PMAS_Part1Form2_SummarySheet_ByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form2ID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2.txtQ1.Text = dr.GetString(0)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2.txtQ2.Text = dr.GetString(1)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2.txtQ3.Text = dr.GetString(2)
						frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2.txtQ4.Text = dr.GetString(2)
					End If
				End Using
			End Using
		End Using
	End Sub

	Sub Select_PMAS_Part2FormA_Value(dgv1 As DataGridView, dgv2 As DataGridView, dgv3 As DataGridView, dgv4 As DataGridView, dgv5 As DataGridView, dgv6 As DataGridView, dgv7 As DataGridView, dgv8 As DataGridView, dgv9 As DataGridView, dgv10 As DataGridView)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorA_Value1]", dgv1)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorA_Value2]", dgv2)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorA_Value3]", dgv3)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorA_Value4]", dgv4)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorA_Value5]", dgv5)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorA_Value6]", dgv6)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorA_Value7]", dgv7)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorA_Value8]", dgv8)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorA_Value9]", dgv9)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorA_Value10]", dgv10)
	End Sub

	Sub Select_LoadDataToGrid_PMAS_Form(storedProcedure As String, dgv As DataGridView)
		dgv.Rows.Clear()

		Using conn As New SqlConnection(StrConn)
			Using cmd As New SqlCommand(storedProcedure, conn)
				cmd.CommandType = CommandType.StoredProcedure
				conn.Open()

				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						Dim rowIdx As Integer = dgv.Rows.Add()
						dgv.Rows(rowIdx).Cells(0).Value = dr.GetInt32(0)  ' ID
						dgv.Rows(rowIdx).Cells(1).Value = dr.GetString(1) ' Value
					End While
				End Using
			End Using
		End Using

		dgv.ClearSelection()
	End Sub

	Sub Select_PMAS_Part2FormB_Value(dgv1 As DataGridView, dgv2 As DataGridView, dgv3 As DataGridView, dgv4 As DataGridView, dgv5 As DataGridView, dgv6 As DataGridView, dgv7 As DataGridView, dgv8 As DataGridView)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorB_Value1]", dgv1)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorB_Value2]", dgv2)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorB_Value3]", dgv3)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorB_Value4]", dgv4)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorB_Value5]", dgv5)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorB_Value6]", dgv6)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorB_Value7]", dgv7)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorB_Value8]", dgv8)
	End Sub

	Sub Select_PMAS_Part2FormC_Value(dgv1 As DataGridView, dgv2 As DataGridView, dgv3 As DataGridView, dgv4 As DataGridView, dgv5 As DataGridView, dgv6 As DataGridView, dgv7 As DataGridView, dgv8 As DataGridView)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorC_Value1]", dgv1)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorC_Value2]", dgv2)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorC_Value3]", dgv3)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorC_Value4]", dgv4)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorC_Value5]", dgv5)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorC_Value6]", dgv6)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorC_Value7]", dgv7)
		Select_LoadDataToGrid_PMAS_Form("[spSelHRIS_PMAS_Part2FactorC_Value8]", dgv8)
	End Sub

	Sub InsUpd_PMAS_Part2FormA()

		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_PMAS_Part2Form1_PerformanceFactorA]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormAID)
			cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
			cmd.Parameters.AddWithValue("@Part1ID", _strPerformancePart1Form1ID)

			Dim table1 As New DataTable()
			table1.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A1.ForEach(Sub(id) table1.Rows.Add(id))
			cmd.Parameters.AddWithValue("@A1", table1).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@A1").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWA1", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW1.Text)
			cmd.Parameters.AddWithValue("@AFWA1", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.txtTFW1.Text)

			Dim table2 As New DataTable()
			table2.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A2.ForEach(Sub(id) table2.Rows.Add(id))
			cmd.Parameters.AddWithValue("@A2", table2).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@A2").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWA2", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW2.Text)
			cmd.Parameters.AddWithValue("@AFWA2", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.txtTFW2.Text)

			Dim table3 As New DataTable()
			table3.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A3.ForEach(Sub(id) table3.Rows.Add(id))
			cmd.Parameters.AddWithValue("@A3", table3).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@A3").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWA3", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW3.Text)
			cmd.Parameters.AddWithValue("@AFWA3", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.txtTFW3.Text)

			Dim table4 As New DataTable()
			table4.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A4.ForEach(Sub(item) table4.Rows.Add(item))
			cmd.Parameters.AddWithValue("@A4", table4).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@A4").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWA4", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW4.Text)
			cmd.Parameters.AddWithValue("@AFWA4", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.txtTFW4.Text)

			Dim table5 As New DataTable()
			table5.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A5.ForEach(Sub(id) table5.Rows.Add(id))
			cmd.Parameters.AddWithValue("@A5", table5).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@A5").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWA5", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW5.Text)
			cmd.Parameters.AddWithValue("@AFWA5", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.txtTFW5.Text)

			Dim table6 As New DataTable()
			table6.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A6.ForEach(Sub(id) table6.Rows.Add(id))
			cmd.Parameters.AddWithValue("@A6", table6).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@A6").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWA6", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW6.Text)
			cmd.Parameters.AddWithValue("@AFWA6", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.txtTFW6.Text)

			Dim table7 As New DataTable()
			table7.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A7.ForEach(Sub(id) table7.Rows.Add(id))
			cmd.Parameters.AddWithValue("@A7", table7).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@A7").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWA7", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW7.Text)
			cmd.Parameters.AddWithValue("@AFWA7", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.txtTFW7.Text)

			Dim table8 As New DataTable()
			table8.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A8.ForEach(Sub(id) table8.Rows.Add(id))
			cmd.Parameters.AddWithValue("@A8", table8).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@A8").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWA8", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW8.Text)
			cmd.Parameters.AddWithValue("@AFWA8", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.txtTFW8.Text)

			Dim table9 As New DataTable()
			table9.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A9.ForEach(Sub(item) table9.Rows.Add(item))
			cmd.Parameters.AddWithValue("@A9", table9).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@A9").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWA9", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW9.Text)
			cmd.Parameters.AddWithValue("@AFWA9", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.txtTFW9.Text)

			Dim table10 As New DataTable()
			table10.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A10.ForEach(Sub(id) table10.Rows.Add(id))
			cmd.Parameters.AddWithValue("@A10", table10).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@A10").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWA10", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW10.Text)
			cmd.Parameters.AddWithValue("@AFWA10", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.txtTFW10.Text)

			cmd.Parameters.AddWithValue("@Reviewer", frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.cbReviewer.Text)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

			If cmd.ExecuteNonQuery = -1 Then
				MessageBox.Show("Saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Call Sel_PMAS_Part2AllForms_ByEmployeeID(frmHRIS_Transaction_PerformanceManagement_Part2.dgvPerformanceFactors)
				Call frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.Dispose()
				Call frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.Dispose()
			End If

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try

	End Sub

	Sub Sel_PMAS_Part2AllForms_ByEmployeeID(dgv As DataGridView)

		dgv.Rows.Clear()
		Conn = New SqlConnection(StrConn)
		Conn.Open()
		cmd = Conn.CreateCommand
		cmd.CommandText = "[spSelHRIS_PMAS_Part2Forms_AllType_ByEmployeeID]"
		cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
						}
		cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
		dr = cmd.ExecuteReader()
		While dr.Read()

			dgv.Rows.Add(
			dr.GetString(0),
			dr.GetString(1),
			dr.GetDecimal(2),
			dr.GetString(3),
			dr.GetString(4))

		End While
		dr.Close()
		Conn.Close()
		cmd.Parameters.Clear()
		dgv.ClearSelection()

	End Sub

	Sub SelUpd_PMAS_Part2FormA_ByID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactor_ByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormAID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then

						Dim Index As Integer = frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.cbPart1.FindStringExact(dr(0).ToString())
						If Index <> -1 Then frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.cbPart1.SelectedIndex = Index

						frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW1.Text = dr.GetDecimal(1)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW2.Text = dr.GetDecimal(2)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW3.Text = dr.GetDecimal(3)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW4.Text = dr.GetDecimal(4)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW5.Text = dr.GetDecimal(5)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW6.Text = dr.GetDecimal(6)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW7.Text = dr.GetDecimal(7)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW8.Text = dr.GetDecimal(8)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW9.Text = dr.GetDecimal(9)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW10.Text = dr.GetDecimal(10)

						Dim Index1 As Integer = frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.cbReviewer.FindStringExact(dr(11).ToString())
						If Index1 <> -1 Then frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.cbReviewer.SelectedIndex = Index1


					End If
				End Using
			End Using
		End Using
	End Sub

	Sub SelUpd_PMAS_Part2FormB_ByID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_PMAS_Part2FormB_PerformanceFactor_ByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormBID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then

						Dim Index As Integer = frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.cbPart1.FindStringExact(dr(0).ToString())
						If Index <> -1 Then frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.cbPart1.SelectedIndex = Index

						frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW1.Text = dr.GetDecimal(1)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW2.Text = dr.GetDecimal(2)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW3.Text = dr.GetDecimal(3)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW4.Text = dr.GetDecimal(4)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW5.Text = dr.GetDecimal(5)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW6.Text = dr.GetDecimal(6)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW7.Text = dr.GetDecimal(7)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW8.Text = dr.GetDecimal(8)

						Dim Index1 As Integer = frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.cbReviewer.FindStringExact(dr(9).ToString())
						If Index1 <> -1 Then frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.cbReviewer.SelectedIndex = Index1

					End If
				End Using
			End Using
		End Using
	End Sub

	Sub SelUpd_PMAS_Part2FormC_ByID()
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As SqlCommand = Conn.CreateCommand()
				cmd.CommandText = "[spSelUpdHRIS_PMAS_Part2FormC_PerformanceFactor_ByID]"
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormCID)

				Using dr As SqlDataReader = cmd.ExecuteReader()
					If dr.Read() Then

						Dim Index As Integer = frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.cbPart1.FindStringExact(dr(0).ToString())
						If Index <> -1 Then frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.cbPart1.SelectedIndex = Index

						frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW1.Text = dr.GetDecimal(1)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW2.Text = dr.GetDecimal(2)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW3.Text = dr.GetDecimal(3)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW4.Text = dr.GetDecimal(4)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW5.Text = dr.GetDecimal(5)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW6.Text = dr.GetDecimal(6)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW7.Text = dr.GetDecimal(7)
						frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW8.Text = dr.GetDecimal(8)

						Dim Index1 As Integer = frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.cbReviewer.FindStringExact(dr(9).ToString())
						If Index1 <> -1 Then frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.cbReviewer.SelectedIndex = Index1

					End If
				End Using
			End Using
		End Using
	End Sub

	Sub SelUpd_PMAS_Part2FormA_Value(dgv1 As DataGridView, dgv2 As DataGridView, dgv3 As DataGridView, dgv4 As DataGridView, dgv5 As DataGridView, dgv6 As DataGridView, dgv7 As DataGridView, dgv8 As DataGridView, dgv9 As DataGridView, dgv10 As DataGridView, id As Integer)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorA1_ByID]", dgv1, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A1, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorA2_ByID]", dgv2, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A2, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorA3_ByID]", dgv3, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A3, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorA4_ByID]", dgv4, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A4, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorA5_ByID]", dgv5, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A5, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorA6_ByID]", dgv6, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A6, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorA7_ByID]", dgv7, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A7, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorA8_ByID]", dgv8, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A8, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorA9_ByID]", dgv9, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A9, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorA10_ByID]", dgv10, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA.A10, id)
	End Sub

	Sub SelUpd_LoadDataToGrid_PMAS_Part2Form(storedProcedure As String, dgv As DataGridView, lst As List(Of Integer), id As Integer)
		dgv.Rows.Clear()
		lst.Clear()

		Using conn As New SqlConnection(StrConn)
			Using cmd As New SqlCommand(storedProcedure, conn)
				conn.Open()
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", id)
				Using dr As SqlDataReader = cmd.ExecuteReader()
					While dr.Read()
						Dim rowIdx As Integer = dgv.Rows.Add()

						dgv.Rows(rowIdx).Cells(0).Value = dr.GetInt64(0) ' ID
						dgv.Rows(rowIdx).Cells(1).Value = dr.GetString(1) ' Description/Text

						Dim foundValue As Integer = 0

						' For columns 2 to 6 (checkbox columns), check if value is not zero
						For colIdx As Integer = 2 To 6
							Dim val As Integer = dr.GetInt32(colIdx)
							Dim chkCell As DataGridViewCheckBoxCell = CType(dgv.Rows(rowIdx).Cells(colIdx), DataGridViewCheckBoxCell)
							chkCell.Value = (val <> 0)

							If val <> 0 Then
								foundValue = colIdx - 1 ' Adjust so column 2 = value 1, column 3 = value 2, etc.
							End If
						Next

						lst.Add(foundValue) 'store all non-zero or the rating from the db
					End While
				End Using
			End Using
		End Using

		dgv.ClearSelection()
	End Sub

	Sub SelUpd_PMAS_Part2FormB_Value(dgv1 As DataGridView, dgv2 As DataGridView, dgv3 As DataGridView, dgv4 As DataGridView, dgv5 As DataGridView, dgv6 As DataGridView, dgv7 As DataGridView, dgv8 As DataGridView, id As Integer)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorB1_ByID]", dgv1, frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B1, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorB2_ByID]", dgv2, frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B2, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorB3_ByID]", dgv3, frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B3, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorB4_ByID]", dgv4, frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B4, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorB5_ByID]", dgv5, frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B5, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorB6_ByID]", dgv6, frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B6, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorB7_ByID]", dgv7, frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B7, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorB8_ByID]", dgv8, frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B8, id)
	End Sub

	Sub SelUpd_PMAS_Part2FormC_Value(dgv1 As DataGridView, dgv2 As DataGridView, dgv3 As DataGridView, dgv4 As DataGridView, dgv5 As DataGridView, dgv6 As DataGridView, dgv7 As DataGridView, dgv8 As DataGridView, id As Integer)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorC1_ByID]", dgv1, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C1, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorC2_ByID]", dgv2, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C2, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorC3_ByID]", dgv3, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C3, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorC4_ByID]", dgv4, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C4, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorC5_ByID]", dgv5, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C5, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorC6_ByID]", dgv6, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C6, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorC7_ByID]", dgv7, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C7, id)
		Call SelUpd_LoadDataToGrid_PMAS_Part2Form("[spSelUpdHRIS_PMAS_Part2FormA_PerformanceFactorC8_ByID]", dgv8, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C8, id)
	End Sub

	Sub InsUpd_PMAS_Part2FormB()

		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_PMAS_Part2Form1_PerformanceFactorB]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormBID)
			cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
			cmd.Parameters.AddWithValue("@Part1ID", _strPerformancePart1Form1ID)

			Dim table1 As New DataTable()
			table1.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B1.ForEach(Sub(id) table1.Rows.Add(id))
			cmd.Parameters.AddWithValue("@B1", table1).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@B1").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWB1", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW1.Text)
			cmd.Parameters.AddWithValue("@AFWB1", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.txtTFW1.Text)

			Dim table2 As New DataTable()
			table2.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B2.ForEach(Sub(id) table2.Rows.Add(id))
			cmd.Parameters.AddWithValue("@B2", table2).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@B2").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWB2", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW2.Text)
			cmd.Parameters.AddWithValue("@AFWB2", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.txtTFW2.Text)

			Dim table3 As New DataTable()
			table3.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B3.ForEach(Sub(id) table3.Rows.Add(id))
			cmd.Parameters.AddWithValue("@B3", table3).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@B3").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWB3", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW3.Text)
			cmd.Parameters.AddWithValue("@AFWB3", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.txtTFW3.Text)

			Dim table4 As New DataTable()
			table4.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B4.ForEach(Sub(item) table4.Rows.Add(item))
			cmd.Parameters.AddWithValue("@B4", table4).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@B4").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWB4", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW4.Text)
			cmd.Parameters.AddWithValue("@AFWB4", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.txtTFW4.Text)

			Dim table5 As New DataTable()
			table5.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B5.ForEach(Sub(id) table5.Rows.Add(id))
			cmd.Parameters.AddWithValue("@B5", table5).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@B5").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWB5", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW5.Text)
			cmd.Parameters.AddWithValue("@AFWB5", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.txtTFW5.Text)

			Dim table6 As New DataTable()
			table6.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B6.ForEach(Sub(id) table6.Rows.Add(id))
			cmd.Parameters.AddWithValue("@B6", table6).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@B6").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWB6", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW6.Text)
			cmd.Parameters.AddWithValue("@AFWB6", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.txtTFW6.Text)

			Dim table7 As New DataTable()
			table7.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B7.ForEach(Sub(id) table7.Rows.Add(id))
			cmd.Parameters.AddWithValue("@B7", table7).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@B7").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWB7", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW7.Text)
			cmd.Parameters.AddWithValue("@AFWB7", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.txtTFW7.Text)

			Dim table8 As New DataTable()
			table8.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.B8.ForEach(Sub(id) table8.Rows.Add(id))
			cmd.Parameters.AddWithValue("@B8", table8).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@B8").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWB8", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.txtFW8.Text)
			cmd.Parameters.AddWithValue("@AFWB8", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.txtTFW8.Text)

			cmd.Parameters.AddWithValue("@Reviewer", frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.cbReviewer.Text)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

			If cmd.ExecuteNonQuery = -1 Then
				MessageBox.Show("Saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Call Sel_PMAS_Part2AllForms_ByEmployeeID(frmHRIS_Transaction_PerformanceManagement_Part2.dgvPerformanceFactors)
				Call frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.Dispose()
				Call frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.Dispose()
			End If

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try

	End Sub

	Sub InsUpd_PMAS_Part2FormC()

		Try
			Conn = New SqlConnection(StrConn)
			Conn.Open()
			cmd = Conn.CreateCommand
			cmd.CommandText = "[spInsUpdHRIS_PMAS_Part2Form1_PerformanceFactorC]"
			cmd = New SqlCommand(cmd.CommandText, Conn) With {
						.CommandType = CommandType.StoredProcedure
					}

			cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormCID)
			cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
			cmd.Parameters.AddWithValue("@Part1ID", _strPerformancePart1Form1ID)

			Dim table1 As New DataTable()
			table1.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C1.ForEach(Sub(id) table1.Rows.Add(id))
			cmd.Parameters.AddWithValue("@C1", table1).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@C1").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWC1", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW1.Text)
			cmd.Parameters.AddWithValue("@AFWC1", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.txtTFW1.Text)

			Dim table2 As New DataTable()
			table2.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C2.ForEach(Sub(id) table2.Rows.Add(id))
			cmd.Parameters.AddWithValue("@C2", table2).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@C2").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWC2", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW2.Text)
			cmd.Parameters.AddWithValue("@AFWC2", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.txtTFW2.Text)

			Dim table3 As New DataTable()
			table3.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C3.ForEach(Sub(id) table3.Rows.Add(id))
			cmd.Parameters.AddWithValue("@C3", table3).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@C3").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWC3", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW3.Text)
			cmd.Parameters.AddWithValue("@AFWC3", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.txtTFW3.Text)

			Dim table4 As New DataTable()
			table4.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C4.ForEach(Sub(item) table4.Rows.Add(item))
			cmd.Parameters.AddWithValue("@C4", table4).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@C4").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWC4", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW4.Text)
			cmd.Parameters.AddWithValue("@AFWC4", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.txtTFW4.Text)

			Dim table5 As New DataTable()
			table5.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C5.ForEach(Sub(id) table5.Rows.Add(id))
			cmd.Parameters.AddWithValue("@C5", table5).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@C5").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWC5", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW5.Text)
			cmd.Parameters.AddWithValue("@AFWC5", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.txtTFW5.Text)

			Dim table6 As New DataTable()
			table6.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C6.ForEach(Sub(id) table6.Rows.Add(id))
			cmd.Parameters.AddWithValue("@C6", table6).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@C6").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWC6", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW6.Text)
			cmd.Parameters.AddWithValue("@AFWC6", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.txtTFW6.Text)

			Dim table7 As New DataTable()
			table7.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C7.ForEach(Sub(id) table7.Rows.Add(id))
			cmd.Parameters.AddWithValue("@C7", table7).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@C7").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWC7", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW7.Text)
			cmd.Parameters.AddWithValue("@AFWC7", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.txtTFW7.Text)

			Dim table8 As New DataTable()
			table8.Columns.Add("ID", GetType(Integer))
			frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.C8.ForEach(Sub(id) table8.Rows.Add(id))
			cmd.Parameters.AddWithValue("@C8", table8).SqlDbType = SqlDbType.Structured
			cmd.Parameters("@C8").TypeName = "dbo.IntList"

			cmd.Parameters.AddWithValue("@FWC8", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW8.Text)
			cmd.Parameters.AddWithValue("@AFWC8", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.txtTFW8.Text)

			cmd.Parameters.AddWithValue("@Reviewer", frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.cbReviewer.Text)
			cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

			If cmd.ExecuteNonQuery = -1 Then
				MessageBox.Show("Saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Call Sel_PMAS_Part2AllForms_ByEmployeeID(frmHRIS_Transaction_PerformanceManagement_Part2.dgvPerformanceFactors)
				Call frmHRIS_PerformanceManagement_AddUpdatePart2_FormC.Dispose()
				Call frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.Dispose()
			End If

		Catch ex As Exception
			MessageBox.Show("Error Occured: " & ex.Message)
		Finally
			Conn.Close()
			cmd.Parameters.Clear()
		End Try

	End Sub

	Sub Del_PMAS_Part1Form1_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_PMAS_Part1Form1]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form1ID)
				cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()
				MsgBox("Deletion Success!")
			End Using
		End Using
		dgv.Rows.Remove(dgv.SelectedRows(0))
	End Sub

	Sub Del_PMAS_Part1Form2_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_PMAS_Part1Form2]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form2ID)
				cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()
				MsgBox("Deletion Success!")
			End Using
		End Using
		dgv.Rows.Remove(dgv.SelectedRows(0))
	End Sub

	Sub Del_PMAS_Part2FormFactorA_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_PMAS_Part2Factor_A]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormAID)
				cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()
				MsgBox("Deletion Success!")
			End Using
		End Using
		dgv.Rows.Remove(dgv.SelectedRows(0))
	End Sub

	Sub Del_PMAS_Part2FormFactorB_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_PMAS_Part2Factor_B]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormBID)
				cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()
				MsgBox("Deletion Success!")
			End Using
		End Using
		dgv.Rows.Remove(dgv.SelectedRows(0))
	End Sub

	Sub Del_PMAS_Part2FormFactorC_ByID(dgv As DataGridView)
		If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
		Using Conn As New SqlConnection(StrConn)
			Conn.Open()
			Using cmd As New SqlCommand("[spDelHRIS_PMAS_Part2Factor_C]", Conn)
				cmd.CommandType = CommandType.StoredProcedure
				cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormCID)
				cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
				cmd.ExecuteNonQuery()
				MsgBox("Deletion Success!")
			End Using
		End Using
		dgv.Rows.Remove(dgv.SelectedRows(0))
	End Sub

	''--->>> Reports - PMAS <<<---

	Sub PrintRPT_PMAS_Part1Form1()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_PMAS_Part1_Form1
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_PMAS_Part1_Form1]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form1ID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							rpt.SetParameterValue("@ID", _strPerformancePart1Form1ID)
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
							frmHRIS_Report_CrystalReportsHolder.ShowDialog()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	'Sub Check_ProjectNumber_Part1Form2()
	'	Dim isMoreThan4 As Integer = 0
	'	Conn = New SqlConnection(StrConn)
	'	Conn.Open()
	'	cmd = Conn.CreateCommand
	'	cmd.CommandText = "[spSelHRIS_PMAS_CheckProjectNumber_Part1Form2]"
	'	cmd = New SqlCommand(cmd.CommandText, Conn) With {
	'					.CommandType = CommandType.StoredProcedure
	'					}
	'	cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form2ID)

	'	isMoreThan4 = cmd.ExecuteScalar

	'	If isMoreThan4 Then
	'		PrintRPT_PMAS_Part1Form2_Projects_8()
	'	Else
	'		PrintRPT_PMAS_Part1Form2_Projects_4()
	'	End If

	'	Conn.Close()
	'	cmd.Parameters.Clear()
	'End Sub

	'Sub PrintRPT_PMAS_Part1Form2_Projects_4()
	'	' Show loading form
	'	frmLoading.Show()
	'	frmLoading.Refresh() ' Force UI update before running long operations

	'	Try
	'		Dim rpt As New rptHRIS_PMAS_Part1_Form2_Projects4
	'		rpt.SetDatabaseLogon("sa", "3dcoP2024")

	'		Using Conn As New SqlConnection(StrConn)
	'			Conn.Open()
	'			Using cmd As New SqlCommand("[spRptHRIS_PMAS_Part1_Form2_Project4]", Conn)
	'				cmd.CommandType = CommandType.StoredProcedure
	'				cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form2ID)
	'				Using dr As SqlDataReader = cmd.ExecuteReader()
	'					If dr.HasRows Then
	'						rpt.SetParameterValue("@ID", _strPerformancePart1Form2ID)
	'						frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
	'						frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
	'						frmHRIS_Report_CrystalReportsHolder.ShowDialog()
	'					Else
	'						MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
	'					End If
	'				End Using
	'			End Using
	'		End Using

	'		Conn.Close()
	'		dr.Close()

	'	Catch ex As Exception
	'		MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
	'	Finally
	'		frmLoading.Close() ' Ensure loading form is closed properly
	'	End Try

	'End Sub

	'Sub PrintRPT_PMAS_Part1Form2_Projects_8()
	'	' Show loading form
	'	frmLoading.Show()
	'	frmLoading.Refresh() ' Force UI update before running long operations

	'	Try
	'		Dim rpt As New rptHRIS_PMAS_Part1_Form2_Projects8
	'		rpt.SetDatabaseLogon("sa", "3dcoP2024")

	'		Using Conn As New SqlConnection(StrConn)
	'			Conn.Open()
	'			Using cmd As New SqlCommand("[spRptHRIS_PMAS_Part1_Form2_Project8]", Conn)
	'				cmd.CommandType = CommandType.StoredProcedure
	'				cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form2ID)
	'				Using dr As SqlDataReader = cmd.ExecuteReader()
	'					If dr.HasRows Then
	'						rpt.SetParameterValue("@ID", _strPerformancePart1Form2ID)
	'						frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
	'						frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
	'						frmHRIS_Report_CrystalReportsHolder.ShowDialog()
	'					Else
	'						MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
	'					End If
	'				End Using
	'			End Using
	'		End Using

	'		Conn.Close()
	'		dr.Close()

	'	Catch ex As Exception
	'		MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
	'	Finally
	'		frmLoading.Close() ' Ensure loading form is closed properly
	'	End Try

	'End Sub

	Sub PrintRPT_PMAS_Part1Form2_POSS()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_PMAS_Part1_Form2_POSS
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_PMAS_Part1_Form2_POSS]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@ID", _strPerformancePart1Form2ID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							rpt.SetParameterValue("@ID", _strPerformancePart1Form2ID)
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
							frmHRIS_Report_CrystalReportsHolder.ShowDialog()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	Sub PrintRPT_PMAS_Part2Factor_A()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_PMAS_Part2_Factor_A
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_PMAS_Part2_Factor_A]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormAID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							rpt.SetParameterValue("@ID", _strPerformancePart2FormAID)
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
							frmHRIS_Report_CrystalReportsHolder.ShowDialog()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub


	Sub PrintRPT_PMAS_Part2Factor_B()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_PMAS_Part2_Factor_B
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_PMAS_Part2_Factor_B]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormBID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							rpt.SetParameterValue("@ID", _strPerformancePart2FormBID)
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
							frmHRIS_Report_CrystalReportsHolder.ShowDialog()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub

	Sub PrintRPT_PMAS_Part2Factor_C()
		' Show loading form
		frmLoading.Show()
		frmLoading.Refresh() ' Force UI update before running long operations

		Try
			Dim rpt As New rptHRIS_PMAS_Part2_Factor_C
			rpt.DataSourceConnections(0).SetConnection(ServerIP, DatabaseName, DBUser, DBPass)
			rpt.DataSourceConnections(0).SetLogon(DBUser, DBPass)

			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spRptHRIS_PMAS_Part2_Factor_C]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@ID", _strPerformancePart2FormCID)
					Using dr As SqlDataReader = cmd.ExecuteReader()
						If dr.HasRows Then
							rpt.SetParameterValue("@ID", _strPerformancePart2FormCID)
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.ReportSource = rpt
							frmHRIS_Report_CrystalReportsHolder.HRIS_CrystalReports_Holder.Refresh()
							frmHRIS_Report_CrystalReportsHolder.ShowDialog()
						Else
							MessageBox.Show("Error Occurred, please try again.", "EDCOP Project Monitoring System", MessageBoxButtons.OK, MessageBoxIcon.Information)
						End If
					End Using
				End Using
			End Using

			Conn.Close()
			dr.Close()

		Catch ex As Exception
			MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			frmLoading.Close() ' Ensure loading form is closed properly
		End Try

	End Sub


	Sub Sel_IHB_PCSR_ProjectList(dgv As DataGridView, txtbox As TextBox, txt As ToolStripLabel)
		dgv.Rows.Clear()
		Try
			Using Conn As New SqlConnection(StrConn)
				Conn.Open()
				Using cmd As New SqlCommand("[spSelIHB_PCSR_AllProjectList]", Conn)
					cmd.CommandType = CommandType.StoredProcedure
					cmd.Parameters.AddWithValue("@txt", txtbox.Text)
					Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
					returnParam.Direction = ParameterDirection.Output
					cmd.Parameters.Add(returnParam)

					Using dr As SqlDataReader = cmd.ExecuteReader()
						While dr.Read()
							txt.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
							dgv.Rows.Add(
							dr.GetInt32(0),
							dr.GetInt32(1),
							dr.GetString(2),
							dr.GetString(3),
							dr.GetString(4),
							dr.GetString(5),
							dr.GetString(6),
							dr.GetString(7))
						End While
					End Using
					txt.Text = If(IsDBNull(returnParam.Value), "0", returnParam.Value.ToString())
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		dgv.ClearSelection()
	End Sub









End Module
