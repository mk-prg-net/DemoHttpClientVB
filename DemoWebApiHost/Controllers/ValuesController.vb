Imports System.Net
Imports System.Web.Http

Public Class ValuesController
    Inherits ApiController

    ' GET api/values
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/values/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function

    ' POST api/values
    Public Function PostValue(<FromBody()> ByVal value As String) As Date
        Try
            ' Um den Anwendungszustand konurrieren die User- Zugriff muss serialisiert werden
            HttpContext.Current.Application.Lock()

            If HttpContext.Current.Application("Log") Is Nothing Then
                HttpContext.Current.Application("Log") = New List(Of Telegram)
            End If

            Dim Log As List(Of Telegram) = CType(HttpContext.Current.Application("Log"), List(Of Telegram))
            Log.Add(New Telegram() With {.ID = Guid.NewGuid, .Posted = Now, .Msg = value})

        Finally
            HttpContext.Current.Application.UnLock()
        End Try

        Return Now

    End Function

    ' PUT api/values/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
