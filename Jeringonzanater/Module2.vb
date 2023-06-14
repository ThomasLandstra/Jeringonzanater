Module Module2
    ' Array of strings containing english words with "apa" or "Apa" in them
    Dim strApaWords As String() = My.Resources.apa_words.Split(vbLf)

    ''' <summary>
    '''     A subroutine to check wether or not a word has been Jeringonzanated
    ''' </summary>
    ''' <param name="strInput" type="string">User word input</param>
    Public Sub checkJering(strInput As String)

        ' Does the word contain "apa" or "Apa"?
        If InStr(strInput, "apa") Or InStr(strInput, "Apa") Then
            ' The word contains "apa" or "Apa"

            ' Loop through every english word which contains "apa"/"Apa"
            For Each strWord In strApaWords
                ' if the input word is an english word already containing apa

                If strInput = strWord Then

                    ' Display result and exit sub
                    MsgBox("Word is not Jeringonzanated")
                    Exit Sub
                End If
            Next

            ' The word is not an english word containing apa
            ' Therefore it is Jeringonzanated
            MsgBox("Word is Jeringonzanated")
        Else
            ' Word does not contain apa or "Apa"
            MsgBox("Word is not Jeringonzanated")
        End If
    End Sub
End Module
