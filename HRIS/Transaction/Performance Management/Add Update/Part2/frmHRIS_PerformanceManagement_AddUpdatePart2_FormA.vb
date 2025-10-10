Public Class frmHRIS_PerformanceManagement_AddUpdatePart2_FormA

    Public A1 As New List(Of Integer)
    Public A2 As New List(Of Integer)
    Public A3 As New List(Of Integer)
    Public A4 As New List(Of Integer)
    Public A5 As New List(Of Integer)
    Public A6 As New List(Of Integer)
    Public A7 As New List(Of Integer)
    Public A8 As New List(Of Integer)
    Public A9 As New List(Of Integer)
    Public A10 As New List(Of Integer)

    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtEmployeeName.Text = _EmployeeName
        txtDepartment.Text = _EmployeeDepartment
        txtPosition.Text = _EmployeePosition
        txtEmploymentStatus.Text = _EmployeeStatus

        Call UpdateEachLabelForFactorWeight()

        If isUpdate Then

            Call SelUpd_PMAS_Part2FormA_Value(dgvA1, dgvA2, dgvA3, dgvA4, dgvA5, dgvA6, dgvA7, dgvA8, dgvA9, dgvA10, _strPerformancePart2FormAID)
            Call UpdateTotalTFW(txtTFW1, A1, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW1)
            Call UpdateTotalTFW(txtTFW2, A2, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW2)
            Call UpdateTotalTFW(txtTFW3, A3, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW3)
            Call UpdateTotalTFW(txtTFW4, A4, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW4)
            Call UpdateTotalTFW(txtTFW5, A5, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW5)
            Call UpdateTotalTFW(txtTFW6, A6, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW6)
            Call UpdateTotalTFW(txtTFW7, A7, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW7)
            Call UpdateTotalTFW(txtTFW8, A8, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW8)
            Call UpdateTotalTFW(txtTFW9, A9, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW9)
            Call UpdateTotalTFW(txtTFW10, A10, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW10)

        Else

            If hasInitialized Then Exit Sub
            hasInitialized = True

            Call Select_PMAS_Part2FormA_Value(dgvA1, dgvA2, dgvA3, dgvA4, dgvA5, dgvA6, dgvA7, dgvA8, dgvA9, dgvA10)
            Call InitializeSelectionList(dgvA1.RowCount, A1)
            Call InitializeSelectionList(dgvA2.RowCount, A2)
            Call InitializeSelectionList(dgvA3.RowCount, A3)
            Call InitializeSelectionList(dgvA4.RowCount, A4)
            Call InitializeSelectionList(dgvA5.RowCount, A5)
            Call InitializeSelectionList(dgvA6.RowCount, A6)
            Call InitializeSelectionList(dgvA7.RowCount, A7)
            Call InitializeSelectionList(dgvA8.RowCount, A8)
            Call InitializeSelectionList(dgvA9.RowCount, A9)
            Call InitializeSelectionList(dgvA10.RowCount, A10)

        End If

    End Sub

    ' Make sure A1 is initialized to hold the selected checkbox per row
    Private Sub InitializeSelectionList(rowCount As Integer, lst As List(Of Integer))
        lst.Clear()
        For i As Integer = 0 To rowCount - 1
            lst.Add(0) ' 0 means no checkbox selected yet
        Next
    End Sub

    Private Sub UpdateEachLabelForFactorWeight()
        For i As Integer = 1 To 10
            Dim txtFW = CType(frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.Controls.Find($"txtFW{i}", True).FirstOrDefault(), TextBox)
            Dim lblFW = CType(Me.Controls.Find($"lblA{i}FW", True).FirstOrDefault(), Label)

            If txtFW IsNot Nothing AndAlso lblFW IsNot Nothing Then
                Dim weightText = txtFW.Text
                lblFW.Text = $"Average Rating x Factor Weight [{weightText}%] = Weighted Score:"
            End If
        Next
    End Sub

    Private Sub UpdateTotalTFW(txtTFW As TextBox, lst As List(Of Integer), txtFW As TextBox)
        Dim sum As Integer = lst.Sum()
        Dim count As Integer = lst.Count
        Dim weightPercent As Decimal

        If Decimal.TryParse(txtFW.Text.Replace("%", ""), weightPercent) AndAlso count > 0 Then
            Dim weightFactor As Decimal = weightPercent / 100D
            Dim result As Decimal = (sum / count) * weightFactor
            txtTFW.Text = result.ToString("F2")
        Else
            txtTFW.Text = "0.00"
        End If
    End Sub

    'Private Sub dgvA1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA1.CellContentClick


    'End Sub

    Private Sub dgvA1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA1.CellClick
        ' Proceed only for valid row and checkbox columns 2 to 6
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            ' Uncheck all checkboxes in the same row except the clicked one
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA1.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            ' Toggle the clicked checkbox
            Dim cell As DataGridViewCheckBoxCell = CType(dgvA1.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            ' Force the grid to commit the edit so UI updates immediately
            dgvA1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgvA1.EndEdit()

            ' Update A1 tracking array
            If newValue Then
                A1(e.RowIndex) = e.ColumnIndex - 1
            Else
                A1(e.RowIndex) = 0
            End If

            ' Update total weight logic
            UpdateTotalTFW(txtTFW1, A1, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW1)

            ' Redraw to apply formatting changes
            dgvA1.Invalidate()
        End If
    End Sub

    'Private Sub dgvA2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA2.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgvA2.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgvA2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgvA2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            A2(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            A2(e.RowIndex) = 0
    '        End If

    '        UpdateTotalTFW(txtTFW2, A2, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW2)
    '    End If
    'End Sub

    'Private Sub dgvA3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA3.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgvA3.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgvA3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgvA3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            A3(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            A3(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW3, A3, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW3)
    '    End If
    'End Sub

    'Private Sub dgvA4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA4.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgvA4.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgvA4.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgvA4.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            A4(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            A4(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW4, A4, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW4)
    '    End If
    'End Sub

    'Private Sub dgvA5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA5.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgvA5.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgvA5.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgvA5.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            A5(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            A5(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW5, A5, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW5)
    '    End If
    'End Sub

    'Private Sub dgvA6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA6.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgvA6.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgvA6.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgvA6.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            A6(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            A6(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW6, A6, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW6)
    '    End If
    'End Sub

    'Private Sub dgvA7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA7.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgvA7.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgvA7.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgvA7.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            A7(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            A7(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW7, A7, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW7)
    '    End If
    'End Sub

    'Private Sub dgvA8_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA8.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgvA8.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgvA8.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgvA8.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            A8(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            A8(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW8, A8, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW8)
    '    End If
    'End Sub

    'Private Sub dgvA9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA9.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgvA9.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgvA9.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgvA9.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            A9(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            A9(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW9, A9, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW9)
    '    End If
    'End Sub

    'Private Sub dgvA10_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA10.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgvA10.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgvA10.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgvA10.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            A10(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            A10(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW10, A10, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW10)
    '    End If
    'End Sub

    Private Sub btnNextTab1_Click(sender As Object, e As EventArgs) Handles btnNextTab1.Click
        If A1.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage2
        'MsgBox("IDs: " & String.Join(", ", A1))
    End Sub

    Private Sub btnNextTab2_Click(sender As Object, e As EventArgs) Handles btnNextTab2.Click
        If A2.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub btnNextTab3_Click(sender As Object, e As EventArgs) Handles btnNextTab3.Click
        If A3.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub btnNextTab4_Click(sender As Object, e As EventArgs) Handles btnNextTab4.Click
        If A4.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub btnNextTab5_Click(sender As Object, e As EventArgs) Handles btnNextTab5.Click
        If A5.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub btnNextTab6_Click(sender As Object, e As EventArgs) Handles btnNextTab6.Click
        If A6.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage7
    End Sub

    Private Sub btnNextTab7_Click(sender As Object, e As EventArgs) Handles btnNextTab7.Click
        If A7.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage8
    End Sub

    Private Sub btnNextTab8_Click(sender As Object, e As EventArgs) Handles btnNextTab8.Click
        If A8.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage9
    End Sub

    Private Sub btnNextTab9_Click(sender As Object, e As EventArgs) Handles btnNextTab9.Click
        If A9.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage10
    End Sub

    Private Sub btnNextTab10_Click(sender As Object, e As EventArgs) Handles btnNextTab10.Click
        Dim allLists As List(Of List(Of Integer)) = New List(Of List(Of Integer)) From {A1, A2, A3, A4, A5, A6, A7, A8, A9, A10}

        For i As Integer = 0 To allLists.Count - 1
            If allLists(i).Contains(0) Then
                Dim factorNumber As Integer = i + 1
                MessageBox.Show($"You may have missed a selection in Factor {factorNumber}. Please double-check and try again.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next

        InsUpd_PMAS_Part2FormA()
    End Sub

    Private Sub btnPrevTab10_Click(sender As Object, e As EventArgs) Handles btnPrevTab10.Click
        TabControl1.SelectedTab = TabPage9
    End Sub

    Private Sub btnPrevTab9_Click(sender As Object, e As EventArgs) Handles btnPrevTab9.Click
        TabControl1.SelectedTab = TabPage8
    End Sub

    Private Sub btnPrevTab8_Click(sender As Object, e As EventArgs) Handles btnPrevTab8.Click
        TabControl1.SelectedTab = TabPage7
    End Sub

    Private Sub btnPrevTab7_Click(sender As Object, e As EventArgs) Handles btnPrevTab7.Click
        TabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub btnPrevTab6_Click(sender As Object, e As EventArgs) Handles btnPrevTab6.Click
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub btnPrevTab5_Click(sender As Object, e As EventArgs) Handles btnPrevTab5.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub btnPrevTab4_Click(sender As Object, e As EventArgs) Handles btnPrevTab4.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub btnPrevTab3_Click(sender As Object, e As EventArgs) Handles btnPrevTab3.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnPrevTab2_Click(sender As Object, e As EventArgs) Handles btnPrevTab2.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btnBackTab1_Click(sender As Object, e As EventArgs) Handles btnBackTab1.Click
        Me.Hide()
    End Sub

    Private Sub lblA1FW_TextChanged(sender As Object, e As EventArgs) Handles lblA1FW.TextChanged
        UpdateTotalTFW(txtTFW1, A1, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW1)
    End Sub

    Private Sub lblA2FW_TextChanged(sender As Object, e As EventArgs) Handles lblA2FW.TextChanged
        UpdateTotalTFW(txtTFW2, A2, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW2)
    End Sub

    Private Sub lblA3FW_TextChanged(sender As Object, e As EventArgs) Handles lblA3FW.TextChanged
        UpdateTotalTFW(txtTFW3, A3, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW3)
    End Sub

    Private Sub lblA4FW_TextChanged(sender As Object, e As EventArgs) Handles lblA4FW.TextChanged
        UpdateTotalTFW(txtTFW4, A4, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW4)
    End Sub

    Private Sub lblA5FW_TextChanged(sender As Object, e As EventArgs) Handles lblA5FW.TextChanged
        UpdateTotalTFW(txtTFW5, A5, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW5)
    End Sub

    Private Sub lblA6FW_TextChanged(sender As Object, e As EventArgs) Handles lblA6FW.TextChanged
        UpdateTotalTFW(txtTFW6, A6, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW6)
    End Sub

    Private Sub lblA7FW_TextChanged(sender As Object, e As EventArgs) Handles lblA7FW.TextChanged
        UpdateTotalTFW(txtTFW7, A7, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW7)
    End Sub

    Private Sub lblA8FW_TextChanged(sender As Object, e As EventArgs) Handles lblA8FW.TextChanged
        UpdateTotalTFW(txtTFW8, A8, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW8)
    End Sub

    Private Sub lblA9FW_TextChanged(sender As Object, e As EventArgs) Handles lblA9FW.TextChanged
        UpdateTotalTFW(txtTFW9, A9, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW9)
    End Sub

    Private Sub lblA10FW_TextChanged(sender As Object, e As EventArgs) Handles lblA10FW.TextChanged
        UpdateTotalTFW(txtTFW10, A10, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW10)
    End Sub

    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call ClearDataGridViewRows(Me)
        Call ClearTextBoxes(Me)
    End Sub

    Private Sub dgvA2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA2.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA2.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgvA2.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgvA2.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgvA2.EndEdit()

            If newValue Then
                A2(e.RowIndex) = e.ColumnIndex - 1
            Else
                A2(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW2, A2, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW2)
            dgvA2.Invalidate()
        End If
    End Sub

    Private Sub dgvA3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA3.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA3.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgvA3.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgvA3.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgvA3.EndEdit()

            If newValue Then
                A3(e.RowIndex) = e.ColumnIndex - 1
            Else
                A3(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW3, A3, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW3)
            dgvA3.Invalidate()
        End If
    End Sub

    Private Sub dgvA4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA4.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA4.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgvA4.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgvA4.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgvA4.EndEdit()

            If newValue Then
                A4(e.RowIndex) = e.ColumnIndex - 1
            Else
                A4(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW4, A4, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW4)
            dgvA4.Invalidate()
        End If
    End Sub

    Private Sub dgvA5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA5.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA5.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgvA5.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgvA5.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgvA5.EndEdit()

            If newValue Then
                A5(e.RowIndex) = e.ColumnIndex - 1
            Else
                A5(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW5, A5, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW5)
            dgvA5.Invalidate()
        End If
    End Sub

    Private Sub dgvA6_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA6.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA6.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgvA6.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgvA6.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgvA6.EndEdit()

            If newValue Then
                A6(e.RowIndex) = e.ColumnIndex - 1
            Else
                A6(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW6, A6, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW6)
            dgvA6.Invalidate()
        End If
    End Sub

    Private Sub dgvA7_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA7.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA7.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgvA7.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgvA7.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgvA7.EndEdit()

            If newValue Then
                A7(e.RowIndex) = e.ColumnIndex - 1
            Else
                A7(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW7, A7, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW7)
            dgvA7.Invalidate()
        End If
    End Sub

    Private Sub dgvA8_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA8.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA8.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgvA8.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgvA8.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgvA8.EndEdit()

            If newValue Then
                A8(e.RowIndex) = e.ColumnIndex - 1
            Else
                A8(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW8, A8, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW8)
            dgvA8.Invalidate()
        End If
    End Sub

    Private Sub dgvA9_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA9.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA9.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgvA9.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgvA9.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgvA9.EndEdit()

            If newValue Then
                A9(e.RowIndex) = e.ColumnIndex - 1
            Else
                A9(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW9, A9, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW9)
            dgvA9.Invalidate()
        End If
    End Sub

    Private Sub dgvA10_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA10.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA10.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgvA10.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgvA10.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgvA10.EndEdit()

            If newValue Then
                A10(e.RowIndex) = e.ColumnIndex - 1
            Else
                A10(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW10, A10, frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.txtFW10)
            dgvA10.Invalidate()
        End If
    End Sub

    Private Sub ApplyCheckboxCellFormatting(grid As DataGridView, e As DataGridViewCellFormattingEventArgs, minColumnIndex As Integer, maxColumnIndex As Integer)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= minColumnIndex AndAlso e.ColumnIndex <= maxColumnIndex Then
            Dim cell As DataGridViewCheckBoxCell = TryCast(grid.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            If cell IsNot Nothing AndAlso Convert.ToBoolean(cell.Value) Then
                e.CellStyle.BackColor = Color.Navy
                e.CellStyle.ForeColor = Color.White
            End If
        End If
    End Sub

    Private Sub dgvA1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvA1.CellFormatting
        ApplyCheckboxCellFormatting(dgvA1, e, 2, 6)
    End Sub

    Private Sub dgvA2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvA2.CellFormatting
        ApplyCheckboxCellFormatting(dgvA2, e, 2, 6)
    End Sub

    Private Sub dgvA3_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvA3.CellFormatting
        ApplyCheckboxCellFormatting(dgvA3, e, 2, 6)
    End Sub

    Private Sub dgvA4_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvA4.CellFormatting
        ApplyCheckboxCellFormatting(dgvA4, e, 2, 6)
    End Sub

    Private Sub dgvA5_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvA5.CellFormatting
        ApplyCheckboxCellFormatting(dgvA5, e, 2, 6)
    End Sub

    Private Sub dgvA6_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvA6.CellFormatting
        ApplyCheckboxCellFormatting(dgvA6, e, 2, 6)
    End Sub

    Private Sub dgvA7_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvA7.CellFormatting
        ApplyCheckboxCellFormatting(dgvA7, e, 2, 6)
    End Sub

    Private Sub dgvA8_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvA8.CellFormatting
        ApplyCheckboxCellFormatting(dgvA8, e, 2, 6)
    End Sub

    Private Sub dgvA9_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvA9.CellFormatting
        ApplyCheckboxCellFormatting(dgvA9, e, 2, 6)
    End Sub

    Private Sub dgvA10_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvA10.CellFormatting
        ApplyCheckboxCellFormatting(dgvA10, e, 2, 6)
    End Sub

    'Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
    '    MsgBox("IDs: " & String.Join(", ", A2))
    'End Sub


End Class