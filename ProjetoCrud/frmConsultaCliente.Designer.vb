<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCliente
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
        Me.gpbfiltrar = New System.Windows.Forms.GroupBox()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.gridconsulta = New System.Windows.Forms.DataGridView()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbfiltrar.SuspendLayout()
        CType(Me.gridconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbfiltrar
        '
        Me.gpbfiltrar.Controls.Add(Me.btnPesquisa)
        Me.gpbfiltrar.Controls.Add(Me.Label1)
        Me.gpbfiltrar.Controls.Add(Me.txtNome)
        Me.gpbfiltrar.Location = New System.Drawing.Point(0, 0)
        Me.gpbfiltrar.Name = "gpbfiltrar"
        Me.gpbfiltrar.Size = New System.Drawing.Size(788, 80)
        Me.gpbfiltrar.TabIndex = 0
        Me.gpbfiltrar.TabStop = False
        Me.gpbfiltrar.Text = "Filtrar por"
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Font = New System.Drawing.Font("Arial", 9.267326!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisa.Location = New System.Drawing.Point(656, 35)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(82, 21)
        Me.btnPesquisa.TabIndex = 2
        Me.btnPesquisa.Text = "Pesquisar"
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(62, 35)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(579, 20)
        Me.txtNome.TabIndex = 0
        '
        'gridconsulta
        '
        Me.gridconsulta.AllowUserToAddRows = False
        Me.gridconsulta.AllowUserToDeleteRows = False
        Me.gridconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridconsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colid, Me.colnome})
        Me.gridconsulta.Location = New System.Drawing.Point(0, 86)
        Me.gridconsulta.Name = "gridconsulta"
        Me.gridconsulta.ReadOnly = True
        Me.gridconsulta.Size = New System.Drawing.Size(788, 352)
        Me.gridconsulta.TabIndex = 1
        '
        'colid
        '
        Me.colid.DataPropertyName = "ID"
        Me.colid.HeaderText = "ID"
        Me.colid.Name = "colid"
        Me.colid.ReadOnly = True
        Me.colid.Width = 44
        '
        'colnome
        '
        Me.colnome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colnome.DataPropertyName = "NOME"
        Me.colnome.HeaderText = "NOME"
        Me.colnome.Name = "colnome"
        Me.colnome.ReadOnly = True
        '
        'frmConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gridconsulta)
        Me.Controls.Add(Me.gpbfiltrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisar Clientes"
        Me.gpbfiltrar.ResumeLayout(False)
        Me.gpbfiltrar.PerformLayout()
        CType(Me.gridconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbfiltrar As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents gridconsulta As DataGridView
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents colid As DataGridViewTextBoxColumn
    Friend WithEvents colnome As DataGridViewTextBoxColumn
End Class
