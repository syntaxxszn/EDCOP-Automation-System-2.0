Public Class frmMain

    'Private MouseIsDown As Boolean = False
    'Private MouseIsDownLoc As Point = Nothing

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.Bounds = Screen.GetWorkingArea(Me)
        'Me.fullsc
        OpenChildForm(frmHR_Transaction_EmployeeFile)
        ' OpenChildForm(frmAccounting_RevolvingFund_Client)
        ' OpenChildForm(frmAccounting_SummaryOfRP_Main)
        'Select_ActivityLog()
        CustomDesign()

    End Sub

    Private Sub CustomDesign()

        panelPMM.Visible = False
        panelHRIS.Visible = False
        PanelFMM.Visible = False
        PanelTrailLog.Visible = False
        SubPanel_RF.Visible = False
        SubPanel_HRIS_Trans.Visible = False
        SubPanel_HRIS_Report.Visible = False


        btnHRIS_Trans_HumRes_EmpFile.Visible = False
        btnHRIS_Trans_SchedManage_SchedAssign.Visible = False

        btnHRIS_Trans_TrainManage_Enroll.Visible = False
        btnHRIS_Trans_TrainManage_Feedback.Visible = False
        btnHRIS_Trans_TrainManage_Request.Visible = False

        btnHRIS_Trans_PerformanceManage_PMAS.Visible = False

    End Sub

    Private Sub HideSubMenu()

        If panelPMM.Visible = True Then
            panelPMM.Visible = False
        End If
        If panelHRIS.Visible = True Then
            panelHRIS.Visible = False
        End If
        If PanelFMM.Visible = True Then
            PanelFMM.Visible = False
        End If
        If PanelTrailLog.Visible = True Then
            PanelTrailLog.Visible = False
        End If

    End Sub

    Private Sub ShowSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            HideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Private Sub btnHumanResourceModule_Click(sender As Object, e As EventArgs) Handles btnHumanResourceModule.Click
        ShowSubMenu(panelHRIS)
    End Sub


    Private Sub btnHRIS_Setup_Click(sender As Object, e As EventArgs) Handles btnHRIS_Setup.Click
        ' ShowSubMenu2(SubPanel_HRIS_Setup)

        OpenChildForm(frmHR_SetupMain)
    End Sub

    Private Sub HideButton()

        If btnHRIS_Trans_HumRes_EmpFile.Visible = True Then
            btnHRIS_Trans_HumRes_EmpFile.Visible = False
        End If

        If btnHRIS_Trans_SchedManage_SchedAssign.Visible = True Then
            btnHRIS_Trans_SchedManage_SchedAssign.Visible = False
        End If

        If btnHRIS_Trans_PerformanceManage_PMAS.Visible = True Then
            btnHRIS_Trans_PerformanceManage_PMAS.Visible = False
        End If

    End Sub

    Private Sub HideButtons()

        '\\ Hide more than 1 Button.
        btnHRIS_Trans_TrainManage_Enroll.Visible = False
        btnHRIS_Trans_TrainManage_Feedback.Visible = False
        btnHRIS_Trans_TrainManage_Request.Visible = False

    End Sub

    Private Sub ShowSubButton(subButton As Button, subPanel As Panel, subPanelOpenHeight As Integer, subPanelCloseHeight As Integer)

        If subButton.Visible = False Then
            HideButton()
            subButton.Visible = True
            subPanel.Height = subPanelOpenHeight
        Else
            subButton.Visible = False
            subPanel.Height = subPanelCloseHeight
        End If

    End Sub

    Private Sub btnHRIS_Trans_HumRes_Click(sender As Object, e As EventArgs) Handles btnHRIS_Trans_HumRes.Click
        ShowSubButton(btnHRIS_Trans_HumRes_EmpFile, SubPanel_HRIS_Trans, 170, 140)
        HideButtons()
    End Sub

    Private Sub btnHRIS_Trans_SchedManage_Click(sender As Object, e As EventArgs) Handles btnHRIS_Trans_SchedManage.Click
        ShowSubButton(btnHRIS_Trans_SchedManage_SchedAssign, SubPanel_HRIS_Trans, 170, 140)
        HideButtons()
    End Sub

    Private Sub btnHRIS_Trans_TrainManage_Click(sender As Object, e As EventArgs) Handles btnHRIS_Trans_TrainManage.Click

        ShowSubButton(btnHRIS_Trans_TrainManage_Enroll, SubPanel_HRIS_Trans, 224, 140)
        ShowSubButton(btnHRIS_Trans_TrainManage_Feedback, SubPanel_HRIS_Trans, 224, 140)
        ShowSubButton(btnHRIS_Trans_TrainManage_Request, SubPanel_HRIS_Trans, 224, 140)

    End Sub

    Private Sub btnHRIS_Trans_PerformanceManage_Click(sender As Object, e As EventArgs) Handles btnHRIS_Trans_PerformanceManage.Click
        ShowSubButton(btnHRIS_Trans_PerformanceManage_PMAS, SubPanel_HRIS_Trans, 170, 140)
        HideButtons()
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Dispose()
    End Sub

    Private Sub btnHRIS_Trans_HumRes_EmpFile_Click(sender As Object, e As EventArgs) Handles btnHRIS_Trans_HumRes_EmpFile.Click
        OpenChildForm(frmHR_Transaction_EmployeeFile)
    End Sub

    Private Sub btnHRIS_Setup_Department_Click(sender As Object, e As EventArgs)
        OpenChildForm(frmHR_Setup_Department)
    End Sub

    Private Sub btnHRIS_Setup_Shift_Click(sender As Object, e As EventArgs)
        OpenChildForm(frmHR_Setup_Shift)
    End Sub


    Private Sub btnHRIS_Setup_LeaveType_Click(sender As Object, e As EventArgs)
        OpenChildForm(frmHR_Setup_LeaveType)
    End Sub


    Private Sub btnHRIS_Setup_LeaveCredit_Click(sender As Object, e As EventArgs)
        OpenChildForm(frmHR_Setup_LeaveCredit)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub btnTimeSheetPreparation_Click(sender As Object, e As EventArgs) Handles btnTimeSheetPreparation.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
