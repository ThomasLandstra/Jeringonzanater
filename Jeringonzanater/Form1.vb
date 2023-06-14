''' <summary>
'''     A program relating to Jeringonza
''' </summary>
''' 
''' Note for Mr. Bonfadini:
''' Code has been modularised into VB Modules,
''' a seperate module of code exists for each tab
''' in the tab control.

Public Class formMain


    ' Module 1

    ''' <summary>
    '''     Handle the "Check" button for Module 1,
    '''     Jeringonzanate/Unjeringonzanate.
    ''' </summary>
    ''' <param name="sender">Sender object (unused)</param>
    ''' <param name="e">Event arguments (unused)</param>
    ''' <handles>
    '''     btnMod1Check.Click
    ''' </handles>
    Private Sub btnMod1ConvertClick(sender As Object, e As EventArgs) Handles btnMod1Convert.Click
        ' Get the input string from the Module 1 input
        Dim strInput = tbxMod1Input.Text

        ' Check whether to Jeringonzanate or Unjeringonzanate
        If rbtnMod1Jeri.Checked Then
            ' Jeringonzanate
            tbxMod1Input.Text = jering(strInput)
        Else
            ' Unjeringonzanate
            tbxMod1Input.Text = unjering(strInput)
        End If
    End Sub


    ' Module 2

    ''' <summary>
    '''     Handle the "Check" button for Module 2,
    '''     Jeringonzanated word checker.
    ''' </summary>
    ''' <param name="sender">Sender object (unused)</param>
    ''' <param name="e">Event arguments (unused)</param>
    ''' <handles>
    '''     btnMod2Check.Click
    ''' </handles>
    Private Sub btnMod2CheckClick(sender As Object, e As EventArgs) Handles btnMod2Check.Click
        ' Check to see if word has been Jeringonzanated
        checkJering(tbxMod2Input.Text)
    End Sub


    'Module 3

    ''' <summary>
    '''     Handle the "Verify" button for Module 3,
    '''     Sentence candidacy checker.
    ''' </summary>
    ''' <param name="sender">Sender object (unused)</param>
    ''' <param name="e">Event arguments (unused)</param>
    ''' <handles>
    '''     btnMod3Verify.Click
    ''' </handles>
    Private Sub btnMod3VerifyClick(sender As Object, e As EventArgs) Handles btnMod3Verify.Click
        ' Is the sentence a valid candidate for Jeringonzanation
        Dim boolValidCandidate = verifyCandidacy(tbxMod3Input.Text)

        ' Display result
        If boolValidCandidate Then
            MsgBox("Sentence is a valid candidate for Jeringonzanation")
        Else
            MsgBox("Sentence is not a valid candidate for Jeringonzanation")
        End If
    End Sub


    ' Module 4

    ''' <summary>
    '''     Handle the "Convert" button for Module 4,
    '''     Smart Jeringonzanater.
    ''' </summary>
    ''' <param name="sender">Sender object (unused)</param>
    ''' <param name="e">Event arguments (unused)</param>
    ''' <handles>
    '''     btnMod4Convert.Click
    ''' </handles>
    Private Sub btnMod4ConvertClick(sender As Object, e As EventArgs) Handles btnMod4Convert.Click
        ' Jeringonzanate the setence (if able)
        tbxMod4Input.Text = jeringonzanate(tbxMod4Input.Text)
    End Sub
End Class
