Public Class AddToGroceryListForm
    Private ListToPopulate As GroceryListMenu
    Public Sub New(currentList As GroceryListMenu)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ListToPopulate = currentList

    End Sub
    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        If (BlankButton.Checked) Then
            ListToPopulate.AddNewBlankItem()
            Me.Close()
        ElseIf (FridgeInventoryButton.Checked) Then
            Dim inventoryItemsToBeAdded = OurMealsMainForm.InventoryMenu.getItems()
            For Each item As InventorySupply In inventoryItemsToBeAdded
                For i = 0 To item.QuantityLabel.Text - 1
                    Dim ListItem1 = New RichTextBox
                    ListItem1.Size = New Point(222, 60)
                    ListItem1.Location = New Point(27, 102)
                    ListItem1.ReadOnly = False
                    ListItem1.Enabled = True
                    If (item.SupplyImage.ImageLocation = "foods/apple.png") Then
                        ListItem1.Text = "Apple"
                    ElseIf (item.SupplyImage.ImageLocation = "foods/tomato.png") Then
                        ListItem1.Text = "Tomato"
                    ElseIf (item.SupplyImage.ImageLocation = "foods/leek.png") Then
                        ListItem1.Text = "Leek"
                    End If
                    ListToPopulate.ModifyListWithExternalItems(ListItem1, True)
                Next
            Next
            Me.Close()
        ElseIf (DifferentListButton.Checked) Then
            Dim AllExistingLists = OurMealsMainForm.GroceryListManagementMenu.getGroceryLists()
            If (AllExistingLists.Count() = 1) Then
                MsgBox("No other shopping list exists")
                Exit Sub
            Else
                Dim EnterShoppingListNameForm = New EnterShoppingListNameForm(ListToPopulate, AllExistingLists)
                EnterShoppingListNameForm.ShowDialog()
                Me.Close()
            End If
        ElseIf (RecipeButton.Checked) Then
            If (OurMealsMainForm.InventoryMenu.getTotalRecipesCreated() = 0) Then
                MsgBox("No recipes exist to populate this list with ingredients")
                Exit Sub
            End If
            Dim recipeSelection As New recipeSelectionForm(Me)
            recipeSelection.ShowDialog()
        End If


    End Sub
    Public Sub populateListWithServings(servings As Integer)
        For Each kvp As KeyValuePair(Of Button, GroceryListMenu) In OurMealsMainForm.GroceryListManagementMenu.getGroceryLists()
            If (kvp.Value Is ListToPopulate) Then
                OurMealsMainForm.GroceryListManagementMenu.AddIngredientsToExistingList(kvp.Key, servings)
                Exit For
            End If
        Next
        Me.Close()
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class