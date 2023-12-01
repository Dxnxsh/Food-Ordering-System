Imports System.Data.OleDb

Public Class EditCustomerInfo

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminMainMenu.Show()
        Me.Hide()
    End Sub


    Private Sub btnComfirm_Click(sender As Object, e As EventArgs) Handles btnComfirm.Click
        ' Get the user input from the text boxes
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim fullname As String = txtFullname.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhoneNumber.Text

        ' Validate the user input
        If String.IsNullOrWhiteSpace(username) OrElse
           String.IsNullOrWhiteSpace(password) OrElse
           String.IsNullOrWhiteSpace(fullname) OrElse
           String.IsNullOrWhiteSpace(email) OrElse
           String.IsNullOrWhiteSpace(phone) Then
            MessageBox.Show("Please fill in all the required fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the username is already taken
        If IsUsernameExist(username) Then
            ' Register the user by inserting their information into the database
            If UpdateUser(username, password, fullname, email, phone) Then
                MessageBox.Show("Update successful", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            Else
                MessageBox.Show("Failed to update the user. Please try again.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("User does not exists.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearFields()
        End If


    End Sub

    Private Function IsUsernameExist(username As String) As Boolean
        ' TODO: Implement your logic to check if the username is already taken in the database
        ' You can connect to the Access database and query the UserInfo table to check if the username exists
        ' Return true if the username is already taken, false otherwise
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Prepare the SQL query to check if the username exists in the database
            Dim query As String = "SELECT COUNT(*) FROM UserInfo WHERE Username = @username"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                Return result > 0
            End Using
        End Using
    End Function

    Private Function UpdateUser(username As String, password As String, fullname As String, email As String, phone As String) As Boolean
        ' TODO: Implement your logic to insert the user information into the database
        ' You can connect to the Access database and execute an INSERT statement to add the user information to the UserInfo table
        ' Return true if the registration is successful, false otherwise
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Prepare the SQL query to insert the user information into the database
            Dim query As String = "UPDATE UserInfo SET USERNAME = @username,[PASSWORD] = @password, FULLNAME = @fullname, EMAIL = @email, PHONE = @phone WHERE USERNAME = @username"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                command.Parameters.AddWithValue("@fullname", fullname)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@phone", phone)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                Return rowsAffected > 0
            End Using
        End Using
    End Function

    Private Sub ClearFields()
        ' Clear all the text boxes
        txtUsername.Clear()
        txtPassword.Clear()
        txtFullname.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()

        ' Set focus to the username text box
        txtUsername.Focus()
    End Sub

    Private Sub EditCustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class