
Public Class frmHRIS_Report_MainPreview

    Private Sub ToolStripBtnClose_Click(sender As Object, e As EventArgs) Handles ToolStripBtnClose.Click
        HRIS_CrystalReports_Holder.ReportSource = Nothing
        HRIS_CrystalReports_Holder.Refresh()
        Me.Close()
    End Sub

End Class