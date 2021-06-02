Imports System.Data.SqlClient

Public Class TB_ztestebruno
#Region "Propiedades"

    Public Property ID As Integer

    Public Property NOME As String

    Public Property ENDERECO As String

    Public Property NUMERO As String

    Public Property TELEFONE As String

#End Region
    Private comando As SqlCommand

#Region "Funções"

    Public Function NovoCliente(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As Boolean

        Dim retorno As Boolean = True
        Dim banco As New DataAccess

        Try
            retorno = banco.ExecuteQuery(SQL, parametros)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return retorno

    End Function

    Public Function AtualizaCliente(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As Boolean

        Dim retorno As Boolean = True
        Dim banco As New DataAccess

        Try
            retorno = banco.ExecuteQuery(SQL, parametros)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return retorno

    End Function

    Public Function DeleteCliente(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As Boolean

        Dim retorno As Boolean = True
        Dim banco As New DataAccess

        Try
            retorno = banco.ExecuteQuery(SQL, parametros)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return retorno

    End Function

    Public Function ConsultaDataset(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As DataSet
        Dim ds As DataSet
        Dim banco As New DataAccess

        Try
            ds = banco.ExecuteDataSet(SQL, parametros)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return ds
    End Function

    Public Function ConsultaDataReader(ByVal SQL As String, ByVal parametros As List(Of SqlParameter)) As Boolean

        Dim dr As IDataReader
        Dim banco As New DataAccess
        Dim retorno As Boolean = False

        Try
            dr = banco.ExecuteDataReader(SQL, parametros)

            While dr.Read
                If Not IsDBNull(dr("nome")) Then NOME = dr("nome")
                If Not IsDBNull(dr("endereco")) Then ENDERECO = dr("endereco")
                If Not IsDBNull(dr("numero")) Then NUMERO = dr("numero")
                If Not IsDBNull(dr("telefone")) Then TELEFONE = dr("telefone")
                retorno = True
            End While

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            banco.CloseConn()
        End Try

        Return retorno

    End Function
    '   Public Function RetornaDadosTabela(ByVal SQL As String) As DataTable
    '  Dim banco As New DataAccess
    ' Dim dt As New DataTable
    '    Try
    '           dt = banco.ExecutaSelect(SQL)
    '  Catch ex As Exception
    '
    '   MsgBox(ex.Message)
    'End Try
    ' Return dt
    ' End Function
#End Region
End Class
