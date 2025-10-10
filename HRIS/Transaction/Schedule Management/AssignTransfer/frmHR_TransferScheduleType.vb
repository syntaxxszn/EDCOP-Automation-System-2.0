Public Class frmHR_TransferScheduleType

    Private Sub frmHR_TransferScheduleType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DropDownListShiftType(cbScheduleType)
        SelUpd_ShiftSubDetail_By_ID()
    End Sub

    Private Sub cbScheduleType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbScheduleType.SelectedIndexChanged
        DropDownListShiftEffectivityByShiftTypeID(cbEffectivityPeriod, cbScheduleType)
    End Sub

    Private Sub frmHR_TransferScheduleType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        UncheckCheckBoxes(Me)
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAssignSchedule_Click(sender As Object, e As EventArgs) Handles btnAssignSchedule.Click
        Update_ScheduleShiftType_To_Employee()
    End Sub
End Class