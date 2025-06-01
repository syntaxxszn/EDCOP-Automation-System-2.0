Imports System.ComponentModel

Public Class frmHRIS_PerformanceManagement_AddUpdatePart1Form1

    Public ch1 As New CheckBox()
    Public ch2 As New CheckBox()
    Public ch3 As New CheckBox()

    Private Sub frmHRIS_PerformanceManagement_Part1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmployeeName.Text = _EmployeeName
        txtDepartment.Text = _EmployeeDepartment
        txtPosition.Text = _EmployeePosition
        txtProjectName.Text = _ProjectDesignation
        txtCoveredPeriod.Text = _StartDate.ToString("MMM/dd/yyyy") & " - " & _EndDate.ToString("MMM/dd/yyyy")
    End Sub

    Private Sub btnNextTab1_Click(sender As Object, e As EventArgs) Handles btnNextTab1.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnNextTab2_Click(sender As Object, e As EventArgs) Handles btnNextTab2.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub btnPrevTab2_Click(sender As Object, e As EventArgs) Handles btnPrevTab2.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btnPrevTab3_Click(sender As Object, e As EventArgs) Handles btnPrevTab3.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Public Sub CalculateRatingxFactor(txtFactor As TextBox, chRating As CheckBox, txtRxF As TextBox)
        Dim factor = Val(txtFactor.Text) / 100
        Dim rating = Val(If(chRating.Tag, 0))
        txtRxF.Text = If(chRating.Checked, (rating * factor).ToString("0.00"), "0")
    End Sub

    Private Sub kra1r_CheckedChanged(sender As Object, e As EventArgs) Handles kra1r5.CheckedChanged, kra1r4.CheckedChanged, kra1r3.CheckedChanged, kra1r2.CheckedChanged, kra1r1.CheckedChanged
        'If isPopulating Then Exit Sub
        Dim selected = CType(sender, CheckBox)
        If Not selected.Checked Then Exit Sub

        For Each cb In New CheckBox() {kra1r1, kra1r2, kra1r3, kra1r4, kra1r5}
            If cb IsNot selected Then cb.Checked = False
        Next

        ' Only calculate for the selected one
        ch1 = selected
        CalculateRatingxFactor(kra1fw, ch1, kra1rfw)
    End Sub

    Private Sub kra1fw_Validating(sender As Object, e As CancelEventArgs) Handles kra1fw.Validating
        Textbox_NumericFormat(kra1fw, e.Cancel)
    End Sub

    Private Sub kra2r_CheckedChanged(sender As Object, e As EventArgs) Handles kra2r5.CheckedChanged, kra2r4.CheckedChanged, kra2r3.CheckedChanged, kra2r2.CheckedChanged, kra2r1.CheckedChanged
        'If isPopulating Then Exit Sub
        Dim selected = CType(sender, CheckBox)
        If Not selected.Checked Then Exit Sub

        For Each cb In New CheckBox() {kra2r1, kra2r2, kra2r3, kra2r4, kra2r5}
            If cb IsNot selected Then cb.Checked = False
        Next

        ch2 = selected
        CalculateRatingxFactor(kra2fw, ch2, kra2rfw)
    End Sub

    Private Sub kra2fw_Validating(sender As Object, e As CancelEventArgs) Handles kra2fw.Validating
        Textbox_NumericFormat(kra2fw, e.Cancel)
    End Sub

    Private Sub kra3r_CheckedChanged(sender As Object, e As EventArgs) Handles kra3r5.CheckedChanged, kra3r4.CheckedChanged, kra3r3.CheckedChanged, kra3r2.CheckedChanged, kra3r1.CheckedChanged
        'If isPopulating Then Exit Sub
        Dim selected = CType(sender, CheckBox)
        If Not selected.Checked Then Exit Sub

        For Each cb In New CheckBox() {kra3r1, kra3r2, kra3r3, kra3r4, kra3r5}
            If cb IsNot selected Then cb.Checked = False
        Next

        ch3 = selected
        CalculateRatingxFactor(kra3fw, ch3, kra3rfw)
    End Sub

    Private Sub kra3fw_Validating(sender As Object, e As CancelEventArgs) Handles kra3fw.Validating
        Textbox_NumericFormat(kra3fw, e.Cancel)
    End Sub

    Private Sub kra1fw_TextChanged(sender As Object, e As EventArgs) Handles kra1fw.TextChanged
        If isPopulating Then Exit Sub
        kra1rfw.Clear()
        For Each cb In {kra1r1, kra1r2, kra1r3, kra1r4, kra1r5}
            cb.Checked = False
        Next
    End Sub

    Private Sub kra2fw_TextChanged(sender As Object, e As EventArgs) Handles kra2fw.TextChanged
        If isPopulating Then Exit Sub
        kra2rfw.Clear()
        For Each cb In {kra2r1, kra2r2, kra2r3, kra2r4, kra2r5}
            cb.Checked = False
        Next
    End Sub

    Private Sub kra3fw_TextChanged(sender As Object, e As EventArgs) Handles kra3fw.TextChanged
        If isPopulating Then Exit Sub
        kra3rfw.Clear()
        For Each cb In {kra3r1, kra3r2, kra3r3, kra3r4, kra3r5}
            cb.Checked = False
        Next

        Dim totalWeight = Val(kra1fw.Text) + Val(kra2fw.Text) + Val(kra3fw.Text)
        If totalWeight = 0 Then Exit Sub
        If totalWeight <> 100 Then MessageBox.Show("Total factor weight must equal 100 %.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error) : Return

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrWhiteSpace(kra1goals.Text) OrElse
            String.IsNullOrWhiteSpace(kra2goals.Text) OrElse
            String.IsNullOrWhiteSpace(kra3goals.Text) Then
            MessageBox.Show("Error! Please fill up all goals of each KRA as it is required.")
            Return
        End If

        If {kra1r1, kra1r2, kra1r3, kra1r4, kra1r5}.All(Function(c) Not c.Checked) Then
            ch1.Tag = 0
        End If

        If {kra2r1, kra2r2, kra2r3, kra2r4, kra2r5}.All(Function(c) Not c.Checked) Then
            ch2.Tag = 0
        End If

        If {kra3r1, kra3r2, kra3r3, kra3r4, kra3r5}.All(Function(c) Not c.Checked) Then
            ch3.Tag = 0
        End If 'check whether all checkboxes are unchecked and sets tag = 0 if true

        InsUpd_PMAS_Part1Form1()

    End Sub

    Private Sub frmHRIS_PerformanceManagement_AddUpdatePart1Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call frmHRIS_PerformanceManagement_AddUpdateProjectCoveredPeriod.Close()
    End Sub

    Public Sub clearFields()
        kra1goals.Clear()
        kra2goals.Clear()
        kra3goals.Clear()
        kra1fw.Clear()
        kra2fw.Clear()
        kra3fw.Clear()
        kra1rfw.Clear()
        kra2rfw.Clear()
        kra3rfw.Clear()
        For Each cb In {kra1r1, kra1r2, kra1r3, kra1r4, kra1r5}
            cb.Checked = False
        Next
        For Each cb In {kra2r1, kra2r2, kra2r3, kra2r4, kra2r5}
            cb.Checked = False
        Next
        For Each cb In {kra3r1, kra3r2, kra3r3, kra3r4, kra3r5}
            cb.Checked = False
        Next
        ch1.Tag = 0
        ch2.Tag = 0
        ch3.Tag = 0
    End Sub

End Class