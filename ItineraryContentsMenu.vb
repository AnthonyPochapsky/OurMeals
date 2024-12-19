Public Class ItineraryContentsMenu
    Private itemBoxes As New List(Of RichTextBox)
    Private Sub ItineraryContentsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        itemBoxes.Add(AppleItemBox)
        itemBoxes.Add(TomatoItemBox)
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Visible = False
        OurMealsMainForm.GroceryListManagementMenu.Visible = True
    End Sub

    Private Sub SplitItineraryButton_Click(sender As Object, e As EventArgs) Handles SplitItineraryButton.Click
        Visible = False
        OurMealsMainForm.GroceryListManagementMenu.Visible = True
        OurMealsMainForm.GroceryListManagementMenu.setSplittingItinerary(True)
        OurMealsMainForm.GroceryListManagementMenu.CreateNewList(Nothing, Nothing)
    End Sub
    Public Function getItemBoxes()
        Return itemBoxes
    End Function

    Private Sub ConvertItineraryButton_Click(sender As Object, e As EventArgs) Handles ConvertItineraryButton.Click
        Visible = False
        OurMealsMainForm.GroceryListManagementMenu.Visible = True
        OurMealsMainForm.GroceryListManagementMenu.setConvertingItinerary(True)
        OurMealsMainForm.GroceryListManagementMenu.CreateNewList(Nothing, Nothing)
    End Sub
End Class
