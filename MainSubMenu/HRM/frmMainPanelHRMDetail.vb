Public Class frmMainPanelHRMDetail
    Private Sub btnHumanResource_Click(sender As Object, e As EventArgs) Handles btnHumanResource.Click
        OpenChildForm_Revision(frmHRIS_Transaction_EmployeeFile)
    End Sub

    Private Sub btnCertificateOfEmployment_Click(sender As Object, e As EventArgs) Handles btnCertificateOfEmployment.Click
        'showSubMenu(New CertificateOfEmploymentSubMenu(), btnCertificateOfEmployment)
        OpenChildForm_Revision(frmHRIS_Report_COE_PreviewList)
    End Sub

    Private Sub btnShift_Click(sender As Object, e As EventArgs) Handles btnShift.Click
        OpenChildForm_Revision(frmHRIS_Setup_Shift)
    End Sub

    Private Sub btnSchedManagement_Click(sender As Object, e As EventArgs) Handles btnSchedManagement.Click
        OpenChildForm_Revision(frmHRIS_Transaction_AssignEmployeeSchedule)
    End Sub

    Private Sub btnPerformanceManagement_Click(sender As Object, e As EventArgs) Handles btnPerformanceManagement.Click
        ShowSubMenu(New PerformanceManagementSubMenu(), btnPerformanceManagement)
    End Sub

    Private Sub btnBenefitAdmin_Click(sender As Object, e As EventArgs) Handles btnBenefitAdmin.Click

    End Sub

    Private Sub btnTrainingManagement_Click(sender As Object, e As EventArgs) Handles btnTrainingManagement.Click

        If frmMain.ToolStripAccessRights.Text = "Master" Then
            ShowSubMenu(New TrainingManagementSubMenu_Master(), btnTrainingManagement)
        Else
            ShowSubMenu(New TrainingManagementSubMenu_Indiv(), btnTrainingManagement)
        End If

    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        ShowSubMenu(New HumanResourceReportSubMenu_Employee(), btnEmployee)
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        OpenChildForm_Revision(frmHRIS_Setup_Department)
    End Sub

    Private Sub btnCompany_Click(sender As Object, e As EventArgs) Handles btnCompany.Click
        OpenChildForm_Revision(frmHRIS_Setup_Company)
    End Sub

    Private Sub btnJobtitle_Click(sender As Object, e As EventArgs) Handles btnJobtitle.Click
        OpenChildForm_Revision(frmHRIS_Setup_JobTitle)
    End Sub

    Private Sub btnLeaveType_Click(sender As Object, e As EventArgs) Handles btnLeaveType.Click
        OpenChildForm_Revision(frmHRIS_Setup_LeaveType)
    End Sub

    Private Sub btnLeaveCredit_Click(sender As Object, e As EventArgs) Handles btnLeaveCredit.Click
        OpenChildForm_Revision(frmHRIS_Setup_LeaveCredit)
    End Sub

    Private Sub btnApprovalHierarchy_Click(sender As Object, e As EventArgs) Handles btnApprovalHierarchy.Click
        OpenChildForm_Revision(frmHRIS_Setup_ApprovalHierarchy)
    End Sub

    Private Sub btnCompanyReport_Click(sender As Object, e As EventArgs) Handles btnCompanyReport.Click
        PrintRPT_Company_List()
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

    Private Sub btnDepartmentReport_Click(sender As Object, e As EventArgs) Handles btnDepartmentReport.Click
        PrintRPT_Department_List()
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

    Private Sub btnTrainingReport_Click(sender As Object, e As EventArgs) Handles btnTrainingReport.Click
        PrintRPT_Training_List()
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

End Class