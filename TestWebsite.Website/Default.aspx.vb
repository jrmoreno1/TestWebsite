Option Strict Off
Imports System.Data

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim d As Decimal = 9
        Dim s As String = d

        ltHello.Text = "Hello, this is a test webSITE, not a web application"
    End Sub

    ''' <remarks>
    ''' my VSIX for missing as clause gives warning in this website
    ''' </remarks>
    Public Function WebSiteMissingAs()
        Return 3
    End Function

    ''' <remarks>
    ''' Codefix provider works in this website 
    ''' </remarks>
    Public Sub TestDr()
        Dim dr As IDataReader = Nothing
        Dim s As String = dr("test")
    End Sub

End Class
