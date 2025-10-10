Public Class frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2

    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frmHRIS_PerformanceManagement_SelectPart1Form1ToPart2Form2.Part1Form1ID.Count <= 4 Then
            Dim scores As Double() = {
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP1WST.Text),
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP2WST.Text),
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP3WST.Text),
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_4_Projectsp1.txtP4WST.Text)
            }
            Dim nonZeroScores = scores.Where(Function(s) s <> 0).ToList()
            Dim average As Double = If(nonZeroScores.Count > 0, nonZeroScores.Average(), 0)
            lblTotalWeighedAverage.Text = average.ToString("0.00")
        Else

            Dim scores As Double() = {
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP1WST.Text),
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP2WST.Text),
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP3WST.Text),
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP4WST.Text),
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP5WST.Text),
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP6WST.Text),
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP7WST.Text),
            Val(frmHRIS_PerformanceManagement_AddUpdatePart1Form2_8_Projectsp1.txtP8WST.Text)
            }
            Dim nonZeroScores = scores.Where(Function(s) s <> 0).ToList()
            Dim average As Double = If(nonZeroScores.Count > 0, nonZeroScores.Average(), 0)
            lblTotalWeighedAverage.Text = average.ToString("0.00")

        End If

        If isUpdate Then
            SelUpd_PMAS_Part1Form2_ByID()
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ClearTextBoxes(Me)
        lblTotalWeighedAverage.Text = "0.00"
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrWhiteSpace(txtQ1.Text) OrElse
            String.IsNullOrWhiteSpace(txtQ2.Text) OrElse
            String.IsNullOrWhiteSpace(txtQ3.Text) OrElse
            String.IsNullOrWhiteSpace(txtQ4.Text) Then
            MessageBox.Show("Error! Please fill up all fields required.")
            Return
        End If

        If lblTotalWeighedAverage.Text = "0.00" Then
            MessageBox.Show("You cannot save an empty rating.")
            Return
        End If

        InsUpd_PMAS_Part1Form2()

    End Sub

End Class