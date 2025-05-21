Public Class frmHRIS_TEF_Feedback_Form_Part1

    Private Sub frmHRIS_TEF_Feedback_Form_Part1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNameParticipant.Text = frmHRIS_Transaction_TrainingEvaluation.lblTrainingName.Text
        txtTitleSeminar.Text = frmHRIS_Transaction_TrainingEvaluation.lblPending.Text
        txtFacilitator.Text = frmHRIS_Transaction_TrainingEvaluation.Label9.Text
        txtDateConducted.Text = frmHRIS_Transaction_TrainingEvaluation.Label7.Text

    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles _
     cb1.CheckedChanged, cb2.CheckedChanged, cb3.CheckedChanged,
     cb4.CheckedChanged, cb5.CheckedChanged, cb6.CheckedChanged,
     cb7.CheckedChanged, cb8.CheckedChanged, cb9.CheckedChanged,
     cb10.CheckedChanged, cb11.CheckedChanged, cb12.CheckedChanged,
     cb13.CheckedChanged, cb14.CheckedChanged, cb15.CheckedChanged

        Dim clickedCheckBox As CheckBox = DirectCast(sender, CheckBox)

        If clickedCheckBox.Checked Then
            Select Case clickedCheckBox.Name
                Case "cb1", "cb2", "cb3"
                    UncheckOtherCheckBoxes({cb1, cb2, cb3}, clickedCheckBox)
                Case "cb4", "cb5", "cb6"
                    UncheckOtherCheckBoxes({cb4, cb5, cb6}, clickedCheckBox)
                Case "cb7", "cb8", "cb9"
                    UncheckOtherCheckBoxes({cb7, cb8, cb9}, clickedCheckBox)
                Case "cb10", "cb11", "cb12"
                    UncheckOtherCheckBoxes({cb10, cb11, cb12}, clickedCheckBox)
                Case "cb13", "cb14", "cb15"
                    UncheckOtherCheckBoxes({cb13, cb14, cb15}, clickedCheckBox)
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

    'Private Sub DisableOtherCheckboxesAndTextbox(checkedCheckbox As CheckBox) 'this is wrong as employee should not be selecting from this menu as this is defined by hr

    '    For Each cb As CheckBox In {cbTrainingType1, cbTrainingType2, cbTrainingType3}
    '        If cb IsNot checkedCheckbox Then
    '            cb.Enabled = False
    '            cb.Checked = False
    '        End If
    '    Next

    'End Sub

    'Private Sub cbTrainingType1_CheckedChanged(sender As Object, e As EventArgs) Handles cbTrainingType1.CheckedChanged
    '    If cbTrainingType1.Checked Then
    '        DisableOtherCheckboxesAndTextbox(cbTrainingType1)
    '    End If
    'End Sub

    'Private Sub cbTrainingType2_CheckedChanged(sender As Object, e As EventArgs) Handles cbTrainingType2.CheckedChanged
    '    If cbTrainingType2.Checked Then
    '        DisableOtherCheckboxesAndTextbox(cbTrainingType2)
    '    End If
    'End Sub

    'Private Sub cbTrainingType3_CheckedChanged(sender As Object, e As EventArgs) Handles cbTrainingType3.CheckedChanged
    '    If cbTrainingType3.Checked Then
    '        DisableOtherCheckboxesAndTextbox(cbTrainingType3)
    '    End If
    'End Sub

    'Private Sub txtTrainingType4_TextChanged(sender As Object, e As EventArgs) Handles txtTrainingType4.TextChanged
    '    If txtTrainingType4.Text.Trim() <> "" Then
    '        cbTrainingType1.Checked = False
    '        cbTrainingType1.Enabled = False
    '        cbTrainingType2.Checked = False
    '        cbTrainingType2.Enabled = False
    '        cbTrainingType3.Checked = False
    '        cbTrainingType3.Enabled = False
    '    End If
    'End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmHRIS_TEF_Feedback_Form_Part2.ShowDialog()
    End Sub
End Class