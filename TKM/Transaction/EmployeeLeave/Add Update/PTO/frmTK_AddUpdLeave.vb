Imports System.ComponentModel

Public Class frmTK_AddUpdLeave

    Public isUpdate As Boolean = False
    Private isPopulating As Boolean = False
    Private LeaveTypes As New List(Of String)
    Dim tooltip As New ToolTip()

    Private Sub frmTK_AddUpdLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DropDownListLeaveType(cbLeaveType)
        DropDownListDayType(cbDayType)
        txtLeaveCredits.Text = "0.00"
        txtNumDays.Text = "1.00"
        dtpDateFiling.Value = Date.Today
        lblHeader.Text = "Add New Leave / Paid Time-Off"
        If isUpdate Then
            lblHeader.Text = "Üpdating Leave / Paid Time-Off"
            isPopulating = True
            SelUpd_EmployeeLeave_By_ID()
            isPopulating = False
            Exit Sub
        End If
        _LeaveFileID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub chLateFiling_CheckedChanged(sender As Object, e As EventArgs) Handles chLateFiling.CheckedChanged
        dtpDateFiling.Enabled = chLateFiling.Checked
        If isPopulating Then Exit Sub
        If Not chLateFiling.Checked Then dtpDateFiling.Value = DateTime.Today
    End Sub

    Private Sub cbLeaveType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLeaveType.SelectedIndexChanged
        SelTK_EmployeeLeave_Credits_By_Leave_Type_ID(txtLeaveCredits, cbLeaveType.Text)
    End Sub

    Private Sub PictureBoxHelp_Click(sender As Object, e As EventArgs) Handles PictureBoxHelp.Click
        tooltip.SetToolTip(PictureBoxHelp, "Thank you for not calling DIMS! <3")
    End Sub

    Private Sub frmTK_AddUpdLeave_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Not Me.IsDisposed Then Me.Dispose()
    End Sub

    Private Sub txtNumDays_Validating(sender As Object, e As CancelEventArgs) Handles txtNumDays.Validating
        Textbox_NumericFormat(txtNumDays, e.Cancel)
    End Sub

    Private Sub btnAddUpdEmployeeLeave_Click(sender As Object, e As EventArgs) Handles btnAddUpdEmployeeLeave.Click
        SelTK_LeaveType_isPaid_By_ID(LeaveTypes)
        Dim leaveTypeMatched As Boolean = LeaveTypes.Any(Function(leaveType) String.Equals(cbLeaveType.Text.Trim(), leaveType.Trim(), StringComparison.OrdinalIgnoreCase))
        'MsgBox(leaveTypeMatched)

        If leaveTypeMatched Then

            Dim leaveCredits As Decimal
            Dim numDays As Decimal

            If Not Decimal.TryParse(txtLeaveCredits.Text, leaveCredits) Then
                MsgBox("Invalid leave credits value. Please check with the System Administrator and try again.")
                Return
            End If

            If Not Decimal.TryParse(txtNumDays.Text, numDays) Then
                MsgBox("Invalid number of days value. Please check the input (numbers only) and try again.")
                Return
            End If

            If leaveCredits <= 0 Then
                MsgBox("Sorry, not enough leave credit balance. If this is a mistake, please contact the System Administrator or opt to file other leave type.")
                Return
            ElseIf numDays > leaveCredits Then
                MsgBox("The number of days (leave count) input exceeds the available leave credits. Please check and try again.")
                Return
            End If

        End If

        InsUpd_EmployeeLeave_By_PersonnelID()
    End Sub
End Class