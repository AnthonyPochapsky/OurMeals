<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmPurchaseForm
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
        NameOfItem = New Label()
        AreYouSureLabel = New Label()
        NoButton = New Button()
        YesButton = New Button()
        SuspendLayout()
        ' 
        ' NameOfItem
        ' 
        NameOfItem.AutoSize = True
        NameOfItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        NameOfItem.Location = New Point(16, 53)
        NameOfItem.Name = "NameOfItem"
        NameOfItem.Size = New Size(0, 21)
        NameOfItem.TabIndex = 13
        ' 
        ' AreYouSureLabel
        ' 
        AreYouSureLabel.AutoSize = True
        AreYouSureLabel.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AreYouSureLabel.Location = New Point(12, 23)
        AreYouSureLabel.Name = "AreYouSureLabel"
        AreYouSureLabel.Size = New Size(293, 15)
        AreYouSureLabel.TabIndex = 12
        AreYouSureLabel.Text = "Are you sure you want to purchase the following item:"
        ' 
        ' NoButton
        ' 
        NoButton.Location = New Point(16, 90)
        NoButton.Name = "NoButton"
        NoButton.Size = New Size(75, 23)
        NoButton.TabIndex = 11
        NoButton.Text = "No"
        NoButton.UseVisualStyleBackColor = True
        ' 
        ' YesButton
        ' 
        YesButton.Location = New Point(124, 90)
        YesButton.Name = "YesButton"
        YesButton.Size = New Size(75, 23)
        YesButton.TabIndex = 10
        YesButton.Text = "Yes"
        YesButton.UseVisualStyleBackColor = True
        ' 
        ' ConfirmPurchaseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(365, 134)
        ControlBox = False
        Controls.Add(NameOfItem)
        Controls.Add(AreYouSureLabel)
        Controls.Add(NoButton)
        Controls.Add(YesButton)
        Name = "ConfirmPurchaseForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Confirm Item Purchase "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NameOfItem As Label
    Friend WithEvents AreYouSureLabel As Label
    Friend WithEvents NoButton As Button
    Friend WithEvents YesButton As Button
End Class
