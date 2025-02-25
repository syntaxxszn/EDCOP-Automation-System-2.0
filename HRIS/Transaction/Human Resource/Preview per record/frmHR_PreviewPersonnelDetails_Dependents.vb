Imports System.Windows.Forms

Public Class frmHR_PreviewPersonnelDetails_Dependents

    Private Sub frmHR_PreviewPersonnelDetails_Dependents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPrevParentsDetails.ClearSelection()
        dgvPrevSiblingsDetails.ClearSelection()
    End Sub

    Private Sub dgvPrevParentsDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrevParentsDetails.CellContentClick

    End Sub
End Class
