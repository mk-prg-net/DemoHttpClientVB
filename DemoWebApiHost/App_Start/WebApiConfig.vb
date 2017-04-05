Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        ' Web API configuration and services


        ' Web API configuration And services
        Dim formatters = GlobalConfiguration.Configuration.Formatters
        Dim jsonFormatter = formatters.JsonFormatter
        Dim settings = jsonFormatter.SerializerSettings

        'jsonFormatter.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None
        config.Formatters.Remove(config.Formatters.XmlFormatter)
        'settings.Formatting = Formatting.Indented
        'settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        settings.DateFormatHandling = DateFormatHandling.IsoDateFormat
        settings.DateTimeZoneHandling = DateTimeZoneHandling.Utc
        'config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore

        ' Web API routes
        config.MapHttpAttributeRoutes()

        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )
    End Sub
End Module
