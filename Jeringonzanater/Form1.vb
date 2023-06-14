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
    '''     Handle the check button for Module 1,
    '''     Jeringonzanate/Unjeringonzanate.
    ''' </summary>
    ''' <param name="sender">Sender object (unused)</param>
    ''' <param name="e">Event arguments (unused)</param>
    ''' <handles>
    '''     btnMod1Check.Click
    ''' </handles>
    Private Sub btnMod1CheckClick(sender As Object, e As EventArgs) Handles btnMod1Check.Click
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

    Private Sub btnMod2CheckClick(sender As Object, e As EventArgs) Handles btnMod2Check.Click

    End Sub
End Class
