Imports System.Data.OleDb

Public Class OrderHistory
    Private userID As Integer

    Private Sub OrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.userID = GlobalVariables.LoggedInUserID

        Dim vertScroll As Integer = SystemInformation.VerticalScrollBarWidth
        FlowLayoutPanel1.Padding = New Padding(0, 0, vertScroll, 0)


        ' Retrieve the data from the database
        Dim data As DataTable = RetrieveDataFromDatabase()

        ' Create panels dynamically based on each entry
        For Each row As DataRow In data.Rows
            Dim panel As New Label()
            panel.Width = CInt(Me.Width * (0.8))
            panel.Height = 80
            panel.BorderStyle = BorderStyle.None

            Dim dateLabel As New Label()
            dateLabel.Text = row("OrderDate").ToString()
            dateLabel.Location = New Point(10, 10)
            dateLabel.Width = CInt(panel.Width * 0.2)


            Dim orderLabel As New Label()
            orderLabel.Text = "Order ID: " & row("ID").ToString()
            orderLabel.Location = New Point(dateLabel.Right + 20, 10)
            orderLabel.Width = CInt(panel.Width * 0.2)


            Dim quantityLabel As New Label()
            quantityLabel.Text = "Quantity: " & row("Quantity").ToString()
            quantityLabel.Location = New Point(orderLabel.Right + 20, 10)
            quantityLabel.Width = CInt(panel.Width * 0.2)


            Dim priceLabel As New Label()
            priceLabel.Text = "Price: RM" & row("Amount").ToString()
            priceLabel.Location = New Point(panel.Width - 115, 10)
            priceLabel.Width = CInt(panel.Width * 1.5)


            panel.AutoSize = False
            panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            panel.Location = New System.Drawing.Point(50, 115)
            panel.Padding = New System.Windows.Forms.Padding(20)
            panel.Size = New System.Drawing.Size(676, 71)
            panel.TabIndex = 28
            panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))

            Dim rectangle As New Rectangle(0, 0, panel.Width, panel.Height)
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim radius As Integer = 22
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90)
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90)
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90)
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90)
            path.CloseAllFigures()
            panel.Region = New Region(path)

            ' Add the labels to the panel
            panel.Controls.Add(dateLabel)
            panel.Controls.Add(orderLabel)
            panel.Controls.Add(quantityLabel)
            panel.Controls.Add(priceLabel)

            ' Add the panel to the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Add(panel)
        Next
    End Sub



    Private Function RetrieveDataFromDatabase() As DataTable
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Dim query As String = "SELECT * FROM OrderHistory WHERE UserID = ?"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                Dim dataAdapter As New OleDbDataAdapter(command)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)

                Return dataTable
            End Using
        End Using
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CustomerMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class