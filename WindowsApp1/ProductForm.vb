

Public Class ProductForm
    Private product As New Product()

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    'Populates Datagridview from Product Class
    Public Sub LoadData()
        db_Datagrid.DataSource = product.GetAll()
    End Sub

    Public Sub ClearData()
        'Clears data in text boxes
        tb_ProdID.Clear()
        tb_ProdName.Clear()
        tb_Description.Clear()
        tb_Quantity.Clear()
        tb_Price.Clear()
        cb_Category.SelectedIndex = -1
        tb_SearchBar.Clear()
    End Sub

    Private Sub bt_Add_Click(sender As Object, e As EventArgs) Handles bt_Add.Click
        Dim product As New Product
        Dim prodName = tb_ProdName.Text.Trim()
        Dim description = tb_Description.Text.Trim()
        Dim category = cb_Category.SelectedItem?.ToString()
        Dim quantity As Integer
        Dim price As Decimal
        If Integer.TryParse(tb_Quantity.Text.Trim(), quantity) AndAlso Decimal.TryParse(tb_Price.Text.Trim(), price) Then
            Dim result = product.Add(CInt(tb_ProdID.Text), prodName, description, category, quantity, price)
            If result Then
                MessageBox.Show("Product Successfully Added", "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearData()
            Else
                MessageBox.Show("Failed to add product. Please try again.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Invalid input. Please enter a product.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub bt_Edit_Click(sender As Object, e As EventArgs) Handles bt_Edit.Click
        'Add the values selected from datagridview to the following variables
        Dim id = db_Datagrid.CurrentRow.Cells(0).Value
        Dim prodName = db_Datagrid.CurrentRow.Cells(1).Value
        Dim prodDescription = db_Datagrid.CurrentRow.Cells(2).Value
        Dim prodCategory = db_Datagrid.CurrentRow.Cells(3).Value
        Dim prodQuantity = db_Datagrid.CurrentRow.Cells(4).Value
        Dim prodPrice = db_Datagrid.CurrentRow.Cells(5).Value
        'Transfer variable values for EditForm
        Dim edit As New EditForm(id, prodName, prodDescription, prodCategory, prodQuantity, CDbl(prodPrice))
        edit.Show()
    End Sub

    Private Sub bt_Delete_Click(sender As Object, e As EventArgs) Handles bt_Delete.Click
        'Executes deleting the data selected from rows
        Dim confMsg = MessageBox.Show("Are you sure you want to delete this item?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confMsg = DialogResult.Yes Then
            Dim result = product.Delete(db_Datagrid.CurrentRow.Cells(0).Value)
            If result Then
                MessageBox.Show("Product Succesfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
            Else
                MessageBox.Show("Failed to delete product. Please try again", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub bt_Clear_Click(sender As Object, e As EventArgs) Handles bt_Clear.Click
        'Excutes clearing data in text boxes when button clear is clicked
        ClearData()
    End Sub

    Private Sub bt_Find_Click(sender As Object, e As EventArgs) Handles bt_Find.Click
        Try
            'instantiate new datatable
            Dim dt As New DataTable
            'transfer datagrid data to datatable
            dt = db_Datagrid.DataSource
            Dim searchText As String = tb_SearchBar.Text.Trim()
            'filter datatable dt using LINQ
            Dim filteredRows = dt.AsEnumerable().Where(Function(row) row.Field(Of String)("ProdName").IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
            If filteredRows.Any() Then
                Dim dtFiltered As DataTable = filteredRows.CopyToDataTable()
                'set datagridview data to the filtered data
                db_Datagrid.DataSource = dtFiltered
            Else
                MessageBox.Show("No Items found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tb_SearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_SearchBar.KeyPress
        'Executes search item when Find button is clicked
        If e.KeyChar = ChrW(Keys.Enter) Then
            bt_Find.PerformClick()
        End If
    End Sub

    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        LoadData()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        'Closes the app when the x button is clicked
        Application.Exit()
    End Sub

End Class