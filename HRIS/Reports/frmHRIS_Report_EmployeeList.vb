Public Class frmHRIS_Report_EmployeeList

    Public isButtonSelected As Integer = 0
    Public isActive As Boolean = False
    Public WhatReportType As Integer = 0

    Private Sub frmHRIS_Report_EmployeeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnActive.PerformClick()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Search_DGVPersonnel_List(dgvEmployeeList, txtboxSearch, isActive, Nothing)
    End Sub

    Private Sub btnisActive_Click(sender As Object, e As EventArgs) Handles btnActive.Click, btnInactive.Click
        Dim btn As Button = DirectCast(sender, Button)
        btnActive.BackColor = Color.White
        btnInactive.BackColor = Color.White
        btn.BackColor = Color.Gold
        isActive = (btn Is btnInactive)
        Search_DGVPersonnel_List(dgvEmployeeList, txtboxSearch, isActive, Nothing)
    End Sub

    Private Sub dgvEmployeeList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellDoubleClick
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            _strEmployeeID = selectedRow.Cells(0).Value
        End If

        If WhatReportType = 0 Then
            frmHRIS_Report_RequestPurpose.ShowDialog()
            Exit Sub
        ElseIf WhatReportType = 1 Then
            PrintRPT_Employee_201File()
            Me.Close()
        ElseIf WhatReportType = 2 Then
            PrintRPT_Employee_201FileChecklist()
            Me.Close()
        End If
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

    Private Sub frmHRIS_Report_EmployeeList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isButtonSelected = 0
        WhatReportType = 0
        isActive = False
        txtboxSearch.Clear()
    End Sub
End Class