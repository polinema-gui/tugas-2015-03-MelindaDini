Public Class Form3

    Dim angka1, angka2 As Integer
    Dim hasil As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        angka1 = Convert.ToInt64(matrik1.Text)
        angka2 = Convert.ToInt64(matrik2.Text)
        If ComboBox1.Text = "Tambah" Then
            hasil = angka1 + angka2
        Else
            hasil = angka1 - angka2
        End If
        TextBox3.Text = hasil

    End Sub
End Class
