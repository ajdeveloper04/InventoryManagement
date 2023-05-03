Public Class Home
    Private Sub btProducts_Click(sender As Object, e As EventArgs) Handles btProducts.Click
        Me.Close()
        ProductForm.Show()
    End Sub

    Private Sub btCustomers_Click(sender As Object, e As EventArgs) Handles btCustomers.Click
        Me.Close()
        CustomerForm.Show()
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        End
    End Sub
End Class