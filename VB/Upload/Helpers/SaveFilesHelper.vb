Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace Upload.Helpers
    Public Class SaveFilesHelper
        Public Shared Sub Save(ByVal context As HttpContextBase)
            Try
                Dim files As HttpFileCollectionBase = context.Request.Files
                Dim request As HttpRequestBase = context.Request
                If files.Count <> 0 Then
                    For i As Integer = 0 To files.Count - 1
                        Dim file As HttpPostedFileBase = files(i)
                        If file.ContentLength <> 0 Then
                            Dim fileName As String = String.Empty
                            If request.Browser.Browser.Contains("InternetExplorer") Then
                                fileName = System.IO.Path.GetFileName(file.FileName)
                            Else
                                fileName = file.FileName
                            End If
                            Dim path As String = context.Server.MapPath("~/Images/") & fileName
                            file.SaveAs(path)
                        End If
                    Next i
                End If
            Catch ex As Exception
                context.Response.Write(ex.Message)
            End Try
        End Sub
    End Class
End Namespace