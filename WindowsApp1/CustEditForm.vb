Public Class CustEditForm

    Private id As Integer
    Private custName As String
    Private custAddress As String
    Private custContact As String

    'Constructor Override to get values from ProductForm Datagridview 
    Public Sub New(id As Integer, custName As String, custAddress As String, custContact As String)
        InitializeComponent()
        Me.id = id
        tbCustName.Text = custName
        tbCustAddress.Text = custAddress
        tbCustContact.Text = custContact
    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        Dim customer As New CustomerMain()
        Dim result = customer.Update(
            id,
            tbCustName.Text,
            tbCustAddress.Text,
            tbCustContact.Text
            )
        If result = True Then
            MessageBox.Show("Customer Successfully Updated.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProductForm.LoadData()
            Dispose()
        Else
            MessageBox.Show("Failed to update customer. Please try again", "Update Fail", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        tbCustName.Clear()
        tbCustAddress.Clear()
        tbCustContact.Clear()
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub
End Class