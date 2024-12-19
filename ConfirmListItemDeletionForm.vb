Public Class ConfirmListItemDeletionForm
    Private ItemToBeDeleted As RichTextBox
    Private GroceryList As GroceryListMenu
    Public Sub New(I As RichTextBox, GL As GroceryListMenu)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ItemToBeDeleted = I
        NameOfItem.Text = I.Text
        GroceryList = GL

    End Sub
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        GroceryList.PrepareDeletion(ItemToBeDeleted)
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub
End Class