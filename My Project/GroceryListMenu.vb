Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar

Public Class GroceryListMenu
    Private OldCursorLocation As Point
    Private ListOfItemBoxes As New List(Of RichTextBox)
    Private PurchasedItems As New Dictionary(Of Timer, RichTextBox)
    Private canDelete As Boolean = False

    Public Sub ModifyListWithExternalItems(item As RichTextBox, createNotifications As Boolean)
        AddHandler item.MouseDown, AddressOf ListItem_MouseDown
        AddHandler item.MouseMove, AddressOf ListItem_MouseMove
        AddHandler item.MouseUp, AddressOf ListItem_MouseUp
        AddHandler item.Click, AddressOf ListItem_Click
        Controls.Add(item)
        ListOfItemBoxes.Add(item)
        If (createNotifications) Then
            OurMealsMainForm.notificationMsg.ForeColor = Color.Green
            OurMealsMainForm.notificationMsg.Text = item.Text + " has been added to " + Me.GroceryListNameLabel.Text.Substring(26) + " at 1 unit of quantity"
        End If
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Visible = False
        OurMealsMainForm.GroceryListManagementMenu.Visible = True
    End Sub
    Public Function getListOfItemBoxes()
        Return ListOfItemBoxes
    End Function
    Public Sub RemoveItemBoxFromListOfItemBoxes(boxToBeRemoved As RichTextBox)
        ListOfItemBoxes.Remove(boxToBeRemoved)
        Controls.Remove(boxToBeRemoved)
    End Sub
    Private Sub EditModeButton_Click(sender As Object, e As EventArgs) Handles EditModeButton.Click
        CurrentModePictureBox.ImageLocation = "other/editModeImage.png"
        AdjustButton.Enabled = True
        EditModeButton.Enabled = False
        AddButton.Enabled = True
        ShopModeButton.Enabled = True
        DeleteButton.Enabled = True
        StopDeleteButton.Enabled = True
        For Each ItemBox As RichTextBox In ListOfItemBoxes
            ItemBox.ReadOnly = False
        Next
    End Sub

    Private Sub ShopModeButton_Click(sender As Object, e As EventArgs) Handles ShopModeButton.Click
        CurrentModePictureBox.ImageLocation = "other/shopModeImage.png"
        AdjustButton.Enabled = False
        ShopModeButton.Enabled = False
        AddButton.Enabled = False
        DeleteButton.Enabled = False
        StopDeleteButton.Enabled = False
        EditModeButton.Enabled = True
        For Each ItemBox As RichTextBox In ListOfItemBoxes
            ItemBox.ReadOnly = True
        Next
    End Sub
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim addToListForm = New AddToGroceryListForm(Me)
        addToListForm.ShowDialog
    End Sub
    Private Sub AdjustButton_Click(sender As Object, e As EventArgs) Handles AdjustButton.Click
        Dim AdjustListForm = New AdjustSpecificListForm(Me)
        AdjustListForm.ShowDialog()
    End Sub
    Public Sub AddNewBlankItem()
        Dim ListItem = New RichTextBox
        ListItem.Size = New Point(222, 60)
        ListItem.Location = New Point(27, 102)
        ListItem.ReadOnly = False
        ListItem.Enabled = True
        AddHandler ListItem.MouseDown, AddressOf ListItem_MouseDown
        AddHandler ListItem.MouseMove, AddressOf ListItem_MouseMove
        AddHandler ListItem.MouseUp, AddressOf ListItem_MouseUp
        AddHandler ListItem.Click, AddressOf ListItem_Click
        Controls.Add(ListItem)
        ListOfItemBoxes.Add(ListItem)
        ListItem.BringToFront()

        OurMealsMainForm.notificationMsg.ForeColor = Color.Green
        OurMealsMainForm.notificationMsg.Text = "A new item has been added to " + Me.GroceryListNameLabel.Text.Substring(26)
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        DeleteButton.Enabled = False
        AddButton.Enabled = False
        AdjustButton.Enabled = False
        StopDeleteButton.Enabled = True
    End Sub
    Private Sub StopDeleteButton_Click(sender As Object, e As EventArgs) Handles StopDeleteButton.Click
        DeleteButton.Enabled = True
        AddButton.Enabled = True
        AdjustButton.Enabled = True
        StopDeleteButton.Enabled = False
    End Sub
    Private Sub ListItem_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If (Not ShopModeButton.Enabled) Then
            Dim ConfirmPurchaseForm = New ConfirmPurchaseForm(sender, Me)
            ConfirmPurchaseForm.ShowDialog()
        ElseIf (Not DeleteButton.Enabled) Then
            Dim ConfirmListItemDeletionForm = New ConfirmListItemDeletionForm(sender, Me)
            ConfirmListItemDeletionForm.ShowDialog()
        End If
    End Sub

    Public Sub PrepareDeletion(ItemToBeDeleted As RichTextBox)
        ListOfItemBoxes.Remove(ItemToBeDeleted)
        Controls.Remove(ItemToBeDeleted)
        OurMealsMainForm.notificationMsg.ForeColor = Color.Red
        OurMealsMainForm.notificationMsg.Text = ItemToBeDeleted.Text + " has been Removed from " + Me.GroceryListNameLabel.Text.Substring(26)
    End Sub
    Public Sub PreparePurchase(ItemToBePurchased As RichTextBox)
        ItemToBePurchased.Enabled = False
        Dim DeletionTimer = New Timer()
        DeletionTimer.Interval = 3000
        PurchasedItems.Add(DeletionTimer, ItemToBePurchased)
        AddHandler DeletionTimer.Tick, AddressOf Me.DeletionTimer_Tick
        DeletionTimer.Enabled = True
    End Sub

    'Remove purchased item from UI after 3 seconds since purchase
    Private Sub DeletionTimer_Tick(sender As Object, e As EventArgs)
        sender.Enabled = False
        Dim PurchasedBoxToBeRemoved = PurchasedItems(sender)
        ListOfItemBoxes.Remove(PurchasedBoxToBeRemoved)
        PurchasedItems.Remove(sender)
        MyBase.Controls.Remove(PurchasedBoxToBeRemoved)

        OurMealsMainForm.notificationMsg.ForeColor = Color.Green
        OurMealsMainForm.notificationMsg.Text = PurchasedBoxToBeRemoved.Text + " has been purchased from " + Me.GroceryListNameLabel.Text.Substring(26) + " and the refrigerator inventory has been adjusted"

        'sync purchase with inventory
        Dim existingItems = OurMealsMainForm.InventoryMenu.getFoodTypesCurrentlyContained()
        Dim newItem As New InventorySupply
        newItem.Location = New Point(46, 137)
        newItem.Visible = True
        If PurchasedBoxToBeRemoved.Text.ToLower.Contains("apple") Then
            If (existingItems(0) = True) Then
                OurMealsMainForm.InventoryMenu.incrementTotalApples()
                Exit Sub
            Else
                newItem.SupplyImage.ImageLocation = "foods/apple.png"
                newItem.NameLabel.Text = "apple"
                newItem.QuantityLabel.Text = 1
                newItem.CategoryLabel.Text = "fruit"
                OurMealsMainForm.InventoryMenu.getFoodTypesCurrentlyContained(0) = True
                OurMealsMainForm.SalesMenu_.QuantityLabel1.Text = 1
                OurMealsMainForm.SalesMenu_.QuantityLabel2.Text = 1
            End If
            OurMealsMainForm.InventoryMenu.addNewItem(newItem)
        ElseIf (PurchasedBoxToBeRemoved.Text.ToLower.Contains("tomato")) Then
            If (existingItems(1) = True) Then
                OurMealsMainForm.InventoryMenu.incrementTotalTomatoes()
                Exit Sub
            Else
                newItem.SupplyImage.ImageLocation = "foods/tomato.png"
                newItem.NameLabel.Text = "tomato"
                newItem.QuantityLabel.Text = 1
                newItem.CategoryLabel.Text = "fruit"
                OurMealsMainForm.InventoryMenu.getFoodTypesCurrentlyContained(1) = True
                OurMealsMainForm.SalesMenu_.QuantityLabel3.Text = 1
            End If
            OurMealsMainForm.InventoryMenu.addNewItem(newItem)
        ElseIf (PurchasedBoxToBeRemoved.Text.ToLower.Contains("leek")) Then
            If (existingItems(2) = True) Then
                OurMealsMainForm.InventoryMenu.incrementTotalLeeks()
                Exit Sub
            Else
                newItem.SupplyImage.ImageLocation = "foods/leek.png"
                newItem.NameLabel.Text = "leek"
                newItem.QuantityLabel.Text = 1
                newItem.CategoryLabel.Text = "vegetable"
                OurMealsMainForm.InventoryMenu.getFoodTypesCurrentlyContained(2) = True
                OurMealsMainForm.SalesMenu_.QuantityLabel4.Text = 1
            End If
            OurMealsMainForm.InventoryMenu.addNewItem(newItem)
        End If
    End Sub
    Private Sub ListItem_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        sender.Capture = True
        sender.BringToFront()
        OldCursorLocation = e.Location
    End Sub

    Private Sub ListItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If (sender.Capture And ShopModeButton.Enabled) Then
            sender.Location = sender.Location + e.Location - OldCursorLocation
        End If
    End Sub

    Private Sub ListItem_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        sender.Capture = False
    End Sub

End Class
