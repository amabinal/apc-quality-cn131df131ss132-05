Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "2013-100096" Then
            MsgBox("You are now logged in", MsgBoxStyle.Information, "Login")
            Form2.Show()
            Me.Hide()


        Else
            If TextBox1.Text = "" Then
                MsgBox("No Username Found!", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Invalid Username and/or Password!", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
