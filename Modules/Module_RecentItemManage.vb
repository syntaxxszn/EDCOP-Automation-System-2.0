

Module Module_RecentItemManage

	Public OpenedForms As New List(Of Form)

	Sub CloseAllForms_isClosed()

		For Each f As Form In OpenedForms.ToList()
			If f IsNot Nothing AndAlso Not f.IsDisposed Then
				f.Close()
			End If
		Next

		OpenedForms.Clear()
		frmMain.CustomDesign()
		frmMain.PanelHolder.Controls.Clear()

	End Sub

	Sub ChildForm_FormClosed(sender As Object, e As FormClosedEventArgs)
		Dim closedForm As Form = CType(sender, Form)
		OpenedForms.Remove(closedForm)
		UpdateRecentMenuItems()
	End Sub

	Private Sub RecentFormMenuItem_Click(sender As Object, e As EventArgs)
		Dim menuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
		Dim formName As String = menuItem.Text
		For Each form As Form In OpenedForms
			If form.Text = formName Then
				form.BringToFront()
				Exit For
			End If
		Next
	End Sub

	Sub UpdateRecentMenuItems()
		frmMain.RecentToolStripMenuItem.DropDownItems.Clear()
		For Each form As Form In OpenedForms
			Dim menuItem As New ToolStripMenuItem(form.Text)
			AddHandler menuItem.Click, AddressOf RecentFormMenuItem_Click
			frmMain.RecentToolStripMenuItem.DropDownItems.Add(menuItem)
		Next
	End Sub

	Sub BringFormToFront(form As Form)
		form.BringToFront()
	End Sub






End Module
