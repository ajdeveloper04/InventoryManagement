Public Class TransEditForm
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
        TransactionForm.Show()
    End Sub
End Class