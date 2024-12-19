<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmRoutineForm
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
        NameOfListLabel = New Label()
        AreYouSureLabel = New Label()
        NoButton = New Button()
        YesButton = New Button()
        SuspendLayout()
        ' 
        ' NameOfListLabel
        ' 
        NameOfListLabel.AutoSize = True
        NameOfListLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        NameOfListLabel.Location = New Point(16, 39)
        NameOfListLabel.Name = "NameOfListLabel"
        NameOfListLabel.Size = New Size(0, 21)
        NameOfListLabel.TabIndex = 13
        ' 
        ' AreYouSureLabel
        ' 
        AreYouSureLabel.AutoSize = True
        AreYouSureLabel.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AreYouSureLabel.Location = New Point(12, 9)
        AreYouSureLabel.Name = "AreYouSureLabel"
        AreYouSureLabel.Size = New Size(381, 15)
        AreYouSureLabel.TabIndex = 12
        AreYouSureLabel.Text = "Are you sure that you want to make the following list into a routine list:" & vbCrLf
        ' 
        ' NoButton
        ' 
        NoButton.Location = New Point(16, 96)
        NoButton.Name = "NoButton"
        NoButton.Size = New Size(75, 23)
        NoButton.TabIndex = 11
        NoButton.Text = "No"
        NoButton.UseVisualStyleBackColor = True
        ' 
        ' YesButton
        ' 
        YesButton.Location = New Point(124, 96)
        YesButton.Name = "YesButton"
        YesButton.Size = New Size(75, 23)
        YesButton.TabIndex = 10
        YesButton.Text = "Yes"
        YesButton.UseVisualStyleBackColor = True
        ' 
        ' ConfirmRoutineForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(401, 134)
        ControlBox = False
        Controls.Add(NameOfListLabel)
        Controls.Add(AreYouSureLabel)
        Controls.Add(NoButton)
        Controls.Add(YesButton)
        Name = "ConfirmRoutineForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Confirm Making List Routine"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NameOfListLabel As Label
    Friend WithEvents AreYouSureLabel As Label
    Friend WithEvents NoButton As Button
    Friend WithEvents YesButton As Button
End Class
