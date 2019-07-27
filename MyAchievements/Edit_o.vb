Public Class Edit_o
	Dim ini As String, x, y As Integer, loc As Point
	Private Sub UbuntuLNF_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown, UbuntuLNF1.MouseDown
		x = True
		loc = MousePosition
	End Sub

	Private Sub UbuntuLNF_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp, UbuntuLNF1.MouseUp
		x = False
		y = False
	End Sub

	Private Sub UbuntuLNF_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove, UbuntuLNF1.MouseMove

		If x = True Then
			y = True
			Me.DesktopLocation = New Point(Me.DesktopLocation.X + (MousePosition.X - loc.X), Me.DesktopLocation.Y + (MousePosition.Y - loc.Y))
			loc = MousePosition
		End If
	End Sub
	Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
		My.Computer.FileSystem.CurrentDirectory = Achievementz.Get_dir
		Close()
	End Sub

	Private Sub Edit_a_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		Achievementz.Enabled = True
	End Sub

	Private Sub Remove_img_Click(sender As Object, e As EventArgs) Handles Remove_img.Click
		PictureBox1.Image = Nothing
	End Sub

	Private Sub Add_img_Click(sender As Object, e As EventArgs) Handles Add_img.Click
		OpenFileDialog.ShowDialog()
	End Sub

	Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
		PictureBox1.Image = Image.FromFile(OpenFileDialog.FileName)
	End Sub

	Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
		My.Computer.FileSystem.CurrentDirectory = Achievementz.Get_dir & "\Opp"
		My.Computer.FileSystem.DeleteDirectory(Achievementz.Get_dir & "\Opp\" & ini, FileIO.DeleteDirectoryOption.DeleteAllContents)
		My.Computer.FileSystem.CreateDirectory(Title.Text)
		My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.CurrentDirectory & "\" & Title.Text
		Dim stream As IO.StreamWriter
		stream = FileIO.FileSystem.OpenTextFileWriter(DateP.Value.DayOfWeek.ToString, False)
		stream.WriteLine(DateP.Value.ToShortDateString)
		stream.WriteLine(TextBox1.Text)
		stream.WriteLine("😀www.zerene.in😀")
		stream.Close()
		If Not (IsNothing(PictureBox1.Image)) Then
			Dim SaveImage As New Bitmap(PictureBox1.Image)
			SaveImage.Save("z")
			SaveImage.Dispose()
		End If
		My.Computer.FileSystem.CurrentDirectory = Achievementz.Get_dir



		For Each control In Achievementz.FlowLayoutPanel2.Controls
			If DirectCast(control, Ubuntu_look_and_feel.AimIcon).BackColor = Color.DarkMagenta Then
				With DirectCast(control, Ubuntu_look_and_feel.AimIcon)
					.Name = Title.Text
					.Label1.Text = Title.Text
					.PictureBox1.Tag = Title.Text
					.Tag = Title.Text
				End With

			End If
		Next
		Close()
	End Sub

	Private Sub Edit_o_Load(sender As Object, e As EventArgs) Handles Me.Load
		DateP.MinDate = Date.Today
		UbuntuLNF2.Label1.Location = New Point(380, -8)
	End Sub

	Private Sub Title_TextChanged(sender As Object, e As EventArgs) Handles Title.TextChanged
		Save_state()
	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		Label9.Text = "[" & (TextBox1.Text.Length.ToString) & "]"
		Save_state()
	End Sub

	Private Sub Save_state()
		If Title.Text.Length = 0 Or TextBox1.Text.Length < 15 Then
			Save.Enabled = False
		Else
			Save.Enabled = True
		End If
	End Sub

	Public Sub Set_ini(s As String)
		ini = s
	End Sub

End Class