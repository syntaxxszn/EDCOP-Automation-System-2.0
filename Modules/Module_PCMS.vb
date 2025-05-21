Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module Module_PCMS

    Public CurrentForm As Form
    Public currentSubMenuForm As Form = Nothing
    Public _strPayPeriodID As Integer
    Public _strWorkdate As String = Nothing
    Public _strEmployeeID As Integer
    Public _strProjectChargeID As Integer = 0
    Dim strEmpIDforInsert As Integer
    Public strEmployeeNumber As String
    Public _strUserLevel As String = Nothing
    Public _strProjectDeptID As Integer = 0
    Public _strFiledDocs As String = Nothing
    Public _strIsFlexiSched As Boolean
    Public _strAttendanceFrom As String
    Public _strAttendanceTo As String
    Public _strTimeSheetID As Integer
    Public _strTimeIn As String = Nothing


    Public Function EncodeBase64(input As String) As String
        Return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input))
    End Function


    'Sub OpenChildForm(childForm As Form)

    '    ' If CurrentForm IsNot Nothing Then CurrentForm.Show()
    '    CurrentForm = childForm
    '    childForm.TopLevel = False
    '    childForm.WindowState = FormWindowState.Maximized
    '    frmMain.panelOpenForm.Controls.Add(childForm)
    '    frmMain.panelOpenForm.Tag = childForm
    '    childForm.BringToFront()
    '    childForm.Visible = True

    'End Sub

    Public Sub OpenChildForm_Revision(childForm As Form)

        If Not IsFormOpened(childForm) Then

            CurrentForm = childForm
            childForm.TopLevel = False
            childForm.WindowState = FormWindowState.Maximized
            frmMain.PanelMainHolder.Controls.Add(childForm)
            frmMain.PanelMainHolder.Tag = childForm
            childForm.BringToFront()
            childForm.Visible = True

            '\\ This code will detect the open form.
            OpenedForms.Add(childForm)

            '\\ 
            AddHandler childForm.FormClosed, AddressOf ChildForm_FormClosed

            '\\ This code will update the list of open form to frmMain_revise.RecentToolStripMenuItem.DropDownItems.
            UpdateRecentMenuItems()
        Else
            BringFormToFront(childForm)
        End If
    End Sub

    Private Function IsFormOpened(form As Form) As Boolean
        Return OpenedForms.Any(Function(f) f.Text = form.Text)
    End Function


    ' this is to show sub menu
    Public Sub ShowSubMenu(subMenuForm As Form, button As Button)
        ' Close existing submenu if open
        currentSubMenuForm?.Close()
        currentSubMenuForm = Nothing

        ' Show new submenu if provided
        If subMenuForm IsNot Nothing Then
            currentSubMenuForm = subMenuForm
            subMenuForm.TopLevel = True
            subMenuForm.TopMost = True

            ' Position submenu at 3/4 of the button's width, centered vertically
            Dim buttonLocation As Point = button.PointToScreen(Point.Empty)
            subMenuForm.Location = New Point(buttonLocation.X + (button.Width * 3.5 \ 4),
                                         buttonLocation.Y + (button.Height \ 2) - (subMenuForm.Height \ 2))

            AddHandler subMenuForm.Deactivate, AddressOf SubMenuForm_Deactivate
            subMenuForm.Show()
        End If
    End Sub

    Private Sub SubMenuForm_Deactivate(sender As Object, e As EventArgs)
        If currentSubMenuForm IsNot Nothing Then
            currentSubMenuForm.Close()
            currentSubMenuForm = Nothing
        End If
    End Sub


    '' Start of Login Code ---------------------------------------------------------------------------------------------------

    Sub Login_User()

        If frmPMS_Login.txtPassword.Text = "Password" Then
            frmPMS_Login.txtPassword.Text = ""
        Else
            frmPMS_Login.txtPassword.Text = EncodeBase64(frmPMS_Login.txtPassword.Text)
        End If

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPCMS_LoginSecurity]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }

        cmd.Parameters.AddWithValue("@PersonnelCode", frmPMS_Login.txtEmployeeCode.Text)
        cmd.Parameters.AddWithValue("@Password", frmPMS_Login.txtPassword.Text)
        dr = cmd.ExecuteReader()

        If dr.Read = True Then

            _strEmployeeID = dr.GetInt32(0)
            frmMain.ToolStripEmployeeNo.Text = dr.GetString(1)
            _strUserLevel = dr.GetString(2)
            frmMain.ToolStripEmployeeName.Text = dr.GetString(3)
            _strIsFlexiSched = dr.GetBoolean(4)

            frmMain.ToolStripConnectionIP.Text = "192.168.0.248"
            frmMain.ToolStripAccessRights.Text = _strUserLevel

            frmPMS_Login.Hide()
            frmPMS_Login.txtEmployeeCode.Clear()
            frmPMS_Login.txtPassword.Clear()

            If frmMain Is Nothing OrElse frmMain.IsDisposed Then
                frmMain = New frmMain()
            End If

            If _strUserLevel = "Master" Then
                frmMain.Show()
                ''frmMain.treeViewIndividual.Visible = False

            Else

                If _strUserLevel = "Individual" Then
                    'frmMain.btnHRM.Visible = False
                    'frmMain.btnFMM.Visible = False
                    'frmMain.btnPMM.Visible = False
                    'frmMain.btnBDM.Visible = False
                    frmMain.Show()
                    ''   frmMain.treeViewMaster.Visible = False
                End If

            End If

        Else

            MessageBox.Show("Invalid Access." & vbNewLine & "" & vbNewLine & "Make sure that you are using an account registered to this system.", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmPMS_Login.txtEmployeeCode.Clear()
            frmPMS_Login.txtPassword.Clear()

        End If

        dr.Close()
        Conn.Close()

    End Sub

    Sub Login_UserRegistration_Clear()
        frmPMS_UserRegistration.cmbboxUserAccount.SelectedIndex = -1
        frmPMS_UserRegistration.txtboxEmployeeName.Clear()
        frmPMS_UserRegistration.txtboxDepartment.Clear()
        frmPMS_UserRegistration.txtBoxContracNo.Clear()
        frmPMS_UserRegistration.txtBoxJobTitle.Clear()
        frmPMS_UserRegistration.cmbboxUserLevel.SelectedIndex = -1
    End Sub

    Sub InsertLogin_UserRegistration()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "spInPCMS_SystemUser"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }
        cmd.Parameters.AddWithValue("@UserName", frmPMS_UserRegistration.cmbboxUserAccount.Text)
        cmd.Parameters.AddWithValue("@EmployeeID", strEmpIDforInsert)
        cmd.Parameters.AddWithValue("@UserLevel", frmPMS_UserRegistration.cmbboxUserLevel.Text)

        If cmd.ExecuteNonQuery = -1 Then
            'If MessageBox.Show("Record saved!" & vbNewLine & "Transact again?", "PCM System", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            '    Login_UserRegistration_Clear()
            'Else
            '    Login_UserRegistration_Clear()
            '    frmPMS_UserRegistration.Close()
            '    cmd.Parameters.Clear()
            'End If
            Login_UserRegistration_Clear()
        End If
        Conn.Close()

    End Sub

    Sub Login_GetUserRegistrationDetailsByUserName()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPCMS_SystemUserDetailsByID]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@UserName", frmPMS_UserRegistration.cmbboxUserAccount.Text)

        dr = cmd.ExecuteReader()
        While (dr.Read)
            strEmpIDforInsert = dr.GetInt32(0)
            frmPMS_UserRegistration.txtboxEmployeeName.Text = dr.GetString(1)
            frmPMS_UserRegistration.txtboxDepartment.Text = dr.GetString(2)
            frmPMS_UserRegistration.txtBoxContracNo.Text = dr.GetString(3)
            frmPMS_UserRegistration.txtBoxJobTitle.Text = dr.GetString(4)
        End While

        dr.Close()
        Conn.Close()
    End Sub

    Sub Populate_ComboBox_EmployeeNo(cmbBoxUserAccount As ComboBox)

        cmbBoxUserAccount.AutoCompleteMode = AutoCompleteMode.Append
        cmbBoxUserAccount.AutoCompleteSource = AutoCompleteSource.CustomSource

        Dim col As New AutoCompleteStringCollection()
        Conn = New SqlConnection(StrConn)
        cmbBoxUserAccount.Items.Clear()
        cmd.CommandText = "[spSelPCMS_SystemUser]"
        cmd = New SqlCommand(cmd.CommandText, Conn)
        Conn.Open()
        dr = cmd.ExecuteReader()
        While dr.Read()
            Dim a = dr(Convert.ToString("UserName"))
            col.Add(a)
            cmbBoxUserAccount.Items.Add(a)

        End While
        cmbBoxUserAccount.AutoCompleteCustomSource = col
        dr.Close()
        Conn.Close()

    End Sub

    '' End of Login Code ---------------------------------------------------------------------------------------------------

    '' Start of Individual Form for Employee Code ---------------------------------------------------------------------------------------------------

    Sub PayrollPeriod(dgvPayPeriod As DataGridView)

        dgvPayPeriod.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPayrollPeriodForPost]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        dr = cmd.ExecuteReader()
        While dr.Read()

            dgvPayPeriod.Rows.Add(dr("ID").ToString, dr("Year").ToString, dr("Month").ToString, dr("Payroll Period").ToString, dr("Attendance Period").ToString)

        End While
        dr.Close()
        Conn.Close()

    End Sub

    Sub PayrollPeriod_Details(dgvPayRollPeriodDetails As DataGridView)

        'dgvPayRollPeriodDetails.Rows.Clear()
        'Conn = New SqlConnection(StrConn)
        'Conn.Open()
        'cmd = Conn.CreateCommand
        'cmd.CommandText = "[spSelPCMS_TimeCardSubDetail]"
        'cmd = New SqlCommand(cmd.CommandText, Conn) With {
        '                .CommandType = CommandType.StoredProcedure
        '                }

        'cmd.Parameters.AddWithValue("@PayPeriodID", strPayPeriodID)
        'cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)

        'dr = cmd.ExecuteReader()
        'While dr.Read()
        '    dgvPayRollPeriodDetails.Rows.Add(dr("ID").ToString, dr("WorkDate").ToString, dr("Restday").ToString, dr("TotalHourRenderPerDay").ToString)
        'End While
        'dr.Close()
        'Conn.Close()

    End Sub

    Sub ProjectCharge_Clear()

        FrmPMS_Individual_AddNew_Activity.txtboxProject.Clear()
        FrmPMS_Individual_AddNew_Activity.txtboxHourRender.Clear()
        FrmPMS_Individual_AddNew_Activity.txtboxActivity.Clear()
        FrmPMS_Individual_AddNew_Activity.btnClear.PerformClick()
    End Sub

    Sub Administrator_ProjectCharge_Clear()

        frmPMS_Administrator_AddNew_Activity.txtboxProject.Clear()
        frmPMS_Administrator_AddNew_Activity.txtboxHourRender.Clear()
        frmPMS_Administrator_AddNew_Activity.txtboxActivity.Clear()

    End Sub

    Sub Select_ActivityDetails(dgvProjectTagList As DataGridView)

        dgvProjectTagList.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPCMS_ProjectChargeDetailsByProjectandWorkDate]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@WorkDate", _strWorkdate)
        cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
        dr = cmd.ExecuteReader()

        While dr.Read()
            dgvProjectTagList.Rows.Add(dr("ID").ToString, dr("WorkDate").ToString, dr("ProjectNo").ToString, dr("Description").ToString, dr("HoursRender").ToString, dr("Activity").ToString, dr("isOT").ToString, dr("isOB").ToString)
        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub Print_ProjectChargeDetails()

        FrmPMS_Individual_ViewPrint.CrystalReportViewer1.ShowProgressAnimation(True)

        Dim report1 As New rpt_IndividualProjectTag_Summary2
        ' Dim report2 As New rpt_IdnvidualProjectTag_SummaryProjectPerCutOff

        Dim user As String = "sa"
        'Dim pwd As String = "3dcoP2022"
        Dim pwd As String = "3dcoP032022"
        report1.SetDatabaseLogon(user, pwd)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        ' cmd.CommandText = "spRpt_PCMSIndividualPrintPerProjectByDateID"
        cmd.CommandText = "rptTestingPCMS"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        ' cmd.Parameters.AddWithValue("@WorkdateID", strWorkdateID)
        cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
        cmd.Parameters.AddWithValue("@PayPeriodID", _strPayPeriodID)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read)

                report1.SetParameterValue("rptEmployeeID", _strEmployeeID)
                report1.SetParameterValue("rptPayPeriodID", _strPayPeriodID)

                Dim strEmployeeNo = dr("EmployeeNamewithID")

                report1.SetParameterValue("@rptFullName", strEmployeeNo)

                Dim strDepartment = dr("JobTitlewithDept")
                report1.SetParameterValue("@rptDepartment", strDepartment)
            End While

            FrmPMS_Individual_ViewPrint.CrystalReportViewer1.ReportSource = report1
            FrmPMS_Individual_ViewPrint.CrystalReportViewer1.Refresh()
            FrmPMS_Individual_ViewPrint.ShowDialog()

        Else
            MessageBox.Show("No Activity found on this date and or pay period.", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr.Close()
        Conn.Close()
    End Sub

    Sub Print_TimeSheet_byEmployee()

        FrmPMS_Individual_ViewPrint.CrystalReportViewer1.ShowProgressAnimation(True)

        Dim report1 As New rpt_ATA_TimesheetByEmployeeFlexi
        Dim user As String = "sa"
        'Dim pwd As String = "3dcoP2022"
        Dim pwd As String = "3dcoP032022"
        report1.SetDatabaseLogon(user, pwd)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "spRpt_ATA_TimesheetDetailSummary"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }


        cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
        cmd.Parameters.AddWithValue("@PayPeriodID", _strPayPeriodID)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read)

                report1.SetParameterValue("rptEmployeeID", _strEmployeeID)
                report1.SetParameterValue("rptPayPeriodID", _strPayPeriodID)

            End While

            FrmPMS_Individual_ViewPrint.CrystalReportViewer1.ReportSource = report1
            FrmPMS_Individual_ViewPrint.CrystalReportViewer1.Refresh()
            FrmPMS_Individual_ViewPrint.ShowDialog()

        Else
            MessageBox.Show("No Activity found on this date and or pay period.", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr.Close()
        Conn.Close()
    End Sub

    Sub Print_AllProjectChargeSummary()

        FrmPMS_Individual_ViewPrint.CrystalReportViewer1.ShowProgressAnimation(True)

        Dim report1 As New rpt_Administrator_AllProjectSummary

        Dim user As String = "sa"
        Dim pwd As String = "3dcoP032022"
        report1.SetDatabaseLogon(user, pwd)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "spRptPCMS_ActualtimeProjectSummary"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@RangeFrom", frmPMS_Administrator_SummaryOfCharge_AllProject.dtpDateFrom.Text)
        cmd.Parameters.AddWithValue("@RangeTo", frmPMS_Administrator_SummaryOfCharge_AllProject.dtpDateTo.Text)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read)

                report1.SetParameterValue("rptRangeFrom", frmPMS_Administrator_SummaryOfCharge_AllProject.dtpDateFrom.Text)
                report1.SetParameterValue("rptRangeTo", frmPMS_Administrator_SummaryOfCharge_AllProject.dtpDateTo.Text)

            End While

            FrmPMS_Administrator_ViewPrint.CrystalReportViewer1.ReportSource = report1
            FrmPMS_Administrator_ViewPrint.CrystalReportViewer1.Refresh()
            FrmPMS_Administrator_ViewPrint.ShowDialog()

        Else
            MessageBox.Show("No Activity found on this date and or pay period.", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr.Close()
        Conn.Close()
    End Sub

    Sub Print_PerProjectWithEmployee()

        FrmPMS_Individual_ViewPrint.CrystalReportViewer1.ShowProgressAnimation(True)

        Dim report1 As New rpt_Administrator_PerProjectSummary

        Dim user As String = "sa"
        Dim pwd As String = "3dcoP032022"
        report1.SetDatabaseLogon(user, pwd)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "spRptPCMS_PerProjectSummary"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@RangeFrom", frmPMS_Administrator_SummaryOfCharge_PerProjectEmployee.dtpDateFrom.Text)
        cmd.Parameters.AddWithValue("@RangeTo", frmPMS_Administrator_SummaryOfCharge_PerProjectEmployee.dtpDateTo.Text)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read)

                report1.SetParameterValue("rptRangeFrom", frmPMS_Administrator_SummaryOfCharge_PerProjectEmployee.dtpDateFrom.Text)
                report1.SetParameterValue("rptRangeTo", frmPMS_Administrator_SummaryOfCharge_PerProjectEmployee.dtpDateTo.Text)

            End While

            FrmPMS_Administrator_ViewPrint.CrystalReportViewer1.ReportSource = report1
            FrmPMS_Administrator_ViewPrint.CrystalReportViewer1.Refresh()
            FrmPMS_Administrator_ViewPrint.ShowDialog()

        Else
            MessageBox.Show("No Activity found on this date and or pay period.", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr.Close()
        Conn.Close()
    End Sub

    Sub Print_PerDepartmentProjectSummary()

        FrmPMS_Individual_ViewPrint.CrystalReportViewer1.ShowProgressAnimation(True)

        Dim report1 As New rpt_Administrator_PerDepartmentProjectSummary

        Dim user As String = "sa"
        Dim pwd As String = "3dcoP032022"
        report1.SetDatabaseLogon(user, pwd)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spRptPCMS_PerDepartmentProjectSummary]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@RangeFrom", frmPMS_Administrator_SummaryOfCharge_PerProjectDept.dtpDateFrom.Text)
        cmd.Parameters.AddWithValue("@RangeTo", frmPMS_Administrator_SummaryOfCharge_PerProjectDept.dtpDateTo.Text)
        cmd.Parameters.AddWithValue("@ID", _strProjectDeptID)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read)

                report1.SetParameterValue("rptRangeFrom", frmPMS_Administrator_SummaryOfCharge_PerProjectDept.dtpDateFrom.Text)
                report1.SetParameterValue("rptRangeTo", frmPMS_Administrator_SummaryOfCharge_PerProjectDept.dtpDateTo.Text)
                report1.SetParameterValue("rptDeptID", _strProjectDeptID)

            End While
            FrmPMS_Administrator_ViewPrint.CrystalReportViewer1.Refresh()
            FrmPMS_Administrator_ViewPrint.CrystalReportViewer1.ReportSource = report1
            FrmPMS_Administrator_ViewPrint.ShowDialog()

        Else
            MessageBox.Show("No Activity found on this date and or pay period.", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr.Close()
        Conn.Close()

    End Sub

    Sub Print_PerEmployeeChargeToProject()

        FrmPMS_Individual_ViewPrint.CrystalReportViewer1.ShowProgressAnimation(True)

        Dim report1 As New rpt_Administrator_PerProjectSummary___EmployeeFirst

        Dim user As String = "sa"
        Dim pwd As String = "3dcoP032022"
        report1.SetDatabaseLogon(user, pwd)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "spRptPCMS_PerEmployeeSummary"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@RangeFrom", frmPMS_Administrator_SummaryOfCharge_PerEmployeeProject.dtpDateFrom.Text)
        cmd.Parameters.AddWithValue("@RangeTo", frmPMS_Administrator_SummaryOfCharge_PerEmployeeProject.dtpDateTo.Text)

        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read)

                report1.SetParameterValue("rptRangeFrom", frmPMS_Administrator_SummaryOfCharge_PerEmployeeProject.dtpDateFrom.Text)
                report1.SetParameterValue("rptRangeTo", frmPMS_Administrator_SummaryOfCharge_PerEmployeeProject.dtpDateTo.Text)

            End While

            FrmPMS_Administrator_ViewPrint.CrystalReportViewer1.ReportSource = report1
            FrmPMS_Administrator_ViewPrint.CrystalReportViewer1.Refresh()
            FrmPMS_Administrator_ViewPrint.ShowDialog()

        Else
            MessageBox.Show("No Activity found on this date and or pay period.", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr.Close()
        Conn.Close()
    End Sub

    Sub Select_EmployeeList()

        frmPMS_Administrator.dgvEmployeeList.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPCMS_Personnel]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@PayrollPeriodID", _strPayPeriodID)

        dr = cmd.ExecuteReader()
        While dr.Read()
            frmPMS_Administrator.dgvEmployeeList.Rows.Add(dr("hrmID").ToString, dr("Code").ToString, dr("FullName").ToString, dr("Jobtitle").ToString, dr("Department").ToString, dr("TotalHourPerCutOff").ToString)
        End While
        dr.Close()
        Conn.Close()

    End Sub

    Sub Select_Employee_ByID()

        frmPMS_Individual.dgvEmployeeList.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPCMS_Personnel_ByID]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@PayrollPeriodID", _strPayPeriodID)
        cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
        dr = cmd.ExecuteReader()
        While dr.Read()
            frmPMS_Individual.dgvEmployeeList.Rows.Add(dr("hrmID").ToString, dr("Code").ToString, dr("FullName").ToString, dr("Jobtitle").ToString, dr("Department").ToString, dr("TotalHourPerCutOff").ToString)
        End While
        dr.Close()
        Conn.Close()

    End Sub

    Sub Insert_ProjectCharge_Administrator()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spInsPCMS_ProjectChargeDetails]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }

        cmd.Parameters.AddWithValue("@UserName", strEmployeeNumber)
        cmd.Parameters.AddWithValue("@WorkDate", frmPMS_Administrator_AddNew_Activity.txtboxDate.Text)
        cmd.Parameters.AddWithValue("@Description", frmPMS_Administrator_AddNew_Activity.txtboxProject.Text)
        cmd.Parameters.AddWithValue("@Hours", frmPMS_Administrator_AddNew_Activity.txtboxHourRender.Text)
        cmd.Parameters.AddWithValue("@Activity", frmPMS_Administrator_AddNew_Activity.txtboxActivity.Text)
        cmd.Parameters.AddWithValue("@CreatedBy", frmMain.ToolStripEmployeeNo.Text)

        If cmd.ExecuteNonQuery = -1 Then

            '\\ This code will refresh activitylog from main form.
            Select_ActivityLog()

            If MessageBox.Show("Tag of Project for " & frmPMS_Administrator_AddNew_Activity.txtboxDate.Text & "Completed!" & vbNewLine & "" & vbNewLine & "" & vbNewLine & "Create Another Activity to this date ? ", "PCM System", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Administrator_ProjectCharge_Clear()

            Else

                Insert_PayrollPeriod_Details(frmPMS_Administrator.dgvPayrollPeriodDetails)
                Administrator_ProjectCharge_Clear()
                frmPMS_Administrator_AddNew_Activity.Dispose()

            End If

        End If
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub Insert_ProjectCharge()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spInsPCMS_ProjectChargeDetails]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }

        cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
        cmd.Parameters.AddWithValue("@WorkDate", FrmPMS_Individual_AddNew_Activity.txtboxDate.Text)
        cmd.Parameters.AddWithValue("@Description", FrmPMS_Individual_AddNew_Activity.txtboxProject.Text)
        cmd.Parameters.AddWithValue("@Hours", FrmPMS_Individual_AddNew_Activity.txtboxHourRender.Text)
        cmd.Parameters.AddWithValue("@Activity", FrmPMS_Individual_AddNew_Activity.txtboxActivity.Text)
        cmd.Parameters.AddWithValue("@CreatedBy", frmMain.ToolStripEmployeeNo.Text)

        If cmd.ExecuteNonQuery = -1 Then

            '\\ This code will refresh activitylog from main form.
            Select_ActivityLog()

            If MessageBox.Show("Tag of Project for " & FrmPMS_Individual_AddNew_Activity.txtboxDate.Text & " Completed!" & vbNewLine & "" & vbNewLine & "" & vbNewLine & "Create Another Activity to this date ? ", "PCM System", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                ProjectCharge_Clear()

            Else

                Insert_PayrollPeriod_Details(frmPMS_Individual.dgvPayrollPeriodDetails)
                ProjectCharge_Clear()
                FrmPMS_Individual_AddNew_Activity.Dispose()

            End If

        Else

            MessageBox.Show("Something went wrong. ", "E-PCM System.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Conn.Close()
        cmd.Parameters.Clear()
    End Sub

    Sub Insert_PayrollPeriod_Details(dgvPayRollPeriodDetails As DataGridView)

        dgvPayRollPeriodDetails.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spUpd_ManualTimeKeepingUpdTimeSheetSubmit]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        cmd.Parameters.AddWithValue("@PayPeriodID", _strPayPeriodID)
        cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
        dr = cmd.ExecuteReader()

        While dr.Read()
            dgvPayRollPeriodDetails.Rows.Add(dr("ATASubmitID").ToString, dr("WorkDate").ToString, dr("HolidayType").ToString, dr("Restday").ToString, dr("FiledDoc").ToString, dr("TimeIn").ToString, dr("BreakOut").ToString, dr("BreakIn").ToString, dr("TimeOut").ToString, dr("OtIn").ToString, dr("OTOut").ToString, dr("RegularHours").ToString, dr("TotalHourRenderPerDay").ToString)
        End While

        dr.Close()
        Conn.Close()
        dgvPayRollPeriodDetails.ClearSelection()

    End Sub

    Sub SelectUpdate_ProjectChargeDetails_ByProjectChargeID()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPCMS_ProjectChargeDetails_byID]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }

        cmd.Parameters.AddWithValue("@ID", _strProjectChargeID)

        dr = cmd.ExecuteReader()

        While dr.Read()

            FrmPMS_Individual_Update_Activity.txtboxDate.Text = dr.GetString(0)
            FrmPMS_Individual_Update_Activity.txtboxProject.Text = dr.GetString(1)
            FrmPMS_Individual_Update_Activity.txtboxHourRender.Text = dr.GetDecimal(2)
            FrmPMS_Individual_Update_Activity.txtboxActivity.Text = dr.GetString(3)

        End While

        dr.Close()
        Conn.Close()


    End Sub

    Sub InsertUpdate_ProjectChargeDetails()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd.Connection.CreateCommand()
        cmd.CommandText = "[spInsUpdPCMS_ProjecrChargeDetails]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@ID", _strProjectChargeID)
        cmd.Parameters.AddWithValue("@Description", FrmPMS_Individual_Update_Activity.txtboxProject.Text)
        cmd.Parameters.AddWithValue("@Hours", FrmPMS_Individual_Update_Activity.txtboxHourRender.Text)
        cmd.Parameters.AddWithValue("@Activity", FrmPMS_Individual_Update_Activity.txtboxActivity.Text)
        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
        cmd.Parameters.AddWithValue("@WorkDate", FrmPMS_Individual_Update_Activity.txtboxDate.Text)
        cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
        If cmd.ExecuteNonQuery = -1 Then

            Select_ActivityDetails(FrmPMS_Individual_ViewActivity.dgvProjectTagList)

        Else

            MessageBox.Show("Cannot update, Something went wrong. ", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Conn.Close()
        cmd.Parameters.Clear()
        FrmPMS_Individual_Update_Activity.Dispose()
    End Sub

    Sub Delete_ProjectChargeDetails()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd.Connection.CreateCommand()
        cmd.CommandText = "[spSelDelPCMS_ProjectChargeDetails]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                    }

        cmd.Parameters.AddWithValue("@ID", _strProjectChargeID)
        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)

        cmd.Parameters.AddWithValue("@Activity", FrmPMS_Individual_Update_Activity.txtboxActivity.Text)
        cmd.Parameters.AddWithValue("@Description", FrmPMS_Individual_Update_Activity.txtboxProject.Text)
        cmd.Parameters.AddWithValue("@WorkDate", FrmPMS_Individual_Update_Activity.txtboxDate.Text)


        If cmd.ExecuteNonQuery = -1 Then

            Select_ActivityDetails(FrmPMS_Individual_ViewActivity.dgvProjectTagList)

        Else

            MessageBox.Show("Cannot update, Something went wrong. ", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Conn.Close()
        cmd.Parameters.Clear()
        FrmPMS_Individual_Update_Activity.Dispose()
    End Sub

    Sub Populate_ComboBox_ProjectDepartment(CmboboxProjectDepartment)

        CmboboxProjectDepartment.AutoCompleteMode = AutoCompleteMode.Append
        CmboboxProjectDepartment.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim col As New AutoCompleteStringCollection()

        Conn = New SqlConnection(StrConn)
        CmboboxProjectDepartment.Items.Clear()
        cmd.CommandText = "SELECT Department  FROM [dbo].[PCMS_Department] ORDER BY Department DESC "
        ' cmd.CommandText = "[spSelPCMS_ProjectDept]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.Text
                    }
        Conn.Open()
        dr = cmd.ExecuteReader()
        While dr.Read()
            Dim a = dr(Convert.ToString("Department"))
            col.Add(a)
            CmboboxProjectDepartment.Items.Add(a)
        End While

        CmboboxProjectDepartment.AutoCompleteCustomSource = col

        dr.Close()
        Conn.Close()

    End Sub

    Sub Select_ProjectDepartment_ID()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "Select ID from dbo.PCMS_Department  where Department = '" & frmPMS_Administrator_SummaryOfCharge_PerProjectDept.cmbboxDepartment.Text & "'"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.Text
                }
        dr = cmd.ExecuteReader()
        If dr.Read = True Then

            _strProjectDeptID = dr.GetInt32(0)

        Else

            MessageBox.Show("Error exist.")

        End If

        dr.Close()
        Conn.Close()

    End Sub


    Sub txtSearch_Project()

        'FrmPMS_Individual_AddNew_Activity.TextBox1.AutoCompleteMode = AutoCompleteMode.Append
        'FrmPMS_Individual_AddNew_Activity.TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Dim col As New AutoCompleteStringCollection()
        'Conn = New SqlConnection(StrConn)
        'FrmPMS_Individual_AddNew_Activity.TextBox1.Clear()
        'cmd.CommandText = "SELECT ProjectNo + ' - ' + Description As FullDesc  FROM [EDCOP_PROD].[dbo].[PMS_PROJECT]  WHERE Description LIKE '%" & FrmPMS_Individual_AddNew_Activity.TextBox1.Text & "'"
        'cmd = New SqlCommand(cmd.CommandText, Conn) With {
        '                .CommandType = CommandType.Text
        '                }
        'Conn.Open()
        'dr = cmd.ExecuteReader()
        'While dr.Read()
        '    ' Dim a = dr(Convert.ToString("FullDesc"))
        '    FrmPMS_Individual_AddNew_Activity.TextBox1.Text = dr.ToString("FullDesc")
        'End While
        'FrmPMS_Individual_AddNew_Activity.TextBox1.AutoCompleteCustomSource = col
        'dr.Close()
        'Conn.Close()

    End Sub

    Sub Sel_projectList(dgvProjectList As DataGridView)

        dgvProjectList.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPCMS_ProjectList]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        dr = cmd.ExecuteReader()
        While dr.Read()

            dgvProjectList.Rows.Add(dr("ID").ToString, dr("ProjectNo").ToString, dr("Description").ToString)

        End While
        dr.Close()
        Conn.Close()

    End Sub

    Sub Search_projectList(dgvProjectList As DataGridView, strSearch As TextBox)

        'Try
        dgvProjectList.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPCMS_SearchProjectList]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@Search", strSearch.Text)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                dgvProjectList.Rows.Add(dr("ID").ToString, dr("ProjectNo").ToString, dr("Description").ToString)
            End While
        Else
            MessageBox.Show("No record found.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        dr.Close()
        Conn.Close()
        '  Catch ex As Exception
        '  MessageBox.Show(ex.Message)
        ' End Try
        '  Conn.Close()

    End Sub

    Sub Select_ActivityLog()

        frmTrailLogs_List.dgvActivityLog.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPCMS_ActivityLog]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)
        cmd.Parameters.AddWithValue("@DateToDay", Date.Today)

        dr = cmd.ExecuteReader()

        While dr.Read()
            frmTrailLogs_List.dgvActivityLog.Rows.Add(dr("ID").ToString, dr("ActivityDate").ToString, dr("ActivityDetails").ToString)
        End While

        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub Insert_OvertimeCharge()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spInsUpdPCMS_Overtime]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }

        cmd.Parameters.AddWithValue("@PayPeriodID", _strPayPeriodID)
        cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)


        If cmd.ExecuteNonQuery = -1 Then

            MessageBox.Show("Overtime filed Updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else

            MessageBox.Show("Something went wrong.")

        End If
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub Select_ActualHours_PerDay()

        'Conn = New SqlConnection(StrConn)
        'Conn.Open()
        'cmd = Conn.CreateCommand
        'cmd.CommandText = "[spSelPCMS_ProjectChargeDetails_HoursPerDay]"
        'cmd = New SqlCommand(cmd.CommandText, Conn) With {
        '            .CommandType = CommandType.StoredProcedure
        '        }
        'cmd.Parameters.AddWithValue("@EmployeeID", _strEmployeeID)
        'cmd.Parameters.AddWithValue("@Workdate", _strWorkdate)
        'dr = cmd.ExecuteReader()
        'dr.Read()
        'frmPMS_Individual.Label1.Text = dr.GetDecimal(1)
        'dr.Close()
        'Conn.Close()

    End Sub

    Sub Insert_PayrollPeriod_Closing()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spInsPCMS_PayrollPeriod_Closing]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }
        cmd.Parameters.AddWithValue("@PayPeriodID", _strPayPeriodID)
        cmd.Parameters.AddWithValue("@Username", frmMain.ToolStripEmployeeNo.Text)

        If cmd.ExecuteNonQuery = -1 Then

            MessageBox.Show("This Payroll Period is closed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("Something went wrong.")

        End If
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub Select_PayrollPeriod_Closed_Administrator()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPCMS_PayrollPeriodClosed]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@payPeriodID", _strPayPeriodID)
        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            MessageBox.Show("You cannot edit with this Attendance Period as it was closed Automatically by the System.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            _strWorkdate = Nothing

        Else

            If _strWorkdate = Nothing Then
                MessageBox.Show("Select Work Date first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                If _strTimeIn = Nothing Then

                    MessageBox.Show("Cannot tag." & vbNewLine & "No time Captured on this Work Date.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    _strWorkdate = Nothing
                Else

                    If _strFiledDocs = "VL" Then
                        MessageBox.Show("You can only tag maximum of 4 hours with this date.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmPMS_Administrator_AddNew_Activity.ShowDialog()
                    Else

                        If _strFiledDocs = "SL" Then
                            MessageBox.Show("You can only tag maximum of 4 hours with this date.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            frmPMS_Administrator_AddNew_Activity.ShowDialog()
                            ' If _strFiledDocs = "OB/FTR" Then
                            'MessageBox.Show("Employee filed an OB(Official Business) on this date.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Else
                            '  End If
                        Else

                            frmPMS_Administrator_AddNew_Activity.ShowDialog()

                        End If
                    End If
                End If
            End If
        End If


        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub Select_PayrollPeriod_Closed_Individual()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelPCMS_PayrollPeriodClosed]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@payPeriodID", _strPayPeriodID)
        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            MessageBox.Show("You cannot edit with this Attendance Period as it was closed Automatically by the System.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            _strWorkdate = Nothing

        Else

            If _strWorkdate = Nothing Then
                MessageBox.Show("Select Work Date first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                If _strTimeIn = Nothing Then

                    MessageBox.Show("Cannot tag." & vbNewLine & "No time Captured on this Work Date.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    _strWorkdate = Nothing
                Else

                    If _strFiledDocs = "VL" Then
                        MessageBox.Show("You can only tag maximum of 4 hours with this date.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        FrmPMS_Individual_AddNew_Activity.ShowDialog()
                    Else

                        If _strFiledDocs = "SL" Then
                            MessageBox.Show("You can only tag maximum of 4 hours with this date.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            FrmPMS_Individual_AddNew_Activity.ShowDialog()
                            ' If _strFiledDocs = "OB/FTR" Then
                            'MessageBox.Show("Employee filed an OB(Official Business) on this date.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Else
                            '  End If
                        Else

                            FrmPMS_Individual_AddNew_Activity.ShowDialog()

                        End If
                    End If
                End If
            End If
        End If


        dr.Close()
        Conn.Close()
        cmd.Parameters.Clear()

    End Sub

    Sub TimeAttendance()

        'Try
        'Conn = New SqlConnection(StrConn)
        'Conn.Open()
        'cmd = Conn.CreateCommand
        'cmd.CommandText = "[spSelPCMS_TimeCard_CheckTimeDiff]"
        'cmd = New SqlCommand(cmd.CommandText, Conn) With {
        '                .CommandType = CommandType.StoredProcedure
        '                }
        'cmd.Parameters.AddWithValue("@TimeIn", strSearch.Text)
        'cmd.Parameters.AddWithValue("@BreakIn", strSearch.Text)
        'cmd.Parameters.AddWithValue("@TimeOut", strSearch.Text)
        'cmd.Parameters.AddWithValue("@BreakOut", strSearch.Text)
        'dr = cmd.ExecuteReader()

        'If dr.HasRows Then

        '    Dim _strTimeAttendance As String = dr.GetString(0)

        'Else

        '    MessageBox.Show("Cannot tag more than the time rendered.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        'End If
        'dr.Close()
        'Conn.Close()
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
        'Conn.Close()

    End Sub

    ''--->>> Clear / Reset Form Controls <<<---

    ' look and clear through nested panels
    Sub ResetTextBoxBackgroundColors(container As Control)
        For Each control As Control In container.Controls
            If TypeOf control Is TextBox Then
                control.BackColor = Color.White
            ElseIf control.HasChildren Then
                ResetTextBoxBackgroundColors(control)
            End If
        Next
    End Sub

    Sub ResetAllControlInForm(frm As Control)
        ClearTextBoxes(frm)
        ResetComboBoxes(frm)
        ResetDatePickers(frm)
        UncheckCheckBoxes(frm)
        ResetRadioButtons(frm)
        ClearDataGridViewRows(frm)
    End Sub

    Sub ClearTextBoxes(container As Control)
        For Each control As Control In container.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            ElseIf control.HasChildren Then
                ClearTextBoxes(control)
            End If
        Next
    End Sub

    Sub ResetComboBoxes(container As Control)
        For Each control As Control In container.Controls
            If TypeOf control Is ComboBox Then
                Dim comboBox = DirectCast(control, ComboBox)
                comboBox.SelectedIndex = -1
                comboBox.Tag = Nothing
            ElseIf control.HasChildren Then
                ResetComboBoxes(control)
            End If
        Next
    End Sub

    Sub ResetDatePickers(container As Control)
        For Each control As Control In container.Controls
            If TypeOf control Is DateTimePicker Then
                DirectCast(control, DateTimePicker).Value = New DateTime(1990, 1, 1)
            ElseIf control.HasChildren Then
                ResetDatePickers(control)
            End If
        Next
    End Sub

    Sub UncheckCheckBoxes(container As Control)
        For Each control As Control In container.Controls
            If TypeOf control Is CheckBox Then
                DirectCast(control, CheckBox).Checked = False
            ElseIf control.HasChildren Then
                UncheckCheckBoxes(control)
            End If
        Next
    End Sub

    Sub ResetRadioButtons(container As Control)
        For Each control As Control In container.Controls
            If TypeOf control Is RadioButton Then
                DirectCast(control, RadioButton).Checked = False
            ElseIf control.HasChildren Then
                ResetRadioButtons(control)
            End If
        Next
    End Sub

    Sub ClearDataGridViewRows(container As Control)
        For Each control As Control In container.Controls
            If TypeOf control Is DataGridView Then
                DirectCast(control, DataGridView).Rows.Clear()
            ElseIf control.HasChildren Then
                ClearDataGridViewRows(control)
            End If
        Next
    End Sub

    Sub EmailRegEx_Color(_txtSample As TextBox)
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        If Regex.IsMatch(_txtSample.Text, emailPattern) Then
            _txtSample.BackColor = Color.White
        Else
            _txtSample.BackColor = Color.LightCoral
        End If
    End Sub

    Sub BlankRegEx_Color(_txtLastname As TextBox)
        If String.IsNullOrWhiteSpace(_txtLastname.Text) Then
            _txtLastname.BackColor = Color.LightCoral
        Else
            _txtLastname.BackColor = Color.White
        End If
    End Sub

    Sub MobileNumber_Color(txt As TextBox, Optional ByRef cancel As Boolean = False)
        If String.IsNullOrWhiteSpace(txt.Text) Then
            txt.BackColor = Color.White
        ElseIf txt.Text.All(AddressOf Char.IsDigit) AndAlso txt.Text.Length = 11 Then
            txt.BackColor = Color.White
        Else
            txt.BackColor = Color.LightCoral
            MessageBox.Show("Please enter a valid 11-digit mobile number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cancel = True
        End If
    End Sub

    Sub TelephoneNumber_Color(txt As TextBox, Optional ByRef cancel As Boolean = False)
        If String.IsNullOrWhiteSpace(txt.Text) Then
            txt.BackColor = Color.White
        ElseIf txt.Text.All(AddressOf Char.IsDigit) AndAlso (txt.Text.Length = 10 OrElse txt.Text.Length = 8) Then
            txt.BackColor = Color.White
        Else
            txt.BackColor = Color.LightCoral
            MessageBox.Show("Please enter a valid 11-digit mobile number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cancel = True
        End If
    End Sub

    Sub ZipCode_Color(txt As TextBox, Optional ByRef cancel As Boolean = False)
        If String.IsNullOrWhiteSpace(txt.Text) Then
            txt.BackColor = Color.White
        ElseIf txt.Text.All(AddressOf Char.IsDigit) AndAlso txt.Text.Length = 4 Then
            txt.BackColor = Color.White
        Else
            txt.BackColor = Color.LightCoral
            MessageBox.Show("Please enter a valid 11-digit mobile number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cancel = True
        End If
    End Sub

    Sub Textbox_NumericFormat(txt As TextBox, Optional ByRef cancel As Boolean = False)
        Dim input = txt.Text.Trim()
        Dim valid = Regex.IsMatch(input, "^[\d,.]*$") AndAlso Decimal.TryParse(input.Replace(",", ""), Nothing)

        txt.BackColor = If(String.IsNullOrEmpty(input) OrElse valid, Color.White, Color.LightCoral)

        If valid Then
            txt.Text = Convert.ToDecimal(input.Replace(",", "")).ToString("N2")
            txt.SelectionStart = txt.Text.Length
        ElseIf Not String.IsNullOrEmpty(input) Then
            MessageBox.Show("Please enter a valid digit/number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cancel = True
        End If
    End Sub

    Sub SetControlsReadOnly(parent As Control)
        For Each ctrl As Control In parent.Controls
            Select Case True
                Case TypeOf ctrl Is TextBox
                    DirectCast(ctrl, TextBox).ReadOnly = True
                    DirectCast(ctrl, TextBox).Cursor = Cursors.No
                Case TypeOf ctrl Is ComboBox, TypeOf ctrl Is DateTimePicker, TypeOf ctrl Is CheckBox
                    ctrl.Enabled = False
            End Select

            ' Recursively check inside nested containers (Panels, GroupBoxes, etc.)
            If ctrl.HasChildren Then
                SetControlsReadOnly(ctrl)
            End If
        Next
    End Sub

    Sub SetControlsEditable(parent As Control)
        For Each ctrl As Control In parent.Controls
            Select Case True
                Case TypeOf ctrl Is TextBox
                    DirectCast(ctrl, TextBox).ReadOnly = False
                    DirectCast(ctrl, TextBox).Cursor = Cursors.IBeam
                Case TypeOf ctrl Is ComboBox, TypeOf ctrl Is DateTimePicker, TypeOf ctrl Is CheckBox
                    ctrl.Enabled = True
                    ctrl.Cursor = Cursors.Hand
            End Select

            ' Recursively check inside nested containers (Panels, GroupBoxes, etc.)
            If ctrl.HasChildren Then
                SetControlsEditable(ctrl)
            End If
        Next
    End Sub



End Module
