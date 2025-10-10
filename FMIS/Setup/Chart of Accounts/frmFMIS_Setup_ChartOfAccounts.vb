Public Class frmFMIS_Setup_ChartOfAccounts

    Private Sub frmFMIS_Setup_ChartOfAccounts_External_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_ChartOfAccounts_External_AccountCategory(dgvAccountType)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click

        If dgvLevel1.SelectedRows.Count > 0 Then
            Call Sel_Setup_ChartOfAccounts_Level1(dgvLevel1)
        ElseIf dgvLevel2.SelectedRows.Count > 0 Then
            Call Sel_Setup_ChartOfAccounts_Level2(dgvLevel2)
        ElseIf dgvLevel3.SelectedRows.Count > 0 Then
            Call Sel_Setup_ChartOfAccounts_Level3(dgvLevel3)
        Else
            Call Sel_Setup_ChartOfAccounts_External_AccountCategory(dgvAccountType)
        End If

    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click

        If dgvLevel1.SelectedRows.Count > 0 Then
            _LevelID = 1
            Call Sel_Setup_ChartOfAccounts_Level1_Code(frmFMIS_Setup_AddUpdChartOfAccounts.txtCode)
            If frmFMIS_Setup_AddUpdChartOfAccounts.txtCode.Text = "" Then Exit Sub
            frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()
        ElseIf dgvLevel2.SelectedRows.Count > 0 Then
            _LevelID = 2
            Call Sel_Setup_ChartOfAccounts_Level2_Code(frmFMIS_Setup_AddUpdChartOfAccounts.txtCode)
            If frmFMIS_Setup_AddUpdChartOfAccounts.txtCode.Text = "" Then Exit Sub
            frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()
        ElseIf dgvLevel3.SelectedRows.Count > 0 Then
            _LevelID = 3
            Call Sel_Setup_ChartOfAccounts_Level3_Code(frmFMIS_Setup_AddUpdChartOfAccounts.txtCode)
            If frmFMIS_Setup_AddUpdChartOfAccounts.txtCode.Text = "" Then Exit Sub
            frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()
        Else
            MessageBox.Show("Unknown Action.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        isUpdate = True
        If dgvLevel1.SelectedRows.Count > 0 Then
            _LevelID = 1
            frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()
        ElseIf dgvLevel2.SelectedRows.Count > 0 Then
            _LevelID = 2
            frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()
        ElseIf dgvLevel3.SelectedRows.Count > 0 Then
            _LevelID = 3
            frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()
        Else
            MessageBox.Show("Unknown Action.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            isUpdate = False
        End If

    End Sub

    Private Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvAccountType IsNot excludeDataGridView Then
            dgvAccountType.ClearSelection()
        End If

        If dgvLevel1 IsNot excludeDataGridView Then
            dgvLevel1.ClearSelection()
        End If

        If dgvLevel2 IsNot excludeDataGridView Then
            dgvLevel2.ClearSelection()
        End If

        If dgvLevel3 IsNot excludeDataGridView Then
            dgvLevel3.ClearSelection()
        End If
    End Sub

    Private Sub dgvAccountType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccountType.CellClick

        UnselectDataGridView(dgvAccountType)

        If dgvAccountType.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvAccountType.SelectedRows(0)
            _AccountCategoryID = selectedRow.Cells(0).Value
            lblAccountType.Text = selectedRow.Cells(2).Value.ToString
            Call Sel_Setup_ChartOfAccounts_Level1(dgvLevel1)
            Call Level1_Balance()
        End If

    End Sub

    Private Sub dgvLevel1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLevel1.CellClick

        UnselectDataGridView(dgvLevel1)
        If dgvLevel1.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvLevel1.SelectedRows(0)
            _ChartLevel1ID = selectedRow.Cells(0).Value
            lblCategory1.Text = selectedRow.Cells(2).Value.ToString
            '_ChartAccountID = _ChartCategory1ID
            Call Sel_Setup_ChartOfAccounts_Level2(dgvLevel2)
            Call Level2_Balance()
        End If

    End Sub

    Private Sub lblAccountType_TextChanged(sender As Object, e As EventArgs) Handles lblAccountType.TextChanged

        lblAccountType.Visible = True
        lblCategory1.Text = String.Empty
        dgvLevel2.Rows.Clear()
        lblCategory2.Text = String.Empty
        dgvLevel3.Rows.Clear()
        lblCategory3.Text = String.Empty
        txtCategory1Discrepancy.Visible = False
        txtCategory2Discrepancy.Visible = False
        lblCategory2Balance.Text = "0.00"
        lblCategory3Balance.Text = "0.00"

    End Sub

    Public Sub Level1_Balance()

        Dim totalYES As Decimal = 0, totalNO As Decimal = 0
        For Each row As DataGridViewRow In dgvLevel1.Rows
            If row.IsNewRow Then Continue For
            Dim amount As Decimal
            If Decimal.TryParse(row.Cells("lvl1BeginAmount").Value.ToString(), amount) Then
                If row.Cells("lvl1Contra").Value.ToString() = "YES" Then
                    totalYES += amount
                ElseIf row.Cells("lvl1Contra").Value.ToString() = "NO" Then
                    totalNO += amount
                End If
            End If
        Next
        lblCategory1Balance.Text = (totalNO - totalYES).ToString("N2")

    End Sub

    Private Sub dgvLevel1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLevel1.CellDoubleClick
        _LevelID = 1
        isUpdate = True
        frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()
    End Sub

    Private Sub lblCategory1_TextChanged(sender As Object, e As EventArgs) Handles lblCategory1.TextChanged

        lblCategory1.Visible = True
        lblCategory2.Text = String.Empty
        dgvLevel3.Rows.Clear()
        lblCategory3.Text = String.Empty
        txtCategory2Discrepancy.Visible = False
        lblCategory3Balance.Text = "0.00"

    End Sub

    Public Sub Level2_Balance()

        Dim totalYES As Decimal = 0, totalNO As Decimal = 0
        For Each row As DataGridViewRow In dgvLevel2.Rows
            If row.IsNewRow Then Continue For
            Dim amount As Decimal
            If Decimal.TryParse(row.Cells("lvl2BeginAmount").Value.ToString(), amount) Then
                If row.Cells("lvl2Contra").Value.ToString() = "YES" Then
                    totalYES += amount
                ElseIf row.Cells("lvl2Contra").Value.ToString() = "NO" Then
                    totalNO += amount
                End If
            End If
        Next
        lblCategory2Balance.Text = (totalNO - totalYES).ToString("N2")

        txtCategory1Discrepancy.Text = (CDec(lblCategory1Balance.Text) - CDec(lblCategory2Balance.Text)).ToString("N2")

    End Sub


    Private Sub dgvLevel2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLevel2.CellContentClick

    End Sub

    Private Sub dgvLevel2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLevel2.CellClick

        UnselectDataGridView(dgvLevel2)
        If dgvLevel2.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvLevel2.SelectedRows(0)
            _ChartLevel2ID = selectedRow.Cells(0).Value
            lblCategory2.Text = selectedRow.Cells(2).Value.ToString
            Call Sel_Setup_ChartOfAccounts_Level3(dgvLevel3)
            Call Level3_Balance()
        End If

        lblCategory3.Text = String.Empty

    End Sub

    Public Sub Level3_Balance()

        Dim totalYES As Decimal = 0, totalNO As Decimal = 0
        For Each row As DataGridViewRow In dgvLevel3.Rows
            If row.IsNewRow Then Continue For
            Dim amount As Decimal
            If Decimal.TryParse(row.Cells("lvl3BeginAmount").Value.ToString(), amount) Then
                If row.Cells("lvl3Contra").Value.ToString() = "YES" Then
                    totalYES += amount
                ElseIf row.Cells("lvl3Contra").Value.ToString() = "NO" Then
                    totalNO += amount
                End If
            End If
        Next
        lblCategory3Balance.Text = (totalNO - totalYES).ToString("N2")

        txtCategory2Discrepancy.Text = (CDec(lblCategory2Balance.Text) - CDec(lblCategory3Balance.Text)).ToString("N2")

    End Sub

    Private Sub dgvLevel2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLevel2.CellDoubleClick

        _LevelID = 2
        isUpdate = True
        frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()

    End Sub

    Private Sub lblCategory2_TextChanged(sender As Object, e As EventArgs) Handles lblCategory2.TextChanged
        lblCategory2.Visible = True
    End Sub

    Private Sub dgvLevel3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLevel3.CellContentClick

    End Sub

    Private Sub dgvLevel3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLevel3.CellClick

        UnselectDataGridView(dgvLevel3)
        If dgvLevel3.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvLevel3.SelectedRows(0)
            _ChartLevel3ID = selectedRow.Cells(0).Value
            lblCategory3.Text = selectedRow.Cells(2).Value.ToString
        End If

    End Sub

    Private Sub dgvLevel3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLevel3.CellDoubleClick

        _LevelID = 3
        isUpdate = True
        frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()

    End Sub

    Private Sub AddNewLevel1AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewLevel1AccountToolStripMenuItem.Click

        If dgvAccountType.SelectedRows.Count > 0 Then

            _LevelID = 1
            Call Sel_Setup_ChartOfAccounts_Level1_Code(frmFMIS_Setup_AddUpdChartOfAccounts.txtCode)
            frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()

        End If

    End Sub

    Private Sub EditThisAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditThisAccountToolStripMenuItem.Click

        _LevelID = 1
        isUpdate = True
        frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()

    End Sub

    Private Sub DeleteThisAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisAccountToolStripMenuItem.Click

        If dgvLevel2.Rows.Count <> 0 Then
            MessageBox.Show("This account has child account associated with it. The system can not proceed with the deletion.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Del_Setup_ChartOfAccounts_Level1_ByID(dgvLevel1)

    End Sub

    Private Sub AddNewLevel2AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewLevel2AccountToolStripMenuItem.Click

        If dgvLevel1.SelectedRows.Count > 0 Then

            _LevelID = 2
            Call Sel_Setup_ChartOfAccounts_Level2_Code(frmFMIS_Setup_AddUpdChartOfAccounts.txtCode)
            frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()

        End If

    End Sub

    Private Sub AddNewLevel3AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewLevel3AccountToolStripMenuItem.Click

        If dgvLevel2.SelectedRows.Count > 0 Then

            _LevelID = 3
            Call Sel_Setup_ChartOfAccounts_Level3_Code(frmFMIS_Setup_AddUpdChartOfAccounts.txtCode)
            frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()

        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        _LevelID = 2
        isUpdate = True
        frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click

        _LevelID = 3
        isUpdate = True
        frmFMIS_Setup_AddUpdChartOfAccounts.ShowDialog()

    End Sub

    Private Sub lblCategory3_TextChanged(sender As Object, e As EventArgs) Handles lblCategory3.TextChanged
        lblCategory3.Visible = True
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

        If dgvLevel3.Rows.Count <> 0 Then
            MessageBox.Show("This account has child account associated with it. The system can not proceed with the deletion.", "EAS 2.0 [System Notice]", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Del_Setup_ChartOfAccounts_Level2_ByID(dgvLevel2)

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Del_Setup_ChartOfAccounts_Level3_ByID(dgvLevel3)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click

        If _AccountCategoryID = 0 Then Return
        Call Sel_Setup_ChartOfAccounts_Level1(dgvLevel1)
        Call Level1_Balance()

    End Sub

    Private Sub txtCategory1Discrepancy_TextChanged(sender As Object, e As EventArgs) Handles txtCategory1Discrepancy.TextChanged
        txtCategory1Discrepancy.Visible = Not (txtCategory1Discrepancy.Text = "0.00" Or txtCategory1Discrepancy.Text = lblCategory1Balance.Text)
    End Sub

    Private Sub txtCategory2Discrepancy_TextChanged(sender As Object, e As EventArgs) Handles txtCategory2Discrepancy.TextChanged
        txtCategory2Discrepancy.Visible = Not (txtCategory2Discrepancy.Text = "0.00" Or txtCategory2Discrepancy.Text = lblCategory2Balance.Text)
    End Sub

    Public Sub ClearDataGridViewSelection()
        dgvAccountType.ClearSelection()
        dgvLevel1.ClearSelection()
        dgvLevel2.ClearSelection()
        dgvLevel3.ClearSelection()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()
        Dim targetGrid As DataGridView = Nothing

        ' Determine which grid to work with based on button text
        Select Case btnSearchFilter.Text
            Case "Account"
                targetGrid = dgvAccountType
            Case "Level 1"
                targetGrid = dgvLevel1
            Case "Level 2"
                targetGrid = dgvLevel2
            Case "Level 3"
                targetGrid = dgvLevel3
        End Select

        ' Proceed if a valid grid is found
        If targetGrid IsNot Nothing Then
            targetGrid.Visible = True

            Dim matchFound As Boolean = False

            For Each row As DataGridViewRow In targetGrid.Rows
                If Not row.IsNewRow Then
                    If keyword = "" Then
                        row.Visible = True
                        matchFound = True
                    Else
                        Dim cellValue As String = row.Cells(2).Value?.ToString().ToLower()
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

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click

        Select Case btnSearchFilter.Text
            Case "Account"
                btnSearchFilter.Text = "Level 1"
            Case "Level 1"
                btnSearchFilter.Text = "Level 2"
            Case "Level 2"
                btnSearchFilter.Text = "Level 3"
            Case Else
                btnSearchFilter.Text = "Account"
        End Select
        txtboxSearch.Clear()

    End Sub

    Private Sub lblAccountType_Click(sender As Object, e As EventArgs) Handles lblAccountType.Click

    End Sub

    Private Sub lblCategory1_Click(sender As Object, e As EventArgs) Handles lblCategory1.Click

    End Sub
End Class