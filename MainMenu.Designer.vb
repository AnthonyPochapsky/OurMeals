<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        FridgeInventoryButton = New Button()
        ViewSuppliesButton = New Button()
        ViewRecipesButton = New Button()
        ViewShoppingListsButton = New Button()
        BackToFrontPageButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(270, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 45)
        Label1.TabIndex = 0
        Label1.Text = "OurMeals Explorer"
        ' 
        ' FridgeInventoryButton
        ' 
        FridgeInventoryButton.BackColor = Color.White
        FridgeInventoryButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FridgeInventoryButton.Location = New Point(107, 179)
        FridgeInventoryButton.Name = "FridgeInventoryButton"
        FridgeInventoryButton.Size = New Size(193, 57)
        FridgeInventoryButton.TabIndex = 1
        FridgeInventoryButton.Text = "View Fridge Inventory"
        FridgeInventoryButton.UseVisualStyleBackColor = False
        ' 
        ' ViewSuppliesButton
        ' 
        ViewSuppliesButton.BackColor = Color.White
        ViewSuppliesButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ViewSuppliesButton.Location = New Point(107, 266)
        ViewSuppliesButton.Name = "ViewSuppliesButton"
        ViewSuppliesButton.Size = New Size(193, 57)
        ViewSuppliesButton.TabIndex = 2
        ViewSuppliesButton.Text = "View OnSale Supplies"
        ViewSuppliesButton.UseVisualStyleBackColor = False
        ' 
        ' ViewRecipesButton
        ' 
        ViewRecipesButton.BackColor = Color.White
        ViewRecipesButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ViewRecipesButton.Location = New Point(491, 179)
        ViewRecipesButton.Name = "ViewRecipesButton"
        ViewRecipesButton.Size = New Size(193, 57)
        ViewRecipesButton.TabIndex = 3
        ViewRecipesButton.Text = "View Recipes"
        ViewRecipesButton.UseVisualStyleBackColor = False
        ' 
        ' ViewShoppingListsButton
        ' 
        ViewShoppingListsButton.BackColor = Color.White
        ViewShoppingListsButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ViewShoppingListsButton.Location = New Point(491, 266)
        ViewShoppingListsButton.Name = "ViewShoppingListsButton"
        ViewShoppingListsButton.Size = New Size(193, 57)
        ViewShoppingListsButton.TabIndex = 4
        ViewShoppingListsButton.Text = "View Shopping Lists"
        ViewShoppingListsButton.UseVisualStyleBackColor = False
        ' 
        ' BackToFrontPageButton
        ' 
        BackToFrontPageButton.BackColor = Color.White
        BackToFrontPageButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        BackToFrontPageButton.Location = New Point(15, 11)
        BackToFrontPageButton.Name = "BackToFrontPageButton"
        BackToFrontPageButton.Size = New Size(202, 45)
        BackToFrontPageButton.TabIndex = 5
        BackToFrontPageButton.Text = "Back To FrontPage"
        BackToFrontPageButton.UseVisualStyleBackColor = False
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BackToFrontPageButton)
        Controls.Add(ViewShoppingListsButton)
        Controls.Add(ViewRecipesButton)
        Controls.Add(ViewSuppliesButton)
        Controls.Add(FridgeInventoryButton)
        Controls.Add(Label1)
        Name = "MainMenu"
        Size = New Size(804, 451)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FridgeInventoryButton As Button
    Friend WithEvents ViewSuppliesButton As Button
    Friend WithEvents ViewRecipesButton As Button
    Friend WithEvents ViewShoppingListsButton As Button
    Friend WithEvents BackToFrontPageButton As Button

End Class
