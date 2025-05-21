Public Class frmTK_AddUpdOtherEmployeesOfficialBusiness

    Public isUpdate As Boolean = False
    Public _AddedEmployeeID As Integer = 0

    Private Sub frmTK_AddOtherEmployeesOfficialBusiness_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvActiveEmployees.ClearSelection()
        dgvAddedEmployees.ClearSelection()
    End Sub

    Private Sub dgvActiveEmployees_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActiveEmployees.CellDoubleClick
        If dgvActiveEmployees.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In dgvActiveEmployees.SelectedRows
                If Not selectedRow.IsNewRow Then
                    Dim EmployeeID As String = selectedRow.Cells(0).Value
                    Dim EmployeeName As String = selectedRow.Cells(2).Value.ToString()
                    Dim EmployeeDept As String = selectedRow.Cells(4).Value.ToString()
                    Dim isAlreadyAdded As Boolean = False

                    If EmployeeID = _strEmployeeID Then
                        MessageBox.Show("Oopps, you cannot select this employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    For Each row As DataGridViewRow In dgvAddedEmployees.Rows
                        If Not row.IsNewRow AndAlso row.Cells(0).Value = EmployeeID Then
                            isAlreadyAdded = True
                            MessageBox.Show("Employee already exists in the table.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit For
                        End If
                    Next
                    If Not isAlreadyAdded Then
                        Dim newRow As String() = {EmployeeID, EmployeeName, EmployeeDept}
                        dgvAddedEmployees.Rows.Add(newRow)
                    End If
                End If
            Next
            dgvAddedEmployees.ClearSelection()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Search_DGVPersonnel(dgvActiveEmployees, txtSearch, False)
    End Sub

    'Private Sub btnClearTable_Click(sender As Object, e As EventArgs)
    '    If isUpdate <> 0 Then
    '        MessageBox.Show("You can not clear added employee table, if you intend to remove all added, do it one by one.", "Clear Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    Else
    '        dgvAddedEmployees.Rows.Clear()
    '    End If
    'End Sub

    Private Sub frmTK_AddOtherEmployeesOfficialBusiness_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        isUpdate = 0
        _AddedEmployeeID = 0
        ClearDataGridViewRows(Me)
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Hide()
    End Sub

    Private Sub dgvAddedEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddedEmployees.CellClick
        UnselectDataGridView(dgvAddedEmployees)
        If dgvAddedEmployees.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvAddedEmployees.SelectedRows(0)
            _AddedEmployeeID = selectedRow.Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvActiveEmployees IsNot excludeDataGridView Then
            dgvActiveEmployees.ClearSelection()
        End If

        If dgvAddedEmployees IsNot excludeDataGridView Then
            dgvAddedEmployees.ClearSelection()
        End If
    End Sub

    Private Sub dgvActiveEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActiveEmployees.CellClick
        UnselectDataGridView(dgvActiveEmployees)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If isUpdate Then
            Del_OfficialBusinessGroup_By_PersonnelID(dgvAddedEmployees)
        Else
            If dgvAddedEmployees.SelectedRows.Count > 0 Then
                dgvAddedEmployees.Rows.Remove(dgvAddedEmployees.SelectedRows(0))
            End If
        End If
        dgvActiveEmployees.ClearSelection()
    End Sub
End Class