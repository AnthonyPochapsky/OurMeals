<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyInventorySupplyForm
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
        BrandTextBox = New TextBox()
        Label1 = New Label()
        SupplyNameTextBox = New TextBox()
        CloseButton = New Button()
        ModifyButton = New Button()
        Label6 = New Label()
        Label2 = New Label()
        QuantityTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 18
        Label3.Text = "Rename the brand:"
        ' 
        ' BrandTextBox
        ' 
        BrandTextBox.Location = New Point(12, 117)
        BrandTextBox.Name = "BrandTextBox"
        BrandTextBox.Size = New Size(178, 23)
        BrandTextBox.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 15)
        Label1.TabIndex = 16
        Label1.Text = "Enter the name of the supply you want to update:"
        ' 
        ' SupplyNameTextBox
        ' 
        SupplyNameTextBox.Location = New Point(12, 38)
        SupplyNameTextBox.Name = "SupplyNameTextBox"
        SupplyNameTextBox.Size = New Size(178, 23)
        SupplyNameTextBox.TabIndex = 15
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(12, 232)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(75, 23)
        CloseButton.TabIndex = 21
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' ModifyButton
        ' 
        ModifyButton.Location = New Point(184, 232)
        ModifyButton.Name = "ModifyButton"
        ModifyButton.Size = New Size(75, 23)
        ModifyButton.TabIndex = 20
        ModifyButton.Text = "Modify"
        ModifyButton.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(277, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(12, 15)
        Label6.TabIndex = 19
        Label6.Text = "*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(177, 15)
        Label2.TabIndex = 23
        Label2.Text = "Update The Quantity Contained:"
        ' 
        ' QuantityTextBox
        ' 
        QuantityTextBox.Location = New Point(12, 190)
        QuantityTextBox.Name = "QuantityTextBox"
        QuantityTextBox.Size = New Size(178, 23)
        QuantityTextBox.TabIndex = 22
        ' 
        ' ModifyInventorySupplyForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(358, 276)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(QuantityTextBox)
        Controls.Add(CloseButton)
        Controls.Add(ModifyButton)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(BrandTextBox)
        Controls.Add(Label1)
        Controls.Add(SupplyNameTextBox)
        Name = "ModifyInventorySupplyForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "ModifyInventorySupplyForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents BrandTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SupplyNameTextBox As TextBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents ModifyButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents QuantityTextBox As TextBox
End Class
