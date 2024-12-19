Public Class SalesMenu
    Private selectedItems As New List(Of PictureBox)
    Private Sub BackToMainMenuButton_Click(sender As Object, e As EventArgs) Handles BackToMainMenuButton.Click
        For Each item As PictureBox In selectedItems
            item.BorderStyle = BorderStyle.None
        Next
        selectedItems.Clear()

        Me.Visible = False
        OurMealsMainForm.MainMenu.Visible = True
    End Sub

    Private Sub Item_Click(sender As Object, e As EventArgs) Handles AppleSaleImage1.Click, TomatoSaleImage1.Click, AppleSaleImage2.Click, LeekSaleImage.Click
        If Not selectedItems.Contains(sender) Then
            selectedItems.Add(sender)
            sender.BorderStyle = BorderStyle.FixedSingle
        Else
            selectedItems.Remove(sender)
            sender.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub CreateItineraryButton_Click(sender As Object, e As EventArgs) Handles CreateItineraryButton.Click
        If (selectedItems.Count > 0) Then
            For Each item As PictureBox In selectedItems
                item.BorderStyle = BorderStyle.None
            Next
            selectedItems.Clear()

            Me.Visible = False
            OurMealsMainForm.GroceryListManagementMenu.Visible = True
            OurMealsMainForm.NotificationBar.Visible = True
            OurMealsMainForm.GroceryListManagementMenu.ItineraryButton.Visible = True
        Else
            MsgBox("Must select at least one on sale item")
        End If
    End Sub

End Class
