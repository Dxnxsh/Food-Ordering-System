<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUsername
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditUsername))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtNewName = New System.Windows.Forms.TextBox()
        Me.txtConName = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Location = New System.Drawing.Point(260, 310)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(255, 13)
        Me.txtPassword.TabIndex = 19
        '
        'txtNewName
        '
        Me.txtNewName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewName.Location = New System.Drawing.Point(260, 245)
        Me.txtNewName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(255, 13)
        Me.txtNewName.TabIndex = 18
        '
        'txtConName
        '
        Me.txtConName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConName.Location = New System.Drawing.Point(260, 310)
        Me.txtConName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConName.Name = "txtConName"
        Me.txtConName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConName.Size = New System.Drawing.Size(255, 13)
        Me.txtConName.TabIndex = 21
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
        Me.btnChange.TabIndex = 33
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
        Me.btnBack.TabIndex = 32
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'EditUsername
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtConName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNewName)
        Me.DoubleBuffered = True
        Me.Name = "EditUsername"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditUsername"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtNewName As TextBox
    Friend WithEvents txtConName As TextBox
    Friend WithEvents btnChange As Button
    Friend WithEvents btnBack As Button
End Class
