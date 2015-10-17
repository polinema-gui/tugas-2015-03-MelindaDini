Public Class Form1

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub MatriksKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim a As String
        a = MsgBox("Apakah Anda Yakin Ingin Keluar", vbYesNo + vbInformation, "Konfirmasi")
        If a = vbYes Then
            End
            Environment.Exit(0)
        ElseIf a = vbNo Then
            Me.Show()
        End If
    End Sub
End Class
