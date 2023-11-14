<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_gerente
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_gerenciar_contas = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_pesquisar = New System.Windows.Forms.TextBox()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.Excluir = New System.Windows.Forms.Button()
        Me.btn_alterar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(140, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 426)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(640, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cobrança"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_alterar)
        Me.TabPage2.Controls.Add(Me.Excluir)
        Me.TabPage2.Controls.Add(Me.btn_adicionar)
        Me.TabPage2.Controls.Add(Me.txt_pesquisar)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(640, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Agenda"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 112)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(12, 390)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(122, 44)
        Me.btn_sair.TabIndex = 2
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_gerenciar_contas
        '
        Me.btn_gerenciar_contas.Location = New System.Drawing.Point(12, 322)
        Me.btn_gerenciar_contas.Name = "btn_gerenciar_contas"
        Me.btn_gerenciar_contas.Size = New System.Drawing.Size(122, 44)
        Me.btn_gerenciar_contas.TabIndex = 3
        Me.btn_gerenciar_contas.Text = "Gerenciar Contas"
        Me.btn_gerenciar_contas.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(597, 259)
        Me.DataGridView1.TabIndex = 0
        '
        'txt_pesquisar
        '
        Me.txt_pesquisar.Location = New System.Drawing.Point(473, 14)
        Me.txt_pesquisar.Name = "txt_pesquisar"
        Me.txt_pesquisar.Size = New System.Drawing.Size(146, 20)
        Me.txt_pesquisar.TabIndex = 1
        '
        'btn_adicionar
        '
        Me.btn_adicionar.Location = New System.Drawing.Point(519, 321)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(100, 38)
        Me.btn_adicionar.TabIndex = 2
        Me.btn_adicionar.Text = "Adicionar"
        Me.btn_adicionar.UseVisualStyleBackColor = True
        '
        'Excluir
        '
        Me.Excluir.Location = New System.Drawing.Point(271, 321)
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Size = New System.Drawing.Size(100, 38)
        Me.Excluir.TabIndex = 3
        Me.Excluir.Text = "Excluir"
        Me.Excluir.UseVisualStyleBackColor = True
        '
        'btn_alterar
        '
        Me.btn_alterar.Location = New System.Drawing.Point(394, 321)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(100, 38)
        Me.btn_alterar.TabIndex = 4
        Me.btn_alterar.Text = "Alterar"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'frm_menu_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_gerenciar_contas)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_menu_gerente"
        Me.Text = "frm_menu_gerente"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_alterar As Button
    Friend WithEvents Excluir As Button
    Friend WithEvents btn_adicionar As Button
    Friend WithEvents txt_pesquisar As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_gerenciar_contas As Button
End Class
