Imports System.Data.OleDb

Public Class AdminLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' Check if the username and password are valid
        If ValidateCredentials(txtUsername.Text, txtPassword.Text) Then
            ' Successful login, show the admin dashboard or the next form
            Dim adminDashboard As New AdminMainMenu()
            adminDashboard.Show()
            Me.Hide()
        Else
            ' Invalid credentials, display an error message
            MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateCredentials(username As String, password As String) As Boolean
        ' TODO: Implement your validation logic here
        ' You can connect to the Access database and query the credentials table to validate the login
        ' Return true if the credentials are valid, false otherwise
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Using connection As New OleDbConnection(connectionString)
            connection.Open()


            Dim query As String = "SELECT COUNT(*) FROM AdminLogin WHERE AdminUsername = @username AND AdminPassword = @password"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                Return result > 0
            End Using
        End Using
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub


    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class