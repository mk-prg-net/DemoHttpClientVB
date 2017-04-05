Imports Microsoft.Owin.Hosting

Module Programm

    Public Sub Main(args() As String)

        Dim baseUrl = "http://localhost:6000/"

        Using WebApp.Start(Of StartUp)(baseUrl)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Using


    End Sub

End Module
