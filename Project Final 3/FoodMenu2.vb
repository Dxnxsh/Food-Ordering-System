Imports System.Data.OleDb

Public Class FoodMenu2

    Private selectedFoodArray(,) As Integer

    Private Sub FoodMenu2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelFood.Visible = True
        panelDrinks.Visible = False
        ' Retrieve the data from the database
        Dim data As DataTable = RetrieveDataFromDatabase()
        ReDim selectedFoodArray(data.Rows.Count - 1, 1)

        ' Create buttons dynamically based on each entry
        For i As Integer = 0 To data.Rows.Count - 1
            Dim row As DataRow = data.Rows(i)
            Dim button As New Button()
            button.Width = CInt(Me.Width * 0.7)
            button.Height = 80
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderSize = 0

            Dim foodLabel As New Label()
            foodLabel.Text = row("FoodName").ToString()
            foodLabel.Location = New Point(10, 10)
            foodLabel.Width = CInt(button.Width * 0.3)


            Dim descriptionLabel As New Label()
            descriptionLabel.Text = row("desc").ToString()
            descriptionLabel.Location = New Point(foodLabel.Right + 20, 10)
            descriptionLabel.Width = CInt(button.Width * 0.3)

            Dim priceLabel As New Label()
            priceLabel.Text = "Price: RM" & row("Price").ToString()
            priceLabel.Location = New Point(button.Width - 100, 10)
            priceLabel.Width = CInt(button.Width * 0.4)

            button.AutoSize = False
            button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            button.Location = New System.Drawing.Point(50, 115)
            button.Padding = New System.Windows.Forms.Padding(20)
            button.Size = New System.Drawing.Size(585, 71)
            button.TabIndex = 28
            button.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))

            Dim rectangle As New Rectangle(0, 0, button.Width, button.Height)
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim radius As Integer = 22
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90)
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90)
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90)
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90)
            path.CloseAllFigures()
            button.Region = New Region(path)

            ' Add the labels to the button
            button.Controls.Add(foodLabel)
            button.Controls.Add(descriptionLabel)
            button.Controls.Add(priceLabel)

            Dim foodID As Integer = Convert.ToInt32(row("ID"))

            AddHandler button.Click, Sub(buttonSender As Object, buttonEventArgs As EventArgs)
                                         HandleButtonClick(foodID)
                                     End Sub

            ' Add the button to the FlowLayoutPanel
            If (Convert.ToInt32(row("Food")) = 1) Then
                panelFood.Controls.Add(button)
            Else
                panelDrinks.Controls.Add(button)
            End If

            selectedFoodArray(i, 0) = foodID
            selectedFoodArray(i, 1) = 0
        Next
    End Sub

    Private Function RetrieveDataFromDatabase() As DataTable
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Dim query As String = "SELECT * FROM FoodList" ' Replace "YourTableName" with the appropriate table name in your database

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using command As New OleDbCommand(query, connection)
                Dim dataAdapter As New OleDbDataAdapter(command)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)

                Return dataTable
            End Using
        End Using
    End Function

    Private Sub HandleButtonClick(foodID As Integer)
        Dim quantity As String = InputBox("Enter the quantity:", "Add Quantity", "1")

        Dim parsedQuantity As Integer
        If Integer.TryParse(quantity, parsedQuantity) Then
            ' Update the selected quantity in the array
            For i As Integer = 0 To selectedFoodArray.GetLength(0) - 1
                If selectedFoodArray(i, 0) = foodID Then
                    selectedFoodArray(i, 1) = parsedQuantity
                    Exit For
                End If
            Next

            MessageBox.Show($"Selected quantity for food ID {foodID}: {parsedQuantity}")
        Else
            MessageBox.Show("Invalid quantity input. Please enter a valid numeric value.")
        End If
    End Sub

    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click

        panelFood.Visible = True
        panelDrinks.Visible = False
    End Sub

    Private Sub btnDrink_Click(sender As Object, e As EventArgs) Handles btnDrink.Click

        panelFood.Visible = False
        panelDrinks.Visible = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CustomerMainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cartPage As New CartPage(selectedFoodArray)
        cartPage.Show()
        Me.Hide()
    End Sub

    Private Sub panelOnBtnFood_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CustomerMainMenu.Show()
        Me.Hide()
    End Sub
End Class
