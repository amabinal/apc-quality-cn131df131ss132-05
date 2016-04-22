Imports MySql.Data.MySqlClient
Public Class Form3
    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub AttackAdviserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttackAdviserToolStripMenuItem.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub RulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RulesToolStripMenuItem.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub SystemInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemInformationToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub OpenConfigurationFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenConfigurationFileToolStripMenuItem.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub NmapCheatSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NmapCheatSheetToolStripMenuItem.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuitem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        MsgBox("Thank you for using NetSec Manager", MsgBoxStyle.Information, "NetSec Manager: Log Out")
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub NmapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NmapToolStripMenuItem.Click
        Dim config As New ProcessStartInfo("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Processes\nmap.bat")
        config.RedirectStandardError = True
        config.RedirectStandardOutput = True
        config.CreateNoWindow = False
        config.WindowStyle = ProcessWindowStyle.Hidden
        config.UseShellExecute = False

        Dim process As Process = Process.Start(config)
    End Sub

    Private Sub StartScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartScanToolStripMenuItem.Click
        Dim config As New ProcessStartInfo("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Processes\cmd.bat")
        config.RedirectStandardError = True
        config.RedirectStandardOutput = True
        config.CreateNoWindow = False
        config.WindowStyle = ProcessWindowStyle.Hidden
        config.UseShellExecute = False

        Dim process As Process = Process.Start(config)
    End Sub

    Private Sub SnifferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SnifferToolStripMenuItem.Click
        Dim config As New ProcessStartInfo("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\sniff\dist\scan.exe")
        config.RedirectStandardError = True
        config.RedirectStandardOutput = True
        config.CreateNoWindow = False
        config.WindowStyle = ProcessWindowStyle.Hidden
        config.UseShellExecute = False

        Dim process As Process = Process.Start(config)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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