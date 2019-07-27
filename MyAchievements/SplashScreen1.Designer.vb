<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen1
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
	Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
	Friend WithEvents Version As System.Windows.Forms.Label
	Friend WithEvents Copyright As System.Windows.Forms.Label
	Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
		Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
		Me.Copyright = New System.Windows.Forms.Label()
		Me.Version = New System.Windows.Forms.Label()
		Me.ApplicationTitle = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
		Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.DetailsLayoutPanel.SuspendLayout()
		Me.SuspendLayout()
		'
		'MainLayoutPanel
		'
		Me.MainLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.MainLayoutPanel.BackColor = System.Drawing.Color.MidnightBlue
		Me.MainLayoutPanel.BackgroundImage = Global.Achievementz.My.Resources.Resources.Ach
		Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.MainLayoutPanel.ColumnCount = 2
		Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
		Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253.0!))
		Me.MainLayoutPanel.Location = New System.Drawing.Point(163, 1)
		Me.MainLayoutPanel.Name = "MainLayoutPanel"
		Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
		Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
		Me.MainLayoutPanel.Size = New System.Drawing.Size(379, 387)
		Me.MainLayoutPanel.TabIndex = 0
		'
		'DetailsLayoutPanel
		'
		Me.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.MidnightBlue
		Me.DetailsLayoutPanel.ColumnCount = 1
		Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
		Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
		Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 1)
		Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 0)
		Me.DetailsLayoutPanel.Location = New System.Drawing.Point(585, 315)
		Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
		Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
		Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
		Me.DetailsLayoutPanel.Size = New System.Drawing.Size(130, 47)
		Me.DetailsLayoutPanel.TabIndex = 1
		'
		'Copyright
		'
		Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Copyright.BackColor = System.Drawing.Color.MidnightBlue
		Me.Copyright.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Copyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Copyright.Location = New System.Drawing.Point(3, 23)
		Me.Copyright.Name = "Copyright"
		Me.Copyright.Size = New System.Drawing.Size(241, 24)
		Me.Copyright.TabIndex = 2
		Me.Copyright.Text = "©  2019 Zerene."
		'
		'Version
		'
		Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Version.BackColor = System.Drawing.Color.MidnightBlue
		Me.Version.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Version.Location = New System.Drawing.Point(3, 1)
		Me.Version.Name = "Version"
		Me.Version.Size = New System.Drawing.Size(241, 20)
		Me.Version.TabIndex = 1
		Me.Version.Text = "Version 1.0.0"
		'
		'ApplicationTitle
		'
		Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.ApplicationTitle.BackColor = System.Drawing.Color.MidnightBlue
		Me.ApplicationTitle.Font = New System.Drawing.Font("Monotype Corsiva", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ApplicationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ApplicationTitle.Location = New System.Drawing.Point(476, 131)
		Me.ApplicationTitle.Name = "ApplicationTitle"
		Me.ApplicationTitle.Size = New System.Drawing.Size(302, 60)
		Me.ApplicationTitle.TabIndex = 0
		Me.ApplicationTitle.Text = "Achievementz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
		Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(480, 182)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(201, 41)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "by Zerene."
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ShapeContainer1
		'
		Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
		Me.ShapeContainer1.Name = "ShapeContainer1"
		Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape2})
		Me.ShapeContainer1.Size = New System.Drawing.Size(878, 384)
		Me.ShapeContainer1.TabIndex = 3
		Me.ShapeContainer1.TabStop = False
		'
		'OvalShape2
		'
		Me.OvalShape2.BackColor = System.Drawing.Color.MidnightBlue
		Me.OvalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
		Me.OvalShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
		Me.OvalShape2.Location = New System.Drawing.Point(73, -99)
		Me.OvalShape2.Name = "OvalShape2"
		Me.OvalShape2.Size = New System.Drawing.Size(721, 588)
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 5000
		'
		'SplashScreen1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(878, 384)
		Me.ControlBox = False
		Me.Controls.Add(Me.DetailsLayoutPanel)
		Me.Controls.Add(Me.ApplicationTitle)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.MainLayoutPanel)
		Me.Controls.Add(Me.ShapeContainer1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "SplashScreen1"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Achievementz"
		Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.DetailsLayoutPanel.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
	Friend WithEvents OvalShape2 As PowerPacks.OvalShape
	Friend WithEvents Timer1 As Timer
End Class
