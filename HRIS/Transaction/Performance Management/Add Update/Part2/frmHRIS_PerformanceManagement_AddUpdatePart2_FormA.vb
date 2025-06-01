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

        Select_PMAS_Part2FormA_Value(dgvA1, dgvA2, dgvA3, dgvA4, dgvA5, dgvA6, dgvA7, dgvA8, dgvA9, dgvA10)

        dgvA1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvA2.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvA3.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvA4.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvA5.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvA6.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvA7.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvA8.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvA9.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvA10.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        InitializeSelectionList(dgvA1.RowCount, A1)
        InitializeSelectionList(dgvA2.RowCount, A2)
        InitializeSelectionList(dgvA3.RowCount, A3)
        InitializeSelectionList(dgvA4.RowCount, A4)
        InitializeSelectionList(dgvA5.RowCount, A5)
        InitializeSelectionList(dgvA6.RowCount, A6)
        InitializeSelectionList(dgvA7.RowCount, A7)
        InitializeSelectionList(dgvA8.RowCount, A8)
        InitializeSelectionList(dgvA9.RowCount, A9)
        InitializeSelectionList(dgvA10.RowCount, A10)

    End Sub

    ' Make sure A1 is initialized to hold the selected checkbox per row
    Private Sub InitializeSelectionList(rowCount As Integer, lst As List(Of Integer))
        lst.Clear()
        For i As Integer = 0 To rowCount - 1
            lst.Add(0) ' 0 means no checkbox selected yet
        Next
    End Sub

    Private Sub dgvA1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA1.CellContentClick
        ' Only proceed if checkbox column and valid row
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            ' Uncheck all checkboxes in the same row except clicked one
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA1.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            ' Toggle the clicked checkbox manually
            Dim currentValue As Boolean = Convert.ToBoolean(dgvA1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            dgvA1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

            ' Update your A1 list accordingly:
            ' If the checkbox is now checked, store its mapped value (e.ColumnIndex - 1)
            ' If unchecked, store -1 (no selection)
            If Not currentValue Then
                ' Checkbox just got checked
                A1(e.RowIndex) = e.ColumnIndex - 1  ' This matches column 2=1, 6=5 logic (columnIndex-1)
            Else
                ' Checkbox just got unchecked
                A1(e.RowIndex) = 0
            End If
        End If
    End Sub

    Private Sub dgvA2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA2.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA2.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim currentValue As Boolean = Convert.ToBoolean(dgvA2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            dgvA2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

            If Not currentValue Then
                A2(e.RowIndex) = e.ColumnIndex - 1
            Else
                A2(e.RowIndex) = 0
            End If
        End If
    End Sub

    Private Sub dgvA3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA3.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA3.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim currentValue As Boolean = Convert.ToBoolean(dgvA3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            dgvA3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

            If Not currentValue Then
                A3(e.RowIndex) = e.ColumnIndex - 1
            Else
                A3(e.RowIndex) = 0
            End If
        End If
    End Sub

    Private Sub dgvA4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA4.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA4.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim currentValue As Boolean = Convert.ToBoolean(dgvA4.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            dgvA4.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

            If Not currentValue Then
                A4(e.RowIndex) = e.ColumnIndex - 1
            Else
                A4(e.RowIndex) = 0
            End If
        End If
    End Sub

    Private Sub dgvA5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA5.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA5.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim currentValue As Boolean = Convert.ToBoolean(dgvA5.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            dgvA5.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

            If Not currentValue Then
                A5(e.RowIndex) = e.ColumnIndex - 1
            Else
                A5(e.RowIndex) = 0
            End If
        End If
    End Sub

    Private Sub dgvA6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA6.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA6.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim currentValue As Boolean = Convert.ToBoolean(dgvA6.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            dgvA6.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

            If Not currentValue Then
                A6(e.RowIndex) = e.ColumnIndex - 1
            Else
                A6(e.RowIndex) = 0
            End If
        End If
    End Sub

    Private Sub dgvA7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA7.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA7.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim currentValue As Boolean = Convert.ToBoolean(dgvA7.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            dgvA7.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

            If Not currentValue Then
                A7(e.RowIndex) = e.ColumnIndex - 1
            Else
                A7(e.RowIndex) = 0
            End If
        End If
    End Sub

    Private Sub dgvA8_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA8.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA8.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim currentValue As Boolean = Convert.ToBoolean(dgvA8.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            dgvA8.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

            If Not currentValue Then
                A8(e.RowIndex) = e.ColumnIndex - 1
            Else
                A8(e.RowIndex) = 0
            End If
        End If
    End Sub

    Private Sub dgvA9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA9.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA9.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim currentValue As Boolean = Convert.ToBoolean(dgvA9.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            dgvA9.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

            If Not currentValue Then
                A9(e.RowIndex) = e.ColumnIndex - 1
            Else
                A9(e.RowIndex) = 0
            End If
        End If
    End Sub

    Private Sub dgvA10_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvA10.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 2 AndAlso e.ColumnIndex <= 6 Then
            For col As Integer = 2 To 6
                If col <> e.ColumnIndex Then
                    dgvA10.Rows(e.RowIndex).Cells(col).Value = False
                End If
            Next

            Dim currentValue As Boolean = Convert.ToBoolean(dgvA10.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            dgvA10.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not currentValue

            If Not currentValue Then
                A10(e.RowIndex) = e.ColumnIndex - 1
            Else
                A10(e.RowIndex) = 0
            End If
        End If
    End Sub

    Private Sub btnNextTab1_Click(sender As Object, e As EventArgs) Handles btnNextTab1.Click
        If A1.Contains(0) Then ' only next if all rows has selected and the list does not contain id = 0
            MessageBox.Show("You may have missed a selection. Please double-check and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        TabControl1.SelectedTab = TabPage2
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
        Me.Close()
    End Sub

    'Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
    '    MsgBox("IDs: " & String.Join(", ", A2))
    'End Sub


End Class