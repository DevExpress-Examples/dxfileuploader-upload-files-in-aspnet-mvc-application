Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports Upload.Helpers

Namespace Upload.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function

		<HttpPost> _
		Public Function Submit() As ActionResult
			SaveFilesHelper.Save(Me.HttpContext)
			Return View("Index")
		End Function

		Public Function FileUpload() As ActionResult
			SaveFilesHelper.Save(Me.HttpContext)
			Return Nothing
		End Function
	End Class
End Namespace