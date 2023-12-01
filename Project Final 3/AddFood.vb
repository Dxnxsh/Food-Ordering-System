Imports System.Data.OleDb

Public Class AddFood
    Public Class Food
        Public Property Name As String
        Public Property Description As String
        Public Property Price As Decimal
    End Class

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminMainMenu.Show()
        Me.Hide()
    End Sub

    Private FoodsList As New List(Of Food)

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Dim name As String = txtFoodName.Text
        Dim description As String = txtFoodDescription.Text
        Dim price As Decimal = Decimal.Parse(txtFoodPrice.Text)

        ' Create a new Food object
        Dim newFood As New Food With {
            .Name = name,
            .Description = description,
            .Price = price
        }

        ' Add the food to the list
        FoodsList.Add(newFood)

        ' Insert the data into the MS Access table
        InsertFoodIntoDatabase(newFood)

        ' Display a message to confirm the addition
        MsgBox("Food added successfully!")
        Dim result As DialogResult = MessageBox.Show("Do you want to add more food?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            AdminMainMenu.Show()
        End If
    End Sub

    Private Sub InsertFoodIntoDatabase(food As Food)
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Dim query As String = "INSERT INTO FoodList (FoodName, [Desc], Price, Food) VALUES (?, ?, ?, ?)"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                connection.Open()

                command.Parameters.AddWithValue("@FoodName", food.Name)
                command.Parameters.AddWithValue("@Desc", food.Description)
                command.Parameters.AddWithValue("@Price", food.Price)
                command.Parameters.AddWithValue("@Food", IIf(RadioButton1.Checked, True, False))

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub AddFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
    End Sub
End Class
