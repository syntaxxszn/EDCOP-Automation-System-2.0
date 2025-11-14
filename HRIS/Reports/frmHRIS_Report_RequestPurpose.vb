Public Class frmHRIS_Report_RequestPurpose

    Private Sub frmHRIS_Report_RequestPurpose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isUpdate Then
            _COEID1 = 0
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If String.IsNullOrWhiteSpace(txtReferenceNo.Text) OrElse String.IsNullOrWhiteSpace(txtPurpose.Text) Then
            MessageBox.Show("Fields cannot be empty.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        InsUpd_COE_References()
        Me.Close()
        'If frmHRIS_Report_EmployeeList.isButtonSelected = 1 Then
        '    PrintRPT_COE_Current_NO_GAP(741)
        'Else
        '    MessageBox.Show("Report File cannot be found.", "Contact System Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub

    Private Sub frmHRIS_Report_RequestPurpose_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        frmHRIS_Report_EmployeeList.Close()
        isUpdate = False
    End Sub


End Class