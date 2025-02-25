
Imports System.Data.SqlClient
Module Module_TimeSheet

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

End Module
