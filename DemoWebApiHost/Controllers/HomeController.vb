Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Title") = "Home Page"

        Return View()
    End Function


    Const AppLogKey = "Log"

    ''' <summary>
    ''' Generiert eine partielle View der aktuellen Logbucheinträge
    ''' </summary>
    ''' <returns></returns>
    Function LogTab() As ActionResult

        Dim logModel As Telegram()

        ' Speichern der übermittelten Nachricht in einer Liste, genannt Log, im Anwendungszustand der Webanwendung        
        Try
            ' Um den Anwendungszustand konurrieren die User- Zugriff muss serialisiert werden
            HttpContext.Application.Lock()

            If HttpContext.Application(AppLogKey) Is Nothing Then
                HttpContext.Application(AppLogKey) = New List(Of Telegram)
            End If

            Dim Log As List(Of Telegram) = CType(HttpContext.Application(AppLogKey), List(Of Telegram))
            logModel = Log.ToArray()

        Finally
            HttpContext.Application.UnLock()
        End Try

        Return View(logModel)

    End Function


End Class
