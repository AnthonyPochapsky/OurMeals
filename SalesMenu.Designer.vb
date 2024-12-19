<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesMenu))
        Label1 = New Label()
        BackToMainMenuButton = New Button()
        AppleSaleImage1 = New PictureBox()
        TomatoSaleImage1 = New PictureBox()
        SaleLabel1 = New Label()
        SaleLabel2 = New Label()
        WholeFoodsLabel = New Label()
        FarmBoyLabel = New Label()
        CreateItineraryButton = New Button()
        PriceLabel1 = New Label()
        PriceLabel2 = New Label()
        PriceLabel3 = New Label()
        NoFrillsLabel = New Label()
        SaleLabel3 = New Label()
        AppleSaleImage2 = New PictureBox()
        OriginalPriceLabel1 = New Label()
        OriginalPriceLabel2 = New Label()
        OriginalPriceLabel3 = New Label()
        HouseholdQuantityLabel1 = New Label()
        HouseholdQuantityLabel2 = New Label()
        HouseholdQuantityLabel3 = New Label()
        QuantityLabel1 = New Label()
        QuantityLabel2 = New Label()
        QuantityLabel3 = New Label()
        HouseHoldQuantityLabel4 = New Label()
        OriginalPriceLabel4 = New Label()
        PriceLabel4 = New Label()
        FarmBoyLabel2 = New Label()
        SaleLabel4 = New Label()
        LeekSaleImage = New PictureBox()
        QuantityLabel4 = New Label()
        CType(AppleSaleImage1, ComponentModel.ISupportInitialize).BeginInit()
        CType(TomatoSaleImage1, ComponentModel.ISupportInitialize).BeginInit()
        CType(AppleSaleImage2, ComponentModel.ISupportInitialize).BeginInit()
        CType(LeekSaleImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(223, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(531, 45)
        Label1.TabIndex = 8
        Label1.Text = "Special Nearby Sales for Food Items"
        ' 
        ' BackToMainMenuButton
        ' 
        BackToMainMenuButton.BackColor = Color.White
        BackToMainMenuButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        BackToMainMenuButton.Location = New Point(15, 11)
        BackToMainMenuButton.Name = "BackToMainMenuButton"
        BackToMainMenuButton.Size = New Size(198, 45)
        BackToMainMenuButton.TabIndex = 9
        BackToMainMenuButton.Text = "Back To Explorer"
        BackToMainMenuButton.UseVisualStyleBackColor = False
        ' 
        ' AppleSaleImage1
        ' 
        AppleSaleImage1.Image = CType(resources.GetObject("AppleSaleImage1.Image"), Image)
        AppleSaleImage1.Location = New Point(74, 76)
        AppleSaleImage1.Name = "AppleSaleImage1"
        AppleSaleImage1.Size = New Size(103, 86)
        AppleSaleImage1.TabIndex = 23
        AppleSaleImage1.TabStop = False
        AppleSaleImage1.Visible = False
        ' 
        ' TomatoSaleImage1
        ' 
        TomatoSaleImage1.Image = CType(resources.GetObject("TomatoSaleImage1.Image"), Image)
        TomatoSaleImage1.Location = New Point(433, 76)
        TomatoSaleImage1.Name = "TomatoSaleImage1"
        TomatoSaleImage1.Size = New Size(103, 86)
        TomatoSaleImage1.TabIndex = 24
        TomatoSaleImage1.TabStop = False
        TomatoSaleImage1.Visible = False
        ' 
        ' SaleLabel1
        ' 
        SaleLabel1.AutoSize = True
        SaleLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SaleLabel1.ForeColor = Color.Green
        SaleLabel1.Location = New Point(74, 298)
        SaleLabel1.Name = "SaleLabel1"
        SaleLabel1.Size = New Size(170, 21)
        SaleLabel1.TabIndex = 25
        SaleLabel1.Text = "20% OFF Until the 21st"
        SaleLabel1.Visible = False
        ' 
        ' SaleLabel2
        ' 
        SaleLabel2.AutoSize = True
        SaleLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SaleLabel2.ForeColor = Color.Green
        SaleLabel2.Location = New Point(442, 291)
        SaleLabel2.Name = "SaleLabel2"
        SaleLabel2.Size = New Size(172, 21)
        SaleLabel2.TabIndex = 26
        SaleLabel2.Text = "25% OFF Until the 19th"
        SaleLabel2.Visible = False
        ' 
        ' WholeFoodsLabel
        ' 
        WholeFoodsLabel.AutoSize = True
        WholeFoodsLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        WholeFoodsLabel.ForeColor = Color.Black
        WholeFoodsLabel.Location = New Point(74, 172)
        WholeFoodsLabel.Name = "WholeFoodsLabel"
        WholeFoodsLabel.Size = New Size(167, 42)
        WholeFoodsLabel.TabIndex = 27
        WholeFoodsLabel.Text = "Whole Foods" & vbCrLf & "87 Avenue Rd, Toronto"
        WholeFoodsLabel.Visible = False
        ' 
        ' FarmBoyLabel
        ' 
        FarmBoyLabel.AutoSize = True
        FarmBoyLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FarmBoyLabel.ForeColor = Color.Black
        FarmBoyLabel.Location = New Point(433, 165)
        FarmBoyLabel.Name = "FarmBoyLabel"
        FarmBoyLabel.Size = New Size(147, 42)
        FarmBoyLabel.TabIndex = 28
        FarmBoyLabel.Text = "Farm Boy" & vbCrLf & "100 Queens Quay E"
        FarmBoyLabel.Visible = False
        ' 
        ' CreateItineraryButton
        ' 
        CreateItineraryButton.BackColor = Color.White
        CreateItineraryButton.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        CreateItineraryButton.Location = New Point(216, 358)
        CreateItineraryButton.Name = "CreateItineraryButton"
        CreateItineraryButton.Size = New Size(320, 77)
        CreateItineraryButton.TabIndex = 29
        CreateItineraryButton.Text = "Create Shopping Itinerary Out Of Selected Items"
        CreateItineraryButton.UseVisualStyleBackColor = False
        ' 
        ' PriceLabel1
        ' 
        PriceLabel1.AutoSize = True
        PriceLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PriceLabel1.ForeColor = Color.Red
        PriceLabel1.Location = New Point(74, 277)
        PriceLabel1.Name = "PriceLabel1"
        PriceLabel1.Size = New Size(123, 21)
        PriceLabel1.TabIndex = 30
        PriceLabel1.Text = "Sale Price: $1.20"
        PriceLabel1.Visible = False
        ' 
        ' PriceLabel2
        ' 
        PriceLabel2.AutoSize = True
        PriceLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PriceLabel2.ForeColor = Color.Red
        PriceLabel2.Location = New Point(442, 270)
        PriceLabel2.Name = "PriceLabel2"
        PriceLabel2.Size = New Size(123, 21)
        PriceLabel2.TabIndex = 31
        PriceLabel2.Text = "Sale Price: $1.10"
        PriceLabel2.Visible = False
        ' 
        ' PriceLabel3
        ' 
        PriceLabel3.AutoSize = True
        PriceLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PriceLabel3.ForeColor = Color.Red
        PriceLabel3.Location = New Point(253, 268)
        PriceLabel3.Name = "PriceLabel3"
        PriceLabel3.Size = New Size(123, 21)
        PriceLabel3.TabIndex = 35
        PriceLabel3.Text = "Sale Price: $1.30"
        PriceLabel3.Visible = False
        ' 
        ' NoFrillsLabel
        ' 
        NoFrillsLabel.AutoSize = True
        NoFrillsLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        NoFrillsLabel.ForeColor = Color.Black
        NoFrillsLabel.Location = New Point(253, 165)
        NoFrillsLabel.Name = "NoFrillsLabel"
        NoFrillsLabel.Size = New Size(107, 42)
        NoFrillsLabel.TabIndex = 34
        NoFrillsLabel.Text = "No Frills" & vbCrLf & "200 Front St E"
        NoFrillsLabel.Visible = False
        ' 
        ' SaleLabel3
        ' 
        SaleLabel3.AutoSize = True
        SaleLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SaleLabel3.ForeColor = Color.Green
        SaleLabel3.Location = New Point(253, 289)
        SaleLabel3.Name = "SaleLabel3"
        SaleLabel3.Size = New Size(172, 21)
        SaleLabel3.TabIndex = 33
        SaleLabel3.Text = "10% OFF Until the 25th"
        SaleLabel3.Visible = False
        ' 
        ' AppleSaleImage2
        ' 
        AppleSaleImage2.Image = CType(resources.GetObject("AppleSaleImage2.Image"), Image)
        AppleSaleImage2.Location = New Point(257, 76)
        AppleSaleImage2.Name = "AppleSaleImage2"
        AppleSaleImage2.Size = New Size(103, 86)
        AppleSaleImage2.TabIndex = 32
        AppleSaleImage2.TabStop = False
        AppleSaleImage2.Visible = False
        ' 
        ' OriginalPriceLabel1
        ' 
        OriginalPriceLabel1.AutoSize = True
        OriginalPriceLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        OriginalPriceLabel1.ForeColor = Color.Black
        OriginalPriceLabel1.Location = New Point(74, 224)
        OriginalPriceLabel1.Name = "OriginalPriceLabel1"
        OriginalPriceLabel1.Size = New Size(150, 21)
        OriginalPriceLabel1.TabIndex = 41
        OriginalPriceLabel1.Text = "Original Price: $1.50"
        OriginalPriceLabel1.Visible = False
        ' 
        ' OriginalPriceLabel2
        ' 
        OriginalPriceLabel2.AutoSize = True
        OriginalPriceLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        OriginalPriceLabel2.ForeColor = Color.Black
        OriginalPriceLabel2.Location = New Point(253, 215)
        OriginalPriceLabel2.Name = "OriginalPriceLabel2"
        OriginalPriceLabel2.Size = New Size(150, 21)
        OriginalPriceLabel2.TabIndex = 42
        OriginalPriceLabel2.Text = "Original Price: $1.44"
        OriginalPriceLabel2.Visible = False
        ' 
        ' OriginalPriceLabel3
        ' 
        OriginalPriceLabel3.AutoSize = True
        OriginalPriceLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        OriginalPriceLabel3.ForeColor = Color.Black
        OriginalPriceLabel3.Location = New Point(436, 217)
        OriginalPriceLabel3.Name = "OriginalPriceLabel3"
        OriginalPriceLabel3.Size = New Size(150, 21)
        OriginalPriceLabel3.TabIndex = 43
        OriginalPriceLabel3.Text = "Original Price: $1.29"
        OriginalPriceLabel3.Visible = False
        ' 
        ' HouseholdQuantityLabel1
        ' 
        HouseholdQuantityLabel1.AutoSize = True
        HouseholdQuantityLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HouseholdQuantityLabel1.ForeColor = Color.Black
        HouseholdQuantityLabel1.Location = New Point(74, 255)
        HouseholdQuantityLabel1.Name = "HouseholdQuantityLabel1"
        HouseholdQuantityLabel1.Size = New Size(156, 21)
        HouseholdQuantityLabel1.TabIndex = 44
        HouseholdQuantityLabel1.Text = "Household Quantity: "
        HouseholdQuantityLabel1.Visible = False
        ' 
        ' HouseholdQuantityLabel2
        ' 
        HouseholdQuantityLabel2.AutoSize = True
        HouseholdQuantityLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HouseholdQuantityLabel2.ForeColor = Color.Black
        HouseholdQuantityLabel2.Location = New Point(251, 247)
        HouseholdQuantityLabel2.Name = "HouseholdQuantityLabel2"
        HouseholdQuantityLabel2.Size = New Size(156, 21)
        HouseholdQuantityLabel2.TabIndex = 45
        HouseholdQuantityLabel2.Text = "Household Quantity: "
        HouseholdQuantityLabel2.Visible = False
        ' 
        ' HouseholdQuantityLabel3
        ' 
        HouseholdQuantityLabel3.AutoSize = True
        HouseholdQuantityLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HouseholdQuantityLabel3.ForeColor = Color.Black
        HouseholdQuantityLabel3.Location = New Point(436, 247)
        HouseholdQuantityLabel3.Name = "HouseholdQuantityLabel3"
        HouseholdQuantityLabel3.Size = New Size(156, 21)
        HouseholdQuantityLabel3.TabIndex = 46
        HouseholdQuantityLabel3.Text = "Household Quantity: "
        HouseholdQuantityLabel3.Visible = False
        ' 
        ' QuantityLabel1
        ' 
        QuantityLabel1.AutoSize = True
        QuantityLabel1.Location = New Point(228, 261)
        QuantityLabel1.Name = "QuantityLabel1"
        QuantityLabel1.Size = New Size(13, 15)
        QuantityLabel1.TabIndex = 47
        QuantityLabel1.Text = "1"
        QuantityLabel1.Visible = False
        ' 
        ' QuantityLabel2
        ' 
        QuantityLabel2.AutoSize = True
        QuantityLabel2.Location = New Point(403, 252)
        QuantityLabel2.Name = "QuantityLabel2"
        QuantityLabel2.Size = New Size(13, 15)
        QuantityLabel2.TabIndex = 48
        QuantityLabel2.Text = "1"
        QuantityLabel2.Visible = False
        ' 
        ' QuantityLabel3
        ' 
        QuantityLabel3.AutoSize = True
        QuantityLabel3.Location = New Point(588, 253)
        QuantityLabel3.Name = "QuantityLabel3"
        QuantityLabel3.Size = New Size(13, 15)
        QuantityLabel3.TabIndex = 49
        QuantityLabel3.Text = "1"
        QuantityLabel3.Visible = False
        ' 
        ' HouseHoldQuantityLabel4
        ' 
        HouseHoldQuantityLabel4.AutoSize = True
        HouseHoldQuantityLabel4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HouseHoldQuantityLabel4.ForeColor = Color.Black
        HouseHoldQuantityLabel4.Location = New Point(620, 247)
        HouseHoldQuantityLabel4.Name = "HouseHoldQuantityLabel4"
        HouseHoldQuantityLabel4.Size = New Size(156, 21)
        HouseHoldQuantityLabel4.TabIndex = 55
        HouseHoldQuantityLabel4.Text = "Household Quantity: "
        HouseHoldQuantityLabel4.Visible = False
        ' 
        ' OriginalPriceLabel4
        ' 
        OriginalPriceLabel4.AutoSize = True
        OriginalPriceLabel4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        OriginalPriceLabel4.ForeColor = Color.Black
        OriginalPriceLabel4.Location = New Point(620, 217)
        OriginalPriceLabel4.Name = "OriginalPriceLabel4"
        OriginalPriceLabel4.Size = New Size(150, 21)
        OriginalPriceLabel4.TabIndex = 54
        OriginalPriceLabel4.Text = "Original Price: $1.29"
        OriginalPriceLabel4.Visible = False
        ' 
        ' PriceLabel4
        ' 
        PriceLabel4.AutoSize = True
        PriceLabel4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PriceLabel4.ForeColor = Color.Red
        PriceLabel4.Location = New Point(626, 270)
        PriceLabel4.Name = "PriceLabel4"
        PriceLabel4.Size = New Size(123, 21)
        PriceLabel4.TabIndex = 53
        PriceLabel4.Text = "Sale Price: $1.10"
        PriceLabel4.Visible = False
        ' 
        ' FarmBoyLabel2
        ' 
        FarmBoyLabel2.AutoSize = True
        FarmBoyLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FarmBoyLabel2.ForeColor = Color.Black
        FarmBoyLabel2.Location = New Point(617, 165)
        FarmBoyLabel2.Name = "FarmBoyLabel2"
        FarmBoyLabel2.Size = New Size(147, 42)
        FarmBoyLabel2.TabIndex = 52
        FarmBoyLabel2.Text = "Farm Boy" & vbCrLf & "100 Queens Quay E"
        FarmBoyLabel2.Visible = False
        ' 
        ' SaleLabel4
        ' 
        SaleLabel4.AutoSize = True
        SaleLabel4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SaleLabel4.ForeColor = Color.Green
        SaleLabel4.Location = New Point(626, 291)
        SaleLabel4.Name = "SaleLabel4"
        SaleLabel4.Size = New Size(172, 21)
        SaleLabel4.TabIndex = 51
        SaleLabel4.Text = "25% OFF Until the 19th"
        SaleLabel4.Visible = False
        ' 
        ' LeekSaleImage
        ' 
        LeekSaleImage.Image = CType(resources.GetObject("LeekSaleImage.Image"), Image)
        LeekSaleImage.Location = New Point(617, 76)
        LeekSaleImage.Name = "LeekSaleImage"
        LeekSaleImage.Size = New Size(103, 86)
        LeekSaleImage.TabIndex = 50
        LeekSaleImage.TabStop = False
        LeekSaleImage.Visible = False
        ' 
        ' QuantityLabel4
        ' 
        QuantityLabel4.AutoSize = True
        QuantityLabel4.Location = New Point(772, 253)
        QuantityLabel4.Name = "QuantityLabel4"
        QuantityLabel4.Size = New Size(13, 15)
        QuantityLabel4.TabIndex = 56
        QuantityLabel4.Text = "0"
        QuantityLabel4.Visible = False
        ' 
        ' SalesMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(QuantityLabel4)
        Controls.Add(HouseHoldQuantityLabel4)
        Controls.Add(OriginalPriceLabel4)
        Controls.Add(PriceLabel4)
        Controls.Add(FarmBoyLabel2)
        Controls.Add(SaleLabel4)
        Controls.Add(LeekSaleImage)
        Controls.Add(QuantityLabel3)
        Controls.Add(QuantityLabel2)
        Controls.Add(QuantityLabel1)
        Controls.Add(HouseholdQuantityLabel3)
        Controls.Add(HouseholdQuantityLabel2)
        Controls.Add(HouseholdQuantityLabel1)
        Controls.Add(OriginalPriceLabel3)
        Controls.Add(OriginalPriceLabel2)
        Controls.Add(OriginalPriceLabel1)
        Controls.Add(PriceLabel3)
        Controls.Add(NoFrillsLabel)
        Controls.Add(SaleLabel3)
        Controls.Add(AppleSaleImage2)
        Controls.Add(PriceLabel2)
        Controls.Add(PriceLabel1)
        Controls.Add(CreateItineraryButton)
        Controls.Add(FarmBoyLabel)
        Controls.Add(WholeFoodsLabel)
        Controls.Add(SaleLabel2)
        Controls.Add(SaleLabel1)
        Controls.Add(TomatoSaleImage1)
        Controls.Add(AppleSaleImage1)
        Controls.Add(BackToMainMenuButton)
        Controls.Add(Label1)
        Name = "SalesMenu"
        Size = New Size(804, 451)
        CType(AppleSaleImage1, ComponentModel.ISupportInitialize).EndInit()
        CType(TomatoSaleImage1, ComponentModel.ISupportInitialize).EndInit()
        CType(AppleSaleImage2, ComponentModel.ISupportInitialize).EndInit()
        CType(LeekSaleImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BackToMainMenuButton As Button
    Friend WithEvents AppleSaleImage1 As PictureBox
    Friend WithEvents TomatoSaleImage1 As PictureBox
    Friend WithEvents SaleLabel1 As Label
    Friend WithEvents SaleLabel2 As Label
    Friend WithEvents WholeFoodsLabel As Label
    Friend WithEvents FarmBoyLabel As Label
    Friend WithEvents CreateItineraryButton As Button
    Friend WithEvents PriceLabel1 As Label
    Friend WithEvents PriceLabel2 As Label
    Friend WithEvents PriceLabel3 As Label
    Friend WithEvents NoFrillsLabel As Label
    Friend WithEvents SaleLabel3 As Label
    Friend WithEvents AppleSaleImage2 As PictureBox
    Friend WithEvents OriginalPriceLabel1 As Label
    Friend WithEvents OriginalPriceLabel2 As Label
    Friend WithEvents OriginalPriceLabel3 As Label
    Friend WithEvents HouseholdQuantityLabel1 As Label
    Friend WithEvents HouseholdQuantityLabel2 As Label
    Friend WithEvents HouseholdQuantityLabel3 As Label
    Friend WithEvents QuantityLabel1 As Label
    Friend WithEvents QuantityLabel2 As Label
    Friend WithEvents QuantityLabel3 As Label
    Friend WithEvents HouseHoldQuantityLabel4 As Label
    Friend WithEvents OriginalPriceLabel4 As Label
    Friend WithEvents PriceLabel4 As Label
    Friend WithEvents FarmBoyLabel2 As Label
    Friend WithEvents SaleLabel4 As Label
    Friend WithEvents LeekSaleImage As PictureBox
    Friend WithEvents QuantityLabel4 As Label

End Class
