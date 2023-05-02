Imports System.Data.OleDb

Public Class Login

    Private Sub tb_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Password.KeyPress
        'Login when press enter key
        If e.KeyChar = ChrW(Keys.Enter) Then
            bt_Login.PerformClick()
        End If
    End Sub

    Private Sub cb_Showpass_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Showpass.CheckedChanged
        'Show Password texts when checkbox is clicked
        If cb_Showpass.Checked Then
            tb_Password.UseSystemPasswordChar = False
        Else
            tb_Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub bt_Cancel_Click(sender As Object, e As EventArgs) Handles bt_Cancel.Click
        End 'Closes the app when clicked
    End Sub

    Private Sub bt_Login_Click(sender As Object, e As EventArgs) Handles bt_Login.Click
        'Validate user input
        If tb_Username.Text = "" Or tb_Password.Text = "" Then
            MessageBox.Show("Please enter required fields!", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ArjayProgramPractice\WindowsApp1\Database\InventoryManagement.accdb"
            Dim sql As String = "SELECT AdmnUser, AdmnPass FROM Admn WHERE AdmnUser =@AdmnUser AND AdmnPass = @AdmnPass "
            Try
                Using conn As New OleDbConnection(connString), cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.Add("@AdmnUser", OleDbType.VarChar).Value = tb_Username.Text.Trim()
                    cmd.Parameters.Add("@AdmnPass", OleDbType.VarChar).Value = tb_Password.Text.Trim()
                    Try
                        conn.Open()
                        Using dr As OleDbDataReader = cmd.ExecuteReader()
                            If dr.Read() Then
                                Product.Show()
                                Me.Hide()
                            Else
                                MessageBox.Show("Username and Password did not match!", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                            conn.Close()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Failed to connect to database.", "Database connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            Catch ex As Exception

            End Try

        End If
    End Sub



End Class