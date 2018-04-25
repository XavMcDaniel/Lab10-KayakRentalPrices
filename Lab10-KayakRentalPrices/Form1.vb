Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllPricesDataSet.RentalPrices' table. You can move, or remove it, as needed.
        Me.RentalPricesTableAdapter.Fill(Me.AllPricesDataSet.RentalPrices)

    End Sub
End Class
