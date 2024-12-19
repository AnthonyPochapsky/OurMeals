<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recipeSelectionForm
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
        RadioButton1 = New RadioButton()
        CreateButton = New Button()
        servingsTextBox = New TextBox()
        Label2 = New Label()
        Label6 = New Label()
        CloseButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 15)
        Label1.TabIndex = 0
        Label1.Text = "Select the recipe to use:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(12, 47)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(225, 19)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "Tomato and Apple Pasta Sauce Recipe"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' CreateButton
        ' 
        CreateButton.Location = New Point(216, 144)
        CreateButton.Name = "CreateButton"
        CreateButton.Size = New Size(75, 23)
        CreateButton.TabIndex = 4
        CreateButton.Text = "Create"
        CreateButton.UseVisualStyleBackColor = True
        ' 
        ' servingsTextBox
        ' 
        servingsTextBox.Location = New Point(12, 114)
        servingsTextBox.Name = "servingsTextBox"
        servingsTextBox.Size = New Size(178, 23)
        servingsTextBox.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 11
        Label2.Text = "Servings:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(63, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(12, 15)
        Label6.TabIndex = 19
        Label6.Text = "*"
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(25, 144)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(75, 23)
        CloseButton.TabIndex = 20
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' recipeSelectionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(303, 179)
        ControlBox = False
        Controls.Add(CloseButton)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(servingsTextBox)
        Controls.Add(CreateButton)
        Controls.Add(RadioButton1)
        Controls.Add(Label1)
        Name = "recipeSelectionForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "recipeSelectionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents CreateButton As Button
    Friend WithEvents servingsTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CloseButton As Button
End Class
