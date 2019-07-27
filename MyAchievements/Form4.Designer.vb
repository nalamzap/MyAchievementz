<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.UbuntuLNF1 = New Ubuntu_look_and_feel.UbuntuLNF()
		Me.UbuntuLNF2 = New look_and_feel.UbuntuLNF()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.back = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.dt = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Ds = New System.Windows.Forms.Label()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = Global.Achievementz.My.Resources.Resources.Trop2
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox1.Location = New System.Drawing.Point(12, 44)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(544, 236)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'UbuntuLNF1
		'
		Me.UbuntuLNF1.AccessibleName = "tBar"
		Me.UbuntuLNF1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.UbuntuLNF1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.UbuntuLNF1.Location = New System.Drawing.Point(-92, -62)
		Me.UbuntuLNF1.MaximumSize = New System.Drawing.Size(816, 100)
		Me.UbuntuLNF1.Name = "UbuntuLNF1"
		Me.UbuntuLNF1.Size = New System.Drawing.Size(816, 100)
		Me.UbuntuLNF1.TabIndex = 1
		'
		'UbuntuLNF2
		'
		Me.UbuntuLNF2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
		Me.UbuntuLNF2.Location = New System.Drawing.Point(-27, 457)
		Me.UbuntuLNF2.Name = "UbuntuLNF2"
		Me.UbuntuLNF2.Size = New System.Drawing.Size(1000, 176)
		Me.UbuntuLNF2.TabIndex = 24
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(-5, 445)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(580, 23)
		Me.Label1.TabIndex = 25
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(139, -1)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(291, 39)
		Me.Label2.TabIndex = 26
		Me.Label2.Text = "Label2"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label2.UseCompatibleTextRendering = True
		'
		'back
		'
		Me.back.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
		Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.back.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.back.Location = New System.Drawing.Point(10, 4)
		Me.back.Name = "back"
		Me.back.Size = New System.Drawing.Size(121, 30)
		Me.back.TabIndex = 27
		Me.back.Text = "BACK"
		Me.back.UseVisualStyleBackColor = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(344, 283)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(93, 21)
		Me.Label3.TabIndex = 28
		Me.Label3.Text = "Date(*):"
		'
		'dt
		'
		Me.dt.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dt.Location = New System.Drawing.Point(443, 282)
		Me.dt.Name = "dt"
		Me.dt.Size = New System.Drawing.Size(113, 21)
		Me.dt.TabIndex = 29
		Me.dt.Text = "Label4"
		Me.dt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(6, 283)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(160, 21)
		Me.Label5.TabIndex = 30
		Me.Label5.Text = "Description(*):"
		'
		'Ds
		'
		Me.Ds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Ds.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Ds.Location = New System.Drawing.Point(12, 304)
		Me.Ds.Name = "Ds"
		Me.Ds.Size = New System.Drawing.Size(544, 157)
		Me.Ds.TabIndex = 31
		Me.Ds.Text = "Label4"
		'
		'PictureBox2
		'
		Me.PictureBox2.BackgroundImage = Global.Achievementz.My.Resources.Resources.Aip
		Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox2.Location = New System.Drawing.Point(12, 44)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(544, 236)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 32
		Me.PictureBox2.TabStop = False
		'
		'Display
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(568, 506)
		Me.Controls.Add(Me.Ds)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.back)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.UbuntuLNF1)
		Me.Controls.Add(Me.UbuntuLNF2)
		Me.Controls.Add(Me.dt)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.PictureBox2)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Display"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Achievementz"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents UbuntuLNF1 As Ubuntu_look_and_feel.UbuntuLNF
	Friend WithEvents UbuntuLNF2 As look_and_feel.UbuntuLNF
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents back As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents dt As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Ds As Label
	Friend WithEvents PictureBox2 As PictureBox
End Class
