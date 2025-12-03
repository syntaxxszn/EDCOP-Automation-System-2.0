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

        If String.IsNullOrWhiteSpace(frmFMIS_Setup_AccountCategory.txtboxSearch.Text) Then
            cmd.Parameters.AddWithValue("@txt", "")
        Else
            cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_AccountCategory.txtboxSearch.Text)
        End If

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
                Using cmd As New SqlCommand("[spSelFMIS_All_BankAccounts]", Conn)
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
        cmd.CommandText = "[spSelFMIS_All_BankAccounts_Detail]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@ID", BankID)
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

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    Sub InsUpd_Setup_BankName()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_BankName]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", BankID)
                cmd.Parameters.AddWithValue("@BankName", frmFMIS_Setup_AddUpdBankName.txtName.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_BankAccounts(frmFMIS_Setup_BankAccount.dgvBankName)
                    Call frmFMIS_Setup_AddUpdBankName.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_BankName_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_BankName_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", BankID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdBankName.txtName.Text = dr.GetString(0)
                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub DropDownListCurrency(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_Currency]"
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

    Sub DropDownListBankCategoryAccount(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_BankCategoryAccount]"
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

    Sub SelUpd_Setup_BankAccount_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_BankAccount_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", BankDetailID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then

                        frmFMIS_Setup_AddUpdBankAccount.txtName.Text = dr.GetString(0)

                        Dim Index1 As Integer = frmFMIS_Setup_AddUpdBankAccount.cbAccountTitle.FindStringExact(dr(1).ToString())
                        If Index1 <> -1 Then frmFMIS_Setup_AddUpdBankAccount.cbAccountTitle.SelectedIndex = Index1

                        frmFMIS_Setup_AddUpdBankAccount.txtBranchName.Text = dr.GetString(2)
                        frmFMIS_Setup_AddUpdBankAccount.txtAccountNo.Text = dr.GetString(3)

                        Dim Index2 As Integer = frmFMIS_Setup_AddUpdBankAccount.cbCurrency.FindStringExact(dr(4).ToString())
                        If Index2 <> -1 Then frmFMIS_Setup_AddUpdBankAccount.cbCurrency.SelectedIndex = Index2

                        frmFMIS_Setup_AddUpdBankAccount.chForeign.Checked = dr.GetBoolean(5)
                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub InsUpd_Setup_BankAccount()

        Try

            Using Conn As New SqlConnection(StrConn),
                cmd As New SqlCommand("[spInsUpdFMIS_Setup_BankAccount]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", BankDetailID)
                cmd.Parameters.AddWithValue("@BankName", frmFMIS_Setup_AddUpdBankAccount.txtName.Text)
                cmd.Parameters.AddWithValue("@AccountName", frmFMIS_Setup_AddUpdBankAccount.cbAccountTitle.Text)
                cmd.Parameters.AddWithValue("@BranchName", frmFMIS_Setup_AddUpdBankAccount.txtBranchName.Text)
                cmd.Parameters.AddWithValue("@AccountNo", frmFMIS_Setup_AddUpdBankAccount.txtAccountNo.Text)
                cmd.Parameters.AddWithValue("@Currency", frmFMIS_Setup_AddUpdBankAccount.cbCurrency.Text)
                cmd.Parameters.AddWithValue("@ForeignAcc", frmFMIS_Setup_AddUpdBankAccount.chForeign.Checked)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_BankAccounts_ByID(frmFMIS_Setup_BankAccount.dgvBankAccount)
                    Call frmFMIS_Setup_AddUpdBankAccount.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    '-------------->>>> SUBSIDIARY <<<<-----------------

    Sub Sel_Setup_Subsidiary(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_Subsidiary]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_Subsidiary.txtboxSearch.Text)
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

    Sub Sel_Setup_SubsidiaryAccount_ByID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_Subsidiary_Detail]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@ID", SubsidiaryTypeID)
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

    Sub SelUpd_Setup_SubsidiaryType_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_Subsidiary_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", SubsidiaryTypeID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdSubsidiaryType.txtType.Text = dr.GetString(0)
                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub InsUpd_Setup_SubsidiaryType()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_Subsidiary]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", SubsidiaryTypeID)
                cmd.Parameters.AddWithValue("@SubsidiaryType", frmFMIS_Setup_AddUpdSubsidiaryType.txtType.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_Subsidiary(frmFMIS_Setup_Subsidiary.dgvType, frmFMIS_Setup_Subsidiary.toolstriplabelNoOfRecord)
                    Call frmFMIS_Setup_AddUpdSubsidiaryType.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_SubsidiaryAccount_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_Subsidiary_Account_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", SubsidiaryAccountID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.txtCode.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.txtTitle.Text = dr.GetString(1)
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.txtAddress.Text = dr.GetString(2)
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.txtBalance.Text = dr.GetDecimal(3).ToString()
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.txtContactPerson.Text = dr.GetString(4)
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.txtContactNumber.Text = dr.GetString(5)
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.txtTIN.Text = dr.GetString(6)
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.chActive.Checked = (dr.GetInt32(7) = 396)
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.chDocumented.Checked = Convert.ToBoolean(dr(8))
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.chAccredited.Checked = Convert.ToBoolean(dr(9))
                        Dim regValue As Integer = dr.GetInt32(10)
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.rbNonVat.Checked = (regValue = 0)
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.rbVat.Checked = (regValue = 1)
                        frmFMIS_Setup_AddUpdSubsidiaryAccount.rbZero.Checked = (regValue = 2)
                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub InsUpd_Setup_SubsidiaryAccount()

        Try

            Dim StatusID As Integer = 397
            Dim Documented As Boolean = False
            Dim Accredited As Boolean = False

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_SubsidiaryAccount]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", SubsidiaryAccountID)
                cmd.Parameters.AddWithValue("@supTypeID", 0)
                cmd.Parameters.AddWithValue("@Code", frmFMIS_Setup_AddUpdSubsidiaryAccount.txtCode.Text)
                cmd.Parameters.AddWithValue("@Name", frmFMIS_Setup_AddUpdSubsidiaryAccount.txtTitle.Text)
                cmd.Parameters.AddWithValue("@Address", frmFMIS_Setup_AddUpdSubsidiaryAccount.txtAddress.Text)
                cmd.Parameters.AddWithValue("@Balance", frmFMIS_Setup_AddUpdSubsidiaryAccount.txtBalance.Text)
                cmd.Parameters.AddWithValue("@ContactPerson", frmFMIS_Setup_AddUpdSubsidiaryAccount.txtContactPerson.Text)
                cmd.Parameters.AddWithValue("@ContactNumber", frmFMIS_Setup_AddUpdSubsidiaryAccount.txtContactNumber.Text)
                cmd.Parameters.AddWithValue("@TIN", frmFMIS_Setup_AddUpdSubsidiaryAccount.txtTIN.Text)
                If frmFMIS_Setup_AddUpdSubsidiaryAccount.chActive.Checked Then
                    StatusID = 396
                End If
                cmd.Parameters.AddWithValue("@StatusID", StatusID)
                If frmFMIS_Setup_AddUpdSubsidiaryAccount.chDocumented.Checked Then
                    Documented = True
                End If
                cmd.Parameters.AddWithValue("@isDocumented", Documented)
                If frmFMIS_Setup_AddUpdSubsidiaryAccount.chAccredited.Checked Then
                    Accredited = True
                End If
                cmd.Parameters.AddWithValue("@isAccredited", Accredited)
                Dim selectedReg As Integer = If(frmFMIS_Setup_AddUpdSubsidiaryAccount.rbNonVat.Checked, 0,
                                If(frmFMIS_Setup_AddUpdSubsidiaryAccount.rbVat.Checked, 1, 2))
                cmd.Parameters.AddWithValue("@reg", selectedReg)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_SubsidiaryAccount_ByID(frmFMIS_Setup_Subsidiary.dgvSubsidiaryAccount)
                    Call frmFMIS_Setup_AddUpdSubsidiaryAccount.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    '-------------->>>> SUPPLIER <<<<-----------------

    Sub Sel_Setup_SupplierType(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_SupplierType]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_Supplier.txtboxSearch.Text)
                    Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
                    returnParam.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(returnParam)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lbl.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2))
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

    Sub Sel_Setup_SupplierAccount_ByID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_Supplier_Detail]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@ID", SupplierTypeID)
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
            dr.GetString(7))

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    Sub SelUpd_Setup_SupplierType_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_Supplier_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", SupplierTypeID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdSupplierType.txtType.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdSupplierType.txtDesc.Text = dr.GetString(1)
                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub InsUpd_Setup_SupplierType()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_Supplier]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", SupplierTypeID)
                cmd.Parameters.AddWithValue("@SupplierType", frmFMIS_Setup_AddUpdSupplierType.txtType.Text)
                cmd.Parameters.AddWithValue("@SupplierDesc", frmFMIS_Setup_AddUpdSupplierType.txtDesc.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_SupplierType(frmFMIS_Setup_Supplier.dgvType, frmFMIS_Setup_Supplier.toolstriplabelNoOfRecord)
                    Call frmFMIS_Setup_AddUpdSupplierType.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub InsUpd_Setup_SupplierAccount()

        Try

            Dim StatusID As Integer = 397
            Dim Documented As Boolean = False
            Dim Accredited As Boolean = False

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_SubsidiaryAccount]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", SupplierAccountID)
                cmd.Parameters.AddWithValue("@supTypeID", SupplierTypeID)
                cmd.Parameters.AddWithValue("@Code", frmFMIS_Setup_AddUpdSupplierAccount.txtCode.Text)
                cmd.Parameters.AddWithValue("@Name", frmFMIS_Setup_AddUpdSupplierAccount.txtTitle.Text)
                cmd.Parameters.AddWithValue("@Address", frmFMIS_Setup_AddUpdSupplierAccount.txtAddress.Text)
                cmd.Parameters.AddWithValue("@Balance", frmFMIS_Setup_AddUpdSupplierAccount.txtBalance.Text)
                cmd.Parameters.AddWithValue("@ContactPerson", frmFMIS_Setup_AddUpdSupplierAccount.txtContactPerson.Text)
                cmd.Parameters.AddWithValue("@ContactNumber", frmFMIS_Setup_AddUpdSupplierAccount.txtContactNumber.Text)
                cmd.Parameters.AddWithValue("@TIN", frmFMIS_Setup_AddUpdSupplierAccount.txtTIN.Text)
                If frmFMIS_Setup_AddUpdSupplierAccount.chActive.Checked Then
                    StatusID = 396
                End If
                cmd.Parameters.AddWithValue("@StatusID", StatusID)
                If frmFMIS_Setup_AddUpdSupplierAccount.chDocumented.Checked Then
                    Documented = True
                End If
                cmd.Parameters.AddWithValue("@isDocumented", Documented)
                If frmFMIS_Setup_AddUpdSupplierAccount.chAccredited.Checked Then
                    Accredited = True
                End If
                cmd.Parameters.AddWithValue("@isAccredited", Accredited)
                Dim selectedReg As Integer = If(frmFMIS_Setup_AddUpdSupplierAccount.rbNonVat.Checked, 0,
                                If(frmFMIS_Setup_AddUpdSupplierAccount.rbVat.Checked, 1, 2))
                cmd.Parameters.AddWithValue("@reg", selectedReg)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_SupplierAccount_ByID(frmFMIS_Setup_Supplier.dgvSupplierAccount)
                    Call frmFMIS_Setup_AddUpdSupplierAccount.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_SupplierAccount_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_Subsidiary_Account_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", SupplierAccountID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdSupplierAccount.txtCode.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdSupplierAccount.txtTitle.Text = dr.GetString(1)
                        frmFMIS_Setup_AddUpdSupplierAccount.txtAddress.Text = dr.GetString(2)
                        frmFMIS_Setup_AddUpdSupplierAccount.txtBalance.Text = dr.GetDecimal(3).ToString()
                        frmFMIS_Setup_AddUpdSupplierAccount.txtContactPerson.Text = dr.GetString(4)
                        frmFMIS_Setup_AddUpdSupplierAccount.txtContactNumber.Text = dr.GetString(5)
                        frmFMIS_Setup_AddUpdSupplierAccount.txtTIN.Text = dr.GetString(6)
                        frmFMIS_Setup_AddUpdSupplierAccount.chActive.Checked = (dr.GetInt32(7) = 396)
                        frmFMIS_Setup_AddUpdSupplierAccount.chDocumented.Checked = Convert.ToBoolean(dr(8))
                        frmFMIS_Setup_AddUpdSupplierAccount.chAccredited.Checked = Convert.ToBoolean(dr(9))
                        Dim regValue As Integer = dr.GetInt32(10)
                        frmFMIS_Setup_AddUpdSupplierAccount.rbNonVat.Checked = (regValue = 0)
                        frmFMIS_Setup_AddUpdSupplierAccount.rbVat.Checked = (regValue = 1)
                        frmFMIS_Setup_AddUpdSupplierAccount.rbZero.Checked = (regValue = 2)
                    End If
                End Using

            End Using
        End Using
    End Sub

    '-------------->>>> TAX RATES <<<<-----------------

    Sub Sel_Setup_TaxRates(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_TaxRates]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_TaxRates.txtboxSearch.Text)
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
                            dr.GetDecimal(3))
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

    Sub DropDownListChartOfAccounts(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_ChartofAccounts]"
        cmd = New SqlCommand(cmd.CommandText, Conn)
        Conn.Open()
        dr = cmd.ExecuteReader()
        While dr.Read()

            Dim a = dr.GetString(1)
            col.Add(a)
            cBox.Items.Add(a)

        End While
        cBox.AutoCompleteCustomSource = col
        dr.Close()
        Conn.Close()

    End Sub

    Sub DropDownListChartOfAccounts_External(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_ChartofAccounts_External]"
        cmd = New SqlCommand(cmd.CommandText, Conn)
        Conn.Open()
        dr = cmd.ExecuteReader()
        While dr.Read()

            Dim a = dr.GetString(1)
            col.Add(a)
            cBox.Items.Add(a)

        End While
        cBox.AutoCompleteCustomSource = col
        dr.Close()
        Conn.Close()

    End Sub

    Sub DropDownListSupplier(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_Supplier]"
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

    Sub DropDownListProjectList(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_ProjectList]"
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

    Sub SelUpd_Setup_TaxRates_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_TaxRates_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", TaxRateID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdTaxRates.txtCode.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdTaxRates.txtName.Text = dr.GetString(1)
                        frmFMIS_Setup_AddUpdTaxRates.txtRate.Text = dr.GetDecimal(2).ToString("N2")

                        Dim Index1 As Integer = frmFMIS_Setup_AddUpdTaxRates.cbAccount.FindStringExact(dr(3).ToString())
                        If Index1 <> -1 Then frmFMIS_Setup_AddUpdTaxRates.cbAccount.SelectedIndex = Index1

                        frmFMIS_Setup_AddUpdTaxRates.chDefault.Checked = dr.GetBoolean(4)
                    End If
                End Using

            End Using
        End Using
    End Sub


    '-------------->>>> ITEMS <<<<-----------------

    Sub Sel_Setup_Item_CategoryType(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_ItemCategory]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_Items.txtboxSearch.Text)
                    Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
                    returnParam.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(returnParam)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lbl.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
                            dgv.Rows.Add(
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2))
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

    Sub Sel_Setup_Item_OPE_ByID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_Item_OPE]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@ID", ItemCategoryID)
        dr = cmd.ExecuteReader()
        While dr.Read()

            dgv.Rows.Add(
            dr.GetInt32(0),
            dr.GetString(1),
            dr.GetString(2),
            dr.GetString(3),
            dr.GetString(4))

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    Sub Sel_Setup_Item_OPE_Detail_ByID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_Item_OPE_Detail]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@ID", ItemOPEID)
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
            dr.GetString(7))

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    Sub Sel_Setup_Item_SubDetail_ByID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_Supplier_Detail]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@ID", ItemOPEID)
        dr = cmd.ExecuteReader()
        While dr.Read()

            dgv.Rows.Add(
            dr.GetInt32(0),
            dr.GetString(1),
            dr.GetString(2),
            dr.GetString(3),
            dr.GetString(4))

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    Sub InsUpd_Setup_ItemCategoryType()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_ItemCategory]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", ItemCategoryID)
                cmd.Parameters.AddWithValue("@Type", frmFMIS_Setup_AddUpdItemCategory.txtType.Text)
                cmd.Parameters.AddWithValue("@Desc", frmFMIS_Setup_AddUpdItemCategory.txtDesc.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_Item_CategoryType(frmFMIS_Setup_Items.dgvType, frmFMIS_Setup_Items.toolstriplabelNoOfRecord)
                    Call frmFMIS_Setup_AddUpdItemCategory.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_ItemCategoryType_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_ItemCategoryType_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", ItemCategoryID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdItemCategory.txtType.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdItemCategory.txtDesc.Text = dr.GetString(1)
                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub InsUpd_Setup_ItemOPE()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_ItemOPE]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", ItemOPEID)
                cmd.Parameters.AddWithValue("@Type", frmFMIS_Setup_AddUpdItemOPE.txtType.Text)
                cmd.Parameters.AddWithValue("@Name", frmFMIS_Setup_AddUpdItemOPE.txtName.Text)
                cmd.Parameters.AddWithValue("@Desc", frmFMIS_Setup_AddUpdItemOPE.txtDesc.Text)
                cmd.Parameters.AddWithValue("@isEnabled", frmFMIS_Setup_AddUpdItemOPE.chEnabled.Checked)
                cmd.Parameters.AddWithValue("@isInventory", frmFMIS_Setup_AddUpdItemOPE.chInventory.Checked)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_Item_OPE_ByID(frmFMIS_Setup_Items.dgvOPE)
                    Call frmFMIS_Setup_AddUpdItemOPE.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_ItemOPE_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_ItemOPE_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", ItemOPEID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdItemOPE.txtType.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdItemOPE.txtName.Text = dr.GetString(1)
                        frmFMIS_Setup_AddUpdItemOPE.txtDesc.Text = dr.GetString(2)
                        frmFMIS_Setup_AddUpdItemOPE.chEnabled.Checked = dr.GetBoolean(3)
                        frmFMIS_Setup_AddUpdItemOPE.chInventory.Checked = dr.GetBoolean(4)
                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub InsUpd_Setup_ItemOPE_Detail()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_ItemOPE_Detail]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", ItemSubDetailID)
                cmd.Parameters.AddWithValue("@Category", frmFMIS_Setup_Items.lblHeader.Text)
                cmd.Parameters.AddWithValue("@Type", frmFMIS_Setup_AddUpdItemOPEDetail.txtOPE.Text)
                cmd.Parameters.AddWithValue("@Code", frmFMIS_Setup_AddUpdItemOPEDetail.txtCode.Text)
                cmd.Parameters.AddWithValue("@Name", frmFMIS_Setup_AddUpdItemOPEDetail.txtName.Text)
                cmd.Parameters.AddWithValue("@Desc", frmFMIS_Setup_AddUpdItemOPEDetail.txtDesc.Text)
                cmd.Parameters.AddWithValue("@Account", frmFMIS_Setup_AddUpdItemOPEDetail.cbAccount.Text)
                cmd.Parameters.AddWithValue("@Price", Decimal.Parse(frmFMIS_Setup_AddUpdItemOPEDetail.txtPrice.Text.Replace(",", "")))
                cmd.Parameters.AddWithValue("@Vendor", frmFMIS_Setup_AddUpdItemOPEDetail.cbVendor.Text)
                cmd.Parameters.AddWithValue("@LifeSpan", Decimal.Parse(frmFMIS_Setup_AddUpdItemOPEDetail.txtLifeSpan.Text.Replace(",", "")))
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_Item_OPE_Detail_ByID(frmFMIS_Setup_Items.dgvSubDetail)
                    Call frmFMIS_Setup_AddUpdItemOPEDetail.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_ItemOPE_Detail_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_ItemOPE_Detail_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", ItemSubDetailID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then

                        frmFMIS_Setup_AddUpdItemOPEDetail.txtOPE.Text = dr.GetString(0)
                        frmFMIS_Setup_AddUpdItemOPEDetail.txtCode.Text = dr.GetString(1)
                        frmFMIS_Setup_AddUpdItemOPEDetail.txtName.Text = dr.GetString(2)
                        frmFMIS_Setup_AddUpdItemOPEDetail.txtDesc.Text = dr.GetString(3)

                        Dim Index1 As Integer = frmFMIS_Setup_AddUpdItemOPEDetail.cbAccount.FindStringExact(dr(4).ToString())
                        If Index1 <> -1 Then frmFMIS_Setup_AddUpdItemOPEDetail.cbAccount.SelectedIndex = Index1

                        frmFMIS_Setup_AddUpdItemOPEDetail.txtPrice.Text = dr.GetDecimal(5).ToString("N2")

                        Dim Index2 As Integer = frmFMIS_Setup_AddUpdItemOPEDetail.cbVendor.FindStringExact(dr(6).ToString())
                        If Index2 <> -1 Then frmFMIS_Setup_AddUpdItemOPEDetail.cbVendor.SelectedIndex = Index2

                        frmFMIS_Setup_AddUpdItemOPEDetail.txtLifeSpan.Text = dr.GetDecimal(7).ToString("N2")

                    End If
                End Using

            End Using
        End Using
    End Sub

    '-------------->>>> BEGINNING PROJECT <<<<-----------------

    Sub Sel_Setup_BeginningProject(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_BeginningProject]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_BeginningProject.txtboxSearch.Text)
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

    Sub Sel_Setup_BeginningProject_Detail_ByID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_BeginningProject_Detail]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@ID", BeginProjectID)
        dr = cmd.ExecuteReader()
        While dr.Read()

            dgv.Rows.Add(
            dr.GetInt32(0),
            dr.GetString(1),
            dr.GetDecimal(2))

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    Sub Sel_ProjectDetail_By_ProjectName()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelFMIS_ProjectDesc_By_ProjectName]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ProjectName", frmFMIS_Setup_AddUpdProjectList.cbProject.Text)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then

                        frmFMIS_Setup_AddUpdProjectList.txtDesc.Text = dr.GetString(0)

                    End If
                End Using

            End Using
        End Using
    End Sub

    Sub InsUpd_Setup_ProjectList()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_ProjectList]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ProjectNo", frmFMIS_Setup_AddUpdProjectList.cbProject.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_BeginningProject(frmFMIS_Setup_BeginningProject.dgvProjectList, frmFMIS_Setup_BeginningProject.toolstriplabelNoOfRecord)
                    Call frmFMIS_Setup_AddUpdProjectList.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub ProcessDataGridView_Setup_ProjectDetail(dataGridView As DataGridView)

        Try

            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spInsUpdFMIS_Setup_ProjectDetail]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    For Each row As DataGridViewRow In dataGridView.Rows

                        cmd.Parameters.AddWithValue("@ProjectName", frmFMIS_Setup_AddUpdProjectDetail.txtProjectName.Text)
                        cmd.Parameters.AddWithValue("@AccountName", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
                        cmd.Parameters.AddWithValue("@Amount", If(IsNumeric(row.Cells(1).Value), Convert.ToDecimal(row.Cells(1).Value), DBNull.Value))
                        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()

                    Next

                End Using
            End Using

            MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Sel_Setup_BeginningProject_Detail_ByID(frmFMIS_Setup_BeginningProject.dgvProjectDetail)
            frmFMIS_Setup_AddUpdProjectDetail.Close()

        Catch ex As Exception
            ' Show error message if something goes wrong
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub SelUpd_FMIS_Setup_ProjectDetail_ByID(dgv As DataGridView)
        dgv.Rows.Clear()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spSelUpdFMIS_Setup_ProjectDetail_ByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", BeginProjectID)
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgv.Rows.Add(
                            dr.GetString(0),
                            dr.GetDecimal(1))
                    End While
                End Using
                dgv.ClearSelection()
            End Using
        End Using
    End Sub

    '-------------->>>> BEGINNING SUBSIDIARY <<<<-----------------

    Sub Sel_Setup_Beginning_Subsidiary(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_Beginning_Subsidiary]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_BeginningSubsidiaries.txtboxSearch.Text)
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

    Sub Sel_Setup_BeginningSubsidiary_ByID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_BeginningProject_Detail]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@ID", SubsidiaryAccountID)
        dr = cmd.ExecuteReader()
        While dr.Read()

            dgv.Rows.Add(
            dr.GetInt32(0),
            dr.GetString(1),
            dr.GetDecimal(2))

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    Sub Sel_Setup_BeginningSubsidiary_Account_ByID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_BeginningSubsidiary_Account]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_BeginningSubsidiaries.txtboxSearch.Text)
        cmd.Parameters.AddWithValue("@Type", SubsidiaryTypeID)
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

    Sub Sel_Setup_BeginningSubsidiary_Account_Detail_ByID(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_BeginningSubsidiary_Detail]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@Type", SubsidiaryTypeID)
        cmd.Parameters.AddWithValue("@ID", SubsidiaryAccountID)
        dr = cmd.ExecuteReader()
        While dr.Read()

            dgv.Rows.Add(
            dr.GetInt32(0),
            dr.GetString(1),
            dr.GetDecimal(2))

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    Sub ProcessDataGridView_Setup_SubsidiaryDetail(dataGridView As DataGridView)

        Try

            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spInsUpdFMIS_Setup_SubsidiaryDetail]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    For Each row As DataGridViewRow In dataGridView.Rows

                        cmd.Parameters.AddWithValue("@SubsidiaryTypeID", SubsidiaryTypeID)
                        cmd.Parameters.AddWithValue("@SubsidiaryAccountID", SubsidiaryAccountID)
                        cmd.Parameters.AddWithValue("@AccountName", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
                        cmd.Parameters.AddWithValue("@Amount", If(IsNumeric(row.Cells(1).Value), Convert.ToDecimal(row.Cells(1).Value), DBNull.Value))
                        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()

                    Next

                End Using
            End Using

            MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Sel_Setup_BeginningSubsidiary_Account_Detail_ByID(frmFMIS_Setup_BeginningSubsidiaries.dgvAccountTitle)
            frmFMIS_Setup_AddUpdSubsidiaryDetail.Close()

        Catch ex As Exception
            ' Show error message if something goes wrong
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub SelUpd_FMIS_Setup_SubsidiaryDetail_ByID(dgv As DataGridView)
        dgv.Rows.Clear()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spSelUpdFMIS_Setup_SubsidiaryDetail_ByID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Type", SubsidiaryTypeID)
                cmd.Parameters.AddWithValue("@ID", SubsidiaryAccountID)
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgv.Rows.Add(
                            dr.GetString(0),
                            dr.GetDecimal(1))
                    End While
                End Using
                dgv.ClearSelection()
            End Using
        End Using
    End Sub

    '-------------->>>> TRANSACTION CLOSING <<<<-----------------

    Sub Sel_Setup_Transaction_Closing(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_Transaction_Closing]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_TransactionClosing.txtboxSearch.Text)
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
                                dr.GetString(4),
                                dr.GetString(5))
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

    Sub InsUpd_Setup_Transaction_Closing()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_TransactionClosing]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", TransactionClosingID)
                cmd.Parameters.AddWithValue("@BeginningDate", frmFMIS_Setup_AddUpdTransactionClosing.dtpBeginDate.Value.Date)
                cmd.Parameters.AddWithValue("@PreClosingDate", frmFMIS_Setup_AddUpdTransactionClosing.dtpPreCloseDate.Value.Date)
                cmd.Parameters.AddWithValue("@ClosingDate", frmFMIS_Setup_AddUpdTransactionClosing.dtpCloseDate.Value.Date)
                cmd.Parameters.AddWithValue("@Override", frmFMIS_Setup_AddUpdTransactionClosing.chOverride.Checked)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_Transaction_Closing(frmFMIS_Setup_TransactionClosing.dgvTransactionDate, frmFMIS_Setup_TransactionClosing.toolstriplabelNoOfRecord)
                    Call frmFMIS_Setup_AddUpdTransactionClosing.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_Transaction_Closing_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_Transaction_Closing_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", TransactionClosingID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdTransactionClosing.dtpBeginDate.Value = dr.GetDateTime(0)
                        frmFMIS_Setup_AddUpdTransactionClosing.dtpCloseDate.Value = dr.GetDateTime(1)
                        frmFMIS_Setup_AddUpdTransactionClosing.dtpPreCloseDate.Value = dr.GetDateTime(2)
                        frmFMIS_Setup_AddUpdTransactionClosing.chOverride.Checked = dr.GetBoolean(3)
                    End If
                End Using

            End Using
        End Using
    End Sub

    '-------------->>>> YEAR END CLOSING <<<<-----------------

    Sub Sel_Setup_YearEnd_Closing(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_YearEnd_Closing]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_YearEndClosing.txtboxSearch.Text)
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

    Sub InsUpd_Setup_YearEnd_Closing()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_YearEndClosing]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", YearEndClosingID)
                cmd.Parameters.AddWithValue("@ClosingDate", frmFMIS_Setup_AddUpdYearEndClosing.dtpCloseDate.Value.Date)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_YearEnd_Closing(frmFMIS_Setup_YearEndClosing.dgvYearEndDate, frmFMIS_Setup_YearEndClosing.toolstriplabelNoOfRecord)
                    Call frmFMIS_Setup_AddUpdYearEndClosing.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_YearEnd_Closing_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_YearEnd_Closing_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", YearEndClosingID)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        frmFMIS_Setup_AddUpdYearEndClosing.dtpCloseDate.Value = dr.GetDateTime(0)
                    End If
                End Using

            End Using
        End Using
    End Sub

    '-------------->>>> ACCOUNT BALANCES <<<<-----------------

    Sub Sel_Setup_AccountBalances(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_AccountBalances]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_AccountBalances.txtboxSearch.Text)
                    Dim returnParam As New SqlParameter("@NumRec", SqlDbType.Int)
                    returnParam.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(returnParam)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            lbl.Text = If(IsDBNull(returnParam.Value), 0, returnParam.Value)
                            dgv.Rows.Add(
                                dr.GetString(0))
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

    Sub Sel_Setup_AccountBalances_ByID(dgv As DataGridView, skip As Boolean)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_AccountBalances_Account]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        If Not skip Then
            cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_AccountBalances.txtboxSearch.Text)
        Else
            cmd.Parameters.AddWithValue("@txt", "")
        End If

        cmd.Parameters.AddWithValue("@Year", AccountBalancesYear)
        dr = cmd.ExecuteReader()
        While dr.Read()

            dgv.Rows.Add(
            dr.GetInt32(0),
            dr.GetString(1),
            dr.GetString(2),
            dr.GetDecimal(3).ToString("N2"),
            dr.GetDecimal(4).ToString("N2"))

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    Sub Sel_AccountBalances_Year_ifNonExistence(txt As TextBox)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_AccountBalances_Year_ifNonExistence]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@txt", txt.Text)

        frmFMIS_Setup_AddAccountBalances.isExist = cmd.ExecuteScalar

        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub Sel_Setup_AccountBalances_Ins(dgv As DataGridView)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_AccountBalances_Account_Ins]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        'cmd.Parameters.AddWithValue("@Year", AccountBalancesYear)
        dr = cmd.ExecuteReader()
        While dr.Read()

            dgv.Rows.Add(
            dr.GetInt32(0),
            dr.GetString(1),
            dr.GetString(2),
            dr.GetDecimal(3).ToString("N2"),
            dr.GetDecimal(4).ToString("N2"))

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    Sub Ins_Setup_Account_Balances(dataGridView As DataGridView, txt As TextBox)

        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spInsUpdFMIS_Setup_AccountBalances]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    For Each row As DataGridViewRow In dataGridView.Rows
                        cmd.Parameters.AddWithValue("@ID", If(row.Cells(0).Value IsNot DBNull.Value, row.Cells(0).Value.ToString(), ""))
                        cmd.Parameters.AddWithValue("@Year", txt.Text)
                        cmd.Parameters.AddWithValue("@BeginningBalance", If(IsNumeric(row.Cells(3).Value), Convert.ToDecimal(row.Cells(3).Value), DBNull.Value))
                        cmd.Parameters.AddWithValue("@DecemberAudited", If(IsNumeric(row.Cells(4).Value), Convert.ToDecimal(row.Cells(4).Value), DBNull.Value))
                        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                    Next
                End Using
            End Using
            MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'frmFMIS_Setup_AddAccountBalances.Close()
        Catch ex As Exception
            ' Show error message if something goes wrong
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    '-------------->>>> ACCOUNT MAPPING <<<<-----------------

    Sub Sel_Setup_AccountMapping(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_AccountMapping]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_Setup_AccountMapping.txtboxSearch.Text)
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
                                dr.GetInt32(3),
                                dr.GetString(4),
                                dr.GetString(5))
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

    Sub InsUpd_Setup_AccountMapping()

        Try

            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdFMIS_Setup_AccountMapping]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Internal", frmFMIS_Setup_AddUpdAccountMapping.cbInternal.Text)
                cmd.Parameters.AddWithValue("@External", frmFMIS_Setup_AddUpdAccountMapping.cbExternal.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    '\\ This Code will Select the Data after Insert.
                    MessageBox.Show("Saved.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Sel_Setup_AccountMapping(frmFMIS_Setup_AccountMapping.dgvMapping, frmFMIS_Setup_AccountMapping.toolstriplabelNoOfRecord)
                    Call frmFMIS_Setup_AddUpdAccountMapping.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message, "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub SelUpd_Setup_AccountMapping_ByID()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As SqlCommand = Conn.CreateCommand()
                cmd.CommandText = "[spSelUpdFMIS_Setup_AccountMapping_ByID]"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Internal", AccountMappingInternal)

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then

                        Dim Index1 As Integer = frmFMIS_Setup_AddUpdAccountMapping.cbInternal.FindStringExact(dr(0).ToString())
                        If Index1 <> -1 Then frmFMIS_Setup_AddUpdAccountMapping.cbInternal.SelectedIndex = Index1

                        Dim Index2 As Integer = frmFMIS_Setup_AddUpdAccountMapping.cbExternal.FindStringExact(dr(1).ToString())
                        If Index2 <> -1 Then frmFMIS_Setup_AddUpdAccountMapping.cbExternal.SelectedIndex = Index2

                    End If
                End Using

            End Using
        End Using
    End Sub


    '-------------->>>> REQUEST FOR PAYMENT <<<<-----------------

    Sub Sel_CashJournal_RequestForPaymentVoucher(dgv As DataGridView, lbl As ToolStripLabel)

        dgv.Rows.Clear()
        Try
            Using Conn As New SqlConnection(StrConn)
                Conn.Open()
                Using cmd As New SqlCommand("[spSelFMIS_All_RequestForPaymentVoucher]", Conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@txt", frmFMIS_CashJournal_RequestForPayment.txtboxSearch.Text)
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
                                dr.GetDecimal(4).ToString("N2"),
                                dr.GetString(5),
                                dr.GetString(6),
                                dr.GetString(7),
                                dr.GetString(8))
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

    Sub Sel_CashJournal_RequestForPaymentVoucher_Detail_ByID(dgv As DataGridView, skip As Boolean)

        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelFMIS_All_RequestForPaymentVoucherDetail]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        'If skip Then
        '    cmd.Parameters.AddWithValue("@txt", "")
        'Else
        cmd.Parameters.AddWithValue("@txt", frmFMIS_CashJournal_RequestForPayment.txtboxSearch.Text)
        'End If

        cmd.Parameters.AddWithValue("@ID", RequestVoucherID)
        dr = cmd.ExecuteReader()
        While dr.Read()

            dgv.Rows.Add(
            dr.GetInt32(0),
            dr.GetString(1),
            dr.GetString(2),
            dr.GetDecimal(3).ToString("N2"),
            dr.GetDecimal(4).ToString("N2"),
            dr.GetString(5),
            dr.GetString(6))

        End While
        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()
        dgv.ClearSelection()

    End Sub

    Sub Sel_FMIS_Payee_By_TypeID(cBox As ComboBox, All As Boolean)

        'Dim col As New AutoCompleteStringCollection()
        'Conn = New SqlConnection(StrConn)
        'Conn.Open()
        'cBox.Items.Clear()
        'cmd.CommandText = "[spSelFMIS_Payee_By_TypeID]"
        'cmd = New SqlCommand(cmd.CommandText, Conn)
        'cmd.Parameters.AddWithValue("@ID", PayeeTypeID)
        'dr = cmd.ExecuteReader()

        'While dr.Read()

        '    Dim a = dr.GetString(0)
        '    col.Add(a)
        '    cBox.Items.Add(a)

        'End While

        'cBox.AutoCompleteCustomSource = col
        'dr.Close()
        'Conn.Close()

        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spSelFMIS_Payee_By_TypeID]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", PayeeTypeID)
                cmd.Parameters.AddWithValue("@ALL", All)
                cBox.Items.Clear()
                Dim payeeDictionary As New Dictionary(Of Integer, List(Of Tuple(Of String, Integer)))()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim id As String = reader.GetString(0)
                        cBox.Items.Add(id)
                    End While
                End Using
            End Using
        End Using

    End Sub

    Sub Sel_FMIS_VoucherStatus(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_VoucherStatus]"
        cmd = New SqlCommand(cmd.CommandText, Conn)
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

    Sub Sel_FMIS_VoucherType(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_VoucherType]"
        cmd = New SqlCommand(cmd.CommandText, Conn)
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

    Sub Sel_FMIS_VoucherDepartment(cb As ComboBox)
        Using conn As New SqlConnection(StrConn),
          cmd As New SqlCommand("[spSelFMIS_VoucherDepartment]", conn)

            cmd.CommandType = CommandType.StoredProcedure
            conn.Open()

            cb.Items.Clear()

            Dim dict As New Dictionary(Of Tuple(Of Integer, Integer), String)

            Using rdr As SqlDataReader = cmd.ExecuteReader()
                While rdr.Read()
                    Dim key = Tuple.Create(rdr.GetInt32(0), rdr.GetInt32(2))
                    If Not dict.ContainsKey(key) Then
                        dict.Add(key, rdr.GetString(1))
                        cb.Items.Add(rdr.GetString(1))
                    End If
                End While
            End Using

            cb.Tag = dict
        End Using
    End Sub

    Sub Sel_FMIS_VoucherCostCenter(cb As ComboBox)

        If VoucherDepartmentID1 = 999 Then
            VoucherDepartmentID3 = VoucherDepartmentID1
        End If

        Using conn As New SqlConnection(StrConn),
          cmd As New SqlCommand("[spSelFMIS_VoucherCostCenter]", conn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@DeptID", VoucherDepartmentID1)
            cmd.Parameters.AddWithValue("@PType", VoucherDepartmentID3)

            conn.Open()

            cb.Items.Clear()

            Dim dict As New Dictionary(Of Tuple(Of Integer, Integer, Integer), String)

            Using rdr = cmd.ExecuteReader()
                While rdr.Read()
                    Dim key = Tuple.Create(rdr.GetInt32(0), rdr.GetInt32(2), rdr.GetInt32(3))
                    If Not dict.ContainsKey(key) Then
                        Dim cost = rdr.GetString(1)
                        dict.Add(key, cost)
                        cb.Items.Add(cost)
                    End If
                End While
            End Using

            cb.Tag = dict

        End Using

    End Sub

    Sub Sel_FMIS_VoucherAccountTitle(cBox As ComboBox)

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cBox.Items.Clear()
        cmd.CommandText = "[spSelFMIS_VoucherAccountTitle]"
        cmd = New SqlCommand(cmd.CommandText, Conn)
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

    Sub SelRequestVoucherNumber(selectedDate As DateTime)

        Try
            Using Conn As New SqlConnection(StrConn),
          cmd As New SqlCommand("[spSelFMIS_RFP_VoucherNo]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                cmd.Parameters.AddWithValue("@date", selectedDate)
                cmd.Parameters.AddWithValue("@id", RequestVoucherID)
                Dim voucherCodeParam As New SqlParameter("@VoucherCode", SqlDbType.VarChar, 20)
                voucherCodeParam.Direction = ParameterDirection.Output
                cmd.Parameters.Add(voucherCodeParam)
                Conn.Open()
                cmd.ExecuteNonQuery()
                frmFMIS_CashJournal_AddUpdateRequestForPayment.txtVoucherNumber.Text = cmd.Parameters("@VoucherCode").Value.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub





End Module
