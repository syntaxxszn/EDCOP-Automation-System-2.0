Imports System.Windows.Forms

Public Class FrmPMS_Individual_ViewActivity

    Private Sub dgvProjectTagList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectTagList.CellContentClick
    End Sub

    Private Sub dgvProjectTagList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectTagList.CellClick
        If e.ColumnIndex = -1 Or e.RowIndex = -1 Then Return   ''This code is to prevent from error when clicking header of DGV button. 8/22/2022

        Dim isOB As String
        Dim isOT As String


        If dgvProjectTagList.Columns(e.ColumnIndex).Name = "Column6" Then
            isOT = dgvProjectTagList.Rows(e.RowIndex).Cells(6).Value.ToString()
            isOB = dgvProjectTagList.Rows(e.RowIndex).Cells(7).Value.ToString()
            _strProjectChargeID = dgvProjectTagList.Rows(e.RowIndex).Cells(0).Value.ToString()



            If isOT = "Yes" Then
                        MessageBox.Show("Cannot edit Overtime(OT Filed).", "PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    Else
                        If isOB = "Yes" Then
                            MessageBox.Show("Cannot edit Official Business(OB Filed).", "PCM System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return
                        Else
                            SelectUpdate_ProjectChargeDetails_ByProjectChargeID()
                            FrmPMS_Individual_Update_Activity.ShowDialog()
                        End If
                    End If
                End If

    End Sub

    Private Sub dgvProjectTagList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProjectTagList.SelectionChanged
        dgvProjectTagList.ClearSelection()
    End Sub

    Private Sub FrmPMS_Individual_ViewActivity_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If _strUserLevel = "Individual" Then

            '\\ This code is to refresh PayPeriod details.
            Insert_PayrollPeriod_Details(frmPMS_Individual.dgvPayrollPeriodDetails)

            '\\ This code is to refresh the Employee Total hour charge in a cut off.
            Select_Employee_ByID()

            '\\ This code will refresh activitylog from main form.
            Select_ActivityLog()

        End If

        '-----------------------------------------------------------------------------

        If _strUserLevel = "Master" Then

            '\\ This code is to refresh PayPeriod details.
            Insert_PayrollPeriod_Details(frmPMS_Administrator.dgvPayrollPeriodDetails)

            '\\ This code is to refresh the Employee Total hour charge in a cut off.
            Select_EmployeeList()

            '\\ This code will refresh activitylog from main form.
            Select_ActivityLog()

        End If

    End Sub

    Private Sub FrmPMS_Individual_ViewActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
