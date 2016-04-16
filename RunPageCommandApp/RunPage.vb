Imports System.Net
Imports System.IO
Friend Class RunPage
    Public Shared Function getUrl(URL As String) As String
        Dim myRequest As HttpWebRequest = DirectCast(WebRequest.Create(URL), HttpWebRequest)
        myRequest.Method = "GET"
        Dim myResponse As WebResponse = myRequest.GetResponse()
        Dim sr As New StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8)
        Dim result As String = sr.ReadToEnd()
        sr.Close()
        myResponse.Close()
        Return result
    End Function

End Class
