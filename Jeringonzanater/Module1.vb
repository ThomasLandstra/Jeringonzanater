Module Module1
    ''' <summary>
    '''     A public function which Jeringonzanates
    '''     an input string as defined by strInput
    ''' </summary>
    ''' <param name="strInput" type="string">
    '''     A string inputted by the user to be Jeringonzanated
    ''' </param>
    ''' <returns type="string">
    '''     The Jeringonzanated string
    ''' </returns>
    Public Function jering(strInput As String) As String
        ' Replace lower case "a" with "apa" FIRST to avoid double replacement
        strInput = strInput.Replace("a", "apa")

        ' Replace upper case "A" with "Apa"
        strInput = strInput.Replace("A", "Apa")

        Return strInput
    End Function

    ''' <summary>
    '''     A public function which Unjeringonzanates
    '''     an input string as defined by strInput
    ''' </summary>
    ''' <param name="strInput" type="string">
    '''     A string inputted by the user to be Unjeringonzanated
    ''' </param>
    ''' <returns type="string">
    '''     The Unjeringonzanated string
    ''' </returns>
    Public Function unjering(strInput As String) As String
        ' Replace lower case "apa" with "a"
        strInput = strInput.Replace("apa", "a")

        ' Replace upper case "Apa" with "A"
        strInput = strInput.Replace("Apa", "A")

        Return strInput
    End Function
End Module
