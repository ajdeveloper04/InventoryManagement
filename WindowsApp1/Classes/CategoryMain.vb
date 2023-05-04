Imports System.Data.OleDb

Public Class CategoryMain

    Private conn As New OleDbConnection()
    Private dr As OleDbDataReader
    Private dt As DataTable
    Private cmd As New OleDbCommand()
    Private da As New OleDbDataAdapter
    Private index As Integer
    Private sql As String

    Public Function GetAll() As DataTable
        'Get All Data From Databases
        Dim dt As New DataTable()
        Try
            Using conn As New OleDbConnection(constring)
                conn.Open()
                Using cmd As New OleDbCommand("SELECT * FROM CategoryList", conn)
                    Using da As New OleDbDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        Finally
            conn.Close()
        End Try

    End Function

    Public Function Add(id As Integer, prodCategory As String) As Boolean
        Try
            conn.ConnectionString = constring
            conn.Open()

            sql = "INSERT INTO CategoryList (ID, ProdCategory) VALUES (@ID, @ProdCategory)"

            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ID", id)
            cmd.Parameters.AddWithValue("@ProdCategory", prodCategory)

            'Execute the command to insert the data into the database
            cmd.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function Update(id As Integer, prodCategory As String) As Boolean
        Try
            conn.ConnectionString = constring
            conn.Open()

            sql = "UPDATE CategoryList SET ProdCategory = @ProdCategory WHERE ID = @ID"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ProdCategory", prodCategory)
            cmd.Parameters.AddWithValue("@ID", id)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
        End Try

    End Function

    Public Function Delete(id As Integer) As Boolean
        Try
            conn.ConnectionString = constring
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM CategoryList WHERE ID = @Id"
            cmd.Parameters.AddWithValue("@Id", id)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
        End Try
    End Function

End Class
