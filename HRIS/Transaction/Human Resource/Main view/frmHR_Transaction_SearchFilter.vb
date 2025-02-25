Public Class frmHR_Transaction_SearchFilter

    Private Sub frmHR_Transaction_SearchFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Store button number in list when button is enabled and is backcolor = gold
    End Sub

    Private Sub Status_201(sender As Object, e As EventArgs) Handles btnActive.Click, btnInactive.Click
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)
        If btn Is btnActive Then btnInactive.BackColor = Color.White Else btnActive.BackColor = Color.White
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
    End Sub

    Private Sub EmployeeGroup(sender As Object, e As EventArgs) Handles btnTechnical.Click, btnSupport.Click
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)
        If btn Is btnTechnical Then btnSupport.BackColor = Color.White Else btnTechnical.BackColor = Color.White
    End Sub

    Dim EmployeeSubStatusID As New List(Of Integer)
    Private Sub EmployeeSubstatus(sender As Object, e As EventArgs) Handles btnRegularEmployee.Click, btnProjectBasedEmployee.Click, btnSubStatConsultantPB.Click,
                                                              btnProbationaryEmployee.Click, btnSubStatConsultantLS.Click, btnSubStatConsultantFT.Click, btnOJTrainee.Click

        Dim btn As Button = DirectCast(sender, Button)
        Dim id As Integer = CInt(btn.Tag)

        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)

        If btn.BackColor = Color.Gold Then
            If Not EmployeeSubStatusID.Contains(id) Then EmployeeSubStatusID.Add(id)
        Else
            EmployeeSubStatusID.Remove(id)
        End If

        ' Reset other consultant buttons & trigger main consultant button if needed
        If btn Is btnSubStatConsultantPB OrElse btn Is btnSubStatConsultantLS OrElse btn Is btnSubStatConsultantFT Then
            For Each otherBtn In {btnSubStatConsultantPB, btnSubStatConsultantLS, btnSubStatConsultantFT}
                If otherBtn IsNot btn Then otherBtn.BackColor = Color.White
            Next
            If btnConsultant.BackColor <> Color.Gold Then btnConsultant.PerformClick()
        End If

        ' Enable/Disable associated buttons & update their colors
        For Each cBtn In {btnJobPosConsultantPB, btnJobPosConsultantLS, btnJobPosConsultantFT}
            cBtn.Enabled = (cBtn Is btnJobPosConsultantPB AndAlso btnSubStatConsultantPB.BackColor = Color.Gold) OrElse
                           (cBtn Is btnJobPosConsultantLS AndAlso btnSubStatConsultantLS.BackColor = Color.Gold) OrElse
                           (cBtn Is btnJobPosConsultantFT AndAlso btnSubStatConsultantFT.BackColor = Color.Gold)
            cBtn.BackColor = If(cBtn.Enabled, Color.White, Color.Gainsboro)
        Next
    End Sub

    Private Sub JobPositions(sender As Object, e As EventArgs) Handles btnAssistant.Click
        ''
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

    Private Sub btnJobPosConsultantPB_EnabledChanged(sender As Object, e As EventArgs) Handles btnJobPosConsultantPB.EnabledChanged, btnJobPosConsultantLS.EnabledChanged, btnJobPosConsultantFT.EnabledChanged
        For Each otherBtn In {btnWaterSanitation, btnRenEnergy, btnRailways, btnInfraSP, btnBIM, btnGlobeInnove}
            otherBtn.BackColor = Color.Gainsboro
            otherBtn.Enabled = False
        Next
    End Sub

    Private Sub RankLevel(sender As Object, e As EventArgs) Handles btnRankFile.Click, btnSupervisor.Click, btnManagerial.Click, btnExecutive.Click, btnDirector.Click
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)
    End Sub

    Private Sub DepartmentUnit(sender As Object, e As EventArgs) Handles btnWaterSanitation.Click, btnBusDev.Click, btnRenEnergy.Click, btnDeptExecutive.Click, btnDims.Click, btnGlobeInnove.Click, btnGenserv.Click,
                                                                         btnHumanResource.Click, btnOpcen.Click, btnInfraSP.Click, btnRailways.Click, btnBIM.Click
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = If(btn.BackColor = Color.Gold, Color.White, Color.Gold)
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        MsgBox(String.Join(", ", EmployeeSubStatusID))
    End Sub
End Class