Imports System.Data.SqlClient
Module Module_TimeSheet

    Public isPopulating = True

    Public _OfficialBusFileID As Integer
    Public _OverTimeFileID As Integer
    Public _UnderTimeFileID As Integer
    Public _LeaveFileID As Integer


    Sub switchPanelEmployeeLeave(ByVal panel As Form)
        frmTimeKeeping_Transaction_EmployeeLeave.PanelTimeKeepingHolder.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        frmTimeKeeping_Transaction_EmployeeLeave.PanelTimeKeepingHolder.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub SelUpd_Timesheet_PerDay()

        Conn = New SqlConnection(StrConn)
        cmd = New SqlCommand("[spSelBMT_DayTimelogByID]", Conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID", _strTimeSheetID)
        Conn.Open()
        dr = cmd.ExecuteReader()
        While (dr.Read())

            frmTS_Edit.cmboBoxTimeIn.Text = dr.GetString(3)
            frmTS_Edit.cmboBoxBreakOut.Text = dr.GetString(4)
            frmTS_Edit.cmboBoxBreakIn.Text = dr.GetString(5)
            frmTS_Edit.cmboBoxTimeOut.Text = dr.GetString(6)
            frmTS_Edit.cmboBoxOTIn.Text = dr.GetString(7)
            frmTS_Edit.cmboBoxOTOut.Text = dr.GetString(8)

        End While
        dr.Close()
        Conn.Close()

    End Sub

    Sub Populate_ComboBox_TimeSheet()

        Conn = New SqlConnection(StrConn)
        frmTS_Edit.cmboBoxTimeIn.Items.Clear()
        cmd.CommandText = "[spSelBMT_TimelogByDayForDC]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }
        cmd.Parameters.AddWithValue("@ID", _strTimeSheetID)
        Conn.Open()
        dr = cmd.ExecuteReader()
        While dr.Read()
            Dim a = dr.GetString(1)
            frmTS_Edit.cmboBoxTimeIn.Items.Add(a)
            frmTS_Edit.cmboBoxBreakOut.Items.Add(a)
            frmTS_Edit.cmboBoxBreakIn.Items.Add(a)
            frmTS_Edit.cmboBoxTimeOut.Items.Add(a)
            frmTS_Edit.cmboBoxOTIn.Items.Add(a)
            frmTS_Edit.cmboBoxOTOut.Items.Add(a)
        End While
        dr.Close()
        Conn.Close()

    End Sub

    Sub InsUpd_TimeSheet()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd.Connection.CreateCommand()
        cmd.CommandText = "[spUpdBMT_TimeLogPerDay]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@ID", _strTimeSheetID)
        cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
        cmd.Parameters.AddWithValue("@TimeIn", frmTS_Edit.cmboBoxTimeIn.Text)
        cmd.Parameters.AddWithValue("@BreakOut", frmTS_Edit.cmboBoxBreakOut.Text)
        cmd.Parameters.AddWithValue("@BreakIn", frmTS_Edit.cmboBoxBreakIn.Text)
        cmd.Parameters.AddWithValue("@Timeout", frmTS_Edit.cmboBoxTimeOut.Text)
        cmd.Parameters.AddWithValue("@OTIn", frmTS_Edit.cmboBoxOTIn.Text)
        cmd.Parameters.AddWithValue("@OTOut", frmTS_Edit.cmboBoxOTOut.Text)
        cmd.Parameters.AddWithValue("@ModifiedBy", frmMain.ToolStripEmployeeNo.Text)

        If cmd.ExecuteNonQuery = -1 Then

            If _strUserLevel = "Individual" Then

                '\\ This code is to refresh PayPeriod details.
                Insert_PayrollPeriod_Details(frmPMS_Individual.dgvPayrollPeriodDetails)


                '\\ This code will refresh activitylog from main form.
                Select_ActivityLog()

                frmTS_Edit.Dispose()

            End If

            '-----------------------------------------------------------------------------

            If _strUserLevel = "Master" Then

                '\\ This code is to refresh PayPeriod details.
                Insert_PayrollPeriod_Details(frmPMS_Administrator.dgvPayrollPeriodDetails)



                '\\ This code will refresh activitylog from main form.
                Select_ActivityLog()
                frmTS_Edit.Dispose()

            End If



        Else

            MessageBox.Show("Cannot Update, Something went wrong. ", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub DropDownListLeavePurpose(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelTKMS_Leave_Purpose]"
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

    Sub DropDownListLeaveTransport(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelTKMS_Leave_Transport]"
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

    Sub DropDownListLeaveStatus(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelTKMS_LeaveStatus]"
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

    Sub DropDownListLeaveProjectName(cBox As ComboBox)
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spSelTKMS_Leave_ProjectName]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cBox.Items.Clear()
                Dim projectDictionary As New Dictionary(Of String, Integer)()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim id As Integer = reader.GetInt32(0)
                        Dim project As String = reader.GetString(1)
                        projectDictionary.Add(project, id)
                        cBox.Items.Add(project)
                    End While
                End Using
                cBox.Tag = projectDictionary
            End Using
        End Using
    End Sub

    Sub DropDownListLeaveOverHeadDept(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelTKMS_Leave_OverHeadDept]"
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

    Sub DropDownListLeaveType(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelTKMS_Leave_LeaveType]"
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

    Sub DropDownListDayType(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelTKMS_Leave_DayType]"
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

    '---- >>> Official Business Form <<< ----

    Sub SelTK_Personnel_OfficialBusinessByID(dgv As DataGridView, txt As ToolStripLabel)
        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelTKMS_Leave_OfficialBusinessByID]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)

                    Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
                    returnParam.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(returnParam)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            txt.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
                            dgv.Rows.Add(
                                Convert.ToInt32(dr(0)),
                                dr(1).ToString(),
                                dr(2).ToString(),
                                dr(3).ToString(),
                                dr(4).ToString(),
                                dr(5).ToString(),
                                dr(6).ToString(),
                                dr(7).ToString(),
                                dr(8).ToString(),
                                dr(9).ToString(),
                                dr(10).ToString(),
                                dr(11).ToString(),
                                dr(12).ToString(),
                                dr(13).ToString(),
                                dr(14).ToString(),
                                dr(15).ToString(),
                                dr(16).ToString(),
                                dr(17).ToString(),
                                dr(18).ToString(),
                                dr(19).ToString())
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

    'Sub SelTK_Leave_OfficialBusinessID()
    '    Try
    '        Using Conn As New SqlConnection(StrConn),
    '        cmd As New SqlCommand("[spInsTKMS_Leave_OfficialBusinessID]", Conn)
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
    '            Dim voucherCodeParam As New SqlParameter("@ID", SqlDbType.Int)
    '            voucherCodeParam.Direction = ParameterDirection.Output
    '            cmd.Parameters.Add(voucherCodeParam)
    '            Conn.Open()
    '            cmd.ExecuteNonQuery()
    '            _OfficialBusFileID = CInt(cmd.Parameters("@ID").Value)
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Sub DelTK_Leave_OfficialBusinessID()
    '    Try
    '        Using Conn As New SqlConnection(StrConn)
    '            Conn.Open()
    '            Using cmd As New SqlCommand("[spDelTKMS_Leave_OfficialBusinessID]", Conn)
    '                cmd.CommandType = CommandType.StoredProcedure
    '                cmd.Parameters.AddWithValue("@ID", _OfficialBusFileID)
    '                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
    '                cmd.ExecuteNonQuery()
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Sub InsUpd_OfficialBusiness_By_PersonnelID(dataGridView As DataGridView)
        Try
            Conn = New SqlConnection(StrConn)
            Conn.Open()
            cmd.Connection.CreateCommand()
            cmd.CommandText = "[spInsUpdTKMS_Leave_OfficialBusiness]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", _OfficialBusFileID)
            cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)

            If Not frmTK_AddUpdOfficialBusiness.txtPOthers.Enabled Then
                cmd.Parameters.AddWithValue("@PurposeID", frmTK_AddUpdOfficialBusiness.cbPurpose.Text)
            Else
                cmd.Parameters.AddWithValue("@PurposeID", frmTK_AddUpdOfficialBusiness.txtPOthers.Text)
            End If

            If Not frmTK_AddUpdOfficialBusiness.txtTOthers.Enabled Then
                cmd.Parameters.AddWithValue("@TransportID", frmTK_AddUpdOfficialBusiness.cbTransport.Text)
            Else
                cmd.Parameters.AddWithValue("@TransportID", frmTK_AddUpdOfficialBusiness.txtTOthers.Text)
            End If

            cmd.Parameters.AddWithValue("@DestinationFrom", frmTK_AddUpdOfficialBusiness.txtDestinationFrom.Text)
            cmd.Parameters.AddWithValue("@DestinationTo", frmTK_AddUpdOfficialBusiness.txtDestinationTo.Text)
            cmd.Parameters.AddWithValue("@DepartureDate", frmTK_AddUpdOfficialBusiness.dtpDepartureDate.Value.Date)
            cmd.Parameters.AddWithValue("@ArrivalDate", frmTK_AddUpdOfficialBusiness.dtpArrivalDate.Value.Date)
            cmd.Parameters.AddWithValue("@DepartureTime", frmTK_AddUpdOfficialBusiness.dtpETD.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@ArrivalTime", frmTK_AddUpdOfficialBusiness.dtpETA.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@ProjectID", _ProjectChargingID1)
            cmd.Parameters.AddWithValue("@DeptID", _ProjectChargingID2)
            cmd.Parameters.AddWithValue("@PtypeID", _ProjectChargingID3)
            cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

            ' to output the ID or the newly created ID if insert to be used in storing details
            Dim returnParam As New SqlParameter("@ReturnTempID", SqlDbType.Int)
            returnParam.Direction = ParameterDirection.Output
            cmd.Parameters.Add(returnParam)

            cmd.ExecuteNonQuery()

            Dim returnTempID As Integer = If(IsDBNull(returnParam.Value), 0, Convert.ToInt32(returnParam.Value))

            ' Proceed if returnTempID is valid
            If returnTempID > 0 Then
                For Each row As DataGridViewRow In dataGridView.Rows
                    If row.IsNewRow Then Continue For
                    Using cmdInsertEmployee As New SqlCommand("[spInsUpdTKMS_Leave_OfficialBusinessDetail]", Conn)
                        cmdInsertEmployee.CommandType = CommandType.StoredProcedure
                        cmdInsertEmployee.Parameters.AddWithValue("@PID", returnTempID)
                        cmdInsertEmployee.Parameters.AddWithValue("@PersonnelID", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
                        cmdInsertEmployee.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                        cmdInsertEmployee.ExecuteNonQuery()
                    End Using
                Next
                MessageBox.Show("Saved.", "Infomation.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Something went wrong, please try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            frmTK_AddUpdOfficialBusiness.Dispose()
            frmTK_AddUpdOtherEmployeesOfficialBusiness.Dispose()
            frmTimeKeeping_Transaction_EmployeeLeave.WhatToLoad()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    Sub Upd_OfficialBusiness_Status_By_PersonnelID()
        Try
            Conn = New SqlConnection(StrConn)
            Conn.Open()
            cmd.Connection.CreateCommand()
            cmd.CommandText = "[spUpdTKMS_Leave_OfficialBusinessStatus]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", _OfficialBusFileID)
            cmd.Parameters.AddWithValue("@SupervisorName", frmTK_UpdateLeaveStatus.cbSupervisor.Text)
            cmd.Parameters.AddWithValue("@LeaveStatus", frmTK_UpdateLeaveStatus.cbStatus.Text)
            cmd.Parameters.AddWithValue("@StatusRemarks", frmTK_UpdateLeaveStatus.txtStatusRemarks.Text)
            cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

            If cmd.ExecuteNonQuery = -1 Then
                MessageBox.Show("Saved.", "Infomation.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Something went wrong, please try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            frmTK_UpdateLeaveStatus.Dispose()
            frmTimeKeeping_Transaction_EmployeeLeave.WhatToLoad()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    Sub SelUpd_OfficialBusiness_By_ID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdTKMS_Leave_OfficialBusinessByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _OfficialBusFileID)
                cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmTK_AddUpdOfficialBusiness.lblControlNumber.Text = dr(0).ToString()

                        Dim Purpose As String = dr(1).ToString()
                        Dim PurposeIndex As Integer = frmTK_AddUpdOfficialBusiness.cbPurpose.FindStringExact(Purpose)
                        If PurposeIndex = -1 Then
                            PurposeIndex = frmTK_AddUpdOfficialBusiness.cbPurpose.FindStringExact("Others, please specify...")
                            frmTK_AddUpdOfficialBusiness.txtPOthers.Text = Purpose
                        End If
                        frmTK_AddUpdOfficialBusiness.cbPurpose.SelectedIndex = PurposeIndex

                        frmTK_AddUpdOfficialBusiness.txtDestinationFrom.Text = dr(2).ToString()
                        frmTK_AddUpdOfficialBusiness.txtDestinationTo.Text = dr(3).ToString()

                        Dim Transport As String = dr(4).ToString()
                        Dim TransportIndex As Integer = frmTK_AddUpdOfficialBusiness.cbTransport.FindStringExact(Transport)
                        If TransportIndex = -1 Then
                            TransportIndex = frmTK_AddUpdOfficialBusiness.cbTransport.FindStringExact("Others, please specify...")
                            frmTK_AddUpdOfficialBusiness.txtTOthers.Text = Transport
                        End If
                        frmTK_AddUpdOfficialBusiness.cbTransport.SelectedIndex = TransportIndex

                        Dim departureDate As DateTime
                        If DateTime.TryParse(dr(5).ToString(), departureDate) Then
                            frmTK_AddUpdOfficialBusiness.dtpDepartureDate.Value = departureDate
                        End If

                        Dim arrivalDate As DateTime
                        If DateTime.TryParse(dr(6).ToString(), arrivalDate) Then
                            frmTK_AddUpdOfficialBusiness.dtpArrivalDate.Value = arrivalDate
                        End If

                        Dim departureTime As TimeSpan
                        If TimeSpan.TryParse(dr(7).ToString(), departureTime) Then
                            frmTK_AddUpdOfficialBusiness.dtpETD.Value = frmTK_AddUpdOfficialBusiness.dtpETD.Value.Date.Add(departureTime)
                        End If

                        Dim arrivalTime As TimeSpan
                        If TimeSpan.TryParse(dr(8).ToString(), arrivalTime) Then
                            frmTK_AddUpdOfficialBusiness.dtpETA.Value = frmTK_AddUpdOfficialBusiness.dtpETA.Value.Date.Add(arrivalTime)
                        End If

                        Dim DivisionIndex As Integer = frmTK_AddUpdOfficialBusiness.cbOverheadDept.FindStringExact(dr.GetString(9))
                        If DivisionIndex <> -1 Then
                            frmTK_AddUpdOfficialBusiness.cbOverheadDept.SelectedIndex = DivisionIndex
                        End If

                        Dim ProjectIndex As Integer = frmTK_AddUpdOfficialBusiness.cbProjectName.FindStringExact(dr.GetString(10))
                        If ProjectIndex <> -1 Then
                            frmTK_AddUpdOfficialBusiness.cbProjectName.SelectedIndex = ProjectIndex
                        End If

                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub SelUpd_OfficialBusinessGroup_By_ID(dgv As DataGridView)
        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelUpdTKMS_Leave_OfficialBusinessGroupByID]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ID", _OfficialBusFileID)
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            dgv.Rows.Add(
                                Convert.ToInt32(dr(0)),
                                dr(1).ToString(),
                                dr(2).ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dgv.ClearSelection()

    End Sub

    Sub Del_OfficialBusinessGroup_By_PersonnelID(dgv As DataGridView)
        If dgv.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record before attempting to delete.")
            Exit Sub
        End If

        If frmTK_AddUpdOtherEmployeesOfficialBusiness._AddedEmployeeID = 0 Then Return
        If MessageBox.Show("Are you sure you want to remove this Employee?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return

        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelTKMS_Leave_OfficialBusinessGroupByEmployeeID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _OfficialBusFileID)
                cmd.Parameters.AddWithValue("@EmployeeID", frmTK_AddUpdOtherEmployeesOfficialBusiness._AddedEmployeeID)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))
    End Sub

    Sub Del_OfficialBusiness_By_ID(dgv As DataGridView)
        If dgv.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select file before attempting to delete.")
            Exit Sub
        End If

        If String.IsNullOrEmpty(_OfficialBusFileID) Then Return
        If MessageBox.Show("Are you sure you want to delete this file?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return

        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelTKMS_Leave_OfficialBusinessByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _OfficialBusFileID)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))
    End Sub

    Sub Search_OfficialBusiness_By_CtrlNum(dgv As DataGridView, txtBox As TextBox)
        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelTKMS_Leave_OfficialBusiness_Search]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
        cmd.Parameters.AddWithValue("@Code", txtBox.Text)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then

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
                dr(8).ToString(),
                dr(9).ToString(),
                dr(10).ToString(),
                dr(11).ToString(),
                dr(12).ToString(),
                dr(13).ToString(),
                dr(14).ToString(),
                dr(15).ToString(),
                dr(16).ToString(),
                dr(17).ToString(),
                dr(18).ToString(),
                dr(19).ToString())
            End While

        Else
            MessageBox.Show("Record not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        dr.Dispose()
        Conn.Dispose()
        dgv.ClearSelection()
    End Sub

    '---- >>> Overtime Form <<< ----

    Sub SelTK_Personnel_OverTimeByID(dgv As DataGridView, txt As ToolStripLabel)
        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelTKMS_Leave_OvertimeByID]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ID", _strEmployeeID)

                    Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
                    returnParam.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(returnParam)

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
                                dr(8).ToString(),
                                dr(9).ToString(),
                                dr(10).ToString(),
                                dr(11).ToString(),
                                dr(12).ToString(),
                                dr(13).ToString(),
                                dr(14).ToString())
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

    Sub Search_Overtime_By_Date(dgv As DataGridView, txtBox As TextBox)
        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelTKMS_Leave_Overtime_Search]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
        cmd.Parameters.AddWithValue("@Date", txtBox.Text)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then

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
                dr(8).ToString(),
                dr(9).ToString(),
                dr(10).ToString(),
                dr(11).ToString(),
                dr(12).ToString(),
                dr(13).ToString(),
                dr(14).ToString())
            End While

        Else
            MessageBox.Show("Record not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        dr.Dispose()
        Conn.Dispose()
        dgv.ClearSelection()
    End Sub

    Sub InsUpd_Overtime_By_PersonnelID()
        Try
            Conn = New SqlConnection(StrConn)
            Conn.Open()
            cmd.Connection.CreateCommand()
            cmd.CommandText = "[spInsUpdTKMS_Leave_Overtime]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", _OverTimeFileID)
            cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
            cmd.Parameters.AddWithValue("@OvertimeDate", frmTK_AddUpdOverTime.dtpWorkDate.Value.Date)
            cmd.Parameters.AddWithValue("@StartTime", frmTK_AddUpdOverTime.dtpWTI.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@EndTime", frmTK_AddUpdOverTime.dtpWTO.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@ProjectID", _ProjectChargingID1)
            cmd.Parameters.AddWithValue("@DeptID", _ProjectChargingID2)
            cmd.Parameters.AddWithValue("@PtypeID", _ProjectChargingID3)
            cmd.Parameters.AddWithValue("@ActualOT", If(frmTK_AddUpdOverTime.chActualOvertime.Checked, True, False))
            cmd.Parameters.AddWithValue("@Remarks", frmTK_AddUpdOverTime.txtDetailsWork.Text)
            cmd.Parameters.AddWithValue("@DateFiled", frmTK_AddUpdOverTime.dtpDateFiling.Value.Date)
            cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

            If cmd.ExecuteNonQuery = -1 Then
                MessageBox.Show("Saved.", "Infomation.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Something went wrong, please try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            frmTK_AddUpdOverTime.Dispose()
            frmTimeKeeping_Transaction_EmployeeLeave.WhatToLoad()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    Sub SelUpd_OverTime_By_ID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdTKMS_Leave_OvertimeByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _OverTimeFileID)
                cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmTK_AddUpdOverTime.dtpWorkDate.Value = dr.GetDateTime(0)

                        Dim StartSpanValue As TimeSpan
                        If TimeSpan.TryParse(dr.GetString(1), StartSpanValue) Then
                            frmTK_AddUpdOverTime.dtpWTI.Value = frmTK_AddUpdOverTime.dtpWTI.Value.Date.Add(StartSpanValue)
                        End If

                        Dim EndSpanValue As TimeSpan
                        If TimeSpan.TryParse(dr.GetString(2), EndSpanValue) Then
                            frmTK_AddUpdOverTime.dtpWTO.Value = frmTK_AddUpdOverTime.dtpWTO.Value.Date.Add(EndSpanValue)
                        End If

                        Dim deptIndex As Integer = frmTK_AddUpdOverTime.cbOverheadDept.FindStringExact(dr.GetString(3))
                        If deptIndex <> -1 Then
                            frmTK_AddUpdOverTime.cbOverheadDept.SelectedIndex = deptIndex
                        End If

                        Dim projectIndex As Integer = frmTK_AddUpdOverTime.cbProjectName.FindStringExact(dr.GetString(4))
                        If projectIndex <> -1 Then
                            frmTK_AddUpdOverTime.cbProjectName.SelectedIndex = projectIndex
                        End If

                        frmTK_AddUpdOverTime.dtpDateFiling.Value = dr.GetDateTime(5)
                        frmTK_AddUpdOverTime.txtDetailsWork.Text = dr.GetString(6)
                        frmTK_AddUpdOverTime.chActualOvertime.Checked = dr.GetBoolean(7)
                    End If
                End Using
            End Using
        End Using
    End Sub

    Sub Del_Overtime_By_ID(dgv As DataGridView)
        If dgv.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select file before attempting to delete.")
            Exit Sub
        End If

        If String.IsNullOrEmpty(_OverTimeFileID) Then Return
        If MessageBox.Show("Are you sure you want to delete this file?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return

        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelTKMS_Leave_OvertimeByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _OverTimeFileID)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))
    End Sub

    Sub Upd_Overtime_Status_By_PersonnelID()
        Try
            Conn = New SqlConnection(StrConn)
            Conn.Open()
            cmd.Connection.CreateCommand()
            cmd.CommandText = "[spUpdTKMS_Leave_OvertimeStatus]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", _OverTimeFileID)
            cmd.Parameters.AddWithValue("@SupervisorName", frmTK_UpdateLeaveStatus.cbSupervisor.Text)
            cmd.Parameters.AddWithValue("@LeaveStatus", frmTK_UpdateLeaveStatus.cbStatus.Text)
            cmd.Parameters.AddWithValue("@StatusRemarks", frmTK_UpdateLeaveStatus.txtStatusRemarks.Text)
            cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

            If cmd.ExecuteNonQuery = -1 Then
                MessageBox.Show("Saved.", "Infomation.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Something went wrong, please try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            frmTK_UpdateLeaveStatus.Dispose()
            frmTimeKeeping_Transaction_EmployeeLeave.WhatToLoad()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    '---- >>> Undertime Form <<< ----

    Sub SelTK_Personnel_UndertimeByID(dgv As DataGridView, txt As ToolStripLabel)
        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelTKMS_Leave_UndertimeByID]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ID", _strEmployeeID)

                    Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
                    returnParam.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(returnParam)

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
                                dr(8).ToString(),
                                dr(9).ToString(),
                                dr(10).ToString(),
                                dr(11).ToString(),
                                dr(12).ToString())
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

    Sub InsUpd_Undertime_By_PersonnelID()
        Try
            Conn = New SqlConnection(StrConn)
            Conn.Open()
            cmd.Connection.CreateCommand()
            cmd.CommandText = "[spInsUpdTKMS_Leave_Undertime]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", _UnderTimeFileID)
            cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
            cmd.Parameters.AddWithValue("@UndertimeDate", frmTK_AddUpdUnderTime.dtpWorkDate.Value.Date)
            cmd.Parameters.AddWithValue("@EWTime", frmTK_AddUpdUnderTime.dtpEWT.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@SWTime", frmTK_AddUpdUnderTime.dtpSWT.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@ActualUT", If(frmTK_AddUpdUnderTime.chLateFiling.Checked, True, False))
            cmd.Parameters.AddWithValue("@Reason", frmTK_AddUpdUnderTime.txtReason.Text)
            cmd.Parameters.AddWithValue("@DateFiled", frmTK_AddUpdUnderTime.dtpDateFiling.Value.Date)
            cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

            If cmd.ExecuteNonQuery = -1 Then
                MessageBox.Show("Saved.", "Infomation.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Something went wrong, please try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            frmTK_AddUpdUnderTime.Dispose()
            frmTimeKeeping_Transaction_EmployeeLeave.WhatToLoad()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    Sub SelUpd_UnderTime_By_ID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdTKMS_Leave_UndertimeByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _UnderTimeFileID)
                cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmTK_AddUpdUnderTime.dtpWorkDate.Value = dr.GetDateTime(0)

                        Dim StartSpanValue As TimeSpan
                        If TimeSpan.TryParse(dr.GetString(1), StartSpanValue) Then
                            frmTK_AddUpdUnderTime.dtpEWT.Value = frmTK_AddUpdOverTime.dtpWTI.Value.Date.Add(StartSpanValue)
                        End If

                        Dim EndSpanValue As TimeSpan
                        If TimeSpan.TryParse(dr.GetString(2), EndSpanValue) Then
                            frmTK_AddUpdUnderTime.dtpSWT.Value = frmTK_AddUpdOverTime.dtpWTO.Value.Date.Add(EndSpanValue)
                        End If

                        frmTK_AddUpdUnderTime.dtpDateFiling.Value = dr.GetDateTime(4)
                        frmTK_AddUpdUnderTime.txtReason.Text = dr.GetString(5)
                        frmTK_AddUpdUnderTime.chLateFiling.Checked = dr.GetBoolean(3)
                    End If
                End Using
            End Using
        End Using
    End Sub

    Sub Upd_Undertime_Status_By_PersonnelID()
        Try
            Conn = New SqlConnection(StrConn)
            Conn.Open()
            cmd.Connection.CreateCommand()
            cmd.CommandText = "[spUpdTKMS_Leave_UndertimeStatus]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", _UnderTimeFileID)
            cmd.Parameters.AddWithValue("@SupervisorName", frmTK_UpdateLeaveStatus.cbSupervisor.Text)
            cmd.Parameters.AddWithValue("@LeaveStatus", frmTK_UpdateLeaveStatus.cbStatus.Text)
            cmd.Parameters.AddWithValue("@StatusRemarks", frmTK_UpdateLeaveStatus.txtStatusRemarks.Text)
            cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

            If cmd.ExecuteNonQuery = -1 Then
                MessageBox.Show("Saved.", "Infomation.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Something went wrong, please try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            frmTK_UpdateLeaveStatus.Dispose()
            frmTimeKeeping_Transaction_EmployeeLeave.WhatToLoad()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    Sub Del_Undertime_By_ID(dgv As DataGridView)
        If dgv.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select file before attempting to delete.")
            Exit Sub
        End If

        If String.IsNullOrEmpty(_UnderTimeFileID) Then Return
        If MessageBox.Show("Are you sure you want to delete this file?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return

        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelTKMS_Leave_UndertimeByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _UnderTimeFileID)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))
    End Sub

    Sub Search_Undertime_By_Date(dgv As DataGridView, txtBox As TextBox)
        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelTKMS_Leave_Undertime_Search]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
        cmd.Parameters.AddWithValue("@Date", txtBox.Text)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then

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
                dr(8).ToString(),
                dr(9).ToString(),
                dr(10).ToString(),
                dr(11).ToString(),
                dr(12).ToString())
            End While

        Else
            MessageBox.Show("Record not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        dr.Dispose()
        Conn.Dispose()
        dgv.ClearSelection()
    End Sub


    '---- >>> Leave / PTO <<< ----

    Sub SelTK_Personnel_LeaveByID(dgv As DataGridView, txt As ToolStripLabel)
        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelTKMS_Leave_EmployeeLeaveByID]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ID", _strEmployeeID)

                    Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
                    returnParam.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(returnParam)

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
                                dr(8).ToString(),
                                dr(9).ToString(),
                                dr(10).ToString(),
                                dr(11).ToString(),
                                dr(12).ToString(),
                                dr(13).ToString(),
                                dr(14).ToString(),
                                dr(15).ToString(),
                                dr(16).ToString(),
                                dr(17).ToString())
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

    Sub SelTK_LeaveType_isPaid_By_ID(ByRef LeaveTypes As List(Of String))
        Using Conn As New SqlConnection(StrConn)
            Dim cmd As New SqlCommand("spSelTKMS_Leave_EmployeeLeaveTypePaid", Conn)
            Conn.Open()
            cmd.CommandType = CommandType.StoredProcedure
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                LeaveTypes.Add(Convert.ToString(reader(0)))
            End While
            reader.Close()
        End Using
    End Sub

    Sub SelTK_EmployeeLeave_Credits_By_Leave_Type_ID(txtLeaveCredits As TextBox, LeaveType As String)
        Using Conn As New SqlConnection(StrConn),
              cmd As New SqlCommand("[spSelTKMS_Leave_EmployeeLeaveCreditsByType]", Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
            cmd.Parameters.AddWithValue("@LeaveType", LeaveType)
            Conn.Open()

            Using dr As SqlDataReader = cmd.ExecuteReader()
                txtLeaveCredits.Text = If(dr.Read(), If(dr.IsDBNull(0), "0.00", dr.GetDecimal(0).ToString("F2")), "0.00")
            End Using

        End Using
    End Sub

    Sub InsUpd_EmployeeLeave_By_PersonnelID()
        Try
            Conn = New SqlConnection(StrConn)
            Conn.Open()
            cmd.Connection.CreateCommand()
            cmd.CommandText = "[spInsUpdTKMS_Leave_EmployeeLeave]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", _LeaveFileID)
            cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
            cmd.Parameters.AddWithValue("@LeaveType", frmTK_AddUpdLeave.cbLeaveType.Text)
            cmd.Parameters.AddWithValue("@StartDate", frmTK_AddUpdLeave.dtpStartPeriod.Value.Date + frmTK_AddUpdLeave.dtpSST.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@EndDate", frmTK_AddUpdLeave.dtpEndPeriod.Value.Date + frmTK_AddUpdLeave.dtpSET.Value.TimeOfDay)
            cmd.Parameters.AddWithValue("@LeaveCount", frmTK_AddUpdLeave.txtNumDays.Text)
            cmd.Parameters.AddWithValue("@LeaveCredit", frmTK_AddUpdLeave.txtLeaveCredits.Text)
            cmd.Parameters.AddWithValue("@DayType", frmTK_AddUpdLeave.cbDayType.Text)
            cmd.Parameters.AddWithValue("@Remarks", frmTK_AddUpdLeave.txtRemarks.Text)
            cmd.Parameters.AddWithValue("@isFiled", If(frmTK_AddUpdLeave.chLateFiling.Checked, True, False))
            cmd.Parameters.AddWithValue("@DateFiled", frmTK_AddUpdLeave.dtpDateFiling.Value.Date)
            cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

            If cmd.ExecuteNonQuery = -1 Then
                MessageBox.Show("Saved.", "Infomation.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Something went wrong, please try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            frmTK_AddUpdLeave.Dispose()
            frmTimeKeeping_Transaction_EmployeeLeave.WhatToLoad()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    Sub SelUpd_EmployeeLeave_By_ID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdTKMS_Leave_EmployeeLeaveByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _LeaveFileID)
                cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then

                        Dim typeIndex As Integer = frmTK_AddUpdLeave.cbLeaveType.FindStringExact(dr.GetString(0))
                        If typeIndex <> -1 Then
                            frmTK_AddUpdLeave.cbLeaveType.SelectedIndex = typeIndex
                        End If

                        frmTK_AddUpdLeave.dtpStartPeriod.Value = dr.GetDateTime(1)
                        frmTK_AddUpdLeave.dtpEndPeriod.Value = dr.GetDateTime(2)

                        Dim StartSpanValue As TimeSpan
                        If TimeSpan.TryParse(dr.GetString(3), StartSpanValue) Then
                            frmTK_AddUpdLeave.dtpSST.Value = frmTK_AddUpdLeave.dtpSST.Value.Date.Add(StartSpanValue)
                        End If

                        Dim EndSpanValue As TimeSpan
                        If TimeSpan.TryParse(dr.GetString(4), EndSpanValue) Then
                            frmTK_AddUpdLeave.dtpSET.Value = frmTK_AddUpdLeave.dtpSET.Value.Date.Add(EndSpanValue)
                        End If

                        frmTK_AddUpdLeave.txtNumDays.Text = dr.GetDecimal(5)

                        Dim dayIndex As Integer = frmTK_AddUpdLeave.cbDayType.FindStringExact(dr.GetString(6))
                        If dayIndex <> -1 Then
                            frmTK_AddUpdLeave.cbDayType.SelectedIndex = dayIndex
                        End If

                        frmTK_AddUpdLeave.chLateFiling.Checked = dr.GetBoolean(7)
                        frmTK_AddUpdLeave.dtpDateFiling.Value = dr.GetDateTime(8)
                        frmTK_AddUpdLeave.txtRemarks.Text = dr.GetString(9)
                    End If
                End Using
            End Using
        End Using
    End Sub

    Sub Upd_EmployeeLeave_Status_By_PersonnelID()
        Try
            Conn = New SqlConnection(StrConn)
            Conn.Open()
            cmd.Connection.CreateCommand()
            cmd.CommandText = "[spUpdTKMS_Leave_EmployeeLeaveStatus]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", _LeaveFileID)
            cmd.Parameters.AddWithValue("@SupervisorName", frmTK_UpdateLeaveStatus.cbSupervisor.Text)
            cmd.Parameters.AddWithValue("@LeaveStatus", frmTK_UpdateLeaveStatus.cbStatus.Text)
            cmd.Parameters.AddWithValue("@StatusRemarks", frmTK_UpdateLeaveStatus.txtStatusRemarks.Text)
            cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

            If cmd.ExecuteNonQuery = -1 Then
                MessageBox.Show("Saved.", "Infomation.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Something went wrong, please try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            frmTK_UpdateLeaveStatus.Dispose()
            frmTimeKeeping_Transaction_EmployeeLeave.WhatToLoad()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    Sub Search_EmployeeLeave_By_Date(dgv As DataGridView, txtBox As TextBox)
        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelTKMS_Leave_EmployeeLeave_Search]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
        cmd.Parameters.AddWithValue("@Date", txtBox.Text)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then

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
                dr(8).ToString(),
                dr(9).ToString(),
                dr(10).ToString(),
                dr(11).ToString(),
                dr(12).ToString(),
                dr(13).ToString(),
                dr(14).ToString(),
                dr(15).ToString(),
                dr(16).ToString(),
                dr(17).ToString())
            End While

        Else
            MessageBox.Show("Record not found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        dr.Dispose()
        Conn.Dispose()
        dgv.ClearSelection()
    End Sub

    Sub Del_EmployeeLeave_By_ID(dgv As DataGridView)
        If dgv.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select file before attempting to delete.")
            Exit Sub
        End If

        If String.IsNullOrEmpty(_LeaveFileID) Then Return
        If MessageBox.Show("Are you sure you want to delete this file?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return

        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelTKMS_Leave_EmployeeLeaveByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _LeaveFileID)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))
    End Sub

    '---- >>> Leave Credits By Employee ID <<< ----

    Sub SelTK_Employee_Leave_Credits_By_ID(dgv As DataGridView)
        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelTKMS_Leave_EmployeeLeaveCreditsByID]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            dgv.Rows.Add(
                            Convert.ToInt32(dr(0)),
                            dr(1).ToString(),
                            dr.GetDecimal(2).ToString(),
                            dr(3).ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dgv.ClearSelection()

    End Sub

    Sub ProcessDataGridView_Employee_Leave_Credits(dataGridView As DataGridView)
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spInsUpdTKMS_Leave_EmployeeLeaveCredits]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    For Each row As DataGridViewRow In dataGridView.Rows
                        cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
                        cmd.Parameters.AddWithValue("@LeaveType", If(IsDBNull(row.Cells(0).Value), "", row.Cells(0).Value.ToString()))
                        cmd.Parameters.AddWithValue("@LeaveCredit", If(IsDBNull(row.Cells(1).Value), 0, CInt(row.Cells(1).Value)))
                        cmd.Parameters.AddWithValue("@DateIssued", If(IsDBNull(row.Cells(2).Value), "", row.Cells(2).Value.ToString()))
                        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                    Next

                End Using
            End Using
            MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmTK_AddUpdLeaveCredits.Dispose()
            frmTimeKeeping_Transaction_EmployeeLeave.WhatToLoad()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub SelUpd_Employee_Leave_Credits_By_ID(dgv As DataGridView)
        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelUpdTKMS_Leave_EmployeeLeaveCreditsByID]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@PersonnelID", _strEmployeeID)
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            dgv.Rows.Add(
                                dr(0).ToString(),
                                Convert.ToDecimal(dr(1)),
                                dr(2).ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dgv.ClearSelection()

    End Sub






End Module
