Public Class frmPMS_Individual

    Private Sub frmPMS_Individual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PayrollPeriod(dgvPayrollPeriod)
        Select_Employee_ByID()
    End Sub

    Private Sub dgvPayrollPeriod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayrollPeriod.CellContentClick

    End Sub

    Private Sub dgvPayrollPeriod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayrollPeriod.CellClick

        If dgvPayrollPeriod.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvPayrollPeriod.SelectedRows(0)
            _strPayPeriodID = selectedRow.Cells(0).Value
        End If
        'PayrollPeriod_Details(dgvPayrollPeriodDetails)

        Insert_PayrollPeriod_Details(dgvPayrollPeriodDetails)
        Select_Employee_ByID()

    End Sub

    Private Sub dgvPayrollPeriod_SelectionChanged(sender As Object, e As EventArgs)

        If dgvPayrollPeriod.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvPayrollPeriod.SelectedRows(0)
            _strPayPeriodID = selectedRow.Cells(0).Value
        End If

    End Sub



    Private Sub ViewMyTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMyTagToolStripMenuItem.Click

        '\\ To show or view the list of project tag on a selected date.

        If dgvPayrollPeriodDetails.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvPayrollPeriodDetails.SelectedRows(0)
            _strWorkdate = selectedRow.Cells(1).Value
            FrmPMS_Individual_ViewActivity.Label1.Text = selectedRow.Cells(4).Value
            Select_ActivityDetails(FrmPMS_Individual_ViewActivity.dgvProjectTagList)

            '-----------------------------------------------------------------------------------------

            '\\ This line is to check if the FrmPMS_Individual_ViewActivity.dgvProjectTagList is not empty.
            If FrmPMS_Individual_ViewActivity.dgvProjectTagList.Rows.Count = 0 Then
                MessageBox.Show("No Activity found on this date.", "PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                FrmPMS_Individual_ViewActivity.ShowDialog()
            End If

        End If

    End Sub

    Private Sub PrintMyWorkdayActivityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintMyWorkdayActivityToolStripMenuItem.Click
        Print_ProjectChargeDetails()
    End Sub

    Private Sub PrintTimeSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintTimeSheetToolStripMenuItem.Click
        Print_TimeSheet_byEmployee()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        PayrollPeriod(dgvPayrollPeriod)
        dgvPayrollPeriodDetails.Rows.Clear()
    End Sub


    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmPMS_Help.ShowDialog()
    End Sub

    Private Sub dgvEmployeeList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmployeeList.SelectionChanged
        dgvEmployeeList.ClearSelection()
    End Sub


    Private Sub dgvPayrollPeriodDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayrollPeriodDetails.CellContentClick


    End Sub

    Private Sub dgvPayrollPeriodDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPayrollPeriodDetails.CellFormatting

        For Each row As DataGridViewRow In dgvPayrollPeriodDetails.Rows
            If ((row.Cells("Column10").Value) = "VL") Then
                row.Cells("Column10").Style.BackColor = Color.Green
                row.Cells("Column10").Style.ForeColor = Color.White
            End If
            If ((row.Cells("Column10").Value) = "OT") Then
                row.Cells("Column10").Style.BackColor = Color.Green
                row.Cells("Column10").Style.ForeColor = Color.White
            End If
        Next

    End Sub

    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click
        '\\ Creating or adding New Activity.

        If dgvPayrollPeriodDetails.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvPayrollPeriodDetails.SelectedRows(0)
            _strWorkdate = selectedRow.Cells(1).Value
            _strFiledDocs = selectedRow.Cells(4).Value
            _strTimeIn = selectedRow.Cells(5).Value
            FrmPMS_Individual_AddNew_Activity.txtboxDate.Text = selectedRow.Cells(1).Value
        End If

        Select_PayrollPeriod_Closed_Individual()

    End Sub

    Private Sub ToolStripBtnPrintActivity_Click(sender As Object, e As EventArgs) Handles ToolStripBtnPrintActivity.Click
        MessageBox.Show("Please wait while printing load in Server..", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Print_ProjectChargeDetails()
    End Sub

    Private Sub ToolStripBtnPrintTimesheet_Click(sender As Object, e As EventArgs) Handles ToolStripBtnPrintTimesheet.Click
        MessageBox.Show("Please wait while printing load in Server..", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Print_TimeSheet_byEmployee()
    End Sub



    Private Sub UpdateTimelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateTimelogToolStripMenuItem.Click

        If dgvPayrollPeriodDetails.SelectedRows.Count > 0 Then

            Dim selectedRow = dgvPayrollPeriodDetails.SelectedRows(0)
            _strTimeSheetID = selectedRow.Cells(0).Value
            frmTS_Edit.txtboxWorkdate.Text = selectedRow.Cells(1).Value
            SelUpd_Timesheet_PerDay()
            frmTS_Edit.ShowDialog()

        End If

    End Sub

    Private Sub GetOvertimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetOvertimeToolStripMenuItem.Click

        Insert_OvertimeCharge()
        Insert_PayrollPeriod_Details(dgvPayrollPeriodDetails)

    End Sub

    Private Sub dgvEmployeeList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellContentClick

    End Sub
End Class