Public Class CatEditForm
    Private id As Integer
    Private prodCategory As String


    'Constructor Override to get values from ProductForm Datagridview 
    Public Sub New(id As Integer, prodCategory As String)
        InitializeComponent()
        Me.id = id
        tbCatName.Text = prodCategory

    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        Dim category As New CategoryMain()
        Dim result = category.Update(id, tbCatName.Text)

        If result = True Then
            MessageBox.Show("Product Successfully Updated", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CategoryForm.LoadData()
            Dispose()
        Else
            MessageBox.Show("Failed to update product. Please try again", "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        tbCatName.Clear()
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
        CategoryForm.Show()
    End Sub

End Class