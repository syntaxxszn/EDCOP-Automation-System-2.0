Public Class frmTK_PrevEmployeeOfficialBusiness
    Private Sub frmTK_PrevEmployeeOfficialBusiness_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPrintDetails.Select()
        Select Case txtTransportOthers.Text
            Case "Airplane"
                pnlAirplane.BackColor = Color.Black
                txtTransportOthers.Visible = False
            Case "Company Vehicle"
                pnlCompanyVehicle.BackColor = Color.Black
                txtTransportOthers.Visible = False
            Case "Vehicle Rental"
                pnlVehicleRental.BackColor = Color.Black
                txtTransportOthers.Visible = False
            Case Else
                txtTransportOthers.Visible = True
                pnlOthers.BackColor = Color.Black
        End Select
    End Sub

    Private Sub frmTK_PrevEmployeeOfficialBusiness_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        pnlAirplane.BackColor = Color.White
        pnlCompanyVehicle.BackColor = Color.White
        pnlVehicleRental.BackColor = Color.White
        pnlOthers.BackColor = Color.White
    End Sub

    Private Sub btnPrintDetails_Click(sender As Object, e As EventArgs) Handles btnPrintDetails.Click

    End Sub
End Class