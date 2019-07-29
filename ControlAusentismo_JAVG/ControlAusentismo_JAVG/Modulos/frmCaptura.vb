Imports System.Net
Public Class frmCaptura
    Public Function dameIP() As String

        Dim ip As Net.Dns
        Dim nombrePC As String
        Dim entradasIP As Net.IPHostEntry

        nombrePC = Dns.GetHostName

        entradasIP = Dns.GetHostByName(nombrePC)

        Dim direccion_Ip As String = entradasIP.AddressList(0).ToString
        'MessageBox.Show(direccion_Ip)

        Return direccion_Ip

    End Function
    Dim Fech As String = ""
    Dim Periodo As String = ""
    Private Sub frmCaptura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fech = Fecha_a_String(Now)
        'MessageBox.Show(Fech)

        Cargar_Periodo()
    End Sub

    Sub Cargar_Periodo()
        Dim consulta As String
        consulta = "SELECT Periodo FROM c_periodos WHERE fecha_inicio <= #" & Fech & "# AND fecha_fin >= #" & Fech & "#"

        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)

        If DTVisualizar.Rows.Count > 0 Then
            Periodo = DTVisualizar.Rows(0).Item("Periodo").ToString()
            txbPeriodo.Text = Periodo
            Cargar_Cursos()
        Else
            MessageBox.Show("Sin periodos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub

    Sub Cargar_Cursos()
        Dim consulta As String
        consulta = "SELECT id_curso, nombre_curso FROM cursos WHERE periodo = '" & Periodo & "' AND id_usuario = " & usuario & " Order By nombre_curso"

        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)

        If DTVisualizar.Rows.Count > 0 Then
            With Me.cboCursos
                .DataSource = DTVisualizar
                .DisplayMember = "nombre_curso"
                .ValueMember = "id_curso"
            End With

        End If

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click

        gbxGrupo.Visible = True
        txtMatricula.Select()
        Cargar_Datos()
    End Sub

    Sub Insertar_Captura()
        Try
            Dim id_curso As String = cboCursos.SelectedValue '.ToString()
            Dim matricula As String = txtMatricula.Text
            Dim Fecha_Hora As String = Fecha_Hora_a_String(Now)
            Dim Campos As String = ""
            Dim Valores As String = ""
            Campos = "id_curso, matricula, IP,fecha_hora,fecha"
            Valores = "" & Val(id_curso) & ", '" & matricula & "', '" & dameIP() & "', #" & Fecha_Hora & "#, #" & Fech & "# "

            Dim Insertar As String = "INSERT INTO capturas (" & Campos & ") VALUES(" & Valores & ")"
            Cambios(Insertar)
            Cargar_Datos()
            txtMatricula.Clear()
            txtMatricula.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Cargar_Datos()
        With dgvCaptura
            .DataSource = Nothing
            .DataMember = Nothing
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
            .DefaultCellStyle.BackColor = Color.White
        End With
        Dim curso As Long = cboCursos.SelectedValue
        Dim consulta As String = ""
        consulta = "SELECT (a.ap_paterno + ' ' + a.ap_materno + ' ' + a.nombres) AS Nombre, c.matricula AS Matricula, c.fecha_hora AS Fecha FROM capturas AS c INNER JOIN c_alumnos AS a ON c.matricula = a.matricula WHERE c.fecha_hora >= #" & Fech & "# AND c.id_curso=" & curso & " ORDER BY c.fecha_hora DESC"
        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)
        If DTVisualizar.Rows.Count <= 0 Then
            dgvCaptura.DataSource = Nothing
        Else
            With dgvCaptura
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                .DataSource = DTVisualizar
                .Refresh()
            End With
        End If
    End Sub


    Private Sub btnCapturar_Click(sender As Object, e As EventArgs) Handles btnCapturar.Click
        Insertar_Captura()

    End Sub

    Private Sub txtMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMatricula.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab) Then
            e.Handled = True
            btnCapturar.PerformClick()
        End If
    End Sub

    Private Sub panel_Paint(sender As Object, e As PaintEventArgs) Handles panel.Paint

    End Sub

    Private Sub dgvCaptura_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCaptura.CellContentClick

    End Sub
End Class