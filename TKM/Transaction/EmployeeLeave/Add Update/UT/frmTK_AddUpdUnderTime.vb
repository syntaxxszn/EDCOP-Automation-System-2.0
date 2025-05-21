Public Class frmTK_AddUpdUnderTime

    Public isUpdate As Boolean = False
    Private isPopulating As Boolean = False
    Dim tooltip As New ToolTip()

    Private Sub PictureBoxHelp_Click(sender As Object, e As EventArgs) Handles PictureBoxHelp.Click, PictureBoxHelp.MouseHover
        tooltip.SetToolTip(PictureBoxHelp, "Thank you for not calling DIMS! <3")
    End Sub

    Private Sub chLateFiling_CheckedChanged(sender As Object, e As EventArgs) Handles chLateFiling.CheckedChanged
        dtpDateFiling.Enabled = chLateFiling.Checked
        If isPopulating Then Exit Sub
        If Not chLateFiling.Checked Then dtpDateFiling.Value = DateTime.Today
    End Sub

    Private Sub frmTK_AddUpdUnderTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Undertime"
        If isUpdate Then
            lblHeader.Text = "Üpdating Undertime"
            isPopulating = True
            SelUpd_UnderTime_By_ID()
            isPopulating = False
            Exit Sub
        End If
        _UnderTimeFileID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnAddUndertime_Click(sender As Object, e As EventArgs) Handles btnAddUndertime.Click
        InsUpd_Undertime_By_PersonnelID()
    End Sub

    Private Sub frmTK_AddUpdUnderTime_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ResetDatePickers(Me)
        ClearTextBoxes(Me)
        chLateFiling.Checked = False
        isUpdate = False
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        ResetDatePickers(Me)
        ClearTextBoxes(Me)
        chLateFiling.Checked = False
    End Sub
End Class