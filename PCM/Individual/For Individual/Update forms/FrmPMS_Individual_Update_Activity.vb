Imports System.Windows.Forms

Public Class FrmPMS_Individual_Update_Activity



    Private Sub FrmPMS_Administrator_Update_Activity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxDate.Enabled = False
        ' Sel_projectList(dgvEmployeeList)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub txtboxActivity_TextChanged(sender As Object, e As EventArgs) Handles txtboxActivity.TextChanged

    End Sub

    Private Sub txtboxHourRender_TextChanged(sender As Object, e As EventArgs) Handles txtboxHourRender.TextChanged
        IsNumeric(txtboxHourRender.Text)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        SelectUpdate_ProjectChargeDetails_ByProjectChargeID()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If MessageBox.Show("Are you sure you want to apply this changes?", "E-PCM System", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            InsertUpdate_ProjectChargeDetails()

        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If MessageBox.Show("Are you sure you want to remove this activity?", "E-PCM System", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            Delete_ProjectChargeDetails()

        End If

    End Sub

    Private Sub FrmPMS_Individual_Update_Activity_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If FrmPMS_Individual_ViewActivity.dgvProjectTagList.Rows.Count = 0 Then
            FrmPMS_Individual_ViewActivity.Dispose()
        End If

    End Sub



    Private Sub bntLoadProject_Click_1(sender As Object, e As EventArgs) Handles bntLoadProject.Click
        Search_projectList(dgvEmployeeList, txtboxProject)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtboxProject.Clear()
        Search_projectList(dgvEmployeeList, txtboxProject)
    End Sub

    Private Sub dgvEmployeeList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellContentClick

    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick
        If e.ColumnIndex = -1 Or e.RowIndex = -1 Then Return   ''This code is to prevent from error when clicking header of DGV button. 8/22/2022

        If _strUserLevel = "Individual" Then
            If dgvEmployeeList.Columns(e.ColumnIndex).Name = "Column4" Then
                txtboxProject.Text = dgvEmployeeList.Rows(e.RowIndex).Cells(1).Value.ToString() + " - " + dgvEmployeeList.Rows(e.RowIndex).Cells(2).Value.ToString()
            End If
        End If

        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            txtboxProject.Text = dgvEmployeeList.Rows(e.RowIndex).Cells(1).Value.ToString() + " - " + dgvEmployeeList.Rows(e.RowIndex).Cells(2).Value.ToString()
        End If
    End Sub

    Private Sub txtboxProject_TextChanged(sender As Object, e As EventArgs) Handles txtboxProject.TextChanged

    End Sub

    Private Sub txtboxProject_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxProject.KeyDown
        If e.KeyCode = Keys.Enter Then
            bntLoadProject.PerformClick()
        End If
    End Sub
End Class
