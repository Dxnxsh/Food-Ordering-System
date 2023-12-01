<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditCustomerInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditCustomerInfo))
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.UserInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodDatabaseDataSet = New Project_Final_3.FoodDatabaseDataSet()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnComfirm = New System.Windows.Forms.Button()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.UserInfoTableAdapter = New Project_Final_3.FoodDatabaseDataSetTableAdapters.UserInfoTableAdapter()
        Me.TableAdapterManager = New Project_Final_3.FoodDatabaseDataSetTableAdapters.TableAdapterManager()
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfoBindingSource, "PHONE", True))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(260, 399)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(255, 13)
        Me.txtPhoneNumber.TabIndex = 43
        '
        'UserInfoBindingSource
        '
        Me.UserInfoBindingSource.DataMember = "UserInfo"
        Me.UserInfoBindingSource.DataSource = Me.FoodDatabaseDataSet
        '
        'FoodDatabaseDataSet
        '
        Me.FoodDatabaseDataSet.DataSetName = "FoodDatabaseDataSet"
        Me.FoodDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfoBindingSource, "EMAIL", True))
        Me.txtEmail.Location = New System.Drawing.Point(260, 340)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(255, 13)
        Me.txtEmail.TabIndex = 41
        '
        'btnComfirm
        '
        Me.btnComfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnComfirm.FlatAppearance.BorderSize = 0
        Me.btnComfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnComfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnComfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComfirm.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!)
        Me.btnComfirm.Location = New System.Drawing.Point(650, 505)
        Me.btnComfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnComfirm.Name = "btnComfirm"
        Me.btnComfirm.Size = New System.Drawing.Size(99, 26)
        Me.btnComfirm.TabIndex = 39
        Me.btnComfirm.UseVisualStyleBackColor = False
        '
        'txtFullname
        '
        Me.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfoBindingSource, "FULLNAME", True))
        Me.txtFullname.Location = New System.Drawing.Point(260, 279)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(255, 13)
        Me.txtFullname.TabIndex = 38
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfoBindingSource, "PASSWORD", True))
        Me.txtPassword.Location = New System.Drawing.Point(260, 212)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(255, 13)
        Me.txtPassword.TabIndex = 36
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserInfoBindingSource, "USERNAME", True))
        Me.txtUsername.Location = New System.Drawing.Point(260, 151)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(255, 13)
        Me.txtUsername.TabIndex = 34
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
        Me.btnBack.Location = New System.Drawing.Point(46, 43)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(43, 40)
        Me.btnBack.TabIndex = 32
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'UserInfoTableAdapter
        '
        Me.UserInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminLoginTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FoodListTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project_Final_3.FoodDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserInfoTableAdapter = Me.UserInfoTableAdapter
        '
        'EditCustomerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(776, 553)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnComfirm)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnBack)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditCustomerInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditCustomerInfo"
        CType(Me.UserInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnComfirm As Button
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents FoodDatabaseDataSet As FoodDatabaseDataSet
    Friend WithEvents UserInfoBindingSource As BindingSource
    Friend WithEvents UserInfoTableAdapter As FoodDatabaseDataSetTableAdapters.UserInfoTableAdapter
    Friend WithEvents TableAdapterManager As FoodDatabaseDataSetTableAdapters.TableAdapterManager
End Class
