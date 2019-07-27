Public Class Aboutw
	Dim x, y As Boolean, loc As Point
	Private Sub UbuntuLNF_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown, UbuntuLNF1.MouseDown
		x = True
		Loc = MousePosition
	End Sub

	Private Sub UbuntuLNF_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp, UbuntuLNF1.MouseUp
		x = False
		y = False
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Process.Start("https://www.zerene.in")
	End Sub

	Private Sub ZF_Click(sender As Object, e As EventArgs) Handles ZF.Click
		Process.Start("http://www.fb.com/zerene.in")
	End Sub

	Private Sub ZI_Click(sender As Object, e As EventArgs) Handles ZI.Click
		Process.Start("http://www.instagram.com/zerene.in")
	End Sub

	Private Sub ZT_Click(sender As Object, e As EventArgs) Handles ZT.Click
		Process.Start("http://www.twitter.com/zereneDotIn")
	End Sub

	Private Sub NF_Click(sender As Object, e As EventArgs) Handles NF.Click
		Process.Start("http://www.fb.com/nalamzap")
	End Sub

	Private Sub NI_Click(sender As Object, e As EventArgs) Handles NI.Click
		Process.Start("http://www.instagram.com/nalamzap")
	End Sub

	Private Sub NT_Click(sender As Object, e As EventArgs) Handles NT.Click
		Process.Start("http://www.twitter.com/nalamzap")
	End Sub

	Private Sub Email_Click(sender As Object, e As EventArgs) Handles email.Click
		Process.Start("mailto:nazibulalam@zerene.in")
	End Sub

	Private Sub UbuntuLNF_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove, UbuntuLNF1.MouseMove

		If x = True Then
			y = True
			DesktopLocation = New Point(DesktopLocation.X + (MousePosition.X - loc.X), DesktopLocation.Y + (MousePosition.Y - loc.Y))
			loc = MousePosition
		End If
	End Sub
	Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
		Achievementz.Show()
		Close()
	End Sub
End Class