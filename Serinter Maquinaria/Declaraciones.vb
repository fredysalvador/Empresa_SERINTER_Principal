Imports System.Data.SqlClient
Imports System.Data
Module Declaraciones

    Public vusuario As String
    Public vnivel As String
    Public Conexion, Conexion2 As SqlConnection
    Public Comando, Comando2 As SqlCommand
    Public adaptar, adaptar2 As SqlDataAdapter
    Public almacen As DataSet
    Public resultado As Integer
    'Public cadena As String = "Data Source=DESKTOP-OTGBSC3;Initial Catalog=SERINTER;User id=sa;Password=08132"
    Public cadena As String = "Data Source=192.168.10.200;Initial Catalog=SERINTER;User id=sa;Password=$3rint3rsrvr"
    Public sql, sql2 As String
    Public registro As DataRow
    Public vfecha As DateTime
    Public vclave, vconfirmar As String
    Public vnombre As String
    Public vrol As String
    Public vobs As String

End Module
