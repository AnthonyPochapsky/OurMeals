Public Class EditListForm
    Private listButtonToEdit As Button
    Private listMenuToEdit As GroceryListMenu
    Public Sub New(LBTE As Button, LMTE As GroceryListMenu)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        listButtonToEdit = LBTE
        listMenuToEdit = LMTE
    End Sub
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If Not ShoppingListNameTextBox.Text = "" Then
            listButtonToEdit.Text = ShoppingListNameTextBox.Text
            listMenuToEdit.GroceryListNameLabel.Text = "Shopping List Name/store: " + ShoppingListNameTextBox.Text
        End If

        If Not ShopperNameTextBox.Text = "" Then
            listMenuToEdit.ShopperNameLabel.Text = "Name of Assigned Shopper: " + ShopperNameTextBox.Text
        End If

        If Not shoppingDateTextBox.Text = "" Then
            listMenuToEdit.shoppingDateLabel.Text = "Shopping date/frequency: " + shoppingDateTextBox.Text
        End If

        If Not purposeTextBox.Text = "" Then
            listMenuToEdit.purposeLabel.Text = "Purpose: " + purposeTextBox.Text
        End If
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class