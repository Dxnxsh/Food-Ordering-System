<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CartPage))
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnOrderMore = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTotalOrder = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnCheckOut.FlatAppearance.BorderSize = 0
        Me.btnCheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnCheckOut.Location = New System.Drawing.Point(640, 495)
        Me.btnCheckOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(114, 45)
        Me.btnCheckOut.TabIndex = 18
        Me.btnCheckOut.UseVisualStyleBackColor = False
        '
        'btnOrderMore
        '
        Me.btnOrderMore.BackColor = System.Drawing.Color.Transparent
        Me.btnOrderMore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnOrderMore.FlatAppearance.BorderSize = 0
        Me.btnOrderMore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOrderMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOrderMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderMore.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnOrderMore.Location = New System.Drawing.Point(522, 495)
        Me.btnOrderMore.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderMore.Name = "btnOrderMore"
        Me.btnOrderMore.Size = New System.Drawing.Size(114, 45)
        Me.btnOrderMore.TabIndex = 19
        Me.btnOrderMore.UseVisualStyleBackColor = False
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
        Me.btnBack.Location = New System.Drawing.Point(43, 42)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(45, 45)
        Me.btnBack.TabIndex = 20
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblTotalOrder
        '
        Me.lblTotalOrder.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOrder.Location = New System.Drawing.Point(55, 486)
        Me.lblTotalOrder.Name = "lblTotalOrder"
        Me.lblTotalOrder.Size = New System.Drawing.Size(44, 30)
        Me.lblTotalOrder.TabIndex = 21
        Me.lblTotalOrder.Text = "Label1"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(600, 457)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(91, 36)
        Me.lblTotalPrice.TabIndex = 22
        Me.lblTotalPrice.Text = "Label2"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(58, 110)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(665, 298)
        Me.FlowLayoutPanel1.TabIndex = 23
        '
        'CartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblTotalOrder)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnOrderMore)
        Me.Controls.Add(Me.btnCheckOut)
        Me.DoubleBuffered = True
        Me.Name = "CartPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CartPage"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnOrderMore As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTotalOrder As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
