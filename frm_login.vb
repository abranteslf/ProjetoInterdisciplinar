Imports System.Data.SQLite
Imports System.Drawing.Text

Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar_campos_login()
        'isso não funciona
        'tirar dúvida com o professor sobre fechar ou esconder os formulários
    End Sub
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim cpf = txt_cpf.Text
        Dim senha = txt_senha.Text
        logar(cpf, senha)
    End Sub

End Class