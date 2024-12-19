<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventorySupply
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
        SupplyImage = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        NameLabel = New Label()
        QuantityLabel = New Label()
        CategoryLabel = New Label()
        Label4 = New Label()
        BrandLabel = New Label()
        CType(SupplyImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SupplyImage
        ' 
        SupplyImage.Enabled = False
        SupplyImage.Location = New Point(0, 0)
        SupplyImage.Name = "SupplyImage"
        SupplyImage.Size = New Size(150, 150)
        SupplyImage.TabIndex = 22
        SupplyImage.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Enabled = False
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 23
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Enabled = False
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(12, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 24
        Label2.Text = "Quantity:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Enabled = False
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(12, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 25
        Label3.Text = "Category:"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.BackColor = Color.Transparent
        NameLabel.Enabled = False
        NameLabel.ForeColor = Color.Black
        NameLabel.Location = New Point(60, 24)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(0, 15)
        NameLabel.TabIndex = 26
        ' 
        ' QuantityLabel
        ' 
        QuantityLabel.AutoSize = True
        QuantityLabel.BackColor = Color.Transparent
        QuantityLabel.Enabled = False
        QuantityLabel.ForeColor = Color.Black
        QuantityLabel.Location = New Point(74, 52)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New Size(13, 15)
        QuantityLabel.TabIndex = 27
        QuantityLabel.Text = "0"
        ' 
        ' CategoryLabel
        ' 
        CategoryLabel.AutoSize = True
        CategoryLabel.BackColor = Color.Transparent
        CategoryLabel.Enabled = False
        CategoryLabel.ForeColor = Color.Black
        CategoryLabel.Location = New Point(76, 78)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New Size(0, 15)
        CategoryLabel.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Enabled = False
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(12, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 29
        Label4.Text = "Brand:"
        ' 
        ' BrandLabel
        ' 
        BrandLabel.AutoSize = True
        BrandLabel.BackColor = Color.Transparent
        BrandLabel.Enabled = False
        BrandLabel.ForeColor = Color.Black
        BrandLabel.Location = New Point(59, 102)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New Size(72, 15)
        BrandLabel.TabIndex = 30
        BrandLabel.Text = "Farm Grown"
        ' 
        ' InventorySupply
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BrandLabel)
        Controls.Add(Label4)
        Controls.Add(CategoryLabel)
        Controls.Add(QuantityLabel)
        Controls.Add(NameLabel)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(SupplyImage)
        Name = "InventorySupply"
        Size = New Size(151, 155)
        CType(SupplyImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SupplyImage As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BrandLabel As Label

End Class
