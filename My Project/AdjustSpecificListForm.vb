Public Class AdjustSpecificListForm
    Private ListToAdjust As GroceryListMenu
    Public Sub New(currentList As GroceryListMenu)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ListToAdjust = currentList
    End Sub
    Private Sub AdjustButton_Click(sender As Object, e As EventArgs) Handles AdjustButton.Click
        If (BasedOnCurrentSuppliesButton.Checked) Then
            Dim CurrentItemBoxes = ListToAdjust.getListOfItemBoxes()
            Dim CurrentInventorySupplies = OurMealsMainForm.InventoryMenu.getItems()
            For Each supply As InventorySupply In CurrentInventorySupplies
                For i = 0 To supply.QuantityLabel.Text - 1
                    For Each Item As RichTextBox In CurrentItemBoxes
                        If (supply.SupplyImage.ImageLocation = "foods/apple.png") Then
                            If (Item.Text.ToLower.Contains("apple")) Then
                                CurrentItemBoxes.Remove(Item)
                                ListToAdjust.Controls.Remove(Item)
                                Exit For
                            End If
                        ElseIf (supply.SupplyImage.ImageLocation = "foods/tomato.png") Then
                            If (Item.Text.ToLower.Contains("tomato")) Then
                                CurrentItemBoxes.Remove(Item)
                                ListToAdjust.Controls.Remove(Item)
                                Exit For
                            End If
                        ElseIf (supply.SupplyImage.ImageLocation = "foods/leek.jpg") Then
                            If (Item.Text.ToLower.Contains("leek")) Then
                                CurrentItemBoxes.Remove(Item)
                                ListToAdjust.Controls.Remove(Item)
                                Exit For
                            End If
                        End If
                    Next
                Next
            Next
            Me.Close()
        End If
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class