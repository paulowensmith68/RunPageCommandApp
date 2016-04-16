Module Module1

    Sub Main(arg As String())

        If arg.Length < 1 Or arg.Length > 1 Then
            Console.WriteLine("Arguments Missing")
            Console.WriteLine("Arguments Are: UrlToRun")
            Return
        End If

        Dim webUrl As String = arg(0).ToString

        Dim loadpage As New RunPage

        Try
            Console.WriteLine(loadpage.getUrl(webUrl))
        Catch e As Exception
            Console.WriteLine("-- ERROR --")
            Console.WriteLine(e.Message)
            Exit Try
        End Try

    End Sub

End Module
