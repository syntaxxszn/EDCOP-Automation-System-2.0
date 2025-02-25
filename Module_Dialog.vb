Module Module_Dialog

    Sub DialogResult_Yes_InsertProjectCharge()


        Dim btnss As New DialogResult


        Using frmDialog_Ok_InsertProjectCharge As New Form


            If btnss = DialogResult.Yes Then
                frmDialog_Ok_InsertProjectCharge.Close()
            End If

        End Using

    End Sub



End Module
