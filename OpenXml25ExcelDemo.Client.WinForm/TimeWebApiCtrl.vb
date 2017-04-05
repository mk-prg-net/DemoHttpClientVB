Imports System.Web.Http
''' <summary>
''' Stuttgart, den 4.7.2016
''' Martin Korneffel
''' Demo eine Wep- API Controllers
''' </summary>
''' <remarks></remarks>
Public Class TimeWebApiController
    Inherits System.Web.Http.ApiController

    ''' <summary>
    ''' Datenstruktur für den Response
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Ergebnis
        Public Property Time As DateTime
        Public Property RandomValue As Double
    End Class

    ''' <summary>
    ''' Implementiert Get- Befehl, indem die aktuelle Uhrzeit ermittelt, und an den Rufer zurückgegeben wird.
    ''' Im QueryString wird ein name erwartet.
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <HttpGet>
    Public Function GetTime(name As String) As Ergebnis

        ' DAten aus dem Quierystring werden an die Anwendung weitergegeben
        AustauschWebApiGui.Info = name

        Dim timeString As String = Now.ToLongTimeString()
        ' Achtun MEssageBox blockiert
        'MessageBox.Show("Sie haben remote eingegeben: " & name)

        Dim rnd As New Random()
        Dim res As New Ergebnis
        With res
            .RandomValue = rnd.Next
            .Time = Now
        End With

        Return res
    End Function


    <HttpPost>
    Public Function PostTime(tel As Telegram) As Ergebnis

        AustauschWebApiGui.Info = "ID: " & tel.ID.ToString() & ", Sendezeit: " & tel.Posted.ToLongTimeString() & ", Msg: " & tel.Msg

        Dim timeString As String = Now.ToLongTimeString()
        ' Achtun MEssageBox blockiert
        'MessageBox.Show("Sie haben remote eingegeben: " & name)

        Dim rnd As New Random()
        Dim res As New Ergebnis
        With res
            .RandomValue = rnd.Next
            .Time = Now
        End With

        Return res

    End Function






End Class
