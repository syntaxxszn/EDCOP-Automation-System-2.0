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
            Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
            ' Proceed if a valid grid is found
            If dgvPerformanceFactors IsNot Nothing Then
                Dim matchFound As Boolean = False
                For Each row As DataGridViewRow In dgvPerformanceFactors.Rows
                    If Not row.IsNewRow Then
                        If keyword = "" Then
                            row.Visible = True
                            matchFound = True
                        Else
                            Dim cellValue As String = row.Cells(1).Value?.ToString().ToLower()
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
            Call ShowSubMenuForm_List(New PerformanceManagementSubMenu_Part2(), btnCreateNew)
        Else
            MessageBox.Show("Please select from the active table before starting to edit.", "Edit Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvActiveEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActiveEmployee.CellClick
        Call UnselectDataGridView(dgvActiveEmployee)
        lblGoalSheet.Visible = False
        dgvPerformanceFactors.Rows.Clear()
        If dgvActiveEmployee.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvActiveEmployee.SelectedRows(0)
            _strEmployeeID = selectedRow.Cells(0).Value
            ToolStripLabelEmployeeName.Visible = True
            ToolStripLabelEmployeeName.Text = selectedRow.Cells(2).Value & " [ " & selectedRow.Cells(1).Value & " ]"
            _EmployeeName = ToolStripLabelEmployeeName.Text
            _EmployeePosition = selectedRow.Cells(3).Value
            _EmployeeDepartment = selectedRow.Cells(4).Value
            _EmployeeStatus = selectedRow.Cells(7).Value
            Call Sel_PMAS_Part2AllForms_ByEmployeeID(dgvPerformanceFactors)
        End If
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvActiveEmployee IsNot excludeDataGridView Then
            dgvActiveEmployee.ClearSelection()
        End If

        If dgvPerformanceFactors IsNot excludeDataGridView Then
            dgvPerformanceFactors.ClearSelection()
        End If
    End Sub

    Private Sub dgvPerformanceFactors_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerformanceFactors.CellClick
        Call UnselectDataGridView(dgvPerformanceFactors)
        lblGoalSheet.Visible = True
        If dgvPerformanceFactors.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvPerformanceFactors.SelectedRows(0)
            _strPerformancePart2FormID = selectedRow.Cells(0).Value
            lblGoalSheet.Text = selectedRow.Cells(4).Value

            If _strPerformancePart2FormID.StartsWith("A") Then 'assign back the id part to its supposed place holder
                _strPerformancePart2FormAID = CInt(_strPerformancePart2FormID.Substring(1))
            ElseIf _strPerformancePart2FormID.StartsWith("B") Then
                _strPerformancePart2FormBID = CInt(_strPerformancePart2FormID.Substring(1))
            ElseIf _strPerformancePart2FormID.StartsWith("C") Then
                _strPerformancePart2FormCID = CInt(_strPerformancePart2FormID.Substring(1))
            End If
        End If
    End Sub

    Private Sub dgvPerformanceFactors_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPerformanceFactors.CellDoubleClick
        If Not HasUserAccess("update") Then Return
        If _strPerformancePart2FormID.StartsWith("A") Then
            isUpdate = True
            frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.ShowDialog()
        ElseIf _strPerformancePart2FormID.StartsWith("B") Then
            isUpdate = True
            frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.ShowDialog()
        ElseIf _strPerformancePart2FormID.StartsWith("C") Then
            isUpdate = True
            frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripBtnPrinter_Click(sender As Object, e As EventArgs) Handles ToolStripBtnPrinter.Click
        If Not HasUserAccess("print") Then Return
        If _strPerformancePart2FormID.StartsWith("A") Then
            PrintRPT_PMAS_Part2Factor_A()
        ElseIf _strPerformancePart2FormID.StartsWith("B") Then
            PrintRPT_PMAS_Part2Factor_B()
        ElseIf _strPerformancePart2FormID.StartsWith("C") Then
            PrintRPT_PMAS_Part2Factor_C()
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        ToolStripBtnPrinter.PerformClick()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If Not HasUserAccess("delete") Then Return
        If dgvPerformanceFactors.SelectedRows.Count > 0 Then
            If _strPerformancePart2FormID.StartsWith("A") Then
                Del_PMAS_Part2FormFactorA_ByID(dgvPerformanceFactors)
            ElseIf _strPerformancePart2FormID.StartsWith("B") Then
                Del_PMAS_Part2FormFactorB_ByID(dgvPerformanceFactors)
            ElseIf _strPerformancePart2FormID.StartsWith("C") Then
                Del_PMAS_Part2FormFactorC_ByID(dgvPerformanceFactors)
            End If
        End If
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_PMAS_Part2AllForms_ByEmployeeID(dgvPerformanceFactors)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If Not HasUserAccess("insert") Then Return
        frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.ShowDialog()
    End Sub

    Private Sub PartIIPerformanceFactorBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartIIPerformanceFactorBToolStripMenuItem.Click
        If Not HasUserAccess("insert") Then Return
        frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.ShowDialog()
    End Sub

    Private Sub PartIIPerformanceFactorCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartIIPerformanceFactorCToolStripMenuItem.Click
        If Not HasUserAccess("insert") Then Return
        frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not HasUserAccess("update") Then Return
        If _strPerformancePart2FormID.StartsWith("A") Then
            isUpdate = True
            frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.ShowDialog()
        ElseIf _strPerformancePart2FormID.StartsWith("B") Then
            isUpdate = True
            frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values.ShowDialog()
        ElseIf _strPerformancePart2FormID.StartsWith("C") Then
            isUpdate = True
            frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.ShowDialog()
        End If
    End Sub
End Class