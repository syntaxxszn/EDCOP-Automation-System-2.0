Public Class frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2

    Public Part1Form1ID As New List(Of Integer)
    Public isUpdate As Boolean = False

    Private Sub frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Proc. : Call the function to refresh the list of available accomplished goal sheet.
        Call Select_PMAS_Part1Form1_ActiveGoalSheet(dgvActiveGoalSheet)

        If isUpdate Then
            Call Select_PMAS_Part1Form2_ActiveSummarySheet(dgvAddedGoalSheet)
            Part1Form1ID = (From r As DataGridViewRow In dgvAddedGoalSheet.Rows
                            Where Not r.IsNewRow AndAlso r.Cells(0).Value IsNot Nothing
                            Select CInt(r.Cells(0).Value)).ToList() 'save the id from the store proc to update the list
        End If
    End Sub

    Private Sub frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call ClearDataGridViewRows(Me)
        Call ClearTextBoxes(Me)
        Part1Form1ID.Clear()
        isUpdate = False
    End Sub

    Private Sub btnSendtoRight_Click(sender As Object, e As EventArgs) Handles btnSendtoRight.Click
        If dgvActiveGoalSheet.SelectedRows.Count = 0 Then Exit Sub

        For Each row As DataGridViewRow In dgvActiveGoalSheet.SelectedRows.Cast(Of DataGridViewRow).ToList()
            If row.IsNewRow Then Continue For
            Dim id = row.Cells(0).Value
            If dgvAddedGoalSheet.Rows.Cast(Of DataGridViewRow).Any(Function(r) Not r.IsNewRow AndAlso r.Cells(0).Value = id) Then Continue For
            dgvAddedGoalSheet.Rows.Add(id.ToString(), row.Cells(1).Value, row.Cells(2).Value)
            dgvActiveGoalSheet.Rows.Remove(row)

            If Part1Form1ID.Count >= 8 Then
                MessageBox.Show("Sorry, only 8 projects can be added.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Part1Form1ID.Add(id)
            End If

        Next

        dgvAddedGoalSheet.ClearSelection()
        dgvActiveGoalSheet.ClearSelection()
    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvActiveGoalSheet IsNot excludeDataGridView Then
            dgvActiveGoalSheet.ClearSelection()
        End If

        If dgvAddedGoalSheet IsNot excludeDataGridView Then
            dgvAddedGoalSheet.ClearSelection()
        End If
    End Sub

    Private Sub dgvActiveGoalSheet_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActiveGoalSheet.CellClick
        UnselectDataGridView(dgvActiveGoalSheet)
    End Sub

    Private Sub dgvAddedGoalSheet_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddedGoalSheet.CellClick
        UnselectDataGridView(dgvAddedGoalSheet)
    End Sub

    Private Sub btnSendtoLeft_Click(sender As Object, e As EventArgs) Handles btnSendtoLeft.Click
        If dgvAddedGoalSheet.SelectedRows.Count = 0 Then Exit Sub

        For Each row As DataGridViewRow In dgvAddedGoalSheet.SelectedRows.Cast(Of DataGridViewRow).ToList()
            If row.IsNewRow Then Continue For
            Dim id = row.Cells(0).Value
            If dgvActiveGoalSheet.Rows.Cast(Of DataGridViewRow).Any(Function(r) Not r.IsNewRow AndAlso r.Cells(0).Value = id) Then Continue For
            dgvActiveGoalSheet.Rows.Add(id.ToString(), row.Cells(1).Value, row.Cells(2).Value)
            dgvAddedGoalSheet.Rows.Remove(row)
            Part1Form1ID.Remove(id)
        Next

        dgvActiveGoalSheet.ClearSelection()
        dgvAddedGoalSheet.ClearSelection()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.Trim().ToLower()
        ' Proceed if a valid grid is found
        If dgvActiveGoalSheet IsNot Nothing Then
            Dim matchFound As Boolean = False
            For Each row As DataGridViewRow In dgvActiveGoalSheet.Rows
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
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'MsgBox("IDs: " & String.Join(", ", Part1Form1ID))
        If Part1Form1ID.Count > 0 Then
            If Part1Form1ID.Count <= 4 Then
                Call Select_PMAS_Part1Form2_SummarySheet_By4ID()
                frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.ShowDialog()
            Else
                Call Select_PMAS_Part1Form2_SummarySheet_By8ID()
                frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.ShowDialog()
            End If
        Else
            MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class