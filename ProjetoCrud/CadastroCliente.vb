Imports System.Data.SqlClient
Imports DBOCadastro

Public Class CadastroCliente

    Enum Opcao As Integer

        Cancelar = 0
        Incluir = 1
        Editar = 2
        Consultar = 3

    End Enum

    Private IntOpcao As Opcao

    Private Sub AtivaDesativa(ByVal Enabled As Boolean)

        txtNome.Enabled = Enabled
        txtEndereco.Enabled = Enabled
        txtNumero.Enabled = Enabled
        txtTelefone.Enabled = Enabled

    End Sub

    Private Sub pesq()

        Using frm As New frmConsultaCliente
            frm.ShowDialog(Me)

            If frm.ID > 0 Then

                Dim enter As New KeyEventArgs(Keys.Enter)
                txtId.Text = frm.ID
                txtId_KeyDown(Nothing, enter)

            End If

        End Using
    End Sub


    Private Sub tsbInserir_Click(sender As Object, e As EventArgs) Handles tsbInserir.Click

        IntOpcao = Opcao.Incluir
        AtivaDesativa(True)

        tsbInserir.Enabled = False
        tsbEditar.Enabled = False
        tsbPesquisar.Enabled = False
        tsbSalvar.Enabled = True
        tsbCancelar.Enabled = True

        txtNome.Focus()

    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click

        IntOpcao = Opcao.Editar
        txtId.Focus()

        txtId.Enabled = True
        tsbInserir.Enabled = False
        tsbEditar.Enabled = False
        tsbPesquisar.Enabled = False
        tsbCancelar.Enabled = True

    End Sub

    Private Sub tsbPesquisar_Click(sender As Object, e As EventArgs) Handles tsbPesquisar.Click
        Dim par As New List(Of SqlParameter)
        IntOpcao = Opcao.Consultar

        txtId.Focus()
        txtId.Enabled = True
        tsbInserir.Enabled = False
        tsbEditar.Enabled = True
        tsbPesquisar.Enabled = True
        tsbCancelar.Enabled = True

    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click

        IntOpcao = Opcao.Cancelar
        AtivaDesativa(False)
        txtId.Enabled = False

        txtNome.Clear()
        txtEndereco.Clear()
        txtNumero.Clear()
        txtTelefone.Clear()

        tsbInserir.Enabled = True
        tsbEditar.Enabled = True
        tsbPesquisar.Enabled = True
        tsbSalvar.Enabled = False
        tsbDeletar.Enabled = False
        tsbCancelar.Enabled = False

    End Sub

    Private Sub tsbSalvar_Click(sender As Object, e As EventArgs) Handles tsbSalvar.Click

        Dim cliente As New TB_ztestebruno
        Dim par As New List(Of SqlParameter)
        Dim SQL As String
        Dim blnEndereco As Boolean = False
        Dim blnNumero As Boolean = False
        Dim blnTelefone As Boolean = False

        Try

            Select Case IntOpcao

                Case Opcao.Incluir
                    SQL = "INSERT INTO TB_ztestebruno ("

                    If txtNome.TextLength = 0 Then
                        nomevalida.SetError(txtNome, "Nome do cliente é obrigatório")
                        txtNome.Focus()
                        Exit Sub
                    Else

                        par.Add(New SqlParameter("@NOME", txtNome.Text))
                        SQL = SQL & "NOME"
                        nomevalida.SetError(txtNome, "")
                    End If

                    If txtEndereco.TextLength > 0 Then
                        par.Add(New SqlParameter("@ENDERECO", txtEndereco.Text))
                        SQL = SQL & ", ENDERECO"
                        blnEndereco = True
                    End If


                    If txtNumero.TextLength > 0 Then
                        par.Add(New SqlParameter("@NUMERO", txtNumero.Text))
                        SQL = SQL & ", NUMERO"
                        blnNumero = True
                    End If


                    If txtTelefone.TextLength > 0 Then
                        par.Add(New SqlParameter("@TELEFONE", txtTelefone.Text))
                        SQL = SQL & ", TELEFONE"
                        blnTelefone = True
                    End If


                    SQL = SQL & ") VALUES (@NOME"

                    If blnEndereco = True Then
                        SQL = SQL & ", @ENDERECO"
                    End If


                    If blnNumero = True Then
                        SQL = SQL & ", @NUMERO"
                    End If


                    If blnTelefone = True Then
                        SQL = SQL & ", @TELEFONE"
                    End If

                    SQL = SQL & ")"

                    If cliente.NovoCliente(SQL, par) Then
                        MessageBox.Show("Cliente adicionado!")
                        tsbCancelar_Click(Nothing, Nothing)
                    Else
                        MessageBox.Show("Erro ao adicionar cliente!")
                    End If

                Case Opcao.Editar

                    SQL = "UPDATE TB_ztestebruno SET "
                    par.Add(New SqlParameter("@ID", txtId.Text))

                    If txtNome.TextLength = 0 Then
                        nomevalida.SetError(txtNome, "Nome do cliente é obrigatório")
                        txtNome.Focus()
                        Exit Sub
                    Else

                        par.Add(New SqlParameter("@NOME", txtNome.Text))
                        SQL = SQL & "NOME = @NOME"
                        nomevalida.SetError(txtNome, "")
                    End If

                    If txtEndereco.TextLength > 0 Then
                        par.Add(New SqlParameter("@ENDERECO", txtEndereco.Text))
                        SQL = SQL & ", ENDERECO = @ENDERECO"
                        blnEndereco = True
                    End If


                    If txtNumero.TextLength > 0 Then
                        par.Add(New SqlParameter("@NUMERO", txtNumero.Text))
                        SQL = SQL & ", NUMERO = @NUMERO"
                        blnNumero = True
                    End If

                    If txtTelefone.TextLength > 0 Then
                        par.Add(New SqlParameter("@TELEFONE", txtTelefone.Text))
                        SQL = SQL & ", TELEFONE = @TELEFONE"
                        blnTelefone = True
                    End If


                    SQL = SQL & " WHERE ID = @ID"

                    If cliente.AtualizaCliente(SQL, par) Then
                        MessageBox.Show("Cliente atualizado!")
                        tsbCancelar_Click(Nothing, Nothing)
                    Else
                        MessageBox.Show("Erro ao atualizar cliente!")
                    End If

            End Select

        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown

        If txtId.TextLength > 0 And e.KeyCode = Keys.Enter Then
            Dim cliente As New TB_ztestebruno
            Dim par As New List(Of SqlParameter)
            par.Add(New SqlParameter("@ID", txtId.Text))

            If cliente.ConsultaDataReader("SELECT * FROM TB_ztestebruno WHERE ID = @ID", par) = True Then

                txtNome.Text = cliente.NOME
                txtEndereco.Text = cliente.ENDERECO
                txtNumero.Text = cliente.NUMERO
                txtTelefone.Text = cliente.TELEFONE

                If IntOpcao = Opcao.Editar Then
                    txtId.Enabled = False
                    AtivaDesativa(True)
                    tsbSalvar.Enabled = True
                    tsbDeletar.Enabled = True
                End If

            Else
                MsgBox("Código do cliente não encontrado")
            End If

        ElseIf txtid.TextLength = 0 And e.KeyCode = Keys.Enter Then
            pesq()
        End If

    End Sub

    Private Sub tsbDeletar_Click(sender As Object, e As EventArgs) Handles tsbDeletar.Click

        Dim cliente As New TB_ztestebruno
        Dim par As New List(Of SqlParameter)

        Try

            par.Add(New SqlParameter("@ID", txtId.Text))
            If MessageBox.Show("Certeza que deseja remover este cliente?", "ATENÇÃO", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                If cliente.DeleteCliente("DELETE TB_ztestebruno WHERE ID = @ID", par) = True Then
                    txtNome.Clear()
                    txtEndereco.Clear()
                    txtNumero.Clear()
                    txtTelefone.Clear()
                    MessageBox.Show("Cliente removido com sucesso!")

                Else
                    MessageBox.Show("Erro ao remover cliente!")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao tentar remover cliente!")
        End Try

    End Sub
End Class