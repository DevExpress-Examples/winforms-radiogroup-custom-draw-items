Imports System
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace WindowsApplication3

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call SkinManager.EnableFormSkins()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Main())
        End Sub
    End Module
End Namespace
