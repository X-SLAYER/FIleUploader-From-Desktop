Imports System.Text.RegularExpressions

Public Class FIleInfo

    Private fullLink As String
    Private shortLink As String


    Public Sub SetInfo(ByVal _from As String)
        On Error Resume Next
        Me.fullLink = Regex.Match(_from, """full"":""(.*?)"",").Groups(1).Value
        Me.shortLink = Regex.Match(_from, ",""short"":""(.*?)""},").Groups(1).Value
    End Sub


    Public Sub GetClipboard(ByVal who As String)
        On Error Resume Next
        If who.ToLower() = "short" Then
            Clipboard.SetText(Me.shortLink, TextDataFormat.Text)
        Else
            Clipboard.SetText(Me.fullLink, TextDataFormat.Text)
        End If
    End Sub

End Class
