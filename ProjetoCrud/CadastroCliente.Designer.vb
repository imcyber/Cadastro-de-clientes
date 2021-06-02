<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroCliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.gpCadastro = New System.Windows.Forms.GroupBox()
        Me.lbTelefone = New System.Windows.Forms.Label()
        Me.lbNumero = New System.Windows.Forms.Label()
        Me.LbEndereco = New System.Windows.Forms.Label()
        Me.lbNome = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lbId = New System.Windows.Forms.Label()
        Me.nomevalida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tsbInserir = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbPesquisar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalvar = New System.Windows.Forms.ToolStripButton()
        Me.tsbDeletar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.gpCadastro.SuspendLayout()
        CType(Me.nomevalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(17, 17)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbInserir, Me.tsbEditar, Me.tsbPesquisar, Me.tsbSalvar, Me.tsbDeletar, Me.tsbCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(571, 40)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'gpCadastro
        '
        Me.gpCadastro.Controls.Add(Me.lbTelefone)
        Me.gpCadastro.Controls.Add(Me.lbNumero)
        Me.gpCadastro.Controls.Add(Me.LbEndereco)
        Me.gpCadastro.Controls.Add(Me.lbNome)
        Me.gpCadastro.Controls.Add(Me.txtTelefone)
        Me.gpCadastro.Controls.Add(Me.txtNumero)
        Me.gpCadastro.Controls.Add(Me.txtEndereco)
        Me.gpCadastro.Controls.Add(Me.txtNome)
        Me.gpCadastro.Controls.Add(Me.txtId)
        Me.gpCadastro.Controls.Add(Me.lbId)
        Me.gpCadastro.Location = New System.Drawing.Point(22, 68)
        Me.gpCadastro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpCadastro.Name = "gpCadastro"
        Me.gpCadastro.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpCadastro.Size = New System.Drawing.Size(514, 215)
        Me.gpCadastro.TabIndex = 1
        Me.gpCadastro.TabStop = False
        '
        'lbTelefone
        '
        Me.lbTelefone.AutoSize = True
        Me.lbTelefone.Font = New System.Drawing.Font("Arial", 7.841584!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefone.Location = New System.Drawing.Point(14, 136)
        Me.lbTelefone.Name = "lbTelefone"
        Me.lbTelefone.Size = New System.Drawing.Size(57, 15)
        Me.lbTelefone.TabIndex = 9
        Me.lbTelefone.Text = "Telefone:"
        '
        'lbNumero
        '
        Me.lbNumero.AutoSize = True
        Me.lbNumero.Font = New System.Drawing.Font("Arial", 7.841584!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumero.Location = New System.Drawing.Point(17, 108)
        Me.lbNumero.Name = "lbNumero"
        Me.lbNumero.Size = New System.Drawing.Size(55, 15)
        Me.lbNumero.TabIndex = 8
        Me.lbNumero.Text = "Número:"
        '
        'LbEndereco
        '
        Me.LbEndereco.AutoSize = True
        Me.LbEndereco.Font = New System.Drawing.Font("Arial", 7.841584!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEndereco.Location = New System.Drawing.Point(9, 80)
        Me.LbEndereco.Name = "LbEndereco"
        Me.LbEndereco.Size = New System.Drawing.Size(63, 15)
        Me.LbEndereco.TabIndex = 7
        Me.LbEndereco.Text = "Endereço:"
        '
        'lbNome
        '
        Me.lbNome.AutoSize = True
        Me.lbNome.Font = New System.Drawing.Font("Arial", 7.841584!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNome.Location = New System.Drawing.Point(28, 52)
        Me.lbNome.Name = "lbNome"
        Me.lbNome.Size = New System.Drawing.Size(44, 15)
        Me.lbNome.TabIndex = 6
        Me.lbNome.Text = "Nome:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Location = New System.Drawing.Point(81, 131)
        Me.txtTelefone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(174, 20)
        Me.txtTelefone.TabIndex = 5
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(81, 103)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(174, 20)
        Me.txtNumero.TabIndex = 4
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(81, 75)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(405, 20)
        Me.txtEndereco.TabIndex = 3
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(81, 47)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(405, 20)
        Me.txtNome.TabIndex = 2
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(81, 19)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(136, 20)
        Me.txtId.TabIndex = 1
        '
        'lbId
        '
        Me.lbId.AutoSize = True
        Me.lbId.Font = New System.Drawing.Font("Arial", 7.841584!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbId.Location = New System.Drawing.Point(50, 24)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(22, 15)
        Me.lbId.TabIndex = 0
        Me.lbId.Text = "ID:"
        '
        'nomevalida
        '
        Me.nomevalida.ContainerControl = Me
        '
        'tsbInserir
        '
        Me.tsbInserir.Font = New System.Drawing.Font("Arial", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbInserir.Image = Global.ProjetoCrud.My.Resources.Resources.inserticon
        Me.tsbInserir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInserir.Name = "tsbInserir"
        Me.tsbInserir.Size = New System.Drawing.Size(51, 37)
        Me.tsbInserir.Text = "Inserir"
        Me.tsbInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbEditar
        '
        Me.tsbEditar.Font = New System.Drawing.Font("Arial", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbEditar.Image = Global.ProjetoCrud.My.Resources.Resources.editicon
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(49, 37)
        Me.tsbEditar.Text = "Editar"
        Me.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbPesquisar
        '
        Me.tsbPesquisar.Font = New System.Drawing.Font("Arial", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbPesquisar.Image = Global.ProjetoCrud.My.Resources.Resources.finIcon
        Me.tsbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPesquisar.Name = "tsbPesquisar"
        Me.tsbPesquisar.Size = New System.Drawing.Size(70, 37)
        Me.tsbPesquisar.Text = "Pesquisa"
        Me.tsbPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbSalvar
        '
        Me.tsbSalvar.Enabled = False
        Me.tsbSalvar.Font = New System.Drawing.Font("Arial", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbSalvar.Image = Global.ProjetoCrud.My.Resources.Resources.saveIcon
        Me.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalvar.Name = "tsbSalvar"
        Me.tsbSalvar.Size = New System.Drawing.Size(52, 37)
        Me.tsbSalvar.Text = "Salvar"
        Me.tsbSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbDeletar
        '
        Me.tsbDeletar.Enabled = False
        Me.tsbDeletar.Font = New System.Drawing.Font("Arial", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbDeletar.Image = Global.ProjetoCrud.My.Resources.Resources.deleteicon
        Me.tsbDeletar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeletar.Name = "tsbDeletar"
        Me.tsbDeletar.Size = New System.Drawing.Size(58, 37)
        Me.tsbDeletar.Text = "Deletar"
        Me.tsbDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Enabled = False
        Me.tsbCancelar.Font = New System.Drawing.Font("Arial", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbCancelar.Image = Global.ProjetoCrud.My.Resources.Resources.inserticon
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(69, 37)
        Me.tsbCancelar.Text = "Cancelar"
        Me.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CadastroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 329)
        Me.Controls.Add(Me.gpCadastro)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 7.841584!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CadastroCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gpCadastro.ResumeLayout(False)
        Me.gpCadastro.PerformLayout()
        CType(Me.nomevalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbInserir As ToolStripButton
    Friend WithEvents tsbEditar As ToolStripButton
    Friend WithEvents tsbPesquisar As ToolStripButton
    Friend WithEvents tsbSalvar As ToolStripButton
    Friend WithEvents tsbDeletar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents gpCadastro As GroupBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lbId As Label
    Friend WithEvents lbTelefone As Label
    Friend WithEvents lbNumero As Label
    Friend WithEvents LbEndereco As Label
    Friend WithEvents lbNome As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents nomevalida As ErrorProvider
End Class
