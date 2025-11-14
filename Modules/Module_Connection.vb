Imports System.Data.SqlClient
Imports System.IO

Module Module_Connection

    Public Conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader

    'Public StrConn As String = "data source=192.168.0.248;database=EDCOP_PROD_NEW;uid=sa;pwd=3dcoP2024"
    'Public StrConn As String = "data source=192.168.0.249;database=EDCOP_DEV;uid=sa;pwd=3dcoP032022"
    'Public StrConn As String = "data source=192.168.0.249;database=EDCOP_PROD;uid=sa;pwd=3dcoP032022"

    'Dim filePath As String = "\\192.168.0.250\references\DIMS_APPS_INST\ServerIPAdress.txt"
    'Dim lines() As String = File.ReadAllLines(filePath)

    '' Assign each line to a variable (add safety checks)
    'Public ServerIP As String = If(lines.Length > 0, lines(0).Trim(), "")
    'Public DatabaseName As String = If(lines.Length > 1, lines(1).Trim(), "")
    'Public DBUser As String = If(lines.Length > 2, lines(2).Trim(), "")
    'Public DBPass As String = If(lines.Length > 3, lines(3).Trim(), "")


    ''Public StrConn As String = "data source=10.10.18.61;database=EDCOP_PROD_NEW;uid=sa;pwd=3dcoP2024"
    'Public StrConn As String = "Data source=" & ServerIP & ";database=" & DatabaseName & ";uid=" & DBUser & ";pwd=" & DBPass

    Public ServerIP As String
    Public DatabaseName As String
    Public DBUser As String
    Public DBPass As String
    Public StrConn As String

    Public Sub LoadDBSettings()

        Try
            Dim filePath As String = "\\192.168.0.250\references\DIMS_APPS_INST\EAS2_ServerIPAdress.txt"

            ' Read all lines from the config file
            Dim lines() As String = File.ReadAllLines(filePath)

            ServerIP = If(lines.Length > 0, lines(0).Trim(), "")
            DatabaseName = If(lines.Length > 1, lines(1).Trim(), "")
            DBUser = If(lines.Length > 2, lines(2).Trim(), "")
            DBPass = If(lines.Length > 3, lines(3).Trim(), "")

            ' connection string
            StrConn = $"Data Source={ServerIP};Database={DatabaseName};User ID={DBUser};Password={DBPass}"

        Catch ex As Exception
            MessageBox.Show($"Unable to load database configuration: {ex.Message}",
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Module
