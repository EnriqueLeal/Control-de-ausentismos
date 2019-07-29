Imports System.Data.OleDb
Imports System.Management
Imports System.Net

Imports System.Text
Imports System.Data
Imports System.Xml
Imports System.IO.Path

Module modulo


    Public usuario As Long '# DE USUSARIO de la sesion presente
    Public tipo As String = "" 'Es el tipo de ususario
    Public no_empleado As String = ""
    Public NombreLogeado As String = ""
    Public Nivel As String = ""
    Public Path As String = "C:\Users\Usuario\source\repos\Control_Ausentismos\Control_Ausentismos\BD\bd.mdb"
    Public String_de_coneccion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & Path & "; Persist Security Info=False;"
    Public cnx As New OleDbConnection(String_de_coneccion)

    Function Fecha_a_String(ByVal Fecha_Date As Date) As String
        Dim M_Fecha_String As String = ""
        M_Fecha_String = Fecha_Date.Year.ToString & "-" & Fecha_Date.Month.ToString & "-" & Fecha_Date.Day.ToString ' & " " & Format(Fecha_Date, "HH:mm:ss")
        Return M_Fecha_String
    End Function

    Function Fecha_Hora_a_String(ByVal Fecha_Date As Date) As String
        Dim M_Fecha_String As String = ""
        M_Fecha_String = Fecha_Date.Year.ToString & "-" & Fecha_Date.Month.ToString & "-" & Fecha_Date.Day.ToString & " " & Format(Fecha_Date, "HH:mm:ss")
        Return M_Fecha_String
    End Function

    Function VALIDAANUMEROS(ByVal txtval As String, ByVal car As Char) As Boolean
        Dim b As Integer
        For b = 1 To txtval.Length
            If Convert.ToChar(Mid(txtval, b, 1)) = car Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Sub pruebaConexion()
        Try
            cnx.Open()
            cnx.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            End
        End Try
    End Sub

    Public Function consultar(ByVal consulta As String) As DataSet
        Dim da As New OleDbDataAdapter(consulta, cnx)
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Public Sub Cambios(ByVal consulta As String)
        Dim cmd As New OleDbCommand
        cmd.Connection = modulo.cnx
        cmd.CommandText = consulta
        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()
    End Sub

End Module
