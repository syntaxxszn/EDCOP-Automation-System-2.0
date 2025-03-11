Public Class frmHR_UpdatePersonnelDetails_Contracts

    Private Sub frmHR_UpdatePersonnelDetails_Contracts_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Call SelUpd_HRIS_Personnel_ContractHistory_ByID(dgvContracts)
        'Call DropDownLists()

    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        ' Show loading form
        frmLoading.Show()
        frmLoading.Refresh() ' Force UI update before running long operations

        ' Load data
        Call SelUpd_HRIS_Personnel_ContractHistory_ByID(dgvContracts)
        Call DropDownLists()

        ' Close loading form after loading is complete
        frmLoading.Dispose()
        MyBase.OnLoad(e)
    End Sub

    Private Sub DropDownLists()
        Call DropDownListEmploymentType(cbEmploymentType)
        Call DropDownListDepartment(cbDepartment)
        Call DropDownListJobPosition(cbJobPosition)
        Call DropDownListJobClass(cbJobClassLevel)
        Call DropDownListSupervisorEmployeeName(cbSuperior)
        Call DropDownListLocation(cbLocation)
        Call DropDownListSignatoryEmployeeName(cbSignatory1)
        Call DropDownListSignatoryEmployeeName(cbSignatory2)
    End Sub

    Public Sub New()
        InitializeComponent()
        Dim menuItem1 As New ToolStripMenuItem("Add / Update Project Omnibus Contracts")
        AddHandler menuItem1.Click, AddressOf ToolStripMenuItemAddSelection_Click
        ContextMenuPojectContracts.Items.AddRange(New ToolStripItem() {menuItem1})
        dgvContracts.ContextMenuStrip = ContextMenuPojectContracts
    End Sub

    Private Sub ToolStripMenuItemAddSelection_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContextMenuPojectContracts_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuPojectContracts.Opening
        If dgvContracts.SelectedCells.Count = 0 Then e.Cancel = True
    End Sub

    Private Sub chContractEnd_CheckedChanged(sender As Object, e As EventArgs) Handles chContractEnd.CheckedChanged
        dtpContractEnd.Enabled = chContractEnd.Checked
        dtpContractEnd.Value = If(chContractEnd.Checked, dtpContractEnd.Value, New Date(1990, 1, 1))
    End Sub

    Private Sub dgvContracts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContracts.CellDoubleClick
        If dgvContracts.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvContracts.SelectedRows(0)
            txtContractNo.Text = If(selectedRow.Cells(1).Value.ToString() = "New", "", selectedRow.Cells(1).Value.ToString())
            Dim typeIndex As Integer = cbEmploymentType.FindStringExact(selectedRow.Cells(2).Value.ToString())
            If typeIndex <> -1 Then cbEmploymentType.SelectedIndex = typeIndex
            Dim deptIndex As Integer = cbDepartment.FindStringExact(selectedRow.Cells(3).Value.ToString())
            If deptIndex <> -1 Then cbDepartment.SelectedIndex = deptIndex
            dtpContractStart.Value = If(IsDate(selectedRow.Cells(4).Value), CDate(selectedRow.Cells(4).Value), New Date(1990, 1, 1))
            Dim hasValue As Boolean = Not IsDBNull(selectedRow.Cells(5).Value) AndAlso selectedRow.Cells(5).Value IsNot Nothing AndAlso selectedRow.Cells(5).Value.ToString() <> ""
            dtpContractEnd.Value = If(hasValue, CDate(selectedRow.Cells(5).Value), New Date(1990, 1, 1))
            chContractEnd.Checked = hasValue
            txtMonthlyRate.Text = selectedRow.Cells(6).Value
            txtProjectDiff.Text = selectedRow.Cells(7).Value
            Dim jobIndex As Integer = cbJobPosition.FindStringExact(selectedRow.Cells(8).Value.ToString())
            If jobIndex <> -1 Then cbJobPosition.SelectedIndex = jobIndex
            Dim classIndex As Integer = cbJobClassLevel.FindStringExact(selectedRow.Cells(9).Value.ToString())
            If classIndex <> -1 Then cbJobClassLevel.SelectedIndex = classIndex
            Dim supIndex As Integer = cbSuperior.FindStringExact(selectedRow.Cells(10).Value.ToString())
            If supIndex <> -1 Then cbSuperior.SelectedIndex = supIndex
            Dim locIndex As Integer = cbLocation.FindStringExact(selectedRow.Cells(11).Value.ToString())
            If locIndex <> -1 Then cbLocation.SelectedIndex = locIndex
            txtFieldAllowance.Text = selectedRow.Cells(12).Value
            txtContractNotes.Text = selectedRow.Cells(13).Value
            txtProjectNotes.Text = selectedRow.Cells(14).Value
            txtRemarks.Text = selectedRow.Cells(15).Value
            Dim sig1Index As Integer = cbSignatory1.FindStringExact(selectedRow.Cells(16).Value.ToString())
            If sig1Index <> -1 Then cbSignatory1.SelectedIndex = sig1Index
            Dim sig2Index As Integer = cbSignatory2.FindStringExact(selectedRow.Cells(17).Value.ToString())
            If sig2Index <> -1 Then cbSignatory2.SelectedIndex = sig2Index
            chDefaultContract.Checked = selectedRow.Cells(18).Value.ToString() = "Yes"
            chOverTimeAllowed.Checked = selectedRow.Cells(19).Value.ToString() = "Yes"
        End If
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        ClearTransactionField()
    End Sub

    Private Sub dgvContracts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContracts.CellClick
        If dgvContracts.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvContracts.SelectedRows(0)
            _ContractID1 = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub ClearTransactionField()
        dgvContracts.ClearSelection()
        ClearTextBoxes(Me)
        ResetDatePickers(Me)
        ResetComboBoxes(Me)
        chContractEnd.Checked = False
        chDefaultContract.Checked = False
        chOverTimeAllowed.Checked = False
        _ContractID1 = _ContractID2
    End Sub

    Private Sub btnAddUpdContract_Click(sender As Object, e As EventArgs) Handles btnAddUpdContract.Click
        If String.IsNullOrWhiteSpace(cbEmploymentType.Text) OrElse
            String.IsNullOrWhiteSpace(cbDepartment.Text) OrElse
            String.IsNullOrWhiteSpace(dtpContractStart.Text) OrElse
            String.IsNullOrWhiteSpace(cbJobPosition.Text) OrElse
            String.IsNullOrWhiteSpace(cbJobClassLevel.Text) OrElse
            String.IsNullOrWhiteSpace(cbSuperior.Text) OrElse
            String.IsNullOrWhiteSpace(cbLocation.Text) OrElse
            String.IsNullOrWhiteSpace(cbSignatory1.Text) OrElse
            String.IsNullOrWhiteSpace(cbSignatory2.Text) OrElse
            String.IsNullOrWhiteSpace(txtMonthlyRate.Text) Then
            MessageBox.Show("Error! Please fill up all fields required.")
            Return
        End If

        Dim exists As Boolean = dgvContracts.Rows.Cast(Of DataGridViewRow)().
        Any(Function(row) CInt(row.Cells(0).Value) = _ContractID1)

        If exists Then
            If MessageBox.Show("Are you sure you want to update this record?", "Warning Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim selectedRow = dgvContracts.SelectedRows(0)
                _ContractID1 = Convert.ToInt32(selectedRow.Cells(0).Value)
                selectedRow.Cells(2).Value = cbEmploymentType.SelectedItem
                selectedRow.Cells(3).Value = cbDepartment.SelectedItem
                selectedRow.Cells(4).Value = dtpContractStart.Value
                selectedRow.Cells(5).Value = If(chContractEnd.Checked, dtpContractEnd.Value, "")
                selectedRow.Cells(6).Value = txtMonthlyRate.Text
                selectedRow.Cells(7).Value = txtProjectDiff.Text
                selectedRow.Cells(8).Value = cbJobPosition.SelectedItem
                selectedRow.Cells(9).Value = cbJobClassLevel.SelectedItem
                selectedRow.Cells(10).Value = cbSuperior.SelectedItem
                selectedRow.Cells(11).Value = cbLocation.SelectedItem
                selectedRow.Cells(12).Value = txtFieldAllowance.Text
                selectedRow.Cells(13).Value = txtContractNotes.Text
                selectedRow.Cells(14).Value = txtProjectNotes.Text
                selectedRow.Cells(15).Value = txtRemarks.Text
                selectedRow.Cells(16).Value = cbSignatory1.SelectedItem
                selectedRow.Cells(17).Value = cbSignatory2.SelectedItem
                selectedRow.Cells(18).Value = If(chDefaultContract.Checked, "Yes", "No")
                selectedRow.Cells(19).Value = If(chOverTimeAllowed.Checked, "Yes", "No")
            End If
            Else
            Dim newRowIndex As Integer = dgvContracts.Rows.Add(_ContractID2, "New", cbEmploymentType.Text, cbDepartment.Text, dtpContractStart.Text,
                                                               If(chContractEnd.Checked, dtpContractEnd.Text, ""), txtMonthlyRate.Text, txtProjectDiff.Text,
                                                               cbJobPosition.Text, cbJobClassLevel.Text, cbSuperior.Text, cbLocation.Text, txtFieldAllowance.Text,
                                                               txtContractNotes.Text, txtProjectNotes.Text, txtRemarks.Text, cbSignatory1.Text, cbSignatory2.Text,
                                                               If(chDefaultContract.Checked, "Yes", "No"), If(chOverTimeAllowed.Checked, "Yes", "No"))
            dgvContracts.Rows(newRowIndex).Tag = "New"
            _ContractID2 += 1
        End If
        ClearTransactionField()
    End Sub

    Private Sub btnDelEducation_Click(sender As Object, e As EventArgs) Handles btnDelEducation.Click
        If dgvContracts.Rows.Count > 0 Then
            Dim lastRow As DataGridViewRow = dgvContracts.Rows(dgvContracts.Rows.Count - 1)
            If lastRow.Tag?.ToString() = "New" Then
                dgvContracts.Rows.Remove(lastRow)
            ElseIf dgvContracts.SelectedRows.Count > 0 Then
                Del_Personnel_ContractsHistory_ByID(dgvContracts)
            Else
                MsgBox("Nothing to remove.")
            End If
            ClearTransactionField()
        End If
    End Sub
End Class