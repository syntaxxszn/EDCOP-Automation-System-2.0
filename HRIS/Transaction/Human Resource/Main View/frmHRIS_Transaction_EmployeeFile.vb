Imports System.ComponentModel

Public Class frmHRIS_Transaction_EmployeeFile

    Dim stat As Boolean = True

    Private Sub frmHR_ActiveEmployeeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        ' Show loading form
        frmLoading.Show()
        frmLoading.Refresh() ' Force UI update before running long operations

        ' Load data
        Call EmployeeList_Active()
        ' Call SelectFirstRowInEmployeeList()

        ' Close loading form after loading is complete
        frmLoading.Close()
        MyBase.OnLoad(e)
    End Sub

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripBtnNew_Click(sender As Object, e As EventArgs) Handles toolstripBtnNew.Click
        If Not HasUserAccess("insert") Then Return
        frmHR_AddNewPersonnel.ShowDialog()
    End Sub

    Public Sub EmployeeList_Active()
        Sel_Personnel_Active(dgvEmployeeList)
    End Sub

    Private Sub dgvEmployeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick

        ' Procedure : When selected from dgvEmployeeList, The name will show on toolstripLabelSelected.

        If dgvEmployeeList.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvEmployeeList.SelectedRows(0)
            _strEmployeeID = selectedRow.Cells(0).Value
            toolstripLblSelected.Text = selectedRow.Cells(2).Value
            lblEmployeeNo.Text = selectedRow.Cells(1).Value
            txtFullName.Text = selectedRow.Cells(2).Value
            frmHR_PreviewPersonnelDetails.lblJobPosition.Text = selectedRow.Cells(3).Value
            frmHR_PreviewPersonnelDetails.lblDepartment.Text = selectedRow.Cells(4).Value
            lblDepartment.Text = selectedRow.Cells(4).Value

            ' Code 1
            FilePath = selectedRow.Cells(5).Value
            If FilePath = "" Then
                FilePath = "\\192.168.0.250\references\DIMS_APPS_INST\Images Profile\default_image.png"
            End If ' This will get the default image if no path is given

            ' Procedure : This code pass the value of Datagrid Cell 3 to 'FilePath String'  See (Code 1) . Then the FilePath will read by "GetImageProfile Function" See  (Code 2).
            ' Code 2
            Call GetImageProfile(PictureBox1)

            frmHR_PreviewPersonnelDetails.lblEmpStatus.Text = selectedRow.Cells(6).Value
            lblBirthDate.Text = selectedRow.Cells(7).Value
            lblMobileNumber.Text = selectedRow.Cells(8).Value
            lblEmailAddress.Text = selectedRow.Cells(9).Value
            Call Sel_HRIS_Personnel_ContractHistory_ByID(dgvContracts, False)
        End If
    End Sub

    Private Sub dgvEmployeeList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellDoubleClick

        ' Procedure : This code enable Double click of a row to preview full details of employee based on _strEmployeeID see ( Code 1 ).
        If Not HasUserAccess("view") Then Return
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            frmHR_PreviewPersonnelDetails.ShowDialog()
        End If

    End Sub

    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        txtboxSearch.Clear()
        frmHRIS_Transaction_SearchFilter.ShowDialog()
    End Sub

    Public Sub SelectFirstRowInEmployeeList() 'select first row
        If dgvEmployeeList.Rows.Count > 0 Then
            Dim firstRow As DataGridViewRow = dgvEmployeeList.Rows(0)
            _strEmployeeID = firstRow.Cells(0).Value
            toolstripLblSelected.Text = firstRow.Cells(2).Value
            lblEmployeeNo.Text = firstRow.Cells(1).Value
            txtFullName.Text = firstRow.Cells(2).Value
            frmHR_PreviewPersonnelDetails.lblJobPosition.Text = firstRow.Cells(3).Value
            frmHR_PreviewPersonnelDetails.lblDepartment.Text = firstRow.Cells(4).Value
            lblDepartment.Text = firstRow.Cells(4).Value
            ' Code 1
            FilePath = firstRow.Cells(5).Value
            If FilePath = "" Then
                FilePath = "\\192.168.0.250\references\DIMS_APPS_INST\Images Profile\default_image.png"
            End If ' This will get the default image if no path is given
            ' Procedure : This code pass the value of Datagrid Cell 3 to 'FilePath String'  See (Code 1) . Then the FilePath will read by "GetImageProfile Function" See  (Code 2).
            ' Code 2
            Call GetImageProfile(PictureBox1)
            frmHR_PreviewPersonnelDetails.lblEmpStatus.Text = firstRow.Cells(6).Value

            lblBirthDate.Text = firstRow.Cells(7).Value
            lblMobileNumber.Text = firstRow.Cells(8).Value
            lblEmailAddress.Text = firstRow.Cells(9).Value

            Call Sel_HRIS_Personnel_ContractHistory_ByID(dgvContracts, False)
        End If
    End Sub

    Private Sub dgvEmployeeList_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvEmployeeList.RowsAdded
        UpdateRowCount()
    End Sub

    Private Sub dgvEmployeeList_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvEmployeeList.RowsRemoved
        UpdateRowCount()
    End Sub

    Private Sub UpdateRowCount()
        Dim rowCount As Integer = dgvEmployeeList.Rows.Count - If(dgvEmployeeList.AllowUserToAddRows, 1, 0)
        toolstriplabelNoOfRecord.Text = rowCount.ToString()
        ClearQuickPreviewPanel()

        If rowCount <> 100 Then
            '' Just set it to "Filtered" if rows is not equal to 100 anymore
            'btnStatus.Text = "Filtered"
            'btnStatus.BackColor = Color.Navy
            'btnStatus.FlatAppearance.BorderColor = Color.Blue
        Else
            ' Set appearance based on current "stat" toggle
            btnStatus.Text = If(stat, "Active", "Inactive")
            btnStatus.BackColor = If(stat, Color.DarkGreen, Color.DarkRed)
            btnStatus.FlatAppearance.BorderColor = If(stat, Color.DarkGreen, Color.DarkRed)
        End If
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        stat = Not stat
        btnStatus.Text = If(stat, "Active", "Inactive")
        btnStatus.BackColor = If(stat, Color.DarkGreen, Color.DarkRed)
        btnStatus.FlatAppearance.BorderColor = If(stat, Color.DarkGreen, Color.DarkRed)
        txtboxSearch.Clear()
        WhatToSearch()
        UpdateRowCount()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        WhatToSearch()
    End Sub

    Public Sub WhatToSearch()
        Try
            frmLoading.Show()
            frmLoading.Refresh() ' Force UI update before running long operations
            If stat Then
                Search_DGVPersonnel(dgvEmployeeList, txtboxSearch, False)
            Else
                Search_DGVPersonnel(dgvEmployeeList, txtboxSearch, True)
            End If
            ClearQuickPreviewPanel()
        Catch ex As Exception
            MessageBox.Show($"Please Contact System Administrator.{vbCrLf}Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmLoading.Close() ' Ensure loading form is closed properly
        End Try
    End Sub

    Private Sub ClearQuickPreviewPanel()
        If lblEmployeeNo.Text = "" Then Exit Sub
        FilePath = "\\192.168.0.250\references\DIMS_APPS_INST\Images Profile\default_image.png"
        Call GetImageProfile(PictureBox1)
        dgvContracts.Rows.Clear()
        'labels
        txtFullName.Text = "Please select from the list of employee."
        lblBirthDate.Text = ""
        lblDepartment.Text = ""
        lblEmployeeNo.Text = ""
        lblMobileNumber.Text = ""
        lblEmailAddress.Text = ""
    End Sub

    Private Sub ToolStripBtnRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripBtnRefresh.Click
        WhatToSearch()
    End Sub

    Private Sub toolstripEdit_Click(sender As Object, e As EventArgs) Handles toolstripEdit.Click
        If Not HasUserAccess("update") Then Return
        If dgvEmployeeList.SelectedRows.Count > 0 Then
            frmHR_PreviewPersonnelDetails.ShowDialog()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmHR_PreviewPersonnelDetails_ProfileImage.PictureBox.Image = PictureBox1.Image
        frmHR_PreviewPersonnelDetails_ProfileImage.Show()
    End Sub

End Class