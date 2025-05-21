Imports System.Data.SqlClient
Module Module_Accounting


    Public _strRevolvingFundID As Integer
    Public _strRFPVoucherID As Integer
    Public _strIsAdvances As Integer
    Public _strStatus As Integer

    Public _DepartmentChargingID1 As Integer
    Public _DepartmentChargingID2 As Integer
    Public _DepartmentChargingID3 As Integer = 0

    Public _ProjectChargingID1 As Integer
    Public _ProjectChargingID2 As Integer
    Public _ProjectChargingID3 As Integer

    Sub Insert_FMS_ReplenishmentAmount()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "spInsFMS_ReplenishmentAmount"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }
        cmd.Parameters.AddWithValue("@ReplenishAmount", frmAccounting_AddRF_ReplenishmentAmount.txtboxReplenishmentAmount.Text)
        cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

        If cmd.ExecuteNonQuery = -1 Then
            frmAccounting_AddRF_ReplenishmentAmount.txtboxReplenishmentAmount.Clear()
        Else
            MessageBox.Show("Invalid")
        End If
        Conn.Close()

    End Sub


    Sub Insert_FMS_Replenishment_details()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spInsFMS_RevolvingFund_Replenishment_Details]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }
        cmd.Parameters.AddWithValue("@ControlNo", frmAccounting_AddRF_Replenishment_details.txtboxControlNo.Text)
        cmd.Parameters.AddWithValue("@FullName", frmAccounting_AddRF_Replenishment_details.txtboxFundUser.Text)
        cmd.Parameters.AddWithValue("@Particulars", frmAccounting_AddRF_Replenishment_details.txtboxParticular.Text)
        cmd.Parameters.AddWithValue("@Credit", frmAccounting_AddRF_Replenishment_details.txtBoxCredit.Text)
        cmd.Parameters.AddWithValue("@isAdvances", _strIsAdvances)
        cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
        cmd.Parameters.AddWithValue("@ID", _strRevolvingFundID)
        If cmd.ExecuteNonQuery = -1 Then

            'Add refresh data list.

            frmAccounting_AddRF_Replenishment_details.txtboxControlNo.Clear()
            frmAccounting_AddRF_Replenishment_details.txtboxFundUser.Clear()
            frmAccounting_AddRF_Replenishment_details.txtBoxCredit.Clear()
            frmAccounting_AddRF_Replenishment_details.dgvEmployeeName.Rows.Clear()
            frmAccounting_AddRF_Replenishment_details.txtboxParticular.Clear()
            frmAccounting_AddRF_Replenishment_details.chkboxAdvances.CheckState = CheckState.Unchecked
            Select_FMS_Replenishment_Details(frmAccounting_RevolvingFund_Client.dgvCashFlow)
            Select_CashFlowID()
            frmAccounting_RevolvingFund_Client.dgvCashFlow.ClearSelection()

        Else

            MessageBox.Show("Invalid")

        End If
        Conn.Close()

    End Sub

    Sub Select_FMS_Replenishment_Details(_dgvRevolvingFund As DataGridView)

        _dgvRevolvingFund.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMS_RevolvingFund_Replenishment_Details]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        dr = cmd.ExecuteReader()

        While dr.Read()
            _dgvRevolvingFund.Rows.Add(dr("ID").ToString, dr("RFNo").ToString, dr("ControlNo").ToString, dr("EmployeeName").ToString, dr("Particulars").ToString, dr("Credit").ToString, dr("Status").ToString, dr("StatusID").ToString)
        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        _dgvRevolvingFund.ClearSelection()

    End Sub

    Sub Select_FMS_Replenishment_AdvancesDetails(_dgvAdvances As DataGridView)

        _dgvAdvances.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMS_RevolvingFund_AdvancesDetails]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        dr = cmd.ExecuteReader()

        While dr.Read()
            _dgvAdvances.Rows.Add(dr("ID").ToString, dr("RFNo").ToString, dr("ControlNo").ToString, dr("EmployeeName").ToString, dr("Particulars").ToString, dr("Credit").ToString, dr("Status").ToString, dr("StatusID").ToString)
        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        _dgvAdvances.ClearSelection()
    End Sub

    Sub Select_FMS_Replenishment_Details_Administrator(_dgvCashFlow As DataGridView)


        _dgvCashFlow.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMS_RevolvingFund_Replenishment_Details_ByIsApproved]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        dr = cmd.ExecuteReader()

        While dr.Read()
            _dgvCashFlow.Rows.Add(dr("ID").ToString, dr("RFNo").ToString, dr("ControlNo").ToString, dr("EmployeeName").ToString, dr("Particulars").ToString, dr("Debit").ToString, dr("Credit").ToString, dr("RFPVoucher").ToString, dr("JournalVoucher").ToString, dr("Status").ToString, dr("StatusID").ToString)
        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        _dgvCashFlow.ClearSelection()

    End Sub

    Sub Select_FMS_EmployeeList_Search(_txtFundUser As TextBox, _dgvEmployeeName As DataGridView)

        _dgvEmployeeName.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMS_EmployeeList_Search]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        cmd.Parameters.AddWithValue("@Search", _txtFundUser.Text)

        dr = cmd.ExecuteReader()

        While dr.Read()
            _dgvEmployeeName.Rows.Add(dr("ID").ToString, dr("FullName").ToString)
        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub Select_FMS_Replenishment_DetailsByID()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelUpFMS_RevolvingFund_Replenishment_ValidationByID]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        cmd.Parameters.AddWithValue("@ID", _strRevolvingFundID)

        dr = cmd.ExecuteReader()

        While dr.Read()
            frmAccounting_RevolvingFund_AcccountValidation.txtRFNo.Text = dr.GetString(1)
            frmAccounting_RevolvingFund_AcccountValidation.txtboxControlNo.Text = dr.GetString(2)
            frmAccounting_RevolvingFund_AcccountValidation.txtboxFundUser.Text = dr.GetString(3)
            frmAccounting_RevolvingFund_AcccountValidation.txtboxParticular.Text = dr.GetString(4)
            frmAccounting_RevolvingFund_AcccountValidation.txtBoxCredit.Text = dr.GetDecimal(6)
            frmAccounting_RevolvingFund_AcccountValidation.LabelCredit.Text = dr.GetString(7)
            frmAccounting_RevolvingFund_AcccountValidation.txtBoxRFPVoucher.Text = dr.GetString(8)
        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub


    Sub Select_CashFlowID()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMS_RevolvingFund_ID]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        dr = cmd.ExecuteReader()
        If dr.HasRows Then

            While dr.Read()
                '    frmAccounting_AddRF_Replenishment_details.Label2.Text = dr.GetInt32(0)
                _strRevolvingFundID = dr.GetInt32(0)
            End While

        End If
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub Select_ReplenishmentAmount_Individual(_lblOriginalAmount As Label, _dgvReplenishForeCast As DataGridView)

        _dgvReplenishForeCast.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMS_ReplenishmentAmount]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            While dr.Read()
                _dgvReplenishForeCast.Rows.Add(dr.GetInt32(0), dr.GetString(8), dr.GetString(6), dr.GetString(7))
                _lblOriginalAmount.Text = dr.GetString(4)
            End While
        End If

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        _dgvReplenishForeCast.ClearSelection()

    End Sub

    Sub Select_ReplenishmentAmount_Administrator(_strForPayment As Label, _dgvReplenishForeCast As DataGridView, _strOriginalAmount As Label)

        _dgvReplenishForeCast.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMS_ReplenishmentAmount]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            While dr.Read()

                _dgvReplenishForeCast.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(6))

                _strForPayment.Text = dr.GetString(5)

                _strOriginalAmount.Text = dr.GetString(4)

            End While
        End If

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        _dgvReplenishForeCast.ClearSelection()

    End Sub

    Sub Insert_FMS_Replenishment_FinalCredit_details()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spInsFMS_RevolvingFund_Replenishment_FinalCredit]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }

        cmd.Parameters.AddWithValue("@RFID", _strRevolvingFundID)
        cmd.Parameters.AddWithValue("@Credit", frmAccounting_RevolvingFund_AcccountValidation.txtBoxCredit.Text)
        cmd.Parameters.AddWithValue("@RFPVoucher", frmAccounting_RevolvingFund_AcccountValidation.txtBoxRFPVoucher.Text)
        cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

        If cmd.ExecuteNonQuery = -1 Then

            'Add refresh data list.

            frmAccounting_RevolvingFund_AcccountValidation.Dispose()

            Select_ReplenishmentAmount_Administrator(frmAccounting_RevolvingFund_Administrator.lblForPayment, frmAccounting_RevolvingFund_Administrator.dgvReplenishmentAmount, frmAccounting_RevolvingFund_Administrator.lblAmountOrig)
            Select_FMS_Replenishment_Details_Administrator(frmAccounting_RevolvingFund_Administrator.dgvCashFlow)

        Else

            MessageBox.Show("Invalid")

        End If
        Conn.Close()

    End Sub

    Sub SelUpd_FMS_Replenishment_Details()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelUpdFMS_RevolvingFund_Replenishment_Details]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        cmd.Parameters.AddWithValue("@ID", _strRevolvingFundID)
        dr = cmd.ExecuteReader()
        While dr.Read()

            frmAccounting_UpdateRF_Replenishment_details.txtboxControlNo.Text = dr.GetString(0)
            frmAccounting_UpdateRF_Replenishment_details.txtboxFundUser.Text = dr.GetString(1)
            frmAccounting_UpdateRF_Replenishment_details.txtboxParticular.Text = dr.GetString(2)
            frmAccounting_UpdateRF_Replenishment_details.LabelCredit.Text = dr.GetString(3)
            frmAccounting_UpdateRF_Replenishment_details.txtBoxCredit.Text = dr.GetDecimal(4)

        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    'Sub InsertUpdate_FMS_Replenishment_Details()

    '    Conn = New SqlConnection(StrConn)
    '    Conn.Open()
    '    cmd.Connection.CreateCommand()
    '    cmd.CommandText = "[spInsUpdFMS_RevolvingFund_Replenishment_Details]"
    '    cmd = New SqlCommand(cmd.CommandText, Conn) With {
    '                .CommandType = CommandType.StoredProcedure
    '                }

    '    cmd.Parameters.AddWithValue("@ID", _strRevolvingFundID)
    '    cmd.Parameters.AddWithValue("@ControlNo", frmAccounting_UpdateRF_Replenishment_details.txtboxControlNo.Text)
    '    cmd.Parameters.AddWithValue("@Particular", frmAccounting_UpdateRF_Replenishment_details.txtboxParticular.Text)
    '    cmd.Parameters.AddWithValue("@Credit", frmAccounting_UpdateRF_Replenishment_details.txtBoxCredit.Text)
    '    ' cmd.Parameters.AddWithValue("@StatusInWords", frmAccounting_RevolvingFund_Client.dgvCashFlow.Rows(rowIndex).Cells(columnIndex).Value.ToString())
    '    cmd.Parameters.AddWithValue("@StatusInWords", frmAccounting_RevolvingFund_Client.dgvCashFlow.Rows(0).Cells(7).Value.ToString())
    '    cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
    '    cmd.Parameters.AddWithValue("@FullName", frmAccounting_UpdateRF_Replenishment_details.txtboxFundUser.Text)
    '    If cmd.ExecuteNonQuery = -1 Then

    '        MessageBox.Show("Schedule Added Successfully!")

    '        Select_FMS_Replenishment_Details(frmAccounting_RevolvingFund_Client.dgvCashFlow)
    '        Select_ReplenishmentAmount_Individual(frmAccounting_RevolvingFund_Client.lblAmountOrig, frmAccounting_RevolvingFund_Client.dgvReplenishmentAmount)
    '        frmAccounting_UpdateRF_Replenishment_details.Dispose()

    '    Else

    '        MessageBox.Show("Cannot update, Something went wrong. ", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End If
    '    Conn.Close()
    '    cmd.Parameters.Clear()

    'End Sub

    Sub InsertUpdate_FMS_Replenishment_ByStatus(columnIndex As Integer)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd.Connection.CreateCommand()
        cmd.CommandText = "[spInsUpdFMS_RevolvingFund_Replenishment_ByStatus]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@ID", _strRevolvingFundID)
        cmd.Parameters.AddWithValue("@StatusInWords", frmAccounting_RevolvingFund_Client.dgvCashFlow.CurrentRow.Cells(6).Value.ToString())
        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
        If cmd.ExecuteNonQuery = -1 Then

            Select_FMS_Replenishment_Details(frmAccounting_RevolvingFund_Client.dgvCashFlow)
            Select_ReplenishmentAmount_Individual(frmAccounting_RevolvingFund_Client.lblAmountOrig, frmAccounting_RevolvingFund_Client.dgvReplenishmentAmount)
            ' frmAccounting_UpdateRF_Replenishment_details.Dispose()

        Else

            MessageBox.Show("Cannot update, Something went wrong. ", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub InsertUpdate_FMS_Advances_ByStatus(columnIndex As Integer)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd.Connection.CreateCommand()
        cmd.CommandText = "[spInsUpdFMS_RevolvingFund_AdvancesDetails]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@ID", _strRevolvingFundID)
        cmd.Parameters.AddWithValue("@StatusInWords", frmAccounting_RevolvingFund_Advances.dgvAdvances.CurrentRow.Cells(6).Value.ToString())
        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
        If cmd.ExecuteNonQuery = -1 Then

            Select_FMS_Replenishment_AdvancesDetails(frmAccounting_RevolvingFund_Advances.dgvAdvances)
            frmAccounting_RevolvingFund_Advances.dgvAdvances.ClearSelection()
        Else

            MessageBox.Show("Cannot update, Something went wrong. ", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub InsUpd_FMS_Replenishment_ByStatus_Administrator(columnIndex As Integer)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd.Connection.CreateCommand()
        cmd.CommandText = "[spInsUpdFMS_RevolvingFund_Replenishment_ByStatus]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@ID", _strRevolvingFundID)
        cmd.Parameters.AddWithValue("@StatusInWords", frmAccounting_RevolvingFund_Administrator.dgvCashFlow.CurrentRow.Cells(9).Value.ToString())
        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
        If cmd.ExecuteNonQuery = -1 Then

            Select_ReplenishmentAmount_Administrator(frmAccounting_RevolvingFund_Administrator.lblForPayment, frmAccounting_RevolvingFund_Administrator.dgvReplenishmentAmount, frmAccounting_RevolvingFund_Administrator.lblAmountOrig)
            Select_FMS_Replenishment_Details_Administrator(frmAccounting_RevolvingFund_Administrator.dgvCashFlow)

        Else

            MessageBox.Show("Cannot update, Something went wrong. ", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub Select_FMS_RFPVoucher_Search(_txtRFPVoucher As TextBox, _dgvRFPVoucher As DataGridView)

        _dgvRFPVoucher.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMS_RevolvingFund_SelectRFPVoucher]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        cmd.Parameters.AddWithValue("@Search", _txtRFPVoucher.Text)
        dr = cmd.ExecuteReader()

        While dr.Read()
            _dgvRFPVoucher.Rows.Add(dr.GetInt32(0), dr.GetString(1))
        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub rpt_trialBalance()

        frmAccounting_ReportTab.CrystalReportViewer1.ShowProgressAnimation(True)
        Dim report1 As New rpttrialbalancenew
        Dim user As String = "sa"
        Dim pwd As String = "3dcoP032022"
        report1.SetDatabaseLogon(user, pwd)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spRptTrialBalanceNew]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@RangeFrom", frmAccounting_DialogTrialBalance.DateTimePicker1.Text)
        cmd.Parameters.AddWithValue("@RangeTo", frmAccounting_DialogTrialBalance.DateTimePicker2.Text)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read)

                report1.SetParameterValue("@RangeFrom", frmAccounting_DialogTrialBalance.DateTimePicker1.Text)
                report1.SetParameterValue("@RangeTo", frmAccounting_DialogTrialBalance.DateTimePicker2.Text)

            End While
            frmAccounting_ReportTab.CrystalReportViewer1.ReportSource = report1
            frmAccounting_ReportTab.CrystalReportViewer1.Refresh()
            frmAccounting_DialogTrialBalance.Dispose()

        Else

            MessageBox.Show("No Activity found on this date.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        dr.Close()
        Conn.Close()

    End Sub

    Sub Select_SummaryOfRP(_dvgSummaryOfRFP As DataGridView)

        _dvgSummaryOfRFP.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMS_RevolvingFund_SummaryOfRFP]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        dr = cmd.ExecuteReader()
        If dr.HasRows Then

            While dr.Read()
                _dvgSummaryOfRFP.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2))
            End While

        End If
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        _dvgSummaryOfRFP.ClearSelection()
    End Sub

    Sub SelUpd_FMS_SummaryOfRP_ByID(_dvgSummaryOfRFP As DataGridView, _lblVoucherCode As Label, _lblVoucherDate As Label, _lbltoolstripTotalRFP As ToolStripLabel, _txtJournalVoucher As TextBox)

        _dvgSummaryOfRFP.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelUpdFMS_RevolvingFund_SummaryOfRFP_ByRFPVoucherID]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        cmd.Parameters.AddWithValue("@RFPVoucherID", _strRFPVoucherID)
        dr = cmd.ExecuteReader()
        While dr.Read()

            _dvgSummaryOfRFP.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4))

            _lblVoucherCode.Text = dr.GetString(5)

            _lblVoucherDate.Text = dr.GetDateTime(6)

            _lbltoolstripTotalRFP.Text = dr.GetString(7)

            _txtJournalVoucher.Text = dr.GetString(8)

            If frmAccounting_SummaryOfRP_Preview.txtboxJV.Text = Nothing Then

                frmAccounting_SummaryOfRP_Preview.lblStatus.Text = "UNSETTLED ACCOUNT"
                frmAccounting_SummaryOfRP_Preview.lblStatus.ForeColor = Color.Maroon
            Else
                frmAccounting_SummaryOfRP_Preview.lblStatus.Text = "SETTLED ACCOUNT"
                frmAccounting_SummaryOfRP_Preview.lblStatus.ForeColor = Color.Green
                frmAccounting_SummaryOfRP_Preview.btnSave.Enabled = False

            End If

        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    Sub InsertUpdate_FMS_SummaryOfRP_ByJV()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd.Connection.CreateCommand()
        cmd.CommandText = "[spInsUpdFMS_RevolvingFund_ValidationByJV]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@RFPVoucherID", _strRFPVoucherID)
        cmd.Parameters.AddWithValue("@JVCode", frmAccounting_SummaryOfRP_Preview.txtboxJV.Text)
        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
        If cmd.ExecuteNonQuery = -1 Then

            Select_SummaryOfRP(frmAccounting_SummaryOfRP_Main.dgvSummaryOfRFP)
            Select_SummaryOfRP_PaidAccounts(frmAccounting_SummaryOfRP_Main.dgvSummaryOfRFP_PaidAccounts)
            frmAccounting_SummaryOfRP_Preview.Dispose()

        Else

            MessageBox.Show("Cannot update, Something went wrong. ", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub Select_FMS_JournalVoucher_Search(_txtRFPVoucher As TextBox, _dgvRFPVoucher As DataGridView)

        _dgvRFPVoucher.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMS_RevolvingFund_SelectJournalVoucher]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        cmd.Parameters.AddWithValue("@Search", _txtRFPVoucher.Text)
        dr = cmd.ExecuteReader()

        While dr.Read()
            _dgvRFPVoucher.Rows.Add(dr.GetInt32(0), dr.GetString(1))
        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub


    Sub Select_AutoComplete_JournalVoucher(_txtJournalVoucher As TextBox)

        _txtJournalVoucher.AutoCompleteMode = AutoCompleteMode.Suggest
        _txtJournalVoucher.AutoCompleteSource = AutoCompleteSource.CustomSource

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd.CommandText = "[spSelFMS_RevolvingFund_SelectJournalVoucher]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        dr = cmd.ExecuteReader()
        While dr.Read()
            col.Add(dr("JVCode").ToString)
        End While

        _txtJournalVoucher.AutoCompleteCustomSource = col

        dr.Close()
        Conn.Close()

    End Sub

    Sub TestingLang()

        Conn = New SqlConnection(StrConn)
        Dim STR As String = "[spSelFMS_RevolvingFund_SelectJournalVoucher]"
        Dim cmd As New SqlCommand(STR, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "list")

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("JVCode").ToString())

        Next

        frmAccounting_SummaryOfRP_Preview.txtboxJV.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmAccounting_SummaryOfRP_Preview.txtboxJV.AutoCompleteCustomSource = col
        frmAccounting_SummaryOfRP_Preview.txtboxJV.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub

    Sub Select_SummaryOfRP_PaidAccounts(_dvgSummaryOfRFP As DataGridView)

        _dvgSummaryOfRFP.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMS_RevolvingFund_SummaryOfRFP_PaidAccounts]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        dr = cmd.ExecuteReader()
        If dr.HasRows Then

            While dr.Read()
                _dvgSummaryOfRFP.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3))
            End While

        End If
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        _dvgSummaryOfRFP.ClearSelection()
    End Sub

    Sub SelUpd_FMS_SummaryOfRP_ByPaidAccounts(_dvgSummaryOfRFP As DataGridView, _lblVoucherCode As Label, _lblVoucherDate As Label, _lbltoolstripTotalRFP As ToolStripLabel, _txtJournalVoucher As TextBox)

        _dvgSummaryOfRFP.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelUpdFMS_RevolvingFund_SummaryOfRFP_ByPaidAccounts]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        cmd.Parameters.AddWithValue("@RFPVoucherID", _strRFPVoucherID)
        dr = cmd.ExecuteReader()
        While dr.Read()

            _dvgSummaryOfRFP.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4))

            _lblVoucherCode.Text = dr.GetString(5)

            _lblVoucherDate.Text = dr.GetDateTime(6)

            _lbltoolstripTotalRFP.Text = dr.GetString(7)

            _txtJournalVoucher.Text = dr.GetString(8)

            If frmAccounting_SummaryOfRP_Preview.txtboxJV.Text = Nothing Then

                frmAccounting_SummaryOfRP_Preview.lblStatus.Text = "UNSETTLED ACCOUNT"
                frmAccounting_SummaryOfRP_Preview.lblStatus.ForeColor = Color.Maroon
            Else
                frmAccounting_SummaryOfRP_Preview.lblStatus.Text = "SETTLED ACCOUNT"
                frmAccounting_SummaryOfRP_Preview.lblStatus.ForeColor = Color.Green
                frmAccounting_SummaryOfRP_Preview.btnSave.Enabled = False

            End If

        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    Sub DepartmentChargingDropDownList(cBox As ComboBox)
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spSelFMS_Charging_Department]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cBox.Items.Clear()
                Dim deptDictionary As New Dictionary(Of Tuple(Of Integer, Integer), String)()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim id As Integer = reader.GetInt32(0)
                        Dim dept As String = reader.GetString(1)
                        Dim deptid As Integer = reader.GetInt32(2)
                        Dim key As New Tuple(Of Integer, Integer)(id, deptid)
                        If Not deptDictionary.ContainsKey(key) Then
                            deptDictionary.Add(key, dept)
                            cBox.Items.Add(dept)
                        End If
                    End While
                End Using
                cBox.Tag = deptDictionary
            End Using
        End Using
    End Sub

    Sub ProjectChargingDropDownList(cBox As ComboBox)
        If _DepartmentChargingID1 = 999 Then
            _DepartmentChargingID3 = _DepartmentChargingID1
        End If
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spSelFMS_Charging_Project]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@DeptID", _DepartmentChargingID1)
                cmd.Parameters.AddWithValue("@PType", _DepartmentChargingID3)
                cBox.Items.Clear()
                Dim costDictionary As New Dictionary(Of Tuple(Of Integer, Integer, Integer), String)()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim id As Integer = reader.GetInt32(0)
                        Dim cost As String = reader.GetString(1)
                        Dim deptid As Integer = reader.GetInt32(2)
                        Dim ptypeid As Integer = reader.GetInt32(3)
                        Dim key As New Tuple(Of Integer, Integer, Integer)(id, deptid, ptypeid)
                        If Not costDictionary.ContainsKey(key) Then
                            costDictionary.Add(key, cost)
                            cBox.Items.Add(cost)
                        End If
                    End While
                End Using
                cBox.Tag = costDictionary
                _DepartmentChargingID3 = 0
            End Using
        End Using
    End Sub

End Module
