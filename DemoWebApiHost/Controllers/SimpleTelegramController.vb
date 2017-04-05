Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class SimpleTelegramController
        Inherits ApiController

        Public Class Ergebnis
            Public Property Time As DateTime
            Public Property RandomValue As Double
            Public Property Msg As String
        End Class

        ''' Hilfsfunktion, um Implementierung zu vereinfachen.
        ''' !!Achtung: ganz wichtig ist es, die Funktion mit NonAction Attribut auszuzeichnen ! Sonst stuft sie 
        ''' die Laufzeitumgebung als mögliche Action für einen Post Befehl ein. Und das gibt dann einen unerkärlichen Serverfehler 500 ...
        <NonAction>
        Function ToTelString(tel As TelegramSimple) As String
            Return "ID: " & tel.ID.ToString() & ", Sendezeit: " & Now.ToLongTimeString & ", Msg: " & tel.Msg
        End Function

        <HttpPost>
        Public Function PostTime(<FromBody()> tel As TelegramSimple) As Ergebnis


            ' Speichern der übermittelten Nachricht in einer Liste, genannt Log, im Anwendungszustand der Webanwendung
            Try

                ' Um den Anwendungszustand konurrieren die User- Zugriff muss serialisiert werden
                HttpContext.Current.Application.Lock()

                If HttpContext.Current.Application("Log") Is Nothing Then
                    HttpContext.Current.Application("Log") = New List(Of Telegram)
                End If

                Dim Log As List(Of Telegram) = CType(HttpContext.Current.Application("Log"), List(Of Telegram))
                Log.Add(New Telegram() With {.ID = Guid.NewGuid, .Posted = Now, .Msg = tel.Msg})

            Finally
                HttpContext.Current.Application.UnLock()
            End Try

            Dim timeString As String = Now.ToLongTimeString()

            Dim rnd As New Random()
            Dim res As New Ergebnis
            With res
                .RandomValue = rnd.Next
                .Time = Now
                .Msg = " Telelgeramm mit ID " & tel.ID.ToString() & " erfolgreich verarbeitet"
            End With

            Return res

        End Function


    End Class
End Namespace