Public Class frmTK_PrevEmployeeLeave

    Public _MsgStatusRemarks As String
    Private LeaveTypes As New List(Of String)()

    Private Sub frmTK_PrevEmployeeLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtLeave.Text = "Sick Leave (SL)" Or txtLeave.Text = "SL w/o pay (SLWOP)" Then
            txtSLBox.Visible = True
        ElseIf txtLeave.Text = "Vacation Leave (VL)" Or txtLeave.Text = "VL w/o pay (VLWOP)" Then
            txtVLBox.Visible = True
        End If

        SelTK_LeaveType_isPaid_By_ID(LeaveTypes)
        Dim leaveTypeMatched As Boolean = LeaveTypes.Any(Function(leaveType) String.Equals(txtLeave.Text.Trim(), leaveType.Trim(), StringComparison.OrdinalIgnoreCase))

        If leaveTypeMatched Then
            txtLWPBox.Visible = True
            txtLWOPBox.Visible = False
        Else
            txtLWPBox.Visible = False
            txtLWOPBox.Visible = True
        End If
    End Sub

    Private Sub frmTK_PrevEmployeeLeave_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtVLBox.Visible = False
        txtSLBox.Visible = False
        txtLWPBox.Visible = False
        txtLWOPBox.Visible = False
    End Sub

    Private Sub btnStatusRemarks_Click(sender As Object, e As EventArgs) Handles btnStatusRemarks.Click
        MsgBox(_MsgStatusRemarks)
    End Sub

    Private Sub btnPrintDetails_Click(sender As Object, e As EventArgs) Handles btnPrintDetails.Click

    End Sub
End Class