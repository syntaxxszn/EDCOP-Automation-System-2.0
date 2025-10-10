Imports System.ComponentModel

Public Class frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values

    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SelPopulate_ActivePart1Form1BList(cbPart1, 0)
        Call SelPopulate_EmployeeName(cbReviewer)

        If isUpdate Then
            isPopulating = True
            Call SelPopulate_ActivePart1Form1BList(cbPart1, _strPerformancePart2FormBID)
            Call SelUpd_PMAS_Part2FormB_ByID()
            isPopulating = False
            Exit Sub
        End If

        _strPerformancePart2FormBID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ClearTextBoxes(Me)
        Call ResetComboBoxes(Me)
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Dispose()
    End Sub

    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart2_FormB_Values_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call ClearTextBoxes(Me)
        Call ResetComboBoxes(Me)
        isUpdate = False
        hasInitialized = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If String.IsNullOrWhiteSpace(cbPart1.Text) OrElse
            String.IsNullOrWhiteSpace(cbReviewer.Text) Then
            MessageBox.Show("Error! Please select from the dropdowns as it is required.")
            Return
        End If

        Dim total As Decimal = 0
        For i = 1 To 8
            Dim t = Me.Controls($"txtFW{i}")
            Dim val As Decimal
            Decimal.TryParse(t.Text, val)
            total += val
        Next

        If total <> 100D Then 'FW must be equal to 100%
            MessageBox.Show($"Total factor weight must be 100%. Current total: {total}%", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        frmHRIS_PerformanceManagement_AddUpdatePart2_FormB.ShowDialog()
    End Sub

    Private Sub cbPart1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPart1.SelectedIndexChanged
        Dim selectedID As String = cbPart1.SelectedItem?.ToString()
        Dim idDictionary As Dictionary(Of String, Integer) = CType(cbPart1.Tag, Dictionary(Of String, Integer))
        _strPerformancePart1Form1ID = If(selectedID IsNot Nothing AndAlso idDictionary.ContainsKey(selectedID), idDictionary(selectedID), -1)
    End Sub

    Private Sub txtFW1_Validating(sender As Object, e As CancelEventArgs) Handles txtFW1.Validating
        Textbox_NumericFormat(txtFW1, e.Cancel)
    End Sub

    Private Sub txtFW2_Validating(sender As Object, e As CancelEventArgs) Handles txtFW2.Validating
        Textbox_NumericFormat(txtFW2, e.Cancel)
    End Sub

    Private Sub txtFW3_Validating(sender As Object, e As CancelEventArgs) Handles txtFW3.Validating
        Textbox_NumericFormat(txtFW3, e.Cancel)
    End Sub

    Private Sub txtFW4_Validating(sender As Object, e As CancelEventArgs) Handles txtFW4.Validating
        Textbox_NumericFormat(txtFW4, e.Cancel)
    End Sub

    Private Sub txtFW5_Validating(sender As Object, e As CancelEventArgs) Handles txtFW5.Validating
        Textbox_NumericFormat(txtFW5, e.Cancel)
    End Sub

    Private Sub txtFW6_Validating(sender As Object, e As CancelEventArgs) Handles txtFW6.Validating
        Textbox_NumericFormat(txtFW6, e.Cancel)
    End Sub

    Private Sub txtFW7_Validating(sender As Object, e As CancelEventArgs) Handles txtFW7.Validating
        Textbox_NumericFormat(txtFW7, e.Cancel)
    End Sub

    Private Sub txtFW8_Validating(sender As Object, e As CancelEventArgs) Handles txtFW8.Validating
        Textbox_NumericFormat(txtFW8, e.Cancel)
    End Sub

End Class