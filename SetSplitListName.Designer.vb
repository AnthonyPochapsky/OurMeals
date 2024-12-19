<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetSplitListName
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
        Label3 = New Label()
        ShopperNameTextBox = New TextBox()
        ShoppingListNameLabel = New Label()
        ShoppingListNameTextBox = New TextBox()
        CreateButton = New Button()
        Label5 = New Label()
        purposeTextBox = New TextBox()
        Label4 = New Label()
        shoppingDateTextBox = New TextBox()
        Label6 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(322, 15)
        Label3.TabIndex = 12
        Label3.Text = "Enter the name of the shopper who will be assigned this list:"
        ' 
        ' ShopperNameTextBox
        ' 
        ShopperNameTextBox.Location = New Point(24, 117)
        ShopperNameTextBox.Name = "ShopperNameTextBox"
        ShopperNameTextBox.Size = New Size(178, 23)
        ShopperNameTextBox.TabIndex = 11
        ' 
        ' ShoppingListNameLabel
        ' 
        ShoppingListNameLabel.AutoSize = True
        ShoppingListNameLabel.Location = New Point(24, 19)
        ShoppingListNameLabel.Name = "ShoppingListNameLabel"
        ShoppingListNameLabel.Size = New Size(221, 15)
        ShoppingListNameLabel.TabIndex = 10
        ShoppingListNameLabel.Text = "Enter a name/store for this shopping list:"
        ' 
        ' ShoppingListNameTextBox
        ' 
        ShoppingListNameTextBox.Location = New Point(24, 48)
        ShoppingListNameTextBox.Name = "ShoppingListNameTextBox"
        ShoppingListNameTextBox.Size = New Size(178, 23)
        ShoppingListNameTextBox.TabIndex = 9
        ' 
        ' CreateButton
        ' 
        CreateButton.Location = New Point(258, 299)
        CreateButton.Name = "CreateButton"
        CreateButton.Size = New Size(75, 23)
        CreateButton.TabIndex = 13
        CreateButton.Text = "Create"
        CreateButton.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 230)
        Label5.Name = "Label5"
        Label5.Size = New Size(210, 15)
        Label5.TabIndex = 17
        Label5.Text = "Enter the purpose of this shopping list:"
        ' 
        ' purposeTextBox
        ' 
        purposeTextBox.Location = New Point(24, 259)
        purposeTextBox.Name = "purposeTextBox"
        purposeTextBox.Size = New Size(178, 23)
        purposeTextBox.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(194, 15)
        Label4.TabIndex = 15
        Label4.Text = "Enter the shopping date/frequency:"
        ' 
        ' shoppingDateTextBox
        ' 
        shoppingDateTextBox.Location = New Point(24, 193)
        shoppingDateTextBox.Name = "shoppingDateTextBox"
        shoppingDateTextBox.Size = New Size(178, 23)
        shoppingDateTextBox.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(242, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(12, 15)
        Label6.TabIndex = 18
        Label6.Text = "*"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(346, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(12, 15)
        Label1.TabIndex = 19
        Label1.Text = "*"
        ' 
        ' SetSplitListName
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 334)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(purposeTextBox)
        Controls.Add(Label4)
        Controls.Add(shoppingDateTextBox)
        Controls.Add(CreateButton)
        Controls.Add(Label3)
        Controls.Add(ShopperNameTextBox)
        Controls.Add(ShoppingListNameLabel)
        Controls.Add(ShoppingListNameTextBox)
        Name = "SetSplitListName"
        StartPosition = FormStartPosition.CenterParent
        Text = "Shopping List Name"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents ShopperNameTextBox As TextBox
    Friend WithEvents ShoppingListNameLabel As Label
    Friend WithEvents ShoppingListNameTextBox As TextBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents purposeTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents shoppingDateTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
End Class
