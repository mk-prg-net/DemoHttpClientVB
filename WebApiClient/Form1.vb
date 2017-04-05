' (C) Martin Korneffel IT-Beratung/softwareentwicklung 2017
Imports System.Net.Http

Public Class Form1

    Public Class Ergebnis
        Public Property Time As DateTime
        Public Property RandomValue As Double
    End Class

    Const BaseUriPort = "http://localhost:{0}/api/"
    Const WebApiControllerName = "TimeWebApi"

    ''' <summary>
    ''' Senden des Telegramms als Http Get im Querystring
    ''' </summary>
    ''' <param name="tel"></param>
    ''' <returns></returns>
    Function ToQueryString(tel As Telegram) As String
        Dim format As String = "ID={0}&Posted={1}&Msg={2}"
        Return String.Format(format, tel.ID.ToString(), tel.Posted.ToString("s"), tel.Msg)
    End Function

    ''' <summary>
    ''' Mit HttpClient einen Get- Request an eine WebApi- Action senden.  Parameter werden im Querystring des HTTP- Request gesendet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub btnSenden_Click(sender As Object, e As EventArgs) Handles btnSenden.Click

        Try
            Dim BaseUri = String.Format(BaseUriPort, tbxPort.Text)

            Dim client As New HttpClient()
            client.BaseAddress = New Uri(BaseUri & WebApiControllerName)

            Dim tel As New Telegram With {.ID = Guid.NewGuid, .Posted = Now, .Msg = tbxNachricht.Text}

            Dim responseMsg As HttpResponseMessage = client.GetAsync("?" & ToQueryString(tel)).Result

            If responseMsg.IsSuccessStatusCode Then

                Dim msg = Await responseMsg.Content.ReadAsStringAsync()
                Dim TimeObj = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Ergebnis)(msg)

                lblServerTime.Text = TimeObj.Time.ToLongTimeString()
            Else
                ' Fehlerbehandlung
                lblServerTime.Text = "Status: " & responseMsg.StatusCode & " Reason: " & responseMsg.ReasonPhrase

            End If

        Catch ex As Exception
            lblServerTime.Text = mko.ExceptionHelper.FlattenExceptionMessages(ex)
        End Try

    End Sub


    Const MimeTypeJson As String = "application/json"

    ''' <summary>
    ''' Mit HttpClient einen Post- Request an eine WebApi- Action senden. Parameter werden im Payload des HTTP- Request gesendet.
    ''' Das Telegramm, welches an den restful WebApi Dienst gesendet wird, besteht aus einem String, einer Guid und einem Datum.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub btnSendWithPost_Click(sender As Object, e As EventArgs) Handles btnSendWithPost.Click

        Try

            Dim BaseUri = String.Format(BaseUriPort, tbxPort.Text)

            Dim client As New HttpClient()
            client.BaseAddress = New Uri(BaseUri & WebApiControllerName)
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue(MimeTypeJson))

            Dim tel As New Telegram With {.ID = Guid.NewGuid, .Posted = Now, .Msg = tbxNachricht.Text}



            ' Serialisieren des Telegramms als Json- String mittels der freien Bibliothek Newtonsoft.Json
            ' (siehe NuGet)

            Dim sett As New Newtonsoft.Json.JsonSerializerSettings()
            With sett
                .DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat
                .DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc

            End With


            Dim telAsJsonString = Newtonsoft.Json.JsonConvert.SerializeObject(tel, sett) '.ToString()

            ' Erzeugen de mit dem Http Post Befehls zu übertragenden Datenpaketes
            Dim content As New StringContent(telAsJsonString, System.Text.Encoding.UTF8, MimeTypeJson)

            Dim js = Await content.ReadAsStringAsync()

            ' asynchroner Post- Request
            Dim responseMsg As HttpResponseMessage = client.PostAsync("", content).Result

            If responseMsg.IsSuccessStatusCode Then

                Dim msg = Await responseMsg.Content.ReadAsStringAsync()
                Dim TimeObj = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Ergebnis)(msg)

                lblServerTime.Text = TimeObj.Time.ToLongTimeString()
            Else
                ' Fehlerbehandlung
                lblServerTime.Text = "Status: " & responseMsg.StatusCode & " Reason: " & responseMsg.ReasonPhrase

            End If

        Catch ex As Exception
            lblServerTime.Text = mko.ExceptionHelper.FlattenExceptionMessages(ex)
        End Try


    End Sub

    ''' <summary>
    ''' Mittels Post an den einfachen Value- Controler Daten senden
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub btnSendValue_Click(sender As Object, e As EventArgs) Handles btnSendValue.Click
        Try

            Dim BaseUri = String.Format(BaseUriPort, tbxPort.Text)

            Dim client As New HttpClient()
            client.BaseAddress = New Uri(BaseUri & "Values")
            client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"))

            ' Payload als KEyValue Pair- Liste erzeugen
            Dim params(1) As KeyValuePair(Of String, String)
            params(0) = New KeyValuePair(Of String, String)("value", tbxNachricht.Text)

            ' Erzeugen de mit dem Http Post Befehls zu übertragenden Datenpaketes
            Dim content As New FormUrlEncodedContent(params)

            ' asynchroner Post- Request
            Dim responseMsg As HttpResponseMessage = client.PostAsync("", content).Result

            If responseMsg.IsSuccessStatusCode Then

                Dim msg = Await responseMsg.Content.ReadAsStringAsync()

                lblServerTime.Text = Now.ToString()
            Else
                ' Fehlerbehandlung
                lblServerTime.Text = "Status: " & responseMsg.StatusCode & " Reason: " & responseMsg.ReasonPhrase

            End If

        Catch ex As Exception
            lblServerTime.Text = mko.ExceptionHelper.FlattenExceptionMessages(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Wie btnSendWithPost_Click, nur dass hier mit einem einfacheren Telegramm (Eigenschaften sind nur Strings) gearbeitet wird
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub btnSendSimpleWithPost_Click(sender As Object, e As EventArgs) Handles btnSendSimpleWithPost.Click
        Try

            Dim BaseUri = String.Format(BaseUriPort, tbxPort.Text)

            Dim client As New HttpClient()
            client.BaseAddress = New Uri(BaseUri & "SimpleTelegram")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue(MimeTypeJson))

            Dim tel As New TelegramSimple With {.ID = Guid.NewGuid.ToString(), .Msg = tbxNachricht.Text}

            ' Serialisieren des Telegramms als Json- String mittels der freien Bibliothek Newtonsoft.Json
            ' (siehe NuGet)

            Dim sett As New Newtonsoft.Json.JsonSerializerSettings()
            With sett
                .DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat
                .DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc

            End With

            Dim telAsJsonString = Newtonsoft.Json.JsonConvert.SerializeObject(tel, sett) '.ToString()

            ' Erzeugen de mit dem Http Post Befehls zu übertragenden Datenpaketes
            Dim content As New StringContent(telAsJsonString, System.Text.Encoding.UTF8, MimeTypeJson)

            Dim js = Await content.ReadAsStringAsync()

            ' asynchroner Post- Request
            Dim responseMsg As HttpResponseMessage = client.PostAsync("", content).Result

            If responseMsg.IsSuccessStatusCode Then

                Dim msg = Await responseMsg.Content.ReadAsStringAsync()
                Dim TimeObj = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Ergebnis)(msg)

                lblServerTime.Text = TimeObj.Time.ToLongTimeString()
            Else
                ' Fehlerbehandlung
                lblServerTime.Text = "Status: " & responseMsg.StatusCode & " Reason: " & responseMsg.ReasonPhrase

            End If

        Catch ex As Exception
            lblServerTime.Text = mko.ExceptionHelper.FlattenExceptionMessages(ex)
        End Try



    End Sub
End Class
