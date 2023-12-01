Imports System.Data.OleDb

Public Class EditPassword
    Private Sub EditUsername_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LoggedInUserID As Integer = GlobalVariables.LoggedInUserID

    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim oldPass As String = txtOldPass.Text
        Dim newPass As String = txtNewPass.Text
        Dim conPass As String = txtConPass.Text

        If String.IsNullOrWhiteSpace(oldPass) OrElse
           String.IsNullOrWhiteSpace(newPass) OrElse
           String.IsNullOrWhiteSpace(conPass) Then
            MessageBox.Show("Please fill in all the required fields.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not newPass.Equals(conPass) Then
            MessageBox.Show("The new password and confirm password do not match.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If ValidatePassword(oldPass) Then
            If UpdatePassword(newPass, LoggedInUserID) Then
                MessageBox.Show("Edit successful.", "Edit Username", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            Else
                MessageBox.Show("Failed to edit. Please try again.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Wrong Password. Please try again.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Function UpdatePassword(password As String, userid As String) As Boolean
        ' TODO: Implement your logic to insert the user information into the database
        ' You can connect to the Access database and execute an INSERT statement to add the user information to the UserInfo table
        ' Return true if the registration is successful, false otherwise
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Prepare the SQL query to insert the user information into the database
            Dim query As String = "UPDATE `UserInfo` SET `PASSWORD` = @password WHERE ((`ID` = @userid))"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@password", password)
                command.Parameters.AddWithValue("@userid", userid)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                Return rowsAffected > 0
            End Using
        End Using
    End Function

    Private Function ValidatePassword(password As String) As Boolean
        ' TODO: Implement your validation logic here
        ' You can connect to the Access database and query the credentials table to validate the login
        ' Return true if the credentials are valid, false otherwise
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Prepare the SQL query to check if the credentials exist in the database
            Dim query As String = "SELECT COUNT(*) FROM UserInfo WHERE PASSWORD = @password"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@password", password)

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                Return result > 0
            End Using
        End Using
    End Function

    Private Sub ClearFields()
        ' Clear all the text boxes
        txtOldPass.Clear()
        txtNewPass.Clear()
        txtConPass.Clear()

        ' Set focus to the username text box
        txtOldPass.Focus()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ProfileEdit.Show()
        Me.Hide()
    End Sub
End Class