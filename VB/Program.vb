Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel

Namespace Rolodex
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

			DevExpress.Skins.SkinManager.EnableFormSkins()
			DevExpress.UserSkins.BonusSkins.Register()
			UserLookAndFeel.Default.SetSkinStyle("Office 2013")

			Application.Run(New Main())
		End Sub
	End Class
End Namespace