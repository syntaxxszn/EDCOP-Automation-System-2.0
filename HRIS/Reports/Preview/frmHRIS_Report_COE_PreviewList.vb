Public Class frmHRIS_Report_COE_PreviewList

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Close()
    End Sub

    ' this is to show sub menu
    Private Sub ShowSubMenuReport_MainPreview_List(subMenuForm As Form, button As Button)
        ' Close existing submenu if open
        currentSubMenuForm?.Close()
        currentSubMenuForm = Nothing

        ' Show new submenu if provided
        If subMenuForm IsNot Nothing Then
            currentSubMenuForm = subMenuForm
            subMenuForm.TopLevel = True
            subMenuForm.TopMost = True

            Dim buttonLocation As Point = button.PointToScreen(Point.Empty)
            subMenuForm.Location = New Point(buttonLocation.X + (button.Width * 3.5 \ 4),
                                 buttonLocation.Y + (button.Height \ 4) - (subMenuForm.Height \ 4))

            AddHandler subMenuForm.Deactivate, AddressOf SubMenuForm_Deactivate
            subMenuForm.Show()
        End If
    End Sub

    Private Sub SubMenuForm_Deactivate(sender As Object, e As EventArgs)
        If currentSubMenuForm IsNot Nothing Then
            currentSubMenuForm.Close()
            currentSubMenuForm = Nothing
        End If
    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        dgvCOE.ClearSelection()
        Call ShowSubMenuReport_MainPreview_List(New CertificateOfEmploymentSubMenu(), btnCreateNew)
    End Sub

    Private Sub frmHRIS_Report_MainPreview_List_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_HRIS_Personnel_COE_Issued_List(dgvCOE)
    End Sub

    Private Sub dgvCOE_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCOE.CellDoubleClick
        If _COEType = 741 Then
            Call PrintRPT_COE_Current_NO_GAP()
        ElseIf _COEType = 742 Then
            Call PrintRPT_COE_Current_WITH_GAP()
        ElseIf _COEType = 743 Then
            Call PrintRPT_COE_Current_WITH_COMPENSATION_ITEMIZED()
        ElseIf _COEType = 744 Then
            Call PrintRPT_COE_Current_WITH_COMPENSATION_ITEMIZED_WITH_GAP()
        ElseIf _COEType = 749 Then
            Call PrintRPT_COE_Current_WITH_COMPENSATION_ANNUALIZED()
        ElseIf _COEType = 745 Then
            Call PrintRPT_COE_Current_WITH_COMPENSATION_ANNUALIZED_WITH_GAP()
        ElseIf _COEType = 746 Then
            Call PrintRPT_COE_SEPARATED_AND_CLEARED()
        ElseIf _COEType = 747 Then
            'Call PrintRPT_COE_SEPARATED_AND_CLEARED() ''same as the given format also the same
            MessageBox.Show("No File Format given to this type.", "Contact System Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf _COEType = 748 Then
            Call PrintRPT_COE_SEPARATED_AND_NOT_CLEARED()
        Else
            MessageBox.Show("Unexpected Error Occured, undefined preview.", "Contact System Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvCOE.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCOE.SelectedRows(0)
            frmHRIS_Report_RequestPurpose.txtReferenceNo.Text = selectedRow.Cells(2).Value
            frmHRIS_Report_RequestPurpose.txtPurpose.Text = selectedRow.Cells(9).Value
            isUpdate = True
            frmHRIS_Report_RequestPurpose.ShowDialog()
        Else
            isUpdate = False
            Return
        End If
    End Sub

    Private Sub dgvCOE_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCOE.CellClick
        If dgvCOE.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvCOE.SelectedRows(0)
            _COEID1 = selectedRow.Cells(0).Value
            _strEmployeeID = selectedRow.Cells(1).Value
            _COEType = selectedRow.Cells(10).Value
            'MsgBox(_COEType)
        End If
    End Sub

    Private Sub ToolStripRefresh_Click(sender As Object, e As EventArgs) Handles ToolStripRefresh.Click
        Call Sel_HRIS_Personnel_COE_Issued_List(dgvCOE)
    End Sub

End Class