Public Class Form3
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If Tag = 0 Then
			Add_new_a.Enabled = True
		ElseIf Tag = 1 Then
			Add_new_o.Enabled = True
		End If
		Close()
	End Sub
End Class