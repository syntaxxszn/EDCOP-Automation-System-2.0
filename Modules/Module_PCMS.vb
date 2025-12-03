Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.ComponentModel


Module Module_PCMS

    Function HasMenuAccess(btn As Button) As Boolean
        Return MenuAccessList.Contains(btn.Tag.ToString())
    End Function

    Function HasSubMenuAccess(btn As Button) As Boolean
        Return SubMenuAccessList.Contains(btn.Tag.ToString())
    End Function

    Public Function EncodeBase64(input As String) As String
        Return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input))
    End Function

    Function GenerateSecurePin() As String
        Dim bytes(3) As Byte
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(bytes)
        End Using
        Dim value As Integer = BitConverter.ToUInt32(bytes, 0) Mod 900000 + 100000
        Return value.ToString()
    End Function

    Public Function HasUserAccess(action As String) As Boolean
        Select Case action.ToLower()
            Case "insert"
                If Not _AllowInsert Then
                    MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Case "update"
                If Not _AllowUpdate Then
                    MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Case "delete"
                If Not _AllowDelete Then
                    MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Case "view"
                If Not _AllowView Then
                    MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Case "print"
                If Not _AllowPrint Then
                    MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Case "post"
                If Not _AllowPost Then
                    MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Case Else
                MessageBox.Show("Unknown access type.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
        End Select
        Return True
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
            subMenuForm.Location = New Point(buttonLocation.X + (button.Width * 3 \ 4),
                                         buttonLocation.Y + (button.Height \ 5) - (subMenuForm.Height \ 2))

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

            _strLoginEmployeeID = dr.GetInt32(0)
            frmMain.ToolStripEmployeeNo.Text = dr.GetString(1)
            _strUserLevel = dr.GetString(2)
            frmMain.ToolStripEmployeeName.Text = dr.GetString(3)
            _strIsFlexiSched = dr.GetBoolean(4)

            frmMain.ToolStripConnectionIP.Text = "192.168.0.248"
            frmMain.ToolStripAccessRights.Text = _strUserLevel

            frmPMS_Login.Hide()
            frmPMS_Login.txtEmployeeCode.Clear()
            frmPMS_Login.txtPassword.Clear()

            'frmMain.lblWelcomeName.Text = "Welcome! " & frmMain.ToolStripEmployeeName.Text
            frmMain.lblWelcomeName.Text = "Welcome frenny!"

            If frmMain Is Nothing OrElse frmMain.IsDisposed Then
                frmMain = New frmMain()
            End If

            Call frmMain.CustomDesign()
            Call frmMain.HideModuleButtons()
            Call GroupAccessByCode()
            Call UserAccessByCode()
            Call frmMain.Show()
            Call frmMain.AdjustSplitContainerToContents()

        Else

            MessageBox.Show("Invalid Access." & vbNewLine & "" & vbNewLine & "Make sure that you are using an account registered to this system.", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmPMS_Login.txtEmployeeCode.Text = "Employee Code"
            frmPMS_Login.txtPassword.Text = "Password"

        End If

        dr.Close()
        Conn.Close()

    End Sub

    Sub GroupAccessByCode()
        Using Conn As New SqlConnection(StrConn)
            Conn.Open()
            Using cmd As New SqlCommand("[spSelSSM_GroupAccess_ByGroupCode]", Conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@GroupName", _strUserLevel)
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        EnableButtonByTag(dr(0).ToString(), Convert.ToBoolean(dr(1)))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Sub EnableButtonByTag(ModuleCode As String, AccessType As Boolean)
        Select Case ModuleCode
            Case "1000000000"
                frmMain.btnHRM.Visible = AccessType
            Case "2000000000"
                frmMain.btnFMM.Visible = AccessType
            Case "3000000000"
                frmMain.btnPMM.Visible = AccessType
            Case "4000000000"
                frmMain.btnTKM.Visible = AccessType
            Case "5000000000"
                frmMain.btnBDM.Visible = AccessType
            Case "7000000000"
                frmMain.btnSSS.Visible = AccessType
        End Select
    End Sub

    Sub MenuLoadAccess(btn As Button)
        MenuAccessList.Clear()
        Using conn As New SqlConnection(StrConn),
          cmd As New SqlCommand("[spSelSSM_UserAccess_ByButtonTag]", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Tag", btn.Tag)
            cmd.Parameters.AddWithValue("@GroupName", _strUserLevel)
            conn.Open()
            Using dr = cmd.ExecuteReader()
                While dr.Read()
                    MenuAccessList.Add(dr(0).ToString())
                End While
            End Using
        End Using
    End Sub

    Sub SubMenuLoadAccess(btn As Button)
        SubMenuAccessList.Clear()
        Using conn As New SqlConnection(StrConn),
          cmd As New SqlCommand("[spSelSSM_UserAccess_ByButtonTag]", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Tag", btn.Tag)
            cmd.Parameters.AddWithValue("@GroupName", _strUserLevel)
            conn.Open()
            Using dr = cmd.ExecuteReader()
                While dr.Read()
                    SubMenuAccessList.Add(dr(0).ToString())
                End While
            End Using
        End Using
    End Sub

    Sub Sel_SystemGroups(dgv As DataGridView)
        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelSSM_AllSystemGroup]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        'cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
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

    Sub Sel_SystemModuleItems(dgv As DataGridView)
        dgv.Rows.Clear()

        Using conn As New SqlConnection(StrConn),
          cmd As New SqlCommand("[spSelSSM_ModuleItemList_ByGroupCode]", conn)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", _SystemGroupID)
            conn.Open()

            Using dr As SqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    Dim rowIdx As Integer = dgv.Rows.Add()
                    dgv.Rows(rowIdx).Cells(0).Value = dr.GetInt32(0)          ' ID
                    dgv.Rows(rowIdx).Cells(1).Value = dr.GetString(1)         ' Code
                    dgv.Rows(rowIdx).Cells(2).Value = dr.GetString(2)         ' Description
                    dgv.Rows(rowIdx).Cells(3).Value = dr.GetBoolean(3)   ' isAccess as checkbox
                    dgv.Rows(rowIdx).Cells(4).Value = dr.GetString(4)         ' Description
                End While
            End Using
        End Using

        dgv.ClearSelection()
    End Sub

    Sub ProcessDataGridViewGroupAccess(dgv As DataGridView)
        Try
            Using conn As New SqlConnection(StrConn),
              cmd As New SqlCommand("[spInsUpdSSM_SystemSetting_GroupAccess]", conn)

                conn.Open()
                cmd.CommandType = CommandType.StoredProcedure

                For Each row As DataGridViewRow In dgv.Rows
                    If row.IsNewRow Then Continue For

                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@GroupCode", _SystemGroupID)
                    cmd.Parameters.AddWithValue("@ModuleCode", If(row.Cells(1).Value?.ToString(), ""))
                    cmd.Parameters.AddWithValue("@isAccess", CBool(row.Cells(3).Value))
                    cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                    cmd.ExecuteNonQuery()
                Next
                MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmSSM_SystemGroupAccessMain.btnSaveChanges.Visible = False
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub SelUpd_UserAccess_ByEmployeeID()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelUpdSSM_SystemUserByEmployeeID]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }
        cmd.Parameters.AddWithValue("@ID", _SystemUserID)
        dr = cmd.ExecuteReader()

        If dr.Read = True Then
            frmSSM_SystemUserAccess_AddUpdAccess.txtEmployeeName.Text = dr.GetString(0)
            frmSSM_SystemUserAccess_AddUpdAccess.txtUserName.Text = dr.GetString(1)

            Dim Index0 As Integer = frmSSM_SystemUserAccess_AddUpdAccess.cbGroupAccess.FindStringExact(dr(2).ToString())
            If Index0 <> -1 Then frmSSM_SystemUserAccess_AddUpdAccess.cbGroupAccess.SelectedIndex = Index0

            Dim Index1 As Integer = frmSSM_SystemUserAccess_AddUpdAccess.cbAccessType.FindStringExact(dr(3).ToString())
            If Index1 <> -1 Then frmSSM_SystemUserAccess_AddUpdAccess.cbAccessType.SelectedIndex = Index1
        Else
            MessageBox.Show("Invalid Access." & vbNewLine & "" & vbNewLine & "Make sure that you are using an account registered to this system.", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        dr.Close()
        Conn.Close()

    End Sub

    Sub Sel_SystemUsers(dgv As DataGridView, txtSearch As TextBox)
        dgv.Rows.Clear()
        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelSSM_AllSystemUser]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                        .CommandType = CommandType.StoredProcedure
                        }
        cmd.Parameters.AddWithValue("@Search", txtSearch.Text)
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

    Sub DropDownListGroupAccess(cbBox As ComboBox)

        cbBox.Items.Clear()
        Conn = New SqlConnection(StrConn)
        cmd.CommandText = "[spSelSSM_GroupAccess]"
        cmd = New SqlCommand(cmd.CommandText, Conn)
        Conn.Open()
        dr = cmd.ExecuteReader()
        While dr.Read()
            Dim a = dr.GetString(0)
            cbBox.Items.Add(a)
        End While
        dr.Close()
        Conn.Close()

    End Sub

    Sub DropDownListUserAccess(cbBox As ComboBox)

        cbBox.Items.Clear()
        Conn = New SqlConnection(StrConn)
        cmd.CommandText = "[spSelSSM_UserAccess]"
        cmd = New SqlCommand(cmd.CommandText, Conn)
        Conn.Open()
        dr = cmd.ExecuteReader()
        While dr.Read()
            Dim a = dr.GetString(0)
            cbBox.Items.Add(a)
        End While
        dr.Close()
        Conn.Close()

    End Sub

    Sub InsUpd_UserAccess_ByEmployeeID()

        Try
            Using Conn As New SqlConnection(StrConn),
            cmd As New SqlCommand("[spInsUpdSSM_SystemSetting_UserAccess]", Conn)
                Conn.Open()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", _SystemUserID)
                cmd.Parameters.AddWithValue("@EUserName", frmSSM_SystemUserAccess_AddUpdAccess.txtUserName.Text)
                Dim encodedPassword As String = EncodeBase64(frmSSM_SystemUserAccess_AddUpdAccess.txtPassword.Text)
                cmd.Parameters.AddWithValue("@Password", encodedPassword)
                cmd.Parameters.AddWithValue("@GroupAccess", frmSSM_SystemUserAccess_AddUpdAccess.cbGroupAccess.Text)
                cmd.Parameters.AddWithValue("@AccessType", frmSSM_SystemUserAccess_AddUpdAccess.cbAccessType.Text)
                cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
                If cmd.ExecuteNonQuery = -1 Then
                    MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmSSM_SystemUserAccess_AddUpdAccess.Close()
                    Call Sel_SystemUsers(frmSSM_SystemUserAccessMain.dgvSystemUsers, frmSSM_SystemUserAccessMain.txtboxSearch)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try

    End Sub

    Sub UserAccessByCode()

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelSSM_SystemUserAccessType_ByEmployeeID]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }
        cmd.Parameters.AddWithValue("@EmployeeCode", frmMain.ToolStripEmployeeNo.Text)
        dr = cmd.ExecuteReader()

        If dr.Read = True Then
            _AllowInsert = dr.GetBoolean(0)
            _AllowUpdate = dr.GetBoolean(1)
            _AllowDelete = dr.GetBoolean(2)
            _AllowView = dr.GetBoolean(3)
            _AllowPrint = dr.GetBoolean(4)
            _AllowPost = dr.GetBoolean(5)
        Else
            MessageBox.Show("Invalid Access." & vbNewLine & "" & vbNewLine & "Make sure that you are using an account registered to this system.", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    '' Start of One-Time Passcode ---------------------------------------------------------------------------------------------------

    Sub InsertLogin_OneTimePasscode(pin As String)
        Try
            Conn = New SqlConnection(StrConn)
            Conn.Open()
            cmd = Conn.CreateCommand
            cmd.CommandText = "[spInsHRIS_Personnel_OneTimePasscode]"
            cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }
            cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
            cmd.Parameters.AddWithValue("@PIN", pin)
            cmd.Parameters.AddWithValue("@isUsed", False)
            cmd.Parameters.AddWithValue("@UserName", frmMain.ToolStripEmployeeNo.Text)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error Occured: " & ex.Message)
        Finally
            Conn.Close()
            cmd.Parameters.Clear()
        End Try
    End Sub

    Sub SelectLogin_OneTimePasscode(lbl As Label)

        Conn = New SqlConnection(StrConn)
        Conn.Open()
        cmd = Conn.CreateCommand
        cmd.CommandText = "[spSelUpdHRIS_Personnel_OneTimePasscode]"
        cmd = New SqlCommand(cmd.CommandText, Conn) With {
                    .CommandType = CommandType.StoredProcedure
                }

        cmd.Parameters.AddWithValue("@ID", _strEmployeeID)
        dr = cmd.ExecuteReader()

        If dr.Read = True Then
            lbl.Text = dr.GetString(0)
            frmHR_PreviewPersonnelDetails_OneTimePasscode.btnRegenerate.Text = "Re-generate"
        Else
            MessageBox.Show("No Active One-Time Password." & vbNewLine & "" & vbNewLine & "Please generate a pin to get started.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lbl.Text = ""
            frmHR_PreviewPersonnelDetails_OneTimePasscode.btnRegenerate.Text = "Generate"
        End If

        dr.Close()
        Conn.Close()

    End Sub

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

    Sub EmailRegEx_Color(_txtSample As TextBox, Optional ByRef cancel As Boolean = False)
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        If Regex.IsMatch(_txtSample.Text, emailPattern) Then
            _txtSample.BackColor = Color.White
        Else
            _txtSample.BackColor = Color.LightCoral
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cancel = True
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
            MessageBox.Show("Please enter a valid 8-digit or 10-digit telephone number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            MessageBox.Show("Please enter a valid 4-digit number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                    'DirectCast(ctrl, TextBox).Cursor = Cursors.No
                    DirectCast(ctrl, TextBox).Enabled = False
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
                    DirectCast(ctrl, TextBox).Enabled = True
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

    Sub SetButtonColor(newClickedBtn As Button)
        If BtnColorText IsNot Nothing Then
            BtnColorText.BackColor = Color.White
        End If
        newClickedBtn.BackColor = Color.Gainsboro
        BtnColorText = newClickedBtn
    End Sub

    Sub ValidateComboBoxSelection(cb As ComboBox, e As CancelEventArgs, message As String)
        If cb.SelectedIndex = -1 OrElse Not cb.Items.Contains(cb.Text) Then
            MessageBox.Show(message, "System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
            cb.Focus()
            cb.DroppedDown = True
        End If
    End Sub


End Module
