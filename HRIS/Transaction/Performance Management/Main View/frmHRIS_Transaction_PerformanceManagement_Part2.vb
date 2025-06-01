Public Class frmHRIS_Transaction_PerformanceManagement_Part2

    Private Sub frmHRIS_Transaction_PerformanceManagement_Part2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_PMAS_ActiveEmployeeList(dgvActiveEmployee, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Employee"
                btnSearchFilter.Text = "Record"
            Case Else
                btnSearchFilter.Text = "Employee"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If btnSearchFilter.Text = "Employee" Then
            Call Sel_PMAS_ActiveEmployeeList(dgvActiveEmployee, txtboxSearch, toolstriplabelNoOfRecord)
            ToolStripLabelEmployeeName.Visible = False
            'dgvPerformanceRecordPart1.Rows.Clear()
        Else
            'Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
            '' Proceed if a valid grid is found
            'If dgvActiveEmployee IsNot Nothing Then
            '    Dim matchFound As Boolean = False
            '    For Each row As DataGridViewRow In dgvActiveEmployee.Rows
            '        If Not row.IsNewRow Then
            '            If keyword = "" Then
            '                row.Visible = True
            '                matchFound = True
            '            Else
            '                Dim cellValue As String = row.Cells(1).Value?.ToString().ToLower()
            '                Dim isMatch As Boolean = (cellValue IsNot Nothing AndAlso cellValue.Contains(keyword))
            '                row.Visible = isMatch
            '                If isMatch Then matchFound = True
            '            End If
            '        End If
            '    Next

            '    ' Show message if no match found and keyword is not empty
            '    If Not matchFound AndAlso keyword <> "" Then
            '        MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    End If
            'End If
        End If
    End Sub

    ' this is to show sub menu
    Private Sub ShowSubMenuForm_List(subMenuForm As Form, button As Button)
        ' Close existing submenu if open
        currentSubMenuForm?.Close()
        currentSubMenuForm = Nothing

        ' Show new submenu if provided
        If subMenuForm IsNot Nothing Then
            currentSubMenuForm = subMenuForm
            subMenuForm.TopLevel = True
            subMenuForm.TopMost = True

            Dim buttonLocation As Point = button.PointToScreen(Point.Empty)
            subMenuForm.Location = New Point(buttonLocation.X + (button.Width * 3.8 \ 4),
                                 buttonLocation.Y + (button.Height \ 4) - (subMenuForm.Height \ 4))

            AddHandler subMenuForm.Deactivate, AddressOf SubMenuForm_Deactivate
            subMenuForm.Show()
        End If
    End Sub

    Private Sub SubMenuForm_Deactivate(sender As Object, e As EventArgs)
        If currentSubMenuForm IsNot Nothing Then
            currentSubMenuForm.Close()
            currentSubMenuForm = Nothing
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        If dgvActiveEmployee.SelectedRows.Count > 0 Then
            'Call Sel_PMAS_isEmployeeTechnical_ByID()
            Call ShowSubMenuForm_List(New PerformanceManagementSubMenu_Part2(), btnCreateNew)
        Else
            MessageBox.Show("Please select from the active table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class