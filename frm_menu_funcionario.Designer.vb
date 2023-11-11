<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_funcionario
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
        Me.btn_agenda = New System.Windows.Forms.Button()
        Me.btn_alterar_senha = New System.Windows.Forms.Button()
        Me.Sair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_agenda
        '
        Me.btn_agenda.Location = New System.Drawing.Point(237, 51)
        Me.btn_agenda.Name = "btn_agenda"
        Me.btn_agenda.Size = New System.Drawing.Size(120, 41)
        Me.btn_agenda.TabIndex = 0
        Me.btn_agenda.Text = "Agenda"
        Me.btn_agenda.UseVisualStyleBackColor = True
        '
        'btn_alterar_senha
        '
        Me.btn_alterar_senha.Location = New System.Drawing.Point(237, 123)
        Me.btn_alterar_senha.Name = "btn_alterar_senha"
        Me.btn_alterar_senha.Size = New System.Drawing.Size(120, 41)
        Me.btn_alterar_senha.TabIndex = 1
        Me.btn_alterar_senha.Text = "Alterar Senha"
        Me.btn_alterar_senha.UseVisualStyleBackColor = True
        '
        'Sair
        '
        Me.Sair.Location = New System.Drawing.Point(237, 195)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(120, 41)
        Me.Sair.TabIndex = 2
        Me.Sair.Text = "Sair"
        Me.Sair.UseVisualStyleBackColor = True
        '
        'frm_menu_funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Sair)
        Me.Controls.Add(Me.btn_alterar_senha)
        Me.Controls.Add(Me.btn_agenda)
        Me.Name = "frm_menu_funcionario"
        Me.Text = "frm_menu_funcionario"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_agenda As Button
    Friend WithEvents btn_alterar_senha As Button
    Friend WithEvents Sair As Button
End Class
