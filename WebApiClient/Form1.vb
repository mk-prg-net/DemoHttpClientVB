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

    Private Async Sub btnSenden_Click(sender As Object, e As EventArgs) Handles btnSenden.Click

        Dim BaseUri = String.Format(BaseUriPort, tbxPort.Text)

        Dim client As New HttpClient()
        client.BaseAddress = New Uri(BaseUri & WebApiControllerName)

        Dim tel As New Telegram With {.ID = Guid.NewGuid, .Posted = Now, .Msg = tbxNachricht.Text}

        Dim responseMsg As HttpResponseMessage = client.GetAsync("?" & ToQueryString(tel)).Result

        Dim msg = Await responseMsg.Content.ReadAsStringAsync()

        Dim TimeObj = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Ergebnis)(msg)

        lblServerTime.Text = TimeObj.Time.ToLongTimeString()


    End Sub

    ''' <summary>
    ''' Senden des Telegramms als Http Post im Http Payload
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub btnSendWithPost_Click(sender As Object, e As EventArgs) Handles btnSendWithPost.Click

        Dim BaseUri = String.Format(BaseUriPort, tbxPort.Text)

        Dim client As New HttpClient()
        client.BaseAddress = New Uri(BaseUri & WebApiControllerName)

        Dim tel As New Telegram With {.ID = Guid.NewGuid, .Posted = Now, .Msg = tbxNachricht.Text}

        ' Serialisieren des Telegramms als Json- String mittels der freien Bibliothek Newtonsoft.Json
        ' (siehe NuGet)
        Dim telAsJsonString As String = Newtonsoft.Json.JsonConvert.SerializeObject(tel).ToString()

        ' Erzeugen de mit dem Http Post Befehls zu übertragenden Datenpaketes
        Dim content As New StringContent(
            telAsJsonString,
            System.Text.Encoding.UTF8,
            "application/json")

        ' asynchroner Post- Request
        Dim responseMsg As HttpResponseMessage = client.PostAsync("TimeWebApi", content).Result

        If responseMsg.IsSuccessStatusCode Then

            Dim msg = Await responseMsg.Content.ReadAsStringAsync()
            Dim TimeObj = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Ergebnis)(msg)

            lblServerTime.Text = TimeObj.Time.ToLongTimeString()
        Else
            ' Fehlerbehandlung
            lblServerTime.Text = "Status: " & responseMsg.StatusCode & " Reason: " & responseMsg.ReasonPhrase

        End If

    End Sub
End Class
