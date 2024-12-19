Public Class MainMenu
    Private Sub BackToFrontPageButton_Click(sender As Object, e As EventArgs) Handles BackToFrontPageButton.Click
        Me.Visible = False
        OurMealsMainForm.FrontPage.Visible = True
    End Sub

    Private Sub ViewShoppingListsButton_Click(sender As Object, e As EventArgs) Handles ViewShoppingListsButton.Click
        Me.Visible = False
        OurMealsMainForm.GroceryListManagementMenu.Visible = True
        OurMealsMainForm.NotificationBar.Visible = True
    End Sub

    Private Sub FridgeInventoryButton_Click(sender As Object, e As EventArgs) Handles FridgeInventoryButton.Click
        Me.Visible = False
        OurMealsMainForm.InventoryMenu.Visible = True
    End Sub

    Private Sub ViewSuppliesButton_Click(sender As Object, e As EventArgs) Handles ViewSuppliesButton.Click
        Me.Visible = False
        OurMealsMainForm.SalesMenu_.Visible = True
    End Sub

    Private Sub ViewRecipesButton_Click(sender As Object, e As EventArgs) Handles ViewRecipesButton.Click
        Me.Visible = False
        OurMealsMainForm.RecipeMenu.Visible = True
    End Sub
End Class
