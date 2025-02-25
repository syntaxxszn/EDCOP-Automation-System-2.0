Public Class frmMain_revise

    Private Sub frmMain_revise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Bounds = Screen.GetWorkingArea(Me)
        CustomDesign()
        'OpenChildForm_Revision(frmHR_Transaction_EmployeeFile)
    End Sub

    Private Sub CustomDesign()

        ' <> Panel for Human Resource Module only.
        panelSubHRM.Visible = False

        'panelSubHRIS_SetupDetails.Visible = False
        'panelSubHRIS_TransactionDetails.Visible = False
        'panelSubHRIS_Reports.Visible = False

        ' </>

        ' <> Panel for Finance Management Module only.
        panelSubFMM.Visible = False
        panelSubPMM.Visible = False
        panelSubTKM.Visible = False
        panelSubBDM.Visible = False
        panelSubTL.Visible = False
        panelSubSS.Visible = False
        panelSubCU.Visible = False
        panelSubAU.Visible = False
        '</>

    End Sub

    Private Sub HideSubMenu()
        ' This Code handle the hiding of Panel. Combined to ShowSubMenu.
        If panelSubHRM.Visible = True Then
            panelSubHRM.Visible = False
        End If
        If panelSubFMM.Visible = True Then
            panelSubFMM.Visible = False
        End If
        If panelSubPMM.Visible = True Then
            panelSubPMM.Visible = False
        End If
        If panelSubTKM.Visible = True Then
            panelSubTKM.Visible = False
        End If
        If panelSubBDM.Visible = True Then
            panelSubBDM.Visible = False
        End If
        If panelSubTL.Visible = True Then
            panelSubTL.Visible = False
        End If
        If panelSubSS.Visible = True Then
            panelSubSS.Visible = False
        End If
        If panelSubCU.Visible = True Then
            panelSubCU.Visible = False
        End If
        If panelSubAU.Visible = True Then
            panelSubAU.Visible = False
        End If
        PanelHolder.Controls.Clear()
    End Sub

    Private Sub ShowSubMenu(subMenu As Panel)

        '\\ This Code handle the Main Button Menu for Menu like Human Resource Modul btn.

        If subMenu.Visible = False Then
            HideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If

    End Sub

    Public Sub switchPanelHolder(ByVal panel As Panel)
        Dim originalLocation As Point = PanelHolder.Location ' Store original location of holder
        PanelHolder.Controls.Clear()

        If panel Is frmMainPanelFMMDetail.panelSubFMM_NewReportsDetails OrElse panel Is frmMainPanelFMMDetail.panelSubFMM_LedgerReportsDetails Then
            PanelHolder.AutoScroll = True
        Else
            PanelHolder.AutoScroll = False
        End If

        panel.Dock = DockStyle.None ' Prevent automatic resizing
        PanelHolder.Controls.Add(panel)
        panel.Location = originalLocation ' Restore original location
        panel.BringToFront()
    End Sub

    Private Sub switchPanelFMM(ByVal panel As Panel)
        Dim originalLocation As Point = panelSubFMM.Location
        panelSubFMM.Size = New Size(284, 300)
        panelSubFMM.Controls.Clear()
        panel.Dock = DockStyle.Fill
        panelSubFMM.Controls.Add(panel)
        panel.Location = originalLocation
        panel.BringToFront()
    End Sub

    Private Sub switchPanelHRM(ByVal panel As Panel)
        Dim originalLocation As Point = panelSubHRM.Location
        panelSubHRM.Size = New Size(284, 200)
        panelSubHRM.Controls.Clear()
        panel.Dock = DockStyle.Fill
        panelSubHRM.Controls.Add(panel)
        panel.Location = originalLocation
        panel.BringToFront()
    End Sub

    Private Sub switchPanelPMM(ByVal panel As Panel)
        Dim originalLocation As Point = panelSubPMM.Location
        panelSubPMM.Size = New Size(284, 50)
        panelSubPMM.Controls.Clear()
        panel.Dock = DockStyle.Fill
        panelSubPMM.Controls.Add(panel)
        panel.Location = originalLocation
        panel.BringToFront()
    End Sub

    Private Sub btnHRM_Click(sender As Object, e As EventArgs) Handles btnHRM.Click
        ShowSubMenu(panelSubHRM)
        switchPanelHRM(frmMainPanelHRM.PanelHRM)
        'frmMainPanelHRM.btnSetup.PerformClick()
    End Sub

    Private Sub btnFMM_Click_1(sender As Object, e As EventArgs) Handles btnFMM.Click
        ShowSubMenu(panelSubFMM)
        switchPanelFMM(frmMainPanelFMM.PanelFMM)
        'frmMainPanelFMM.btnSetup.PerformClick()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnPMM.Click
        ShowSubMenu(panelSubPMM)
        switchPanelPMM(frmMainPanelPMM.PanelPMM)
    End Sub
End Class