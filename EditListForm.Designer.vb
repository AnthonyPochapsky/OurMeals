<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditListForm
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
        Label5 = New Label()
        purposeTextBox = New TextBox()
        Label4 = New Label()
        shoppingDateTextBox = New TextBox()
        Label3 = New Label()
        ShopperNameTextBox = New TextBox()
        Label1 = New Label()
        ShoppingListNameTextBox = New TextBox()
        CloseButton = New Button()
        ConfirmButton = New Button()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 224)
        Label5.Name = "Label5"
        Label5.Size = New Size(224, 15)
        Label5.TabIndex = 23
        Label5.Text = "Change the purpose of this shopping list:"
        ' 
        ' purposeTextBox
        ' 
        purposeTextBox.Location = New Point(12, 253)
        purposeTextBox.Name = "purposeTextBox"
        purposeTextBox.Size = New Size(178, 23)
        purposeTextBox.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(208, 15)
        Label4.TabIndex = 21
        Label4.Text = "Change the shopping date/frequency:"
        ' 
        ' shoppingDateTextBox
        ' 
        shoppingDateTextBox.Location = New Point(12, 187)
        shoppingDateTextBox.Name = "shoppingDateTextBox"
        shoppingDateTextBox.Size = New Size(178, 23)
        shoppingDateTextBox.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(336, 15)
        Label3.TabIndex = 19
        Label3.Text = "Change the name of the shopper who will be assigned this list:"
        ' 
        ' ShopperNameTextBox
        ' 
        ShopperNameTextBox.Location = New Point(12, 117)
        ShopperNameTextBox.Name = "ShopperNameTextBox"
        ShopperNameTextBox.Size = New Size(178, 23)
        ShopperNameTextBox.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 15)
        Label1.TabIndex = 17
        Label1.Text = "Change name/store for the shopping list:"
        ' 
        ' ShoppingListNameTextBox
        ' 
        ShoppingListNameTextBox.Location = New Point(12, 48)
        ShoppingListNameTextBox.Name = "ShoppingListNameTextBox"
        ShoppingListNameTextBox.Size = New Size(178, 23)
        ShoppingListNameTextBox.TabIndex = 16
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(97, 301)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(75, 23)
        CloseButton.TabIndex = 25
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' ConfirmButton
        ' 
        ConfirmButton.Location = New Point(228, 301)
        ConfirmButton.Name = "ConfirmButton"
        ConfirmButton.Size = New Size(75, 23)
        ConfirmButton.TabIndex = 24
        ConfirmButton.Text = "Confirm"
        ConfirmButton.UseVisualStyleBackColor = True
        ' 
        ' EditListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(358, 349)
        ControlBox = False
        Controls.Add(CloseButton)
        Controls.Add(ConfirmButton)
        Controls.Add(Label5)
        Controls.Add(purposeTextBox)
        Controls.Add(Label4)
        Controls.Add(shoppingDateTextBox)
        Controls.Add(Label3)
        Controls.Add(ShopperNameTextBox)
        Controls.Add(Label1)
        Controls.Add(ShoppingListNameTextBox)
        Name = "EditListForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "EditListForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents purposeTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents shoppingDateTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ShopperNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ShoppingListNameTextBox As TextBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents ConfirmButton As Button
End Class
