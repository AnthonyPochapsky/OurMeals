Public Class ConfirmInventoryItemDeletionForm
    Private SupplyToBeDeleted As InventorySupply
    Public Sub New(I As InventorySupply)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SupplyToBeDeleted = I
        NameOfItem.Text = I.NameLabel.Text

    End Sub
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        OurMealsMainForm.InventoryMenu.CompleteSupplyDeletion(SupplyToBeDeleted)
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub
End Class