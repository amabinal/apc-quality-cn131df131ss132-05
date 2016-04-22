Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As New MySqlConnection
    Dim sql As MySqlCommand

    Public Sub connect()
        Dim dbname As String = "netsec2"
        Dim server As String = "localhost"
        Dim username As String = "root"
        Dim password As String = ""

        If Not conn Is Nothing Then conn.Close()

        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=False", server, username, password, dbname)
        Dim dbreader As MySqlDataReader

        Try
            conn.Open()
            Dim Query As String
            Query = "select * from admin where AdminNum ='" & TextBox1.Text & "' "
            sql = New MySqlCommand(Query, conn)
            dbreader = sql.ExecuteReader
            Dim count As Integer
            count = 0
            While dbreader.Read
                count = count + 1
            End While

            If count = 1 Then
                Form2.Show()
                Me.Hide()
            Else
                MsgBox("Not registered. Please contact system administrator.")
            End If

            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
