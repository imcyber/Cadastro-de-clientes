Imports System.Data.SqlClient
Imports DBOCadastro

Public Class frmConsultaCliente

    Public Property ID As Integer

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click

        Dim cliente As New TB_ztestebruno
        Dim ds As DataSet
        Dim par As New List(Of SqlParameter)

        Try
            If txtNome.TextLength > 0 Then
                par.Add(New SqlParameter("@NOME", txtNome.Text))
                ds = cliente.ConsultaDataset("SELECT * FROM TB_ztestebruno WHERE NOME LIKE '%' + @NOME + '%' ", par)
            Else
                ds = cliente.ConsultaDataset("SELECT * FROM TB_ztestebruno", par)
            End If

            gridconsulta.AutoGenerateColumns = False
            gridconsulta.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Erro na pesquisa")
        End Try

    End Sub

    Private Sub gridconsulta_DoubleClick(sender As Object, e As EventArgs) Handles gridconsulta.DoubleClick

        If gridconsulta.Rows.Count > 0 Then
            ID = gridconsulta.CurrentRow.Cells("colid").Value
            Me.Close()
        End If

    End Sub

    Private Sub gridconsulta_KeyDown(sender As Object, e As KeyEventArgs) Handles gridconsulta.KeyDown

        If gridconsulta.Rows.Count > 0 And e.KeyCode = Keys.Enter Then
            ID = gridconsulta.CurrentRow.Cells("colid").Value
            Me.Close()
        End If

    End Sub
End Class