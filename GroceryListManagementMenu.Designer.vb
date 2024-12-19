<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroceryListManagementMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroceryListManagementMenu))
        Label1 = New Label()
        BackToMainMenuButton = New Button()
        createNewListButton = New Button()
        Label3 = New Label()
        Label4 = New Label()
        EnableDeletionButton = New Button()
        MakeRoutineButton = New Button()
        DisableRemovalButton = New Button()
        DisableMakingRoutine = New Button()
        SeperatorBar = New PictureBox()
        ItineraryButton = New Button()
        DisableEditButton = New Button()
        EnableEditButton = New Button()
        CType(SeperatorBar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(293, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 45)
        Label1.TabIndex = 6
        Label1.Text = "Shopping Lists"
        ' 
        ' BackToMainMenuButton
        ' 
        BackToMainMenuButton.BackColor = Color.White
        BackToMainMenuButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        BackToMainMenuButton.Location = New Point(15, 11)
        BackToMainMenuButton.Name = "BackToMainMenuButton"
        BackToMainMenuButton.Size = New Size(198, 45)
        BackToMainMenuButton.TabIndex = 5
        BackToMainMenuButton.Text = "Back To Explorer"
        BackToMainMenuButton.UseVisualStyleBackColor = False
        ' 
        ' createNewListButton
        ' 
        createNewListButton.BackColor = Color.White
        createNewListButton.ForeColor = Color.Green
        createNewListButton.Location = New Point(35, 168)
        createNewListButton.Name = "createNewListButton"
        createNewListButton.Size = New Size(50, 46)
        createNewListButton.TabIndex = 4
        createNewListButton.Text = "Create New"
        createNewListButton.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(154, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 30)
        Label3.TabIndex = 8
        Label3.Text = "Created Lists"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(601, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 30)
        Label4.TabIndex = 9
        Label4.Text = "Created Itineraries"
        ' 
        ' EnableDeletionButton
        ' 
        EnableDeletionButton.BackColor = Color.White
        EnableDeletionButton.ForeColor = Color.Red
        EnableDeletionButton.Location = New Point(409, 213)
        EnableDeletionButton.Name = "EnableDeletionButton"
        EnableDeletionButton.Size = New Size(160, 23)
        EnableDeletionButton.TabIndex = 10
        EnableDeletionButton.Text = "Enable Deletion On Click"
        EnableDeletionButton.UseVisualStyleBackColor = False
        ' 
        ' MakeRoutineButton
        ' 
        MakeRoutineButton.BackColor = Color.White
        MakeRoutineButton.ForeColor = Color.Blue
        MakeRoutineButton.Location = New Point(409, 132)
        MakeRoutineButton.Name = "MakeRoutineButton"
        MakeRoutineButton.Size = New Size(160, 23)
        MakeRoutineButton.TabIndex = 11
        MakeRoutineButton.Text = "Enable Routine On Click"
        MakeRoutineButton.UseVisualStyleBackColor = False
        ' 
        ' DisableRemovalButton
        ' 
        DisableRemovalButton.BackColor = Color.White
        DisableRemovalButton.Enabled = False
        DisableRemovalButton.ForeColor = Color.Red
        DisableRemovalButton.Location = New Point(409, 238)
        DisableRemovalButton.Name = "DisableRemovalButton"
        DisableRemovalButton.Size = New Size(160, 23)
        DisableRemovalButton.TabIndex = 12
        DisableRemovalButton.Text = "Disable Deletion On Click"
        DisableRemovalButton.UseVisualStyleBackColor = False
        ' 
        ' DisableMakingRoutine
        ' 
        DisableMakingRoutine.BackColor = Color.White
        DisableMakingRoutine.Enabled = False
        DisableMakingRoutine.ForeColor = Color.Blue
        DisableMakingRoutine.Location = New Point(409, 161)
        DisableMakingRoutine.Name = "DisableMakingRoutine"
        DisableMakingRoutine.Size = New Size(160, 23)
        DisableMakingRoutine.TabIndex = 13
        DisableMakingRoutine.Text = "Disable Routine On Click"
        DisableMakingRoutine.UseVisualStyleBackColor = False
        ' 
        ' SeperatorBar
        ' 
        SeperatorBar.Image = CType(resources.GetObject("SeperatorBar.Image"), Image)
        SeperatorBar.Location = New Point(580, 99)
        SeperatorBar.Name = "SeperatorBar"
        SeperatorBar.Size = New Size(15, 329)
        SeperatorBar.TabIndex = 14
        SeperatorBar.TabStop = False
        ' 
        ' ItineraryButton
        ' 
        ItineraryButton.BackColor = Color.White
        ItineraryButton.Location = New Point(637, 149)
        ItineraryButton.Name = "ItineraryButton"
        ItineraryButton.Size = New Size(141, 75)
        ItineraryButton.TabIndex = 15
        ItineraryButton.Text = "WholeFoods and FarmBoy Shopping Itinerary"
        ItineraryButton.UseVisualStyleBackColor = False
        ItineraryButton.Visible = False
        ' 
        ' DisableEditButton
        ' 
        DisableEditButton.BackColor = Color.White
        DisableEditButton.Enabled = False
        DisableEditButton.ForeColor = Color.Green
        DisableEditButton.Location = New Point(409, 316)
        DisableEditButton.Name = "DisableEditButton"
        DisableEditButton.Size = New Size(160, 23)
        DisableEditButton.TabIndex = 17
        DisableEditButton.Text = "Disable Edit List On Click"
        DisableEditButton.UseVisualStyleBackColor = False
        ' 
        ' EnableEditButton
        ' 
        EnableEditButton.BackColor = Color.White
        EnableEditButton.ForeColor = Color.Green
        EnableEditButton.Location = New Point(409, 287)
        EnableEditButton.Name = "EnableEditButton"
        EnableEditButton.Size = New Size(160, 23)
        EnableEditButton.TabIndex = 16
        EnableEditButton.Text = "Enable Edit List On Click"
        EnableEditButton.UseVisualStyleBackColor = False
        ' 
        ' GroceryListManagementMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DisableEditButton)
        Controls.Add(EnableEditButton)
        Controls.Add(ItineraryButton)
        Controls.Add(SeperatorBar)
        Controls.Add(DisableMakingRoutine)
        Controls.Add(DisableRemovalButton)
        Controls.Add(MakeRoutineButton)
        Controls.Add(EnableDeletionButton)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(BackToMainMenuButton)
        Controls.Add(createNewListButton)
        Name = "GroceryListManagementMenu"
        Size = New Size(804, 451)
        CType(SeperatorBar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BackToMainMenuButton As Button
    Friend WithEvents createNewListButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EnableDeletionButton As Button
    Friend WithEvents MakeRoutineButton As Button
    Friend WithEvents DisableRemovalButton As Button
    Friend WithEvents DisableMakingRoutine As Button
    Friend WithEvents SeperatorBar As PictureBox
    Friend WithEvents ItineraryButton As Button
    Friend WithEvents DisableEditButton As Button
    Friend WithEvents EnableEditButton As Button

End Class
