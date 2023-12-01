<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFood
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddFood))
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.txtFoodPrice = New System.Windows.Forms.TextBox()
        Me.txtFoodDescription = New System.Windows.Forms.TextBox()
        Me.txtFoodName = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'BtnConfirm
        '
        Me.BtnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.BtnConfirm.FlatAppearance.BorderSize = 0
        Me.BtnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirm.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!)
        Me.BtnConfirm.Location = New System.Drawing.Point(651, 502)
        Me.BtnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(96, 30)
        Me.BtnConfirm.TabIndex = 26
        Me.BtnConfirm.UseVisualStyleBackColor = False
        '
        'txtFoodPrice
        '
        Me.txtFoodPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFoodPrice.Location = New System.Drawing.Point(259, 361)
        Me.txtFoodPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFoodPrice.Name = "txtFoodPrice"
        Me.txtFoodPrice.Size = New System.Drawing.Size(255, 13)
        Me.txtFoodPrice.TabIndex = 25
        '
        'txtFoodDescription
        '
        Me.txtFoodDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFoodDescription.Location = New System.Drawing.Point(259, 294)
        Me.txtFoodDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFoodDescription.Name = "txtFoodDescription"
        Me.txtFoodDescription.Size = New System.Drawing.Size(255, 13)
        Me.txtFoodDescription.TabIndex = 23
        '
        'txtFoodName
        '
        Me.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFoodName.Location = New System.Drawing.Point(259, 229)
        Me.txtFoodName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFoodName.Name = "txtFoodName"
        Me.txtFoodName.Size = New System.Drawing.Size(255, 13)
        Me.txtFoodName.TabIndex = 21
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.Location = New System.Drawing.Point(45, 41)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(44, 41)
        Me.btnBack.TabIndex = 19
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Food or drink ?"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(259, 437)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton1.TabIndex = 28
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Food"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(382, 437)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton2.TabIndex = 29
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Drink"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'AddFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.txtFoodPrice)
        Me.Controls.Add(Me.txtFoodDescription)
        Me.Controls.Add(Me.txtFoodName)
        Me.Controls.Add(Me.btnBack)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddFood"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddFood"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnConfirm As Button
    Friend WithEvents txtFoodPrice As TextBox
    Friend WithEvents txtFoodDescription As TextBox
    Friend WithEvents txtFoodName As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
