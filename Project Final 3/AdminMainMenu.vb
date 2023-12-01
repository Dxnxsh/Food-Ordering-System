Public Class AdminMainMenu
    Private Sub btnAddFood_Click(sender As Object, e As EventArgs) Handles btnAddFood.Click
        AddFood.Show()
        Me.Hide()
    End Sub

    Private Sub btnDeleteFood_Click(sender As Object, e As EventArgs) Handles btnDeleteFood.Click
        DeleteFood.Show()
        Me.Hide()
    End Sub

    Private Sub btnEditCust_Click(sender As Object, e As EventArgs) Handles btnEditCust.Click
        EditCustomerInfo.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteCustomer.Show()
        Me.Hide()
    End Sub



    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub AdminMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCheckOrderH_Click(sender As Object, e As EventArgs) Handles btnCheckOrderH.Click
        AdminHistory.Show()
        Me.Hide()
    End Sub
End Class