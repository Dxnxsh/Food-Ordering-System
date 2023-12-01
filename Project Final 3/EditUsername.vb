Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class EditUsername

    Private Sub EditUsername_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LoggedInUserID As Integer = GlobalVariables.LoggedInUserID

    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim username As String = txtNewName.Text
        Dim conUser As String = txtConName.Text

        If String.IsNullOrWhiteSpace(username) OrElse
           String.IsNullOrWhiteSpace(conUser) Then
            MessageBox.Show("Please fill in all the required fields.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not username.Equals(conUser) Then
            MessageBox.Show("The new username and confirm username do not match.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If UpdateUsername(username, LoggedInUserID) Then
            MessageBox.Show("Edit successful. You can now log in.", "Edit Username", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
        Else
            MessageBox.Show("Failed to register the user. Please try again later.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ProfileEdit.Show()
        Me.Hide()
    End Sub

    Private Function UpdateUsername(username As String, userid As String) As Boolean
        ' TODO: Implement your logic to insert the user information into the database
        ' You can connect to the Access database and execute an INSERT statement to add the user information to the UserInfo table
        ' Return true if the registration is successful, false otherwise
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Prepare the SQL query to insert the user information into the database
            Dim query As String = "UPDATE `UserInfo` SET `USERNAME` = @username WHERE ((`ID` = @userid))"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@userid", userid)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                Return rowsAffected > 0
            End Using
        End Using
    End Function

    Private Sub ClearFields()
        ' Clear all the text boxes
        txtNewName.Clear()
        txtConName.Clear()

        ' Set focus to the username text box
        txtNewName.Focus()
    End Sub
End Class