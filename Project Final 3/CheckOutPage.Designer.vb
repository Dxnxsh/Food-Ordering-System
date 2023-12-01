<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOutPage
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
        Me.components = New System.ComponentModel.Container()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.txtCardNum = New System.Windows.Forms.TextBox()
        Me.txtED = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.rBCredit = New System.Windows.Forms.RadioButton()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Location = New System.Drawing.Point(56, 430)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(442, 13)
        Me.txtName.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtCVV
        '
        Me.txtCVV.BackColor = System.Drawing.SystemColors.Control
        Me.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCVV.Location = New System.Drawing.Point(419, 492)
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(79, 13)
        Me.txtCVV.TabIndex = 2
        '
        'txtCardNum
        '
        Me.txtCardNum.BackColor = System.Drawing.SystemColors.Control
        Me.txtCardNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCardNum.Location = New System.Drawing.Point(54, 485)
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(212, 13)
        Me.txtCardNum.TabIndex = 3
        '
        'txtED
        '
        Me.txtED.BackColor = System.Drawing.SystemColors.Control
        Me.txtED.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtED.Location = New System.Drawing.Point(295, 488)
        Me.txtED.Name = "txtED"
        Me.txtED.Size = New System.Drawing.Size(95, 13)
        Me.txtED.TabIndex = 4
        '
        'lblDisplay
        '
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(318, 160)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(142, 56)
        Me.lblDisplay.TabIndex = 5
        Me.lblDisplay.Text = "Label1"
        '
        'rbCash
        '
        Me.rbCash.BackColor = System.Drawing.Color.Transparent
        Me.rbCash.Location = New System.Drawing.Point(34, 305)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(16, 18)
        Me.rbCash.TabIndex = 6
        Me.rbCash.TabStop = True
        Me.rbCash.UseVisualStyleBackColor = False
        '
        'rBCredit
        '
        Me.rBCredit.BackColor = System.Drawing.Color.Transparent
        Me.rBCredit.Location = New System.Drawing.Point(34, 359)
        Me.rBCredit.Name = "rBCredit"
        Me.rBCredit.Size = New System.Drawing.Size(16, 18)
        Me.rBCredit.TabIndex = 7
        Me.rBCredit.TabStop = True
        Me.rBCredit.UseVisualStyleBackColor = False
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
        Me.btnBack.Location = New System.Drawing.Point(34, 39)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(62, 48)
        Me.btnBack.TabIndex = 21
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnConfirm.Location = New System.Drawing.Point(608, 485)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(119, 45)
        Me.btnConfirm.TabIndex = 22
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'CheckOutPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_Final_3.My.Resources.Resources._6__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rBCredit)
        Me.Controls.Add(Me.rbCash)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtED)
        Me.Controls.Add(Me.txtCardNum)
        Me.Controls.Add(Me.txtCVV)
        Me.Controls.Add(Me.txtName)
        Me.DoubleBuffered = True
        Me.Name = "CheckOutPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckOutPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents txtCardNum As TextBox
    Friend WithEvents txtED As TextBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents rbCash As RadioButton
    Friend WithEvents rBCredit As RadioButton
    Friend WithEvents btnBack As Button
    Friend WithEvents btnConfirm As Button
End Class
