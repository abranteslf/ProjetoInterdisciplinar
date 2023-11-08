<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_funcionarios
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.cmb_acesso = New System.Windows.Forms.ComboBox()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.txt_novocpf = New System.Windows.Forms.TextBox()
        Me.lbl_novocpf = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(152, 183)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(157, 20)
        Me.txt_senha.TabIndex = 3
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(152, 101)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(157, 20)
        Me.txt_cpf.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CPF:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 190)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Senha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 235)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Acesso:"
        '
        'btn_cadastro
        '
        Me.btn_cadastro.Location = New System.Drawing.Point(152, 275)
        Me.btn_cadastro.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(104, 28)
        Me.btn_cadastro.TabIndex = 5
        Me.btn_cadastro.Text = "CADASTRAR"
        Me.btn_cadastro.UseVisualStyleBackColor = True
        '
        'cmb_acesso
        '
        Me.cmb_acesso.FormattingEnabled = True
        Me.cmb_acesso.Items.AddRange(New Object() {"admin", "usuario"})
        Me.cmb_acesso.Location = New System.Drawing.Point(152, 227)
        Me.cmb_acesso.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_acesso.Name = "cmb_acesso"
        Me.cmb_acesso.Size = New System.Drawing.Size(157, 21)
        Me.cmb_acesso.TabIndex = 4
        '
        'btn_excluir
        '
        Me.btn_excluir.Enabled = False
        Me.btn_excluir.Location = New System.Drawing.Point(260, 275)
        Me.btn_excluir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(104, 28)
        Me.btn_excluir.TabIndex = 6
        Me.btn_excluir.Text = "EXCLUIR"
        Me.btn_excluir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nome:"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(152, 142)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(157, 20)
        Me.txt_nome.TabIndex = 2
        '
        'btn_atualizar
        '
        Me.btn_atualizar.Enabled = False
        Me.btn_atualizar.Location = New System.Drawing.Point(152, 308)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(104, 28)
        Me.btn_atualizar.TabIndex = 7
        Me.btn_atualizar.Text = "ATUALIZAR"
        Me.btn_atualizar.UseVisualStyleBackColor = True
        '
        'txt_novocpf
        '
        Me.txt_novocpf.Location = New System.Drawing.Point(395, 101)
        Me.txt_novocpf.Name = "txt_novocpf"
        Me.txt_novocpf.Size = New System.Drawing.Size(157, 20)
        Me.txt_novocpf.TabIndex = 1
        Me.txt_novocpf.Visible = False
        '
        'lbl_novocpf
        '
        Me.lbl_novocpf.AutoSize = True
        Me.lbl_novocpf.Location = New System.Drawing.Point(330, 108)
        Me.lbl_novocpf.Name = "lbl_novocpf"
        Me.lbl_novocpf.Size = New System.Drawing.Size(59, 13)
        Me.lbl_novocpf.TabIndex = 14
        Me.lbl_novocpf.Text = "Novo CPF:"
        Me.lbl_novocpf.Visible = False
        '
        'frm_cadastro_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 555)
        Me.Controls.Add(Me.lbl_novocpf)
        Me.Controls.Add(Me.txt_novocpf)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.cmb_acesso)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_senha)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_cadastro_funcionarios"
        Me.Text = "Gerenciamento de Usuários"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents cmb_acesso As ComboBox
    Friend WithEvents btn_excluir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents btn_atualizar As Button
    Friend WithEvents txt_novocpf As TextBox
    Friend WithEvents lbl_novocpf As Label
End Class
