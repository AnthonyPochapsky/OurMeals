<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setNameForm
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
        ShoppingListNameTextBox = New TextBox()
        Label1 = New Label()
        EnterButton = New Button()
        Label2 = New Label()
        BlankButton = New RadioButton()
        RecipeButton = New RadioButton()
        RoutineButton = New RadioButton()
        Label3 = New Label()
        ShopperNameTextBox = New TextBox()
        Label4 = New Label()
        shoppingDateTextBox = New TextBox()
        Label5 = New Label()
        purposeTextBox = New TextBox()
        CloseButton = New Button()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' ShoppingListNameTextBox
        ' 
        ShoppingListNameTextBox.Location = New Point(12, 38)
        ShoppingListNameTextBox.Name = "ShoppingListNameTextBox"
        ShoppingListNameTextBox.Size = New Size(178, 23)
        ShoppingListNameTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter a name/store for the shopping list:"
        ' 
        ' EnterButton
        ' 
        EnterButton.Location = New Point(237, 400)
        EnterButton.Name = "EnterButton"
        EnterButton.Size = New Size(75, 23)
        EnterButton.TabIndex = 2
        EnterButton.Text = "Create"
        EnterButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 282)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 15)
        Label2.TabIndex = 3
        Label2.Text = "Select type of shopping list to create:"
        ' 
        ' BlankButton
        ' 
        BlankButton.AutoSize = True
        BlankButton.Checked = True
        BlankButton.Location = New Point(28, 319)
        BlankButton.Name = "BlankButton"
        BlankButton.Size = New Size(54, 19)
        BlankButton.TabIndex = 4
        BlankButton.TabStop = True
        BlankButton.Text = "Blank"
        BlankButton.UseVisualStyleBackColor = True
        ' 
        ' RecipeButton
        ' 
        RecipeButton.AutoSize = True
        RecipeButton.Location = New Point(28, 344)
        RecipeButton.Name = "RecipeButton"
        RecipeButton.Size = New Size(60, 19)
        RecipeButton.TabIndex = 5
        RecipeButton.Text = "Recipe"
        RecipeButton.UseVisualStyleBackColor = True
        ' 
        ' RoutineButton
        ' 
        RoutineButton.AutoSize = True
        RoutineButton.Location = New Point(28, 369)
        RoutineButton.Name = "RoutineButton"
        RoutineButton.Size = New Size(66, 19)
        RoutineButton.TabIndex = 6
        RoutineButton.Text = "Routine"
        RoutineButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(322, 15)
        Label3.TabIndex = 8
        Label3.Text = "Enter the name of the shopper who will be assigned this list:"
        ' 
        ' ShopperNameTextBox
        ' 
        ShopperNameTextBox.Location = New Point(12, 107)
        ShopperNameTextBox.Name = "ShopperNameTextBox"
        ShopperNameTextBox.Size = New Size(178, 23)
        ShopperNameTextBox.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(194, 15)
        Label4.TabIndex = 10
        Label4.Text = "Enter the shopping date/frequency:"
        ' 
        ' shoppingDateTextBox
        ' 
        shoppingDateTextBox.Location = New Point(12, 177)
        shoppingDateTextBox.Name = "shoppingDateTextBox"
        shoppingDateTextBox.Size = New Size(178, 23)
        shoppingDateTextBox.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(210, 15)
        Label5.TabIndex = 12
        Label5.Text = "Enter the purpose of this shopping list:"
        ' 
        ' purposeTextBox
        ' 
        purposeTextBox.Location = New Point(12, 243)
        purposeTextBox.Name = "purposeTextBox"
        purposeTextBox.Size = New Size(178, 23)
        purposeTextBox.TabIndex = 11
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(106, 400)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(75, 23)
        CloseButton.TabIndex = 13
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(228, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(12, 15)
        Label6.TabIndex = 14
        Label6.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(334, 78)
        Label7.Name = "Label7"
        Label7.Size = New Size(12, 15)
        Label7.TabIndex = 15
        Label7.Text = "*"
        ' 
        ' setNameForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(358, 435)
        ControlBox = False
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(CloseButton)
        Controls.Add(Label5)
        Controls.Add(purposeTextBox)
        Controls.Add(Label4)
        Controls.Add(shoppingDateTextBox)
        Controls.Add(Label3)
        Controls.Add(ShopperNameTextBox)
        Controls.Add(RoutineButton)
        Controls.Add(RecipeButton)
        Controls.Add(BlankButton)
        Controls.Add(Label2)
        Controls.Add(EnterButton)
        Controls.Add(Label1)
        Controls.Add(ShoppingListNameTextBox)
        Name = "setNameForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Grocery List Name"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ShoppingListNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EnterButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BlankButton As RadioButton
    Friend WithEvents RecipeButton As RadioButton
    Friend WithEvents RoutineButton As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ShopperNameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents shoppingDateTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents purposeTextBox As TextBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
