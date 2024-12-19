Imports System.Text.RegularExpressions

Public Class recipeSelectionForm
    Private currentAddToForm
    Public Sub New(ATGLF As AddToGroceryListForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        currentAddToForm = ATGLF
    End Sub

    Public Sub New(SNF As setNameForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        currentAddToForm = SNF
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        If (Regex.IsMatch(servingsTextBox.Text, "^[1-9][0-9]*$")) Then
            If (servingsTextBox.Text >= 1 And servingsTextBox.Text <= 4) Then
                currentAddToForm.populateListWithServings(servingsTextBox.Text)
                Me.Close()
                Exit Sub
            End If
            MsgBox("Specified servings must be an integer amount between one and four")
        Else
            MsgBox("Specified servings must be an integer amount between one and four")
        End If

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class