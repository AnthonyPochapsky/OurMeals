<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontPage
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
        Logo = New Label()
        StartButton = New Button()
        OurMealsIcon = New PictureBox()
        CType(OurMealsIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Logo
        ' 
        Logo.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Logo.Location = New Point(285, 19)
        Logo.Name = "Logo"
        Logo.Size = New Size(217, 80)
        Logo.TabIndex = 0
        Logo.Text = "OurMeals"
        ' 
        ' StartButton
        ' 
        StartButton.BackColor = Color.White
        StartButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        StartButton.Location = New Point(275, 308)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(227, 78)
        StartButton.TabIndex = 1
        StartButton.Text = "Start Application"
        StartButton.UseVisualStyleBackColor = False
        ' 
        ' OurMealsIcon
        ' 
        OurMealsIcon.Location = New Point(285, 86)
        OurMealsIcon.Name = "OurMealsIcon"
        OurMealsIcon.Size = New Size(261, 189)
        OurMealsIcon.TabIndex = 2
        OurMealsIcon.TabStop = False
        ' 
        ' FrontPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(OurMealsIcon)
        Controls.Add(StartButton)
        Controls.Add(Logo)
        Name = "FrontPage"
        Size = New Size(804, 451)
        CType(OurMealsIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Logo As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents OurMealsIcon As PictureBox

End Class
