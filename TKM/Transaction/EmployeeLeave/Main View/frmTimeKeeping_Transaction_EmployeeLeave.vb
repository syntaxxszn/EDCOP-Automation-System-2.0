Public Class frmTimeKeeping_Transaction_EmployeeLeave

    Public lastClickedBtn As Integer = 0
    Dim mode As Boolean = True

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
        lastClickedBtn = 0
        mode = True
    End Sub

    Private Sub frmTimeKeeping_Transaction_EmployeeLeave_Load(sender As Object, e As EventArgs) Handles Me.Load
        Search_DGVPersonnel_List(dgvEmployeeList, txtboxSearch, False, Nothing)
        btnOfficialBusiness.PerformClick()
    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            _strEmployeeID = selectedRow.Cells(0).Value
            WhatToLoad()
        End If
    End Sub

    Private Sub btnOfficialBusiness_Click(sender As Object, e As EventArgs) Handles btnOfficialBusiness.Click
        switchPanelEmployeeLeave(frmTK_DataGridViewOfficialBusiness)
        ToolStripLabelFileType.Text = "O F F I C I A L   B U S I N E S S"
        lastClickedBtn = 1
        WhatToLoad()
    End Sub

    Private Sub btnOverTime_Click(sender As Object, e As EventArgs) Handles btnOverTime.Click
        switchPanelEmployeeLeave(frmTK_DataGridViewOverTime)
        ToolStripLabelFileType.Text = "O V E R T I M E"
        lastClickedBtn = 2
        WhatToLoad()
    End Sub

    Private Sub btnUnderTime_Click(sender As Object, e As EventArgs) Handles btnUnderTime.Click
        switchPanelEmployeeLeave(frmTK_DataGridViewUnderTime)
        ToolStripLabelFileType.Text = "U N D E R T I M E"
        lastClickedBtn = 3
        WhatToLoad()
    End Sub

    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click
        switchPanelEmployeeLeave(frmTK_DataGridViewLeave)
        ToolStripLabelFileType.Text = "L E A V E  /  P A I D   T I M E   O F F"
        lastClickedBtn = 4
        WhatToLoad()
    End Sub

    Private Sub btnLeaveCredits_Click(sender As Object, e As EventArgs) Handles btnLeaveCredits.Click
        switchPanelEmployeeLeave(frmTK_DataGridViewLeaveCredits)
        ToolStripLabelFileType.Text = "L E A V E  /  P A I D   T I M E   O F F   C R E D I T S"
        lastClickedBtn = 5
        WhatToLoad()
    End Sub

    Public Sub WhatToLoad()
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            toolstriplabelNoOfRecord.Text = 0
            If lastClickedBtn = 1 Then
                SelTK_Personnel_OfficialBusinessByID(frmTK_DataGridViewOfficialBusiness.dgvOfficialBusiness, toolstriplabelNoOfRecord)
                'toolstriplabelNoOfRecord.Text = frmTK_DataGridViewOfficialBusiness.dgvOfficialBusiness.RowCount.ToString()
            ElseIf lastClickedBtn = 2 Then
                SelTK_Personnel_OverTimeByID(frmTK_DataGridViewOverTime.dgvOverTime, toolstriplabelNoOfRecord)
            ElseIf lastClickedBtn = 3 Then
                SelTK_Personnel_UndertimeByID(frmTK_DataGridViewUnderTime.dgvUnderTime, toolstriplabelNoOfRecord)
            ElseIf lastClickedBtn = 4 Then
                SelTK_Personnel_LeaveByID(frmTK_DataGridViewLeave.dgvLeave, toolstriplabelNoOfRecord)
            ElseIf lastClickedBtn = 5 Then
                SelTK_Employee_Leave_Credits_By_ID(frmTK_DataGridViewLeaveCredits.dgvLeaveCredits)
                toolstriplabelNoOfRecord.Text = 1
            End If
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            If lastClickedBtn = 1 Then
                frmTK_AddUpdOfficialBusiness.ShowDialog()
            ElseIf lastClickedBtn = 2 Then
                frmTK_AddUpdOverTime.ShowDialog()
            ElseIf lastClickedBtn = 3 Then
                frmTK_AddUpdUnderTime.ShowDialog()
            ElseIf lastClickedBtn = 4 Then
                frmTK_AddUpdLeave.ShowDialog()
            ElseIf lastClickedBtn = 5 Then
                frmTK_AddUpdLeaveCredits.ShowDialog()
            End If
        Else
            MessageBox.Show("Please select an active employee first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lastClickedBtn = 1 AndAlso frmTK_DataGridViewOfficialBusiness.dgvOfficialBusiness.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = frmTK_DataGridViewOfficialBusiness.dgvOfficialBusiness.SelectedRows(0)
            If selectedRow.Cells(17).Value?.ToString() <> "Pending" Then
                MessageBox.Show("Sorry, only 'Pending' status can be edited.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frmTK_AddUpdOfficialBusiness.isUpdate = True
                frmTK_AddUpdOfficialBusiness.ShowDialog()
            End If
        ElseIf lastClickedBtn = 2 AndAlso frmTK_DataGridViewOverTime.dgvOverTime.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = frmTK_DataGridViewOverTime.dgvOverTime.SelectedRows(0)
            If selectedRow.Cells(13).Value?.ToString() <> "Pending" Then
                MessageBox.Show("Sorry, only 'Pending' status can be edited.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frmTK_AddUpdOverTime.isUpdate = True
                frmTK_AddUpdOverTime.ShowDialog()
            End If
        ElseIf lastClickedBtn = 3 AndAlso frmTK_DataGridViewUnderTime.dgvUnderTime.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = frmTK_DataGridViewUnderTime.dgvUnderTime.SelectedRows(0)
            If selectedRow.Cells(9).Value?.ToString() <> "Pending" Then
                MessageBox.Show("Sorry, only 'Pending' status can be edited.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frmTK_AddUpdUnderTime.isUpdate = True
                frmTK_AddUpdUnderTime.ShowDialog()
            End If
        ElseIf lastClickedBtn = 4 AndAlso frmTK_DataGridViewLeave.dgvLeave.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = frmTK_DataGridViewLeave.dgvLeave.SelectedRows(0)
            If selectedRow.Cells(10).Value?.ToString() <> "Pending" Then
                MessageBox.Show("Sorry, only 'Pending' status can be edited.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                frmTK_AddUpdLeave.isUpdate = True
                frmTK_AddUpdLeave.ShowDialog()
            End If
        ElseIf lastClickedBtn = 5 Then
            frmTK_AddUpdLeaveCredits.ShowDialog()
        Else
            MessageBox.Show("Please select file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        mode = Not mode
        btnSearchFilter.Text = If(mode, "Employee", "File")
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If mode Then
            Search_DGVPersonnel_List(dgvEmployeeList, txtboxSearch, False, Nothing)
            Select Case lastClickedBtn
                Case 1 : frmTK_DataGridViewOfficialBusiness.dgvOfficialBusiness.Rows.Clear()
                Case 2 : frmTK_DataGridViewOverTime.dgvOverTime.Rows.Clear()
                Case 3 : frmTK_DataGridViewUnderTime.dgvUnderTime.Rows.Clear()
                Case 4 : frmTK_DataGridViewLeave.dgvLeave.Rows.Clear()
            End Select
            toolstriplabelNoOfRecord.Text = "0"
        Else
            Select Case lastClickedBtn
                Case 1 : Search_OfficialBusiness_By_CtrlNum(frmTK_DataGridViewOfficialBusiness.dgvOfficialBusiness, txtboxSearch)
                Case 2 : Search_Overtime_By_Date(frmTK_DataGridViewOverTime.dgvOverTime, txtboxSearch)
                Case 3 : Search_Undertime_By_Date(frmTK_DataGridViewUnderTime.dgvUnderTime, txtboxSearch)
                Case 4 : Search_EmployeeLeave_By_Date(frmTK_DataGridViewLeave.dgvLeave, txtboxSearch)
            End Select
        End If
    End Sub

End Class