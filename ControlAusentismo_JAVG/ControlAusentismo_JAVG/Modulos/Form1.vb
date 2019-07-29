Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        Try

            no_empleado = txtUsuario.Text
            Dim password As String = txtPassword.Text
            If no_empleado.Length > 0 And password.Length >= 1 Then
                Dim consulta As String
                consulta = "SELECT * FROM c_usuarios WHERE no_empleado = '" & no_empleado & "' AND password ='" & password & "'"

                Dim DTVisualizar As DataTable = Nothing
                DTVisualizar = consultar(consulta).Tables(0)

                If DTVisualizar.Rows.Count > 0 Then
                    usuario = DTVisualizar.Rows(0).Item("id_usuario").ToString()
                    no_empleado = DTVisualizar.Rows(0).Item("no_empleado").ToString()
                    tipo = DTVisualizar.Rows(0).Item("tipo").ToString
                    Nivel = DTVisualizar.Rows(0).Item("nivel").ToString()
                    NombreLogeado = DTVisualizar.Rows(0).Item("Ap_Paterno").ToString() & "/ " & DTVisualizar.Rows(0).Item("Ap_Materno").ToString() & ", " & DTVisualizar.Rows(0).Item("nombres").ToString()
                    Me.Hide()
                    frmPrincipal.Show()

                    Exit Sub
                Else
                    MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Else
                MessageBox.Show("Introduzca usuario y contraseña", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress, txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            Application.Exit()
        End If

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab) Then
            e.Handled = True
            btnLogin.PerformClick()
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            Application.Exit()
        End If

    End Sub

    Private Sub frmLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
       
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
