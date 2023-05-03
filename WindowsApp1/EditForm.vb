
Public Class EditForm
    Private id As Integer
    Private prodName As String
    Private prodDescription As String
    Private prodCategory As String
    Private prodQuantity As Integer
    Private prodPrice As Decimal

    'Constructor Override to get values from ProductForm Datagridview 
    Public Sub New(id As Integer, prodName As String, prodDescription As String, prodCategory As String, prodQuantity As Integer, prodPrice As Decimal)
        InitializeComponent()
        Me.id = id
        tb_ProdName.Text = prodName
        tb_Description.Text = prodDescription
        cb_Category.Text = prodCategory
        tb_Quantity.Text = prodQuantity
        tb_Price.Text = prodPrice
    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        Dim product As New Product()
        Dim result = product.Update(
            id,
            tb_ProdName.Text,
            tb_Description.Text,
            cb_Category.SelectedItem().ToString,
            CInt(tb_Quantity.Text),
            CDbl(tb_Price.Text)
            )
        If result = True Then
            MessageBox.Show("Product Successfully Updated", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProductForm.LoadData()
            Dispose()
        Else
            MessageBox.Show("Failed to update product. Please try again", "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        tb_ProdName.Clear()
        tb_Description.Clear()
        tb_Quantity.Clear()
        tb_Price.Clear()
        cb_Category.SelectedIndex = -1
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub
End Class