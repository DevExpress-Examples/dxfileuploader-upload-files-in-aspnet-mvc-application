Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace Upload
	Public Class MvcApplication
		Inherits System.Web.HttpApplication
		Protected Sub Application_Start()
			AreaRegistration.RegisterAllAreas()
			RouteConfig.RegisterRoutes(RouteTable.Routes)
		End Sub
	End Class
End Namespace
