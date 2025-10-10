Public Class frmMainPanelHRMDetail

    Private Sub btnHumanResource_Click(sender As Object, e As EventArgs) Handles btnHumanResource.Click
        If HasSubMenuAccess(btnHumanResource) Then
            SetButtonColor(btnHumanResource) 'set btn color to gainsboro if recently clicked
            OpenChildForm_Revision(frmHRIS_Transaction_EmployeeFile)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCertificateOfEmployment_Click(sender As Object, e As EventArgs) Handles btnCertificateOfEmployment.Click
        'showSubMenu(New CertificateOfEmploymentSubMenu(), btnCertificateOfEmployment)
        SetButtonColor(btnCertificateOfEmployment)
        OpenChildForm_Revision(frmHRIS_Report_COE_PreviewList)
    End Sub

    Private Sub btnShift_Click(sender As Object, e As EventArgs) Handles btnShift.Click
        If HasSubMenuAccess(btnShift) Then
            SetButtonColor(btnShift)
            OpenChildForm_Revision(frmHRIS_Setup_Shift)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSchedManagement_Click(sender As Object, e As EventArgs) Handles btnSchedManagement.Click
        If HasSubMenuAccess(btnSchedManagement) Then
            SetButtonColor(btnSchedManagement)
            OpenChildForm_Revision(frmHRIS_Transaction_AssignEmployeeSchedule)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPerformanceManagement_Click(sender As Object, e As EventArgs) Handles btnPerformanceManagement.Click
        If HasSubMenuAccess(btnSchedManagement) Then
            SetButtonColor(btnPerformanceManagement)
            ShowSubMenu(New PerformanceManagementSubMenu(), btnPerformanceManagement)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBenefitAdmin_Click(sender As Object, e As EventArgs) Handles btnBenefitAdmin.Click

    End Sub

    Private Sub btnTrainingManagement_Click(sender As Object, e As EventArgs) Handles btnTrainingManagement.Click
        If HasSubMenuAccess(btnTrainingManagement) Then
            SetButtonColor(btnTrainingManagement)
            If String.Equals(frmMain.ToolStripAccessRights.Text, "MASTER", StringComparison.OrdinalIgnoreCase) Then
                ShowSubMenu(New TrainingManagementSubMenu_Master(), btnTrainingManagement)
            Else
                ShowSubMenu(New TrainingManagementSubMenu_Indiv(), btnTrainingManagement)
            End If
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        SetButtonColor(btnEmployee)
        ShowSubMenu(New HumanResourceReportSubMenu_Employee(), btnEmployee)
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        If HasSubMenuAccess(btnDepartment) Then
            SetButtonColor(btnDepartment)
            OpenChildForm_Revision(frmHRIS_Setup_Department)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCompany_Click(sender As Object, e As EventArgs) Handles btnCompany.Click
        If HasSubMenuAccess(btnCompany) Then
            SetButtonColor(btnCompany)
            frmHRIS_Setup_Company.ToolStripLabel1.Text = "Human Resource Module > Setup > Company"
            OpenChildForm_Revision(frmHRIS_Setup_Company)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnJobtitle_Click(sender As Object, e As EventArgs) Handles btnJobtitle.Click
        If HasSubMenuAccess(btnJobtitle) Then
            SetButtonColor(btnJobtitle)
            OpenChildForm_Revision(frmHRIS_Setup_JobTitle)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnLeaveType_Click(sender As Object, e As EventArgs) Handles btnLeaveType.Click
        If HasSubMenuAccess(btnLeaveType) Then
            SetButtonColor(btnLeaveType)
            OpenChildForm_Revision(frmHRIS_Setup_LeaveType)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnLeaveCredit_Click(sender As Object, e As EventArgs) Handles btnLeaveCredit.Click
        If HasSubMenuAccess(btnLeaveCredit) Then
            SetButtonColor(btnLeaveCredit)
            OpenChildForm_Revision(frmHRIS_Setup_LeaveCredit)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnApprovalHierarchy_Click(sender As Object, e As EventArgs) Handles btnApprovalHierarchy.Click
        If HasSubMenuAccess(btnApprovalHierarchy) Then
            SetButtonColor(btnApprovalHierarchy)
            OpenChildForm_Revision(frmHRIS_Setup_ApprovalHierarchy)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCompanyReport_Click(sender As Object, e As EventArgs) Handles btnCompanyReport.Click
        If HasSubMenuAccess(btnCompanyReport) Then
            SetButtonColor(btnCompanyReport)
            PrintRPT_Company_List()
            OpenChildForm_Revision(frmHRIS_Report_MainPreview)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDepartmentReport_Click(sender As Object, e As EventArgs) Handles btnDepartmentReport.Click
        If HasSubMenuAccess(btnDepartmentReport) Then
            SetButtonColor(btnDepartmentReport)
            PrintRPT_Department_List()
            OpenChildForm_Revision(frmHRIS_Report_MainPreview)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnTrainingReport_Click(sender As Object, e As EventArgs) Handles btnTrainingReport.Click
        If HasSubMenuAccess(btnTrainingReport) Then
            SetButtonColor(btnTrainingReport)
            PrintRPT_Training_List()
            OpenChildForm_Revision(frmHRIS_Report_MainPreview)
        Else
            MessageBox.Show("Access denied. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class