Imports System.Net
Public Class IPFinder
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Hostname As IPHostEntry = Dns.GetHostByName(TextBox1.Text)
        Dim IP As IPAddress() = Hostname.AddressList
        TextBox2.Text = IP(0).ToString
    End Sub
End Class