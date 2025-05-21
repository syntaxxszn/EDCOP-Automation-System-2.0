Imports System.ComponentModel

Public Class frmHRIS_Transaction_SearchFilter

    Public EmployeeStatusID As Nullable(Of Integer)
    Public isEmployeeID As Nullable(Of Integer)
    Public isTechnicalID As Nullable(Of Integer)
    Public EmployeeSubStatus1ID As New List(Of Integer)
    Public EmployeeSubStatus2ID As New List(Of Integer)
    Public EmployeeClassGroupID As New List(Of Integer)
    Public EmployeeJobPositionID As New List(Of String)
    Public EmployeeJobPositionRawString As New List(Of String)
    Public EmployeeJobPositionCombinedString As New List(Of String)
    Public EmployeeDepartmentID As New List(Of Integer)
    Private WithEvents hideTimer As New Timer()

    Private Sub frmHR_Transaction_SearchFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Store button number in list when button is enabled and is backcolor = gold
        disableJobPosConsultant()
        hideTimer.Interval = 5 * 60 * 1000 ' 5 minutes in milliseconds
    End Sub

    Private Sub disableJobPosConsultant()
        For Each btn As Button In {btnJobPosConsultantPB, btnJobPosConsultantLS, btnJobPosConsultantFT}
            btn.Enabled = False
            btn.BackColor = Color.Gainsboro
        Next
    End Sub

    Private Sub Status_201(sender As Object, e As EventArgs) Handles btnActive.Click, btnInactive.Click
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)
        If btn Is btnActive Then btnInactive.BackColor = Color.White Else btnActive.BackColor = Color.White

        EmployeeStatusID = If(btnActive.BackColor = Color.Gold, 0, If(btnInactive.BackColor = Color.Gold, 1, CType(Nothing, Integer?)))
    End Sub

    Private Sub EmployeeStatus(sender As Object, e As EventArgs) Handles btnConsultant.Click, btnEmployee.Click
        Dim btn As Button = DirectCast(sender, Button)

        Dim isSelected As Boolean = (btn.BackColor = Color.Gold)

        ' Toggle selection, but do not reset immediately
        btn.BackColor = If(isSelected, Color.White, Color.Gold)

        ' If button was deselected (turning white), then reset everything
        If isSelected Then
            For Each ctrl As Control In PanelEmployeeFilter.Controls
                If TypeOf ctrl Is Button AndAlso ctrl IsNot btn Then
                    DirectCast(ctrl, Button).Enabled = True
                    DirectCast(ctrl, Button).BackColor = Color.White
                    disableJobPosConsultant()
                End If
            Next
            Exit Sub
        End If


        ' Ensure only one button is selected at a time
        If btn Is btnConsultant Then
            btnEmployee.BackColor = Color.White
        Else
            btnConsultant.BackColor = Color.White
        End If

        ' Disable/Enable buttons based on selection
        Dim isConsultantSelected As Boolean = (btnConsultant.BackColor = Color.Gold)
        Dim isEmployeeSelected As Boolean = (btnEmployee.BackColor = Color.Gold)

        For Each ctrl As Control In PanelEmployeeFilter.Controls
            If TypeOf ctrl Is Button Then
                Dim otherBtn As Button = DirectCast(ctrl, Button)

                If isConsultantSelected Then
                    otherBtn.Enabled = (otherBtn Is btnSubStatConsultantPB OrElse
                                        otherBtn Is btnActive OrElse
                                        otherBtn Is btnInactive OrElse
                                        otherBtn Is btnSupport OrElse
                                        otherBtn Is btnTechnical OrElse
                                        otherBtn Is btnSubStatConsultantLS OrElse
                                        otherBtn Is btnSubStatConsultantFT OrElse
                                        otherBtn Is btnConsultant OrElse
                                        otherBtn Is btnEmployee)
                ElseIf isEmployeeSelected Then
                    otherBtn.Enabled = Not (otherBtn Is btnSubStatConsultantPB OrElse
                                        otherBtn Is btnSubStatConsultantLS OrElse
                                        otherBtn Is btnSubStatConsultantFT OrElse
                                        otherBtn Is btnJobPosConsultantFT OrElse
                                        otherBtn Is btnJobPosConsultantLS OrElse
                                        otherBtn Is btnJobPosConsultantPB)
                End If

                'Exclude default buttons at the top
                Dim excludedButtons = {btnActive, btnInactive, btnSupport, btnTechnical, btnConsultant, btnEmployee, btnSupport}
                otherBtn.BackColor = If(otherBtn.Enabled, If(excludedButtons.Contains(otherBtn), otherBtn.BackColor, Color.White), Color.Gainsboro)
            End If
        Next
        isEmployeeID = If(btnConsultant.BackColor = Color.Gold, 1, If(btnEmployee.BackColor = Color.Gold, 0, CType(Nothing, Integer?)))
    End Sub

    Private Sub EmployeeGroup(sender As Object, e As EventArgs) Handles btnTechnical.Click, btnSupport.Click
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)
        If btn Is btnTechnical Then btnSupport.BackColor = Color.White Else btnTechnical.BackColor = Color.White

        isTechnicalID = If(btnTechnical.BackColor = Color.Gold, 1, If(btnSupport.BackColor = Color.Gold, 0, CType(Nothing, Integer?)))
    End Sub

    Private Sub EmployeeSubstatus1(sender As Object, e As EventArgs) Handles btnRegularEmployee.Click, btnConfidentialEmployee.Click, btnProbationaryEmployee.Click, btnContractualEmployee.Click

        Dim btn As Button = DirectCast(sender, Button)
        Dim id As Integer = CInt(btn.Tag)

        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)
        If btnEmployee.BackColor <> Color.Gold Then btnEmployee.PerformClick()

        If btn.BackColor = Color.Gold Then
            If Not EmployeeSubStatus1ID.Contains(id) Then EmployeeSubStatus1ID.Add(id)
        Else
            EmployeeSubStatus1ID.Remove(id)
        End If
    End Sub

    Private Sub EmployeeSubstatus2(sender As Object, e As EventArgs) Handles btnSubStatConsultantPB.Click, btnSubStatConsultantFT.Click, btnSubStatConsultantLS.Click
        Dim btn As Button = DirectCast(sender, Button)
        Dim id As Integer = CInt(btn.Tag)

        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)

        If btn Is btnSubStatConsultantPB OrElse btn Is btnSubStatConsultantLS OrElse btn Is btnSubStatConsultantFT Then
            If btnConsultant.BackColor <> Color.Gold Then btnConsultant.PerformClick()
        End If

        btnJobPosConsultantPB.Enabled = (btnSubStatConsultantPB.BackColor = Color.Gold)
        btnJobPosConsultantPB.BackColor = If(btnJobPosConsultantPB.Enabled, Color.White, Color.Gainsboro)
        If btnSubStatConsultantPB.BackColor = Color.Gold Then btnJobPosConsultantPB.PerformClick()

        btnJobPosConsultantLS.Enabled = (btnSubStatConsultantLS.BackColor = Color.Gold)
        btnJobPosConsultantLS.BackColor = If(btnJobPosConsultantLS.Enabled, Color.White, Color.Gainsboro)
        If btnSubStatConsultantLS.BackColor = Color.Gold Then btnJobPosConsultantLS.PerformClick()

        btnJobPosConsultantFT.Enabled = (btnSubStatConsultantFT.BackColor = Color.Gold)
        btnJobPosConsultantFT.BackColor = If(btnJobPosConsultantFT.Enabled, Color.White, Color.Gainsboro)
        If btnSubStatConsultantFT.BackColor = Color.Gold Then btnJobPosConsultantFT.PerformClick()

        If btn.BackColor = Color.Gold Then
            If Not EmployeeSubStatus2ID.Contains(id) Then EmployeeSubStatus2ID.Add(id)
        Else
            EmployeeSubStatus2ID.Remove(id)
        End If
    End Sub

    Private Sub RankLevel(sender As Object, e As EventArgs) Handles btnRankFile.Click, btnRankSenior.Click, btnRankPrincipal.Click, btnRankSupervisor.Click, btnRankExecutive.Click, btnRankOfficer.Click
        Dim btn As Button = DirectCast(sender, Button)
        Dim id As Integer = CInt(btn.Tag)
        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)

        If btn.BackColor = Color.Gold Then
            If Not EmployeeClassGroupID.Contains(id) Then EmployeeClassGroupID.Add(id)
        Else
            EmployeeClassGroupID.Remove(id)
        End If
    End Sub

    Private Sub JobPositions(sender As Object, e As EventArgs) Handles btnJobPosAssistant.Click, btnJobPosAssociate.Click, btnJobPosJunior.Click, btnJobPosSenior.Click, btnJobPosOfficer.Click,
                                                                               btnJobPosManager.Click, btnJobPosSupervisor.Click, btnJobPosPrincipal.Click, btnJobPosExecutive.Click,
                                                                               btnJobPosDriver.Click, btnJobPosOthers.Click
        Dim btn As Button = DirectCast(sender, Button)
        Dim txt As String = btn.Text
        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)

        If btn.BackColor = Color.Gold Then
            If Not EmployeeJobPositionRawString.Contains(txt) Then EmployeeJobPositionRawString.Add(txt)
        Else
            EmployeeJobPositionRawString.Remove(txt)
        End If
        JobPositionProcessedString()
    End Sub

    Private Sub JobPositionsLevel(sender As Object, e As EventArgs) Handles btnJobPosLevel1.Click, btnJobPosLevel2.Click, btnJobPosLevel3.Click, btnJobPosLevel4.Click
        Dim btn As Button = DirectCast(sender, Button)
        Dim txt As String = btn.Tag
        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)

        If btn.BackColor = Color.Gold Then
            If Not EmployeeJobPositionID.Contains(txt) Then EmployeeJobPositionID.Add(txt)
        Else
            EmployeeJobPositionID.Remove(txt)
        End If
        JobPositionProcessedString()
    End Sub

    Public Sub JobPositionProcessedString()
        EmployeeJobPositionCombinedString.Clear()

        If EmployeeJobPositionRawString.Count > 0 AndAlso EmployeeJobPositionID.Count > 0 Then
            ' Combine each raw string with each ID
            For Each id In EmployeeJobPositionID
                For Each txt In EmployeeJobPositionRawString
                    EmployeeJobPositionCombinedString.Add(txt & " " & id.ToString())
                Next
            Next
        ElseIf EmployeeJobPositionRawString.Count > 0 Then
            ' Only raw strings
            EmployeeJobPositionCombinedString.AddRange(EmployeeJobPositionRawString)
        ElseIf EmployeeJobPositionID.Count > 0 Then
            ' Only IDs
            For Each id In EmployeeJobPositionID
                EmployeeJobPositionCombinedString.Add(id.ToString())
            Next
        End If
    End Sub

    Private Sub chSpecificJobTitle_CheckedChanged(sender As Object, e As EventArgs) Handles chSpecificJobTitle.CheckedChanged

        ResetJobPositionButtons(Me)
        EmployeeJobPositionID.Clear()
        EmployeeJobPositionRawString.Clear()
        EmployeeJobPositionCombinedString.Clear()
        txtSpecificJobTitle.Enabled = chSpecificJobTitle.Checked
        txtSpecificJobTitle.Text = ""

    End Sub

    Private Sub ResetJobPositionButtons(ctrl As Control)

        For Each child As Control In ctrl.Controls
            If TypeOf child Is Button AndAlso child.Name.StartsWith("btnJobPos") Then
                child.BackColor = Color.White
            End If
            ' Recursively search nested containers
            If child.HasChildren Then
                ResetJobPositionButtons(child)
            End If
        Next

        btnJobPosConsultantFT.BackColor = Color.Gainsboro
        btnJobPosConsultantLS.BackColor = Color.Gainsboro
        btnJobPosConsultantPB.BackColor = Color.Gainsboro

    End Sub

    Private Sub txtSpecificJobTitle_Validating(sender As Object, e As CancelEventArgs) Handles txtSpecificJobTitle.Validating

        EmployeeJobPositionCombinedString.Clear()

        If chSpecificJobTitle.Checked Then
            txtSpecificJobTitle.Enabled = True
            If Not EmployeeJobPositionCombinedString.Contains(txtSpecificJobTitle.Text) Then EmployeeJobPositionCombinedString.Add(txtSpecificJobTitle.Text)
        End If

    End Sub

    Private Sub JobPositionConsultants(sender As Object, e As EventArgs) Handles btnJobPosConsultantFT.Click, btnJobPosConsultantLS.Click, btnJobPosConsultantPB.Click
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)

        ' if any consultant button is still selected
        Dim anySelected As Boolean = btnJobPosConsultantFT.BackColor = Color.Gold OrElse
                                     btnJobPosConsultantLS.BackColor = Color.Gold OrElse
                                     btnJobPosConsultantPB.BackColor = Color.Gold

        ' Enable or disable the non-support department 
        For Each otherBtn In {btnWaterSanitation, btnRenEnergy, btnRailways, btnInfraSP, btnBIM, btnGlobeInnove}
            otherBtn.Enabled = anySelected
            otherBtn.BackColor = If(otherBtn.Enabled, Color.White, Color.Gainsboro)
        Next


    End Sub

    Private Sub DepartmentUnit(sender As Object, e As EventArgs) Handles btnWaterSanitation.Click, btnBusDev.Click, btnRenEnergy.Click, btnDeptExecutive.Click, btnDims.Click, btnGlobeInnove.Click, btnGenserv.Click,
                                                                         btnHumanResource.Click, btnOpcen.Click, btnInfraSP.Click, btnRailways.Click, btnBIM.Click
        Dim btn As Button = DirectCast(sender, Button)
        Dim id As Integer = CInt(btn.Tag)
        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)

        If btn.BackColor = Color.Gold Then
            If Not EmployeeDepartmentID.Contains(id) Then EmployeeDepartmentID.Add(id)
        Else
            EmployeeDepartmentID.Remove(id)
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Search_DGVPersonnel_by_Filter(frmHRIS_Transaction_EmployeeFile.dgvEmployeeList)
        'MsgBox(String.Join(", ", EmployeeDepartmentID))
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        For Each ctrl As Control In PanelEmployeeFilter.Controls
            If TypeOf ctrl Is Button Then
                DirectCast(ctrl, Button).Enabled = True
                DirectCast(ctrl, Button).BackColor = Color.White
            End If
        Next

        EmployeeStatusID = Nothing
        isEmployeeID = Nothing
        isTechnicalID = Nothing
        EmployeeSubStatus1ID.Clear()
        EmployeeSubStatus2ID.Clear()
        EmployeeClassGroupID.Clear()
        EmployeeJobPositionID.Clear()
        EmployeeJobPositionRawString.Clear()
        EmployeeJobPositionCombinedString.Clear()
        EmployeeDepartmentID.Clear()
        chSpecificJobTitle.Checked = False

        disableJobPosConsultant()

    End Sub

    Private Sub frmHRIS_Transaction_SearchFilter_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            hideTimer.Stop()
        Else
            hideTimer.Start() 'start the countdown to 5 mins and if lapses dispose/clear resources in this search form
        End If
    End Sub

    Private Sub hideTimer_Tick(sender As Object, e As EventArgs) Handles hideTimer.Tick
        hideTimer.Stop()
        Me.Dispose()
    End Sub

End Class