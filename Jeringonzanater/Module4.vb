Module Module4
    ''' <summary>
    '''     A function to Jeringozanate words in a valid sentence
    '''     if the word doesn't already contain "apa" or "Apa"
    ''' </summary>
    ''' <param name="strInputSentence" type="string">
    '''     The sentence  to be Jeringozanated if valid
    ''' </param>
    ''' <returns type="string">
    '''     A string representing the sentence after Jeringozanation
    '''     if the sentence was valid/if any modifications are made.
    '''     If the sentence was not valid and no modifications are made
    '''     then the original sentence is returned.
    ''' </returns>
    Public Function jeringonzanate(strInputSentence As String) As String
        ' Ensure that the sentence is a valid candidate for jeringonzanation
        If Not verifyCandidacy(strInputSentence) Then
            Return strInputSentence ' Return original sentence
        End If

        ' Split the sentence into Words
        Dim strSentenceWords As String() = strInputSentence.Split(" ")

        ' Loop through each word using an index instead of a "For Each" loop
        For i As UInt16 = 0 To strSentenceWords.Length - 1
            Dim strWord = strSentenceWords(i)

            ' Check that the word contains "a" or "A"
            ' then ensure "apa" or "Apa" isn't already in the word
            If strWord.Contains("a") Or strWord.Contains("A") Then
                If (InStr(strWord, "apa") = 0) And (InStr(strWord, "Apa") = 0) Then
                    ' Replace lower case "a" with "apa" FIRST to avoid double replacement
                    strWord = strWord.Replace("a", "apa")
                    ' Replace upper case "A" with "Apa"
                    strWord = strWord.Replace("A", "Apa")

                    ' Replace the word in the list with the new converted word
                    strSentenceWords(i) = strWord
                End If
            End If
        Next

        ' Create the return sentence
        Dim strConvertedSentence As String = ""

        ' Add each word to the sentence
        For Each strWord In strSentenceWords
            strConvertedSentence &= strWord & " "
        Next

        ' Remove trailing space
        strConvertedSentence = strConvertedSentence.Substring(0, strConvertedSentence.Length - 1)

        Return strConvertedSentence ' Return converted sentence
    End Function
End Module
