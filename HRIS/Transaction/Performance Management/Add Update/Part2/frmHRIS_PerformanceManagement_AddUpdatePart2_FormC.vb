Public Class frmHRIS_PerformanceManagement_AddUpdatePart2_FormC

    Public C1 As New List(Of Integer)
    Public C2 As New List(Of Integer)
    Public C3 As New List(Of Integer)
    Public C4 As New List(Of Integer)
    Public C5 As New List(Of Integer)
    Public C6 As New List(Of Integer)
    Public C7 As New List(Of Integer)
    Public C8 As New List(Of Integer)


    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtEmployeeName.Text = _EmployeeName
        txtDepartment.Text = _EmployeeDepartment
        txtPosition.Text = _EmployeePosition
        txtEmploymentStatus.Text = _EmployeeStatus

        Call UpdateEachLabelForFactorWeight()

        If isUpdate Then

            Call SelUpd_PMAS_Part2FormC_Value(dgv1, dgv2, dgv3, dgv4, dgv5, dgv6, dgv7, dgv8, _strPerformancePart2FormCID)
            Call UpdateTotalTFW(txtTFW1, C1, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW1)
            Call UpdateTotalTFW(txtTFW2, C2, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW2)
            Call UpdateTotalTFW(txtTFW3, C3, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW3)
            Call UpdateTotalTFW(txtTFW4, C4, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW4)
            Call UpdateTotalTFW(txtTFW5, C5, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW5)
            Call UpdateTotalTFW(txtTFW6, C6, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW6)
            Call UpdateTotalTFW(txtTFW7, C7, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW7)
            Call UpdateTotalTFW(txtTFW8, C8, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW8)

        Else

            If hasInitialized Then Exit Sub
            hasInitialized = True

            Call Select_PMAS_Part2FormC_Value(dgv1, dgv2, dgv3, dgv4, dgv5, dgv6, dgv7, dgv8)
            Call InitializeSelectionList(dgv1.RowCount, C1)
            Call InitializeSelectionList(dgv2.RowCount, C2)
            Call InitializeSelectionList(dgv3.RowCount, C3)
            Call InitializeSelectionList(dgv4.RowCount, C4)
            Call InitializeSelectionList(dgv5.RowCount, C5)
            Call InitializeSelectionList(dgv6.RowCount, C6)
            Call InitializeSelectionList(dgv7.RowCount, C7)
            Call InitializeSelectionList(dgv8.RowCount, C8)

        End If

    End Sub

    ' Make sure AC is initialized to hold the selected checkbox per row
    Private Sub InitializeSelectionList(rowCount As Integer, lst As List(Of Integer))
        lst.Clear()
        For i As Integer = 0 To rowCount - 1
            lst.Add(0) ' 0 means no checkbox selected yet
        Next
    End Sub

    Private Sub UpdateEachLabelForFactorWeight()
        For i As Integer = 1 To 8
            Dim txtFW = CType(frmHRIS_PerformanceManagement_AddUpdatePart2_FormA_Values.Controls.Find($"txtFW{i}", True).FirstOrDefault(), TextBox)
            Dim lblFW = CType(Me.Controls.Find($"lbl{i}FW", True).FirstOrDefault(), Label)

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

    'Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
    '    ' Only proceed if checkbox column and valid row
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        ' Uncheck all checkboxes in the same row except clicked one
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgv1.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        ' Toggle the clicked checkbox manually
    '        Dim currentValue As Boolean = Convert.ToBoolean(dgv1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgv1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        ' Update your A1 list accordingly:
    '        ' If the checkbox is now checked, store its mapped value (e.ColumnIndex - 1)
    '        ' If unchecked, store -1 (no selection)
    '        If Not currentValue Then
    '            ' Checkbox just got checked
    '            C1(e.RowIndex) = e.ColumnIndex - 1  ' This matches column 2=1, 6=5 logic (columnIndex-1)
    '        Else
    '            ' Checkbox just got unchecked
    '            C1(e.RowIndex) = 0
    '        End If

    '        UpdateTotalTFW(txtTFW1, C1, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW1)
    '    End If
    'End Sub

    'Private Sub dgv2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgv2.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgv2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgv2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            C2(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            C2(e.RowIndex) = 0
    '        End If

    '        UpdateTotalTFW(txtTFW2, C2, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW2)
    '    End If
    'End Sub

    'Private Sub dgv3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv3.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgv3.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgv3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgv3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            C3(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            C3(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW3, C3, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW3)
    '    End If
    'End Sub

    'Private Sub dgv4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv4.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgv4.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgv4.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgv4.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            C4(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            C4(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW4, C4, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW4)
    '    End If
    'End Sub

    'Private Sub dgv5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv5.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgv5.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgv5.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgv5.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            C5(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            C5(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW5, C5, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW5)
    '    End If
    'End Sub

    'Private Sub dgv6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv6.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgv6.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgv6.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgv6.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            C6(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            C6(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW6, C6, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW6)
    '    End If
    'End Sub

    'Private Sub dgv7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv7.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgv7.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgv7.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgv7.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            C7(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            C7(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW7, C7, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW7)
    '    End If
    'End Sub

    'Private Sub dgv8_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv8.CellContentClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
    '        For col As Integer = 2 To 6
    '            If col <> e.ColumnIndex Then
    '                dgv8.Rows(e.RowIndex).Cells(col).Value = False
    '            End If
    '        Next

    '        Dim currentValue As Boolean = Convert.ToBoolean(dgv8.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    '        dgv8.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

    '        If Not currentValue Then
    '            C8(e.RowIndex) = e.ColumnIndex - 1
    '        Else
    '            C8(e.RowIndex) = 0
    '        End If
    '        UpdateTotalTFW(txtTFW8, C8, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW8)
    '    End If
    'End Sub

    Private Sub btnNextTab1_Click(sender As Object, e As EventArgs) Handles btnNextTab1.Click
        If C1.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage2
        'MsgBox("IDs: " & String.Join(", ", C1))
    End Sub

    Private Sub btnNextTab2_Click(sender As Object, e As EventArgs) Handles btnNextTab2.Click
        If C2.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub btnNextTab3_Click(sender As Object, e As EventArgs) Handles btnNextTab3.Click
        If C3.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub btnNextTab4_Click(sender As Object, e As EventArgs) Handles btnNextTab4.Click
        If C4.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub btnNextTab5_Click(sender As Object, e As EventArgs) Handles btnNextTab5.Click
        If C5.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub btnNextTab6_Click(sender As Object, e As EventArgs) Handles btnNextTab6.Click
        If C6.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage7
    End Sub

    Private Sub btnNextTab7_Click(sender As Object, e As EventArgs) Handles btnNextTab7.Click
        If C7.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage8
    End Sub

    Private Sub btnNextTab8_Click(sender As Object, e As EventArgs) Handles btnNextTab8.Click
        Dim allLists As List(Of List(Of Integer)) = New List(Of List(Of Integer)) From {C1, C2, C3, C4, C5, C6, C7, C8}

        For i As Integer = 0 To allLists.Count - 1
            If allLists(i).Contains(0) Then
                Dim factorNumber As Integer = i + 1
                MessageBox.Show($"You may have missed a selection in Factor {factorNumber}. Please double-check and try again.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next

        InsUpd_PMAS_Part2FormC()
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

    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call ClearDataGridViewRows(Me)
        Call ClearTextBoxes(Me)
    End Sub

    Private Sub lbl1FW_TextChanged(sender As Object, e As EventArgs) Handles lbl1FW.TextChanged
        Call UpdateTotalTFW(txtTFW1, C1, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW1)
    End Sub

    Private Sub lbl2FW_TextChanged(sender As Object, e As EventArgs) Handles lbl2FW.TextChanged
        Call UpdateTotalTFW(txtTFW2, C2, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW2)
    End Sub

    Private Sub lbl3FW_TextChanged(sender As Object, e As EventArgs) Handles lbl3FW.TextChanged
        Call UpdateTotalTFW(txtTFW3, C3, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW3)
    End Sub

    Private Sub lbl4FW_TextChanged(sender As Object, e As EventArgs) Handles lbl4FW.TextChanged
        Call UpdateTotalTFW(txtTFW4, C4, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW4)
    End Sub

    Private Sub lbl5FW_TextChanged(sender As Object, e As EventArgs) Handles lbl5FW.TextChanged
        Call UpdateTotalTFW(txtTFW5, C5, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW5)
    End Sub

    Private Sub lbl6FW_TextChanged(sender As Object, e As EventArgs) Handles lbl6FW.TextChanged
        Call UpdateTotalTFW(txtTFW6, C6, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW6)
    End Sub

    Private Sub lbl7FW_TextChanged(sender As Object, e As EventArgs) Handles lbl7FW.TextChanged
        Call UpdateTotalTFW(txtTFW7, C7, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW7)
    End Sub

    Private Sub lbl8FW_TextChanged(sender As Object, e As EventArgs) Handles lbl8FW.TextChanged
        Call UpdateTotalTFW(txtTFW8, C8, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW8)
    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        ' Proceed only for valid row and checkbox columns 2 to 6
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            ' Uncheck all checkboxes in the same row except the clicked one
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgv1.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            ' Toggle the clicked checkbox
            Dim cell As DataGridViewCheckBoxCell = CType(dgv1.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            ' Force the grid to commit the edit so UI updates immediately
            dgv1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgv1.EndEdit()

            ' Update A1 tracking array
            If newValue Then
                C1(e.RowIndex) = e.ColumnIndex - 1
            Else
                C1(e.RowIndex) = 0
            End If

            ' Update total weight logic
            UpdateTotalTFW(txtTFW1, C1, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW1)

            ' Redraw to apply formatting changes
            dgv1.Invalidate()
        End If
    End Sub

    Private Sub dgv2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgv2.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgv2.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgv2.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgv2.EndEdit()

            If newValue Then
                C2(e.RowIndex) = e.ColumnIndex - 1
            Else
                C2(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW2, C2, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW2)
            dgv2.Invalidate()
        End If
    End Sub

    Private Sub dgv3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv3.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgv3.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgv3.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgv3.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgv3.EndEdit()

            If newValue Then
                C3(e.RowIndex) = e.ColumnIndex - 1
            Else
                C3(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW3, C3, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW3)
            dgv3.Invalidate()
        End If
    End Sub

    Private Sub dgv4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv4.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgv4.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgv4.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgv4.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgv4.EndEdit()

            If newValue Then
                C4(e.RowIndex) = e.ColumnIndex - 1
            Else
                C4(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW4, C4, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW4)
            dgv4.Invalidate()
        End If
    End Sub

    Private Sub dgv5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv5.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgv5.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgv5.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgv5.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgv5.EndEdit()

            If newValue Then
                C5(e.RowIndex) = e.ColumnIndex - 1
            Else
                C5(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW5, C5, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW5)
            dgv5.Invalidate()
        End If
    End Sub

    Private Sub dgv6_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv6.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgv6.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgv6.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgv6.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgv6.EndEdit()

            If newValue Then
                C6(e.RowIndex) = e.ColumnIndex - 1
            Else
                C6(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW6, C6, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW6)
            dgv6.Invalidate()
        End If
    End Sub

    Private Sub dgv7_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv7.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgv7.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgv7.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgv7.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgv7.EndEdit()

            If newValue Then
                C7(e.RowIndex) = e.ColumnIndex - 1
            Else
                C7(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW7, C7, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW7)
            dgv7.Invalidate()
        End If
    End Sub

    Private Sub dgv8_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv8.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgv8.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim cell As DataGridViewCheckBoxCell = CType(dgv8.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            Dim currentValue As Boolean = Convert.ToBoolean(cell.Value)
            Dim newValue As Boolean = Not currentValue
            cell.Value = newValue

            dgv8.CommitEdit(DataGridViewDataErrorContexts.Commit)
            dgv8.EndEdit()

            If newValue Then
                C8(e.RowIndex) = e.ColumnIndex - 1
            Else
                C8(e.RowIndex) = 0
            End If

            UpdateTotalTFW(txtTFW8, C8, frmHRIS_PerformanceManagement_AddUpdatePart2_FormC_Values.txtFW8)
            dgv8.Invalidate()
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

    Private Sub dgv1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv1.CellFormatting
        ApplyCheckboxCellFormatting(dgv1, e, 2, 6)
    End Sub

    Private Sub dgv2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv2.CellFormatting
        ApplyCheckboxCellFormatting(dgv2, e, 2, 6)
    End Sub

    Private Sub dgv3_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv3.CellFormatting
        ApplyCheckboxCellFormatting(dgv3, e, 2, 6)
    End Sub

    Private Sub dgv4_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv4.CellFormatting
        ApplyCheckboxCellFormatting(dgv4, e, 2, 6)
    End Sub

    Private Sub dgv5_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv5.CellFormatting
        ApplyCheckboxCellFormatting(dgv5, e, 2, 6)
    End Sub

    Private Sub dgv6_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv6.CellFormatting
        ApplyCheckboxCellFormatting(dgv6, e, 2, 6)
    End Sub

    Private Sub dgv7_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv7.CellFormatting
        ApplyCheckboxCellFormatting(dgv7, e, 2, 6)
    End Sub

    Private Sub dgv8_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv8.CellFormatting
        ApplyCheckboxCellFormatting(dgv8, e, 2, 6)
    End Sub
End Class