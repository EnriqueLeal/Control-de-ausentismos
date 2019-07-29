Public Class frmControlAusentismos
    Dim Fech As String = ""
    Dim Periodo As String = ""
    Dim Dia As Integer = 0
    Dim listo As Boolean = False
    Dim Hoarios_Cargados As Boolean = False
    Dim Hra_inicio As String = ""
    Dim Hra_Fin As String = ""
    Dim dgvDatos As Object
    Dim dgvCaptura As Object
    Dim Precargar_Con As String = ""
    Dim Precargar_Faltas_Con As String = ""
    Dim ID As Long = 0
    Dim Registro As String = ""


    Private Sub frmControlAusentismos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtDocente.Text = NombreLogeado
        Iniciar()

    End Sub

    Sub Iniciar()
        With Me.cboCursos
            .DataSource = Nothing
            .Refresh()
        End With
        With Me.cboHorarios
            .DataSource = Nothing
            .Refresh()
        End With
        txtHoraInicio.Text = ""
        txtHoraFin.Text = ""
        txtPeriodo.Text = ""

        Dim F As Date = dtpFecha.Value
        Fech = Fecha_a_String(F)
        Dia = Val(F.DayOfWeek)
        Cargar_Periodo()

    End Sub


    Sub Cargar_Periodo()
        Dim consulta As String
        consulta = "SELECT Periodo FROM c_periodos WHERE fecha_inicio <= #" & Fech & "# AND fecha_fin >= #" & Fech & "#"

        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)

        If DTVisualizar.Rows.Count > 0 Then
            Periodo = DTVisualizar.Rows(0).Item("Periodo").ToString()
            txtPeriodo.Text = Periodo
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
            listo = True
            Cargar_Horarios()
    
        End If

    End Sub

    Sub Cargar_Horarios()
        Dim curso As String
        curso = cboCursos.SelectedValue

        'If curso = 0 Then
        '    Exit Sub
        'End If

        Dim consulta As String
        consulta = "SELECT id_horario, ('De ' & hra_inicio & ' a ' & hra_fin) AS Horario FROM horarios WHERE id_curso=" & curso & " AND dia = " & Dia & " ORDER BY hra_inicio" ' WHERE periodo = '" & Periodo & "' AND id_usuario = " & usuario & " Order By nombre_curso"

        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)

        If DTVisualizar.Rows.Count > 0 Then
            With Me.cboHorarios
                .DataSource = DTVisualizar
                .DisplayMember = "Horario"
                .ValueMember = "id_horario"
            End With
            Hoarios_Cargados = True
            If Hoarios_Cargados = True And cboHorarios.Text <> "" Then
                Define_Horarios()
            End If

        End If

    End Sub


    Private Sub cboCursos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCursos.SelectedValueChanged
        If listo = True And cboCursos.Text <> "" Then
            Cargar_Horarios()
        End If
    End Sub

    Sub Define_Horarios()
        Dim Horario_Seleccionado As Long = cboHorarios.SelectedValue
        Dim consulta As String
        consulta = "SELECT * FROM horarios WHERE id_horario = " & Horario_Seleccionado & ""

        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)

        If DTVisualizar.Rows.Count > 0 Then
            Hra_Fin = DTVisualizar.Rows(0).Item("hra_fin").ToString()
            Hra_inicio = DTVisualizar.Rows(0).Item("hra_inicio").ToString()
            txtHoraInicio.Text = Hra_inicio
            txtHoraFin.Text = Hra_Fin
        End If
    End Sub



    Private Sub cboHorarios_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboHorarios.SelectedValueChanged
        If Hoarios_Cargados = True And cboHorarios.Text <> "" Then
            Define_Horarios()
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        Iniciar()
    End Sub

    Sub CargarLista()
        With gvDatos
            .DataSource = Nothing
            .DataMember = Nothing
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
            .DefaultCellStyle.BackColor = Color.White
        End With
        If txtHoraFin.Text <> "" And txtHoraInicio.Text <> "" Then
            Dim id_curso As Long = Val(cboCursos.SelectedValue)
            Dim id_horario As Long = Val(cboHorarios.SelectedValue)
            Dim consulta As String = ""
            consulta = "SELECT c.id_control_ausentismos, c.matricula AS Matricula, (a.ap_paterno & '/ ' & a.ap_materno & ', ' & a.nombres) AS Alumno, c.registro AS Registro FROM control_ausentismos AS c INNER JOIN c_alumnos AS a ON c.matricula = a.matricula WHERE c.fecha = #" & Fech & "# AND c.id_curso = " & id_curso & " AND c.id_horario = " & id_horario & ""

            Dim DtVisualizar As DataTable = Nothing
            DtVisualizar = consultar(consulta).Tables(0)
            If DtVisualizar.Rows.Count <= 0 Then
                Proceso_Insertar()
                CargarLista()
            Else
                With gvDatos
                    .DataSource = DtVisualizar
                    .Columns.Remove("Registro")
                End With
                ''''''''''''''''''''''
                Dim Consulta2 As String = ""
                Consulta2 = "SELECT registro FROM c_registro"
                Dim DT2 As DataTable = Nothing
                DT2 = consultar(Consulta2).Tables(0)
                ''''''''''''''''''''''
                Dim column1 As New DataGridViewComboBoxColumn
                With column1
                    .DataPropertyName = "Registro"
                    .Name = "Registro"
                    .HeaderText = "Registro"
                    .DataSource = DT2
                    .DisplayMember = DT2.Columns("registro").ToString
                    .ValueMember = DT2.Columns("registro").ToString
                End With

                gvDatos.Columns.Insert(3, column1)

                With gvDatos
                    .DataSource = DtVisualizar
                    .Columns("Alumno").ReadOnly = True
                    .Columns("Matricula").ReadOnly = True
                    .Columns("id_control_ausentismos").Visible = False
                    .Refresh()
                End With
               
                
            End If

        Else
            Exit Sub
        End If


    End Sub

    ''' 
    ''' ''''''''''''''
    Private Sub gvDatos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvDatos.RowEnter
        If gvDatos.Rows.Count <= 0 Then
        Else
            ID = Val(gvDatos.Rows(e.RowIndex).Cells("id_control_ausentismos").Value.ToString())
        End If
    End Sub

    Private Sub gvDatos_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gvDatos.CellValueChanged
        Registro = gvDatos.Rows(e.RowIndex).Cells("Registro").Value.ToString()
        If Registro <> "" Then
            ActualizarRegistro()
        End If

    End Sub
    Sub ActualizarRegistro()
        Try
            Dim Campos As String = "registro = '" & Registro & "'"

            Dim actualizar As String = "Update control_ausentismos set " & Campos & " Where id_control_ausentismos = " & ID & ""
            Cambios(actualizar)
            'MessageBox.Show("Datos actualizados correctamente", "Proceso terminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub Busca_Captura(ByVal Matricula As String)
        Dim id_curso As Long = Val(cboCursos.SelectedValue)

        Dim F1 As String = Fech & " " & txtHoraInicio.Text
        Dim F2 As String = Fech & " " & txtHoraFin.Text

        Dim consulta As String = ""
        consulta = "SELECT id_captura FROM capturas WHERE matricula = '" & Matricula & "' AND id_curso = " & id_curso & " AND fecha_hora >= #" & F1 & "# AND fecha_hora <= #" & F2 & "#"

        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)

        If DTVisualizar.Rows.Count <= 0 Then
            InsertarRegistro(Matricula, Precargar_Faltas_Con)
        Else
            InsertarRegistro(Matricula, "A")
        End If
    End Sub
    ''' 

    Sub Proceso_Insertar()

        Configurar_Precarga_Datos()
        Configurar_Precarga_Faltas()

        Dim curso As Long = cboCursos.SelectedValue
        Dim consulta As String = "SELECT matricula FROM curso_alumno AS c WHERE id_curso =" & curso
        Dim DtVisualizar As DataTable = Nothing
        DtVisualizar = consultar(consulta).Tables(0)
        If DtVisualizar.Rows.Count <= 0 Then
            gvDatos.DataSource = Nothing
        Else

            For Each row As DataRow In DtVisualizar.Rows
                Dim Matricula As String = ""
                Matricula = CStr(row("matricula"))

                If Precargar_Con = "Proceso" Then
                    Busca_Captura(Matricula)
                Else
                    InsertarRegistro(Matricula, Precargar_Con)
                End If
            Next


            'With gvDatos
            '    .DataSource = DtVisualizar
            '    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            '    .Refresh()
            'End With


        End If
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CargarLista()
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

    End Sub

    Private Sub cboHorarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHorarios.SelectedIndexChanged
        If Hoarios_Cargados = True And cboHorarios.Text <> "" Then
            Define_Horarios()
        End If
    End Sub

    Sub Configurar_Precarga_Datos()
        Precargar_Con = "Proceso"
        If rbA1.Checked = True Then
            Precargar_Con = "A"
        End If
        If rbF1.Checked = True Then
            Precargar_Con = "F"
        End If
        If rbNA1.Checked = True Then
            Precargar_Con = "NA"
        End If

    End Sub

    Sub Configurar_Precarga_Faltas()
        Precargar_Faltas_Con = "F"
        If rbA2.Checked = True Then
            Precargar_Faltas_Con = "A"
        End If
        If rbJ2.Checked = True Then
            Precargar_Faltas_Con = "J"
        End If
        If rbNA2.Checked = True Then
            Precargar_Faltas_Con = "NA"
        End If

    End Sub

    Sub InsertarRegistro(ByVal Matricula As String, ByVal Valor As String)

        Dim id_curso As Long = Val(cboCursos.SelectedValue)
        Dim id_horario As Long = Val(cboHorarios.SelectedValue)
        Dim Campos As String = ""
        Dim Valores As String = ""

        Campos = "fecha, id_curso, matricula, registro, id_horario"
        Valores = "#" & Fech & "#, " & id_curso & ", '" & Matricula & "', '" & Valor & "', '" & id_horario & "'"

        Dim insertar As String = "INSERT INTO control_ausentismoS(" & Campos & ") VALUES (" & Valores & ")"
        Cambios(insertar)
    End Sub

    Private Sub gvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvDatos.CellContentClick

    End Sub

    Private Sub txtHoraInicio_TextChanged(sender As Object, e As EventArgs) Handles txtHoraInicio.TextChanged

    End Sub

    Private Sub txtPeriodo_TextChanged(sender As Object, e As EventArgs) Handles txtPeriodo.TextChanged

    End Sub
End Class