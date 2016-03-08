Imports MySql.Data.MySqlClient
Public Class viewdata
    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection()
        SQL = "SELECT pid, src, dst, ttl, chksum FROM sniff"

        'Connection String
        conn.ConnectionString = "server=localhost;" _
        & "user id=root;" _
        & "password=;" _
        & "database=netsec"

        Try
            conn.Open()
            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            DataGridView1.DataSource = myData

        Catch ex As MySqlException
            MessageBox.Show("Cannot connect to db" & ex.Message)

        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub
End Class