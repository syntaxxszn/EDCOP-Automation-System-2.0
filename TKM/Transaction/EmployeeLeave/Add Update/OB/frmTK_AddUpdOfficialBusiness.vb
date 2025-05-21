Public Class frmTK_AddUpdOfficialBusiness

    Public isUpdate As Boolean = False
    'Public isFormSubmitted As Boolean = False

    Private Sub frmTK_AddOfficialBusiness_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Official Business File"
        lblControlNumber.Text = "OB-0000-0000"
        DropDownListLeavePurpose(cbPurpose)
        DropDownListLeaveTransport(cbTransport)
        DepartmentChargingDropDownList(cbOverheadDept)
        'DropDownListLeaveProjectName(cbProjectName)
        'DropDownListLeaveOverHeadDept(cbOverheadDept)
        If isUpdate Then
            lblHeader.Text = "Üpdating Official Business File"
            SelUpd_OfficialBusiness_By_ID()
            SelUpd_OfficialBusinessGroup_By_ID(frmTK_AddUpdOtherEmployeesOfficialBusiness.dgvAddedEmployees)
            frmTK_AddUpdOtherEmployeesOfficialBusiness.isUpdate = True
            Exit Sub
        End If
        _OfficialBusFileID = 0 'set to ID = 0 to trigger insert in stored procedure
    End Sub

    Private Sub cbPurpose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPurpose.SelectedIndexChanged
        If cbPurpose.Text = "Others, please specify..." Then
            txtPOthers.Enabled = True
        Else
            txtPOthers.Enabled = False
            txtPOthers.Clear()
        End If
    End Sub

    Private Sub cbTransport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTransport.SelectedIndexChanged
        If cbTransport.Text = "Others, please specify..." Then
            txtTOthers.Enabled = True
        Else
            txtTOthers.Enabled = False
            txtTOthers.Clear()
        End If
    End Sub

    Private Sub AddEmployees_Click(sender As Object, e As EventArgs) Handles AddEmployees.Click
        Sel_Personnel_Active(frmTK_AddUpdOtherEmployeesOfficialBusiness.dgvActiveEmployees)
        frmTK_AddUpdOtherEmployeesOfficialBusiness.ShowDialog()
    End Sub

    Private Sub btnAddOfficialBusiness_Click(sender As Object, e As EventArgs) Handles btnAddOfficialBusiness.Click
        InsUpd_OfficialBusiness_By_PersonnelID(frmTK_AddUpdOtherEmployeesOfficialBusiness.dgvAddedEmployees)
    End Sub

    Private Sub btnClearTextFields_Click(sender As Object, e As EventArgs) Handles btnClearTextFields.Click
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
        ResetDatePickers(Me)
    End Sub

    Private Sub frmTK_AddOfficialBusiness_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        ResetComboBoxes(Me)
        ResetDatePickers(Me)
        isUpdate = False
        frmTK_DataGridViewOfficialBusiness.dgvOfficialBusiness.ClearSelection()
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
                _ProjectChargingID1 = key.Item1
                _ProjectChargingID2 = key.Item2
                _ProjectChargingID3 = key.Item3
            Next
        End If
    End Sub

    Private Sub cbOverheadDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOverheadDept.SelectedIndexChanged
        Dim cb As ComboBox = CType(sender, ComboBox)
        Dim deptDictionary = CType(cb.Tag, Dictionary(Of Tuple(Of Integer, Integer), String))
        If cb.SelectedIndex <> -1 AndAlso deptDictionary IsNot Nothing Then
            Dim selectedDept = cb.SelectedItem.ToString()
            For Each kvp In deptDictionary
                If kvp.Value = selectedDept Then
                    _DepartmentChargingID1 = kvp.Key.Item1
                    _DepartmentChargingID2 = kvp.Key.Item2
                    Exit For
                End If
            Next
        End If
        ProjectChargingDropDownList(cbProjectName)
    End Sub

    'Private Sub frmTK_AddOfficialBusiness_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    If Not isFormSubmitted Then
    '        'DelTK_Leave_OfficialBusinessID()
    '    End If
    'End Sub
End Class