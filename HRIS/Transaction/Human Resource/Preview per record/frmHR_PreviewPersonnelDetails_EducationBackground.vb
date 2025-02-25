Public Class frmHR_PreviewPersonnelDetails_EducationBackground

    Dim dataSet As New DataSet()

    Private Sub frmHR_PreviewPersonnelDetails_EducationBackground_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnPrimaryEducation.BackColor = Color.FromArgb(252, 243, 196)
        btnSecondaryEducation.BackColor = Color.FromArgb(252, 219, 190)
        btnSeniorHighEducation.BackColor = Color.FromArgb(251, 195, 184)
        btnTertiaryEducation.BackColor = Color.FromArgb(251, 171, 178)
        btnMasteralEducation.BackColor = Color.FromArgb(250, 146, 172)
        btnDoctorateEducation.BackColor = Color.FromArgb(250, 122, 166)
        btnVocationalEducation.BackColor = Color.FromArgb(249, 98, 160)
        LoadAndDisplayEducationLevel(0)
    End Sub

    Private Sub frmHR_PreviewPersonnelDetails_EducationBackground_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub LoadAndDisplayEducationLevel(tableIndex As Integer)
        Try
            dgvEducationalSchool.ClearSelection()
            dgvEducationalSchool.Rows.Clear()
            ClearTextBoxes(Me)
            Preview_Personnel_EducationBackground_ByID(dataSet)
            DisplayEducationLevel(tableIndex, dataSet)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrimaryEducation_Click(sender As Object, e As EventArgs) Handles btnPrimaryEducation.Click
        LoadAndDisplayEducationLevel(0)
    End Sub

    Private Sub btnSecondaryEducation_Click(sender As Object, e As EventArgs) Handles btnSecondaryEducation.Click
        LoadAndDisplayEducationLevel(1)
    End Sub

    Private Sub btnSeniorHighEducation_Click(sender As Object, e As EventArgs) Handles btnSeniorHighEducation.Click
        LoadAndDisplayEducationLevel(6)
    End Sub

    Private Sub btnTertiaryEducation_Click(sender As Object, e As EventArgs) Handles btnTertiaryEducation.Click
        LoadAndDisplayEducationLevel(2)
    End Sub

    Private Sub btnMasteralEducation_Click(sender As Object, e As EventArgs) Handles btnMasteralEducation.Click
        LoadAndDisplayEducationLevel(3)
    End Sub

    Private Sub btnDoctorateEducation_Click(sender As Object, e As EventArgs) Handles btnDoctorateEducation.Click
        LoadAndDisplayEducationLevel(4)
    End Sub

    Private Sub btnVocationalEducation_Click(sender As Object, e As EventArgs) Handles btnVocationalEducation.Click
        LoadAndDisplayEducationLevel(5)
    End Sub

    Private Sub dgvEducationalSchool_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEducationalSchool.CellClick
        If dgvEducationalSchool.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEducationalSchool.SelectedRows(0)
            With Me
                .txtSchool.Text = selectedRow.Cells(0).Value
                .txtDegree.Text = selectedRow.Cells(3).Value
                .txtSchoolAddress.Text = selectedRow.Cells(2).Value
                .txtSchoolContact.Text = selectedRow.Cells(4).Value
                .txtAwardsRecognition.Text = selectedRow.Cells(5).Value
            End With
        End If
    End Sub
End Class