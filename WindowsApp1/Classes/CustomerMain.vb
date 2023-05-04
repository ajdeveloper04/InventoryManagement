Imports System.Data.OleDb

Public Class CustomerMain
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
                Using cmd As New OleDbCommand("SELECT * FROM CustList", conn)
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

    Public Function Add(id As Integer, custName As String, custAddress As String,
                        custContact As String) As Boolean
        Try
            conn.ConnectionString = constring
            conn.Open()

            sql = "INSERT INTO CustList (ID, CustName, CustAddress, CustContact) " &
                "VALUES (@ID, @CustName, @CustAddress, @CustContact)"

            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ID", id)
            cmd.Parameters.AddWithValue("@CustName", custName)
            cmd.Parameters.AddWithValue("@CustAddress", custAddress)
            cmd.Parameters.AddWithValue("@CustContact", custContact)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Public Function Update(id As Integer, custName As String, custAddress As String,
                        custContact As String) As Boolean
        Try
            conn.ConnectionString = constring
            conn.Open()

            sql = "UPDATE CustList SET CustName = @CustName, CustAddress = @CustAddress , CustContact = @CustContact WHERE ID = @ID"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@CustName", custName)
            cmd.Parameters.AddWithValue("@CustAddress", custAddress)
            cmd.Parameters.AddWithValue("@CustContact", custContact)
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
            cmd.CommandText = "DELETE FROM CustList WHERE ID = @Id"
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
