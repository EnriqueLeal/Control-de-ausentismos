Public Class Administracion
    Dim Precargar_Con As String = ""
    Dim periodo As String = ""
    Dim Fech As String = ""
    Dim Dia As Integer = 0
    Sub Iniciar()


        Dim F As Date = dtpFecha.Value
        Fech = Fecha_a_String(F)
        Dia = Val(F.DayOfWeek)
        Cargar_Datos()
        'Cargar_Periodo()

        MessageBox.Show(Fech)


    End Sub
    'Dim Precargar_Faltas_Con As String = ""
    Sub Cargar_TodosDatos()
        With dgvDatosTotal
            .DataSource = Nothing
            .DataMember = Nothing
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
            .DefaultCellStyle.BackColor = Color.White
        End With
        Dim curso As String = cboIP.SelectedValue
        Dim IPfija As String = txtIPfija.Text
        lblIP.Text = IPfija
        Dim consulta As String = ""
        consulta = "SELECT *
                    FROM capturas"
        '    "SELECT nombre_equipo,COUNT(IP) FROM c_computos
        ' WHERE '" & txtIPfija.ToString & "'
        'GROUP BY nombre_equipo"


        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)
        If DTVisualizar.Rows.Count <= 0 Then
            dgvDatosTotal.DataSource = Nothing
        Else
            With dgvDatosTotal
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                .DataSource = DTVisualizar
                .Refresh()
            End With
        End If
    End Sub
    Sub Cargar_Datos()
        With dgvDatos
            .DataSource = Nothing
            .DataMember = Nothing
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
            .DefaultCellStyle.BackColor = Color.White
        End With
        Dim curso As String = cboIP.SelectedValue
        Dim IPfija As String = txtIPfija.Text
        lblIP.Text = IPfija
        Dim consulta As String = ""
        consulta = "SELECT c_computos.nombre_equipo ,COUNT(capturas.IP) AS Número
         FROM c_computos
        INNER JOIN capturas
        On c_computos.IP = capturas.IP
        WHERE capturas.IP = '" & IPfija & "' AND capturas.fecha = #" & Fech & "#

        GROUP BY nombre_equipo
                 "

        '    "SELECT nombre_equipo,COUNT(IP) FROM c_computos
        ' WHERE '" & txtIPfija.ToString & "'
        'GROUP BY nombre_equipo"


        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)
        If DTVisualizar.Rows.Count <= 0 Then
            MessageBox.Show("Datos Erroneo")
            dgvDatos.DataSource = Nothing
        Else

            With dgvDatos
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                .DataSource = DTVisualizar
                .Refresh()
            End With
        End If
    End Sub
    Sub Cargar_IP()
        Dim consulta As String
        consulta = "SELECT IP
                    FROM c_computos"

        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)

        If DTVisualizar.Rows.Count > 0 Then


            With Me.cboIP
                .DataSource = DTVisualizar
                .DisplayMember = "IP"
                .ValueMember = "IP"
            End With

        End If

    End Sub
    Sub Cargar_registro()
        Dim consulta As String
        consulta = "SELECT IP
                    FROM c_computos"

        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)

        If DTVisualizar.Rows.Count > 0 Then
            periodo = DTVisualizar.Rows(0).Item("IP").ToString()
            txtNumRegistro.Text = periodo
            Cargar_IP()
        Else
            MessageBox.Show("Sin count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub




    'With dgvDatos
    '    .DataSource = Nothing
    '    .DataMember = Nothing
    '    .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
    '    .DefaultCellStyle.BackColor = Color.White
    'End With
    ''If txtRegistro.Text <> "" And txtNumRegistro.Text <> "" Then
    'Dim ip As Long = Val(cboIP.SelectedValue)
    '    'Dim id_horario As Long = Val(cboHorarios.SelectedValue)
    '    Dim consulta As String = ""
    '    consulta = "SELECT ip = " & ip &
    '                "FROM c_computos"   '" And c.id_horario = " & id_horario & ""
    '    'Select Case Count(ip)
    '    'From c_computos
    '    'Where ip = "192.168.1.31"

    '    Dim DtVisualizar As DataTable = Nothing
    '        DtVisualizar = consultar(consulta).Tables(0)
    '    If DtVisualizar.Rows.Count <= 0 Then
    '        'Proceso_Insertar()
    '        CargarLista()
    '    Else
    '        'With dgvDatos
    '        '    .DataSource = DtVisualizar
    '        '    .Columns.Remove("Registro")
    '        'End With
    '        ''''''''''''''''''''''
    '        Dim Consulta2 As String = ""
    '        Consulta2 = "SELECT Count(ip)
    '                     FROM c_computos
    '                     WHERE ip = " & ip & ""
    '        Dim DT2 As DataTable = Nothing
    '        DT2 = consultar(Consulta2).Tables(0)
    '        ''''''''''''''''''''''
    '        Dim column1 As New DataGridViewComboBoxColumn
    '        'With column1
    '        '    .DataPropertyName = "Registro"
    '        '    .Name = "Registro"
    '        '    .HeaderText = "Registro"
    '        '    .DataSource = DT2
    '        '    .DisplayMember = DT2.Columns("registro").ToString
    '        '    .ValueMember = DT2.Columns("registro").ToString
    '        'End With

    '        'dgvDatos.Columns.Insert(3, column1)

    '        With dgvDatos
    '            .DataSource = DtVisualizar
    '            .Columns("nombre_equipo").ReadOnly = True
    '            .Columns("categoria").ReadOnly = True
    '            .Columns("IP").Visible = False
    '            .Refresh()
    '        End With


    '    End If


    'Exit Sub



    'End Sub
    'Sub Proceso_Insertar()

    '    'Configurar_Precarga_Datos()
    '    'Configurar_Precarga_Faltas()

    '    Dim curso As Long = cboIP.SelectedValue
    '    Dim consulta As String = "SELECT matricula FROM curso_alumno AS c WHERE id_curso =" & curso
    '    Dim DtVisualizar As DataTable = Nothing
    '    DtVisualizar = consultar(consulta).Tables(0)
    '    If DtVisualizar.Rows.Count <= 0 Then
    '        dgvDatos.DataSource = Nothing
    '    Else

    '        For Each row As DataRow In DtVisualizar.Rows
    '            Dim Matricula As String = ""
    '            Matricula = CStr(row("matricula"))

    '            If Precargar_Con = "Proceso" Then
    '                'Busca_Captura(Matricula)
    '            Else
    '                'InsertarRegistro(Matricula, Precargar_Con)
    '            End If
    '        Next


    '        'With gvDatos
    '        '    .DataSource = DtVisualizar
    '        '    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    '        '    .Refresh()
    '        'End With


    '    End If
    'End Sub

    'Sub Busca_Captura(ByVal Matricula As String)
    '    Dim id_curso As Long = Val(cboCursos.SelectedValue)

    '    Dim F1 As String = Fech & " " & txtHoraInicio.Text
    '    Dim F2 As String = Fech & " " & txtHoraFin.Text

    '    Dim consulta As String = ""
    '    consulta = "SELECT id_captura FROM capturas WHERE matricula = '" & Matricula & "' AND id_curso = " & id_curso & " AND fecha_hora >= #" & F1 & "# AND fecha_hora <= #" & F2 & "#"

    '    Dim DTVisualizar As DataTable = Nothing
    '    DTVisualizar = consultar(consulta).Tables(0)

    '    If DTVisualizar.Rows.Count <= 0 Then
    '        InsertarRegistro(Matricula, Precargar_Faltas_Con)
    '    Else
    '        InsertarRegistro(Matricula, "A")
    '    End If
    'End Sub
    Private Sub dgvCaptura_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick

    End Sub

    Private Sub Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_IP()
        'Cargar_IPs()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Cargar_IP()
        Cargar_Datos()
        Cargar_TodosDatos()



    End Sub

    Private Sub cboIP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIP.SelectedIndexChanged

    End Sub

    Private Sub txtRegistro_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboRegistro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRegistro.SelectedIndexChanged

    End Sub

    Private Sub lblIP_Click(sender As Object, e As EventArgs) Handles lblIP.Click

    End Sub

    Private Sub dgvDatosTotal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatosTotal.CellContentClick

    End Sub

    Private Sub btnProceso_Click(sender As Object, e As EventArgs) Handles btnProceso.Click
        Try
            'Dim A As String = "*"
            Dim direccionIP1 = txtIPfija.Text
            Dim Directa As String = cboIP.SelectedValue
            If direccionIP1.Length > 0 And Directa.Length >= 1 Then
                Dim consulta As String
                consulta = "SELECT id_captura,IP
                            FROM capturas
                            WHERE IP LIKE  '*" & direccionIP1 & "*'"

                Dim DTVisualizar As DataTable = Nothing
                DTVisualizar = consultar(consulta).Tables(0)

                If DTVisualizar.Rows.Count > 0 Then



                    Exit Sub
                Else
                    MessageBox.Show("Datos Incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Else
                MessageBox.Show("Introduzca usuario y contraseña", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        Iniciar()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class