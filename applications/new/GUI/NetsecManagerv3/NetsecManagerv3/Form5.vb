Public Class Form5

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

    Private Sub SystemInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemInformationToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                RichTextBox1.LoadFile("C:\Snort\rules\app-detect.rules", RichTextBoxStreamType.PlainText)
            Case 1
                RichTextBox1.LoadFile("C:\Snort\rules\attack-responses.rules", RichTextBoxStreamType.PlainText)
            Case 2
                RichTextBox1.LoadFile("C:\Snort\rules\backdoor.rules", RichTextBoxStreamType.PlainText)
            Case 3
                RichTextBox1.LoadFile("C:\Snort\rules\bad-traffic.rules", RichTextBoxStreamType.PlainText)
            Case 4
                RichTextBox1.LoadFile("C:\Snort\rules\blacklist.rules", RichTextBoxStreamType.PlainText)
            Case 5
                RichTextBox1.LoadFile("C:\Snort\rules\botnet-cnc.rules", RichTextBoxStreamType.PlainText)
            Case 6
                RichTextBox1.LoadFile("C:\Snort\rules\browser-chrome.rules", RichTextBoxStreamType.PlainText)
            Case 7
                RichTextBox1.LoadFile("C:\Snort\rules\browser-firefox.rules", RichTextBoxStreamType.PlainText)
            Case 8
                RichTextBox1.LoadFile("C:\Snort\rules\browser-ie.rules", RichTextBoxStreamType.PlainText)
            Case 9
                RichTextBox1.LoadFile("C:\Snort\rules\browser-other.rules", RichTextBoxStreamType.PlainText)
            Case 10
                RichTextBox1.LoadFile("C:\Snort\rules\browser-plugins.rules", RichTextBoxStreamType.PlainText)
            Case 11
                RichTextBox1.LoadFile("C:\Snort\rules\browser-webkit.rules", RichTextBoxStreamType.PlainText)
            Case 12
                RichTextBox1.LoadFile("C:\Snort\rules\chat.rules", RichTextBoxStreamType.PlainText)
            Case 13
                RichTextBox1.LoadFile("C:\Snort\rules\content-replace.rules", RichTextBoxStreamType.PlainText)
            Case 14
                RichTextBox1.LoadFile("C:\Snort\rules\ddos.rules", RichTextBoxStreamType.PlainText)
            Case 15
                RichTextBox1.LoadFile("C:\Snort\rules\deleted.rules", RichTextBoxStreamType.PlainText)
            Case 16
                RichTextBox1.LoadFile("C:\Snort\rules\dns.rules", RichTextBoxStreamType.PlainText)
            Case 17
                RichTextBox1.LoadFile("C:\Snort\rules\dos.rules", RichTextBoxStreamType.PlainText)
            Case 18
                RichTextBox1.LoadFile("C:\Snort\rules\experimental.rules", RichTextBoxStreamType.PlainText)
            Case 19
                RichTextBox1.LoadFile("C:\Snort\rules\exploit.rules", RichTextBoxStreamType.PlainText)
            Case 20
                RichTextBox1.LoadFile("C:\Snort\rules\exploit-kit.rules", RichTextBoxStreamType.PlainText)
            Case 21
                RichTextBox1.LoadFile("C:\Snort\rules\file-executable.rules", RichTextBoxStreamType.PlainText)
            Case 22
                RichTextBox1.LoadFile("C:\Snort\rules\file-flash.rules", RichTextBoxStreamType.PlainText)
            Case 23
                RichTextBox1.LoadFile("C:\Snort\rules\file-identify.rules", RichTextBoxStreamType.PlainText)
            Case 24
                RichTextBox1.LoadFile("C:\Snort\rules\file-image.rules", RichTextBoxStreamType.PlainText)
            Case 25
                RichTextBox1.LoadFile("C:\Snort\rules\file-java.rules", RichTextBoxStreamType.PlainText)
            Case 26
                RichTextBox1.LoadFile("C:\Snort\rules\file-multimedia.rules", RichTextBoxStreamType.PlainText)
            Case 27
                RichTextBox1.LoadFile("C:\Snort\rules\file-office.rules", RichTextBoxStreamType.PlainText)
            Case 28
                RichTextBox1.LoadFile("C:\Snort\rules\file-other.rules", RichTextBoxStreamType.PlainText)
            Case 29
                RichTextBox1.LoadFile("C:\Snort\rules\file-pdf.rules", RichTextBoxStreamType.PlainText)
            Case 30
                RichTextBox1.LoadFile("C:\Snort\rules\finger.rules", RichTextBoxStreamType.PlainText)
            Case 31
                RichTextBox1.LoadFile("C:\Snort\rules\fpt.rules", RichTextBoxStreamType.PlainText)
            Case 32
                RichTextBox1.LoadFile("C:\Snort\rules\icmp.rules", RichTextBoxStreamType.PlainText)
            Case 33
                RichTextBox1.LoadFile("C:\Snort\rules\icmp-info.rules", RichTextBoxStreamType.PlainText)
            Case 34
                RichTextBox1.LoadFile("C:\Snort\rules\imap.rules", RichTextBoxStreamType.PlainText)
            Case 35
                RichTextBox1.LoadFile("C:\Snort\rules\indicator-compromise.rules", RichTextBoxStreamType.PlainText)
            Case 36
                RichTextBox1.LoadFile("C:\Snort\rules\indicator-obfuscation.rules", RichTextBoxStreamType.PlainText)
            Case 37
                RichTextBox1.LoadFile("C:\Snort\rules\indicator-scan.rules", RichTextBoxStreamType.PlainText)
            Case 38
                RichTextBox1.LoadFile("C:\Snort\rules\indicator-shellcode.rules", RichTextBoxStreamType.PlainText)
            Case 39
                RichTextBox1.LoadFile("C:\Snort\rules\info.rules", RichTextBoxStreamType.PlainText)
            Case 40
                RichTextBox1.LoadFile("C:\Snort\rules\local.rules", RichTextBoxStreamType.PlainText)
            Case 41
                RichTextBox1.LoadFile("C:\Snort\rules\malware-backdoor.rules", RichTextBoxStreamType.PlainText)
            Case 42
                RichTextBox1.LoadFile("C:\Snort\rules\malware-cnc.rules", RichTextBoxStreamType.PlainText)
            Case 43
                RichTextBox1.LoadFile("C:\Snort\rules\malware-other.rules", RichTextBoxStreamType.PlainText)
            Case 44
                RichTextBox1.LoadFile("C:\Snort\rules\malware-tools.rules", RichTextBoxStreamType.PlainText)
            Case 45
                RichTextBox1.LoadFile("C:\Snort\rules\misc.rules", RichTextBoxStreamType.PlainText)
            Case 46
                RichTextBox1.LoadFile("C:\Snort\rules\multimedia.rules", RichTextBoxStreamType.PlainText)
            Case 47
                RichTextBox1.LoadFile("C:\Snort\rules\mysql.rules", RichTextBoxStreamType.PlainText)
            Case 48
                RichTextBox1.LoadFile("C:\Snort\rules\netbios.rules", RichTextBoxStreamType.PlainText)
            Case 49
                RichTextBox1.LoadFile("C:\Snort\rules\nntp.rules", RichTextBoxStreamType.PlainText)
            Case 50
                RichTextBox1.LoadFile("C:\Snort\rules\oracle.rules", RichTextBoxStreamType.PlainText)
            Case 51
                RichTextBox1.LoadFile("C:\Snort\rules\os-linux.rules", RichTextBoxStreamType.PlainText)
            Case 52
                RichTextBox1.LoadFile("C:\Snort\rules\os-mobile.rules", RichTextBoxStreamType.PlainText)
            Case 53
                RichTextBox1.LoadFile("C:\Snort\rules\os-other.rules", RichTextBoxStreamType.PlainText)
            Case 54
                RichTextBox1.LoadFile("C:\Snort\rules\os-solaris.rules", RichTextBoxStreamType.PlainText)
            Case 55
                RichTextBox1.LoadFile("C:\Snort\rules\os-windows.rules", RichTextBoxStreamType.PlainText)
            Case 56
                RichTextBox1.LoadFile("C:\Snort\rules\other-ids.rules", RichTextBoxStreamType.PlainText)
            Case 57
                RichTextBox1.LoadFile("C:\Snort\rules\p2p.rules", RichTextBoxStreamType.PlainText)
            Case 58
                RichTextBox1.LoadFile("C:\Snort\rules\phishing-spam.rules", RichTextBoxStreamType.PlainText)
            Case 59
                RichTextBox1.LoadFile("C:\Snort\rules\policy.rules", RichTextBoxStreamType.PlainText)
            Case 60
                RichTextBox1.LoadFile("C:\Snort\rules\policy-multimedia.rules", RichTextBoxStreamType.PlainText)
            Case 61
                RichTextBox1.LoadFile("C:\Snort\rules\policy-other.rules", RichTextBoxStreamType.PlainText)
            Case 62
                RichTextBox1.LoadFile("C:\Snort\rules\policy-social.rules", RichTextBoxStreamType.PlainText)
            Case 63
                RichTextBox1.LoadFile("C:\Snort\rules\policy-spam.rules", RichTextBoxStreamType.PlainText)
            Case 64
                RichTextBox1.LoadFile("C:\Snort\rules\pop2.rules", RichTextBoxStreamType.PlainText)
            Case 65
                RichTextBox1.LoadFile("C:\Snort\rules\pop3.rules", RichTextBoxStreamType.PlainText)
            Case 66
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-dns.rules", RichTextBoxStreamType.PlainText)
            Case 67
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-finger.rules", RichTextBoxStreamType.PlainText)
            Case 68
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-ftp.rules", RichTextBoxStreamType.PlainText)
            Case 69
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-icmp.rules", RichTextBoxStreamType.PlainText)
            Case 70
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-imap.rules", RichTextBoxStreamType.PlainText)
            Case 71
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-nntp.rules", RichTextBoxStreamType.PlainText)
            Case 72
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-other.rules", RichTextBoxStreamType.PlainText)
            Case 73
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-pop.rules", RichTextBoxStreamType.PlainText)
            Case 74
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-rpc.rules", RichTextBoxStreamType.PlainText)
            Case 75
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-scada.rules", RichTextBoxStreamType.PlainText)
            Case 76
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-services.rules", RichTextBoxStreamType.PlainText)
            Case 77
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-snmp.rules", RichTextBoxStreamType.PlainText)
            Case 78
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-telnet.rules", RichTextBoxStreamType.PlainText)
            Case 79
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-tftp.rules", RichTextBoxStreamType.PlainText)
            Case 80
                RichTextBox1.LoadFile("C:\Snort\rules\protocol-voip.rules", RichTextBoxStreamType.PlainText)
            Case 81
                RichTextBox1.LoadFile("C:\Snort\rules\pua-adware.rules", RichTextBoxStreamType.PlainText)
            Case 82
                RichTextBox1.LoadFile("C:\Snort\rules\pua-other.rules", RichTextBoxStreamType.PlainText)
            Case 83
                RichTextBox1.LoadFile("C:\Snort\rules\pua-p2p.rules", RichTextBoxStreamType.PlainText)
            Case 84
                RichTextBox1.LoadFile("C:\Snort\rules\pua-toolbars.rules", RichTextBoxStreamType.PlainText)
            Case 85
                RichTextBox1.LoadFile("C:\Snort\rules\rpc.rules", RichTextBoxStreamType.PlainText)
            Case 86
                RichTextBox1.LoadFile("C:\Snort\rules\rservices.rules", RichTextBoxStreamType.PlainText)
            Case 87
                RichTextBox1.LoadFile("C:\Snort\rules\scada.rules", RichTextBoxStreamType.PlainText)
            Case 88
                RichTextBox1.LoadFile("C:\Snort\rules\scan.rules", RichTextBoxStreamType.PlainText)
            Case 89
                RichTextBox1.LoadFile("C:\Snort\rules\server-apache.rules", RichTextBoxStreamType.PlainText)
            Case 90
                RichTextBox1.LoadFile("C:\Snort\rules\server-iis.rules", RichTextBoxStreamType.PlainText)
            Case 91
                RichTextBox1.LoadFile("C:\Snort\rules\server-mail.rules", RichTextBoxStreamType.PlainText)
            Case 92
                RichTextBox1.LoadFile("C:\Snort\rules\server-mssql.rules", RichTextBoxStreamType.PlainText)
            Case 93
                RichTextBox1.LoadFile("C:\Snort\rules\server-mysql.rules", RichTextBoxStreamType.PlainText)
            Case 94
                RichTextBox1.LoadFile("C:\Snort\rules\server-oracle.rules", RichTextBoxStreamType.PlainText)
            Case 95
                RichTextBox1.LoadFile("C:\Snort\rules\server-other.rules", RichTextBoxStreamType.PlainText)
            Case 96
                RichTextBox1.LoadFile("C:\Snort\rules\server-samba.rules", RichTextBoxStreamType.PlainText)
            Case 97
                RichTextBox1.LoadFile("C:\Snort\rules\server-webapp.rules", RichTextBoxStreamType.PlainText)
            Case 98
                RichTextBox1.LoadFile("C:\Snort\rules\shellcode.rules", RichTextBoxStreamType.PlainText)
            Case 99
                RichTextBox1.LoadFile("C:\Snort\rules\smtp.rules", RichTextBoxStreamType.PlainText)
            Case 100
                RichTextBox1.LoadFile("C:\Snort\rules\snmp.rules", RichTextBoxStreamType.PlainText)
            Case 101
                RichTextBox1.LoadFile("C:\Snort\rules\specific-threats.rules", RichTextBoxStreamType.PlainText)
            Case 102
                RichTextBox1.LoadFile("C:\Snort\rules\spyware-put.rules", RichTextBoxStreamType.PlainText)
            Case 103
                RichTextBox1.LoadFile("C:\Snort\rules\sql.rules", RichTextBoxStreamType.PlainText)
            Case 104
                RichTextBox1.LoadFile("C:\Snort\rules\telnet.rules", RichTextBoxStreamType.PlainText)
            Case 105
                RichTextBox1.LoadFile("C:\Snort\rules\tftp.rules", RichTextBoxStreamType.PlainText)
            Case 106
                RichTextBox1.LoadFile("C:\Snort\rules\virus.rules", RichTextBoxStreamType.PlainText)
            Case 107
                RichTextBox1.LoadFile("C:\Snort\rules\voip.rules", RichTextBoxStreamType.PlainText)
            Case 108
                RichTextBox1.LoadFile("C:\Snort\rules\web-activex.rules", RichTextBoxStreamType.PlainText)
            Case 109
                RichTextBox1.LoadFile("C:\Snort\rules\web-attacks.rules", RichTextBoxStreamType.PlainText)
            Case 110
                RichTextBox1.LoadFile("C:\Snort\rules\web-cgi.rules", RichTextBoxStreamType.PlainText)
            Case 111
                RichTextBox1.LoadFile("C:\Snort\rules\web-client.rules", RichTextBoxStreamType.PlainText)
            Case 112
                RichTextBox1.LoadFile("C:\Snort\rules\web-coldfusion.rules", RichTextBoxStreamType.PlainText)
            Case 113
                RichTextBox1.LoadFile("C:\Snort\rules\web-frontpage.rules", RichTextBoxStreamType.PlainText)
            Case 114
                RichTextBox1.LoadFile("C:\Snort\rules\web-iis.rules", RichTextBoxStreamType.PlainText)
            Case 115
                RichTextBox1.LoadFile("C:\Snort\rules\web-misc.rules", RichTextBoxStreamType.PlainText)
            Case 116
                RichTextBox1.LoadFile("C:\Snort\rules\web-php.rules", RichTextBoxStreamType.PlainText)
            Case 117
                RichTextBox1.LoadFile("C:\Snort\rules\x11.rules", RichTextBoxStreamType.PlainText)

        End Select
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Select Case ListBox1.SelectedIndex
            Case 0
                RichTextBox1.SaveFile("C:\Snort\rules\app-detect.rules", RichTextBoxStreamType.PlainText)
            Case 1
                RichTextBox1.SaveFile("C:\Snort\rules\attack-responses.rules", RichTextBoxStreamType.PlainText)
            Case 2
                RichTextBox1.SaveFile("C:\Snort\rules\backdoor.rules", RichTextBoxStreamType.PlainText)
            Case 3
                RichTextBox1.SaveFile("C:\Snort\rules\bad-traffic.rules", RichTextBoxStreamType.PlainText)
            Case 4
                RichTextBox1.SaveFile("C:\Snort\rules\blacklist.rules", RichTextBoxStreamType.PlainText)
            Case 5
                RichTextBox1.SaveFile("C:\Snort\rules\botnet-cnc.rules", RichTextBoxStreamType.PlainText)
            Case 6
                RichTextBox1.SaveFile("C:\Snort\rules\browser-chrome.rules", RichTextBoxStreamType.PlainText)
            Case 7
                RichTextBox1.SaveFile("C:\Snort\rules\browser-firefox.rules", RichTextBoxStreamType.PlainText)
            Case 8
                RichTextBox1.SaveFile("C:\Snort\rules\browser-ie.rules", RichTextBoxStreamType.PlainText)
            Case 9
                RichTextBox1.SaveFile("C:\Snort\rules\browser-other.rules", RichTextBoxStreamType.PlainText)
            Case 10
                RichTextBox1.SaveFile("C:\Snort\rules\browser-plugins.rules", RichTextBoxStreamType.PlainText)
            Case 11
                RichTextBox1.SaveFile("C:\Snort\rules\browser-webkit.rules", RichTextBoxStreamType.PlainText)
            Case 12
                RichTextBox1.SaveFile("C:\Snort\rules\chat.rules", RichTextBoxStreamType.PlainText)
            Case 13
                RichTextBox1.SaveFile("C:\Snort\rules\content-replace.rules", RichTextBoxStreamType.PlainText)
            Case 14
                RichTextBox1.SaveFile("C:\Snort\rules\ddos.rules", RichTextBoxStreamType.PlainText)
            Case 15
                RichTextBox1.SaveFile("C:\Snort\rules\deleted.rules", RichTextBoxStreamType.PlainText)
            Case 16
                RichTextBox1.SaveFile("C:\Snort\rules\dns.rules", RichTextBoxStreamType.PlainText)
            Case 17
                RichTextBox1.SaveFile("C:\Snort\rules\dos.rules", RichTextBoxStreamType.PlainText)
            Case 18
                RichTextBox1.SaveFile("C:\Snort\rules\experimental.rules", RichTextBoxStreamType.PlainText)
            Case 19
                RichTextBox1.SaveFile("C:\Snort\rules\exploit.rules", RichTextBoxStreamType.PlainText)
            Case 20
                RichTextBox1.SaveFile("C:\Snort\rules\exploit-kit.rules", RichTextBoxStreamType.PlainText)
            Case 21
                RichTextBox1.SaveFile("C:\Snort\rules\file-executable.rules", RichTextBoxStreamType.PlainText)
            Case 22
                RichTextBox1.SaveFile("C:\Snort\rules\file-flash.rules", RichTextBoxStreamType.PlainText)
            Case 23
                RichTextBox1.SaveFile("C:\Snort\rules\file-identify.rules", RichTextBoxStreamType.PlainText)
            Case 24
                RichTextBox1.SaveFile("C:\Snort\rules\file-image.rules", RichTextBoxStreamType.PlainText)
            Case 25
                RichTextBox1.SaveFile("C:\Snort\rules\file-java.rules", RichTextBoxStreamType.PlainText)
            Case 26
                RichTextBox1.SaveFile("C:\Snort\rules\file-multimedia.rules", RichTextBoxStreamType.PlainText)
            Case 27
                RichTextBox1.SaveFile("C:\Snort\rules\file-office.rules", RichTextBoxStreamType.PlainText)
            Case 28
                RichTextBox1.SaveFile("C:\Snort\rules\file-other.rules", RichTextBoxStreamType.PlainText)
            Case 29
                RichTextBox1.SaveFile("C:\Snort\rules\file-pdf.rules", RichTextBoxStreamType.PlainText)
            Case 30
                RichTextBox1.SaveFile("C:\Snort\rules\finger.rules", RichTextBoxStreamType.PlainText)
            Case 31
                RichTextBox1.SaveFile("C:\Snort\rules\fpt.rules", RichTextBoxStreamType.PlainText)
            Case 32
                RichTextBox1.SaveFile("C:\Snort\rules\icmp.rules", RichTextBoxStreamType.PlainText)
            Case 33
                RichTextBox1.SaveFile("C:\Snort\rules\icmp-info.rules", RichTextBoxStreamType.PlainText)
            Case 34
                RichTextBox1.SaveFile("C:\Snort\rules\imap.rules", RichTextBoxStreamType.PlainText)
            Case 35
                RichTextBox1.SaveFile("C:\Snort\rules\indicator-compromise.rules", RichTextBoxStreamType.PlainText)
            Case 36
                RichTextBox1.SaveFile("C:\Snort\rules\indicator-obfuscation.rules", RichTextBoxStreamType.PlainText)
            Case 37
                RichTextBox1.SaveFile("C:\Snort\rules\indicator-scan.rules", RichTextBoxStreamType.PlainText)
            Case 38
                RichTextBox1.SaveFile("C:\Snort\rules\indicator-shellcode.rules", RichTextBoxStreamType.PlainText)
            Case 39
                RichTextBox1.SaveFile("C:\Snort\rules\info.rules", RichTextBoxStreamType.PlainText)
            Case 40
                RichTextBox1.SaveFile("C:\Snort\rules\local.rules", RichTextBoxStreamType.PlainText)
            Case 41
                RichTextBox1.SaveFile("C:\Snort\rules\malware-backdoor.rules", RichTextBoxStreamType.PlainText)
            Case 42
                RichTextBox1.SaveFile("C:\Snort\rules\malware-cnc.rules", RichTextBoxStreamType.PlainText)
            Case 43
                RichTextBox1.SaveFile("C:\Snort\rules\malware-other.rules", RichTextBoxStreamType.PlainText)
            Case 44
                RichTextBox1.SaveFile("C:\Snort\rules\malware-tools.rules", RichTextBoxStreamType.PlainText)
            Case 45
                RichTextBox1.SaveFile("C:\Snort\rules\misc.rules", RichTextBoxStreamType.PlainText)
            Case 46
                RichTextBox1.SaveFile("C:\Snort\rules\multimedia.rules", RichTextBoxStreamType.PlainText)
            Case 47
                RichTextBox1.SaveFile("C:\Snort\rules\mysql.rules", RichTextBoxStreamType.PlainText)
            Case 48
                RichTextBox1.SaveFile("C:\Snort\rules\netbios.rules", RichTextBoxStreamType.PlainText)
            Case 49
                RichTextBox1.SaveFile("C:\Snort\rules\nntp.rules", RichTextBoxStreamType.PlainText)
            Case 50
                RichTextBox1.SaveFile("C:\Snort\rules\oracle.rules", RichTextBoxStreamType.PlainText)
            Case 51
                RichTextBox1.SaveFile("C:\Snort\rules\os-linux.rules", RichTextBoxStreamType.PlainText)
            Case 52
                RichTextBox1.SaveFile("C:\Snort\rules\os-mobile.rules", RichTextBoxStreamType.PlainText)
            Case 53
                RichTextBox1.SaveFile("C:\Snort\rules\os-other.rules", RichTextBoxStreamType.PlainText)
            Case 54
                RichTextBox1.SaveFile("C:\Snort\rules\os-solaris.rules", RichTextBoxStreamType.PlainText)
            Case 55
                RichTextBox1.SaveFile("C:\Snort\rules\os-windows.rules", RichTextBoxStreamType.PlainText)
            Case 56
                RichTextBox1.SaveFile("C:\Snort\rules\other-ids.rules", RichTextBoxStreamType.PlainText)
            Case 57
                RichTextBox1.SaveFile("C:\Snort\rules\p2p.rules", RichTextBoxStreamType.PlainText)
            Case 58
                RichTextBox1.SaveFile("C:\Snort\rules\phishing-spam.rules", RichTextBoxStreamType.PlainText)
            Case 59
                RichTextBox1.SaveFile("C:\Snort\rules\policy.rules", RichTextBoxStreamType.PlainText)
            Case 60
                RichTextBox1.SaveFile("C:\Snort\rules\policy-multimedia.rules", RichTextBoxStreamType.PlainText)
            Case 61
                RichTextBox1.SaveFile("C:\Snort\rules\policy-other.rules", RichTextBoxStreamType.PlainText)
            Case 62
                RichTextBox1.SaveFile("C:\Snort\rules\policy-social.rules", RichTextBoxStreamType.PlainText)
            Case 63
                RichTextBox1.SaveFile("C:\Snort\rules\policy-spam.rules", RichTextBoxStreamType.PlainText)
            Case 64
                RichTextBox1.SaveFile("C:\Snort\rules\pop2.rules", RichTextBoxStreamType.PlainText)
            Case 65
                RichTextBox1.SaveFile("C:\Snort\rules\pop3.rules", RichTextBoxStreamType.PlainText)
            Case 66
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-dns.rules", RichTextBoxStreamType.PlainText)
            Case 67
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-finger.rules", RichTextBoxStreamType.PlainText)
            Case 68
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-ftp.rules", RichTextBoxStreamType.PlainText)
            Case 69
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-icmp.rules", RichTextBoxStreamType.PlainText)
            Case 70
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-imap.rules", RichTextBoxStreamType.PlainText)
            Case 71
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-nntp.rules", RichTextBoxStreamType.PlainText)
            Case 72
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-other.rules", RichTextBoxStreamType.PlainText)
            Case 73
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-pop.rules", RichTextBoxStreamType.PlainText)
            Case 74
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-rpc.rules", RichTextBoxStreamType.PlainText)
            Case 75
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-scada.rules", RichTextBoxStreamType.PlainText)
            Case 76
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-services.rules", RichTextBoxStreamType.PlainText)
            Case 77
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-snmp.rules", RichTextBoxStreamType.PlainText)
            Case 78
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-telnet.rules", RichTextBoxStreamType.PlainText)
            Case 79
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-tftp.rules", RichTextBoxStreamType.PlainText)
            Case 80
                RichTextBox1.SaveFile("C:\Snort\rules\protocol-voip.rules", RichTextBoxStreamType.PlainText)
            Case 81
                RichTextBox1.SaveFile("C:\Snort\rules\pua-adware.rules", RichTextBoxStreamType.PlainText)
            Case 82
                RichTextBox1.SaveFile("C:\Snort\rules\pua-other.rules", RichTextBoxStreamType.PlainText)
            Case 83
                RichTextBox1.SaveFile("C:\Snort\rules\pua-p2p.rules", RichTextBoxStreamType.PlainText)
            Case 84
                RichTextBox1.SaveFile("C:\Snort\rules\pua-toolbars.rules", RichTextBoxStreamType.PlainText)
            Case 85
                RichTextBox1.SaveFile("C:\Snort\rules\rpc.rules", RichTextBoxStreamType.PlainText)
            Case 86
                RichTextBox1.SaveFile("C:\Snort\rules\rservices.rules", RichTextBoxStreamType.PlainText)
            Case 87
                RichTextBox1.SaveFile("C:\Snort\rules\scada.rules", RichTextBoxStreamType.PlainText)
            Case 88
                RichTextBox1.SaveFile("C:\Snort\rules\scan.rules", RichTextBoxStreamType.PlainText)
            Case 89
                RichTextBox1.SaveFile("C:\Snort\rules\server-apache.rules", RichTextBoxStreamType.PlainText)
            Case 90
                RichTextBox1.SaveFile("C:\Snort\rules\server-iis.rules", RichTextBoxStreamType.PlainText)
            Case 91
                RichTextBox1.SaveFile("C:\Snort\rules\server-mail.rules", RichTextBoxStreamType.PlainText)
            Case 92
                RichTextBox1.SaveFile("C:\Snort\rules\server-mssql.rules", RichTextBoxStreamType.PlainText)
            Case 93
                RichTextBox1.SaveFile("C:\Snort\rules\server-mysql.rules", RichTextBoxStreamType.PlainText)
            Case 94
                RichTextBox1.SaveFile("C:\Snort\rules\server-oracle.rules", RichTextBoxStreamType.PlainText)
            Case 95
                RichTextBox1.SaveFile("C:\Snort\rules\server-other.rules", RichTextBoxStreamType.PlainText)
            Case 96
                RichTextBox1.SaveFile("C:\Snort\rules\server-samba.rules", RichTextBoxStreamType.PlainText)
            Case 97
                RichTextBox1.SaveFile("C:\Snort\rules\server-webapp.rules", RichTextBoxStreamType.PlainText)
            Case 98
                RichTextBox1.SaveFile("C:\Snort\rules\shellcode.rules", RichTextBoxStreamType.PlainText)
            Case 99
                RichTextBox1.SaveFile("C:\Snort\rules\smtp.rules", RichTextBoxStreamType.PlainText)
            Case 100
                RichTextBox1.SaveFile("C:\Snort\rules\snmp.rules", RichTextBoxStreamType.PlainText)
            Case 101
                RichTextBox1.SaveFile("C:\Snort\rules\specific-threats.rules", RichTextBoxStreamType.PlainText)
            Case 102
                RichTextBox1.SaveFile("C:\Snort\rules\spyware-put.rules", RichTextBoxStreamType.PlainText)
            Case 103
                RichTextBox1.SaveFile("C:\Snort\rules\sql.rules", RichTextBoxStreamType.PlainText)
            Case 104
                RichTextBox1.SaveFile("C:\Snort\rules\telnet.rules", RichTextBoxStreamType.PlainText)
            Case 105
                RichTextBox1.SaveFile("C:\Snort\rules\tftp.rules", RichTextBoxStreamType.PlainText)
            Case 106
                RichTextBox1.SaveFile("C:\Snort\rules\virus.rules", RichTextBoxStreamType.PlainText)
            Case 107
                RichTextBox1.SaveFile("C:\Snort\rules\voip.rules", RichTextBoxStreamType.PlainText)
            Case 108
                RichTextBox1.SaveFile("C:\Snort\rules\web-activex.rules", RichTextBoxStreamType.PlainText)
            Case 109
                RichTextBox1.SaveFile("C:\Snort\rules\web-attacks.rules", RichTextBoxStreamType.PlainText)
            Case 110
                RichTextBox1.SaveFile("C:\Snort\rules\web-cgi.rules", RichTextBoxStreamType.PlainText)
            Case 111
                RichTextBox1.SaveFile("C:\Snort\rules\web-client.rules", RichTextBoxStreamType.PlainText)
            Case 112
                RichTextBox1.SaveFile("C:\Snort\rules\web-coldfusion.rules", RichTextBoxStreamType.PlainText)
            Case 113
                RichTextBox1.SaveFile("C:\Snort\rules\web-frontpage.rules", RichTextBoxStreamType.PlainText)
            Case 114
                RichTextBox1.SaveFile("C:\Snort\rules\web-iis.rules", RichTextBoxStreamType.PlainText)
            Case 115
                RichTextBox1.SaveFile("C:\Snort\rules\web-misc.rules", RichTextBoxStreamType.PlainText)
            Case 116
                RichTextBox1.SaveFile("C:\Snort\rules\web-php.rules", RichTextBoxStreamType.PlainText)
            Case 117
                RichTextBox1.SaveFile("C:\Snort\rules\x11.rules", RichTextBoxStreamType.PlainText)
        End Select
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
End Class