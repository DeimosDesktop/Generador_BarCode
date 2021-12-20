Imports iTextSharp.text.pdf
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("No se puede generar un codeBar vacio!", vbCritical, "Escribe un número")
        Else
            If ComboBox1.SelectedItem = Nothing Then
                MsgBox("Tienes que seleccionar la codificación", vbCritical, "Selecciona la codificación")
                ComboBox1.Focus()
            End If
            Try
                Dim alto As Single = 0
                If TextBox2.Text <> "" Then
                    alto = Convert.ToSingle(TextBox2.Text)
                End If
                Dim bm As Bitmap = Nothing
                With ComboBox1.SelectedIndex
                    If ComboBox1.SelectedIndex = 0 Then
                        bm = Codigos.codigo128("A" & TextBox1.Text & "B", CheckBox1.Checked, alto)
                    End If
                    If ComboBox1.SelectedIndex = 1 Then
                        bm = Codigos.codigo128_Alfa(TextBox1.Text, CheckBox1.Checked, alto)
                    End If
                End With

                If Not IsNothing(bm) Then
                    PictureBox1.Image = bm
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://mirpas.com")
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://mirpas.com/content/Lenguajes/projects/VBNET/barcode.php")
    End Sub
End Class
