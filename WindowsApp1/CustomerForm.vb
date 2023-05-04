Public Class CustomerForm
    Private customer As New CustomerMain()

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    'Populates Datagridview from Main Class
    Public Sub LoadData()
        db_Datagrid.DataSource = customer.GetAll()
    End Sub

    Public Sub ClearData()
        'Clears data in text boxes
        tbCustID.Clear()
        tbCustName.Clear()
        tbCustAddress.Clear()
        tbCustContact.Clear()
        tb_SearchBar.Clear()
    End Sub

    Private Sub bt_Add_Click(sender As Object, e As EventArgs) Handles bt_Add.Click
        Dim customer As New CustomerMain
        Dim custName = tbCustName.Text.Trim()
        Dim custAddress = tbCustAddress.Text.Trim()
        Dim custContact = tbCustContact.Text.Trim()
        If Not tbCustName.Text = "" And Not tbCustAddress.Text = "" And Not tbCustContact.Text = "" Then
            Dim result = customer.Add(CInt(tbCustID.Text), custName, custAddress, custContact)
            If result Then
                MessageBox.Show("Customer Successfully Added", "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearData()
            Else
                MessageBox.Show("Failed to add customer. Please try again.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Invalid input. Please enter a customer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub bt_Edit_Click(sender As Object, e As EventArgs) Handles bt_Edit.Click
        'Add the values selected from datagridview to the following variables
        Dim id = db_Datagrid.CurrentRow.Cells(0).Value
        Dim custName = db_Datagrid.CurrentRow.Cells(1).Value
        Dim custAddress = db_Datagrid.CurrentRow.Cells(2).Value
        Dim custContact = db_Datagrid.CurrentRow.Cells(3).Value
        Dim edit As New CustEditForm(id, custName, custAddress, custContact)
        edit.Show()
    End Sub

    Private Sub bt_Delete_Click(sender As Object, e As EventArgs) Handles bt_Delete.Click
        'Executes deleting the data selected from rows
        Dim confMsg = MessageBox.Show("Are you sure you want to delete this item?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confMsg = DialogResult.Yes Then
            Dim result = customer.Delete(db_Datagrid.CurrentRow.Cells(0).Value)
            If result Then
                MessageBox.Show("Customer Succesfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
            Else
                MessageBox.Show("Failed to delete Customer. Please try again", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
            Dim filteredRows = dt.AsEnumerable().Where(Function(row) row.Field(Of String)("CustName").IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
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

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        Me.Close()
        Home.Show()
    End Sub
End Class