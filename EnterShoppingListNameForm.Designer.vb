<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterShoppingListNameForm
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
        NameTextBox = New TextBox()
        ConfirmButton = New Button()
        CloseButton = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(345, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter the name of the shopping list you want to add items from:"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(12, 37)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(280, 23)
        NameTextBox.TabIndex = 1
        ' 
        ' ConfirmButton
        ' 
        ConfirmButton.Location = New Point(217, 71)
        ConfirmButton.Name = "ConfirmButton"
        ConfirmButton.Size = New Size(75, 23)
        ConfirmButton.TabIndex = 5
        ConfirmButton.Text = "Confirm"
        ConfirmButton.UseVisualStyleBackColor = True
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(12, 71)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(75, 23)
        CloseButton.TabIndex = 6
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(354, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(12, 15)
        Label6.TabIndex = 15
        Label6.Text = "*"
        ' 
        ' EnterShoppingListNameForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 106)
        ControlBox = False
        Controls.Add(Label6)
        Controls.Add(CloseButton)
        Controls.Add(ConfirmButton)
        Controls.Add(NameTextBox)
        Controls.Add(Label1)
        Name = "EnterShoppingListNameForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "EnterShoppingListNameForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label6 As Label
End Class
