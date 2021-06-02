Imports System.Data.SqlClient

Public Class DataAccess

    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader

    Public Sub New()
        conexao = New SqlConnection("Server = 192.168.1.176;Database=dbFeedTeste;User Id=sa;Password=Feed333")
    End Sub

    Public Sub CloseConn()
        If IsNothing(conexao) Then
            If conexao.State = ConnectionState.Open Then
                conexao.Close()
            End If
        End If
    End Sub

    Public Function ExecuteQuery(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As Boolean

        Dim retorno As Boolean = True

        Try
            comando = New SqlCommand(SQL, conexao)

            For Each P As SqlParameter In parametros
                comando.Parameters.Add(P)
            Next

            conexao.Open()
            retorno = comando.ExecuteNonQuery()

        Catch ex As Exception
            retorno = False
            Throw New Exception(ex.Message)
        Finally
            comando = Nothing
        End Try

        Return retorno
    End Function

    Public Function ExecuteDataSet(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As DataSet

        Dim ds As New DataSet

        Try

            comando = New SqlCommand(SQL, conexao)

            For Each P As SqlParameter In parametros
                comando.Parameters.Add(P)
            Next
            conexao.Open()

            da = New SqlDataAdapter(comando)
            da.Fill(ds)

        Catch ex As Exception
            Throw New Exception("Problema no banco de dados")
        Finally
            comando = Nothing
        End Try
        Return ds
    End Function

    Public Function ExecuteDataReader(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As IDataReader

        Try
            comando = New SqlCommand(SQL, conexao)

            For Each P As SqlParameter In parametros
                comando.Parameters.Add(P)
            Next
            conexao.Open()


            dr = comando.ExecuteReader

        Catch ex As Exception
            Throw New Exception("Problema no banco de dados")
        Finally
            comando = Nothing
        End Try
        Return dr
    End Function

    '   Public Function ExecutaSelect(ByVal SQL As String) As DataTable
    '  Dim dt As New DataTable
    ' Dim timeOut As Integer = 900000
    '
    'Try
    '
    '   comando = New SqlCommand(SQL, conexao)
    '  conexao.Open()
    '
    'Dim carrega As New SqlDataAdapter(SQL, conexao)
    '       carrega.SelectCommand.CommandTimeout = timeOut
    '      carrega.Fill(dt)
    '
    'Catch ex As Exception
    '        MsgBox("Erro!", MsgBoxStyle.Critical)
    'End Try
    'Return dt
    'End Function


End Class