Public Class AddNewInventoryItemForm
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim ExistingItems = OurMealsMainForm.InventoryMenu.getItems()

        Dim newItem As New InventorySupply
        newItem.Location = New Point(46, 137)
        newItem.Visible = True

        If AppleButton.Checked Then
            For Each Item As InventorySupply In ExistingItems
                If Item.SupplyImage.ImageLocation = "foods/apple.png" Then
                    Item.QuantityLabel.Text += 1
                    OurMealsMainForm.SalesMenu_.QuantityLabel1.Text = Item.QuantityLabel.Text
                    OurMealsMainForm.SalesMenu_.QuantityLabel2.Text = Item.QuantityLabel.Text
                    Me.Close()
                    Exit Sub
                End If
            Next
            newItem.SupplyImage.ImageLocation = "foods/apple.png"
            newItem.NameLabel.Text = "apple"
            newItem.QuantityLabel.Text = 1
            newItem.CategoryLabel.Text = "fruit"
            OurMealsMainForm.SalesMenu_.QuantityLabel1.Text = 1
            OurMealsMainForm.SalesMenu_.QuantityLabel2.Text = 1
            OurMealsMainForm.InventoryMenu.getFoodTypesCurrentlyContained(0) = True
        ElseIf TomatoButton.Checked Then
            For Each Item As InventorySupply In ExistingItems
                If Item.SupplyImage.ImageLocation = "foods/tomato.png" Then
                    Item.QuantityLabel.Text += 1
                    OurMealsMainForm.SalesMenu_.QuantityLabel3.Text = Item.QuantityLabel.Text
                    Me.Close()
                    Exit Sub
                End If
            Next
            newItem.SupplyImage.ImageLocation = "foods/tomato.png"
            newItem.NameLabel.Text = "tomato"
            newItem.QuantityLabel.Text = 1
            newItem.CategoryLabel.Text = "fruit"
            OurMealsMainForm.SalesMenu_.QuantityLabel3.Text = 1
            OurMealsMainForm.InventoryMenu.getFoodTypesCurrentlyContained(1) = True
        ElseIf LeekButton.Checked Then
            For Each Item As InventorySupply In ExistingItems
                If Item.SupplyImage.ImageLocation = "foods/leek.png" Then
                    Item.QuantityLabel.Text += 1
                    OurMealsMainForm.SalesMenu_.QuantityLabel4.Text = Item.QuantityLabel.Text
                    Me.Close()
                    Exit Sub
                End If
            Next
            newItem.SupplyImage.ImageLocation = "foods/leek.png"
            newItem.NameLabel.Text = "leek"
            newItem.QuantityLabel.Text = 1
            newItem.CategoryLabel.Text = "vegetable"
            OurMealsMainForm.SalesMenu_.QuantityLabel4.Text = 1
            OurMealsMainForm.InventoryMenu.getFoodTypesCurrentlyContained(2) = True
        End If
        OurMealsMainForm.InventoryMenu.addNewItem(newItem)
        Me.Close()

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class