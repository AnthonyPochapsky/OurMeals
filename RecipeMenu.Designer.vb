<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecipeMenu
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
        BackToMainMenuButton = New Button()
        RecipeName = New Label()
        recipeIngredients = New Label()
        ingrediantHeading = New Label()
        InstructionHeader = New Label()
        firstTwoInstructions = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(287, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(352, 45)
        Label1.TabIndex = 9
        Label1.Text = "Recommended Recipes"
        ' 
        ' BackToMainMenuButton
        ' 
        BackToMainMenuButton.BackColor = Color.White
        BackToMainMenuButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        BackToMainMenuButton.Location = New Point(15, 11)
        BackToMainMenuButton.Name = "BackToMainMenuButton"
        BackToMainMenuButton.Size = New Size(198, 45)
        BackToMainMenuButton.TabIndex = 10
        BackToMainMenuButton.Text = "Back To Explorer"
        BackToMainMenuButton.UseVisualStyleBackColor = False
        ' 
        ' RecipeName
        ' 
        RecipeName.AutoSize = True
        RecipeName.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        RecipeName.Location = New Point(47, 106)
        RecipeName.Name = "RecipeName"
        RecipeName.Size = New Size(315, 30)
        RecipeName.TabIndex = 11
        RecipeName.Text = "Tomato and Apple Pasta Sauce "
        RecipeName.Visible = False
        ' 
        ' recipeIngredients
        ' 
        recipeIngredients.Location = New Point(76, 175)
        recipeIngredients.Name = "recipeIngredients"
        recipeIngredients.Size = New Size(334, 71)
        recipeIngredients.TabIndex = 12
        recipeIngredients.Text = "2 Tomatoes" & vbCrLf & "2 Apples" & vbCrLf & "1 Medium Sized Boal" & vbCrLf & "1 Potato Masher"
        recipeIngredients.Visible = False
        ' 
        ' ingrediantHeading
        ' 
        ingrediantHeading.AutoSize = True
        ingrediantHeading.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ingrediantHeading.Location = New Point(67, 145)
        ingrediantHeading.Name = "ingrediantHeading"
        ingrediantHeading.Size = New Size(255, 21)
        ingrediantHeading.TabIndex = 13
        ingrediantHeading.Text = "Ingredients and equipment needed:"
        ingrediantHeading.Visible = False
        ' 
        ' InstructionHeader
        ' 
        InstructionHeader.AutoSize = True
        InstructionHeader.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        InstructionHeader.Location = New Point(76, 246)
        InstructionHeader.Name = "InstructionHeader"
        InstructionHeader.Size = New Size(94, 21)
        InstructionHeader.TabIndex = 14
        InstructionHeader.Text = "Instructions:"
        InstructionHeader.Visible = False
        ' 
        ' firstTwoInstructions
        ' 
        firstTwoInstructions.Location = New Point(76, 281)
        firstTwoInstructions.Name = "firstTwoInstructions"
        firstTwoInstructions.Size = New Size(360, 47)
        firstTwoInstructions.TabIndex = 15
        firstTwoInstructions.Text = "1. place the two tomatoes and apples into the medium sized boal " & vbCrLf & "2. crush them into a nice sauce" & vbCrLf & "3. enjoy"
        firstTwoInstructions.Visible = False
        ' 
        ' RecipeMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(firstTwoInstructions)
        Controls.Add(InstructionHeader)
        Controls.Add(ingrediantHeading)
        Controls.Add(recipeIngredients)
        Controls.Add(RecipeName)
        Controls.Add(BackToMainMenuButton)
        Controls.Add(Label1)
        Name = "RecipeMenu"
        Size = New Size(804, 451)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BackToMainMenuButton As Button
    Friend WithEvents RecipeName As Label
    Friend WithEvents recipeIngredients As Label
    Friend WithEvents ingrediantHeading As Label
    Friend WithEvents InstructionHeader As Label
    Friend WithEvents firstTwoInstructions As Label

End Class
