Imports System.Data.OleDb

Public Class CustomerMainMenu
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Label1.Text = " "
        GlobalVariables.LoggedInUserID = -1
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnFoodOrder_Click(sender As Object, e As EventArgs) Handles btnFoodOrder.Click
        FoodMenu2.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOrderHistory.Click
        OrderHistory.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnProfileEdit.Click
        ProfileEdit.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CustomerMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FoodDatabaseDataSet.UserInfo' table. You can move, or remove it, as needed.
        Dim loggedInUserID As Integer = GlobalVariables.LoggedInUserID
        Dim username As String = GetUsername(loggedInUserID)

        ' Display the username on Label1
        Label1.Text = username

    End Sub
    Private Function GetUsername(UserID As Integer) As String
        ' Perform database query to retrieve the username based on the userID
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Dim query As String = "SELECT USERNAME FROM UserInfo WHERE ID = @UserID"
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", UserID)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing Then
                    Return result.ToString()
                Else
                    Return "Unknown User"
                End If
            End Using
        End Using
    End Function
End Class