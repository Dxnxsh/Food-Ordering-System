Imports System.Data.OleDb

Public Module GlobalVariables
    Public LoggedInUserID As Integer = -1 ' Default value indicating no user logged in
End Module
Public Class Form1
    Private Sub btnContinueAsAdmin_Click(sender As Object, e As EventArgs) Handles btnContinueAsAdmin.Click
        AdminLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        RegistrationPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Check if the username and password are valid
        If ValidateCredentials(txtUsername.Text, txtPassword.Text) Then
            ' Successful login, show the admin dashboard or the next form
            Dim adminDashboard As New AdminMainMenu()
            CustomerMainMenu.Show()
            Me.Hide()
        Else
            ' Invalid credentials, display an error message
            MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateCredentials(username As String, password As String) As Boolean
        ' Perform database query to check username and password
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Dim query As String = "SELECT ID FROM UserInfo WHERE USERNAME = @Username AND PASSWORD = @Password"
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing Then
                    ' Login successful
                    GlobalVariables.LoggedInUserID = Convert.ToInt32(result)
                    Return True
                Else
                    ' Login failed
                    Return False
                End If
            End Using
        End Using
    End Function


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
