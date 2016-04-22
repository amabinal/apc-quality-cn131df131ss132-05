Public Class Form9
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                RichTextBox1.LoadFile("C:\Snort\ruless\app-detect.rules", RichTextBoxStreamType.PlainText)
            Case 1
                RichTextBox1.LoadFile("C:\Snort\rules\attack-responses.rules", RichTextBoxStreamType.PlainText)

        End Select
    End Sub
End Class