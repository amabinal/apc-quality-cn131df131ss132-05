Imports System.Net
Public Class Form2
    Private Sub HostDiscoveryToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IPScanToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub OpenConfigurationFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenConfigicgurationFileToolStripMenuItem.Click
        Dim config As New ProcessStartInfo("C:\Users\Yan Wisdom\Desktop\Processes\snortconf.bat")
        config.RedirectStandardError = True
        config.RedirectStandardOutput = True
        config.CreateNoWindow = False
        config.WindowStyle = ProcessWindowStyle.Hidden
        config.UseShellExecute = False

        Dim process As Process = Process.Start(config)
    End Sub

    Private Sub AddAnotherUserToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AddUser.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub WiresharkToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim config As New ProcessStartInfo("C:\Users\Yan Wisdom\Desktop\Processes\wireshark.bat")
        config.RedirectStandardError = True
        config.RedirectStandardOutput = True
        config.CreateNoWindow = False
        config.WindowStyle = ProcessWindowStyle.Hidden
        config.UseShellExecute = False

        Dim process As Process = Process.Start(config)
    End Sub

    Private Sub NmapGUIToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim config As New ProcessStartInfo("C:\Users\Yan Wisdom\Desktop\Processes\nmap.bat")
        config.RedirectStandardError = True
        config.RedirectStandardOutput = True
        config.CreateNoWindow = False
        config.WindowStyle = ProcessWindowStyle.Hidden
        config.UseShellExecute = False

        Dim process As Process = Process.Start(config)
    End Sub

    Private Sub IndividualHostScanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim config As New ProcessStartInfo("C:\Users\Yan Wisdom\Desktop\Processes\cmd.bat")
        config.RedirectStandardError = True
        config.RedirectStandardOutput = True
        config.CreateNoWindow = False
        config.WindowStyle = ProcessWindowStyle.Hidden
        config.UseShellExecute = False

        Dim process As Process = Process.Start(config)
    End Sub

    Private Sub StartScanCMDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartScanCMDToolStripMenuItem.Click
        Dim config As New ProcessStartInfo("C:\Users\Yan Wisdom\Desktop\Processes\cmd.bat")
        config.RedirectStandardError = True
        config.RedirectStandardOutput = True
        config.CreateNoWindow = False
        config.WindowStyle = ProcessWindowStyle.Hidden
        config.UseShellExecute = False

        Dim process As Process = Process.Start(config)
    End Sub

    Private Sub RulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RulesToolStripMenuItem.Click
        Dim config As New ProcessStartInfo("C:\Users\Yan Wisdom\Desktop\Processes\rules.bat")
        config.RedirectStandardError = True
        config.RedirectStandardOutput = True
        config.CreateNoWindow = False
        config.WindowStyle = ProcessWindowStyle.Hidden
        config.UseShellExecute = False

        Dim process As Process = Process.Start(config)
    End Sub

    Private Sub IPWhoisToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim config As New ProcessStartInfo("C:\Users\Yan Wisdom\Desktop\Processes\cmd.bat")
        config.RedirectStandardError = True
        config.RedirectStandardOutput = True
        config.CreateNoWindow = False
        config.WindowStyle = ProcessWindowStyle.Hidden
        config.UseShellExecute = False

        Dim process As Process = Process.Start(config)
    End Sub

    Private Sub IPFinderToolStripMenuItem_Click(sender As Object, e As EventArgs)
        IPFinder.Show()
    End Sub

    Private Sub IPScanToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles IPScanToolStripMenuItem.Click

    End Sub

    Private Sub ViewDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDataToolStripMenuItem.Click
        viewdata.Show()
    End Sub
End Class
