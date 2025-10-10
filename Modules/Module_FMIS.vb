Imports System.Data.SqlClient
Module Module_FMIS

    Sub DepartmentChargingDropDownList(cBox As ComboBox)
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spSelFMIS_Charging_Department]", Conn)
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
            Using cmd As New SqlCommand("[spSelFMIS_Charging_Project]", Conn)
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

    '-------------->>>> FISCAL PERIOD <<<<-----------------

    Sub DropDownListTaxForms(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_TaxForm]"
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

    Sub InsUpd_FiscalPeriod()

        Try
            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Fiscal_Period]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _FiscalPeriodID)
                cmd.Parameters.AddWithValue("@FiscalStartDate", frmFMIS_Setup_AddUpdFiscalPeriod.dtpFiscalStartDate.Value)
                cmd.Parameters.AddWithValue("@FiscalEndDate", frmFMIS_Setup_AddUpdFiscalPeriod.dtpFiscalEndDate.Value)
                cmd.Parameters.AddWithValue("@TaxYearStartDate", frmFMIS_Setup_AddUpdFiscalPeriod.dtpTaxStartDate.Value)
                cmd.Parameters.AddWithValue("@TaxYearEndDate", frmFMIS_Setup_AddUpdFiscalPeriod.dtpTaxEndDate.Value)
                cmd.Parameters.AddWithValue("@TaxForm", frmFMIS_Setup_AddUpdFiscalPeriod.cbTaxForm.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_FiscalPeriod(frmFMIS_Setup_FiscalPeriod.dgvFiscalPeriod, frmFMIS_Setup_FiscalPeriod.toolstriplabelNoOfRecord)
                    Call frmFMIS_Setup_AddUpdFiscalPeriod.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub Sel_Setup_FiscalPeriod(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_FiscalPeriod]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_FiscalPeriod.txtboxSearch.Text)
                    Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
                    returnParam.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(returnParam)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lbl.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetString(3))
                        End While
                    End Using
                    lbl.Text = If(IsDBNull(returnParam.Value), "0", returnParam.Value.ToString())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dgv.ClearSelection()

    End Sub

    Sub SelUpd_FiscalPeriod_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_FiscalPeriod_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _FiscalPeriodID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdFiscalPeriod.dtpFiscalStartDate.Value = dr.GetDateTime(0)
                        frmFMIS_Setup_AddUpdFiscalPeriod.dtpFiscalEndDate.Value = dr.GetDateTime(1)
                        frmFMIS_Setup_AddUpdFiscalPeriod.dtpTaxStartDate.Value = dr.GetDateTime(2)
                        frmFMIS_Setup_AddUpdFiscalPeriod.dtpTaxEndDate.Value = dr.GetDateTime(3)
                        Dim TaxIndex As Integer = frmFMIS_Setup_AddUpdFiscalPeriod.cbTaxForm.FindStringExact(dr(4).ToString())
                        If TaxIndex <> -1 Then frmFMIS_Setup_AddUpdFiscalPeriod.cbTaxForm.SelectedIndex = TaxIndex
                    End If
                End Using
            End Using
        End Using
    End Sub

    Sub Del_FiscalPeriod_ByID(dgv As DataGridView)
        If _FiscalPeriodID = 0 Then Return
        If MessageBox.Show("Are you sure you want to delete this fiscal period?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelFMIS_FiscalPeriodByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _FiscalPeriodID)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Deleted.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))
    End Sub


    '-------------->>>> CASH FLOW CATEGORY <<<<-----------------

    Sub DropDownListCompany(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_Company]"
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

    Sub Sel_Setup_CashFlow_CategoryType(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_CashFlowCategory]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_CashFlowCategory.txtboxSearch.Text)
                    Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
                    returnParam.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(returnParam)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lbl.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1))
                        End While
                    End Using
                    lbl.Text = If(IsDBNull(returnParam.Value), "0", returnParam.Value.ToString())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dgv.ClearSelection()

    End Sub

    Sub InsUpd_CashFlow_CategoryType()

        Try
            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_CashFlow_CategoryType]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _CashFlowCategoryID)
                cmd.Parameters.AddWithValue("@CashFlowType", frmFMIS_Setup_AddUpdCashFlowCategoryType.txtType.Text)
                cmd.Parameters.AddWithValue("@CompanyName", frmFMIS_Setup_AddUpdCashFlowCategoryType.cbCompany.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_CashFlow_CategoryType(frmFMIS_Setup_CashFlowCategory.dgvCashFlowType, frmFMIS_Setup_CashFlowCategory.toolstriplabelNoOfRecord)
                    Call frmFMIS_Setup_AddUpdCashFlowCategoryType.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_CashFlow_CategoryType_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_CashFlow_CategoryType_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _CashFlowCategoryID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdCashFlowCategoryType.txtType.Text = dr.GetString(0)
                        Dim Index0 As Integer = frmFMIS_Setup_AddUpdCashFlowCategoryType.cbCompany.FindStringExact(dr(1).ToString())
                        If Index0 <> -1 Then frmFMIS_Setup_AddUpdCashFlowCategoryType.cbCompany.SelectedIndex = Index0
                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub Sel_Setup_CashFlow_CategoryDetail(dgv As DataGridView)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_CashFlowCategoryDetail]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@ID", _CashFlowCategoryID)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1))
                        End While
                    End Using

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dgv.ClearSelection()

    End Sub

    Sub SelUpd_Setup_CashFlow_CategoryDetail_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_CashFlow_CategoryDetail_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _CashFlowCategoryDetailID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdCashFlowCategoryDetail.txtTypeName.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdCashFlowCategoryDetail.txtDetailName.Text = dr.GetString(1)
                    End If
                End Using
            End Using
        End Using
    End Sub

    Sub InsUpd_CashFlow_CategoryDetail()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_CashFlow_CategoryDetail]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _CashFlowCategoryDetailID)
                cmd.Parameters.AddWithValue("@CashFlowType", frmFMIS_Setup_AddUpdCashFlowCategoryDetail.txtTypeName.Text)
                cmd.Parameters.AddWithValue("@DetailName", frmFMIS_Setup_AddUpdCashFlowCategoryDetail.txtDetailName.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_CashFlow_CategoryDetail(frmFMIS_Setup_CashFlowCategory.dgvCashFlowDetail)
                    Call frmFMIS_Setup_AddUpdCashFlowCategoryDetail.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub Sel_Setup_CashFlow_CategorySubdetail(dgv As DataGridView)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_CashFlowCategorySubdetail]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@ID", _CashFlowCategoryDetailID)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1))
                        End While
                    End Using

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dgv.ClearSelection()

    End Sub

    Sub InsUpd_CashFlow_CategorySubdetail()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_CashFlow_CategorySubdetail]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _CashFlowCategorySubDetailID)
                cmd.Parameters.AddWithValue("@CashFlowType", _strCashFlowCategory)
                cmd.Parameters.AddWithValue("@CashFlowDetail", frmFMIS_Setup_AddUpdCashFlowCategorySubdetail.txtDetailName.Text)
                cmd.Parameters.AddWithValue("@SubdetailName", frmFMIS_Setup_AddUpdCashFlowCategorySubdetail.txtSubdetailName.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_CashFlow_CategorySubdetail(frmFMIS_Setup_CashFlowCategory.dgvCashFlowSubdetail)
                    Call frmFMIS_Setup_AddUpdCashFlowCategorySubdetail.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_CashFlow_CategorySubdetail_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_CashFlow_CategorySubdetail_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _CashFlowCategorySubDetailID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdCashFlowCategorySubdetail.txtDetailName.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdCashFlowCategorySubdetail.txtSubdetailName.Text = dr.GetString(1)
                    End If
                End Using
            End Using
        End Using
    End Sub

    Sub Del_Setup_CashFlow_Category_ByID(dgv As DataGridView)
        If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelFMIS_CashFlow_CategoryByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _CashFlowCategoryID)
                cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Deleted.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))
    End Sub

    Sub Del_Setup_CashFlow_CategoryDetail_ByID(dgv As DataGridView)
        If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelFMIS_CashFlow_CategoryDetailByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _CashFlowCategoryDetailID)
                cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Deleted.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))
    End Sub

    Sub Del_Setup_CashFlow_CategorySubdetail_ByID(dgv As DataGridView)
        If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelFMIS_CashFlow_CategorySubdetailByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _CashFlowCategorySubDetailID)
                cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Deleted.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))
    End Sub

    '-------------->>>> COST CENTER <<<<-----------------

    Sub Sel_Setup_CostCenter(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_CostCenter]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_CostCenter.txtboxSearch.Text)
                    Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
                    returnParam.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(returnParam)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lbl.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetString(3),
                                dr.GetString(4))
                        End While
                    End Using
                    lbl.Text = If(IsDBNull(returnParam.Value), "0", returnParam.Value.ToString())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dgv.ClearSelection()

    End Sub

    Sub Sel_Setup_ProjectName_ByID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_ProjectNameByID]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@ID", _strDepartmentID)
        dr = cmd.ExecuteReader()
        While dr.Read()

            dgv.Rows.Add(
            dr.GetString(0),
            dr.GetString(1),
            dr.GetString(2),
            dr.GetString(3))

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    'Sub InsUpd_CostCenter()

    '    Try

    '        Using Conn As New SqlConnection(StrConn),
    '        cmd As New SqlCommand("[spInsUpdFMIS_CashFlow_CategoryType]", Conn)
    '            Conn.Open()
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Parameters.AddWithValue("@ID", _CashFlowCategoryID)
    '            cmd.Parameters.AddWithValue("@CashFlowType", frmFMIS_Setup_AddUpdCashFlowCategoryType.txtType.Text)
    '            cmd.Parameters.AddWithValue("@CompanyName", frmFMIS_Setup_AddUpdCashFlowCategoryType.cbCompany.Text)
    '            cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
    '            If cmd.ExecuteNonQuery = -1 Then
    '                '\\ This Code will Select the Data after Insert.
    '                MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Call Sel_Setup_CashFlow_CategoryType(frmFMIS_Setup_CashFlowCategory.dgvCashFlowType, frmFMIS_Setup_CashFlowCategory.toolstriplabelNoOfRecord)
    '                Call frmFMIS_Setup_AddUpdCashFlowCategoryType.Close()
    '            End If
    '        End Using

    '    Catch ex As Exception
    '        MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        Conn.Close()
    '        cmd.Parameters.Clear()
    '    End Try

    'End Sub


    '-------------->>>> ACCOUNT CATEGORY <<<<-----------------

    Sub Sel_Setup_AccountCategory(dgv As DataGridView)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_AccountCategory]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_AccountCategory.txtboxSearch.Text)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetString(3))
                        End While
                    End Using

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dgv.ClearSelection()

    End Sub

    Sub Sel_Setup_AccountCategory_ByTypeID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_AccountCategory_Detail]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@ID", _AccountCategoryID)
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

    Sub SelUpd_Setup_AccountCategory_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_AccountCategory_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _AccountCategoryID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdAccountCategory.txtCode.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdAccountCategory.txtType.Text = dr.GetString(1)
                        frmFMIS_Setup_AddUpdAccountCategory.chDebit.Checked = (dr.GetString(2) = "Debit")
                        frmFMIS_Setup_AddUpdAccountCategory.chCredit.Checked = (dr.GetString(2) = "Credit")
                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub InsUpd_Setup_AccountCategory()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_AccountCategory]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _AccountCategoryID)
                cmd.Parameters.AddWithValue("@Code", frmFMIS_Setup_AddUpdAccountCategory.txtCode.Text)
                cmd.Parameters.AddWithValue("@Type", frmFMIS_Setup_AddUpdAccountCategory.txtType.Text)
                cmd.Parameters.AddWithValue("@Debit", frmFMIS_Setup_AddUpdAccountCategory.chDebit.Checked)
                cmd.Parameters.AddWithValue("@Credit", frmFMIS_Setup_AddUpdAccountCategory.chCredit.Checked)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_AccountCategory(frmFMIS_Setup_AccountCategory.dgvAccountCategoryMain)
                    Call frmFMIS_Setup_AddUpdAccountCategory.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub Del_Setup_AccountCategory_ByID(dgv As DataGridView, dgv1 As DataGridView)
        If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelFMIS_AccountCategory_ByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _AccountCategoryID)
                cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Deleted.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))
        dgv1.Rows.Clear()
    End Sub

    Sub InsUpd_Setup_AccountCategory_Detail()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_AccountCategory_Detail]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _AccountCategoryDetailID)
                cmd.Parameters.AddWithValue("@CatID", _AccountCategoryID)
                cmd.Parameters.AddWithValue("@Code", frmFMIS_Setup_AddUpdAccountCategoryDetail.txtCode.Text)
                cmd.Parameters.AddWithValue("@Type", frmFMIS_Setup_AddUpdAccountCategoryDetail.txtType.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_AccountCategory_ByTypeID(frmFMIS_Setup_AccountCategory.dgvAccountCategoryDetail)
                    Call frmFMIS_Setup_AddUpdAccountCategoryDetail.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_AccountCategoryDetail_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_AccountCategoryDetail_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _AccountCategoryDetailID)
                cmd.Parameters.AddWithValue("@CatID", _AccountCategoryID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdAccountCategoryDetail.txtCode.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdAccountCategoryDetail.txtType.Text = dr.GetString(1)
                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub Del_Setup_AccountCategoryDetail_ByID(dgv As DataGridView)
        If MessageBox.Show("Are you sure you want to delete this from the list?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()

            Using cmd As New SqlCommand("[spDelFMIS_AccountCategoryDetail_ByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _AccountCategoryDetailID)
                cmd.Parameters.AddWithValue("@CatID", _AccountCategoryID)
                cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Deleted.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))
    End Sub

    Sub Sel_Setup_AccountCategory_Main_Code(txt As TextBox)

        Using Conn As New SqlConnection(StrConn)
            cmd.CommandText = "[spSelFMIS_AccountCategory_Main_Code]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
            Conn.Open()
            'cmd.Parameters.AddWithValue("@AcctTypeID", _AccountCategoryID)
            dr = cmd.ExecuteReader()

            While dr.Read()
                txt.Text = dr.GetString(0)
            End While

            dr.Close()
        End Using

    End Sub

    Sub Sel_Setup_AccountCategory_Detail_Code(txt As TextBox)

        Using Conn As New SqlConnection(StrConn)
            cmd.CommandText = "[spSelFMIS_AccountCategory_Detail_Code]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
            Conn.Open()
            cmd.Parameters.AddWithValue("@ParentID", _AccountCategoryID)
            dr = cmd.ExecuteReader()

            While dr.Read()
                txt.Text = dr.GetString(0)
            End While

            dr.Close()
        End Using

    End Sub

    '-------------->>>> CHART OF ACCOUNTS - EXTERNAL <<<<-----------------

    Sub Sel_Setup_ChartOfAccounts_External_AccountCategory(dgv As DataGridView)

        Try
            dgv.Rows.Clear()
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_ChartOfAccounts_External_AccountCategory]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_ChartOfAccounts.txtboxSearch.Text)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()

                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2))

                        End While
                    End Using

                End Using
            End Using
            dgv.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub Sel_Setup_ChartOfAccounts_Level1(dgv As DataGridView)

        Try
            dgv.Rows.Clear()
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_ChartOfAccounts_Level1]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ID", _AccountCategoryID)
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()

                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetString(3),
                                dr.GetDecimal(4),
                                dr.GetDecimal(5),
                                dr.GetString(6),
                                dr.GetString(7))

                        End While
                    End Using
                End Using
            End Using
            dgv.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub DropDownListCashFlow(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_CashFlow]"
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

    Sub SelUpd_Setup_ChartOfAccounts_Level1_ByID()

        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_ChartOfAccounts_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _ChartLevel1ID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then

                        frmFMIS_Setup_AddUpdChartOfAccounts.txtCode.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdChartOfAccounts.txtTitle.Text = dr.GetString(1)
                        Dim Index As Integer = frmFMIS_Setup_AddUpdChartOfAccounts.cbCashFlow.FindStringExact(dr(2).ToString())
                        If Index <> -1 Then frmFMIS_Setup_AddUpdChartOfAccounts.cbCashFlow.SelectedIndex = Index
                        frmFMIS_Setup_AddUpdChartOfAccounts.txtBalance.Text = dr.GetDecimal(3).ToString("N2")
                        frmFMIS_Setup_AddUpdChartOfAccounts.txtRemarks.Text = dr.GetString(4)
                        frmFMIS_Setup_AddUpdChartOfAccounts.chActive.Checked = (dr.GetInt32(5) = 1)
                        frmFMIS_Setup_AddUpdChartOfAccounts.chContra.Checked = (dr.GetInt32(6) = 1)

                    End If
                End Using

            End Using
        End Using

    End Sub

    Sub Sel_Setup_ChartOfAccounts_Level1_Code(txt As TextBox)

        Using Conn As New SqlConnection(StrConn)
            cmd.CommandText = "[spSelFMIS_ChartOfAccounts_Level1_Code]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
            Conn.Open()
            cmd.Parameters.AddWithValue("@AcctTypeID", _AccountCategoryID)
            dr = cmd.ExecuteReader()

            While dr.Read()
                txt.Text = dr.GetString(0)
            End While

            dr.Close()
        End Using

    End Sub

    Sub InsUpd_Setup_ChartOfAccounts_Level1()

        Try

            Dim StatusID As Integer = 397
            Dim Contra As Integer = 0

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_ChartOfAccounts_Level1]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _ChartLevel1ID)
                cmd.Parameters.AddWithValue("@TypeID", _AccountCategoryID)
                cmd.Parameters.AddWithValue("@Code", frmFMIS_Setup_AddUpdChartOfAccounts.txtCode.Text)
                cmd.Parameters.AddWithValue("@Title", frmFMIS_Setup_AddUpdChartOfAccounts.txtTitle.Text)
                cmd.Parameters.AddWithValue("@CashFlow", frmFMIS_Setup_AddUpdChartOfAccounts.cbCashFlow.Text)
                cmd.Parameters.AddWithValue("@Balance", Decimal.Parse(frmFMIS_Setup_AddUpdChartOfAccounts.txtBalance.Text.Replace(",", "")))
                cmd.Parameters.AddWithValue("@Remarks", frmFMIS_Setup_AddUpdChartOfAccounts.txtRemarks.Text)

                If frmFMIS_Setup_AddUpdChartOfAccounts.chActive.Checked Then
                    StatusID = 396
                End If
                cmd.Parameters.AddWithValue("@StatusID", StatusID)

                If frmFMIS_Setup_AddUpdChartOfAccounts.chContra.Checked Then
                    Contra = 1
                End If
                cmd.Parameters.AddWithValue("@Contra", Contra)

                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_ChartOfAccounts_Level1(frmFMIS_Setup_ChartOfAccounts.dgvLevel1)
                    frmFMIS_Setup_AddUpdChartOfAccounts.Close()
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub Sel_Setup_ChartOfAccounts_Level2_Code(txt As TextBox)

        Using Conn As New SqlConnection(StrConn)
            cmd.CommandText = "[spSelFMIS_ChartOfAccounts_Level2_Code]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
            Conn.Open()
            cmd.Parameters.AddWithValue("@ID", _ChartLevel1ID)
            dr = cmd.ExecuteReader()

            While dr.Read()
                txt.Text = dr.GetString(0)
            End While

            dr.Close()
        End Using

    End Sub

    Sub Sel_Setup_ChartOfAccounts_Level2(dgv As DataGridView)

        Try
            dgv.Rows.Clear()
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_ChartOfAccounts_Level2]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ID", _ChartLevel1ID)
                    cmd.Parameters.AddWithValue("@TypeID", _AccountCategoryID)
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()

                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetString(3),
                                dr.GetDecimal(4),
                                dr.GetDecimal(5),
                                dr.GetString(6),
                                dr.GetString(7))

                        End While
                    End Using
                End Using
            End Using
            dgv.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub InsUpd_Setup_ChartOfAccounts_Level2()

        Try

            Dim StatusID As Integer = 397
            Dim Contra As Integer = 0

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_ChartOfAccounts_Level2]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _ChartLevel2ID)
                cmd.Parameters.AddWithValue("@ParentID", _ChartLevel1ID)
                cmd.Parameters.AddWithValue("@TypeID", _AccountCategoryID)
                cmd.Parameters.AddWithValue("@Code", frmFMIS_Setup_AddUpdChartOfAccounts.txtCode.Text)
                cmd.Parameters.AddWithValue("@Title", frmFMIS_Setup_AddUpdChartOfAccounts.txtTitle.Text)
                cmd.Parameters.AddWithValue("@CashFlow", frmFMIS_Setup_AddUpdChartOfAccounts.cbCashFlow.Text)
                cmd.Parameters.AddWithValue("@Balance", Decimal.Parse(frmFMIS_Setup_AddUpdChartOfAccounts.txtBalance.Text.Replace(",", "")))
                cmd.Parameters.AddWithValue("@Remarks", frmFMIS_Setup_AddUpdChartOfAccounts.txtRemarks.Text)

                If frmFMIS_Setup_AddUpdChartOfAccounts.chActive.Checked Then
                    StatusID = 396
                End If
                cmd.Parameters.AddWithValue("@StatusID", StatusID)

                If frmFMIS_Setup_AddUpdChartOfAccounts.chContra.Checked Then
                    Contra = 1
                End If
                cmd.Parameters.AddWithValue("@Contra", Contra)

                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_ChartOfAccounts_Level2(frmFMIS_Setup_ChartOfAccounts.dgvLevel2)
                    frmFMIS_Setup_AddUpdChartOfAccounts.Close()
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub Sel_Setup_ChartOfAccounts_Level3(dgv As DataGridView)

        Try
            dgv.Rows.Clear()
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_ChartOfAccounts_Level3]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ID", _ChartLevel2ID)
                    cmd.Parameters.AddWithValue("@TypeID", _AccountCategoryID)
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()

                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetString(3),
                                dr.GetDecimal(4),
                                dr.GetDecimal(5),
                                dr.GetString(6),
                                dr.GetString(7))

                        End While
                    End Using
                End Using
            End Using
            dgv.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub SelUpd_Setup_ChartOfAccounts_Level2_ByID()

        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_ChartOfAccounts_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _ChartLevel2ID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then

                        frmFMIS_Setup_AddUpdChartOfAccounts.txtCode.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdChartOfAccounts.txtTitle.Text = dr.GetString(1)
                        Dim Index As Integer = frmFMIS_Setup_AddUpdChartOfAccounts.cbCashFlow.FindStringExact(dr(2).ToString())
                        If Index <> -1 Then frmFMIS_Setup_AddUpdChartOfAccounts.cbCashFlow.SelectedIndex = Index
                        frmFMIS_Setup_AddUpdChartOfAccounts.txtBalance.Text = dr.GetDecimal(3).ToString("N2")
                        frmFMIS_Setup_AddUpdChartOfAccounts.txtRemarks.Text = dr.GetString(4)
                        frmFMIS_Setup_AddUpdChartOfAccounts.chActive.Checked = (dr.GetInt32(5) = 1)
                        frmFMIS_Setup_AddUpdChartOfAccounts.chContra.Checked = (dr.GetInt32(6) = 1)

                    End If
                End Using

            End Using
        End Using

    End Sub

    Sub SelUpd_Setup_ChartOfAccounts_Level3_ByID()

        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_ChartOfAccounts_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _ChartLevel3ID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then

                        frmFMIS_Setup_AddUpdChartOfAccounts.txtCode.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdChartOfAccounts.txtTitle.Text = dr.GetString(1)
                        Dim Index As Integer = frmFMIS_Setup_AddUpdChartOfAccounts.cbCashFlow.FindStringExact(dr(2).ToString())
                        If Index <> -1 Then frmFMIS_Setup_AddUpdChartOfAccounts.cbCashFlow.SelectedIndex = Index
                        frmFMIS_Setup_AddUpdChartOfAccounts.txtBalance.Text = dr.GetDecimal(3).ToString("N2")
                        frmFMIS_Setup_AddUpdChartOfAccounts.txtRemarks.Text = dr.GetString(4)
                        frmFMIS_Setup_AddUpdChartOfAccounts.chActive.Checked = (dr.GetInt32(5) = 1)
                        frmFMIS_Setup_AddUpdChartOfAccounts.chContra.Checked = (dr.GetInt32(6) = 1)

                    End If
                End Using

            End Using
        End Using

    End Sub

    Sub Sel_Setup_ChartOfAccounts_Level3_Code(txt As TextBox)

        Using Conn As New SqlConnection(StrConn)
            cmd.CommandText = "[spSelFMIS_ChartOfAccounts_Level3_Code]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
            Conn.Open()
            cmd.Parameters.AddWithValue("@ID", _ChartLevel2ID)
            dr = cmd.ExecuteReader()

            While dr.Read()
                txt.Text = dr.GetString(0)
            End While

            dr.Close()
        End Using

    End Sub

    Sub InsUpd_Setup_ChartOfAccounts_Level3()

        Try

            Dim StatusID As Integer = 397
            Dim Contra As Integer = 0

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_ChartOfAccounts_Level3]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _ChartLevel3ID)
                cmd.Parameters.AddWithValue("@ParentID", _ChartLevel2ID)
                cmd.Parameters.AddWithValue("@TypeID", _AccountCategoryID)
                cmd.Parameters.AddWithValue("@Code", frmFMIS_Setup_AddUpdChartOfAccounts.txtCode.Text)
                cmd.Parameters.AddWithValue("@Title", frmFMIS_Setup_AddUpdChartOfAccounts.txtTitle.Text)
                cmd.Parameters.AddWithValue("@CashFlow", frmFMIS_Setup_AddUpdChartOfAccounts.cbCashFlow.Text)
                cmd.Parameters.AddWithValue("@Balance", Decimal.Parse(frmFMIS_Setup_AddUpdChartOfAccounts.txtBalance.Text.Replace(",", "")))
                cmd.Parameters.AddWithValue("@Remarks", frmFMIS_Setup_AddUpdChartOfAccounts.txtRemarks.Text)

                If frmFMIS_Setup_AddUpdChartOfAccounts.chActive.Checked Then
                    StatusID = 396
                End If
                cmd.Parameters.AddWithValue("@StatusID", StatusID)

                If frmFMIS_Setup_AddUpdChartOfAccounts.chContra.Checked Then
                    Contra = 1
                End If
                cmd.Parameters.AddWithValue("@Contra", Contra)

                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)

                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_ChartOfAccounts_Level3(frmFMIS_Setup_ChartOfAccounts.dgvLevel3)
                    frmFMIS_Setup_AddUpdChartOfAccounts.Close()
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub Del_Setup_ChartOfAccounts_Level1_ByID(dgv As DataGridView)

        If _ChartLevel1ID = 0 Then Return
        If MessageBox.Show("Are you sure you want to delete this account?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelFMIS_ChartOfAccounts_Level1_ByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _ChartLevel1ID)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Deleted.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))

    End Sub

    Sub Del_Setup_ChartOfAccounts_Level2_ByID(dgv As DataGridView)

        If _ChartLevel2ID = 0 Then Return
        If MessageBox.Show("Are you sure you want to delete this account?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelFMIS_ChartOfAccounts_Level2_ByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _ChartLevel2ID)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Deleted.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))

    End Sub

    Sub Del_Setup_ChartOfAccounts_Level3_ByID(dgv As DataGridView)

        If _ChartLevel3ID = 0 Then Return
        If MessageBox.Show("Are you sure you want to delete this account?", "Warning Message", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spDelFMIS_ChartOfAccounts_Level2_ByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _ChartLevel3ID)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Deleted.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using
        dgv.Rows.Remove(dgv.SelectedRows(0))

    End Sub

    '-------------->>>> BANK ACCOUNTS <<<<-----------------

    Sub Sel_Setup_BankAccounts(dgv As DataGridView)

        Try
            dgv.Rows.Clear()
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_BankAccounts]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_BankAccount.txtboxSearch.Text)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()

                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1))

                        End While
                    End Using

                End Using
            End Using
            dgv.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub Sel_Setup_BankAccounts_ByID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_BankAccounts_Detail]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@ID", BankID)
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




End Module
