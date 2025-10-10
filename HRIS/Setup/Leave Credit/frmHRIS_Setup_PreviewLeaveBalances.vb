Public Class frmHRIS_Setup_PreviewLeaveBalances
    Private Sub frmHRIS_Setup_PreviewLeaveBalances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sel_AccumulatedLeaveCredit_ByEmployeeID(dgvLeaveBalance)
        Dim totalLeaveBalance As Decimal = GetLeaveBalanceTotal()
        lblTotalBalance.Text = totalLeaveBalance.ToString("N2")
    End Sub

    Private Sub frmHRIS_Setup_PreviewLeaveBalances_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ClearDataGridViewRows(Me)
        lblTotalBalance.Text = "0.00"
    End Sub

    Private Sub frmHRIS_Setup_PreviewLeaveBalances_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dgvLeaveBalance.ClearSelection()
    End Sub

    Private Function GetLeaveBalanceTotal() As Decimal
        Dim total As Decimal = 0D

        For Each row As DataGridViewRow In dgvLeaveBalance.Rows
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