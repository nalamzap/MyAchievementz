Imports System.ComponentModel

Public Class Add_new_o
	Dim x, y As Boolean, loc As Point

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

	Private Sub Add_new_o_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		Achievementz.Enabled = True
	End Sub

	Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
		Close()
	End Sub
	Private Sub Add_new_o_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'My.Computer.FileSystem.CurrentDirectory = Achievementz.Get_dir
		'Dim fnt As New Text.PrivateFontCollection
		'fnt.AddFontFile("LCALLIG.TTF")
		'fnt.AddFontFile("LHANDW.TTF")
		'fnt.AddFontFile("MTCORSVA.TTF")
		'Back.Font = New Font(fnt.Families(1), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'Save.Font = New Font(fnt.Families(1), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'Label1.Font = New Font(fnt.Families(2), 21.75!, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
		'Label2.Font = New Font(fnt.Families(1), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'Label3.Font = New Font(fnt.Families(1), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'Label4.Font = New Font(fnt.Families(1), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'Label5.Font = New Font(fnt.Families(1), 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0)

		UbuntuLNF2.Label1.Location = New Point(380, -8)
		DateP.MinDate = Date.Today
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
		Dim AIcon = New Ubuntu_look_and_feel.AimIcon
		My.Computer.FileSystem.CurrentDirectory = Achievementz.Get_dir & "\Opp"
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

		With AIcon
			.Name = Title.Text
			.Label1.Text = Title.Text
			.PictureBox1.Tag = Title.Text
			.Tag = Title.Text
		End With

		Achievementz.ToolTip1.SetToolTip(AIcon, "Double click to view Opportunity")
		Achievementz.ToolTip1.SetToolTip(AIcon.Label1, "Double click to view Opportunity")
		Achievementz.ToolTip1.SetToolTip(AIcon.PictureBox1, "Double click to view Opportunity")

		AddHandler AIcon.DoubleClick, AddressOf Achievementz.Aim_clicked
		AddHandler AIcon.Label1.DoubleClick, AddressOf Achievementz.Aim_clicked
		AddHandler AIcon.PictureBox1.DoubleClick, AddressOf Achievementz.Aim_clicked
		AddHandler AIcon.Click, AddressOf Achievementz.Aim_select
		AddHandler AIcon.Label1.Click, AddressOf Achievementz.Aim_select
		AddHandler AIcon.PictureBox1.Click, AddressOf Achievementz.Aim_select



		Achievementz.FlowLayoutPanel2.Controls.Add(AIcon)

		Close()
	End Sub
End Class