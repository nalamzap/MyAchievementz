Imports System.ComponentModel

Public NotInheritable Class SplashScreen1

	Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		'Dim fnt As New System.Drawing.Text.PrivateFontCollection

		'fnt.AddFontFile("LCALLIG.TTF")
		'fnt.AddFontFile("LHANDW.TTF")
		'fnt.AddFontFile("MTCORSVA.TTF")

		'Copyright.Font = New Font(fnt.Families(1), 9.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'Version.Font = New Font(fnt.Families(1), 9.0!, FontStyle.Bold, GraphicsUnit.Point, 0)
		'ApplicationTitle.Font = New Font(fnt.Families(2), 39.75!, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
		'Label1.Font = New Font(fnt.Families(2), 24.0!, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)

	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Achievementz.Show()
		Close()
	End Sub

	Private Sub SplashScreen1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Timer1.Stop()
	End Sub
End Class