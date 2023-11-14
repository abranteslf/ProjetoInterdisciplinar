Imports System.Data.SQLite
Imports System.Drawing.Text

Public Class frm_login
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim cpf = txt_cpf.Text
        Dim senha = txt_senha.Text
        logar(cpf, senha)
        limpar_campos_login()
    End Sub

End Class