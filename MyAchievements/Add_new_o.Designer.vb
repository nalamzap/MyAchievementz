<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_new_o
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.UbuntuLNF1 = New Ubuntu_look_and_feel.UbuntuLNF()
		Me.Back = New System.Windows.Forms.Button()
		Me.Save = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Title = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.DateP = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
		Me.Add_img = New System.Windows.Forms.Button()
		Me.Remove_img = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.UbuntuLNF2 = New look_and_feel.UbuntuLNF()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'UbuntuLNF1
		'
		Me.UbuntuLNF1.AccessibleName = "tBar"
		Me.UbuntuLNF1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.UbuntuLNF1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.UbuntuLNF1.Location = New System.Drawing.Point(-217, 0)
		Me.UbuntuLNF1.MaximumSize = New System.Drawing.Size(1000, 100)
		Me.UbuntuLNF1.Name = "UbuntuLNF1"
		Me.UbuntuLNF1.Size = New System.Drawing.Size(1000, 94)
		Me.UbuntuLNF1.TabIndex = 0
		'
		'Back
		'
		Me.Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
		Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Back.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.Back.Location = New System.Drawing.Point(12, 25)
		Me.Back.Name = "Back"
		Me.Back.Size = New System.Drawing.Size(104, 42)
		Me.Back.TabIndex = 2
		Me.Back.Text = "Back"
		Me.Back.UseVisualStyleBackColor = False
		'
		'Save
		'
		Me.Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
		Me.Save.Enabled = False
		Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Save.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.Save.Location = New System.Drawing.Point(450, 25)
		Me.Save.Name = "Save"
		Me.Save.Size = New System.Drawing.Size(104, 42)
		Me.Save.TabIndex = 3
		Me.Save.Text = "Save"
		Me.Save.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(142, -1)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(276, 42)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Add new Opportunity"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(13, 120)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(92, 21)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Title(*):"
		'
		'Title
		'
		Me.Title.Location = New System.Drawing.Point(104, 120)
		Me.Title.Name = "Title"
		Me.Title.Size = New System.Drawing.Size(220, 20)
		Me.Title.TabIndex = 6
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(13, 151)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(93, 21)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Date(*):"
		'
		'DateP
		'
		Me.DateP.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption
		Me.DateP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateP.Location = New System.Drawing.Point(211, 151)
		Me.DateP.MaxDate = New Date(2200, 6, 30, 0, 0, 0, 0)
		Me.DateP.MinDate = Date.Today
		Me.DateP.Name = "DateP"
		Me.DateP.Size = New System.Drawing.Size(113, 20)
		Me.DateP.TabIndex = 8
		Me.DateP.Value = Date.Today
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(13, 184)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(160, 21)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Description(*):"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(16, 208)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(308, 198)
		Me.TextBox1.TabIndex = 10
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(330, 120)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(88, 21)
		Me.Label5.TabIndex = 14
		Me.Label5.Text = "Picture:"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(168, 189)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(123, 13)
		Me.Label8.TabIndex = 17
		Me.Label8.Text = "(Minimum 15 Characters)"
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(271, 189)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(53, 16)
		Me.Label9.TabIndex = 18
		Me.Label9.Text = "[0]"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'OpenFileDialog
		'
		Me.OpenFileDialog.Filter = "JPG images|*.jpg;*.jpeg|PNG images|*.png"
		Me.OpenFileDialog.RestoreDirectory = True
		Me.OpenFileDialog.SupportMultiDottedExtensions = True
		Me.OpenFileDialog.Title = "Select Picture"
		'
		'Add_img
		'
		Me.Add_img.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Add_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Add_img.Location = New System.Drawing.Point(329, 306)
		Me.Add_img.Name = "Add_img"
		Me.Add_img.Size = New System.Drawing.Size(111, 23)
		Me.Add_img.TabIndex = 19
		Me.Add_img.Text = "Add/Change"
		Me.Add_img.UseVisualStyleBackColor = False
		'
		'Remove_img
		'
		Me.Remove_img.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Remove_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Remove_img.Location = New System.Drawing.Point(443, 306)
		Me.Remove_img.Name = "Remove_img"
		Me.Remove_img.Size = New System.Drawing.Size(111, 23)
		Me.Remove_img.TabIndex = 20
		Me.Remove_img.Text = "Remove"
		Me.Remove_img.UseVisualStyleBackColor = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(353, 393)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(201, 13)
		Me.Label6.TabIndex = 21
		Me.Label6.Text = "Note: Fields with star(*) are required fields"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.White
		Me.PictureBox1.BackgroundImage = Global.Achievementz.My.Resources.Resources.Aip
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox1.Location = New System.Drawing.Point(329, 151)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(225, 149)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 12
		Me.PictureBox1.TabStop = False
		'
		'UbuntuLNF2
		'
		Me.UbuntuLNF2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
		Me.UbuntuLNF2.Location = New System.Drawing.Point(0, 410)
		Me.UbuntuLNF2.Name = "UbuntuLNF2"
		Me.UbuntuLNF2.Size = New System.Drawing.Size(1000, 176)
		Me.UbuntuLNF2.TabIndex = 24
		'
		'Add_new_o
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(567, 446)
		Me.ControlBox = False
		Me.Controls.Add(Me.UbuntuLNF2)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Remove_img)
		Me.Controls.Add(Me.Add_img)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.DateP)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Title)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Save)
		Me.Controls.Add(Me.Back)
		Me.Controls.Add(Me.UbuntuLNF1)
		Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.Name = "Add_new_o"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Achievementz"
		Me.TopMost = True
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents UbuntuLNF1 As Ubuntu_look_and_feel.UbuntuLNF
	Friend WithEvents Back As Button
	Friend WithEvents Save As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Title As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents DateP As DateTimePicker
	Friend WithEvents Label4 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents OpenFileDialog As OpenFileDialog
	Friend WithEvents Add_img As Button
	Friend WithEvents Remove_img As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents UbuntuLNF2 As look_and_feel.UbuntuLNF
End Class
