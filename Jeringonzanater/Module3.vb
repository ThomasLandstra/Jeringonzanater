Module Module3
    ''' <summary>
    '''     A function to checks to see if input sentence has
    '''     between 20% and 80% of words containing an "a" character
    ''' </summary>
    ''' <param name="strInputSentence" type="string">
    '''     The input sentence to be checked
    ''' </param>
    ''' <returns type="bool">
    '''     A boolean representing if the sentence is a valid candidate
    ''' </returns>
    Public Function verifyCandidacy(strInputSentence As String) As Boolean
        ' Convert sentence to lowercase for ease of use
        strInputSentence = strInputSentence.ToLower()
        ' Split the sentence into words
        Dim strSentenceWords As String() = strInputSentence.Split(" ")

        ' Counter for number of word containing an "a"
        Dim ui16Counter As UInt16 = 0

        ' Loop through each word
        For Each strWord In strSentenceWords

            ' If the word contains an "a" then add 1 to counter
            If strWord.Contains("a") Then
                ui16Counter += 1
            End If

        Next

        ' Calculate percentage of words containing an "a" in the sentence
        ' Store as a double due to floating point inaccuracy (see test table)
        Dim snglPercentage As Double = ui16Counter / strSentenceWords.Length

        ' Does sentence has more than 20% and less
        ' than 80% words containing "a"s (inclusive)
        Return (0.2 <= snglPercentage) And (snglPercentage <= 0.8)
    End Function
End Module
