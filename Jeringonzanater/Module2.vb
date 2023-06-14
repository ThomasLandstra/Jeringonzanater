Module Module2
    Dim strApaWords As String() = My.Resources.apa_words.Split(vbLf)

    Public Sub checkJering(strInput As String)
        If (Not InStr(strInput, "apa")) Or (Not InStr(strInput, "Apa")) Then
            MsgBox("Word is Unjeringonzanated")
            Exit Sub
        End If

        For Each strWord In strApaWords
            If strInput = strWord Then
                MsgBox("Word is Unjeringonzanated")
                Exit Sub
            End If
        Next

        MsgBox("Word is Jeringonzanated")
    End Sub
End Module
