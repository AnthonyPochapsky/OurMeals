<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdjustSpecificListForm
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
        CloseButton = New Button()
        AdjustButton = New Button()
        Label1 = New Label()
        BasedOnCurrentSuppliesButton = New RadioButton()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(41, 118)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(75, 23)
        CloseButton.TabIndex = 8
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' AdjustButton
        ' 
        AdjustButton.Location = New Point(286, 118)
        AdjustButton.Name = "AdjustButton"
        AdjustButton.Size = New Size(75, 23)
        AdjustButton.TabIndex = 7
        AdjustButton.Text = "Adjust"
        AdjustButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 15)
        Label1.TabIndex = 9
        Label1.Text = "Choose the method of adjusting this list:"
        ' 
        ' BasedOnCurrentSuppliesButton
        ' 
        BasedOnCurrentSuppliesButton.AutoSize = True
        BasedOnCurrentSuppliesButton.Checked = True
        BasedOnCurrentSuppliesButton.Location = New Point(12, 54)
        BasedOnCurrentSuppliesButton.Name = "BasedOnCurrentSuppliesButton"
        BasedOnCurrentSuppliesButton.Size = New Size(200, 19)
        BasedOnCurrentSuppliesButton.TabIndex = 10
        BasedOnCurrentSuppliesButton.TabStop = True
        BasedOnCurrentSuppliesButton.Text = "Adjust based on current supplies "
        BasedOnCurrentSuppliesButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(424, 15)
        Label2.TabIndex = 11
        Label2.Text = "(remove items from the list that are already contained in the fridge by quantity)"
        ' 
        ' AdjustSpecificListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(464, 165)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(BasedOnCurrentSuppliesButton)
        Controls.Add(Label1)
        Controls.Add(CloseButton)
        Controls.Add(AdjustButton)
        Name = "AdjustSpecificListForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Adjust Shopping List"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents AdjustButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BasedOnCurrentSuppliesButton As RadioButton
    Friend WithEvents Label2 As Label
End Class
