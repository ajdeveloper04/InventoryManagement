Imports System.Data.OleDb

Public Class Product
    Dim conn As New OleDbConnection()
    Dim dr As OleDbDataReader
    Dim dt As DataTable
    Dim cmd As New OleDbCommand()
    Dim index As Integer
    Dim sql As String

    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ArjayProgramPractice\WindowsApp1\Database\InventoryManagement.accdb"
    Private e As Object

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Opens a connection from database and shows data tables to datagridview
        conn.ConnectionString = constring
        conn.Open()
        _datagridShow()
    End Sub

    Private Sub _datagridShow()
        'Displays data in datagridview
        Try
            Dim ds As New DataSet
            Dim da As New OleDbDataAdapter

            dt = New DataTable()
            da = New OleDbDataAdapter("Select * from ProdList", conn)
            da.Fill(dt)
            db_Datagrid.DataSource = dt.DefaultView
            conn.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub db_Datagrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles db_Datagrid.CellClick
        'Displays the texts of selected rows to the text boxes
        Try
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = db_Datagrid.Rows(index)

            tb_ProdID.Text = selectedRow.Cells(0).Value.ToString()
            tb_ProdName.Text = selectedRow.Cells(1).Value.ToString()
            tb_Description.Text = selectedRow.Cells(2).Value.ToString()
            cb_Category.Text = selectedRow.Cells(3).Value.ToString()
            tb_Quantity.Text = selectedRow.Cells(4).Value.ToString()
            tb_Price.Text = selectedRow.Cells(5).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub _Add()
        'Opens a connection to database and closes after data input
        Try

            conn.ConnectionString = constring
            conn.Open()

            sql = "INSERT INTO ProdList (ProdID, ProdName, ProdDecription, ProdCategory, ProdQuantity, ProdPrice) VALUES ('" &
                tb_ProdID.Text & "','" & tb_ProdName.Text & "', '" & tb_Description.Text & "', '" & cb_Category.Text & "', '" & tb_Quantity.Text & "', '" & tb_Price.Text & "')"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ProdID", Convert.ToInt32(tb_ProdID.Text))
            cmd.Parameters.AddWithValue("@ProdName", tb_ProdName.Text)
            cmd.Parameters.AddWithValue("@ProdDecription", tb_Description.Text)
            cmd.Parameters.AddWithValue("@ProdCategory", cb_Category.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@ProdQuantity", Convert.ToInt32(tb_Quantity.Text))
            cmd.Parameters.AddWithValue("@ProdPrice", Convert.ToInt32(tb_Price.Text))

            cmd.ExecuteNonQuery()
            MsgBox("Product Added.", vbInformation)
            _datagridShow()
        Catch ex As Exception
            MessageBox.Show("Please the right value.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        conn.Close()
        _ClearData()
    End Sub

    Public Sub _Edit()
        'Updates data in the selected rows
        Try
            conn.ConnectionString = constring
            conn.Open()

            sql = "UPDATE ProdList SET ProdID = '" & tb_ProdID.Text & "', ProdName = '" & tb_ProdName.Text &
                    "', ProdDecription = '" & tb_Description.Text & "' , ProdCategory = '" & cb_Category.Text & "', ProdQuantity = '" _
                    & tb_Quantity.Text & "', ProdPrice =  '" & tb_Price.Text & "' WHERE ProdID = " & tb_ProdID.Text
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ProdID", Convert.ToInt32(tb_ProdID.Text))
            cmd.Parameters.AddWithValue("@ProdName", tb_ProdName.Text)
            cmd.Parameters.AddWithValue("@ProdDecription", tb_Description.Text)
            cmd.Parameters.AddWithValue("@ProdCategory", cb_Category.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@ProdQuantity", Convert.ToInt32(tb_Quantity.Text))
            cmd.Parameters.AddWithValue("@ProdPrice", Convert.ToInt32(tb_Price.Text))
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(tb_ProdID.Text))

            cmd.ExecuteNonQuery()
            MsgBox("Product Updated.", vbInformation)
            _datagridShow()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
        _ClearData()
    End Sub

    Private Sub Delete(id As Integer)

        Try
            Dim confMsg = MessageBox.Show("Are you sure you want to Delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confMsg = DialogResult.Yes Then
                conn.Open()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from prodlist where prodid = @prodid"
                cmd.Parameters.AddWithValue("@prodid", id)
                cmd.ExecuteNonQuery()
                MsgBox("Selected row deleted successfully.")
                _datagridShow()
            End If
        Catch ex As Exception
            conn.Close()
        End Try
    End Sub

    Sub _ClearData()
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
        _Add()
    End Sub

    Private Sub bt_Edit_Click(sender As Object, e As EventArgs) Handles bt_Edit.Click
        'Enables the user to edit the text from selected rows
        Try
            Dim newDataRow As DataGridViewRow
            newDataRow = db_Datagrid.Rows(index)
            newDataRow.Cells(0).Value = tb_ProdID.Text
            newDataRow.Cells(1).Value = tb_ProdName.Text
            newDataRow.Cells(2).Value = tb_Description.Text
            newDataRow.Cells(3).Value = cb_Category.Text
            newDataRow.Cells(4).Value = tb_Quantity.Text
            newDataRow.Cells(5).Value = tb_Price.Text
            _Edit()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bt_Delete_Click(sender As Object, e As EventArgs) Handles bt_Delete.Click
        'Executes deleting the data selected from rows
        Delete(db_Datagrid.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub bt_Clear_Click(sender As Object, e As EventArgs) Handles bt_Clear.Click
        'Excutes clearing data in text boxes when button clear is clicked
        _ClearData()
    End Sub

    Private Sub bt_Find_Click(sender As Object, e As EventArgs) Handles bt_Find.Click
        'Finds a specific item in datagridview
        Try
            Dim searchText As String = tb_SearchBar.Text.Trim()
            Dim dtFiltered As DataTable = dt.AsEnumerable().Where(Function(row) row.Field(Of String)("ProdName").IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).CopyToDataTable()
            db_Datagrid.DataSource = dtFiltered
        Catch ex As Exception
            MessageBox.Show("No Items found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tb_SearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_SearchBar.KeyPress
        'Executes search item when Find button is clicked
        If e.KeyChar = ChrW(Keys.Enter) Then
            bt_Find.PerformClick()
        End If
    End Sub

    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        'Opens a connection from database and shows data tables to datagridview
        conn.ConnectionString = constring
        conn.Open()
        _datagridShow()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        'Closes the app when the x button is clicked
        Application.Exit()
    End Sub

End Class