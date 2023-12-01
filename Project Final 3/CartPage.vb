Imports System.Data.OleDb

Public Class CartPage
    ' Define a 2D array to store the selected food and quantity
    Private selectedFoodArray(,) As Integer
    Private totalAmount As Decimal
    Private count As Integer

    Public Sub New(selectedFoodArray As Integer(,))
        InitializeComponent()

        ' Store the selected food array from the previous form
        Me.selectedFoodArray = selectedFoodArray
    End Sub

    Private Sub CartPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create panels dynamically based on each entry
        For i As Integer = 0 To selectedFoodArray.GetLength(0) - 1
            Dim foodID As Integer = selectedFoodArray(i, 0)
            Dim quantity As Integer = selectedFoodArray(i, 1)

            ' Skip creating the panel if the quantity is zero
            If quantity > 0 Then
                ' Retrieve the food details from the database using the foodID
                Dim foodDetails As DataRow = RetrieveFoodDetails(foodID)

                Dim panel As New Panel()
                panel.Width = CInt(Me.Width * 0.8)
                panel.Height = 80
                panel.BorderStyle = BorderStyle.None

                Dim foodNameLabel As New Label()
                foodNameLabel.Text = foodDetails("FoodName").ToString()
                foodNameLabel.Location = New Point(10, 10)
                foodNameLabel.Width = CInt(panel.Width * 0.4)

                Dim quantityLabel As New Label()
                quantityLabel.Text = "Quantity: " & quantity.ToString
                quantityLabel.Location = New Point(foodNameLabel.Right + 20, 10)
                quantityLabel.Width = CInt(panel.Width * 0.2)

                Dim priceLabel As New Label()
                priceLabel.Text = "Price: RM" & foodDetails("Price").ToString()
                priceLabel.Location = New Point(quantityLabel.Right + 20, 10)
                priceLabel.Width = CInt(panel.Width * 0.5)

                panel.AutoSize = False
                panel.Font = New Font("Microsoft Sans Serif", 20.0!, FontStyle.Regular, GraphicsUnit.Pixel, CType(0, Byte))
                panel.Location = New Point(50, 115)
                panel.Padding = New Padding(20)
                panel.Size = New Size(662, 71)
                panel.TabIndex = 28
                panel.BackColor = Color.FromArgb(217, 217, 217)

                Dim rectangle As New Rectangle(0, 0, panel.Width, panel.Height)
                Dim path As New Drawing2D.GraphicsPath()
                Dim radius As Integer = 22
                path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90)
                path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90)
                path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90)
                path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90)
                path.CloseAllFigures()
                panel.Region = New Region(path)

                ' Add the labels to the panel
                panel.Controls.Add(foodNameLabel)
                panel.Controls.Add(quantityLabel)
                panel.Controls.Add(priceLabel)

                ' Add the panel to the FlowLayoutPanel
                FlowLayoutPanel1.Controls.Add(panel)
                count += 1
            End If
        Next

        totalAmount = CalculateTotalPrice()
        Dim totalPrice As Decimal = CalculateTotalPrice()
        lblTotalOrder.Text = count.toString
        lblTotalPrice.Text = $"RM {totalPrice}"
    End Sub

    Private Function RetrieveFoodDetails(foodID As Integer) As DataRow
        ' Retrieve the food details from the database based on the foodID
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Dim query As String = $"SELECT * FROM FoodList WHERE ID = {foodID}"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using command As New OleDbCommand(query, connection)
                Dim dataAdapter As New OleDbDataAdapter(command)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)

                If dataTable.Rows.Count > 0 Then
                    Return dataTable.Rows(0)
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function

    Private Function CalculateTotalPrice() As Decimal
        Dim totalPrice As Decimal = 0

        ' Calculate the total amount based on the selected food and quantity
        For i As Integer = 0 To selectedFoodArray.GetLength(0) - 1
            Dim foodID As Integer = selectedFoodArray(i, 0)
            Dim quantity As Integer = selectedFoodArray(i, 1)

            ' Retrieve the food details from the database using the foodID
            Dim foodDetails As DataRow = RetrieveFoodDetails(foodID)

            ' Calculate the subtotal amount for the food item
            Dim price As Decimal = Convert.ToDecimal(foodDetails("Price"))
            Dim subtotal As Decimal = price * quantity

            ' Add the subtotal to the total amount
            totalPrice += subtotal
        Next

        Return totalPrice
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FoodMenu2.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrderMore_Click(sender As Object, e As EventArgs) Handles btnOrderMore.Click
        FoodMenu2.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        ' Pass the selected food array and total amount to the CheckOutPage form
        Dim checkOutPage As New CheckOutPage(selectedFoodArray, totalAmount)
        checkOutPage.Show()
        Me.Hide()
    End Sub

    Private Sub lblTotalPrice_Click(sender As Object, e As EventArgs) Handles lblTotalPrice.Click

    End Sub
End Class
