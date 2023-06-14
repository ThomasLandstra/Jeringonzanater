Module Module4
    Public Function jeringonzanate(strInputSentence As String) As String
        Dim strSentenceWords As String() = strInputSentence.Split(" ")

        For Each strWord In strSentenceWords
            If strWord.Contains("a") Then
                If InStr(strWord, "apa") Or InStr(strWord, "Apa") Then

                End If
            End If
        Next
    End Function
End Module
