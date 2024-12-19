Public Class InventoryMenu
    Private items As New List(Of InventorySupply)
    Private selectedItems As New List(Of InventorySupply)
    Private CanSelect As Boolean = True
    Private OldCursorLocation As Point
    Private canBeDeleted As Boolean = False
    Private totalRecipesCreated As Integer = 0
    Private FoodTypesCurrentlyContained = New Boolean() {True, True, False}
    Private FoodTypesCurrentlySelected = New Boolean() {False, False, False}
    Public Sub Initial_first_two_items()
        InventorySupply1.SupplyImage.ImageLocation = "foods/apple.png"
        InventorySupply1.NameLabel.Text = "apple"
        InventorySupply1.QuantityLabel.Text = 1
        InventorySupply1.CategoryLabel.Text = "fruit"

        InventorySupply2.SupplyImage.ImageLocation = "foods/tomato.png"
        InventorySupply2.NameLabel.Text = "tomato"
        InventorySupply2.QuantityLabel.Text = 1
        InventorySupply2.CategoryLabel.Text = "fruit"

        items.Add(InventorySupply1)
        items.Add(InventorySupply2)
    End Sub
    Private Sub BackToMainMenuButton_Click(sender As Object, e As EventArgs) Handles BackToMainMenuButton.Click
        For Each item As InventorySupply In selectedItems
            item.BorderStyle = BorderStyle.None
        Next
        selectedItems.Clear()
        For i = 0 To FoodTypesCurrentlySelected.length - 1
            FoodTypesCurrentlySelected(i) = False
        Next
        Me.Visible = False
        OurMealsMainForm.MainMenu.Visible = True
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        For Each item As InventorySupply In selectedItems
            item.BorderStyle = BorderStyle.None
        Next
        selectedItems.Clear()

        EditButton.Enabled = False
        CreateRecipesButton.Enabled = False
        FindSalesButton.Enabled = False
        StopEditButton.Enabled = True
        AddButton.Enabled = True
        ModifyButton.Enabled = True
        DeleteButton.Enabled = True
        CanSelect = False

    End Sub

    Private Sub StopEditButton_Click(sender As Object, e As EventArgs) Handles StopEditButton.Click
        EditButton.Enabled = True
        CreateRecipesButton.Enabled = True
        FindSalesButton.Enabled = True
        StopEditButton.Enabled = False
        AddButton.Enabled = False
        ModifyButton.Enabled = False
        DeleteButton.Enabled = False
        StopDeleteButton.Enabled = False
        canBeDeleted = False

        CanSelect = True
        For Each item As InventorySupply In items
            item.Cursor = Cursors.Default
        Next
    End Sub

    Private Sub Item_Click(sender As Object, e As EventArgs) Handles InventorySupply1.Click, InventorySupply2.Click
        Dim ClickedItem As InventorySupply = sender
        If CanSelect And Not selectedItems.Contains(ClickedItem) Then
            ClickedItem.BorderStyle = BorderStyle.FixedSingle
            selectedItems.Add(ClickedItem)
            If ClickedItem.SupplyImage.ImageLocation = "foods/apple.png" Then
                FoodTypesCurrentlySelected(0) = True
            ElseIf ClickedItem.SupplyImage.ImageLocation = "foods/tomato.png" Then
                FoodTypesCurrentlySelected(1) = True
            ElseIf ClickedItem.SupplyImage.ImageLocation = "foods/leek.png" Then
                FoodTypesCurrentlySelected(2) = True
            End If
        ElseIf CanSelect And selectedItems.Contains(ClickedItem) Then
            ClickedItem.BorderStyle = BorderStyle.None
            selectedItems.Remove(ClickedItem)
            If ClickedItem.SupplyImage.ImageLocation = "foods/apple.png" Then
                FoodTypesCurrentlySelected(0) = False
            ElseIf ClickedItem.SupplyImage.ImageLocation = "foods/tomato.png" Then
                FoodTypesCurrentlySelected(1) = False
            ElseIf ClickedItem.SupplyImage.ImageLocation = "foods/leek.png" Then
                FoodTypesCurrentlySelected(2) = False
            End If
        ElseIf canBeDeleted Then
            Dim ConfirmInventoryItemDeletionForm = New ConfirmInventoryItemDeletionForm(ClickedItem)
            ConfirmInventoryItemDeletionForm.ShowDialog()
        End If
    End Sub

    Public Sub CompleteSupplyDeletion(ClickedItem As InventorySupply)
        items.Remove(ClickedItem)
        Controls.Remove(ClickedItem)
        If ClickedItem.SupplyImage.ImageLocation = "foods/apple.png" Then
            FoodTypesCurrentlyContained(0) = False
            OurMealsMainForm.SalesMenu_.QuantityLabel1.Text = 0
            OurMealsMainForm.SalesMenu_.QuantityLabel2.Text = 0
        ElseIf ClickedItem.SupplyImage.ImageLocation = "foods/tomato.png" Then
            FoodTypesCurrentlyContained(1) = False
            OurMealsMainForm.SalesMenu_.QuantityLabel3.Text = 0
        ElseIf ClickedItem.SupplyImage.ImageLocation = "foods/leek.png" Then
            FoodTypesCurrentlyContained(2) = False
            OurMealsMainForm.SalesMenu_.QuantityLabel4.Text = 0
        End If
    End Sub
    Public Sub incrementTotalApples()
        For Each Item As InventorySupply In items
            If Item.SupplyImage.ImageLocation = "foods/apple.png" Then
                Item.QuantityLabel.Text += 1
                OurMealsMainForm.SalesMenu_.QuantityLabel1.Text = Item.QuantityLabel.Text
                OurMealsMainForm.SalesMenu_.QuantityLabel2.Text = Item.QuantityLabel.Text
                Exit For
            End If
        Next
    End Sub

    Public Sub incrementTotalTomatoes()
        For Each Item As InventorySupply In items
            If Item.SupplyImage.ImageLocation = "foods/tomato.png" Then
                Item.QuantityLabel.Text += 1
                OurMealsMainForm.SalesMenu_.QuantityLabel3.Text = Item.QuantityLabel.Text
                Exit For
            End If
        Next
    End Sub
    Public Sub incrementTotalLeeks()
        For Each Item As InventorySupply In items
            If Item.SupplyImage.ImageLocation = "foods/leek.png" Then
                Item.QuantityLabel.Text += 1
                OurMealsMainForm.SalesMenu_.QuantityLabel4.Text = Item.QuantityLabel.Text
                Exit For
            End If
        Next
    End Sub
    Private Sub Item_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles InventorySupply1.MouseDown, InventorySupply2.MouseDown
        sender.Capture = True
        sender.BringToFront
        OldCursorLocation = e.Location
    End Sub

    Private Sub Item_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles InventorySupply1.MouseMove, InventorySupply2.MouseMove
        If sender.Capture And StopEditButton.Enabled Then
            Cursor = Cursors.Hand
            sender.Location = sender.Location + e.Location - OldCursorLocation
        End If
    End Sub

    Private Sub Item_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles InventorySupply1.MouseUp, InventorySupply2.MouseUp
        sender.Capture = False
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        DeleteButton.Enabled = False
        StopDeleteButton.Enabled = True
        canBeDeleted = True
    End Sub

    Private Sub StopDeleteButton_Click(sender As Object, e As EventArgs) Handles StopDeleteButton.Click
        DeleteButton.Enabled = True
        StopEditButton.Enabled = True
        StopDeleteButton.Enabled = False
        canBeDeleted = False
    End Sub

    Private Sub FindSalesButton_Click(sender As Object, e As EventArgs) Handles FindSalesButton.Click
        If selectedItems.Count = 0 Then
            MsgBox("Must select atleast one item")
        Else
            Visible = False
            OurMealsMainForm.SalesMenu_.Visible = True
            If (FoodTypesCurrentlySelected(0)) Then
                OurMealsMainForm.SalesMenu_.AppleSaleImage1.Visible = True
                OurMealsMainForm.SalesMenu_.AppleSaleImage2.Visible = True
                OurMealsMainForm.SalesMenu_.WholeFoodsLabel.Visible = True
                OurMealsMainForm.SalesMenu_.NoFrillsLabel.Visible = True
                OurMealsMainForm.SalesMenu_.OriginalPriceLabel1.Visible = True
                OurMealsMainForm.SalesMenu_.OriginalPriceLabel2.Visible = True
                OurMealsMainForm.SalesMenu_.HouseholdQuantityLabel1.Visible = True
                OurMealsMainForm.SalesMenu_.HouseholdQuantityLabel2.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel1.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel1.BringToFront()
                OurMealsMainForm.SalesMenu_.QuantityLabel2.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel2.BringToFront()
                OurMealsMainForm.SalesMenu_.PriceLabel1.Visible = True
                OurMealsMainForm.SalesMenu_.PriceLabel3.Visible = True
                OurMealsMainForm.SalesMenu_.SaleLabel1.Visible = True
                OurMealsMainForm.SalesMenu_.SaleLabel3.Visible = True
            End If
            If (FoodTypesCurrentlySelected(1)) Then
                OurMealsMainForm.SalesMenu_.TomatoSaleImage1.Visible = True
                OurMealsMainForm.SalesMenu_.FarmBoyLabel.Visible = True
                OurMealsMainForm.SalesMenu_.OriginalPriceLabel3.Visible = True
                OurMealsMainForm.SalesMenu_.HouseholdQuantityLabel3.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel3.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel3.BringToFront()
                OurMealsMainForm.SalesMenu_.PriceLabel2.Visible = True
                OurMealsMainForm.SalesMenu_.SaleLabel2.Visible = True
            End If
            If (FoodTypesCurrentlySelected(2)) Then
                OurMealsMainForm.SalesMenu_.LeekSaleImage.Visible = True
                OurMealsMainForm.SalesMenu_.FarmBoyLabel2.Visible = True
                OurMealsMainForm.SalesMenu_.PriceLabel4.Visible = True
                OurMealsMainForm.SalesMenu_.SaleLabel4.Visible = True
                OurMealsMainForm.SalesMenu_.OriginalPriceLabel4.Visible = True
                OurMealsMainForm.SalesMenu_.HouseHoldQuantityLabel4.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel4.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel4.BringToFront()
                OurMealsMainForm.SalesMenu_.QuantityLabel4.Visible = True
            End If
        End If
        For Each item In selectedItems
            item.BorderStyle = BorderStyle.None
        Next
        For i = 0 To FoodTypesCurrentlySelected.length - 1
            FoodTypesCurrentlySelected(i) = False
        Next
        selectedItems.Clear()
    End Sub
    Private Sub FindMissingItemSalesButton_Click(sender As Object, e As EventArgs) Handles FindMissingItemSalesButton.Click
        If (FoodTypesCurrentlyContained(0) And FoodTypesCurrentlyContained(1) And FoodTypesCurrentlyContained(2)) Then
            MsgBox("The refrigerator is not missing any items")
        Else
            For Each item In selectedItems
                item.BorderStyle = BorderStyle.None
            Next
            selectedItems.Clear()
            Visible = False
            OurMealsMainForm.SalesMenu_.Visible = True
            If (Not FoodTypesCurrentlyContained(0)) Then
                OurMealsMainForm.SalesMenu_.AppleSaleImage1.Visible = True
                OurMealsMainForm.SalesMenu_.AppleSaleImage2.Visible = True
                OurMealsMainForm.SalesMenu_.WholeFoodsLabel.Visible = True
                OurMealsMainForm.SalesMenu_.NoFrillsLabel.Visible = True
                OurMealsMainForm.SalesMenu_.OriginalPriceLabel1.Visible = True
                OurMealsMainForm.SalesMenu_.OriginalPriceLabel2.Visible = True
                OurMealsMainForm.SalesMenu_.HouseholdQuantityLabel1.Visible = True
                OurMealsMainForm.SalesMenu_.HouseholdQuantityLabel2.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel1.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel1.BringToFront()
                OurMealsMainForm.SalesMenu_.QuantityLabel2.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel2.BringToFront()
                OurMealsMainForm.SalesMenu_.PriceLabel1.Visible = True
                OurMealsMainForm.SalesMenu_.PriceLabel3.Visible = True
                OurMealsMainForm.SalesMenu_.SaleLabel1.Visible = True
                OurMealsMainForm.SalesMenu_.SaleLabel3.Visible = True
            End If
            If (Not FoodTypesCurrentlyContained(1)) Then
                OurMealsMainForm.SalesMenu_.TomatoSaleImage1.Visible = True
                OurMealsMainForm.SalesMenu_.FarmBoyLabel.Visible = True
                OurMealsMainForm.SalesMenu_.OriginalPriceLabel3.Visible = True
                OurMealsMainForm.SalesMenu_.HouseholdQuantityLabel3.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel3.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel3.BringToFront()
                OurMealsMainForm.SalesMenu_.PriceLabel2.Visible = True
                OurMealsMainForm.SalesMenu_.SaleLabel2.Visible = True
            End If
            If (Not FoodTypesCurrentlyContained(2)) Then
                OurMealsMainForm.SalesMenu_.LeekSaleImage.Visible = True
                OurMealsMainForm.SalesMenu_.FarmBoyLabel2.Visible = True
                OurMealsMainForm.SalesMenu_.PriceLabel4.Visible = True
                OurMealsMainForm.SalesMenu_.SaleLabel4.Visible = True
                OurMealsMainForm.SalesMenu_.OriginalPriceLabel4.Visible = True
                OurMealsMainForm.SalesMenu_.HouseHoldQuantityLabel4.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel4.Visible = True
                OurMealsMainForm.SalesMenu_.QuantityLabel4.BringToFront()
            End If
        End If




    End Sub
    Private Sub CreateRecipesButton_Click(sender As Object, e As EventArgs) Handles CreateRecipesButton.Click
        If (Not FoodTypesCurrentlySelected(0) = False Or Not FoodTypesCurrentlySelected(1) = False Or Not FoodTypesCurrentlySelected(2) = False) Then
            If selectedItems.Count = 2 Then
                For Each Item As InventorySupply In selectedItems
                    If Item.SupplyImage.ImageLocation = "foods/apple.png" And Item.QuantityLabel.Text < 2 Then
                        MsgBox("Cannot produce recipe from selected items")
                        Exit Sub
                    ElseIf Item.SupplyImage.ImageLocation = "foods/tomato.png" And Item.QuantityLabel.Text < 2 Then
                        MsgBox("Cannot produce recipe from selected items")
                        Exit Sub
                    ElseIf Item.SupplyImage.ImageLocation = "foods/leek.png" Then
                        MsgBox("Cannot produce recipe from selected items")
                        Exit Sub
                    End If
                Next

                totalRecipesCreated += 1
                For Each item As InventorySupply In selectedItems
                    item.BorderStyle = BorderStyle.None
                Next
                For i = 0 To FoodTypesCurrentlySelected.length - 1
                    FoodTypesCurrentlySelected(i) = False
                Next
                selectedItems.Clear()
                Me.Visible = False
                OurMealsMainForm.RecipeMenu.Visible = True
                OurMealsMainForm.RecipeMenu.RecipeName.Visible = True
                OurMealsMainForm.RecipeMenu.ingrediantHeading.Visible = True
                OurMealsMainForm.RecipeMenu.recipeIngredients.Visible = True
                OurMealsMainForm.RecipeMenu.InstructionHeader.Visible = True
                OurMealsMainForm.RecipeMenu.firstTwoInstructions.Visible = True
            Else
                MsgBox("Cannot produce recipe from selected items")
            End If

        Else
            MsgBox("Must select at least one item before any recipe can be recommended")
        End If
    End Sub
    Public Function getTotalRecipesCreated()
        Return totalRecipesCreated
    End Function
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim addItemForm As New AddNewInventoryItemForm
        addItemForm.ShowDialog
    End Sub

    Public Function getItems()
        Return items
    End Function
    Public Function getFoodTypesCurrentlyContained()
        Return FoodTypesCurrentlyContained
    End Function
    Public Sub addNewItem(itemToAdd As InventorySupply)
        items.Add(itemToAdd)
        MyBase.Controls.Add(itemToAdd)
        itemToAdd.BringToFront()
        AddHandler itemToAdd.Click, AddressOf Me.Item_Click
        AddHandler itemToAdd.MouseDown, AddressOf Me.Item_MouseDown
        AddHandler itemToAdd.MouseMove, AddressOf Me.Item_MouseMove
        AddHandler itemToAdd.MouseUp, AddressOf Me.Item_MouseUp
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim ModifyInventorySupplyForm = New ModifyInventorySupplyForm
        ModifyInventorySupplyForm.ShowDialog()
    End Sub
End Class
