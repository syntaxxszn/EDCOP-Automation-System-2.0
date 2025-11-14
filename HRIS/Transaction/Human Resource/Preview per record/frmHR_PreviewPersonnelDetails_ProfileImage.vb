Public Class frmHR_PreviewPersonnelDetails_ProfileImage

    Private Sub frmHR_PreviewPersonnelDetails_ProfileImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub

    Private Sub frmHR_PreviewPersonnelDetails_ProfileImage_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
    End Sub

End Class