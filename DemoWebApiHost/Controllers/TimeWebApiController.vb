Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class TimeWebApiController
        Inherits ApiController

        ''' <summary>
        ''' Datenstruktur für den Response
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Ergebnis
            Public Property Time As DateTime
            Public Property RandomValue As Double
            Public Property Msg As String
        End Class

        Function ToTelString(tel As Telegram) As String
            Return "ID: " & tel.ID.ToString() & ", Sendezeit: " & tel.Posted.ToLongTimeString() & ", Msg: " & tel.Msg
        End Function

        ''' <summary>
        ''' Implementiert Get- Befehl
        ''' Das Telegramm wurde im Querystring als eine Liste von Parametern übertragen:
        ''' ?ID=0A1...&Posted=2017-04-05T12:00:00&Msg=Hallo Welt
        ''' </summary>
        ''' <param name="name"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <HttpGet>
        Public Function GetTime(tel As Telegram) As Ergebnis

            ' Speichern der übermittelten Nachricht in einer Liste, genannt Log, im Anwendungszustand der Webanwendung        
            Try
                ' Um den Anwendungszustand konurrieren die User- Zugriff muss serialisiert werden
                HttpContext.Current.Application.Lock()

                If HttpContext.Current.Application("Log") Is Nothing Then
                    HttpContext.Current.Application("Log") = New List(Of String)
                End If

                Dim Log As List(Of Telegram) = CType(HttpContext.Current.Application("Log"), List(Of Telegram))
                Log.Add(tel)

            Finally
                HttpContext.Current.Application.UnLock()
            End Try

            ' Antwort (Response) des Webdienstes wird formuliert
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


        <HttpPost>
        Public Function PostTime(tel As Telegram) As Ergebnis

            ' Speichern der übermittelten Nachricht in einer Liste, genannt Log, im Anwendungszustand der Webanwendung
            Try
                ' Um den Anwendungszustand konurrieren die User- Zugriff muss serialisiert werden
                HttpContext.Current.Application.Lock()

                If HttpContext.Current.Application("Log") Is Nothing Then
                    HttpContext.Current.Application("Log") = New List(Of String)
                End If

                Dim Log As List(Of Telegram) = CType(HttpContext.Current.Application("Log"), List(Of Telegram))
                Log.Add(tel)

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