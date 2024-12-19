Public Class setNameForm
    Private currentListButton As Button
    Private currentGroceryListMenu As GroceryListMenu
    Public Sub New(newListButton As Button, ListItems As GroceryListMenu)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        currentListButton = newListButton
        currentGroceryListMenu = ListItems
    End Sub
    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Dim allCurrentLists = OurMealsMainForm.GroceryListManagementMenu.getGroceryLists()
        Dim nameAlreadyExits = False
        For Each kvp As KeyValuePair(Of Button, GroceryListMenu) In allCurrentLists
            If (kvp.Key.Text = ShoppingListNameTextBox.Text And Not kvp.Key Is currentListButton) Then
                nameAlreadyExits = True
            End If
        Next
        If (nameAlreadyExits) Then
            MsgBox("Shopping list with that name already exists, must choose a different name")
            Exit Sub
        End If
        If (ShoppingListNameTextBox.Text.Length >= 1 And ShopperNameTextBox.Text.Length >= 1) Then
            currentGroceryListMenu.ShopperNameLabel.Text += ShopperNameTextBox.Text
            currentListButton.Text = ShoppingListNameTextBox.Text
            currentGroceryListMenu.shoppingDateLabel.Text += shoppingDateTextBox.Text
            currentGroceryListMenu.purposeLabel.Text += purposeTextBox.Text
            currentGroceryListMenu.GroceryListNameLabel.Text += currentListButton.Text
            OurMealsMainForm.notificationMsg.ForeColor = Color.Green
            OurMealsMainForm.notificationMsg.Text = ShoppingListNameTextBox.Text + " has been created"
            If (BlankButton.Checked) Then
                OurMealsMainForm.GroceryListManagementMenu.CreateOrdinaryList(currentGroceryListMenu)
                Me.Close()
            ElseIf (RecipeButton.Checked) Then
                If (OurMealsMainForm.InventoryMenu.getTotalRecipesCreated() = 0) Then
                    MsgBox("No recipes to create list out of")
                    Exit Sub

                Else
                    Dim recipeSelection As New recipeSelectionForm(Me)
                    recipeSelection.ShowDialog()
                End If
            ElseIf (RoutineButton.Checked) Then
                OurMealsMainForm.GroceryListManagementMenu.CreateOrdinaryList(currentGroceryListMenu)
                OurMealsMainForm.GroceryListManagementMenu.setMakingRoutineOnCreation(True)
                OurMealsMainForm.GroceryListManagementMenu.GroceryListButton_Click(currentListButton, Nothing)
                Me.Close()
            End If
        End If
    End Sub
    Public Sub populateListWithServings(servings As Integer)
        OurMealsMainForm.GroceryListManagementMenu.CreateOrdinaryList(currentGroceryListMenu)
        OurMealsMainForm.GroceryListManagementMenu.CreateRecipeList(currentListButton, servings)
        Me.Close()
    End Sub


    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class