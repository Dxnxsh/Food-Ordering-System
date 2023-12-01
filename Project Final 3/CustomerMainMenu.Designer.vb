<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnFoodOrder = New System.Windows.Forms.Button()
        Me.btnOrderHistory = New System.Windows.Forms.Button()
        Me.btnProfileEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline)
        Me.btnLogout.Location = New System.Drawing.Point(347, 466)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(92, 30)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnFoodOrder
        '
        Me.btnFoodOrder.BackColor = System.Drawing.Color.Transparent
        Me.btnFoodOrder.FlatAppearance.BorderSize = 0
        Me.btnFoodOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFoodOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFoodOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoodOrder.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnFoodOrder.Location = New System.Drawing.Point(243, 212)
        Me.btnFoodOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFoodOrder.Name = "btnFoodOrder"
        Me.btnFoodOrder.Size = New System.Drawing.Size(288, 60)
        Me.btnFoodOrder.TabIndex = 1
        Me.btnFoodOrder.UseVisualStyleBackColor = False
        '
        'btnOrderHistory
        '
        Me.btnOrderHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnOrderHistory.FlatAppearance.BorderSize = 0
        Me.btnOrderHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOrderHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderHistory.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnOrderHistory.Location = New System.Drawing.Point(243, 290)
        Me.btnOrderHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrderHistory.Name = "btnOrderHistory"
        Me.btnOrderHistory.Size = New System.Drawing.Size(288, 67)
        Me.btnOrderHistory.TabIndex = 2
        Me.btnOrderHistory.UseVisualStyleBackColor = False
        '
        'btnProfileEdit
        '
        Me.btnProfileEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnProfileEdit.FlatAppearance.BorderSize = 0
        Me.btnProfileEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnProfileEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnProfileEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfileEdit.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnProfileEdit.Location = New System.Drawing.Point(243, 374)
        Me.btnProfileEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProfileEdit.Name = "btnProfileEdit"
        Me.btnProfileEdit.Size = New System.Drawing.Size(288, 65)
        Me.btnProfileEdit.TabIndex = 3
        Me.btnProfileEdit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(448, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 28)
        Me.Label1.TabIndex = 4
        '
        'CustomerMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.Project_Final_3.My.Resources.Resources._2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProfileEdit)
        Me.Controls.Add(Me.btnOrderHistory)
        Me.Controls.Add(Me.btnFoodOrder)
        Me.Controls.Add(Me.btnLogout)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CustomerMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerMainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents btnFoodOrder As Button
    Friend WithEvents btnOrderHistory As Button
    Friend WithEvents btnProfileEdit As Button
    Friend WithEvents Label1 As Label
End Class
