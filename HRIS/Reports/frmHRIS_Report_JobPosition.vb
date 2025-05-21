Public Class frmHRIS_Report_JobPosition

    Dim _JobTitleID As Integer

    Private Sub frmHRIS_Report_JobPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DropDownListJobPosition2(cbJobPosition)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Close()
        PrintRPT_Employee_ByJobPosition(_JobTitleID)
        OpenChildForm_Revision(frmHRIS_Report_MainPreview)
    End Sub

    Private Sub cbJobPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJobPosition.SelectedIndexChanged
        Dim selectedJobTitle As String = cbJobPosition.SelectedItem?.ToString()
        Dim jobtitleDictionary As Dictionary(Of String, Integer) = CType(cbJobPosition.Tag, Dictionary(Of String, Integer))
        _JobTitleID = If(selectedJobTitle IsNot Nothing AndAlso jobtitleDictionary.ContainsKey(selectedJobTitle), jobtitleDictionary(selectedJobTitle), -1)
    End Sub

    Private Sub frmHRIS_Report_JobPosition_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _JobTitleID = 0
        ResetComboBoxes(Me)
    End Sub
End Class