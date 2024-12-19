Imports System.Text.RegularExpressions

Public Class ModifyInventorySupplyForm
    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim SupplyToModify As InventorySupply
        Dim Match = False
        Dim currentSupplies As List(Of InventorySupply) = OurMealsMainForm.InventoryMenu.getItems()
        For Each supply In currentSupplies
            If supply.NameLabel.Text = SupplyNameTextBox.Text Then
                Match = True
                SupplyToModify = supply
                Exit For
            End If
        Next
        If Not Match Then
            MsgBox("No supply currently in inventory with that name")
            Exit Sub
        End If
        If (Not BrandTextBox.Text = "") Then
            SupplyToModify.BrandLabel.Text = BrandTextBox.Text
        End If
        If (Regex.IsMatch(QuantityTextBox.Text, "^[1-9]$")) Then
            SupplyToModify.QuantityLabel.Text = QuantityTextBox.Text
            If SupplyToModify.SupplyImage.ImageLocation = "foods/apple.png" Then
                OurMealsMainForm.SalesMenu_.QuantityLabel1.Text = QuantityTextBox.Text
                OurMealsMainForm.SalesMenu_.QuantityLabel2.Text = QuantityTextBox.Text
            ElseIf SupplyToModify.SupplyImage.ImageLocation = "foods/tomato.png" Then
                OurMealsMainForm.SalesMenu_.QuantityLabel3.Text = QuantityTextBox.Text
            ElseIf SupplyToModify.SupplyImage.ImageLocation = "foods/leek.png" Then
                OurMealsMainForm.SalesMenu_.QuantityLabel4.Text = QuantityTextBox.Text
            End If
        ElseIf (Not QuantityTextBox.Text = "") Then
            MsgBox("Specified quantity must be an integer amount between 1 and 9")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class