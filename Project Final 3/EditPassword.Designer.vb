<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPassword))
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtConPass = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.Transparent
        Me.btnChange.FlatAppearance.BorderSize = 0
        Me.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChange.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!)
        Me.btnChange.Location = New System.Drawing.Point(651, 501)
        Me.btnChange.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(96, 30)
        Me.btnChange.TabIndex = 39
        Me.btnChange.UseVisualStyleBackColor = False
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
        Me.btnBack.Location = New System.Drawing.Point(46, 41)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(44, 41)
        Me.btnBack.TabIndex = 38
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtNewPass
        '
        Me.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPass.Location = New System.Drawing.Point(260, 310)
        Me.txtNewPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(255, 13)
        Me.txtNewPass.TabIndex = 37
        '
        'txtConPass
        '
        Me.txtConPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConPass.Location = New System.Drawing.Point(260, 378)
        Me.txtConPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConPass.Name = "txtConPass"
        Me.txtConPass.Size = New System.Drawing.Size(255, 13)
        Me.txtConPass.TabIndex = 36
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Location = New System.Drawing.Point(260, 310)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(255, 13)
        Me.txtPassword.TabIndex = 35
        '
        'txtOldPass
        '
        Me.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldPass.Location = New System.Drawing.Point(260, 245)
        Me.txtOldPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Size = New System.Drawing.Size(255, 13)
        Me.txtOldPass.TabIndex = 34
        '
        'EditPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtConPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtOldPass)
        Me.DoubleBuffered = True
        Me.Name = "EditPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChange As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtConPass As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtOldPass As TextBox
End Class
