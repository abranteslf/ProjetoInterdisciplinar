Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim usuario As String = txt_usuario.Text
        Dim senha As String = txt_senha.Text

        Try
            SQL = "SELECT * FROM tb_usuarios WHERE usuario='" & usuario & "' AND senha='" & senha & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                MessageBox.Show("Logado com sucesso!")
                limpar_campos_login()
                frm_cadastro_funcionarios.Show() 'Chamada de Formulário
            Else
                MessageBox.Show("Dados incorretos!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao consultar dados!")
            End
        End Try
    End Sub
End Class
