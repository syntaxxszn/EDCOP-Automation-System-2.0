Public Class frmTK_AddUpdOverTime

    Public isUpdate As Boolean = False
    Private isPopulating As Boolean = False

    Private Sub frmTK_AddUpdOverTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = "Add New Overtime"
        DepartmentChargingDropDownList(cbOverheadDept)
        If isUpdate Then
            lblHeader.Text = "Üpdating Overtime"
            isPopulating = True
            SelUpd_OverTime_By_ID()
            isPopulating = False
            Exit Sub
        End If
        _OverTimeFileID = 0 'set to ID = 0 to trigger insert in stored procedure
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

    Private Sub btnAddOfficialBusiness_Click(sender As Object, e As EventArgs) Handles btnAddOfficialBusiness.Click
        InsUpd_Overtime_By_PersonnelID()
    End Sub

    Private Sub chActualOvertime_CheckedChanged(sender As Object, e As EventArgs) Handles chActualOvertime.CheckedChanged
        dtpDateFiling.Enabled = Not chActualOvertime.Checked
        If isPopulating Then Exit Sub
        If chActualOvertime.Checked Then dtpDateFiling.Value = DateTime.Today
    End Sub

    Private Sub frmTK_AddUpdOverTime_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearTextBoxes(Me)
        ResetDatePickers(Me)
        ResetComboBoxes(Me)
        chActualOvertime.Checked = True
        isUpdate = False
    End Sub

    Dim tooltip As New ToolTip()
    Private Sub PictureBoxHelp_Click(sender As Object, e As EventArgs) Handles PictureBoxHelp.Click, PictureBoxHelp.MouseHover
        tooltip.SetToolTip(PictureBoxHelp, "Thank you for not calling DIMS! <3")
    End Sub
End Class