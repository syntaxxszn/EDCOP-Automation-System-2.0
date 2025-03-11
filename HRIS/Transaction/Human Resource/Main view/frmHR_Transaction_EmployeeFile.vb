Public Class frmHR_Transaction_EmployeeFile
    Private Sub frmHR_ActiveEmployeeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        ' Show loading form
        frmLoading.Show()
        frmLoading.Refresh() ' Force UI update before running long operations

        ' Load data
        Call EmployeeList_Active()
        Call SelectFirstRowInEmployeeList()

        ' Close loading form after loading is complete
        frmLoading.Close()
        MyBase.OnLoad(e)
    End Sub


    'Sub DefaultLabelValue()

    '    lblFullName.Text = "----"
    '    lblEmployeeNo.Text = "----"
    '    lblJobPosition.Text = "----"
    '    lblDepartment.Text = "----"
    '    lblEmpStatus.Text = "----"
    '    FilePath = Nothing
    '    GetImageProfile(PictureBoxAddProfile)

    'End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripBtnNew_Click(sender As Object, e As EventArgs) Handles toolstripBtnNew.Click

        Ins_PersonnelTempRecord()
        ' Sel_PersonnelID()
        frmHR_AddNewPersonnel.ShowDialog()

    End Sub

    Public Sub EmployeeList_Active()
        Sel_Personnel_Active(dgvEmployeeList)
        'labelEmployeeStatus.Text = "ACTIVE"
        'labelEmployeeStatus.ForeColor = Color.Green
        'DefaultLabelValue()

    End Sub

    Private Sub EmployeeList_InActive()

        'Sel_Personnel_InActive(dgvEmployeeList)
        'labelEmployeeStatus.Text = "IN ACTIVE"
        'labelEmployeeStatus.ForeColor = Color.Maroon

    End Sub

    Private Sub ActiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveToolStripMenuItem.Click
        EmployeeList_Active()
        lblStatus.Text = "Active"
        lblStatus.ForeColor = Color.Green
    End Sub

    Private Sub ClearFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFilterToolStripMenuItem.Click
        lblStatus.Text = "----"
        lblStatus.ForeColor = Color.Black
    End Sub

    Private Sub InactiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InactiveToolStripMenuItem.Click
        EmployeeList_InActive()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Search_DGVPersonnel(dgvEmployeeList, txtboxSearch)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        txtboxSearch.Clear()
    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick

        ' Procedure : When selected from dgvEmployeeList, The name will show on toolstripLabelSelected.

        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            _strEmployeeID = selectedRow.Cells(0).Value
            toolstripLblSelected.Text = selectedRow.Cells(2).Value
            lblEmployeeNo.Text = selectedRow.Cells(1).Value
            lblFullName.Text = selectedRow.Cells(2).Value
            frmHR_PreviewPersonnelDetails.lblJobPosition.Text = selectedRow.Cells(3).Value
            frmHR_PreviewPersonnelDetails.lblDepartment.Text = selectedRow.Cells(4).Value
            ' Code 1
            FilePath = selectedRow.Cells(5).Value
            If FilePath = "" Then
                FilePath = "\\192.168.0.250\references\DIMS_APPS_INST\Images Profile\default_image.png"
            End If ' This will get the default image if no path is given
            ' Procedure : This code pass the value of Datagrid Cell 3 to 'FilePath String'  See (Code 1) . Then the FilePath will read by "GetImageProfile Function" See  (Code 2).
            ' Code 2
            Call GetImageProfile(PictureBox1)
            frmHR_PreviewPersonnelDetails.lblEmpStatus.Text = selectedRow.Cells(6).Value
            Call Sel_HRIS_Personnel_ContractHistory_ByID(dgvContracts)
        End If
    End Sub

    Private Sub dgvEmployeeList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellDoubleClick

        ' Procedure : This code enable Double click of a row to preview full details of employee based on _strEmployeeID see ( Code 1 ). 
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            frmHR_PreviewPersonnelDetails.ShowDialog()
        End If
    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        frmHR_Transaction_SearchFilter.ShowDialog()
    End Sub

    Public Sub SelectFirstRowInEmployeeList() 'select first row
        If dgvEmployeeList.Rows.Count > 0 Then
            Dim firstRow As DataGridViewRow = dgvEmployeeList.Rows(0)
            _strEmployeeID = firstRow.Cells(0).Value
            toolstripLblSelected.Text = firstRow.Cells(2).Value
            lblEmployeeNo.Text = firstRow.Cells(1).Value
            lblFullName.Text = firstRow.Cells(2).Value
            frmHR_PreviewPersonnelDetails.lblJobPosition.Text = firstRow.Cells(3).Value
            frmHR_PreviewPersonnelDetails.lblDepartment.Text = firstRow.Cells(4).Value
            ' Code 1
            FilePath = firstRow.Cells(5).Value
            If FilePath = "" Then
                FilePath = "\\192.168.0.250\references\DIMS_APPS_INST\Images Profile\default_image.png"
            End If ' This will get the default image if no path is given
            ' Procedure : This code pass the value of Datagrid Cell 3 to 'FilePath String'  See (Code 1) . Then the FilePath will read by "GetImageProfile Function" See  (Code 2).
            ' Code 2
            Call GetImageProfile(PictureBox1)
            frmHR_PreviewPersonnelDetails.lblEmpStatus.Text = firstRow.Cells(6).Value
            Call Sel_HRIS_Personnel_ContractHistory_ByID(dgvContracts)
        End If
    End Sub


End Class