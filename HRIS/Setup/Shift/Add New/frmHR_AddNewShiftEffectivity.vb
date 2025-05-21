Public Class frmHR_AddNewShiftEffectivity

    Public isUpdate As Boolean = False

    Private Sub frmHR_AddNewShiftEffectivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Shift Effectivity Date"

        If isUpdate Then
            lblHeader.Text = "Üpdating Shift Effectivity Date"
            SelUpd_Shift_EffectivityDate_By_ID()
            Exit Sub
        End If

        _strShiftEffectivityID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsUpd_ShiftEffectivityDate()
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Private Sub frmHR_AddNewShiftEffectivity_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = False
    End Sub
End Class