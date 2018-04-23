Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace Upload
    Public Class RouteConfig
        Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
            routes.MapRoute("Default", "{controller}/{action}/{id}", New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional})
        End Sub
    End Class
End Namespace
