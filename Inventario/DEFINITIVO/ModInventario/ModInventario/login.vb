Public Class login
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text = " " And txtClave.Text = " " Then
            MsgBox("Ingrese el usuario y contraseña", MsgBoxStyle.Exclamation, "Advetencia")
        ElseIf txtUsuario.Text = "user" And txtClave.Text = "1234" Then
            Dim window As New FrmPrincipal()
            window.show()
            Me.Hide()
        Else
            MsgBox("El usuario y contraseña es incorrecto", MsgBoxStyle.Exclamation, "Advetencia")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim mensaje = MsgBox("Desea cerra el programa", MsgBoxStyle.YesNo, "Advetencia")
        If mensaje = MsgBoxResult.Ok Then
            'End
        End If
    End Sub
End Class