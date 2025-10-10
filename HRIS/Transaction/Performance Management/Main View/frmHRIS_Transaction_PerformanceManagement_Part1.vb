Public Class frmHRIS_Transaction_PerformanceManagement_Part1

    Private Sub frmHRIS_Transaction_PerformanceManagement_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_PMAS_ActiveEmployeeList(dgvActiveEmployee, txtboxSearch, toolstriplabelNoOfRecord)
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Employee"
                btnSearchFilter.Text = "Project Name"
            Case Else
                btnSearchFilter.Text = "Employee"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If btnSearchFilter.Text = "Employee" Then
            Call Sel_PMAS_ActiveEmployeeList(dgvActiveEmployee, txtboxSearch, toolstriplabelNoOfRecord)
            ToolStripLabelEmployeeName.Visible = False
            dgvPerformanceRecordPart1.Rows.Clear()
        Else
            Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
            ' Proceed if a valid grid is found
            If dgvPerformanceRecordPart1 IsNot Nothing Then
                Dim matchFound As Boolean = False
                For Each row As DataGridViewRow In dgvPerformanceRecordPart1.Rows
                    If Not row.IsNewRow Then
                        If keyword = "" Then
                            row.Visible = True
                            matchFound = True
                        Else
                            Dim cellValue As String = row.Cells(11).Value?.ToString().ToLower()
                            Dim isMatch As Boolean = (cellValue IsNot Nothing AndAlso cellValue.Contains(keyword))
                            row.Visible = isMatch
                            If isMatch Then matchFound = True
                        End If
                    End If
                Next

                ' Show message if no match found and keyword is not empty
                If Not matchFound AndAlso keyword <> "" Then
                    MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub dgvActiveEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActiveEmployee.CellClick
        Call UnselectDataGridView(dgvActiveEmployee)
        lblPart1.Visible = False
        dgvPerformanceRecordPart2.Rows.Clear()
        If dgvActiveEmployee.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvActiveEmployee.SelectedRows(0)
            _strEmployeeID = selectedRow.Cells(0).Value
            ToolStripLabelEmployeeName.Visible = True
            ToolStripLabelEmployeeName.Text = selectedRow.Cells(2).Value & " [ " & selectedRow.Cells(1).Value & " ]"
            _EmployeeName = ToolStripLabelEmployeeName.Text
            _EmployeePosition = selectedRow.Cells(3).Value
            _EmployeeDepartment = selectedRow.Cells(4).Value
            Call Sel_PMAS_Part1Form1_ByEmployeeID(dgvPerformanceRecordPart1)
        End If
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvActiveEmployee IsNot excludeDataGridView Then
            dgvActiveEmployee.ClearSelection()
        End If

        If dgvPerformanceRecordPart1 IsNot excludeDataGridView Then
            dgvPerformanceRecordPart1.ClearSelection()
        End If

        If dgvPerformanceRecordPart2 IsNot excludeDataGridView Then
            dgvPerformanceRecordPart2.ClearSelection()
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
        If Not HasUserAccess("insert") Then Return
        If dgvActiveEmployee.SelectedRows.Count > 0 Then
            'Call Sel_PMAS_isEmployeeTechnical_ByID()
            'Call ShowSubMenuForm_List(New PerformanceManagementSubMenu_Part1(), btnCreateNew)
            frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.ShowDialog()
        ElseIf dgvPerformanceRecordPart1.SelectedRows.Count > 0 Then
            frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2.ShowDialog()
        Else
            MessageBox.Show("Invalid Selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not HasUserAccess("update") Then Return
        If dgvPerformanceRecordPart1.SelectedRows.Count > 0 Then
            If dgvPerformanceRecordPart2.Rows.Count <> 0 Then
                MessageBox.Show("You cannot make edits at this point because the Summary Sheet has already been saved. Please delete it first if you wish to proceed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            isUpdate = True
            frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.ShowDialog()
        ElseIf dgvPerformanceRecordPart2.SelectedRows.Count > 0 Then
            isUpdate = True
            frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2.ShowDialog()
        Else
            MessageBox.Show("Please select from the active table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvPerformanceRecordPart1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerformanceRecordPart1.CellClick
        Call UnselectDataGridView(dgvPerformanceRecordPart1)
        If dgvPerformanceRecordPart1.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvPerformanceRecordPart1.SelectedRows(0)
            _strPerformancePart1Form1ID = selectedRow.Cells(0).Value
            lblPart1.Text = selectedRow.Cells(1).Value & " - " & selectedRow.Cells(2).Value
            lblPart1.Visible = True
            Call Sel_PMAS_Part1Form2_ByForm1ID(dgvPerformanceRecordPart2)
        End If
    End Sub

    Private Sub dgvPerformanceRecordPart1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerformanceRecordPart1.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        If dgvPerformanceRecordPart2.Rows.Count <> 0 Then
            MessageBox.Show("You cannot make edits at this point because the Summary Sheet has already been saved. Please delete it first if you wish to proceed.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        isUpdate = True
        frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.ShowDialog()
    End Sub

    Private Sub dgvPerformanceRecordPart2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerformanceRecordPart2.CellClick
        Call UnselectDataGridView(dgvPerformanceRecordPart2)
        If dgvPerformanceRecordPart2.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvPerformanceRecordPart2.SelectedRows(0)
            _strPerformancePart1Form2ID = selectedRow.Cells(0).Value
            lblPart2.Text = selectedRow.Cells(1).Value
            lblPart1.Visible = True
        End If
    End Sub

    Private Sub dgvPerformanceRecordPart2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerformanceRecordPart2.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        isUpdate = True
        frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2.ShowDialog()
    End Sub

    Private Sub ToolStripButtonPrint_Click(sender As Object, e As EventArgs) Handles ToolStripButtonPrint.Click
        If Not HasUserAccess("print") Then Return
        If dgvPerformanceRecordPart1.SelectedRows.Count > 0 Then
            Call PrintRPT_PMAS_Part1Form1()
        ElseIf dgvPerformanceRecordPart2.SelectedRows.Count > 0 Then
            'Call Check_ProjectNumber_Part1Form2() 'R0
            Call PrintRPT_PMAS_Part1Form2_POSS() 'R1
        Else
            MessageBox.Show("Action not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_PMAS_Part1Form1_ByEmployeeID(dgvPerformanceRecordPart1)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If Not HasUserAccess("print") Then Return
        If dgvPerformanceRecordPart1.SelectedRows.Count > 0 Then
            Call PrintRPT_PMAS_Part1Form1()
        Else
            MessageBox.Show("Action not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If Not HasUserAccess("print") Then Return
        If dgvPerformanceRecordPart2.SelectedRows.Count > 0 Then
            Call PrintRPT_PMAS_Part1Form2_POSS() 'R1
        Else
            MessageBox.Show("Action not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If Not HasUserAccess("delete") Then Return
        If dgvPerformanceRecordPart2.Rows.Count > 0 Then
            MessageBox.Show("Please delete Summary Sheet first.", "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Call Del_PMAS_Part1Form1_ByID(dgvPerformanceRecordPart1)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If Not HasUserAccess("delete") Then Return
        Call Del_PMAS_Part1Form2_ByID(dgvPerformanceRecordPart2)
    End Sub

    Private Sub ToolStripMenuItemForm1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemForm1.Click
        If Not HasUserAccess("insert") Then Return
        frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.ShowDialog()
    End Sub

    Private Sub PartIFormIIPerformanceOutputUpTo8ProjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartIFormIIPerformanceOutputUpTo8ProjectsToolStripMenuItem.Click
        If Not HasUserAccess("insert") Then Return
        frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2.ShowDialog()
    End Sub

End Class