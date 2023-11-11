Public Class frm_alterar_senha
    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        If checar_senha(txt_senha.Text) Then
            If txt_nova_senha.Text = txt_confirmar_senha.Text Then
                alterar_senha(txt_nova_senha.Text)
                MsgBox("Senha alterada com sucesso!")
                limpar_campos_alterar_senha()
            Else
                MsgBox("As novas senhas não batem!")
                limpar_campos_alterar_senha()
            End If
        Else
            MsgBox("A senha atual está incorreta.")
            limpar_campos_alterar_senha()
        End If
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu_funcionario.Show()
    End Sub
End Class