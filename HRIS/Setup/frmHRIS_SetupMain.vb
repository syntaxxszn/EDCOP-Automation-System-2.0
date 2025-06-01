Public Class frmHRIS_SetupMain
    Private Sub frmHR_SetupMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub OpenChildForm(childForm As Form)

        ' If CurrentForm IsNot Nothing Then CurrentForm.Show()
        CurrentForm = childForm
        childForm.TopLevel = False
        childForm.WindowState = FormWindowState.Maximized
        panelOpenForm.Controls.Add(childForm)
        panelOpenForm.Tag = childForm
        childForm.BringToFront()
        childForm.Visible = True


    End Sub
    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        OpenChildForm(frmHRIS_Setup_Department)
    End Sub
End Class