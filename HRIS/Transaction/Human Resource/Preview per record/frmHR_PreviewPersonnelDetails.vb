Imports System.Windows.Forms

Public Class frmHR_PreviewPersonnelDetails

    Dim tooltip As New ToolTip()

    Private Sub frmHR_PreviewPersonnelDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBoxProfilePic.Focus()
        switchPanel(frmHR_PreviewPersonnelDetails_PersonalInformation)
        Call GetImageProfile(PictureBoxProfilePic)
        ''\\ Hide Update buttons, Only visible when 'Edit profile' Click.
        Function_btnUpdates_Hide()
        ''\\ List of textboxes that set to Read only.
        frmHR_PreviewPersonnelDetails_PersonalInformation.Function_ReadOnly_isTrue()
        ''\\ set color of employee status.
        lblEmpStatus.ForeColor = If(lblEmpStatus.Text = "Inactive", Color.Red, Color.Green)
        isEdit = False

        Dim isActive As Boolean = (lblEmpStatus.Text <> "Inactive")
        btnSetInactive.Enabled = isActive
        btnEdit.Enabled = isActive
    End Sub


    Public Sub Function_btnUpdates_Hide()
        btnSave.Visible = False
        btnDiscard.Visible = False
        btnPrintContract.Visible = True
        btnExport.Visible = True
    End Sub

    Public Sub Function_btnUpdates_Show()
        ' Name : Dela Pena, Jerome [2024-1435]
        ' Date Created : 02-24-25

        btnSave.Visible = True
        btnDiscard.Visible = True
        btnPrintContract.Visible = False
        btnExport.Visible = False
    End Sub

    Public Sub switchPanel(ByVal panel As Form)
        If btnSave.Visible AndAlso btnDiscard.Visible Then
            Function_btnUpdates_Hide()
        End If

        PanelHolder.Controls.Clear()
        panel.TopLevel = False
        PanelTagID = panel.Tag
        PanelHolder.Controls.Add(panel)
        panel.Show()

        ' Manually trigger the Load event
        Dim loadEvent As New EventArgs()
        Dim loadMethod = panel.GetType().GetMethod("OnLoad", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        If loadMethod IsNot Nothing Then
            loadMethod.Invoke(panel, New Object() {loadEvent})
        End If
    End Sub

    Public Sub Function_Set_All_Other_Form_to_ReadOnly()
        'this function will make other text buttons from form that is currently not showing or inactive when being switched
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If PanelTagID = 101 Then
            '\\  Personnel Information Tab
            Call InsUpd_PersonnelDetails()
            Call InsUpd_PersonnelDetails_Address()
            Call InsUpd_ForeignAddress()
            Call InsUpd_Personnel_Identification()
            Call ProcessDataGridViewParentsAndSiblings(frmHR_PreviewPersonnelDetails_PersonalInformation.dgvParentsAndSiblings)
            Call ProcessDataGridViewSpouseAndChildren(frmHR_PreviewPersonnelDetails_PersonalInformation.dgvSpouseAndChildren)
            'this will update the dgv in personal information --> family background to align id
            Call SelUpd_FamilyBackground(frmHR_PreviewPersonnelDetails_PersonalInformation.dgvParentsAndSiblings, frmHR_PreviewPersonnelDetails_PersonalInformation.dgvSpouseAndChildren)

        ElseIf PanelTagID = 102 Then
            ProcessDataGridViewContractHistory(frmHR_UpdatePersonnelDetails_Contracts.dgvContracts)
        ElseIf PanelTagID = 103 Then
            ProcessDataGridViewCharacterReference(frmHR_UpdatePersonnelDetails_CharacterReference.dgvCharRef)
        ElseIf PanelTagID = 104 Then
            ProcessDataGridViewEducationBackground(frmHR_UpdatePersonnelDetails_EducationBackground.dgvEducationBackground)
        ElseIf PanelTagID = 105 Then
            ProcessDataGridViewResume(frmHR_UpdatePersonnelDetails_Resume.dgvResume)
        ElseIf PanelTagID = 108 Then
            ProcessDataGridViewEmploymentHistory(frmHR_UpdatePersonnelDetails_EmploymentHistory.dgvEmploymentHistory)
        ElseIf PanelTagID = 109 Then
            ProcessDataGridView201Checklist(frmHR_UpdatePersonnelDetails_201FileChecklist.dgv201CheckList)
        ElseIf PanelTagID = 111 Then
            ProcessDataGridViewPerformanceAppraisal(frmHR_UpdatePersonnelDetails_PerformanceAppraisal.dgvPerformanceAppraisal)
        Else
            MessageBox.Show("Unexpected Error Occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        '\\  Button Edit
        Call FunctionBtnEdit_Enable()
    End Sub

    Private Sub btnPersonalInformation_Click(sender As Object, e As EventArgs) Handles btnPersonalInformation.Click
        switchPanel(frmHR_PreviewPersonnelDetails_PersonalInformation)
    End Sub

    Private Sub btnEducBack_Click(sender As Object, e As EventArgs) Handles btnEducBack.Click
        switchPanel(frmHR_PreviewPersonnelDetails_EducationBackground)
    End Sub

    Private Sub btnEmployementHistory_Click(sender As Object, e As EventArgs) Handles btnEmployementHistory.Click
        switchPanel(frmHR_PreviewPersonnelDetails_EmploymentHistory)
    End Sub

    Private Sub btnCharRef_Click(sender As Object, e As EventArgs) Handles btnCharRef.Click
        switchPanel(frmHR_PreviewPersonnelDetails_CharacterReference)
    End Sub

    Private Sub btnContracts_Click(sender As Object, e As EventArgs) Handles btnContracts.Click
        switchPanel(frmHR_PreviewPersonnelDetails_Contracts)
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        switchPanel(frmHR_PreviewPersonnelDetails_Resume)
    End Sub

    Private Sub btnTrainingHistory_Click(sender As Object, e As EventArgs) Handles btnTrainingHistory.Click
        switchPanel(frmHR_PreviewPersonnelDetails_TrainingHistory)
    End Sub

    Private Sub btnCheckList_Click(sender As Object, e As EventArgs) Handles btnCheckList.Click
        switchPanel(frmHR_PreviewPersonnelDetails_201FileChecklist)
    End Sub

    Private Sub btnPerformanceAppraisal_Click(sender As Object, e As EventArgs) Handles btnPerformanceAppraisal.Click
        switchPanel(frmHR_PreviewPersonnelDetails_PerformanceAppraisal)
    End Sub

    Private Sub frmHR_PreviewPersonnelDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Close()

        'Personal Information Fields
        ResetAllControlInForm(Me)

        'Education Background Fields
        ResetAllControlInForm(frmHR_PreviewPersonnelDetails_EducationBackground)
        ResetAllControlInForm(frmHR_UpdatePersonnelDetails_EducationBackground)

        'Character References
        ResetAllControlInForm(frmHR_UpdatePersonnelDetails_CharacterReference)
        ResetAllControlInForm(frmHR_PreviewPersonnelDetails_CharacterReference)

        'Contract Fields
        ResetAllControlInForm(frmHR_PreviewPersonnelDetails_Contracts)
        ResetAllControlInForm(frmHR_UpdatePersonnelDetails_Contracts)
    End Sub

    Private Sub btnSetInactive_Click(sender As Object, e As EventArgs) Handles btnSetInactive.Click

        If MessageBox.Show("Are you sure you want to set this Employee to inactive? This action is cannot be undone.", "Critical Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Call Upd_EmployeeStatus_To_Inactive()
        End If

    End Sub

    Private Sub PictureBoxProfilePic_Click(sender As Object, e As EventArgs) Handles PictureBoxProfilePic.Click
        If Not isEdit Then
            Return
        End If
        BrowseProfilePic(PictureBoxProfilePic)
    End Sub

    Private Sub PictureBoxHelp_Click(sender As Object, e As EventArgs) Handles PictureBoxHelp.Click, PictureBoxHelp.MouseHover
        tooltip.SetToolTip(PictureBoxHelp, "Thank you for not calling DIMS! <3")
    End Sub

End Class
