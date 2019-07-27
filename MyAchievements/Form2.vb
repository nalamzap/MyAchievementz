Imports System.ComponentModel

Public Class Add_new_a
	Dim x, y As Boolean, loc As Point

	Private Sub UbuntuLNF_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown, UbuntuLNF1.MouseDown
		x = True
		Loc = MousePosition
	End Sub

	Private Sub UbuntuLNF_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp, UbuntuLNF1.MouseUp
		x = False
		y = False
	End Sub

	Private Sub UbuntuLNF_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove, UbuntuLNF1.MouseMove

		If x = True Then
			y = True
			Me.DesktopLocation = New Point(Me.DesktopLocation.X + (MousePosition.X - Loc.X), Me.DesktopLocation.Y + (MousePosition.Y - Loc.Y))
			loc = MousePosition

		End If
	End Sub

	Private Sub Add_new_a_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		Achievementz.Enabled = True
	End Sub

	Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
		Close()
	End Sub

	Private Sub Add_new_a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		UbuntuLNF2.Label1.Location = New Point(380, -8)
		DateP.MaxDate = Date.Today
	End Sub

	Private Sub Title_TextChanged(sender As Object, e As EventArgs) Handles Title.TextChanged
		Save_state()
	End Sub

	Private Sub Save_state()
		If Title.Text.Length = 0 Or TextBox1.Text.Length < 15 Then
			Save.Enabled = False
		Else
			Save.Enabled = True
		End If
	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		Label9.Text = "[" & (TextBox1.Text.Length.ToString) & "]"
		Save_state()
	End Sub

	Private Sub Add_img_Click(sender As Object, e As EventArgs) Handles Add_img.Click
		OpenFileDialog.ShowDialog()
	End Sub

	Private Sub OpenFileDialog_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog.FileOk
		PictureBox1.Image = Image.FromFile(OpenFileDialog.FileName)
	End Sub

	Private Sub Remove_img_Click(sender As Object, e As EventArgs) Handles Remove_img.Click
		PictureBox1.Image = Nothing
	End Sub

	Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
		My.Computer.FileSystem.CurrentDirectory = Achievementz.Get_dir & "\Ach"
		If My.Computer.FileSystem.DirectoryExists(Title.Text) Then
			Form3.Show()
			Form3.Tag = 0
			Form3.Label1.Text = "Achievement already exists! You can edit it from the main window"
			My.Computer.FileSystem.CurrentDirectory = Achievementz.Get_dir
			Enabled = False
		Else
			Dim TIcon = New Ubuntu_look_and_feel.TrophyIcon
			My.Computer.FileSystem.CurrentDirectory = Achievementz.Get_dir & "\Ach"
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

			With TIcon
				.Name = Title.Text
				.Label1.Text = Title.Text
				.PictureBox1.Tag = Title.Text
				.Tag = Title.Text
			End With

			Achievementz.ToolTip1.SetToolTip(TIcon, "Double click to view Achievement")
			Achievementz.ToolTip1.SetToolTip(TIcon.PictureBox1, "Double click to view Achievement")
			Achievementz.ToolTip1.SetToolTip(TIcon.Label1, "Double click to view Achievement")
			AddHandler TIcon.DoubleClick, AddressOf Achievementz.Trophy_clicked
			AddHandler TIcon.Label1.DoubleClick, AddressOf Achievementz.Trophy_clicked
			AddHandler TIcon.PictureBox1.DoubleClick, AddressOf Achievementz.Trophy_clicked
			AddHandler TIcon.Click, AddressOf Achievementz.Trophy_select
			AddHandler TIcon.Label1.Click, AddressOf Achievementz.Trophy_select
			AddHandler TIcon.PictureBox1.Click, AddressOf Achievementz.Trophy_select

			Achievementz.FlowLayoutPanel1.Controls.Add(TIcon)

			Close()
		End If
	End Sub
End Class