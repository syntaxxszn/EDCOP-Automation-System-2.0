Public Class frmHRIS_Setup_PreviewLeaveTaken
    Private Sub frmHRIS_Setup_PreviewLeaveTaken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sel_AccumulatedLeaveTaken_ByEmployeeID(dgvLeaveTaken)
        Dim totalLeaveBalance As Decimal = GetLeaveBalanceTotal()
        lblTotalBalance.Text = totalLeaveBalance.ToString("N2")
    End Sub

    Private Sub frmHRIS_Setup_PreviewLeaveTaken_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearDataGridViewRows(Me)
        lblTotalBalance.Text = "0.00"
    End Sub

    Private Sub frmHRIS_Setup_PreviewLeaveTaken_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dgvLeaveTaken.ClearSelection()
    End Sub

    Private Function GetLeaveBalanceTotal() As Decimal
        Dim total As Decimal = 0D

        For Each row As DataGridViewRow In dgvLeaveTaken.Rows
            ' Skip the new row placeholder
            If Not row.IsNewRow Then
                Dim value As Object = row.Cells(3).Value

                If value IsNot Nothing AndAlso IsNumeric(value) Then
                    total += Convert.ToDecimal(value)
                End If
            End If
        Next

        Return total
    End Function

End Class