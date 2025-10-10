Imports System.ComponentModel

Public Class frmFMIS_Setup_AddUpdChartOfAccounts

    Private Sub frmFMIS_Setup_AddUpdChartOfAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DropDownListCashFlow(cbCashFlow)

        Dim action As String = If(isUpdate, "Üpdating", "Add New")
        lblHeader.Text = $"{action} Level {_LevelID} Account"

        Select Case _LevelID
            Case 1
                txtType.Text = frmFMIS_Setup_ChartOfAccounts.lblAccountType.Text
                If isUpdate Then
                    Call SelUpd_Setup_ChartOfAccounts_Level1_ByID()
                    Exit Sub
                End If
                _ChartLevel1ID = 0 'set to ID = 0 to trigger insert in stored procedure
            Case 2
                txtType.Text = frmFMIS_Setup_ChartOfAccounts.lblCategory1.Text
                If isUpdate Then
                    Call SelUpd_Setup_ChartOfAccounts_Level2_ByID()
                    Exit Sub
                End If
                _ChartLevel2ID = 0
            Case 3
                txtType.Text = frmFMIS_Setup_ChartOfAccounts.lblCategory2.Text
                If isUpdate Then
                    Call SelUpd_Setup_ChartOfAccounts_Level3_ByID()
                    Exit Sub
                End If
                _ChartLevel3ID = 0
        End Select

    End Sub

    Private Sub txtBalance_TextChanged(sender As Object, e As EventArgs) Handles txtBalance.TextChanged

    End Sub

    Private Sub txtBalance_Validating(sender As Object, e As CancelEventArgs) Handles txtBalance.Validating
        Call Textbox_NumericFormat(txtBalance, e.Cancel)
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        If Not isUpdate Then
            txtTitle.Clear()
        End If

        cbCashFlow.SelectedIndex = -1
        txtBalance.Text = "0.00"
        txtRemarks.Clear()
        chActive.Checked = False
        chContra.Checked = False

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrWhiteSpace(txtTitle.Text) OrElse String.IsNullOrWhiteSpace(cbCashFlow.Text) Then
            MessageBox.Show("Error, please fill up account title and its cash flow category.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If _LevelID = 1 Then
            InsUpd_Setup_ChartOfAccounts_Level1()
            frmFMIS_Setup_ChartOfAccounts.Level1_Balance()
        ElseIf _LevelID = 2 Then
            InsUpd_Setup_ChartOfAccounts_Level2()
            frmFMIS_Setup_ChartOfAccounts.Level2_Balance()
        ElseIf _LevelID = 3 Then
            InsUpd_Setup_ChartOfAccounts_Level3()
            frmFMIS_Setup_ChartOfAccounts.Level3_Balance()
        Else
            MessageBox.Show("Error Occured: Level unidentified.", "EAS 2.0 --[System Notice]--", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub frmFMIS_Setup_AddUpdChartOfAccounts_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
        UncheckCheckBoxes(Me)
        frmFMIS_Setup_ChartOfAccounts.ClearDataGridViewSelection()
        txtBalance.Text = "0.00"
        _LevelID = 0
        isUpdate = False
    End Sub

End Class