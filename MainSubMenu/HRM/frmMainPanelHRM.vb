Public Class frmMainPanelHRM

    Private Sub frmMainPanelHRM_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        If HasMenuAccess(btnSetup) Then
            SubMenuLoadAccess(btnSetup)
            For Each btn In {frmMainPanelHRMDetail.btnCompany, frmMainPanelHRMDetail.btnDepartment, frmMainPanelHRMDetail.btnJobtitle,
                frmMainPanelHRMDetail.btnApprovalHierarchy, frmMainPanelHRMDetail.btnShift, frmMainPanelHRMDetail.btnLeaveCredit,
                frmMainPanelHRMDetail.btnLeaveType}
                btn.Visible = SubMenuAccessList.Contains(btn.Tag?.ToString())
            Next
            SetButtonColor(btnSetup)
            frmMain.switchPanelHolder(frmMainPanelHRMDetail.panelSubHRIS_SetupDetails)
        Else
            Return
        End If
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        If HasMenuAccess(btnTransaction) Then
            SubMenuLoadAccess(btnTransaction)
            For Each btn In {frmMainPanelHRMDetail.btnHumanResource, frmMainPanelHRMDetail.btnSchedManagement,
                frmMainPanelHRMDetail.btnTrainingManagement, frmMainPanelHRMDetail.btnBenefitAdmin, frmMainPanelHRMDetail.btnPerformanceManagement}
                btn.Visible = SubMenuAccessList.Contains(btn.Tag?.ToString())
            Next
            SetButtonColor(btnTransaction)
            frmMain.switchPanelHolder(frmMainPanelHRMDetail.panelSubHRIS_TransactionDetails)
        Else
            Return
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If HasMenuAccess(btnReport) Then
            SubMenuLoadAccess(btnReport)
            For Each btn In {frmMainPanelHRMDetail.btnEmployee, frmMainPanelHRMDetail.btnCompanyReport,
                frmMainPanelHRMDetail.btnDepartmentReport, frmMainPanelHRMDetail.btnCertificateOfEmployment, frmMainPanelHRMDetail.btnTrainingReport}
                btn.Visible = SubMenuAccessList.Contains(btn.Tag?.ToString())
            Next
            SetButtonColor(btnReport)
            frmMain.switchPanelHolder(frmMainPanelHRMDetail.panelSubHRIS_Reports)
        Else
            Return
        End If
    End Sub

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        If HasMenuAccess(btnOption) Then
            SubMenuLoadAccess(btnOption)
            SetButtonColor(btnOption)
            OpenChildForm_Revision(frmHRIS_Options_MainView)
        Else
            Return
        End If
    End Sub

End Class