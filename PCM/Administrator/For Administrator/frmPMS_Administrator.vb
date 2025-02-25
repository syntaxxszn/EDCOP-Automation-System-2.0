Public Class frmPMS_Administrator


    Private Sub frmPMS_Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PayrollPeriod(dgvPayrollPeriod)
        ' TestOpenToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ToolStripBtnNewUser_Click(sender As Object, e As EventArgs) Handles ToolStripBtnNewUser.Click
        frmPMS_UserRegistration.ShowDialog()
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvPayrollPeriod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayrollPeriod.CellContentClick

    End Sub

    Private Sub dgvPayrollPeriod_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayrollPeriod.CellClick

        If dgvPayrollPeriod.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvPayrollPeriod.SelectedRows(0)
            _strPayPeriodID = selectedRow.Cells(0).Value
        End If
        Select_EmployeeList()
        dgvPayrollPeriodDetails.Rows.Clear()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmPMS_Administrator_AddNew_Help.ShowDialog()
    End Sub

    Private Sub dgvEmployeeList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellContentClick

    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            _strEmployeeID = selectedRow.Cells(0).Value
            strEmployeeNumber = selectedRow.Cells(1).Value
            ToolStripLabel12.Text = selectedRow.Cells(2).Value
        End If

        Insert_PayrollPeriod_Details(dgvPayrollPeriodDetails)
        'PayrollPeriod_Details(dgvPayrollPeriodDetails)
    End Sub

    Private Sub dgvPayrollPeriodDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayrollPeriodDetails.CellContentClick

    End Sub

    Private Sub dgvPayrollPeriodDetails_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPayrollPeriodDetails.CellFormatting

        For Each row As DataGridViewRow In dgvPayrollPeriodDetails.Rows
            If ((row.Cells("Column13").Value) = "VL") Then
                row.Cells("Column13").Style.BackColor = Color.Green
                row.Cells("Column13").Style.ForeColor = Color.White
            End If
            If ((row.Cells("Column13").Value) = "OT") Then
                row.Cells("Column13").Style.BackColor = Color.Green
                row.Cells("Column13").Style.ForeColor = Color.White
            End If
            If ((row.Cells("Column13").Value) = "OB/FTR") Then
                row.Cells("Column13").Style.BackColor = Color.Green
                row.Cells("Column13").Style.ForeColor = Color.White
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
            frmPMS_Administrator_AddNew_Activity.txtboxDate.Text = selectedRow.Cells(1).Value
        End If

        Select_PayrollPeriod_Closed_Administrator()

    End Sub

    Private Sub ViewMyTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMyTagToolStripMenuItem.Click
        '\\ To show or view the list of project tag on a selected date.

        If dgvPayrollPeriodDetails.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvPayrollPeriodDetails.SelectedRows(0)
            FrmPMS_Individual_ViewActivity.ToolStripLabel8.Text = selectedRow.Cells(1).Value
            _strWorkdate = selectedRow.Cells(1).Value
            Select_ActivityDetails(FrmPMS_Individual_ViewActivity.dgvProjectTagList)

            '\\ This line is to check if the FrmPMS_Individual_ViewActivity.dgvProjectTagList is not empty.
            If FrmPMS_Individual_ViewActivity.dgvProjectTagList.Rows.Count = 0 Then
                MessageBox.Show("No Activity found on this date.", "PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                FrmPMS_Individual_ViewActivity.ShowDialog()
            End If

        End If

    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        '\\ To refresh list from PayPeriod , Employee list and Payroll Details. 

        PayrollPeriod(dgvPayrollPeriod)
        dgvEmployeeList.Rows.Clear()
        dgvPayrollPeriodDetails.Rows.Clear()
    End Sub

    Private Sub PrintMyWorkdayActivityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintMyWorkdayActivityToolStripMenuItem.Click
        Print_ProjectChargeDetails()
    End Sub


    Private Sub PrintTimeSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintTimeSheetToolStripMenuItem.Click
        Print_TimeSheet_byEmployee()
    End Sub


    Private Sub ToolStripBtnPrintActivity_Click(sender As Object, e As EventArgs) Handles ToolStripBtnPrintActivity.Click
        MessageBox.Show("Please wait while printing load in Server..", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Print_ProjectChargeDetails()
    End Sub

    Private Sub ToolStripBtnPrintTimesheet_Click(sender As Object, e As EventArgs) Handles ToolStripBtnPrintTimesheet.Click
        MessageBox.Show("Please wait while printing load in Server..", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Print_TimeSheet_byEmployee()
    End Sub

    Private Sub UpdateOvertimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateOvertimeToolStripMenuItem.Click
        Insert_OvertimeCharge()
        Insert_PayrollPeriod_Details(dgvPayrollPeriodDetails)
    End Sub

    Private Sub CloseThisAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseThisAttendanceToolStripMenuItem.Click

        If MessageBox.Show("Closing this attendance will be disabled any changes you want to make." & vbCrLf & "Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Insert_PayrollPeriod_Closing()
        Else
            Return
        End If

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

End Class