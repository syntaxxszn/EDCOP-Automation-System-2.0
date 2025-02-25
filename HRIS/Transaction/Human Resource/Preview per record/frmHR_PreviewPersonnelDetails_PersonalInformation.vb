Public Class frmHR_PreviewPersonnelDetails_PersonalInformation
    Private Sub frmHR_PreviewPersonnelDetails_PersonalInformation_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Sel_Personnel_PersonalInformation_ByEmployeeID()
        frmHR_PreviewPersonnelDetails.Function_btnUpdates_Hide()
        Function_ReadOnly_isTrue()
    End Sub

    Public Sub Function_ReadOnly_isTrue()

        dtpDateofBirth.Enabled = False
        txtAge.ReadOnly = True
        txtPlaceofBirth.ReadOnly = True
        cbGender.Enabled = False
        txtHeight.ReadOnly = True
        txtWeight.ReadOnly = True
        cbCitizenship.Enabled = False
        cbCivilStatus.Enabled = False
        cbReligion.Enabled = True
        txtTelephone.ReadOnly = True
        txtEmailAddress.ReadOnly = True

        txtAdrStreet1.ReadOnly = True
        txtAdrBrgy1.ReadOnly = True
        cbAdrRegion1.Enabled = False
        cbAdrProvince1.Enabled = False
        cbAdrCity1.Enabled = False
        txtAdrZip1.ReadOnly = True

        cbPresentAdr.Enabled = False

        txtAdrStreet2.ReadOnly = True
        txtAdrBrgy2.ReadOnly = True
        cbAdrRegion2.Enabled = False
        cbAdrProvince2.Enabled = False
        cbAdrCity2.Enabled = False
        txtAdrZip2.ReadOnly = True

    End Sub

    Public Sub function_ReadOnly_isFalse()

        dtpDateofBirth.Enabled = True
        txtAge.ReadOnly = False
        txtPlaceofBirth.ReadOnly = False
        cbGender.Enabled = True
        txtHeight.ReadOnly = False
        txtWeight.ReadOnly = False
        cbCitizenship.Enabled = True
        cbCivilStatus.Enabled = True
        cbReligion.Enabled = True
        txtTelephone.ReadOnly = False
        txtMobileNumber.ReadOnly = False
        txtEmailAddress.ReadOnly = False

        txtAdrStreet1.ReadOnly = False
        txtAdrBrgy1.ReadOnly = False
        cbAdrRegion1.Enabled = True
        cbAdrProvince1.Enabled = True
        cbAdrCity1.Enabled = True
        txtAdrZip1.ReadOnly = False

        cbPresentAdr.Enabled = True

        txtAdrStreet2.ReadOnly = False
        txtAdrBrgy2.ReadOnly = False
        cbAdrRegion2.Enabled = True
        cbAdrProvince2.Enabled = True
        cbAdrCity2.Enabled = True
        txtAdrZip2.ReadOnly = False

    End Sub

    Private Sub frmHR_PreviewPersonnelDetails_PersonalInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub
End Class