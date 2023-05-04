Public Class Home
    Private Sub btProducts_Click(sender As Object, e As EventArgs) Handles btProducts.Click
        Me.Close()
        ProductForm.Show()
    End Sub

    Private Sub btCustomers_Click(sender As Object, e As EventArgs) Handles btCustomers.Click
        Me.Close()
        CustomerForm.Show()
    End Sub

    Private Sub btTransactions_Click(sender As Object, e As EventArgs) Handles btTransactions.Click
        Me.Close()
        TransactionForm.Show()
    End Sub

    Private Sub btCategories_Click(sender As Object, e As EventArgs) Handles btCategories.Click
        Me.Close()
        CategoryForm.Show()
    End Sub

    Private Sub btLogout_Click(sender As Object, e As EventArgs) Handles btLogout.Click
        End
    End Sub

End Class