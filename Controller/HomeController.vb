Imports System.Web.Mvc
Imports VBHelloApp.Models

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        Function Index() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Function Index(p As Person) As ActionResult
            ViewBag.Name = p.Name
            Return View()
        End Function
    End Class
End Namespace
