Option Strict On

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim d As Decimal = 9
        Dim s As String = d.ToString

        ltHello.Text = "Hello, this is a test webSITE, not a web application"
    End Sub

End Class
