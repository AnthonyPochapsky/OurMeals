<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OurMealsMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OurMealsMainForm))
        GroceryListManagementMenu = New GroceryListManagementMenu()
        MainMenu = New MainMenu()
        FrontPage = New FrontPage()
        InventoryMenu = New InventoryMenu()
        SalesMenu = New SalesMenu()
        SalesMenu_ = New SalesMenu()
        RecipeMenu = New RecipeMenu()
        NotificationBar = New StatusStrip()
        notificationMsg = New ToolStripStatusLabel()
        NotificationBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroceryListManagementMenu
        ' 
        GroceryListManagementMenu.Location = New Point(0, 0)
        GroceryListManagementMenu.Name = "GroceryListManagementMenu"
        GroceryListManagementMenu.Size = New Size(804, 451)
        GroceryListManagementMenu.TabIndex = 0
        ' 
        ' MainMenu
        ' 
        MainMenu.Location = New Point(0, 0)
        MainMenu.Name = "MainMenu"
        MainMenu.Size = New Size(804, 451)
        MainMenu.TabIndex = 1
        ' 
        ' FrontPage
        ' 
        FrontPage.Location = New Point(0, 0)
        FrontPage.Name = "FrontPage"
        FrontPage.Size = New Size(804, 451)
        FrontPage.TabIndex = 2
        ' 
        ' InventoryMenu
        ' 
        InventoryMenu.Location = New Point(0, 0)
        InventoryMenu.Name = "InventoryMenu"
        InventoryMenu.Size = New Size(804, 451)
        InventoryMenu.TabIndex = 3
        InventoryMenu.Visible = False
        ' 
        ' SalesMenu
        ' 
        SalesMenu.Location = New Point(0, 0)
        SalesMenu.Name = "SalesMenu"
        SalesMenu.Size = New Size(804, 451)
        SalesMenu.TabIndex = 4
        SalesMenu.Visible = False
        ' 
        ' SalesMenu_
        ' 
        SalesMenu_.Location = New Point(0, 0)
        SalesMenu_.Name = "SalesMenu_"
        SalesMenu_.Size = New Size(804, 451)
        SalesMenu_.TabIndex = 5
        SalesMenu_.Visible = False
        ' 
        ' RecipeMenu
        ' 
        RecipeMenu.Location = New Point(0, 0)
        RecipeMenu.Name = "RecipeMenu"
        RecipeMenu.Size = New Size(804, 451)
        RecipeMenu.TabIndex = 6
        RecipeMenu.Visible = False
        ' 
        ' NotificationBar
        ' 
        NotificationBar.Items.AddRange(New ToolStripItem() {notificationMsg})
        NotificationBar.Location = New Point(0, 428)
        NotificationBar.Name = "NotificationBar"
        NotificationBar.Size = New Size(800, 22)
        NotificationBar.TabIndex = 7
        NotificationBar.Text = "fsafasg"
        NotificationBar.Visible = False
        ' 
        ' notificationMsg
        ' 
        notificationMsg.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        notificationMsg.Name = "notificationMsg"
        notificationMsg.Size = New Size(0, 17)
        ' 
        ' OurMealsMainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(NotificationBar)
        Controls.Add(RecipeMenu)
        Controls.Add(SalesMenu_)
        Controls.Add(SalesMenu)
        Controls.Add(InventoryMenu)
        Controls.Add(FrontPage)
        Controls.Add(MainMenu)
        Controls.Add(GroceryListManagementMenu)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "OurMealsMainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OurMeals"
        NotificationBar.ResumeLayout(False)
        NotificationBar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroceryListManagementMenu As GroceryListManagementMenu
    Friend WithEvents MainMenu As MainMenu
    Friend WithEvents FrontPage As FrontPage
    Friend WithEvents InventoryMenu As InventoryMenu
    Friend WithEvents SalesMenu As SalesMenu
    Friend WithEvents SalesMenu_ As SalesMenu
    Friend WithEvents RecipeMenu As RecipeMenu
    Friend WithEvents NotificationBar As StatusStrip
    Friend WithEvents notificationMsg As ToolStripStatusLabel

End Class
