Imports ClienteNegocio

Public Class Form1
    Dim negocio As New ClienteNegocio.PruebaConexion()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        negocio.DatosClientes()

    End Sub
End Class
