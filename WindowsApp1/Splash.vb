

Public Class Splash

    Dim counter As Integer = 0
    Dim counter2 As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Progress bar initiation
        If counter < 100 Then
            counter += 1
            pb_ProgressBar.Value = counter
            Select Case counter
                Case <= 30
                    counter2 += 1
                    GunaLabel1.Text = "Launching" & New String("."c, counter2 Mod 4)
                Case 31 To 60
                    counter2 += 1
                    GunaLabel1.Text = "Checking files" & New String("."c, counter2 Mod 4)
                Case 61 To 90
                    counter2 += 1
                    GunaLabel1.Text = "Gathering data" & New String("."c, counter2 Mod 4)
                Case 91 To 100
                    counter2 += 1
                    GunaLabel1.Text = "Please wait" & New String("."c, counter2 Mod 4)
            End Select
            If counter = 100 Then
                Me.Hide()
                Login.Show()
            End If
        End If


    End Sub

End Class
