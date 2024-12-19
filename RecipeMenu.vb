Public Class RecipeMenu
    Private Sub BackToMainMenuButton_Click(sender As Object, e As EventArgs) Handles BackToMainMenuButton.Click
        Me.Visible = False
        OurMealsMainForm.MainMenu.Visible = True
    End Sub

End Class
