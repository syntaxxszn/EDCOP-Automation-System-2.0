Imports System.IO
Public Class frmMain

    Private Sub frmMain_revise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Bounds = Screen.GetWorkingArea(Me)
        WindowState = FormWindowState.Maximized
        'OpenChildForm_Revision(frmHRIS_Setup_Company)

        Dim imageFileName1 = Path.Combine("\\192.168.0.250\references\DIMS_APPS_INST\Image Announcement\Test Images", "PTO.png")
        picBoxNotif1.Image = Image.FromFile(imageFileName1)
        picBoxNotif1.SizeMode = PictureBoxSizeMode.StretchImage

        Dim imageFileName2 = Path.Combine("\\192.168.0.250\references\DIMS_APPS_INST\Image Announcement\Test Images", "May 12 Holiday.png")
        picBoxNotif2.Image = Image.FromFile(imageFileName2)
        picBoxNotif2.SizeMode = PictureBoxSizeMode.StretchImage

        'lblWelcomeName.Text = "Welcome, " & ToolStripEmployeeName.Text


    End Sub

    Public Sub CustomDesign()

        ' <> Panel for Module only.
        panelSubHRM.Visible = False
        panelSubFMM.Visible = False
        panelSubPMM.Visible = False
        panelSubTKM.Visible = False
        panelSubBDM.Visible = False
        panelSubTL.Visible = False
        panelSubSSS.Visible = False
        panelSubCU.Visible = False
        panelSubAU.Visible = False
        '</>

    End Sub

    Public Sub HideModuleButtons()

        btnHRM.Visible = False
        btnFMM.Visible = False
        btnPMM.Visible = False
        btnTKM.Visible = False
        btnBDM.Visible = False
        btnSSS.Visible = False

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
        If panelSubSSS.Visible = True Then
            panelSubSSS.Visible = False
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

        If panel Is frmMainPanelFMMDetail.panelSubFMM_NewReportsDetails OrElse panel Is frmMainPanelFMMDetail.panelSubFMM_LedgerReportsDetails OrElse panel Is frmMainPanelFMMDetail.panelSubFMM_SetupDetails Then
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
        panelSubHRM.Size = New Size(284, 160)
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

    Private Sub switchPanelTKM(ByVal panel As Panel)
        Dim originalLocation As Point = panelSubTKM.Location
        panelSubTKM.Size = New Size(284, 160)
        panelSubTKM.Controls.Clear()
        panel.Dock = DockStyle.Fill
        panelSubTKM.Controls.Add(panel)
        panel.Location = originalLocation
        panel.BringToFront()
    End Sub

    Private Sub switchPanelSSS(ByVal panel As Panel)
        Dim originalLocation As Point = panelSubSSS.Location
        panelSubSSS.Size = New Size(284, 90)
        panelSubSSS.Controls.Clear()
        panel.Dock = DockStyle.Fill
        panelSubSSS.Controls.Add(panel)
        panel.Location = originalLocation
        panel.BringToFront()
    End Sub

    Private Sub btnHRM_Click(sender As Object, e As EventArgs) Handles btnHRM.Click
        Call MenuLoadAccess(btnHRM) 'this will load the access of logged-in user

        For Each btn In {frmMainPanelHRM.btnSetup, frmMainPanelHRM.btnTransaction, frmMainPanelHRM.btnReport, frmMainPanelHRM.btnOption}
            btn.Enabled = MenuAccessList.Contains(btn.Tag?.ToString())
        Next 'this will enable = false depedining on access

        'If Not isHRISAcess Then
        '    MessageBox.Show("Oooppsss..." & vbNewLine & "" & vbNewLine & "You don't have previledge to access this module. Contact System Administrator if this is a mistake.", "EAS 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End If

        ShowSubMenu(panelSubHRM)
        switchPanelHRM(frmMainPanelHRM.PanelHRM)
        'frmMainPanelHRM.btnSetup.PerformClick()

    End Sub

    Private Sub btnFMM_Click(sender As Object, e As EventArgs) Handles btnFMM.Click
        Call MenuLoadAccess(btnFMM) 'this will load the access of logged in user

        For Each btn In {frmMainPanelFMM.btnSetup, frmMainPanelFMM.btnProjectStatus, frmMainPanelFMM.btnBudgetManagement, frmMainPanelFMM.btnPettyCash,
            frmMainPanelFMM.btnCashAdvance, frmMainPanelFMM.btnCashLedger, frmMainPanelFMM.btnSalesJournal, frmMainPanelFMM.btnGeneralJournal,
            frmMainPanelFMM.btnFinancialStatement, frmMainPanelFMM.btnLedgerReports, frmMainPanelFMM.btnNewReports, frmMainPanelFMM.btnOtherReports,
            frmMainPanelFMM.btnBankRecon, frmMainPanelFMM.btnIHBM, frmMainPanelFMM.btnCashFlow, frmMainPanelFMM.btnOptions}
            btn.Enabled = MenuAccessList.Contains(btn.Tag?.ToString())
        Next 'this will enable = false depedining on access

        ShowSubMenu(panelSubFMM)
        switchPanelFMM(frmMainPanelFMM.PanelFMM)
        'frmMainPanelFMM.btnSetup.PerformClick()
    End Sub

    Private Sub btnPMM_Click(sender As Object, e As EventArgs) Handles btnPMM.Click
        ShowSubMenu(panelSubPMM)
        switchPanelPMM(frmMainPanelPMM.PanelPMM)
    End Sub

    Private Sub btnTKM_Click(sender As Object, e As EventArgs) Handles btnTKM.Click
        ShowSubMenu(panelSubTKM)
        switchPanelTKM(frmMainPanelTKM.PanelTKM)
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            CustomDesign()
            HideModuleButtons()
            _AllowInsert = False
            _AllowUpdate = False
            _AllowDelete = False
            _AllowView = False
            _AllowPrint = False
            _AllowPost = False
            MenuAccessList.Clear()
            SubMenuAccessList.Clear()
            Call CloseAllForms_isClosed() 'to close all forms
            e.Cancel = True  ' Cancel the close
            Me.Hide()        ' Just hide the form instead
            frmPMS_Login.Show()
        End If

    End Sub

    Private Sub btnSSS_Click(sender As Object, e As EventArgs) Handles btnSSS.Click
        ShowSubMenu(panelSubSSS)
        switchPanelSSS(frmMainPanelSSM.PanelSSS)
    End Sub


End Class