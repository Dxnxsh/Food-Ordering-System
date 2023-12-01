Public Class ProfileEdit
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CustomerMainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        EditUsername.Show()
        Me.Hide()
    End Sub

    Private Sub btnEditPass_Click(sender As Object, e As EventArgs) Handles btnEditPass.Click
        EditPassword.Show()
        Me.Hide()
    End Sub

    Private Sub ProfileEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class