Imports System.Data.OleDb

Public Class DeleteCustomer

    Private Sub DeleteCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve the data from the database
        Dim data As DataTable = RetrieveDataFromDatabase()

        ' Create objects dynamically based on each entry
        For Each row As DataRow In data.Rows
            ' Create the CheckBox
            Dim checkBox As New CheckBox()
            checkBox.AutoSize = False
            checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            checkBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            checkBox.Location = New System.Drawing.Point(50, 115)
            checkBox.Padding = New System.Windows.Forms.Padding(20)
            checkBox.Size = New System.Drawing.Size(676, 71)
            checkBox.TabIndex = 28
            checkBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
            checkBox.UseVisualStyleBackColor = True

            ' Create the Label

            checkBox.Text = row("Username").ToString()

            ' Set corner radius
            Dim rectangle As New Rectangle(0, 0, checkBox.Width, checkBox.Height)
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim radius As Integer = 22
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90)
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90)
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90)
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90)
            path.CloseAllFigures()
            checkBox.Region = New Region(path)


            ' Add the controls to the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Add(checkBox)
        Next
    End Sub
    Private Function RetrieveDataFromDatabase() As DataTable
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Dim query As String = "SELECT * FROM UserInfo" ' Replace "YourTableName" with the appropriate table name in your database

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

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ' Delete the selected entries
        For Each control As Control In FlowLayoutPanel1.Controls
            If TypeOf control Is CheckBox AndAlso DirectCast(control, CheckBox).Checked Then
                Dim username As String = DirectCast(control, CheckBox).Text
                DeleteEntry(username)
            End If
        Next

        ' Refresh the displayed data
        FlowLayoutPanel1.Controls.Clear()
        DeleteCustomer_Load(Nothing, Nothing)
    End Sub

    Private Sub DeleteEntry(username As String)
        ' Perform the deletion in the database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\danis\Documents\FoodDatabase.mdb"
        Dim query As String = "DELETE FROM UserInfo WHERE Username = @username"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click
        AdminMainMenu.Show()
        Me.Hide()
    End Sub

End Class