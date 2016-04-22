Public Class Form8

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub DataAnalysisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataAnalysisToolStripMenuItem.Click
        Form3.Show()
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

    Private Sub LogOutToolStripMenuitem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        MsgBox("Thank you for using NetSec Manager", MsgBoxStyle.Information, "NetSec Manager: Log Out")
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Nmap Cheat Sheet.PNG")
            Case 1
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Aggregate Time Options.PNG")
            Case 2
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Base Syntax.PNG")
            Case 3
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Fine-Grained Timing Options.PNG")
            Case 4
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Misc Options.PNG")
            Case 5
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Notable Scripts.PNG")
            Case 6
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Output Formats.PNG")
            Case 7
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Probing Options.PNG")
            Case 8
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Scan Types.PNG")
            Case 9
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Script Categories.PNG")
            Case 10
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Scripting Engine.PNG")
            Case 11
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Target Ports.PNG")
            Case 12
                PictureBox1.Image = Image.FromFile("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Images\Nmap Cheat Sheet\Target Specification.PNG")

        End Select
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
        Dim config As New ProcessStartInfo("C:\Users\Yan Wisdom\Documents\Visual Studio 2015\Projects\NetsecManagerv3\NetsecManagerv3\Processes\scan.exe")
        config.RedirectStandardError = True
        config.RedirectStandardOutput = True
        config.CreateNoWindow = False
        config.WindowStyle = ProcessWindowStyle.Hidden
        config.UseShellExecute = False

        Dim process As Process = Process.Start(config)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub
End Class