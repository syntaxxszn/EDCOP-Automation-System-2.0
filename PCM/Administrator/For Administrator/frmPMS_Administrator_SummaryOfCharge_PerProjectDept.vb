Imports System.Windows.Forms

Public Class frmPMS_Administrator_SummaryOfCharge_PerProjectDept


    Private Sub frmPMS_Administrator_SummaryOfCharge_PerProjectDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate_ComboBox_ProjectDepartment(cmbboxDepartment)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If dtpDateFrom.Text > dtpDateTo.Text Then
            MessageBox.Show("Invalid date selected. [ Date from ] must be less than from [ Date to ].", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If cmbboxDepartment.SelectedIndex = -1 Then
                MessageBox.Show("Select Department to be filter.", "E-PCM System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If
        Print_PerDepartmentProjectSummary()
    End Sub

    Private Sub cmbboxDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbboxDepartment.SelectedIndexChanged
        Select_ProjectDepartment_ID()
    End Sub
End Class
