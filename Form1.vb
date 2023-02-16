Public Class Form1
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Dim x As CONTACTO
        x = New CONTACTO()

        x.fechadenacimiento_ = DateTime.Parse("2003/01/01")

        x.nombre_ = textNombre.Text
        x.telefono_ = txtTelefono.Text

        lblText.Text = x.ToString

    End Sub


End Class
