<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileEdit))
        Me.btnEditPass = New System.Windows.Forms.Button()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEditPass
        '
        Me.btnEditPass.BackColor = System.Drawing.Color.Transparent
        Me.btnEditPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnEditPass.FlatAppearance.BorderSize = 0
        Me.btnEditPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPass.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnEditPass.Location = New System.Drawing.Point(247, 289)
        Me.btnEditPass.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditPass.Name = "btnEditPass"
        Me.btnEditPass.Size = New System.Drawing.Size(282, 58)
        Me.btnEditPass.TabIndex = 19
        Me.btnEditPass.UseVisualStyleBackColor = False
        '
        'btnEditUser
        '
        Me.btnEditUser.BackColor = System.Drawing.Color.Transparent
        Me.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnEditUser.FlatAppearance.BorderSize = 0
        Me.btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditUser.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnEditUser.Location = New System.Drawing.Point(247, 206)
        Me.btnEditUser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(282, 58)
        Me.btnEditUser.TabIndex = 18
        Me.btnEditUser.UseVisualStyleBackColor = False
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
        Me.btnBack.Location = New System.Drawing.Point(46, 42)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(44, 41)
        Me.btnBack.TabIndex = 28
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'ProfileEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEditPass)
        Me.Controls.Add(Me.btnEditUser)
        Me.DoubleBuffered = True
        Me.Name = "ProfileEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProfileEdit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEditPass As Button
    Friend WithEvents btnEditUser As Button
    Friend WithEvents btnBack As Button
End Class
