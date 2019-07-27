Public Class Achievementz
	Dim x, y As Boolean
	Dim loc As Point
	Dim c, n As Integer
	Dim item, ed, del, dir As String

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
			DesktopLocation = New Point(DesktopLocation.X + (MousePosition.X - loc.X), DesktopLocation.Y + (MousePosition.Y - loc.Y))
			loc = MousePosition
		End If
	End Sub

	Private Sub Achievements_button_Click(sender As Object, e As EventArgs) Handles Achievements_button.Click
		Deselect_All()
		Opportunities_button.BackColor = Color.FromArgb(70, 70, 70)
		Achievements_button.BackColor = Color.FromArgb(56, 56, 56)
		TabControl1.SelectedTab = TabPage1

	End Sub

	Private Sub Add_button_Click(sender As Object, e As EventArgs) Handles AddAButton.Click
		Deselect_All()
		Enabled = False
		Add_new_a.Show()
	End Sub

	Private Sub Opportunities_button_Click(sender As Object, e As EventArgs) Handles Opportunities_button.Click
		Deselect_All()
		Achievements_button.BackColor = Color.FromArgb(70, 70, 70)
		Opportunities_button.BackColor = Color.FromArgb(56, 56, 56)
		TabControl1.SelectedTab = TabPage2
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		'Dim fnt As New Text.PrivateFontCollection
		'fnt.AddFontFile("LCALLIG.TTF")
		'fnt.AddFontFile("LHANDW.TTF")
		'fnt.AddFontFile("MTCORSVA.TTF")
		'fnt.AddFontFile("BS.otf")

		'Achievements_button.Font = New Font(fnt.Families(2), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'Opportunities_button.Font = New Font(fnt.Families(2), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'AddAButton.Font = New Font(fnt.Families(2), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'DeleteAButton.Font = New Font(fnt.Families(2), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'EditAButton.Font = New Font(fnt.Families(2), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'About.Font = New Font(fnt.Families(2), 14.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'Label1.Font = New Font(fnt.Families(3), 25.0!, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
		'AddOButton.Font = New Font(fnt.Families(2), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'EditOButton.Font = New Font(fnt.Families(2), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'DeleteOButton.Font = New Font(fnt.Families(2), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)


		UbuntuLNF2.Label1.Location = New Point(625, -8)

		UbuntuLNF2.Label1.Location = New Point(UbuntuLNF2.Label1.Location.X, UbuntuLNF2.Label1.Location.Y + 2)
		dir = My.Computer.FileSystem.CurrentDirectory
		If Not My.Computer.FileSystem.DirectoryExists("Ach") Then
			My.Computer.FileSystem.CreateDirectory("Ach")
		End If
		If Not My.Computer.FileSystem.DirectoryExists("Opp") Then
			My.Computer.FileSystem.CreateDirectory("Opp")
		End If
		My.Computer.FileSystem.CurrentDirectory = dir + "\Ach"
		n = My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.CurrentDirectory).Count
		For i = 1 To n
			item = My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.CurrentDirectory).Item(i - 1)
			Dim TIcon = New Ubuntu_look_and_feel.TrophyIcon
			item = item.Substring(item.LastIndexOf(Char.Parse("\")) + 1)
			With TIcon
				.Name = item
				.Label1.Text = item
				.PictureBox1.Tag = item
				.Tag = item
			End With
			ToolTip1.SetToolTip(TIcon, "Double click to view Achievement")
			ToolTip1.SetToolTip(TIcon.PictureBox1, "Double click to view Achievement")
			ToolTip1.SetToolTip(TIcon.Label1, "Double click to view Achievement")
			AddHandler TIcon.DoubleClick, AddressOf Trophy_clicked
			AddHandler TIcon.Label1.DoubleClick, AddressOf Trophy_clicked
			AddHandler TIcon.PictureBox1.DoubleClick, AddressOf Trophy_clicked
			AddHandler TIcon.Click, AddressOf Trophy_select
			AddHandler TIcon.Label1.Click, AddressOf Trophy_select
			AddHandler TIcon.PictureBox1.Click, AddressOf Trophy_select
			FlowLayoutPanel1.Controls.Add(TIcon)
		Next

		My.Computer.FileSystem.CurrentDirectory = dir + "\Opp"
		n = My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.CurrentDirectory).Count
		For i = 1 To n
			item = My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.CurrentDirectory).Item(i - 1)
			Dim AIcon = New Ubuntu_look_and_feel.AimIcon
			item = item.Substring(item.LastIndexOf(Char.Parse("\")) + 1)
			With AIcon
				.Name = item
				.Label1.Text = item
				.PictureBox1.Tag = item
				.Tag = item
			End With
			ToolTip1.SetToolTip(AIcon, "Double click to view Opportunity")
			ToolTip1.SetToolTip(AIcon.Label1, "Double click to view Opportunity")
			ToolTip1.SetToolTip(AIcon.PictureBox1, "Double click to view Opportunity")
			AddHandler AIcon.DoubleClick, AddressOf Aim_clicked
			AddHandler AIcon.Label1.DoubleClick, AddressOf Aim_clicked
			AddHandler AIcon.PictureBox1.DoubleClick, AddressOf Aim_clicked
			AddHandler AIcon.Click, AddressOf Aim_select
			AddHandler AIcon.Label1.Click, AddressOf Aim_select
			AddHandler AIcon.PictureBox1.Click, AddressOf Aim_select
			FlowLayoutPanel2.Controls.Add(AIcon)
		Next

		My.Computer.FileSystem.CurrentDirectory = dir
		c = 0
	End Sub

	Private Sub DeleteAButton_Click(sender As Object, e As EventArgs) Handles DeleteAButton.Click
		If MsgBox("Are you sure you want to proceed ?", MsgBoxStyle.YesNo, "Delete achievement?") = MsgBoxResult.Yes Then

			For Each control In FlowLayoutPanel1.Controls
				If DirectCast(control, Ubuntu_look_and_feel.TrophyIcon).BackColor = Color.DarkMagenta Then
					del = DirectCast(control, Ubuntu_look_and_feel.TrophyIcon).Name
					DirectCast(control, Ubuntu_look_and_feel.TrophyIcon).Dispose()
				End If
			Next
			My.Computer.FileSystem.CurrentDirectory = dir + "\Ach"
			My.Computer.FileSystem.DeleteDirectory(del, FileIO.DeleteDirectoryOption.DeleteAllContents)
			My.Computer.FileSystem.CurrentDirectory = dir
		End If
		Deselect_All()
	End Sub

	Public Sub Trophy_select(sender As Object, e As EventArgs)
		Deselect_All()
		Try
			DirectCast(sender, Ubuntu_look_and_feel.TrophyIcon).BackColor = Color.DarkMagenta
		Catch
			Try
				DirectCast(sender, Label).Parent.BackColor = Color.DarkMagenta
			Catch
				DirectCast(sender, PictureBox).Parent.BackColor = Color.DarkMagenta
			End Try
		End Try
		EditAButton.Enabled = True
		DeleteAButton.Enabled = True
	End Sub

	Public Sub Aim_select(sender As Object, e As EventArgs)
		Deselect_All()
		Try
			DirectCast(sender, Ubuntu_look_and_feel.AimIcon).BackColor = Color.DarkMagenta
		Catch
			Try
				DirectCast(sender, Label).Parent.BackColor = Color.DarkMagenta
			Catch
				DirectCast(sender, PictureBox).Parent.BackColor = Color.DarkMagenta
			End Try
		End Try
		EditOButton.Enabled = True
		DeleteOButton.Enabled = True
	End Sub

	Public Sub Trophy_clicked(sender As Object, e As EventArgs)
		Display.Show()
		My.Computer.FileSystem.CurrentDirectory = dir + "\Ach"
		For Each control In FlowLayoutPanel1.Controls
			If DirectCast(control, Ubuntu_look_and_feel.TrophyIcon).BackColor = Color.DarkMagenta Then
				ed = DirectCast(control, Ubuntu_look_and_feel.TrophyIcon).Name
			End If
		Next
		Display.Label2.Text = ed
		My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.CurrentDirectory + "\" + ed
		Dim stream As IO.StreamReader
		If Not (My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory).Item(0) = "z") Then
			item = My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory).Item(0)
			stream = FileIO.FileSystem.OpenTextFileReader(item)
			Display.dt.Text = stream.ReadLine
			Display.Ds.Text = stream.ReadLine
			stream.Close()
		End If

		If My.Computer.FileSystem.FileExists("z") Then
			Dim fs As New IO.FileStream("z", IO.FileMode.Open, IO.FileAccess.Read)
			Display.PictureBox1.Image = Image.FromStream(fs)
			fs.Close()
		End If

		Hide()
	End Sub

	Public Sub Aim_clicked(sender As Object, e As EventArgs)
		Display.Show()
		My.Computer.FileSystem.CurrentDirectory = dir + "\Opp"
		For Each control In FlowLayoutPanel2.Controls
			If DirectCast(control, Ubuntu_look_and_feel.AimIcon).BackColor = Color.DarkMagenta Then
				ed = DirectCast(control, Ubuntu_look_and_feel.AimIcon).Name
			End If
		Next
		Display.Label2.Text = ed
		My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.CurrentDirectory + "\" + ed
		Dim stream As IO.StreamReader
		If Not (My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory).Item(0) = "z") Then
			item = My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory).Item(0)
			stream = FileIO.FileSystem.OpenTextFileReader(item)
			Display.dt.Text = stream.ReadLine
			Display.Ds.Text = stream.ReadLine
			stream.Close()
		End If

		If My.Computer.FileSystem.FileExists("z") Then
			Dim fs As New IO.FileStream("z", IO.FileMode.Open, IO.FileAccess.Read)
			Display.PictureBox2.Image = Image.FromStream(fs)
			fs.Close()
		End If
		Display.PictureBox2.BringToFront()

		Hide()
	End Sub

	Private Sub FlowLayoutPanel_Click(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.Click, FlowLayoutPanel2.Click
		Deselect_All()
	End Sub

	Private Sub Deselect_All()
		For Each control In FlowLayoutPanel1.Controls
			If DirectCast(control, Ubuntu_look_and_feel.TrophyIcon).BackColor = Color.DarkMagenta Then
				DirectCast(control, Ubuntu_look_and_feel.TrophyIcon).BackColor = Color.SteelBlue
			End If
		Next
		For Each control In FlowLayoutPanel2.Controls
			If DirectCast(control, Ubuntu_look_and_feel.AimIcon).BackColor = Color.DarkMagenta Then
				DirectCast(control, Ubuntu_look_and_feel.AimIcon).BackColor = Color.SteelBlue
			End If
		Next
		EditAButton.Enabled = False
		DeleteAButton.Enabled = False
		EditOButton.Enabled = False
		DeleteOButton.Enabled = False
	End Sub

	Private Sub AddOButton_Click(sender As Object, e As EventArgs) Handles AddOButton.Click
		Deselect_All()
		Enabled = False
		Add_new_o.Show()
	End Sub

	Private Sub EditOButton_Click(sender As Object, e As EventArgs) Handles EditOButton.Click
		Edit_o.Show()
		My.Computer.FileSystem.CurrentDirectory = dir + "\Opp"
		For Each control In FlowLayoutPanel2.Controls
			If DirectCast(control, Ubuntu_look_and_feel.AimIcon).BackColor = Color.DarkMagenta Then
				ed = DirectCast(control, Ubuntu_look_and_feel.AimIcon).Name
			End If
		Next
		Edit_o.Title.Text = ed
		Edit_o.Set_ini(ed)
		My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.CurrentDirectory + "\" + ed
		Dim stream As IO.StreamReader

		If Not My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory).Item(0) = "z" Then
			item = My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory).Item(0)
			stream = FileIO.FileSystem.OpenTextFileReader(item)
			Edit_o.DateP.Value = Date.Parse(stream.ReadLine)
			Edit_o.TextBox1.Text = stream.ReadLine
			stream.Close()
		End If

		If My.Computer.FileSystem.FileExists("z") Then
			Dim fs As New IO.FileStream("z", IO.FileMode.Open, IO.FileAccess.Read)
			Edit_o.PictureBox1.Image = Image.FromStream(fs)
			fs.Close()
		End If
		Enabled = False
	End Sub

	Private Sub DeleteOButton_Click(sender As Object, e As EventArgs) Handles DeleteOButton.Click
		If MsgBox("Are you sure you want to proceed ?", MsgBoxStyle.YesNo, "Delete achievement?") = MsgBoxResult.Yes Then
			For Each control In FlowLayoutPanel2.Controls
				If DirectCast(control, Ubuntu_look_and_feel.AimIcon).BackColor = Color.DarkMagenta Then
					del = DirectCast(control, Ubuntu_look_and_feel.AimIcon).Name
					DirectCast(control, Ubuntu_look_and_feel.AimIcon).Dispose()
				End If
			Next
			My.Computer.FileSystem.CurrentDirectory = dir + "\Opp"
			My.Computer.FileSystem.DeleteDirectory(del, FileIO.DeleteDirectoryOption.DeleteAllContents)
			My.Computer.FileSystem.CurrentDirectory = dir
		End If
		Deselect_All()
	End Sub

	Private Sub TabPage_Click(sender As Object, e As EventArgs) Handles TabPage1.Click, TabPage2.Click
		Deselect_All()
	End Sub

	Private Sub UbuntuLNF2_click(sender As Object, e As EventArgs) Handles UbuntuLNF2.Click
		Deselect_All()
	End Sub

	Private Sub EditAButton_Click(sender As Object, e As EventArgs) Handles EditAButton.Click
		Edit_a.Show()
		My.Computer.FileSystem.CurrentDirectory = dir + "\Ach"
		For Each control In FlowLayoutPanel1.Controls
			If DirectCast(control, Ubuntu_look_and_feel.TrophyIcon).BackColor = Color.DarkMagenta Then
				ed = DirectCast(control, Ubuntu_look_and_feel.TrophyIcon).Name
			End If
		Next
		Edit_a.Title.Text = ed
		Edit_a.Set_ini(ed)
		My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.CurrentDirectory + "\" + ed
		Dim stream As IO.StreamReader
		If Not (My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory).Item(0) = "z") Then
			item = My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory).Item(0)
			stream = FileIO.FileSystem.OpenTextFileReader(item)
			Edit_a.DateP.Value = Date.Parse(stream.ReadLine)
			Edit_a.TextBox1.Text = stream.ReadLine
			stream.Close()
		End If

		If My.Computer.FileSystem.FileExists("z") Then
			Dim fs As New IO.FileStream("z", IO.FileMode.Open, IO.FileAccess.Read)
			Edit_a.PictureBox1.Image = Image.FromStream(fs)
			fs.Close()
		End If

		Enabled = False
	End Sub

	Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

	End Sub

	Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
		Deselect_All()
		Aboutw.Show()
		Hide()
	End Sub

	Private Sub MyAchievements_Click(sender As Object, e As EventArgs) Handles Me.Click
		Deselect_All()
	End Sub

	Public Function Get_dir() As String
		Return dir
	End Function

	Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
		Deselect_All()
	End Sub

	Private Sub UbuntuLNF1_Click(sender As Object, e As EventArgs) Handles UbuntuLNF1.Click
		Deselect_All()
	End Sub
End Class