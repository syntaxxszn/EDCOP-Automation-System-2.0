Public Class frmFMIS_Setup_BeginningSubsidiaries

    Private Sub frmFMIS_Setup_BeginningSubsidiaries_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Setup_Beginning_Subsidiary(dgvSubsidiaryType, toolstriplabelNoOfRecord)
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        Call Sel_Setup_Beginning_Subsidiary(dgvSubsidiaryType, toolstriplabelNoOfRecord)
        SubsidiaryTypeID = 0
        SubsidiaryAccountID = 0
        lblHeader.Text = ""
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Public Sub UnselectDataGridView(Optional ByVal excludeDataGridView As DataGridView = Nothing)
        If dgvSubsidiaryType IsNot excludeDataGridView Then
            dgvSubsidiaryType.ClearSelection()
        End If

        If dgvSubsidiaryAccount IsNot excludeDataGridView Then
            dgvSubsidiaryAccount.ClearSelection()
        End If

        If dgvAccountTitle IsNot excludeDataGridView Then
            dgvAccountTitle.ClearSelection()
        End If
    End Sub

    Private Sub dgvSubsidiaryType_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubsidiaryType.CellContentClick

    End Sub

    Private Sub dgvSubsidiaryType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubsidiaryType.CellClick
        UnselectDataGridView(dgvSubsidiaryType)
        If dgvSubsidiaryType.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvSubsidiaryType.SelectedRows(0)
            SubsidiaryTypeID = selectedRow.Cells(0).Value
            lblHeader.Text = selectedRow.Cells(1).Value
            SubsidiaryAccountID = 0
            lblDetail.Visible = False
            dgvAccountTitle.Rows.Clear()
            Call Sel_Setup_BeginningSubsidiary_Account_ByID(dgvSubsidiaryAccount)
        End If
    End Sub

    Private Sub dgvSubsidiaryAccount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubsidiaryAccount.CellContentClick

    End Sub

    Private Sub dgvSubsidiaryAccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubsidiaryAccount.CellClick
        UnselectDataGridView(dgvSubsidiaryAccount)
        If dgvSubsidiaryAccount.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvSubsidiaryAccount.SelectedRows(0)
            SubsidiaryAccountID = selectedRow.Cells(0).Value
            frmFMIS_Setup_AddUpdSubsidiaryDetail.txtName.Text = selectedRow.Cells(2).Value
            lblDetail.Text = selectedRow.Cells(2).Value
            lblSubDetail.Visible = False
            Call Sel_Setup_BeginningSubsidiary_Account_Detail_ByID(dgvAccountTitle)
        End If
    End Sub

    Private Sub lblDetail_TextChanged(sender As Object, e As EventArgs) Handles lblDetail.TextChanged
        lblDetail.Visible = True
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click

        If SubsidiaryTypeID = 0 Then
            MessageBox.Show("Please select Subsidiary Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf SubsidiaryAccountID = 0 Then
            MessageBox.Show("Please select Subsidiary Account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            frmFMIS_Setup_AddUpdSubsidiaryDetail.ShowDialog()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If SubsidiaryTypeID = 0 Then
            MessageBox.Show("Please select Subsidiary Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf SubsidiaryAccountID = 0 Then
            MessageBox.Show("Please select Subsidiary Account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            isUpdate = True
            frmFMIS_Setup_AddUpdSubsidiaryDetail.ShowDialog()
        End If

    End Sub

    Private Sub AddNewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewAccountToolStripMenuItem.Click
        frmFMIS_Setup_AddUpdSubsidiaryDetail.ShowDialog()
    End Sub

    Private Sub EditProjectDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProjectDetailToolStripMenuItem.Click
        If dgvSubsidiaryAccount.SelectedRows.Count > 0 AndAlso SubsidiaryAccountID <> 0 Then
            Exit Sub
        End If
        isUpdate = True
        frmFMIS_Setup_AddUpdSubsidiaryDetail.ShowDialog()
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        Select Case btnSearchFilter.Text
            Case "Subsidiary Type"
                btnSearchFilter.Text = "Subsidiary Account"
            Case "Subsidiary Account"
                btnSearchFilter.Text = "Account Title"
            Case Else
                btnSearchFilter.Text = "Subsidiary Type"
        End Select
        txtboxSearch.Clear()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged

        Dim keyword As String = txtboxSearch.Text.Trim().ToLower()

        ' Require 3 chars (unless cleared)
        If keyword.Length < 3 AndAlso keyword <> "" Then Exit Sub

        frmLoading.Show()
        frmLoading.Refresh()

        Try
            Call Sel_Setup_BeginningSubsidiary_Account_ByID(dgvSubsidiaryAccount)
        Finally
            frmLoading.Close()
        End Try

    End Sub

    Private Sub dgvSubsidiaryAccount_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubsidiaryAccount.CellDoubleClick
        If dgvSubsidiaryAccount.SelectedRows.Count > 0 AndAlso SubsidiaryAccountID <> 0 Then
            Exit Sub
        End If
        isUpdate = True
        frmFMIS_Setup_AddUpdSubsidiaryDetail.ShowDialog()
    End Sub

End Class