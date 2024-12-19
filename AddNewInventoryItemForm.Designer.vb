<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewInventoryItemForm
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
        AppleButton = New RadioButton()
        TomatoButton = New RadioButton()
        AddButton = New Button()
        CloseButton = New Button()
        LeekButton = New RadioButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 15)
        Label1.TabIndex = 0
        Label1.Text = "Select the item that you wish to add:"
        ' 
        ' AppleButton
        ' 
        AppleButton.AutoSize = True
        AppleButton.Location = New Point(28, 27)
        AppleButton.Name = "AppleButton"
        AppleButton.Size = New Size(81, 19)
        AppleButton.TabIndex = 1
        AppleButton.TabStop = True
        AppleButton.Text = "Add Apple"
        AppleButton.UseVisualStyleBackColor = True
        ' 
        ' TomatoButton
        ' 
        TomatoButton.AutoSize = True
        TomatoButton.Location = New Point(28, 52)
        TomatoButton.Name = "TomatoButton"
        TomatoButton.Size = New Size(90, 19)
        TomatoButton.TabIndex = 2
        TomatoButton.TabStop = True
        TomatoButton.Text = "Add Tomato"
        TomatoButton.UseVisualStyleBackColor = True
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(144, 113)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(75, 23)
        AddButton.TabIndex = 3
        AddButton.Text = "Add"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(28, 113)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(75, 23)
        CloseButton.TabIndex = 4
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' LeekButton
        ' 
        LeekButton.AutoSize = True
        LeekButton.Location = New Point(28, 77)
        LeekButton.Name = "LeekButton"
        LeekButton.Size = New Size(74, 19)
        LeekButton.TabIndex = 5
        LeekButton.TabStop = True
        LeekButton.Text = "Add Leek"
        LeekButton.UseVisualStyleBackColor = True
        ' 
        ' AddNewInventoryItemForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(231, 162)
        ControlBox = False
        Controls.Add(LeekButton)
        Controls.Add(CloseButton)
        Controls.Add(AddButton)
        Controls.Add(TomatoButton)
        Controls.Add(AppleButton)
        Controls.Add(Label1)
        Name = "AddNewInventoryItemForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Add To Inventory"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AppleButton As RadioButton
    Friend WithEvents TomatoButton As RadioButton
    Friend WithEvents AddButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents LeekButton As RadioButton
End Class
