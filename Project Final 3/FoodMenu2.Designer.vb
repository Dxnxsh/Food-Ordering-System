<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodMenu2
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
        Me.panelFood = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelDrinks = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnDrink = New System.Windows.Forms.Button()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.panelLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelFood
        '
        Me.panelFood.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panelFood.BackColor = System.Drawing.Color.Transparent
        Me.panelFood.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panelFood.Location = New System.Drawing.Point(176, 43)
        Me.panelFood.Name = "panelFood"
        Me.panelFood.Size = New System.Drawing.Size(588, 470)
        Me.panelFood.TabIndex = 32
        '
        'panelDrinks
        '
        Me.panelDrinks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panelDrinks.BackColor = System.Drawing.Color.Transparent
        Me.panelDrinks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panelDrinks.Location = New System.Drawing.Point(176, 43)
        Me.panelDrinks.Name = "panelDrinks"
        Me.panelDrinks.Size = New System.Drawing.Size(609, 470)
        Me.panelDrinks.TabIndex = 33
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnBack.Location = New System.Drawing.Point(58, 7)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(45, 45)
        Me.btnBack.TabIndex = 31
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(21, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 45)
        Me.Button1.TabIndex = 33
        Me.Button1.UseVisualStyleBackColor = False
        '
        'panelLeft
        '
        Me.panelLeft.BackColor = System.Drawing.Color.LightCoral
        Me.panelLeft.Controls.Add(Me.Button2)
        Me.panelLeft.Controls.Add(Me.Button3)
        Me.panelLeft.Controls.Add(Me.btnDrink)
        Me.panelLeft.Controls.Add(Me.btnFood)
        Me.panelLeft.Location = New System.Drawing.Point(0, 0)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(149, 560)
        Me.panelLeft.TabIndex = 34
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 28)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "CART"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Project_Final_3.My.Resources.Resources.Frame_5
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(46, 43)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 41)
        Me.Button3.TabIndex = 7
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnDrink
        '
        Me.btnDrink.FlatAppearance.BorderSize = 0
        Me.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrink.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrink.Location = New System.Drawing.Point(3, 135)
        Me.btnDrink.Name = "btnDrink"
        Me.btnDrink.Size = New System.Drawing.Size(143, 28)
        Me.btnDrink.TabIndex = 5
        Me.btnDrink.Text = "DRINKS"
        Me.btnDrink.UseVisualStyleBackColor = True
        '
        'btnFood
        '
        Me.btnFood.FlatAppearance.BorderSize = 0
        Me.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFood.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFood.Location = New System.Drawing.Point(3, 98)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(143, 28)
        Me.btnFood.TabIndex = 0
        Me.btnFood.Text = "FOODS"
        Me.btnFood.UseVisualStyleBackColor = True
        '
        'FoodMenu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.panelDrinks)
        Me.Controls.Add(Me.panelLeft)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.panelFood)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "FoodMenu2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FoodMenu2"
        Me.panelLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelFood As FlowLayoutPanel
    Friend WithEvents btnBack As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents panelLeft As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnDrink As Button
    Friend WithEvents btnFood As Button
    Friend WithEvents panelDrinks As FlowLayoutPanel
End Class
