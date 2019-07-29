Imports System.Net
Public Class Catalogo



    Public Shared Function ValidaIP(ByVal direccionIP As String) As IPAddress
        Dim ip As IPAddress = New IPAddress(New Byte() {0, 0, 0, 0})
        IPAddress.TryParse(direccionIP, ip)
        Return ip
    End Function
    'Public Function dameIP() As String

    '    Dim ip As Net.Dns
    '    Dim nombrePC As String
    '    Dim entradasIP As Net.IPHostEntry

    '    nombrePC = Dns.GetHostName

    '    entradasIP = Dns.GetHostByName(nombrePC)

    '    Dim direccion_Ip As String = entradasIP.AddressList(0).ToString
    '    MessageBox.Show(direccion_Ip)

    '    Return direccion_Ip

    'End Function
    Dim Periodo As String = ""
    Sub Insertar_CapturaEquipos()
        Try
            'Se agrego estos campos para agregar a los equipos que se van a estar vinculando con el sistema
            '

            Dim estado As Integer = "1"
            Dim ID As String = ""
            Dim equipo As String = txtEquipos.Text '.ToString()
            Dim IP As String = mskIP.Text
            Dim categoria As String = cboCategorias.Text
            Dim Fecha_Hora As String = Fecha_Hora_a_String(Now)
            'Esto nos servira para realziar la consulta mas facil en cuenstion de organizacion
            Dim Campos As String = ""
            Dim Valores As String = ""
            If equipo.Length > 0 And IP.Length >= 11 Then
                Campos = "nombre_equipo,IP,categoria,estatus"
                Valores = "'" & equipo & "', '" & IP & "', '" & categoria & "', '" & estado & "'"
                'Los datos que se van a insertar 
                Dim Insertar As String = "INSERT INTO c_computos (" & Campos & ") VALUES(" & Valores & ")"
                Cambios(Insertar)
                'MessageBox.Show(equipo)
                Cargar_Datos()

                txtEquipos.Clear()
                txtEquipos.Focus()

            Else
                MessageBox.Show("Error", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Cargar_categorias()
        Dim consulta As String
        consulta = "SELECT *
                    FROM c_categorias"

        Dim DTVisualizar As DataTable = Nothing
        DTVisualizar = consultar(consulta).Tables(0)

        If DTVisualizar.Rows.Count > 0 Then
            With Me.cboCategorias
                .DataSource = DTVisualizar
                .DisplayMember = "nombre_categoria"
                .ValueMember = "id_categoria"
            End With

        End If

    End Sub
    Sub Cargar_Datos()
        With dgvCaptura
            .DataSource = Nothing
            .DataMember = Nothing
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
            .DefaultCellStyle.BackColor = Color.White
        End With
        Dim curso As Long = cboCategorias.SelectedValue
        Dim consulta As String = ""
        consulta = "SELECT * FROM c_computos"
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



    Private Sub lblCurso_Click(sender As Object, e As EventArgs) Handles lblCurso.Click

    End Sub

    Private Sub lblHorario_Click(sender As Object, e As EventArgs) Handles lblHorario.Click

    End Sub

    Private Sub cboHorarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategorias.SelectedIndexChanged

    End Sub

    Private Sub cboCursos_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_categorias()
        Cargar_Datos()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Cargar_categorias()

        Insertar_CapturaEquipos()
    End Sub

    Private Sub dgvCaptura_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCaptura.CellContentClick

    End Sub

    Private Sub txtIP_Validated(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIP_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIP_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskIP.MaskInputRejected

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class