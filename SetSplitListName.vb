Public Class SetSplitListName
    Private currentListButton As Button
    Private currentGroceryListMenu As GroceryListMenu
    Public Sub New(newListButton As Button, ListItems As GroceryListMenu)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        currentListButton = newListButton
        currentGroceryListMenu = ListItems
    End Sub
    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim allCurrentLists = OurMealsMainForm.GroceryListManagementMenu.getGroceryLists()
        Dim nameAlreadyExits = False
        Debug.Print(allCurrentLists.count)
        For Each kvp As KeyValuePair(Of Button, GroceryListMenu) In allCurrentLists
            If (kvp.Key.Text = ShoppingListNameTextBox.Text) Then
                nameAlreadyExits = True
                Exit For
            End If
        Next
        If (nameAlreadyExits) Then
            MsgBox("Shopping list with that name already exists, must choose a different name")
            Exit Sub
        End If
        If (ShopperNameTextBox.Text.Length >= 1 And ShoppingListNameTextBox.Text.Length >= 1) Then
            currentGroceryListMenu.ShopperNameLabel.Text = currentGroceryListMenu.ShopperNameLabel.Text + ShopperNameTextBox.Text
            currentListButton.Text = ShoppingListNameTextBox.Text
            currentGroceryListMenu.GroceryListNameLabel.Text = currentGroceryListMenu.GroceryListNameLabel.Text + currentListButton.Text
            currentGroceryListMenu.shoppingDateLabel.Text += shoppingDateTextBox.Text
            currentGroceryListMenu.purposeLabel.Text += purposeTextBox.Text
            OurMealsMainForm.notificationMsg.ForeColor = Color.Green
            OurMealsMainForm.notificationMsg.Text = ShoppingListNameTextBox.Text + " has been created"
            Me.Close()
        End If
    End Sub
End Class