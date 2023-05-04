Public Class CategoryForm

    Private category As New CategoryMain()

    Private Sub CategoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    'Populates Datagridview from Main Class
    Public Sub LoadData()
        db_Datagrid.DataSource = category.GetAll()
    End Sub

    Public Sub ClearData()
        'Clears data in text boxes
        tbCategoryID.Clear()
        tbCatName.Clear()
        tb_SearchBar.Clear()
    End Sub

    Private Sub bt_Add_Click(sender As Object, e As EventArgs) Handles bt_Add.Click
        Dim category As New CategoryMain
        Dim categoryName = tbCatName.Text.Trim()
        If Not tbCatName.Text = "" Then
            Dim result = category.Add(CInt(tbCategoryID.Text), categoryName)
            If result Then
                MessageBox.Show("Category Successfully Added", "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearData()
            Else
                MessageBox.Show("Failed to add Category. Please try again.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Invalid input. Please enter a category.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub bt_Edit_Click(sender As Object, e As EventArgs) Handles bt_Edit.Click
        'Add the values selected from datagridview to the following variables
        Dim id = db_Datagrid.CurrentRow.Cells(0).Value
        Dim prodCategory = db_Datagrid.CurrentRow.Cells(1).Value

        'Transfer variable values for EditForm
        Dim edit As New CatEditForm(id, prodCategory)
        edit.Show()
    End Sub

    Private Sub bt_Delete_Click(sender As Object, e As EventArgs) Handles bt_Delete.Click
        'Executes deleting the data selected from rows
        Dim confMsg = MessageBox.Show("Are you sure you want to delete this item?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confMsg = DialogResult.Yes Then
            Dim result = category.Delete(db_Datagrid.CurrentRow.Cells(0).Value)
            If result Then
                MessageBox.Show("Category Succesfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
            Else
                MessageBox.Show("Failed to delete category. Please try again", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
            Dim filteredRows = dt.AsEnumerable().Where(Function(row) row.Field(Of String)("ProdCategory").IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
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