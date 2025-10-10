Public Class frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod

    Private Sub frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod_Support_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SelPopulate_ProjectList(cbProjectList)
        Call DropDownListJobPosition(cbJobPosition)

        Dim index As Integer = cbJobPosition.Items.IndexOf(_EmployeePosition) 'Auto select the current job position of the employee if available
        cbJobPosition.SelectedIndex = If(index <> -1, index, cbJobPosition.Items.IndexOf("-"))

        If isUpdate Then
            isPopulating = True
            Call SelUpd_PMAS_Part1Form1_ByID()
            isPopulating = False
            Exit Sub
        End If

        _strPerformancePart1Form1ID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ResetComboBoxes(Me)
        Call ResetDatePickers(Me)
        Call ClearTextBoxes(Me)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmHRIS_PerformanceManagement_AddUpdatePart1Form1.ShowDialog()
    End Sub

    Private Sub dtpStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        _StartDate = dtpStartDate.Value
    End Sub

    Private Sub dtpEnd_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        _EndDate = dtpEndDate.Value
    End Sub

    Private Sub dtpReviewDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpReviewDate.ValueChanged
        _ReviewDate = dtpReviewDate.Value
    End Sub

    Private Sub frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        Call ClearTextBoxes(Me)
        Call ResetComboBoxes(Me)
        Call ResetDatePickers(Me)
        Call frmHRIS_PerformanceManagement_AddUpdatePart1Form1.clearFields()
    End Sub

    Private Sub cbJobPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJobPosition.SelectedIndexChanged
        _ProjectDesignation = cbJobPosition.Text
    End Sub

End Class