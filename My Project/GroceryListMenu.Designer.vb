<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroceryListMenu
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroceryListMenu))
        GroceryListNameLabel = New Label()
        BackButton = New Button()
        ShopModeButton = New Button()
        EditModeButton = New Button()
        Timer1 = New Timer(components)
        DeleteButton = New Button()
        AddButton = New Button()
        StopDeleteButton = New Button()
        ShopperNameLabel = New Label()
        purposeLabel = New Label()
        shoppingDateLabel = New Label()
        CurrentModePictureBox = New PictureBox()
        AdjustButton = New Button()
        CType(CurrentModePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroceryListNameLabel
        ' 
        GroceryListNameLabel.AutoSize = True
        GroceryListNameLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroceryListNameLabel.Location = New Point(517, 64)
        GroceryListNameLabel.Name = "GroceryListNameLabel"
        GroceryListNameLabel.Size = New Size(159, 15)
        GroceryListNameLabel.TabIndex = 0
        GroceryListNameLabel.Text = "Shopping List Name/Store: "
        ' 
        ' BackButton
        ' 
        BackButton.BackColor = Color.White
        BackButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        BackButton.Location = New Point(15, 11)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(260, 41)
        BackButton.TabIndex = 1
        BackButton.Text = "Back To Shopping Lists"
        BackButton.UseVisualStyleBackColor = False
        ' 
        ' ShopModeButton
        ' 
        ShopModeButton.BackColor = Color.White
        ShopModeButton.Enabled = False
        ShopModeButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        ShopModeButton.ForeColor = SystemColors.ControlText
        ShopModeButton.Location = New Point(572, 356)
        ShopModeButton.Name = "ShopModeButton"
        ShopModeButton.Size = New Size(197, 49)
        ShopModeButton.TabIndex = 3
        ShopModeButton.Text = "Shop Mode"
        ShopModeButton.UseVisualStyleBackColor = False
        ' 
        ' EditModeButton
        ' 
        EditModeButton.BackColor = Color.White
        EditModeButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        EditModeButton.ForeColor = SystemColors.ControlText
        EditModeButton.Location = New Point(52, 356)
        EditModeButton.Name = "EditModeButton"
        EditModeButton.Size = New Size(197, 49)
        EditModeButton.TabIndex = 5
        EditModeButton.Text = "Edit Mode"
        EditModeButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteButton
        ' 
        DeleteButton.BackColor = Color.White
        DeleteButton.Enabled = False
        DeleteButton.ForeColor = Color.Red
        DeleteButton.Location = New Point(598, 11)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(98, 41)
        DeleteButton.TabIndex = 21
        DeleteButton.Text = "Delete On Click"
        DeleteButton.UseVisualStyleBackColor = False
        ' 
        ' AddButton
        ' 
        AddButton.BackColor = Color.White
        AddButton.Enabled = False
        AddButton.ForeColor = Color.Green
        AddButton.Location = New Point(328, 11)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(98, 41)
        AddButton.TabIndex = 20
        AddButton.Text = "Add New Item"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' StopDeleteButton
        ' 
        StopDeleteButton.BackColor = Color.White
        StopDeleteButton.Enabled = False
        StopDeleteButton.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        StopDeleteButton.ForeColor = Color.Red
        StopDeleteButton.Location = New Point(702, 11)
        StopDeleteButton.Name = "StopDeleteButton"
        StopDeleteButton.Size = New Size(98, 41)
        StopDeleteButton.TabIndex = 22
        StopDeleteButton.Text = "Stop Delete"
        StopDeleteButton.UseVisualStyleBackColor = False
        ' 
        ' ShopperNameLabel
        ' 
        ShopperNameLabel.AutoSize = True
        ShopperNameLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ShopperNameLabel.Location = New Point(517, 88)
        ShopperNameLabel.Name = "ShopperNameLabel"
        ShopperNameLabel.Size = New Size(163, 15)
        ShopperNameLabel.TabIndex = 23
        ShopperNameLabel.Text = "Name of Assigned Shopper: "
        ' 
        ' purposeLabel
        ' 
        purposeLabel.AutoSize = True
        purposeLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        purposeLabel.Location = New Point(517, 137)
        purposeLabel.Name = "purposeLabel"
        purposeLabel.Size = New Size(58, 15)
        purposeLabel.TabIndex = 25
        purposeLabel.Text = "Purpose: "
        ' 
        ' shoppingDateLabel
        ' 
        shoppingDateLabel.AutoSize = True
        shoppingDateLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        shoppingDateLabel.Location = New Point(517, 113)
        shoppingDateLabel.Name = "shoppingDateLabel"
        shoppingDateLabel.Size = New Size(158, 15)
        shoppingDateLabel.TabIndex = 24
        shoppingDateLabel.Text = "Shopping Date/Frequency: "
        ' 
        ' CurrentModePictureBox
        ' 
        CurrentModePictureBox.Image = CType(resources.GetObject("CurrentModePictureBox.Image"), Image)
        CurrentModePictureBox.Location = New Point(340, 334)
        CurrentModePictureBox.Name = "CurrentModePictureBox"
        CurrentModePictureBox.Size = New Size(137, 95)
        CurrentModePictureBox.TabIndex = 26
        CurrentModePictureBox.TabStop = False
        ' 
        ' AdjustButton
        ' 
        AdjustButton.BackColor = Color.White
        AdjustButton.Enabled = False
        AdjustButton.ForeColor = Color.Green
        AdjustButton.Location = New Point(432, 11)
        AdjustButton.Name = "AdjustButton"
        AdjustButton.Size = New Size(98, 41)
        AdjustButton.TabIndex = 27
        AdjustButton.Text = "Adjust List"
        AdjustButton.UseVisualStyleBackColor = False
        ' 
        ' GroceryListMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(AdjustButton)
        Controls.Add(CurrentModePictureBox)
        Controls.Add(purposeLabel)
        Controls.Add(shoppingDateLabel)
        Controls.Add(ShopperNameLabel)
        Controls.Add(StopDeleteButton)
        Controls.Add(DeleteButton)
        Controls.Add(AddButton)
        Controls.Add(EditModeButton)
        Controls.Add(ShopModeButton)
        Controls.Add(BackButton)
        Controls.Add(GroceryListNameLabel)
        Name = "GroceryListMenu"
        Size = New Size(804, 451)
        CType(CurrentModePictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroceryListNameLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents ShopModeButton As Button
    Friend WithEvents EditModeButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents StopDeleteButton As Button
    Friend WithEvents ShopperNameLabel As Label
    Friend WithEvents purposeLabel As Label
    Friend WithEvents shoppingDateLabel As Label
    Friend WithEvents CurrentModePictureBox As PictureBox
    Friend WithEvents AdjustButton As Button

End Class
