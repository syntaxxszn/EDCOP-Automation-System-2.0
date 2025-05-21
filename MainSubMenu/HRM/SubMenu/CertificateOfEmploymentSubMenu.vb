Public Class CertificateOfEmploymentSubMenu
    Private Sub btnCurrentNoGap_Click(sender As Object, e As EventArgs) Handles btnCurrentNoGap.Click
        Me.Close()
        _COEType = 741
        frmHRIS_Report_EmployeeList.lblHeader.Text = btnCurrentNoGap.Text
        frmHRIS_Report_EmployeeList.ShowDialog()
    End Sub

    Private Sub btnCurrentWithGap_Click(sender As Object, e As EventArgs) Handles btnCurrentWithGap.Click
        Me.Close()
        _COEType = 742
        frmHRIS_Report_EmployeeList.lblHeader.Text = btnCurrentWithGap.Text
        frmHRIS_Report_EmployeeList.ShowDialog()
    End Sub

    Private Sub btnCurrentWithCompensationItemized_Click(sender As Object, e As EventArgs) Handles btnCurrentWithCompensationItemized.Click
        Me.Close()
        _COEType = 743
        frmHRIS_Report_EmployeeList.lblHeader.Text = btnCurrentWithCompensationItemized.Text
        frmHRIS_Report_EmployeeList.ShowDialog()
    End Sub

    Private Sub btnCurrentWithCompensationItemizedWithGap_Click(sender As Object, e As EventArgs) Handles btnCurrentWithCompensationItemizedWithGap.Click
        Me.Close()
        _COEType = 744
        frmHRIS_Report_EmployeeList.lblHeader.Text = btnCurrentWithCompensationItemizedWithGap.Text
        frmHRIS_Report_EmployeeList.ShowDialog()
    End Sub

    Private Sub btnCurrentWithCompensationAnnualized_Click(sender As Object, e As EventArgs) Handles btnCurrentWithCompensationAnnualized.Click
        Me.Close()
        _COEType = 749
        frmHRIS_Report_EmployeeList.lblHeader.Text = btnCurrentWithCompensationAnnualized.Text
        frmHRIS_Report_EmployeeList.ShowDialog()
    End Sub

    Private Sub btnCurrentWithCompensationAnnualizedWithGap_Click(sender As Object, e As EventArgs) Handles btnCurrentWithCompensationAnnualizedWithGap.Click
        Me.Close()
        _COEType = 745
        frmHRIS_Report_EmployeeList.lblHeader.Text = btnCurrentWithCompensationAnnualized.Text
        frmHRIS_Report_EmployeeList.ShowDialog()
    End Sub

    Private Sub btnSeparatedAndCleared_Click(sender As Object, e As EventArgs) Handles btnSeparatedAndCleared.Click
        Me.Close()
        _COEType = 746
        frmHRIS_Report_EmployeeList.lblHeader.Text = btnSeparatedAndCleared.Text
        frmHRIS_Report_EmployeeList.ShowDialog()
    End Sub

    Private Sub btnSeparatedAndNotCleared_Click(sender As Object, e As EventArgs) Handles btnSeparatedAndNotCleared.Click
        Me.Close()
        _COEType = 748
        frmHRIS_Report_EmployeeList.lblHeader.Text = btnSeparatedAndNotCleared.Text
        frmHRIS_Report_EmployeeList.ShowDialog()
    End Sub

    Private Sub btnSeparateWithGaps_Click(sender As Object, e As EventArgs) Handles btnSeparateWithGaps.Click
        Me.Close()
        _COEType = 747
        frmHRIS_Report_EmployeeList.lblHeader.Text = btnSeparateWithGaps.Text
        frmHRIS_Report_EmployeeList.ShowDialog()
    End Sub
End Class