Imports System.Data.SqlClient
Imports DBOCadastro

Public Class Principal

    Private cadCliente As CadastroCliente = Nothing

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuCadastro_Click(sender As Object, e As EventArgs) Handles MenuCadastro.Click

    End Sub

    Private Sub tsbCadCliente_Click(sender As Object, e As EventArgs) Handles tsbCadCliente.Click
        MenuCliente_Click(Nothing, Nothing)
    End Sub

    Private Sub MenuCliente_Click(sender As Object, e As EventArgs) Handles MenuCliente.Click

        If cadCliente Is Nothing Then
            cadCliente = New CadastroCliente
            cadCliente.ShowDialog()
        Else
            If cadCliente.IsHandleCreated = True Then
                cadCliente.Focus()
            Else
                cadCliente = New CadastroCliente
                cadCliente.Show()
            End If
        End If
    End Sub
End Class
