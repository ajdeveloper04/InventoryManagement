Public Class TransactionForm
    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub bt_Edit_Click(sender As Object, e As EventArgs) Handles bt_Edit.Click
        TransEditForm.Show()
    End Sub
End Class