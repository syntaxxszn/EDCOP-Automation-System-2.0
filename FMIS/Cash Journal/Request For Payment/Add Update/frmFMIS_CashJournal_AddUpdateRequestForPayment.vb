Imports System.ComponentModel

Public Class frmFMIS_CashJournal_AddUpdateRequestForPayment

    Private Sub frmFMIS_CashJournal_AddUpdateRequestForPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DropDownList()
        Call SelRequestVoucherNumber(DateTime.Now)

        lblHeader.Text = "Add New Request For Payment Voucher"
        If isUpdate Then
            lblHeader.Text = "Updating Request For Payment Voucher"
            'SelUpdRequestVoucherByID(dgvAccountTitle)
            Call AccountTotal()
            Call DiscrepancyAmount()
        End If

        RequestVoucherID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub DropDownList()
        Call Sel_FMIS_VoucherStatus(cbStatus)
        Call Sel_FMIS_VoucherType(cbType)
        Call Sel_FMIS_VoucherDepartment(cbDepartment)
        Call Sel_FMIS_VoucherAccountTitle(cbAccountTitle)
        Call Sel_FMIS_Payee_By_TypeID(cbSubsidiary, 1)
    End Sub

    Private Sub AccountTotal()
        Dim totalAmount As Decimal = 0D
        Dim amount As Decimal
        For Each row As DataGridViewRow In dgvAccountTitle.Rows
            If row.IsNewRow Then Continue For
            If Decimal.TryParse(row.Cells(3).Value.ToString(), amount) Then
                totalAmount += amount
            End If
        Next
        lblAccountTotal.Text = totalAmount.ToString("N2")
        txtReqAmount.Text = totalAmount.ToString("N2")
    End Sub

    Private Sub DiscrepancyAmount()
        Dim paymentAmount As Decimal
        Dim accountTotal As Decimal
        If Decimal.TryParse(txtInPaymentOf.Text, paymentAmount) AndAlso Decimal.TryParse(lblAccountTotal.Text, accountTotal) Then
            lblDiscrepancyAmount.Text = (paymentAmount - accountTotal).ToString("N2")
            lblDiscrepancyAmount.ForeColor = If(paymentAmount - accountTotal <> 0D, Color.LightCoral, Color.Yellow)
        Else
            lblDiscrepancyAmount.Text = "0.00"
            lblDiscrepancyAmount.ForeColor = Color.Yellow
        End If
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbClient.CheckedChanged, rbVendor.CheckedChanged, rbEmployee.CheckedChanged, rbOthers.CheckedChanged
        cbPayee.SelectedIndex = -1
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        If rb.Checked Then
            PayeeTypeID = Convert.ToInt32(rb.Tag)
            Call Sel_FMIS_Payee_By_TypeID(cbPayee, 0)
        End If
    End Sub

    Private Sub cbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged

        cbCostCenter.SelectedIndex = -1
        cbProjectName.SelectedIndex = -1
        Dim cb As ComboBox = CType(sender, ComboBox)
        Dim deptDictionary = CType(cb.Tag, Dictionary(Of Tuple(Of Integer, Integer), String))
        If cb.SelectedIndex <> -1 AndAlso deptDictionary IsNot Nothing Then
            Dim selectedDept = cb.SelectedItem.ToString()
            For Each kvp In deptDictionary
                If kvp.Value = selectedDept Then
                    VoucherDepartmentID1 = kvp.Key.Item1
                    VoucherDepartmentID2 = kvp.Key.Item2
                    Exit For
                End If
            Next
        End If
        Call Sel_FMIS_VoucherCostCenter(cbCostCenter)
        Call Sel_FMIS_VoucherCostCenter(cbProjectName)

    End Sub

    Private Sub cbCostCenter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCostCenter.SelectedIndexChanged

        If cbCostCenter.SelectedIndex <> -1 Then
            Dim selectedCost As String = cbCostCenter.SelectedItem.ToString()
            Dim costDictionary As Dictionary(Of Tuple(Of Integer, Integer, Integer), String) = CType(cbCostCenter.Tag, Dictionary(Of Tuple(Of Integer, Integer, Integer), String))
            Dim result As New List(Of Tuple(Of Integer, Integer, Integer))()
            For Each kvp As KeyValuePair(Of Tuple(Of Integer, Integer, Integer), String) In costDictionary
                If kvp.Value = selectedCost Then
                    result.Add(kvp.Key)
                End If
            Next
            For Each key As Tuple(Of Integer, Integer, Integer) In result
                VoucherCostCenterID1 = key.Item1
                VoucherCostCenterID2 = key.Item2
                VoucherCostCenterID3 = key.Item3
            Next
        End If

    End Sub

    Private Sub cbProjectName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProjectName.SelectedIndexChanged

        If cbProjectName.SelectedIndex <> -1 Then
            Dim selectedCost As String = cbProjectName.SelectedItem.ToString()
            Dim costDictionary As Dictionary(Of Tuple(Of Integer, Integer, Integer), String) = CType(cbProjectName.Tag, Dictionary(Of Tuple(Of Integer, Integer, Integer), String))
            Dim result As New List(Of Tuple(Of Integer, Integer, Integer))()
            For Each kvp As KeyValuePair(Of Tuple(Of Integer, Integer, Integer), String) In costDictionary
                If kvp.Value = selectedCost Then
                    result.Add(kvp.Key)
                End If
            Next
            For Each key As Tuple(Of Integer, Integer, Integer) In result
                VoucherProjectNameID1 = key.Item1
                VoucherProjectNameID2 = key.Item2
                VoucherProjectNameID3 = key.Item3
            Next
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If String.IsNullOrWhiteSpace(cbAccountTitle.Text) OrElse
               String.IsNullOrWhiteSpace(txtTransactionAmount.Text) OrElse
               String.IsNullOrWhiteSpace(cbProjectName.Text) OrElse
               String.IsNullOrWhiteSpace(cbSubsidiary.Text) Then
            MessageBox.Show("Error! Please fill up all fields required.")
            Return
        End If

        Dim exists As Boolean = dgvAccountTitle.Rows.Cast(Of DataGridViewRow)().
                       Any(Function(row) CInt(row.Cells(0).Value) = VoucherAccountTitleID1)
        If exists Then
            If MessageBox.Show("Are you sure you want to update this record?", "Warning Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim selectedRow = dgvAccountTitle.SelectedRows(0)
                VoucherAccountTitleID1 = Convert.ToInt32(selectedRow.Cells(0).Value)
                selectedRow.Cells(1).Value = VoucherAccountTitleID2
                selectedRow.Cells(2).Value = cbAccountTitle.SelectedItem
                selectedRow.Cells(3).Value = txtTransactionAmount.Text
                selectedRow.Cells(4).Value = VoucherProjectNameID1
                selectedRow.Cells(5).Value = cbProjectName.SelectedItem
                selectedRow.Cells(6).Value = VoucherProjectNameID2
                selectedRow.Cells(7).Value = VoucherProjectNameID3
                selectedRow.Cells(8).Value = VoucherSubsidiaryID1
                selectedRow.Cells(9).Value = cbSubsidiary.SelectedItem
                selectedRow.Cells(10).Value = VoucherSubsidiaryID2
                selectedRow.Cells(11).Value = txtDateRange.Text
                selectedRow.Cells(12).Value = txtNoDays.Text
            End If
        Else
            VoucherAccountTitleID1 = VoucherAccountTitleID3
            Dim newRowIndex As Integer = dgvAccountTitle.Rows.Add(VoucherAccountTitleID1, VoucherAccountTitleID2, cbAccountTitle.Text, txtTransactionAmount.Text, VoucherProjectNameID1, cbProjectName.Text, VoucherProjectNameID2, VoucherProjectNameID3, VoucherSubsidiaryID1, cbSubsidiary.Text, VoucherSubsidiaryID2, txtDateRange.Text, txtNoDays.Text)
            dgvAccountTitle.Rows(newRowIndex).Tag = "New"
            VoucherAccountTitleID3 += 1
        End If

        Call AccountTotal()
        Call DiscrepancyAmount()
        Call ClearTransactionField()

    End Sub

    Private Sub ClearTransactionField()
        dgvAccountTitle.ClearSelection()
        VoucherAccountTitleID2 = 0
        VoucherProjectNameID1 = 0
        VoucherProjectNameID2 = 0
        VoucherProjectNameID3 = 0
        VoucherSubsidiaryID1 = 0
        VoucherSubsidiaryID2 = 0
        VoucherAccountTitleID1 = VoucherAccountTitleID3
        txtTransactionAmount.Clear()
        cbAccountTitle.SelectedIndex = -1
        cbProjectName.SelectedIndex = -1
        cbSubsidiary.SelectedIndex = -1
        txtNoDays.Clear()
        txtDateRange.Clear()
        btnAdd.Text = "Add"
    End Sub

    Private Sub dgvAccountTitle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccountTitle.CellContentClick

    End Sub

    Private Sub dgvAccountTitle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccountTitle.CellDoubleClick

        If dgvAccountTitle.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvAccountTitle.SelectedRows(0)
            VoucherAccountTitleID1 = selectedRow.Cells(0).Value
            VoucherAccountTitleID2 = selectedRow.Cells(1).Value
            Dim title As Integer = cbAccountTitle.FindStringExact(selectedRow.Cells(2).Value.ToString())
            If title <> -1 Then cbAccountTitle.SelectedIndex = title
            txtTransactionAmount.Text = selectedRow.Cells(3).Value
            VoucherProjectNameID1 = selectedRow.Cells(4).Value
            Dim project As Integer = cbProjectName.FindStringExact(selectedRow.Cells(5).Value.ToString())
            If project <> -1 Then cbProjectName.SelectedIndex = project
            VoucherProjectNameID2 = selectedRow.Cells(6).Value
            VoucherProjectNameID3 = selectedRow.Cells(7).Value
            VoucherSubsidiaryID1 = selectedRow.Cells(8).Value
            Dim subsidiary As Integer = cbSubsidiary.FindStringExact(selectedRow.Cells(9).Value.ToString())
            If subsidiary <> -1 Then cbSubsidiary.SelectedIndex = subsidiary
            VoucherSubsidiaryID2 = selectedRow.Cells(10).Value
            txtDateRange.Text = selectedRow.Cells(11).Value
            txtNoDays.Text = selectedRow.Cells(12).Value
            btnAdd.Text = "Update"
        End If

    End Sub

    Private Sub btnClearTransactionFields_Click(sender As Object, e As EventArgs) Handles btnClearTransactionFields.Click
        Call ClearTransactionField()
    End Sub

    Private Sub txtInPaymentOf_Validating(sender As Object, e As CancelEventArgs) Handles txtInPaymentOf.Validating
        Call Textbox_NumericFormat(txtInPaymentOf, e.Cancel)
    End Sub

    Private Sub txtTransactionAmount_Validating(sender As Object, e As CancelEventArgs) Handles txtTransactionAmount.Validating
        Call Textbox_NumericFormat(txtTransactionAmount, e.Cancel)
    End Sub

    Private Sub txtReqAmount_Validating(sender As Object, e As CancelEventArgs) Handles txtReqAmount.Validating
        Call Textbox_NumericFormat(txtReqAmount, e.Cancel)
    End Sub

    Private Sub cbPayee_Validating(sender As Object, e As CancelEventArgs) Handles cbPayee.Validating
        If cbPayee.Text = "" Then Exit Sub
        Call ValidateComboBoxSelection(CType(sender, ComboBox), e, "Please select a valid payee from the list.")
    End Sub

    Private Sub cbType_Validating(sender As Object, e As CancelEventArgs) Handles cbType.Validating
        If cbType.Text = "" Then Exit Sub
        Call ValidateComboBoxSelection(CType(sender, ComboBox), e, "Please select a valid type from the list.")
    End Sub

    Private Sub cbStatus_Validating(sender As Object, e As CancelEventArgs) Handles cbStatus.Validating
        If cbStatus.Text = "" Then Exit Sub
        Call ValidateComboBoxSelection(CType(sender, ComboBox), e, "Please select a valid status from the list.")
    End Sub

    Private Sub cbDepartment_Validating(sender As Object, e As CancelEventArgs) Handles cbDepartment.Validating
        If cbDepartment.Text = "" Then Exit Sub
        Call ValidateComboBoxSelection(CType(sender, ComboBox), e, "Please select a valid department from the list.")
    End Sub

    Private Sub cbCostCenter_Validating(sender As Object, e As CancelEventArgs) Handles cbCostCenter.Validating
        If cbCostCenter.Text = "" Then Exit Sub
        Call ValidateComboBoxSelection(CType(sender, ComboBox), e, "Please select a valid cost center from the list.")
    End Sub

    Private Sub cbAccountTitle_Validating(sender As Object, e As CancelEventArgs) Handles cbAccountTitle.Validating
        If cbAccountTitle.Text = "" Then Exit Sub
        Call ValidateComboBoxSelection(CType(sender, ComboBox), e, "Please select a valid account title from the list.")
    End Sub

    Private Sub cbProjectName_Validating(sender As Object, e As CancelEventArgs) Handles cbProjectName.Validating
        If cbProjectName.Text = "" Then Exit Sub
        Call ValidateComboBoxSelection(CType(sender, ComboBox), e, "Please select a valid project from the list.")
    End Sub

    Private Sub cbSubsidiary_Validating(sender As Object, e As CancelEventArgs) Handles cbSubsidiary.Validating
        If cbSubsidiary.Text = "" Then Exit Sub
        Call ValidateComboBoxSelection(CType(sender, ComboBox), e, "Please select a valid subsidiary from the list.")
    End Sub

    Private Sub txtReqAmount_TextChanged(sender As Object, e As EventArgs) Handles txtReqAmount.TextChanged
        Call DiscrepancyAmount()
    End Sub

    Private Sub txtInPaymentOf_TextChanged(sender As Object, e As EventArgs) Handles txtInPaymentOf.TextChanged
        Call DiscrepancyAmount()
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        Me.Close()
    End Sub

    Private Sub frmFMIS_CashJournal_AddUpdateRequestForPayment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
        ResetDatePickers(Me)
        ResetRadioButtons(Me)
        ClearDataGridViewRows(Me)
        isUpdate = False
        txtVoucherNumber.Text = "RFP-0000-000"
        txtInPaymentOf.Text = "0.00"
        txtReqAmount.Text = "0.00"
        txtTransactionAmount.Text = "0.00"
        TextBox9.Text = "0.00"
        TextBox1.Text = "0.00"
        btnAdd.Text = "Add"

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrWhiteSpace(cbPayee.Text) OrElse cbPayee.SelectedIndex = -1 OrElse
               String.IsNullOrWhiteSpace(txtParticulars.Text) OrElse
               String.IsNullOrWhiteSpace(txtInPaymentOf.Text) OrElse
               String.IsNullOrWhiteSpace(cbType.Text) OrElse
               String.IsNullOrWhiteSpace(cbStatus.Text) OrElse
               String.IsNullOrWhiteSpace(cbDepartment.Text) OrElse
               String.IsNullOrWhiteSpace(cbCostCenter.Text) OrElse
                     dgvAccountTitle.Rows.Count = 0 Then
            MessageBox.Show("Please fill up all required fields to submit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If lblDiscrepancyAmount.Text = "0.00" OrElse
          MessageBox.Show("Discrepancy found. Proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            'InsUpdRequestForPaymentVoucherAndDetail(dgvAccountTitle)
        End If

    End Sub

    Private Sub dtpVoucherDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpVoucherDate.ValueChanged
        If isUpdate Then Exit Sub
        SelRequestVoucherNumber(dtpVoucherDate.Value)
    End Sub

End Class