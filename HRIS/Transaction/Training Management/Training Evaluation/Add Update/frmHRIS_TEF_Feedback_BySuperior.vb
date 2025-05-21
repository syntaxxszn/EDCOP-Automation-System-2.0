Public Class frmHRIS_TEF_Feedback_BySuperior

    Private Sub frmHRIS_TEF_Feedback_BySuperior_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnSubmit.Visible = (Label8.Text <> "Completed")
        If btnSubmit.Visible Then Exit Sub

        EnableAllCheckboxesAndTextbox()
    End Sub

    Private Sub cbe1_CheckedChanged(sender As Object, e As EventArgs) Handles cbe1.CheckedChanged, cbe2.CheckedChanged, cbe3.CheckedChanged,
                                                                            cbe4.CheckedChanged, cbe5.CheckedChanged, cbe6.CheckedChanged,
                                                                            cbe7.CheckedChanged, cbe8.CheckedChanged, cbe9.CheckedChanged

        Dim clickedCheckBox As CheckBox = DirectCast(sender, CheckBox)

        If clickedCheckBox.Checked Then
            Select Case clickedCheckBox.Name
                Case "cbe1", "cbe2", "cbe3"
                    UncheckOtherCheckBoxes({cbe1, cbe2, cbe3}, clickedCheckBox)
                Case "cbe4", "cbe5", "cbe6"
                    UncheckOtherCheckBoxes({cbe4, cbe5, cbe6}, clickedCheckBox)
                Case "cbe7", "cbe8", "cbe9"
                    UncheckOtherCheckBoxes({cbe7, cbe8, cbe9}, clickedCheckBox)
            End Select
        End If

    End Sub

    Private Sub UncheckOtherCheckBoxes(group As CheckBox(), checkedCheckBox As CheckBox)
        For Each cb As CheckBox In group
            If cb IsNot checkedCheckBox Then
                cb.Checked = False
            End If
        Next
    End Sub

    Private Sub EnableAllCheckboxesAndTextbox()

        For Each cb As CheckBox In {cbTrainingType1, cbTrainingType2, cbTrainingType3}
            cb.Enabled = True
        Next
        txtTrainingType4.Enabled = True
        Label8.ForeColor = Color.Navy

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Call InsUpd_TEF_TrainingEvaluationFeedbackByMngrID()
    End Sub

    Private Sub cbTimeFrame_DropDown(sender As Object, e As EventArgs) Handles cbTimeFrame.DropDown
        TimeFrameDropDownList(cbTimeFrame)
    End Sub

End Class