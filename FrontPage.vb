Public Class FrontPage
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        OurMealsMainForm.FrontPage.Visible = False
        OurMealsMainForm.MainMenu.Visible = True
    End Sub

    Private Sub FrontPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OurMealsIcon.ImageLocation = "other/OurMealsIcon.png"
    End Sub
End Class
