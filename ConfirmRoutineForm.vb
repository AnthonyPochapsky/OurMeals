Public Class ConfirmRoutineForm
    Private ButtonToBeMarkedRoutine As Button
    Public Sub New(B As Button)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ButtonToBeMarkedRoutine = B
        NameOfListLabel.Text = ButtonToBeMarkedRoutine.Text
    End Sub
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        OurMealsMainForm.GroceryListManagementMenu.MakeRoutine(ButtonToBeMarkedRoutine)
        Me.Close()
    End Sub
    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub
End Class