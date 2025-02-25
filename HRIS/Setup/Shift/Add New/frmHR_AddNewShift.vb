Imports System.ComponentModel
Imports System.Windows.Forms

Public Class frmHR_AddNewShift


    Private Sub frmHR_AddNewShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' This Calling will Disabled editing on textbox.
        textboxReadOnly()

    End Sub

    Private Sub frmHR_AddNewShift_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Delete_ShiftTempRecord()
    End Sub

    Sub ClearField()

        txtCode.Clear()
        txtName.Clear()
        txtDescriptions.Clear()
        ' dtpNormalWorkTimeFrom.ResetText()
        ' dtpNormalWorkTimeTo.ResetText()
        txtSlideTime.Clear()
        ' dtpNormalBreakTimeFrom.ResetText()
        ' dtpNormalBreakTimeTo.ResetText()
        checkboxForceBreak.CheckState = CheckState.Unchecked
        checkboxFlexi.CheckState = CheckState.Unchecked
        txtTotalHours.Clear()

    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Delete_ShiftTempRecord()
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        txtTotalHours.Text = (DateDiff(DateInterval.Minute, dtpNormalWorkTimeFrom.Value, dtpNormalWorkTimeTo.Value) - DateDiff(DateInterval.Minute, dtpNormalBreakTimeFrom.Value, dtpNormalBreakTimeTo.Value)) / 60


        Dim strMessage As String = "Input Details"

        If txtCode.Text = Nothing Then

            MessageBox.Show(strMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            If txtName.Text = Nothing Then
                MessageBox.Show(strMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Ins_Shift()

            End If

        End If

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

    Private Sub txtTotalHours_TextChanged(sender As Object, e As EventArgs) Handles txtTotalHours.TextChanged

    End Sub

    Sub textboxReadOnly()
        txtTotalHours.ReadOnly = True
    End Sub


End Class
