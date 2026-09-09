Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama As String = NamaTextBox.Text

        Dim jenisKelamin As String = ""

        If RadioButton1.Checked Then
            jenisKelamin = "Pria"
        ElseIf RadioButton2.Checked Then
            jenisKelamin = "Wanita"
        End If

        Dim alamat As String = TextBox1.Text
        Dim jabatan As String = ComboBox1.Text
        Dim lamaBekerja As String = NumericUpDown1.Value.ToString()

        Dim status As String = ""

        If CheckBox1.Checked Then
            status = "Aktif"
        Else
            status = "Tidak Aktif"
        End If

        MessageBox.Show(
            "Nama: " & nama &
            vbCrLf & "Jenis Kelamin: " & jenisKelamin &
            vbCrLf & "Alamat: " & alamat &
            vbCrLf & "Jabatan: " & jabatan &
            vbCrLf & "Lama Bekerja: " & lamaBekerja & " tahun" &
            vbCrLf & "Status: " & status,
            "Data Karyawan"
        )
    End Sub
End Class
