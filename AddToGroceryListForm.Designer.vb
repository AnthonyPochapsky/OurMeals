<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddToGroceryListForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        BlankButton = New RadioButton()
        FridgeInventoryButton = New RadioButton()
        DifferentListButton = New RadioButton()
        RecipeButton = New RadioButton()
        EnterButton = New Button()
        CloseButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 15)
        Label1.TabIndex = 0
        Label1.Text = "Choose the method of adding to this list:"
        ' 
        ' BlankButton
        ' 
        BlankButton.AutoSize = True
        BlankButton.Checked = True
        BlankButton.Location = New Point(28, 38)
        BlankButton.Name = "BlankButton"
        BlankButton.Size = New Size(136, 19)
        BlankButton.TabIndex = 1
        BlankButton.TabStop = True
        BlankButton.Text = "New Empty Item Box"
        BlankButton.UseVisualStyleBackColor = True
        ' 
        ' FridgeInventoryButton
        ' 
        FridgeInventoryButton.AutoSize = True
        FridgeInventoryButton.Location = New Point(29, 75)
        FridgeInventoryButton.Name = "FridgeInventoryButton"
        FridgeInventoryButton.Size = New Size(111, 19)
        FridgeInventoryButton.TabIndex = 2
        FridgeInventoryButton.TabStop = True
        FridgeInventoryButton.Text = "Fridge Inventory"
        FridgeInventoryButton.UseVisualStyleBackColor = True
        ' 
        ' DifferentListButton
        ' 
        DifferentListButton.AutoSize = True
        DifferentListButton.Location = New Point(29, 111)
        DifferentListButton.Name = "DifferentListButton"
        DifferentListButton.Size = New Size(143, 19)
        DifferentListButton.TabIndex = 3
        DifferentListButton.TabStop = True
        DifferentListButton.Text = "Another Shopping List"
        DifferentListButton.UseVisualStyleBackColor = True
        ' 
        ' RecipeButton
        ' 
        RecipeButton.AutoSize = True
        RecipeButton.Location = New Point(28, 147)
        RecipeButton.Name = "RecipeButton"
        RecipeButton.Size = New Size(91, 19)
        RecipeButton.TabIndex = 4
        RecipeButton.TabStop = True
        RecipeButton.Text = "From Recipe"
        RecipeButton.UseVisualStyleBackColor = True
        ' 
        ' EnterButton
        ' 
        EnterButton.Location = New Point(144, 189)
        EnterButton.Name = "EnterButton"
        EnterButton.Size = New Size(75, 23)
        EnterButton.TabIndex = 5
        EnterButton.Text = "Enter"
        EnterButton.UseVisualStyleBackColor = True
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(44, 189)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(75, 23)
        CloseButton.TabIndex = 6
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' AddToGroceryListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(253, 224)
        ControlBox = False
        Controls.Add(CloseButton)
        Controls.Add(EnterButton)
        Controls.Add(RecipeButton)
        Controls.Add(DifferentListButton)
        Controls.Add(FridgeInventoryButton)
        Controls.Add(BlankButton)
        Controls.Add(Label1)
        Name = "AddToGroceryListForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Add To Grocery List"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BlankButton As RadioButton
    Friend WithEvents FridgeInventoryButton As RadioButton
    Friend WithEvents DifferentListButton As RadioButton
    Friend WithEvents RecipeButton As RadioButton
    Friend WithEvents EnterButton As Button
    Friend WithEvents CloseButton As Button
End Class
