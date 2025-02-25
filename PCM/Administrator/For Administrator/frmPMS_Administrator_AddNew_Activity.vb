Imports System.Windows.Forms
Imports System.Linq
Public Class frmPMS_Administrator_AddNew_Activity


    Private Sub frmPMS_Administrator_AddNew_Activity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtboxDate.Enabled = False
        Sel_projectList(dgvEmployeeList)
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtboxProject.Text = Nothing Then
            MessageBox.Show("Cannot be empty field for Project.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtboxHourRender.Text = Nothing Then
            MessageBox.Show("Please input Hour / time rendered.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtboxActivity.Text = Nothing Then
            MessageBox.Show("Please input Actvity.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtboxProject.TextLength < 8 Then
            MessageBox.Show(" Select Project to tag .", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If _strFiledDocs = "VL" Then
            If txtboxHourRender.Text > 4 Then
                MessageBox.Show("Cannot tag more than 4 hours (half day).", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If _strFiledDocs = "SL" Then
                If txtboxHourRender.Text > 4 Then
                    MessageBox.Show("Cannot tag more than 4 hours (half day).", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            End If
        End If

        If _strIsFlexiSched = "False" Then
            If txtboxHourRender.Text > 8 Then
                MessageBox.Show("Cannot tag more than 8 Regular hours.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        End If

        Insert_ProjectCharge_Administrator()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        If MessageBox.Show("Discard input?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Administrator_ProjectCharge_Clear()
            Insert_PayrollPeriod_Details(frmPMS_Administrator.dgvPayrollPeriodDetails)
            Me.Dispose()
        End If

    End Sub

    Private Sub bntLoadProject_Click(sender As Object, e As EventArgs) Handles bntLoadProject.Click
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

    Private Sub txtboxHourRender_TextChanged(sender As Object, e As EventArgs) Handles txtboxHourRender.TextChanged
        IsNumeric(txtboxHourRender.Text)
    End Sub
End Class
