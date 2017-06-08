Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<STAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Application.Run(New GUI.FormPhieuThuTien())
	End Sub
End Class
