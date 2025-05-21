Imports System.Data.SqlClient
Module Module_Connection

    Public Conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader

    Public StrConn As String = "data source=192.168.0.248;database=EDCOP_PROD_NEW;uid=sa;pwd=3dcoP2024"
    ' Public StrConn As String = "data source=192.168.0.249;database=EDCOP_DEV;uid=sa;pwd=3dcoP032022"
    'Public StrConn As String = "data source=192.168.0.249;database=EDCOP_PROD;uid=sa;pwd=3dcoP032022"

End Module
