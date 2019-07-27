<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Achievementz
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Achievementz))
		Me.Achievements_button = New System.Windows.Forms.Button()
		Me.Opportunities_button = New System.Windows.Forms.Button()
		Me.AddAButton = New System.Windows.Forms.Button()
		Me.DeleteAButton = New System.Windows.Forms.Button()
		Me.EditAButton = New System.Windows.Forms.Button()
		Me.About = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.AddOButton = New System.Windows.Forms.Button()
		Me.EditOButton = New System.Windows.Forms.Button()
		Me.DeleteOButton = New System.Windows.Forms.Button()
		Me.UbuntuLNF2 = New look_and_feel.UbuntuLNF()
		Me.UbuntuLNF1 = New Ubuntu_look_and_feel.UbuntuLNF()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Achievements_button
		'
		Me.Achievements_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
		Me.Achievements_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Achievements_button.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Achievements_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.Achievements_button.Location = New System.Drawing.Point(12, 44)
		Me.Achievements_button.Name = "Achievements_button"
		Me.Achievements_button.Size = New System.Drawing.Size(188, 42)
		Me.Achievements_button.TabIndex = 1
		Me.Achievements_button.Text = "ACHIEVEMENTS"
		Me.Achievements_button.UseVisualStyleBackColor = False
		'
		'Opportunities_button
		'
		Me.Opportunities_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
		Me.Opportunities_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Opportunities_button.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Opportunities_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.Opportunities_button.Location = New System.Drawing.Point(200, 44)
		Me.Opportunities_button.Name = "Opportunities_button"
		Me.Opportunities_button.Size = New System.Drawing.Size(188, 42)
		Me.Opportunities_button.TabIndex = 2
		Me.Opportunities_button.Text = "OPPORTUNITIES"
		Me.Opportunities_button.UseVisualStyleBackColor = False
		'
		'AddAButton
		'
		Me.AddAButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
		Me.AddAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AddAButton.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AddAButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.AddAButton.Location = New System.Drawing.Point(8, 410)
		Me.AddAButton.Name = "AddAButton"
		Me.AddAButton.Size = New System.Drawing.Size(97, 41)
		Me.AddAButton.TabIndex = 4
		Me.AddAButton.Text = "ADD"
		Me.AddAButton.UseVisualStyleBackColor = False
		'
		'DeleteAButton
		'
		Me.DeleteAButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
		Me.DeleteAButton.Enabled = False
		Me.DeleteAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DeleteAButton.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DeleteAButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.DeleteAButton.Location = New System.Drawing.Point(214, 410)
		Me.DeleteAButton.Name = "DeleteAButton"
		Me.DeleteAButton.Size = New System.Drawing.Size(97, 41)
		Me.DeleteAButton.TabIndex = 5
		Me.DeleteAButton.Text = "DELETE"
		Me.DeleteAButton.UseVisualStyleBackColor = False
		'
		'EditAButton
		'
		Me.EditAButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
		Me.EditAButton.Enabled = False
		Me.EditAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.EditAButton.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EditAButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.EditAButton.Location = New System.Drawing.Point(111, 410)
		Me.EditAButton.Name = "EditAButton"
		Me.EditAButton.Size = New System.Drawing.Size(97, 41)
		Me.EditAButton.TabIndex = 6
		Me.EditAButton.Text = "EDIT"
		Me.EditAButton.UseVisualStyleBackColor = False
		'
		'About
		'
		Me.About.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
		Me.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.About.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.About.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.About.Location = New System.Drawing.Point(699, 44)
		Me.About.Name = "About"
		Me.About.Size = New System.Drawing.Size(105, 42)
		Me.About.TabIndex = 8
		Me.About.Text = "About"
		Me.About.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(255, -1)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(306, 42)
		Me.Label1.TabIndex = 9
		Me.Label1.Text = "ACHIEVEMENTZ"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Location = New System.Drawing.Point(-4, 77)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(825, 487)
		Me.TabControl1.TabIndex = 10
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(240, Byte), Integer))
		Me.TabPage1.Controls.Add(Me.FlowLayoutPanel1)
		Me.TabPage1.Controls.Add(Me.AddAButton)
		Me.TabPage1.Controls.Add(Me.EditAButton)
		Me.TabPage1.Controls.Add(Me.DeleteAButton)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(817, 461)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "TabPage1"
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel1.AutoScroll = True
		Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(240, Byte), Integer))
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(811, 400)
		Me.FlowLayoutPanel1.TabIndex = 3
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(240, Byte), Integer))
		Me.TabPage2.Controls.Add(Me.FlowLayoutPanel2)
		Me.TabPage2.Controls.Add(Me.AddOButton)
		Me.TabPage2.Controls.Add(Me.EditOButton)
		Me.TabPage2.Controls.Add(Me.DeleteOButton)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(817, 461)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "TabPage2"
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel2.AutoScroll = True
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(811, 400)
		Me.FlowLayoutPanel2.TabIndex = 7
		'
		'AddOButton
		'
		Me.AddOButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
		Me.AddOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AddOButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.AddOButton.Location = New System.Drawing.Point(8, 410)
		Me.AddOButton.Name = "AddOButton"
		Me.AddOButton.Size = New System.Drawing.Size(97, 41)
		Me.AddOButton.TabIndex = 8
		Me.AddOButton.Text = "ADD"
		Me.AddOButton.UseVisualStyleBackColor = False
		'
		'EditOButton
		'
		Me.EditOButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
		Me.EditOButton.Enabled = False
		Me.EditOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.EditOButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.EditOButton.Location = New System.Drawing.Point(111, 410)
		Me.EditOButton.Name = "EditOButton"
		Me.EditOButton.Size = New System.Drawing.Size(97, 41)
		Me.EditOButton.TabIndex = 10
		Me.EditOButton.Text = "EDIT"
		Me.EditOButton.UseVisualStyleBackColor = False
		'
		'DeleteOButton
		'
		Me.DeleteOButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
		Me.DeleteOButton.Enabled = False
		Me.DeleteOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DeleteOButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.DeleteOButton.Location = New System.Drawing.Point(214, 410)
		Me.DeleteOButton.Name = "DeleteOButton"
		Me.DeleteOButton.Size = New System.Drawing.Size(97, 41)
		Me.DeleteOButton.TabIndex = 9
		Me.DeleteOButton.Text = "DELETE"
		Me.DeleteOButton.UseVisualStyleBackColor = False
		'
		'UbuntuLNF2
		'
		Me.UbuntuLNF2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
		Me.UbuntuLNF2.Location = New System.Drawing.Point(0, 560)
		Me.UbuntuLNF2.Name = "UbuntuLNF2"
		Me.UbuntuLNF2.Size = New System.Drawing.Size(1000, 176)
		Me.UbuntuLNF2.TabIndex = 23
		'
		'UbuntuLNF1
		'
		Me.UbuntuLNF1.AccessibleName = "tBar"
		Me.UbuntuLNF1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
		Me.UbuntuLNF1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.UbuntuLNF1.Location = New System.Drawing.Point(0, -1)
		Me.UbuntuLNF1.MaximumSize = New System.Drawing.Size(816, 100)
		Me.UbuntuLNF1.Name = "UbuntuLNF1"
		Me.UbuntuLNF1.Size = New System.Drawing.Size(816, 100)
		Me.UbuntuLNF1.TabIndex = 7
		'
		'ToolTip1
		'
		Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.ToolTip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		'
		'Achievementz
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(816, 596)
		Me.ControlBox = False
		Me.Controls.Add(Me.UbuntuLNF2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.About)
		Me.Controls.Add(Me.Opportunities_button)
		Me.Controls.Add(Me.Achievements_button)
		Me.Controls.Add(Me.UbuntuLNF1)
		Me.Controls.Add(Me.TabControl1)
		Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.Name = "Achievementz"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Achievementz"
		Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer))
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Achievements_button As Button
	Friend WithEvents Opportunities_button As Button
	Friend WithEvents AddAButton As Button
	Friend WithEvents DeleteAButton As Button
	Friend WithEvents EditAButton As Button
	Friend WithEvents About As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents UbuntuLNF2 As look_and_feel.UbuntuLNF
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents AddOButton As Button
	Friend WithEvents EditOButton As Button
	Friend WithEvents DeleteOButton As Button
	Friend WithEvents UbuntuLNF1 As Ubuntu_look_and_feel.UbuntuLNF
	Friend WithEvents ToolTip1 As ToolTip
End Class
