Imports System.ComponentModel
Imports System.Windows.Forms

Public Class frmHRIS_AddNewShift

    Private Sub frmHR_AddNewShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Shift"
        textboxReadOnly()

        If isUpdate Then
            lblHeader.Text = "Üpdating Shift"
            isPopulating = True
            SelUpd_Shift_By_ID()
            isPopulating = False
            Exit Sub
        End If

        _strShiftID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        'Delete_ShiftTempRecord()
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'txtTotalHours.Text = (DateDiff(DateInterval.Minute, dtpNormalWorkTimeFrom.Value, dtpNormalWorkTimeTo.Value) - DateDiff(DateInterval.Minute, dtpNormalBreakTimeFrom.Value, dtpNormalBreakTimeTo.Value)) / 60

        If txtTotalHours.Text = "" OrElse txtTotalHours.Text = "Invalid Time" Then
            MessageBox.Show("Please provide all details required.", "Invalid Saving", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim strMessage As String = "Input Details"

        If txtCode.Text = Nothing OrElse txtName.Text = Nothing Then

            MessageBox.Show(strMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            InsUpd_Shift()

        End If
        'MsgBox(_strShiftID)
    End Sub

    Private Sub checkboxFlexi_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxFlexi.CheckedChanged

        If checkboxFlexi.CheckState = CheckState.Checked Then
            isFlexi = 1
        Else
            isFlexi = 0
        End If

    End Sub

    Private Sub checkboxForceBreak_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxForceBreak.CheckedChanged

        If checkboxForceBreak.CheckState = CheckState.Checked Then
            isForceBreak = 1
        Else
            isForceBreak = 0
        End If

    End Sub


    Sub textboxReadOnly()
        txtTotalHours.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearTextBoxes(Me)
        UncheckCheckBoxes(Me)
        ResetDatePickers(Me)
    End Sub

    Private Sub dtpNormalWorkTimeFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpNormalWorkTimeFrom.ValueChanged
        If isPopulating Then Exit Sub
        calculateTotalHours()
    End Sub

    Private Sub dtpNormalWorkTimeTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpNormalWorkTimeTo.ValueChanged
        If isPopulating Then Exit Sub
        calculateTotalHours()
    End Sub

    Private Sub dtpNormalBreakTimeFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpNormalBreakTimeFrom.ValueChanged
        If isPopulating Then Exit Sub
        calculateTotalHours()
    End Sub

    Private Sub dtpNormalBreakTimeTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpNormalBreakTimeTo.ValueChanged
        If isPopulating Then Exit Sub
        calculateTotalHours()
    End Sub

    Private Sub calculateTotalHours()
        Dim workStart As DateTime = dtpNormalWorkTimeFrom.Value
        Dim workEnd As DateTime = dtpNormalWorkTimeTo.Value
        Dim breakStart As DateTime = dtpNormalBreakTimeFrom.Value
        Dim breakEnd As DateTime = dtpNormalBreakTimeTo.Value

        txtTotalHours.Text = ""

        ' Basic validation
        If workEnd <= workStart OrElse breakEnd <= breakStart Then
            txtTotalHours.Text = "Invalid Time"
            Return
        End If

        Dim workHours As TimeSpan = workEnd - workStart
        Dim breakHours As TimeSpan = breakEnd - breakStart
        Dim totalHours As TimeSpan = workHours - breakHours

        txtTotalHours.Text = totalHours.TotalHours.ToString("0.00")
    End Sub

    Private Sub txtSlideTime_Validating(sender As Object, e As CancelEventArgs) Handles txtSlideTime.Validating
        Textbox_NumericFormat(txtSlideTime, e.Cancel)
    End Sub

    Private Sub frmHR_AddNewShift_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
        ClearTextBoxes(Me)
        ResetDatePickers(Me)
        UncheckCheckBoxes(Me)
    End Sub
End Class
