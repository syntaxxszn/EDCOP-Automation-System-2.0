
Public Class HumanResourceReportSubMenu_Employee

    Private Sub btnActiveEmployee_Click(sender As Object, e As EventArgs) Handles btnActiveEmployee.Click
        Me.Close()
        PrintRPT_Employee_isInActive(False)
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

    Private Sub btnCurrentWithGap_Click(sender As Object, e As EventArgs) Handles btnCurrentWithGap.Click
        Me.Close()
        PrintRPT_Employee_isInActive(True)
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

    Private Sub btnEmployeeByDepartment_Click(sender As Object, e As EventArgs) Handles btnEmployeeByDepartment.Click
        Me.Close()
        PrintRPT_Employee_ByDepartment()
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

    Private Sub btnAdhocInfo_Click(sender As Object, e As EventArgs) Handles btnAdhocInfo.Click
        Me.Close()
        PrintRPT_Employee_AdhocInformation()
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

    Private Sub btnEmployeeJobPosition_Click(sender As Object, e As EventArgs) Handles btnEmployeeJobPosition.Click
        Me.Close()
        frmHRIS_Report_JobPosition.ShowDialog()
    End Sub

    Private Sub btnLeaveEncashment_Click(sender As Object, e As EventArgs) Handles btnLeaveEncashment.Click
        Me.Close()
        PrintRPT_Employee_LeaveEncashment()
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

    Private Sub btnLeaveBalances_Click(sender As Object, e As EventArgs) Handles btnLeaveBalances.Click
        Me.Close()
        PrintRPT_Employee_LeaveBalances()
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

    Private Sub btnEmployeeBirthdate_Click(sender As Object, e As EventArgs) Handles btnEmployeeBirthdate.Click
        Me.Close()
        PrintRPT_Employee_Birthdates()
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

    Private Sub btn201File_Click(sender As Object, e As EventArgs) Handles btn201File.Click
        Me.Close()
        frmHRIS_Report_EmployeeList.WhatReportType = 1
        frmHRIS_Report_EmployeeList.ShowDialog()
    End Sub

    Private Sub btnCurrentWithCompensationItemizedWithGap_Click(sender As Object, e As EventArgs) Handles btnCurrentWithCompensationItemizedWithGap.Click
        MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: Not yet working.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btn201CheckList_Click(sender As Object, e As EventArgs) Handles btn201CheckList.Click
        Me.Close()
        frmHRIS_Report_EmployeeList.WhatReportType = 2
        frmHRIS_Report_EmployeeList.ShowDialog()
    End Sub
End Class