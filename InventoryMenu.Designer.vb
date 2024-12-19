<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryMenu
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
        CreateRecipesButton = New Button()
        FindSalesButton = New Button()
        BackToMainMenuButton = New Button()
        EditButton = New Button()
        StopEditButton = New Button()
        DeleteButton = New Button()
        AddButton = New Button()
        FindMissingItemSalesButton = New Button()
        InventorySupply1 = New InventorySupply()
        InventorySupply2 = New InventorySupply()
        StopDeleteButton = New Button()
        ModifyButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(241, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 45)
        Label1.TabIndex = 7
        Label1.Text = "Refrigerator Inventory"
        ' 
        ' CreateRecipesButton
        ' 
        CreateRecipesButton.BackColor = Color.White
        CreateRecipesButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        CreateRecipesButton.Location = New Point(54, 296)
        CreateRecipesButton.Name = "CreateRecipesButton"
        CreateRecipesButton.Size = New Size(309, 69)
        CreateRecipesButton.TabIndex = 8
        CreateRecipesButton.Text = "Be Recommended A Recipe From Selected Supplies"
        CreateRecipesButton.UseVisualStyleBackColor = False
        ' 
        ' FindSalesButton
        ' 
        FindSalesButton.BackColor = Color.White
        FindSalesButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        FindSalesButton.Location = New Point(490, 296)
        FindSalesButton.Name = "FindSalesButton"
        FindSalesButton.Size = New Size(252, 69)
        FindSalesButton.TabIndex = 9
        FindSalesButton.Text = "Find Special Sales On Selected Supplies"
        FindSalesButton.UseVisualStyleBackColor = False
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
        ' EditButton
        ' 
        EditButton.BackColor = Color.White
        EditButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        EditButton.ForeColor = SystemColors.ControlText
        EditButton.Location = New Point(577, 15)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(109, 65)
        EditButton.TabIndex = 11
        EditButton.Text = "Edit"
        EditButton.UseVisualStyleBackColor = False
        ' 
        ' StopEditButton
        ' 
        StopEditButton.BackColor = Color.White
        StopEditButton.Enabled = False
        StopEditButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        StopEditButton.ForeColor = SystemColors.ControlText
        StopEditButton.Location = New Point(692, 15)
        StopEditButton.Name = "StopEditButton"
        StopEditButton.Size = New Size(109, 65)
        StopEditButton.TabIndex = 17
        StopEditButton.Text = "Stop Edit"
        StopEditButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteButton
        ' 
        DeleteButton.BackColor = Color.White
        DeleteButton.Enabled = False
        DeleteButton.ForeColor = Color.Red
        DeleteButton.Location = New Point(644, 195)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(108, 41)
        DeleteButton.TabIndex = 19
        DeleteButton.Text = "Enable Removal On Click"
        DeleteButton.UseVisualStyleBackColor = False
        ' 
        ' AddButton
        ' 
        AddButton.BackColor = Color.White
        AddButton.Enabled = False
        AddButton.ForeColor = Color.Green
        AddButton.Location = New Point(644, 95)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(108, 41)
        AddButton.TabIndex = 18
        AddButton.Text = "Add Supply"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' FindMissingItemSalesButton
        ' 
        FindMissingItemSalesButton.BackColor = Color.White
        FindMissingItemSalesButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        FindMissingItemSalesButton.Location = New Point(490, 371)
        FindMissingItemSalesButton.Name = "FindMissingItemSalesButton"
        FindMissingItemSalesButton.Size = New Size(252, 69)
        FindMissingItemSalesButton.TabIndex = 23
        FindMissingItemSalesButton.Text = "Find Special Sales On Missing Supplies"
        FindMissingItemSalesButton.UseVisualStyleBackColor = False
        ' 
        ' InventorySupply1
        ' 
        InventorySupply1.Location = New Point(29, 83)
        InventorySupply1.Name = "InventorySupply1"
        InventorySupply1.Size = New Size(151, 155)
        InventorySupply1.TabIndex = 24
        ' 
        ' InventorySupply2
        ' 
        InventorySupply2.Location = New Point(212, 83)
        InventorySupply2.Name = "InventorySupply2"
        InventorySupply2.Size = New Size(151, 155)
        InventorySupply2.TabIndex = 25
        ' 
        ' StopDeleteButton
        ' 
        StopDeleteButton.BackColor = Color.White
        StopDeleteButton.Enabled = False
        StopDeleteButton.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        StopDeleteButton.ForeColor = Color.Red
        StopDeleteButton.Location = New Point(644, 242)
        StopDeleteButton.Name = "StopDeleteButton"
        StopDeleteButton.Size = New Size(108, 41)
        StopDeleteButton.TabIndex = 20
        StopDeleteButton.Text = "Disable Removal On Click"
        StopDeleteButton.UseVisualStyleBackColor = False
        ' 
        ' ModifyButton
        ' 
        ModifyButton.BackColor = Color.White
        ModifyButton.Enabled = False
        ModifyButton.ForeColor = Color.Green
        ModifyButton.Location = New Point(644, 142)
        ModifyButton.Name = "ModifyButton"
        ModifyButton.Size = New Size(108, 41)
        ModifyButton.TabIndex = 26
        ModifyButton.Text = "Modify Supply"
        ModifyButton.UseVisualStyleBackColor = False
        ' 
        ' InventoryMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ModifyButton)
        Controls.Add(InventorySupply2)
        Controls.Add(InventorySupply1)
        Controls.Add(FindMissingItemSalesButton)
        Controls.Add(StopDeleteButton)
        Controls.Add(DeleteButton)
        Controls.Add(AddButton)
        Controls.Add(StopEditButton)
        Controls.Add(EditButton)
        Controls.Add(BackToMainMenuButton)
        Controls.Add(FindSalesButton)
        Controls.Add(CreateRecipesButton)
        Controls.Add(Label1)
        Name = "InventoryMenu"
        Size = New Size(804, 451)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CreateRecipesButton As Button
    Friend WithEvents FindSalesButton As Button
    Friend WithEvents BackToMainMenuButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents StopEditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents FindMissingItemSalesButton As Button
    Friend WithEvents InventorySupply1 As InventorySupply
    Friend WithEvents InventorySupply2 As InventorySupply
    Friend WithEvents StopDeleteButton As Button
    Friend WithEvents ModifyButton As Button

End Class
