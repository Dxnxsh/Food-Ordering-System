Public Class CheckOutPage
    Private selectedFoodArray(,) As Integer
    Private totalAmount As Decimal

    Public Sub New(selectedFoodArray As Integer(,), totalAmount As Decimal)
        InitializeComponent()

        ' Store the selected food array and total amount from the previous form
        Me.selectedFoodArray = selectedFoodArray
        Me.totalAmount = totalAmount
        lblDisplay.Text = "RM" + totalAmount.ToString
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' Pass the selected food array and total amount to the CheckOutPage form
        Dim orderSuccesfulPage As New OrderSuccesfulPage(selectedFoodArray, totalAmount)
        orderSuccesfulPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim cartPage As New CartPage(selectedFoodArray)
        cartPage.Show()
        Me.Hide()
    End Sub

    Private Sub lblDisplay_Click(sender As Object, e As EventArgs) Handles lblDisplay.Click

    End Sub
End Class