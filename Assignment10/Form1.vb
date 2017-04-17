Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MyClock1.ForeColor = Color.Red Then
            MyClock1.ForeColor = Color.Black
        Else
            MyClock1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.BackColor = Color.Blue Then
            Me.BackColor = Color.White
        Else
            Me.BackColor = Color.Blue
        End If
    End Sub
End Class
