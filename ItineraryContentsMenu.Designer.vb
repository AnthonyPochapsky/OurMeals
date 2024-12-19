<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItineraryContentsMenu
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
        ItineraryNameLabel = New Label()
        BackButton = New Button()
        SplitItineraryButton = New Button()
        AppleItemBox = New RichTextBox()
        TomatoItemBox = New RichTextBox()
        ConvertItineraryButton = New Button()
        SuspendLayout()
        ' 
        ' ItineraryNameLabel
        ' 
        ItineraryNameLabel.AutoSize = True
        ItineraryNameLabel.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        ItineraryNameLabel.Location = New Point(295, 19)
        ItineraryNameLabel.Name = "ItineraryNameLabel"
        ItineraryNameLabel.Size = New Size(0, 30)
        ItineraryNameLabel.TabIndex = 1
        ' 
        ' BackButton
        ' 
        BackButton.BackColor = Color.White
        BackButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        BackButton.Location = New Point(15, 11)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(251, 41)
        BackButton.TabIndex = 2
        BackButton.Text = "Back To Shopping Lists"
        BackButton.UseVisualStyleBackColor = False
        ' 
        ' SplitItineraryButton
        ' 
        SplitItineraryButton.BackColor = Color.White
        SplitItineraryButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        SplitItineraryButton.Location = New Point(429, 339)
        SplitItineraryButton.Name = "SplitItineraryButton"
        SplitItineraryButton.Size = New Size(320, 77)
        SplitItineraryButton.TabIndex = 30
        SplitItineraryButton.Text = "Split itinerary into multiple shopping lists for each store"
        SplitItineraryButton.UseVisualStyleBackColor = False
        ' 
        ' AppleItemBox
        ' 
        AppleItemBox.BackColor = Color.White
        AppleItemBox.Location = New Point(114, 163)
        AppleItemBox.Name = "AppleItemBox"
        AppleItemBox.ReadOnly = True
        AppleItemBox.ScrollBars = RichTextBoxScrollBars.None
        AppleItemBox.Size = New Size(222, 60)
        AppleItemBox.TabIndex = 31
        AppleItemBox.Text = "Apple, WholeFoods, $1.20"
        ' 
        ' TomatoItemBox
        ' 
        TomatoItemBox.BackColor = Color.White
        TomatoItemBox.Location = New Point(429, 163)
        TomatoItemBox.Name = "TomatoItemBox"
        TomatoItemBox.ReadOnly = True
        TomatoItemBox.Size = New Size(222, 60)
        TomatoItemBox.TabIndex = 32
        TomatoItemBox.Text = "Tomato, FarmBoy, $1.10"
        ' 
        ' ConvertItineraryButton
        ' 
        ConvertItineraryButton.BackColor = Color.White
        ConvertItineraryButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        ConvertItineraryButton.Location = New Point(61, 339)
        ConvertItineraryButton.Name = "ConvertItineraryButton"
        ConvertItineraryButton.Size = New Size(320, 77)
        ConvertItineraryButton.TabIndex = 33
        ConvertItineraryButton.Text = "Convert itinerary into a single shopping list for all stores"
        ConvertItineraryButton.UseVisualStyleBackColor = False
        ' 
        ' ItineraryContentsMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ConvertItineraryButton)
        Controls.Add(TomatoItemBox)
        Controls.Add(AppleItemBox)
        Controls.Add(SplitItineraryButton)
        Controls.Add(BackButton)
        Controls.Add(ItineraryNameLabel)
        Name = "ItineraryContentsMenu"
        Size = New Size(804, 451)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ItineraryNameLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents SplitItineraryButton As Button
    Friend WithEvents AppleItemBox As RichTextBox
    Friend WithEvents TomatoItemBox As RichTextBox
    Friend WithEvents ConvertItineraryButton As Button

End Class
