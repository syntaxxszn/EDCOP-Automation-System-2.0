Public Class frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1

    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ClearMatchingTextBoxes(Me)
        txtEmployeeName.Text = _EmployeeName
        txtDepartment.Text = _EmployeeDepartment
        txtPosition.Text = _EmployeePosition
        txtCoveredPeriod.Text = _StartDate.ToString("MMM/dd/yyyy") & " - " & _EndDate.ToString("MMM/dd/yyyy")
        btxtProjectName1.Text = atxtProjectName1.Text
        btxtProjectName2.Text = atxtProjectName2.Text
        btxtProjectName3.Text = atxtProjectName3.Text
        btxtProjectName4.Text = atxtProjectName4.Text
    End Sub

    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
    End Sub

    Private Sub ClearMatchingTextBoxes(parent As Control) 'to clear the textboxes that has default values
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox AndAlso ctrl.Text = "text" OrElse ctrl.Text = "0.00" Then
                ctrl.Text = ""
            End If
            If ctrl.HasChildren Then
                ClearMatchingTextBoxes(ctrl)
            End If
        Next
    End Sub

    Private Sub btnNextTab1_Click(sender As Object, e As EventArgs) Handles btnNextTab1.Click
        RatingsTab.SelectedTab = TabPage2
    End Sub

    Private Sub btnNextTab2_Click(sender As Object, e As EventArgs) Handles btnNextTab2.Click
        RatingsTab.SelectedTab = TabPage3
    End Sub

    Private Sub btnNextTab3_Click(sender As Object, e As EventArgs) Handles btnNextTab3.Click
        RatingsTab.SelectedTab = TabPage4
    End Sub

    Private Sub btnPrevTab4_Click(sender As Object, e As EventArgs) Handles btnPrevTab4.Click
        RatingsTab.SelectedTab = TabPage3
    End Sub

    Private Sub btnPrevTab3_Click(sender As Object, e As EventArgs) Handles btnPrevTab3.Click
        RatingsTab.SelectedTab = TabPage2
    End Sub

    Private Sub btnPrevTab2_Click(sender As Object, e As EventArgs) Handles btnPrevTab2.Click
        RatingsTab.SelectedTab = TabPage1
    End Sub

    Private Sub btnPrevTab1_Click(sender As Object, e As EventArgs) Handles btnPrevTab1.Click
        Me.Close()
    End Sub

    Private Sub SetRatingAcronym(inputBox As TextBox, outputBox As TextBox)
        Dim r As Double
        If Double.TryParse(inputBox.Text, r) Then
            outputBox.Text = If(r >= 4.51, "E",
                        If(r >= 3.76, "EE",
                        If(r >= 3.0, "ME",
                        If(r >= 2.21, "MSE", "DE"))))
        Else
            outputBox.Text = ""
        End If
    End Sub

    Private Sub txtP1Rating1_TextChanged(sender As Object, e As EventArgs) Handles txtP1Rating1.TextChanged
        SetRatingAcronym(txtP1Rating1, txtP1R1Acro)
    End Sub

    Private Sub txtP1Rating2_TextChanged(sender As Object, e As EventArgs) Handles txtP1Rating2.TextChanged
        SetRatingAcronym(txtP1Rating2, txtP1R2Acro)
    End Sub

    Private Sub txtP1Rating3_TextChanged(sender As Object, e As EventArgs) Handles txtP1Rating3.TextChanged
        SetRatingAcronym(txtP1Rating3, txtP1R3Acro)
    End Sub

    Private Sub txtP1FW3_TextChanged(sender As Object, e As EventArgs) Handles txtP1FW3.TextChanged
        txtP1FWT.Text = (Val(txtP1FW3.Text) + Val(txtP1FW2.Text) + Val(txtP1FW1.Text)).ToString("0.00")
    End Sub

    Private Sub txtP1WS3_TextChanged(sender As Object, e As EventArgs) Handles txtP1WS3.TextChanged
        txtP1WST.Text = (Val(txtP1WS3.Text) + Val(txtP1WS2.Text) + Val(txtP1WS1.Text)).ToString("0.00")
    End Sub

    Private Sub txtP2Rating1_TextChanged(sender As Object, e As EventArgs) Handles txtP2Rating1.TextChanged
        SetRatingAcronym(txtP2Rating1, txtP2R1Acro)
    End Sub

    Private Sub txtP2Rating2_TextChanged(sender As Object, e As EventArgs) Handles txtP2Rating2.TextChanged
        SetRatingAcronym(txtP2Rating2, txtP2R2Acro)
    End Sub

    Private Sub txtP2Rating3x_TextChanged(sender As Object, e As EventArgs) Handles txtP2Rating3x.TextChanged
        SetRatingAcronym(txtP2Rating3x, txtP2R3Acro)
    End Sub

    Private Sub txtP2FW3_TextChanged(sender As Object, e As EventArgs) Handles txtP2FW3.TextChanged
        txtP2FWT.Text = (Val(txtP2FW3.Text) + Val(txtP2FW2.Text) + Val(txtP2FW1.Text)).ToString("0.00")
    End Sub

    Private Sub txtP2WS3_TextChanged(sender As Object, e As EventArgs) Handles txtP2WS3.TextChanged
        txtP2WST.Text = (Val(txtP2WS3.Text) + Val(txtP2WS2.Text) + Val(txtP2WS1.Text)).ToString("0.00")
    End Sub

    Private Sub txtP3Rating1_TextChanged(sender As Object, e As EventArgs) Handles txtP3Rating1.TextChanged
        SetRatingAcronym(txtP3Rating1, txtP3R1Acro)
    End Sub

    Private Sub txtP3Rating2_TextChanged(sender As Object, e As EventArgs) Handles txtP3Rating2.TextChanged
        SetRatingAcronym(txtP3Rating2, txtP3R2Acro)
    End Sub

    Private Sub txtP3Rating3_TextChanged(sender As Object, e As EventArgs) Handles txtP3Rating3.TextChanged
        SetRatingAcronym(txtP3Rating3, txtP3R3Acro)
    End Sub

    Private Sub txtP3FW3_TextChanged(sender As Object, e As EventArgs) Handles txtP3FW3.TextChanged
        txtP3FWT.Text = (Val(txtP3FW3.Text) + Val(txtP3FW2.Text) + Val(txtP3FW1.Text)).ToString("0.00")
    End Sub

    Private Sub txtP3WS3_TextChanged(sender As Object, e As EventArgs) Handles txtP3WS3.TextChanged
        txtP3WST.Text = (Val(txtP3WS3.Text) + Val(txtP3WS2.Text) + Val(txtP3WS1.Text)).ToString("0.00")
    End Sub

    Private Sub txtP4Rating1_TextChanged(sender As Object, e As EventArgs) Handles txtP4Rating1.TextChanged
        SetRatingAcronym(txtP4Rating1, txtP4R1Acro)
    End Sub

    Private Sub txtP4Rating2_TextChanged(sender As Object, e As EventArgs) Handles txtP4Rating2.TextChanged
        SetRatingAcronym(txtP4Rating2, txtP4R2Acro)
    End Sub

    Private Sub txtP4Rating3_TextChanged(sender As Object, e As EventArgs) Handles txtP4Rating3.TextChanged
        SetRatingAcronym(txtP4Rating3, txtP4R3Acro)
    End Sub

    Private Sub txtP4FW3_TextChanged(sender As Object, e As EventArgs) Handles txtP4FW3.TextChanged
        txtP4FWT.Text = (Val(txtP4FW3.Text) + Val(txtP4FW2.Text) + Val(txtP4FW1.Text)).ToString("0.00")
    End Sub

    Private Sub txtP4WS3_TextChanged(sender As Object, e As EventArgs) Handles txtP4WS3.TextChanged
        txtP4WST.Text = (Val(txtP4WS3.Text) + Val(txtP4WS2.Text) + Val(txtP4WS1.Text)).ToString("0.00")
    End Sub

    Private Sub btnNextTab4_Click(sender As Object, e As EventArgs) Handles btnNextTab4.Click
        frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2.ShowDialog()
    End Sub

End Class