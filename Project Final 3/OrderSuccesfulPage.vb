Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.OleDb

Public Class OrderSuccesfulPage
    Private selectedFoodArray(,) As Integer
    Private totalAmount As Decimal
    Private userID As Integer


    Public Sub New(selectedFoodArray As Integer(,), totalAmount As Decimal)
        InitializeComponent()

        ' Store the selected food array and total amount from the previous form
        Me.selectedFoodArray = selectedFoodArray
        Me.totalAmount = Decimal.Round(totalAmount, 2)
        Me.userID = GlobalVariables.LoggedInUserID
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        CustomerMainMenu.Show()
        Me.Hide()
        FoodMenu2.Close()

    End Sub

    Private Sub OrderSuccesfulPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Insert the order details into the OrderHistory table
        InsertOrderDetails()

        ' Display the order ID in the label
        lblOrderID.Text = GetLastOrderID().ToString()
    End Sub

    Private Sub InsertOrderDetails()
        Dim count As Integer
        ' Retrieve the current date and time
        Dim orderDate As DateTime = DateTime.Now

        ' Establish the database connection
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Insert the order details for each selected food item
            For i As Integer = 0 To selectedFoodArray.GetLength(0) - 1

                count += selectedFoodArray(i, 1)
            Next


            ' Create the SQL INSERT statement to insert the order details
            Dim sqlInsert As String = "INSERT INTO OrderHistory (UserID, Quantity, OrderDate, Amount) " &
            "VALUES (?, ?, ?, ?)"

            ' Prepare the command with parameters
            Using command As New OleDbCommand(sqlInsert, connection)
                ' Pass NULL for UserID if it is 0, otherwise pass the valid user ID
                Dim userIDParam As OleDbParameter
                If Me.userID = 0 Then
                    userIDParam = New OleDbParameter("@UserID", OleDbType.Integer)
                    userIDParam.Value = DBNull.Value
                Else
                    userIDParam = New OleDbParameter("@UserID", OleDbType.Integer)
                    userIDParam.Value = Me.userID
                End If

                command.Parameters.Add(userIDParam)
                command.Parameters.Add("@Quantity", OleDbType.Integer).Value = count
                command.Parameters.Add("@OrderDate", OleDbType.DBDate).Value = orderDate
                command.Parameters.Add("@Amount", OleDbType.Currency).Value = totalAmount

                ' Execute the command to insert the order details
                command.ExecuteNonQuery()
            End Using

        End Using
    End Sub

    Private Function GetLastOrderID() As Integer
        ' Establish the database connection
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Create the SQL SELECT statement to retrieve the last order ID
            Dim sqlSelect As String = "SELECT MAX(ID) FROM OrderHistory"

            ' Prepare the command
            Using command As New OleDbCommand(sqlSelect, connection)
                ' Execute the command and retrieve the last order ID
                Dim lastOrderID As Object = command.ExecuteScalar()

                ' Check if the lastOrderID is not DBNull
                If Not IsDBNull(lastOrderID) Then
                    Return Convert.ToInt32(lastOrderID)
                End If
            End Using
        End Using

        Return -1 ' Return -1 if no order ID is found
    End Function
End Class