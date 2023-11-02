Public Class frm_cadastro_funcionarios
    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Try
            SQL = "select * from tb_usuarios where usuario='" & txt_usuario.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then
                SQL = "insert into tb_usuarios(usuario, senha, admin) values ('" & txt_usuario.Text & "' , '" & txt_senha.Text & "' , '" & cmb_acesso.Text & "')"
                rs = db.Execute(SQL)
                MsgBox("Usuario cadastrado com sucesso!")
                limpar_campos_cadastro()
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!")
        End Try
    End Sub

    Private Sub cadastro_funcionarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
    End Sub

    Private Sub txt_usuario_LostFocus(sender As Object, e As EventArgs) Handles txt_usuario.LostFocus
        Try
            SQL = "select * from tb_usuarios where usuario='" & txt_usuario.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                txt_usuario.Text = rs.Fields(1).ToString
                txt_senha.Text = rs.Fields(2).ToString
            End If
        Catch ex As Exception
            MsgBox("tmj")
        End Try
    End Sub
End Class