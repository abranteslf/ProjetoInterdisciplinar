Public Class frm_cadastro_funcionarios
    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Dim cpf, nome, senha, acesso As String
        cpf = txt_cpf.Text
        nome = txt_nome.Text
        senha = txt_senha.Text
        acesso = cmb_acesso.Text
        cadastrar(cpf, nome, senha, acesso)
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Dim cpf As String
        cpf = txt_cpf.Text
        procurar_usuario(cpf)
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Dim cpf As String
        cpf = txt_cpf.Text
        excluir_cadastro(cpf)
    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click
        Dim novoCpf, cpf, nome, senha, acesso As String
        novoCpf = txt_novocpf.Text
        cpf = txt_cpf.Text
        nome = txt_nome.Text
        senha = txt_senha.Text
        acesso = cmb_acesso.Text
        atualizar_cadastro(novoCpf, cpf, nome, senha, acesso)
    End Sub
End Class