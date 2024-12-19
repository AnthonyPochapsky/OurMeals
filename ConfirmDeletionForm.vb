Public Class ConfirmDeletionForm
    Private ButtonToBeDeleted As Button
    Public Sub New(B As Button)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ButtonToBeDeleted = B
        NameOfListLabel.Text = ButtonToBeDeleted.Text
    End Sub
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        OurMealsMainForm.GroceryListManagementMenu.DeleteList(ButtonToBeDeleted)
        Me.Close()
    End Sub
    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub
End Class