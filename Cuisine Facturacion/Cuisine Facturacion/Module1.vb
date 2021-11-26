Imports System.Data.Odbc
Module Modulo1
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public rs1 As OdbcDataReader
    Public rs2 As OdbcDataReader

    Public adp As OdbcDataAdapter
    Public sql As String
    Public x As Integer
    Public Function conectar()
        Try
            cnn = New OdbcConnection("dsn=cuisine")

            cnn.Open()

            MsgBox("Se ha conectado con éxito", , "Resultado de la conexión")

        Catch ex As Exception

            MsgBox(ex.Message & vbCrLf & "Falla de la conexión con la Base de Datos", , "Sin conexión")

        End Try

        Return 0

    End Function

    Public Sub Proc(ByVal sql As String)

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        If x = 0 Then
            rs = cmd.ExecuteReader()
            x = 1

        Else

            rs1 = cmd.ExecuteReader()

        End If

        cmd.Dispose()

    End Sub
    Public Sub procGrid(ByVal sql As String)
        adp = New OdbcDataAdapter(sql, cnn)
    End Sub

    Public Sub Proc1(ByVal sql As String)

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs2 = cmd.ExecuteReader()
        cmd.Dispose()

    End Sub

End Module
