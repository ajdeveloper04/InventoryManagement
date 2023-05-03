Imports System.Data.OleDb

Public Class Product

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
                Using cmd As New OleDbCommand("SELECT * FROM ProdList", conn)
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

    Public Function Add(id As Integer, prodName As String, prodDescription As String,
                        prodCategory As String, prodQuantity As Integer, prodPrice As Decimal) As Boolean
        Try
            conn.ConnectionString = constring
            conn.Open()

            sql = "INSERT INTO ProdList (ProdID, ProdName, ProdDecription, ProdCategory, ProdQuantity, ProdPrice) " &
                "VALUES (@ProdID, @ProdName, @ProdDescription, @ProdCategory, @ProdQuantity, @ProdPrice)"

            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ProdID", id)
            cmd.Parameters.AddWithValue("@ProdName", prodName)
            cmd.Parameters.AddWithValue("@ProdDecription", prodDescription)
            cmd.Parameters.AddWithValue("@ProdCategory", prodCategory)
            cmd.Parameters.AddWithValue("@ProdQuantity", prodQuantity)
            cmd.Parameters.AddWithValue("@ProdPrice", prodPrice)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function Update(id As Integer, prodName As String, prodDescription As String,
                           prodCategory As String, prodQuantity As Integer, prodPrice As Decimal) As Boolean
        Try
            conn.ConnectionString = constring
            conn.Open()

            sql = "UPDATE ProdList SET ProdName = @ProdName, ProdDecription = @ProdDescription , ProdCategory = @ProdCategory, ProdQuantity = @ProdQuantity, ProdPrice =  @ProdPrice WHERE ProdID = @ProdID"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ProdName", prodName)
            cmd.Parameters.AddWithValue("@ProdDescription", prodDescription)
            cmd.Parameters.AddWithValue("@ProdCategory", prodCategory)
            cmd.Parameters.AddWithValue("@ProdQuantity", prodQuantity)
            cmd.Parameters.AddWithValue("@ProdPrice", prodPrice)
            cmd.Parameters.AddWithValue("@ProdID", id)
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
            cmd.CommandText = "DELETE FROM ProdList WHERE ProdID = @Id"
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
