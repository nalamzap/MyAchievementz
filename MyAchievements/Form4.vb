Public Class Display
	Dim x, y As Boolean, loc As Point
	Private Sub UbuntuLNF_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown, UbuntuLNF1.MouseDown
		x = True
		Loc = MousePosition
	End Sub

	Private Sub UbuntuLNF_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp, UbuntuLNF1.MouseUp
		x = False
		y = False
	End Sub

	Private Sub UbuntuLNF_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove, UbuntuLNF1.MouseMove

		If x = True Then
			y = True
			Me.DesktopLocation = New Point(Me.DesktopLocation.X + (MousePosition.X - Loc.X), Me.DesktopLocation.Y + (MousePosition.Y - Loc.Y))
			Loc = MousePosition
		End If
	End Sub
	Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
		Achievementz.Show()
		Close()
	End Sub
End Class