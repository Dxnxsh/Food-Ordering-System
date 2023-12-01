<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderSuccesfulPage
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
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMainMenu.FlatAppearance.BorderSize = 0
        Me.btnMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainMenu.Location = New System.Drawing.Point(332, 358)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(110, 34)
        Me.btnMainMenu.TabIndex = 0
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'lblOrderID
        '
        Me.lblOrderID.Location = New System.Drawing.Point(414, 333)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(52, 13)
        Me.lblOrderID.TabIndex = 1
        Me.lblOrderID.Text = "lbl"
        '
        'OrderSuccesfulPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.Project_Final_3.My.Resources.Resources._7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.btnMainMenu)
        Me.DoubleBuffered = True
        Me.Name = "OrderSuccesfulPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrderSuccesfulPage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMainMenu As Button
    Friend WithEvents lblOrderID As Label
End Class
