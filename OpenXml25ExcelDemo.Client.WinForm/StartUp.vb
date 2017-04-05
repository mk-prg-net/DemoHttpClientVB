Imports System.Web.Http
Imports Owin

Public Class StartUp

    Public Sub Configuration(app As IAppBuilder)

        ' Configure Web API for self-host. 
        Dim config = New HttpConfiguration()
        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )

        'UseWebApi ist Bestandteil vom Packge Microsoft WebApi 2.2 Owin
        app.UseWebApi(config)

    End Sub

End Class
